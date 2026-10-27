using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Common.MediumItemGrid;
using CSharpScript.Game.Module.Util;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02002D1A RID: 11546
[NullableContext(1)]
[Nullable(0)]
public class WeaponListComponent
{
	// Token: 0x06018439 RID: 99385 RVA: 0x0062C58F File Offset: 0x0062A78F
	public void Init(UUIScrollViewWithScrollbarComponent scrollView)
	{
		this.ScrollView = new GenericScrollViewNew<WeaponItemSmallItemGrid, WeaponDataBase>(scrollView, new Func<WeaponItemSmallItemGrid>(this.InitWeaponItem), null, false, null);
	}

	// Token: 0x0601843A RID: 99386 RVA: 0x0062C5AC File Offset: 0x0062A7AC
	protected WeaponItemSmallItemGrid InitWeaponItem()
	{
		WeaponItemSmallItemGrid weaponItemSmallItemGrid = new WeaponItemSmallItemGrid();
		weaponItemSmallItemGrid.BindOnExtendToggleStateChanged(new Action<MediumItemGridExtendCallback>(this.OnToggleClick));
		weaponItemSmallItemGrid.BindOnCanExecuteChange(new Func<object, bool, EToggleState, bool>(this.CanToggleExecuteChange));
		return weaponItemSmallItemGrid;
	}

	// Token: 0x0601843B RID: 99387 RVA: 0x0062C5D7 File Offset: 0x0062A7D7
	public void SetWeaponChangeCallBack(Action callBack)
	{
		this.OnWeaponChangeCallBack = callBack;
	}

	// Token: 0x0601843C RID: 99388 RVA: 0x0062C5E0 File Offset: 0x0062A7E0
	public UniTask UpdateDataList(List<WeaponDataBase> dataList)
	{
		WeaponListComponent.<UpdateDataList>d__6 <UpdateDataList>d__;
		<UpdateDataList>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<UpdateDataList>d__.<>4__this = this;
		<UpdateDataList>d__.dataList = dataList;
		<UpdateDataList>d__.<>1__state = -1;
		<UpdateDataList>d__.<>t__builder.Start<WeaponListComponent.<UpdateDataList>d__6>(ref <UpdateDataList>d__);
		return <UpdateDataList>d__.<>t__builder.Task;
	}

	// Token: 0x0601843D RID: 99389 RVA: 0x0062C62C File Offset: 0x0062A82C
	public void SetCurSelect(int selectedIndex)
	{
		if (this.WeaponDataList == null || selectedIndex < 0 || selectedIndex >= this.WeaponDataList.Count || selectedIndex == this.ScrollView.GetGenericLayout().GetSelectedGridIndex())
		{
			return;
		}
		WeaponItemSmallItemGrid scrollItemByIndex = this.ScrollView.GetScrollItemByIndex(selectedIndex);
		if (scrollItemByIndex != null)
		{
			if (scrollItemByIndex != null)
			{
				scrollItemByIndex.SetSelected(true, false);
			}
			this.OnItemToggleCallBack(selectedIndex);
		}
	}

	// Token: 0x0601843E RID: 99390 RVA: 0x0062C689 File Offset: 0x0062A889
	private bool CanToggleExecuteChange(object data, bool isForceSelected, EToggleState state)
	{
		return this.GetCurSelectedData() != data;
	}

	// Token: 0x0601843F RID: 99391 RVA: 0x0062C698 File Offset: 0x0062A898
	private void OnToggleClick(MediumItemGridExtendCallback callbackParameter)
	{
		if (callbackParameter.State == EToggleState.ETT_Checked)
		{
			WeaponItemSmallItemGrid weaponItemSmallItemGrid = callbackParameter.MediumItemGrid as WeaponItemSmallItemGrid;
			if (weaponItemSmallItemGrid != null)
			{
				this.OnItemToggleCallBack(weaponItemSmallItemGrid.GridIndex);
			}
		}
	}

	// Token: 0x06018440 RID: 99392 RVA: 0x0062C6C9 File Offset: 0x0062A8C9
	private void OnItemToggleCallBack(int index)
	{
		GenericLayout<WeaponItemSmallItemGrid, WeaponDataBase> genericLayout = this.ScrollView.GetGenericLayout();
		if (genericLayout != null)
		{
			genericLayout.DeselectCurrentGridProxy();
		}
		GenericLayout<WeaponItemSmallItemGrid, WeaponDataBase> genericLayout2 = this.ScrollView.GetGenericLayout();
		if (genericLayout2 != null)
		{
			genericLayout2.SelectGridProxy(index, false);
		}
		Action onWeaponChangeCallBack = this.OnWeaponChangeCallBack;
		if (onWeaponChangeCallBack == null)
		{
			return;
		}
		onWeaponChangeCallBack();
	}

	// Token: 0x06018441 RID: 99393 RVA: 0x0062C70C File Offset: 0x0062A90C
	[NullableContext(2)]
	public WeaponDataBase GetCurSelectedData()
	{
		int selectedGridIndex = this.ScrollView.GetGenericLayout().GetSelectedGridIndex();
		if (this.WeaponDataList == null || selectedGridIndex < 0 || selectedGridIndex >= this.WeaponDataList.Count)
		{
			return null;
		}
		return this.WeaponDataList[selectedGridIndex];
	}

	// Token: 0x06018442 RID: 99394 RVA: 0x0062C752 File Offset: 0x0062A952
	public void CancelSelect()
	{
		GenericLayout<WeaponItemSmallItemGrid, WeaponDataBase> genericLayout = this.ScrollView.GetGenericLayout();
		if (genericLayout == null)
		{
			return;
		}
		genericLayout.DeselectCurrentGridProxy();
	}

	// Token: 0x0400B439 RID: 46137
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private List<WeaponDataBase> WeaponDataList;

	// Token: 0x0400B43A RID: 46138
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private GenericScrollViewNew<WeaponItemSmallItemGrid, WeaponDataBase> ScrollView;

	// Token: 0x0400B43B RID: 46139
	[Nullable(2)]
	private Action OnWeaponChangeCallBack;
}
