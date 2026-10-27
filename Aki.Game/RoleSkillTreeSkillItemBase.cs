using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.RoleUi;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x020028C6 RID: 10438
[NullableContext(2)]
[Nullable(0)]
public class RoleSkillTreeSkillItemBase : UiPanelBase
{
	// Token: 0x060158B3 RID: 88243 RVA: 0x005710CA File Offset: 0x0056F2CA
	protected override void OnStart()
	{
		this.SkillIconItem = new RoleSkillIconItem(this.GetSkillIconItem(), this.IsIconTexture());
		this.InitBranchSequencePlayer();
		this.SetToggleCallBack(new Action(this.OnToggleClick));
	}

	// Token: 0x060158B4 RID: 88244 RVA: 0x005710FC File Offset: 0x0056F2FC
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

	// Token: 0x060158B5 RID: 88245 RVA: 0x00571135 File Offset: 0x0056F335
	public void Update(int roleId, int skillNodeId)
	{
		this.SkillIconItem.SetId(roleId, skillNodeId);
		this.Refresh();
	}

	// Token: 0x060158B6 RID: 88246 RVA: 0x0057114A File Offset: 0x0056F34A
	public int GetRoleId()
	{
		return this.SkillIconItem.GetRoleId();
	}

	// Token: 0x060158B7 RID: 88247 RVA: 0x00571157 File Offset: 0x0056F357
	public int GetSkillNodeId()
	{
		return this.SkillIconItem.GetSkillNodeId();
	}

	// Token: 0x060158B8 RID: 88248 RVA: 0x00571164 File Offset: 0x0056F364
	public int GetSkillId()
	{
		return this.SkillIconItem.GetSkillId();
	}

	// Token: 0x060158B9 RID: 88249 RVA: 0x00571171 File Offset: 0x0056F371
	public int GetUpgradeSkillId()
	{
		return this.SkillIconItem.GetUpgradeSkillId();
	}

	// Token: 0x060158BA RID: 88250 RVA: 0x0057117E File Offset: 0x0056F37E
	public SkillTree? GetSkillTreeNodeConfig()
	{
		return this.SkillIconItem.GetSkillTreeNodeConfig();
	}

	// Token: 0x060158BB RID: 88251 RVA: 0x0057118B File Offset: 0x0056F38B
	public Aki.Config.Skill? GetSkillConfig()
	{
		return this.SkillIconItem.GetSkillConfig();
	}

	// Token: 0x060158BC RID: 88252 RVA: 0x00571198 File Offset: 0x0056F398
	public Aki.Config.Skill? GetUpgradeSkillConfig()
	{
		return this.SkillIconItem.GetUpgradeSkillConfig();
	}

	// Token: 0x060158BD RID: 88253 RVA: 0x005711A5 File Offset: 0x0056F3A5
	protected virtual UUIItem GetSkillIconItem()
	{
		return null;
	}

	// Token: 0x060158BE RID: 88254 RVA: 0x005711A8 File Offset: 0x0056F3A8
	protected virtual UUIText GetLevelText()
	{
		return null;
	}

	// Token: 0x060158BF RID: 88255 RVA: 0x005711AB File Offset: 0x0056F3AB
	protected virtual UUIText GetNameText()
	{
		return null;
	}

	// Token: 0x060158C0 RID: 88256 RVA: 0x005711AE File Offset: 0x0056F3AE
	protected virtual UUIItem GetLockItem()
	{
		return null;
	}

	// Token: 0x060158C1 RID: 88257 RVA: 0x005711B1 File Offset: 0x0056F3B1
	protected virtual UUIItem GetLeftBranchItem()
	{
		return null;
	}

	// Token: 0x060158C2 RID: 88258 RVA: 0x005711B4 File Offset: 0x0056F3B4
	protected virtual UUISprite GetLeftBranchIcon()
	{
		return null;
	}

	// Token: 0x060158C3 RID: 88259 RVA: 0x005711B7 File Offset: 0x0056F3B7
	protected virtual UUIItem GetRightBranchItem()
	{
		return null;
	}

	// Token: 0x060158C4 RID: 88260 RVA: 0x005711BA File Offset: 0x0056F3BA
	protected virtual UUISprite GetRightBranchIcon()
	{
		return null;
	}

	// Token: 0x060158C5 RID: 88261 RVA: 0x005711BD File Offset: 0x0056F3BD
	protected virtual UUIItem GetStrongArrowUpItem()
	{
		return null;
	}

	// Token: 0x060158C6 RID: 88262 RVA: 0x005711C0 File Offset: 0x0056F3C0
	protected virtual UUIItem GetShowTagItem()
	{
		return null;
	}

	// Token: 0x060158C7 RID: 88263 RVA: 0x005711C3 File Offset: 0x0056F3C3
	protected virtual UUITexture GetShowTagTex()
	{
		return null;
	}

	// Token: 0x060158C8 RID: 88264 RVA: 0x005711C6 File Offset: 0x0056F3C6
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

	// Token: 0x060158C9 RID: 88265 RVA: 0x005711EF File Offset: 0x0056F3EF
	public void Refresh()
	{
		this.SkillIconItem.Refresh();
		this.RefreshName();
		this.RefreshLevel();
		this.RefreshState();
		this.RefreshSkillBranch(false);
		this.RefreshShowTag();
	}

