using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.RoleUi;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02000647 RID: 1607
[NullableContext(1)]
[Nullable(0)]
public class BeginnerCarnivalChoseRoleView : UiViewBase
{
	// Token: 0x06004AA9 RID: 19113 RVA: 0x00196004 File Offset: 0x00194204
	public BeginnerCarnivalChoseRoleView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x06004AAA RID: 19114 RVA: 0x00196010 File Offset: 0x00194210
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIText)),
			new ValueTuple<int, Type>(1, typeof(UUIText)),
			new ValueTuple<int, Type>(2, typeof(UUIScrollViewWithScrollbarComponent)),
			new ValueTuple<int, Type>(3, typeof(UUIItem)),
			new ValueTuple<int, Type>(4, typeof(UUIText)),
			new ValueTuple<int, Type>(5, typeof(UUIButtonComponent))
		};
		this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
		{
			new ValueTuple<int, Delegate>(5, new Action(this.OnClickConfirmBtn))
		};
	}

	// Token: 0x06004AAB RID: 19115 RVA: 0x001960D0 File Offset: 0x001942D0
	protected override UniTask OnBeforeStartAsync()
	{
		BeginnerCarnivalChoseRoleView.<OnBeforeStartAsync>d__5 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<BeginnerCarnivalChoseRoleView.<OnBeforeStartAsync>d__5>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06004AAC RID: 19116 RVA: 0x00196114 File Offset: 0x00194314
	protected override void OnStart()
	{
		NewbieCarnivalParam? newbieCarnivalParam = BeginnerCarnivalConfig.Instance.GetNewbieCarnivalParam(BeginnerCarnivalController.Instance.ActivityId);
		List<int> list = (newbieCarnivalParam == null) ? new List<int>() : new List<int>(newbieCarnivalParam.Value.GetRolesArray());
		GenericScrollViewNew<RoleSelectItem, int> selectionScrollView = this.SelectionScrollView;
		if (selectionScrollView != null)
		{
			selectionScrollView.RefreshByData(list, delegate
			{
				int choseRoleId = BeginnerCarnivalController.Instance.GetBeginnerCarnivalData().ChoseRoleId;
				int val = list.IndexOf(choseRoleId);
				GenericLayout<RoleSelectItem, int> genericLayout = this.SelectionScrollView.GetGenericLayout();
				int num = Math.Max(val, 0);
				genericLayout.SelectGridProxy(num, false);
				this.OnItemSelect(list[num]);
				this.RoleId = list[num];
			}, false);
		}
		BeginnerCarnivalController.Instance.GetBeginnerCarnivalData().SetChoseRoleViewEnter();
	}

	// Token: 0x06004AAD RID: 19117 RVA: 0x001961A0 File Offset: 0x001943A0
	private void OnClickConfirmBtn()
	{
		if (this.RoleId != BeginnerCarnivalController.Instance.GetBeginnerCarnivalData().ChoseRoleId)
		{
			BeginnerCarnivalController.Instance.NewbieCarnivalSwitchRoleRequest(this.RoleId);
		}
		base.CloseMe(null);
	}

	// Token: 0x06004AAE RID: 19118 RVA: 0x001961D0 File Offset: 0x001943D0
	private RoleSelectItem CreateSelectionItem()
	{
		return new RoleSelectItem
		{
			ToggleCallBack = new Action<int, int>(this.SelectItemByIndex),
			CanToggleChange = new Func<int, bool>(this.CanToggleChange)
		};
	}

	// Token: 0x06004AAF RID: 19119 RVA: 0x001961FB File Offset: 0x001943FB
	private void SelectItemByIndex(int gridIndex, int roleId)
	{
		GenericScrollViewNew<RoleSelectItem, int> selectionScrollView = this.SelectionScrollView;
		if (selectionScrollView != null)
		{
			GenericLayout<RoleSelectItem, int> genericLayout = selectionScrollView.GetGenericLayout();
			if (genericLayout != null)
			{
				genericLayout.SelectGridProxy(gridIndex, false);
			}
		}
		this.OnItemSelect(roleId);
		this.RoleId = roleId;
	}

	// Token: 0x06004AB0 RID: 19120 RVA: 0x0019622C File Offset: 0x0019442C
	private bool CanToggleChange(int gridIndex)
	{
		GenericScrollViewNew<RoleSelectItem, int> selectionScrollView = this.SelectionScrollView;
		int? num;
		if (selectionScrollView == null)
		{
			num = null;
		}
		else
		{
			GenericLayout<RoleSelectItem, int> genericLayout = selectionScrollView.GetGenericLayout();
			num = ((genericLayout != null) ? new int?(genericLayout.GetSelectedGridIndex()) : null);
		}
		int? num2 = num;
		int? num3 = num2;
		return !(gridIndex == num3.GetValueOrDefault() & num3 != null);
	}

	// Token: 0x06004AB1 RID: 19121 RVA: 0x00196284 File Offset: 0x00194484
	private void OnItemSelect(int roleId)
	{
		RoleInfo value = RoleConfig.Instance.GetRoleConfig(roleId).Value;
		LguiUtil.Instance.SetLocalTextNew(base.GetText(4), value.Name, Array.Empty<object>());
		CharacterSmallItemGrid parameters = new CharacterSmallItemGrid
		{
			Data = null,
			ItemConfigId = new int?(roleId)
		};
		SmallItemGrid curSelectedItem = this.CurSelectedItem;
		if (curSelectedItem == null)
		{
			return;
		}
		curSelectedItem.Apply<CharacterSmallItemGrid>(parameters);
	}

	// Token: 0x04003737 RID: 14135
	private int RoleId;

	// Token: 0x04003738 RID: 14136
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private GenericScrollViewNew<RoleSelectItem, int> SelectionScrollView;

	// Token: 0x04003739 RID: 14137
	[Nullable(2)]
	private SmallItemGrid CurSelectedItem;
}
