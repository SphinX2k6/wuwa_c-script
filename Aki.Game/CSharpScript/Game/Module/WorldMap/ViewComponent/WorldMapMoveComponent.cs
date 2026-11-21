using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Map;
using CSharpScript.Game.Module.Map.Base;
using CSharpScript.Game.Module.Map.Marks.MarkItem;
using CSharpScript.Game.Module.Map.View.BaseMap;
using CSharpScript.Game.Module.Map.View.BaseMap.Assistant;
using UnrealEngine;

namespace CSharpScript.Game.Module.WorldMap.ViewComponent
{
	// Token: 0x020036E1 RID: 14049
	[NullableContext(1)]
	[Nullable(0)]
	public class WorldMapMoveComponent : MapComponent
	{
		// Token: 0x06024898 RID: 149656 RVA: 0x00A526FF File Offset: 0x00A508FF
		public WorldMapMoveComponent([Nullable(new byte[]
		{
			0,
			1,
			1,
			1
		})] OneOf<MapComponent, MapComponentContainer, MapEntity> parent) : base(parent)
		{
		}

		// Token: 0x17004B08 RID: 19208
		// (get) Token: 0x06024899 RID: 149657 RVA: 0x00A5271E File Offset: 0x00A5091E
		public override EMapComponent ComponentType
		{
			get
			{
				return EMapComponent.WorldMapMove;
			}
		}

		// Token: 0x17004B09 RID: 19209
		// (get) Token: 0x0602489A RID: 149658 RVA: 0x00A52721 File Offset: 0x00A50921
		public bool IsTweeningMove
		{
			get
			{
				return this.IsTweening;
			}
		}

		// Token: 0x17004B0A RID: 19210
		// (get) Token: 0x0602489B RID: 149659 RVA: 0x00A52729 File Offset: 0x00A50929
		[Nullable(2)]
		public Vector2D TweenTarget
		{
			[NullableContext(2)]
			get
			{
				return this.TweenTargetInner;
			}
		}

		// Token: 0x17004B0B RID: 19211
		// (get) Token: 0x0602489C RID: 149660 RVA: 0x00A52731 File Offset: 0x00A50931
		public bool IsDragMoveDisabled
		{
			get
			{
				return this.IsDragDisabled;
			}
		}

		// Token: 0x17004B0C RID: 19212
		// (get) Token: 0x0602489D RID: 149661 RVA: 0x00A52739 File Offset: 0x00A50939
		public float MapScale
		{
			get
			{
				return WorldMapModel.Instance.MapScale;
			}
		}

		// Token: 0x17004B0D RID: 19213
		// (get) Token: 0x0602489E RID: 149662 RVA: 0x00A52748 File Offset: 0x00A50948
		[Nullable(2)]
		private WorldMapUiEntity WorldMapUiComponent
		{
			[NullableContext(2)]
			get
			{
				WorldMapUiEntity worldMapUiEntity = base.Parent.AsT3 as WorldMapUiEntity;
				if (worldMapUiEntity == null)
				{
					base.LogError(ELogAuthor.LRX, "[地图系统]->二级界面组件没有附加到容器下！", default(ReadOnlySpan<ValueTuple<string, object>>));
					return null;
				}
				return worldMapUiEntity;
			}
		}

		// Token: 0x17004B0E RID: 19214
		// (get) Token: 0x0602489F RID: 149663 RVA: 0x00A52785 File Offset: 0x00A50985
		[Nullable(2)]
		private UKuroWorldMapUIParams UiParams
		{
			[NullableContext(2)]
			get
			{
				WorldMapUiEntity worldMapUiComponent = this.WorldMapUiComponent;
				if (worldMapUiComponent == null)
				{
					return null;
				}
				return worldMapUiComponent.UiParams;
			}
		}

		// Token: 0x17004B0F RID: 19215
		// (get) Token: 0x060248A0 RID: 149664 RVA: 0x00A52798 File Offset: 0x00A50998
		private FVector2D ViewportSize
		{
			get
			{
				return this.WorldMapUiComponent.ViewPortSize;
			}
		}

