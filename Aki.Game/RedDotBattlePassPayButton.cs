using System;
using CSharpScript.Game.Common.Event;

// Token: 0x020028D5 RID: 10453
public class RedDotBattlePassPayButton : RedDotBase
{
	// Token: 0x0601A705 RID: 108293 RVA: 0x0082BC85 File Offset: 0x00829E85
	protected override ERedDotName? OnGetParentName()
	{
		return new ERedDotName?(ERedDotName.BattlePass);
	}

	// Token: 0x0601A706 RID: 108294 RVA: 0x0082BC8E File Offset: 0x00829E8E
	protected override bool OnCheck(int uId = 0)
	{
		return (BattlePassModel.Instance.PayButtonRedDotState || !BattlePassModel.Instance.HadEnter) && BattlePassModel.Instance.GetInTimeRange();
	}

	// Token: 0x0601A707 RID: 108295 RVA: 0x0082BCB4 File Offset: 0x00829EB4
	protected override void AddCheckEvent()
	{
		EventSystem.Instance.Add(EEventName.BattlePassHadEnterUpdate, new Action(base.EventCheck));
	}

	// Token: 0x0601A708 RID: 108296 RVA: 0x0082BCD2 File Offset: 0x00829ED2
	protected override void RemoveCheckEvent()
	{
		EventSystem.Instance.Remove(EEventName.BattlePassHadEnterUpdate, new Action(base.EventCheck));
	}

	// Token: 0x0601A709 RID: 108297 RVA: 0x0082BCF0 File Offset: 0x00829EF0
	protected override void AddActiveEvents()
	{
		EventSystem.Instance.Add(EEventName.UpdateBattlePassTaskEvent, new Action(base.OnActiveEvent));
	}

	// Token: 0x0601A70A RID: 108298 RVA: 0x0082BD0E File Offset: 0x00829F0E
	protected override void AddDisActiveEvents()
	{
		EventSystem.Instance.Add(EEventName.OnBattlePassExpireEvent, new Action(base.OnDisActiveEvent));
	}
}
