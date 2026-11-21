using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002B95 RID: 11157
	public class IResetFocusConfig
	{
		// Token: 0x0600F5FC RID: 62972 RVA: 0x0023D8B1 File Offset: 0x0023BAB1
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

		// Token: 0x17004B80 RID: 19328
		// (get) Token: 0x0600F5FD RID: 62973 RVA: 0x0023D8D0 File Offset: 0x0023BAD0
		public virtual float FadeInTime
		{
			get
			{
				return this.Instance.FadeInTime;
			}
		}

		// Token: 0x17004B81 RID: 19329
		// (get) Token: 0x0600F5FE RID: 62974 RVA: 0x0023D8DD File Offset: 0x0023BADD
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

		// Token: 0x040086E3 RID: 34531
		private IResetFocusConfig Instance;

		// Token: 0x040086E4 RID: 34532
		[Nullable(2)]
		private IBaseCurve _FadeInCurveCache;

		// Token: 0x040086E5 RID: 34533
		private bool _FadeInCurveInited;
	}
}
