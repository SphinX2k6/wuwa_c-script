using System;
using CSharpScript.Game.Common.Event;

// Token: 0x020029C6 RID: 10694
public class VisionTabRedDot : RedDotBase
{
	// Token: 0x0601AB64 RID: 109412 RVA: 0x008349CA File Offset: 0x00832BCA
	protected override void AddCheckEvent()
	{
		EventSystem.Instance.Add<int>(EEventName.RefreshVisionEquipRedPoint, new Action<int>(base.EventCheckWithUid));
	}

	// Token: 0x0601AB65 RID: 109413 RVA: 0x008349E8 File Offset: 0x00832BE8
	protected override void RemoveCheckEvent()
	{
		EventSystem.Instance.Remove<int>(EEventName.RefreshVisionEquipRedPoint, new Action<int>(base.EventCheckWithUid));
	}

	// Token: 0x0601AB66 RID: 109414 RVA: 0x00834A06 File Offset: 0x00832C06
	protected override bool IsMultiple()
	{
		return true;
	}

	// Token: 0x0601AB67 RID: 109415 RVA: 0x00834A09 File Offset: 0x00832C09
	protected override bool OnCheck(int uId = 0)
	{
		return VisionRecommendModel.Instance.CheckVisionOneKeyEquipRedDot(uId) || VisionEquipGroupModel.Instance.GetVisionGroupFirstOpenState();
	}
}
