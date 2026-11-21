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

// Token: 0x02000856 RID: 2134
public class NewcomerJourneyChoseRoleView : UiViewBase
{
	// Token: 0x060060D0 RID: 24784 RVA: 0x001EE64E File Offset: 0x001EC84E
	[NullableContext(1)]
	public NewcomerJourneyChoseRoleView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x060060D1 RID: 24785 RVA: 0x001EE658 File Offset: 0x001EC858
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

	// Token: 0x060060D2 RID: 24786 RVA: 0x001EE7A4 File Offset: 0x001EC9A4
	protected override UniTask OnBeforeStartAsync()
	{
		NewcomerJourneyChoseRoleView.<OnBeforeStartAsync>d__6 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<NewcomerJourneyChoseRoleView.<OnBeforeStartAsync>d__6>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x060060D3 RID: 24787 RVA: 0x001EE7E8 File Offset: 0x001EC9E8
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

	// Token: 0x060060D4 RID: 24788 RVA: 0x001EE8A0 File Offset: 0x001ECAA0
	private void OnClickConfirmBtn()
	{
		ActivityNewcomerJourneyData newcomerJourneyData = ActivityNewcomerJourneyController.Instance.GetNewcomerJourneyData();
		if (newcomerJourneyData.GetCanGetCharacter())
		{
			ActivityNewcomerJourneyController.Instance.GetSelectRole(newcomerJourneyData.Id, newcomerJourneyData.ChooseRoleChapterId, this.RoleId);
		}
		base.CloseMe(null);
	}

	// Token: 0x060060D5 RID: 24789 RVA: 0x001EE8E3 File Offset: 0x001ECAE3
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

	// Token: 0x060060D6 RID: 24790 RVA: 0x001EE920 File Offset: 0x001ECB20
	private void AfterOpenRoleView()
	{
		base.CloseMe(null);
	}

	// Token: 0x060060D7 RID: 24791 RVA: 0x001EE929 File Offset: 0x001ECB29
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

	// Token: 0x060060D8 RID: 24792 RVA: 0x001EE958 File Offset: 0x001ECB58
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

	// Token: 0x060060D9 RID: 24793 RVA: 0x001EE9B0 File Offset: 0x001ECBB0
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

	// Token: 0x04003F28 RID: 16168
	private int RoleId;

	// Token: 0x04003F29 RID: 16169
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private GenericScrollViewNew<NewcomerJourneyRoleSelectItem, int> SelectionScrollView;

	// Token: 0x04003F2A RID: 16170
	[Nullable(2)]
	private SmallItemGrid CurSelectedItem;

	// Token: 0x02006B9D RID: 27549
	private class EComponentDefine
	{
		// Token: 0x04023614 RID: 144916
		public const int TitleText = 0;

		// Token: 0x04023615 RID: 144917
		public const int SubTitleText = 1;

		// Token: 0x04023616 RID: 144918
		public const int ScrollView = 2;

		// Token: 0x04023617 RID: 144919
		public const int RoleItem = 3;

		// Token: 0x04023618 RID: 144920
		public const int RoleNameText = 4;

		// Token: 0x04023619 RID: 144921
		public const int ConfirmBtn = 5;

		// Token: 0x0402361A RID: 144922
		public const int SelectText = 6;

		// Token: 0x0402361B RID: 144923
		public const int TipsText = 7;
	}
}
