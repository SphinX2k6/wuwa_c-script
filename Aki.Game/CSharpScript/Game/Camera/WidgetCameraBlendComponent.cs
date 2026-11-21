using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Character.BaseCharacter.Camera;
using UnrealEngine;

namespace CSharpScript.Game.Camera
{
	// Token: 0x02006467 RID: 25703
	[NullableContext(2)]
	[Nullable(0)]
	public class WidgetCameraBlendComponent : EntityComponent
	{
		// Token: 0x170076E0 RID: 30432
		// (get) Token: 0x0603E746 RID: 255814 RVA: 0x0122C23F File Offset: 0x0122A43F
		// (set) Token: 0x0603E747 RID: 255815 RVA: 0x0122C247 File Offset: 0x0122A447
		private WidgetCameraDisplayComponent DisplayComponent { get; set; }

		// Token: 0x0603E748 RID: 255816 RVA: 0x0122C250 File Offset: 0x0122A450
		public void SetBlendParams(float blendTime, EViewTargetBlendFunction blendFunction, byte blendExp, bool blendLocation, bool isRelativeLocation, bool overrideLocation, FVectorDouble newLocation, bool blendRotation, bool isRelativeRotation, bool overrideRotation, FRotator newRotation)
		{
			this.BlendTime = blendTime;
			this.BlendTimeToGo = blendTime;
			this.BlendFunction = blendFunction;
			this.BlendExp = (EEasingFunc)blendExp;
			this.BlendLocation = blendLocation;
			if (this.BlendLocation)
			{
				this.IsRelativeLocation = isRelativeLocation;
				BP_CineCamera_C cineCamera = this.DisplayComponent.CineCamera;
				if (this.IsRelativeLocation)
				{
					FVectorDouble value = UKismetMathLibrary.Conv_VectorToVectorDouble(cineCamera.SceneComponent.RelativeLocation);
					this.PreBlendLocation = new FVectorDouble?(value);
				}
				else
				{
					this.PreBlendLocation = new FVectorDouble?(cineCamera.D_K2_GetActorLocation());
				}
				if (overrideLocation)
				{
					this.TargetLocation.FromUeVector(newLocation);
				}
				else
				{
					Vector targetLocation = this.TargetLocation;
					FVectorDouble value2 = this.PreBlendLocation.Value;
					FVectorDouble fvectorDouble = value2 + newLocation;
					targetLocation.FromUeVector(fvectorDouble);
				}
				this.BlendRotation = blendRotation;
				if (this.BlendRotation)
				{
					this.IsRelativeRotation = isRelativeRotation;
					this.PreBlendRotation = new FRotator?(this.IsRelativeRotation ? cineCamera.SceneComponent.RelativeRotation : cineCamera.K2_GetActorRotation());
					if (overrideRotation)
					{
						this.TargetRotation = new FRotator?(newRotation);
						return;
					}
					FRotator frotator = newRotation;
					FRotator? preBlendRotation = this.PreBlendRotation;
					FRotator? targetRotation;
					if (preBlendRotation == null)
					{
						targetRotation = null;
					}
					else
					{
						FRotator valueOrDefault = preBlendRotation.GetValueOrDefault();
						targetRotation = new FRotator?(frotator + valueOrDefault);
					}
					this.TargetRotation = targetRotation;
				}
			}
		}

		// Token: 0x0603E749 RID: 255817 RVA: 0x0122C39C File Offset: 0x0122A59C
		protected override bool OnStart()
		{
			this.DisplayComponent = base.Entity.GetComponent<WidgetCameraDisplayComponent>();
			return this.DisplayComponent.Valid;
		}

		// Token: 0x0603E74A RID: 255818 RVA: 0x0122C3BA File Offset: 0x0122A5BA
		protected override bool OnEnd()
		{
			this.DisplayComponent = null;
			return true;
		}

