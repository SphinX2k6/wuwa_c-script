using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Common.MediumItemGrid;
using CSharpScript.Game.Module.Util;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02002274 RID: 8820
[NullableContext(1)]
[Nullable(0)]
public class WeaponListComponent
{
	// Token: 0x06015CDA RID: 89306 RVA: 0x00652583 File Offset: 0x00650783
	public void Init(UUIScrollViewWithScrollbarComponent scrollView)
	{
		this.ScrollView = new GenericScrollViewNew<WeaponItemSmallItemGrid, WeaponDataBase>(scrollView, new Func<WeaponItemSmallItemGrid>(this.InitWeaponItem), null, false, null);
	}

	// Token: 0x06015CDB RID: 89307 RVA: 0x006525A0 File Offset: 0x006507A0
	protected WeaponItemSmallItemGrid InitWeaponItem()
	{
		WeaponItemSmallItemGrid weaponItemSmallItemGrid = new WeaponItemSmallItemGrid();
		weaponItemSmallItemGrid.BindOnExtendToggleStateChanged(new Action<MediumItemGridExtendCallback>(this.OnToggleClick));
		weaponItemSmallItemGrid.BindOnCanExecuteChange(new Func<object, bool, EToggleState, bool>(this.CanToggleExecuteChange));
		return weaponItemSmallItemGrid;
	}

	// Token: 0x06015CDC RID: 89308 RVA: 0x006525CB File Offset: 0x006507CB
	public void SetWeaponChangeCallBack(Action callBack)
	{
		this.OnWeaponChangeCallBack = callBack;
	}

	// Token: 0x06015CDD RID: 89309 RVA: 0x006525D4 File Offset: 0x006507D4
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

	// Token: 0x06015CDE RID: 89310 RVA: 0x00652620 File Offset: 0x00650820
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

	// Token: 0x06015CDF RID: 89311 RVA: 0x0065267D File Offset: 0x0065087D
	private bool CanToggleExecuteChange(object data, bool isForceSelected, EToggleState state)
	{
		return this.GetCurSelectedData() != data;
	}

	// Token: 0x06015CE0 RID: 89312 RVA: 0x0065268C File Offset: 0x0065088C
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

	// Token: 0x06015CE1 RID: 89313 RVA: 0x006526BD File Offset: 0x006508BD
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

	// Token: 0x06015CE2 RID: 89314 RVA: 0x00652700 File Offset: 0x00650900
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

	// Token: 0x06015CE3 RID: 89315 RVA: 0x00652746 File Offset: 0x00650946
	public void CancelSelect()
	{
		GenericLayout<WeaponItemSmallItemGrid, WeaponDataBase> genericLayout = this.ScrollView.GetGenericLayout();
		if (genericLayout == null)
		{
			return;
		}
		genericLayout.DeselectCurrentGridProxy();
	}

	// Token: 0x0400B7AE RID: 47022
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private List<WeaponDataBase> WeaponDataList;

	// Token: 0x0400B7AF RID: 47023
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private GenericScrollViewNew<WeaponItemSmallItemGrid, WeaponDataBase> ScrollView;

	// Token: 0x0400B7B0 RID: 47024
	[Nullable(2)]
	private Action OnWeaponChangeCallBack;
}
