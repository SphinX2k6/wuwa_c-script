using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001FBD RID: 8125
	public class IResetFocusConfig
	{
		// Token: 0x0600ACB1 RID: 44209 RVA: 0x00186410 File Offset: 0x00184610
		private IResetFocusConfig_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IResetFocusConfig 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IResetFocusConfig_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IResetFocusConfig_SetValue());
			}
			return result;
		}

		// Token: 0x0600ACB2 RID: 44210 RVA: 0x00186448 File Offset: 0x00184648
		public static IResetFocusConfig Create([Nullable(2)] IResetFocusConfig instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IResetFocusConfig
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600ACB3 RID: 44211 RVA: 0x0018645B File Offset: 0x0018465B
		public static IResetFocusConfig CreateFromSetValue([Nullable(2)] IResetFocusConfig_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IResetFocusConfig
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600ACB4 RID: 44212 RVA: 0x0018646E File Offset: 0x0018466E
		public IResetFocusConfig_SetValue ToSetValue()
		{
			return new IResetFocusConfig_SetValue
			{
				FadeInTime = this.FadeInTime,
				FadeInCurve = this.FadeInCurve
			};
		}

		// Token: 0x170034CB RID: 13515
		// (get) Token: 0x0600ACB5 RID: 44213 RVA: 0x0018648D File Offset: 0x0018468D
		// (set) Token: 0x0600ACB6 RID: 44214 RVA: 0x001864BC File Offset: 0x001846BC
		public virtual float FadeInTime
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.FadeInTime;
				}
				if (this.PocoInterface == null)
				{
					return 0f;
				}
				return this.PocoInterface.FadeInTime;
			}
			set
			{
				this.GetOrCreatePoco().FadeInTime = value;
			}
		}

		// Token: 0x170034CC RID: 13516
		// (get) Token: 0x0600ACB7 RID: 44215 RVA: 0x001864CC File Offset: 0x001846CC
		// (set) Token: 0x0600ACB8 RID: 44216 RVA: 0x0018652D File Offset: 0x0018472D
		public virtual IBaseCurve FadeInCurve
		{
			get
			{
				if (this._FadeInCurveInited)
				{
					return this._FadeInCurveCache;
				}
				this._FadeInCurveInited = true;
				if (this.FbInstance != null)
				{
					this._FadeInCurveCache = IBaseCurve.Create(this.FbInstance.FadeInCurve);
				}
				else
				{
					IResetFocusConfig_SetValue pocoInterface = this.PocoInterface;
					this._FadeInCurveCache = ((pocoInterface != null) ? pocoInterface.FadeInCurve : null);
				}
				return this._FadeInCurveCache;
			}
			set
			{
				this.GetOrCreatePoco().FadeInCurve = value;
				this._FadeInCurveInited = false;
			}
		}

		// Token: 0x04006730 RID: 26416
		[Nullable(2)]
		protected IResetFocusConfig FbInstance;

		// Token: 0x04006731 RID: 26417
		[Nullable(2)]
		protected IResetFocusConfig_SetValue PocoInterface;

		// Token: 0x04006732 RID: 26418
		private IBaseCurve _FadeInCurveCache;

		// Token: 0x04006733 RID: 26419
		private bool _FadeInCurveInited;
	}
}
