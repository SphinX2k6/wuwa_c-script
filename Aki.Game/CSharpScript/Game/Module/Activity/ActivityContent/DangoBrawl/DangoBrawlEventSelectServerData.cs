using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;

namespace CSharpScript.Game.Module.Activity.ActivityContent.DangoBrawl
{
	// Token: 0x02005714 RID: 22292
	[NullableContext(1)]
	[Nullable(0)]
	public class DangoBrawlEventSelectServerData
	{
		// Token: 0x170069FB RID: 27131
		// (set) Token: 0x06036DE0 RID: 224736 RVA: 0x00F4C3AC File Offset: 0x00F4A5AC
		public DangoBrawlEventInfo CurrentEventSelectInfo
		{
			set
			{
				this.CardInfos.Clear();
				foreach (DangoBrawlEventSlotInfo dangoBrawlEventSlotInfo in value.Slots)
				{
					this.CardInfos.Add(new CardInfo
					{
						CardId = dangoBrawlEventSlotInfo.EventConfigId,
						TotalRefreshCount = value.PerSlotRefreshLimit,
						RefreshCount = dangoBrawlEventSlotInfo.RefreshedCount
					});
				}
			}
		}

		// Token: 0x06036DE1 RID: 224737 RVA: 0x00F4C438 File Offset: 0x00F4A638
		public bool UpdateSlot(int index, DangoBrawlEventSlotInfo slot)
		{
			if (index < 0 || index >= this.CardInfos.Count)
			{
				return false;
			}
			CardInfo value = this.CardInfos[index];
			value.CardId = slot.EventConfigId;
			value.RefreshCount = slot.RefreshedCount;
			this.CardInfos[index] = value;
			return true;
		}

		// Token: 0x0401D101 RID: 119041
		public readonly List<CardInfo> CardInfos = new List<CardInfo>();
	}
}
