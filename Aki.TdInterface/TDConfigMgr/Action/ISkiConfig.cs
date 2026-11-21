using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020020AC RID: 8364
	public class ISkiConfig : ISportConfig
	{
		// Token: 0x0600B1A2 RID: 45474 RVA: 0x0018F5EC File Offset: 0x0018D7EC
		private ISkiConfig_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ISkiConfig 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ISkiConfig_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ISkiConfig_SetValue());
			}
			return result;
		}

		// Token: 0x0600B1A3 RID: 45475 RVA: 0x0018F624 File Offset: 0x0018D824
		public static ISkiConfig Create([Nullable(2)] ISkiConfig instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ISkiConfig
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600B1A4 RID: 45476 RVA: 0x0018F637 File Offset: 0x0018D837
		public static ISkiConfig CreateFromSetValue([Nullable(2)] ISkiConfig_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ISkiConfig
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600B1A5 RID: 45477 RVA: 0x0018F64A File Offset: 0x0018D84A
		public new ISkiConfig_SetValue ToSetValue()
		{
			return new ISkiConfig_SetValue
			{
				Type = this.Type,
				Config = this.Config
			};
		}

		// Token: 0x170035DE RID: 13790
		// (get) Token: 0x0600B1A6 RID: 45478 RVA: 0x0018F669 File Offset: 0x0018D869
		// (set) Token: 0x0600B1A7 RID: 45479 RVA: 0x0018F694 File Offset: 0x0018D894
		public override ESportStateType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ESportStateType.Slide;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x170035DF RID: 13791
		// (get) Token: 0x0600B1A8 RID: 45480 RVA: 0x0018F6A2 File Offset: 0x0018D8A2
		// (set) Token: 0x0600B1A9 RID: 45481 RVA: 0x0018F6C9 File Offset: 0x0018D8C9
		public virtual ISkiConfigType Config
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Config;
				}
				ISkiConfig_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x0400698B RID: 27019
		[Nullable(2)]
		protected new ISkiConfig FbInstance;

		// Token: 0x0400698C RID: 27020
		[Nullable(2)]
		protected new ISkiConfig_SetValue PocoInterface;
	}
}
