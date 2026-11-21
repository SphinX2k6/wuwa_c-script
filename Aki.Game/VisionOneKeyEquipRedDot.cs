using System;
using CSharpScript.Game.Common.Event;

// Token: 0x020029C5 RID: 10693
public class VisionOneKeyEquipRedDot : RedDotBase
{
	// Token: 0x0601AB5F RID: 109407 RVA: 0x00834976 File Offset: 0x00832B76
	protected override void AddCheckEvent()
	{
		EventSystem.Instance.Add<int>(EEventName.RefreshVisionEquipRedPoint, new Action<int>(base.EventCheckWithUid));
	}

	// Token: 0x0601AB60 RID: 109408 RVA: 0x00834994 File Offset: 0x00832B94
	protected override void RemoveCheckEvent()
	{
		EventSystem.Instance.Remove<int>(EEventName.RefreshVisionEquipRedPoint, new Action<int>(base.EventCheckWithUid));
	}

	// Token: 0x0601AB61 RID: 109409 RVA: 0x008349B2 File Offset: 0x00832BB2
	protected override bool IsMultiple()
	{
		return true;
	}

	// Token: 0x0601AB62 RID: 109410 RVA: 0x008349B5 File Offset: 0x00832BB5
	protected override bool OnCheck(int uId = 0)
	{
		return VisionRecommendModel.Instance.CheckVisionOneKeyEquipRedDot(uId);
	}
}
