using System;
using CSharpScript.Game.Common.Event;

// Token: 0x0200342A RID: 13354
public class IntroductionRedDot : RedDotBase
{
	// Token: 0x0601CDB0 RID: 118192 RVA: 0x0080CBA9 File Offset: 0x0080ADA9
	protected override void AddCheckEvent()
	{
		EventSystem.Instance.Add(EEventName.SdkIntroductionRedPointRefresh, new Action(base.EventCheck));
	}

	// Token: 0x0601CDB1 RID: 118193 RVA: 0x0080CBC7 File Offset: 0x0080ADC7
	protected override void RemoveCheckEvent()
	{
		EventSystem.Instance.Remove(EEventName.SdkIntroductionRedPointRefresh, new Action(base.EventCheck));
	}

	// Token: 0x0601CDB2 RID: 118194 RVA: 0x0080CBE5 File Offset: 0x0080ADE5
	protected override bool OnCheck(int uId = 0)
	{
		return KuroSdkModel.Instance.IntroductionNoticeState;
	}
}
