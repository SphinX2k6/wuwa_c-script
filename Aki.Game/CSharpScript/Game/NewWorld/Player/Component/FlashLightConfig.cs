using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Character.Role.Common.Data.Structure;
using UnrealEngine;

namespace CSharpScript.Game.NewWorld.Player.Component
{
	// Token: 0x02007057 RID: 28759
	[NullableContext(1)]
	[Nullable(0)]
	public class FlashLightConfig
	{
		// Token: 0x06045FE7 RID: 286695 RVA: 0x011726F0 File Offset: 0x011708F0
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

		// Token: 0x06045FE8 RID: 286696 RVA: 0x01172828 File Offset: 0x01170A28
		public bool IsValid()
		{
			return this.Intensity >= 0f && this.AttenuationRadius >= 0f && this.MaxTurnSpeed >= this.MinTurnSpeed && this.MinTurnSpeed > 0f && this.OuterConeAngle >= this.InnerConeAngle && this.InnerConeAngle > 0f && (!this.IsUsePitchLerp || this.LerpCurve != null || this.LerpPow != 0f);
		}

		// Token: 0x06045FE9 RID: 286697 RVA: 0x011728AC File Offset: 0x01170AAC
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

		// Token: 0x04024A39 RID: 150073
		public Transform RelativeTrans = Transform.Create();

		// Token: 0x04024A3A RID: 150074
		public float Intensity;

		// Token: 0x04024A3B RID: 150075
		public float AttenuationRadius;

		// Token: 0x04024A3C RID: 150076
		public float InnerConeAngle;

		// Token: 0x04024A3D RID: 150077
		public float OuterConeAngle;

		// Token: 0x04024A3E RID: 150078
		public float SpecularScale;

		// Token: 0x04024A3F RID: 150079
		public float LightFalloffExponent;

		// Token: 0x04024A40 RID: 150080
		public float VolumetricScatteringIntensity;

		// Token: 0x04024A41 RID: 150081
		public FLinearColor LightColor = new FLinearColor();

		// Token: 0x04024A42 RID: 150082
		public float ToonPointLightFallOff;

		// Token: 0x04024A43 RID: 150083
		public float ToonDistanceBlendIntensity;

		// Token: 0x04024A44 RID: 150084
		public float ToonIntensity;

		// Token: 0x04024A45 RID: 150085
		public int ToonLightingPriority;

		// Token: 0x04024A46 RID: 150086
		public float ToonShadowColorIntensity;

		// Token: 0x04024A47 RID: 150087
		public float ToonRealTimeShadowIntensity;

		// Token: 0x04024A48 RID: 150088
		public FLinearColor LightToonColor = new FLinearColor();

		// Token: 0x04024A49 RID: 150089
		[Nullable(2)]
		public UTextureLightProfile IESTexture;

		// Token: 0x04024A4A RID: 150090
		public bool IsUseCameraPitch;

		// Token: 0x04024A4B RID: 150091
		public bool IsUsePitchLerp;

		// Token: 0x04024A4C RID: 150092
		public float MinTurnSpeed;

		// Token: 0x04024A4D RID: 150093
		public float MaxTurnSpeed;

		// Token: 0x04024A4E RID: 150094
		public float LerpBeginDeg;

		// Token: 0x04024A4F RID: 150095
		public float LerpPow;

		// Token: 0x04024A50 RID: 150096
		[Nullable(2)]
		public UCurveFloat LerpCurve;
	}
}
