using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Character.BaseCharacter.Camera;
using UnrealEngine;

namespace CSharpScript.Game.Camera
{
	// Token: 0x020072E4 RID: 29412
	[NullableContext(2)]
	[Nullable(0)]
	public class WidgetCameraBlendComponent : EntityComponent
	{
		// Token: 0x17009F49 RID: 40777
		// (get) Token: 0x06048302 RID: 295682 RVA: 0x012897FB File Offset: 0x012879FB
		// (set) Token: 0x06048303 RID: 295683 RVA: 0x01289803 File Offset: 0x01287A03
		private WidgetCameraDisplayComponent DisplayComponent { get; set; }

		// Token: 0x06048304 RID: 295684 RVA: 0x0128980C File Offset: 0x01287A0C
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

		// Token: 0x06048305 RID: 295685 RVA: 0x01289958 File Offset: 0x01287B58
		protected override bool OnStart()
		{
			this.DisplayComponent = base.Entity.GetComponent<WidgetCameraDisplayComponent>();
			return this.DisplayComponent.Valid;
		}

		// Token: 0x06048306 RID: 295686 RVA: 0x01289976 File Offset: 0x01287B76
		protected override bool OnEnd()
		{
			this.DisplayComponent = null;
			return true;
		}

		// Token: 0x06048307 RID: 295687 RVA: 0x01289980 File Offset: 0x01287B80
		protected override void OnTick(float deltaSeconds)
		{
			float val = this.BlendTimeToGo - deltaSeconds;
			float val2 = 0f;
			this.BlendTimeToGo = Math.Max(val, val2);
			float blendPercent = this.UpdateBlendPct();
			this.UpdateLocation(blendPercent);
			this.UpdateRotation(blendPercent);
		}

		// Token: 0x06048308 RID: 295688 RVA: 0x012899C0 File Offset: 0x01287BC0
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

		// Token: 0x06048309 RID: 295689 RVA: 0x01289A88 File Offset: 0x01287C88
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

		// Token: 0x0604830A RID: 295690 RVA: 0x01289B44 File Offset: 0x01287D44
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

		// Token: 0x0604830B RID: 295691 RVA: 0x01289C14 File Offset: 0x01287E14
		[NullableContext(1)]
		public override bool ClearComponent(EntityComponent componentTemplate)
		{
			if (!base.ClearComponent(componentTemplate))
			{
				return false;
			}
			WidgetCameraBlendComponent widgetCameraBlendComponent = (WidgetCameraBlendComponent)componentTemplate;
			if (base.CanResetComponentProperty("BlendTimeToGo"))
			{
				this.BlendTimeToGo = widgetCameraBlendComponent.BlendTimeToGo;
			}
			if (base.CanResetComponentProperty("BlendTime"))
			{
				this.BlendTime = widgetCameraBlendComponent.BlendTime;
			}
			if (base.CanResetComponentProperty("BlendFunction"))
			{
				this.BlendFunction = widgetCameraBlendComponent.BlendFunction;
			}
			if (base.CanResetComponentProperty("BlendExp"))
			{
				this.BlendExp = widgetCameraBlendComponent.BlendExp;
			}
			if (base.CanResetComponentProperty("TargetLocation") && widgetCameraBlendComponent.TargetLocation != null && !base.CheckClearObject(EntityComponentSystem.ClearObject<Vector>(this.TargetLocation), "TargetLocation"))
			{
				return false;
			}
			if (base.CanResetComponentProperty("TargetRotation"))
			{
				this.TargetRotation = widgetCameraBlendComponent.TargetRotation;
			}
			if (base.CanResetComponentProperty("BlendLocation"))
			{
				this.BlendLocation = widgetCameraBlendComponent.BlendLocation;
			}
			if (base.CanResetComponentProperty("BlendRotation"))
			{
				this.BlendRotation = widgetCameraBlendComponent.BlendRotation;
			}
			if (base.CanResetComponentProperty("PreBlendRotation"))
			{
				this.PreBlendRotation = widgetCameraBlendComponent.PreBlendRotation;
			}
			if (base.CanResetComponentProperty("PreBlendLocation"))
			{
				this.PreBlendLocation = widgetCameraBlendComponent.PreBlendLocation;
			}
			if (base.CanResetComponentProperty("IsRelativeLocation"))
			{
				this.IsRelativeLocation = widgetCameraBlendComponent.IsRelativeLocation;
			}
			if (base.CanResetComponentProperty("IsRelativeRotation"))
			{
				this.IsRelativeRotation = widgetCameraBlendComponent.IsRelativeRotation;
			}
			if (base.CanResetComponentProperty("<DisplayComponent>k__BackingField"))
			{
				if (widgetCameraBlendComponent.DisplayComponent == null)
				{
					this.DisplayComponent = null;
				}
				else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<WidgetCameraDisplayComponent>(this.DisplayComponent), "<DisplayComponent>k__BackingField"))
				{
					return false;
				}
			}
			return true;
		}

		// Token: 0x040261EA RID: 156138
		private float BlendTimeToGo;

		// Token: 0x040261EB RID: 156139
		private float BlendTime;

		// Token: 0x040261EC RID: 156140
		private EViewTargetBlendFunction BlendFunction;

		// Token: 0x040261ED RID: 156141
		private EEasingFunc BlendExp;

		// Token: 0x040261EE RID: 156142
		[Nullable(1)]
		private readonly Vector TargetLocation = Vector.Create();

		// Token: 0x040261EF RID: 156143
		private FRotator? TargetRotation;

		// Token: 0x040261F0 RID: 156144
		private bool BlendLocation;

		// Token: 0x040261F1 RID: 156145
		private bool BlendRotation;

		// Token: 0x040261F2 RID: 156146
		private FRotator? PreBlendRotation;

		// Token: 0x040261F3 RID: 156147
		private FVectorDouble? PreBlendLocation;

		// Token: 0x040261F4 RID: 156148
		private bool IsRelativeLocation;

		// Token: 0x040261F5 RID: 156149
		private bool IsRelativeRotation;
	}
}
