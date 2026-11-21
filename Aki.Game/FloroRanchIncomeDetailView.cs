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

// Token: 0x02001026 RID: 4134
[NullableContext(1)]
[Nullable(0)]
public class FloroRanchIncomeDetailView : UiViewBase
{
	// Token: 0x0600A487 RID: 42119 RVA: 0x00304C8C File Offset: 0x00302E8C
	public FloroRanchIncomeDetailView(UiViewInfo info) : base(info)
	{
	}

	// Token: 0x0600A488 RID: 42120 RVA: 0x00304CBC File Offset: 0x00302EBC
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

	// Token: 0x0600A489 RID: 42121 RVA: 0x00304F1C File Offset: 0x0030311C
	protected override UniTask OnBeforeStartAsync()
	{
		FloroRanchIncomeDetailView.<OnBeforeStartAsync>d__17 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<FloroRanchIncomeDetailView.<OnBeforeStartAsync>d__17>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600A48A RID: 42122 RVA: 0x00304F5F File Offset: 0x0030315F
	private OneTextDropDownItem CreateDropDownItem(UUIItem uiItem, FloroRanchFilterType type)
	{
		return new OneTextDropDownItem(uiItem);
	}

	// Token: 0x0600A48B RID: 42123 RVA: 0x00304F67 File Offset: 0x00303167
	private OneTextTitleItem CreateTitleItem(UUIItem uiItem)
	{
		return new OneTextTitleItem(uiItem);
	}

	// Token: 0x0600A48C RID: 42124 RVA: 0x00304F70 File Offset: 0x00303170
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

	// Token: 0x0600A48D RID: 42125 RVA: 0x0030500D File Offset: 0x0030320D
	protected override void OnAddEventListener()
	{
		EventSystem.Instance.Add(EEventName.OnFloroRanchCardEntityCountChange, new Action(this.OnFloroRanchCardEntityCountChange));
	}

	// Token: 0x0600A48E RID: 42126 RVA: 0x0030502B File Offset: 0x0030322B
	protected override void OnRemoveEventListener()
	{
		EventSystem.Instance.Remove(EEventName.OnFloroRanchCardEntityCountChange, new Action(this.OnFloroRanchCardEntityCountChange));
	}

	// Token: 0x0600A48F RID: 42127 RVA: 0x0030504C File Offset: 0x0030324C
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

	// Token: 0x0600A490 RID: 42128 RVA: 0x003050C4 File Offset: 0x003032C4
	private FloroRanchIncomeItem CreateIncomeItem()
	{
		FloroRanchIncomeItem floroRanchIncomeItem = new FloroRanchIncomeItem();
		floroRanchIncomeItem.BindClickCallBack(new Action<int, FloroRanchEntityBase>(this.OnIncomeItemClick));
		floroRanchIncomeItem.SetSelectState(false);
		this.IncomeItemList.Add(floroRanchIncomeItem);
		return floroRanchIncomeItem;
	}

	// Token: 0x0600A491 RID: 42129 RVA: 0x00305100 File Offset: 0x00303300
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

	// Token: 0x0600A492 RID: 42130 RVA: 0x003051B0 File Offset: 0x003033B0
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

	// Token: 0x0600A493 RID: 42131 RVA: 0x003051FD File Offset: 0x003033FD
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

	// Token: 0x0600A494 RID: 42132 RVA: 0x00305220 File Offset: 0x00303420
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

	// Token: 0x0600A495 RID: 42133 RVA: 0x003052D8 File Offset: 0x003034D8
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

	// Token: 0x0600A496 RID: 42134 RVA: 0x0030536B File Offset: 0x0030356B
	private void StopSequenceIfPlaying(LevelSequencePlayer player, string sequenceName)
	{
		if (!player.IsPlayingSequence(sequenceName))
		{
			return;
		}
		player.StopSequenceByKey(sequenceName, false, false);
	}

	// Token: 0x0600A497 RID: 42135 RVA: 0x00305380 File Offset: 0x00303580
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

	// Token: 0x0600A498 RID: 42136 RVA: 0x003053E0 File Offset: 0x003035E0
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

	// Token: 0x0600A499 RID: 42137 RVA: 0x00305440 File Offset: 0x00303640
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

	// Token: 0x0600A49A RID: 42138 RVA: 0x003054C8 File Offset: 0x003036C8
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

	// Token: 0x0600A49B RID: 42139 RVA: 0x0030555D File Offset: 0x0030375D
	private void HideRightInfoTip()
	{
		this.SelectTipData.ChangeTipInfo(EFloroRanchTipType.None, null, null);
		this.HideMainTip(true);
		this.HideSubTip(true);
	}

	// Token: 0x0600A49C RID: 42140 RVA: 0x0030557C File Offset: 0x0030377C
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

	// Token: 0x0600A49D RID: 42141 RVA: 0x003055A8 File Offset: 0x003037A8
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

	// Token: 0x0600A49E RID: 42142 RVA: 0x003055FB File Offset: 0x003037FB
	private void RefreshIncomeItemToggleState(bool isSelected, int gridIndex)
	{
		if (gridIndex < 0 || gridIndex >= this.IncomeItemList.Count)
		{
			return;
		}
		this.IncomeItemList[gridIndex].SetSelectState(isSelected);
	}

	// Token: 0x0600A49F RID: 42143 RVA: 0x00305624 File Offset: 0x00303824
	private void RefreshScrollViewInfo()
	{
		this.DataList = FloroRanchGamePlayModel.Instance.GetLastIncomeEntityList(this.CurrentFilterData, this.IsAscending, this.IsShowNotPresentCard);
		this.IncomeScrollView.RefreshByData(this.DataList, null, false);
		base.GetItem(11).SetUIActive(this.DataList.Count <= 0);
	}

	// Token: 0x0600A4A0 RID: 42144 RVA: 0x00305684 File Offset: 0x00303884
	private void OnSelectFilter(int index, FloroRanchFilterType data)
	{
		this.CurrentFilterData = data;
		this.RefreshScrollViewInfo();
		this.CancelItemSelect();
	}

	// Token: 0x0600A4A1 RID: 42145 RVA: 0x00305699 File Offset: 0x00303899
	private TableTextArgNew GetDropDownText(FloroRanchFilterType data)
	{
		return new TableTextArgNew(data.Name, Array.Empty<object>());
	}

	// Token: 0x0600A4A2 RID: 42146 RVA: 0x003056AC File Offset: 0x003038AC
	private void OnToggleCheckClick(EToggleState _)
	{
		this.IsShowNotPresentCard = !this.IsShowNotPresentCard;
		this.RefreshScrollViewInfo();
		this.CancelItemSelect();
	}

	// Token: 0x0600A4A3 RID: 42147 RVA: 0x003056C9 File Offset: 0x003038C9
	private void OnToggleOrderClick(EToggleState _)
	{
		this.IsAscending = !this.IsAscending;
		this.RefreshScrollViewInfo();
		this.CancelItemSelect();
	}

	// Token: 0x0600A4A4 RID: 42148 RVA: 0x003056E6 File Offset: 0x003038E6
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

	// Token: 0x0600A4A5 RID: 42149 RVA: 0x00305707 File Offset: 0x00303907
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

	// Token: 0x0600A4A6 RID: 42150 RVA: 0x00305727 File Offset: 0x00303927
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

	// Token: 0x0600A4A7 RID: 42151 RVA: 0x00305748 File Offset: 0x00303948
	private void OnFloroRanchCardEntityCountChange()
	{
		int ownCardEntityCount = FloroRanchGamePlayModel.Instance.OwnCardEntityCount;
		LguiUtil.Instance.SetLocalTextNew(base.GetText(8), "Farm_ShowAllAnimal", new <>z__ReadOnlySingleElementList<object>(ownCardEntityCount));
	}

	// Token: 0x04006086 RID: 24710
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private GenericScrollViewNew<FloroRanchIncomeItem, IFloroRanchDetailData> IncomeScrollView;

	// Token: 0x04006087 RID: 24711
	private readonly List<FloroRanchIncomeItem> IncomeItemList = new List<FloroRanchIncomeItem>();

	// Token: 0x04006088 RID: 24712
	private CommonDropDown<TableTextArgNew, FloroRanchFilterType> DropDownList;

	// Token: 0x04006089 RID: 24713
	private FloroRanchFilterType CurrentFilterData;

	// Token: 0x0400608A RID: 24714
	private bool IsShowNotPresentCard;

	// Token: 0x0400608B RID: 24715
	private bool IsAscending = true;

	// Token: 0x0400608C RID: 24716
	private List<IFloroRanchDetailData> DataList = new List<IFloroRanchDetailData>();

	// Token: 0x0400608D RID: 24717
	private int IncomeItemSelectIndex = -1;

	// Token: 0x0400608E RID: 24718
	private FloroRanchTipData SelectTipData;

	// Token: 0x0400608F RID: 24719
	[Nullable(2)]
	private FloroRanchCommonTipItem MainTipInfoItem;

	// Token: 0x04006090 RID: 24720
	[Nullable(2)]
	private FloroRanchTerrainTipItem SubTipInfoItem;

	// Token: 0x04006091 RID: 24721
	[Nullable(2)]
	private LevelSequencePlayer MainTipLevelSequencePlayer;

	// Token: 0x04006092 RID: 24722
	[Nullable(2)]
	private LevelSequencePlayer SubTipLevelSequencePlayer;

	// Token: 0x04006093 RID: 24723
	[Nullable(2)]
	private Action<int> SelectStateCallback;

	// Token: 0x02007264 RID: 29284
	[NullableContext(0)]
	private class EComponentDefine
	{
		// Token: 0x040253BB RID: 152507
		public const int CloseButton = 0;

		// Token: 0x040253BC RID: 152508
		public const int CoinTexture = 1;

		// Token: 0x040253BD RID: 152509
		public const int IncomeCoin = 2;

		// Token: 0x040253BE RID: 152510
		public const int IncomeScrollView = 3;

		// Token: 0x040253BF RID: 152511
		public const int IncomeItem = 4;

		// Token: 0x040253C0 RID: 152512
		public const int DropDown = 5;

		// Token: 0x040253C1 RID: 152513
		public const int OrderToggle = 6;

		// Token: 0x040253C2 RID: 152514
		public const int CheckToggle = 7;

		// Token: 0x040253C3 RID: 152515
		public const int CheckToggleText = 8;

		// Token: 0x040253C4 RID: 152516
		public const int RightInfoRoot = 9;

		// Token: 0x040253C5 RID: 152517
		public const int MaskButton = 10;

		// Token: 0x040253C6 RID: 152518
		public const int EmptyPanel = 11;
	}
}
