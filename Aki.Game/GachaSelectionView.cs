using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Inventory;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02001147 RID: 4423
[NullableContext(1)]
[Nullable(0)]
public class GachaSelectionView : UiViewBase
{
	// Token: 0x0600B07A RID: 45178 RVA: 0x00341A66 File Offset: 0x0033FC66
	public GachaSelectionView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x17001210 RID: 4624
	// (get) Token: 0x0600B07B RID: 45179 RVA: 0x00341A70 File Offset: 0x0033FC70
	private int CurSelectedPoolId
	{
		get
		{
			int selectedGridIndex = this.SelectionScrollView.GetGenericLayout().GetSelectedGridIndex();
			if (this.SelectionDataList == null || selectedGridIndex < 0 || selectedGridIndex >= this.SelectionDataList.Length)
			{
				return 0;
			}
			return this.SelectionDataList[selectedGridIndex].PoolInfo.Id;
		}
	}

	// Token: 0x0600B07C RID: 45180 RVA: 0x00341ABC File Offset: 0x0033FCBC
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
		*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIText));
		this.ComponentRegisterInfos = list;
		num2 = 1;
		List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
		CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
		Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
		num = 0;
		*span2[num] = new ValueTuple<int, Delegate>(5, new Action(this.OnConfirmBtnClick));
		this.BtnBindInfo = list2;
	}

	// Token: 0x0600B07D RID: 45181 RVA: 0x00341C07 File Offset: 0x0033FE07
	protected override void OnAddEventListener()
	{
		EventSystem.Instance.Add(EEventName.GachaSelectionViewRefresh, new Action<ProtoGachaInfo>(this.OnDataChange));
	}

	// Token: 0x0600B07E RID: 45182 RVA: 0x00341C25 File Offset: 0x0033FE25
	protected override void OnRemoveEventListener()
	{
		EventSystem.Instance.Remove(EEventName.GachaSelectionViewRefresh, new Action<ProtoGachaInfo>(this.OnDataChange));
	}

	// Token: 0x0600B07F RID: 45183 RVA: 0x00341C44 File Offset: 0x0033FE44
	private void OnConfirmBtnClick()
	{
		int curSelectedPoolId = this.CurSelectedPoolId;
		this.ReportGachaSelection(curSelectedPoolId);
		GachaController.Instance.GachaUsePoolRequest(this.GachaInfo.Id, curSelectedPoolId);
		UiManager.Instance.CloseView(EUiViewName.GachaSelectionView, null);
	}

	// Token: 0x0600B080 RID: 45184 RVA: 0x00341C88 File Offset: 0x0033FE88
	private void ReportGachaSelection(int poolId)
	{
		GachaViewInfo? gachaViewInfo = GachaConfig.Instance.GetGachaViewInfo(poolId);
		if (gachaViewInfo == null)
		{
			return;
		}
		double poolEndTimeByPoolId = this.GachaInfo.GetPoolEndTimeByPoolId(poolId);
		OnConfirmGachaSelectionLogEvent onConfirmGachaSelectionLogEvent = new OnConfirmGachaSelectionLogEvent();
		onConfirmGachaSelectionLogEvent.i_type = gachaViewInfo.Value.Type;
		onConfirmGachaSelectionLogEvent.i_roleid_id = gachaViewInfo.Value.ShowIdList()[0];
		onConfirmGachaSelectionLogEvent.i_time_left = ((poolEndTimeByPoolId > 0.0) ? ((int)(poolEndTimeByPoolId - TimeUtil.Instance.GetServerTime())) : 0);
		LogReportController.Instance.LogReport(onConfirmGachaSelectionLogEvent);
	}

	// Token: 0x0600B081 RID: 45185 RVA: 0x00341D17 File Offset: 0x0033FF17
	private void OnDataChange(ProtoGachaInfo gachaInfo)
	{
		this.GachaInfo = gachaInfo;
		this.RefreshSelection();
	}

	// Token: 0x0600B082 RID: 45186 RVA: 0x00341D28 File Offset: 0x0033FF28
	protected override UniTask OnBeforeStartAsync()
	{
		GachaSelectionView.<OnBeforeStartAsync>d__14 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<GachaSelectionView.<OnBeforeStartAsync>d__14>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600B083 RID: 45187 RVA: 0x00341D6B File Offset: 0x0033FF6B
	private GachaSelectionItem CreateSelectionItem()
	{
		return new GachaSelectionItem
		{
			ToggleCallBack = new Action<int>(this.SelectItemByIndex),
			CanToggleChange = new Func<int, bool>(this.CanToggleChange)
		};
	}

	// Token: 0x0600B084 RID: 45188 RVA: 0x00341D96 File Offset: 0x0033FF96
	private void SelectItemByIndex(int gridIndex)
	{
		GenericScrollViewNew<GachaSelectionItem, GachaPoolData> selectionScrollView = this.SelectionScrollView;
		if (selectionScrollView != null)
		{
			GenericLayout<GachaSelectionItem, GachaPoolData> genericLayout = selectionScrollView.GetGenericLayout();
			if (genericLayout != null)
			{
				genericLayout.SelectGridProxy(gridIndex, false);
			}
		}
		this.OnItemSelect();
	}

	// Token: 0x0600B085 RID: 45189 RVA: 0x00341DBC File Offset: 0x0033FFBC
	private bool CanToggleChange(int gridIndex)
	{
		GenericScrollViewNew<GachaSelectionItem, GachaPoolData> selectionScrollView = this.SelectionScrollView;
		int? num;
		if (selectionScrollView == null)
		{
			num = null;
		}
		else
		{
			GenericLayout<GachaSelectionItem, GachaPoolData> genericLayout = selectionScrollView.GetGenericLayout();
			num = ((genericLayout != null) ? new int?(genericLayout.GetSelectedGridIndex()) : null);
		}
		int? num2 = num;
		int? num3 = num2;
		return !(gridIndex == num3.GetValueOrDefault() & num3 != null);
	}

	// Token: 0x0600B086 RID: 45190 RVA: 0x00341E14 File Offset: 0x00340014
	[return: Nullable(new byte[]
	{
		2,
		1
	})]
	private GachaPoolData[] CreateSelectionDataList()
	{
		if (this.GachaInfo == null)
		{
			return null;
		}
		ProtoGachaPoolInfo[] validPoolList = this.GachaInfo.GetValidPoolList();
		if (validPoolList == null)
		{
			return null;
		}
		GachaPoolData[] array = new GachaPoolData[validPoolList.Length];
		for (int i = 0; i < validPoolList.Length; i++)
		{
			GachaPoolData gachaPoolData = new GachaPoolData(this.GachaInfo, validPoolList[i]);
			array[i] = gachaPoolData;
		}
		return array;
	}

	// Token: 0x0600B087 RID: 45191 RVA: 0x00341E68 File Offset: 0x00340068
	private bool CheckPoolListValid()
	{
		ProtoGachaPoolInfo[] validPoolList = this.GachaInfo.GetValidPoolList();
		return validPoolList != null && this.SelectionDataList != null && validPoolList.Length == this.SelectionDataList.Length;
	}

	// Token: 0x0600B088 RID: 45192 RVA: 0x00341E9C File Offset: 0x0034009C
	private void RefreshSelection()
	{
		GachaSelectionView.<>c__DisplayClass20_0 CS$<>8__locals1 = new GachaSelectionView.<>c__DisplayClass20_0();
		CS$<>8__locals1.<>4__this = this;
		if (this.SelectionScrollView == null)
		{
			return;
		}
		this.SelectionDataList = this.CreateSelectionDataList();
		if (this.SelectionDataList == null)
		{
			return;
		}
		if (this.SelectionDataList.Length == 0)
		{
			return;
		}
		CS$<>8__locals1.lastSelectedPoolId = this.CurSelectedPoolId;
		this.SelectionScrollView.RefreshByData(this.SelectionDataList, new Action(CS$<>8__locals1.<RefreshSelection>g__AfterRefreshSelection|0), false);
	}

	// Token: 0x0600B089 RID: 45193 RVA: 0x00341F08 File Offset: 0x00340108
	private void OnItemSelect()
	{
		int selectedGridIndex = this.SelectionScrollView.GetGenericLayout().GetSelectedGridIndex();
		int id = this.SelectionDataList[selectedGridIndex].PoolInfo.Id;
		GachaViewInfo value = GachaConfig.Instance.GetGachaViewInfo(id).Value;
		int num = value.ShowIdList()[0];
		int type = value.Type;
		GachaViewTypeInfo? gachaViewTypeConfig = GachaConfig.Instance.GetGachaViewTypeConfig(type);
		LguiUtil.Instance.SetLocalTextNew(base.GetText(0), gachaViewTypeConfig.Value.OptionalTitle, Array.Empty<object>());
		LguiUtil.Instance.SetLocalTextNew(base.GetText(1), gachaViewTypeConfig.Value.OptionalDesc, Array.Empty<object>());
		if (GachaModel.Instance.IsRolePool((GachaDefine.EGachaViewType)type))
		{
			RoleInfo? roleInfoById = GachaConfig.Instance.GetRoleInfoById(num);
			LguiUtil.Instance.SetLocalTextNew(base.GetText(4), roleInfoById.Value.Name, Array.Empty<object>());
			CharacterSmallItemGrid parameters = new CharacterSmallItemGrid
			{
				Data = null,
				ItemConfigId = new int?(num)
			};
			this.CurSelectedItem.Apply<CharacterSmallItemGrid>(parameters);
		}
		else
		{
			WeaponConf? weaponItemConfig = InventoryConfig.Instance.GetWeaponItemConfig(num);
			LguiUtil.Instance.SetLocalTextNew(base.GetText(4), weaponItemConfig.Value.WeaponName, Array.Empty<object>());
			PropSmallItemGrid parameters2 = new PropSmallItemGrid
			{
				Data = null,
				ItemConfigId = new int?(num)
			};
			this.CurSelectedItem.Apply<PropSmallItemGrid>(parameters2);
		}
		bool flag = this.GachaInfo.UsePoolId == id;
		string textStringId = flag ? "Text_GachaOptionalText1_Text" : "Text_GachaOptionalText2_Text";
		UUIButtonComponent button = base.GetButton(5);
		if (button != null)
		{
			button.SetSelfInteractive(!flag);
		}
		LguiUtil.Instance.SetLocalTextNew(base.GetText(6), textStringId, Array.Empty<object>());
	}

	// Token: 0x040065ED RID: 26093
	[Nullable(2)]
	private ProtoGachaInfo GachaInfo;

	// Token: 0x040065EE RID: 26094
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private GenericScrollViewNew<GachaSelectionItem, GachaPoolData> SelectionScrollView;

	// Token: 0x040065EF RID: 26095
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private GachaPoolData[] SelectionDataList;

	// Token: 0x040065F0 RID: 26096
	[Nullable(2)]
	private SmallItemGrid CurSelectedItem;

	// Token: 0x020073E7 RID: 29671
	[NullableContext(0)]
	private enum EComponent
	{
		// Token: 0x04025BBD RID: 154557
		TitleText,
		// Token: 0x04025BBE RID: 154558
		TipText,
		// Token: 0x04025BBF RID: 154559
		SelectionScrollView,
		// Token: 0x04025BC0 RID: 154560
		CurSelectedItem,
		// Token: 0x04025BC1 RID: 154561
		CurSelectedNameText,
		// Token: 0x04025BC2 RID: 154562
		ConfirmBtn,
		// Token: 0x04025BC3 RID: 154563
		SelectionTipText
	}
}