		// Token: 0x17004B10 RID: 19216
		// (get) Token: 0x060248A1 RID: 149665 RVA: 0x00A527A5 File Offset: 0x00A509A5
		private Vector2D MapSize
		{
			get
			{
				WorldMapUiEntity worldMapUiComponent = this.WorldMapUiComponent;
				return ((worldMapUiComponent != null) ? worldMapUiComponent.MapSize : null) ?? Vector2D.Create();
			}
		}

		// Token: 0x17004B11 RID: 19217
		// (get) Token: 0x060248A2 RID: 149666 RVA: 0x00A527C4 File Offset: 0x00A509C4
		public Vector2D MapUiPosition
		{
			get
			{
				if (this.MapUiPositionInner == null)
				{
					FVector2D anchorOffset = this.WorldMapUiComponent.Map.GetRootItem().GetAnchorOffset();
					this.MapUiPositionInner = Vector2D.Create((double)anchorOffset.X, (double)anchorOffset.Y);
				}
				return this.MapUiPositionInner;
			}
		}

		// Token: 0x17004B12 RID: 19218
		// (get) Token: 0x060248A3 RID: 149667 RVA: 0x00A52810 File Offset: 0x00A50A10
		public IArea SafeAreaSize
		{
			get
			{
				BaseMap map = this.WorldMapUiComponent.Map;
				IArea safeArea = this.SafeArea;
				AkiMap? akiMapConfig = WorldMapConfig.Instance.GetAkiMapConfig(map.MapId, true);
				int[] array = (akiMapConfig.Value.SafeAreaOffsetLength == 4) ? akiMapConfig.Value.SafeAreaOffset() : new int[4];
				MapTileMgr mapTileMgr = map.MapTileMgr;
				Vector2D vector2D = (mapTileMgr != null) ? mapTileMgr.GetContentCenterOffset() : null;
				double num = (vector2D != null) ? (vector2D.X * (double)this.MapScale) : 0.0;
				double num2 = (vector2D != null) ? (vector2D.Y * (double)this.MapScale) : 0.0;
				safeArea.MinX = -((this.MapSize.X + (double)map.MapOffset.Value.Y + (double)array[1]) * (double)this.MapScale - (double)this.ViewportSize.X) / 2.0 + num;
				safeArea.MaxX = ((this.MapSize.X - (double)map.MapOffset.Value.X - (double)array[0]) * (double)this.MapScale - (double)this.ViewportSize.X) / 2.0 + num;
				safeArea.MinY = -((this.MapSize.Y - (double)map.MapOffset.Value.Z + (double)array[3]) * (double)this.MapScale - (double)this.ViewportSize.Y) / 2.0 + num2;
				safeArea.MaxY = ((this.MapSize.Y - (double)map.MapOffset.Value.W - (double)array[2]) * (double)this.MapScale - (double)this.ViewportSize.Y) / 2.0 + num2;
				return safeArea;
			}
		}

		// Token: 0x17004B13 RID: 19219
		// (get) Token: 0x060248A4 RID: 149668 RVA: 0x00A52A00 File Offset: 0x00A50C00
		public IArea DangerousAreaSize
		{
			get
			{
				BaseMap map = this.WorldMapUiComponent.Map;
				IArea dangerousArea = this.DangerousArea;
				AkiMap? akiMapConfig = WorldMapConfig.Instance.GetAkiMapConfig(map.MapId, true);
				int[] array = (akiMapConfig.Value.SafeAreaOffsetLength == 4) ? akiMapConfig.Value.SafeAreaOffset() : new int[4];
				MapTileMgr mapTileMgr = map.MapTileMgr;
				Vector2D vector2D = (mapTileMgr != null) ? mapTileMgr.GetContentCenterOffset() : null;
				double num = (vector2D != null) ? (vector2D.X * (double)this.MapScale) : 0.0;
				double num2 = (vector2D != null) ? (vector2D.Y * (double)this.MapScale) : 0.0;
				dangerousArea.MinX = -((this.MapSize.X + (double)map.MapOffset.Value.Y + (double)map.FakeOffset + (double)array[1]) * (double)this.MapScale - (double)this.ViewportSize.X) / 2.0 + num;
				dangerousArea.MaxX = ((this.MapSize.X - (double)map.MapOffset.Value.X + (double)map.FakeOffset - (double)array[0]) * (double)this.MapScale - (double)this.ViewportSize.X) / 2.0 + num;
				dangerousArea.MinY = -((this.MapSize.Y - (double)map.MapOffset.Value.Z + (double)map.FakeOffset + (double)array[3]) * (double)this.MapScale - (double)this.ViewportSize.Y) / 2.0 + num2;
				dangerousArea.MaxY = ((this.MapSize.Y - (double)map.MapOffset.Value.W + (double)map.FakeOffset - (double)array[2]) * (double)this.MapScale - (double)this.ViewportSize.Y) / 2.0 + num2;
				return dangerousArea;
			}
		}

