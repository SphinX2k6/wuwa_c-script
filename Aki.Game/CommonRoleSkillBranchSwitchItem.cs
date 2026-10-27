using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x0200289E RID: 10398
[NullableContext(1)]
[Nullable(0)]
public abstract class CommonRoleSkillBranchSwitchItem : UiPanelBase
{
	// Token: 0x06015760 RID: 87904
	protected abstract SkillBranchSwitchItemGroup[] CollectBranchItems();

	// Token: 0x06015761 RID: 87905
	protected abstract UUIExtendToggle GetBranchToggle();

	// Token: 0x06015762 RID: 87906 RVA: 0x00569F7C File Offset: 0x0056817C
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

	// Token: 0x06015763 RID: 87907 RVA: 0x00569FB9 File Offset: 0x005681B9
	protected override void OnStart()
	{
		this.CommonRoleSkillBranchSwitchFunction = this.CreateCommonRoleSkillBranchSwitchFunction();
	}

	// Token: 0x06015764 RID: 87908 RVA: 0x00569FC7 File Offset: 0x005681C7
	protected void OnToggleStateChange(EToggleState state)
	{
		CommonRoleSkillBranchSwitchFunction commonRoleSkillBranchSwitchFunction = this.CommonRoleSkillBranchSwitchFunction;
		if (commonRoleSkillBranchSwitchFunction == null)
		{
			return;
		}
		commonRoleSkillBranchSwitchFunction.OnToggleStateChange(state);
	}

	// Token: 0x06015765 RID: 87909 RVA: 0x00569FDA File Offset: 0x005681DA
	public void SetActiveBranchIndex(int index)
	{
		CommonRoleSkillBranchSwitchFunction commonRoleSkillBranchSwitchFunction = this.CommonRoleSkillBranchSwitchFunction;
		if (commonRoleSkillBranchSwitchFunction == null)
		{
			return;
		}
		commonRoleSkillBranchSwitchFunction.SetActiveBranchIndex(index);
	}

	// Token: 0x06015766 RID: 87910 RVA: 0x00569FED File Offset: 0x005681ED
	public void RefreshIcon(Func<int, string> handler)
	{
		CommonRoleSkillBranchSwitchFunction commonRoleSkillBranchSwitchFunction = this.CommonRoleSkillBranchSwitchFunction;
		if (commonRoleSkillBranchSwitchFunction == null)
		{
			return;
		}
		commonRoleSkillBranchSwitchFunction.RefreshIcon(handler);
	}

	// Token: 0x06015767 RID: 87911 RVA: 0x0056A000 File Offset: 0x00568200
	public void SetToggleInteractive(bool interactive)
	{
		UUIExtendToggle branchToggle = this.GetBranchToggle();
		if (branchToggle == null)
		{
			return;
		}
		branchToggle.SetSelfInteractive(interactive);
	}

	// Token: 0x04009FFC RID: 40956
	[Nullable(2)]
	protected CommonRoleSkillBranchSwitchFunction CommonRoleSkillBranchSwitchFunction;

	// Token: 0x04009FFD RID: 40957
	[Nullable(2)]
	public Action<int> SwitchBranchHandler;
}
