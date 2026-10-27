using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

// Token: 0x0200289D RID: 10397
[NullableContext(2)]
[Nullable(0)]
public class CommonRoleSkillBranchSwitchFunction
{
	// Token: 0x0601575B RID: 87899 RVA: 0x00569E28 File Offset: 0x00568028
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

	// Token: 0x0601575C RID: 87900 RVA: 0x00569E58 File Offset: 0x00568058
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

	// Token: 0x0601575D RID: 87901 RVA: 0x00569E8C File Offset: 0x0056808C
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

	// Token: 0x0601575E RID: 87902 RVA: 0x00569EFC File Offset: 0x005680FC
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

	// Token: 0x04009FF8 RID: 40952
	[Nullable(new byte[]
	{
		2,
		1
	})]
	public SkillBranchSwitchItemGroup[] SkillItemGroups;

	// Token: 0x04009FF9 RID: 40953
	public Action<int> SwitchBranchHandler;

	// Token: 0x04009FFA RID: 40954
	public UUIExtendToggle Toggle;

	// Token: 0x04009FFB RID: 40955
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	public Action<string, UUISprite, bool> SetSpriteByPath;
}
