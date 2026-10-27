using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020028C0 RID: 10432
	[NullableContext(1)]
	[Nullable(0)]
	public class IResetFocusConfig
	{
		// Token: 0x0600E7CD RID: 59341 RVA: 0x00220931 File Offset: 0x0021EB31
		public static IResetFocusConfig Create(IResetFocusConfig? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IResetFocusConfig
			{
				Instance = instance.Value
			};
		}

		// Token: 0x1700480F RID: 18447
		// (get) Token: 0x0600E7CE RID: 59342 RVA: 0x00220950 File Offset: 0x0021EB50
		public virtual float FadeInTime
		{
			get
			{
				return this.Instance.FadeInTime;
			}
		}

		// Token: 0x17004810 RID: 18448
		// (get) Token: 0x0600E7CF RID: 59343 RVA: 0x0022095D File Offset: 0x0021EB5D
		public virtual IBaseCurve FadeInCurve
		{
			get
			{
				if (this._FadeInCurveInited)
				{
					return this._FadeInCurveCache;
				}
				this._FadeInCurveInited = true;
				this._FadeInCurveCache = IBaseCurve.Create(this.Instance.FadeInCurve);
				return this._FadeInCurveCache;
			}
		}

		// Token: 0x04008024 RID: 32804
		private IResetFocusConfig Instance;

		// Token: 0x04008025 RID: 32805
		[Nullable(2)]
		private IBaseCurve _FadeInCurveCache;

		// Token: 0x04008026 RID: 32806
		private bool _FadeInCurveInited;
	}
}
