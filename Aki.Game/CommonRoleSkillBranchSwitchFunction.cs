using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

// Token: 0x02001E18 RID: 7704
[NullableContext(2)]
[Nullable(0)]
public class CommonRoleSkillBranchSwitchFunction
{
	// Token: 0x0601315B RID: 78171 RVA: 0x00594C70 File Offset: 0x00592E70
	public void OnToggleStateChange(EToggleState state)
	{
		int num = (state != EToggleState.ETT_Checked) ? 1 : 0;
		this.SetActiveBranchIndex(num);
		Action<int> switchBranchHandler = this.SwitchBranchHandler;
		if (switchBranchHandler == null)
		{
			return;
		}
		switchBranchHandler(num);
	}

	// Token: 0x0601315C RID: 78172 RVA: 0x00594CA0 File Offset: 0x00592EA0
	private void SetSkillBranchState(int index, bool state)
	{
		SkillBranchSwitchItemGroup[] skillItemGroups = this.SkillItemGroups;
		SkillBranchSwitchItemGroup skillBranchSwitchItemGroup = (skillItemGroups != null) ? skillItemGroups[index] : null;
		if (skillBranchSwitchItemGroup == null)
		{
			return;
		}
		Action<bool> activeIndexHandler = skillBranchSwitchItemGroup.ActiveIndexHandler;
		if (activeIndexHandler == null)
		{
			return;
		}
		activeIndexHandler(state);
	}

	// Token: 0x0601315D RID: 78173 RVA: 0x00594CD4 File Offset: 0x00592ED4
	public void SetActiveBranchIndex(int index)
	{
		UUIExtendToggle toggle = this.Toggle;
		if (toggle != null)
		{
			toggle.SetToggleState((index == 1) ? EToggleState.ETT_UnChecked : EToggleState.ETT_Checked, false, false, false);
		}
		int num = 0;
		for (;;)
		{
			int num2 = num;
			SkillBranchSwitchItemGroup[] skillItemGroups = this.SkillItemGroups;
			int? num3 = (skillItemGroups != null) ? new int?(skillItemGroups.Length) : null;
			if (!(num2 < num3.GetValueOrDefault() & num3 != null))
			{
				break;
			}
			this.SetSkillBranchState(num, num == index);
			num++;
		}
	}

	// Token: 0x0601315E RID: 78174 RVA: 0x00594D44 File Offset: 0x00592F44
	[NullableContext(1)]
	public void RefreshIcon(Func<int, string> handler)
	{
		int num = 0;
		for (;;)
		{
			int num2 = num;
			SkillBranchSwitchItemGroup[] skillItemGroups = this.SkillItemGroups;
			int? num3 = (skillItemGroups != null) ? new int?(skillItemGroups.Length) : null;
			if (!(num2 < num3.GetValueOrDefault() & num3 != null))
			{
				break;
			}
			SkillBranchSwitchItemGroup[] skillItemGroups2 = this.SkillItemGroups;
			UUISprite uuisprite = (skillItemGroups2 != null) ? skillItemGroups2[num].SpriteTagIcon : null;
			if (uuisprite != null)
			{
				Action<string, UUISprite, bool> setSpriteByPath = this.SetSpriteByPath;
				if (setSpriteByPath != null)
				{
					setSpriteByPath(handler(num), uuisprite, false);
				}
			}
			num++;
		}
	}

	// Token: 0x0400A3E1 RID: 41953
	[Nullable(new byte[]
	{
		2,
		1
	})]
	public SkillBranchSwitchItemGroup[] SkillItemGroups;

	// Token: 0x0400A3E2 RID: 41954
	public Action<int> SwitchBranchHandler;

	// Token: 0x0400A3E3 RID: 41955
	public UUIExtendToggle Toggle;

	// Token: 0x0400A3E4 RID: 41956
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	public Action<string, UUISprite, bool> SetSpriteByPath;
}
