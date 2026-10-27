using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.TrapDefense;

// Token: 0x02001530 RID: 5424
public class ActivityTrapDefenseData : ActivityBaseData
{
	// Token: 0x06009ACA RID: 39626 RVA: 0x00217AD4 File Offset: 0x00215CD4
	public override bool GetExDataRedPointShowState()
	{
		RedDotBase redDot = RedDotModel.Instance.GetRedDot(ERedDotName.TrapDefense);
		return (redDot != null && redDot.IsRedDotActive()) || TrapDefenseModel.Instance.RougeModeData.IsShowRougeModeTipsToActivity();
	}

	// Token: 0x06009ACB RID: 39627 RVA: 0x00217B10 File Offset: 0x00215D10
	[NullableContext(1)]
	protected override void PhraseEx(ActivityData data)
	{
		TrapDefenseActivityInfo trapDefenseActivityInfo = data.TrapDefenseActivityInfo;
		if (trapDefenseActivityInfo == null)
		{
			return;
		}
		TrapDefenseModel instance = TrapDefenseModel.Instance;
		if (instance != null)
		{
			instance.InitData(new int?(base.Id));
		}
		TrapDefenseModel instance2 = TrapDefenseModel.Instance;
		if (instance2 != null)
		{
			instance2.UpdateActivityData(trapDefenseActivityInfo);
		}
		EventSystem.Instance.Emit(EEventName.RedDotUpdateTrapDefenseRougeModeOpen);
		EventSystem.Instance.Emit(EEventName.RedDotUpdateTrapDefenseLevelModeLevelReachOpenTime);
		EventSystem.Instance.Emit(EEventName.RedDotUpdateTrapDefenseRougeModeLevelReachOpenTime);
		EventSystem.Instance.Emit(EEventName.RedDotUpdateTrapDefenseBdBuffNewUnlock);
		EventSystem.Instance.Emit(EEventName.RedDotUpdateTrapDefenseTalentTree);
		EventSystem.Instance.Emit(EEventName.RedDotUpdateTrapDefenseLimitReward);
		EventSystem.Instance.Emit(EEventName.RedDotUpdateTrapDefenseFixedReward);
		TrapDefenseController.Instance.IsActivityInited = true;
		TrapDefenseChallengeResultNotify resultNotifyCache = TrapDefenseController.Instance.ResultNotifyCache;
		if (resultNotifyCache != null)
		{
			TrapDefenseController.Instance.OpenDefenseChallengeResultView(resultNotifyCache, true);
			TrapDefenseController.Instance.ResultNotifyCache = null;
		}
	}

	// Token: 0x06009ACC RID: 39628 RVA: 0x00217BF4 File Offset: 0x00215DF4
	protected override bool GetExDataFinishShowState()
	{
		return TrapDefenseModel.Instance.RewardData.IsFixedRewardAllClaimed();
	}
}
