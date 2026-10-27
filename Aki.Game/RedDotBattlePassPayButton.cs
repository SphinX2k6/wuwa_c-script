using System;
using CSharpScript.Game.Common.Event;

// Token: 0x02003363 RID: 13155
public class RedDotBattlePassPayButton : RedDotBase
{
	// Token: 0x0601CA0D RID: 117261 RVA: 0x008056C1 File Offset: 0x008038C1
	protected override ERedDotName? OnGetParentName()
	{
		return new ERedDotName?(ERedDotName.BattlePass);
	}

	// Token: 0x0601CA0E RID: 117262 RVA: 0x008056CA File Offset: 0x008038CA
	protected override bool OnCheck(int uId = 0)
	{
		return (BattlePassModel.Instance.PayButtonRedDotState || !BattlePassModel.Instance.HadEnter) && BattlePassModel.Instance.GetInTimeRange();
	}

	// Token: 0x0601CA0F RID: 117263 RVA: 0x008056F0 File Offset: 0x008038F0
	protected override void AddCheckEvent()
	{
		EventSystem.Instance.Add(EEventName.BattlePassHadEnterUpdate, new Action(base.EventCheck));
	}

	// Token: 0x0601CA10 RID: 117264 RVA: 0x0080570E File Offset: 0x0080390E
	protected override void RemoveCheckEvent()
	{
		EventSystem.Instance.Remove(EEventName.BattlePassHadEnterUpdate, new Action(base.EventCheck));
	}

	// Token: 0x0601CA11 RID: 117265 RVA: 0x0080572C File Offset: 0x0080392C
	protected override void AddActiveEvents()
	{
		EventSystem.Instance.Add(EEventName.UpdateBattlePassTaskEvent, new Action(base.OnActiveEvent));
	}

	// Token: 0x0601CA12 RID: 117266 RVA: 0x0080574A File Offset: 0x0080394A
	protected override void AddDisActiveEvents()
	{
		EventSystem.Instance.Add(EEventName.OnBattlePassExpireEvent, new Action(base.OnDisActiveEvent));
	}
}
