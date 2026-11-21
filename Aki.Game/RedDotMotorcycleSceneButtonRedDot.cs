using System;
using CSharpScript.Game.Common.Event;

// Token: 0x02002942 RID: 10562
public class RedDotMotorcycleSceneButtonRedDot : RedDotBase
{
	// Token: 0x0601A8F4 RID: 108788 RVA: 0x0082F958 File Offset: 0x0082DB58
	protected override ERedDotName? OnGetParentName()
	{
		return new ERedDotName?(ERedDotName.FunctionMotorDevelop);
	}

	// Token: 0x0601A8F5 RID: 108789 RVA: 0x0082F961 File Offset: 0x0082DB61
	protected override void AddCheckEvent()
	{
		EventSystem.Instance.Add(EEventName.MotorDiySceneItemUpdate, new Action(base.EventCheck));
	}

	// Token: 0x0601A8F6 RID: 108790 RVA: 0x0082F97F File Offset: 0x0082DB7F
	protected override void RemoveCheckEvent()
	{
		EventSystem.Instance.Remove(EEventName.MotorDiySceneItemUpdate, new Action(base.EventCheck));
	}

	// Token: 0x0601A8F7 RID: 108791 RVA: 0x0082F99D File Offset: 0x0082DB9D
	protected override bool OnCheck(int uId = 0)
	{
		return MotorcycleDiyModel.Instance.RedDotHasAnyNewScene();
	}
}
