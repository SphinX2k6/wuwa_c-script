using System;
using CSharpScript.Game.Common.Event;

// Token: 0x020029C2 RID: 10690
public class VisionGridRedDot : RedDotBase
{
	// Token: 0x0601AB52 RID: 109394 RVA: 0x008347F5 File Offset: 0x008329F5
	protected override void AddCheckEvent()
	{
		EventSystem.Instance.Add<int>(EEventName.RefreshVisionEquipRedPoint, new Action<int>(base.EventCheckWithUid));
	}

	// Token: 0x0601AB53 RID: 109395 RVA: 0x00834813 File Offset: 0x00832A13
	protected override void RemoveCheckEvent()
	{
		EventSystem.Instance.Remove<int>(EEventName.RefreshVisionEquipRedPoint, new Action<int>(base.EventCheckWithUid));
	}

	// Token: 0x0601AB54 RID: 109396 RVA: 0x00834831 File Offset: 0x00832A31
	protected override bool IsMultiple()
	{
		return true;
	}

	// Token: 0x0601AB55 RID: 109397 RVA: 0x00834834 File Offset: 0x00832A34
	protected override bool OnCheck(int uId = 0)
	{
		return VisionRecommendModel.Instance.CheckVisionOneKeyEquipRedDot(uId);
	}
}
