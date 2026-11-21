using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02001E19 RID: 7705
[NullableContext(1)]
[Nullable(0)]
public abstract class CommonRoleSkillBranchSwitchItem : UiPanelBase
{
	// Token: 0x06013160 RID: 78176
	protected abstract SkillBranchSwitchItemGroup[] CollectBranchItems();

	// Token: 0x06013161 RID: 78177
	protected abstract UUIExtendToggle GetBranchToggle();

	// Token: 0x06013162 RID: 78178 RVA: 0x00594DC4 File Offset: 0x00592FC4
	protected CommonRoleSkillBranchSwitchFunction CreateCommonRoleSkillBranchSwitchFunction()
	{
		return new CommonRoleSkillBranchSwitchFunction
		{
			Toggle = this.GetBranchToggle(),
			SkillItemGroups = this.CollectBranchItems(),
			SetSpriteByPath = delegate(string path, UUISprite uiSprite, bool setSize)
			{
				this.SetSpriteByPath(path, uiSprite, setSize, null, null);
			},
			SwitchBranchHandler = this.SwitchBranchHandler
		};
	}

	// Token: 0x06013163 RID: 78179 RVA: 0x00594E01 File Offset: 0x00593001
	protected override void OnStart()
	{
		this.CommonRoleSkillBranchSwitchFunction = this.CreateCommonRoleSkillBranchSwitchFunction();
	}

	// Token: 0x06013164 RID: 78180 RVA: 0x00594E0F File Offset: 0x0059300F
	protected void OnToggleStateChange(EToggleState state)
	{
		CommonRoleSkillBranchSwitchFunction commonRoleSkillBranchSwitchFunction = this.CommonRoleSkillBranchSwitchFunction;
		if (commonRoleSkillBranchSwitchFunction == null)
		{
			return;
		}
		commonRoleSkillBranchSwitchFunction.OnToggleStateChange(state);
	}

	// Token: 0x06013165 RID: 78181 RVA: 0x00594E22 File Offset: 0x00593022
	public void SetActiveBranchIndex(int index)
	{
		CommonRoleSkillBranchSwitchFunction commonRoleSkillBranchSwitchFunction = this.CommonRoleSkillBranchSwitchFunction;
		if (commonRoleSkillBranchSwitchFunction == null)
		{
			return;
		}
		commonRoleSkillBranchSwitchFunction.SetActiveBranchIndex(index);
	}

	// Token: 0x06013166 RID: 78182 RVA: 0x00594E35 File Offset: 0x00593035
	public void RefreshIcon(Func<int, string> handler)
	{
		CommonRoleSkillBranchSwitchFunction commonRoleSkillBranchSwitchFunction = this.CommonRoleSkillBranchSwitchFunction;
		if (commonRoleSkillBranchSwitchFunction == null)
		{
			return;
		}
		commonRoleSkillBranchSwitchFunction.RefreshIcon(handler);
	}

	// Token: 0x06013167 RID: 78183 RVA: 0x00594E48 File Offset: 0x00593048
	public void SetToggleInteractive(bool interactive)
	{
		UUIExtendToggle branchToggle = this.GetBranchToggle();
		if (branchToggle == null)
		{
			return;
		}
		branchToggle.SetSelfInteractive(interactive);
	}

	// Token: 0x0400A3E5 RID: 41957
	[Nullable(2)]
	protected CommonRoleSkillBranchSwitchFunction CommonRoleSkillBranchSwitchFunction;

	// Token: 0x0400A3E6 RID: 41958
	[Nullable(2)]
	public Action<int> SwitchBranchHandler;
}
