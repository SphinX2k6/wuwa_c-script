using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Data.UiCameraAnimation.Enum;
using AkiClient.Game.Aki.Data.UiCameraAnimation.Struct;
using UnrealEngine;

namespace CSharpScript.Game.Module.UiCamera
{
	// Token: 0x02003997 RID: 14743
	[NullableContext(1)]
	[Nullable(0)]
	public abstract class UiCameraHandleData
	{
		// Token: 0x17004D78 RID: 19832
		// (get) Token: 0x06025F62 RID: 155490 RVA: 0x00AA80D4 File Offset: 0x00AA62D4
		// (set) Token: 0x06025F63 RID: 155491 RVA: 0x00AA80DC File Offset: 0x00AA62DC
		protected EUiCameraAnimationTargetType TargetType { get; set; }

		// Token: 0x17004D79 RID: 19833
		// (get) Token: 0x06025F64 RID: 155492 RVA: 0x00AA80E5 File Offset: 0x00AA62E5
		// (set) Token: 0x06025F65 RID: 155493 RVA: 0x00AA80ED File Offset: 0x00AA62ED
		[Nullable(2)]
		protected SUiCameraAnimationSettings CameraSettings { [NullableContext(2)] get; [NullableContext(2)] set; }

		// Token: 0x17004D7A RID: 19834
		// (get) Token: 0x06025F66 RID: 155494 RVA: 0x00AA80F6 File Offset: 0x00AA62F6
		// (set) Token: 0x06025F67 RID: 155495 RVA: 0x00AA80FE File Offset: 0x00AA62FE
		protected bool SkipApply { get; set; }

		// Token: 0x17004D7B RID: 19835
		// (get) Token: 0x06025F68 RID: 155496 RVA: 0x00AA8107 File Offset: 0x00AA6307
		// (set) Token: 0x06025F69 RID: 155497 RVA: 0x00AA810F File Offset: 0x00AA630F
		protected FVectorDouble Location { get; set; }

		// Token: 0x17004D7C RID: 19836
		// (get) Token: 0x06025F6A RID: 155498 RVA: 0x00AA8118 File Offset: 0x00AA6318
		// (set) Token: 0x06025F6B RID: 155499 RVA: 0x00AA8120 File Offset: 0x00AA6320
		protected FRotator Rotation { get; set; }

		// Token: 0x17004D7D RID: 19837
		// (get) Token: 0x06025F6C RID: 155500 RVA: 0x00AA8129 File Offset: 0x00AA6329
		// (set) Token: 0x06025F6D RID: 155501 RVA: 0x00AA8131 File Offset: 0x00AA6331
		protected float ArmLength { get; set; }

		// Token: 0x17004D7E RID: 19838
		// (get) Token: 0x06025F6E RID: 155502 RVA: 0x00AA813A File Offset: 0x00AA633A
		// (set) Token: 0x06025F6F RID: 155503 RVA: 0x00AA8142 File Offset: 0x00AA6342
		protected FVectorDouble ArmOffsetLocation { get; set; }

		// Token: 0x17004D7F RID: 19839
		// (get) Token: 0x06025F70 RID: 155504 RVA: 0x00AA814B File Offset: 0x00AA634B
		// (set) Token: 0x06025F71 RID: 155505 RVA: 0x00AA8153 File Offset: 0x00AA6353
		protected FRotator ArmOffsetRotation { get; set; }

		// Token: 0x17004D80 RID: 19840
		// (get) Token: 0x06025F72 RID: 155506 RVA: 0x00AA815C File Offset: 0x00AA635C
		// (set) Token: 0x06025F73 RID: 155507 RVA: 0x00AA8164 File Offset: 0x00AA6364
		protected bool ArmCollisionTest { get; set; }

