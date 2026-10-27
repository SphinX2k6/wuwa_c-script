using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.UiCameraAnimation.UiCameraContext;

// Token: 0x02002C33 RID: 11315
public class UiCameraAnimationDefine
{
	// Token: 0x0400AFEF RID: 45039
	[Nullable(1)]
	public const string DEFAULT_BLEND_NAME = "1001";

	// Token: 0x0400AFF0 RID: 45040
	[Nullable(1)]
	public const string CAMERA_ZEROTIME_BLENDNAME = "10009";

	// Token: 0x02009226 RID: 37414
	public enum ECameraAnimationAttributeType
	{
		// Token: 0x0402F45A RID: 193626
		None,
		// Token: 0x0402F45B RID: 193627
		Location,
		// Token: 0x0402F45C RID: 193628
		Rotation,
		// Token: 0x0402F45D RID: 193629
		ArmLength,
		// Token: 0x0402F45E RID: 193630
		ArmOffsetLocation,
		// Token: 0x0402F45F RID: 193631
		ArmOffsetRotation,
		// Token: 0x0402F460 RID: 193632
		CameraFieldOfView,
		// Token: 0x0402F461 RID: 193633
		FocalDistance,
		// Token: 0x0402F462 RID: 193634
		PostProcessBlendWeight,
		// Token: 0x0402F463 RID: 193635
		Aperture,
		// Token: 0x0402F464 RID: 193636
		FocalRegion
	}

	// Token: 0x02009227 RID: 37415
	public enum ECameraAnimationFinishType
	{
		// Token: 0x0402F466 RID: 193638
		Finished,
		// Token: 0x0402F467 RID: 193639
		Stop
	}

	// Token: 0x02009228 RID: 37416
	public enum EPlayCameraHandleResult
	{
		// Token: 0x0402F469 RID: 193641
		Fail,
		// Token: 0x0402F46A RID: 193642
		PlayAnimation,
		// Token: 0x0402F46B RID: 193643
		RevertAnimation,
		// Token: 0x0402F46C RID: 193644
		Activate
	}

	// Token: 0x02009229 RID: 37417
	[NullableContext(1)]
	public interface IFinishData
	{
		// Token: 0x1700A0A3 RID: 41123
		// (get) Token: 0x0604BE40 RID: 310848
		UiCameraAnimationDefine.ECameraAnimationFinishType FinishType { get; }

		// Token: 0x1700A0A4 RID: 41124
		// (get) Token: 0x0604BE41 RID: 310849
		UiCameraHandleData FromHandleData { get; }

		// Token: 0x1700A0A5 RID: 41125
		// (get) Token: 0x0604BE42 RID: 310850
		UiCameraHandleData ToHandleData { get; }
	}

	// Token: 0x0200922A RID: 37418
	[NullableContext(1)]
	[Nullable(0)]
	public class FinishData : UiCameraAnimationDefine.IFinishData
	{
		// Token: 0x1700A0A6 RID: 41126
		// (get) Token: 0x0604BE43 RID: 310851 RVA: 0x014019A6 File Offset: 0x013FFBA6
		// (set) Token: 0x0604BE44 RID: 310852 RVA: 0x014019AE File Offset: 0x013FFBAE
		public UiCameraAnimationDefine.ECameraAnimationFinishType FinishType { get; set; }

		// Token: 0x1700A0A7 RID: 41127
		// (get) Token: 0x0604BE45 RID: 310853 RVA: 0x014019B7 File Offset: 0x013FFBB7
		// (set) Token: 0x0604BE46 RID: 310854 RVA: 0x014019BF File Offset: 0x013FFBBF
		public UiCameraHandleData FromHandleData { get; set; }

		// Token: 0x1700A0A8 RID: 41128
		// (get) Token: 0x0604BE47 RID: 310855 RVA: 0x014019C8 File Offset: 0x013FFBC8
		// (set) Token: 0x0604BE48 RID: 310856 RVA: 0x014019D0 File Offset: 0x013FFBD0
		public UiCameraHandleData ToHandleData { get; set; }
	}

