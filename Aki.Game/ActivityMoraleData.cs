using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;

// Token: 0x02000821 RID: 2081
[NullableContext(1)]
[Nullable(0)]
public class ActivityMoraleData : ActivityBaseData
{
	// Token: 0x06005E4D RID: 24141 RVA: 0x001E2FBC File Offset: 0x001E11BC
	protected override bool GetExDataFinishShowState()
	{
		MoraleModel instance = MoraleModel.Instance;
		return instance.IsAllScoreBoxRewardReceived() && instance.IsAllAreaFlagRewardReceived();
	}

	// Token: 0x06005E4E RID: 24142 RVA: 0x001E2FE4 File Offset: 0x001E11E4
	public override bool GetExDataRedPointShowState()
	{
		MoraleModel instance = MoraleModel.Instance;
		return instance.RedDotScoreBox() || instance.RedDotAreaBuff() || instance.RedDotFlagBox();
	}

	// Token: 0x06005E4F RID: 24143 RVA: 0x001E3011 File Offset: 0x001E1211
	public override ERedDotName? GetExternalButtonRedPointName()
	{
		return new ERedDotName?(ERedDotName.Morale);
	}

	// Token: 0x06005E50 RID: 24144 RVA: 0x001E3020 File Offset: 0x001E1220
	protected override void PhraseEx(ActivityData data)
	{
		MoraleActivityData moraleActivityData = data.MoraleActivityData;
		if (moraleActivityData == null)
		{
			return;
		}
		MoraleModel.Instance.InitActivityData(moraleActivityData);
		EventSystem.Instance.Emit(EEventName.RedDotUpdateMoraleScoreBox);
		EventSystem.Instance.Emit(EEventName.RedDotUpdateMoraleFlagBox);
	}

	// Token: 0x06005E51 RID: 24145 RVA: 0x001E3063 File Offset: 0x001E1263
	public ActivityMoraleController GetController()
	{
		return (ActivityMoraleController)ActivityManager.GetActivityController(base.Type);
	}
}
