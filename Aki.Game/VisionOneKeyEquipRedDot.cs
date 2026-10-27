using System;
using CSharpScript.Game.Common.Event;

// Token: 0x02003451 RID: 13393
public class VisionOneKeyEquipRedDot : RedDotBase
{
	// Token: 0x0601CE5F RID: 118367 RVA: 0x0080E28E File Offset: 0x0080C48E
	protected override void AddCheckEvent()
	{
		EventSystem.Instance.Add<int>(EEventName.RefreshVisionEquipRedPoint, new Action<int>(base.EventCheckWithUid));
	}

	// Token: 0x0601CE60 RID: 118368 RVA: 0x0080E2AC File Offset: 0x0080C4AC
	protected override void RemoveCheckEvent()
	{
		EventSystem.Instance.Remove<int>(EEventName.RefreshVisionEquipRedPoint, new Action<int>(base.EventCheckWithUid));
	}

	// Token: 0x0601CE61 RID: 118369 RVA: 0x0080E2CA File Offset: 0x0080C4CA
	protected override bool IsMultiple()
	{
		return true;
	}

	// Token: 0x0601CE62 RID: 118370 RVA: 0x0080E2CD File Offset: 0x0080C4CD
	protected override bool OnCheck(int uId = 0)
	{
		return VisionRecommendModel.Instance.CheckVisionOneKeyEquipRedDot(uId);
	}
}
