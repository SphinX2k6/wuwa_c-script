using System;
using System.Collections.Generic;
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
	// Token: 0x0200370D RID: 14093
	[NullableContext(1)]
	[Nullable(0)]
	public class WorldMapQuickNavigatePanel : WorldMapSecondaryUi
	{
		// Token: 0x06024AD5 RID: 150229 RVA: 0x00A5A557 File Offset: 0x00A58757
		public override string GetResourceId()
		{
			return "UiItem_MapChange";
		}

		// Token: 0x06024AD6 RID: 150230 RVA: 0x00A5A560 File Offset: 0x00A58760
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

		// Token: 0x06024AD7 RID: 150231 RVA: 0x00A5A66E File Offset: 0x00A5886E
		protected override PopupTypeRightItem GetPopupRightItem()
		{
			return new PopupRightItemA();
		}

		// Token: 0x06024AD8 RID: 150232 RVA: 0x00A5A678 File Offset: 0x00A58878
		protected override UniTask OnBeforeStartAsync()
		{
			WorldMapQuickNavigatePanel.<OnBeforeStartAsync>d__11 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<WorldMapQuickNavigatePanel.<OnBeforeStartAsync>d__11>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06024AD9 RID: 150233 RVA: 0x00A5A6BC File Offset: 0x00A588BC
		protected override void OnStart()
		{
			UUIItem rootItem = base.GetRootItem();
			this.SequencePlayer = new UiSequencePlayer(rootItem);
		}

		// Token: 0x06024ADA RID: 150234 RVA: 0x00A5A6DC File Offset: 0x00A588DC
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

		// Token: 0x06024ADB RID: 150235 RVA: 0x00A5A7D0 File Offset: 0x00A589D0
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

		// Token: 0x06024ADC RID: 150236 RVA: 0x00A5A88C File Offset: 0x00A58A8C
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

		// Token: 0x06024ADD RID: 150237 RVA: 0x00A5A930 File Offset: 0x00A58B30
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

		// Token: 0x06024ADE RID: 150238 RVA: 0x00A5A984 File Offset: 0x00A58B84
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

		// Token: 0x06024ADF RID: 150239 RVA: 0x00A5A9CF File Offset: 0x00A58BCF
		protected override void OnCloseWorldMapSecondaryUi()
		{
			this.SelectionInfo = null;
		}

		// Token: 0x06024AE0 RID: 150240 RVA: 0x00A5A9D8 File Offset: 0x00A58BD8
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

		// Token: 0x06024AE1 RID: 150241 RVA: 0x00A5AA11 File Offset: 0x00A58C11
		private QuickNavigateLoopScrollAreaGridItem OnGridProxyCreate()
		{
			return new QuickNavigateLoopScrollAreaGridItem();
		}

		// Token: 0x06024AE2 RID: 150242 RVA: 0x00A5AA18 File Offset: 0x00A58C18
		private QuickNavigateDynamicScrollItem CreateItemFunc(QuickNavigateDynamicData data, UUIItem uiItem, int index)
		{
			return new QuickNavigateDynamicScrollItem();
		}

		// Token: 0x06024AE3 RID: 150243 RVA: 0x00A5AA20 File Offset: 0x00A58C20
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

		// Token: 0x06024AE4 RID: 150244 RVA: 0x00A5AB04 File Offset: 0x00A58D04
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
					using (List<IWorldMapNavigateState>.Enumerator enumerator2 = NoLinq.OrderByToList<IWorldMapNavigateState, int>(navigateCountry.StateMap.Values, (IWorldMapNavigateState state) => state.SortIndex).GetEnumerator())
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

		// Token: 0x06024AE5 RID: 150245 RVA: 0x00A5AE1C File Offset: 0x00A5901C
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

		// Token: 0x06024AE6 RID: 150246 RVA: 0x00A5AF58 File Offset: 0x00A59158
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

		// Token: 0x06024AE7 RID: 150247 RVA: 0x00A5B0AC File Offset: 0x00A592AC
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
				IWorldMapNavigateState worldMapNavigateState = null;
				foreach (IWorldMapNavigateState worldMapNavigateState2 in valueOrDefault.StateMap.Values)
				{
					if (worldMapNavigateState == null || worldMapNavigateState2.SortIndex < worldMapNavigateState.SortIndex)
					{
						worldMapNavigateState = worldMapNavigateState2;
					}
				}
				IWorldMapNavigateState worldMapNavigateState3 = worldMapNavigateState;
				IWorldMapNavigate worldMapNavigate = worldMapNavigateState3.AreaNavigateList[0];
				ISelectionInfo selectionInfo = this.SelectionInfo;
				int? num = (selectionInfo != null) ? new int?(selectionInfo.CountryId) : null;
				this.IsRepeatSelectCountry = (countryId == num.GetValueOrDefault() & num != null);
				this.Select(new SelectionInfo
				{
					FirstIndex = index,
					SecondIndex = 0,
					CountryId = countryId,
					ExpandCountry = expandCountry,
					StateId = (this.IsRepeatSelectCountry ? this.SelectionInfo.StateId : worldMapNavigateState3.StateId),
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

		// Token: 0x06024AE8 RID: 150248 RVA: 0x00A5B2C0 File Offset: 0x00A594C0
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

		// Token: 0x06024AE9 RID: 150249 RVA: 0x00A5B3A4 File Offset: 0x00A595A4
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

		// Token: 0x06024AEA RID: 150250 RVA: 0x00A5B418 File Offset: 0x00A59618
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

		// Token: 0x06024AEB RID: 150251 RVA: 0x00A5B477 File Offset: 0x00A59677
		private void OnFirstNavigateSelect(QuickNavigateDynamicData navigateDynamicData)
		{
			if (navigateDynamicData.ItemType == EQuickNavigateItemType.Country)
			{
				this.SelectCountry(navigateDynamicData.CountryId, navigateDynamicData.Index);
				return;
			}
			this.SelectState(navigateDynamicData.StateId, navigateDynamicData.Index);
		}

		// Token: 0x06024AEC RID: 150252 RVA: 0x00A5B4A8 File Offset: 0x00A596A8
		private void OnSecondNavigateSelect(int gridIndex)
		{
			IWorldMapNavigate areaNavigateInfo = this.AreaLoopScrollView.TryGetCachedData(gridIndex).AreaNavigateInfo;
			this.SelectArea(areaNavigateInfo.AreaId, gridIndex);
		}

		// Token: 0x06024AED RID: 150253 RVA: 0x00A5B4D4 File Offset: 0x00A596D4
		private void OnBeforeChangeMap()
		{
			base.GetItem(5).SetUIActive(true);
		}

		// Token: 0x06024AEE RID: 150254 RVA: 0x00A5B4E3 File Offset: 0x00A596E3
		private void OnAfterChangeMap()
		{
			base.GetItem(5).SetUIActive(false);
		}

		// Token: 0x06024AEF RID: 150255 RVA: 0x00A5B4F2 File Offset: 0x00A596F2
		[NullableContext(2)]
		private void OnFocusPlayerClick(int id, MarkItem markItem)
		{
			this.SelectionInfo = null;
			this.SetupSelection();
			this.RefreshNavigateLayout(ERefreshNavigateType.All);
			EventSystem.Instance.Emit(EEventName.WorldMapFocusPlayer);
		}

		// Token: 0x06024AF0 RID: 150256 RVA: 0x00A5B518 File Offset: 0x00A59718
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

		// Token: 0x06024AF1 RID: 150257 RVA: 0x00A5B670 File Offset: 0x00A59870
		[NullableContext(2)]
		private void OnNavigateIconClick(int id, MarkItem markItem = null)
		{
			UiNavigationNewController.Instance.MarkViewHandleRefreshNavigationDirty();
			EventSystem.Instance.Emit<EMarkType, int>(EEventName.OnWorldMapTrackMarkItem, markItem.MarkType, markItem.MarkId);
		}

		// Token: 0x06024AF2 RID: 150258 RVA: 0x00A5B698 File Offset: 0x00A59898
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

		// Token: 0x06024AF3 RID: 150259 RVA: 0x00A5B737 File Offset: 0x00A59937
		private void OnTimerRefresh(float delta)
		{
			if (OnlineModel.Instance.GetIsTeamModel())
			{
				ExploreProgressController.Instance.QueryOnlinePlayersAreaAsyncRequest().Forget();
			}
		}

		// Token: 0x06024AF4 RID: 150260 RVA: 0x00A5B754 File Offset: 0x00A59954
		private void ClearTimer()
		{
			if (TimerSystem.RealTimeInstance.Has(this.RefreshTimerHandle))
			{
				TimerSystem.RealTimeInstance.Remove(this.RefreshTimerHandle);
				this.RefreshTimerHandle = null;
			}
		}

		// Token: 0x06024AF5 RID: 150261 RVA: 0x00A5B780 File Offset: 0x00A59980
		private void OnUpdateOnlinePlayersArea()
		{
			ERefreshNavigateType refreshType = ERefreshNavigateType.AreaOnly;
			this.RefreshNavigateLayout(refreshType);
		}

		// Token: 0x06024AF6 RID: 150262 RVA: 0x00A5B798 File Offset: 0x00A59998
		private void OnPlayerMarkItemChanged()
		{
			List<MarkItem> navigateMarkList = this.Map.GetNavigateMarkList();
			this.OnBeforeShowWorldMapSecondaryUiAsync(new object[]
			{
				navigateMarkList
			}).Forget();
		}

		// Token: 0x040145F5 RID: 83445
		[Nullable(2)]
		private ISelectionInfo SelectionInfo;

		// Token: 0x040145F6 RID: 83446
		[Nullable(2)]
		protected UiSequencePlayer SequencePlayer;

		// Token: 0x040145F7 RID: 83447
		[Nullable(new byte[]
		{
			2,
			1,
			1,
			1
		})]
		private DynamicScrollView<QuickNavigateDynamicScrollItem, QuickNavigateDynamicItem, QuickNavigateDynamicData> DynamicScrollView;

		// Token: 0x040145F8 RID: 83448
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private LoopScrollView<QuickNavigateLoopScrollAreaGridItem, QuickNavigateLoopScrollAreaGridItemData> AreaLoopScrollView;

		// Token: 0x040145F9 RID: 83449
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private GenericLayout<NavigateIconItem, INavigateIconItemData> IconLayout;

		// Token: 0x040145FA RID: 83450
		[Nullable(2)]
		private TimerHandle RefreshTimerHandle;

		// Token: 0x040145FB RID: 83451
		private bool IsRepeatSelectCountry;

		// Token: 0x040145FC RID: 83452
		private WorldMapNavigateBundle NavigateBundle = new WorldMapNavigateBundle();
	}
}
