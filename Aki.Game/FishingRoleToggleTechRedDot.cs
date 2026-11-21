using System;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Activity.ActivityContent.Fishing;

// Token: 0x020028F9 RID: 10489
public class FishingRoleToggleTechRedDot : RedDotBase
{
	// Token: 0x0601A7B0 RID: 108464 RVA: 0x0082D0E7 File Offset: 0x0082B2E7
	protected override ERedDotName? OnGetParentName()
	{
		return new ERedDotName?(ERedDotName.FishingRoleTech);
	}

	// Token: 0x0601A7B1 RID: 108465 RVA: 0x0082D0F3 File Offset: 0x0082B2F3
	protected override void AddCheckEvent()
	{
		EventSystem.Instance.Add<EFishingTechNodeType>(EEventName.OnFishingRoleTechRefresh, new Action<EFishingTechNodeType>(this.OnFishingRoleTechRefresh));
	}

	// Token: 0x0601A7B2 RID: 108466 RVA: 0x0082D111 File Offset: 0x0082B311
	protected override void RemoveCheckEvent()
	{
		EventSystem.Instance.Remove<EFishingTechNodeType>(EEventName.OnFishingRoleTechRefresh, new Action<EFishingTechNodeType>(this.OnFishingRoleTechRefresh));
	}

	// Token: 0x0601A7B3 RID: 108467 RVA: 0x0082D12F File Offset: 0x0082B32F
	protected override bool OnCheck(int uId = 0)
	{
		return FishingModel.Instance.GetRoleTechNodeCanLevelUp((EFishingTechNodeType)uId);
	}

	// Token: 0x0601A7B4 RID: 108468 RVA: 0x0082D13C File Offset: 0x0082B33C
	private void OnFishingRoleTechRefresh(EFishingTechNodeType type)
	{
		base.EventCheckWithUid((int)type);
	}
}
