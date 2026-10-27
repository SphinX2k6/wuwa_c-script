using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020020EA RID: 8426
	[NullableContext(1)]
	[Nullable(0)]
	public class OpenQteAction : ActionParams
	{
		// Token: 0x0600B932 RID: 47410 RVA: 0x001AC348 File Offset: 0x001AA548
		private OpenQteAction_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("OpenQteAction 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			OpenQteAction_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new OpenQteAction_SetValue());
			}
			return result;
		}

		// Token: 0x0600B933 RID: 47411 RVA: 0x001AC380 File Offset: 0x001AA580
		public static OpenQteAction Create([Nullable(2)] OpenQteAction instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new OpenQteAction
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600B934 RID: 47412 RVA: 0x001AC393 File Offset: 0x001AA593
		public static OpenQteAction CreateFromSetValue([Nullable(2)] OpenQteAction_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new OpenQteAction
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600B935 RID: 47413 RVA: 0x001AC3A6 File Offset: 0x001AA5A6
		public OpenQteAction_SetValue ToSetValue()
		{
			return new OpenQteAction_SetValue
			{
				Config = this.Config
			};
		}

		// Token: 0x17003893 RID: 14483
		// (get) Token: 0x0600B936 RID: 47414 RVA: 0x001AC3B9 File Offset: 0x001AA5B9
		// (set) Token: 0x0600B937 RID: 47415 RVA: 0x001AC3E0 File Offset: 0x001AA5E0
		public virtual IOpenQteConfig Config
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Config;
				}
				OpenQteAction_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.Config;
			}
			set
			{
				this.GetOrCreatePoco().Config = value;
			}
		}

		// Token: 0x04006EE9 RID: 28393
		[Nullable(2)]
		protected new OpenQteAction FbInstance;

		// Token: 0x04006EEA RID: 28394
		[Nullable(2)]
		protected OpenQteAction_SetValue PocoInterface;
	}
}