		// Token: 0x060248A5 RID: 149669 RVA: 0x00A52C10 File Offset: 0x00A50E10
		protected override void OnAdd()
		{
			this.SafeArea = new Area
			{
				MinX = 0.0,
				MaxX = 0.0,
				MinY = 0.0,
				MaxY = 0.0
			};
			this.DangerousArea = new Area
			{
				MinX = 0.0,
				MaxX = 0.0,
				MinY = 0.0,
				MaxY = 0.0
			};
			this.TweenerDelegate = DelegateUtils.ToManualReleaseDelegate<FLTweenVector2SetterDynamic>(new Action<FVector2D>(this.OnTweenUpdate));
		}

		// Token: 0x060248A6 RID: 149670 RVA: 0x00A52CC2 File Offset: 0x00A50EC2
		protected override void OnEnable()
		{
			this.AddEventListener();
		}

		// Token: 0x060248A7 RID: 149671 RVA: 0x00A52CCA File Offset: 0x00A50ECA
		protected override void OnDisable()
		{
			this.RemoveEventListener();
		}

		// Token: 0x060248A8 RID: 149672 RVA: 0x00A52CD4 File Offset: 0x00A50ED4
		protected override void OnRemove()
		{
			this.KillPositionTweener(false);
			FLTweenVector2SetterDynamic tweenerDelegate = this.TweenerDelegate;
			if (tweenerDelegate != null && tweenerDelegate.IsBound())
			{
				DelegateUtils.ReleaseManualReleaseDelegate(new Action<FVector2D>(this.OnTweenUpdate));
			}
			this.TweenerDelegate = null;
			this.SafeArea = null;
			this.DangerousArea = null;
		}

		// Token: 0x060248A9 RID: 149673 RVA: 0x00A52D22 File Offset: 0x00A50F22
		public void KillTweening()
		{
			if (this.IsTweening)
			{
				this.KillPositionTweener(false);
			}
			this.IsTweening = false;
		}

		// Token: 0x060248AA RID: 149674 RVA: 0x00A52D3C File Offset: 0x00A50F3C
		private void AddEventListener()
		{
			EventSystem.Instance.Add(EEventName.WorldMapDragInertia, new Action<Vector2D>(this.WorldMapDragInertia));
			EventSystem.Instance.Add(EEventName.WorldMapPointerDrag, new Action<Vector2D>(this.OnPointerDrag));
			EventSystem.Instance.Add(EEventName.WorldMapPointerDown, new Action(this.OnPointerDown));
			EventSystem.Instance.Add<float, EMapScaleSetType>(EEventName.WorldMapWheelAxisInput, new Action<float, EMapScaleSetType>(this.OnWheelInput));
			EventSystem.Instance.Add(EEventName.WorldMapJoystickMoveForward, new Action<float>(this.OnMoveForward));
			EventSystem.Instance.Add(EEventName.WorldMapJoystickMoveRight, new Action<float>(this.OnMoveRight));
			EventSystem.Instance.Add(EEventName.MoveWorldMapToPosition, new Action<global::Vector>(this.MoveToPosition));
		}

		// Token: 0x060248AB RID: 149675 RVA: 0x00A52E10 File Offset: 0x00A51010
		private void RemoveEventListener()
		{
			EventSystem.Instance.Remove(EEventName.WorldMapDragInertia, new Action<Vector2D>(this.WorldMapDragInertia));
			EventSystem.Instance.Remove(EEventName.WorldMapPointerDrag, new Action<Vector2D>(this.OnPointerDrag));
			EventSystem.Instance.Remove(EEventName.WorldMapPointerDown, new Action(this.OnPointerDown));
			EventSystem.Instance.Remove<float, EMapScaleSetType>(EEventName.WorldMapWheelAxisInput, new Action<float, EMapScaleSetType>(this.OnWheelInput));
			EventSystem.Instance.Remove(EEventName.WorldMapJoystickMoveForward, new Action<float>(this.OnMoveForward));
			EventSystem.Instance.Remove(EEventName.WorldMapJoystickMoveRight, new Action<float>(this.OnMoveRight));
			EventSystem.Instance.Remove(EEventName.MoveWorldMapToPosition, new Action<global::Vector>(this.MoveToPosition));
		}

