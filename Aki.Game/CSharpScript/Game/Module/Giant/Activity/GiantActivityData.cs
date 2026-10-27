using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;

namespace CSharpScript.Game.Module.Giant.Activity
{
	// Token: 0x0200598E RID: 22926
	public class GiantActivityData : ActivityBaseData
	{
		// Token: 0x0603A2D3 RID: 238291 RVA: 0x00DD3F2C File Offset: 0x00DD212C
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

		// Token: 0x0603A2D4 RID: 238292 RVA: 0x00DD3F80 File Offset: 0x00DD2180
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

		// Token: 0x0603A2D5 RID: 238293 RVA: 0x00DD3FE1 File Offset: 0x00DD21E1
		protected override bool GetExDataFinishShowState()
		{
			return GiantConfig.IsActivityAllFinished();
		}
	}
}
