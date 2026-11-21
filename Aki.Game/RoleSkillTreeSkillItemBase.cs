using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.RoleUi;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02001E41 RID: 7745
[NullableContext(2)]
[Nullable(0)]
public class RoleSkillTreeSkillItemBase : UiPanelBase
{
	// Token: 0x060132B3 RID: 78515 RVA: 0x0059BF8E File Offset: 0x0059A18E
	protected override void OnStart()
	{
		this.SkillIconItem = new RoleSkillIconItem(this.GetSkillIconItem(), this.IsIconTexture());
		this.InitBranchSequencePlayer();
		this.SetToggleCallBack(new Action(this.OnToggleClick));
	}

	// Token: 0x060132B4 RID: 78516 RVA: 0x0059BFC0 File Offset: 0x0059A1C0
	protected void InitBranchSequencePlayer()
	{
		UUIItem leftBranchItem = this.GetLeftBranchItem();
		if (leftBranchItem != null)
		{
			this.LeftBranchSequencePlayer = new LevelSequencePlayer(leftBranchItem);
		}
		UUIItem rightBranchItem = this.GetRightBranchItem();
		if (rightBranchItem != null)
		{
			this.RightBranchSequencePlayer = new LevelSequencePlayer(rightBranchItem);
		}
	}

	// Token: 0x060132B5 RID: 78517 RVA: 0x0059BFF9 File Offset: 0x0059A1F9
	public void Update(int roleId, int skillNodeId)
	{
		this.SkillIconItem.SetId(roleId, skillNodeId);
		this.Refresh();
	}

	// Token: 0x060132B6 RID: 78518 RVA: 0x0059C00E File Offset: 0x0059A20E
	public int GetRoleId()
	{
		return this.SkillIconItem.GetRoleId();
	}

	// Token: 0x060132B7 RID: 78519 RVA: 0x0059C01B File Offset: 0x0059A21B
	public int GetSkillNodeId()
	{
		return this.SkillIconItem.GetSkillNodeId();
	}

	// Token: 0x060132B8 RID: 78520 RVA: 0x0059C028 File Offset: 0x0059A228
	public int GetSkillId()
	{
		return this.SkillIconItem.GetSkillId();
	}

	// Token: 0x060132B9 RID: 78521 RVA: 0x0059C035 File Offset: 0x0059A235
	public int GetUpgradeSkillId()
	{
		return this.SkillIconItem.GetUpgradeSkillId();
	}

	// Token: 0x060132BA RID: 78522 RVA: 0x0059C042 File Offset: 0x0059A242
	public SkillTree? GetSkillTreeNodeConfig()
	{
		return this.SkillIconItem.GetSkillTreeNodeConfig();
	}

	// Token: 0x060132BB RID: 78523 RVA: 0x0059C04F File Offset: 0x0059A24F
	public Aki.Config.Skill? GetSkillConfig()
	{
		return this.SkillIconItem.GetSkillConfig();
	}

	// Token: 0x060132BC RID: 78524 RVA: 0x0059C05C File Offset: 0x0059A25C
	public Aki.Config.Skill? GetUpgradeSkillConfig()
	{
		return this.SkillIconItem.GetUpgradeSkillConfig();
	}

	// Token: 0x060132BD RID: 78525 RVA: 0x0059C069 File Offset: 0x0059A269
	protected virtual UUIItem GetSkillIconItem()
	{
		return null;
	}

	// Token: 0x060132BE RID: 78526 RVA: 0x0059C06C File Offset: 0x0059A26C
	protected virtual UUIText GetLevelText()
	{
		return null;
	}

	// Token: 0x060132BF RID: 78527 RVA: 0x0059C06F File Offset: 0x0059A26F
	protected virtual UUIText GetNameText()
	{
		return null;
	}

	// Token: 0x060132C0 RID: 78528 RVA: 0x0059C072 File Offset: 0x0059A272
	protected virtual UUIItem GetLockItem()
	{
		return null;
	}

	// Token: 0x060132C1 RID: 78529 RVA: 0x0059C075 File Offset: 0x0059A275
	protected virtual UUIItem GetLeftBranchItem()
	{
		return null;
	}

	// Token: 0x060132C2 RID: 78530 RVA: 0x0059C078 File Offset: 0x0059A278
	protected virtual UUISprite GetLeftBranchIcon()
	{
		return null;
	}

	// Token: 0x060132C3 RID: 78531 RVA: 0x0059C07B File Offset: 0x0059A27B
	protected virtual UUIItem GetRightBranchItem()
	{
		return null;
	}

	// Token: 0x060132C4 RID: 78532 RVA: 0x0059C07E File Offset: 0x0059A27E
	protected virtual UUISprite GetRightBranchIcon()
	{
		return null;
	}