	// Token: 0x0200922B RID: 37419
	[NullableContext(1)]
	[Nullable(0)]
	public class IUiCameraMapping
	{
		// Token: 0x0604BE4A RID: 310858 RVA: 0x014019E4 File Offset: 0x013FFBE4
		public IUiCameraMapping(UiCameraMapping config)
		{
			this.Id = config.Id;
			this.ViewName = config.ViewName;
			this.DefaultUiCameraSettingsName = config.DefaultUiCameraSettingsName;
			this.PlayLoadingCameraAnimation = config.BPlayLoadingCameraAnimation;
			this.BodyTargetType = config.BodyTargetType;
			this.DefaultCameraBlendName = config.DefaultCameraBlendName;
			this.UiCameraDelayTime = (float)config.UiCameraDelayTime;
			this.BodyCameraSettingsNameMap = config.BodyCameraSettingsNameMap();
			this.UiCameraBlendNameMap = config.UiCameraBlendNameMap();
		}

		// Token: 0x0604BE4B RID: 310859 RVA: 0x01401A70 File Offset: 0x013FFC70
		public IUiCameraMapping(ChildUiCameraMapping config)
		{
			this.Id = config.Id;
			this.ViewName = config.ViewName;
			this.DefaultUiCameraSettingsName = config.DefaultUiCameraSettingsName;
			this.PlayLoadingCameraAnimation = config.BPlayLoadingCameraAnimation;
			this.BodyTargetType = config.BodyTargetType;
			this.DefaultCameraBlendName = config.DefaultCameraBlendName;
			this.UiCameraDelayTime = (float)config.UiCameraDelayTime;
			this.BodyCameraSettingsNameMap = config.BodyCameraSettingsNameMap();
			this.UiCameraBlendNameMap = config.UiCameraBlendNameMap();
		}

		// Token: 0x1700A0A9 RID: 41129
		// (get) Token: 0x0604BE4C RID: 310860 RVA: 0x01401AF9 File Offset: 0x013FFCF9
		public int Id { get; }

		// Token: 0x1700A0AA RID: 41130
		// (get) Token: 0x0604BE4D RID: 310861 RVA: 0x01401B01 File Offset: 0x013FFD01
		public string ViewName { get; }

		// Token: 0x1700A0AB RID: 41131
		// (get) Token: 0x0604BE4E RID: 310862 RVA: 0x01401B09 File Offset: 0x013FFD09
		public string DefaultUiCameraSettingsName { get; }

		// Token: 0x1700A0AC RID: 41132
		// (get) Token: 0x0604BE4F RID: 310863 RVA: 0x01401B11 File Offset: 0x013FFD11
		public bool PlayLoadingCameraAnimation { get; }

		// Token: 0x1700A0AD RID: 41133
		// (get) Token: 0x0604BE50 RID: 310864 RVA: 0x01401B19 File Offset: 0x013FFD19
		public int BodyTargetType { get; }

		// Token: 0x1700A0AE RID: 41134
		// (get) Token: 0x0604BE51 RID: 310865 RVA: 0x01401B21 File Offset: 0x013FFD21
		public Dictionary<string, string> BodyCameraSettingsNameMap { get; }

		// Token: 0x1700A0AF RID: 41135
		// (get) Token: 0x0604BE52 RID: 310866 RVA: 0x01401B29 File Offset: 0x013FFD29
		public string DefaultCameraBlendName { get; }

		// Token: 0x1700A0B0 RID: 41136
		// (get) Token: 0x0604BE53 RID: 310867 RVA: 0x01401B31 File Offset: 0x013FFD31
		public float UiCameraDelayTime { get; }

		// Token: 0x1700A0B1 RID: 41137
		// (get) Token: 0x0604BE54 RID: 310868 RVA: 0x01401B39 File Offset: 0x013FFD39
		public Dictionary<string, string> UiCameraBlendNameMap { get; }
	}

	// Token: 0x0200922C RID: 37420
	public enum EPlayBlendCameraSequenceResult
	{
		// Token: 0x0402F47A RID: 193658
		Success,
		// Token: 0x0402F47B RID: 193659
		PathIsEmpty,
		// Token: 0x0402F47C RID: 193660
		TargetActorNotFound
	}
}
