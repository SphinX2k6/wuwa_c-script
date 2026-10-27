using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Module.RoleUi;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x020013A2 RID: 5026
public class NewcomerJourneyChoseRoleView : UiViewBase
{
	// Token: 0x06008D3A RID: 36154 RVA: 0x001E5A1A File Offset: 0x001E3C1A
	[NullableContext(1)]
	public NewcomerJourneyChoseRoleView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x06008D3B RID: 36155 RVA: 0x001E5A24 File Offset: 0x001E3C24
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
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIScrollViewWithScrollbarComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIItem));
		this.ComponentRegisterInfos = list;
		num2 = 1;
		List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
		CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
		Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
		num = 0;
		*span2[num] = new ValueTuple<int, Delegate>(5, new Action(this.OnClickConfirmBtn));
		this.BtnBindInfo = list2;
	}

	// Token: 0x06008D3C RID: 36156 RVA: 0x001E5B70 File Offset: 0x001E3D70
	protected override UniTask OnBeforeStartAsync()
	{
		NewcomerJourneyChoseRoleView.<OnBeforeStartAsync>d__6 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<NewcomerJourneyChoseRoleView.<OnBeforeStartAsync>d__6>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06008D3D RID: 36157 RVA: 0x001E5BB4 File Offset: 0x001E3DB4
	protected override void OnStart()
	{
		ActivityNewcomerJourneyData newcomerJourneyData = ActivityNewcomerJourneyController.Instance.GetNewcomerJourneyData();
		List<int> list = new List<int>(ActivityNewcomerJourneyConfig.Instance.GetChapterById(newcomerJourneyData.ChooseRoleChapterId).Value.GetRolesArray());
		GenericScrollViewNew<NewcomerJourneyRoleSelectItem, int> selectionScrollView = this.SelectionScrollView;
		if (selectionScrollView != null)
		{
			selectionScrollView.RefreshByData(list, delegate
			{
				int num = 0;
				this.SelectionScrollView.GetGenericLayout().SelectGridProxy(num, false);
				this.OnItemSelect(list[num]);
				this.RoleId = list[num];
			}, false);
		}
		LguiUtil.Instance.SetLocalTextNew(base.GetText(0), "NewPlayer_Adventure_005", Array.Empty<object>());
		LguiUtil.Instance.SetLocalTextNew(base.GetText(1), "NewPlayer_Adventure_006", Array.Empty<object>());
		base.GetItem(7).SetUIActive(false);
	}

	// Token: 0x06008D3E RID: 36158 RVA: 0x001E5C6C File Offset: 0x001E3E6C
	private void OnClickConfirmBtn()
	{
		ActivityNewcomerJourneyData newcomerJourneyData = ActivityNewcomerJourneyController.Instance.GetNewcomerJourneyData();
		if (newcomerJourneyData.GetCanGetCharacter())
		{
			ActivityNewcomerJourneyController.Instance.GetSelectRole(newcomerJourneyData.Id, newcomerJourneyData.ChooseRoleChapterId, this.RoleId);
		}
		base.CloseMe(null);
	}

	// Token: 0x06008D3F RID: 36159 RVA: 0x001E5CAF File Offset: 0x001E3EAF
	[NullableContext(1)]
	private NewcomerJourneyRoleSelectItem CreateSelectionItem()
	{
		return new NewcomerJourneyRoleSelectItem
		{
			ToggleCallBack = new Action<int, int>(this.SelectItemByIndex),
			CanToggleChange = new Func<int, bool>(this.CanToggleChange),
			OpenCallBack = new Action(this.AfterOpenRoleView)
		};
	}

	// Token: 0x06008D40 RID: 36160 RVA: 0x001E5CEC File Offset: 0x001E3EEC
	private void AfterOpenRoleView()
	{
		base.CloseMe(null);
	}

	// Token: 0x06008D41 RID: 36161 RVA: 0x001E5CF5 File Offset: 0x001E3EF5
	private void SelectItemByIndex(int gridIndex, int roleId)
	{
		GenericScrollViewNew<NewcomerJourneyRoleSelectItem, int> selectionScrollView = this.SelectionScrollView;
		if (selectionScrollView != null)
		{
			GenericLayout<NewcomerJourneyRoleSelectItem, int> genericLayout = selectionScrollView.GetGenericLayout();
			if (genericLayout != null)
			{
				genericLayout.SelectGridProxy(gridIndex, false);
			}
		}
		this.OnItemSelect(roleId);
		this.RoleId = roleId;
	}

	// Token: 0x06008D42 RID: 36162 RVA: 0x001E5D24 File Offset: 0x001E3F24
	private bool CanToggleChange(int gridIndex)
	{
		GenericScrollViewNew<NewcomerJourneyRoleSelectItem, int> selectionScrollView = this.SelectionScrollView;
		int? num;
		if (selectionScrollView == null)
		{
			num = null;
		}
		else
		{
			GenericLayout<NewcomerJourneyRoleSelectItem, int> genericLayout = selectionScrollView.GetGenericLayout();
			num = ((genericLayout != null) ? new int?(genericLayout.GetSelectedGridIndex()) : null);
		}
		int? num2 = num;
		int? num3 = num2;
		return !(gridIndex == num3.GetValueOrDefault() & num3 != null);
	}

	// Token: 0x06008D43 RID: 36163 RVA: 0x001E5D7C File Offset: 0x001E3F7C
	private void OnItemSelect(int roleId)
	{
		RoleInfo? roleConfig = RoleConfig.Instance.GetRoleConfig(roleId);
		LguiUtil.Instance.SetLocalTextNew(base.GetText(4), roleConfig.Value.Name, Array.Empty<object>());
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

	// Token: 0x04003E90 RID: 16016
	private int RoleId;

	// Token: 0x04003E91 RID: 16017
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private GenericScrollViewNew<NewcomerJourneyRoleSelectItem, int> SelectionScrollView;

	// Token: 0x04003E92 RID: 16018
	[Nullable(2)]
	private SmallItemGrid CurSelectedItem;

	// Token: 0x02007A16 RID: 31254
	private class EComponentDefine
	{
		// Token: 0x040282F4 RID: 164596
		public const int TitleText = 0;

		// Token: 0x040282F5 RID: 164597
		public const int SubTitleText = 1;

		// Token: 0x040282F6 RID: 164598
		public const int ScrollView = 2;

		// Token: 0x040282F7 RID: 164599
		public const int RoleItem = 3;

		// Token: 0x040282F8 RID: 164600
		public const int RoleNameText = 4;

		// Token: 0x040282F9 RID: 164601
		public const int ConfirmBtn = 5;

		// Token: 0x040282FA RID: 164602
		public const int SelectText = 6;

		// Token: 0x040282FB RID: 164603
		public const int TipsText = 7;
	}
}
