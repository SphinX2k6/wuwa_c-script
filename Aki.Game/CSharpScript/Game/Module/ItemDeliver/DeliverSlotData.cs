using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Quest;

namespace CSharpScript.Game.Module.ItemDeliver
{
	// Token: 0x020047E8 RID: 18408
	[NullableContext(1)]
	[Nullable(0)]
	public class DeliverSlotData
	{
		// Token: 0x0602E3EB RID: 189419 RVA: 0x00CE616C File Offset: 0x00CE436C
		public void Initialize(List<int> itemIdList, int needCount, EHandInItemType handInType)
		{
			this.ItemRangeList = itemIdList;
			this.ItemRangeSet = new HashSet<int>(itemIdList);
			this.NeedCount = needCount;
			this.HandInType = handInType;
			this.CurrentItemConfigId = 0;
			this.CurrentCount = 0;
		}

		// Token: 0x0602E3EC RID: 189420 RVA: 0x00CE619D File Offset: 0x00CE439D
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

		// Token: 0x0602E3ED RID: 189421 RVA: 0x00CE61B9 File Offset: 0x00CE43B9
		public void ClearItem()
		{
			this.CurrentItemConfigId = 0;
			this.CurrentCount = 0;
		}

		// Token: 0x0602E3EE RID: 189422 RVA: 0x00CE61C9 File Offset: 0x00CE43C9
		public bool CanSet(int itemConfigId)
		{
			return (this.CurrentItemConfigId <= 0 || this.CurrentItemConfigId == itemConfigId) && this.ItemRangeSet.Contains(itemConfigId);
		}

		// Token: 0x0602E3EF RID: 189423 RVA: 0x00CE61F0 File Offset: 0x00CE43F0
		public bool IsEnough()
		{
			return this.CurrentCount >= this.NeedCount;
		}

		// Token: 0x0602E3F0 RID: 189424 RVA: 0x00CE6203 File Offset: 0x00CE4403
		public bool HasItem()
		{
			return this.CurrentItemConfigId > 0;
		}

		// Token: 0x0602E3F1 RID: 189425 RVA: 0x00CE620E File Offset: 0x00CE440E
		public IReadOnlySet<int> GetItemRangeSet()
		{
			return this.ItemRangeSet;
		}

		// Token: 0x0602E3F2 RID: 189426 RVA: 0x00CE6216 File Offset: 0x00CE4416
		public IReadOnlyList<int> GetItemRangeList()
		{
			return this.ItemRangeList;
		}

		// Token: 0x0602E3F3 RID: 189427 RVA: 0x00CE621E File Offset: 0x00CE441E
		public int GetNeedCount()
		{
			return this.NeedCount;
		}

		// Token: 0x0602E3F4 RID: 189428 RVA: 0x00CE6226 File Offset: 0x00CE4426
		public int GetCurrentItemConfigId()
		{
			return this.CurrentItemConfigId;
		}

		// Token: 0x0602E3F5 RID: 189429 RVA: 0x00CE622E File Offset: 0x00CE442E
		public int GetCurrentCount()
		{
			return this.CurrentCount;
		}

		// Token: 0x0602E3F6 RID: 189430 RVA: 0x00CE6236 File Offset: 0x00CE4436
		public void SetCurrentCount(int count)
		{
			this.CurrentCount = count;
		}

		// Token: 0x04018A06 RID: 100870
		private List<int> ItemRangeList = new List<int>();

		// Token: 0x04018A07 RID: 100871
		private HashSet<int> ItemRangeSet = new HashSet<int>();

		// Token: 0x04018A08 RID: 100872
		private int NeedCount;

		// Token: 0x04018A09 RID: 100873
		public EHandInItemType HandInType;

		// Token: 0x04018A0A RID: 100874
		private int CurrentItemConfigId;

		// Token: 0x04018A0B RID: 100875
		private int CurrentCount;
	}
}
