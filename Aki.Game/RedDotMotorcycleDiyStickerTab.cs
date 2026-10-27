using System;
using CSharpScript.Game.Common.Event;

// Token: 0x020033DF RID: 13279
public class RedDotMotorcycleDiyStickerTab : RedDotBase
{
	// Token: 0x0601CC4A RID: 117834 RVA: 0x00809C5A File Offset: 0x00807E5A
	protected override bool IsMultiple()
	{
		return true;
	}

	// Token: 0x0601CC4B RID: 117835 RVA: 0x00809C5D File Offset: 0x00807E5D
	protected override void AddCheckEvent()
	{
		EventSystem.Instance.Add(EEventName.MotorDiyInfoUpdate, new Action(base.EventCheck));
		EventSystem.Instance.Add(EEventName.MotorDiyInfoRedDotUpdate, new Action(base.EventCheck));
	}

	// Token: 0x0601CC4C RID: 117836 RVA: 0x00809C97 File Offset: 0x00807E97
	protected override void RemoveCheckEvent()
	{
		EventSystem.Instance.Remove(EEventName.MotorDiyInfoUpdate, new Action(base.EventCheck));
		EventSystem.Instance.Remove(EEventName.MotorDiyInfoRedDotUpdate, new Action(base.EventCheck));
	}

	// Token: 0x0601CC4D RID: 117837 RVA: 0x00809CD1 File Offset: 0x00807ED1
	protected override bool OnCheck(int uId = 0)
	{
		return !MotorcycleDiyModel.Instance.RedDotIsPreviewInAnyPart(EOutlookType.Sticker) && MotorcycleDiyModel.Instance.RedDotHasNewStickerByAnyPart();
	}
}
