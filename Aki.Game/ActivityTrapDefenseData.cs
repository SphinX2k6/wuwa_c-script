using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.TrapDefense;

// Token: 0x020009E8 RID: 2536
public class ActivityTrapDefenseData : ActivityBaseData
{
	// Token: 0x06006EA8 RID: 28328 RVA: 0x00221874 File Offset: 0x0021FA74
	public override bool GetExDataRedPointShowState()
	{
		RedDotBase redDot = RedDotModel.Instance.GetRedDot(ERedDotName.TrapDefense);
		return (redDot != null && redDot.IsRedDotActive()) || TrapDefenseModel.Instance.RougeModeData.IsShowRougeModeTipsToActivity();
	}

	// Token: 0x06006EA9 RID: 28329 RVA: 0x002218B0 File Offset: 0x0021FAB0
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

	// Token: 0x06006EAA RID: 28330 RVA: 0x00221994 File Offset: 0x0021FB94
	protected override bool GetExDataFinishShowState()
	{
		return TrapDefenseModel.Instance.RewardData.IsFixedRewardAllClaimed();
	}
}
