using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using Aki.Protocol.Debug;
using CSharpScript.Core.Common;
using CSharpScript.Game.Common;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Area;
using CSharpScript.Game.Module.Battle;
using CSharpScript.Game.Module.GenericPrompt;
using CSharpScript.Game.Module.Map;
using CSharpScript.Game.Module.Map.Controller;
using CSharpScript.Game.Module.Map.MapDefine;
using CSharpScript.Game.Module.Map.Mark;
using CSharpScript.Game.Module.Map.Marks.MarkItem;
using CSharpScript.Game.Module.Map.Marks.MarkItemView;
using CSharpScript.Game.Module.Map.Misc;
using CSharpScript.Game.Module.Map.View.BaseMap;
using CSharpScript.Game.Module.Map.View.BaseMap.Assistant.MapLifeEvent;
using CSharpScript.Game.Module.RecallQuest.Model;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Module.WorldMap.RegionalTerminal.View;
using CSharpScript.Game.Module.WorldMap.SubItems;
using CSharpScript.Game.Module.WorldMap.SubViews;
using CSharpScript.Game.Module.WorldMap.SubViews.Common;
using CSharpScript.Game.Module.WorldMap.SubViews.CustomMarkPanel;
using CSharpScript.Game.Module.WorldMap.SubViews.TrackMenu;
using CSharpScript.Game.Module.WorldMap.SubViews.UnderseaExperimentField;
using CSharpScript.Game.Module.WorldMap.ViewComponent;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using Google.Protobuf;
using Ui.WorldMap.View.Component;
using UnrealEngine;
using UnrealEngine.Extension;

namespace CSharpScript.Game.Module.WorldMap
{
	// Token: 0x020047AC RID: 18348
	[NullableContext(1)]
	[Nullable(0)]
	public class WorldMapView : UiTickViewBase
	{
		// Token: 0x0602FFE7 RID: 196583 RVA: 0x00B1C320 File Offset: 0x00B1A520
		public WorldMapView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x0602FFE8 RID: 196584 RVA: 0x00B1C40D File Offset: 0x00B1A60D
		private bool InEightMap()
		{
			return this.OpenParamMapId == 8;
		}