	// Token: 0x060158CA RID: 88266 RVA: 0x0057121C File Offset: 0x0056F41C
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

	// Token: 0x060158CB RID: 88267 RVA: 0x00571280 File Offset: 0x0056F480
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

	// Token: 0x060158CC RID: 88268 RVA: 0x005712ED File Offset: 0x0056F4ED
	private void OnToggleClick()
	{
		EventSystem.Instance.Emit<RoleSkillTreeSkillItemBase>(EEventName.OnSkillTreeNodeToggleClick, this);
	}

	// Token: 0x060158CD RID: 88269 RVA: 0x00571300 File Offset: 0x0056F500
	[NullableContext(1)]
	public void SetToggleCallBack(Action callBack)
	{
		this.SkillIconItem.SetToggleCallBack(callBack);
	}

	// Token: 0x060158CE RID: 88270 RVA: 0x0057130E File Offset: 0x0056F50E
	public void SetToggleState(EToggleState state, bool bFireEvent = false)
	{
		this.SkillIconItem.SetToggleState(state, bFireEvent);
	}

	// Token: 0x060158CF RID: 88271 RVA: 0x0057131D File Offset: 0x0056F51D
	[NullableContext(1)]
	public UUIItem GetSkillIconToggleItem()
	{
		return this.SkillIconItem.GetToggleItem();
	}

	// Token: 0x060158D0 RID: 88272 RVA: 0x0057132C File Offset: 0x0056F52C
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

	// Token: 0x060158D1 RID: 88273 RVA: 0x005713E2 File Offset: 0x0056F5E2
	public void OnOtherNodeLevelChange()
	{
		if (this.State.GetValueOrDefault() != ESkillTreeNodeState.Active)
		{
			this.SkillIconItem.RefreshState();
			this.RefreshState();
		}
	}

	// Token: 0x060158D2 RID: 88274 RVA: 0x00571403 File Offset: 0x0056F603
	public void OnSelfNodeLevelChange()
	{
		this.SkillIconItem.RefreshState();
		this.RefreshLevel();
		this.RefreshState();
	}

	// Token: 0x060158D3 RID: 88275 RVA: 0x0057141C File Offset: 0x0056F61C
	public void OnNodeLevelChange(int nodeId)
	{
		if (nodeId == this.GetSkillNodeId())
		{
			this.OnSelfNodeLevelChange();
			return;
		}
		this.OnOtherNodeLevelChange();
	}

	// Token: 0x060158D4 RID: 88276 RVA: 0x00571434 File Offset: 0x0056F634
	public new virtual ESkillTreeNodeType? GetType()
	{
		return null;
	}

	// Token: 0x060158D5 RID: 88277 RVA: 0x0057144A File Offset: 0x0056F64A
	public virtual bool IsIconTexture()
	{
		return false;
	}

	// Token: 0x060158D6 RID: 88278 RVA: 0x0057144D File Offset: 0x0056F64D
	public ESkillTreeNodeState? GetState()
	{
		return this.State;
	}

	// Token: 0x060158D7 RID: 88279 RVA: 0x00571455 File Offset: 0x0056F655
	public void TriggerToggle()
	{
		this.OnToggleClick();
	}

	// Token: 0x060158D8 RID: 88280 RVA: 0x00571460 File Offset: 0x0056F660
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

	// Token: 0x060158D9 RID: 88281 RVA: 0x005715C4 File Offset: 0x0056F7C4
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

	// Token: 0x060158DA RID: 88282 RVA: 0x00571640 File Offset: 0x0056F840
	private bool CheckSkillBranchEnabled()
	{
		int roleId = this.GetRoleId();
		int skillNodeId = this.GetSkillNodeId();
		return roleId != 0 && skillNodeId != 0 && (this.IsSkillBranchEnable && RoleModel.Instance.IsRoleHasBranch(roleId)) && RoleModel.Instance.IsSkillNodeHasBranch(skillNodeId);
	}

	// Token: 0x060158DB RID: 88283 RVA: 0x00571685 File Offset: 0x0056F885
	public void OnSkillBranchChanged()
	{
		if (!this.CheckSkillBranchEnabled())
		{
			return;
		}
		this.RefreshSkillBranch(true);
	}

	// Token: 0x060158DC RID: 88284 RVA: 0x00571697 File Offset: 0x0056F897
	public void SetSkillBranchEnable(bool isEnable)
	{
		this.IsSkillBranchEnable = isEnable;
	}

	// Token: 0x060158DD RID: 88285 RVA: 0x005716A0 File Offset: 0x0056F8A0
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
			string resourcePath2 = UiResourceConfig.Instance.GetResourcePath("T_RoleDevelopRecommend");
			base.SetTextureByPath(resourcePath2, showTagTex, null, null);
			return;
		}
		showTagItem.SetUIActive(false);
	}

	// Token: 0x0400A081 RID: 41089
	private RoleSkillIconItem SkillIconItem;

	// Token: 0x0400A082 RID: 41090
	private ESkillTreeNodeState? State;

	// Token: 0x0400A083 RID: 41091
	private LevelSequencePlayer LeftBranchSequencePlayer;

	// Token: 0x0400A084 RID: 41092
	private LevelSequencePlayer RightBranchSequencePlayer;

	// Token: 0x0400A085 RID: 41093
	private bool IsSkillBranchEnable;
}
