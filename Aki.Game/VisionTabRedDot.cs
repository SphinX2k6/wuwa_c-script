using System;
using CSharpScript.Game.Common.Event;

// Token: 0x02003452 RID: 13394
public class VisionTabRedDot : RedDotBase
{
	// Token: 0x0601CE64 RID: 118372 RVA: 0x0080E2E2 File Offset: 0x0080C4E2
	protected override void AddCheckEvent()
	{
		EventSystem.Instance.Add<int>(EEventName.RefreshVisionEquipRedPoint, new Action<int>(base.EventCheckWithUid));
	}

	// Token: 0x0601CE65 RID: 118373 RVA: 0x0080E300 File Offset: 0x0080C500
	protected override void RemoveCheckEvent()
	{
		EventSystem.Instance.Remove<int>(EEventName.RefreshVisionEquipRedPoint, new Action<int>(base.EventCheckWithUid));
	}

	// Token: 0x0601CE66 RID: 118374 RVA: 0x0080E31E File Offset: 0x0080C51E
	protected override bool IsMultiple()
	{
		return true;
	}

	// Token: 0x0601CE67 RID: 118375 RVA: 0x0080E321 File Offset: 0x0080C521
	protected override bool OnCheck(int uId = 0)
	{
		return VisionRecommendModel.Instance.CheckVisionOneKeyEquipRedDot(uId) || VisionEquipGroupModel.Instance.GetVisionGroupFirstOpenState();
	}
}