		// Token: 0x17004D81 RID: 19841
		// (get) Token: 0x06025F74 RID: 155508 RVA: 0x00AA816D File Offset: 0x00AA636D
		// (set) Token: 0x06025F75 RID: 155509 RVA: 0x00AA8175 File Offset: 0x00AA6375
		protected float FieldOfView { get; set; }

		// Token: 0x17004D82 RID: 19842
		// (get) Token: 0x06025F76 RID: 155510 RVA: 0x00AA817E File Offset: 0x00AA637E
		// (set) Token: 0x06025F77 RID: 155511 RVA: 0x00AA8186 File Offset: 0x00AA6386
		protected float FocalDistance { get; set; }

		// Token: 0x17004D83 RID: 19843
		// (get) Token: 0x06025F78 RID: 155512 RVA: 0x00AA818F File Offset: 0x00AA638F
		// (set) Token: 0x06025F79 RID: 155513 RVA: 0x00AA8197 File Offset: 0x00AA6397
		protected float Aperture { get; set; }

		// Token: 0x17004D84 RID: 19844
		// (get) Token: 0x06025F7A RID: 155514 RVA: 0x00AA81A0 File Offset: 0x00AA63A0
		// (set) Token: 0x06025F7B RID: 155515 RVA: 0x00AA81A8 File Offset: 0x00AA63A8
		protected float FocalRegion { get; set; }

		// Token: 0x17004D85 RID: 19845
		// (get) Token: 0x06025F7C RID: 155516 RVA: 0x00AA81B1 File Offset: 0x00AA63B1
		// (set) Token: 0x06025F7D RID: 155517 RVA: 0x00AA81B9 File Offset: 0x00AA63B9
		protected float PostProcessBlendWeight { get; set; }

		// Token: 0x06025F7E RID: 155518 RVA: 0x00AA81C2 File Offset: 0x00AA63C2
		protected UiCameraHandleData()
		{
		}

		// Token: 0x06025F7F RID: 155519 RVA: 0x00AA81E0 File Offset: 0x00AA63E0
		protected UiCameraHandleData(string handleName)
		{
			this.HandleName = handleName;
		}

		// Token: 0x06025F80 RID: 155520 RVA: 0x00AA8205 File Offset: 0x00AA6405
		internal void Initialize(string handleName, [Nullable(2)] string viewName)
		{
			this.HandleName = handleName;
			this.ViewName = (viewName ?? string.Empty);
		}

		// Token: 0x06025F81 RID: 155521 RVA: 0x00AA821E File Offset: 0x00AA641E
		internal void AssignHandleId(int handleId)
		{
			if (this.HandleId == 0)
			{
				this.HandleId = handleId;
			}
		}

		// Token: 0x06025F82 RID: 155522 RVA: 0x00AA822F File Offset: 0x00AA642F
		internal void SetViewId(int? viewId)
		{
			this.ViewId = viewId;
		}

		// Token: 0x06025F83 RID: 155523 RVA: 0x00AA8238 File Offset: 0x00AA6438
		internal void SetHandleName(string handleName)
		{
			this.HandleName = handleName;
		}

		// Token: 0x06025F84 RID: 155524
		public abstract bool Refresh(UiCameraModel model);

		// Token: 0x06025F85 RID: 155525 RVA: 0x00AA8244 File Offset: 0x00AA6444
		protected internal bool RefreshConfigData(UiCameraModel model)
		{
			this.ResetCameraData();
			this.CameraSettings = UiCameraConfig.Instance.GetUiCameraAnimationConfig(this.GetHandleName());
			if (this.CameraSettings == null)
			{
				return false;
			}
			this.TargetType = this.CameraSettings.TargetType;
			return this.RefreshTargetData(model);
		}

		// Token: 0x06025F86 RID: 155526 RVA: 0x00AA829C File Offset: 0x00AA649C
		protected bool RefreshTargetData(UiCameraModel model)
		{
			if (this.TargetType != EUiCameraAnimationTargetType.None)
			{
				UiCameraTargetType targetType = model.GetTargetType(this.TargetType, this.CameraSettings);
				if (targetType == null)
				{
					return false;
				}
				this.TargetActor = targetType.Actor;
				this.TargetSkeletalMesh = targetType.SkeletalMesh;
				this.TargetBodyKey = targetType.BodyKey;
			}
			return true;
		}

