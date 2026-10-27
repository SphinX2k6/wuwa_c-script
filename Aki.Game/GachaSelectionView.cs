using System;
using System.Collections.Generic;
using System.Linq;
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

// Token: 0x02001C88 RID: 7304
[NullableContext(1)]
[Nullable(0)]
public class GachaSelectionView : UiViewBase
{
	// Token: 0x0600DC64 RID: 56420 RVA: 0x0033653A File Offset: 0x0033473A
	public GachaSelectionView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x170011EA RID: 4586
	// (get) Token: 0x0600DC65 RID: 56421 RVA: 0x00336544 File Offset: 0x00334744
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

	// Token: 0x0600DC66 RID: 56422 RVA: 0x00336590 File Offset: 0x00334790
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

	// Token: 0x0600DC67 RID: 56423 RVA: 0x003366DB File Offset: 0x003348DB
	protected override void OnAddEventListener()
	{
		EventSystem.Instance.Add(EEventName.GachaSelectionViewRefresh, new Action<ProtoGachaInfo>(this.OnDataChange));
	}

	// Token: 0x0600DC68 RID: 56424 RVA: 0x003366F9 File Offset: 0x003348F9
	protected override void OnRemoveEventListener()
	{
		EventSystem.Instance.Remove(EEventName.GachaSelectionViewRefresh, new Action<ProtoGachaInfo>(this.OnDataChange));
	}

	// Token: 0x0600DC69 RID: 56425 RVA: 0x00336718 File Offset: 0x00334918
	private void OnConfirmBtnClick()
	{
		int curSelectedPoolId = this.CurSelectedPoolId;
		this.ReportGachaSelection(curSelectedPoolId);
		GachaController.Instance.GachaUsePoolRequest(this.GachaInfo.Id, curSelectedPoolId);
		UiManager.Instance.CloseView(EUiViewName.GachaSelectionView, null);
	}

	// Token: 0x0600DC6A RID: 56426 RVA: 0x0033675C File Offset: 0x0033495C
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

	// Token: 0x0600DC6B RID: 56427 RVA: 0x003367EB File Offset: 0x003349EB
	private void OnDataChange(ProtoGachaInfo gachaInfo)
	{
		this.GachaInfo = gachaInfo;
		this.RefreshSelection();
	}

	// Token: 0x0600DC6C RID: 56428 RVA: 0x003367FC File Offset: 0x003349FC
	protected override UniTask OnBeforeStartAsync()
	{
		GachaSelectionView.<OnBeforeStartAsync>d__14 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<GachaSelectionView.<OnBeforeStartAsync>d__14>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600DC6D RID: 56429 RVA: 0x0033683F File Offset: 0x00334A3F
	private GachaSelectionItem CreateSelectionItem()
	{
		return new GachaSelectionItem
		{
			ToggleCallBack = new Action<int>(this.SelectItemByIndex),
			CanToggleChange = new Func<int, bool>(this.CanToggleChange)
		};
	}

	// Token: 0x0600DC6E RID: 56430 RVA: 0x0033686A File Offset: 0x00334A6A
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

	// Token: 0x0600DC6F RID: 56431 RVA: 0x00336890 File Offset: 0x00334A90
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

	// Token: 0x0600DC70 RID: 56432 RVA: 0x003368E8 File Offset: 0x00334AE8
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

	// Token: 0x0600DC71 RID: 56433 RVA: 0x0033693C File Offset: 0x00334B3C
	private bool CheckPoolListValid()
	{
		ProtoGachaPoolInfo[] validPoolList = this.GachaInfo.GetValidPoolList();
		return validPoolList != null && this.SelectionDataList != null && validPoolList.Length == this.SelectionDataList.Length;
	}

	// Token: 0x0600DC72 RID: 56434 RVA: 0x00336970 File Offset: 0x00334B70
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
		this.SelectionScrollView.RefreshByData(this.SelectionDataList.ToList<GachaPoolData>(), new Action(CS$<>8__locals1.<RefreshSelection>g__AfterRefreshSelection|0), false);
	}

	// Token: 0x0600DC73 RID: 56435 RVA: 0x003369E4 File Offset: 0x00334BE4
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

	// Token: 0x0400651B RID: 25883
	[Nullable(2)]
	private ProtoGachaInfo GachaInfo;

	// Token: 0x0400651C RID: 25884
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private GenericScrollViewNew<GachaSelectionItem, GachaPoolData> SelectionScrollView;

	// Token: 0x0400651D RID: 25885
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private GachaPoolData[] SelectionDataList;

	// Token: 0x0400651E RID: 25886
	[Nullable(2)]
	private SmallItemGrid CurSelectedItem;

	// Token: 0x0200825F RID: 33375
	[NullableContext(0)]
	private enum EComponent
	{
		// Token: 0x0402A89C RID: 174236
		TitleText,
		// Token: 0x0402A89D RID: 174237
		TipText,
		// Token: 0x0402A89E RID: 174238
		SelectionScrollView,
		// Token: 0x0402A89F RID: 174239
		CurSelectedItem,
		// Token: 0x0402A8A0 RID: 174240
		CurSelectedNameText,
		// Token: 0x0402A8A1 RID: 174241
		ConfirmBtn,
		// Token: 0x0402A8A2 RID: 174242
		SelectionTipText
	}
}
