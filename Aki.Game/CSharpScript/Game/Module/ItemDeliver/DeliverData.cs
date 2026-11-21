using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Quest;
using CSharpScript.Game.LevelGamePlay;

namespace CSharpScript.Game.Module.ItemDeliver
{
	// Token: 0x020047E7 RID: 18407
	[NullableContext(1)]
	[Nullable(0)]
	public class DeliverData
	{
		// Token: 0x0602E3E5 RID: 189413 RVA: 0x00CE5FFC File Offset: 0x00CE41FC
		[NullableContext(2)]
		public DeliverData([Nullable(1)] string npcName, string titleTextId = null, string descriptionTextId = null, GeneralContext content = null)
		{
			this.Context = content;
			this.NpcName = npcName;
			this.TitleTextId = titleTextId;
			this.DescriptionTextId = descriptionTextId;
		}

		// Token: 0x0602E3E6 RID: 189414 RVA: 0x00CE6037 File Offset: 0x00CE4237
		public void Clear()
		{
			this.Context = null;
			this.SlotDataList.Clear();
			this.NpcName = "";
			this.DescriptionTextId = "";
		}

		// Token: 0x0602E3E7 RID: 189415 RVA: 0x00CE6064 File Offset: 0x00CE4264
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

		// Token: 0x0602E3E8 RID: 189416 RVA: 0x00CE609A File Offset: 0x00CE429A
		public List<DeliverSlotData> GetSlotDataList()
		{
			return this.SlotDataList;
		}

		// Token: 0x0602E3E9 RID: 189417 RVA: 0x00CE60A4 File Offset: 0x00CE42A4
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

		// Token: 0x0602E3EA RID: 189418 RVA: 0x00CE6110 File Offset: 0x00CE4310
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

		// Token: 0x04018A01 RID: 100865
		[Nullable(2)]
		public GeneralContext Context;

		// Token: 0x04018A02 RID: 100866
		private readonly List<DeliverSlotData> SlotDataList = new List<DeliverSlotData>();

		// Token: 0x04018A03 RID: 100867
		public string NpcName = "";

		// Token: 0x04018A04 RID: 100868
		[Nullable(2)]
		public string TitleTextId;

		// Token: 0x04018A05 RID: 100869
		[Nullable(2)]
		public string DescriptionTextId;
	}
}
