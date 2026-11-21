using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace System.Diagnostics.Tracing
{
	// Token: 0x020008E9 RID: 2281
	internal class EventProviderImpl
	{
		// Token: 0x17001299 RID: 4761
		// (get) Token: 0x06008BD2 RID: 35794 RVA: 0x00153729 File Offset: 0x00151929
		// (set) Token: 0x06008BD3 RID: 35795 RVA: 0x00153731 File Offset: 0x00151931
		internal EventLevel Level
		{
			get
			{
				return (EventLevel)this._level;
			}
			set
			{
				this._level = (byte)value;
			}
		}

		// Token: 0x1700129A RID: 4762
		// (get) Token: 0x06008BD4 RID: 35796 RVA: 0x0015373B File Offset: 0x0015193B
		// (set) Token: 0x06008BD5 RID: 35797 RVA: 0x00153743 File Offset: 0x00151943
		internal EventKeywords MatchAnyKeyword
		{
			get
			{
				return (EventKeywords)this._anyKeywordMask;
			}
			set
			{
				this._anyKeywordMask = (long)value;
			}
		}

		// Token: 0x1700129B RID: 4763
		// (get) Token: 0x06008BD6 RID: 35798 RVA: 0x0015374C File Offset: 0x0015194C
		// (set) Token: 0x06008BD7 RID: 35799 RVA: 0x00153754 File Offset: 0x00151954
		internal EventKeywords MatchAllKeyword
		{
			get
			{
				return (EventKeywords)this._allKeywordMask;
			}
			set
			{
				this._allKeywordMask = (long)value;
			}
		}

		// Token: 0x06008BD8 RID: 35800 RVA: 0x0000FCFA File Offset: 0x0000DEFA
		protected unsafe virtual void HandleEnableNotification(EventProvider target, byte* additionalData, byte level, long matchAnyKeywords, long matchAllKeywords, Interop.Advapi32.EVENT_FILTER_DESCRIPTOR* filterData)
		{
		}

		// Token: 0x06008BD9 RID: 35801 RVA: 0x0015375D File Offset: 0x0015195D
		public bool IsEnabled()
		{
			return this._enabled;
		}

		// Token: 0x06008BDA RID: 35802 RVA: 0x00153765 File Offset: 0x00151965
		public bool IsEnabled(byte level, long keywords)
		{
			return this._enabled && ((level <= this._level || this._level == 0) && (keywords == 0L || ((keywords & this._anyKeywordMask) != 0L && (keywords & this._allKeywordMask) == this._allKeywordMask)));
		}

		// Token: 0x06008BDB RID: 35803 RVA: 0x001537A2 File Offset: 0x001519A2
		internal void Enable(byte level, long anyKeyword, long allKeyword)
		{
			this._enabled = true;
			this._level = level;
			this._anyKeywordMask = anyKeyword;
			this._allKeywordMask = allKeyword;
		}

		// Token: 0x06008BDC RID: 35804 RVA: 0x001537C0 File Offset: 0x001519C0
		internal virtual void Disable()
		{
			this._enabled = false;
			this._level = 0;
			this._anyKeywordMask = 0L;
			this._allKeywordMask = 0L;
		}

		// Token: 0x06008BDD RID: 35805 RVA: 0x0000FCFA File Offset: 0x0000DEFA
		internal virtual void Register(Guid id, string name)
		{
		}

		// Token: 0x06008BDE RID: 35806 RVA: 0x0000FCFA File Offset: 0x0000DEFA
		internal virtual void Unregister()
		{
		}

		// Token: 0x06008BDF RID: 35807 RVA: 0x00007B65 File Offset: 0x00005D65
		internal unsafe virtual EventProvider.WriteEventErrorCode EventWriteTransfer(in EventDescriptor eventDescriptor, IntPtr eventHandle, Guid* activityId, Guid* relatedActivityId, int userDataCount, EventProvider.EventData* userData)
		{
			return EventProvider.WriteEventErrorCode.NoError;
		}

		// Token: 0x06008BE0 RID: 35808 RVA: 0x000F2A6E File Offset: 0x000F0C6E
		internal unsafe virtual IntPtr DefineEventHandle(uint eventID, string eventName, long keywords, uint eventVersion, uint level, byte* pMetadata, uint metadataLength)
		{
			return IntPtr.Zero;
		}

		// Token: 0x06008BE1 RID: 35809 RVA: 0x001537E0 File Offset: 0x001519E0
		protected unsafe void ProviderCallback(EventProvider target, byte* additionalData, int controlCode, byte level, long matchAnyKeywords, long matchAllKeywords, Interop.Advapi32.EVENT_FILTER_DESCRIPTOR* filterData)
		{
			try
			{
				if (controlCode == 1)
				{
					this.Enable(level, matchAnyKeywords, matchAllKeywords);
					this.HandleEnableNotification(target, additionalData, level, matchAnyKeywords, matchAllKeywords, filterData);
				}
				else
				{
					ControllerCommand command = ControllerCommand.Update;
					if (controlCode == 0)
					{
						this.Disable();
					}
					else
					{
						if (controlCode != 2)
						{
							return;
						}
						command = ControllerCommand.SendManifest;
					}
					target.OnControllerCommand(command, null, 0);
				}
			}
			catch
			{
			}
		}

		// Token: 0x06008BE2 RID: 35810 RVA: 0x00153844 File Offset: 0x00151A44
		private static int FindNull(byte[] buffer, int idx)
		{
			while (idx < buffer.Length && buffer[idx] != 0)
			{
				idx++;
			}
			return idx;
		}

		// Token: 0x06008BE3 RID: 35811 RVA: 0x0015385C File Offset: 0x00151A5C
		protected static IDictionary<string, string> ParseFilterData(byte[] data)
		{
			Dictionary<string, string> dictionary = null;
			if (data != null)
			{
				dictionary = new Dictionary<string, string>(4);
				int num3;
				for (int i = 0; i < data.Length; i = num3 + 1)
				{
					int num = EventProviderImpl.FindNull(data, i);
					int num2 = num + 1;
					num3 = EventProviderImpl.FindNull(data, num2);
					if (num3 < data.Length)
					{
						string @string = Encoding.UTF8.GetString(data, i, num - i);
						string string2 = Encoding.UTF8.GetString(data, num2, num3 - num2);
						dictionary[@string] = string2;
					}
				}
			}
			return dictionary;
		}

		// Token: 0x06008BE4 RID: 35812 RVA: 0x001538D0 File Offset: 0x00151AD0
		protected unsafe bool MarshalFilterData(Interop.Advapi32.EVENT_FILTER_DESCRIPTOR* filterData, out ControllerCommand command, out byte[] data)
		{
			data = null;
			if (filterData->Ptr != 0L && 0 < filterData->Size && filterData->Size <= 102400)
			{
				data = new byte[filterData->Size];
				Marshal.Copy((IntPtr)((UIntPtr)filterData->Ptr), data, 0, data.Length);
			}
			command = (ControllerCommand)filterData->Type;
			return true;
		}

		// Token: 0x04001FAA RID: 8106
		protected byte _level;

		// Token: 0x04001FAB RID: 8107
		protected long _anyKeywordMask;

		// Token: 0x04001FAC RID: 8108
		protected long _allKeywordMask;

		// Token: 0x04001FAD RID: 8109
		protected bool _enabled;
	}
}
