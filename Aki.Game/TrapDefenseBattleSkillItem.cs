using System;
using CSharpScript.Core.Common;
using CSharpScript.Game.Module.BattleUi.Views;

// Token: 0x02001D29 RID: 7465
public class TrapDefenseBattleSkillItem : BattleSkillItem
{
	// Token: 0x0600E21B RID: 57883 RVA: 0x00351C10 File Offset: 0x0034FE10
	public void RefreshTrapDefenseSkillCoolDown()
	{
		int? followerProxyId = TowerDefensePlayerController.GetFollowerProxyId();
		if (followerProxyId == null)
		{
			return;
		}
		float followerSkillRemainCD = TowerDefensePlayerController.GetFollowerSkillRemainCD(followerProxyId.Value);
		if (followerSkillRemainCD > 0f)
		{
			base.PlaySkillCd(followerSkillRemainCD, TowerDefensePlayerController.GetFollowerSkillCD(followerProxyId.Value), false);
		}
	}

	// Token: 0x0600E21C RID: 57884 RVA: 0x00351C58 File Offset: 0x0034FE58
	protected override bool IsNeedLongPress()
	{
		return !this.IsBanLongPress && this.SkillButtonData.GetIsLongPressControlCamera().Value;
	}

	// Token: 0x0600E21D RID: 57885 RVA: 0x00351C84 File Offset: 0x0034FE84
	public override void RefreshSkillName()
	{
		string skillIconName = this.SkillButtonData.GetSkillIconName();
		if (!StringUtils.IsBlank(skillIconName) && Info.Instance.IsInTouch())
		{
			LguiUtil.Instance.SetLocalTextNew(this.SkillNameText, skillIconName, Array.Empty<object>());
			this.SkillNameText.SetUIActive(true);
			return;
		}
		this.SkillNameText.SetUIActive(false);
	}

	// Token: 0x0600E21E RID: 57886 RVA: 0x00351CE0 File Offset: 0x0034FEE0
	public void SetIsBanLongPress(bool isBanLongPress)
	{
		this.IsBanLongPress = isBanLongPress;
	}

	// Token: 0x04006893 RID: 26771
	private bool IsBanLongPress;
}
