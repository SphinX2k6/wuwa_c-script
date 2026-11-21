using System;
using CSharpScript.Game.Common.Event;

// Token: 0x020028D6 RID: 10454
public class RedDotBattlePassReward : RedDotBase
{
	// Token: 0x0601A70C RID: 108300 RVA: 0x0082BD34 File Offset: 0x00829F34
	protected override ERedDotName? OnGetParentName()
	{
		return new ERedDotName?(ERedDotName.BattlePass);
	}

	// Token: 0x0601A70D RID: 108301 RVA: 0x0082BD3D File Offset: 0x00829F3D
	protected override bool OnCheck(int uId = 0)
	{
		return BattlePassModel.Instance.CheckHasRewardWaitTake();
	}

	// Token: 0x0601A70E RID: 108302 RVA: 0x0082BD4C File Offset: 0x00829F4C
	protected override void AddCheckEvent()
	{
		EventSystem.Instance.Add<int?>(EEventName.GetBattlePassRewardEvent, new Action<int?>(this.OnGetBattlePassRewardEvent));
		EventSystem.Instance.Add(EEventName.ReceiveBattlePassDataEvent, new Action(base.EventCheck));
		EventSystem.Instance.Add(EEventName.OnBattlePassLevelUpEvent, new Action(base.EventCheck));
	}

	// Token: 0x0601A70F RID: 108303 RVA: 0x0082BDB0 File Offset: 0x00829FB0
	protected override void RemoveCheckEvent()
	{
		EventSystem.Instance.Remove<int?>(EEventName.GetBattlePassRewardEvent, new Action<int?>(this.OnGetBattlePassRewardEvent));
		EventSystem.Instance.Remove(EEventName.ReceiveBattlePassDataEvent, new Action(base.EventCheck));
		EventSystem.Instance.Remove(EEventName.OnBattlePassLevelUpEvent, new Action(base.EventCheck));
	}

	// Token: 0x0601A710 RID: 108304 RVA: 0x0082BE11 File Offset: 0x0082A011
	protected override bool IsAllEventParamAsUId()
	{
		return false;
	}

	// Token: 0x0601A711 RID: 108305 RVA: 0x0082BE14 File Offset: 0x0082A014
	private void OnGetBattlePassRewardEvent(int? gridIndex)
	{
		base.EventCheck();
	}
}
