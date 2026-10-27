using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Area;
using CSharpScript.Game.Module.Map;
using CSharpScript.Game.Module.Map.MapDefine;
using CSharpScript.Game.Module.Map.Mark;
using CSharpScript.Game.Module.Map.Marks.MarkItem;
using CSharpScript.Game.Module.RecallQuest.Model;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Module.WorldMap.ViewComponent;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.WorldMap.SubViews.WorldMapQuickNavigate
{
	// Token: 0x020047DC RID: 18396
	[NullableContext(1)]
	[Nullable(0)]
	public class WorldMapQuickNavigatePanel : WorldMapSecondaryUi
	{
		// Token: 0x06030305 RID: 197381 RVA: 0x00B2A6BB File Offset: 0x00B288BB
		public override string GetResourceId()
		{
			return "UiItem_MapChange";
		}

		// Token: 0x06030306 RID: 197382 RVA: 0x00B2A6C4 File Offset: 0x00B288C4
		protected unsafe override void OnRegisterComponent()
		{
			int num = 7;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIDynScrollViewComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUILoopScrollViewComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIHorizontalLayout));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x06030307 RID: 197383 RVA: 0x00B2A7D2 File Offset: 0x00B289D2
		protected override PopupTypeRightItem GetPopupRightItem()
		{
			return new PopupRightItemA();
		}

		// Token: 0x06030308 RID: 197384 RVA: 0x00B2A7DC File Offset: 0x00B289DC
		protected override UniTask OnBeforeStartAsync()
		{
			WorldMapQuickNavigatePanel.<OnBeforeStartAsync>d__11 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<WorldMapQuickNavigatePanel.<OnBeforeStartAsync>d__11>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06030309 RID: 197385 RVA: 0x00B2A820 File Offset: 0x00B28A20
		protected override void OnStart()
		{
			UUIItem rootItem = base.GetRootItem();
			this.SequencePlayer = new UiSequencePlayer(rootItem);
		}

		// Token: 0x0603030A RID: 197386 RVA: 0x00B2A840 File Offset: 0x00B28A40
		protected override void OnBeforeShow()
		{
			EventSystem.Instance.Add(EEventName.WorldMapFirstNavigateSelect, new Action<QuickNavigateDynamicData>(this.OnFirstNavigateSelect));
			EventSystem.Instance.Add(EEventName.WorldMapSecondNavigateSelect, new Action<int>(this.OnSecondNavigateSelect));
			EventSystem.Instance.Add(EEventName.WorldMapBeforeChangeMap, new Action(this.OnBeforeChangeMap));
			EventSystem.Instance.Add(EEventName.WorldMapAfterChangeMap, new Action(this.OnAfterChangeMap));
			EventSystem.Instance.Add(EEventName.UpdateOnlinePlayersArea, new Action(this.OnUpdateOnlinePlayersArea));
			EventSystem.Instance.Add(EEventName.PlayerMarkItemChanged, new Action(this.OnPlayerMarkItemChanged));
			int num = TimeUtil.Instance.InverseMillisecond * 3;
			this.RefreshTimerHandle = TimerSystem.RealTimeInstance.Forever(new TTimerAction(this.OnTimerRefresh), (float)num, 1f, null, null, true);
			this.OnTimerRefresh(0f);
		}

		// Token: 0x0603030B RID: 197387 RVA: 0x00B2A934 File Offset: 0x00B28B34
		protected override void OnAfterHide()
		{
			EventSystem.Instance.Remove(EEventName.WorldMapFirstNavigateSelect, new Action<QuickNavigateDynamicData>(this.OnFirstNavigateSelect));
			EventSystem.Instance.Remove(EEventName.WorldMapSecondNavigateSelect, new Action<int>(this.OnSecondNavigateSelect));
			EventSystem.Instance.Remove(EEventName.WorldMapBeforeChangeMap, new Action(this.OnBeforeChangeMap));
			EventSystem.Instance.Remove(EEventName.WorldMapAfterChangeMap, new Action(this.OnAfterChangeMap));
			EventSystem.Instance.Remove(EEventName.UpdateOnlinePlayersArea, new Action(this.OnUpdateOnlinePlayersArea));
			EventSystem.Instance.Remove(EEventName.PlayerMarkItemChanged, new Action(this.OnPlayerMarkItemChanged));
			this.ClearTimer();
		}

		// Token: 0x0603030C RID: 197388 RVA: 0x00B2A9F0 File Offset: 0x00B28BF0
		private void SetupSelection()
		{
			if (this.SelectionInfo == null)
			{
				this.SelectionInfo = new SelectionInfo
				{
					FirstIndex = 0,
					SecondIndex = 0,
					CountryId = 0,
					ExpandCountry = true,
					StateId = 0,
					AreaId = 0
				};
				int worldMapLevelOneAreaId = MapUtil.GetWorldMapLevelOneAreaId();
				IWorldMapNavigate valueOrDefault = this.NavigateBundle.AreaMap.GetValueOrDefault(worldMapLevelOneAreaId);
				if (valueOrDefault != null)
				{
					this.SelectionInfo.CountryId = valueOrDefault.CountryId;
					this.SelectionInfo.StateId = valueOrDefault.StateId.GetValueOrDefault();
					this.SelectionInfo.AreaId = valueOrDefault.AreaId;
				}
			}
		}

		// Token: 0x0603030D RID: 197389 RVA: 0x00B2AA94 File Offset: 0x00B28C94
		protected override void OnShowWorldMapSecondaryUi(params object[] parameters)
		{
			if (RecallQuestModel.Instance.IsInRecallInstance())
			{
				this.NavigateBundle = MapConfig.Instance.BuildRecallFilteredNavigateBundle(RecallQuestModel.Instance.GetCurrentRecallDungeonIdSet());
			}
			else
			{
				this.NavigateBundle = MapConfig.Instance.GetFullNavigateBundle();
			}
			this.SetupSelection();
			this.RefreshNavigateLayout(ERefreshNavigateType.All);
		}

		// Token: 0x0603030E RID: 197390 RVA: 0x00B2AAE8 File Offset: 0x00B28CE8
		protected override UniTask OnBeforeShowWorldMapSecondaryUiAsync(params object[] parameters)
		{
			WorldMapQuickNavigatePanel.<OnBeforeShowWorldMapSecondaryUiAsync>d__17 <OnBeforeShowWorldMapSecondaryUiAsync>d__;
			<OnBeforeShowWorldMapSecondaryUiAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeShowWorldMapSecondaryUiAsync>d__.<>4__this = this;
			<OnBeforeShowWorldMapSecondaryUiAsync>d__.parameters = parameters;
			<OnBeforeShowWorldMapSecondaryUiAsync>d__.<>1__state = -1;
			<OnBeforeShowWorldMapSecondaryUiAsync>d__.<>t__builder.Start<WorldMapQuickNavigatePanel.<OnBeforeShowWorldMapSecondaryUiAsync>d__17>(ref <OnBeforeShowWorldMapSecondaryUiAsync>d__);
			return <OnBeforeShowWorldMapSecondaryUiAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603030F RID: 197391 RVA: 0x00B2AB33 File Offset: 0x00B28D33
		protected override void OnCloseWorldMapSecondaryUi()
		{
			this.SelectionInfo = null;
		}

		// Token: 0x06030310 RID: 197392 RVA: 0x00B2AB3C File Offset: 0x00B28D3C
		protected override void OnBeforeDestroy()
		{
			LoopScrollView<QuickNavigateLoopScrollAreaGridItem, QuickNavigateLoopScrollAreaGridItemData> areaLoopScrollView = this.AreaLoopScrollView;
			if (areaLoopScrollView != null)
			{
				areaLoopScrollView.ClearGridProxies();
			}
			this.AreaLoopScrollView = null;
			DynamicScrollView<QuickNavigateDynamicScrollItem, QuickNavigateDynamicItem, QuickNavigateDynamicData> dynamicScrollView = this.DynamicScrollView;
			if (dynamicScrollView != null)
			{
				dynamicScrollView.ClearChildren();
			}
			this.DynamicScrollView = null;
			this.IconLayout = null;
		}

		// Token: 0x06030311 RID: 197393 RVA: 0x00B2AB75 File Offset: 0x00B28D75
		private QuickNavigateLoopScrollAreaGridItem OnGridProxyCreate()
		{
			return new QuickNavigateLoopScrollAreaGridItem();
		}

		// Token: 0x06030312 RID: 197394 RVA: 0x00B2AB7C File Offset: 0x00B28D7C
		private QuickNavigateDynamicScrollItem CreateItemFunc(QuickNavigateDynamicData data, UUIItem uiItem, int index)
		{
			return new QuickNavigateDynamicScrollItem();
		}

		// Token: 0x06030313 RID: 197395 RVA: 0x00B2AB84 File Offset: 0x00B28D84
		private void RefreshNavigateLayout(ERefreshNavigateType refreshType)
		{
			if (refreshType == ERefreshNavigateType.All || refreshType == ERefreshNavigateType.StateOnly)
			{
				QuickNavigateDynamicData[] dynamicScrollViewDataList = this.GetDynamicScrollViewDataList(refreshType);
				this.DynamicScrollView.RefreshByData(dynamicScrollViewDataList, false, false);
			}
			if (refreshType == ERefreshNavigateType.StateAndAreaBoth)
			{
				QuickNavigateDynamicData[] dynamicScrollViewDataList2 = this.GetDynamicScrollViewDataList(refreshType);
				int num = 0;
				QuickNavigateDynamicScrollItem[] scrollItemItems = this.DynamicScrollView.GetScrollItemItems();
				for (int i = 0; i < scrollItemItems.Length; i++)
				{
					scrollItemItems[i].Update(dynamicScrollViewDataList2[num], num++);
				}
			}
			if (refreshType == ERefreshNavigateType.All || refreshType == ERefreshNavigateType.AreaOnly || refreshType == ERefreshNavigateType.StateAndAreaBoth)
			{
				List<QuickNavigateLoopScrollAreaGridItemData> gridItemDataList = this.GetAreaGridItemDataList(refreshType);
				this.AreaLoopScrollView.RefreshByData(gridItemDataList, false, delegate
				{
					if (refreshType != ERefreshNavigateType.All)
					{
						if (this.IsRepeatSelectCountry)
						{
							LoopScrollView<QuickNavigateLoopScrollAreaGridItem, QuickNavigateLoopScrollAreaGridItemData> areaLoopScrollView = this.AreaLoopScrollView;
							if (areaLoopScrollView != null)
							{
								areaLoopScrollView.ScrollToGridIndex(0, false);
							}
							this.IsRepeatSelectCountry = false;
						}
						return;
					}
					int gridIndex = gridItemDataList.FindIndex((QuickNavigateLoopScrollAreaGridItemData item) => item.IsSelected);
					LoopScrollView<QuickNavigateLoopScrollAreaGridItem, QuickNavigateLoopScrollAreaGridItemData> areaLoopScrollView2 = this.AreaLoopScrollView;
					if (areaLoopScrollView2 == null)
					{
						return;
					}
					areaLoopScrollView2.ScrollToGridIndex(gridIndex, false);
				}, false);
			}
		}

		// Token: 0x06030314 RID: 197396 RVA: 0x00B2AC68 File Offset: 0x00B28E68
		private QuickNavigateDynamicData[] GetDynamicScrollViewDataList(ERefreshNavigateType refreshType)
		{
			List<IWorldMapNavigateCountryData> countryList = this.NavigateBundle.CountryList;
			List<QuickNavigateDynamicData> list = new List<QuickNavigateDynamicData>();
			foreach (IWorldMapNavigateCountryData worldMapNavigateCountryData in countryList)
			{
				int countryId = worldMapNavigateCountryData.CountryId;
				IWorldMapNavigateCountry navigateCountry = worldMapNavigateCountryData.NavigateCountry;
				QuickNavigateDynamicData quickNavigateDynamicData = new QuickNavigateDynamicData();
				quickNavigateDynamicData.ItemType = EQuickNavigateItemType.Country;
				quickNavigateDynamicData.CountryId = countryId;
				quickNavigateDynamicData.Index = list.Count;
				quickNavigateDynamicData.IsSelected = (this.SelectionInfo.CountryId == countryId);
				quickNavigateDynamicData.RefreshType = refreshType;
				quickNavigateDynamicData.HasState = (navigateCountry.StateMap != null);
				quickNavigateDynamicData.IsExpand = (this.SelectionInfo.CountryId == countryId && this.SelectionInfo.ExpandCountry);
				list.Add(quickNavigateDynamicData);
				if (navigateCountry.StateMap != null)
				{
					using (IEnumerator<IWorldMapNavigateState> enumerator2 = (from a in navigateCountry.StateMap.Values
					orderby a.SortIndex
					select a).GetEnumerator())
					{
						while (enumerator2.MoveNext())
						{
							IWorldMapNavigateState worldMapNavigateState = enumerator2.Current;
							if (this.SelectionInfo.CountryId == 0)
							{
								this.SelectionInfo.CountryId = countryId;
								this.SelectionInfo.ExpandCountry = true;
								this.SelectionInfo.StateId = worldMapNavigateState.StateId;
								this.SelectionInfo.AreaId = worldMapNavigateState.AreaNavigateList[0].AreaId;
								quickNavigateDynamicData.IsSelected = (this.SelectionInfo.CountryId == countryId);
								quickNavigateDynamicData.IsExpand = true;
							}
							quickNavigateDynamicData.StateId = worldMapNavigateState.StateId;
							bool flag = this.SelectionInfo.CountryId == countryId;
							bool expandCountry = this.SelectionInfo.ExpandCountry;
							if (flag && expandCountry)
							{
								this.SelectionInfo.FirstIndex = list.Count - 1;
								list.Add(new QuickNavigateDynamicData
								{
									ItemType = EQuickNavigateItemType.State,
									CountryId = countryId,
									StateId = worldMapNavigateState.StateId,
									Index = list.Count,
									IsSelected = (this.SelectionInfo.StateId == worldMapNavigateState.StateId),
									RefreshType = refreshType
								});
								if (this.SelectionInfo.StateId == worldMapNavigateState.StateId)
								{
									this.SelectionInfo.FirstIndex = list.Count - 1;
								}
							}
						}
						continue;
					}
				}
				if (this.SelectionInfo.CountryId == 0)
				{
					this.SelectionInfo.CountryId = countryId;
					this.SelectionInfo.ExpandCountry = false;
					this.SelectionInfo.StateId = 0;
					this.SelectionInfo.AreaId = navigateCountry.AreaNavigateList[0].AreaId;
					quickNavigateDynamicData.IsSelected = (this.SelectionInfo.CountryId == countryId);
				}
			}
			return list.ToArray();
		}

		// Token: 0x06030315 RID: 197397 RVA: 0x00B2AF80 File Offset: 0x00B29180
		private List<QuickNavigateLoopScrollAreaGridItemData> GetAreaGridItemDataList(ERefreshNavigateType refreshType)
		{
			List<QuickNavigateLoopScrollAreaGridItemData> list = new List<QuickNavigateLoopScrollAreaGridItemData>();
			int countryId = this.SelectionInfo.CountryId;
			int stateId = this.SelectionInfo.StateId;
			IWorldMapNavigateCountry valueOrDefault = this.NavigateBundle.CountryMap.GetValueOrDefault(countryId);
			if (valueOrDefault == null)
			{
				return list;
			}
			List<IWorldMapNavigate> areaNavigateList = valueOrDefault.AreaNavigateList;
			if (valueOrDefault.StateMap != null)
			{
				areaNavigateList = valueOrDefault.StateMap.GetValueOrDefault(stateId).AreaNavigateList;
			}
			foreach (IWorldMapNavigate worldMapNavigate in areaNavigateList)
			{
				QuickNavigateLoopScrollAreaGridItemData quickNavigateLoopScrollAreaGridItemData = new QuickNavigateLoopScrollAreaGridItemData();
				quickNavigateLoopScrollAreaGridItemData.AreaNavigateInfo = worldMapNavigate;
				quickNavigateLoopScrollAreaGridItemData.Index = list.Count;
				quickNavigateLoopScrollAreaGridItemData.RefreshType = refreshType;
				list.Add(quickNavigateLoopScrollAreaGridItemData);
				if (this.SelectionInfo.AreaId == 0)
				{
					this.SelectionInfo.AreaId = worldMapNavigate.AreaId;
				}
				if (this.SelectionInfo.AreaId == worldMapNavigate.AreaId)
				{
					this.SelectionInfo.FirstIndex = list.Count - 1;
				}
				quickNavigateLoopScrollAreaGridItemData.IsSelected = (this.SelectionInfo.AreaId == worldMapNavigate.AreaId);
			}
			return list;
		}

		// Token: 0x06030316 RID: 197398 RVA: 0x00B2B0BC File Offset: 0x00B292BC
		private void Select(ISelectionInfo selectInfo)
		{
			IWorldMapNavigateCountry valueOrDefault = this.NavigateBundle.CountryMap.GetValueOrDefault(selectInfo.CountryId);
			bool flag = ((valueOrDefault != null) ? valueOrDefault.StateMap : null) != null;
			int stateId = selectInfo.StateId;
			ISelectionInfo selectionInfo = this.SelectionInfo;
			int? num = (selectionInfo != null) ? new int?(selectionInfo.StateId) : null;
			bool flag2 = !(stateId == num.GetValueOrDefault() & num != null);
			bool flag4;
			if (flag)
			{
				bool expandCountry = selectInfo.ExpandCountry;
				ISelectionInfo selectionInfo2 = this.SelectionInfo;
				bool? flag3 = (selectionInfo2 != null) ? new bool?(selectionInfo2.ExpandCountry) : null;
				flag4 = !(expandCountry == flag3.GetValueOrDefault() & flag3 != null);
			}
			else
			{
				flag4 = false;
			}
			bool flag5 = flag4;
			int countryId = selectInfo.CountryId;
			ISelectionInfo selectionInfo3 = this.SelectionInfo;
			num = ((selectionInfo3 != null) ? new int?(selectionInfo3.CountryId) : null);
			bool flag6 = !(countryId == num.GetValueOrDefault() & num != null);
			bool flag7 = flag5 || flag6;
			this.SelectionInfo = selectInfo;
			if (!flag2 && !flag7)
			{
				ERefreshNavigateType refreshType = ERefreshNavigateType.AreaOnly;
				this.RefreshNavigateLayout(refreshType);
				this.ExecuteSelection(false);
				return;
			}
			if (flag2 && !flag7)
			{
				ERefreshNavigateType refreshType = ERefreshNavigateType.StateAndAreaBoth;
				this.RefreshNavigateLayout(refreshType);
				this.ExecuteSelection(false);
				return;
			}
			if (flag6)
			{
				ERefreshNavigateType refreshType = ERefreshNavigateType.All;
				this.RefreshNavigateLayout(refreshType);
				this.ExecuteSelection(false);
				return;
			}
			if (flag5)
			{
				ERefreshNavigateType refreshType = ERefreshNavigateType.StateOnly;
				this.RefreshNavigateLayout(refreshType);
			}
		}

		// Token: 0x06030317 RID: 197399 RVA: 0x00B2B210 File Offset: 0x00B29410
		private void SelectCountry(int countryId, int index)
		{
			IWorldMapNavigateCountry valueOrDefault = this.NavigateBundle.CountryMap.GetValueOrDefault(countryId);
			bool expandCountry = !this.SelectionInfo.ExpandCountry;
			bool flag = countryId != this.SelectionInfo.CountryId;
			if (valueOrDefault.StateMap != null)
			{
				if (flag)
				{
					expandCountry = true;
				}
				IWorldMapNavigateState worldMapNavigateState = (from a in valueOrDefault.StateMap.Values
				orderby a.SortIndex
				select a).First<IWorldMapNavigateState>();
				IWorldMapNavigate worldMapNavigate = worldMapNavigateState.AreaNavigateList[0];
				ISelectionInfo selectionInfo = this.SelectionInfo;
				int? num = (selectionInfo != null) ? new int?(selectionInfo.CountryId) : null;
				this.IsRepeatSelectCountry = (countryId == num.GetValueOrDefault() & num != null);
				this.Select(new SelectionInfo
				{
					FirstIndex = index,
					SecondIndex = 0,
					CountryId = countryId,
					ExpandCountry = expandCountry,
					StateId = (this.IsRepeatSelectCountry ? this.SelectionInfo.StateId : worldMapNavigateState.StateId),
					AreaId = worldMapNavigate.AreaId
				});
			}
			else
			{
				ISelectionInfo selectionInfo2 = this.SelectionInfo;
				int? num = (selectionInfo2 != null) ? new int?(selectionInfo2.CountryId) : null;
				this.IsRepeatSelectCountry = (countryId == num.GetValueOrDefault() & num != null);
				this.Select(new SelectionInfo
				{
					FirstIndex = index,
					SecondIndex = 0,
					CountryId = countryId,
					ExpandCountry = false,
					StateId = 0,
					AreaId = valueOrDefault.AreaNavigateList[0].AreaId
				});
			}
			if (flag)
			{
				if (this.SequencePlayer.IsSequenceInPlaying("Switch"))
				{
					this.SequencePlayer.ReplaySequence("Switch");
					return;
				}
				this.SequencePlayer.PlaySequence("Switch", false, null);
			}
		}

		// Token: 0x06030318 RID: 197400 RVA: 0x00B2B3F4 File Offset: 0x00B295F4
		private void SelectState(int stateId, int index)
		{
			bool flag = stateId != this.SelectionInfo.StateId;
			IWorldMapNavigateState valueOrDefault = this.NavigateBundle.CountryMap.GetValueOrDefault(this.SelectionInfo.CountryId).StateMap.GetValueOrDefault(stateId);
			SelectionInfo selectionInfo = new SelectionInfo();
			selectionInfo.FirstIndex = index;
			selectionInfo.SecondIndex = 0;
			selectionInfo.CountryId = this.SelectionInfo.CountryId;
			ISelectionInfo selectionInfo2 = this.SelectionInfo;
			selectionInfo.ExpandCountry = (selectionInfo2 == null || selectionInfo2.ExpandCountry);
			selectionInfo.StateId = stateId;
			selectionInfo.AreaId = valueOrDefault.AreaNavigateList[0].AreaId;
			this.Select(selectionInfo);
			if (flag)
			{
				if (this.SequencePlayer.IsSequenceInPlaying("Switch"))
				{
					this.SequencePlayer.ReplaySequence("Switch");
					return;
				}
				this.SequencePlayer.PlaySequence("Switch", false, null);
			}
		}

		// Token: 0x06030319 RID: 197401 RVA: 0x00B2B4D8 File Offset: 0x00B296D8
		private void SelectArea(int areaId, int index)
		{
			SelectionInfo selectionInfo = new SelectionInfo();
			selectionInfo.FirstIndex = this.SelectionInfo.FirstIndex;
			selectionInfo.SecondIndex = index;
			selectionInfo.CountryId = this.SelectionInfo.CountryId;
			ISelectionInfo selectionInfo2 = this.SelectionInfo;
			selectionInfo.ExpandCountry = (selectionInfo2 == null || selectionInfo2.ExpandCountry);
			selectionInfo.StateId = this.SelectionInfo.StateId;
			selectionInfo.AreaId = areaId;
			this.Select(selectionInfo);
		}

		// Token: 0x0603031A RID: 197402 RVA: 0x00B2B54C File Offset: 0x00B2974C
		private void ExecuteSelection(bool closeView = false)
		{
			if (closeView)
			{
				base.Close();
			}
			IWorldMapNavigate valueOrDefault = this.NavigateBundle.AreaMap.GetValueOrDefault(this.SelectionInfo.AreaId);
			EventSystem.Instance.Emit<NavigateMark>(EEventName.WorldMapNavigate, new NavigateMark
			{
				MarkId = valueOrDefault.MarkId,
				MarkType = valueOrDefault.MarkType
			});
		}

		// Token: 0x0603031B RID: 197403 RVA: 0x00B2B5AB File Offset: 0x00B297AB
		private void OnFirstNavigateSelect(QuickNavigateDynamicData navigateDynamicData)
		{
			if (navigateDynamicData.ItemType == EQuickNavigateItemType.Country)
			{
				this.SelectCountry(navigateDynamicData.CountryId, navigateDynamicData.Index);
				return;
			}
			this.SelectState(navigateDynamicData.StateId, navigateDynamicData.Index);
		}

		// Token: 0x0603031C RID: 197404 RVA: 0x00B2B5DC File Offset: 0x00B297DC
		private void OnSecondNavigateSelect(int gridIndex)
		{
			IWorldMapNavigate areaNavigateInfo = this.AreaLoopScrollView.TryGetCachedData(gridIndex).AreaNavigateInfo;
			this.SelectArea(areaNavigateInfo.AreaId, gridIndex);
		}

		// Token: 0x0603031D RID: 197405 RVA: 0x00B2B608 File Offset: 0x00B29808
		private void OnBeforeChangeMap()
		{
			base.GetItem(5).SetUIActive(true);
		}

		// Token: 0x0603031E RID: 197406 RVA: 0x00B2B617 File Offset: 0x00B29817
		private void OnAfterChangeMap()
		{
			base.GetItem(5).SetUIActive(false);
		}

		// Token: 0x0603031F RID: 197407 RVA: 0x00B2B626 File Offset: 0x00B29826
		[NullableContext(2)]
		private void OnFocusPlayerClick(int id, MarkItem markItem)
		{
			this.SelectionInfo = null;
			this.SetupSelection();
			this.RefreshNavigateLayout(ERefreshNavigateType.All);
			EventSystem.Instance.Emit(EEventName.WorldMapFocusPlayer);
		}

		// Token: 0x06030320 RID: 197408 RVA: 0x00B2B64C File Offset: 0x00B2984C
		private INavigateIconItemData[] GetNavigateIconDataList(List<MarkItem> navigateMarkItems)
		{
			ExploreProgressModel.Instance.ClearTrackTaskAreaId();
			List<INavigateIconItemData> list = new List<INavigateIconItemData>();
			foreach (MarkItem markItem in navigateMarkItems)
			{
				EMarkType markType = markItem.MarkType;
				if (markType != EMarkType.OtherPlayers)
				{
					if (markType == EMarkType.Quest)
					{
						list.Add(new NavigateIconItemData
						{
							Id = 1,
							IconPath = markItem.IconPath,
							ClickCallback = new Action<int, MarkItem>(this.OnNavigateIconClick),
							MarkItem = markItem
						});
						this.UpdateTrackTaskArea(markItem);
					}
				}
				else
				{
					int num = (markItem as PlayerMarkItem).PlayerIndex - 1;
					list.Add(new NavigateIconItemData
					{
						Id = 2 + num,
						IconId = WorldMapDefine.OnlinePlayerIconPathList2[num],
						ClickCallback = new Action<int, MarkItem>(this.OnNavigateIconClick),
						MarkItem = markItem
					});
				}
			}
			list.Sort((INavigateIconItemData a, INavigateIconItemData b) => b.Id - a.Id);
			list.Add(new NavigateIconItemData
			{
				Id = 0,
				IconId = "SP_IconCommonPlayer",
				ClickCallback = new Action<int, MarkItem>(this.OnFocusPlayerClick)
			});
			return list.ToArray();
		}

		// Token: 0x06030321 RID: 197409 RVA: 0x00B2B7A4 File Offset: 0x00B299A4
		[NullableContext(2)]
		private void OnNavigateIconClick(int id, MarkItem markItem = null)
		{
			UiNavigationNewController.Instance.MarkViewHandleRefreshNavigationDirty();
			EventSystem.Instance.Emit<EMarkType, int>(EEventName.OnWorldMapTrackMarkItem, markItem.MarkType, markItem.MarkId);
		}

		// Token: 0x06030322 RID: 197410 RVA: 0x00B2B7CC File Offset: 0x00B299CC
		private void UpdateTrackTaskArea(MarkItem markItem)
		{
			TTrackTarget trackTarget = markItem.TrackTarget;
			if (!(trackTarget is TTrackTarget_Int))
			{
				return;
			}
			LevelEntityConfig? entityConfigByMapIdAndEntityId = MapConfig.Instance.GetEntityConfigByMapIdAndEntityId(markItem.MapId, ((TTrackTarget_Int)trackTarget).Value);
			int? num = (entityConfigByMapIdAndEntityId != null) ? new int?(entityConfigByMapIdAndEntityId.GetValueOrDefault().AreaId) : null;
			if (num != null && num.Value != 0)
			{
				int levelOneAreaId = AreaConfig.Instance.GetLevelOneAreaId(num.Value);
				if (levelOneAreaId > 0)
				{
					ExploreProgressModel.Instance.SetTrackTaskAreaId(levelOneAreaId, markItem.IconPath);
				}
			}
		}

		// Token: 0x06030323 RID: 197411 RVA: 0x00B2B86B File Offset: 0x00B29A6B
		private void OnTimerRefresh(float delta)
		{
			if (OnlineModel.Instance.GetIsTeamModel())
			{
				ExploreProgressController.Instance.QueryOnlinePlayersAreaAsyncRequest().Forget();
			}
		}

		// Token: 0x06030324 RID: 197412 RVA: 0x00B2B888 File Offset: 0x00B29A88
		private void ClearTimer()
		{
			if (TimerSystem.RealTimeInstance.Has(this.RefreshTimerHandle))
			{
				TimerSystem.RealTimeInstance.Remove(this.RefreshTimerHandle);
				this.RefreshTimerHandle = null;
			}
		}

		// Token: 0x06030325 RID: 197413 RVA: 0x00B2B8B4 File Offset: 0x00B29AB4
		private void OnUpdateOnlinePlayersArea()
		{
			ERefreshNavigateType refreshType = ERefreshNavigateType.AreaOnly;
			this.RefreshNavigateLayout(refreshType);
		}

		// Token: 0x06030326 RID: 197414 RVA: 0x00B2B8CC File Offset: 0x00B29ACC
		private void OnPlayerMarkItemChanged()
		{
			List<MarkItem> navigateMarkList = this.Map.GetNavigateMarkList();
			this.OnBeforeShowWorldMapSecondaryUiAsync(new object[]
			{
				navigateMarkList
			}).Forget();
		}

		// Token: 0x04019F41 RID: 106305
		[Nullable(2)]
		private ISelectionInfo SelectionInfo;

		// Token: 0x04019F42 RID: 106306
		[Nullable(2)]
		protected UiSequencePlayer SequencePlayer;

		// Token: 0x04019F43 RID: 106307
		[Nullable(new byte[]
		{
			2,
			1,
			1,
			1
		})]
		private DynamicScrollView<QuickNavigateDynamicScrollItem, QuickNavigateDynamicItem, QuickNavigateDynamicData> DynamicScrollView;

		// Token: 0x04019F44 RID: 106308
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private LoopScrollView<QuickNavigateLoopScrollAreaGridItem, QuickNavigateLoopScrollAreaGridItemData> AreaLoopScrollView;

		// Token: 0x04019F45 RID: 106309
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private GenericLayout<NavigateIconItem, INavigateIconItemData> IconLayout;

		// Token: 0x04019F46 RID: 106310
		[Nullable(2)]
		private TimerHandle RefreshTimerHandle;

		// Token: 0x04019F47 RID: 106311
		private bool IsRepeatSelectCountry;

		// Token: 0x04019F48 RID: 106312
		private WorldMapNavigateBundle NavigateBundle = new WorldMapNavigateBundle();
	}
}
