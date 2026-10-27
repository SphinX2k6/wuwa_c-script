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
	// Token: 0x02006950 RID: 26960
	[NullableContext(1)]
	[Nullable(0)]
	public class ScreenPositionTraceCapability : Capability
	{
		// Token: 0x060432D6 RID: 275158 RVA: 0x01061148 File Offset: 0x0105F348
		[NullableContext(2)]
		public ScreenPositionTraceCapability(ICapabilityGameObject ownerGameObject = null) : base(ownerGameObject)
		{
		}

		// Token: 0x060432D7 RID: 275159 RVA: 0x010611A9 File Offset: 0x0105F3A9
		public override void Setup()
		{
		}

		// Token: 0x060432D8 RID: 275160 RVA: 0x010611AB File Offset: 0x0105F3AB
		public override void PreTick(float deltaMilliseconds)
		{
		}

		// Token: 0x060432D9 RID: 275161 RVA: 0x010611B0 File Offset: 0x0105F3B0
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

		// Token: 0x060432DA RID: 275162 RVA: 0x01061309 File Offset: 0x0105F509
		public override bool ShouldActivate()
		{
			return true;
		}

		// Token: 0x060432DB RID: 275163 RVA: 0x0106130C File Offset: 0x0105F50C
		public override bool ShouldDeactivate()
		{
			return false;
		}

		// Token: 0x060432DC RID: 275164 RVA: 0x0106130F File Offset: 0x0105F50F
		public override void OnActivated()
		{
			this.Activate();
		}

		// Token: 0x060432DD RID: 275165 RVA: 0x01061318 File Offset: 0x0105F518
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

		// Token: 0x060432DE RID: 275166 RVA: 0x0106135C File Offset: 0x0105F55C
		public override void Activate()
		{
			float? floatConfig = ConfigCommonParamById.GetFloatConfig("ScreenPositionTraceOffset");
			if (floatConfig != null)
			{
				this.TraceOffset = floatConfig.Value;
			}
			this.GetLineTrace(true, ETraceTypeQuery.TraceTypeQuery6);
		}

		// Token: 0x060432DF RID: 275167 RVA: 0x01061393 File Offset: 0x0105F593
		public override void Deactivate()
		{
			UTraceLineElement lineTrace = this.LineTrace;
			if (lineTrace != null)
			{
				lineTrace.Dispose();
			}
			this.LineTrace = null;
		}

		// Token: 0x060432E0 RID: 275168 RVA: 0x010613AD File Offset: 0x0105F5AD
		[NullableContext(2)]
		public UTraceLineElement GetLineTrace(bool bIsSingle = true, ETraceTypeQuery queryType = ETraceTypeQuery.TraceTypeQuery6)
		{
			if (this.LineTrace == null)
			{
				this.InitLineTraceInternal(queryType, bIsSingle);
			}
			return this.LineTrace;
		}

		// Token: 0x060432E1 RID: 275169 RVA: 0x010613C8 File Offset: 0x0105F5C8
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

		// Token: 0x060432E2 RID: 275170 RVA: 0x01061450 File Offset: 0x0105F650
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

		// Token: 0x04022FB4 RID: 143284
		private FVector2D ScreenPosition = new FVector2D();

		// Token: 0x04022FB5 RID: 143285
		private FVector WorldPosition = new FVector();

		// Token: 0x04022FB6 RID: 143286
		private FVector WorldDirection = new FVector();

		// Token: 0x04022FB7 RID: 143287
		[Nullable(2)]
		private UTraceLineElement LineTrace;

		// Token: 0x04022FB8 RID: 143288
		private global::Vector LocationOffset = global::Vector.Create();

		// Token: 0x04022FB9 RID: 143289
		public float TraceOffset = 50000f;

		// Token: 0x04022FBA RID: 143290
		private UKuroHitResult HoverHitResult = new UKuroHitResult();

		// Token: 0x04022FBB RID: 143291
		private global::Vector HoverScreenPos = global::Vector.Create();
	}
}
