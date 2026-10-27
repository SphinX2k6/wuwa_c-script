using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020028AD RID: 10413
	[NullableContext(2)]
	[Nullable(0)]
	public class ICameraOffsetInMovementDirection
	{
		// Token: 0x0600E6B3 RID: 59059 RVA: 0x0021E36E File Offset: 0x0021C56E
		[NullableContext(1)]
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

		// Token: 0x1700471B RID: 18203
		// (get) Token: 0x0600E6B4 RID: 59060 RVA: 0x0021E38D File Offset: 0x0021C58D
		public virtual float MinInterpolationSpeed
		{
			get
			{
				return this.Instance.MinInterpolationSpeed;
			}
		}

		// Token: 0x1700471C RID: 18204
		// (get) Token: 0x0600E6B5 RID: 59061 RVA: 0x0021E39A File Offset: 0x0021C59A
		public virtual float MaxInterpolationSpeed
		{
			get
			{
				return this.Instance.MaxInterpolationSpeed;
			}
		}

		// Token: 0x1700471D RID: 18205
		// (get) Token: 0x0600E6B6 RID: 59062 RVA: 0x0021E3A7 File Offset: 0x0021C5A7
		public virtual float OffsetDistance1
		{
			get
			{
				return this.Instance.OffsetDistance1;
			}
		}

		// Token: 0x1700471E RID: 18206
		// (get) Token: 0x0600E6B7 RID: 59063 RVA: 0x0021E3B4 File Offset: 0x0021C5B4
		public virtual float OffsetDistance2
		{
			get
			{
				return this.Instance.OffsetDistance2;
			}
		}

		// Token: 0x1700471F RID: 18207
		// (get) Token: 0x0600E6B8 RID: 59064 RVA: 0x0021E3C1 File Offset: 0x0021C5C1
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

		// Token: 0x17004720 RID: 18208
		// (get) Token: 0x0600E6B9 RID: 59065 RVA: 0x0021E3F8 File Offset: 0x0021C5F8
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

		// Token: 0x17004721 RID: 18209
		// (get) Token: 0x0600E6BA RID: 59066 RVA: 0x0021E430 File Offset: 0x0021C630
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

		// Token: 0x04007F83 RID: 32643
		private ICameraOffsetInMovementDirection Instance;

		// Token: 0x04007F84 RID: 32644
		private IBaseCurve _OffsetCurveCache;

		// Token: 0x04007F85 RID: 32645
		private bool _OffsetCurveInited;
	}
}
