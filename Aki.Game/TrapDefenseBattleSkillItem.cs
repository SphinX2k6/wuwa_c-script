using System;
using CSharpScript.Core.Common;
using CSharpScript.Game.Module.BattleUi.Views;

// Token: 0x020011EB RID: 4587
public class TrapDefenseBattleSkillItem : BattleSkillItem
{
	// Token: 0x0600B638 RID: 46648 RVA: 0x0035D640 File Offset: 0x0035B840
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

	// Token: 0x0600B639 RID: 46649 RVA: 0x0035D688 File Offset: 0x0035B888
	protected override bool IsNeedLongPress()
	{
		return !this.IsBanLongPress && this.SkillButtonData.GetIsLongPressControlCamera().Value;
	}

	// Token: 0x0600B63A RID: 46650 RVA: 0x0035D6B4 File Offset: 0x0035B8B4
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

	// Token: 0x0600B63B RID: 46651 RVA: 0x0035D710 File Offset: 0x0035B910
	public void SetIsBanLongPress(bool isBanLongPress)
	{
		this.IsBanLongPress = isBanLongPress;
	}

	// Token: 0x04006972 RID: 26994
	private bool IsBanLongPress;
}
