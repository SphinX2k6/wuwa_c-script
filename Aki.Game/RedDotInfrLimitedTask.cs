using System;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Infrastructure;

// Token: 0x020033AD RID: 13229
public class RedDotInfrLimitedTask : RedDotBase
{
	// Token: 0x0601CB5A RID: 117594 RVA: 0x00807EBE File Offset: 0x008060BE
	protected override ERedDotName? OnGetParentName()
	{
		return new ERedDotName?(ERedDotName.Infrastructure);
	}

	// Token: 0x0601CB5B RID: 117595 RVA: 0x00807ECA File Offset: 0x008060CA
	protected override void AddCheckEvent()
	{
		EventSystem.Instance.Add(EEventName.InfrastructureActivityTaskDataUpdate, new Action(base.EventCheck));
	}

	// Token: 0x0601CB5C RID: 117596 RVA: 0x00807EE8 File Offset: 0x008060E8
	protected override void RemoveCheckEvent()
	{
		EventSystem.Instance.Remove(EEventName.InfrastructureActivityTaskDataUpdate, new Action(base.EventCheck));
	}

	// Token: 0x0601CB5D RID: 117597 RVA: 0x00807F06 File Offset: 0x00806106
	protected override bool OnCheck(int uId = 0)
	{
		InfrastructureActivityData activityData = InfrastructureModel.Instance.GetActivityData();
		return activityData != null && activityData.GetLimitedTaskReadDot();
	}
}