		// Token: 0x0603E74B RID: 255819 RVA: 0x0122C3C4 File Offset: 0x0122A5C4
		protected override void OnTick(float deltaSeconds)
		{
			float val = this.BlendTimeToGo - deltaSeconds;
			float val2 = 0f;
			this.BlendTimeToGo = Math.Max(val, val2);
			float blendPercent = this.UpdateBlendPct();
			this.UpdateLocation(blendPercent);
			this.UpdateRotation(blendPercent);
		}

		// Token: 0x0603E74C RID: 255820 RVA: 0x0122C404 File Offset: 0x0122A604
		private void UpdateLocation(float blendPercent)
		{
			if (this.BlendLocation)
			{
				FVectorDouble newRelativeLocation = UKismetMathLibrary.D_VLerp(this.PreBlendLocation.Value, this.TargetLocation.ToUeVector(false), (double)blendPercent);
				double tolerance = 0.1;
				BP_CineCamera_C cineCamera = this.DisplayComponent.CineCamera;
				if (this.IsRelativeLocation)
				{
					FHitResult fhitResult = new FHitResult();
					cineCamera.D_K2_SetActorRelativeLocation(newRelativeLocation, false, ref fhitResult, false);
					if (Vector.Create(cineCamera.SceneComponent.RelativeLocation).Equals(this.TargetLocation, tolerance))
					{
						this.BlendLocation = false;
						return;
					}
				}
				else
				{
					FHitResult fhitResult2 = new FHitResult();
					cineCamera.D_K2_SetActorRelativeLocation(newRelativeLocation, false, ref fhitResult2, false);
					if (Vector.Create(cineCamera.D_K2_GetActorLocation()).Equals(this.TargetLocation, tolerance))
					{
						this.BlendLocation = false;
					}
				}
			}
		}

		// Token: 0x0603E74D RID: 255821 RVA: 0x0122C4CC File Offset: 0x0122A6CC
		private void UpdateRotation(float blendPercent)
		{
			if (this.BlendRotation)
			{
				FRotator newRelativeRotation = UKismetMathLibrary.RLerp(this.PreBlendRotation.Value, this.TargetRotation.Value, blendPercent, true);
				float errorTolerance = 0.1f;
				BP_CineCamera_C cineCamera = this.DisplayComponent.CineCamera;
				if (this.IsRelativeRotation)
				{
					FHitResult fhitResult = new FHitResult();
					cineCamera.K2_SetActorRelativeRotation(newRelativeRotation, false, ref fhitResult, false);
					if (UKismetMathLibrary.EqualEqual_RotatorRotator(cineCamera.SceneComponent.RelativeRotation, this.TargetRotation.Value, errorTolerance))
					{
						this.BlendLocation = false;
						return;
					}
				}
				else
				{
					FHitResult fhitResult2 = new FHitResult();
					cineCamera.K2_SetActorRelativeRotation(newRelativeRotation, false, ref fhitResult2, false);
					if (UKismetMathLibrary.EqualEqual_RotatorRotator(cineCamera.K2_GetActorRotation(), this.TargetRotation.Value, errorTolerance))
					{
						this.BlendLocation = false;
					}
				}
			}
		}

		// Token: 0x0603E74E RID: 255822 RVA: 0x0122C588 File Offset: 0x0122A788
		private float UpdateBlendPct()
		{
			float alpha = (float)MathUtils.Instance.SafeDivide((double)(this.BlendTime - this.BlendTimeToGo), (double)this.BlendTime);
			float result = 0f;
			float num = 0f;
			float num2 = 1f;
			float exponent = 3f;
			switch (this.BlendFunction)
			{
			case EViewTargetBlendFunction.VTBlend_Linear:
				result = MathUtils.Instance.Lerp(num, num2, alpha);
				break;
			case EViewTargetBlendFunction.VTBlend_Cubic:
				result = UKismetMathLibrary.FInterpEaseInOut(num, num2, alpha, exponent);
				break;
			case EViewTargetBlendFunction.VTBlend_EaseIn:
				result = UKismetMathLibrary.Ease(num, num2, alpha, this.BlendExp, 2f, 2);
				break;
			case EViewTargetBlendFunction.VTBlend_EaseOut:
				result = UKismetMathLibrary.Ease(num, num2, alpha, this.BlendExp, 2f, 2);
				break;
			case EViewTargetBlendFunction.VTBlend_EaseInOut:
				result = UKismetMathLibrary.Ease(num, num2, alpha, this.BlendExp, 2f, 2);
				break;
			}
			return result;
		}

