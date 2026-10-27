using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Quest;

namespace CSharpScript.Game.Module.ItemDeliver
{
	// Token: 0x02005811 RID: 22545
	[NullableContext(1)]
	[Nullable(0)]
	public class DeliverSlotData
	{
		// Token: 0x060394D7 RID: 234711 RVA: 0x00D972DC File Offset: 0x00D954DC
		public void Initialize(List<int> itemIdList, int needCount, EHandInItemType handInType)
		{
			this.ItemRangeList = itemIdList;
			this.ItemRangeSet = new HashSet<int>(itemIdList);
			this.NeedCount = needCount;
			this.HandInType = handInType;
			this.CurrentItemConfigId = 0;
			this.CurrentCount = 0;
		}

		// Token: 0x060394D8 RID: 234712 RVA: 0x00D9730D File Offset: 0x00D9550D
		public bool SetItem(int itemConfigId, int count)
		{
			if (!this.CanSet(itemConfigId))
			{
				return false;
			}
			this.CurrentItemConfigId = itemConfigId;
			this.CurrentCount = count;
			return true;
		}

		// Token: 0x060394D9 RID: 234713 RVA: 0x00D97329 File Offset: 0x00D95529
		public void ClearItem()
		{
			this.CurrentItemConfigId = 0;
			this.CurrentCount = 0;
		}

		// Token: 0x060394DA RID: 234714 RVA: 0x00D97339 File Offset: 0x00D95539
		public bool CanSet(int itemConfigId)
		{
			return (this.CurrentItemConfigId <= 0 || this.CurrentItemConfigId == itemConfigId) && this.ItemRangeSet.Contains(itemConfigId);
		}

		// Token: 0x060394DB RID: 234715 RVA: 0x00D97360 File Offset: 0x00D95560
		public bool IsEnough()
		{
			return this.CurrentCount >= this.NeedCount;
		}

		// Token: 0x060394DC RID: 234716 RVA: 0x00D97373 File Offset: 0x00D95573
		public bool HasItem()
		{
			return this.CurrentItemConfigId > 0;
		}

		// Token: 0x060394DD RID: 234717 RVA: 0x00D9737E File Offset: 0x00D9557E
		public IReadOnlySet<int> GetItemRangeSet()
		{
			return this.ItemRangeSet;
		}

		// Token: 0x060394DE RID: 234718 RVA: 0x00D97386 File Offset: 0x00D95586
		public IReadOnlyList<int> GetItemRangeList()
		{
			return this.ItemRangeList;
		}

		// Token: 0x060394DF RID: 234719 RVA: 0x00D9738E File Offset: 0x00D9558E
		public int GetNeedCount()
		{
			return this.NeedCount;
		}

		// Token: 0x060394E0 RID: 234720 RVA: 0x00D97396 File Offset: 0x00D95596
		public int GetCurrentItemConfigId()
		{
			return this.CurrentItemConfigId;
		}

		// Token: 0x060394E1 RID: 234721 RVA: 0x00D9739E File Offset: 0x00D9559E
		public int GetCurrentCount()
		{
			return this.CurrentCount;
		}

		// Token: 0x060394E2 RID: 234722 RVA: 0x00D973A6 File Offset: 0x00D955A6
		public void SetCurrentCount(int count)
		{
			this.CurrentCount = count;
		}

		// Token: 0x0401DF6F RID: 122735
		private List<int> ItemRangeList = new List<int>();

		// Token: 0x0401DF70 RID: 122736
		private HashSet<int> ItemRangeSet = new HashSet<int>();

		// Token: 0x0401DF71 RID: 122737
		private int NeedCount;

		// Token: 0x0401DF72 RID: 122738
		public EHandInItemType HandInType;

		// Token: 0x0401DF73 RID: 122739
		private int CurrentItemConfigId;

		// Token: 0x0401DF74 RID: 122740
		private int CurrentCount;
	}
}