		// Token: 0x06025F87 RID: 155527 RVA: 0x00AA82EE File Offset: 0x00AA64EE
		public int GetHandleId()
		{
			return this.HandleId;
		}

		// Token: 0x06025F88 RID: 155528 RVA: 0x00AA82F6 File Offset: 0x00AA64F6
		public int? GetViewId()
		{
			return this.ViewId;
		}

		// Token: 0x06025F89 RID: 155529 RVA: 0x00AA82FE File Offset: 0x00AA64FE
		public string GetHandleName()
		{
			return this.HandleName;
		}

		// Token: 0x06025F8A RID: 155530 RVA: 0x00AA8306 File Offset: 0x00AA6506
		public string GetViewName()
		{
			return this.ViewName;
		}

		// Token: 0x06025F8B RID: 155531 RVA: 0x00AA830E File Offset: 0x00AA650E
		public EUiCameraAnimationTargetType GetTargetType()
		{
			return this.TargetType;
		}

		// Token: 0x06025F8C RID: 155532 RVA: 0x00AA8316 File Offset: 0x00AA6516
		[NullableContext(2)]
		public SUiCameraAnimationSettings GetUiCameraAnimationConfig()
		{
			return this.CameraSettings;
		}

		// Token: 0x06025F8D RID: 155533 RVA: 0x00AA831E File Offset: 0x00AA651E
		[NullableContext(2)]
		public AActor GetTargetActor()
		{
			return this.TargetActor;
		}

		// Token: 0x06025F8E RID: 155534 RVA: 0x00AA8326 File Offset: 0x00AA6526
		[NullableContext(2)]
		public USkeletalMeshComponent GetTargetSkeletalMesh()
		{
			return this.TargetSkeletalMesh;
		}

		// Token: 0x06025F8F RID: 155535 RVA: 0x00AA832E File Offset: 0x00AA652E
		[NullableContext(2)]
		public string GetTargetBodyKey()
		{
			return this.TargetBodyKey;
		}

		// Token: 0x06025F90 RID: 155536 RVA: 0x00AA8336 File Offset: 0x00AA6536
		public bool ShouldSkipApply()
		{
			return this.SkipApply;
		}

		// Token: 0x06025F91 RID: 155537 RVA: 0x00AA833E File Offset: 0x00AA653E
		public FVectorDouble GetTargetLocation()
		{
			return this.Location;
		}

		// Token: 0x06025F92 RID: 155538 RVA: 0x00AA8346 File Offset: 0x00AA6546
		public FRotator GetTargetRotation()
		{
			return this.Rotation;
		}

		// Token: 0x06025F93 RID: 155539 RVA: 0x00AA834E File Offset: 0x00AA654E
		public float GetTargetArmLength()
		{
			return this.ArmLength;
		}

		// Token: 0x06025F94 RID: 155540 RVA: 0x00AA8356 File Offset: 0x00AA6556
		public FVectorDouble GetTargetArmOffsetLocation()
		{
			return this.ArmOffsetLocation;
		}

		// Token: 0x06025F95 RID: 155541 RVA: 0x00AA835E File Offset: 0x00AA655E
		public FRotator GetTargetArmOffsetRotation()
		{
			return this.ArmOffsetRotation;
		}

		// Token: 0x06025F96 RID: 155542 RVA: 0x00AA8366 File Offset: 0x00AA6566
		public bool GetTargetArmCollisionTest()
		{
			return this.ArmCollisionTest;
		}

		// Token: 0x06025F97 RID: 155543 RVA: 0x00AA836E File Offset: 0x00AA656E
		public float GetTargetFieldOfView()
		{
			return this.FieldOfView;
		}

