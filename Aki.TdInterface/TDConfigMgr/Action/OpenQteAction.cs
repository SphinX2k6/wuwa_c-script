using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200234B RID: 9035
	public class OpenQteAction : ActionParams
	{
		// Token: 0x0600C4BE RID: 50366 RVA: 0x001C34A8 File Offset: 0x001C16A8
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

		// Token: 0x0600C4BF RID: 50367 RVA: 0x001C34E0 File Offset: 0x001C16E0
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

		// Token: 0x0600C4C0 RID: 50368 RVA: 0x001C34F3 File Offset: 0x001C16F3
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

		// Token: 0x0600C4C1 RID: 50369 RVA: 0x001C3506 File Offset: 0x001C1706
		public OpenQteAction_SetValue ToSetValue()
		{
			return new OpenQteAction_SetValue
			{
				Config = this.Config
			};
		}

		// Token: 0x17003B7F RID: 15231
		// (get) Token: 0x0600C4C2 RID: 50370 RVA: 0x001C3519 File Offset: 0x001C1719
		// (set) Token: 0x0600C4C3 RID: 50371 RVA: 0x001C3540 File Offset: 0x001C1740
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

		// Token: 0x0400751D RID: 29981
		[Nullable(2)]
		protected new OpenQteAction FbInstance;

		// Token: 0x0400751E RID: 29982
		[Nullable(2)]
		protected OpenQteAction_SetValue PocoInterface;
	}
}
