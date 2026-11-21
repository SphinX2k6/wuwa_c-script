using System;
using CSharpScript.Game.Common.Event;

// Token: 0x0200299C RID: 10652
public class IntroductionRedDot : RedDotBase
{
	// Token: 0x0601AAA8 RID: 109224 RVA: 0x0083316D File Offset: 0x0083136D
	protected override void AddCheckEvent()
	{
		EventSystem.Instance.Add(EEventName.SdkIntroductionRedPointRefresh, new Action(base.EventCheck));
	}

	// Token: 0x0601AAA9 RID: 109225 RVA: 0x0083318B File Offset: 0x0083138B
	protected override void RemoveCheckEvent()
	{
		EventSystem.Instance.Remove(EEventName.SdkIntroductionRedPointRefresh, new Action(base.EventCheck));
	}

	// Token: 0x0601AAAA RID: 109226 RVA: 0x008331A9 File Offset: 0x008313A9
	protected override bool OnCheck(int uId = 0)
	{
		return KuroSdkModel.Instance.IntroductionNoticeState;
	}
}
