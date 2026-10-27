using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.FloroRanch;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02001B67 RID: 7015
[NullableContext(1)]
[Nullable(0)]
public class FloroRanchIncomeDetailView : UiViewBase
{
	// Token: 0x0600D076 RID: 53366 RVA: 0x002F9BB4 File Offset: 0x002F7DB4
	public FloroRanchIncomeDetailView(UiViewInfo info) : base(info)
	{
	}

	// Token: 0x0600D077 RID: 53367 RVA: 0x002F9BE4 File Offset: 0x002F7DE4
	protected unsafe override void OnRegisterComponent()
	{
		int num = 12;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUITexture));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIScrollViewWithScrollbarComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIExtendToggle));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIExtendToggle));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(8, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(9, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(10, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(11, typeof(UUIItem));
		this.ComponentRegisterInfos = list;
		num2 = 4;
		List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
		CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
		Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
		num = 0;
		*span2[num] = new ValueTuple<int, Delegate>(0, new Action(this.OnCloseButtonClick));
		num++;
		*span2[num] = new ValueTuple<int, Delegate>(7, new Action<EToggleState>(this.OnToggleCheckClick));
		num++;
		*span2[num] = new ValueTuple<int, Delegate>(6, new Action<EToggleState>(this.OnToggleOrderClick));
		num++;
		*span2[num] = new ValueTuple<int, Delegate>(10, new Action(this.OnCloseButtonClick));
		this.BtnBindInfo = list2;
	}

	// Token: 0x0600D078 RID: 53368 RVA: 0x002F9E44 File Offset: 0x002F8044
	protected override UniTask OnBeforeStartAsync()
	{
		FloroRanchIncomeDetailView.<OnBeforeStartAsync>d__17 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<FloroRanchIncomeDetailView.<OnBeforeStartAsync>d__17>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600D079 RID: 53369 RVA: 0x002F9E87 File Offset: 0x002F8087
	private OneTextDropDownItem CreateDropDownItem(UUIItem uiItem, FloroRanchFilterType type)
	{
		return new OneTextDropDownItem(uiItem);
	}

	// Token: 0x0600D07A RID: 53370 RVA: 0x002F9E8F File Offset: 0x002F808F
	private OneTextTitleItem CreateTitleItem(UUIItem uiItem)
	{
		return new OneTextTitleItem(uiItem);
	}

	// Token: 0x0600D07B RID: 53371 RVA: 0x002F9E98 File Offset: 0x002F8098
	protected override void OnBeforeShow()
	{
		FloroRanchGamePlayModel.Instance.RefreshLastIncomeEntityList();
		this.IsShowNotPresentCard = false;
		this.IsAscending = true;
		base.GetText(2).SetText(FloroRanchModel.Instance.GetCoinText(FloroRanchGamePlayModel.Instance.GetLastDayIncome()), true);
		LguiUtil.Instance.SetLocalTextNew(base.GetText(8), "Farm_ShowAllAnimal", new <>z__ReadOnlySingleElementList<object>(FloroRanchGamePlayModel.Instance.OwnCardEntityCount));
		base.SetTextureByPath(FloroRanchModel.Instance.GetFloroRanchCurrencyConfig(ECurrencyType.Coin).GetSmallIcon(), base.GetTexture(1), null, null);
		this.RefreshScrollViewInfo();
	}

	// Token: 0x0600D07C RID: 53372 RVA: 0x002F9F35 File Offset: 0x002F8135
	protected override void OnAddEventListener()
	{
		EventSystem.Instance.Add(EEventName.OnFloroRanchCardEntityCountChange, new Action(this.OnFloroRanchCardEntityCountChange));
	}

	// Token: 0x0600D07D RID: 53373 RVA: 0x002F9F53 File Offset: 0x002F8153
	protected override void OnRemoveEventListener()
	{
		EventSystem.Instance.Remove(EEventName.OnFloroRanchCardEntityCountChange, new Action(this.OnFloroRanchCardEntityCountChange));
	}

	// Token: 0x0600D07E RID: 53374 RVA: 0x002F9F74 File Offset: 0x002F8174
	protected override void OnStart()
	{
		IReadOnlyList<FloroRanchFilterType> floroRanchFilterTypeConfigList = FloroRanchConfig.Instance.GetFloroRanchFilterTypeConfigList();
		if (floroRanchFilterTypeConfigList.Count <= 0)
		{
			this.DropDownList.SetUiActive(false);
			return;
		}
		this.CurrentFilterData = floroRanchFilterTypeConfigList[0];
		this.DropDownList.InitScroll(floroRanchFilterTypeConfigList, new Func<FloroRanchFilterType, TableTextArgNew>(this.GetDropDownText), 0, true);
		this.DropDownList.SetShowType(ECommonDropDownShowType.Up);
		this.DropDownList.SetOnSelectCall(new Action<int, FloroRanchFilterType>(this.OnSelectFilter));
	}

	// Token: 0x0600D07F RID: 53375 RVA: 0x002F9FEC File Offset: 0x002F81EC
	private FloroRanchIncomeItem CreateIncomeItem()
	{
		FloroRanchIncomeItem floroRanchIncomeItem = new FloroRanchIncomeItem();
		floroRanchIncomeItem.BindClickCallBack(new Action<int, FloroRanchEntityBase>(this.OnIncomeItemClick));
		floroRanchIncomeItem.SetSelectState(false);
		this.IncomeItemList.Add(floroRanchIncomeItem);
		return floroRanchIncomeItem;
	}

	// Token: 0x0600D080 RID: 53376 RVA: 0x002FA028 File Offset: 0x002F8228
	private void OnIncomeItemClick(int gridIndex, FloroRanchEntityBase floroRanchEntity)
	{
		this.OnItemSelect(gridIndex);
		FloroRanchEntityDataComponent floroRanchEntityDataComponent = floroRanchEntity.CheckGetComponent<FloroRanchEntityDataComponent>();
		int point = floroRanchEntityDataComponent.Point;
		bool flag = floroRanchEntityDataComponent.IsValid && point != -1;
		if (flag)
		{
			this.ShowTips(floroRanchEntity);
		}
		else
		{
			if (point == -1)
			{
				ScrollingTipsController.Instance.ShowTipsByTextId("Farm_AnimalBehind", Array.Empty<object>());
			}
			this.HideRightInfoTip();
		}
		if (!flag || floroRanchEntity.EntityType == EFloroRanchEntityType.Toy)
		{
			Action<int> selectStateCallback = this.SelectStateCallback;
			if (selectStateCallback == null)
			{
				return;
			}
			selectStateCallback(-1);
			return;
		}
		else if (floroRanchEntityDataComponent != null && floroRanchEntityDataComponent.IsValid && flag)
		{
			Action<int> selectStateCallback2 = this.SelectStateCallback;
			if (selectStateCallback2 == null)
			{
				return;
			}
			selectStateCallback2(point);
			return;
		}
		else
		{
			Action<int> selectStateCallback3 = this.SelectStateCallback;
			if (selectStateCallback3 == null)
			{
				return;
			}
			selectStateCallback3(0);
			return;
		}
	}

	// Token: 0x0600D081 RID: 53377 RVA: 0x002FA0D8 File Offset: 0x002F82D8
	private void OnItemSelect(int gridIndex)
	{
		this.RefreshIncomeItemToggleState(false, this.IncomeItemSelectIndex);
		if (gridIndex < 0 || gridIndex >= this.DataList.Count || gridIndex == this.IncomeItemSelectIndex)
		{
			this.IncomeItemSelectIndex = -1;
		}
		else
		{
			this.IncomeItemSelectIndex = gridIndex;
		}
		this.RefreshIncomeItemToggleState(true, gridIndex);
	}

	// Token: 0x0600D082 RID: 53378 RVA: 0x002FA125 File Offset: 0x002F8325
	private void CancelItemSelect()
	{
		this.OnItemSelect(-1);
		this.HideRightInfoTip();
		Action<int> selectStateCallback = this.SelectStateCallback;
		if (selectStateCallback == null)
		{
			return;
		}
		selectStateCallback(-1);
	}

	// Token: 0x0600D083 RID: 53379 RVA: 0x002FA148 File Offset: 0x002F8348
	private void SetTipType(FloroRanchEntityBase floroRanchEntity)
	{
		EFloroRanchEntityType entityType = floroRanchEntity.EntityType;
		int point = floroRanchEntity.CheckGetComponent<FloroRanchEntityDataComponent>().Point;
		switch (entityType)
		{
		case EFloroRanchEntityType.Terrain:
		{
			FloroRanchEntityBase mainEntityData = null;
			if (point != -1)
			{
				mainEntityData = FloroRanchGamePlayModel.Instance.GetCardEntityByPoint(point);
			}
			this.SelectTipData.ChangeTipInfo(EFloroRanchTipType.Terrain, mainEntityData, floroRanchEntity);
			return;
		}
		case EFloroRanchEntityType.Card:
		{
			FloroRanchEntityBase subEntityData = null;
			if (point != -1)
			{
				subEntityData = FloroRanchGamePlayModel.Instance.GetTerrainEntityByPoint(point);
			}
			this.SelectTipData.ChangeTipInfo(EFloroRanchTipType.Terrain, floroRanchEntity, subEntityData);
			return;
		}
		case EFloroRanchEntityType.Toy:
			this.SelectTipData.ChangeTipInfo(EFloroRanchTipType.Toy, floroRanchEntity, null);
			return;
		default:
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.FloroRanchGamePlay;
			ELogAuthor author = ELogAuthor.LRC;
			string message = "SetTipType Invalid entity type:";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("entityType", entityType);
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return;
		}
		}
	}

	// Token: 0x0600D084 RID: 53380 RVA: 0x002FA200 File Offset: 0x002F8400
	private void ShowTips(FloroRanchEntityBase floroRanchEntity)
	{
		this.SetTipType(floroRanchEntity);
		FloroRanchEntityBase lastMainEntityData = this.SelectTipData.LastMainEntityData;
		FloroRanchEntityBase lastSubEntityData = this.SelectTipData.LastSubEntityData;
		bool mainEntityData = this.SelectTipData.MainEntityData != null;
		FloroRanchEntityBase subEntityData = this.SelectTipData.SubEntityData;
		bool lastTipType = this.SelectTipData.LastTipType != EFloroRanchTipType.None;
		EFloroRanchTipType tipType = this.SelectTipData.TipType;
		bool playAnim = !lastTipType || tipType == EFloroRanchTipType.None;
		if (mainEntityData)
		{
			this.ShowMainTip(playAnim);
		}
		else if (lastMainEntityData != null)
		{
			this.HideMainTip(playAnim);
		}
		if (subEntityData != null)
		{
			this.ShowSubTip(playAnim);
			return;
		}
		if (lastSubEntityData != null)
		{
			this.HideSubTip(playAnim);
		}
	}

	// Token: 0x0600D085 RID: 53381 RVA: 0x002FA293 File Offset: 0x002F8493
	private void StopSequenceIfPlaying(LevelSequencePlayer player, string sequenceName)
	{
		if (!player.IsPlayingSequence(sequenceName))
		{
			return;
		}
		player.StopSequenceByKey(sequenceName, false, false);
	}

	// Token: 0x0600D086 RID: 53382 RVA: 0x002FA2A8 File Offset: 0x002F84A8
	private void HideSubTip(bool playAnim = true)
	{
		this.StopSequenceIfPlaying(this.SubTipLevelSequencePlayer, "Start");
		this.SubTipLevelSequencePlayer.PlayLevelSequenceByName("Close", false, null, false);
		if (!playAnim)
		{
			this.SubTipLevelSequencePlayer.EndSequenceLastFrame("Close");
			FloroRanchTerrainTipItem subTipInfoItem = this.SubTipInfoItem;
			if (subTipInfoItem == null)
			{
				return;
			}
			subTipInfoItem.SetUiActive(false);
		}
	}

	// Token: 0x0600D087 RID: 53383 RVA: 0x002FA308 File Offset: 0x002F8508
	private void HideMainTip(bool playAnim = true)
	{
		this.StopSequenceIfPlaying(this.MainTipLevelSequencePlayer, "Start");
		this.MainTipLevelSequencePlayer.PlayLevelSequenceByName("Close", false, null, false);
		if (!playAnim)
		{
			this.MainTipLevelSequencePlayer.EndSequenceLastFrame("Close");
			FloroRanchCommonTipItem mainTipInfoItem = this.MainTipInfoItem;
			if (mainTipInfoItem == null)
			{
				return;
			}
			mainTipInfoItem.SetUiActive(false);
		}
	}

	// Token: 0x0600D088 RID: 53384 RVA: 0x002FA368 File Offset: 0x002F8568
	private void ShowSubTip(bool playAnim = true)
	{
		FloroRanchEntityBase subEntityData = this.SelectTipData.SubEntityData;
		this.SubTipInfoItem.RefreshInfoTipByEntity(subEntityData);
		this.SetSubTipHeight((this.SelectTipData.MainEntityData != null) ? 240 : 380);
		this.StopSequenceIfPlaying(this.SubTipLevelSequencePlayer, "Close");
		this.SubTipLevelSequencePlayer.PlayLevelSequenceByName("Start", false, null, false);
		if (!playAnim)
		{
			this.SubTipLevelSequencePlayer.EndSequenceLastFrame("Start");
		}
	}

	// Token: 0x0600D089 RID: 53385 RVA: 0x002FA3F0 File Offset: 0x002F85F0
	private void ShowMainTip(bool playAnim = true)
	{
		FloroRanchEntityBase mainEntityData = this.SelectTipData.MainEntityData;
		FloroRanchCommonTipItem mainTipInfoItem = this.MainTipInfoItem;
		if (mainTipInfoItem != null)
		{
			mainTipInfoItem.RefreshInfoTipByParam(new FloroRanchCommonTipParam
			{
				TipType = EFloroRanchCommonTipType.Entity,
				EntityData = mainEntityData,
				RemoveCallback = new Action<FloroRanchEntityBase>(this.OnSellClick),
				CurrencyData = null
			});
		}
		this.StopSequenceIfPlaying(this.MainTipLevelSequencePlayer, "Close");
		this.MainTipLevelSequencePlayer.PlayLevelSequenceByName("Start", false, null, false);
		if (!playAnim)
		{
			this.MainTipLevelSequencePlayer.EndSequenceLastFrame("Start");
		}
	}

	// Token: 0x0600D08A RID: 53386 RVA: 0x002FA485 File Offset: 0x002F8685
	private void HideRightInfoTip()
	{
		this.SelectTipData.ChangeTipInfo(EFloroRanchTipType.None, null, null);
		this.HideMainTip(true);
		this.HideSubTip(true);
	}

	// Token: 0x0600D08B RID: 53387 RVA: 0x002FA4A4 File Offset: 0x002F86A4
	private void SetSubTipHeight(int height)
	{
		FloroRanchTerrainTipItem subTipInfoItem = this.SubTipInfoItem;
		UUIItem uuiitem = (subTipInfoItem != null) ? subTipInfoItem.GetRootItem() : null;
		if (uuiitem == null)
		{
			return;
		}
		uuiitem.SetHeight((float)height);
	}

	// Token: 0x0600D08C RID: 53388 RVA: 0x002FA4D0 File Offset: 0x002F86D0
	private void OnSellClick(FloroRanchEntityBase floroRanchEntity)
	{
		this.RefreshIncomeItemToggleState(false, this.IncomeItemSelectIndex);
		this.RefreshScrollViewInfo();
		this.SubTipInfoItem.GetRootItem().SetUIActive(false);
		this.MainTipInfoItem.GetRootItem().SetUIActive(false);
		Action<int> selectStateCallback = this.SelectStateCallback;
		if (selectStateCallback == null)
		{
			return;
		}
		selectStateCallback(-1);
	}

	// Token: 0x0600D08D RID: 53389 RVA: 0x002FA523 File Offset: 0x002F8723
	private void RefreshIncomeItemToggleState(bool isSelected, int gridIndex)
	{
		if (gridIndex < 0 || gridIndex >= this.IncomeItemList.Count)
		{
			return;
		}
		this.IncomeItemList[gridIndex].SetSelectState(isSelected);
	}

	// Token: 0x0600D08E RID: 53390 RVA: 0x002FA54C File Offset: 0x002F874C
	private void RefreshScrollViewInfo()
	{
		this.DataList = FloroRanchGamePlayModel.Instance.GetLastIncomeEntityList(this.CurrentFilterData, this.IsAscending, this.IsShowNotPresentCard);
		this.IncomeScrollView.RefreshByData(this.DataList, null, false);
		base.GetItem(11).SetUIActive(this.DataList.Count <= 0);
	}

	// Token: 0x0600D08F RID: 53391 RVA: 0x002FA5AC File Offset: 0x002F87AC
	private void OnSelectFilter(int index, FloroRanchFilterType data)
	{
		this.CurrentFilterData = data;
		this.RefreshScrollViewInfo();
		this.CancelItemSelect();
	}

	// Token: 0x0600D090 RID: 53392 RVA: 0x002FA5C1 File Offset: 0x002F87C1
	private TableTextArgNew GetDropDownText(FloroRanchFilterType data)
	{
		return new TableTextArgNew(data.Name, Array.Empty<object>());
	}

	// Token: 0x0600D091 RID: 53393 RVA: 0x002FA5D4 File Offset: 0x002F87D4
	private void OnToggleCheckClick(EToggleState _)
	{
		this.IsShowNotPresentCard = !this.IsShowNotPresentCard;
		this.RefreshScrollViewInfo();
		this.CancelItemSelect();
	}

	// Token: 0x0600D092 RID: 53394 RVA: 0x002FA5F1 File Offset: 0x002F87F1
	private void OnToggleOrderClick(EToggleState _)
	{
		this.IsAscending = !this.IsAscending;
		this.RefreshScrollViewInfo();
		this.CancelItemSelect();
	}

	// Token: 0x0600D093 RID: 53395 RVA: 0x002FA60E File Offset: 0x002F880E
	private void OnCloseButtonClick()
	{
		Action<int> selectStateCallback = this.SelectStateCallback;
		if (selectStateCallback != null)
		{
			selectStateCallback(-1);
		}
		this.CancelItemSelect();
		base.CloseMe(null);
	}

	// Token: 0x0600D094 RID: 53396 RVA: 0x002FA62F File Offset: 0x002F882F
	private void MainTipSequenceFinishEvent(string sequenceName)
	{
		if (sequenceName == "Close")
		{
			FloroRanchCommonTipItem mainTipInfoItem = this.MainTipInfoItem;
			if (mainTipInfoItem == null)
			{
				return;
			}
			mainTipInfoItem.SetUiActive(false);
		}
	}

	// Token: 0x0600D095 RID: 53397 RVA: 0x002FA64F File Offset: 0x002F884F
	private void SubTipSequenceFinishEvent(string sequenceName)
	{
		if (sequenceName == "Close")
		{
			FloroRanchTerrainTipItem subTipInfoItem = this.SubTipInfoItem;
			if (subTipInfoItem == null)
			{
				return;
			}
			subTipInfoItem.SetUiActive(false);
		}
	}

	// Token: 0x0600D096 RID: 53398 RVA: 0x002FA670 File Offset: 0x002F8870
	private void OnFloroRanchCardEntityCountChange()
	{
		int ownCardEntityCount = FloroRanchGamePlayModel.Instance.OwnCardEntityCount;
		LguiUtil.Instance.SetLocalTextNew(base.GetText(8), "Farm_ShowAllAnimal", new <>z__ReadOnlySingleElementList<object>(ownCardEntityCount));
	}

	// Token: 0x04005FB7 RID: 24503
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private GenericScrollViewNew<FloroRanchIncomeItem, IFloroRanchDetailData> IncomeScrollView;

	// Token: 0x04005FB8 RID: 24504
	private readonly List<FloroRanchIncomeItem> IncomeItemList = new List<FloroRanchIncomeItem>();

	// Token: 0x04005FB9 RID: 24505
	private CommonDropDown<TableTextArgNew, FloroRanchFilterType> DropDownList;

	// Token: 0x04005FBA RID: 24506
	private FloroRanchFilterType CurrentFilterData;

	// Token: 0x04005FBB RID: 24507
	private bool IsShowNotPresentCard;

	// Token: 0x04005FBC RID: 24508
	private bool IsAscending = true;

	// Token: 0x04005FBD RID: 24509
	private List<IFloroRanchDetailData> DataList = new List<IFloroRanchDetailData>();

	// Token: 0x04005FBE RID: 24510
	private int IncomeItemSelectIndex = -1;

	// Token: 0x04005FBF RID: 24511
	private FloroRanchTipData SelectTipData;

	// Token: 0x04005FC0 RID: 24512
	[Nullable(2)]
	private FloroRanchCommonTipItem MainTipInfoItem;

	// Token: 0x04005FC1 RID: 24513
	[Nullable(2)]
	private FloroRanchTerrainTipItem SubTipInfoItem;

	// Token: 0x04005FC2 RID: 24514
	[Nullable(2)]
	private LevelSequencePlayer MainTipLevelSequencePlayer;

	// Token: 0x04005FC3 RID: 24515
	[Nullable(2)]
	private LevelSequencePlayer SubTipLevelSequencePlayer;

	// Token: 0x04005FC4 RID: 24516
	[Nullable(2)]
	private Action<int> SelectStateCallback;

	// Token: 0x020080D6 RID: 32982
	[NullableContext(0)]
	private class EComponentDefine
	{
		// Token: 0x0402A087 RID: 172167
		public const int CloseButton = 0;

		// Token: 0x0402A088 RID: 172168
		public const int CoinTexture = 1;

		// Token: 0x0402A089 RID: 172169
		public const int IncomeCoin = 2;

		// Token: 0x0402A08A RID: 172170
		public const int IncomeScrollView = 3;

		// Token: 0x0402A08B RID: 172171
		public const int IncomeItem = 4;

		// Token: 0x0402A08C RID: 172172
		public const int DropDown = 5;

		// Token: 0x0402A08D RID: 172173
		public const int OrderToggle = 6;

		// Token: 0x0402A08E RID: 172174
		public const int CheckToggle = 7;

		// Token: 0x0402A08F RID: 172175
		public const int CheckToggleText = 8;

		// Token: 0x0402A090 RID: 172176
		public const int RightInfoRoot = 9;

		// Token: 0x0402A091 RID: 172177
		public const int MaskButton = 10;

		// Token: 0x0402A092 RID: 172178
		public const int EmptyPanel = 11;
	}
}
