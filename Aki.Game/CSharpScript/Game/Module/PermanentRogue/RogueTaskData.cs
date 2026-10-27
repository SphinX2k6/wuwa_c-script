using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Module.Inventory;
using CSharpScript.Game.Module.Reward;

namespace CSharpScript.Game.Module.PermanentRogue
{
	// Token: 0x020052FF RID: 21247
	public class RogueTaskData
	{
		// Token: 0x060365DA RID: 222682 RVA: 0x00CDC863 File Offset: 0x00CDAA63
		public RogueTaskData(int id)
		{
			this.Id = id;
		}

		// Token: 0x060365DB RID: 222683 RVA: 0x00CDC879 File Offset: 0x00CDAA79
		public bool IsFinished()
		{
			return this.Status == ActivityTaskState.ActivityTaskFinish;
		}

		// Token: 0x060365DC RID: 222684 RVA: 0x00CDC884 File Offset: 0x00CDAA84
		public bool IsTaken()
		{
			return this.Status == ActivityTaskState.ActivityTaskTaken;
		}

		// Token: 0x060365DD RID: 222685 RVA: 0x00CDC890 File Offset: 0x00CDAA90
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

		// Token: 0x0401CB6A RID: 117610
		public ActivityTaskState Status;

		// Token: 0x0401CB6B RID: 117611
		public readonly int Id;

		// Token: 0x0401CB6C RID: 117612
		public int Current;

		// Token: 0x0401CB6D RID: 117613
		public int Target = 1;
	}
}
