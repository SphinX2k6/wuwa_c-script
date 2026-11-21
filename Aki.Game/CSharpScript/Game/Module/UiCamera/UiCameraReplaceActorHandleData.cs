using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Data.UiCameraAnimation.Struct;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.UiCamera
{
	// Token: 0x02003998 RID: 14744
	[NullableContext(2)]
	[Nullable(0)]
	public class UiCameraReplaceActorHandleData : UiCameraConfigHandleData
	{
		// Token: 0x06025F9F RID: 155551 RVA: 0x00AA8543 File Offset: 0x00AA6743
		[NullableContext(1)]
		internal void SetReplaceCameraActor(ACineCameraActor replaceCameraActor)
		{
			this.ReplaceCameraActor = replaceCameraActor;
		}

		// Token: 0x06025FA0 RID: 155552 RVA: 0x00AA854C File Offset: 0x00AA674C
		public ACineCameraActor GetReplaceCameraActor()
		{
			return this.ReplaceCameraActor;
		}

		// Token: 0x06025FA1 RID: 155553 RVA: 0x00AA8554 File Offset: 0x00AA6754
		public UCineCameraComponent GetReplaceCameraComponent()
		{
			return this.ReplaceCameraComponent;
		}

		// Token: 0x06025FA2 RID: 155554 RVA: 0x00AA855C File Offset: 0x00AA675C
		[NullableContext(1)]
		public override bool Refresh(UiCameraModel model)
		{
			return base.RefreshConfigData(model) && this.RefreshReplaceCameraData(this.ReplaceCameraActor);
		}

		// Token: 0x06025FA3 RID: 155555 RVA: 0x00AA8578 File Offset: 0x00AA6778
		protected unsafe bool RefreshReplaceCameraData(ACineCameraActor replaceCameraActor)
		{
			this.ReplaceCameraActor = replaceCameraActor;
			ACineCameraActor replaceCameraActor2 = this.ReplaceCameraActor;
			this.ReplaceCameraComponent = ((replaceCameraActor2 != null) ? replaceCameraActor2.GetCineCameraComponent() : null);
			if (!(base.CameraSettings == null))
			{
				ACineCameraActor replaceCameraActor3 = this.ReplaceCameraActor;
				if (replaceCameraActor3 != null && replaceCameraActor3.IsValid())
				{
					UCineCameraComponent replaceCameraComponent = this.ReplaceCameraComponent;
					if (replaceCameraComponent != null && replaceCameraComponent.IsValid())
					{
						base.RefreshCommonCameraData(base.CameraSettings);
						bool flag;
						if (base.CameraSettings.bTargetActorAsCenter)
						{
							AActor targetActor = base.GetTargetActor();
							flag = (targetActor != null && targetActor.IsValid());
						}
						else
						{
							flag = false;
						}
						bool flag2 = flag;
						FVectorDouble fvectorDouble = this.ReplaceCameraActor.D_K2_GetActorLocation();
						FRotator frotator = this.ReplaceCameraActor.K2_GetActorRotation();
						FVectorDouble location = flag2 ? UiCameraReplaceActorHandleData.CalculateCameraCenterLocation(base.GetTargetActor().D_K2_GetActorLocation(), fvectorDouble, frotator) : fvectorDouble;
						base.Location = location;
						base.Rotation = (flag2 ? FRotator.ZeroRotator : frotator);
						float armLength;
						if (!flag2)
						{
							armLength = 0f;
						}
						else
						{
							FVectorDouble fvectorDouble2 = base.GetTargetActor().D_K2_GetActorLocation();
							FVector fvector = fvectorDouble2;
							FVector fvector2 = fvectorDouble;
							armLength = FVector.Dist2D(fvector, fvector2);
						}
						base.ArmLength = armLength;
						base.ArmOffsetLocation = FVectorDouble.ZeroVector;
						base.ArmOffsetRotation = (flag2 ? UKismetMathLibrary.D_FindLookAtRotation(fvectorDouble, location) : base.CameraSettings.ArmOffsetRotation);
						base.ArmCollisionTest = false;
						base.FieldOfView = this.ReplaceCameraComponent.FieldOfView;
						this.RefreshDynamicFieldOfView();
						if (base.CameraSettings.IsDynamicFov)
						{
							Vector2D viewportSize = UiLayer.Instance.GetViewportSize();
							int value = 0;
							int value2 = 0;
							TsCharacterController characterController = Global.CharacterController;
							if (characterController != null)
							{
								characterController.GetViewportSize(ref value, ref value2);
							}
							Log instance = Log.Instance;
							ELogModule module = ELogModule.UiCamera;
							ELogAuthor author = ELogAuthor.BB;
							string message = "刷新替换相机动态FOV";
							<>y__InlineArray13<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray13<ValueTuple<string, object>>);
							*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray13<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("HandleData", this.ToString());
							*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray13<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("ReplaceCameraActor", this.ReplaceCameraActor.GetName());
							*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray13<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("ReplaceCameraTag", base.CameraSettings.ReplaceCameraTag);
							*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray13<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 3) = new ValueTuple<string, object>("SourceFieldOfView", this.ReplaceCameraComponent.FieldOfView);
							*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray13<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 4) = new ValueTuple<string, object>("BaseAspectRatio", this.ReplaceCameraComponent.AspectRatio);
							*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray13<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 5) = new ValueTuple<string, object>("FilmbackAspectRatio", this.ReplaceCameraComponent.Filmback.SensorAspectRatio);
							*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray13<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 6) = new ValueTuple<string, object>("SourceFocalLength", this.ReplaceCameraComponent.CurrentFocalLength);
							*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray13<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 7) = new ValueTuple<string, object>("DynamicBaseResolution", base.CameraSettings.DynamicBaseResolution);
							*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray13<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 8) = new ValueTuple<string, object>("ConfigFieldOfView", base.CameraSettings.CameraFieldOfView);
							*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray13<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 9) = new ValueTuple<string, object>("ConfigAperture", base.CameraSettings.Aperture);
							*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray13<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 10) = new ValueTuple<string, object>("UiViewportSize", viewportSize);
							ref ValueTuple<string, object> ptr = ref <PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray13<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 11);
							string item = "GameViewportSize";
							DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
							defaultInterpolatedStringHandler.AppendFormatted<int>(value);
							defaultInterpolatedStringHandler.AppendLiteral("x");
							defaultInterpolatedStringHandler.AppendFormatted<int>(value2);
							ptr = new ValueTuple<string, object>(item, defaultInterpolatedStringHandler.ToStringAndClear());
							*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray13<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 12) = new ValueTuple<string, object>("TargetFieldOfView", base.FieldOfView);
							instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray13<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 13));
						}
						base.FocalDistance = this.ReplaceCameraComponent.FocusSettings.ManualFocusDistance;
						base.Aperture = this.ReplaceCameraComponent.CurrentAperture;
						base.FocalRegion = this.ReplaceCameraComponent.CurrentFocalRegion;
						base.PostProcessBlendWeight = this.ReplaceCameraComponent.PostProcessBlendWeight;
						return true;
					}
				}
			}
			return false;
		}

		// Token: 0x06025FA4 RID: 155556 RVA: 0x00AA897C File Offset: 0x00AA6B7C
		internal void RefreshDynamicFieldOfView()
		{
			SUiCameraAnimationSettings cameraSettings = base.CameraSettings;
			bool flag = cameraSettings != null && cameraSettings.IsDynamicFov;
			UCineCameraComponent replaceCameraComponent = this.ReplaceCameraComponent;
			bool flag2 = replaceCameraComponent != null && replaceCameraComponent.IsValid();
			if (!flag || !flag2)
			{
				return;
			}
			base.FieldOfView = UiCameraReplaceActorHandleData.CalculateDynamicFieldOfView(this.ReplaceCameraComponent.FieldOfView, this.ReplaceCameraComponent.AspectRatio);
		}

		// Token: 0x06025FA5 RID: 155557 RVA: 0x00AA89D8 File Offset: 0x00AA6BD8
		private static FVectorDouble CalculateCameraCenterLocation(FVectorDouble targetActorLocation, FVectorDouble cameraLocation, FRotator cameraRotation)
		{
			FVector fvector = targetActorLocation;
			FVector fvector2 = cameraLocation;
			float num = FVector.Dist2D(fvector, fvector2);
			float degVal = MathCommon.WrapAngle(cameraRotation.Pitch);
			double inZ = cameraLocation.Z + (double)(num * MathF.Tan(MathCommon.DegreeToRadian(degVal)));
			return new FVectorDouble(targetActorLocation.X, targetActorLocation.Y, inZ);
		}

		// Token: 0x06025FA6 RID: 155558 RVA: 0x00AA8A34 File Offset: 0x00AA6C34
		private static float CalculateDynamicFieldOfView(float fieldOfView, float baseAspectRatio)
		{
			Vector2D viewportSize = UiLayer.Instance.GetViewportSize();
			if (viewportSize.Y <= 0.0)
			{
				return fieldOfView;
			}
			float num = (float)(viewportSize.X / viewportSize.Y);
			float num2 = MathCommon.DegreeToRadian(fieldOfView);
			return MathF.Max(MathCommon.RadianToDegree(MathF.Atan(baseAspectRatio / num * MathF.Tan(num2 / 2f)) * 2f), fieldOfView);
		}

		// Token: 0x04014E17 RID: 85527
		private ACineCameraActor ReplaceCameraActor;

		// Token: 0x04014E18 RID: 85528
		private UCineCameraComponent ReplaceCameraComponent;
	}
}
