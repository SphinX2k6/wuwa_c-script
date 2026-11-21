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
	// Token: 0x020045F8 RID: 17912
	[NullableContext(1)]
	[Nullable(0)]
	public class MapRogueMapModule : UiPanelBase
	{
		// Token: 0x0602D065 RID: 184421 RVA: 0x00C96C94 File Offset: 0x00C94E94
		public MapRogueMapModule(MapRogueGameInfo gameInfo)
		{
			this.GameInfo = gameInfo;
		}

		// Token: 0x0602D066 RID: 184422 RVA: 0x00C96DB0 File Offset: 0x00C94FB0
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

		// Token: 0x0602D067 RID: 184423 RVA: 0x00C96F98 File Offset: 0x00C95198
		protected override UniTask OnBeforeStartAsync()
		{
			MapRogueMapModule.<OnBeforeStartAsync>d__32 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<MapRogueMapModule.<OnBeforeStartAsync>d__32>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0602D068 RID: 184424 RVA: 0x00C96FDC File Offset: 0x00C951DC
		private UniTask InitMap()
		{
			MapRogueMapModule.<InitMap>d__33 <InitMap>d__;
			<InitMap>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitMap>d__.<>4__this = this;
			<InitMap>d__.<>1__state = -1;
			<InitMap>d__.<>t__builder.Start<MapRogueMapModule.<InitMap>d__33>(ref <InitMap>d__);
			return <InitMap>d__.<>t__builder.Task;
		}

		// Token: 0x0602D069 RID: 184425 RVA: 0x00C97020 File Offset: 0x00C95220
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

		// Token: 0x0602D06A RID: 184426 RVA: 0x00C971C4 File Offset: 0x00C953C4
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

		// Token: 0x0602D06B RID: 184427 RVA: 0x00C97224 File Offset: 0x00C95424
		public void MapShow()
		{
			this.ResetAllPath();
			this.MoveComponent.BindTouch();
			this.MoveComponent.AddGamepadEvent();
			this.MoveComponent.AddMoveListener(this.GameInfo.CanInteract, false);
			EventSystem.Instance.Add<EInputControllerType, EInputControllerType>(EEventName.InputControllerChange, new Action<EInputControllerType, EInputControllerType>(this.OnInputControllerChange));
			InputDistributeController.Instance.BindAction("UI左键点击", new TInputHandle<InputDistributeDefine.EActionType>(this.OnInputAction));
		}

		// Token: 0x0602D06C RID: 184428 RVA: 0x00C9729C File Offset: 0x00C9549C
		public void MapHide()
		{
			this.MoveComponent.UnbindTouch();
			this.MoveComponent.RemoveGamepadEvent();
			this.MoveComponent.RemoveMoveListener();
			EventSystem.Instance.Remove<EInputControllerType, EInputControllerType>(EEventName.InputControllerChange, new Action<EInputControllerType, EInputControllerType>(this.OnInputControllerChange));
			InputDistributeController.Instance.UnBindAction("UI左键点击", new TInputHandle<InputDistributeDefine.EActionType>(this.OnInputAction));
		}

		// Token: 0x0602D06D RID: 184429 RVA: 0x00C97304 File Offset: 0x00C95504
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

		// Token: 0x0602D06E RID: 184430 RVA: 0x00C97368 File Offset: 0x00C95568
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

		// Token: 0x0602D06F RID: 184431 RVA: 0x00C973B3 File Offset: 0x00C955B3
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

		// Token: 0x0602D070 RID: 184432 RVA: 0x00C973DC File Offset: 0x00C955DC
		private bool IsMapMoveOffsetDiff()
		{
			Vector2D b = Vector2D.Create(this.MoveComponent.GetMapItem().GetAnchorOffset());
			return !this.MapTempPos.Equals(b, (double)this.ClickTolerance);
		}

		// Token: 0x0602D071 RID: 184433 RVA: 0x00C9741C File Offset: 0x00C9561C
		private void SetAnchorOffset(int id, UUIItem item)
		{
			ValueTuple<double, double> gridAnchorOffset = this.GetGridAnchorOffset(id, null);
			double item2 = gridAnchorOffset.Item1;
			double item3 = gridAnchorOffset.Item2;
			this.PosTempVector.Set(item2, item3);
			item.SetAnchorOffset(this.PosTempVector.ToUeVector2D(false));
		}

		// Token: 0x0602D072 RID: 184434 RVA: 0x00C97460 File Offset: 0x00C95660
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

		// Token: 0x0602D073 RID: 184435 RVA: 0x00C974CC File Offset: 0x00C956CC
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

		// Token: 0x0602D074 RID: 184436 RVA: 0x00C97547 File Offset: 0x00C95747
		private void OnInputControllerChange(EInputControllerType last, EInputControllerType now)
		{
			this.RefreshMoveComponent();
		}

		// Token: 0x0602D075 RID: 184437 RVA: 0x00C97550 File Offset: 0x00C95750
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

		// Token: 0x0602D076 RID: 184438 RVA: 0x00C975BC File Offset: 0x00C957BC
		public void SetInteractAvailable(bool bAvailable)
		{
			base.GetButton(5).RootUIComp.Get().SetUIActive(!bAvailable);
			this.MoveComponent.SwitchOnMove(bAvailable);
		}

		// Token: 0x0602D077 RID: 184439 RVA: 0x00C975F4 File Offset: 0x00C957F4
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

		// Token: 0x0602D078 RID: 184440 RVA: 0x00C9766C File Offset: 0x00C9586C
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

		// Token: 0x0602D079 RID: 184441 RVA: 0x00C976CC File Offset: 0x00C958CC
		private UniTask HandleCreatePending()
		{
			MapRogueMapModule.<HandleCreatePending>d__55 <HandleCreatePending>d__;
			<HandleCreatePending>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<HandleCreatePending>d__.<>4__this = this;
			<HandleCreatePending>d__.<>1__state = -1;
			<HandleCreatePending>d__.<>t__builder.Start<MapRogueMapModule.<HandleCreatePending>d__55>(ref <HandleCreatePending>d__);
			return <HandleCreatePending>d__.<>t__builder.Task;
		}

		// Token: 0x0602D07A RID: 184442 RVA: 0x00C97710 File Offset: 0x00C95910
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

		// Token: 0x0602D07B RID: 184443 RVA: 0x00C97768 File Offset: 0x00C95968
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

		// Token: 0x0602D07C RID: 184444 RVA: 0x00C977B4 File Offset: 0x00C959B4
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

		// Token: 0x0602D07D RID: 184445 RVA: 0x00C97808 File Offset: 0x00C95A08
		public void RecycleAllActor()
		{
			foreach (UiPoolActor uiPoolActor in this.UiPoolActorHandle)
			{
				this.RecycleActor(uiPoolActor);
			}
			this.UiPoolActorHandle.Clear();
		}

		// Token: 0x0602D07E RID: 184446 RVA: 0x00C97868 File Offset: 0x00C95A68
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

		// Token: 0x0602D07F RID: 184447 RVA: 0x00C978A4 File Offset: 0x00C95AA4
		private UUIItem CreateMapGridPosItem(UUIItem rootItem, UUIItem parentItem, MapGridData data)
		{
			UUIItem uuiitem = LguiUtil.Instance.CopyItem(rootItem, parentItem);
			this.SetAnchorOffset(data.GridIndex, uuiitem);
			uuiitem.SetUIActive(true);
			return uuiitem;
		}

		// Token: 0x0602D080 RID: 184448 RVA: 0x00C978D4 File Offset: 0x00C95AD4
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

		// Token: 0x0602D081 RID: 184449 RVA: 0x00C97920 File Offset: 0x00C95B20
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

		// Token: 0x0602D082 RID: 184450 RVA: 0x00C9796C File Offset: 0x00C95B6C
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

		// Token: 0x0602D083 RID: 184451 RVA: 0x00C979C0 File Offset: 0x00C95BC0
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

		// Token: 0x0602D084 RID: 184452 RVA: 0x00C97A28 File Offset: 0x00C95C28
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

		// Token: 0x0602D085 RID: 184453 RVA: 0x00C97A70 File Offset: 0x00C95C70
		public void SetMapGridBgState(int gridIndex, bool bSelectOn, bool? bFireEvent = null)
		{
			MapRogueGrid mapRogueGrid = null;
			this.GridItemMap.TryGetValue(gridIndex, out mapRogueGrid);
			if (mapRogueGrid != null)
			{
				mapRogueGrid.SetGridToggleState(bSelectOn, bFireEvent.GetValueOrDefault());
			}
		}

		// Token: 0x0602D086 RID: 184454 RVA: 0x00C97AA0 File Offset: 0x00C95CA0
		public void SetMapGridMoveEnable(int gridIndex, bool bEnable)
		{
			MapRogueGrid mapRogueGrid = null;
			this.GridItemMap.TryGetValue(gridIndex, out mapRogueGrid);
			if (mapRogueGrid != null)
			{
				mapRogueGrid.SetToggleMoveEnable(bEnable);
			}
		}

		// Token: 0x0602D087 RID: 184455 RVA: 0x00C97AC8 File Offset: 0x00C95CC8
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

		// Token: 0x0602D088 RID: 184456 RVA: 0x00C97B00 File Offset: 0x00C95D00
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

		// Token: 0x17005AF3 RID: 23283
		// (get) Token: 0x0602D089 RID: 184457 RVA: 0x00C97BD1 File Offset: 0x00C95DD1
		private bool NeedDoubleClick
		{
			get
			{
				return Info.Instance.IsInKeyBoard();
			}
		}

		// Token: 0x17005AF4 RID: 23284
		// (get) Token: 0x0602D08A RID: 184458 RVA: 0x00C97BDD File Offset: 0x00C95DDD
		private bool InClick
		{
			get
			{
				return this.InClickGridId >= 0;
			}
		}

		// Token: 0x0602D08B RID: 184459 RVA: 0x00C97BEB File Offset: 0x00C95DEB
		private void OnMaskBtnClick()
		{
		}

		// Token: 0x0602D08C RID: 184460 RVA: 0x00C97BED File Offset: 0x00C95DED
		private void CancelSingleClickTimer()
		{
			if (this.SingleClickTimerHandle != null && TimerSystem.GameplayTimeInstance.Has(this.SingleClickTimerHandle))
			{
				TimerSystem.GameplayTimeInstance.Remove(this.SingleClickTimerHandle);
			}
			this.SingleClickTimerHandle = null;
			this.InClickGridId = -1;
		}

		// Token: 0x0602D08D RID: 184461 RVA: 0x00C97C28 File Offset: 0x00C95E28
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

		// Token: 0x0602D08E RID: 184462 RVA: 0x00C97CD0 File Offset: 0x00C95ED0
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

		// Token: 0x0602D08F RID: 184463 RVA: 0x00C97D21 File Offset: 0x00C95F21
		private void OnGridBgPointerDown(EToggleState state, MapGridData data)
		{
			this.MapTempPos.FromUeVector2D(this.MoveComponent.GetMapItem().GetAnchorOffset());
			this.MoveComponent.EmitPointerDown();
		}

		// Token: 0x0602D090 RID: 184464 RVA: 0x00C97D4E File Offset: 0x00C95F4E
		private void OnGridBgExtendToggleStateChanged(EToggleState state, MapGridData data)
		{
			this.GameInfo.OnCheck(data.GridIndex);
		}

		// Token: 0x0602D091 RID: 184465 RVA: 0x00C97D64 File Offset: 0x00C95F64
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

		// Token: 0x0602D092 RID: 184466 RVA: 0x00C97DB2 File Offset: 0x00C95FB2
		private void OnGridBgUnHover(MapGridData data)
		{
			if (Info.Instance.IsInTouch())
			{
				return;
			}
			this.GameInfo.UnHoverOnTarget(data.GridIndex);
		}

		// Token: 0x0602D093 RID: 184467 RVA: 0x00C97DD2 File Offset: 0x00C95FD2
		private void OnBackPlaneEnter()
		{
			if (this.InClick)
			{
				this.CancelSingleClickTimer();
			}
			this.GameInfo.BlankPlaneEnter();
		}

		// Token: 0x0602D094 RID: 184468 RVA: 0x00C97DED File Offset: 0x00C95FED
		private void OnBackPlanePointerDown()
		{
			this.MoveComponent.EmitPointerDown();
		}

		// Token: 0x0602D095 RID: 184469 RVA: 0x00C97DFC File Offset: 0x00C95FFC
		private void OnBeginDrag(ULGUIPointerEventData _)
		{
			base.GetButton(16).RootUIComp.Get().SetUIActive(true);
			base.GetItem(12).SetUIActive(false);
		}

		// Token: 0x0602D096 RID: 184470 RVA: 0x00C97E34 File Offset: 0x00C96034
		private void OnEndDrag(ULGUIPointerEventData _)
		{
			base.GetButton(16).RootUIComp.Get().SetUIActive(false);
			this.SetInteractState(this.CanMove, this.CanCheck, new int?(this.GameInfo.CurHoverIndex));
		}

		// Token: 0x0602D097 RID: 184471 RVA: 0x00C97E80 File Offset: 0x00C96080
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

		// Token: 0x0602D098 RID: 184472 RVA: 0x00C97ED4 File Offset: 0x00C960D4
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

		// Token: 0x0602D099 RID: 184473 RVA: 0x00C97F28 File Offset: 0x00C96128
		public void RefreshAllEventLv()
		{
			foreach (MapRogueGridEvent mapRogueGridEvent in this.GridEventItemMap.Values)
			{
				mapRogueGridEvent.RefreshLv(true);
			}
		}

		// Token: 0x0602D09A RID: 184474 RVA: 0x00C97F80 File Offset: 0x00C96180
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

		// Token: 0x0602D09B RID: 184475 RVA: 0x00C97FC8 File Offset: 0x00C961C8
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

		// Token: 0x0602D09C RID: 184476 RVA: 0x00C9801C File Offset: 0x00C9621C
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

		// Token: 0x0602D09D RID: 184477 RVA: 0x00C98080 File Offset: 0x00C96280
		protected EShapeType GetShapeType(int curId, int preId, int nextId)
		{
			EShapeType eshapeType = (EShapeType)MapRogueMapModule.<GetShapeType>g__directionFunc|99_0(curId, preId);
			int num = (int)MapRogueMapModule.<GetShapeType>g__directionFunc|99_0(curId, nextId);
			return eshapeType * (EShapeType)10 + num;
		}

		// Token: 0x0602D09E RID: 184478 RVA: 0x00C980A4 File Offset: 0x00C962A4
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

		// Token: 0x0602D09F RID: 184479 RVA: 0x00C980E8 File Offset: 0x00C962E8
		public void ResetAllPath()
		{
			foreach (MapRogueGridPath mapRogueGridPath in this.GridPathItemMap.Values)
			{
				mapRogueGridPath.SetUiActive(false);
				this.CachedPathItemList.Add(mapRogueGridPath);
			}
			this.GridPathItemMap.Clear();
		}

		// Token: 0x0602D0A0 RID: 184480 RVA: 0x00C98158 File Offset: 0x00C96358
		private UniTask InitRole()
		{
			MapRogueMapModule.<InitRole>d__102 <InitRole>d__;
			<InitRole>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitRole>d__.<>4__this = this;
			<InitRole>d__.<>1__state = -1;
			<InitRole>d__.<>t__builder.Start<MapRogueMapModule.<InitRole>d__102>(ref <InitRole>d__);
			return <InitRole>d__.<>t__builder.Task;
		}

		// Token: 0x0602D0A1 RID: 184481 RVA: 0x00C9819C File Offset: 0x00C9639C
		public void SetRolePos(int gridId)
		{
			UUIItem item = base.GetItem(4);
			this.SetAnchorOffset(gridId, item);
		}

		// Token: 0x0602D0A2 RID: 184482 RVA: 0x00C981BC File Offset: 0x00C963BC
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

		// Token: 0x0602D0A3 RID: 184483 RVA: 0x00C9823C File Offset: 0x00C9643C
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

		// Token: 0x0602D0A4 RID: 184484 RVA: 0x00C982EC File Offset: 0x00C964EC
		private void OnScaleDown(float _)
		{
			this.MoveComponent.LongPressScroll((float)(-(float)this.MoveComponent.ScaleStep));
		}

		// Token: 0x0602D0A5 RID: 184485 RVA: 0x00C98306 File Offset: 0x00C96506
		private void OnScaleUp(float _)
		{
			this.MoveComponent.LongPressScroll((float)this.MoveComponent.ScaleStep);
		}

		// Token: 0x0602D0A6 RID: 184486 RVA: 0x00C9831F File Offset: 0x00C9651F
		private void OnSliderValueChange(float value)
		{
			this.MoveComponent.SliderScroll(value);
		}

		// Token: 0x0602D0A7 RID: 184487 RVA: 0x00C98330 File Offset: 0x00C96530
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

		// Token: 0x0602D0A8 RID: 184488 RVA: 0x00C98448 File Offset: 0x00C96648
		private UniTask InitSelectPanel()
		{
			MapRogueMapModule.<InitSelectPanel>d__115 <InitSelectPanel>d__;
			<InitSelectPanel>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitSelectPanel>d__.<>4__this = this;
			<InitSelectPanel>d__.<>1__state = -1;
			<InitSelectPanel>d__.<>t__builder.Start<MapRogueMapModule.<InitSelectPanel>d__115>(ref <InitSelectPanel>d__);
			return <InitSelectPanel>d__.<>t__builder.Task;
		}

		// Token: 0x0602D0A9 RID: 184489 RVA: 0x00C9848C File Offset: 0x00C9668C
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

		// Token: 0x0602D0AA RID: 184490 RVA: 0x00C98578 File Offset: 0x00C96778
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

		// Token: 0x0602D0AB RID: 184491 RVA: 0x00C985BC File Offset: 0x00C967BC
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

		// Token: 0x0602D0AE RID: 184494 RVA: 0x00C98672 File Offset: 0x00C96872
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

		// Token: 0x0401828F RID: 98959
		[Nullable(2)]
		protected LevelSequencePlayer LevelSequencePlayer;

		// Token: 0x04018290 RID: 98960
		protected BuildingMapMoveComponent MoveComponent;

		// Token: 0x04018291 RID: 98961
		public MapRoguePanelRole RolePanel;

		// Token: 0x04018292 RID: 98962
		protected readonly Dictionary<int, MapRogueGrid> GridItemMap = new Dictionary<int, MapRogueGrid>();

		// Token: 0x04018293 RID: 98963
		protected readonly Dictionary<int, MapRogueGridEvent> GridEventItemMap = new Dictionary<int, MapRogueGridEvent>();

		// Token: 0x04018294 RID: 98964
		protected readonly Dictionary<int, MapRogueGridPath> GridPathItemMap = new Dictionary<int, MapRogueGridPath>();

		// Token: 0x04018295 RID: 98965
		protected readonly Dictionary<int, MapRogueGridFog> GridFogItemMap = new Dictionary<int, MapRogueGridFog>();

		// Token: 0x04018296 RID: 98966
		protected readonly Dictionary<int, UUIItem> GridPosItemMap = new Dictionary<int, UUIItem>();

		// Token: 0x04018297 RID: 98967
		protected readonly Dictionary<int, UUIItem> GridFogPosItemMap = new Dictionary<int, UUIItem>();

		// Token: 0x04018298 RID: 98968
		protected readonly List<MapRogueGridPath> CachedPathItemList = new List<MapRogueGridPath>();

		// Token: 0x04018299 RID: 98969
		protected Vector2D PosTempVector = Vector2D.Create();

		// Token: 0x0401829A RID: 98970
		protected Vector2D MapTempPos = Vector2D.Create();

		// Token: 0x0401829B RID: 98971
		protected global::Vector MapTempScaleVector = global::Vector.Create();

		// Token: 0x0401829C RID: 98972
		private readonly int ClickTolerance = ConfigCommonParamById.GetIntConfig("MapRogueClickOffsetTolerance").GetValueOrDefault(10);

		// Token: 0x0401829D RID: 98973
		private readonly double FocusTweenTime = (double)MapRogueConfig.Instance.GetGlobalParamConfig().Value.FocusTime / 1000.0;

		// Token: 0x0401829E RID: 98974
		private const double X_BIAS = 110.0;

		// Token: 0x0401829F RID: 98975
		private const double Y_BIAS = -64.0;

		// Token: 0x040182A0 RID: 98976
		private const double CENTER_Y_BIAS = 16.0;

		// Token: 0x040182A1 RID: 98977
		private const double RANGE_X = 110.0;

		// Token: 0x040182A2 RID: 98978
		private const double RANGE_Y = 62.0;

		// Token: 0x040182A3 RID: 98979
		private const double BG_MIN_SCALE = 1.0;

		// Token: 0x040182A4 RID: 98980
		private const double BG_MAX_SCALE = 1.2999999523162842;

		// Token: 0x040182A5 RID: 98981
		private const double VIEWPORT_PRIORITY_RATIO = 1.2999999523162842;

		// Token: 0x040182A6 RID: 98982
		private const double THOUSANDTH_RATIO = 1000.0;

		// Token: 0x040182A7 RID: 98983
		private const int PROCESSING_CREATE_COUNT = 120;

		// Token: 0x040182A8 RID: 98984
		private const float PROCESSING_INTERVAL = 100f;

		// Token: 0x040182A9 RID: 98985
		private const int CACHED_SELECT_PANEL_COUNT = 5;

		// Token: 0x040182AA RID: 98986
		private const string RESOURCE_FRONT_PATH = "/Game/Aki/UI/UIResources/UiRogue/Prefabs/RogueMap/PnlMapPieceFront.PnlMapPieceFront";

		// Token: 0x040182AB RID: 98987
		private const string RESOURCE_BACK_PATH = "/Game/Aki/UI/UIResources/UiRogue/Prefabs/RogueMap/PnlMapPieceBack.PnlMapPieceBack";

		// Token: 0x040182AC RID: 98988
		protected MapRogueGameInfo GameInfo;

		// Token: 0x040182AD RID: 98989
		protected List<UiPoolActor> UiPoolActorHandle = new List<UiPoolActor>();

		// Token: 0x040182AE RID: 98990
		protected List<IGridCreateInfo> CreatePendingList = new List<IGridCreateInfo>();

		// Token: 0x040182AF RID: 98991
		private int CurrentProcessingCount;

		// Token: 0x040182B0 RID: 98992
		private float CreateDeltaTime;

		// Token: 0x040182B1 RID: 98993
		private bool InCreating;

		// Token: 0x040182B2 RID: 98994
		private readonly int DoubleClickIntervalTime = ConfigCommonParamById.GetIntConfig("MapRogueDoubleClickInterval").Value;

		// Token: 0x040182B3 RID: 98995
		[Nullable(2)]
		private TimerHandle SingleClickTimerHandle;

		// Token: 0x040182B4 RID: 98996
		private int InClickGridId = -1;

		// Token: 0x040182B5 RID: 98997
		private bool IsClickUp;

		// Token: 0x040182B6 RID: 98998
		private bool CanMove;

		// Token: 0x040182B7 RID: 98999
		private bool CanCheck;

		// Token: 0x040182B8 RID: 99000
		[Nullable(2)]
		protected LongPressButton ScaleUp;

		// Token: 0x040182B9 RID: 99001
		[Nullable(2)]
		protected LongPressButton ScaleDown;

		// Token: 0x040182BA RID: 99002
		[Nullable(new byte[]
		{
			1,
			0,
			1,
			1
		})]
		protected readonly List<ValueTuple<MapRogueGridSelectBase, MapRogueGridSelectBase>> CachedSelectPanelList = new List<ValueTuple<MapRogueGridSelectBase, MapRogueGridSelectBase>>();

		// Token: 0x040182BB RID: 99003
		private readonly int[] OccupiedSelectPanelIndex = new int[5];

		// Token: 0x040182BC RID: 99004
		private int LatestSelectPanelIndex;
	}
}
