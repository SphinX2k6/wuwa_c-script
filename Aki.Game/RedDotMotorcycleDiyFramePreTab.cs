using System;
using CSharpScript.Game.Common.Event;

// Token: 0x0200294C RID: 10572
public class RedDotMotorcycleDiyFramePreTab : RedDotBase
{
	// Token: 0x0601A929 RID: 108841 RVA: 0x0082FFCB File Offset: 0x0082E1CB
	protected override bool IsMultiple()
	{
		return true;
	}

	// Token: 0x0601A92A RID: 108842 RVA: 0x0082FFCE File Offset: 0x0082E1CE
	protected override void AddCheckEvent()
	{
		EventSystem.Instance.Add(EEventName.MotorDiyInfoRedDotUpdate, new Action(base.EventCheck));
	}

	// Token: 0x0601A92B RID: 108843 RVA: 0x0082FFEC File Offset: 0x0082E1EC
	protected override void RemoveCheckEvent()
	{
		EventSystem.Instance.Remove(EEventName.MotorDiyInfoRedDotUpdate, new Action(base.EventCheck));
	}

	// Token: 0x0601A92C RID: 108844 RVA: 0x0083000C File Offset: 0x0082E20C
	protected override bool OnCheck(int uId = 0)
	{
		return MotorcycleDiyModel.Instance.RedDotIsPreview(EOutlookType.Frame, null);
	}
}
