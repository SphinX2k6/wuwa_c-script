using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;

namespace CSharpScript.Game.Module.VillageInfr
{
	// Token: 0x020037DF RID: 14303
	[NullableContext(1)]
	[Nullable(0)]
	public class VillageInfrActivityData : ActivityBaseData
	{
		// Token: 0x06025387 RID: 152455 RVA: 0x00A7F315 File Offset: 0x00A7D515
		protected override void OnInit(ActivityData data)
		{
		}

		// Token: 0x06025388 RID: 152456 RVA: 0x00A7F317 File Offset: 0x00A7D517
		protected override void PhraseEx(ActivityData data)
		{
		}

		// Token: 0x06025389 RID: 152457 RVA: 0x00A7F319 File Offset: 0x00A7D519
		public override bool GetExDataRedPointShowState()
		{
			return this.CheckRedDot();
		}

		// Token: 0x0602538A RID: 152458 RVA: 0x00A7F324 File Offset: 0x00A7D524
		public bool CheckRedDot()
		{
			if (!base.IsUnLock())
			{
				return false;
			}
			VillageInfrModel instance = VillageInfrModel.Instance;
			return instance.HasTreeCanLevelUp() || instance.GetCanVillageLevelUp() || instance.HasScoreReward() || instance.GetTaskRedDot();
		}

		// Token: 0x0602538B RID: 152459 RVA: 0x00A7F364 File Offset: 0x00A7D564
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

		// Token: 0x0602538C RID: 152460 RVA: 0x00A7F488 File Offset: 0x00A7D688
		public override ERedDotName? GetExternalButtonRedPointName()
		{
			return new ERedDotName?(ERedDotName.VillageInfr);
		}
	}
}
