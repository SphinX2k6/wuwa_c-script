using System;
using CSharpScript.Game.Common.Event;

// Token: 0x020033DC RID: 13276
public class RedDotMotorcycleDiyStickerPartTab : RedDotBase
{
	// Token: 0x0601CC3B RID: 117819 RVA: 0x00809B0B File Offset: 0x00807D0B
	protected override bool IsMultiple()
	{
		return true;
	}

	// Token: 0x0601CC3C RID: 117820 RVA: 0x00809B0E File Offset: 0x00807D0E
	protected override void AddCheckEvent()
	{
		EventSystem.Instance.Add(EEventName.MotorDiyInfoUpdate, new Action(base.EventCheck));
		EventSystem.Instance.Add(EEventName.MotorDiyInfoRedDotUpdate, new Action(base.EventCheck));
	}

	// Token: 0x0601CC3D RID: 117821 RVA: 0x00809B48 File Offset: 0x00807D48
	protected override void RemoveCheckEvent()
	{
		EventSystem.Instance.Remove(EEventName.MotorDiyInfoUpdate, new Action(base.EventCheck));
		EventSystem.Instance.Remove(EEventName.MotorDiyInfoRedDotUpdate, new Action(base.EventCheck));
	}

	// Token: 0x0601CC3E RID: 117822 RVA: 0x00809B82 File Offset: 0x00807D82
	protected override bool OnCheck(int uId = 0)
	{
		return !MotorcycleDiyModel.Instance.RedDotIsPreview(EOutlookType.Sticker, new int?(uId)) && MotorcycleDiyModel.Instance.RedDotHasNewStickerByPart(uId);
	}
}
