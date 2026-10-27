using System;
using CSharpScript.Game.Common.Event;

// Token: 0x0200344E RID: 13390
public class VisionGridRedDot : RedDotBase
{
	// Token: 0x0601CE52 RID: 118354 RVA: 0x0080E10D File Offset: 0x0080C30D
	protected override void AddCheckEvent()
	{
		EventSystem.Instance.Add<int>(EEventName.RefreshVisionEquipRedPoint, new Action<int>(base.EventCheckWithUid));
	}

	// Token: 0x0601CE53 RID: 118355 RVA: 0x0080E12B File Offset: 0x0080C32B
	protected override void RemoveCheckEvent()
	{
		EventSystem.Instance.Remove<int>(EEventName.RefreshVisionEquipRedPoint, new Action<int>(base.EventCheckWithUid));
	}

	// Token: 0x0601CE54 RID: 118356 RVA: 0x0080E149 File Offset: 0x0080C349
	protected override bool IsMultiple()
	{
		return true;
	}

	// Token: 0x0601CE55 RID: 118357 RVA: 0x0080E14C File Offset: 0x0080C34C
	protected override bool OnCheck(int uId = 0)
	{
		return VisionRecommendModel.Instance.CheckVisionOneKeyEquipRedDot(uId);
	}
}