		// Token: 0x06025F98 RID: 155544 RVA: 0x00AA8376 File Offset: 0x00AA6576
		public float GetTargetFocalDistance()
		{
			return this.FocalDistance;
		}

		// Token: 0x06025F99 RID: 155545 RVA: 0x00AA837E File Offset: 0x00AA657E
		public float GetTargetAperture()
		{
			return this.Aperture;
		}

		// Token: 0x06025F9A RID: 155546 RVA: 0x00AA8386 File Offset: 0x00AA6586
		public float GetTargetFocalRegion()
		{
			return this.FocalRegion;
		}

		// Token: 0x06025F9B RID: 155547 RVA: 0x00AA838E File Offset: 0x00AA658E
		public float GetTargetPostProcessBlendWeight()
		{
			return this.PostProcessBlendWeight;
		}

		// Token: 0x06025F9C RID: 155548 RVA: 0x00AA8398 File Offset: 0x00AA6598
		public bool IsSameState(UiCameraHandleData other)
		{
			if (base.GetType() == other.GetType() && this.HandleId != 0 && this.HandleId == other.HandleId && this.HandleName == other.HandleName && this.ViewName == other.ViewName)
			{
				int? viewId = this.ViewId;
				int? viewId2 = other.ViewId;
				return viewId.GetValueOrDefault() == viewId2.GetValueOrDefault() & viewId != null == (viewId2 != null);
			}
			return false;
		}

		// Token: 0x06025F9D RID: 155549 RVA: 0x00AA8428 File Offset: 0x00AA6628
		public override string ToString()
		{
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(39, 4);
			defaultInterpolatedStringHandler.AppendLiteral("HandleId:");
			defaultInterpolatedStringHandler.AppendFormatted<int>(this.HandleId);
			defaultInterpolatedStringHandler.AppendLiteral(",ViewId:");
			defaultInterpolatedStringHandler.AppendFormatted<int?>(this.ViewId);
			defaultInterpolatedStringHandler.AppendLiteral(",HandleName:");
			defaultInterpolatedStringHandler.AppendFormatted(this.HandleName);
			defaultInterpolatedStringHandler.AppendLiteral(",ViewName:");
			defaultInterpolatedStringHandler.AppendFormatted(this.ViewName);
			return defaultInterpolatedStringHandler.ToStringAndClear();
		}

		// Token: 0x06025F9E RID: 155550 RVA: 0x00AA84AC File Offset: 0x00AA66AC
		protected void ResetCameraData()
		{
			this.TargetActor = null;
			this.TargetSkeletalMesh = null;
			this.TargetBodyKey = null;
			this.Location = FVectorDouble.ZeroVector;
			this.Rotation = FRotator.ZeroRotator;
			this.ArmLength = 0f;
			this.ArmOffsetLocation = FVectorDouble.ZeroVector;
			this.ArmOffsetRotation = FRotator.ZeroRotator;
			this.ArmCollisionTest = false;
			this.FieldOfView = 0f;
			this.FocalDistance = 0f;
			this.Aperture = 0f;
			this.FocalRegion = 0f;
			this.PostProcessBlendWeight = 0f;
		}

		// Token: 0x04014E02 RID: 85506
		private int HandleId;

		// Token: 0x04014E03 RID: 85507
		private int? ViewId;

		// Token: 0x04014E04 RID: 85508
		private string HandleName = string.Empty;

		// Token: 0x04014E05 RID: 85509
		private string ViewName = string.Empty;

		// Token: 0x04014E08 RID: 85512
		[Nullable(2)]
		private AActor TargetActor;

		// Token: 0x04014E09 RID: 85513
		[Nullable(2)]
		private USkeletalMeshComponent TargetSkeletalMesh;

		// Token: 0x04014E0A RID: 85514
		[Nullable(2)]
		private string TargetBodyKey;
	}
}