		// Token: 0x060248AC RID: 149676 RVA: 0x00A52EE4 File Offset: 0x00A510E4
		public void PushMap(MarkItem markItem, bool bUseTween = true, EClampType clampType = EClampType.ClampToDangerousArea)
		{
			if (this.UiParams == null)
			{
				Log.Instance.Error(ELogModule.Map, ELogAuthor.LYX, "请于根节点挂KuroWorldMapUIParams组件", default(ReadOnlySpan<ValueTuple<string, object>>));
				return;
			}
			this.PushMapByUiPosition(markItem.UiPosition, bUseTween, clampType);
		}

		// Token: 0x060248AD RID: 149677 RVA: 0x00A52F24 File Offset: 0x00A51124
		public void PushMapByUiPosition(global::Vector uiPosition, bool bUseTween = true, EClampType clampType = EClampType.ClampToDangerousArea)
		{
			if (this.UiParams == null)
			{
				Log.Instance.Error(ELogModule.Map, ELogAuthor.YSQ, "请于根节点挂KuroWorldMapUIParams组件", default(ReadOnlySpan<ValueTuple<string, object>>));
				return;
			}
			double x = uiPosition.X;
			double y = uiPosition.Y;
			FVector2D anchorOffset = this.WorldMapUiComponent.Map.GetRootItem().GetAnchorOffset();
			double num = x * (double)this.MapScale + (double)anchorOffset.X;
			double num2 = y * (double)this.MapScale + (double)anchorOffset.Y;
			float x2 = this.UiParams.FocusMark_AnchoredPosition.X;
			float y2 = this.UiParams.FocusMark_AnchoredPosition.Y;
			if (Math.Abs(num - (double)x2) < 9.99999993922529E-09 && Math.Abs(num2 - (double)y2) < 9.99999993922529E-09)
			{
				EventSystem.Instance.Emit(EEventName.WorldMapPositionChanged);
				EventSystem.Instance.Emit(EEventName.WorldMapUpdateMultiMap);
				return;
			}
			Vector2D inTarget = Vector2D.Create(-x * (double)this.MapScale + (double)x2, -y * (double)this.MapScale + (double)y2);
			this.SetMapPosition(inTarget, bUseTween, clampType, new LTweenEase?(this.UiParams.TweenTypeEase), new float?(this.UiParams.TweenTime), true, true);
		}

		// Token: 0x060248AE RID: 149678 RVA: 0x00A5305C File Offset: 0x00A5125C
		[NullableContext(2)]
		public void SetMapPosition(object inTarget, bool bUseTween, EClampType clampType = EClampType.NotClamp, LTweenEase? tweenEase = null, float? tweenTime = null, bool sendEvent = true, bool disableDrag = false)
		{
			if (inTarget == null)
			{
				return;
			}
			if (this.UiParams == null)
			{
				Log.Instance.Error(ELogModule.Map, ELogAuthor.LYX, "请于根节点挂KuroWorldMapUIParams组件", default(ReadOnlySpan<ValueTuple<string, object>>));
				return;
			}
			Vector2D vector2D = Vector2D.Create();
			Vector2D vector2D2 = inTarget as Vector2D;
			if (vector2D2 != null)
			{
				vector2D.DeepCopy(vector2D2);
			}
			else
			{
				MarkItem markItem = inTarget as MarkItem;
				if (markItem != null)
				{
					vector2D.X = markItem.UiPosition.X;
					vector2D.Y = markItem.UiPosition.Y;
					vector2D.MultiplyEqual((double)this.MapScale).UnaryNegation(vector2D);
				}
			}
			Vector2D position = Vector2D.Create(vector2D.X, vector2D.Y);
			vector2D = this.ClampPosition(position, clampType, false);
			if (!bUseTween)
			{
				this.SetMapAnchorOffset(vector2D);
				if (sendEvent)
				{
					this.<SetMapPosition>g__SendEventAction|46_0();
				}
				return;
			}
			FVector2D anchorOffset = this.WorldMapUiComponent.Map.GetRootItem().GetAnchorOffset();
			FVector2D fvector2D = vector2D.ToUeVector2D(false);
			if (this.NearlyPosition(anchorOffset, fvector2D))
			{
				this.SetMapAnchorOffset(vector2D);
				this.<SetMapPosition>g__SendEventAction|46_0();
				return;
			}
			this.KillPositionTweener(false);
			this.IsDragDisabled = disableDrag;
			this.IsTweening = true;
			this.TweenTargetInner = vector2D;
			this.PositionTweener = ULTweenBPLibrary.Vector2To(GlobalData.World, this.TweenerDelegate, anchorOffset, fvector2D, tweenTime.GetValueOrDefault(), 0f, tweenEase.GetValueOrDefault());
			this.PositionTweener.OnCompleteCallBack.Bind(delegate()
			{
				this.TweenTargetInner = null;
				this.IsTweening = false;
				this.IsDragDisabled = false;
				this.<SetMapPosition>g__SendEventAction|46_0();
			});
		}

