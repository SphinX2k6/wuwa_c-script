using System;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Infrastructure;

// Token: 0x0200291F RID: 10527
public class RedDotInfrLimitedTask : RedDotBase
{
	// Token: 0x0601A852 RID: 108626 RVA: 0x0082E482 File Offset: 0x0082C682
	protected override ERedDotName? OnGetParentName()
	{
		return new ERedDotName?(ERedDotName.Infrastructure);
	}

	// Token: 0x0601A853 RID: 108627 RVA: 0x0082E48E File Offset: 0x0082C68E
	protected override void AddCheckEvent()
	{
		EventSystem.Instance.Add(EEventName.InfrastructureActivityTaskDataUpdate, new Action(base.EventCheck));
	}

	// Token: 0x0601A854 RID: 108628 RVA: 0x0082E4AC File Offset: 0x0082C6AC
	protected override void RemoveCheckEvent()
	{
		EventSystem.Instance.Remove(EEventName.InfrastructureActivityTaskDataUpdate, new Action(base.EventCheck));
	}

	// Token: 0x0601A855 RID: 108629 RVA: 0x0082E4CA File Offset: 0x0082C6CA
	protected override bool OnCheck(int uId = 0)
	{
		InfrastructureActivityData activityData = InfrastructureModel.Instance.GetActivityData();
		return activityData != null && activityData.GetLimitedTaskReadDot();
	}
}
