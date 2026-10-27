using System;
using CSharpScript.Game.Common.Event;

// Token: 0x020033D8 RID: 13272
public class RedDotMotorcycleDiyDecorationPreTab : RedDotBase
{
	// Token: 0x0601CC27 RID: 117799 RVA: 0x00809919 File Offset: 0x00807B19
	protected override bool IsMultiple()
	{
		return true;
	}

	// Token: 0x0601CC28 RID: 117800 RVA: 0x0080991C File Offset: 0x00807B1C
	protected override void AddCheckEvent()
	{
		EventSystem.Instance.Add(EEventName.MotorDiyInfoRedDotUpdate, new Action(base.EventCheck));
	}

	// Token: 0x0601CC29 RID: 117801 RVA: 0x0080993A File Offset: 0x00807B3A
	protected override void RemoveCheckEvent()
	{
		EventSystem.Instance.Remove(EEventName.MotorDiyInfoRedDotUpdate, new Action(base.EventCheck));
	}

	// Token: 0x0601CC2A RID: 117802 RVA: 0x00809958 File Offset: 0x00807B58
	protected override bool OnCheck(int uId = 0)
	{
		return MotorcycleDiyModel.Instance.RedDotIsPreviewInAnyPart(EOutlookType.Decoration);
	}
}
