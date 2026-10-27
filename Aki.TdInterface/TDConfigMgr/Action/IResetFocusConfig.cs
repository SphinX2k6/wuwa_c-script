using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001DA6 RID: 7590
	[NullableContext(1)]
	[Nullable(0)]
	public class IResetFocusConfig
	{
		// Token: 0x0600A2A7 RID: 41639 RVA: 0x00171CE8 File Offset: 0x0016FEE8
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

		// Token: 0x0600A2A8 RID: 41640 RVA: 0x00171D20 File Offset: 0x0016FF20
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

		// Token: 0x0600A2A9 RID: 41641 RVA: 0x00171D33 File Offset: 0x0016FF33
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

		// Token: 0x0600A2AA RID: 41642 RVA: 0x00171D46 File Offset: 0x0016FF46
		public IResetFocusConfig_SetValue ToSetValue()
		{
			return new IResetFocusConfig_SetValue
			{
				FadeInTime = this.FadeInTime,
				FadeInCurve = this.FadeInCurve
			};
		}

		// Token: 0x17003231 RID: 12849
		// (get) Token: 0x0600A2AB RID: 41643 RVA: 0x00171D65 File Offset: 0x0016FF65
		// (set) Token: 0x0600A2AC RID: 41644 RVA: 0x00171D94 File Offset: 0x0016FF94
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

		// Token: 0x17003232 RID: 12850
		// (get) Token: 0x0600A2AD RID: 41645 RVA: 0x00171DA4 File Offset: 0x0016FFA4
		// (set) Token: 0x0600A2AE RID: 41646 RVA: 0x00171E05 File Offset: 0x00170005
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

		// Token: 0x040061A8 RID: 25000
		[Nullable(2)]
		protected IResetFocusConfig FbInstance;

		// Token: 0x040061A9 RID: 25001
		[Nullable(2)]
		protected IResetFocusConfig_SetValue PocoInterface;

		// Token: 0x040061AA RID: 25002
		private IBaseCurve _FadeInCurveCache;

		// Token: 0x040061AB RID: 25003
		private bool _FadeInCurveInited;
	}
}
