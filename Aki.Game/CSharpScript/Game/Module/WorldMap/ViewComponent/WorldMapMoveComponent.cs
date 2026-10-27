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
	// Token: 0x020047B0 RID: 18352
	[NullableContext(1)]
	[Nullable(0)]
	public class WorldMapMoveComponent : MapComponent
	{
		// Token: 0x060300C9 RID: 196809 RVA: 0x00B227B3 File Offset: 0x00B209B3
		public WorldMapMoveComponent([Nullable(new byte[]
		{
			0,
			1,
			1,
			1
		})] OneOf<MapComponent, MapComponentContainer, MapEntity> parent) : base(parent)
		{
		}

		// Token: 0x1700784C RID: 30796
		// (get) Token: 0x060300CA RID: 196810 RVA: 0x00B227D2 File Offset: 0x00B209D2
		public override EMapComponent ComponentType
		{
			get
			{
				return EMapComponent.WorldMapMove;
			}
		}

		// Token: 0x1700784D RID: 30797
		// (get) Token: 0x060300CB RID: 196811 RVA: 0x00B227D5 File Offset: 0x00B209D5
		public bool IsTweeningMove
		{
			get
			{
				return this.IsTweening;
			}
		}

		// Token: 0x1700784E RID: 30798
		// (get) Token: 0x060300CC RID: 196812 RVA: 0x00B227DD File Offset: 0x00B209DD
		[Nullable(2)]
		public Vector2D TweenTarget
		{
			[NullableContext(2)]
			get
			{
				return this.TweenTargetInner;
			}
		}

		// Token: 0x1700784F RID: 30799
		// (get) Token: 0x060300CD RID: 196813 RVA: 0x00B227E5 File Offset: 0x00B209E5
		public bool IsDragMoveDisabled
		{
			get
			{
				return this.IsDragDisabled;
			}
		}

		// Token: 0x17007850 RID: 30800
		// (get) Token: 0x060300CE RID: 196814 RVA: 0x00B227ED File Offset: 0x00B209ED
		public float MapScale
		{
			get
			{
				return WorldMapModel.Instance.MapScale;
			}
		}

		// Token: 0x17007851 RID: 30801
		// (get) Token: 0x060300CF RID: 196815 RVA: 0x00B227FC File Offset: 0x00B209FC
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

		// Token: 0x17007852 RID: 30802
		// (get) Token: 0x060300D0 RID: 196816 RVA: 0x00B22839 File Offset: 0x00B20A39
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

		// Token: 0x17007853 RID: 30803
		// (get) Token: 0x060300D1 RID: 196817 RVA: 0x00B2284C File Offset: 0x00B20A4C
		private FVector2D ViewportSize
		{
			get
			{
				return this.WorldMapUiComponent.ViewPortSize;
			}
		}

		// Token: 0x17007854 RID: 30804
		// (get) Token: 0x060300D2 RID: 196818 RVA: 0x00B22859 File Offset: 0x00B20A59
		private Vector2D MapSize
		{
			get
			{
				WorldMapUiEntity worldMapUiComponent = this.WorldMapUiComponent;
				return ((worldMapUiComponent != null) ? worldMapUiComponent.MapSize : null) ?? Vector2D.Create();
			}
		}

		// Token: 0x17007855 RID: 30805
		// (get) Token: 0x060300D3 RID: 196819 RVA: 0x00B22878 File Offset: 0x00B20A78
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

		// Token: 0x17007856 RID: 30806
		// (get) Token: 0x060300D4 RID: 196820 RVA: 0x00B228C4 File Offset: 0x00B20AC4
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

		// Token: 0x17007857 RID: 30807
		// (get) Token: 0x060300D5 RID: 196821 RVA: 0x00B22AB4 File Offset: 0x00B20CB4
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

		// Token: 0x060300D6 RID: 196822 RVA: 0x00B22CC4 File Offset: 0x00B20EC4
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

		// Token: 0x060300D7 RID: 196823 RVA: 0x00B22D76 File Offset: 0x00B20F76
		protected override void OnEnable()
		{
			this.AddEventListener();
		}

		// Token: 0x060300D8 RID: 196824 RVA: 0x00B22D7E File Offset: 0x00B20F7E
		protected override void OnDisable()
		{
			this.RemoveEventListener();
		}

		// Token: 0x060300D9 RID: 196825 RVA: 0x00B22D88 File Offset: 0x00B20F88
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

		// Token: 0x060300DA RID: 196826 RVA: 0x00B22DD6 File Offset: 0x00B20FD6
		public void KillTweening()
		{
			if (this.IsTweening)
			{
				this.KillPositionTweener(false);
			}
			this.IsTweening = false;
		}

		// Token: 0x060300DB RID: 196827 RVA: 0x00B22DF0 File Offset: 0x00B20FF0
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

		// Token: 0x060300DC RID: 196828 RVA: 0x00B22EC4 File Offset: 0x00B210C4
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

		// Token: 0x060300DD RID: 196829 RVA: 0x00B22F98 File Offset: 0x00B21198
		public void PushMap(MarkItem markItem, bool bUseTween = true, EClampType clampType = EClampType.ClampToDangerousArea)
		{
			if (this.UiParams == null)
			{
				Log.Instance.Error(ELogModule.Map, ELogAuthor.LYX, "请于根节点挂KuroWorldMapUIParams组件", default(ReadOnlySpan<ValueTuple<string, object>>));
				return;
			}
			this.PushMapByUiPosition(markItem.UiPosition, bUseTween, clampType);
		}

		// Token: 0x060300DE RID: 196830 RVA: 0x00B22FD8 File Offset: 0x00B211D8
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

		// Token: 0x060300DF RID: 196831 RVA: 0x00B23110 File Offset: 0x00B21310
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

		// Token: 0x060300E0 RID: 196832 RVA: 0x00B23278 File Offset: 0x00B21478
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

		// Token: 0x060300E1 RID: 196833 RVA: 0x00B232D0 File Offset: 0x00B214D0
		public void FocusPlayer(Vector2D playerPosition, bool bUseTween = false, EClampType clampType = EClampType.NotClamp)
		{
			Vector2D vector2D = Vector2D.Create();
			playerPosition.Multiply((double)this.MapScale, vector2D).UnaryNegation(vector2D);
			this.SetMapPosition(vector2D, bUseTween, clampType, new LTweenEase?(this.UiParams.TweenTypeEase), new float?(this.UiParams.TweenTime), true, true);
		}

		// Token: 0x060300E2 RID: 196834 RVA: 0x00B23324 File Offset: 0x00B21524
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

		// Token: 0x060300E3 RID: 196835 RVA: 0x00B233B8 File Offset: 0x00B215B8
		private void SetMapAnchorOffset(Vector2D targetPosition)
		{
			this.WorldMapUiComponent.Map.GetRootItem().SetAnchorOffset(targetPosition.ToUeVector2D(false));
			this.MapUiPositionInner = targetPosition;
			this.SyncUnlockFogAnchorItemPosition(targetPosition);
		}

		// Token: 0x060300E4 RID: 196836 RVA: 0x00B233E4 File Offset: 0x00B215E4
		private void SyncUnlockFogAnchorItemPosition(Vector2D mapPosition)
		{
			Vector2D vector2D = Vector2D.Create(mapPosition.X, mapPosition.Y);
			BaseMap map = this.WorldMapUiComponent.Map;
			float mapScale = WorldMapModel.Instance.MapScale;
			vector2D.DivisionEqual((double)mapScale);
			vector2D.UnaryNegation(vector2D);
			map.FogUnlockAnchorItem.SetAnchorOffset(vector2D.ToUeVector2D(false));
		}

		// Token: 0x060300E5 RID: 196837 RVA: 0x00B2343C File Offset: 0x00B2163C
		private bool NearlyPosition(FVector2D srcPosition, FVector2D dstPosition)
		{
			return MathUtils.Instance.IsNearlyEqual((double)srcPosition.X, (double)dstPosition.X, null) && MathUtils.Instance.IsNearlyEqual((double)srcPosition.Y, (double)dstPosition.Y, null);
		}

		// Token: 0x060300E6 RID: 196838 RVA: 0x00B2348F File Offset: 0x00B2168F
		private static double ClampOrCenter(double value, double min, double max)
		{
			if (min <= max)
			{
				return MathCommon.Clamp(value, min, max);
			}
			return (min + max) / 2.0;
		}

		// Token: 0x060300E7 RID: 196839 RVA: 0x00B234AC File Offset: 0x00B216AC
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

		// Token: 0x060300E8 RID: 196840 RVA: 0x00B23571 File Offset: 0x00B21771
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

		// Token: 0x060300E9 RID: 196841 RVA: 0x00B235B0 File Offset: 0x00B217B0
		private void OnTweenUpdate(FVector2D value)
		{
			Vector2D inTarget = Vector2D.Create(value);
			this.SetMapPosition(inTarget, false, EClampType.ClampToDangerousArea, null, null, true, false);
		}

		// Token: 0x060300EA RID: 196842 RVA: 0x00B235E8 File Offset: 0x00B217E8
		private void WorldMapDragInertia(Vector2D speed)
		{
			Vector2D vector2D = Vector2D.Create();
			speed.Multiply((double)this.UiParams.TweenTime, vector2D);
			Vector2D inTarget = Vector2D.Create(this.MapUiPosition).AdditionEqual(vector2D);
			this.SetMapPosition(inTarget, true, EClampType.ClampToSafeArea, new LTweenEase?(LTweenEase.OutQuad), new float?(ConfigCommonParamById.GetFloatConfig("MapDragInertiaTime").GetValueOrDefault()), true, false);
		}

		// Token: 0x060300EB RID: 196843 RVA: 0x00B23649 File Offset: 0x00B21849
		private void OnPointerDown()
		{
			if (this.IsDragDisabled)
			{
				return;
			}
			this.KillPositionTweener(true);
		}

		// Token: 0x060300EC RID: 196844 RVA: 0x00B2365B File Offset: 0x00B2185B
		private void OnWheelInput(float f, EMapScaleSetType eMapScaleSetType)
		{
		}

		// Token: 0x060300ED RID: 196845 RVA: 0x00B2365D File Offset: 0x00B2185D
		private void OnPointerDrag(Vector2D delta)
		{
			if (this.IsDragDisabled)
			{
				return;
			}
			this.MoveByDelta(delta);
		}

		// Token: 0x060300EE RID: 196846 RVA: 0x00B2366F File Offset: 0x00B2186F
		private void OnMoveForward(float delta)
		{
			this.ForwardVector.Y = (double)delta;
			this.IsMoveForwardDirty = true;
		}

		// Token: 0x060300EF RID: 196847 RVA: 0x00B23685 File Offset: 0x00B21885
		private void OnMoveRight(float delta)
		{
			this.RightVector.X = (double)delta;
			this.IsMoveRightDirty = true;
		}

		// Token: 0x060300F0 RID: 196848 RVA: 0x00B2369C File Offset: 0x00B2189C
		private void MoveToPosition(global::Vector worldPosition)
		{
			Vector2D vector2D = MapUtil.WorldPosition2UiPosition2D(Vector2D.Create(worldPosition.X, worldPosition.Y), null);
			float mapScale = WorldMapModel.Instance.MapScale;
			vector2D.UnaryNegation(vector2D);
			vector2D.MultiplyEqual((double)mapScale);
			this.SetMapPosition(vector2D, false, EClampType.ClampToDangerousArea, null, null, true, false);
		}

		// Token: 0x060300F1 RID: 196849 RVA: 0x00B236FC File Offset: 0x00B218FC
		private void MoveByDelta(Vector2D delta)
		{
			Vector2D vector2D = Vector2D.Create(this.MapUiPosition);
			this.SetMapPosition(vector2D.AdditionEqual(delta), false, EClampType.ClampToDangerousArea, null, null, true, false);
		}

		// Token: 0x060300F2 RID: 196850 RVA: 0x00B23738 File Offset: 0x00B21938
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

		// Token: 0x060300F3 RID: 196851 RVA: 0x00B23798 File Offset: 0x00B21998
		[CompilerGenerated]
		private void <SetMapPosition>g__SendEventAction|46_0()
		{
			EventSystem.Instance.Emit(EEventName.WorldMapPositionChanged);
			if (!this.IsTweening)
			{
				EventSystem.Instance.Emit(EEventName.WorldMapUpdateMultiMap);
			}
		}

		// Token: 0x04019E96 RID: 106134
		private bool IsTweening;

		// Token: 0x04019E97 RID: 106135
		private bool IsDragDisabled;

		// Token: 0x04019E98 RID: 106136
		[Nullable(2)]
		private Vector2D TweenTargetInner;

		// Token: 0x04019E99 RID: 106137
		[Nullable(2)]
		private ULTweener PositionTweener;

		// Token: 0x04019E9A RID: 106138
		[Nullable(2)]
		private FLTweenVector2SetterDynamic TweenerDelegate;

		// Token: 0x04019E9B RID: 106139
		[Nullable(2)]
		private IArea SafeArea;

		// Token: 0x04019E9C RID: 106140
		[Nullable(2)]
		private IArea DangerousArea;

		// Token: 0x04019E9D RID: 106141
		private readonly Vector2D ForwardVector = Vector2D.Create();

		// Token: 0x04019E9E RID: 106142
		private readonly Vector2D RightVector = Vector2D.Create();

		// Token: 0x04019E9F RID: 106143
		[Nullable(2)]
		private Vector2D MapUiPositionInner;

		// Token: 0x04019EA0 RID: 106144
		private bool IsMoveForwardDirty;

		// Token: 0x04019EA1 RID: 106145
		private bool IsMoveRightDirty;
	}
}
