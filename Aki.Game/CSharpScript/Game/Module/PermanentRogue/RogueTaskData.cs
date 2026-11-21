using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Module.Inventory;
using CSharpScript.Game.Module.Reward;

namespace CSharpScript.Game.Module.PermanentRogue
{
	// Token: 0x020042CF RID: 17103
	public class RogueTaskData
	{
		// Token: 0x0602B4D6 RID: 177366 RVA: 0x00C2A233 File Offset: 0x00C28433
		public RogueTaskData(int id)
		{
			this.Id = id;
		}

		// Token: 0x0602B4D7 RID: 177367 RVA: 0x00C2A249 File Offset: 0x00C28449
		public bool IsFinished()
		{
			return this.Status == ActivityTaskState.ActivityTaskFinish;
		}

		// Token: 0x0602B4D8 RID: 177368 RVA: 0x00C2A254 File Offset: 0x00C28454
		public bool IsTaken()
		{
			return this.Status == ActivityTaskState.ActivityTaskTaken;
		}

		// Token: 0x0602B4D9 RID: 177369 RVA: 0x00C2A260 File Offset: 0x00C28460
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

		// Token: 0x040175A0 RID: 95648
		public ActivityTaskState Status;

		// Token: 0x040175A1 RID: 95649
		public readonly int Id;

		// Token: 0x040175A2 RID: 95650
		public int Current;

		// Token: 0x040175A3 RID: 95651
		public int Target = 1;
	}
}
