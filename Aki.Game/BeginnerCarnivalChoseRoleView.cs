using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.RoleUi;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02001193 RID: 4499
[NullableContext(1)]
[Nullable(0)]
public class BeginnerCarnivalChoseRoleView : UiViewBase
{
	// Token: 0x06007712 RID: 30482 RVA: 0x0018D418 File Offset: 0x0018B618
	public BeginnerCarnivalChoseRoleView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x06007713 RID: 30483 RVA: 0x0018D424 File Offset: 0x0018B624
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

	// Token: 0x06007714 RID: 30484 RVA: 0x0018D4E4 File Offset: 0x0018B6E4
	protected override UniTask OnBeforeStartAsync()
	{
		BeginnerCarnivalChoseRoleView.<OnBeforeStartAsync>d__5 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<BeginnerCarnivalChoseRoleView.<OnBeforeStartAsync>d__5>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06007715 RID: 30485 RVA: 0x0018D528 File Offset: 0x0018B728
	protected override void OnStart()
	{
		NewbieCarnivalParam? newbieCarnivalParam;
		List<int> list = ((BeginnerCarnivalConfig.Instance.GetNewbieCarnivalParam(BeginnerCarnivalController.Instance.ActivityId) != null) ? newbieCarnivalParam.GetValueOrDefault().GetRolesArray().ToList<int>() : null) ?? new List<int>();
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

	// Token: 0x06007716 RID: 30486 RVA: 0x0018D5B9 File Offset: 0x0018B7B9
	private void OnClickConfirmBtn()
	{
		if (this.RoleId != BeginnerCarnivalController.Instance.GetBeginnerCarnivalData().ChoseRoleId)
		{
			BeginnerCarnivalController.Instance.NewbieCarnivalSwitchRoleRequest(this.RoleId);
		}
		base.CloseMe(null);
	}

	// Token: 0x06007717 RID: 30487 RVA: 0x0018D5E9 File Offset: 0x0018B7E9
	private RoleSelectItem CreateSelectionItem()
	{
		return new RoleSelectItem
		{
			ToggleCallBack = new Action<int, int>(this.SelectItemByIndex),
			CanToggleChange = new Func<int, bool>(this.CanToggleChange)
		};
	}

	// Token: 0x06007718 RID: 30488 RVA: 0x0018D614 File Offset: 0x0018B814
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

	// Token: 0x06007719 RID: 30489 RVA: 0x0018D644 File Offset: 0x0018B844
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

	// Token: 0x0600771A RID: 30490 RVA: 0x0018D69C File Offset: 0x0018B89C
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

	// Token: 0x0400369E RID: 13982
	private int RoleId;

	// Token: 0x0400369F RID: 13983
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private GenericScrollViewNew<RoleSelectItem, int> SelectionScrollView;

	// Token: 0x040036A0 RID: 13984
	[Nullable(2)]
	private SmallItemGrid CurSelectedItem;
}
