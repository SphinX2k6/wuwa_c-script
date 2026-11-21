using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Camera;
using CSharpScript.Game.Capability;
using CSharpScript.Game.LevelGamePlay.SplineConstrainedDrag;
using CSharpScript.Game.Utils;
using UnrealEngine;

namespace CSharpScript.Game.LevelGameplay.SplineConstrainedDrag.Capability
{
	// Token: 0x02005AAB RID: 23211
	[NullableContext(1)]
	[Nullable(0)]
	public class ScreenPositionTraceCapability : Capability
	{
		// Token: 0x0603930D RID: 234253 RVA: 0x010053A8 File Offset: 0x010035A8
		[NullableContext(2)]
		public ScreenPositionTraceCapability(ICapabilityGameObject ownerGameObject = null) : base(ownerGameObject)
		{
		}

		// Token: 0x0603930E RID: 234254 RVA: 0x01005409 File Offset: 0x01003609
		public override void Setup()
		{
		}

		// Token: 0x0603930F RID: 234255 RVA: 0x0100540B File Offset: 0x0100360B
		public override void PreTick(float deltaMilliseconds)
		{
		}

		// Token: 0x06039310 RID: 234256 RVA: 0x01005410 File Offset: 0x01003610
		public override void TickActive(float deltaMilliseconds)
		{
			ICapabilityGameObject ownerGameObject = this.OwnerGameObject;
			DraggableHoverStateData draggableHoverStateData = (ownerGameObject != null) ? ownerGameObject.GetCapabilityData<DraggableHoverStateData>(typeof(DraggableHoverStateData)) : null;
			if (draggableHoverStateData == null)
			{
				return;
			}
			SplineConstrainedDragModel instance = SplineConstrainedDragModel.Instance;
			if (instance == null)
			{
				draggableHoverStateData.HasResult = false;
				draggableHoverStateData.HoveredActorKey = null;
				return;
			}
			TsCharacterController characterController = Global.CharacterController;
			if (characterController == null)
			{
				draggableHoverStateData.HasResult = false;
				draggableHoverStateData.HoveredActorKey = null;
				return;
			}
			float num = 0f;
			float num2 = 0f;
			if (!characterController.GetMousePosition(ref num, ref num2))
			{
				draggableHoverStateData.HasResult = false;
				draggableHoverStateData.HoveredActorKey = null;
				return;
			}
			this.HoverScreenPos.X = (double)num;
			this.HoverScreenPos.Y = (double)num2;
			this.HoverScreenPos.Z = 0.0;
			UKuroHitResult hoverHitResult = this.HoverHitResult;
			bool hitResultAtScreenPosition = this.GetHitResultAtScreenPosition(this.HoverScreenPos, ref hoverHitResult, "ScreenPositionTraceCapability.TickActiveHover");
			draggableHoverStateData.HasResult = true;
			if (!hitResultAtScreenPosition)
			{
				draggableHoverStateData.HoveredActorKey = null;
				return;
			}
			UKuroHitResult ukuroHitResult = hoverHitResult;
			if (ukuroHitResult.Actors.Num() == 0)
			{
				draggableHoverStateData.HoveredActorKey = null;
				return;
			}
			string[] array = UKismetSystemLibrary.GetPathName(ukuroHitResult.Actors.Get(0)).Split('.', StringSplitOptions.None);
			if (array.Length < 3)
			{
				draggableHoverStateData.HoveredActorKey = null;
				return;
			}
			string text = array[1] + "." + array[2];
			if (instance.GetKuroSplineConstrainedDrag(text) == null)
			{
				draggableHoverStateData.HoveredActorKey = null;
				return;
			}
			draggableHoverStateData.HoveredActorKey = text;
		}

		// Token: 0x06039311 RID: 234257 RVA: 0x01005569 File Offset: 0x01003769
		public override bool ShouldActivate()
		{
			return true;
		}

		// Token: 0x06039312 RID: 234258 RVA: 0x0100556C File Offset: 0x0100376C
		public override bool ShouldDeactivate()
		{
			return false;
		}

		// Token: 0x06039313 RID: 234259 RVA: 0x0100556F File Offset: 0x0100376F
		public override void OnActivated()
		{
			this.Activate();
		}

		// Token: 0x06039314 RID: 234260 RVA: 0x01005578 File Offset: 0x01003778
		public override void OnDeactivated()
		{
			this.Deactivate();
			ICapabilityGameObject ownerGameObject = this.OwnerGameObject;
			DraggableHoverStateData draggableHoverStateData = (ownerGameObject != null) ? ownerGameObject.GetCapabilityData<DraggableHoverStateData>(typeof(DraggableHoverStateData)) : null;
			if (draggableHoverStateData != null)
			{
				draggableHoverStateData.HasResult = false;
				draggableHoverStateData.HoveredActorKey = null;
			}
		}

