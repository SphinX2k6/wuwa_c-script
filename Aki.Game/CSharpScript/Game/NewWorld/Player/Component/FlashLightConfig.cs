using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Character.Role.Common.Data.Structure;
using UnrealEngine;

namespace CSharpScript.Game.NewWorld.Player.Component
{
	// Token: 0x020061D8 RID: 25048
	[NullableContext(1)]
	[Nullable(0)]
	public class FlashLightConfig
	{
		// Token: 0x0603C1D5 RID: 246229 RVA: 0x0111C3B0 File Offset: 0x0111A5B0
		public void Init(BP_FlashLightConfig_C asset)
		{
			Transform relativeTrans = this.RelativeTrans;
			FTransform relativeTrans2 = asset.RelativeTrans;
			relativeTrans.FromUeTransform(relativeTrans2);
			this.Intensity = asset.Intensity;
			this.AttenuationRadius = asset.AttenuationRadius;
			this.InnerConeAngle = asset.InnerConeAngle;
			this.OuterConeAngle = asset.OuterConeAngle;
			this.SpecularScale = asset.SpecularScale;
			this.LightFalloffExponent = asset.LightFalloffExponent;
			this.VolumetricScatteringIntensity = asset.VolumetricScatteringIntensity;
			this.LightColor = asset.LightColor;
			this.ToonRealTimeShadowIntensity = asset.ToonRealTimeShadowIntensity;
			this.ToonPointLightFallOff = asset.ToonPointLightFallOff;
			this.ToonDistanceBlendIntensity = asset.ToonDistanceBlendIntensity;
			this.ToonIntensity = asset.ToonIntensity;
			this.ToonLightingPriority = asset.ToonLightingPriority;
			this.ToonShadowColorIntensity = asset.ToonShadowColorIntensity;
			this.LightToonColor = asset.LightToonColor;
			this.IESTexture = asset.IESTexture;
			this.IsUseCameraPitch = asset.UseCameraPitch;
			this.IsUsePitchLerp = asset.UsePitchLerp;
			this.MinTurnSpeed = asset.MinTurnSpeed;
			this.MaxTurnSpeed = asset.MaxTurnSpeed;
			this.LerpBeginDeg = asset.LerpBeginDeg;
			this.LerpPow = asset.LerpPow;
			this.LerpCurve = asset.LerpCurve;
		}

		// Token: 0x0603C1D6 RID: 246230 RVA: 0x0111C4E8 File Offset: 0x0111A6E8
		public bool IsValid()
		{
			return this.Intensity >= 0f && this.AttenuationRadius >= 0f && this.MaxTurnSpeed >= this.MinTurnSpeed && this.MinTurnSpeed > 0f && this.OuterConeAngle >= this.InnerConeAngle && this.InnerConeAngle > 0f && (!this.IsUsePitchLerp || this.LerpCurve != null || this.LerpPow != 0f);
		}

		// Token: 0x0603C1D7 RID: 246231 RVA: 0x0111C56C File Offset: 0x0111A76C
		public float GetLerpDegAlpha(float inAlpha)
		{
			float num = MathUtils.Instance.Clamp(inAlpha, 0f, 1f);
			UCurveFloat lerpCurve = this.LerpCurve;
			if (lerpCurve != null && lerpCurve.IsValid())
			{
				return MathUtils.Instance.Clamp(this.LerpCurve.GetFloatValue(num), 0f, 1f);
			}
			return (float)Math.Pow((double)num, (double)this.LerpPow);
		}

		// Token: 0x0401FCEF RID: 130287
		public Transform RelativeTrans = Transform.Create();

		// Token: 0x0401FCF0 RID: 130288
		public float Intensity;

		// Token: 0x0401FCF1 RID: 130289
		public float AttenuationRadius;

		// Token: 0x0401FCF2 RID: 130290
		public float InnerConeAngle;

		// Token: 0x0401FCF3 RID: 130291
		public float OuterConeAngle;

		// Token: 0x0401FCF4 RID: 130292
		public float SpecularScale;

		// Token: 0x0401FCF5 RID: 130293
		public float LightFalloffExponent;

		// Token: 0x0401FCF6 RID: 130294
		public float VolumetricScatteringIntensity;

		// Token: 0x0401FCF7 RID: 130295
		public FLinearColor LightColor = new FLinearColor();

		// Token: 0x0401FCF8 RID: 130296
		public float ToonPointLightFallOff;

		// Token: 0x0401FCF9 RID: 130297
		public float ToonDistanceBlendIntensity;

		// Token: 0x0401FCFA RID: 130298
		public float ToonIntensity;

		// Token: 0x0401FCFB RID: 130299
		public int ToonLightingPriority;

		// Token: 0x0401FCFC RID: 130300
		public float ToonShadowColorIntensity;

		// Token: 0x0401FCFD RID: 130301
		public float ToonRealTimeShadowIntensity;

		// Token: 0x0401FCFE RID: 130302
		public FLinearColor LightToonColor = new FLinearColor();

		// Token: 0x0401FCFF RID: 130303
		[Nullable(2)]
		public UTextureLightProfile IESTexture;

		// Token: 0x0401FD00 RID: 130304
		public bool IsUseCameraPitch;

		// Token: 0x0401FD01 RID: 130305
		public bool IsUsePitchLerp;

		// Token: 0x0401FD02 RID: 130306
		public float MinTurnSpeed;

		// Token: 0x0401FD03 RID: 130307
		public float MaxTurnSpeed;

		// Token: 0x0401FD04 RID: 130308
		public float LerpBeginDeg;

		// Token: 0x0401FD05 RID: 130309
		public float LerpPow;

		// Token: 0x0401FD06 RID: 130310
		[Nullable(2)]
		public UCurveFloat LerpCurve;
	}
}
