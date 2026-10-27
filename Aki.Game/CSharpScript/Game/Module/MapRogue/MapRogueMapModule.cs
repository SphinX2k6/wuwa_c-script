using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Core.Common;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Activity.ActivityContent.MoonChasing;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.MapRogue
{
	// Token: 0x02005622 RID: 22050
	[NullableContext(1)]
	[Nullable(0)]
	public class MapRogueMapModule : UiPanelBase
	{
		// Token: 0x06038167 RID: 229735 RVA: 0x00D48F4C File Offset: 0x00D4714C
		public MapRogueMapModule(MapRogueGameInfo gameInfo)
		{
			this.GameInfo = gameInfo;
		}

		// Token: 0x06038168 RID: 229736 RVA: 0x00D49068 File Offset: 0x00D47268
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIDraggableComponent)),
				new ValueTuple<int, Type>(1, typeof(UUIItem)),
				new ValueTuple<int, Type>(2, typeof(UUIItem)),
				new ValueTuple<int, Type>(3, typeof(UUIItem)),
				new ValueTuple<int, Type>(4, typeof(UUIItem)),
				new ValueTuple<int, Type>(5, typeof(UUIButtonComponent)),
				new ValueTuple<int, Type>(6, typeof(UUIItem)),
				new ValueTuple<int, Type>(7, typeof(UUIButtonComponent)),
				new ValueTuple<int, Type>(8, typeof(UUIButtonComponent)),
				new ValueTuple<int, Type>(9, typeof(UUISliderComponent)),
				new ValueTuple<int, Type>(10, typeof(UUIButtonComponent)),
				new ValueTuple<int, Type>(11, typeof(UUITexture)),
				new ValueTuple<int, Type>(12, typeof(UUIItem)),
				new ValueTuple<int, Type>(13, typeof(UUIItem)),
				new ValueTuple<int, Type>(14, typeof(UUIItem)),
				new ValueTuple<int, Type>(15, typeof(UUIItem)),
				new ValueTuple<int, Type>(16, typeof(UUIButtonComponent)),
				new ValueTuple<int, Type>(17, typeof(UUIItem)),
				new ValueTuple<int, Type>(18, typeof(UUIItem))
			};
			this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
			{
				new ValueTuple<int, Delegate>(5, new Action(this.OnMaskBtnClick))
			};
		}

		// Token: 0x06038169 RID: 229737 RVA: 0x00D49250 File Offset: 0x00D47450
		protected override UniTask OnBeforeStartAsync()
		{
			MapRogueMapModule.<OnBeforeStartAsync>d__32 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<MapRogueMapModule.<OnBeforeStartAsync>d__32>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603816A RID: 229738 RVA: 0x00D49294 File Offset: 0x00D47494
		private UniTask InitMap()
		{
			MapRogueMapModule.<InitMap>d__33 <InitMap>d__;
			<InitMap>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitMap>d__.<>4__this = this;
			<InitMap>d__.<>1__state = -1;
			<InitMap>d__.<>t__builder.Start<MapRogueMapModule.<InitMap>d__33>(ref <InitMap>d__);
			return <InitMap>d__.<>t__builder.Task;
		}

		// Token: 0x0603816B RID: 229739 RVA: 0x00D492D8 File Offset: 0x00D474D8
		private void InitMoveComponent()
		{
			RogueResInstGrid? insGridConfigByInstId = MapRogueConfig.Instance.GetInsGridConfigByInstId(this.GameInfo.InstanceId);
			if (insGridConfigByInstId == null)
			{
				return;
			}
			UUIDraggableComponent draggable = base.GetDraggable(0);
			draggable.RootUIComp.Get().SetHeight((float)insGridConfigByInstId.Value.MapHeight);
			draggable.RootUIComp.Get().SetWidth((float)insGridConfigByInstId.Value.MapWidth);
			this.MoveComponent = new BuildingMapMoveComponent(base.GetDraggable(0), true, true, true);
			this.RefreshMoveComponent();
			this.MoveComponent.PointerBeginDragExtraCallBack = new Action<ULGUIPointerEventData>(this.OnBeginDrag);
			this.MoveComponent.PointerUpExtraCallBack = new Action<ULGUIPointerEventData>(this.OnEndDrag);
			double num = (double)insGridConfigByInstId.Value.MapScaleMin / 1000.0;
			double num2 = (double)insGridConfigByInstId.Value.MapScaleMax / 1000.0;
			double scale = Math.Max(Math.Min(num2, this.GameInfo.MapScale), num);
			this.MoveComponent.SetScaleSafeArea(num, num2);
			base.SetTextureByPath(insGridConfigByInstId.Value.MapBackground, base.GetTexture(11), null, null);
			this.MoveComponent.SetChangeScaleCallback(new Action<ESetScaleSource>(this.OnChangeScale));
			this.MoveComponent.SetScale(scale, ESetScaleSource.Other, null);
			this.GameInfo.TriggerGuideEventOnFocusStart();
			this.FocusOnGrid(this.GameInfo.PlayerGridIndex, false, null, null);
			this.GameInfo.TriggerGuideEventOnFocusEnd();
		}

		// Token: 0x0603816C RID: 229740 RVA: 0x00D4947C File Offset: 0x00D4767C
		private void RefreshMoveComponent()
		{
			if (Info.Instance.IsInGamepad())
			{
				this.MoveComponent.MoveSpeed = ConfigCommonParamById.GetFloatConfig("MapRogueMapMoveSpeedGamepad").Value;
				return;
			}
			if (Info.Instance.IsInKeyBoard())
			{
				this.MoveComponent.MoveSpeed = ConfigCommonParamById.GetFloatConfig("MapRogueMapMoveSpeedKeyboard").Value;
			}
		}

		// Token: 0x0603816D RID: 229741 RVA: 0x00D494DC File Offset: 0x00D476DC
		public void MapShow()
		{
			this.ResetAllPath();
			this.MoveComponent.BindTouch();
			this.MoveComponent.AddGamepadEvent();
			this.MoveComponent.AddMoveListener(this.GameInfo.CanInteract);
			EventSystem.Instance.Add<EInputControllerType, EInputControllerType>(EEventName.InputControllerChange, new Action<EInputControllerType, EInputControllerType>(this.OnInputControllerChange));
			InputDistributeController.Instance.BindAction("UI左键点击", new TInputHandle<InputDistributeDefine.EActionType>(this.OnInputAction));
		}

		// Token: 0x0603816E RID: 229742 RVA: 0x00D49554 File Offset: 0x00D47754
		public void MapHide()
		{
			this.MoveComponent.UnbindTouch();
			this.MoveComponent.RemoveGamepadEvent();
			this.MoveComponent.RemoveMoveListener();
			EventSystem.Instance.Remove<EInputControllerType, EInputControllerType>(EEventName.InputControllerChange, new Action<EInputControllerType, EInputControllerType>(this.OnInputControllerChange));
			InputDistributeController.Instance.UnBindAction("UI左键点击", new TInputHandle<InputDistributeDefine.EActionType>(this.OnInputAction));
		}

		// Token: 0x0603816F RID: 229743 RVA: 0x00D495BC File Offset: 0x00D477BC
		protected override void OnBeforeDestroy()
		{
			this.GridEventItemMap.Clear();
			this.GridPosItemMap.Clear();
			this.GridFogPosItemMap.Clear();
			this.MoveComponent.Destroy();
			LongPressButton scaleUp = this.ScaleUp;
			if (scaleUp != null)
			{
				scaleUp.OnDestroy();
			}
			LongPressButton scaleDown = this.ScaleDown;
			if (scaleDown != null)
			{
				scaleDown.OnDestroy();
			}
			this.CancelSingleClickTimer();
		}

		// Token: 0x06038170 RID: 229744 RVA: 0x00D49620 File Offset: 0x00D47820
		public UniTask PlaySequence(string seqName)
		{
			MapRogueMapModule.<PlaySequence>d__39 <PlaySequence>d__;
			<PlaySequence>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<PlaySequence>d__.<>4__this = this;
			<PlaySequence>d__.seqName = seqName;
			<PlaySequence>d__.<>1__state = -1;
			<PlaySequence>d__.<>t__builder.Start<MapRogueMapModule.<PlaySequence>d__39>(ref <PlaySequence>d__);
			return <PlaySequence>d__.<>t__builder.Task;
		}

		// Token: 0x06038171 RID: 229745 RVA: 0x00D4966B File Offset: 0x00D4786B
		public void OnTick(float delta)
		{
			MapRoguePanelRole rolePanel = this.RolePanel;
			if (rolePanel != null)
			{
				rolePanel.OnTick(delta);
			}
			this.MoveComponent.TickMove();
			this.TickPendingList(delta);
		}

		// Token: 0x06038172 RID: 229746 RVA: 0x00D49694 File Offset: 0x00D47894
		private bool IsMapMoveOffsetDiff()
		{
			Vector2D b = Vector2D.Create(this.MoveComponent.GetMapItem().GetAnchorOffset());
			return !this.MapTempPos.Equals(b, (double)this.ClickTolerance);
		}

		// Token: 0x06038173 RID: 229747 RVA: 0x00D496D4 File Offset: 0x00D478D4
		private void SetAnchorOffset(int id, UUIItem item)
		{
			ValueTuple<double, double> gridAnchorOffset = this.GetGridAnchorOffset(id, null);
			double item2 = gridAnchorOffset.Item1;
			double item3 = gridAnchorOffset.Item2;
			this.PosTempVector.Set(item2, item3);
			item.SetAnchorOffset(this.PosTempVector.ToUeVector2D(false));
		}

		// Token: 0x06038174 RID: 229748 RVA: 0x00D49718 File Offset: 0x00D47918
		[NullableContext(0)]
		[return: TupleElementNames(new string[]
		{
			"X",
			"Y"
		})]
		private ValueTuple<double, double> GetGridAnchorOffset(int id, [Nullable(2)] IPos center = null)
		{
			if (center == null)
			{
				center = this.GameInfo.Center;
			}
			MapRogueMapPoint gridPos = this.GameInfo.GetGridPos(id);
			int y = gridPos.Y;
			int x = gridPos.X;
			int num = y - center.Y;
			int num2 = x - center.X;
			double item = 110.0 * (double)(num2 + num);
			double item2 = -64.0 * (double)(num - num2);
			return new ValueTuple<double, double>(item, item2);
		}

		// Token: 0x06038175 RID: 229749 RVA: 0x00D49784 File Offset: 0x00D47984
		private double GetGridCreatePriority(int gridIndex)
		{
			MapRogueMapPoint gridPos = this.GameInfo.GetGridPos(this.GameInfo.PlayerGridIndex);
			ValueTuple<double, double> gridAnchorOffset = this.GetGridAnchorOffset(gridIndex, gridPos);
			double item = gridAnchorOffset.Item1;
			double item2 = gridAnchorOffset.Item2;
			ValueTuple<double, double> offsetDisRelativeToViewportCenterRatio = this.MoveComponent.GetOffsetDisRelativeToViewportCenterRatio(item, item2);
			double item3 = offsetDisRelativeToViewportCenterRatio.Item1;
			double item4 = offsetDisRelativeToViewportCenterRatio.Item2;
			if (item3 <= 1.2999999523162842 && item4 <= 1.2999999523162842)
			{
				return 0.0;
			}
			return item3 + item4;
		}

		// Token: 0x06038176 RID: 229750 RVA: 0x00D497FF File Offset: 0x00D479FF
		private void OnInputControllerChange(EInputControllerType last, EInputControllerType now)
		{
			this.RefreshMoveComponent();
		}

		// Token: 0x06038177 RID: 229751 RVA: 0x00D49808 File Offset: 0x00D47A08
		[NullableContext(2)]
		public void FocusOnGrid(int gridId, bool needTween = true, Action callback = null, float? focusTweenTime = null)
		{
			ValueTuple<double, double> gridAnchorOffset = this.GetGridAnchorOffset(gridId, null);
			double item = gridAnchorOffset.Item1;
			double item2 = gridAnchorOffset.Item2;
			double num;
			if (!needTween)
			{
				num = 0.0;
			}
			else
			{
				float? num2 = focusTweenTime;
				num = ((num2 != null) ? ((double)num2.GetValueOrDefault()) : this.FocusTweenTime);
			}
			double tweenTime = num;
			this.MoveComponent.MoveToTarget(new double[]
			{
				item,
				item2
			}, LTweenEase.InOutSine, tweenTime, callback);
		}

		// Token: 0x06038178 RID: 229752 RVA: 0x00D49874 File Offset: 0x00D47A74
		public void SetInteractAvailable(bool bAvailable)
		{
			base.GetButton(5).RootUIComp.Get().SetUIActive(!bAvailable);
			this.MoveComponent.SwitchOnMove(bAvailable);
		}

		// Token: 0x06038179 RID: 229753 RVA: 0x00D498AC File Offset: 0x00D47AAC
		public void SetInteractState(bool move, bool check, int? gridIndex = null)
		{
			this.CanMove = move;
			this.CanCheck = check;
			if (gridIndex != null)
			{
				this.SetAnchorOffset(gridIndex.Value, base.GetItem(12));
			}
			base.GetItem(13).SetUIActive(move);
			base.GetItem(14).SetUIActive(check);
			base.GetItem(12).SetUIActive((move || check) && !this.MoveComponent.IsInDrag);
		}

		// Token: 0x0603817A RID: 229754 RVA: 0x00D49924 File Offset: 0x00D47B24
		protected void TickPendingList(float delta)
		{
			if (!this.InCreating)
			{
				return;
			}
			this.CreateDeltaTime += delta;
			if (this.CreateDeltaTime < 100f)
			{
				return;
			}
			this.CreateDeltaTime = 0f;
			UiAsyncTask task = new UiAsyncTask("MapRogueMapModule.TickPendingList", delegate()
			{
				MapRogueMapModule.<<TickPendingList>b__54_0>d <<TickPendingList>b__54_0>d;
				<<TickPendingList>b__54_0>d.<>t__builder = AsyncUniTaskMethodBuilder.Create();
				<<TickPendingList>b__54_0>d.<>4__this = this;
				<<TickPendingList>b__54_0>d.<>1__state = -1;
				<<TickPendingList>b__54_0>d.<>t__builder.Start<MapRogueMapModule.<<TickPendingList>b__54_0>d>(ref <<TickPendingList>b__54_0>d);
				return <<TickPendingList>b__54_0>d.<>t__builder.Task;
			}, null);
			base.RunAsyncTask(task);
		}

		// Token: 0x0603817B RID: 229755 RVA: 0x00D49984 File Offset: 0x00D47B84
		private UniTask HandleCreatePending()
		{
			MapRogueMapModule.<HandleCreatePending>d__55 <HandleCreatePending>d__;
			<HandleCreatePending>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<HandleCreatePending>d__.<>4__this = this;
			<HandleCreatePending>d__.<>1__state = -1;
			<HandleCreatePending>d__.<>t__builder.Start<MapRogueMapModule.<HandleCreatePending>d__55>(ref <HandleCreatePending>d__);
			return <HandleCreatePending>d__.<>t__builder.Task;
		}

		// Token: 0x0603817C RID: 229756 RVA: 0x00D499C8 File Offset: 0x00D47BC8
		private void CheckViewLoadDone()
		{
			if (this.InCreating)
			{
				this.GameInfo.SetTipsItemProxy(true, "RogueRes_Map_Loading");
				return;
			}
			this.GameInfo.SetInteractAvailable(EMapForbiddenTag.GridCreate, true);
			CustomPromise viewLoadPromise = this.GameInfo.ViewLoadPromise;
			if (viewLoadPromise != null)
			{
				viewLoadPromise.SetResult();
			}
			this.GameInfo.SetTipsItemProxy(false, null);
		}

		// Token: 0x0603817D RID: 229757 RVA: 0x00D49A20 File Offset: 0x00D47C20
		private UniTask HandlePendingItem(IGridCreateInfo info)
		{
			MapRogueMapModule.<HandlePendingItem>d__57 <HandlePendingItem>d__;
			<HandlePendingItem>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<HandlePendingItem>d__.<>4__this = this;
			<HandlePendingItem>d__.info = info;
			<HandlePendingItem>d__.<>1__state = -1;
			<HandlePendingItem>d__.<>t__builder.Start<MapRogueMapModule.<HandlePendingItem>d__57>(ref <HandlePendingItem>d__);
			return <HandlePendingItem>d__.<>t__builder.Task;
		}

		// Token: 0x0603817E RID: 229758 RVA: 0x00D49A6C File Offset: 0x00D47C6C
		[return: Nullable(new byte[]
		{
			0,
			2
		})]
		protected UniTask<UiPoolActor> GetActor(string uiPath, [Nullable(2)] UUIItem parent = null)
		{
			MapRogueMapModule.<GetActor>d__58 <GetActor>d__;
			<GetActor>d__.<>t__builder = AsyncUniTaskMethodBuilder<UiPoolActor>.Create();
			<GetActor>d__.<>4__this = this;
			<GetActor>d__.uiPath = uiPath;
			<GetActor>d__.parent = parent;
			<GetActor>d__.<>1__state = -1;
			<GetActor>d__.<>t__builder.Start<MapRogueMapModule.<GetActor>d__58>(ref <GetActor>d__);
			return <GetActor>d__.<>t__builder.Task;
		}

		// Token: 0x0603817F RID: 229759 RVA: 0x00D49AC0 File Offset: 0x00D47CC0
		public void RecycleAllActor()
		{
			foreach (UiPoolActor uiPoolActor in this.UiPoolActorHandle)
			{
				this.RecycleActor(uiPoolActor);
			}
			this.UiPoolActorHandle.Clear();
		}

		// Token: 0x06038180 RID: 229760 RVA: 0x00D49B20 File Offset: 0x00D47D20
		protected void RecycleActor(UiPoolActor uiPoolActor)
		{
			if (this.GameInfo == null)
			{
				return;
			}
			if (this.GameInfo.ActorPool != null && !this.GameInfo.IsEnd)
			{
				this.GameInfo.ActorPool.RecycleAsync(uiPoolActor, uiPoolActor.Path);
			}
		}

		// Token: 0x06038181 RID: 229761 RVA: 0x00D49B5C File Offset: 0x00D47D5C
		private UUIItem CreateMapGridPosItem(UUIItem rootItem, UUIItem parentItem, MapGridData data)
		{
			UUIItem uuiitem = LguiUtil.Instance.CopyItem(rootItem, parentItem);
			this.SetAnchorOffset(data.GridIndex, uuiitem);
			uuiitem.SetUIActive(true);
			return uuiitem;
		}

		// Token: 0x06038182 RID: 229762 RVA: 0x00D49B8C File Offset: 0x00D47D8C
		protected UniTask CreateMapGridBg(MapGridData data)
		{
			MapRogueMapModule.<CreateMapGridBg>d__68 <CreateMapGridBg>d__;
			<CreateMapGridBg>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<CreateMapGridBg>d__.<>4__this = this;
			<CreateMapGridBg>d__.data = data;
			<CreateMapGridBg>d__.<>1__state = -1;
			<CreateMapGridBg>d__.<>t__builder.Start<MapRogueMapModule.<CreateMapGridBg>d__68>(ref <CreateMapGridBg>d__);
			return <CreateMapGridBg>d__.<>t__builder.Task;
		}

		// Token: 0x06038183 RID: 229763 RVA: 0x00D49BD8 File Offset: 0x00D47DD8
		protected UniTask CreateMapGridFog(int gridIndex)
		{
			MapRogueMapModule.<CreateMapGridFog>d__69 <CreateMapGridFog>d__;
			<CreateMapGridFog>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<CreateMapGridFog>d__.<>4__this = this;
			<CreateMapGridFog>d__.gridIndex = gridIndex;
			<CreateMapGridFog>d__.<>1__state = -1;
			<CreateMapGridFog>d__.<>t__builder.Start<MapRogueMapModule.<CreateMapGridFog>d__69>(ref <CreateMapGridFog>d__);
			return <CreateMapGridFog>d__.<>t__builder.Task;
		}

		// Token: 0x06038184 RID: 229764 RVA: 0x00D49C24 File Offset: 0x00D47E24
		protected UniTask RefreshMapGridFogVision(int gridIndex, bool bHasVision)
		{
			MapRogueMapModule.<RefreshMapGridFogVision>d__70 <RefreshMapGridFogVision>d__;
			<RefreshMapGridFogVision>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<RefreshMapGridFogVision>d__.<>4__this = this;
			<RefreshMapGridFogVision>d__.gridIndex = gridIndex;
			<RefreshMapGridFogVision>d__.bHasVision = bHasVision;
			<RefreshMapGridFogVision>d__.<>1__state = -1;
			<RefreshMapGridFogVision>d__.<>t__builder.Start<MapRogueMapModule.<RefreshMapGridFogVision>d__70>(ref <RefreshMapGridFogVision>d__);
			return <RefreshMapGridFogVision>d__.<>t__builder.Task;
		}

		// Token: 0x06038185 RID: 229765 RVA: 0x00D49C78 File Offset: 0x00D47E78
		public void RefreshMapGrid(MapGridData data)
		{
			MapRogueMapModule.<>c__DisplayClass71_0 CS$<>8__locals1 = new MapRogueMapModule.<>c__DisplayClass71_0();
			CS$<>8__locals1.<>4__this = this;
			CS$<>8__locals1.data = data;
			MapRogueGrid mapRogueGrid = null;
			this.GridItemMap.TryGetValue(CS$<>8__locals1.data.GridIndex, out mapRogueGrid);
			mapRogueGrid.Refresh(CS$<>8__locals1.data);
			UiAsyncTask task = new UiAsyncTask("MapRogueMapModule.RefreshMapGridTask", delegate()
			{
				MapRogueMapModule.<>c__DisplayClass71_0.<<RefreshMapGrid>b__0>d <<RefreshMapGrid>b__0>d;
				<<RefreshMapGrid>b__0>d.<>t__builder = AsyncUniTaskMethodBuilder.Create();
				<<RefreshMapGrid>b__0>d.<>4__this = CS$<>8__locals1;
				<<RefreshMapGrid>b__0>d.<>1__state = -1;
				<<RefreshMapGrid>b__0>d.<>t__builder.Start<MapRogueMapModule.<>c__DisplayClass71_0.<<RefreshMapGrid>b__0>d>(ref <<RefreshMapGrid>b__0>d);
				return <<RefreshMapGrid>b__0>d.<>t__builder.Task;
			}, null);
			base.RunAsyncTask(task);
		}

		// Token: 0x06038186 RID: 229766 RVA: 0x00D49CE0 File Offset: 0x00D47EE0
		public void SetMapGridBgVision(int gridIndex, bool bHasVision)
		{
			MapRogueMapModule.<>c__DisplayClass72_0 CS$<>8__locals1 = new MapRogueMapModule.<>c__DisplayClass72_0();
			CS$<>8__locals1.<>4__this = this;
			CS$<>8__locals1.gridIndex = gridIndex;
			CS$<>8__locals1.bHasVision = bHasVision;
			UiAsyncTask task = new UiAsyncTask("MapRogueMapModule.SetMapGridBgVision", delegate()
			{
				MapRogueMapModule.<>c__DisplayClass72_0.<<SetMapGridBgVision>b__0>d <<SetMapGridBgVision>b__0>d;
				<<SetMapGridBgVision>b__0>d.<>t__builder = AsyncUniTaskMethodBuilder.Create();
				<<SetMapGridBgVision>b__0>d.<>4__this = CS$<>8__locals1;
				<<SetMapGridBgVision>b__0>d.<>1__state = -1;
				<<SetMapGridBgVision>b__0>d.<>t__builder.Start<MapRogueMapModule.<>c__DisplayClass72_0.<<SetMapGridBgVision>b__0>d>(ref <<SetMapGridBgVision>b__0>d);
				return <<SetMapGridBgVision>b__0>d.<>t__builder.Task;
			}, null);
			base.RunAsyncTask(task);
		}

		// Token: 0x06038187 RID: 229767 RVA: 0x00D49D28 File Offset: 0x00D47F28
		public void SetMapGridBgState(int gridIndex, bool bSelectOn, bool? bFireEvent = null)
		{
			MapRogueGrid mapRogueGrid = null;
			this.GridItemMap.TryGetValue(gridIndex, out mapRogueGrid);
			if (mapRogueGrid != null)
			{
				mapRogueGrid.SetGridToggleState(bSelectOn, bFireEvent.GetValueOrDefault());
			}
		}

		// Token: 0x06038188 RID: 229768 RVA: 0x00D49D58 File Offset: 0x00D47F58
		public void SetMapGridMoveEnable(int gridIndex, bool bEnable)
		{
			MapRogueGrid mapRogueGrid = null;
			this.GridItemMap.TryGetValue(gridIndex, out mapRogueGrid);
			if (mapRogueGrid != null)
			{
				mapRogueGrid.SetToggleMoveEnable(bEnable);
			}
		}

		// Token: 0x06038189 RID: 229769 RVA: 0x00D49D80 File Offset: 0x00D47F80
		public void SetPerspectiveMode(int gridIndex, bool bOn)
		{
			if (this.MoveComponent.IsInDrag)
			{
				return;
			}
			MapRogueGrid mapRogueGrid = null;
			this.GridItemMap.TryGetValue(gridIndex, out mapRogueGrid);
			if (mapRogueGrid != null)
			{
				mapRogueGrid.SetPerspectiveMode(bOn);
			}
		}

		// Token: 0x0603818A RID: 229770 RVA: 0x00D49DB8 File Offset: 0x00D47FB8
		[NullableContext(2)]
		public IGridRangeInfo GetGridRangeInfo(int gridIndex)
		{
			MapRogueGrid mapRogueGrid = null;
			this.GridItemMap.TryGetValue(gridIndex, out mapRogueGrid);
			if (mapRogueGrid == null)
			{
				return null;
			}
			FVector lguispaceAbsolutePosition = mapRogueGrid.GetOriginalItem().GetLGUISpaceAbsolutePosition();
			double num = (double)MapRogueConfig.Instance.GetGlobalParamConfig().Value.GridValidRangeTolerance / 1000.0 * this.MoveComponent.MapScale;
			return new GridRangeInfo
			{
				CenterX = (double)lguispaceAbsolutePosition.X,
				CenterY = (double)lguispaceAbsolutePosition.Y + 16.0 * this.MoveComponent.MapScale,
				RadiusX = 110.0 * this.MoveComponent.MapScale + num,
				RadiusY = 62.0 * this.MoveComponent.MapScale + num
			};
		}

		// Token: 0x1700872C RID: 34604
		// (get) Token: 0x0603818B RID: 229771 RVA: 0x00D49E89 File Offset: 0x00D48089
		private bool NeedDoubleClick
		{
			get
			{
				return Info.Instance.IsInKeyBoard();
			}
		}

		// Token: 0x1700872D RID: 34605
		// (get) Token: 0x0603818C RID: 229772 RVA: 0x00D49E95 File Offset: 0x00D48095
		private bool InClick
		{
			get
			{
				return this.InClickGridId >= 0;
			}
		}

		// Token: 0x0603818D RID: 229773 RVA: 0x00D49EA3 File Offset: 0x00D480A3
		private void OnMaskBtnClick()
		{
		}

		// Token: 0x0603818E RID: 229774 RVA: 0x00D49EA5 File Offset: 0x00D480A5
		private void CancelSingleClickTimer()
		{
			if (this.SingleClickTimerHandle != null && TimerSystem.GameplayTimeInstance.Has(this.SingleClickTimerHandle))
			{
				TimerSystem.GameplayTimeInstance.Remove(this.SingleClickTimerHandle);
			}
			this.SingleClickTimerHandle = null;
			this.InClickGridId = -1;
		}

		// Token: 0x0603818F RID: 229775 RVA: 0x00D49EE0 File Offset: 0x00D480E0
		private void OnInputAction(string name, InputDistributeDefine.EActionType actionType, InputIdentification inputIdentification)
		{
			if (!this.NeedDoubleClick)
			{
				return;
			}
			if (!this.GameInfo.IsStageAvailable)
			{
				return;
			}
			if (actionType != InputDistributeDefine.EActionType.Press)
			{
				this.IsClickUp = true;
				return;
			}
			if (!this.InClick)
			{
				this.CancelSingleClickTimer();
				this.InClickGridId = this.GameInfo.CurHoverIndex;
				this.IsClickUp = false;
				this.SingleClickTimerHandle = TimerSystem.GameplayTimeInstance.Delay(delegate(float _)
				{
					if (this.InClick)
					{
						if (this.IsClickUp)
						{
							this.SetMapGridBgState(this.InClickGridId, true, new bool?(true));
						}
						this.SingleClickTimerHandle = null;
						this.InClickGridId = -1;
					}
				}, (float)this.DoubleClickIntervalTime, null, null, true, 1f);
				return;
			}
			if (this.CanMove)
			{
				this.GameInfo.OnMove(new int?(this.InClickGridId));
			}
			this.CancelSingleClickTimer();
		}

		// Token: 0x06038190 RID: 229776 RVA: 0x00D49F88 File Offset: 0x00D48188
		private bool OnGridBgExtendToggleCanExecute(EToggleState state, MapGridData data)
		{
			if (this.InClick)
			{
				return false;
			}
			if (this.IsMapMoveOffsetDiff())
			{
				return false;
			}
			if (this.GameInfo.CurHoverIndex != data.GridIndex)
			{
				this.GameInfo.HoverOnTarget(data.GridIndex, true);
			}
			return state == EToggleState.ETT_UnChecked && this.CanCheck;
		}

		// Token: 0x06038191 RID: 229777 RVA: 0x00D49FD9 File Offset: 0x00D481D9
		private void OnGridBgPointerDown(EToggleState state, MapGridData data)
		{
			this.MapTempPos.FromUeVector2D(this.MoveComponent.GetMapItem().GetAnchorOffset());
			this.MoveComponent.EmitPointerDown();
		}

		// Token: 0x06038192 RID: 229778 RVA: 0x00D4A006 File Offset: 0x00D48206
		private void OnGridBgExtendToggleStateChanged(EToggleState state, MapGridData data)
		{
			this.GameInfo.OnCheck(data.GridIndex);
		}

		// Token: 0x06038193 RID: 229779 RVA: 0x00D4A01C File Offset: 0x00D4821C
		private void OnGridBgHover(MapGridData data)
		{
			this.SetSelectPanel(data);
			if (this.InClick)
			{
				this.CancelSingleClickTimer();
			}
			if (this.MoveComponent.IsInDrag)
			{
				return;
			}
			this.GameInfo.HoverOnTarget(data.GridIndex, !Info.Instance.IsInTouch());
		}

		// Token: 0x06038194 RID: 229780 RVA: 0x00D4A06A File Offset: 0x00D4826A
		private void OnGridBgUnHover(MapGridData data)
		{
			if (Info.Instance.IsInTouch())
			{
				return;
			}
			this.GameInfo.UnHoverOnTarget(data.GridIndex);
		}

		// Token: 0x06038195 RID: 229781 RVA: 0x00D4A08A File Offset: 0x00D4828A
		private void OnBackPlaneEnter()
		{
			if (this.InClick)
			{
				this.CancelSingleClickTimer();
			}
			this.GameInfo.BlankPlaneEnter();
		}

		// Token: 0x06038196 RID: 229782 RVA: 0x00D4A0A5 File Offset: 0x00D482A5
		private void OnBackPlanePointerDown()
		{
			this.MoveComponent.EmitPointerDown();
		}

		// Token: 0x06038197 RID: 229783 RVA: 0x00D4A0B4 File Offset: 0x00D482B4
		private void OnBeginDrag(ULGUIPointerEventData _)
		{
			base.GetButton(16).RootUIComp.Get().SetUIActive(true);
			base.GetItem(12).SetUIActive(false);
		}

		// Token: 0x06038198 RID: 229784 RVA: 0x00D4A0EC File Offset: 0x00D482EC
		private void OnEndDrag(ULGUIPointerEventData _)
		{
			base.GetButton(16).RootUIComp.Get().SetUIActive(false);
			this.SetInteractState(this.CanMove, this.CanCheck, new int?(this.GameInfo.CurHoverIndex));
		}

		// Token: 0x06038199 RID: 229785 RVA: 0x00D4A138 File Offset: 0x00D48338
		protected UniTask CreateMapGridEvent(MapGridData data, bool bHasVision = true)
		{
			MapRogueMapModule.<CreateMapGridEvent>d__93 <CreateMapGridEvent>d__;
			<CreateMapGridEvent>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<CreateMapGridEvent>d__.<>4__this = this;
			<CreateMapGridEvent>d__.data = data;
			<CreateMapGridEvent>d__.bHasVision = bHasVision;
			<CreateMapGridEvent>d__.<>1__state = -1;
			<CreateMapGridEvent>d__.<>t__builder.Start<MapRogueMapModule.<CreateMapGridEvent>d__93>(ref <CreateMapGridEvent>d__);
			return <CreateMapGridEvent>d__.<>t__builder.Task;
		}

		// Token: 0x0603819A RID: 229786 RVA: 0x00D4A18C File Offset: 0x00D4838C
		protected UniTask RefreshMapGridEventVision(MapGridData data, bool bHasVision)
		{
			MapRogueMapModule.<RefreshMapGridEventVision>d__94 <RefreshMapGridEventVision>d__;
			<RefreshMapGridEventVision>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<RefreshMapGridEventVision>d__.<>4__this = this;
			<RefreshMapGridEventVision>d__.data = data;
			<RefreshMapGridEventVision>d__.bHasVision = bHasVision;
			<RefreshMapGridEventVision>d__.<>1__state = -1;
			<RefreshMapGridEventVision>d__.<>t__builder.Start<MapRogueMapModule.<RefreshMapGridEventVision>d__94>(ref <RefreshMapGridEventVision>d__);
			return <RefreshMapGridEventVision>d__.<>t__builder.Task;
		}

		// Token: 0x0603819B RID: 229787 RVA: 0x00D4A1E0 File Offset: 0x00D483E0
		public void RefreshAllEventLv()
		{
			foreach (MapRogueGridEvent mapRogueGridEvent in this.GridEventItemMap.Values)
			{
				mapRogueGridEvent.RefreshLv(true);
			}
		}

		// Token: 0x0603819C RID: 229788 RVA: 0x00D4A238 File Offset: 0x00D48438
		public void CreateAllMapGridPath(List<int> lastGridIdList, List<int> gridIdList)
		{
			MapRogueMapModule.<>c__DisplayClass96_0 CS$<>8__locals1 = new MapRogueMapModule.<>c__DisplayClass96_0();
			CS$<>8__locals1.<>4__this = this;
			CS$<>8__locals1.lastGridIdList = lastGridIdList;
			CS$<>8__locals1.gridIdList = gridIdList;
			UiAsyncTask task = new UiAsyncTask("MapRogueMapModule.CreateAllMapGridPath", delegate()
			{
				MapRogueMapModule.<>c__DisplayClass96_0.<<CreateAllMapGridPath>b__0>d <<CreateAllMapGridPath>b__0>d;
				<<CreateAllMapGridPath>b__0>d.<>t__builder = AsyncUniTaskMethodBuilder.Create();
				<<CreateAllMapGridPath>b__0>d.<>4__this = CS$<>8__locals1;
				<<CreateAllMapGridPath>b__0>d.<>1__state = -1;
				<<CreateAllMapGridPath>b__0>d.<>t__builder.Start<MapRogueMapModule.<>c__DisplayClass96_0.<<CreateAllMapGridPath>b__0>d>(ref <<CreateAllMapGridPath>b__0>d);
				return <<CreateAllMapGridPath>b__0>d.<>t__builder.Task;
			}, null);
			base.RunAsyncTask(task);
		}

		// Token: 0x0603819D RID: 229789 RVA: 0x00D4A280 File Offset: 0x00D48480
		public UniTask CreateAllMapGridPathAsync(List<int> lastGridIdList, List<int> gridIdList)
		{
			MapRogueMapModule.<CreateAllMapGridPathAsync>d__97 <CreateAllMapGridPathAsync>d__;
			<CreateAllMapGridPathAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<CreateAllMapGridPathAsync>d__.<>4__this = this;
			<CreateAllMapGridPathAsync>d__.lastGridIdList = lastGridIdList;
			<CreateAllMapGridPathAsync>d__.gridIdList = gridIdList;
			<CreateAllMapGridPathAsync>d__.<>1__state = -1;
			<CreateAllMapGridPathAsync>d__.<>t__builder.Start<MapRogueMapModule.<CreateAllMapGridPathAsync>d__97>(ref <CreateAllMapGridPathAsync>d__);
			return <CreateAllMapGridPathAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603819E RID: 229790 RVA: 0x00D4A2D4 File Offset: 0x00D484D4
		protected UniTask CreateMapGridPath(int gridId, EShapeType shape, bool isLast, bool isCreate)
		{
			MapRogueMapModule.<CreateMapGridPath>d__98 <CreateMapGridPath>d__;
			<CreateMapGridPath>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<CreateMapGridPath>d__.<>4__this = this;
			<CreateMapGridPath>d__.gridId = gridId;
			<CreateMapGridPath>d__.shape = shape;
			<CreateMapGridPath>d__.isLast = isLast;
			<CreateMapGridPath>d__.isCreate = isCreate;
			<CreateMapGridPath>d__.<>1__state = -1;
			<CreateMapGridPath>d__.<>t__builder.Start<MapRogueMapModule.<CreateMapGridPath>d__98>(ref <CreateMapGridPath>d__);
			return <CreateMapGridPath>d__.<>t__builder.Task;
		}

		// Token: 0x0603819F RID: 229791 RVA: 0x00D4A338 File Offset: 0x00D48538
		protected EShapeType GetShapeType(int curId, int preId, int nextId)
		{
			EShapeType eshapeType = (EShapeType)MapRogueMapModule.<GetShapeType>g__directionFunc|99_0(curId, preId);
			int num = (int)MapRogueMapModule.<GetShapeType>g__directionFunc|99_0(curId, nextId);
			return eshapeType * (EShapeType)10 + num;
		}

		// Token: 0x060381A0 RID: 229792 RVA: 0x00D4A35C File Offset: 0x00D4855C
		public void ResetPath(int index)
		{
			MapRogueGridPath mapRogueGridPath = null;
			this.GridPathItemMap.TryGetValue(index, out mapRogueGridPath);
			if (mapRogueGridPath == null)
			{
				return;
			}
			mapRogueGridPath.SetUiActive(false);
			this.CachedPathItemList.Add(mapRogueGridPath);
			this.GridPathItemMap.Remove(index);
		}

		// Token: 0x060381A1 RID: 229793 RVA: 0x00D4A3A0 File Offset: 0x00D485A0
		public void ResetAllPath()
		{
			foreach (MapRogueGridPath mapRogueGridPath in this.GridPathItemMap.Values)
			{
				mapRogueGridPath.SetUiActive(false);
				this.CachedPathItemList.Add(mapRogueGridPath);
			}
			this.GridPathItemMap.Clear();
		}

		// Token: 0x060381A2 RID: 229794 RVA: 0x00D4A410 File Offset: 0x00D48610
		private UniTask InitRole()
		{
			MapRogueMapModule.<InitRole>d__102 <InitRole>d__;
			<InitRole>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitRole>d__.<>4__this = this;
			<InitRole>d__.<>1__state = -1;
			<InitRole>d__.<>t__builder.Start<MapRogueMapModule.<InitRole>d__102>(ref <InitRole>d__);
			return <InitRole>d__.<>t__builder.Task;
		}

		// Token: 0x060381A3 RID: 229795 RVA: 0x00D4A454 File Offset: 0x00D48654
		public void SetRolePos(int gridId)
		{
			UUIItem item = base.GetItem(4);
			this.SetAnchorOffset(gridId, item);
		}

		// Token: 0x060381A4 RID: 229796 RVA: 0x00D4A474 File Offset: 0x00D48674
		public void SetRolePosByGrid(float progress, int lastGridId, int curGridId)
		{
			UUIItem item = base.GetItem(4);
			ValueTuple<double, double> gridAnchorOffset = this.GetGridAnchorOffset(lastGridId, null);
			double item2 = gridAnchorOffset.Item1;
			double item3 = gridAnchorOffset.Item2;
			ValueTuple<double, double> gridAnchorOffset2 = this.GetGridAnchorOffset(curGridId, null);
			double item4 = gridAnchorOffset2.Item1;
			double item5 = gridAnchorOffset2.Item2;
			double inX = MathUtils.Instance.Lerp(item2, item4, (double)progress);
			double inY = MathUtils.Instance.Lerp(item3, item5, (double)progress);
			this.PosTempVector.Set(inX, inY);
			item.SetAnchorOffset(this.PosTempVector.ToUeVector2D(false));
		}

		// Token: 0x060381A5 RID: 229797 RVA: 0x00D4A4F4 File Offset: 0x00D486F4
		private void InitScaleSlider()
		{
			UUISliderComponent slider = base.GetSlider(9);
			slider.SetMinValue((float)this.MoveComponent.MapScaleSafeArea.Min, false, false);
			slider.SetMaxValue((float)this.MoveComponent.MapScaleSafeArea.Max, false, false);
			slider.SetValue((float)this.MoveComponent.MapScale, true);
			slider.OnValueChangeCb.Bind(new Action<float>(this.OnSliderValueChange));
			this.ScaleUp = new LongPressButton(base.GetButton(7), new Action<float>(this.OnScaleUp), 100);
			this.ScaleDown = new LongPressButton(base.GetButton(8), new Action<float>(this.OnScaleDown), 100);
		}

		// Token: 0x060381A6 RID: 229798 RVA: 0x00D4A5A4 File Offset: 0x00D487A4
		private void OnScaleDown(float _)
		{
			this.MoveComponent.LongPressScroll((float)(-(float)this.MoveComponent.ScaleStep));
		}

		// Token: 0x060381A7 RID: 229799 RVA: 0x00D4A5BE File Offset: 0x00D487BE
		private void OnScaleUp(float _)
		{
			this.MoveComponent.LongPressScroll((float)this.MoveComponent.ScaleStep);
		}

		// Token: 0x060381A8 RID: 229800 RVA: 0x00D4A5D7 File Offset: 0x00D487D7
		private void OnSliderValueChange(float value)
		{
			this.MoveComponent.SliderScroll(value);
		}

		// Token: 0x060381A9 RID: 229801 RVA: 0x00D4A5E8 File Offset: 0x00D487E8
		private void OnChangeScale(ESetScaleSource source)
		{
			this.GameInfo.MapScale = this.MoveComponent.MapScale;
			UUISliderComponent slider = base.GetSlider(9);
			if (source != ESetScaleSource.Slider)
			{
				slider.SetValue((float)this.MoveComponent.MapScale, false);
			}
			double min = this.MoveComponent.MapScaleSafeArea.Min;
			double max = this.MoveComponent.MapScaleSafeArea.Max;
			double alpha = (this.MoveComponent.MapScale - min) / (max - min);
			double num = MathUtils.Instance.Lerp(1.0, 1.2999999523162842, alpha);
			this.MapTempScaleVector.Set(num, num, num);
			base.GetTexture(11).SetUIItemScale(this.MapTempScaleVector.ToUeVectorOld());
			double num2 = 1.0 / this.MoveComponent.MapScale;
			this.MapTempScaleVector.Set(num2, num2, num2);
			base.GetItem(12).SetUIItemScale(this.MapTempScaleVector.ToUeVectorOld());
			if (this.RolePanel != null)
			{
				this.RolePanel.SetListRootItem(this.MapTempScaleVector);
			}
		}

		// Token: 0x060381AA RID: 229802 RVA: 0x00D4A700 File Offset: 0x00D48900
		private UniTask InitSelectPanel()
		{
			MapRogueMapModule.<InitSelectPanel>d__115 <InitSelectPanel>d__;
			<InitSelectPanel>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitSelectPanel>d__.<>4__this = this;
			<InitSelectPanel>d__.<>1__state = -1;
			<InitSelectPanel>d__.<>t__builder.Start<MapRogueMapModule.<InitSelectPanel>d__115>(ref <InitSelectPanel>d__);
			return <InitSelectPanel>d__.<>t__builder.Task;
		}

		// Token: 0x060381AB RID: 229803 RVA: 0x00D4A744 File Offset: 0x00D48944
		protected void SetSelectPanel(MapGridData gridData)
		{
			int gridIndex = gridData.GridIndex;
			if (this.CachedSelectPanelList.Count <= this.LatestSelectPanelIndex)
			{
				return;
			}
			MapRogueGrid mapRogueGrid = null;
			this.GridItemMap.TryGetValue(gridIndex, out mapRogueGrid);
			if (mapRogueGrid == null)
			{
				return;
			}
			if (mapRogueGrid.SelectPanel.Count > 0)
			{
				return;
			}
			if (!gridData.Walkable)
			{
				return;
			}
			ValueTuple<MapRogueGridSelectBase, MapRogueGridSelectBase> valueTuple = this.CachedSelectPanelList[this.LatestSelectPanelIndex];
			MapRogueGridSelectBase item = valueTuple.Item1;
			MapRogueGridSelectBase item2 = valueTuple.Item2;
			item.SetUiActive(false);
			item2.SetUiActive(false);
			int key = this.OccupiedSelectPanelIndex[this.LatestSelectPanelIndex];
			MapRogueGrid mapRogueGrid2 = null;
			this.GridItemMap.TryGetValue(key, out mapRogueGrid2);
			if (mapRogueGrid2 != null)
			{
				mapRogueGrid2.ClearSelectPanel();
			}
			mapRogueGrid.SetSelectPanel(item, item2);
			this.OccupiedSelectPanelIndex[this.LatestSelectPanelIndex] = gridIndex;
			this.LatestSelectPanelIndex++;
			if (this.LatestSelectPanelIndex >= this.CachedSelectPanelList.Count)
			{
				this.LatestSelectPanelIndex = 0;
			}
		}

		// Token: 0x060381AC RID: 229804 RVA: 0x00D4A830 File Offset: 0x00D48A30
		[return: Nullable(new byte[]
		{
			2,
			1
		})]
		public override UUIItem[] GetGuideUiItemAndUiItemForShowEx(string[] configParams)
		{
			if (configParams.Length == 0)
			{
				return null;
			}
			int num;
			if (configParams[0] == "MapRougeGrid" && configParams.Length == 2 && int.TryParse(configParams[1], out num) && num > 0)
			{
				return this.GetGridGuideUiItem(num);
			}
			return null;
		}

		// Token: 0x060381AD RID: 229805 RVA: 0x00D4A874 File Offset: 0x00D48A74
		[return: Nullable(new byte[]
		{
			2,
			1
		})]
		private UUIItem[] GetGridGuideUiItem(int id)
		{
			MapRogueGrid mapRogueGrid = null;
			this.GridItemMap.TryGetValue(id, out mapRogueGrid);
			if (mapRogueGrid == null)
			{
				return null;
			}
			UUIItem rootItem = mapRogueGrid.GetRootItem();
			if (rootItem == null)
			{
				return null;
			}
			return new UUIItem[]
			{
				rootItem,
				rootItem
			};
		}

		// Token: 0x060381B0 RID: 229808 RVA: 0x00D4A92A File Offset: 0x00D48B2A
		[CompilerGenerated]
		internal static EWayType <GetShapeType>g__directionFunc|99_0(int g0, int g1)
		{
			if (g0 < g1)
			{
				if (g0 + 1 == g1)
				{
					return EWayType.Right;
				}
				return EWayType.Down;
			}
			else
			{
				if (g0 - 1 == g1)
				{
					return EWayType.Left;
				}
				return EWayType.Up;
			}
		}

		// Token: 0x0401D804 RID: 120836
		[Nullable(2)]
		protected LevelSequencePlayer LevelSequencePlayer;

		// Token: 0x0401D805 RID: 120837
		protected BuildingMapMoveComponent MoveComponent;

		// Token: 0x0401D806 RID: 120838
		public MapRoguePanelRole RolePanel;

		// Token: 0x0401D807 RID: 120839
		protected readonly Dictionary<int, MapRogueGrid> GridItemMap = new Dictionary<int, MapRogueGrid>();

		// Token: 0x0401D808 RID: 120840
		protected readonly Dictionary<int, MapRogueGridEvent> GridEventItemMap = new Dictionary<int, MapRogueGridEvent>();

		// Token: 0x0401D809 RID: 120841
		protected readonly Dictionary<int, MapRogueGridPath> GridPathItemMap = new Dictionary<int, MapRogueGridPath>();

		// Token: 0x0401D80A RID: 120842
		protected readonly Dictionary<int, MapRogueGridFog> GridFogItemMap = new Dictionary<int, MapRogueGridFog>();

		// Token: 0x0401D80B RID: 120843
		protected readonly Dictionary<int, UUIItem> GridPosItemMap = new Dictionary<int, UUIItem>();

		// Token: 0x0401D80C RID: 120844
		protected readonly Dictionary<int, UUIItem> GridFogPosItemMap = new Dictionary<int, UUIItem>();

		// Token: 0x0401D80D RID: 120845
		protected readonly List<MapRogueGridPath> CachedPathItemList = new List<MapRogueGridPath>();

		// Token: 0x0401D80E RID: 120846
		protected Vector2D PosTempVector = Vector2D.Create();

		// Token: 0x0401D80F RID: 120847
		protected Vector2D MapTempPos = Vector2D.Create();

		// Token: 0x0401D810 RID: 120848
		protected global::Vector MapTempScaleVector = global::Vector.Create();

		// Token: 0x0401D811 RID: 120849
		private readonly int ClickTolerance = ConfigCommonParamById.GetIntConfig("MapRogueClickOffsetTolerance").GetValueOrDefault(10);

		// Token: 0x0401D812 RID: 120850
		private readonly double FocusTweenTime = (double)MapRogueConfig.Instance.GetGlobalParamConfig().Value.FocusTime / 1000.0;

		// Token: 0x0401D813 RID: 120851
		private const double X_BIAS = 110.0;

		// Token: 0x0401D814 RID: 120852
		private const double Y_BIAS = -64.0;

		// Token: 0x0401D815 RID: 120853
		private const double CENTER_Y_BIAS = 16.0;

		// Token: 0x0401D816 RID: 120854
		private const double RANGE_X = 110.0;

		// Token: 0x0401D817 RID: 120855
		private const double RANGE_Y = 62.0;

		// Token: 0x0401D818 RID: 120856
		private const double BG_MIN_SCALE = 1.0;

		// Token: 0x0401D819 RID: 120857
		private const double BG_MAX_SCALE = 1.2999999523162842;

		// Token: 0x0401D81A RID: 120858
		private const double VIEWPORT_PRIORITY_RATIO = 1.2999999523162842;

		// Token: 0x0401D81B RID: 120859
		private const double THOUSANDTH_RATIO = 1000.0;

		// Token: 0x0401D81C RID: 120860
		private const int PROCESSING_CREATE_COUNT = 120;

		// Token: 0x0401D81D RID: 120861
		private const float PROCESSING_INTERVAL = 100f;

		// Token: 0x0401D81E RID: 120862
		private const int CACHED_SELECT_PANEL_COUNT = 5;

		// Token: 0x0401D81F RID: 120863
		private const string RESOURCE_FRONT_PATH = "/Game/Aki/UI/UIResources/UiRogue/Prefabs/RogueMap/PnlMapPieceFront.PnlMapPieceFront";

		// Token: 0x0401D820 RID: 120864
		private const string RESOURCE_BACK_PATH = "/Game/Aki/UI/UIResources/UiRogue/Prefabs/RogueMap/PnlMapPieceBack.PnlMapPieceBack";

		// Token: 0x0401D821 RID: 120865
		protected MapRogueGameInfo GameInfo;

		// Token: 0x0401D822 RID: 120866
		protected List<UiPoolActor> UiPoolActorHandle = new List<UiPoolActor>();

		// Token: 0x0401D823 RID: 120867
		protected List<IGridCreateInfo> CreatePendingList = new List<IGridCreateInfo>();

		// Token: 0x0401D824 RID: 120868
		private int CurrentProcessingCount;

		// Token: 0x0401D825 RID: 120869
		private float CreateDeltaTime;

		// Token: 0x0401D826 RID: 120870
		private bool InCreating;

		// Token: 0x0401D827 RID: 120871
		private readonly int DoubleClickIntervalTime = ConfigCommonParamById.GetIntConfig("MapRogueDoubleClickInterval").Value;

		// Token: 0x0401D828 RID: 120872
		[Nullable(2)]
		private TimerHandle SingleClickTimerHandle;

		// Token: 0x0401D829 RID: 120873
		private int InClickGridId = -1;

		// Token: 0x0401D82A RID: 120874
		private bool IsClickUp;

		// Token: 0x0401D82B RID: 120875
		private bool CanMove;

		// Token: 0x0401D82C RID: 120876
		private bool CanCheck;

		// Token: 0x0401D82D RID: 120877
		[Nullable(2)]
		protected LongPressButton ScaleUp;

		// Token: 0x0401D82E RID: 120878
		[Nullable(2)]
		protected LongPressButton ScaleDown;

		// Token: 0x0401D82F RID: 120879
		[Nullable(new byte[]
		{
			1,
			0,
			1,
			1
		})]
		protected readonly List<ValueTuple<MapRogueGridSelectBase, MapRogueGridSelectBase>> CachedSelectPanelList = new List<ValueTuple<MapRogueGridSelectBase, MapRogueGridSelectBase>>();

		// Token: 0x0401D830 RID: 120880
		private readonly int[] OccupiedSelectPanelIndex = new int[5];

		// Token: 0x0401D831 RID: 120881
		private int LatestSelectPanelIndex;
	}
}
