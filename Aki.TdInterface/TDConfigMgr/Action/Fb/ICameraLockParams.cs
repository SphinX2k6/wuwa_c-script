using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002B7E RID: 11134
	public class ICameraLockParams
	{
		// Token: 0x0600F4A8 RID: 62632 RVA: 0x0023ABE0 File Offset: 0x00238DE0
		public static ICameraLockParams Create(ICameraLockParams? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ICameraLockParams
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004A5A RID: 19034
		// (get) Token: 0x0600F4A9 RID: 62633 RVA: 0x0023ABFF File Offset: 0x00238DFF
		public virtual float RelativeYawHardMin
		{
			get
			{
				return this.Instance.RelativeYawHardMin;
			}
		}

		// Token: 0x17004A5B RID: 19035
		// (get) Token: 0x0600F4AA RID: 62634 RVA: 0x0023AC0C File Offset: 0x00238E0C
		public virtual float RelativeYawHardMax
		{
			get
			{
				return this.Instance.RelativeYawHardMax;
			}
		}

		// Token: 0x17004A5C RID: 19036
		// (get) Token: 0x0600F4AB RID: 62635 RVA: 0x0023AC19 File Offset: 0x00238E19
		public virtual float RelativePitchHardMin
		{
			get
			{
				return this.Instance.RelativePitchHardMin;
			}
		}

		// Token: 0x17004A5D RID: 19037
		// (get) Token: 0x0600F4AC RID: 62636 RVA: 0x0023AC26 File Offset: 0x00238E26
		public virtual float RelativePitchHardMax
		{
			get
			{
				return this.Instance.RelativePitchHardMax;
			}
		}

		// Token: 0x17004A5E RID: 19038
		// (get) Token: 0x0600F4AD RID: 62637 RVA: 0x0023AC33 File Offset: 0x00238E33
		public virtual float YawSignAdaptionLockDirection
		{
			get
			{
				return this.Instance.YawSignAdaptionLockDirection;
			}
		}

		// Token: 0x17004A5F RID: 19039
		// (get) Token: 0x0600F4AE RID: 62638 RVA: 0x0023AC40 File Offset: 0x00238E40
		public virtual float RelativeRotationLagYawSpeedMin
		{
			get
			{
				return this.Instance.RelativeRotationLagYawSpeedMin;
			}
		}

		// Token: 0x17004A60 RID: 19040
		// (get) Token: 0x0600F4AF RID: 62639 RVA: 0x0023AC4D File Offset: 0x00238E4D
		public virtual float RelativeRotationLagYawSpeedMax
		{
			get
			{
				return this.Instance.RelativeRotationLagYawSpeedMax;
			}
		}

		// Token: 0x17004A61 RID: 19041
		// (get) Token: 0x0600F4B0 RID: 62640 RVA: 0x0023AC5A File Offset: 0x00238E5A
		public virtual float RelativeRotationLagYawAngleRange
		{
			get
			{
				return this.Instance.RelativeRotationLagYawAngleRange;
			}
		}

		// Token: 0x17004A62 RID: 19042
		// (get) Token: 0x0600F4B1 RID: 62641 RVA: 0x0023AC67 File Offset: 0x00238E67
		public virtual float RelativeRotationLagPitchSpeedMin
		{
			get
			{
				return this.Instance.RelativeRotationLagPitchSpeedMin;
			}
		}

		// Token: 0x17004A63 RID: 19043
		// (get) Token: 0x0600F4B2 RID: 62642 RVA: 0x0023AC74 File Offset: 0x00238E74
		public virtual float RelativeRotationLagPitchSpeedMax
		{
			get
			{
				return this.Instance.RelativeRotationLagPitchSpeedMax;
			}
		}

		// Token: 0x17004A64 RID: 19044
		// (get) Token: 0x0600F4B3 RID: 62643 RVA: 0x0023AC81 File Offset: 0x00238E81
		public virtual float RelativeRotationLagPitchAngleRange
		{
			get
			{
				return this.Instance.RelativeRotationLagPitchAngleRange;
			}
		}

		// Token: 0x17004A65 RID: 19045
		// (get) Token: 0x0600F4B4 RID: 62644 RVA: 0x0023AC8E File Offset: 0x00238E8E
		public virtual float RelativeRotationLagRatioMin
		{
			get
			{
				return this.Instance.RelativeRotationLagRatioMin;
			}
		}

		// Token: 0x17004A66 RID: 19046
		// (get) Token: 0x0600F4B5 RID: 62645 RVA: 0x0023AC9B File Offset: 0x00238E9B
		public virtual float RelativeRotationLagRatioMax
		{
			get
			{
				return this.Instance.RelativeRotationLagRatioMax;
			}
		}

		// Token: 0x17004A67 RID: 19047
		// (get) Token: 0x0600F4B6 RID: 62646 RVA: 0x0023ACA8 File Offset: 0x00238EA8
		public virtual float RelativeRotationLagDistanceRangeMin
		{
			get
			{
				return this.Instance.RelativeRotationLagDistanceRangeMin;
			}
		}

		// Token: 0x17004A68 RID: 19048
		// (get) Token: 0x0600F4B7 RID: 62647 RVA: 0x0023ACB5 File Offset: 0x00238EB5
		public virtual float RelativeRotationLagDistanceRangeMax
		{
			get
			{
				return this.Instance.RelativeRotationLagDistanceRangeMax;
			}
		}

		// Token: 0x0400862A RID: 34346
		private ICameraLockParams Instance;
	}
}
