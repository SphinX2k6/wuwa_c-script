using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Module.Inventory;
using CSharpScript.Game.Module.Reward;

namespace CSharpScript.Game.Module.PermanentRogue
{
	// Token: 0x02005300 RID: 21248
	public class RogueEndingTaskData
	{
		// Token: 0x060365DE RID: 222686 RVA: 0x00CDC934 File Offset: 0x00CDAB34
		public RogueEndingTaskData(int id)
		{
			this.Id = id;
		}

		// Token: 0x060365DF RID: 222687 RVA: 0x00CDC94A File Offset: 0x00CDAB4A
		public bool IsFinished()
		{
			return this.Status == ActivityTaskState.ActivityTaskFinish;
		}

		// Token: 0x060365E0 RID: 222688 RVA: 0x00CDC955 File Offset: 0x00CDAB55
		public bool IsTaken()
		{
			return this.Status == ActivityTaskState.ActivityTaskTaken;
		}

		// Token: 0x060365E1 RID: 222689 RVA: 0x00CDC960 File Offset: 0x00CDAB60
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

		// Token: 0x0401CB6E RID: 117614
		public ActivityTaskState Status;

		// Token: 0x0401CB6F RID: 117615
		public readonly int Id;

		// Token: 0x0401CB70 RID: 117616
		public int Current;

		// Token: 0x0401CB71 RID: 117617
		public int Target = 1;
	}
}
