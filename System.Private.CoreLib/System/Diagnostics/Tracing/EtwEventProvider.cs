using System;
using System.Collections.Generic;
using System.Globalization;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Internal.Win32;

namespace System.Diagnostics.Tracing
{
	// Token: 0x020008E5 RID: 2277
	internal sealed class EtwEventProvider : EventProviderImpl
	{
		// Token: 0x06008BC1 RID: 35777 RVA: 0x0015311B File Offset: 0x0015131B
		internal EtwEventProvider(EventProvider eventProvider)
		{
			this._eventProvider = new WeakReference<EventProvider>(eventProvider);
		}

		// Token: 0x06008BC2 RID: 35778 RVA: 0x0015312F File Offset: 0x0015132F
		internal override void Disable()
		{
			base.Disable();
			this._liveSessions = null;
		}

		// Token: 0x06008BC3 RID: 35779 RVA: 0x00153140 File Offset: 0x00151340
		protected unsafe override void HandleEnableNotification(EventProvider target, byte* additionalData, byte level, long matchAnyKeywords, long matchAllKeywords, Interop.Advapi32.EVENT_FILTER_DESCRIPTOR* filterData)
		{
			List<KeyValuePair<EtwEventProvider.SessionInfo, bool>> changedSessions = this.GetChangedSessions();
			foreach (KeyValuePair<EtwEventProvider.SessionInfo, bool> keyValuePair in changedSessions)
			{
				int sessionIdBit = keyValuePair.Key.sessionIdBit;
				bool value = keyValuePair.Value;
				IDictionary<string, string> arguments = null;
				ControllerCommand command = ControllerCommand.Update;
				if (value)
				{
					byte[] data;
					if (changedSessions.Count > 1 || filterData == null)
					{
						this.TryReadRegistryFilterData(keyValuePair.Key.etwSessionId, out command, out data);
					}
					else
					{
						base.MarshalFilterData(filterData, out command, out data);
					}
					arguments = EventProviderImpl.ParseFilterData(data);
				}
				target.OnControllerCommand(command, arguments, value ? sessionIdBit : (-sessionIdBit));
			}
		}

		// Token: 0x06008BC4 RID: 35780 RVA: 0x00153204 File Offset: 0x00151404
		[UnmanagedCallersOnly]
		private unsafe static void Callback(Guid* sourceId, int isEnabled, byte level, long matchAnyKeywords, long matchAllKeywords, Interop.Advapi32.EVENT_FILTER_DESCRIPTOR* filterData, void* callbackContext)
		{
			EtwEventProvider etwEventProvider = (EtwEventProvider)GCHandle.FromIntPtr(callbackContext).Target;
			EventProvider target;
			if (etwEventProvider._eventProvider.TryGetTarget(out target))
			{
				etwEventProvider.ProviderCallback(target, null, isEnabled, level, matchAnyKeywords, matchAllKeywords, filterData);
			}
		}

		// Token: 0x06008BC5 RID: 35781 RVA: 0x00153248 File Offset: 0x00151448
		internal unsafe override void Register(Guid id, string name)
		{
			this._gcHandle = GCHandle.Alloc(this);
			long registrationHandle = 0L;
			this._providerId = id;
			Guid providerId = this._providerId;
			uint num = Interop.Advapi32.EventRegister(&providerId, ldftn(Callback), (ushort)GCHandle.ToIntPtr(this._gcHandle), &registrationHandle);
			if (num != 0U)
			{
				this._gcHandle.Free();
				throw new ArgumentException(Interop.Kernel32.GetMessage((int)num));
			}
			this._registrationHandle = registrationHandle;
		}

		// Token: 0x06008BC6 RID: 35782 RVA: 0x001532B0 File Offset: 0x001514B0
		internal override void Unregister()
		{
			if (this._registrationHandle != 0L)
			{
				Interop.Advapi32.EventUnregister(this._registrationHandle);
				this._registrationHandle = 0L;
			}
			if (this._gcHandle.IsAllocated)
			{
				this._gcHandle.Free();
			}
		}

		// Token: 0x06008BC7 RID: 35783 RVA: 0x001532E8 File Offset: 0x001514E8
		internal unsafe override EventProvider.WriteEventErrorCode EventWriteTransfer(in EventDescriptor eventDescriptor, IntPtr eventHandle, Guid* activityId, Guid* relatedActivityId, int userDataCount, EventProvider.EventData* userData)
		{
			int num = Interop.Advapi32.EventWriteTransfer(this._registrationHandle, eventDescriptor, activityId, relatedActivityId, userDataCount, userData);
			EventProvider.WriteEventErrorCode result;
			if (num != 8)
			{
				if (num == 234 || num == 534)
				{
					result = EventProvider.WriteEventErrorCode.EventTooBig;
				}
				else
				{
					result = EventProvider.WriteEventErrorCode.NoError;
				}
			}
			else
			{
				result = EventProvider.WriteEventErrorCode.NoFreeBuffers;
			}
			return result;
		}

