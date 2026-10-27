using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;

namespace CSharpScript.Game.Module.VillageInfr
{
	// Token: 0x02004868 RID: 18536
	[NullableContext(1)]
	[Nullable(0)]
	public class VillageInfrActivityData : ActivityBaseData
	{
		// Token: 0x0603085B RID: 198747 RVA: 0x00B44579 File Offset: 0x00B42779
		protected override void OnInit(ActivityData data)
		{
		}

		// Token: 0x0603085C RID: 198748 RVA: 0x00B4457B File Offset: 0x00B4277B
		protected override void PhraseEx(ActivityData data)
		{
		}

		// Token: 0x0603085D RID: 198749 RVA: 0x00B4457D File Offset: 0x00B4277D
		public override bool GetExDataRedPointShowState()
		{
			return this.CheckRedDot();
		}

		// Token: 0x0603085E RID: 198750 RVA: 0x00B44588 File Offset: 0x00B42788
		public bool CheckRedDot()
		{
			if (!base.IsUnLock())
			{
				return false;
			}
			VillageInfrModel instance = VillageInfrModel.Instance;
			return instance.HasTreeCanLevelUp() || instance.GetCanVillageLevelUp() || instance.HasScoreReward() || instance.GetTaskRedDot();
		}

		// Token: 0x0603085F RID: 198751 RVA: 0x00B445C8 File Offset: 0x00B427C8
		protected override bool GetExDataFinishShowState()
		{
			VillageInfrModel instance = VillageInfrModel.Instance;
			VillageInfrConfig instance2 = VillageInfrConfig.Instance;
			bool flag = false;
			using (List<IVillageInfrTreeData>.Enumerator enumerator = instance.GetAllTreeData().GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					if (enumerator.Current.Status != InfrV2StatusPb.InfrV2StatusComplete)
					{
						flag = true;
						break;
					}
				}
			}
			if (flag)
			{
				return false;
			}
			if (instance.GetVillageLevel() < instance2.GetInfrMaxLevel())
			{
				return false;
			}
			bool flag2 = false;
			foreach (InfrV2ScoreReward infrV2ScoreReward in instance2.GetScoreReward())
			{
				if (!instance.IsScoreRewardReceived(infrV2ScoreReward.Id))
				{
					flag2 = true;
					break;
				}
			}
			if (flag2)
			{
				return false;
			}
			bool flag3 = false;
			using (List<VillageInfrLimitTaskData>.Enumerator enumerator3 = instance.GetActivityTaskDataList().GetEnumerator())
			{
				while (enumerator3.MoveNext())
				{
					if (enumerator3.Current.Status != ConditionTaskState.ConditionTaskTaken)
					{
						flag3 = true;
						break;
					}
				}
			}
			return !flag3;
		}

		// Token: 0x06030860 RID: 198752 RVA: 0x00B446EC File Offset: 0x00B428EC
		public override ERedDotName? GetExternalButtonRedPointName()
		{
			return new ERedDotName?(ERedDotName.VillageInfr);
		}
	}
}