		// Token: 0x0603E74F RID: 255823 RVA: 0x0122C658 File Offset: 0x0122A858
		[NullableContext(1)]
		public override bool ClearComponent(EntityComponent componentTemplate)
		{
			if (!base.ClearComponent(componentTemplate))
			{
				return false;
			}
			WidgetCameraBlendComponent widgetCameraBlendComponent = (WidgetCameraBlendComponent)componentTemplate;
			this.BlendTimeToGo = widgetCameraBlendComponent.BlendTimeToGo;
			this.BlendTime = widgetCameraBlendComponent.BlendTime;
			this.BlendFunction = widgetCameraBlendComponent.BlendFunction;
			this.BlendExp = widgetCameraBlendComponent.BlendExp;
			if (widgetCameraBlendComponent.TargetLocation != null && !base.CheckClearObject(EntityComponentSystem.ClearObject(this.TargetLocation), "TargetLocation"))
			{
				return false;
			}
			this.TargetRotation = widgetCameraBlendComponent.TargetRotation;
			this.BlendLocation = widgetCameraBlendComponent.BlendLocation;
			this.BlendRotation = widgetCameraBlendComponent.BlendRotation;
			this.PreBlendRotation = widgetCameraBlendComponent.PreBlendRotation;
			this.PreBlendLocation = widgetCameraBlendComponent.PreBlendLocation;
			this.IsRelativeLocation = widgetCameraBlendComponent.IsRelativeLocation;
			this.IsRelativeRotation = widgetCameraBlendComponent.IsRelativeRotation;
			if (widgetCameraBlendComponent.DisplayComponent == null)
			{
				this.DisplayComponent = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.DisplayComponent), "DisplayComponent"))
			{
				return false;
			}
			return true;
		}

		// Token: 0x170076E1 RID: 30433
		// (get) Token: 0x0603E750 RID: 255824 RVA: 0x0122C749 File Offset: 0x0122A949
		public override bool NeedStartInternal
		{
			get
			{
				return true;
			}
		}

		// Token: 0x170076E2 RID: 30434
		// (get) Token: 0x0603E751 RID: 255825 RVA: 0x0122C74C File Offset: 0x0122A94C
		public override bool NeedEndInternal
		{
			get
			{
				return true;
			}
		}

		// Token: 0x170076E3 RID: 30435
		// (get) Token: 0x0603E752 RID: 255826 RVA: 0x0122C74F File Offset: 0x0122A94F
		public override bool NeedTickInternal
		{
			get
			{
				return true;
			}
		}

		// Token: 0x040214D5 RID: 136405
		private float BlendTimeToGo;

		// Token: 0x040214D6 RID: 136406
		private float BlendTime;

		// Token: 0x040214D7 RID: 136407
		private EViewTargetBlendFunction BlendFunction;

		// Token: 0x040214D8 RID: 136408
		private EEasingFunc BlendExp;

		// Token: 0x040214D9 RID: 136409
		[Nullable(1)]
		private readonly Vector TargetLocation = Vector.Create();

		// Token: 0x040214DA RID: 136410
		private FRotator? TargetRotation;

		// Token: 0x040214DB RID: 136411
		private bool BlendLocation;

		// Token: 0x040214DC RID: 136412
		private bool BlendRotation;

		// Token: 0x040214DD RID: 136413
		private FRotator? PreBlendRotation;

		// Token: 0x040214DE RID: 136414
		private FVectorDouble? PreBlendLocation;

		// Token: 0x040214DF RID: 136415
		private bool IsRelativeLocation;

		// Token: 0x040214E0 RID: 136416
		private bool IsRelativeRotation;
	}
}