		// Token: 0x060248AF RID: 149679 RVA: 0x00A531C4 File Offset: 0x00A513C4
		public void SetMapPositionCauseByScaling(Vector2D focusPosition, [Nullable(2)] Vector2D targetPosition, EClampType clampType = EClampType.NotClamp)
		{
			bool isTweeningMove = this.IsTweeningMove;
			this.KillTweening();
			this.SetMapPosition(focusPosition, false, clampType, null, null, true, false);
			if (targetPosition != null)
			{
				this.SetMapPosition(targetPosition, isTweeningMove, clampType, null, null, true, false);
			}
		}

		// Token: 0x060248B0 RID: 149680 RVA: 0x00A5321C File Offset: 0x00A5141C
		public void FocusPlayer(Vector2D playerPosition, bool bUseTween = false, EClampType clampType = EClampType.NotClamp)
		{
			Vector2D vector2D = Vector2D.Create();
			playerPosition.Multiply((double)this.MapScale, vector2D).UnaryNegation(vector2D);
			this.SetMapPosition(vector2D, bUseTween, clampType, new LTweenEase?(this.UiParams.TweenTypeEase), new float?(this.UiParams.TweenTime), true, true);
		}

		// Token: 0x060248B1 RID: 149681 RVA: 0x00A53270 File Offset: 0x00A51470
		public void TickMoveDirty()
		{
			if (!this.IsMoveForwardDirty && !this.IsMoveRightDirty)
			{
				return;
			}
			Vector2D vector2D = Vector2D.Create(this.MapUiPosition);
			float moveSpeedMultiplier = this.GetMoveSpeedMultiplier();
			if (this.IsMoveForwardDirty)
			{
				vector2D.AdditionEqual(this.ForwardVector.MultiplyEqual((double)moveSpeedMultiplier));
				this.IsMoveForwardDirty = false;
			}
			if (this.IsMoveRightDirty)
			{
				vector2D.AdditionEqual(this.RightVector.MultiplyEqual((double)moveSpeedMultiplier));
				this.IsMoveRightDirty = false;
			}
			this.SetMapPosition(vector2D, false, EClampType.ClampToDangerousArea, null, null, true, false);
		}

		// Token: 0x060248B2 RID: 149682 RVA: 0x00A53304 File Offset: 0x00A51504
		private void SetMapAnchorOffset(Vector2D targetPosition)
		{
			this.WorldMapUiComponent.Map.GetRootItem().SetAnchorOffset(targetPosition.ToUeVector2D(false));
			this.MapUiPositionInner = targetPosition;
			this.SyncUnlockFogAnchorItemPosition(targetPosition);
		}

		// Token: 0x060248B3 RID: 149683 RVA: 0x00A53330 File Offset: 0x00A51530
		private void SyncUnlockFogAnchorItemPosition(Vector2D mapPosition)
		{
			Vector2D vector2D = Vector2D.Create(mapPosition.X, mapPosition.Y);
			BaseMap map = this.WorldMapUiComponent.Map;
			float mapScale = WorldMapModel.Instance.MapScale;
			vector2D.DivisionEqual((double)mapScale);
			vector2D.UnaryNegation(vector2D);
			map.FogUnlockAnchorItem.SetAnchorOffset(vector2D.ToUeVector2D(false));
		}

