using System;
using CSharpScript.Game.Common.Event;

// Token: 0x0200339C RID: 13212
public class RedDotFunctionNotice : RedDotBase
{
	// Token: 0x0601CB08 RID: 117512 RVA: 0x008074CB File Offset: 0x008056CB
	protected override ERedDotName? OnGetParentName()
	{
		return new ERedDotName?(ERedDotName.BattleViewResonanceButton);
	}

	// Token: 0x0601CB09 RID: 117513 RVA: 0x008074D3 File Offset: 0x008056D3
	protected override void AddCheckEvent()
	{
		EventSystem.Instance.Add(EEventName.SdkPostWebViewRedPointRefresh, new Action(base.EventCheck));
	}

	// Token: 0x0601CB0A RID: 117514 RVA: 0x008074F1 File Offset: 0x008056F1
	protected override void RemoveCheckEvent()
	{
		EventSystem.Instance.Remove(EEventName.SdkPostWebViewRedPointRefresh, new Action(base.EventCheck));
	}

	// Token: 0x0601CB0B RID: 117515 RVA: 0x0080750F File Offset: 0x0080570F
	protected override bool OnCheck(int uId = 0)
	{
		return KuroSdkController.Instance.GetPostWebViewRedPointState();
	}
}
