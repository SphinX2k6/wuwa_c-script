using System;
using CSharpScript.Game.Common.Event;

// Token: 0x0200290E RID: 10510
public class RedDotFunctionNotice : RedDotBase
{
	// Token: 0x0601A800 RID: 108544 RVA: 0x0082DA8F File Offset: 0x0082BC8F
	protected override ERedDotName? OnGetParentName()
	{
		return new ERedDotName?(ERedDotName.BattleViewResonanceButton);
	}

	// Token: 0x0601A801 RID: 108545 RVA: 0x0082DA97 File Offset: 0x0082BC97
	protected override void AddCheckEvent()
	{
		EventSystem.Instance.Add(EEventName.SdkPostWebViewRedPointRefresh, new Action(base.EventCheck));
	}

	// Token: 0x0601A802 RID: 108546 RVA: 0x0082DAB5 File Offset: 0x0082BCB5
	protected override void RemoveCheckEvent()
	{
		EventSystem.Instance.Remove(EEventName.SdkPostWebViewRedPointRefresh, new Action(base.EventCheck));
	}

	// Token: 0x0601A803 RID: 108547 RVA: 0x0082DAD3 File Offset: 0x0082BCD3
	protected override bool OnCheck(int uId = 0)
	{
		return KuroSdkController.Instance.GetPostWebViewRedPointState();
	}
}
