using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;

namespace CSharpScript.Game.Module.Activity.ActivityContent.DangoBrawl
{
	// Token: 0x020067C4 RID: 26564
	[NullableContext(1)]
	[Nullable(0)]
	public class DangoBrawlEventSelectServerData
	{
		// Token: 0x170096BA RID: 38586
		// (set) Token: 0x0604228A RID: 270986 RVA: 0x0100AFC8 File Offset: 0x010091C8
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

		// Token: 0x0604228B RID: 270987 RVA: 0x0100B054 File Offset: 0x01009254
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

		// Token: 0x040228A4 RID: 141476
		public readonly List<CardInfo> CardInfos = new List<CardInfo>();
	}
}