		// Token: 0x060248B4 RID: 149684 RVA: 0x00A53388 File Offset: 0x00A51588
		private bool NearlyPosition(FVector2D srcPosition, FVector2D dstPosition)
		{
			return MathUtils.Instance.IsNearlyEqual((double)srcPosition.X, (double)dstPosition.X, null) && MathUtils.Instance.IsNearlyEqual((double)srcPosition.Y, (double)dstPosition.Y, null);
		}

		// Token: 0x060248B5 RID: 149685 RVA: 0x00A533DB File Offset: 0x00A515DB
		private static double ClampOrCenter(double value, double min, double max)
		{
			if (min <= max)
			{
				return MathCommon.Clamp(value, min, max);
			}
			return (min + max) / 2.0;
		}

		// Token: 0x060248B6 RID: 149686 RVA: 0x00A533F8 File Offset: 0x00A515F8
		private Vector2D ClampPosition(Vector2D position, EClampType type, bool dontNew = false)
		{
			double x = position.X;
			double y = position.Y;
			switch (type)
			{
			case EClampType.ClampToSafeArea:
			{
				IArea safeAreaSize = this.SafeAreaSize;
				x = WorldMapMoveComponent.ClampOrCenter(position.X, safeAreaSize.MinX, safeAreaSize.MaxX);
				y = WorldMapMoveComponent.ClampOrCenter(position.Y, safeAreaSize.MinY, safeAreaSize.MaxY);
				break;
			}
			case EClampType.ClampToDangerousArea:
			{
				IArea dangerousAreaSize = this.DangerousAreaSize;
				x = WorldMapMoveComponent.ClampOrCenter(position.X, dangerousAreaSize.MinX, dangerousAreaSize.MaxX);
				y = WorldMapMoveComponent.ClampOrCenter(position.Y, dangerousAreaSize.MinY, dangerousAreaSize.MaxY);
				break;
			}
			}
			Vector2D vector2D = position;
			if (dontNew || type == EClampType.NotClamp)
			{
				vector2D.X = x;
				vector2D.Y = y;
			}
			else
			{
				vector2D = Vector2D.Create(x, y);
			}
			return vector2D;
		}

		// Token: 0x060248B7 RID: 149687 RVA: 0x00A534BD File Offset: 0x00A516BD
		private void KillPositionTweener(bool callComplete = false)
		{
			ULTweener positionTweener = this.PositionTweener;
			if (positionTweener != null && positionTweener.IsValid())
			{
				this.PositionTweener.Kill(callComplete);
				this.PositionTweener = null;
			}
			this.TweenTargetInner = null;
			this.IsTweening = false;
			this.IsDragDisabled = false;
		}

		// Token: 0x060248B8 RID: 149688 RVA: 0x00A534FC File Offset: 0x00A516FC
		private void OnTweenUpdate(FVector2D value)
		{
			Vector2D inTarget = Vector2D.Create(value);
			this.SetMapPosition(inTarget, false, EClampType.ClampToDangerousArea, null, null, true, false);
		}

		// Token: 0x060248B9 RID: 149689 RVA: 0x00A53534 File Offset: 0x00A51734
		private void WorldMapDragInertia(Vector2D speed)
		{
			Vector2D vector2D = Vector2D.Create();
			speed.Multiply((double)this.UiParams.TweenTime, vector2D);
			Vector2D inTarget = Vector2D.Create(this.MapUiPosition).AdditionEqual(vector2D);
			this.SetMapPosition(inTarget, true, EClampType.ClampToSafeArea, new LTweenEase?(LTweenEase.OutQuad), new float?(ConfigCommonParamById.GetFloatConfig("MapDragInertiaTime").GetValueOrDefault()), true, false);
		}

		// Token: 0x060248BA RID: 149690 RVA: 0x00A53595 File Offset: 0x00A51795
		private void OnPointerDown()
		{
			if (this.IsDragDisabled)
			{
				return;
			}
			this.KillPositionTweener(true);
		}

		// Token: 0x060248BB RID: 149691 RVA: 0x00A535A7 File Offset: 0x00A517A7
		private void OnWheelInput(float f, EMapScaleSetType eMapScaleSetType)
		{
		}

