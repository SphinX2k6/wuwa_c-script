using System;
using CSharpScript.Game.Common.Event;

// Token: 0x020033CE RID: 13262
public class RedDotMotorcycleDiyTab : RedDotBase
{
	// Token: 0x0601CBF2 RID: 117746 RVA: 0x00809265 File Offset: 0x00807465
	protected override bool IsMultiple()
	{
		return true;
	}

	// Token: 0x0601CBF3 RID: 117747 RVA: 0x00809268 File Offset: 0x00807468
	protected override void AddCheckEvent()
	{
		EventSystem.Instance.Add(EEventName.MotorDiyInfoUpdate, new Action(base.EventCheck));
		EventSystem.Instance.Add(EEventName.MotorDiyInfoRedDotUpdate, new Action(base.EventCheck));
		EventSystem.Instance.Add(EEventName.MotorDiySceneItemUpdate, new Action(base.EventCheck));
	}

	// Token: 0x0601CBF4 RID: 117748 RVA: 0x008092CC File Offset: 0x008074CC
	protected override void RemoveCheckEvent()
	{
		EventSystem.Instance.Remove(EEventName.MotorDiyInfoUpdate, new Action(base.EventCheck));
		EventSystem.Instance.Remove(EEventName.MotorDiyInfoRedDotUpdate, new Action(base.EventCheck));
		EventSystem.Instance.Remove(EEventName.MotorDiySceneItemUpdate, new Action(base.EventCheck));
	}

	// Token: 0x0601CBF5 RID: 117749 RVA: 0x0080932D File Offset: 0x0080752D
	protected override bool OnCheck(int uId = 0)
	{
		return MotorcycleDiyModel.Instance.RedDotForDiyTab();
	}
}
