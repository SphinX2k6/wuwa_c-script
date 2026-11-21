using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x02000AA4 RID: 2724
[NullableContext(1)]
[Nullable(0)]
internal class RoleSkillItem : GridProxyAbstract<int>
{
	// Token: 0x06007259 RID: 29273 RVA: 0x00233898 File Offset: 0x00231A98
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

	// Token: 0x0600725A RID: 29274 RVA: 0x00233960 File Offset: 0x00231B60
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

	// Token: 0x0600725B RID: 29275 RVA: 0x00233A16 File Offset: 0x00231C16
	public override object GetKey(int data, int gridIndex)
	{
		return data;
	}

	// Token: 0x0600725C RID: 29276 RVA: 0x00233A1E File Offset: 0x00231C1E
	public override void OnDeselected(bool fireEvent)
	{
		this.SetSelectedState(false, false);
	}

	// Token: 0x0600725D RID: 29277 RVA: 0x00233A28 File Offset: 0x00231C28
	public void SetToggleCallback(Action<int> callback)
	{
		this.ToggleCallback = callback;
	}

	// Token: 0x0600725E RID: 29278 RVA: 0x00233A31 File Offset: 0x00231C31
	private void ToggleClick(EToggleState state)
	{
		Action<int> toggleCallback = this.ToggleCallback;
		if (toggleCallback == null)
		{
			return;
		}
		toggleCallback(this.SkillId);
	}

	// Token: 0x0600725F RID: 29279 RVA: 0x00233A49 File Offset: 0x00231C49
	public void SetSelectedState(bool selected, bool skipAnim = false)
	{
		UUIExtendToggle extendToggle = base.GetExtendToggle(0);
		if (extendToggle == null)
		{
			return;
		}
		extendToggle.SetToggleStateForce(selected ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked, false, false, skipAnim);
	}

	// Token: 0x04004774 RID: 18292
	private int SkillId;

	// Token: 0x04004775 RID: 18293
	[Nullable(2)]
	private Action<int> ToggleCallback;
}
