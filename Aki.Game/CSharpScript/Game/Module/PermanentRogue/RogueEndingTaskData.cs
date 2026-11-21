using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Module.Inventory;
using CSharpScript.Game.Module.Reward;

namespace CSharpScript.Game.Module.PermanentRogue
{
	// Token: 0x020042D0 RID: 17104
	public class RogueEndingTaskData
	{
		// Token: 0x0602B4DA RID: 177370 RVA: 0x00C2A304 File Offset: 0x00C28504
		public RogueEndingTaskData(int id)
		{
			this.Id = id;
		}

		// Token: 0x0602B4DB RID: 177371 RVA: 0x00C2A31A File Offset: 0x00C2851A
		public bool IsFinished()
		{
			return this.Status == ActivityTaskState.ActivityTaskFinish;
		}

		// Token: 0x0602B4DC RID: 177372 RVA: 0x00C2A325 File Offset: 0x00C28525
		public bool IsTaken()
		{
			return this.Status == ActivityTaskState.ActivityTaskTaken;
		}

		// Token: 0x0602B4DD RID: 177373 RVA: 0x00C2A330 File Offset: 0x00C28530
		[NullableContext(1)]
		public List<TItem> GetRewardList()
		{
			RogueResTask value = ConfigRogueResTaskById.GetConfig(this.Id, true).Value;
			DropPackage value2 = CSharpScript.Game.Module.Reward.RewardConfig.Instance.GetDropPackage(value.Award).Value;
			List<TItem> list = new List<TItem>();
			foreach (DicIntInt dicIntInt in value2.DropPreviewIter())
			{
				list.Add(new TItem(new InventoryDefine.GetItemData(dicIntInt.Key, 0), dicIntInt.Value));
			}
			return list;
		}

		// Token: 0x040175A4 RID: 95652
		public ActivityTaskState Status;

		// Token: 0x040175A5 RID: 95653
		public readonly int Id;

		// Token: 0x040175A6 RID: 95654
		public int Current;

		// Token: 0x040175A7 RID: 95655
		public int Target = 1;
	}
}
