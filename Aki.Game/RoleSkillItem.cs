using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x020015EC RID: 5612
[NullableContext(1)]
[Nullable(0)]
internal class RoleSkillItem : GridProxyAbstract<int>
{
	// Token: 0x06009E7B RID: 40571 RVA: 0x00229AE8 File Offset: 0x00227CE8
	protected unsafe override void OnRegisterComponent()
	{
		int num = 3;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIExtendToggle));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUISprite));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
		this.ComponentRegisterInfos = list;
		num2 = 1;
		List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
		CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
		Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
		num = 0;
		*span2[num] = new ValueTuple<int, Delegate>(0, new Action<EToggleState>(this.ToggleClick));
		this.BtnBindInfo = list2;
	}

	// Token: 0x06009E7C RID: 40572 RVA: 0x00229BB0 File Offset: 0x00227DB0
	public override void Refresh(int skillId, bool isSelected, int gridIndex)
	{
		this.SkillId = skillId;
		Aki.Config.Skill? skillConfigById = RoleSkillConfig.Instance.GetSkillConfigById(skillId);
		if (skillConfigById == null)
		{
			return;
		}
		UUISprite icon = base.GetSprite(1);
		icon.SetUIActive(false);
		this.SetSpriteByPath(skillConfigById.Value.Icon, icon, false, null, delegate(bool _)
		{
			icon.SetUIActive(true);
		});
		int roleId = WheelTowerModel.Instance.TryGetRealRoleId(WheelTowerModel.Instance.TmpSelectRoleId);
		UUIItem item = base.GetItem(2);
		if (item != null)
		{
			item.SetUIActive(WheelTowerModel.Instance.IsEnhanceSkill(roleId, skillId));
		}
		this.SetSelectedState(isSelected, true);
	}

	// Token: 0x06009E7D RID: 40573 RVA: 0x00229C66 File Offset: 0x00227E66
	public override object GetKey(int data, int gridIndex)
	{
		return data;
	}

	// Token: 0x06009E7E RID: 40574 RVA: 0x00229C6E File Offset: 0x00227E6E
	public override void OnDeselected(bool fireEvent)
	{
		this.SetSelectedState(false, false);
	}

	// Token: 0x06009E7F RID: 40575 RVA: 0x00229C78 File Offset: 0x00227E78
	public void SetToggleCallback(Action<int> callback)
	{
		this.ToggleCallback = callback;
	}

	// Token: 0x06009E80 RID: 40576 RVA: 0x00229C81 File Offset: 0x00227E81
	private void ToggleClick(EToggleState state)
	{
		Action<int> toggleCallback = this.ToggleCallback;
		if (toggleCallback == null)
		{
			return;
		}
		toggleCallback(this.SkillId);
	}

	// Token: 0x06009E81 RID: 40577 RVA: 0x00229C99 File Offset: 0x00227E99
	public void SetSelectedState(bool selected, bool skipAnim = false)
	{
		UUIExtendToggle extendToggle = base.GetExtendToggle(0);
		if (extendToggle == null)
		{
			return;
		}
		extendToggle.SetToggleStateForce(selected ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked, false, false, skipAnim);
	}

	// Token: 0x040046CE RID: 18126
	private int SkillId;

	// Token: 0x040046CF RID: 18127
	[Nullable(2)]
	private Action<int> ToggleCallback;
}