		// Token: 0x0602FFE9 RID: 196585 RVA: 0x00B1C418 File Offset: 0x00B1A618
		protected unsafe override void OnRegisterComponent()
		{
			int num = 31;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUISliderComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(7, typeof(UUINiagara));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(8, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(9, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(10, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(11, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(12, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(13, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(14, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(15, typeof(UUIVerticalLayout));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(16, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(17, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(18, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(19, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(20, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(21, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(22, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(23, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(24, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(25, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(26, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(27, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(28, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(29, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(30, typeof(UUITexture));
			this.ComponentRegisterInfos = list;
			num2 = 3;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(5, new Action(this.OnCloseBtnClick));
			num++;
			*span2[num] = new ValueTuple<int, Delegate>(17, new Action(this.OnChangeMapBtnClick));
			num++;
			*span2[num] = new ValueTuple<int, Delegate>(6, new Action(this.OnMarkToggleBtnClick));
			this.BtnBindInfo = list2;
		}

		// Token: 0x0602FFEA RID: 196586 RVA: 0x00B1C8DC File Offset: 0x00B1AADC
		protected override UniTask OnBeforeStartAsync()
		{
			WorldMapView.<OnBeforeStartAsync>d__41 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<WorldMapView.<OnBeforeStartAsync>d__41>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0602FFEB RID: 196587 RVA: 0x00B1C920 File Offset: 0x00B1AB20
		private void InitShowMode()
		{
			this.ShowMode = (EWorldMapShowMode)InstanceDungeonConfig.Instance.GetConfig(CreatureModel.Instance.GetInstanceId()).Value.MapShowMode;
			if (FlagChallengeBattleModel.Instance.IsInFlagChallengeDungeon)
			{
				this.ShowMode = EWorldMapShowMode.Base;
			}
			if (RecallQuestModel.Instance.IsInRecallInstance())
			{
				this.ShowMode = EWorldMapShowMode.Recall;
			}
			this.PowerCurrencyItem.SetWorldMapSelfShow(this.ShowMode);
			this.OverPowerCurrencyItem.SetWorldMapSelfShow(this.ShowMode);
			this.WorldMapPeriodicActivityItem.SetWorldMapSelfShow(this.ShowMode);
			this.ExploreInfoItem.SetWorldMapSelfShow(this.ShowMode);
			this.RegionalTerminalBar.SetWorldMapSelfShow(this.ShowMode);
		}

		// Token: 0x0602FFEC RID: 196588 RVA: 0x00B1C9D4 File Offset: 0x00B1ABD4
		private void SetupParams()
		{
			if (this.ShowParams != null)
			{
				int? markId = this.ShowParams.MarkId;
				if (markId != null && markId.GetValueOrDefault() != 0 && this.ShowParams.MapId == null)
				{
					int? markId2 = this.ShowParams.MarkId;
					EMarkType markType = this.ShowParams.MarkType;
					int markMapConfigId = MapModel.Instance.GetMarkMapConfigId(markId2.Value, markType);
					this.ShowParams.MapId = new int?(markMapConfigId);
				}
				if (this.ShowParams.MapId == null)
				{
					this.ShowParams.MapId = new int?(MapModel.Instance.CurrentWorldMapConfigId);
				}
				this.OpenParamMapId = this.ShowParams.MapId.GetValueOrDefault();
			}
			else
			{
				this.OpenParamMapId = MapModel.Instance.CurrentWorldMapConfigId;
			}
			if (this.OpenParamMapId == 0 || !WorldMapConfig.Instance.IsMapInWorld(this.OpenParamMapId))
			{
				this.InstanceIdToMapId();
			}
			WorldMapModel.Instance.WorldMapId = new int?(this.OpenParamMapId);
			int navigateAreaId = (this.ShowParams == null) ? 0 : WorldMapView.GetNavigateAreaId(this.ShowParams.MarkId, this.ShowParams.MarkType);
			WorldMapModel.Instance.InitScaleTier(null, navigateAreaId);
			WorldMapModel.Instance.ResetMapScale(null);
		}

		// Token: 0x0602FFED RID: 196589 RVA: 0x00B1CB3A File Offset: 0x00B1AD3A
		private static int GetNavigateAreaId(int? markId, EMarkType markType)
		{
			if ((markId ?? 0) == 0)
			{
				return 0;
			}
			return MapModel.Instance.GetWorldMapMarkAreaId(markId.Value, markType);
		}

		// Token: 0x0602FFEE RID: 196590 RVA: 0x00B1CB64 File Offset: 0x00B1AD64
		private unsafe void InstanceIdToMapId()
		{
			MapModel instance = MapModel.Instance;
			AreaConfig instance2 = AreaConfig.Instance;
			int num = instance.GetDungeonWorldMapConfigId(CreatureModel.Instance.GetInstanceId());
			ILastBigSceneMiniMapInfo lastBigSceneMiniMapInfo = WorldMapModel.Instance.LastBigSceneMiniMapInfo;
			if (!WorldMapConfig.Instance.IsMapInWorld(num))
			{
				int? lastHighLevelArea = instance.LastHighLevelArea;
				int num2 = 0;
				if (!(lastHighLevelArea.GetValueOrDefault() == num2 & lastHighLevelArea != null))
				{
					int levelOneAreaId = instance2.GetLevelOneAreaId(instance.LastHighLevelArea.Value);
					Area? area;
					num = ((instance2.GetAreaInfo(levelOneAreaId) != null) ? area.GetValueOrDefault().MapConfigId : num);
				}
			}
			this.OpenParamMapId = num;
			if (!WorldMapConfig.Instance.IsMapInWorld(num))
			{
				this.OpenParamMapId = 8;
				ELogAuthor author = ELogAuthor.LYX;
				string message = "[地图系统]->获取上一次大世界区域配置失败";
				<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("MapId:", this.OpenParamMapId);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("lastBigSceneMiniMapInfo", lastBigSceneMiniMapInfo);
				MapLogger.Error(author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
			}
		}

		// Token: 0x0602FFEF RID: 196591 RVA: 0x00B1CC78 File Offset: 0x00B1AE78
		[NullableContext(0)]
		private UniTask<bool> LoadAllUiObjAsync()
		{
			WorldMapView.<LoadAllUiObjAsync>d__46 <LoadAllUiObjAsync>d__;
			<LoadAllUiObjAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<LoadAllUiObjAsync>d__.<>4__this = this;
			<LoadAllUiObjAsync>d__.<>1__state = -1;
			<LoadAllUiObjAsync>d__.<>t__builder.Start<WorldMapView.<LoadAllUiObjAsync>d__46>(ref <LoadAllUiObjAsync>d__);
			return <LoadAllUiObjAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0602FFF0 RID: 196592 RVA: 0x00B1CCBC File Offset: 0x00B1AEBC
		[NullableContext(0)]
		private UniTask<bool> RequestInfrV2Info()
		{
			WorldMapView.<RequestInfrV2Info>d__47 <RequestInfrV2Info>d__;
			<RequestInfrV2Info>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<RequestInfrV2Info>d__.<>1__state = -1;
			<RequestInfrV2Info>d__.<>t__builder.Start<WorldMapView.<RequestInfrV2Info>d__47>(ref <RequestInfrV2Info>d__);
			return <RequestInfrV2Info>d__.<>t__builder.Task;
		}

		// Token: 0x0602FFF1 RID: 196593 RVA: 0x00B1CCF8 File Offset: 0x00B1AEF8
		private UniTask CreateMapUiObj()
		{
			WorldMapView.<CreateMapUiObj>d__48 <CreateMapUiObj>d__;
			<CreateMapUiObj>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<CreateMapUiObj>d__.<>4__this = this;
			<CreateMapUiObj>d__.<>1__state = -1;
			<CreateMapUiObj>d__.<>t__builder.Start<WorldMapView.<CreateMapUiObj>d__48>(ref <CreateMapUiObj>d__);
			return <CreateMapUiObj>d__.<>t__builder.Task;
		}

		// Token: 0x0602FFF2 RID: 196594 RVA: 0x00B1CD3C File Offset: 0x00B1AF3C
		private UniTask CreateCurrencyItemUiObj()
		{
			WorldMapView.<CreateCurrencyItemUiObj>d__49 <CreateCurrencyItemUiObj>d__;
			<CreateCurrencyItemUiObj>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<CreateCurrencyItemUiObj>d__.<>4__this = this;
			<CreateCurrencyItemUiObj>d__.<>1__state = -1;
			<CreateCurrencyItemUiObj>d__.<>t__builder.Start<WorldMapView.<CreateCurrencyItemUiObj>d__49>(ref <CreateCurrencyItemUiObj>d__);
			return <CreateCurrencyItemUiObj>d__.<>t__builder.Task;
		}

		// Token: 0x0602FFF3 RID: 196595 RVA: 0x00B1CD80 File Offset: 0x00B1AF80
		private UniTask CreatePowerCurrencyItemUiObj()
		{
			WorldMapView.<CreatePowerCurrencyItemUiObj>d__50 <CreatePowerCurrencyItemUiObj>d__;
			<CreatePowerCurrencyItemUiObj>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<CreatePowerCurrencyItemUiObj>d__.<>4__this = this;
			<CreatePowerCurrencyItemUiObj>d__.<>1__state = -1;
			<CreatePowerCurrencyItemUiObj>d__.<>t__builder.Start<WorldMapView.<CreatePowerCurrencyItemUiObj>d__50>(ref <CreatePowerCurrencyItemUiObj>d__);
			return <CreatePowerCurrencyItemUiObj>d__.<>t__builder.Task;
		}

		// Token: 0x0602FFF4 RID: 196596 RVA: 0x00B1CDC4 File Offset: 0x00B1AFC4
		private UniTask CreateCursorItemUiObj()
		{
			WorldMapView.<CreateCursorItemUiObj>d__51 <CreateCursorItemUiObj>d__;
			<CreateCursorItemUiObj>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<CreateCursorItemUiObj>d__.<>4__this = this;
			<CreateCursorItemUiObj>d__.<>1__state = -1;
			<CreateCursorItemUiObj>d__.<>t__builder.Start<WorldMapView.<CreateCursorItemUiObj>d__51>(ref <CreateCursorItemUiObj>d__);
			return <CreateCursorItemUiObj>d__.<>t__builder.Task;
		}

		// Token: 0x0602FFF5 RID: 196597 RVA: 0x00B1CE08 File Offset: 0x00B1B008
		private UniTask CreateExploreItemUiObj()
		{
			WorldMapView.<CreateExploreItemUiObj>d__52 <CreateExploreItemUiObj>d__;
			<CreateExploreItemUiObj>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<CreateExploreItemUiObj>d__.<>4__this = this;
			<CreateExploreItemUiObj>d__.<>1__state = -1;
			<CreateExploreItemUiObj>d__.<>t__builder.Start<WorldMapView.<CreateExploreItemUiObj>d__52>(ref <CreateExploreItemUiObj>d__);
			return <CreateExploreItemUiObj>d__.<>t__builder.Task;
		}

		// Token: 0x0602FFF6 RID: 196598 RVA: 0x00B1CE4C File Offset: 0x00B1B04C
		private UniTask CreateActivityListItemUiObj()
		{
			WorldMapView.<CreateActivityListItemUiObj>d__53 <CreateActivityListItemUiObj>d__;
			<CreateActivityListItemUiObj>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<CreateActivityListItemUiObj>d__.<>4__this = this;
			<CreateActivityListItemUiObj>d__.<>1__state = -1;
			<CreateActivityListItemUiObj>d__.<>t__builder.Start<WorldMapView.<CreateActivityListItemUiObj>d__53>(ref <CreateActivityListItemUiObj>d__);
			return <CreateActivityListItemUiObj>d__.<>t__builder.Task;
		}

		// Token: 0x0602FFF7 RID: 196599 RVA: 0x00B1CE90 File Offset: 0x00B1B090
		private UniTask CreateShowAreaOpenEffect()
		{
			WorldMapView.<CreateShowAreaOpenEffect>d__54 <CreateShowAreaOpenEffect>d__;
			<CreateShowAreaOpenEffect>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<CreateShowAreaOpenEffect>d__.<>4__this = this;
			<CreateShowAreaOpenEffect>d__.<>1__state = -1;
			<CreateShowAreaOpenEffect>d__.<>t__builder.Start<WorldMapView.<CreateShowAreaOpenEffect>d__54>(ref <CreateShowAreaOpenEffect>d__);
			return <CreateShowAreaOpenEffect>d__.<>t__builder.Task;
		}

		// Token: 0x0602FFF8 RID: 196600 RVA: 0x00B1CED4 File Offset: 0x00B1B0D4
		private UniTask CreateUnderseaOverview()
		{
			WorldMapView.<CreateUnderseaOverview>d__55 <CreateUnderseaOverview>d__;
			<CreateUnderseaOverview>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<CreateUnderseaOverview>d__.<>4__this = this;
			<CreateUnderseaOverview>d__.<>1__state = -1;
			<CreateUnderseaOverview>d__.<>t__builder.Start<WorldMapView.<CreateUnderseaOverview>d__55>(ref <CreateUnderseaOverview>d__);
			return <CreateUnderseaOverview>d__.<>t__builder.Task;
		}

		// Token: 0x0602FFF9 RID: 196601 RVA: 0x00B1CF18 File Offset: 0x00B1B118
		private UniTask CreateChangeGravityButton()
		{
			WorldMapView.<CreateChangeGravityButton>d__56 <CreateChangeGravityButton>d__;
			<CreateChangeGravityButton>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<CreateChangeGravityButton>d__.<>4__this = this;
			<CreateChangeGravityButton>d__.<>1__state = -1;
			<CreateChangeGravityButton>d__.<>t__builder.Start<WorldMapView.<CreateChangeGravityButton>d__56>(ref <CreateChangeGravityButton>d__);
			return <CreateChangeGravityButton>d__.<>t__builder.Task;
		}

		// Token: 0x0602FFFA RID: 196602 RVA: 0x00B1CF5C File Offset: 0x00B1B15C
		private void CreateZoomButtonUiObj()
		{
			this.ZoomInButton = new LongPressButton(base.GetButton(2), new Action<float>(this.OnZoomOut), 100);
			this.ZoomOutButton = new LongPressButton(base.GetButton(3), new Action<float>(this.OnZoomIn), 100);
		}

		// Token: 0x0602FFFB RID: 196603 RVA: 0x00B1CFA9 File Offset: 0x00B1B1A9
		private void CreateMultiMapFloorLayout()
		{
			this.MultiMapFloorLayout = new GenericLayout<WorldMapSubMapItem, MultiMap>(base.GetVerticalLayout(15), () => new WorldMapSubMapItem(), null, false, true);
		}

		// Token: 0x0602FFFC RID: 196604 RVA: 0x00B1CFE0 File Offset: 0x00B1B1E0
		private UniTask CreateHonamiMarkSelectPanel()
		{
			WorldMapView.<CreateHonamiMarkSelectPanel>d__59 <CreateHonamiMarkSelectPanel>d__;
			<CreateHonamiMarkSelectPanel>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<CreateHonamiMarkSelectPanel>d__.<>4__this = this;
			<CreateHonamiMarkSelectPanel>d__.<>1__state = -1;
			<CreateHonamiMarkSelectPanel>d__.<>t__builder.Start<WorldMapView.<CreateHonamiMarkSelectPanel>d__59>(ref <CreateHonamiMarkSelectPanel>d__);
			return <CreateHonamiMarkSelectPanel>d__.<>t__builder.Task;
		}

		// Token: 0x0602FFFD RID: 196605 RVA: 0x00B1D024 File Offset: 0x00B1B224
		private UniTask CreateRegionalTerminalBar()
		{
			WorldMapView.<CreateRegionalTerminalBar>d__60 <CreateRegionalTerminalBar>d__;
			<CreateRegionalTerminalBar>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<CreateRegionalTerminalBar>d__.<>4__this = this;
			<CreateRegionalTerminalBar>d__.<>1__state = -1;
			<CreateRegionalTerminalBar>d__.<>t__builder.Start<WorldMapView.<CreateRegionalTerminalBar>d__60>(ref <CreateRegionalTerminalBar>d__);
			return <CreateRegionalTerminalBar>d__.<>t__builder.Task;
		}

		// Token: 0x0602FFFE RID: 196606 RVA: 0x00B1D068 File Offset: 0x00B1B268
		protected override void OnAddEventListener()
		{
			EventSystem.Instance.Add<MarkItem>(EEventName.MarkMenuClickItem, new Action<MarkItem>(this.OnMarkMenuClickItem));
			EventSystem.Instance.Add<EUiViewName>(EEventName.OpenViewBegined, new Action<EUiViewName>(this.OnOpenViewBegin));
			EventSystem.Instance.Add<EUiViewName, int>(EEventName.CloseView, new Action<EUiViewName, int>(this.OnCloseView));
			EventSystem.Instance.Add<Vector2D>(EEventName.WorldMapPointerDrag, new Action<Vector2D>(this.OnPointerDrag));
			EventSystem.Instance.Add<float, EMapScaleSetType>(EEventName.WorldMapFingerExpandClose, new Action<float, EMapScaleSetType>(this.IncreaseMapScale));
			EventSystem.Instance.Add<float, EMapScaleSetType>(EEventName.WorldMapWheelAxisInput, new Action<float, EMapScaleSetType>(this.IncreaseMapScale));
			EventSystem.Instance.Add<float, EMapScaleSetType>(EEventName.WorldMapHandleTriggerAxisInput, new Action<float, EMapScaleSetType>(this.IncreaseMapScale));
			EventSystem.Instance.Add<float, EMapScaleSetType>(EEventName.WorldMapZoomBtnInput, new Action<float, EMapScaleSetType>(this.IncreaseMapScale));
			EventSystem.Instance.Add<ULGUIPointerEventData>(EEventName.WorldMapPointerUp, new Action<ULGUIPointerEventData>(this.OnPointerUp));
			EventSystem.Instance.Add<bool>(EEventName.WorldMapSecondaryUiClosed, new Action<bool>(this.OnSecondaryUiClosed));
			EventSystem.Instance.Add(EEventName.WorldMapSecondaryUiOpened, new Action(this.OnSecondaryUiOpened));
			EventSystem.Instance.Add<EInputControllerType, EInputControllerType>(EEventName.InputControllerChange, new Action<EInputControllerType, EInputControllerType>(this.InputControllerChange));
			EventSystem.Instance.Add(EEventName.WorldMapFocusPlayer, new Action(this.OnWorldMapFocusPlayer));
			EventSystem.Instance.Add(EEventName.WorldMapShowTrackList, new Action(this.OnWorldMapShowTrackList));
			EventSystem.Instance.Add<ITrackMenuItemData>(EEventName.TrackMenuClickItem, new Action<ITrackMenuItemData>(this.OnTrackMenuClickItem));
			EventSystem.Instance.Add(EEventName.GetAreaProgress, new Action(this.UpdateAreaProgress));
			EventSystem.Instance.Add<EMarkType, int>(EEventName.OnWorldMapTrackMarkItem, new Action<EMarkType, int>(this.OnWorldMapTrackMarkItem));
			EventSystem.Instance.Add<DynamicMarkCreateInfo>(EEventName.CreateMapMark, new Action<DynamicMarkCreateInfo>(this.OnCreateMarkItem));
			EventSystem.Instance.Add<MarkItem>(EEventName.AddMapMark, new Action<MarkItem>(this.OnAddMarkItem));
			EventSystem.Instance.Add<EMarkType, int>(EEventName.RemoveMapMark, new Action<EMarkType, int>(this.OnRemoveMarkItem));
			EventSystem.Instance.Add(EEventName.BlackScreenFadeOnPlotToWorldMap, new Action(this.HandleUnLockEffect));
			EventSystem.Instance.Add<int, EMarkType, bool, bool, bool?>(EEventName.WorldMapFocalMarkItem, new Action<int, EMarkType, bool, bool, bool?>(this.OnNavigateFocalMarkItem));
			EventSystem.Instance.Add<WorldMapChangeMapParams>(EEventName.ChangeWorldMap, new Action<WorldMapChangeMapParams>(this.OnChangeWorldMap));
			EventSystem.Instance.Add<bool>(EEventName.ToggleShowCustomMark, new Action<bool>(this.EventToggleShowCustomMark));
			EventSystem.Instance.Add<bool>(EEventName.ToggleShowCompletedPlayMark, new Action<bool>(this.EventToggleShowCompletedPlayMark));
			EventSystem.Instance.Add<NavigateMarkShowRange>(EEventName.NavigateMarkAndShowRange, new Action<NavigateMarkShowRange>(this.EventNavigateMarkAndShowRange));
			EventSystem.Instance.Add<int, EExploreType?>(EEventName.OpenExploreAreaDetailViewFromMap, new Action<int, EExploreType?>(this.EventOpenExploreAreaDetailViewFromMap));
			EventSystem.Instance.Add<EWorldMapExtraUiPanelName, object>(EEventName.OpenExtraUiFromMap, new Action<EWorldMapExtraUiPanelName, object>(this.EventOpenExtraUiFromMap));
			EventSystem.Instance.Add(EEventName.CloseAllExtraUiFromMap, new Action(this.EventCloseAllExtraUiFromMap));
			EventSystem.Instance.Add<int>(EEventName.MapOpenFogChange, new Action<int>(this.OnMapOpenFogChange));
			EventSystem.Instance.Add(EEventName.WorldMapActivityListDataUpdate, new Action(this.OnWorldMapActivityListDataUpdate));
			EventSystem.Instance.Add<bool>(EEventName.SetWorldMapCursorButtonVisible, new Action<bool>(this.SetWorldMapCursorButtonVisible));
		}

		// Token: 0x0602FFFF RID: 196607 RVA: 0x00B1D3F0 File Offset: 0x00B1B5F0
		protected override void OnRemoveEventListener()
		{
			EventSystem.Instance.Remove<MarkItem>(EEventName.MarkMenuClickItem, new Action<MarkItem>(this.OnMarkMenuClickItem));
			EventSystem.Instance.Remove<EUiViewName>(EEventName.OpenViewBegined, new Action<EUiViewName>(this.OnOpenViewBegin));
			EventSystem.Instance.Remove<EUiViewName, int>(EEventName.CloseView, new Action<EUiViewName, int>(this.OnCloseView));
			EventSystem.Instance.Remove<Vector2D>(EEventName.WorldMapPointerDrag, new Action<Vector2D>(this.OnPointerDrag));
			EventSystem.Instance.Remove<float, EMapScaleSetType>(EEventName.WorldMapFingerExpandClose, new Action<float, EMapScaleSetType>(this.IncreaseMapScale));
			EventSystem.Instance.Remove<float, EMapScaleSetType>(EEventName.WorldMapWheelAxisInput, new Action<float, EMapScaleSetType>(this.IncreaseMapScale));
			EventSystem.Instance.Remove<float, EMapScaleSetType>(EEventName.WorldMapHandleTriggerAxisInput, new Action<float, EMapScaleSetType>(this.IncreaseMapScale));
			EventSystem.Instance.Remove<float, EMapScaleSetType>(EEventName.WorldMapZoomBtnInput, new Action<float, EMapScaleSetType>(this.IncreaseMapScale));
			EventSystem.Instance.Remove<ULGUIPointerEventData>(EEventName.WorldMapPointerUp, new Action<ULGUIPointerEventData>(this.OnPointerUp));
			EventSystem.Instance.Remove<bool>(EEventName.WorldMapSecondaryUiClosed, new Action<bool>(this.OnSecondaryUiClosed));
			EventSystem.Instance.Remove(EEventName.WorldMapSecondaryUiOpened, new Action(this.OnSecondaryUiOpened));
			EventSystem.Instance.Remove<EInputControllerType, EInputControllerType>(EEventName.InputControllerChange, new Action<EInputControllerType, EInputControllerType>(this.InputControllerChange));
			EventSystem.Instance.Remove(EEventName.WorldMapFocusPlayer, new Action(this.OnWorldMapFocusPlayer));
			EventSystem.Instance.Remove(EEventName.WorldMapShowTrackList, new Action(this.OnWorldMapShowTrackList));
			EventSystem.Instance.Remove<ITrackMenuItemData>(EEventName.TrackMenuClickItem, new Action<ITrackMenuItemData>(this.OnTrackMenuClickItem));
			EventSystem.Instance.Remove(EEventName.GetAreaProgress, new Action(this.UpdateAreaProgress));
			EventSystem.Instance.Remove<EMarkType, int>(EEventName.OnWorldMapTrackMarkItem, new Action<EMarkType, int>(this.OnWorldMapTrackMarkItem));
			EventSystem.Instance.Remove<DynamicMarkCreateInfo>(EEventName.CreateMapMark, new Action<DynamicMarkCreateInfo>(this.OnCreateMarkItem));
			EventSystem.Instance.Remove<MarkItem>(EEventName.AddMapMark, new Action<MarkItem>(this.OnAddMarkItem));
			EventSystem.Instance.Remove<EMarkType, int>(EEventName.RemoveMapMark, new Action<EMarkType, int>(this.OnRemoveMarkItem));
			EventSystem.Instance.Remove(EEventName.BlackScreenFadeOnPlotToWorldMap, new Action(this.HandleUnLockEffect));
			EventSystem.Instance.Remove<int, EMarkType, bool, bool, bool?>(EEventName.WorldMapFocalMarkItem, new Action<int, EMarkType, bool, bool, bool?>(this.OnNavigateFocalMarkItem));
			EventSystem.Instance.Remove<WorldMapChangeMapParams>(EEventName.ChangeWorldMap, new Action<WorldMapChangeMapParams>(this.OnChangeWorldMap));
			EventSystem.Instance.Remove<bool>(EEventName.ToggleShowCustomMark, new Action<bool>(this.EventToggleShowCustomMark));
			EventSystem.Instance.Remove<bool>(EEventName.ToggleShowCompletedPlayMark, new Action<bool>(this.EventToggleShowCompletedPlayMark));
			EventSystem.Instance.Remove<NavigateMarkShowRange>(EEventName.NavigateMarkAndShowRange, new Action<NavigateMarkShowRange>(this.EventNavigateMarkAndShowRange));
			EventSystem.Instance.Remove<int, EExploreType?>(EEventName.OpenExploreAreaDetailViewFromMap, new Action<int, EExploreType?>(this.EventOpenExploreAreaDetailViewFromMap));
			EventSystem.Instance.Remove<EWorldMapExtraUiPanelName, object>(EEventName.OpenExtraUiFromMap, new Action<EWorldMapExtraUiPanelName, object>(this.EventOpenExtraUiFromMap));
			EventSystem.Instance.Remove(EEventName.CloseAllExtraUiFromMap, new Action(this.EventCloseAllExtraUiFromMap));
			EventSystem.Instance.Remove<int>(EEventName.MapOpenFogChange, new Action<int>(this.OnMapOpenFogChange));
			EventSystem.Instance.Remove(EEventName.WorldMapActivityListDataUpdate, new Action(this.OnWorldMapActivityListDataUpdate));
			EventSystem.Instance.Remove<bool>(EEventName.SetWorldMapCursorButtonVisible, new Action<bool>(this.SetWorldMapCursorButtonVisible));
		}

		// Token: 0x06030000 RID: 196608 RVA: 0x00B1D778 File Offset: 0x00B1B978
		protected override void OnStart()
		{
			this.RegisterLogicComponents();
			this.CheckAndCleanInvalidCustomMarks();
			this.HudSequencer = new LevelSequencePlayer(base.GetItem(14));
			this.HudSequencer.BindSequenceCloseEvent(new TSequenceEndEvent(this.OnHudSequenceEnd), false);
			base.GetText(18).ShowTextNew("ChangeMapBtn_Text");
			this.ExploreInfoItem.SetInfo(this.WorldMapUiEntity, new Action<Action, bool>(this.CloseSecondaryUi));
			this.ExploreInfoItem.UpdateBtnRedOrNew(false, false);
			base.GetText(21).SetUIActive(WorldMapModel.Instance.EnableDebug);
			this.RefreshAllItemShow();
		}

		// Token: 0x06030001 RID: 196609 RVA: 0x00B1D818 File Offset: 0x00B1BA18
		private void RefreshAllItemShow()
		{
			this.PowerCurrencyItem.RefreshWorldMapSelfShow(this.ShowMode);
			this.OverPowerCurrencyItem.RefreshWorldMapSelfShow(this.ShowMode);
			this.WorldMapPeriodicActivityItem.RefreshWorldMapSelfShow(this.ShowMode);
			this.ExploreInfoItem.RefreshWorldMapSelfShow(this.ShowMode);
			this.RegionalTerminalBar.RefreshWorldMapSelfShow(this.ShowMode);
			UUIItem uuiitem = base.GetButton(17).RootUIComp.Get();
			EWorldMapShowMode showMode = this.ShowMode;
			bool uiactive = showMode == EWorldMapShowMode.Default || showMode == EWorldMapShowMode.Recall;
			uuiitem.SetUIActive(uiactive);
		}

		// Token: 0x06030002 RID: 196610 RVA: 0x00B1D8AC File Offset: 0x00B1BAAC
		protected override void OnBeforeShow()
		{
			this.InitSize();
			this.OverridePsoCvars();
			WorldMapUiEntity worldMapUiEntity = this.WorldMapUiEntity;
			if (worldMapUiEntity != null)
			{
				worldMapUiEntity.Init();
			}
			this.WorldMapUiEntity.MultiFloorComponent.MultiMapFloorContainer = base.GetItem(16);
			this.ExploreInfoItem.SetMapNotesState(true);
			this.UpdateAreaProgress();
			this.UpdateGravityBtn();
			this.UpdateCustomizedThumbnail();
			if (this.OpenFogId > 0)
			{
				BaseMap map = this.Map;
				if (map != null)
				{
					map.HandleFogAreaOpen(this.OpenFogId);
				}
			}
			this.LifeEventDispatcher.OnWorldMapBeforeShow();
			this.WorldMapUiEntity.UpdateMarkItems(null);
			IWorldMapViewOpenParams showParams = this.ShowParams;
			if (showParams != null)
			{
				if (showParams.SkipToExtraUiName != null)
				{
					this.OpenExtraUi(showParams.SkipToExtraUiName.Value, showParams.SkipToExtraUiParam);
				}
				int? markId = showParams.MarkId;
				if (markId != null && markId.GetValueOrDefault() != 0)
				{
					BaseMap map2 = this.Map;
					MarkItem markItem = (map2 != null) ? map2.GetMarkItem(showParams.MarkType, showParams.MarkId.Value) : null;
					if (markItem != null)
					{
						MapHelper.CheckAndShowCrossMapTips(showParams.MarkId.Value, showParams.MarkType, markItem.TrackAreaId, markItem.WorldPosition);
						this.WorldMapUiEntity.QuickNavigateComponent.NavigateTo(showParams.MarkId.Value, showParams.MarkType, !showParams.IsNotFocal.GetValueOrDefault(), !showParams.IsNotFocusTween.GetValueOrDefault(), false);
					}
				}
				if (showParams.FocusExplorePlayPoint != null)
				{
					int areaId = showParams.FocusExplorePlayPoint[0];
					int exploreType = showParams.FocusExplorePlayPoint[1];
					ExploreProgressModel.Instance.SetTrackExploreAreaItemData(areaId, exploreType);
					ExploreProgressModel.Instance.CheckTrackExploreAreaItemData();
				}
				IWorldMapViewOpenParams showParams2 = this.ShowParams;
				if (((showParams2 != null) ? showParams2.SkipToExploreAreaDetailView : null) != null)
				{
					int areaId2 = this.ShowParams.SkipToExploreAreaDetailView[0];
					EExploreType value = (EExploreType)this.ShowParams.SkipToExploreAreaDetailView[1];
					this.OpenMapExploreAreaDetailView(areaId2, new EExploreType?(value));
				}
				IWorldMapViewOpenParams showParams3 = this.ShowParams;
				if (showParams3 != null && showParams3.NeedRefreshMultiFloor.GetValueOrDefault())
				{
					this.WorldMapUiEntity.MultiFloorComponent.InitMultiMap();
				}
			}
			else
			{
				this.WorldMapUiEntity.MultiFloorComponent.InitMultiMap();
			}
			this.UpdateExtraSecondaryUiOpen();
			this.IsWaitNoteAndRecommend = this.WorldMapUiEntity.SecondaryUiComponent.IsSecondaryUiOpening;
			if (!this.IsWaitNoteAndRecommend)
			{
				this.ExploreInfoItem.UpdateNoteOrPlayProgress();
			}
			if (this.RegionalTerminalBar.IsAvailableShow())
			{
				this.RegionalTerminalBar.BeforeShow();
			}
		}

		// Token: 0x06030003 RID: 196611 RVA: 0x00B1DB38 File Offset: 0x00B1BD38
		private void InitSize()
		{
			this.WorldMapUiEntity.PlayerComponent.PlayerRotation = 0f;
			float num = base.GetItem(8).GetWidth() / this.RootItem.GetWidth();
			float num2 = base.GetItem(8).GetHeight() / this.RootItem.GetHeight();
			Vector2D viewportSize = LGuiExtension.GetViewportSize();
			this.WorldMapUiEntity.MarkEdgeSize = new Vector2D(viewportSize.X / 2.0 * (double)num - 70.0, viewportSize.Y / 2.0 * (double)num2 - 70.0);
			this.WorldMapUiEntity.OutOfViewPortSize = Vector2D.Create((viewportSize.X / 2.0 + 400.0) * (double)num, (viewportSize.Y / 2.0 + 400.0) * (double)num2);
		}

		// Token: 0x06030004 RID: 196612 RVA: 0x00B1DC28 File Offset: 0x00B1BE28
		protected override UniTask OnPlayingStartSequenceAsync()
		{
			WorldMapView.<OnPlayingStartSequenceAsync>d__67 <OnPlayingStartSequenceAsync>d__;
			<OnPlayingStartSequenceAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnPlayingStartSequenceAsync>d__.<>4__this = this;
			<OnPlayingStartSequenceAsync>d__.<>1__state = -1;
			<OnPlayingStartSequenceAsync>d__.<>t__builder.Start<WorldMapView.<OnPlayingStartSequenceAsync>d__67>(ref <OnPlayingStartSequenceAsync>d__);
			return <OnPlayingStartSequenceAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06030005 RID: 196613 RVA: 0x00B1DC6C File Offset: 0x00B1BE6C
		protected override void OnAfterShow()
		{
			EventSystem.Instance.Emit(EEventName.WorldMapViewOpened);
			this.ShowParams = null;
			this.LifeEventDispatcher.OnWorldMapAfterShow();
			this.WorldMapUiEntity.MultiFloorComponent.UpdateMultiMap();
			ExploreProgressModel.Instance.CheckTrackExploreAreaItemData();
			if (this.ShowFogEffectInstant)
			{
				this.HandleUnLockEffect();
			}
		}

		// Token: 0x06030006 RID: 196614 RVA: 0x00B1DCC4 File Offset: 0x00B1BEC4
		protected override void OnAfterPlayStartSequence()
		{
			if (this.IsWaitNoteAndRecommend)
			{
				return;
			}
			this.ResumeMapAndRecommendSequence(null);
		}

		// Token: 0x06030007 RID: 196615 RVA: 0x00B1DCEC File Offset: 0x00B1BEEC
		private UniTask ResumeMapAndRecommendSequence(float? waitTime = null)
		{
			WorldMapView.<ResumeMapAndRecommendSequence>d__70 <ResumeMapAndRecommendSequence>d__;
			<ResumeMapAndRecommendSequence>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<ResumeMapAndRecommendSequence>d__.<>4__this = this;
			<ResumeMapAndRecommendSequence>d__.waitTime = waitTime;
			<ResumeMapAndRecommendSequence>d__.<>1__state = -1;
			<ResumeMapAndRecommendSequence>d__.<>t__builder.Start<WorldMapView.<ResumeMapAndRecommendSequence>d__70>(ref <ResumeMapAndRecommendSequence>d__);
			return <ResumeMapAndRecommendSequence>d__.<>t__builder.Task;
		}

		// Token: 0x06030008 RID: 196616 RVA: 0x00B1DD38 File Offset: 0x00B1BF38
		private void HandleUnLockEffect()
		{
			if (this.OpenFogId <= 0)
			{
				return;
			}
			this.OpenFogId = 0;
			this.ShowFogEffectInstant = false;
			BaseMap map = this.Map;
			FVector? fvector = (map != null) ? new FVector?(map.SelfPlayerNode.GetLGUISpaceAbsolutePosition()) : null;
			if (fvector != null)
			{
				UUIItem unLockItem = this.UnLockItem;
				FVector value = fvector.Value;
				unLockItem.SetLGUISpaceAbsolutePosition(value);
			}
			this.UnLockItem.SetUIActive(!this.IsNotNeedUnLockEffect);
			this.UnLockSequence.PlayLevelSequenceByName("Start", true, null, false);
			BaseMap map2 = this.Map;
			if (map2 == null)
			{
				return;
			}
			map2.HandleMapTileDelegate();
		}

		// Token: 0x06030009 RID: 196617 RVA: 0x00B1DDE0 File Offset: 0x00B1BFE0
		protected override void OnBeforeHide()
		{
			this.RestorePsoCvars();
			if (this.RegionalTerminalBar.IsAvailableShow())
			{
				this.RegionalTerminalBar.BeforeHide();
			}
			BaseMap map = this.Map;
			if (map != null)
			{
				map.UnBindMapTileDelegate();
			}
			this.ShowParams = null;
			WorldMapModel.Instance.SetNavigateBoxArea(0, 0);
		}

		// Token: 0x0603000A RID: 196618 RVA: 0x00B1DE30 File Offset: 0x00B1C030
		private void OverridePsoCvars()
		{
			foreach (string text in this._psoCvars)
			{
				this._cachedPsoCvarValues[text] = UKismetSystemLibrary.GetConsoleVariableIntValue(text);
				UKismetSystemLibrary.ExecuteConsoleCommand(GlobalData.World, text + " 1", null);
			}
		}

		// Token: 0x0603000B RID: 196619 RVA: 0x00B1DE80 File Offset: 0x00B1C080
		private void RestorePsoCvars()
		{
			foreach (KeyValuePair<string, int> keyValuePair in this._cachedPsoCvarValues)
			{
				UObject world = GlobalData.World;
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted(keyValuePair.Key);
				defaultInterpolatedStringHandler.AppendLiteral(" ");
				defaultInterpolatedStringHandler.AppendFormatted<int>(keyValuePair.Value);
				UKismetSystemLibrary.ExecuteConsoleCommand(world, defaultInterpolatedStringHandler.ToStringAndClear(), null);
			}
			this._cachedPsoCvarValues.Clear();
		}

		// Token: 0x0603000C RID: 196620 RVA: 0x00B1DF1C File Offset: 0x00B1C11C
		protected override void OnTick(float delta)
		{
			if (this.WorldMapUiEntity != null)
			{
				WorldMapUiEntity worldMapUiEntity = this.WorldMapUiEntity;
				if (((worldMapUiEntity != null) ? worldMapUiEntity.Map : null) != null)
				{
					this.WorldMapUiEntity.Tick(delta);
					if (this.ClickedItems == null)
					{
						this.ClickedItems = new List<MarkItem>();
					}
					this.WorldMapUiEntity.InteractComponent.CheckTouch();
					this.WorldMapUiEntity.MoveComponent.TickMoveDirty();
					this.JoystickCheck(false);
					return;
				}
			}
		}

		// Token: 0x0603000D RID: 196621 RVA: 0x00B1DF8C File Offset: 0x00B1C18C
		[Conditional("DEBUG")]
		private void DrawDebug()
		{
		}

		// Token: 0x0603000E RID: 196622 RVA: 0x00B1DF90 File Offset: 0x00B1C190
		private void CalculateJoystickClickItems()
		{
			if (Info.Instance.IsInGamepad())
			{
				FVectorDouble location = this.CursorButton.GetRootItem().D_K2_GetComponentLocation();
				FTransformDouble ftransformDouble = this.Map.MapRootItem.D_K2_GetComponentToWorld();
				FVectorDouble fvectorDouble = UKismetMathLibrary.D_InverseTransformLocation(ftransformDouble, location);
				this.ClickedPosition.Set(fvectorDouble.X, fvectorDouble.Y);
				this.MinRangeAndItem.Item1 = 2147483647.0;
				this.ClickedItems = new List<MarkItem>();
				BaseMap map = this.Map;
				Dictionary<EMarkType, Dictionary<int, MarkItem>> dictionary = (map != null) ? map.GetAllMarkItems() : null;
				bool singleTest = dictionary.Count <= 1;
				foreach (Dictionary<int, MarkItem> dictionary2 in dictionary.Values)
				{
					foreach (MarkItem markItem in dictionary2.Values)
					{
						if (markItem.View != null)
						{
							ValueTuple<bool, double> valueTuple = this.InClickRangeByUiPosition(this.ClickedPosition, Vector2D.Create(markItem.UiPosition.X, markItem.UiPosition.Y), singleTest, new bool?(true), this.WorldMapUiEntity.WorldMapExtraUiPanelComponent.GetCustomClickRange());
							bool item = valueTuple.Item1;
							double item2 = valueTuple.Item2;
							bool interactiveFlag = markItem.GetInteractiveFlag();
							if (item && interactiveFlag)
							{
								if (this.MinRangeAndItem.Item1 > item2)
								{
									this.MinRangeAndItem.Item1 = item2;
									this.MinRangeAndItem.Item2 = markItem;
								}
								this.ClickedItems.Add(markItem);
							}
						}
					}
				}
				this.CursorButton.SetSelected(false);
			}
		}

		// Token: 0x0603000F RID: 196623 RVA: 0x00B1E160 File Offset: 0x00B1C360
		private void HandleJoystickMoving(bool forceExecute = false)
		{
			if ((Info.Instance.IsInGamepad() && this.WorldMapUiEntity.InteractComponent.IsJoystickMoving && !this.WorldMapUiEntity.MoveComponent.IsDragMoveDisabled) || forceExecute)
			{
				this.WorldMapUiEntity.MoveComponent.KillTweening();
				this.CalculateJoystickClickItems();
			}
		}

		// Token: 0x06030010 RID: 196624 RVA: 0x00B1E1BC File Offset: 0x00B1C3BC
		private void HandleJoystickNoMoving()
		{
			if (Info.Instance.IsInGamepad() && !this.WorldMapUiEntity.InteractComponent.IsJoystickMoving && !this.WorldMapUiEntity.InteractComponent.IsJoystickZoom)
			{
				if (this.WorldMapUiEntity.InteractComponent.IsJoystickFocus)
				{
					if (this.WorldMapUiEntity.MoveComponent.IsTweeningMove)
					{
						return;
					}
					this.WorldMapUiEntity.InteractComponent.SetJoystickFocus(false);
					this.CalculateJoystickClickItems();
				}
				if (this.ClickedItems.Count > 0 && this.WorldMapUiEntity.ClickedItem == null)
				{
					this.CursorButton.SetSelected(true);
					this.WorldMapUiEntity.MoveComponent.SetMapPosition(this.MinRangeAndItem.Item2, true, EClampType.NotClamp, new LTweenEase?(this.UiParams.TweenTypeEase), new float?(this.UiParams.GamePadTweenTime), true, false);
				}
			}
		}

		// Token: 0x06030011 RID: 196625 RVA: 0x00B1E2A4 File Offset: 0x00B1C4A4
		private void JoystickCheck(bool forceExecute = false)
		{
			this.HandleJoystickMoving(forceExecute);
			this.HandleJoystickNoMoving();
		}

		// Token: 0x06030012 RID: 196626 RVA: 0x00B1E2B4 File Offset: 0x00B1C4B4
		protected override void OnBeforeDestroy()
		{
			this.CloseSecondaryUi(null, true);
			this.UnRegisterLogicComponents();
			this.ExploreInfoItem.DestroyMapNotes();
			this.ExploreInfoItem.DestroyMapPlayPoints();
			WorldMapController.Instance.ClearFocalMarkItem();
			this.ZoomInButton.OnDestroy();
			this.ZoomOutButton.OnDestroy();
			LevelSequencePlayer unLockSequence = this.UnLockSequence;
			if (unLockSequence != null)
			{
				unLockSequence.Clear();
			}
			LevelSequencePlayer hudSequencer = this.HudSequencer;
			if (hudSequencer != null)
			{
				hudSequencer.Clear();
			}
			this.ClickedItems = null;
			this.PowerCurrencyItem.Destroy(null);
			this.OverPowerCurrencyItem.Destroy(null);
			BaseMap map = this.Map;
			if (map != null)
			{
				map.Destroy(null);
			}
			this.CursorButton.Destroy(null);
			WorldMapModel.Instance.WorldMapAxisInteractValidation.Reset();
			WorldMapModel.Instance.WorldMapId = null;
			WorldMapModel.Instance.WorldMapCurrentMultiMapId = null;
			WorldMapModel.Instance.WorldExtraUiCount = 0;
			WorldMapModel.Instance.IsCanAutoPilotTrack = true;
			WorldMapModel.Instance.IsMapRangeVisible = true;
			WorldMapModel.Instance.IsMultiMapVisible = true;
			MapModel.Instance.ClearPendingAddTempMapMarkList();
			MapModel instance = MapModel.Instance;
			if (instance != null)
			{
				instance.ClearExtraUiMarkType(EMapType.WorldMap);
			}
			MapModel instance2 = MapModel.Instance;
			if (instance2 != null)
			{
				instance2.ClearExtraUiMarkId(EMapType.WorldMap);
			}
			MapModel instance3 = MapModel.Instance;
			if (instance3 != null)
			{
				instance3.ClearExtraUiTileRange(EMapType.WorldMap);
			}
			LevelPlayReportModel.Instance.ResetDetailRequestFlag();
			ExploreProgressModel.Instance.WorldMapViewClose();
			ExploreProgressModel.Instance.SaveToLocalShowNoteIdMap();
			EventSystem.Instance.Emit(EEventName.OnWorldMapClose);
		}

		// Token: 0x06030013 RID: 196627 RVA: 0x00B1E42C File Offset: 0x00B1C62C
		private UniTask ChangeMapAsyncAfterFocalMark(WorldMapChangeMapParams changeMapParams)
		{
			WorldMapView.<ChangeMapAsyncAfterFocalMark>d__82 <ChangeMapAsyncAfterFocalMark>d__;
			<ChangeMapAsyncAfterFocalMark>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<ChangeMapAsyncAfterFocalMark>d__.<>4__this = this;
			<ChangeMapAsyncAfterFocalMark>d__.changeMapParams = changeMapParams;
			<ChangeMapAsyncAfterFocalMark>d__.<>1__state = -1;
			<ChangeMapAsyncAfterFocalMark>d__.<>t__builder.Start<WorldMapView.<ChangeMapAsyncAfterFocalMark>d__82>(ref <ChangeMapAsyncAfterFocalMark>d__);
			return <ChangeMapAsyncAfterFocalMark>d__.<>t__builder.Task;
		}

		// Token: 0x06030014 RID: 196628 RVA: 0x00B1E478 File Offset: 0x00B1C678
		private UniTask ChangeMapAfterAsync(WorldMapChangeMapParams changeMapParams)
		{
			WorldMapView.<ChangeMapAfterAsync>d__83 <ChangeMapAfterAsync>d__;
			<ChangeMapAfterAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<ChangeMapAfterAsync>d__.<>4__this = this;
			<ChangeMapAfterAsync>d__.changeMapParams = changeMapParams;
			<ChangeMapAfterAsync>d__.<>1__state = -1;
			<ChangeMapAfterAsync>d__.<>t__builder.Start<WorldMapView.<ChangeMapAfterAsync>d__83>(ref <ChangeMapAfterAsync>d__);
			return <ChangeMapAfterAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06030015 RID: 196629 RVA: 0x00B1E4C4 File Offset: 0x00B1C6C4
		private UniTask ChangeMapAfterFocusPlayer()
		{
			WorldMapView.<ChangeMapAfterFocusPlayer>d__84 <ChangeMapAfterFocusPlayer>d__;
			<ChangeMapAfterFocusPlayer>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<ChangeMapAfterFocusPlayer>d__.<>4__this = this;
			<ChangeMapAfterFocusPlayer>d__.<>1__state = -1;
			<ChangeMapAfterFocusPlayer>d__.<>t__builder.Start<WorldMapView.<ChangeMapAfterFocusPlayer>d__84>(ref <ChangeMapAfterFocusPlayer>d__);
			return <ChangeMapAfterFocusPlayer>d__.<>t__builder.Task;
		}

		// Token: 0x06030016 RID: 196630 RVA: 0x00B1E508 File Offset: 0x00B1C708
		private void RegisterLogicComponents()
		{
			this.WorldMapUiEntity = new WorldMapUiEntity();
			this.WorldMapUiEntity.Map = this.Map;
			this.WorldMapUiEntity.UiParams = this.UiParams;
			this.WorldMapUiEntity.OpenParams = this.ShowParams;
			this.WorldMapUiEntity.MapId = this.OpenParamMapId;
			this.WorldMapUiEntity.RegisterComponents();
			this.WorldMapUiEntity.ScaleComponent.ScaleSlider = base.GetSlider(1);
			WorldMapScaleComponent scaleComponent = this.WorldMapUiEntity.ScaleComponent;
			scaleComponent.BoxPanel = base.GetItem(26);
			scaleComponent.BoxThresholdSprite = base.GetSprite(27);
			scaleComponent.BoxHandleTexture = base.GetTexture(28);
			scaleComponent.BoxSwitchButton = new ButtonItem(base.GetItem(29));
			scaleComponent.BoxSwitchButton.SetFunction(delegate(int _)
			{
				this.OnBoxSwitchBtnClick();
			});
			scaleComponent.BoxBarSequencer = new LevelSequencePlayer(base.GetItem(26));
			scaleComponent.SetHandleTextureFunction = delegate(string path, UUITexture texture)
			{
				base.SetTextureByPath(path, texture, null, null);
			};
			this.WorldMapUiEntity.MultiFloorComponent.MultiMapFloorLayout = this.MultiMapFloorLayout;
			TWorldMapPlaySequenceFunction tworldMapPlaySequenceFunction = delegate(string sequenceName, bool blockClick)
			{
				WorldMapView.<<RegisterLogicComponents>b__85_2>d <<RegisterLogicComponents>b__85_2>d;
				<<RegisterLogicComponents>b__85_2>d.<>t__builder = AsyncUniTaskMethodBuilder.Create();
				<<RegisterLogicComponents>b__85_2>d.<>4__this = this;
				<<RegisterLogicComponents>b__85_2>d.sequenceName = sequenceName;
				<<RegisterLogicComponents>b__85_2>d.blockClick = blockClick;
				<<RegisterLogicComponents>b__85_2>d.<>1__state = -1;
				<<RegisterLogicComponents>b__85_2>d.<>t__builder.Start<WorldMapView.<<RegisterLogicComponents>b__85_2>d>(ref <<RegisterLogicComponents>b__85_2>d);
				return <<RegisterLogicComponents>b__85_2>d.<>t__builder.Task;
			};
			this.WorldMapUiEntity.MultiFloorComponent.WorldMapViewPlaySequenceFunction = tworldMapPlaySequenceFunction;
			this.WorldMapUiEntity.WorldMapAlterMapComponent.WorldMapViewPlaySequenceFunction = tworldMapPlaySequenceFunction;
			this.WorldMapUiEntity.BoxTransitionPlaySequenceFunction = tworldMapPlaySequenceFunction;
			this.WorldMapUiEntity.BoxScreenCaptureTexture = base.GetTexture(30);
			this.WorldMapUiEntity.WorldMapAlterMapComponent.InverseTowerCtrlRoot = base.GetItem(20);
			this.WorldMapUiEntity.WorldMapAlterMapComponent.InverseTowerCtrlRoot.SetUIActive(false);
			this.WorldMapUiEntity.WorldMapExtraUiPanelComponent.OnExtraUiViewOpened = new Action<WorldMapExtraUiPanel>(this.OnExtraUiViewOpened);
			this.WorldMapUiEntity.WorldMapExtraUiPanelComponent.OnExtraUiViewClosed = new Action(this.OnExtraUiViewClosed);
		}

		// Token: 0x06030017 RID: 196631 RVA: 0x00B1E6D3 File Offset: 0x00B1C8D3
		private void UnRegisterLogicComponents()
		{
			this.WorldMapUiEntity.Dispose();
			this.WorldMapUiEntity = null;
		}

		// Token: 0x06030018 RID: 196632 RVA: 0x00B1E6E8 File Offset: 0x00B1C8E8
		private void ShowPanel(MarkItem clickedItem, ECustomMarkPanelMode customPanelMode = ECustomMarkPanelMode.Modify)
		{
			if (Info.Instance.IsInGamepad())
			{
				this.WorldMapUiEntity.MoveComponent.PushMap(clickedItem, true, EClampType.NotClamp);
			}
			else
			{
				this.WorldMapUiEntity.MoveComponent.PushMap(clickedItem, true, EClampType.ClampToSafeArea);
			}
			this.WorldMapUiEntity.SecondaryUiComponent.ShowPanel(clickedItem, base.GetItem(25), (int)customPanelMode);
		}

		// Token: 0x06030019 RID: 196633 RVA: 0x00B1E744 File Offset: 0x00B1C944
		private void UpdateExtraSecondaryUiOpen()
		{
			bool extraSecondaryUiOpen = false;
			foreach (EUiViewName viewName in this.ExtraSecondaryUiViewMap)
			{
				if (UiManager.Instance.IsViewOpen(viewName))
				{
					extraSecondaryUiOpen = true;
					break;
				}
			}
			this.WorldMapUiEntity.SecondaryUiComponent.ExtraSecondaryUiOpen = extraSecondaryUiOpen;
		}

		// Token: 0x0603001A RID: 196634 RVA: 0x00B1E7B4 File Offset: 0x00B1C9B4
		private void OnOpenViewBegin(EUiViewName viewName)
		{
			if (this.ExtraSecondaryUiViewMap.Contains(viewName))
			{
				this.CloseSecondaryUi(null, false);
				this.WorldMapUiEntity.SecondaryUiComponent.ExtraSecondaryUiOpen = true;
				this.OnSecondaryUiOpened();
			}
		}

		// Token: 0x0603001B RID: 196635 RVA: 0x00B1E7E3 File Offset: 0x00B1C9E3
		private void OnCloseView(EUiViewName viewName, int i)
		{
			if (this.ExtraSecondaryUiViewMap.Contains(viewName))
			{
				this.WorldMapUiEntity.SecondaryUiComponent.ExtraSecondaryUiOpen = false;
				if (!this.WorldMapUiEntity.SecondaryUiComponent.IsSecondaryUiOpening)
				{
					this.OnSecondaryUiClosed(false);
				}
			}
		}

		// Token: 0x0603001C RID: 196636 RVA: 0x00B1E820 File Offset: 0x00B1CA20
		[NullableContext(2)]
		private void CloseSecondaryUi(Action onClosed = null, bool playSequence = true)
		{
			WorldMapUiEntity worldMapUiEntity = this.WorldMapUiEntity;
			if (((worldMapUiEntity != null) ? worldMapUiEntity.ClickedItem : null) != null && this.WorldMapUiEntity.ClickedItem.IsIgnoreScaleShow)
			{
				this.WorldMapUiEntity.ClickedItem.IsIgnoreScaleShow = false;
				this.WorldMapUiEntity.ClickedItem.SetSelected(false);
				this.WorldMapUiEntity.UpdateSingleMarkItem(this.WorldMapUiEntity.ClickedItem, true);
			}
			if (this.WorldMapUiEntity.SecondaryUiComponent.ExtraSecondaryUiOpen)
			{
				foreach (EUiViewName euiViewName in this.ExtraSecondaryUiViewMap)
				{
					if (UiManager.Instance.IsViewOpen(euiViewName))
					{
						UiManager.Instance.CloseView(euiViewName, null);
					}
				}
			}
			if (!this.WorldMapUiEntity.SecondaryUiComponent.IsInternalSecondaryUiOpen())
			{
				if (onClosed != null)
				{
					onClosed();
				}
				return;
			}
			this.WorldMapUiEntity.MultiFloorComponent.UpdateMultiMap();
			this.WorldMapUiEntity.SecondaryUiComponent.CloseUi(onClosed, playSequence);
		}

		// Token: 0x0603001D RID: 196637 RVA: 0x00B1E934 File Offset: 0x00B1CB34
		private void OpenPowerView(int index)
		{
			this.CloseSecondaryUi(delegate
			{
				PowerController.Instance.OpenPowerView(EPowerMenuType.Supply, 0);
			}, true);
		}

		// Token: 0x0603001E RID: 196638 RVA: 0x00B1E95C File Offset: 0x00B1CB5C
		private void OnSecondaryUiClosed(bool bIsForce = false)
		{
			BaseMap map = this.Map;
			if (map != null)
			{
				map.SetClickRangeVisible(false, null);
			}
			if (this.WorldMapUiEntity.ClickedItem != null)
			{
				this.WorldMapUiEntity.ClickedItem.IsIgnoreScaleShow = false;
				this.WorldMapUiEntity.ClickedItem.SetSelected(false);
				this.WorldMapUiEntity.UpdateSingleMarkItem(this.WorldMapUiEntity.ClickedItem, true);
				this.WorldMapUiEntity.ClickedItem = null;
			}
			this.RemoveUncommittedCustomMark();
			this.WorldMapUiEntity.UpdateMarkItems(null);
			this.ExploreInfoItem.SetMapNotesState(true);
			if (!this.WorldMapUiEntity.WorldMapExtraUiPanelComponent.ShowTopPanel() && (!this.IsCloseThenOpenSecondaryUi || bIsForce))
			{
				this.HudSequencer.StopCurrentSequence(false, false);
				base.GetItem(14).SetUIActive(true);
				EventSystem.Instance.Emit<bool>(EEventName.WorldMapPanelHudVisibleChanged, true);
				this.HudSequencer.PlayLevelSequenceByName("Show", false, null, false);
			}
			this.JoystickCheck(Info.Instance.IsInGamepad());
			this.CursorButton.SetCursorActive(true);
			this.CheckWaitNoteAndRecommend();
		}

		// Token: 0x0603001F RID: 196639 RVA: 0x00B1EA7C File Offset: 0x00B1CC7C
		private void CheckWaitNoteAndRecommend()
		{
			if (!this.IsWaitNoteAndRecommend)
			{
				return;
			}
			if (this.WorldMapUiEntity.SecondaryUiComponent.IsSecondaryUiOpening)
			{
				return;
			}
			int num = 500;
			this.IsWaitNoteAndRecommend = false;
			this.ExploreInfoItem.UpdateNoteOrPlayProgress();
			this.ResumeMapAndRecommendSequence(new float?((float)num));
		}

		// Token: 0x06030020 RID: 196640 RVA: 0x00B1EACC File Offset: 0x00B1CCCC
		private void OnSecondaryUiOpened()
		{
			this.ExploreInfoItem.SetMapNotesState(false);
			if (!this.WorldMapUiEntity.WorldMapExtraUiPanelComponent.HideTopPanel())
			{
				UUIItem item = base.GetItem(14);
				if (!this.IsCloseThenOpenSecondaryUi || (item != null && item.IsUIActiveSelf()))
				{
					this.HudSequencer.StopCurrentSequence(false, false);
					this.HudSequencer.PlayLevelSequenceByName("Hide", false, null, false);
				}
				this.IsCloseThenOpenSecondaryUi = false;
			}
			this.CursorButton.SetCursorActive(false);
		}

		// Token: 0x06030021 RID: 196641 RVA: 0x00B1EB4E File Offset: 0x00B1CD4E
		private void OnHudSequenceEnd(string param)
		{
			if (param == "Hide")
			{
				base.GetItem(14).SetUIActive(false);
				EventSystem.Instance.Emit<bool>(EEventName.WorldMapPanelHudVisibleChanged, false);
			}
		}

		// Token: 0x06030022 RID: 196642 RVA: 0x00B1EB7C File Offset: 0x00B1CD7C
		private void OnPointerDrag(Vector2D delta)
		{
			if (this.WorldMapUiEntity.MoveComponent.IsDragMoveDisabled)
			{
				return;
			}
			WorldMapUiEntity worldMapUiEntity = this.WorldMapUiEntity;
			if (worldMapUiEntity != null && worldMapUiEntity.WorldMapExtraUiPanelComponent.OnPointerDrag(delta))
			{
				return;
			}
			this.CloseSecondaryUi(null, true);
		}

		// Token: 0x17007834 RID: 30772
		// (get) Token: 0x06030023 RID: 196643 RVA: 0x00B1EBB4 File Offset: 0x00B1CDB4
		public float MapScale
		{
			get
			{
				return WorldMapModel.Instance.MapScale;
			}
		}

		// Token: 0x06030024 RID: 196644 RVA: 0x00B1EBC0 File Offset: 0x00B1CDC0
		private void OnPointerUp(ULGUIPointerEventData eventData)
		{
			if (eventData.mouseButtonType == EMouseButtonType.Right)
			{
				return;
			}
			if (this.WorldMapUiEntity.SecondaryUiComponent.ExtraSecondaryUiOpen)
			{
				return;
			}
			FVector localPointInPlane = eventData.GetLocalPointInPlane();
			Vector2D clickedPosition = Vector2D.Create((double)localPointInPlane.X, (double)localPointInPlane.Y);
			if (!Info.Instance.IsBuildShipping)
			{
				global::Vector vector = MapUtil.UiPosition2WorldPosition(global::Vector.Create((double)localPointInPlane.X, (double)localPointInPlane.Y, 0.0), null);
				global::Vector markPosition = MapController.Instance.GetMarkPosition((double)localPointInPlane.X, (double)(-(double)localPointInPlane.Y));
				if (markPosition != null)
				{
					vector.Set(markPosition.X * 100.0, markPosition.Y * 100.0, markPosition.Z * 100.0);
					WorldNavigation.TestFindPath(vector, delegate(bool isSuccess)
					{
						if (isSuccess && UiManager.Instance.IsViewOpen(EUiViewName.WorldMapView))
						{
							UiManager.Instance.CloseViewAsync(EUiViewName.WorldMapView);
						}
					});
				}
			}
			if (this.WorldMapUiEntity.IsInPlayerMap && this.WorldMapUiEntity.PlayerComponent.PlayerOutOfBound)
			{
				Vector2D clickedPosition2 = clickedPosition;
				BaseMap map = this.Map;
				if (this.InClickRange(clickedPosition2, (map != null) ? map.SelfPlayerNode : null, true, null).Item1)
				{
					this.MapFocusPlayer();
					return;
				}
			}
			List<MarkItem> clickedItems = new List<MarkItem>();
			global::Vector clickPosition = global::Vector.Create((double)localPointInPlane.X, (double)localPointInPlane.Y, (double)localPointInPlane.Z);
			int? customClickRange = this.WorldMapUiEntity.WorldMapExtraUiPanelComponent.GetCustomClickRange();
			int cellRadius = 1;
			if (customClickRange != null)
			{
				float num = Math.Max(Math.Max(50f, (float)this.UiParams.MarkMenuRectSize), (float)customClickRange.Value);
				cellRadius = Math.Max(1, (int)Math.Ceiling((double)(num / (this.MapScale * 50f))));
			}
			BaseMap map2 = this.Map;
			List<MarkItem> list = (map2 != null) ? map2.GetMarkItemsByClickPosition(clickPosition, cellRadius) : null;
			List<UniTask<ValueTuple<MarkItem, UUIItem>>> list2 = new List<UniTask<ValueTuple<MarkItem, UUIItem>>>();
			List<UniTask<ValueTuple<MarkItem, UUIItem>>> list3 = new List<UniTask<ValueTuple<MarkItem, UUIItem>>>();
			foreach (MarkItem markItem in list)
			{
				if (markItem.View != null && markItem.GetInteractiveFlag() && !markItem.IsOutOfBound)
				{
					list2.Add(WorldMapView.<OnPointerUp>g__getMarkTupleFunc|101_0(markItem));
				}
			}
			bool singleClickTest = list2.Count <= 1;
			UniTask uniTask = UniTask.WhenAll<ValueTuple<MarkItem, UUIItem>>(list2).ContinueWith(delegate(ValueTuple<MarkItem, UUIItem>[] markTupleItemList)
			{
				foreach (ValueTuple<MarkItem, UUIItem> valueTuple in markTupleItemList)
				{
					if (this.InClickRange(clickedPosition, valueTuple.Item2, singleClickTest, this.WorldMapUiEntity.WorldMapExtraUiPanelComponent.GetCustomClickRange()).Item1)
					{
						clickedItems.Add(valueTuple.Item1);
					}
				}
			});
			BaseMap map3 = this.Map;
			foreach (Dictionary<int, MarkItem> dictionary in ((map3 != null) ? map3.GetAllMarkItems().Values : null))
			{
				foreach (MarkItem markItem2 in dictionary.Values)
				{
					if (markItem2.IsOutOfBound)
					{
						list3.Add(WorldMapView.<OnPointerUp>g__getMarkTupleFunc|101_0(markItem2));
					}
				}
			}
			singleClickTest = (list3.Count <= 1);
			UniTask uniTask2 = UniTask.WhenAll<ValueTuple<MarkItem, UUIItem>>(list3).ContinueWith(delegate(ValueTuple<MarkItem, UUIItem>[] markTupleItemList)
			{
				foreach (ValueTuple<MarkItem, UUIItem> valueTuple in markTupleItemList)
				{
					if (this.InClickRange(clickedPosition, valueTuple.Item2, singleClickTest, this.WorldMapUiEntity.WorldMapExtraUiPanelComponent.GetCustomClickRange()).Item1)
					{
						clickedItems.Add(valueTuple.Item1);
					}
				}
			});
			UniTask.WhenAll(new UniTask[]
			{
				uniTask2,
				uniTask
			}).ContinueWith(delegate()
			{
				List<MarkItem> list4;
				if (!clickedItems.Any((MarkItem item) => item.IsOutOfBound))
				{
					list4 = clickedItems;
				}
				else
				{
					list4 = (from item in clickedItems
					where item.IsOutOfBound
					select item).ToList<MarkItem>();
				}
				List<MarkItem> list5 = list4;
				if (list5.Count == 0)
				{
					this.ClickEmpty(clickedPosition);
					return;
				}
				if (list5.Count == 1)
				{
					this.ClickSingleMark(list5[0], null);
					return;
				}
				if (list5.Count > 1)
				{
					this.ClickMarks(list5, clickedPosition);
				}
			}).Forget();
		}

		// Token: 0x06030025 RID: 196645 RVA: 0x00B1EF58 File Offset: 0x00B1D158
		[NullableContext(0)]
		private ValueTuple<bool, double> InClickRange([Nullable(1)] Vector2D clickedPosition, [Nullable(2)] UUIItem item, bool singleTest, int? customClickRange = null)
		{
			return this.InClickRangeByUiPosition(clickedPosition, Vector2D.Create((item != null) ? new FVector2D?(item.GetAnchorOffset()) : null), singleTest, null, customClickRange);
		}

		// Token: 0x06030026 RID: 196646 RVA: 0x00B1EF9C File Offset: 0x00B1D19C
		[return: Nullable(0)]
		private ValueTuple<bool, double> InClickRangeByUiPosition(Vector2D clickedPosition, Vector2D targetPosition, bool singleTest, bool? isJoystick = null, int? customClickRange = null)
		{
			double num = Vector2D.Distance(clickedPosition, targetPosition);
			double num2 = (double)(singleTest ? customClickRange.GetValueOrDefault(50) : this.UiParams.MarkMenuRectSize);
			if (isJoystick.GetValueOrDefault())
			{
				num2 *= (double)WorldMapModel.Instance.JoystickClickMultiplier;
			}
			return new ValueTuple<bool, double>(num * (double)this.MapScale <= num2, num);
		}

		// Token: 0x06030027 RID: 196647 RVA: 0x00B1EFF8 File Offset: 0x00B1D1F8
		private void ClickEmpty(Vector2D clickedPosition)
		{
			WorldMapUiEntity worldMapUiEntity = this.WorldMapUiEntity;
			if (worldMapUiEntity != null && worldMapUiEntity.MoveComponent.IsTweeningMove)
			{
				this.WorldMapUiEntity.MoveComponent.KillTweening();
			}
			WorldMapUiEntity worldMapUiEntity2 = this.WorldMapUiEntity;
			if (worldMapUiEntity2 != null && worldMapUiEntity2.WorldMapExtraUiPanelComponent.ClickEmpty(clickedPosition))
			{
				return;
			}
			WorldMapModel instance = WorldMapModel.Instance;
			if (instance.CurrentFocalMarkId != null)
			{
				int? currentFocalMarkId = instance.CurrentFocalMarkId;
				int num = 0;
				if (!(currentFocalMarkId.GetValueOrDefault() == num & currentFocalMarkId != null) && instance.CurrentFocalMarkType != null)
				{
					BaseMap map = this.Map;
					if (map != null)
					{
						map.SetMarkUnFocal(instance.CurrentFocalMarkType.Value, instance.CurrentFocalMarkId.Value);
					}
				}
			}
			WorldMapController.Instance.ClearFocalMarkItem();
			if (this.WorldMapUiEntity.SecondaryUiComponent.IsSecondaryUiOpening)
			{
				this.IsCloseThenOpenSecondaryUi = false;
				this.WorldMapUiEntity.UpdateMarkItems(null);
				this.CloseSecondaryUi(null, true);
				return;
			}
			if (MapModel.Instance.GetMarkCountByType(EMarkType.Custom) == instance.CustomMarkSize)
			{
				ScrollingTipsController.Instance.ShowTipsById("WorldMapTagFull", Array.Empty<object>());
				return;
			}
			if (!instance.CustomMarksIsShow || instance.EnableInstanceDungeonFilterMark || instance.IsCustomMarkDisabled || this.ShowMode == EWorldMapShowMode.Base || this.ShowMode == EWorldMapShowMode.Recall)
			{
				return;
			}
			this.WorldMapUiEntity.ClickedItem = this.CreateNewCustomMarkItem(clickedPosition);
			if (this.WorldMapUiEntity.ClickedItem != null)
			{
				this.WorldMapUiEntity.ClickedItem.IsIgnoreScaleShow = true;
				this.WorldMapUiEntity.ClickedItem.IsCanShowView = true;
				this.ShowPanel(this.WorldMapUiEntity.ClickedItem, ECustomMarkPanelMode.Create);
			}
			AudioSystem.Instance.PostEvent("play_ui_ia_spl_map_click_com");
		}

		// Token: 0x06030028 RID: 196648 RVA: 0x00B1F1A4 File Offset: 0x00B1D3A4
		private void RemoveUncommittedCustomMark()
		{
			Dictionary<int, MarkItem> markItemsByType = this.Map.GetMarkItemsByType(EMarkType.Custom, true);
			if (markItemsByType == null)
			{
				return;
			}
			List<int> list = new List<int>();
			foreach (MarkItem markItem in markItemsByType.Values)
			{
				CustomMarkItem customMarkItem = markItem as CustomMarkItem;
				if (customMarkItem != null && customMarkItem.IsNewCustomMarkItem)
				{
					list.Add(markItem.MarkId);
				}
			}
			foreach (int p in list)
			{
				EventSystem.Instance.Emit<EMarkType, int>(EEventName.RemoveMapMark, EMarkType.Custom, p);
			}
		}

		// Token: 0x06030029 RID: 196649 RVA: 0x00B1F278 File Offset: 0x00B1D478
		private unsafe CustomMarkItem CreateNewCustomMarkItem(Vector2D position)
		{
			double x = position.X;
			double y = position.Y;
			OneOf<global::Vector, Vector2D>? newCustomMarkPosition = MapController.Instance.GetNewCustomMarkPosition(x, -y);
			DynamicMarkCreateInfo dynamicMarkCreateInfo = new DynamicMarkCreateInfo(new DynamicMarkCreateParams
			{
				MarkId = new int?(1),
				TrackTarget = (newCustomMarkPosition.Value.IsT1 ? newCustomMarkPosition.Value.AsT1 : newCustomMarkPosition.Value.AsT2),
				MarkConfigId = 1,
				MarkType = EMarkType.Custom,
				MapAndDungeonInfo = new MapAndDungeonInfo
				{
					MapConfigId = new int?(this.OpenParamMapId)
				}
			});
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Map;
			ELogAuthor author = ELogAuthor.LYX;
			string message = "[CustomMarkItem Debug]WorldMapView.CreateNewCustomMarkItem->";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("position", position);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("info", dynamicMarkCreateInfo);
			instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
			BaseMap map = this.Map;
			CustomMarkItem customMarkItem = (map != null) ? map.CreateCustomMark(dynamicMarkCreateInfo) : null;
			if (customMarkItem == null)
			{
				return customMarkItem;
			}
			customMarkItem.SetIsNew(true);
			return customMarkItem;
		}

		// Token: 0x0603002A RID: 196650 RVA: 0x00B1F39C File Offset: 0x00B1D59C
		private void OnMarkMenuClickItem(MarkItem clickedItem)
		{
			this.ClickSingleMark(clickedItem, null);
		}

		// Token: 0x0603002B RID: 196651 RVA: 0x00B1F3B9 File Offset: 0x00B1D5B9
		private void ClickSingleMark(MarkItem clickedItem, bool? forceShow = null)
		{
			this.WorldMapUiEntity.QuickNavigateComponent.NavigateTo(clickedItem.MarkId, clickedItem.MarkType, true, true, false);
		}

		// Token: 0x0603002C RID: 196652 RVA: 0x00B1F3DC File Offset: 0x00B1D5DC
		private void ClickSingleMarkImp(MarkItem clickedItem, bool? forceShow = null)
		{
			if (this.WorldMapUiEntity.ClickedItem != null && this.WorldMapUiEntity.ClickedItem.MarkId == clickedItem.MarkId)
			{
				return;
			}
			WorldMapModel instance = WorldMapModel.Instance;
			int? currentFocalMarkId = instance.CurrentFocalMarkId;
			int num = 0;
			if (!(currentFocalMarkId.GetValueOrDefault() == num & currentFocalMarkId != null) && instance.CurrentFocalMarkType != null)
			{
				BaseMap map = this.Map;
				if (map != null)
				{
					map.SetMarkUnFocal(instance.CurrentFocalMarkType.Value, instance.CurrentFocalMarkId.Value);
				}
			}
			BaseMap map2 = this.Map;
			if (map2 != null)
			{
				map2.SetMarkFocal(clickedItem.MarkType, clickedItem.MarkId);
			}
			instance.CurrentFocalMarkType = new EMarkType?(clickedItem.MarkType);
			instance.CurrentFocalMarkId = new int?(clickedItem.MarkId);
			bool enableDebug = instance.EnableDebug;
			WorldMapUiEntity worldMapUiEntity = this.WorldMapUiEntity;
			if (worldMapUiEntity != null && worldMapUiEntity.WorldMapExtraUiPanelComponent.ClickSingleMark(clickedItem))
			{
				return;
			}
			bool playSequence = true;
			if (this.WorldMapUiEntity.SecondaryUiComponent.IsInternalSecondaryUiOpen())
			{
				if (!clickedItem.IsOutOfBound || forceShow.GetValueOrDefault())
				{
					this.IsCloseThenOpenSecondaryUi = true;
				}
				else
				{
					this.IsCloseThenOpenSecondaryUi = false;
				}
				playSequence = false;
			}
			Action<UUIItem> <>9__1;
			this.CloseSecondaryUi(delegate
			{
				if (clickedItem.IsOutOfBound)
				{
					this.WorldMapUiEntity.MoveComponent.SetMapPosition(clickedItem, true, EClampType.ClampToSafeArea, null, null, true, true);
					if (!forceShow.GetValueOrDefault())
					{
						return;
					}
				}
				if (this.SequenceMarkItem != null && !this.SequenceMarkItem.IsDestroy)
				{
					UniTask<UUIItem> rootItemAsync = this.SequenceMarkItem.GetRootItemAsync();
					Action<UUIItem> continuationFunction;
					if ((continuationFunction = <>9__1) == null)
					{
						continuationFunction = (<>9__1 = delegate(UUIItem rootItem)
						{
							if (rootItem != null)
							{
								this.GetItemLevelSequenceItem(rootItem).StopSequenceByKey("Dianji", false, false);
							}
						});
					}
					rootItemAsync.ContinueWith(continuationFunction);
				}
				this.SequenceMarkItem = clickedItem;
				this.WorldMapUiEntity.ClickedItem = clickedItem;
				MarkItem clickedItem2 = this.WorldMapUiEntity.ClickedItem;
				if (clickedItem2 != null)
				{
					clickedItem2.SetSelected(true);
				}
				this.WorldMapUiEntity.UpdateSingleMarkItem(clickedItem, true);
				WorldMapUiEntity worldMapUiEntity2 = this.WorldMapUiEntity;
				if (((worldMapUiEntity2 != null) ? worldMapUiEntity2.ClickedItem : null) != null && this.WorldMapUiEntity.ClickedItem.IsMultiMap())
				{
					int multiMapId = this.WorldMapUiEntity.ClickedItem.GetMultiMapId();
					MultiMap? subMapConfigById = MapConfig.Instance.GetSubMapConfigById(multiMapId);
					if (subMapConfigById != null)
					{
						int areaId = (subMapConfigById.Value.AreaLength > 0 && this.WorldMapUiEntity.Map != null) ? subMapConfigById.Value.Area(0) : this.WorldMapUiEntity.Map.GetWorldMapCenterAreaId();
						int groupId = subMapConfigById.Value.GroupId;
						int floor = subMapConfigById.Value.Floor;
						this.WorldMapUiEntity.MultiFloorComponent.SelectMultiMapFloor(areaId, new int?(groupId), new int?(floor), true);
					}
				}
				else
				{
					this.WorldMapUiEntity.MultiFloorComponent.DeSelectMultiMapFloor(true);
				}
				this.ShowPanel(clickedItem, ECustomMarkPanelMode.Modify);
			}, playSequence);
		}

		// Token: 0x0603002D RID: 196653 RVA: 0x00B1F558 File Offset: 0x00B1D758
		private LevelSequencePlayer GetItemLevelSequenceItem(UUIItem item)
		{
			LevelSequencePlayer levelSequencePlayer;
			this.ClickItemLevelSequenceMap.TryGetValue(item, out levelSequencePlayer);
			LevelSequencePlayer levelSequencePlayer2 = levelSequencePlayer;
			if (levelSequencePlayer2 == null)
			{
				levelSequencePlayer2 = new LevelSequencePlayer(item);
				this.ClickItemLevelSequenceMap[item] = levelSequencePlayer2;
			}
			return levelSequencePlayer2;
		}

		// Token: 0x0603002E RID: 196654 RVA: 0x00B1F590 File Offset: 0x00B1D790
		private UniTask OnCloseSecondaryUiByClickOtherMarkCall(List<MarkItem> clickedItems, Vector2D clickedPosition)
		{
			WorldMapView.<OnCloseSecondaryUiByClickOtherMarkCall>d__111 <OnCloseSecondaryUiByClickOtherMarkCall>d__;
			<OnCloseSecondaryUiByClickOtherMarkCall>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnCloseSecondaryUiByClickOtherMarkCall>d__.<>4__this = this;
			<OnCloseSecondaryUiByClickOtherMarkCall>d__.clickedItems = clickedItems;
			<OnCloseSecondaryUiByClickOtherMarkCall>d__.clickedPosition = clickedPosition;
			<OnCloseSecondaryUiByClickOtherMarkCall>d__.<>1__state = -1;
			<OnCloseSecondaryUiByClickOtherMarkCall>d__.<>t__builder.Start<WorldMapView.<OnCloseSecondaryUiByClickOtherMarkCall>d__111>(ref <OnCloseSecondaryUiByClickOtherMarkCall>d__);
			return <OnCloseSecondaryUiByClickOtherMarkCall>d__.<>t__builder.Task;
		}

		// Token: 0x0603002F RID: 196655 RVA: 0x00B1F5E4 File Offset: 0x00B1D7E4
		private void ClickMarks(List<MarkItem> clickedItems, Vector2D clickedPosition)
		{
			if (this.WorldMapUiEntity.WorldMapExtraUiPanelComponent.ClickMarks(clickedItems, clickedPosition))
			{
				return;
			}
			if (this.WorldMapUiEntity.SecondaryUiComponent.IsSecondaryUiOpening)
			{
				this.IsCloseThenOpenSecondaryUi = true;
			}
			this.CloseSecondaryUi(delegate
			{
				this.OnCloseSecondaryUiByClickOtherMarkCall(clickedItems, clickedPosition);
				AudioSystem.Instance.PostEvent("play_ui_ia_spl_map_click_com");
			}, true);
			int? currentFocalMarkId = WorldMapModel.Instance.CurrentFocalMarkId;
			int num = 0;
			if (!(currentFocalMarkId.GetValueOrDefault() == num & currentFocalMarkId != null) && WorldMapModel.Instance.CurrentFocalMarkType != null)
			{
				BaseMap map = this.Map;
				if (map != null)
				{
					map.SetMarkUnFocal(WorldMapModel.Instance.CurrentFocalMarkType.Value, WorldMapModel.Instance.CurrentFocalMarkId.Value);
				}
			}
			WorldMapController.Instance.ClearFocalMarkItem();
		}

		// Token: 0x06030030 RID: 196656 RVA: 0x00B1F6C4 File Offset: 0x00B1D8C4
		private void OnCreateMarkItem(DynamicMarkCreateInfo info)
		{
			BaseMap map = this.Map;
			MarkItem markItem = (map != null) ? map.GetMarkItem(info.MarkType, info.MarkId.Value) : null;
			if (markItem != null && markItem.MarkType == EMarkType.Custom)
			{
				markItem.IsIgnoreScaleShow = true;
			}
		}

		// Token: 0x06030031 RID: 196657 RVA: 0x00B1F70C File Offset: 0x00B1D90C
		private void OnAddMarkItem(MarkItem markItem)
		{
			if (!markItem.IsInConsistentDistrict(false))
			{
				WorldMapUiEntity worldMapUiEntity = this.WorldMapUiEntity;
				if (worldMapUiEntity == null)
				{
					return;
				}
				worldMapUiEntity.UpdateSingleMarkItem(markItem, false);
			}
		}

		// Token: 0x06030032 RID: 196658 RVA: 0x00B1F72C File Offset: 0x00B1D92C
		private void OnRemoveMarkItem(EMarkType markType, int markId)
		{
			BaseMap map = this.Map;
			MarkItem markItem = (map != null) ? map.GetMarkItem(markType, markId) : null;
			if (markItem != null)
			{
				WorldMapUiEntity worldMapUiEntity = this.WorldMapUiEntity;
				if (worldMapUiEntity != null)
				{
					worldMapUiEntity.UpdateSingleMarkItem(markItem, true);
				}
			}
			WorldMapUiEntity worldMapUiEntity2 = this.WorldMapUiEntity;
			bool flag;
			if (worldMapUiEntity2 == null)
			{
				flag = false;
			}
			else
			{
				MarkItem clickedItem = worldMapUiEntity2.ClickedItem;
				EMarkType? emarkType = (clickedItem != null) ? new EMarkType?(clickedItem.MarkType) : null;
				flag = (emarkType.GetValueOrDefault() == markType & emarkType != null);
			}
			if (flag)
			{
				MarkItem clickedItem2 = this.WorldMapUiEntity.ClickedItem;
				if (clickedItem2 != null && clickedItem2.MarkId == markId)
				{
					this.WorldMapUiEntity.ClickedItem.IsIgnoreScaleShow = false;
					this.WorldMapUiEntity.ClickedItem = null;
				}
			}
		}

		// Token: 0x06030033 RID: 196659 RVA: 0x00B1F7DF File Offset: 0x00B1D9DF
		private void OnWorldMapTrackMarkItem(EMarkType markType, int markId)
		{
			WorldMapUiEntity worldMapUiEntity = this.WorldMapUiEntity;
			if (worldMapUiEntity == null)
			{
				return;
			}
			worldMapUiEntity.QuickNavigateComponent.NavigateTo(markId, markType, true, true, false);
		}

		// Token: 0x06030034 RID: 196660 RVA: 0x00B1F7FC File Offset: 0x00B1D9FC
		private unsafe void OnNavigateFocalMarkItem(int markId, EMarkType markType, bool focal, bool focusTween, bool? needTempShow = null)
		{
			if (needTempShow.GetValueOrDefault())
			{
				BaseMap map = this.Map;
				if (((map != null) ? map.GetMarkItem(markType, markId) : null) == null)
				{
					MapModel.Instance.CreateTempMapMark(markId);
				}
			}
			BaseMap map2 = this.Map;
			MarkItem markItem = (map2 != null) ? map2.GetMarkItem(markType, markId) : null;
			if (markItem == null)
			{
				ELogAuthor author = ELogAuthor.LYX;
				string message = "聚焦了不存在的标记";
				<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("地图标记类型:", markType);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("地图标记Id", markId);
				MapLogger.Warn(author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
				return;
			}
			WorldMapModel instance = WorldMapModel.Instance;
			int worldMapAreaId = markItem.GetWorldMapAreaId();
			EWorldMapScaleTier? areaScaleTier = WorldMapModel.GetAreaScaleTier(worldMapAreaId);
			bool flag = instance.CurrentWorldMapConfigId == 912 && areaScaleTier.GetValueOrDefault() == EWorldMapScaleTier.Other && !instance.IsAreaInDisplay(instance.CurrentWorldMapConfigId, worldMapAreaId);
			if (areaScaleTier != null)
			{
				EWorldMapScaleTier? eworldMapScaleTier = areaScaleTier;
				EWorldMapScaleTier scaleTier = instance.ScaleTier;
				if (!(eworldMapScaleTier.GetValueOrDefault() == scaleTier & eworldMapScaleTier != null) || flag)
				{
					this.NavigateAcrossTierAsync(areaScaleTier.Value, worldMapAreaId, markItem, markId, focal);
					return;
				}
			}
			WorldMapUiEntity worldMapUiEntity = this.WorldMapUiEntity;
			if (worldMapUiEntity != null)
			{
				worldMapUiEntity.MoveComponent.PushMap(markItem, focusTween, EClampType.ClampToDangerousArea);
			}
			if (!focal)
			{
				return;
			}
			if (markItem.MarkType != EMarkType.AreaMark)
			{
				this.FocalMarkItem(markItem.MarkType, markId);
			}
		}

		// Token: 0x06030035 RID: 196661 RVA: 0x00B1F958 File Offset: 0x00B1DB58
		private UniTask NavigateAcrossTierAsync(EWorldMapScaleTier tier, int areaId, MarkItem markItem, int markId, bool focal)
		{
			WorldMapView.<NavigateAcrossTierAsync>d__118 <NavigateAcrossTierAsync>d__;
			<NavigateAcrossTierAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<NavigateAcrossTierAsync>d__.<>4__this = this;
			<NavigateAcrossTierAsync>d__.tier = tier;
			<NavigateAcrossTierAsync>d__.areaId = areaId;
			<NavigateAcrossTierAsync>d__.markItem = markItem;
			<NavigateAcrossTierAsync>d__.markId = markId;
			<NavigateAcrossTierAsync>d__.focal = focal;
			<NavigateAcrossTierAsync>d__.<>1__state = -1;
			<NavigateAcrossTierAsync>d__.<>t__builder.Start<WorldMapView.<NavigateAcrossTierAsync>d__118>(ref <NavigateAcrossTierAsync>d__);
			return <NavigateAcrossTierAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06030036 RID: 196662 RVA: 0x00B1F9C5 File Offset: 0x00B1DBC5
		private void OnChangeWorldMap(WorldMapChangeMapParams changeMapParams)
		{
			this.ChangeMapAsyncAfterFocalMark(changeMapParams);
		}

		// Token: 0x06030037 RID: 196663 RVA: 0x00B1F9D0 File Offset: 0x00B1DBD0
		private void EventToggleShowCustomMark(bool isShow)
		{
			WorldMapUiEntity worldMapUiEntity = this.WorldMapUiEntity;
			if (worldMapUiEntity == null)
			{
				return;
			}
			worldMapUiEntity.UpdateMarkItems(null);
		}

		// Token: 0x06030038 RID: 196664 RVA: 0x00B1F9F8 File Offset: 0x00B1DBF8
		private void EventToggleShowCompletedPlayMark(bool isShow)
		{
			WorldMapUiEntity worldMapUiEntity = this.WorldMapUiEntity;
			if (worldMapUiEntity == null)
			{
				return;
			}
			worldMapUiEntity.UpdateMarkItems(null);
		}

		// Token: 0x06030039 RID: 196665 RVA: 0x00B1FA20 File Offset: 0x00B1DC20
		private void EventNavigateMarkAndShowRange(NavigateMarkShowRange navigate)
		{
			WorldMapUiEntity worldMapUiEntity = this.WorldMapUiEntity;
			WorldMapChangeMapDiffParams worldMapChangeMapDiffParams = (worldMapUiEntity != null) ? worldMapUiEntity.QuickNavigateComponent.GetNavigateMarkIsNeedChangeMap(navigate.MarkId, navigate.MarkType) : null;
			if (worldMapChangeMapDiffParams != null && (worldMapChangeMapDiffParams.MapId != null || worldMapChangeMapDiffParams.Gravity != null))
			{
				this.ChangeMapAsyncAfterFocalMarkAndShowRange(worldMapChangeMapDiffParams.MapId.Value, navigate, new EMapGravityDirection?(worldMapChangeMapDiffParams.Gravity.GetValueOrDefault(EMapGravityDirection.Down)));
				return;
			}
			this.OnNavigateFocalMarkItem(navigate.MarkId, navigate.MarkType, false, navigate.FocusTween.GetValueOrDefault(true), null);
			this.ShowRangeByMarkItem(navigate);
		}

		// Token: 0x0603003A RID: 196666 RVA: 0x00B1FAC4 File Offset: 0x00B1DCC4
		private void EventOpenExploreAreaDetailViewFromMap(int areaId, EExploreType? exploreType = null)
		{
			if (UiManager.Instance.IsViewShow(EUiViewName.MapExploreDetailView))
			{
				return;
			}
			if (UiManager.Instance.IsViewOpen(EUiViewName.MapExploreDetailView))
			{
				UiManager.Instance.CloseViewAsync(EUiViewName.MapExploreDetailView).ContinueWith(delegate(bool _)
				{
					this.OpenMapExploreAreaDetailView(areaId, exploreType);
				});
				return;
			}
			this.OpenMapExploreAreaDetailView(areaId, exploreType);
		}

		// Token: 0x0603003B RID: 196667 RVA: 0x00B1FB43 File Offset: 0x00B1DD43
		private void OnWorldMapActivityListDataUpdate()
		{
			this.WorldMapPeriodicActivityItem.Refresh(this.InEightMap());
		}

		// Token: 0x0603003C RID: 196668 RVA: 0x00B1FB58 File Offset: 0x00B1DD58
		public void OpenMapExploreAreaDetailView(int areaId, EExploreType? exploreType = null)
		{
			UiManager instance = UiManager.Instance;
			EUiViewName mapExploreDetailView = EUiViewName.MapExploreDetailView;
			MapExploreDetailViewParams mapExploreDetailViewParams = new MapExploreDetailViewParams();
			mapExploreDetailViewParams.AreaId = areaId;
			mapExploreDetailViewParams.ExploreType = exploreType;
			instance.OpenView(mapExploreDetailView, mapExploreDetailViewParams, delegate(bool success, int viewId)
			{
				if (!success)
				{
					return;
				}
				UiModel.Instance.NormalStack.Peek().AddChildViewById(viewId);
			});
		}

		// Token: 0x0603003D RID: 196669 RVA: 0x00B1FBA8 File Offset: 0x00B1DDA8
		private UniTask ChangeMapAsyncAfterFocalMarkAndShowRange(int mapId, NavigateMarkShowRange navigate, EMapGravityDirection? gravity = null)
		{
			WorldMapView.<ChangeMapAsyncAfterFocalMarkAndShowRange>d__126 <ChangeMapAsyncAfterFocalMarkAndShowRange>d__;
			<ChangeMapAsyncAfterFocalMarkAndShowRange>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<ChangeMapAsyncAfterFocalMarkAndShowRange>d__.<>4__this = this;
			<ChangeMapAsyncAfterFocalMarkAndShowRange>d__.mapId = mapId;
			<ChangeMapAsyncAfterFocalMarkAndShowRange>d__.navigate = navigate;
			<ChangeMapAsyncAfterFocalMarkAndShowRange>d__.gravity = gravity;
			<ChangeMapAsyncAfterFocalMarkAndShowRange>d__.<>1__state = -1;
			<ChangeMapAsyncAfterFocalMarkAndShowRange>d__.<>t__builder.Start<WorldMapView.<ChangeMapAsyncAfterFocalMarkAndShowRange>d__126>(ref <ChangeMapAsyncAfterFocalMarkAndShowRange>d__);
			return <ChangeMapAsyncAfterFocalMarkAndShowRange>d__.<>t__builder.Task;
		}

		// Token: 0x0603003E RID: 196670 RVA: 0x00B1FC04 File Offset: 0x00B1DE04
		private UniTask ShowRangeByMarkItem(NavigateMarkShowRange navigate)
		{
			WorldMapView.<ShowRangeByMarkItem>d__127 <ShowRangeByMarkItem>d__;
			<ShowRangeByMarkItem>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<ShowRangeByMarkItem>d__.<>4__this = this;
			<ShowRangeByMarkItem>d__.navigate = navigate;
			<ShowRangeByMarkItem>d__.<>1__state = -1;
			<ShowRangeByMarkItem>d__.<>t__builder.Start<WorldMapView.<ShowRangeByMarkItem>d__127>(ref <ShowRangeByMarkItem>d__);
			return <ShowRangeByMarkItem>d__.<>t__builder.Task;
		}

		// Token: 0x0603003F RID: 196671 RVA: 0x00B1FC50 File Offset: 0x00B1DE50
		private unsafe void FocalMarkItem(EMarkType markType, int markId)
		{
			BaseMap map = this.Map;
			MarkItem markItem = (map != null) ? map.GetMarkItem(markType, markId) : null;
			if (markItem == null)
			{
				ELogAuthor author = ELogAuthor.LYX;
				string message = "申请了不存在的地图标记";
				<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("地图标记类型:", markType);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("地图标记Id", markId);
				MapLogger.Error(author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
				return;
			}
			if (markItem.GetIsStrictConfigMark())
			{
				ConfigMarkItem configMarkItem = markItem as ConfigMarkItem;
				if (!configMarkItem.IsFogUnlock)
				{
					int fogHide = configMarkItem.MarkConfig.Value.FogHide;
					MapFog? mapFogConfig = WorldMapConfig.Instance.GetMapFogConfig(fogHide);
					this.ShowUnlockCondition((mapFogConfig != null) ? mapFogConfig.GetValueOrDefault().UnlockCondition : 0);
					return;
				}
				if (!configMarkItem.IsConditionShouldShow && !markItem.MarkItemEntity.IsTempMapMark)
				{
					if (configMarkItem.MarkType != EMarkType.CommonGamePlay && configMarkItem.MarkType != EMarkType.LevelPlayReport)
					{
						this.ShowUnlockCondition(configMarkItem.MarkConfig.Value.ShowCondition);
						return;
					}
					if (!configMarkItem.IsConditionShouldShowWithoutServerState && !markItem.MarkItemEntity.IsTempMapMark)
					{
						this.ShowUnlockCondition(configMarkItem.MarkConfig.Value.ShowCondition);
						return;
					}
				}
			}
			markItem.IsCanShowView = true;
			markItem.IsIgnoreScaleShow = true;
			if (markItem.GetInteractiveFlag())
			{
				this.ClickSingleMarkImp(markItem, new bool?(true));
			}
		}

		// Token: 0x06030040 RID: 196672 RVA: 0x00B1FDC4 File Offset: 0x00B1DFC4
		private void ShowUnlockCondition(int conditionId)
		{
			if (conditionId <= 0)
			{
				GenericPromptController.Instance.ShowPromptByCode("MapAreaIsLock", Array.Empty<object>());
				return;
			}
			ConditionGroup? conditionGroup = WorldMapConfig.Instance.GetConditionGroup(conditionId);
			string text = (conditionGroup != null) ? conditionGroup.GetValueOrDefault().HintText : null;
			if (text != null && !StringUtils.IsEmpty(text))
			{
				string localText = MapConfig.Instance.GetLocalText(text);
				GenericPromptController.Instance.ShowPromptByCode("UnlockCondition", new object[]
				{
					localText
				});
				return;
			}
			GenericPromptController.Instance.ShowPromptByCode("MapAreaIsLock", Array.Empty<object>());
		}

		// Token: 0x06030041 RID: 196673 RVA: 0x00B1FE57 File Offset: 0x00B1E057
		private void OnZoomOut(float _)
		{
			AudioSystem.Instance.PostEvent("play_ui_com_slider_tick");
			this.IncreaseMapScale(0.1f, EMapScaleSetType.ZoomButton);
		}

		// Token: 0x06030042 RID: 196674 RVA: 0x00B1FE75 File Offset: 0x00B1E075
		private void OnZoomIn(float _)
		{
			AudioSystem.Instance.PostEvent("play_ui_com_slider_tick");
			this.IncreaseMapScale(-0.1f, EMapScaleSetType.ZoomButton);
		}

		// Token: 0x06030043 RID: 196675 RVA: 0x00B1FE93 File Offset: 0x00B1E093
		private void OnCloseBtnClick()
		{
			UiManager.Instance.ResetToBattleView(null);
		}

		// Token: 0x06030044 RID: 196676 RVA: 0x00B1FEA0 File Offset: 0x00B1E0A0
		private void OnBoxSwitchBtnClick()
		{
			WorldMapModel instance = WorldMapModel.Instance;
			if (!instance.HasOutBoxTier)
			{
				return;
			}
			if (this.WorldMapUiEntity.SecondaryUiComponent.IsSecondaryUiOpening || !this.WorldMapUiEntity.WorldMapExtraUiPanelComponent.IsEnableMapScale)
			{
				return;
			}
			EWorldMapScaleTier tier = (instance.ScaleTier == EWorldMapScaleTier.Box) ? EWorldMapScaleTier.OutBox : EWorldMapScaleTier.Box;
			this.WorldMapUiEntity.ScaleComponent.SetScaleTier(tier, EMapScaleSetType.Other);
		}

		// Token: 0x06030045 RID: 196677 RVA: 0x00B1FF00 File Offset: 0x00B1E100
		private void IncreaseMapScale(float delta, EMapScaleSetType type)
		{
			if (this.WorldMapUiEntity.IsBoxTransitioning)
			{
				return;
			}
			if (type == EMapScaleSetType.Gamepad && this.WorldMapUiEntity.InteractComponent.IsJoystickZoom)
			{
				this.WorldMapUiEntity.MoveComponent.KillTweening();
			}
			if (!this.WorldMapUiEntity.SecondaryUiComponent.IsSecondaryUiOpening && this.WorldMapUiEntity.WorldMapExtraUiPanelComponent.IsEnableMapScale)
			{
				this.WorldMapUiEntity.ScaleComponent.AddMapScale(delta, type);
			}
		}

		// Token: 0x06030046 RID: 196678 RVA: 0x00B1FF77 File Offset: 0x00B1E177
		private void InputControllerChange(EInputControllerType eInputControllerType, EInputControllerType inputControllerType)
		{
			this.CursorButton.SetCursorActive(!this.WorldMapUiEntity.SecondaryUiComponent.IsSecondaryUiOpening && this.WorldMapUiEntity.WorldMapExtraUiPanelComponent.IsEnableMapCursorButton);
		}

		// Token: 0x06030047 RID: 196679 RVA: 0x00B1FFAC File Offset: 0x00B1E1AC
		private void OnJoystickCheck()
		{
			if (Info.Instance.IsInGamepad())
			{
				if (this.ClickedItems.Count == 0)
				{
					this.ClickEmpty(this.ClickedPosition);
					return;
				}
				if (this.ClickedItems.Count == 1)
				{
					this.ClickSingleMark(this.ClickedItems[0], null);
					return;
				}
				if (this.ClickedItems.Count > 1)
				{
					this.ClickMarks(this.ClickedItems, this.ClickedPosition);
				}
			}
		}

		// Token: 0x06030048 RID: 196680 RVA: 0x00B20029 File Offset: 0x00B1E229
		private void OnWorldMapFocusPlayer()
		{
			WorldMapUiEntity worldMapUiEntity = this.WorldMapUiEntity;
			if (worldMapUiEntity != null && worldMapUiEntity.IsInPlayerMap)
			{
				WorldMapUiEntity worldMapUiEntity2 = this.WorldMapUiEntity;
				if (worldMapUiEntity2 != null && worldMapUiEntity2.IsInPlayerGravity)
				{
					this.MapFocusPlayer();
					return;
				}
			}
			this.ChangeMapAfterFocusPlayer();
		}

		// Token: 0x06030049 RID: 196681 RVA: 0x00B20064 File Offset: 0x00B1E264
		private void MapFocusPlayer()
		{
			this.ResetFocusInteract();
			int currentAreaId = AreaModel.Instance.GetCurrentAreaId(null);
			WorldMapUiEntity worldMapUiEntity = this.WorldMapUiEntity;
			if (worldMapUiEntity != null && WorldMapModel.IsBoxMapId(worldMapUiEntity.MapId) && !WorldMapModel.Instance.IsAreaInDisplay(worldMapUiEntity.MapId, currentAreaId))
			{
				this.FocusPlayerAcrossTierAsync(currentAreaId);
				return;
			}
			this.FocusPlayerInCurrentTier(currentAreaId);
		}

		// Token: 0x0603004A RID: 196682 RVA: 0x00B200C8 File Offset: 0x00B1E2C8
		private UniTask FocusPlayerAcrossTierAsync(int areaId)
		{
			WorldMapView.<FocusPlayerAcrossTierAsync>d__139 <FocusPlayerAcrossTierAsync>d__;
			<FocusPlayerAcrossTierAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<FocusPlayerAcrossTierAsync>d__.<>4__this = this;
			<FocusPlayerAcrossTierAsync>d__.areaId = areaId;
			<FocusPlayerAcrossTierAsync>d__.<>1__state = -1;
			<FocusPlayerAcrossTierAsync>d__.<>t__builder.Start<WorldMapView.<FocusPlayerAcrossTierAsync>d__139>(ref <FocusPlayerAcrossTierAsync>d__);
			return <FocusPlayerAcrossTierAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603004B RID: 196683 RVA: 0x00B20114 File Offset: 0x00B1E314
		private void FocusPlayerInCurrentTier(int areaId)
		{
			MultiMap? subMapConfigByAreaId = MapConfig.Instance.GetSubMapConfigByAreaId(areaId);
			if (subMapConfigByAreaId != null)
			{
				int groupId = subMapConfigByAreaId.Value.GroupId;
				int floor = subMapConfigByAreaId.Value.Floor;
				this.WorldMapUiEntity.MultiFloorComponent.SelectMultiMapFloor(areaId, new int?(groupId), new int?(floor), true);
			}
			WorldMapUiEntity worldMapUiEntity = this.WorldMapUiEntity;
			if (worldMapUiEntity == null)
			{
				return;
			}
			worldMapUiEntity.MoveComponent.FocusPlayer(this.WorldMapUiEntity.PlayerComponent.PlayerUiPosition, true, EClampType.ClampToSafeArea);
		}

		// Token: 0x0603004C RID: 196684 RVA: 0x00B2019C File Offset: 0x00B1E39C
		private void OnWorldMapShowTrackList()
		{
			List<ITrackMenuItemData> dataList = this.GetAllTrackMenuItemData();
			if (dataList.Count <= 0)
			{
				ScrollingTipsController.Instance.ShowTipsByTextId("Tracking_List_Empty_Text", Array.Empty<object>());
				return;
			}
			if (this.WorldMapUiEntity.SecondaryUiComponent.IsSecondaryUiOpening)
			{
				this.IsCloseThenOpenSecondaryUi = true;
			}
			this.CloseSecondaryUi(delegate
			{
				WorldMapUiEntity worldMapUiEntity = this.WorldMapUiEntity;
				if (worldMapUiEntity == null)
				{
					return;
				}
				worldMapUiEntity.SecondaryUiComponent.ShowTrackMenu(this.GetItem(25), dataList);
			}, true);
		}

		// Token: 0x0603004D RID: 196685 RVA: 0x00B20214 File Offset: 0x00B1E414
		private List<ITrackMenuItemData> GetAllTrackMenuItemData()
		{
			BaseMap map = this.Map;
			List<MarkItem> list = (map != null) ? map.GetTrackMenuMarkList() : null;
			List<ITrackMenuItemData> list2 = new List<ITrackMenuItemData>();
			WorldMapUiEntity worldMapUiEntity = this.WorldMapUiEntity;
			if (worldMapUiEntity != null && worldMapUiEntity.IsInPlayerMap)
			{
				list2.Add(new TrackMenuItemData
				{
					IsPlayerSelf = true,
					Icon = UiResourceConfig.Instance.GetResourcePath("SP_WorldMapPlayer1"),
					Title = FunctionModel.Instance.GetPlayerName()
				});
			}
			foreach (MarkItem markItem in list)
			{
				list2.Add(new TrackMenuItemData
				{
					Icon = markItem.IconPath,
					StateIcon = markItem.GetStateIconPath(),
					MarkItem = markItem
				});
			}
			return list2;
		}

		// Token: 0x0603004E RID: 196686 RVA: 0x00B202E8 File Offset: 0x00B1E4E8
		private void OnTrackMenuClickItem(ITrackMenuItemData data)
		{
			this.CloseSecondaryUi(delegate
			{
				this.ResetFocusInteract();
				if (data.IsPlayerSelf)
				{
					this.MapFocusPlayer();
					return;
				}
				if (data.MarkItem != null)
				{
					WorldMapUiEntity worldMapUiEntity = this.WorldMapUiEntity;
					if (worldMapUiEntity == null)
					{
						return;
					}
					worldMapUiEntity.QuickNavigateComponent.NavigateTo(data.MarkItem.MarkId, data.MarkItem.MarkType, false, true, false);
				}
			}, true);
		}

		// Token: 0x0603004F RID: 196687 RVA: 0x00B2031C File Offset: 0x00B1E51C
		private void UpdateAreaProgress()
		{
			this.ExploreInfoItem.UpdateAreaProgress();
		}

		// Token: 0x06030050 RID: 196688 RVA: 0x00B2032C File Offset: 0x00B1E52C
		[return: Nullable(new byte[]
		{
			2,
			1
		})]
		public override UUIItem[] GetGuideUiItemAndUiItemForShowEx(string[] configParams)
		{
			WorldMapView.<>c__DisplayClass145_0 CS$<>8__locals1 = new WorldMapView.<>c__DisplayClass145_0();
			CS$<>8__locals1.<>4__this = this;
			if (configParams[0] == "BarItem")
			{
				RegionalTerminalBarItem regionalTerminalBar = this.RegionalTerminalBar;
				if (regionalTerminalBar == null)
				{
					return null;
				}
				return regionalTerminalBar.GetGuideUiItemAndUiItemForShowEx(configParams);
			}
			else
			{
				UUIItem uuiitem;
				if (configParams[0] == "PanelIndex")
				{
					int panelIndex = int.Parse(configParams[1]);
					WorldMapUiEntity worldMapUiEntity = this.WorldMapUiEntity;
					uuiitem = ((worldMapUiEntity != null) ? worldMapUiEntity.SecondaryUiComponent.GetSecondaryPanelGuideFocusUiItem((ESecondaryPanel)panelIndex) : null);
				}
				else
				{
					int num = int.Parse(configParams[0]);
					MapMark? mapMark;
					int? num2 = (MapConfig.Instance.GetConfigMark(num) != null) ? new int?(mapMark.GetValueOrDefault().ObjectType) : null;
					if (num2 == null)
					{
						Log instance = Log.Instance;
						ELogModule module = ELogModule.Guide;
						ELogAuthor author = ELogAuthor.TL;
						string message = "聚焦引导的额外参数配置有误, 找不到地图标记";
						ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("markId", num);
						instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
						return null;
					}
					WorldMapView.<>c__DisplayClass145_0 CS$<>8__locals2 = CS$<>8__locals1;
					BaseMap map = this.Map;
					CS$<>8__locals2.markItem = ((map != null) ? map.GetMarkItem((EMarkType)num2.Value, num) : null);
					WorldMapUiEntity worldMapUiEntity2 = this.WorldMapUiEntity;
					if (worldMapUiEntity2 != null)
					{
						worldMapUiEntity2.MoveComponent.SetMapPosition(CS$<>8__locals1.markItem, true, EClampType.ClampToSafeArea, null, null, true, true);
					}
					MarkItem markItem = CS$<>8__locals1.markItem;
					UUIItem uuiitem2;
					if (markItem == null)
					{
						uuiitem2 = null;
					}
					else
					{
						MarkItemView view = markItem.View;
						uuiitem2 = ((view != null) ? view.GetIconItem() : null);
					}
					uuiitem = uuiitem2;
					if (uuiitem == null)
					{
						return null;
					}
					AActor owner = uuiitem.GetOwner();
					TSubclassOf<UActorComponent> @class = UUIButtonComponent.StaticClass();
					bool bManualAttachment = false;
					FTransform ftransform = new FTransform();
					(owner.AddComponentByClass(@class, bManualAttachment, ftransform, false, default(FName)) as UUIButtonComponent).OnClickCallBack.Bind(delegate()
					{
						CS$<>8__locals1.<>4__this.ClickSingleMark(CS$<>8__locals1.markItem, null);
					});
				}
				if (uuiitem == null)
				{
					return null;
				}
				return new UUIItem[]
				{
					uuiitem,
					uuiitem
				};
			}
		}

		// Token: 0x06030051 RID: 196689 RVA: 0x00B204F0 File Offset: 0x00B1E6F0
		private void CheckAndCleanInvalidCustomMarks()
		{
			if (!LocalStorage.GetPlayer<bool>(ELocalStoragePlayerKey.HasCleanInvalidCustomMark, false))
			{
				BaseMap map = this.Map;
				Dictionary<int, MarkItem> dictionary = (map != null) ? map.GetMarkItemsByType(EMarkType.Custom, false) : null;
				if (dictionary != null)
				{
					List<int> list = new List<int>();
					foreach (MarkItem markItem in dictionary.Values)
					{
						if (!this.Map.InValidMapTile(markItem.WorldPosition))
						{
							list.Add(markItem.MarkId);
						}
					}
					if (list.Count > 0)
					{
						MapController.Instance.RequestRemoveMapMarks(EMarkType.Custom, list);
					}
				}
				LocalStorage.SetPlayer<bool>(ELocalStoragePlayerKey.HasCleanInvalidCustomMark, true);
			}
		}

		// Token: 0x06030052 RID: 196690 RVA: 0x00B205A8 File Offset: 0x00B1E7A8
		private void OnChangeMapBtnClick()
		{
			this.ResetFocusInteract();
			this.CloseSecondaryUi(delegate
			{
				WorldMapUiEntity worldMapUiEntity = this.WorldMapUiEntity;
				if (worldMapUiEntity != null)
				{
					worldMapUiEntity.MultiFloorComponent.DeSelectMultiMapFloor(true);
				}
				WorldMapUiEntity worldMapUiEntity2 = this.WorldMapUiEntity;
				if (worldMapUiEntity2 == null)
				{
					return;
				}
				WorldMapSecondaryUiComponent secondaryUiComponent = worldMapUiEntity2.SecondaryUiComponent;
				UUIItem item = base.GetItem(25);
				BaseMap map = this.Map;
				secondaryUiComponent.ShowQuickNavigate(item, (map != null) ? map.GetNavigateMarkList() : null);
			}, true);
		}

		// Token: 0x06030053 RID: 196691 RVA: 0x00B205C3 File Offset: 0x00B1E7C3
		private void OnMarkToggleBtnClick()
		{
			this.CloseSecondaryUi(delegate
			{
				WorldMapUiEntity worldMapUiEntity = this.WorldMapUiEntity;
				if (worldMapUiEntity == null)
				{
					return;
				}
				worldMapUiEntity.SecondaryUiComponent.ShowMapMarkTogglePanel(base.GetItem(25), null, null);
			}, true);
		}

		// Token: 0x06030054 RID: 196692 RVA: 0x00B205D8 File Offset: 0x00B1E7D8
		private void ResetFocusInteract()
		{
			WorldMapUiEntity worldMapUiEntity = this.WorldMapUiEntity;
			if (worldMapUiEntity != null)
			{
				worldMapUiEntity.InteractComponent.SetJoystickFocus(false);
			}
			this.ClickedItems = new List<MarkItem>();
		}

		// Token: 0x06030055 RID: 196693 RVA: 0x00B205FC File Offset: 0x00B1E7FC
		private void OnChangeGravityBtnClick()
		{
			WorldMapUiEntity worldMapUiEntity = this.WorldMapUiEntity;
			if (worldMapUiEntity != null && worldMapUiEntity.WorldMapAlterMapComponent.CanChangeMapGravity)
			{
				this.ResetFocusInteract();
				this.CloseSecondaryUi(delegate
				{
					this.WorldMapUiEntity.MultiFloorComponent.DeSelectMultiMapFloor(true);
					this.WorldMapUiEntity.WorldMapAlterMapComponent.ChangeMapGravity();
					this.UpdateGravityBtn();
				}, true);
			}
		}

		// Token: 0x06030056 RID: 196694 RVA: 0x00B20630 File Offset: 0x00B1E830
		private void UpdateGravityBtn()
		{
			bool canChangeMapGravity = this.WorldMapUiEntity.WorldMapAlterMapComponent.CanChangeMapGravity;
			this.WorldMapChangeGravityButtonItem.SetUiActive(canChangeMapGravity);
			if (canChangeMapGravity)
			{
				bool flag = WorldMapModel.Instance.WorldMapGravity == EMapGravityDirection.Down;
				string resourcePath = UiResourceConfig.Instance.GetResourcePath(flag ? "SP_BtnOverviewBDown" : "SP_BtnOverviewB");
				this.WorldMapChangeGravityButtonItem.SetSprite(resourcePath);
			}
			EventSystem.Instance.Emit<bool>(EEventName.OnUpdateGravityBtn, canChangeMapGravity);
		}

		// Token: 0x06030057 RID: 196695 RVA: 0x00B206A2 File Offset: 0x00B1E8A2
		private void OnMapOpenFogChange(int fogId)
		{
			this.UpdateCustomizedThumbnail();
		}

		// Token: 0x06030058 RID: 196696 RVA: 0x00B206AC File Offset: 0x00B1E8AC
		private void UpdateCustomizedThumbnail()
		{
			Dictionary<int, bool> allUnlockedAreas = MapModel.Instance.GetAllUnlockedAreas();
			bool flag = allUnlockedAreas != null && allUnlockedAreas.GetValueOrDefault(ConfigCommonParamById.GetIntConfig("UnderseaOverviewUnlockAreaId").Value);
			base.GetItem(22).SetUIActive(WorldMapModel.Instance.IsNeedCustomizedThumbnail(this.Map.MapId) && flag);
		}

		// Token: 0x06030059 RID: 196697 RVA: 0x00B20706 File Offset: 0x00B1E906
		private void OnInputKeyEvent(string keyName, InputDistributeDefine.EActionType actionType, InputIdentification inputIdentification)
		{
		}

		// Token: 0x0603005A RID: 196698 RVA: 0x00B20708 File Offset: 0x00B1E908
		[NullableContext(2)]
		private void DebugDrawPosNotify(IMessage msg, Net.CallbackStatus status)
		{
			DebugDrawPosNotify debugDrawPosNotify = (DebugDrawPosNotify)msg;
		}

		// Token: 0x0603005B RID: 196699 RVA: 0x00B20711 File Offset: 0x00B1E911
		[Conditional("DEBUG")]
		private void HandleDebugCopy()
		{
		}

		// Token: 0x0603005C RID: 196700 RVA: 0x00B20714 File Offset: 0x00B1E914
		[NullableContext(2)]
		private void OpenExtraUi(EWorldMapExtraUiPanelName panelName, object param = null)
		{
			WorldMapUiEntity worldMapUiEntity = this.WorldMapUiEntity;
			if (worldMapUiEntity == null || !worldMapUiEntity.WorldMapExtraUiPanelComponent.IsExtraUiViewOpened)
			{
				this.ExploreInfoItem.SetMapNotesState(false);
				this.HudSequencer.StopCurrentSequence(false, false);
				this.HudSequencer.PlayLevelSequenceByName("Hide", false, null, false);
			}
			WorldMapUiEntity worldMapUiEntity2 = this.WorldMapUiEntity;
			if (worldMapUiEntity2 == null)
			{
				return;
			}
			worldMapUiEntity2.WorldMapExtraUiPanelComponent.OpenUi(panelName, base.GetItem(25), param);
		}

		// Token: 0x0603005D RID: 196701 RVA: 0x00B20791 File Offset: 0x00B1E991
		private void OnExtraUiViewOpened(WorldMapExtraUiPanel panel)
		{
			base.AddChild(panel);
		}

		// Token: 0x0603005E RID: 196702 RVA: 0x00B2079C File Offset: 0x00B1E99C
		private void OnExtraUiViewClosed()
		{
			WorldMapUiEntity worldMapUiEntity = this.WorldMapUiEntity;
			if (worldMapUiEntity == null || !worldMapUiEntity.WorldMapExtraUiPanelComponent.IsExtraUiViewOpened)
			{
				this.ExploreInfoItem.SetMapNotesState(true);
				this.HudSequencer.StopCurrentSequence(false, false);
				base.GetItem(14).SetUIActive(true);
				EventSystem.Instance.Emit<bool>(EEventName.WorldMapPanelHudVisibleChanged, true);
				this.HudSequencer.PlayLevelSequenceByName("Show", false, null, false);
			}
		}

		// Token: 0x0603005F RID: 196703 RVA: 0x00B20818 File Offset: 0x00B1EA18
		[NullableContext(2)]
		private void EventOpenExtraUiFromMap(EWorldMapExtraUiPanelName panelName, object param = null)
		{
			this.OpenExtraUi(panelName, param);
		}

		// Token: 0x06030060 RID: 196704 RVA: 0x00B20822 File Offset: 0x00B1EA22
		private void EventCloseAllExtraUiFromMap()
		{
			WorldMapUiEntity worldMapUiEntity = this.WorldMapUiEntity;
			if (worldMapUiEntity == null)
			{
				return;
			}
			worldMapUiEntity.WorldMapExtraUiPanelComponent.CloseAllUi();
		}

		// Token: 0x06030061 RID: 196705 RVA: 0x00B20839 File Offset: 0x00B1EA39
		private void SetWorldMapCursorButtonVisible(bool visible)
		{
			this.CursorButton.SetCursorActive(visible);
		}

		// Token: 0x06030068 RID: 196712 RVA: 0x00B20940 File Offset: 0x00B1EB40
		[CompilerGenerated]
		[return: Nullable(new byte[]
		{
			0,
			0,
			1,
			1
		})]
		internal static UniTask<ValueTuple<MarkItem, UUIItem>> <OnPointerUp>g__getMarkTupleFunc|101_0(MarkItem markItem)
		{
			WorldMapView.<<OnPointerUp>g__getMarkTupleFunc|101_0>d <<OnPointerUp>g__getMarkTupleFunc|101_0>d;
			<<OnPointerUp>g__getMarkTupleFunc|101_0>d.<>t__builder = AsyncUniTaskMethodBuilder<ValueTuple<MarkItem, UUIItem>>.Create();
			<<OnPointerUp>g__getMarkTupleFunc|101_0>d.markItem = markItem;
			<<OnPointerUp>g__getMarkTupleFunc|101_0>d.<>1__state = -1;
			<<OnPointerUp>g__getMarkTupleFunc|101_0>d.<>t__builder.Start<WorldMapView.<<OnPointerUp>g__getMarkTupleFunc|101_0>d>(ref <<OnPointerUp>g__getMarkTupleFunc|101_0>d);
			return <<OnPointerUp>g__getMarkTupleFunc|101_0>d.<>t__builder.Task;
		}

		// Token: 0x06030069 RID: 196713 RVA: 0x00B20984 File Offset: 0x00B1EB84
		[CompilerGenerated]
		[return: Nullable(new byte[]
		{
			0,
			0,
			1,
			1
		})]
		internal static UniTask<ValueTuple<MarkItem, UUIItem>> <OnCloseSecondaryUiByClickOtherMarkCall>g__getMarkTupleFunc|111_1(MarkItem markItem)
		{
			WorldMapView.<<OnCloseSecondaryUiByClickOtherMarkCall>g__getMarkTupleFunc|111_1>d <<OnCloseSecondaryUiByClickOtherMarkCall>g__getMarkTupleFunc|111_1>d;
			<<OnCloseSecondaryUiByClickOtherMarkCall>g__getMarkTupleFunc|111_1>d.<>t__builder = AsyncUniTaskMethodBuilder<ValueTuple<MarkItem, UUIItem>>.Create();
			<<OnCloseSecondaryUiByClickOtherMarkCall>g__getMarkTupleFunc|111_1>d.markItem = markItem;
			<<OnCloseSecondaryUiByClickOtherMarkCall>g__getMarkTupleFunc|111_1>d.<>1__state = -1;
			<<OnCloseSecondaryUiByClickOtherMarkCall>g__getMarkTupleFunc|111_1>d.<>t__builder.Start<WorldMapView.<<OnCloseSecondaryUiByClickOtherMarkCall>g__getMarkTupleFunc|111_1>d>(ref <<OnCloseSecondaryUiByClickOtherMarkCall>g__getMarkTupleFunc|111_1>d);
			return <<OnCloseSecondaryUiByClickOtherMarkCall>g__getMarkTupleFunc|111_1>d.<>t__builder.Task;
		}

		// Token: 0x04019E58 RID: 106072
		[Nullable(2)]
		protected WorldMapUiEntity WorldMapUiEntity;

		// Token: 0x04019E59 RID: 106073
		[Nullable(2)]
		private BaseMap Map;

		// Token: 0x04019E5A RID: 106074
		[Nullable(2)]
		private UKuroWorldMapUIParams UiParams;

		// Token: 0x04019E5B RID: 106075
		[Nullable(2)]
		private IWorldMapViewOpenParams ShowParams;

		// Token: 0x04019E5C RID: 106076
		private EWorldMapShowMode ShowMode;

		// Token: 0x04019E5D RID: 106077
		[Nullable(2)]
		private MarkItem SequenceMarkItem;

		// Token: 0x04019E5E RID: 106078
		private readonly PowerCurrencyItem PowerCurrencyItem = new PowerCurrencyItem();

		// Token: 0x04019E5F RID: 106079
		private readonly PowerCurrencyItem OverPowerCurrencyItem = new PowerCurrencyItem();

		// Token: 0x04019E60 RID: 106080
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<MarkItem> ClickedItems = new List<MarkItem>();

		// Token: 0x04019E61 RID: 106081
		private readonly Vector2D ClickedPosition = new Vector2D();

		// Token: 0x04019E62 RID: 106082
		private LongPressButton ZoomInButton;

		// Token: 0x04019E63 RID: 106083
		private LongPressButton ZoomOutButton;

		// Token: 0x04019E64 RID: 106084
		[Nullable(new byte[]
		{
			0,
			2
		})]
		private ValueTuple<double, MarkItem> MinRangeAndItem = new ValueTuple<double, MarkItem>(0.0, null);

		// Token: 0x04019E65 RID: 106085
		private readonly HandleCursorButton CursorButton = new HandleCursorButton();

		// Token: 0x04019E66 RID: 106086
		private readonly ExploreInfoItem ExploreInfoItem = new ExploreInfoItem();

		// Token: 0x04019E67 RID: 106087
		private readonly WorldMapPeriodicActivityItem WorldMapPeriodicActivityItem = new WorldMapPeriodicActivityItem();

		// Token: 0x04019E68 RID: 106088
		private readonly HonamiMarkSelectPanel HonamiMarkSelectPanel = new HonamiMarkSelectPanel();

		// Token: 0x04019E69 RID: 106089
		private UnderseaOverviewItem UnderseaOverviewItem;

		// Token: 0x04019E6A RID: 106090
		private UUIItem UnLockItem;

		// Token: 0x04019E6B RID: 106091
		private readonly Dictionary<UUIItem, LevelSequencePlayer> ClickItemLevelSequenceMap = new Dictionary<UUIItem, LevelSequencePlayer>();

		// Token: 0x04019E6C RID: 106092
		private MapLifeEventDispatcher LifeEventDispatcher;

		// Token: 0x04019E6D RID: 106093
		private GenericLayout<WorldMapSubMapItem, MultiMap> MultiMapFloorLayout;

		// Token: 0x04019E6E RID: 106094
		private readonly RegionalTerminalBarItem RegionalTerminalBar = new RegionalTerminalBarItem();

		// Token: 0x04019E6F RID: 106095
		private LevelSequencePlayer HudSequencer;

		// Token: 0x04019E70 RID: 106096
		private LevelSequencePlayer UnLockSequence;

		// Token: 0x04019E71 RID: 106097
		private int OpenFogId;

		// Token: 0x04019E72 RID: 106098
		private bool ShowFogEffectInstant;

		// Token: 0x04019E73 RID: 106099
		private bool IsNotNeedUnLockEffect;

		// Token: 0x04019E74 RID: 106100
		private int OpenParamMapId;

		// Token: 0x04019E75 RID: 106101
		private bool IsCloseThenOpenSecondaryUi;

		// Token: 0x04019E76 RID: 106102
		private bool IsWaitNoteAndRecommend;

		// Token: 0x04019E77 RID: 106103
		private WorldMapChangeGravityButtonItem WorldMapChangeGravityButtonItem;

		// Token: 0x04019E78 RID: 106104
		private const int MARKICON_HALFSIZE = 70;

		// Token: 0x04019E79 RID: 106105
		private const int MAX_INT32_NUMBER = 2147483647;

		// Token: 0x04019E7A RID: 106106
		private readonly string[] _psoCvars = new string[]
		{
			"r.PSO.IgnoreCreationHints",
			"r.PSO.CompilationMode"
		};

		// Token: 0x04019E7B RID: 106107
		private readonly Dictionary<string, int> _cachedPsoCvarValues = new Dictionary<string, int>();

		// Token: 0x04019E7C RID: 106108
		private const int VIEW_PORT_BUFFER_REGION = 400;

		// Token: 0x04019E7D RID: 106109
		private readonly HashSet<EUiViewName> ExtraSecondaryUiViewMap = new HashSet<EUiViewName>
		{
			EUiViewName.PowerView,
			EUiViewName.ExploreProgressView,
			EUiViewName.MapExploreDetailView
		};

		// Token: 0x0200AA42 RID: 43586
		[NullableContext(0)]
		public static class EMapComponents
		{
			// Token: 0x04033CD3 RID: 212179
			public const int LeftUi = 0;

			// Token: 0x04033CD4 RID: 212180
			public const int ScaleSlider = 1;

			// Token: 0x04033CD5 RID: 212181
			public const int ZoomOut = 2;

			// Token: 0x04033CD6 RID: 212182
			public const int ZoomIn = 3;

			// Token: 0x04033CD7 RID: 212183
			public const int FloorSelection = 4;

			// Token: 0x04033CD8 RID: 212184
			public const int CloseBtn = 5;

			// Token: 0x04033CD9 RID: 212185
			public const int BtnMarkToggle = 6;

			// Token: 0x04033CDA RID: 212186
			public const int SwitchFog = 7;

			// Token: 0x04033CDB RID: 212187
			public const int MarkEdge = 8;

			// Token: 0x04033CDC RID: 212188
			public const int MapRoot = 9;

			// Token: 0x04033CDD RID: 212189
			public const int CurrencyItem = 10;

			// Token: 0x04033CDE RID: 212190
			public const int Cursor = 11;

			// Token: 0x04033CDF RID: 212191
			public const int ParamsItem = 12;

			// Token: 0x04033CE0 RID: 212192
			public const int TowerItem = 13;

			// Token: 0x04033CE1 RID: 212193
			public const int PanelHud = 14;

			// Token: 0x04033CE2 RID: 212194
			public const int MultiMapFloorLayout = 15;

			// Token: 0x04033CE3 RID: 212195
			public const int MultiMapFloorContainer = 16;

			// Token: 0x04033CE4 RID: 212196
			public const int MapChangeBtn = 17;

			// Token: 0x04033CE5 RID: 212197
			public const int TxtCountryName = 18;

			// Token: 0x04033CE6 RID: 212198
			public const int BtnGravityChange = 19;

			// Token: 0x04033CE7 RID: 212199
			public const int InverseTowerCtrl = 20;

			// Token: 0x04033CE8 RID: 212200
			public const int DebugTxt = 21;

			// Token: 0x04033CE9 RID: 212201
			public const int UnderseaOverview = 22;

			// Token: 0x04033CEA RID: 212202
			public const int ExploreInfoItem = 23;

			// Token: 0x04033CEB RID: 212203
			public const int BarTerminal = 24;

			// Token: 0x04033CEC RID: 212204
			public const int PanelContent = 25;

			// Token: 0x04033CED RID: 212205
			public const int BoxSliderPanel = 26;

			// Token: 0x04033CEE RID: 212206
			public const int BoxThresholdSprite = 27;

			// Token: 0x04033CEF RID: 212207
			public const int BoxSliderHandle = 28;

			// Token: 0x04033CF0 RID: 212208
			public const int BoxSwitchBtn = 29;

			// Token: 0x04033CF1 RID: 212209
			public const int BoxScreenCapture = 30;
		}
	}
}
