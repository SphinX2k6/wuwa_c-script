using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002B82 RID: 11138
	[NullableContext(2)]
	[Nullable(0)]
	public class ICameraOffsetInMovementDirection
	{
		// Token: 0x0600F4E2 RID: 62690 RVA: 0x0023B2EE File Offset: 0x002394EE
		[NullableContext(0)]
		public static ICameraOffsetInMovementDirection Create(ICameraOffsetInMovementDirection? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ICameraOffsetInMovementDirection
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004A8C RID: 19084
		// (get) Token: 0x0600F4E3 RID: 62691 RVA: 0x0023B30D File Offset: 0x0023950D
		public virtual float MinInterpolationSpeed
		{
			get
			{
				return this.Instance.MinInterpolationSpeed;
			}
		}

		// Token: 0x17004A8D RID: 19085
		// (get) Token: 0x0600F4E4 RID: 62692 RVA: 0x0023B31A File Offset: 0x0023951A
		public virtual float MaxInterpolationSpeed
		{
			get
			{
				return this.Instance.MaxInterpolationSpeed;
			}
		}

		// Token: 0x17004A8E RID: 19086
		// (get) Token: 0x0600F4E5 RID: 62693 RVA: 0x0023B327 File Offset: 0x00239527
		public virtual float OffsetDistance1
		{
			get
			{
				return this.Instance.OffsetDistance1;
			}
		}

		// Token: 0x17004A8F RID: 19087
		// (get) Token: 0x0600F4E6 RID: 62694 RVA: 0x0023B334 File Offset: 0x00239534
		public virtual float OffsetDistance2
		{
			get
			{
				return this.Instance.OffsetDistance2;
			}
		}

		// Token: 0x17004A90 RID: 19088
		// (get) Token: 0x0600F4E7 RID: 62695 RVA: 0x0023B341 File Offset: 0x00239541
		public virtual IBaseCurve OffsetCurve
		{
			get
			{
				if (this._OffsetCurveInited)
				{
					return this._OffsetCurveCache;
				}
				this._OffsetCurveInited = true;
				this._OffsetCurveCache = IBaseCurve.Create(this.Instance.OffsetCurve);
				return this._OffsetCurveCache;
			}
		}

		// Token: 0x17004A91 RID: 19089
		// (get) Token: 0x0600F4E8 RID: 62696 RVA: 0x0023B378 File Offset: 0x00239578
		public virtual int? CenteringWaitTime
		{
			get
			{
				if ((this.Instance.NullMask & 1) == 0)
				{
					return null;
				}
				return new int?(this.Instance.CenteringWaitTime);
			}
		}

		// Token: 0x17004A92 RID: 19090
		// (get) Token: 0x0600F4E9 RID: 62697 RVA: 0x0023B3B0 File Offset: 0x002395B0
		public virtual int? StartupWaitTime
		{
			get
			{
				if ((this.Instance.NullMask & 2) == 0)
				{
					return null;
				}
				return new int?(this.Instance.StartupWaitTime);
			}
		}

		// Token: 0x04008642 RID: 34370
		private ICameraOffsetInMovementDirection Instance;

		// Token: 0x04008643 RID: 34371
		private IBaseCurve _OffsetCurveCache;

		// Token: 0x04008644 RID: 34372
		private bool _OffsetCurveInited;
	}
}
