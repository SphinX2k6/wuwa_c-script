using System;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Activity.ActivityContent.Fishing;

// Token: 0x02003387 RID: 13191
public class FishingRoleToggleTechRedDot : RedDotBase
{
	// Token: 0x0601CAB8 RID: 117432 RVA: 0x00806B23 File Offset: 0x00804D23
	protected override ERedDotName? OnGetParentName()
	{
		return new ERedDotName?(ERedDotName.FishingRoleTech);
	}

	// Token: 0x0601CAB9 RID: 117433 RVA: 0x00806B2F File Offset: 0x00804D2F
	protected override void AddCheckEvent()
	{
		EventSystem.Instance.Add<EFishingTechNodeType>(EEventName.OnFishingRoleTechRefresh, new Action<EFishingTechNodeType>(this.OnFishingRoleTechRefresh));
	}

	// Token: 0x0601CABA RID: 117434 RVA: 0x00806B4D File Offset: 0x00804D4D
	protected override void RemoveCheckEvent()
	{
		EventSystem.Instance.Remove<EFishingTechNodeType>(EEventName.OnFishingRoleTechRefresh, new Action<EFishingTechNodeType>(this.OnFishingRoleTechRefresh));
	}

	// Token: 0x0601CABB RID: 117435 RVA: 0x00806B6B File Offset: 0x00804D6B
	protected override bool OnCheck(int uId = 0)
	{
		return FishingModel.Instance.GetRoleTechNodeCanLevelUp((EFishingTechNodeType)uId);
	}

	// Token: 0x0601CABC RID: 117436 RVA: 0x00806B78 File Offset: 0x00804D78
	private void OnFishingRoleTechRefresh(EFishingTechNodeType type)
	{
		base.EventCheckWithUid((int)type);
	}
}