		// Token: 0x060248BC RID: 149692 RVA: 0x00A535A9 File Offset: 0x00A517A9
		private void OnPointerDrag(Vector2D delta)
		{
			if (this.IsDragDisabled)
			{
				return;
			}
			this.MoveByDelta(delta);
		}

		// Token: 0x060248BD RID: 149693 RVA: 0x00A535BB File Offset: 0x00A517BB
		private void OnMoveForward(float delta)
		{
			this.ForwardVector.Y = (double)delta;
			this.IsMoveForwardDirty = true;
		}

		// Token: 0x060248BE RID: 149694 RVA: 0x00A535D1 File Offset: 0x00A517D1
		private void OnMoveRight(float delta)
		{
			this.RightVector.X = (double)delta;
			this.IsMoveRightDirty = true;
		}

		// Token: 0x060248BF RID: 149695 RVA: 0x00A535E8 File Offset: 0x00A517E8
		private void MoveToPosition(global::Vector worldPosition)
		{
			Vector2D vector2D = MapUtil.WorldPosition2UiPosition2D(Vector2D.Create(worldPosition.X, worldPosition.Y), null);
			float mapScale = WorldMapModel.Instance.MapScale;
			vector2D.UnaryNegation(vector2D);
			vector2D.MultiplyEqual((double)mapScale);
			this.SetMapPosition(vector2D, false, EClampType.ClampToDangerousArea, null, null, true, false);
		}

		// Token: 0x060248C0 RID: 149696 RVA: 0x00A53648 File Offset: 0x00A51848
		private void MoveByDelta(Vector2D delta)
		{
			Vector2D vector2D = Vector2D.Create(this.MapUiPosition);
			this.SetMapPosition(vector2D.AdditionEqual(delta), false, EClampType.ClampToDangerousArea, null, null, true, false);
		}

		// Token: 0x060248C1 RID: 149697 RVA: 0x00A53684 File Offset: 0x00A51884
		private float GetMoveSpeedMultiplier()
		{
			WorldMapModel instance = WorldMapModel.Instance;
			float valueOrDefault = ConfigCommonParamById.GetFloatConfig("MapDragSpeedMultiplier").GetValueOrDefault(1f);
			float num = instance.MapScaleMax - instance.MapScaleMin;
			if (num > 0f)
			{
				return (instance.MapScale - instance.MapScaleMin) * (1f - valueOrDefault) / num + valueOrDefault;
			}
			return 1f;
		}

		// Token: 0x060248C2 RID: 149698 RVA: 0x00A536E4 File Offset: 0x00A518E4
		[CompilerGenerated]
		private void <SetMapPosition>g__SendEventAction|46_0()
		{
			EventSystem.Instance.Emit(EEventName.WorldMapPositionChanged);
			if (!this.IsTweening)
			{
				EventSystem.Instance.Emit(EEventName.WorldMapUpdateMultiMap);
			}
		}

		// Token: 0x04014546 RID: 83270
		private bool IsTweening;

		// Token: 0x04014547 RID: 83271
		private bool IsDragDisabled;

		// Token: 0x04014548 RID: 83272
		[Nullable(2)]
		private Vector2D TweenTargetInner;

		// Token: 0x04014549 RID: 83273
		[Nullable(2)]
		private ULTweener PositionTweener;

		// Token: 0x0401454A RID: 83274
		[Nullable(2)]
		private FLTweenVector2SetterDynamic TweenerDelegate;

		// Token: 0x0401454B RID: 83275
		[Nullable(2)]
		private IArea SafeArea;

		// Token: 0x0401454C RID: 83276
		[Nullable(2)]
		private IArea DangerousArea;

		// Token: 0x0401454D RID: 83277
		private readonly Vector2D ForwardVector = Vector2D.Create();

		// Token: 0x0401454E RID: 83278
		private readonly Vector2D RightVector = Vector2D.Create();

		// Token: 0x0401454F RID: 83279
		[Nullable(2)]
		private Vector2D MapUiPositionInner;

		// Token: 0x04014550 RID: 83280
		private bool IsMoveForwardDirty;

		// Token: 0x04014551 RID: 83281
		private bool IsMoveRightDirty;
	}
}
