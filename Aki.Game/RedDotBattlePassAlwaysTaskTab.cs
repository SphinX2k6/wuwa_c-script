using System;
using CSharpScript.Game.Common.Event;

// Token: 0x020028D3 RID: 10451
public class RedDotBattlePassAlwaysTaskTab : RedDotBase
{
	// Token: 0x0601A6F7 RID: 108279 RVA: 0x0082BB4B File Offset: 0x00829D4B
	protected override ERedDotName? OnGetParentName()
	{
		return new ERedDotName?(ERedDotName.BattlePassTask);
	}

	// Token: 0x0601A6F8 RID: 108280 RVA: 0x0082BB54 File Offset: 0x00829D54
	protected override bool OnCheck(int uId = 0)
	{
		return BattlePassModel.Instance.CheckHasTaskWaitTakeWithType(EBattlePassTaskUpdateState.Always);
	}

	// Token: 0x0601A6F9 RID: 108281 RVA: 0x0082BB61 File Offset: 0x00829D61
	protected override void AddCheckEvent()
	{
		EventSystem.Instance.Add(EEventName.UpdateBattlePassTaskEvent, new Action(base.EventCheck));
		EventSystem.Instance.Add<bool>(EEventName.ReceiveBattlePassTaskEvent, new Action<bool>(this.OnReceiveBattlePassTaskEvent));
	}

	// Token: 0x0601A6FA RID: 108282 RVA: 0x0082BB9B File Offset: 0x00829D9B
	protected override void RemoveCheckEvent()
	{
		EventSystem.Instance.Remove(EEventName.UpdateBattlePassTaskEvent, new Action(base.EventCheck));
		EventSystem.Instance.Remove<bool>(EEventName.ReceiveBattlePassTaskEvent, new Action<bool>(this.OnReceiveBattlePassTaskEvent));
	}

	// Token: 0x0601A6FB RID: 108283 RVA: 0x0082BBD5 File Offset: 0x00829DD5
	protected override bool IsAllEventParamAsUId()
	{
		return false;
	}

	// Token: 0x0601A6FC RID: 108284 RVA: 0x0082BBD8 File Offset: 0x00829DD8
	private void OnReceiveBattlePassTaskEvent(bool isWeekUpdate)
	{
		base.EventCheck();
	}
}
