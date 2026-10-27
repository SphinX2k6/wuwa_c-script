using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Protocol;
using CSharpScript.Game.Module.Util;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x0200159E RID: 5534
[NullableContext(2)]
[Nullable(new byte[]
{
	0,
	1
})]
public class WheelTowerRecommendTeam : GridProxyAbstract<NewTowerRecommendTeam>
{
	// Token: 0x17000D79 RID: 3449
	// (get) Token: 0x06009D89 RID: 40329 RVA: 0x00222E0A File Offset: 0x0022100A
	// (set) Token: 0x06009D8A RID: 40330 RVA: 0x00222E12 File Offset: 0x00221012
	[Nullable(new byte[]
	{
		2,
		1
	})]
	public Action<NewTowerRecommendTeam> OnApplyBtnClick { [return: Nullable(new byte[]
	{
		2,
		1
	})] get; [param: Nullable(new byte[]
	{
		2,
		1
	})] set; }

	// Token: 0x06009D8B RID: 40331 RVA: 0x00222E1C File Offset: 0x0022101C
	protected unsafe override void OnRegisterComponent()
	{
		int num = 7;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIHorizontalLayout));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIInteractionGroup));
		this.ComponentRegisterInfos = list;
		num2 = 1;
		List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
		CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
		Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
		num = 0;
		*span2[num] = new ValueTuple<int, Delegate>(5, new Action(delegate()
		{
			if (this.Data != null)
			{
				Action<NewTowerRecommendTeam> onApplyBtnClick = this.OnApplyBtnClick;
				if (onApplyBtnClick == null)
				{
					return;
				}
				onApplyBtnClick(this.Data);
			}
		}));
		this.BtnBindInfo = list2;
	}

	// Token: 0x06009D8C RID: 40332 RVA: 0x00222F68 File Offset: 0x00221168
	protected override UniTask OnBeforeStartAsync()
	{
		WheelTowerRecommendTeam.<OnBeforeStartAsync>d__8 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<WheelTowerRecommendTeam.<OnBeforeStartAsync>d__8>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06009D8D RID: 40333 RVA: 0x00222FAC File Offset: 0x002211AC
	[NullableContext(1)]
	public override void Refresh(NewTowerRecommendTeam data, bool isSelected, int gridIndex)
	{
		this.Data = data;
		UUIText text = base.GetText(0);
		if (text != null)
		{
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(0, 1);
			defaultInterpolatedStringHandler.AppendFormatted<int>(gridIndex + 1);
			text.SetText(defaultInterpolatedStringHandler.ToStringAndClear(), true);
		}
		List<RoleDataWithBranch> list = new List<RoleDataWithBranch>();
		for (int i = 0; i < data.RoleIds.Count; i++)
		{
			int roleId = data.RoleIds[i];
			int skillBranchId = (i < data.SkillBranchIds.Count) ? data.SkillBranchIds[i] : 0;
			list.Add(new RoleDataWithBranch(roleId, skillBranchId));
		}
		GenericLayout<WheelTowerRecommendRoleGridItem, RoleDataWithBranch> roleLayout = this.RoleLayout;
		if (roleLayout != null)
		{
			roleLayout.RefreshByData(list, null, false);
		}
		if (data.BuffIds.Count > 0)
		{
			WheelTowerBuffGridItem buffItem = this.BuffItem;
			if (buffItem != null)
			{
				buffItem.Refresh(data.BuffIds[0], false, 0);
			}
		}
		double value = Math.Floor((double)data.UsageRate) / 100.0;
		UUIText text2 = base.GetText(1);
		if (text2 != null)
		{
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 1);
			defaultInterpolatedStringHandler.AppendFormatted<double>(value, "F2");
			defaultInterpolatedStringHandler.AppendLiteral("%");
			text2.SetText(defaultInterpolatedStringHandler.ToStringAndClear(), true);
		}
		bool interactable = true;
		foreach (int roleId2 in data.RoleIds)
		{
			if (!RoleModel.Instance.IsHasRole(roleId2))
			{
				interactable = false;
				break;
			}
		}
		UUIInteractionGroup interactionGroup = base.GetInteractionGroup(6);
		if (interactionGroup == null)
		{
			return;
		}
		interactionGroup.SetInteractable(interactable);
	}

	// Token: 0x04004573 RID: 17779
	private NewTowerRecommendTeam Data;

	// Token: 0x04004574 RID: 17780
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private GenericLayout<WheelTowerRecommendRoleGridItem, RoleDataWithBranch> RoleLayout;

	// Token: 0x04004575 RID: 17781
	private WheelTowerBuffGridItem BuffItem;
}
