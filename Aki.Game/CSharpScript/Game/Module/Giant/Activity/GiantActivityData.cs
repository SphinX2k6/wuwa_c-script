using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;

namespace CSharpScript.Game.Module.Giant.Activity
{
	// Token: 0x02004967 RID: 18791
	public class GiantActivityData : ActivityBaseData
	{
		// Token: 0x0602F1F9 RID: 193017 RVA: 0x00D233BC File Offset: 0x00D215BC
		[NullableContext(1)]
		protected override void PhraseEx(ActivityData data)
		{
			GiantActivityInfo giantActivityInfo = data.GiantActivityInfo;
			if (giantActivityInfo == null)
			{
				return;
			}
			GiantModel instance = GiantModel.Instance;
			if (instance == null)
			{
				return;
			}
			instance.SetActivityId(base.Id);
			instance.SetGotRewardIds(giantActivityInfo.GotRewardIds);
			instance.SetInteractedNodeIds(giantActivityInfo.ActiveIds);
			instance.SetTotalStableValue((double)giantActivityInfo.TotalStableValue);
		}

		// Token: 0x0602F1FA RID: 193018 RVA: 0x00D23410 File Offset: 0x00D21610
		public override bool GetExDataRedPointShowState()
		{
			if (!base.GetPreGuideQuestFinishState())
			{
				return false;
			}
			if (GiantModel.Instance == null)
			{
				return false;
			}
			foreach (GiantEcoNetType eco in new GiantEcoNetType[]
			{
				GiantEcoNetType.Fire,
				GiantEcoNetType.Water,
				GiantEcoNetType.Wood
			})
			{
				if (GiantConfig.CanEcoLevelUp(eco) || GiantConfig.HasNewAccessForEco(eco))
				{
					return true;
				}
			}
			return GiantConfig.HasClaimableNode() || GiantConfig.HasUnreadActivatedNode();
		}

		// Token: 0x0602F1FB RID: 193019 RVA: 0x00D23471 File Offset: 0x00D21671
		protected override bool GetExDataFinishShowState()
		{
			return GiantConfig.IsActivityAllFinished();
		}
	}
}
