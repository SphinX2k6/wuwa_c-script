using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Activity.ActivityContent.MoonChasing;
using CSharpScript.Game.Module.ActivityCommonRootView;
using CSharpScript.Game.Module.UiNavigation;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.SolarSchool
{
	// Token: 0x02005A30 RID: 23088
	[NullableContext(1)]
	[Nullable(0)]
	public class SolarSchoolMapPanel : SolarSchoolChildViewBase
	{
		// Token: 0x17006C76 RID: 27766
		// (get) Token: 0x06038DE1 RID: 232929 RVA: 0x00FEC332 File Offset: 0x00FEA532
		public override bool BackgroundVisible
		{
			get
			{
				return false;
			}
		}

		// Token: 0x06038DE2 RID: 232930 RVA: 0x00FEC338 File Offset: 0x00FEA538
		protected override SolarSchoolRootUiParams CreateRootUiParams()
		{
			SolarSchoolGamePlayModel instance = SolarSchoolGamePlayModel.Instance;
			return new SolarSchoolRootUiParams
			{
				Caption = new SolarSchoolCaptionParams
				{
					SetVisible = true,
					TipCostVisible = true,
					OverviewVisible = true,
					BackpackVisible = true,
					HelpGroupId = 732
				},
				FestivalTips = (instance.IsFestivalInstance ? new SolarSchoolFestivalTipsParams(instance.FestivalName) : null),
				ShopButtonVisible = instance.ShouldShowShopEntryTip(),
				InvitationTagVisible = instance.ShouldShowInvitationTag()
			};
		}

		// Token: 0x17006C77 RID: 27767
		// (get) Token: 0x06038DE3 RID: 232931 RVA: 0x00FEC3B6 File Offset: 0x00FEA5B6
		// (set) Token: 0x06038DE4 RID: 232932 RVA: 0x00FEC3C3 File Offset: 0x00FEA5C3
		private ESolarSchoolMapTimePhase? MapTimePhase
		{
			get
			{
				return base.SolarSchoolViewModel.LastShownMapPhase;
			}
			set
			{
				base.SolarSchoolViewModel.LastShownMapPhase = value;
			}
		}

		// Token: 0x06038DE5 RID: 232933 RVA: 0x00FEC3D4 File Offset: 0x00FEA5D4
		protected unsafe override void OnRegisterComponent()
		{
			int num = 9;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIDraggableComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(8, typeof(UUIButtonComponent));
			this.ComponentRegisterInfos = list;
			num2 = 1;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(8, new Action(this.OnBtnGoHomeClick));
			this.BtnBindInfo = list2;
		}

		// Token: 0x06038DE6 RID: 232934 RVA: 0x00FEC564 File Offset: 0x00FEA764
		protected override UniTask OnBeforeStartAsync()
		{
			SolarSchoolMapPanel.<OnBeforeStartAsync>d__27 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<SolarSchoolMapPanel.<OnBeforeStartAsync>d__27>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06038DE7 RID: 232935 RVA: 0x00FEC5A8 File Offset: 0x00FEA7A8
		protected override void OnStart()
		{
			UUIItem item = base.GetItem(6);
			if (item != null)
			{
				item.SetUIActive(false);
			}
			this.RootActor.OnSequencePlayEvent.Bind(new Action<string, string>(this.OnEventSequence));
			if (SolarSchoolGamePlayModel.Instance.TimeData.DisplayMapTimePhase == ESolarSchoolMapTimePhase.Dusk)
			{
				this.SequencePlayer.PlaySequence("ToDusk", false, null);
				this.SequencePlayer.StopSequenceByKey("ToDusk", false, true);
			}
			this.ApplyOpenParam();
		}

		// Token: 0x06038DE8 RID: 232936 RVA: 0x00FEC628 File Offset: 0x00FEA828
		public override void OnReopen()
		{
			this.RefreshLocations();
			SolarSchoolQuestInfoItem questInfoItem = this.QuestInfoItem;
			if (questInfoItem != null)
			{
				questInfoItem.Refresh();
			}
			this.RefreshHomeButton();
			base.SolarSchoolViewModel.RefreshInvitationTag();
			base.SolarSchoolViewModel.RefreshFestivalTips();
			this.ApplyOpenParam();
		}

		// Token: 0x06038DE9 RID: 232937 RVA: 0x00FEC664 File Offset: 0x00FEA864
		protected override void OnBeforeShow()
		{
			SolarSchoolAttrPanel scorePanel = this.ScorePanel;
			if (scorePanel != null)
			{
				scorePanel.RefreshAttr();
			}
			SolarSchoolMapUnlockPanelParam solarSchoolMapUnlockPanelParam = this.OpenParam as SolarSchoolMapUnlockPanelParam;
			if (solarSchoolMapUnlockPanelParam != null)
			{
				this.PrepareUnlockLocations(solarSchoolMapUnlockPanelParam.UnlockLocationIds);
			}
			SolarSchoolMapTilePanel tilePanel = this.TilePanel;
			if (tilePanel != null)
			{
				tilePanel.RefreshLocations();
			}
			this.RefreshHomeButton();
			this.ApplyTimePhase();
			base.SolarSchoolViewModel.RefreshLocationRole();
		}

		// Token: 0x06038DEA RID: 232938 RVA: 0x00FEC6C6 File Offset: 0x00FEA8C6
		public override void OnTick(float delta)
		{
			BuildingMapMoveComponent mapMoveComponent = this.MapMoveComponent;
			if (mapMoveComponent == null)
			{
				return;
			}
			mapMoveComponent.TickMove();
		}

		// Token: 0x06038DEB RID: 232939 RVA: 0x00FEC6D8 File Offset: 0x00FEA8D8
		protected override void OnAfterShow()
		{
			this.RefreshArrows();
		}

		// Token: 0x06038DEC RID: 232940 RVA: 0x00FEC6E0 File Offset: 0x00FEA8E0
		protected override void OnAddEventListener()
		{
			EventSystem.Instance.Add<int>(EEventName.SolarSchoolLocationUnlocked, new Action<int>(this.OnSolarSchoolLocationUnlocked));
			EventSystem.Instance.Add(EEventName.SolarSchoolTimeChanged, new Action(this.OnTimeChanged));
			EventSystem.Instance.Add<ECommonChildViewName>(EEventName.OnCommonChildViewShowDone, new Action<ECommonChildViewName>(this.OnChildViewShowDone));
			BuildingMapMoveComponent mapMoveComponent = this.MapMoveComponent;
			if (mapMoveComponent != null)
			{
				mapMoveComponent.AddGamepadEvent();
			}
			BuildingMapMoveComponent mapMoveComponent2 = this.MapMoveComponent;
			if (mapMoveComponent2 == null)
			{
				return;
			}
			mapMoveComponent2.AddMoveListener(true, true);
		}

		// Token: 0x06038DED RID: 232941 RVA: 0x00FEC764 File Offset: 0x00FEA964
		protected override void OnRemoveEventListener()
		{
			EventSystem.Instance.Remove<int>(EEventName.SolarSchoolLocationUnlocked, new Action<int>(this.OnSolarSchoolLocationUnlocked));
			EventSystem.Instance.Remove(EEventName.SolarSchoolTimeChanged, new Action(this.OnTimeChanged));
			EventSystem.Instance.Remove<ECommonChildViewName>(EEventName.OnCommonChildViewShowDone, new Action<ECommonChildViewName>(this.OnChildViewShowDone));
			BuildingMapMoveComponent mapMoveComponent = this.MapMoveComponent;
			if (mapMoveComponent != null)
			{
				mapMoveComponent.RemoveGamepadEvent();
			}
			BuildingMapMoveComponent mapMoveComponent2 = this.MapMoveComponent;
			if (mapMoveComponent2 == null)
			{
				return;
			}
			mapMoveComponent2.RemoveMoveListener();
		}

		// Token: 0x06038DEE RID: 232942 RVA: 0x00FEC7E8 File Offset: 0x00FEA9E8
		private void OnTimeChanged()
		{
			this.ApplyTimePhase();
			this.RefreshHomeButton();
			base.SolarSchoolViewModel.RefreshInvitationTag();
			base.SolarSchoolViewModel.RefreshFestivalTips();
			if (this.CacheTransitionDayIndex != -1 && this.CacheTransitionDayIndex != SolarSchoolGamePlayModel.Instance.TimeData.DayIndex)
			{
				this.CacheTransitionDayIndex = -1;
				this.RefreshLocations();
				this.SequencePlayer.PlaySequence("UI_In", true, null);
			}
		}

		// Token: 0x06038DEF RID: 232943 RVA: 0x00FEC85E File Offset: 0x00FEAA5E
		private void OnChildViewShowDone(ECommonChildViewName viewName)
		{
			if (viewName != ECommonChildViewName.SolarSchoolMap)
			{
				return;
			}
			UiNavigationViewManager.Instance.MarkCalculateCurrentPanelDirty();
		}

		// Token: 0x06038DF0 RID: 232944 RVA: 0x00FEC86F File Offset: 0x00FEAA6F
		public void NotifyAppear()
		{
			this.ApplyTimePhase();
		}

		// Token: 0x06038DF1 RID: 232945 RVA: 0x00FEC878 File Offset: 0x00FEAA78
		private void ApplyTimePhase()
		{
			SolarSchoolGamePlayModel instance = SolarSchoolGamePlayModel.Instance;
			ESolarSchoolMapTimePhase displayMapTimePhase = instance.TimeData.DisplayMapTimePhase;
			ESolarSchoolMapTimePhase? mapTimePhase = this.MapTimePhase;
			ESolarSchoolMapTimePhase esolarSchoolMapTimePhase = displayMapTimePhase;
			bool flag = !(mapTimePhase.GetValueOrDefault() == esolarSchoolMapTimePhase & mapTimePhase != null) && instance.HasSlotTransitionUnplayed && !instance.HasDaySmallTransitionUnplayed;
			Action refreshDate = base.SolarSchoolViewModel.RefreshDate;
			if (refreshDate != null)
			{
				refreshDate();
			}
			if (flag)
			{
				this.PlayMapTimePhaseTransition(displayMapTimePhase);
				return;
			}
			this.SnapMapTimePhase(displayMapTimePhase);
		}

		// Token: 0x06038DF2 RID: 232946 RVA: 0x00FEC8F0 File Offset: 0x00FEAAF0
		private void ApplyOpenParam()
		{
			SolarSchoolMapPanelParam solarSchoolMapPanelParam = this.OpenParam as SolarSchoolMapPanelParam;
			if (solarSchoolMapPanelParam == null)
			{
				return;
			}
			this.OpenParam = null;
			SolarSchoolMapUnlockPanelParam solarSchoolMapUnlockPanelParam = solarSchoolMapPanelParam as SolarSchoolMapUnlockPanelParam;
			if (solarSchoolMapUnlockPanelParam != null)
			{
				this.PlayUnlockAnimationAsync(solarSchoolMapUnlockPanelParam).Forget();
				return;
			}
			this.FocusOnLocation(solarSchoolMapPanelParam.FocusLocationId, null, true);
		}

		// Token: 0x06038DF3 RID: 232947 RVA: 0x00FEC944 File Offset: 0x00FEAB44
		protected override void OnBeforeDestroy()
		{
			this.CancelAnimTimer();
			CustomPromise<bool> unlockIconEventPromise = this.UnlockIconEventPromise;
			if (unlockIconEventPromise != null)
			{
				unlockIconEventPromise.SetResult(false);
			}
			this.UnlockIconEventPromise = null;
			AUIBaseActor rootActor = this.RootActor;
			if (rootActor != null)
			{
				rootActor.OnSequencePlayEvent.Unbind();
			}
			this.Arrows.Clear();
			BuildingMapMoveComponent mapMoveComponent = this.MapMoveComponent;
			if (mapMoveComponent != null)
			{
				mapMoveComponent.Destroy();
			}
			this.MapMoveComponent = null;
		}

		// Token: 0x06038DF4 RID: 232948 RVA: 0x00FEC9A9 File Offset: 0x00FEABA9
		public void RefreshLocations()
		{
			SolarSchoolMapTilePanel tilePanel = this.TilePanel;
			if (tilePanel != null)
			{
				tilePanel.RefreshLocations();
			}
			this.RefreshHomeButton();
			this.RefreshArrows();
		}

		// Token: 0x06038DF5 RID: 232949 RVA: 0x00FEC9C8 File Offset: 0x00FEABC8
		[return: Nullable(new byte[]
		{
			2,
			1
		})]
		public override UUIItem[] GetGuideUiItemAndUiItemForShowEx(string[] configParams)
		{
			if (configParams.Length >= 2 && configParams[0] == "QuestInfoEntry")
			{
				int num;
				if (!int.TryParse(configParams[1], out num) || num <= 0)
				{
					return null;
				}
				SolarSchoolQuestInfoItem questInfoItem = this.QuestInfoItem;
				UUIItem uuiitem = (questInfoItem != null) ? questInfoItem.GetGuideEntryItem(num) : null;
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
			else
			{
				int num2;
				if (configParams.Length < 2 || configParams[0] != "MapLocation" || !int.TryParse(configParams[1], out num2) || num2 <= 0)
				{
					return null;
				}
				SolarSchoolMapTilePanel tilePanel = this.TilePanel;
				UUIItem uuiitem2;
				if (tilePanel == null)
				{
					uuiitem2 = null;
				}
				else
				{
					SolarSchoolMapItem mapItem = tilePanel.GetMapItem(num2);
					uuiitem2 = ((mapItem != null) ? mapItem.GetGuideLocationItem() : null);
				}
				UUIItem uuiitem3 = uuiitem2;
				if (uuiitem3 == null)
				{
					return null;
				}
				this.FocusOnLocation(num2, null, false);
				return new UUIItem[]
				{
					uuiitem3,
					uuiitem3
				};
			}
		}

		// Token: 0x06038DF6 RID: 232950 RVA: 0x00FECA90 File Offset: 0x00FEAC90
		public void FocusOnLocation(int locationId, double? tweenTime = null, bool playTips = true)
		{
			this.CancelAnimTimer();
			double valueOrDefault = tweenTime.GetValueOrDefault(0.5);
			if (!this.TryFocusOnLocation(locationId, valueOrDefault))
			{
				return;
			}
			if (playTips)
			{
				this.PlayLocationTipsAfterMove(locationId, valueOrDefault);
			}
		}

		// Token: 0x06038DF7 RID: 232951 RVA: 0x00FECACC File Offset: 0x00FEACCC
		private bool TryFocusOnLocation(int locationId, double tweenTime)
		{
			if (this.MapMoveComponent == null)
			{
				return false;
			}
			SolarSchoolMapTilePanel tilePanel = this.TilePanel;
			FVector2D? fvector2D;
			if (tilePanel == null)
			{
				fvector2D = null;
			}
			else
			{
				UUIItem slotItem = tilePanel.GetSlotItem(locationId);
				fvector2D = ((slotItem != null) ? new FVector2D?(slotItem.GetAnchorOffset()) : null);
			}
			FVector2D? fvector2D2 = fvector2D;
			if (fvector2D2 == null)
			{
				return false;
			}
			this.MapMoveComponent.MoveToTarget(new double[]
			{
				(double)fvector2D2.Value.X,
				(double)fvector2D2.Value.Y
			}, LTweenEase.InOutSine, tweenTime, null);
			return true;
		}

		// Token: 0x06038DF8 RID: 232952 RVA: 0x00FECB5C File Offset: 0x00FEAD5C
		private void PlayLocationTipsAfterMove(int locationId, double tweenTime)
		{
			if (tweenTime > 0.0)
			{
				this.AnimTimer = TimerSystem.GameplayTimeInstance.Delay(delegate(float _)
				{
					this.AnimTimer = null;
					SolarSchoolMapTilePanel tilePanel2 = this.TilePanel;
					if (tilePanel2 == null)
					{
						return;
					}
					tilePanel2.PlayLocationAnimation(locationId, "Tips");
				}, (float)(tweenTime * (double)TimeUtil.Instance.InverseMillisecond), null, null, true, 1f);
				return;
			}
			SolarSchoolMapTilePanel tilePanel = this.TilePanel;
			if (tilePanel == null)
			{
				return;
			}
			tilePanel.PlayLocationAnimation(locationId, "Tips");
		}

		// Token: 0x06038DF9 RID: 232953 RVA: 0x00FECBD8 File Offset: 0x00FEADD8
		private UniTask PlayUnlockAnimationAsync(SolarSchoolMapUnlockPanelParam openParam)
		{
			SolarSchoolMapPanel.<PlayUnlockAnimationAsync>d__46 <PlayUnlockAnimationAsync>d__;
			<PlayUnlockAnimationAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<PlayUnlockAnimationAsync>d__.<>4__this = this;
			<PlayUnlockAnimationAsync>d__.openParam = openParam;
			<PlayUnlockAnimationAsync>d__.<>1__state = -1;
			<PlayUnlockAnimationAsync>d__.<>t__builder.Start<SolarSchoolMapPanel.<PlayUnlockAnimationAsync>d__46>(ref <PlayUnlockAnimationAsync>d__);
			return <PlayUnlockAnimationAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06038DFA RID: 232954 RVA: 0x00FECC24 File Offset: 0x00FEAE24
		private bool PrepareUnlockLocations(IReadOnlyList<int> locationIds)
		{
			if (this.TilePanel == null)
			{
				return false;
			}
			foreach (int locationId in locationIds)
			{
				SolarSchoolMapItem mapItem = this.TilePanel.GetMapItem(locationId);
				if (mapItem == null || !mapItem.PrepareUnlockAnimation(locationId, "Unlock"))
				{
					return false;
				}
			}
			return true;
		}

		// Token: 0x06038DFB RID: 232955 RVA: 0x00FECC9C File Offset: 0x00FEAE9C
		private unsafe bool TryFocusOnUnlockLocations(IReadOnlyList<int> locationIds)
		{
			if (this.MapMoveComponent == null || this.TilePanel == null || locationIds.Count == 0)
			{
				return false;
			}
			double num = 0.0;
			double num2 = 0.0;
			foreach (int num3 in locationIds)
			{
				UUIItem slotItem = this.TilePanel.GetSlotItem(num3);
				FVector2D? fvector2D = (slotItem != null) ? new FVector2D?(slotItem.GetAnchorOffset()) : null;
				if (fvector2D == null)
				{
					Log instance = Log.Instance;
					ELogModule module = ELogModule.SolarSchool;
					ELogAuthor author = ELogAuthor.YYZ;
					string message = "[SolarSchool] 待解锁建筑地图节点不存在";
					<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("locationId", num3);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("locationIds", string.Join<int>(",", locationIds));
					instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
					return false;
				}
				num += (double)fvector2D.Value.X;
				num2 += (double)fvector2D.Value.Y;
			}
			this.MapMoveComponent.MoveToTarget(new double[]
			{
				num / (double)locationIds.Count,
				num2 / (double)locationIds.Count
			}, LTweenEase.InOutSine, 0.4000000059604645, null);
			return true;
		}

		// Token: 0x06038DFC RID: 232956 RVA: 0x00FECE08 File Offset: 0x00FEB008
		private void OnEventSequence(string _, string eventName)
		{
			if (eventName != "Sequence_Map_Icon" || this.UnlockIconEventPromise == null)
			{
				return;
			}
			this.UnlockIconEventPromise.SetResult(true);
			this.UnlockIconEventPromise = null;
		}

		// Token: 0x06038DFD RID: 232957 RVA: 0x00FECE33 File Offset: 0x00FEB033
		private void CancelAnimTimer()
		{
			if (TimerSystem.GameplayTimeInstance.Has(this.AnimTimer))
			{
				TimerSystem.GameplayTimeInstance.Remove(this.AnimTimer);
			}
			this.AnimTimer = null;
		}

		// Token: 0x06038DFE RID: 232958 RVA: 0x00FECE5F File Offset: 0x00FEB05F
		private void RefreshArrows()
		{
			base.RunAsyncTask(new UiAsyncTask("SolarSchoolMapPanel.RefreshArrows", new Func<UniTask>(this.RefreshArrowsAsync), null)).Forget();
		}

		// Token: 0x06038DFF RID: 232959 RVA: 0x00FECE84 File Offset: 0x00FEB084
		private UniTask RefreshArrowsAsync()
		{
			SolarSchoolMapPanel.<RefreshArrowsAsync>d__52 <RefreshArrowsAsync>d__;
			<RefreshArrowsAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<RefreshArrowsAsync>d__.<>4__this = this;
			<RefreshArrowsAsync>d__.<>1__state = -1;
			<RefreshArrowsAsync>d__.<>t__builder.Start<SolarSchoolMapPanel.<RefreshArrowsAsync>d__52>(ref <RefreshArrowsAsync>d__);
			return <RefreshArrowsAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06038E00 RID: 232960 RVA: 0x00FECEC8 File Offset: 0x00FEB0C8
		private void UpdateArrowTransforms()
		{
			UUIItem item = base.GetItem(5);
			if (this.Arrows.Count == 0 || this.TilePanel == null || item == null)
			{
				return;
			}
			UUIItem uuiitem = item;
			FVector2D fvector2D = new FVector2D(0f, 0f);
			FVector lguispaceAbsolutePositionByPivot = uuiitem.GetLGUISpaceAbsolutePositionByPivot(fvector2D);
			UUIItem uuiitem2 = item;
			fvector2D = new FVector2D(1f, 1f);
			FVector lguispaceAbsolutePositionByPivot2 = uuiitem2.GetLGUISpaceAbsolutePositionByPivot(fvector2D);
			double num = (double)(lguispaceAbsolutePositionByPivot.X + lguispaceAbsolutePositionByPivot2.X) * 0.5;
			double num2 = (double)(lguispaceAbsolutePositionByPivot.Y + lguispaceAbsolutePositionByPivot2.Y) * 0.5;
			double num3 = (double)(lguispaceAbsolutePositionByPivot2.X - lguispaceAbsolutePositionByPivot.X) * 0.5;
			double num4 = (double)(lguispaceAbsolutePositionByPivot2.Y - lguispaceAbsolutePositionByPivot.Y) * 0.5;
			FVector fvector = item.K2_GetComponentScale();
			foreach (SolarSchoolMapArrowItem solarSchoolMapArrowItem in this.Arrows)
			{
				if (solarSchoolMapArrowItem.LocationId != 0)
				{
					UUIItem redDotItem = this.TilePanel.GetRedDotItem(solarSchoolMapArrowItem.LocationId);
					if (redDotItem == null)
					{
						solarSchoolMapArrowItem.SetUiActive(false);
					}
					else
					{
						FVector lguispaceCenterAbsolutePosition = redDotItem.GetLGUISpaceCenterAbsolutePosition();
						double num5 = (double)lguispaceCenterAbsolutePosition.X - num;
						double num6 = (double)lguispaceCenterAbsolutePosition.Y - num2;
						if (Math.Abs(num5) <= num3 && Math.Abs(num6) <= num4)
						{
							solarSchoolMapArrowItem.SetUiActive(false);
						}
						else
						{
							double num7 = Math.Min((Math.Abs(num5) > double.Epsilon) ? (num3 / Math.Abs(num5)) : double.MaxValue, (Math.Abs(num6) > double.Epsilon) ? (num4 / Math.Abs(num6)) : double.MaxValue);
							solarSchoolMapArrowItem.Refresh(new FVector2D((float)(num5 * num7 / (double)fvector.X), (float)(num6 * num7 / (double)fvector.Y)), Math.Atan2(num6, num5) * 57.29577951308232);
							solarSchoolMapArrowItem.SetUiActive(true);
						}
					}
				}
			}
		}

		// Token: 0x06038E01 RID: 232961 RVA: 0x00FED0F8 File Offset: 0x00FEB2F8
		public void PlayMapTimePhaseTransition(ESolarSchoolMapTimePhase phase)
		{
			ESolarSchoolMapTimePhase? mapTimePhase = this.MapTimePhase;
			if (mapTimePhase.GetValueOrDefault() == phase & mapTimePhase != null)
			{
				return;
			}
			this.MapTimePhase = new ESolarSchoolMapTimePhase?(phase);
			this.SequencePlayer.StopSequenceByKey(this.GetPhaseAnim(this.Opposite(phase)), false, false);
			this.SequencePlayer.PlaySequence(this.GetPhaseAnim(phase), true, null);
		}

		// Token: 0x06038E02 RID: 232962 RVA: 0x00FED168 File Offset: 0x00FEB368
		public void StopMapTimePhaseTransition()
		{
			if (this.MapTimePhase == null)
			{
				return;
			}
			this.SequencePlayer.StopSequenceByKey(this.GetPhaseAnim(this.MapTimePhase.Value), false, true);
		}

		// Token: 0x06038E03 RID: 232963 RVA: 0x00FED1A8 File Offset: 0x00FEB3A8
		public void SnapMapTimePhase(ESolarSchoolMapTimePhase phase)
		{
			ESolarSchoolMapTimePhase? mapTimePhase = this.MapTimePhase;
			if (mapTimePhase.GetValueOrDefault() == phase & mapTimePhase != null)
			{
				return;
			}
			this.MapTimePhase = new ESolarSchoolMapTimePhase?(phase);
			string phaseAnim = this.GetPhaseAnim(phase);
			this.SequencePlayer.StopSequenceByKey(this.GetPhaseAnim(this.Opposite(phase)), false, false);
			this.SequencePlayer.PlaySequence(phaseAnim, false, null);
			this.SequencePlayer.StopSequenceByKey(phaseAnim, false, true);
		}

		// Token: 0x06038E04 RID: 232964 RVA: 0x00FED225 File Offset: 0x00FEB425
		private string GetPhaseAnim(ESolarSchoolMapTimePhase phase)
		{
			if (phase != ESolarSchoolMapTimePhase.Dusk)
			{
				return "ToDay";
			}
			return "ToDusk";
		}

		// Token: 0x06038E05 RID: 232965 RVA: 0x00FED238 File Offset: 0x00FEB438
		public void PlayDayTransitionSequence(string sequenceName)
		{
			this.DayTransitionSeqName = sequenceName;
			this.CacheTransitionDayIndex = SolarSchoolGamePlayModel.Instance.TimeData.DayIndex;
			this.SequencePlayer.PlaySequence(sequenceName, true, null);
		}

		// Token: 0x06038E06 RID: 232966 RVA: 0x00FED278 File Offset: 0x00FEB478
		public void StopDayTransitionSequence()
		{
			if (this.DayTransitionSeqName == null)
			{
				return;
			}
			string dayTransitionSeqName = this.DayTransitionSeqName;
			this.DayTransitionSeqName = null;
			this.SequencePlayer.StopSequenceByKey(dayTransitionSeqName, false, true);
		}

		// Token: 0x06038E07 RID: 232967 RVA: 0x00FED2AA File Offset: 0x00FEB4AA
		private ESolarSchoolMapTimePhase Opposite(ESolarSchoolMapTimePhase phase)
		{
			if (phase != ESolarSchoolMapTimePhase.Dusk)
			{
				return ESolarSchoolMapTimePhase.Dusk;
			}
			return ESolarSchoolMapTimePhase.Day;
		}

		// Token: 0x06038E08 RID: 232968 RVA: 0x00FED2B4 File Offset: 0x00FEB4B4
		[return: Nullable(new byte[]
		{
			0,
			1
		})]
		private UniTask<SolarSchoolMapArrowItem> AcquireArrowAsync()
		{
			SolarSchoolMapPanel.<AcquireArrowAsync>d__61 <AcquireArrowAsync>d__;
			<AcquireArrowAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder<SolarSchoolMapArrowItem>.Create();
			<AcquireArrowAsync>d__.<>4__this = this;
			<AcquireArrowAsync>d__.<>1__state = -1;
			<AcquireArrowAsync>d__.<>t__builder.Start<SolarSchoolMapPanel.<AcquireArrowAsync>d__61>(ref <AcquireArrowAsync>d__);
			return <AcquireArrowAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06038E09 RID: 232969 RVA: 0x00FED2F8 File Offset: 0x00FEB4F8
		private void RefreshHomeButton()
		{
			this.HomeLocationId = 0;
			SolarSchoolGamePlayModel instance = SolarSchoolGamePlayModel.Instance;
			foreach (SolarSchoolLocation solarSchoolLocation in SolarSchoolConfig.Instance.GetLocationList(instance.ActivityId, instance.InstanceId))
			{
				if (solarSchoolLocation.IsHome && instance.MapData.IsLocationAvailable(solarSchoolLocation.Id))
				{
					this.HomeLocationId = solarSchoolLocation.Id;
					break;
				}
			}
			UUIButtonComponent button = base.GetButton(8);
			if (button == null)
			{
				return;
			}
			UUIItem uuiitem = button.RootUIComp.Get();
			if (uuiitem == null)
			{
				return;
			}
			uuiitem.SetUIActive(this.HomeLocationId != 0);
		}

		// Token: 0x06038E0A RID: 232970 RVA: 0x00FED3B4 File Offset: 0x00FEB5B4
		private void OnBtnGoHomeClick()
		{
			if (this.HomeLocationId == 0)
			{
				return;
			}
			this.OnMapItemClicked(this.HomeLocationId);
		}

		// Token: 0x06038E0B RID: 232971 RVA: 0x00FED3CB File Offset: 0x00FEB5CB
		private void OnMapItemClicked(int locationId)
		{
			SolarSchoolGamePlayModel.Instance.OnClickMapLocation(locationId);
		}

		// Token: 0x06038E0C RID: 232972 RVA: 0x00FED3D8 File Offset: 0x00FEB5D8
		private void OnMapItemPointerDown()
		{
			BuildingMapMoveComponent mapMoveComponent = this.MapMoveComponent;
			if (mapMoveComponent == null)
			{
				return;
			}
			mapMoveComponent.EmitPointerDown();
		}

		// Token: 0x06038E0D RID: 232973 RVA: 0x00FED3EA File Offset: 0x00FEB5EA
		private void OnSolarSchoolLocationUnlocked(int locationId)
		{
			SolarSchoolMapTilePanel tilePanel = this.TilePanel;
			if (tilePanel != null)
			{
				tilePanel.RefreshLocations();
			}
			this.RefreshHomeButton();
		}

		// Token: 0x0401DECD RID: 122573
		private const double FOCUS_TWEEN_TIME = 0.5;

		// Token: 0x0401DECE RID: 122574
		private const double RAD_2_DEG = 57.29577951308232;

		// Token: 0x0401DECF RID: 122575
		private const string ANIM_TO_DAY = "ToDay";

		// Token: 0x0401DED0 RID: 122576
		private const string ANIM_TO_DUSK = "ToDusk";

		// Token: 0x0401DED1 RID: 122577
		private const string ANIM_TIPS = "Tips";

		// Token: 0x0401DED2 RID: 122578
		private const string ANIM_UNLOCK = "Unlock";

		// Token: 0x0401DED3 RID: 122579
		private const string EVENT_MAP_ICON = "Sequence_Map_Icon";

		// Token: 0x0401DED4 RID: 122580
		private const string UNLOCK_ANIM_NAME = "Unlock_Icon";

		// Token: 0x0401DED5 RID: 122581
		public const double HomeFocusTweenTime = 0.75;

		// Token: 0x0401DED6 RID: 122582
		[Nullable(2)]
		private SolarSchoolAttrPanel ScorePanel;

		// Token: 0x0401DED7 RID: 122583
		[Nullable(2)]
		private SolarSchoolMapTilePanel TilePanel;

		// Token: 0x0401DED8 RID: 122584
		[Nullable(2)]
		private SolarSchoolQuestInfoItem QuestInfoItem;

		// Token: 0x0401DED9 RID: 122585
		private int HomeLocationId;

		// Token: 0x0401DEDA RID: 122586
		[Nullable(2)]
		private BuildingMapMoveComponent MapMoveComponent;

		// Token: 0x0401DEDB RID: 122587
		[Nullable(2)]
		private string DayTransitionSeqName;

		// Token: 0x0401DEDC RID: 122588
		private int CacheTransitionDayIndex = -1;

		// Token: 0x0401DEDD RID: 122589
		[Nullable(2)]
		private TimerHandle AnimTimer;

		// Token: 0x0401DEDE RID: 122590
		private readonly List<SolarSchoolMapArrowItem> Arrows = new List<SolarSchoolMapArrowItem>();

		// Token: 0x0401DEDF RID: 122591
		[Nullable(2)]
		private CustomPromise<bool> UnlockIconEventPromise;

		// Token: 0x0200B607 RID: 46599
		[NullableContext(0)]
		private class EComponents
		{
			// Token: 0x0403849A RID: 230554
			public const int PnlMapTile = 0;

			// Token: 0x0403849B RID: 230555
			public const int PnlMap = 1;

			// Token: 0x0403849C RID: 230556
			public const int PnlSolarSchoolScore = 2;

			// Token: 0x0403849D RID: 230557
			public const int PnlDayTimeFg = 3;

			// Token: 0x0403849E RID: 230558
			public const int PnlDuskTimeFg = 4;

			// Token: 0x0403849F RID: 230559
			public const int PnlArrowArea = 5;

			// Token: 0x040384A0 RID: 230560
			public const int PnlArrowItem = 6;

			// Token: 0x040384A1 RID: 230561
			public const int QuestInfoItem = 7;

			// Token: 0x040384A2 RID: 230562
			public const int BtnGoHome = 8;
		}
	}
}