	// Token: 0x060132C5 RID: 78533 RVA: 0x0059C081 File Offset: 0x0059A281
	protected virtual UUIItem GetStrongArrowUpItem()
	{
		return null;
	}

	// Token: 0x060132C6 RID: 78534 RVA: 0x0059C084 File Offset: 0x0059A284
	protected virtual UUIItem GetShowTagItem()
	{
		return null;
	}

	// Token: 0x060132C7 RID: 78535 RVA: 0x0059C087 File Offset: 0x0059A287
	protected virtual UUITexture GetShowTagTex()
	{
		return null;
	}

	// Token: 0x060132C8 RID: 78536 RVA: 0x0059C08A File Offset: 0x0059A28A
	public bool HasActiveBranchItem()
	{
		UUIItem leftBranchItem = this.GetLeftBranchItem();
		if (leftBranchItem == null || !leftBranchItem.IsUIActiveSelf())
		{
			UUIItem rightBranchItem = this.GetRightBranchItem();
			return rightBranchItem != null && rightBranchItem.IsUIActiveSelf();
		}
		return true;
	}

	// Token: 0x060132C9 RID: 78537 RVA: 0x0059C0B3 File Offset: 0x0059A2B3
	public void Refresh()
	{
		this.SkillIconItem.Refresh();
		this.RefreshName();
		this.RefreshLevel();
		this.RefreshState();
		this.RefreshSkillBranch(false);
		this.RefreshShowTag();
	}

	// Token: 0x060132CA RID: 78538 RVA: 0x0059C0E0 File Offset: 0x0059A2E0
	public void RefreshName()
	{
		UUIText nameText = this.GetNameText();
		if (nameText != null)
		{
			Aki.Config.Skill? upgradeSkillConfig = this.GetUpgradeSkillConfig();
			Aki.Config.Skill? skillConfig = this.GetSkillConfig();
			Aki.Config.Skill? skill = (upgradeSkillConfig != null) ? upgradeSkillConfig : skillConfig;
			string skillTypeNameLocalText = RoleSkillConfig.Instance.GetSkillTypeNameLocalText(skill.Value.SkillType);
			if (!string.IsNullOrEmpty(skillTypeNameLocalText))
			{
				nameText.SetText(skillTypeNameLocalText, true);
			}
		}
	}

	// Token: 0x060132CB RID: 78539 RVA: 0x0059C144 File Offset: 0x0059A344
	public void RefreshLevel()
	{
		int roleId = this.GetRoleId();
		int skillNodeId = this.GetSkillNodeId();
		int roleSkillTreeNodeLevel = RoleModel.Instance.GetRoleSkillTreeNodeLevel(roleId, skillNodeId);
		UUIText levelText = this.GetLevelText();
		if (levelText != null)
		{
			int? roleSkillMaxLevelBySkillNodeId = RoleSkillConfig.Instance.GetRoleSkillMaxLevelBySkillNodeId(skillNodeId);
			LguiUtil.Instance.SetLocalTextNew(levelText, "RoleSkillTreeLevelText", new <>z__ReadOnlyArray<object>(new object[]
			{
				roleSkillTreeNodeLevel,
				roleSkillMaxLevelBySkillNodeId
			}));
		}
	}

	// Token: 0x060132CC RID: 78540 RVA: 0x0059C1B1 File Offset: 0x0059A3B1
	private void OnToggleClick()
	{
		EventSystem.Instance.Emit<RoleSkillTreeSkillItemBase>(EEventName.OnSkillTreeNodeToggleClick, this);
	}

	// Token: 0x060132CD RID: 78541 RVA: 0x0059C1C4 File Offset: 0x0059A3C4
	[NullableContext(1)]
	public void SetToggleCallBack(Action callBack)
	{
		this.SkillIconItem.SetToggleCallBack(callBack);
	}

	// Token: 0x060132CE RID: 78542 RVA: 0x0059C1D2 File Offset: 0x0059A3D2
	public void SetToggleState(EToggleState state, bool bFireEvent = false)
	{
		this.SkillIconItem.SetToggleState(state, bFireEvent);
	}

	// Token: 0x060132CF RID: 78543 RVA: 0x0059C1E1 File Offset: 0x0059A3E1
	[NullableContext(1)]
	public UUIItem GetSkillIconToggleItem()
	{
		return this.SkillIconItem.GetToggleItem();
	}

