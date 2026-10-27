using System;
using CSharpScript.Game.Common.Event;

// Token: 0x020033D9 RID: 13273
public class RedDotMotorcycleDiyDecorationTab : RedDotBase
{
	// Token: 0x0601CC2C RID: 117804 RVA: 0x0080996D File Offset: 0x00807B6D
	protected override bool IsMultiple()
	{
		return true;
	}

	// Token: 0x0601CC2D RID: 117805 RVA: 0x00809970 File Offset: 0x00807B70
	protected override void AddCheckEvent()
	{
		EventSystem.Instance.Add(EEventName.MotorDiyInfoUpdate, new Action(base.EventCheck));
		EventSystem.Instance.Add(EEventName.MotorDiyInfoRedDotUpdate, new Action(base.EventCheck));
	}

	// Token: 0x0601CC2E RID: 117806 RVA: 0x008099AA File Offset: 0x00807BAA
	protected override void RemoveCheckEvent()
	{
		EventSystem.Instance.Remove(EEventName.MotorDiyInfoUpdate, new Action(base.EventCheck));
		EventSystem.Instance.Remove(EEventName.MotorDiyInfoRedDotUpdate, new Action(base.EventCheck));
	}

	// Token: 0x0601CC2F RID: 117807 RVA: 0x008099E4 File Offset: 0x00807BE4
	protected override bool OnCheck(int uId = 0)
	{
		return !MotorcycleDiyModel.Instance.RedDotIsPreviewInAnyPart(EOutlookType.Decoration) && MotorcycleDiyModel.Instance.RedDotHasNewDecorationByAnyPart();
	}
}
