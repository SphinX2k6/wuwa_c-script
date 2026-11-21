using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace System.Diagnostics.Tracing
{
	// Token: 0x020008E2 RID: 2274
	internal class EventProvider : IDisposable
	{
		// Token: 0x06008BAB RID: 35755 RVA: 0x00152520 File Offset: 0x00150720
		internal EventProvider(EventProviderType providerType)
		{
			EventProviderImpl eventProvider;
			if (providerType != EventProviderType.ETW)
			{
				if (providerType != EventProviderType.EventPipe)
				{
					eventProvider = new EventProviderImpl();
				}
				else
				{
					eventProvider = new EventPipeEventProvider(this);
				}
			}
			else
			{
				eventProvider = new EtwEventProvider(this);
			}
			this._eventProvider = eventProvider;
		}

		// Token: 0x06008BAC RID: 35756 RVA: 0x0015255C File Offset: 0x0015075C
		internal void Register(Guid id, string name)
		{
			this._providerName = name;
			this._providerId = id;
			this._eventProvider.Register(id, name);
		}

		// Token: 0x06008BAD RID: 35757 RVA: 0x00152579 File Offset: 0x00150779
		public void Dispose()
		{
			this.Dispose(true);
			GC.SuppressFinalize(this);
		}

		// Token: 0x06008BAE RID: 35758 RVA: 0x00152588 File Offset: 0x00150788
		protected virtual void Dispose(bool disposing)
		{
			if (this._disposed)
			{
				return;
			}
			this._eventProvider.Disable();
			object eventListenersLock = EventListener.EventListenersLock;
			lock (eventListenersLock)
			{
				if (this._disposed)
				{
					return;
				}
				this._disposed = true;
			}
			this._eventProvider.Unregister();
		}

		// Token: 0x06008BAF RID: 35759 RVA: 0x001525F4 File Offset: 0x001507F4
		public virtual void Close()
		{
			this.Dispose();
		}

		// Token: 0x06008BB0 RID: 35760 RVA: 0x001525FC File Offset: 0x001507FC
		~EventProvider()
		{
			this.Dispose(false);
		}

		// Token: 0x06008BB1 RID: 35761 RVA: 0x0000FCFA File Offset: 0x0000DEFA
		internal virtual void OnControllerCommand(ControllerCommand command, IDictionary<string, string> arguments, int sessionId)
		{
		}

		// Token: 0x17001296 RID: 4758
		// (get) Token: 0x06008BB2 RID: 35762 RVA: 0x0015262C File Offset: 0x0015082C
		// (set) Token: 0x06008BB3 RID: 35763 RVA: 0x00152639 File Offset: 0x00150839
		protected EventLevel Level
		{
			get
			{
				return this._eventProvider.Level;
			}
			set
			{
				this._eventProvider.Level = value;
			}
		}

		// Token: 0x17001297 RID: 4759
		// (get) Token: 0x06008BB4 RID: 35764 RVA: 0x00152647 File Offset: 0x00150847
		// (set) Token: 0x06008BB5 RID: 35765 RVA: 0x00152654 File Offset: 0x00150854
		protected EventKeywords MatchAnyKeyword
		{
			get
			{
				return this._eventProvider.MatchAnyKeyword;
			}
			set
			{
				this._eventProvider.MatchAnyKeyword = value;
			}
		}

		// Token: 0x17001298 RID: 4760
		// (get) Token: 0x06008BB6 RID: 35766 RVA: 0x00152662 File Offset: 0x00150862
		// (set) Token: 0x06008BB7 RID: 35767 RVA: 0x0015266F File Offset: 0x0015086F
		protected EventKeywords MatchAllKeyword
		{
			get
			{
				return this._eventProvider.MatchAllKeyword;
			}
			set
			{
				this._eventProvider.MatchAllKeyword = value;
			}
		}

		// Token: 0x06008BB8 RID: 35768 RVA: 0x0015267D File Offset: 0x0015087D
		public bool IsEnabled()
		{
			return this._eventProvider.IsEnabled();
		}

		// Token: 0x06008BB9 RID: 35769 RVA: 0x0015268A File Offset: 0x0015088A
		public bool IsEnabled(byte level, long keywords)
		{
			return this._eventProvider.IsEnabled(level, keywords);
		}

		// Token: 0x06008BBA RID: 35770 RVA: 0x00152699 File Offset: 0x00150899
		public static EventProvider.WriteEventErrorCode GetLastWriteEventError()
		{
			return EventProvider.s_returnCode;
		}

		// Token: 0x06008BBB RID: 35771 RVA: 0x001526A0 File Offset: 0x001508A0
		private static void SetLastError(EventProvider.WriteEventErrorCode error)
		{
			EventProvider.s_returnCode = error;
		}

		// Token: 0x06008BBC RID: 35772 RVA: 0x001526A8 File Offset: 0x001508A8
		private unsafe static object EncodeObject(ref object data, ref EventProvider.EventData* dataDescriptor, ref byte* dataBuffer, ref uint totalEventSize)
		{
			string text;
			byte[] array;
			for (;;)
			{
				dataDescriptor.Reserved = 0U;
				text = (data as string);
				array = null;
				if (text != null)
				{
					break;
				}
				if ((array = (data as byte[])) != null)
				{
					goto Block_1;
				}
				if (data is IntPtr)
				{
					goto Block_2;
				}
				if (data is int)
				{
					goto Block_3;
				}
				if (data is long)
				{
					goto Block_4;
				}
				if (data is uint)
				{
					goto Block_5;
				}
				if (data is ulong)
				{
					goto Block_6;
				}
				if (data is char)
				{
					goto Block_7;
				}
				if (data is byte)
				{
					goto Block_8;
				}
				if (data is short)
				{
					goto Block_9;
				}
				if (data is sbyte)
				{
					goto Block_10;
				}
				if (data is ushort)
				{
					goto Block_11;
				}
				if (data is float)
				{
					goto Block_12;
				}
				if (data is double)
				{
					goto Block_13;
				}
				if (data is bool)
				{
					goto Block_14;
				}
				if (data is Guid)
				{
					goto Block_16;
				}
				if (data is decimal)
				{
					goto Block_17;
				}
				if (data is DateTime)
				{
					goto Block_18;
				}
				if (data is Enum)
				{
					try
					{
						Type underlyingType = Enum.GetUnderlyingType(data.GetType());
						if (underlyingType == typeof(ulong))
						{
							data = (ulong)data;
						}
						else if (underlyingType == typeof(long))
						{
							data = (long)data;
						}
						else
						{
							data = (int)Convert.ToInt64(data);
						}
						continue;
					}
					catch
					{
					}
					goto IL_410;
				}
				goto IL_410;
			}
			dataDescriptor.Size = (uint)((text.Length + 1) * 2);
			goto IL_435;
			Block_1:
			*dataBuffer = array.Length;
			dataDescriptor.Ptr = (ulong)dataBuffer;
			dataDescriptor.Size = 4U;
			totalEventSize += dataDescriptor.Size;
			dataDescriptor += (IntPtr)sizeof(EventProvider.EventData);
			dataBuffer += 16;
			dataDescriptor.Size = (uint)array.Length;
			goto IL_435;
			Block_2:
			dataDescriptor.Size = 8U;
			IntPtr* ptr = dataBuffer;
			*ptr = (IntPtr)data;
			dataDescriptor.Ptr = ptr;
			goto IL_435;
			Block_3:
			dataDescriptor.Size = 4U;
			int* ptr2 = dataBuffer;
			*ptr2 = (int)data;
			dataDescriptor.Ptr = ptr2;
			goto IL_435;
			Block_4:
			dataDescriptor.Size = 8U;
			long* ptr3 = dataBuffer;
			*ptr3 = (long)data;
			dataDescriptor.Ptr = ptr3;
			goto IL_435;
			Block_5:
			dataDescriptor.Size = 4U;
			uint* ptr4 = dataBuffer;
			*ptr4 = (uint)data;
			dataDescriptor.Ptr = ptr4;
			goto IL_435;
			Block_6:
			dataDescriptor.Size = 8U;
			ulong* ptr5 = dataBuffer;
			*ptr5 = (ulong)data;
			dataDescriptor.Ptr = ptr5;
			goto IL_435;
			Block_7:
			dataDescriptor.Size = 2U;
			char* ptr6 = dataBuffer;
			*ptr6 = (char)data;
			dataDescriptor.Ptr = ptr6;
			goto IL_435;
			Block_8:
			dataDescriptor.Size = 1U;
			byte* ptr7 = dataBuffer;
			*ptr7 = (byte)data;
			dataDescriptor.Ptr = ptr7;
			goto IL_435;
			Block_9:
			dataDescriptor.Size = 2U;
			short* ptr8 = dataBuffer;
			*ptr8 = (short)data;
			dataDescriptor.Ptr = ptr8;
			goto IL_435;
			Block_10:
			dataDescriptor.Size = 1U;
			sbyte* ptr9 = dataBuffer;
			*ptr9 = (sbyte)data;
			dataDescriptor.Ptr = ptr9;
			goto IL_435;
			Block_11:
			dataDescriptor.Size = 2U;
			ushort* ptr10 = dataBuffer;
			*ptr10 = (ushort)data;
			dataDescriptor.Ptr = ptr10;
			goto IL_435;
			Block_12:
			dataDescriptor.Size = 4U;
			float* ptr11 = dataBuffer;
			*ptr11 = (float)data;
			dataDescriptor.Ptr = ptr11;
			goto IL_435;
			Block_13:
			dataDescriptor.Size = 8U;
			double* ptr12 = dataBuffer;
			*ptr12 = (double)data;
			dataDescriptor.Ptr = ptr12;
			goto IL_435;
			Block_14:
			dataDescriptor.Size = 4U;
			int* ptr13 = dataBuffer;
			if ((bool)data)
			{
				*ptr13 = 1;
			}
			else
			{
				*ptr13 = 0;
			}
			dataDescriptor.Ptr = ptr13;
			goto IL_435;
			Block_16:
			dataDescriptor.Size = (uint)sizeof(Guid);
			Guid* ptr14 = dataBuffer;
			*ptr14 = (Guid)data;
			dataDescriptor.Ptr = ptr14;
			goto IL_435;
			Block_17:
			dataDescriptor.Size = 16U;
			decimal* ptr15 = dataBuffer;
			*ptr15 = (decimal)data;
			dataDescriptor.Ptr = ptr15;
			goto IL_435;
			Block_18:
			long num = 0L;
			if (((DateTime)data).Ticks > 504911232000000000L)
			{
				num = ((DateTime)data).ToFileTimeUtc();
			}
			dataDescriptor.Size = 8U;
			long* ptr16 = dataBuffer;
			*ptr16 = num;
			dataDescriptor.Ptr = ptr16;
			goto IL_435;
			IL_410:
			if (data == null)
			{
				text = "";
			}
			else
			{
				text = data.ToString();
			}
			dataDescriptor.Size = (uint)((text.Length + 1) * 2);
			IL_435:
			totalEventSize += dataDescriptor.Size;
			dataDescriptor += (IntPtr)sizeof(EventProvider.EventData);
			dataBuffer += 16;
			return text ?? array;
		}

		// Token: 0x06008BBD RID: 35773 RVA: 0x00152B20 File Offset: 0x00150D20
		internal unsafe bool WriteEvent(ref EventDescriptor eventDescriptor, IntPtr eventHandle, Guid* activityID, Guid* childActivityID, object[] eventPayload)
		{
			EventProvider.WriteEventErrorCode writeEventErrorCode = EventProvider.WriteEventErrorCode.NoError;
			if (this.IsEnabled(eventDescriptor.Level, eventDescriptor.Keywords))
			{
				int num = eventPayload.Length;
				if (num > 128)
				{
					EventProvider.s_returnCode = EventProvider.WriteEventErrorCode.TooManyArgs;
					return false;
				}
				uint num2 = 0U;
				int i = 0;
				EightObjects eightObjects = default(EightObjects);
				Span<int> span = new Span<int>(stackalloc byte[(UIntPtr)32], 8);
				Span<object> span2 = <PrivateImplementationDetails>.InlineArrayAsSpan<EightObjects, object>(ref eightObjects, 8);
				EventProvider.EventData* ptr = stackalloc EventProvider.EventData[checked(unchecked((UIntPtr)(2 * num)) * (UIntPtr)sizeof(EventProvider.EventData))];
				for (int j = 0; j < 2 * num; j++)
				{
					ptr[j] = default(EventProvider.EventData);
				}
				EventProvider.EventData* ptr2 = ptr;
				byte* ptr3 = stackalloc byte[(UIntPtr)(32 * num)];
				bool flag = false;
				for (int k = 0; k < eventPayload.Length; k++)
				{
					if (eventPayload[k] == null)
					{
						EventProvider.s_returnCode = EventProvider.WriteEventErrorCode.NullInput;
						return false;
					}
					object obj = EventProvider.EncodeObject(ref eventPayload[k], ref ptr2, ref ptr3, ref num2);
					if (obj != null)
					{
						int num3 = (int)((long)(ptr2 - ptr) - 1L);
						if (!(obj is string))
						{
							if (eventPayload.Length + num3 + 1 - k > 128)
							{
								EventProvider.s_returnCode = EventProvider.WriteEventErrorCode.TooManyArgs;
								return false;
							}
							flag = true;
						}
						if (i >= span2.Length)
						{
							Span<object> span3 = new object[span2.Length * 2];
							span2.CopyTo(span3);
							span2 = span3;
							Span<int> span4 = new int[span.Length * 2];
							span.CopyTo(span4);
							span = span4;
						}
						*span2[i] = obj;
						*span[i] = num3;
						i++;
					}
				}
				num = (int)((long)(ptr2 - ptr));
				if (num2 > 65482U)
				{
					EventProvider.s_returnCode = EventProvider.WriteEventErrorCode.EventTooBig;
					return false;
				}
				if (!flag && i <= 8)
				{
					while (i < 8)
					{
						*span2[i] = null;
						*span[i] = -1;
						i++;
					}
					string text = (string)(*span2[0]);
					char* ptr4;
					if (text == null)
					{
						ptr4 = null;
					}
					else
					{
						fixed (char* ptr5 = text.GetPinnableReference())
						{
							ptr4 = ptr5;
						}
					}
					char* ptr6 = ptr4;
					string text2 = (string)(*span2[1]);
					char* ptr7;
					if (text2 == null)
					{
						ptr7 = null;
					}
					else
					{
						fixed (char* ptr8 = text2.GetPinnableReference())
						{
							ptr7 = ptr8;
						}
					}
					char* ptr9 = ptr7;
					string text3 = (string)(*span2[2]);
					char* ptr10;
					if (text3 == null)
					{
						ptr10 = null;
					}
					else
					{
						fixed (char* ptr11 = text3.GetPinnableReference())
						{
							ptr10 = ptr11;
						}
					}
					char* ptr12 = ptr10;
					string text4 = (string)(*span2[3]);
					char* ptr13;
					if (text4 == null)
					{
						ptr13 = null;
					}
					else
					{
						fixed (char* ptr14 = text4.GetPinnableReference())
						{
							ptr13 = ptr14;
						}
					}
					char* ptr15 = ptr13;
					string text5 = (string)(*span2[4]);
					char* ptr16;
					if (text5 == null)
					{
						ptr16 = null;
					}
					else
					{
						fixed (char* ptr17 = text5.GetPinnableReference())
						{
							ptr16 = ptr17;
						}
					}
					char* ptr18 = ptr16;
					string text6 = (string)(*span2[5]);
					char* ptr19;
					if (text6 == null)
					{
						ptr19 = null;
					}
					else
					{
						fixed (char* ptr20 = text6.GetPinnableReference())
						{
							ptr19 = ptr20;
						}
					}
					char* ptr21 = ptr19;
					string text7 = (string)(*span2[6]);
					char* ptr22;
					if (text7 == null)
					{
						ptr22 = null;
					}
					else
					{
						fixed (char* ptr23 = text7.GetPinnableReference())
						{
							ptr22 = ptr23;
						}
					}
					char* ptr24 = ptr22;
					string text8 = (string)(*span2[7]);
					char* ptr25;
					if (text8 == null)
					{
						ptr25 = null;
					}
					else
					{
						fixed (char* ptr26 = text8.GetPinnableReference())
						{
							ptr25 = ptr26;
						}
					}
					char* ptr27 = ptr25;
					ptr2 = ptr;
					if (*span2[0] != null)
					{
						ptr2[*span[0]].Ptr = ptr6;
					}
					if (*span2[1] != null)
					{
						ptr2[*span[1]].Ptr = ptr9;
					}
					if (*span2[2] != null)
					{
						ptr2[*span[2]].Ptr = ptr12;
					}
					if (*span2[3] != null)
					{
						ptr2[*span[3]].Ptr = ptr15;
					}
					if (*span2[4] != null)
					{
						ptr2[*span[4]].Ptr = ptr18;
					}
					if (*span2[5] != null)
					{
						ptr2[*span[5]].Ptr = ptr21;
					}
					if (*span2[6] != null)
					{
						ptr2[*span[6]].Ptr = ptr24;
					}
					if (*span2[7] != null)
					{
						ptr2[*span[7]].Ptr = ptr27;
					}
					writeEventErrorCode = this._eventProvider.EventWriteTransfer(eventDescriptor, eventHandle, activityID, childActivityID, num, ptr);
					char* ptr5 = null;
					char* ptr8 = null;
					char* ptr11 = null;
					char* ptr14 = null;
					char* ptr17 = null;
					char* ptr20 = null;
					char* ptr23 = null;
					char* ptr26 = null;
				}
				else
				{
					ptr2 = ptr;
					GCHandle[] array = new GCHandle[i];
					for (int l = 0; l < i; l++)
					{
						array[l] = GCHandle.Alloc(*span2[l], GCHandleType.Pinned);
						if ((*span2[l]) is string)
						{
							string text9 = (string)(*span2[l]);
							char* ptr28;
							if (text9 == null)
							{
								ptr28 = null;
							}
							else
							{
								fixed (char* ptr26 = text9.GetPinnableReference())
								{
									ptr28 = ptr26;
								}
							}
							char* ptr29 = ptr28;
							ptr2[*span[l]].Ptr = ptr29;
							char* ptr26 = null;
						}
						else
						{
							byte[] array2;
							byte* ptr30;
							if ((array2 = (byte[])(*span2[l])) == null || array2.Length == 0)
							{
								ptr30 = null;
							}
							else
							{
								ptr30 = &array2[0];
							}
							ptr2[*span[l]].Ptr = ptr30;
							array2 = null;
						}
					}
					writeEventErrorCode = this._eventProvider.EventWriteTransfer(eventDescriptor, eventHandle, activityID, childActivityID, num, ptr);
					for (int m = 0; m < i; m++)
					{
						array[m].Free();
					}
				}
			}
			if (writeEventErrorCode != EventProvider.WriteEventErrorCode.NoError)
			{
				EventProvider.SetLastError(writeEventErrorCode);
				return false;
			}
			return true;
		}

		// Token: 0x06008BBE RID: 35774 RVA: 0x001530A4 File Offset: 0x001512A4
		protected internal unsafe bool WriteEvent(ref EventDescriptor eventDescriptor, IntPtr eventHandle, Guid* activityID, Guid* childActivityID, int dataCount, IntPtr data)
		{
			UIntPtr uintPtr = (UIntPtr)0;
			EventProvider.WriteEventErrorCode writeEventErrorCode = this._eventProvider.EventWriteTransfer(eventDescriptor, eventHandle, activityID, childActivityID, dataCount, data);
			if (writeEventErrorCode != EventProvider.WriteEventErrorCode.NoError)
			{
				EventProvider.SetLastError(writeEventErrorCode);
				return false;
			}
			return true;
		}

		// Token: 0x06008BBF RID: 35775 RVA: 0x001530D8 File Offset: 0x001512D8
		internal unsafe bool WriteEventRaw(ref EventDescriptor eventDescriptor, IntPtr eventHandle, Guid* activityID, Guid* relatedActivityID, int dataCount, IntPtr data)
		{
			EventProvider.WriteEventErrorCode writeEventErrorCode = this._eventProvider.EventWriteTransfer(eventDescriptor, eventHandle, activityID, relatedActivityID, dataCount, data);
			if (writeEventErrorCode != EventProvider.WriteEventErrorCode.NoError)
			{
				EventProvider.SetLastError(writeEventErrorCode);
				return false;
			}
			return true;
		}

		// Token: 0x06008BC0 RID: 35776 RVA: 0x00153106 File Offset: 0x00151306
		internal unsafe int SetInformation(Interop.Advapi32.EVENT_INFO_CLASS eventInfoClass, void* data, uint dataSize)
		{
			return ((EtwEventProvider)this._eventProvider).SetInformation(eventInfoClass, data, dataSize);
		}

		// Token: 0x04001F8E RID: 8078
		internal EventProviderImpl _eventProvider;

		// Token: 0x04001F8F RID: 8079
		private string _providerName;

		// Token: 0x04001F90 RID: 8080
		private Guid _providerId;

		// Token: 0x04001F91 RID: 8081
		internal bool _disposed;

		// Token: 0x04001F92 RID: 8082
		[ThreadStatic]
		private static EventProvider.WriteEventErrorCode s_returnCode;

		// Token: 0x04001F93 RID: 8083
		private const int BasicTypeAllocationBufferSize = 16;

		// Token: 0x04001F94 RID: 8084
		private const int EtwMaxNumberArguments = 128;

		// Token: 0x04001F95 RID: 8085
		private const int EtwAPIMaxRefObjCount = 8;

		// Token: 0x04001F96 RID: 8086
		private const int TraceEventMaximumSize = 65482;

		// Token: 0x020008E3 RID: 2275
		public struct EventData
		{
			// Token: 0x04001F97 RID: 8087
			internal ulong Ptr;

			// Token: 0x04001F98 RID: 8088
			internal uint Size;

			// Token: 0x04001F99 RID: 8089
			internal uint Reserved;
		}

		// Token: 0x020008E4 RID: 2276
		public enum WriteEventErrorCode
		{
			// Token: 0x04001F9B RID: 8091
			NoError,
			// Token: 0x04001F9C RID: 8092
			NoFreeBuffers,
			// Token: 0x04001F9D RID: 8093
			EventTooBig,
			// Token: 0x04001F9E RID: 8094
			NullInput,
			// Token: 0x04001F9F RID: 8095
			TooManyArgs,
			// Token: 0x04001FA0 RID: 8096
			Other
		}
	}
}