	// Token: 0x060132D0 RID: 78544 RVA: 0x0059C1F0 File Offset: 0x0059A3F0
	public void RefreshState()
	{
		UUIItem lockItem = this.GetLockItem();
		UUIItem strongArrowUpItem = this.GetStrongArrowUpItem();
		this.State = RoleModel.Instance.GetRoleSkillTreeNodeState(this.GetRoleId(), this.GetSkillNodeId());
		if (this.State.GetValueOrDefault() == ESkillTreeNodeState.Lock)
		{
			if (lockItem != null)
			{
				lockItem.SetUIActive(true);
			}
			if (strongArrowUpItem != null)
			{
				strongArrowUpItem.SetUIActive(false);
				return;
			}
		}
		else if (this.State.GetValueOrDefault() == ESkillTreeNodeState.Active)
		{
			if (lockItem != null)
			{
				lockItem.SetUIActive(false);
			}
			if (strongArrowUpItem != null)
			{
				strongArrowUpItem.SetUIActive(false);
				return;
			}
		}
		else if (this.State.GetValueOrDefault() == ESkillTreeNodeState.Inactive)
		{
			bool roleSkillTreeNodeConsumeSatisfied = RoleModel.Instance.GetRoleSkillTreeNodeConsumeSatisfied(this.GetRoleId(), this.GetSkillNodeId());
			if (lockItem != null)
			{
				lockItem.SetUIActive(false);
			}
			if (strongArrowUpItem != null)
			{
				strongArrowUpItem.SetUIActive(roleSkillTreeNodeConsumeSatisfied);
			}
		}
	}

	// Token: 0x060132D1 RID: 78545 RVA: 0x0059C2A6 File Offset: 0x0059A4A6
	public void OnOtherNodeLevelChange()
	{
		if (this.State.GetValueOrDefault() != ESkillTreeNodeState.Active)
		{
			this.SkillIconItem.RefreshState();
			this.RefreshState();
		}
	}

	// Token: 0x060132D2 RID: 78546 RVA: 0x0059C2C7 File Offset: 0x0059A4C7
	public void OnSelfNodeLevelChange()
	{
		this.SkillIconItem.RefreshState();
		this.RefreshLevel();
		this.RefreshState();
	}

	// Token: 0x060132D3 RID: 78547 RVA: 0x0059C2E0 File Offset: 0x0059A4E0
	public void OnNodeLevelChange(int nodeId)
	{
		if (nodeId == this.GetSkillNodeId())
		{
			this.OnSelfNodeLevelChange();
			return;
		}
		this.OnOtherNodeLevelChange();
	}

	// Token: 0x060132D4 RID: 78548 RVA: 0x0059C2F8 File Offset: 0x0059A4F8
	public new virtual ESkillTreeNodeType? GetType()
	{
		return null;
	}

	// Token: 0x060132D5 RID: 78549 RVA: 0x0059C30E File Offset: 0x0059A50E
	public virtual bool IsIconTexture()
	{
		return false;
	}

	// Token: 0x060132D6 RID: 78550 RVA: 0x0059C311 File Offset: 0x0059A511
	public ESkillTreeNodeState? GetState()
	{
		return this.State;
	}

	// Token: 0x060132D7 RID: 78551 RVA: 0x0059C319 File Offset: 0x0059A519
	public void TriggerToggle()
	{
		this.OnToggleClick();
	}

	// Token: 0x060132D8 RID: 78552 RVA: 0x0059C324 File Offset: 0x0059A524
	public void RefreshSkillBranch(bool playAnim = false)
	{
		UUIItem leftBranchItem = this.GetLeftBranchItem();
		UUIItem rightBranchItem = this.GetRightBranchItem();
		if (!this.CheckSkillBranchEnabled())
		{
			if (leftBranchItem != null)
			{
				leftBranchItem.SetUIActive(false);
			}
			if (rightBranchItem != null)
			{
				rightBranchItem.SetUIActive(false);
			}
			return;
		}
		int roleId = this.GetRoleId();
		int skillNodeId = this.GetSkillNodeId();
		int roleCurrentBranchIndex = RoleModel.Instance.GetRoleCurrentBranchIndex(roleId);
		if (playAnim && this.LeftBranchSequencePlayer != null && this.RightBranchSequencePlayer != null)
		{
			if (leftBranchItem != null)
			{
				leftBranchItem.SetUIActive(true);
			}
			if (rightBranchItem != null)
			{
				rightBranchItem.SetUIActive(true);
			}
			this.LeftBranchSequencePlayer.StopCurrentSequence(false, true);
			this.RightBranchSequencePlayer.StopCurrentSequence(false, true);
			this.LeftBranchSequencePlayer.PlayLevelSequenceByName((roleCurrentBranchIndex == 0) ? "Start" : "Close", true, null, false);
			this.RightBranchSequencePlayer.PlayLevelSequenceByName((roleCurrentBranchIndex != 0) ? "Start" : "Close", true, null, false);
		}
		else
		{
			this.ResetSkillBranchAnim();
			if (leftBranchItem != null)
			{
				leftBranchItem.SetUIActive(roleCurrentBranchIndex == 0);
			}
			if (rightBranchItem != null)
			{
				rightBranchItem.SetUIActive(roleCurrentBranchIndex != 0);
			}
		}
		UUISprite uuisprite = (roleCurrentBranchIndex == 0) ? this.GetLeftBranchIcon() : this.GetRightBranchIcon();
		if (uuisprite != null)
		{
			int skillNodeCurrentBranchId = RoleModel.Instance.GetSkillNodeCurrentBranchId(roleId, skillNodeId);
			this.SetSpriteByPath(RoleConfig.Instance.GetSkillBranchConfigById(skillNodeCurrentBranchId).Value.Icon, uuisprite, false, null, null);
		}
	}

