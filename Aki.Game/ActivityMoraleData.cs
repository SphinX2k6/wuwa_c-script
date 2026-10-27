using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;

// Token: 0x0200136D RID: 4973
[NullableContext(1)]
[Nullable(0)]
public class ActivityMoraleData : ActivityBaseData
{
	// Token: 0x06008AB2 RID: 35506 RVA: 0x001DA160 File Offset: 0x001D8360
	protected override bool GetExDataFinishShowState()
	{
		MoraleModel instance = MoraleModel.Instance;
		return instance.IsAllScoreBoxRewardReceived() && instance.IsAllAreaFlagRewardReceived();
	}

	// Token: 0x06008AB3 RID: 35507 RVA: 0x001DA188 File Offset: 0x001D8388
	public override bool GetExDataRedPointShowState()
	{
		MoraleModel instance = MoraleModel.Instance;
		return instance.RedDotScoreBox() || instance.RedDotAreaBuff() || instance.RedDotFlagBox();
	}

	// Token: 0x06008AB4 RID: 35508 RVA: 0x001DA1B5 File Offset: 0x001D83B5
	public override ERedDotName? GetExternalButtonRedPointName()
	{
		return new ERedDotName?(ERedDotName.Morale);
	}

	// Token: 0x06008AB5 RID: 35509 RVA: 0x001DA1C4 File Offset: 0x001D83C4
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

	// Token: 0x06008AB6 RID: 35510 RVA: 0x001DA207 File Offset: 0x001D8407
	public ActivityMoraleController GetController()
	{
		return (ActivityMoraleController)ActivityManager.GetActivityController(base.Type);
	}
}
