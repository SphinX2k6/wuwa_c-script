using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace System.Diagnostics.Tracing
{
	// Token: 0x020008DC RID: 2268
	internal sealed class EventPipeEventProvider : EventProviderImpl
	{
		// Token: 0x06008B8E RID: 35726 RVA: 0x00151371 File Offset: 0x0014F571
		internal EventPipeEventProvider(EventProvider eventProvider)
		{
			this._eventProvider = new WeakReference<EventProvider>(eventProvider);
		}

		// Token: 0x06008B8F RID: 35727 RVA: 0x00151388 File Offset: 0x0014F588
		protected unsafe override void HandleEnableNotification(EventProvider target, byte* additionalData, byte level, long matchAnyKeywords, long matchAllKeywords, Interop.Advapi32.EVENT_FILTER_DESCRIPTOR* filterData)
		{
			ulong num = 0UL;
			if (additionalData != null)
			{
				num = BitConverter.ToUInt64(new ReadOnlySpan<byte>((void*)additionalData, 8));
			}
			bool flag = num > 0UL;
			IDictionary<string, string> arguments = null;
			ControllerCommand command = ControllerCommand.Update;
			if (flag)
			{
				byte[] data = null;
				if (filterData != null)
				{
					base.MarshalFilterData(filterData, out command, out data);
				}
				arguments = EventProviderImpl.ParseFilterData(data);
			}
			target.OnControllerCommand(command, arguments, flag ? 4 : -1);
		}

		// Token: 0x06008B90 RID: 35728 RVA: 0x001513E4 File Offset: 0x0014F5E4
		[UnmanagedCallersOnly]
		private unsafe static void Callback(byte* sourceId, int isEnabled, byte level, long matchAnyKeywords, long matchAllKeywords, Interop.Advapi32.EVENT_FILTER_DESCRIPTOR* filterData, void* callbackContext)
		{
			EventPipeEventProvider eventPipeEventProvider = (EventPipeEventProvider)GCHandle.FromIntPtr(callbackContext).Target;
			EventProvider target;
			if (eventPipeEventProvider._eventProvider.TryGetTarget(out target))
			{
				eventPipeEventProvider.ProviderCallback(target, sourceId, isEnabled, level, matchAnyKeywords, matchAllKeywords, filterData);
			}
		}

		// Token: 0x06008B91 RID: 35729 RVA: 0x00151424 File Offset: 0x0014F624
		internal override void Register(Guid id, string name)
		{
			this._gcHandle = GCHandle.Alloc(this);
			this._provHandle = EventPipeInternal.CreateProvider(name, ldftn(Callback), (ushort)GCHandle.ToIntPtr(this._gcHandle));
			if (this._provHandle == 0)
			{
				this._gcHandle.Free();
				throw new OutOfMemoryException();
			}
		}

		// Token: 0x06008B92 RID: 35730 RVA: 0x00151473 File Offset: 0x0014F673
		internal override void Unregister()
		{
			if (this._provHandle != 0)
			{
				EventPipeInternal.DeleteProvider(this._provHandle);
				this._provHandle = (IntPtr)0;
			}
			if (this._gcHandle.IsAllocated)
			{
				this._gcHandle.Free();
			}
		}

		// Token: 0x06008B93 RID: 35731 RVA: 0x001514A8 File Offset: 0x0014F6A8
		internal unsafe override EventProvider.WriteEventErrorCode EventWriteTransfer(in EventDescriptor eventDescriptor, IntPtr eventHandle, Guid* activityId, Guid* relatedActivityId, int userDataCount, EventProvider.EventData* userData)
		{
			if (eventHandle != IntPtr.Zero)
			{
				if (userDataCount == 0)
				{
					EventPipeInternal.WriteEventData(eventHandle, null, 0U, activityId, relatedActivityId);
					return EventProvider.WriteEventErrorCode.NoError;
				}
				if (eventDescriptor.Channel == 11)
				{
					userData += 3;
					userDataCount -= 3;
				}
				EventPipeInternal.WriteEventData(eventHandle, userData, (uint)userDataCount, activityId, relatedActivityId);
			}
			return EventProvider.WriteEventErrorCode.NoError;
		}

		// Token: 0x06008B94 RID: 35732 RVA: 0x001514FB File Offset: 0x0014F6FB
		internal unsafe override IntPtr DefineEventHandle(uint eventID, string eventName, long keywords, uint eventVersion, uint level, byte* pMetadata, uint metadataLength)
		{
			return EventPipeInternal.DefineEvent(this._provHandle, eventID, keywords, eventVersion, level, pMetadata, metadataLength);
		}

		// Token: 0x06008B95 RID: 35733 RVA: 0x00151512 File Offset: 0x0014F712
		internal static int EventActivityIdControl(Interop.Advapi32.ActivityControl controlCode, ref Guid activityId)
		{
			return EventPipeInternal.EventActivityIdControl((uint)controlCode, ref activityId);
		}

		// Token: 0x04001F7E RID: 8062
		private readonly WeakReference<EventProvider> _eventProvider;

		// Token: 0x04001F7F RID: 8063
		private IntPtr _provHandle;

		// Token: 0x04001F80 RID: 8064
		private GCHandle _gcHandle;
	}
}