		// Token: 0x06008BC8 RID: 35784 RVA: 0x0001A563 File Offset: 0x00018763
		internal unsafe override IntPtr DefineEventHandle(uint eventID, string eventName, long keywords, uint eventVersion, uint level, byte* pMetadata, uint metadataLength)
		{
			throw new NotSupportedException();
		}

		// Token: 0x06008BC9 RID: 35785 RVA: 0x00153328 File Offset: 0x00151528
		internal unsafe int SetInformation(Interop.Advapi32.EVENT_INFO_CLASS eventInfoClass, void* data, uint dataSize)
		{
			int result = 50;
			if (!EtwEventProvider.s_setInformationMissing)
			{
				try
				{
					result = Interop.Advapi32.EventSetInformation(this._registrationHandle, eventInfoClass, data, dataSize);
				}
				catch (TypeLoadException)
				{
					EtwEventProvider.s_setInformationMissing = true;
				}
			}
			return result;
		}

		// Token: 0x06008BCA RID: 35786 RVA: 0x0015336C File Offset: 0x0015156C
		private bool TryReadRegistryFilterData(int etwSessionId, out ControllerCommand command, out byte[] data)
		{
			command = ControllerCommand.Update;
			data = null;
			string text = "\\Microsoft\\Windows\\CurrentVersion\\Winevt\\Publishers\\{" + this._providerId.ToString() + "}";
			text = "Software\\Wow6432Node" + text;
			string name = "ControllerData_Session_" + etwSessionId.ToString(CultureInfo.InvariantCulture);
			using (RegistryKey registryKey = Registry.LocalMachine.OpenSubKey(text))
			{
				data = (((registryKey != null) ? registryKey.GetValue(name, null) : null) as byte[]);
				if (data != null)
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x06008BCB RID: 35787 RVA: 0x00153414 File Offset: 0x00151614
		private List<KeyValuePair<EtwEventProvider.SessionInfo, bool>> GetChangedSessions()
		{
			List<EtwEventProvider.SessionInfo> list = null;
			EtwEventProvider.SessionInfoCallback action;
			if ((action = EtwEventProvider.<>O.<0>__GetSessionInfoCallback) == null)
			{
				action = (EtwEventProvider.<>O.<0>__GetSessionInfoCallback = new EtwEventProvider.SessionInfoCallback(EtwEventProvider.GetSessionInfoCallback));
			}
			this.GetSessionInfo(action, ref list);
			List<KeyValuePair<EtwEventProvider.SessionInfo, bool>> list2 = new List<KeyValuePair<EtwEventProvider.SessionInfo, bool>>();
			if (this._liveSessions != null)
			{
				foreach (EtwEventProvider.SessionInfo sessionInfo in this._liveSessions)
				{
					int index;
					if ((index = EtwEventProvider.IndexOfSessionInList(list, sessionInfo.etwSessionId)) < 0 || list[index].sessionIdBit != sessionInfo.sessionIdBit)
					{
						list2.Add(new KeyValuePair<EtwEventProvider.SessionInfo, bool>(sessionInfo, false));
					}
				}
			}
			if (list != null)
			{
				foreach (EtwEventProvider.SessionInfo sessionInfo2 in list)
				{
					int index2;
					if ((index2 = EtwEventProvider.IndexOfSessionInList(this._liveSessions, sessionInfo2.etwSessionId)) < 0 || this._liveSessions[index2].sessionIdBit != sessionInfo2.sessionIdBit)
					{
						list2.Add(new KeyValuePair<EtwEventProvider.SessionInfo, bool>(sessionInfo2, true));
					}
				}
			}
			this._liveSessions = list;
			return list2;
		}

		// Token: 0x06008BCC RID: 35788 RVA: 0x0015354C File Offset: 0x0015174C
		private static void GetSessionInfoCallback(int etwSessionId, long matchAllKeywords, ref List<EtwEventProvider.SessionInfo> sessionList)
		{
			uint value = (uint)SessionMask.FromEventKeywords((ulong)matchAllKeywords);
			int num = BitOperations.PopCount(value);
			if (num > 1)
			{
				return;
			}
			if (sessionList == null)
			{
				sessionList = new List<EtwEventProvider.SessionInfo>(8);
			}
			if (num == 1)
			{
				num = BitOperations.TrailingZeroCount(value);
			}
			else
			{
				num = BitOperations.PopCount((uint)SessionMask.All);
			}
			sessionList.Add(new EtwEventProvider.SessionInfo(num + 1, etwSessionId));
		}

		// Token: 0x06008BCD RID: 35789 RVA: 0x001535AC File Offset: 0x001517AC
		private unsafe void GetSessionInfo(EtwEventProvider.SessionInfoCallback action, ref List<EtwEventProvider.SessionInfo> sessionList)
		{
			int num = 256;
			byte* ptr = stackalloc byte[(UIntPtr)num];
			byte* ptr2 = ptr;
			try
			{
				for (;;)
				{
					int num2 = 0;
					try
					{
						fixed (Guid* ptr3 = &this._providerId)
						{
							Guid* inBuffer = ptr3;
							num2 = Interop.Advapi32.EnumerateTraceGuidsEx(Interop.Advapi32.TRACE_QUERY_INFO_CLASS.TraceGuidQueryInfo, (void*)inBuffer, sizeof(Guid), (void*)ptr2, num, out num);
						}
					}
					finally
					{
						Guid* ptr3 = null;
					}
					if (num2 == 0)
					{
						goto IL_5D;
					}
					if (num2 != 122)
					{
						break;
					}
					if (ptr2 != ptr)
					{
						IntPtr hglobal = ptr2;
						ptr2 = null;
						Marshal.FreeHGlobal(hglobal);
					}
					ptr2 = Marshal.AllocHGlobal(num);
				}
				return;
				IL_5D:
				Interop.Advapi32.TRACE_GUID_INFO* ptr4 = (Interop.Advapi32.TRACE_GUID_INFO*)ptr2;
				Interop.Advapi32.TRACE_PROVIDER_INSTANCE_INFO* ptr5 = (Interop.Advapi32.TRACE_PROVIDER_INSTANCE_INFO*)(ptr4 + 1);
				int currentProcessId = (int)Interop.Kernel32.GetCurrentProcessId();
				for (int i = 0; i < ptr4->InstanceCount; i++)
				{
					if (ptr5->Pid == currentProcessId)
					{
						Interop.Advapi32.TRACE_ENABLE_INFO* ptr6 = (Interop.Advapi32.TRACE_ENABLE_INFO*)(ptr5 + 1);
						for (int j = 0; j < ptr5->EnableCount; j++)
						{
							action((int)ptr6[j].LoggerId, ptr6[j].MatchAllKeyword, ref sessionList);
						}
					}
					if (ptr5->NextOffset == 0)
					{
						break;
					}
					byte* ptr7 = (byte*)ptr5;
					ptr5 = (Interop.Advapi32.TRACE_PROVIDER_INSTANCE_INFO*)(ptr7 + ptr5->NextOffset);
				}
			}
			finally
			{
				if (ptr2 != null && ptr2 != ptr)
				{
					Marshal.FreeHGlobal(ptr2);
				}
			}
		}

		// Token: 0x06008BCE RID: 35790 RVA: 0x001536E4 File Offset: 0x001518E4
		private static int IndexOfSessionInList(List<EtwEventProvider.SessionInfo> sessions, int etwSessionId)
		{
			if (sessions == null)
			{
				return -1;
			}
			for (int i = 0; i < sessions.Count; i++)
			{
				if (sessions[i].etwSessionId == etwSessionId)
				{
					return i;
				}
			}
			return -1;
		}

		// Token: 0x04001FA1 RID: 8097
		private readonly WeakReference<EventProvider> _eventProvider;

		// Token: 0x04001FA2 RID: 8098
		private long _registrationHandle;

		// Token: 0x04001FA3 RID: 8099
		private GCHandle _gcHandle;

		// Token: 0x04001FA4 RID: 8100
		private List<EtwEventProvider.SessionInfo> _liveSessions;

		// Token: 0x04001FA5 RID: 8101
		private Guid _providerId;

		// Token: 0x04001FA6 RID: 8102
		private static bool s_setInformationMissing;

		// Token: 0x020008E6 RID: 2278
		public struct SessionInfo
		{
			// Token: 0x06008BCF RID: 35791 RVA: 0x00153719 File Offset: 0x00151919
			internal SessionInfo(int sessionIdBit_, int etwSessionId_)
			{
				this.sessionIdBit = sessionIdBit_;
				this.etwSessionId = etwSessionId_;
			}

			// Token: 0x04001FA7 RID: 8103
			internal int sessionIdBit;

			// Token: 0x04001FA8 RID: 8104
			internal int etwSessionId;
		}

		// Token: 0x020008E7 RID: 2279
		// (Invoke) Token: 0x06008BD1 RID: 35793
		private delegate void SessionInfoCallback(int etwSessionId, long matchAllKeywords, ref List<EtwEventProvider.SessionInfo> sessionList);

		// Token: 0x020008E8 RID: 2280
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04001FA9 RID: 8105
			public static EtwEventProvider.SessionInfoCallback <0>__GetSessionInfoCallback;
		}
	}
}
