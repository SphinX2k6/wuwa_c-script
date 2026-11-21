using System;
using CSharpScript.Game.Common.Event;

// Token: 0x02002951 RID: 10577
public class RedDotMotorcycleDiyStickerTab : RedDotBase
{
	// Token: 0x0601A942 RID: 108866 RVA: 0x0083021E File Offset: 0x0082E41E
	protected override bool IsMultiple()
	{
		return true;
	}

	// Token: 0x0601A943 RID: 108867 RVA: 0x00830221 File Offset: 0x0082E421
	protected override void AddCheckEvent()
	{
		EventSystem.Instance.Add(EEventName.MotorDiyInfoUpdate, new Action(base.EventCheck));
		EventSystem.Instance.Add(EEventName.MotorDiyInfoRedDotUpdate, new Action(base.EventCheck));
	}

	// Token: 0x0601A944 RID: 108868 RVA: 0x0083025B File Offset: 0x0082E45B
	protected override void RemoveCheckEvent()
	{
		EventSystem.Instance.Remove(EEventName.MotorDiyInfoUpdate, new Action(base.EventCheck));
		EventSystem.Instance.Remove(EEventName.MotorDiyInfoRedDotUpdate, new Action(base.EventCheck));
	}

	// Token: 0x0601A945 RID: 108869 RVA: 0x00830295 File Offset: 0x0082E495
	protected override bool OnCheck(int uId = 0)
	{
		return !MotorcycleDiyModel.Instance.RedDotIsPreviewInAnyPart(EOutlookType.Sticker) && MotorcycleDiyModel.Instance.RedDotHasNewStickerByAnyPart();
	}
}