		// Token: 0x06039315 RID: 234261 RVA: 0x010055BC File Offset: 0x010037BC
		public override void Activate()
		{
			float? floatConfig = ConfigCommonParamById.GetFloatConfig("ScreenPositionTraceOffset");
			if (floatConfig != null)
			{
				this.TraceOffset = floatConfig.Value;
			}
			this.GetLineTrace(true, ETraceTypeQuery.TraceTypeQuery6);
		}

		// Token: 0x06039316 RID: 234262 RVA: 0x010055F3 File Offset: 0x010037F3
		public override void Deactivate()
		{
			UTraceLineElement lineTrace = this.LineTrace;
			if (lineTrace != null)
			{
				lineTrace.Dispose();
			}
			this.LineTrace = null;
		}

		// Token: 0x06039317 RID: 234263 RVA: 0x0100560D File Offset: 0x0100380D
		[NullableContext(2)]
		public UTraceLineElement GetLineTrace(bool bIsSingle = true, ETraceTypeQuery queryType = ETraceTypeQuery.TraceTypeQuery6)
		{
			if (this.LineTrace == null)
			{
				this.InitLineTraceInternal(queryType, bIsSingle);
			}
			return this.LineTrace;
		}

		// Token: 0x06039318 RID: 234264 RVA: 0x01005628 File Offset: 0x01003828
		private void InitLineTraceInternal(ETraceTypeQuery queryType, bool bIsSingle = true)
		{
			this.LineTrace = new UTraceLineElement();
			this.LineTrace.bIsSingle = bIsSingle;
			this.LineTrace.bIgnoreSelf = true;
			this.LineTrace.SetTraceTypeQuery(queryType);
			this.LineTrace.WorldContextObject = GlobalData.World;
			this.LineTrace.ActorsToIgnore.Empty(true);
			TraceElementCommon.Instance.SetTraceColor(this.LineTrace, ColorUtils.LinearGreen);
			TraceElementCommon.Instance.SetTraceHitColor(this.LineTrace, ColorUtils.LinearRed);
		}

		// Token: 0x06039319 RID: 234265 RVA: 0x010056B0 File Offset: 0x010038B0
		public bool GetHitResultAtScreenPosition(global::Vector screenPosition, ref UKuroHitResult outHitResult, string reason)
		{
			TsCharacterController characterController = Global.CharacterController;
			if (characterController == null)
			{
				return false;
			}
			this.ScreenPosition.Set((float)screenPosition.X, (float)screenPosition.Y);
			if (!UGameplayStatics.DeprojectScreenToWorld(characterController, this.ScreenPosition, ref this.WorldPosition, ref this.WorldDirection))
			{
				return false;
			}
			global::Vector locationOffset = this.LocationOffset;
			FVector fvector = characterController.GetViewTarget().K2_GetActorLocation();
			FVectorDouble fvectorDouble = fvector;
			locationOffset.DeepCopy(fvectorDouble);
			CameraController.Instance.MainModel.CameraLocation.Subtraction(this.LocationOffset, this.LocationOffset);
			global::Vector commonStartLocation = TraceElementModel.Instance.CommonStartLocation;
			global::Vector vector = commonStartLocation;
			fvectorDouble = this.WorldPosition;
			vector.DeepCopy(fvectorDouble);
			commonStartLocation.Addition(this.LocationOffset, commonStartLocation);
			global::Vector commonEndLocation = TraceElementModel.Instance.CommonEndLocation;
			global::Vector vector2 = commonEndLocation;
			fvector = this.WorldDirection * this.TraceOffset;
			FVector fvector2 = this.WorldPosition + fvector;
			fvectorDouble = fvector2;
			vector2.DeepCopy(fvectorDouble);
			commonEndLocation.Addition(this.LocationOffset, commonEndLocation);
			UTraceLineElement lineTrace = this.GetLineTrace(true, ETraceTypeQuery.TraceTypeQuery6);
			TraceElementCommon.Instance.SetStartLocation(lineTrace, commonStartLocation);
			TraceElementCommon.Instance.SetEndLocation(lineTrace, commonEndLocation);
			if (!TraceElementCommon.Instance.LineTrace(lineTrace, "GetHitResultAtScreenPosition: " + reason))
			{
				lineTrace.ClearCacheData(false);
				return false;
			}
			outHitResult = lineTrace.HitResult;
			return true;
		}

		// Token: 0x0401E19E RID: 123294
		private FVector2D ScreenPosition = new FVector2D();

		// Token: 0x0401E19F RID: 123295
		private FVector WorldPosition = new FVector();

		// Token: 0x0401E1A0 RID: 123296
		private FVector WorldDirection = new FVector();

		// Token: 0x0401E1A1 RID: 123297
		[Nullable(2)]
		private UTraceLineElement LineTrace;

		// Token: 0x0401E1A2 RID: 123298
		private global::Vector LocationOffset = global::Vector.Create();

		// Token: 0x0401E1A3 RID: 123299
		public float TraceOffset = 50000f;

		// Token: 0x0401E1A4 RID: 123300
		private UKuroHitResult HoverHitResult = new UKuroHitResult();

		// Token: 0x0401E1A5 RID: 123301
		private global::Vector HoverScreenPos = global::Vector.Create();
	}
}
