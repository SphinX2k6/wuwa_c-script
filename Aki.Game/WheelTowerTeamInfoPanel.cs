using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x020015CA RID: 5578
[NullableContext(2)]
[Nullable(0)]
public class WheelTowerTeamInfoPanel : UiPanelBase
{
	// Token: 0x17000D7F RID: 3455
	// (get) Token: 0x06009E08 RID: 40456 RVA: 0x00226302 File Offset: 0x00224502
	// (set) Token: 0x06009E09 RID: 40457 RVA: 0x0022630A File Offset: 0x0022450A
	public Action ClickCallback { get; set; }

	// Token: 0x06009E0A RID: 40458 RVA: 0x00226314 File Offset: 0x00224514
	protected unsafe override void OnRegisterComponent()
	{
		int num = 9;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIHorizontalLayout));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(8, typeof(UUITexture));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(9, typeof(UUITexture));
		this.ComponentRegisterInfos = list;
		num2 = 2;
		List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
		CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
		Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
		num = 0;
		*span2[num] = new ValueTuple<int, Delegate>(0, new Action(this.OnRecommendBtnClick));
		num++;
		*span2[num] = new ValueTuple<int, Delegate>(2, new Action(this.OnClick));
		this.BtnBindInfo = list2;
	}

	// Token: 0x06009E0B RID: 40459 RVA: 0x002264C8 File Offset: 0x002246C8
	protected override UniTask OnBeforeStartAsync()
	{
		WheelTowerTeamInfoPanel.<OnBeforeStartAsync>d__7 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<WheelTowerTeamInfoPanel.<OnBeforeStartAsync>d__7>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06009E0C RID: 40460 RVA: 0x0022650C File Offset: 0x0022470C
	[NullableContext(1)]
	public void RefreshRoleList(List<RoleDataWithBranch> roleDataList)
	{
		GenericLayout<WheelTowerRoleItem, RoleDataWithBranch> roleIconLayout = this.RoleIconLayout;
		if (roleIconLayout != null)
		{
			roleIconLayout.RefreshByData(roleDataList, null, false);
		}
		List<IConflictInfo> list = WheelTowerModel.Instance.CheckCurrentSelectConflict();
		bool uiactive = false;
		foreach (IConflictInfo conflictInfo in list)
		{
			if (WheelTowerModel.Instance.SelectedEnergyInfo.GetRoleEnergy(conflictInfo.RoleId) > 0)
			{
				uiactive = true;
				break;
			}
		}
		UUIItem item = base.GetItem(7);
		if (item == null)
		{
			return;
		}
		item.SetUIActive(uiactive);
	}

	// Token: 0x06009E0D RID: 40461 RVA: 0x002265A0 File Offset: 0x002247A0
	public void RefreshBuff(int buffId)
	{
		WheelTowerSmallBuffItem buffItem = this.BuffItem;
		if (buffItem == null)
		{
			return;
		}
		buffItem.Refresh(buffId);
	}

	// Token: 0x06009E0E RID: 40462 RVA: 0x002265B4 File Offset: 0x002247B4
	protected override void OnBeforeShow()
	{
		UUIItem item = base.GetItem(1);
		if (item != null)
		{
			item.SetUIActive(false);
		}
		int num = WheelTowerModel.Instance.SelectedRound + 1;
		string text;
		if (num / 10 <= 0)
		{
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 1);
			defaultInterpolatedStringHandler.AppendLiteral("0");
			defaultInterpolatedStringHandler.AppendFormatted<int>(num);
			text = defaultInterpolatedStringHandler.ToStringAndClear();
		}
		else
		{
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(0, 1);
			defaultInterpolatedStringHandler.AppendFormatted<int>(num);
			text = defaultInterpolatedStringHandler.ToStringAndClear();
		}
		string newText = text;
		UUIText text2 = base.GetText(3);
		if (text2 == null)
		{
			return;
		}
		text2.SetText(newText, true);
	}

	// Token: 0x06009E0F RID: 40463 RVA: 0x0022663A File Offset: 0x0022483A
	private void OnClick()
	{
		Action clickCallback = this.ClickCallback;
		if (clickCallback == null)
		{
			return;
		}
		clickCallback();
	}

	// Token: 0x06009E10 RID: 40464 RVA: 0x0022664C File Offset: 0x0022484C
	private void OnRecommendBtnClick()
	{
		UiManager.Instance.OpenView(EUiViewName.WheelTowerRecommendView, null, null);
	}

	// Token: 0x04004628 RID: 17960
	private WheelTowerSmallBuffItem BuffItem;

	// Token: 0x04004629 RID: 17961
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private GenericLayout<WheelTowerRoleItem, RoleDataWithBranch> RoleIconLayout;
}
