using System;
using CSharpScript.Game.Common.Event;

// Token: 0x020033D7 RID: 13271
public class RedDotMotorcycleDiyDecorationPrePartTab : RedDotBase
{
	// Token: 0x0601CC22 RID: 117794 RVA: 0x008098BF File Offset: 0x00807ABF
	protected override bool IsMultiple()
	{
		return true;
	}

	// Token: 0x0601CC23 RID: 117795 RVA: 0x008098C2 File Offset: 0x00807AC2
	protected override void AddCheckEvent()
	{
		EventSystem.Instance.Add(EEventName.MotorDiyInfoRedDotUpdate, new Action(base.EventCheck));
	}

	// Token: 0x0601CC24 RID: 117796 RVA: 0x008098E0 File Offset: 0x00807AE0
	protected override void RemoveCheckEvent()
	{
		EventSystem.Instance.Remove(EEventName.MotorDiyInfoRedDotUpdate, new Action(base.EventCheck));
	}

	// Token: 0x0601CC25 RID: 117797 RVA: 0x008098FE File Offset: 0x00807AFE
	protected override bool OnCheck(int uId = 0)
	{
		return MotorcycleDiyModel.Instance.RedDotIsPreview(EOutlookType.Decoration, new int?(uId));
	}
}
