using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Quest;
using CSharpScript.Game.LevelGamePlay;

namespace CSharpScript.Game.Module.ItemDeliver
{
	// Token: 0x02005810 RID: 22544
	[NullableContext(1)]
	[Nullable(0)]
	public class DeliverData
	{
		// Token: 0x060394D1 RID: 234705 RVA: 0x00D9716C File Offset: 0x00D9536C
		[NullableContext(2)]
		public DeliverData([Nullable(1)] string npcName, string titleTextId = null, string descriptionTextId = null, GeneralContext content = null)
		{
			this.Context = content;
			this.NpcName = npcName;
			this.TitleTextId = titleTextId;
			this.DescriptionTextId = descriptionTextId;
		}

		// Token: 0x060394D2 RID: 234706 RVA: 0x00D971A7 File Offset: 0x00D953A7
		public void Clear()
		{
			this.Context = null;
			this.SlotDataList.Clear();
			this.NpcName = "";
			this.DescriptionTextId = "";
		}

		// Token: 0x060394D3 RID: 234707 RVA: 0x00D971D4 File Offset: 0x00D953D4
		[return: Nullable(2)]
		public DeliverSlotData AddSlotData(List<int> itemIdList, int needCount, EHandInItemType handInType)
		{
			if (itemIdList == null || itemIdList.Count == 0)
			{
				return null;
			}
			DeliverSlotData deliverSlotData = new DeliverSlotData();
			deliverSlotData.Initialize(itemIdList, needCount, handInType);
			this.SlotDataList.Add(deliverSlotData);
			return deliverSlotData;
		}

		// Token: 0x060394D4 RID: 234708 RVA: 0x00D9720A File Offset: 0x00D9540A
		public List<DeliverSlotData> GetSlotDataList()
		{
			return this.SlotDataList;
		}

		// Token: 0x060394D5 RID: 234709 RVA: 0x00D97214 File Offset: 0x00D95414
		public bool IsSlotEnough(int itemConfigId)
		{
			foreach (DeliverSlotData deliverSlotData in this.SlotDataList)
			{
				if (deliverSlotData.HasItem() && deliverSlotData.GetCurrentItemConfigId() == itemConfigId && deliverSlotData.IsEnough())
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x060394D6 RID: 234710 RVA: 0x00D97280 File Offset: 0x00D95480
		public bool HasEmptySlot()
		{
			using (List<DeliverSlotData>.Enumerator enumerator = this.SlotDataList.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					if (!enumerator.Current.HasItem())
					{
						return true;
					}
				}
			}
			return false;
		}

		// Token: 0x0401DF6A RID: 122730
		[Nullable(2)]
		public GeneralContext Context;

		// Token: 0x0401DF6B RID: 122731
		private readonly List<DeliverSlotData> SlotDataList = new List<DeliverSlotData>();

		// Token: 0x0401DF6C RID: 122732
		public string NpcName = "";

		// Token: 0x0401DF6D RID: 122733
		[Nullable(2)]
		public string TitleTextId;

		// Token: 0x0401DF6E RID: 122734
		[Nullable(2)]
		public string DescriptionTextId;
	}
}
