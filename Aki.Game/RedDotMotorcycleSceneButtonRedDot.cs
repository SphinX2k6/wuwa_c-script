using System;
using CSharpScript.Game.Common.Event;

// Token: 0x020033D0 RID: 13264
public class RedDotMotorcycleSceneButtonRedDot : RedDotBase
{
	// Token: 0x0601CBFC RID: 117756 RVA: 0x00809394 File Offset: 0x00807594
	protected override ERedDotName? OnGetParentName()
	{
		return new ERedDotName?(ERedDotName.FunctionMotorDevelop);
	}

	// Token: 0x0601CBFD RID: 117757 RVA: 0x0080939D File Offset: 0x0080759D
	protected override void AddCheckEvent()
	{
		EventSystem.Instance.Add(EEventName.MotorDiySceneItemUpdate, new Action(base.EventCheck));
	}

	// Token: 0x0601CBFE RID: 117758 RVA: 0x008093BB File Offset: 0x008075BB
	protected override void RemoveCheckEvent()
	{
		EventSystem.Instance.Remove(EEventName.MotorDiySceneItemUpdate, new Action(base.EventCheck));
	}

	// Token: 0x0601CBFF RID: 117759 RVA: 0x008093D9 File Offset: 0x008075D9
	protected override bool OnCheck(int uId = 0)
	{
		return MotorcycleDiyModel.Instance.RedDotHasAnyNewScene();
	}
}