	// Token: 0x060132D9 RID: 78553 RVA: 0x0059C488 File Offset: 0x0059A688
	private void ResetSkillBranchAnim()
	{
		LevelSequencePlayer leftBranchSequencePlayer = this.LeftBranchSequencePlayer;
		if (leftBranchSequencePlayer != null)
		{
			leftBranchSequencePlayer.PlayLevelSequenceByName("Start", false, null, false);
		}
		LevelSequencePlayer leftBranchSequencePlayer2 = this.LeftBranchSequencePlayer;
		if (leftBranchSequencePlayer2 != null)
		{
			leftBranchSequencePlayer2.EndSequenceLastFrame("Start");
		}
		LevelSequencePlayer rightBranchSequencePlayer = this.RightBranchSequencePlayer;
		if (rightBranchSequencePlayer != null)
		{
			rightBranchSequencePlayer.PlayLevelSequenceByName("Start", false, null, false);
		}
		LevelSequencePlayer rightBranchSequencePlayer2 = this.RightBranchSequencePlayer;
		if (rightBranchSequencePlayer2 == null)
		{
			return;
		}
		rightBranchSequencePlayer2.EndSequenceLastFrame("Start");
	}

	// Token: 0x060132DA RID: 78554 RVA: 0x0059C504 File Offset: 0x0059A704
	private bool CheckSkillBranchEnabled()
	{
		int roleId = this.GetRoleId();
		int skillNodeId = this.GetSkillNodeId();
		return roleId != 0 && skillNodeId != 0 && (this.IsSkillBranchEnable && RoleModel.Instance.IsRoleHasBranch(roleId)) && RoleModel.Instance.IsSkillNodeHasBranch(skillNodeId);
	}

	// Token: 0x060132DB RID: 78555 RVA: 0x0059C549 File Offset: 0x0059A749
	public void OnSkillBranchChanged()
	{
		if (!this.CheckSkillBranchEnabled())
		{
			return;
		}
		this.RefreshSkillBranch(true);
	}

	// Token: 0x060132DC RID: 78556 RVA: 0x0059C55B File Offset: 0x0059A75B
	public void SetSkillBranchEnable(bool isEnable)
	{
		this.IsSkillBranchEnable = isEnable;
	}

	// Token: 0x060132DD RID: 78557 RVA: 0x0059C564 File Offset: 0x0059A764
	public void RefreshShowTag()
	{
		UUIItem showTagItem = this.GetShowTagItem();
		UUITexture showTagTex = this.GetShowTagTex();
		if (showTagItem == null || showTagTex == null)
		{
			return;
		}
		if (!RoleModel.Instance.IsShowSkillShowTag)
		{
			showTagItem.SetUIActive(false);
			return;
		}
		Aki.Config.Skill? skillConfig = this.GetSkillConfig();
		int num = (skillConfig != null) ? skillConfig.GetValueOrDefault().SkillShowTagType : 0;
		if (num == 1)
		{
			showTagItem.SetUIActive(true);
			string resourcePath = UiResourceConfig.Instance.GetResourcePath("T_RoleDevelopRecommendA");
			base.SetTextureByPath(resourcePath, showTagTex, null, null);
			return;
		}
		if (num == 2)
		{
			showTagItem.SetUIActive(true);
			string resourcePath2 = UiResourceConfig.Instance.GetResourcePath("T_RoleDevelopRecommendB");
			base.SetTextureByPath(resourcePath2, showTagTex, null, null);
			return;
		}
		showTagItem.SetUIActive(false);
	}

	// Token: 0x0400A46A RID: 42090
	private RoleSkillIconItem SkillIconItem;

	// Token: 0x0400A46B RID: 42091
	private ESkillTreeNodeState? State;

	// Token: 0x0400A46C RID: 42092
	private LevelSequencePlayer LeftBranchSequencePlayer;

	// Token: 0x0400A46D RID: 42093
	private LevelSequencePlayer RightBranchSequencePlayer;

	// Token: 0x0400A46E RID: 42094
	private bool IsSkillBranchEnable;
}
