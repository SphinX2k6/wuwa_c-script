using System;
using CSharpScript.Game.Common.Event;

// Token: 0x020033DD RID: 13277
public class RedDotMotorcycleDiyStickerPrePartTab : RedDotBase
{
	// Token: 0x0601CC40 RID: 117824 RVA: 0x00809BAC File Offset: 0x00807DAC
	protected override bool IsMultiple()
	{
		return true;
	}

	// Token: 0x0601CC41 RID: 117825 RVA: 0x00809BAF File Offset: 0x00807DAF
	protected override void AddCheckEvent()
	{
		EventSystem.Instance.Add(EEventName.MotorDiyInfoRedDotUpdate, new Action(base.EventCheck));
	}

	// Token: 0x0601CC42 RID: 117826 RVA: 0x00809BCD File Offset: 0x00807DCD
	protected override void RemoveCheckEvent()
	{
		EventSystem.Instance.Remove(EEventName.MotorDiyInfoRedDotUpdate, new Action(base.EventCheck));
	}

	// Token: 0x0601CC43 RID: 117827 RVA: 0x00809BEB File Offset: 0x00807DEB
	protected override bool OnCheck(int uId = 0)
	{
		return MotorcycleDiyModel.Instance.RedDotIsPreview(EOutlookType.Sticker, new int?(uId));
	}
}
