using System;
using CSharpScript.Game.Common.Event;

// Token: 0x0200294B RID: 10571
public class RedDotMotorcycleDiyDecorationTab : RedDotBase
{
	// Token: 0x0601A924 RID: 108836 RVA: 0x0082FF31 File Offset: 0x0082E131
	protected override bool IsMultiple()
	{
		return true;
	}

	// Token: 0x0601A925 RID: 108837 RVA: 0x0082FF34 File Offset: 0x0082E134
	protected override void AddCheckEvent()
	{
		EventSystem.Instance.Add(EEventName.MotorDiyInfoUpdate, new Action(base.EventCheck));
		EventSystem.Instance.Add(EEventName.MotorDiyInfoRedDotUpdate, new Action(base.EventCheck));
	}

	// Token: 0x0601A926 RID: 108838 RVA: 0x0082FF6E File Offset: 0x0082E16E
	protected override void RemoveCheckEvent()
	{
		EventSystem.Instance.Remove(EEventName.MotorDiyInfoUpdate, new Action(base.EventCheck));
		EventSystem.Instance.Remove(EEventName.MotorDiyInfoRedDotUpdate, new Action(base.EventCheck));
	}

	// Token: 0x0601A927 RID: 108839 RVA: 0x0082FFA8 File Offset: 0x0082E1A8
	protected override bool OnCheck(int uId = 0)
	{
		return !MotorcycleDiyModel.Instance.RedDotIsPreviewInAnyPart(EOutlookType.Decoration) && MotorcycleDiyModel.Instance.RedDotHasNewDecorationByAnyPart();
	}
}
