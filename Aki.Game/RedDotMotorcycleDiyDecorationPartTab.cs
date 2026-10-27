using System;
using CSharpScript.Game.Common.Event;

// Token: 0x020033D6 RID: 13270
public class RedDotMotorcycleDiyDecorationPartTab : RedDotBase
{
	// Token: 0x0601CC1D RID: 117789 RVA: 0x0080981E File Offset: 0x00807A1E
	protected override bool IsMultiple()
	{
		return true;
	}

	// Token: 0x0601CC1E RID: 117790 RVA: 0x00809821 File Offset: 0x00807A21
	protected override void AddCheckEvent()
	{
		EventSystem.Instance.Add(EEventName.MotorDiyInfoUpdate, new Action(base.EventCheck));
		EventSystem.Instance.Add(EEventName.MotorDiyInfoRedDotUpdate, new Action(base.EventCheck));
	}

	// Token: 0x0601CC1F RID: 117791 RVA: 0x0080985B File Offset: 0x00807A5B
	protected override void RemoveCheckEvent()
	{
		EventSystem.Instance.Remove(EEventName.MotorDiyInfoUpdate, new Action(base.EventCheck));
		EventSystem.Instance.Remove(EEventName.MotorDiyInfoRedDotUpdate, new Action(base.EventCheck));
	}

	// Token: 0x0601CC20 RID: 117792 RVA: 0x00809895 File Offset: 0x00807A95
	protected override bool OnCheck(int uId = 0)
	{
		return !MotorcycleDiyModel.Instance.RedDotIsPreview(EOutlookType.Decoration, new int?(uId)) && MotorcycleDiyModel.Instance.RedDotHasNewDecorationByPart(uId);
	}
}
