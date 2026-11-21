using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020008FA RID: 2298
	public class PortalComponent : IComponentBase
	{
		// Token: 0x0600325B RID: 12891 RVA: 0x00081010 File Offset: 0x0007F210
		private PortalComponent_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("PortalComponent 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			PortalComponent_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new PortalComponent_SetValue());
			}
			return result;
		}

		// Token: 0x0600325C RID: 12892 RVA: 0x00081048 File Offset: 0x0007F248
		public static PortalComponent Create([Nullable(2)] PortalComponent instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new PortalComponent
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600325D RID: 12893 RVA: 0x0008105B File Offset: 0x0007F25B
		public static PortalComponent CreateFromSetValue([Nullable(2)] PortalComponent_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new PortalComponent
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600325E RID: 12894 RVA: 0x0008106E File Offset: 0x0007F26E
		public new PortalComponent_SetValue ToSetValue()
		{
			return new PortalComponent_SetValue
			{
				Disabled = this.Disabled,
				EdIsLocked = this.EdIsLocked,
				Config = this.Config
			};
		}

		// Token: 0x17000D39 RID: 3385
		// (get) Token: 0x0600325F RID: 12895 RVA: 0x0008109C File Offset: 0x0007F29C
		// (set) Token: 0x06003260 RID: 12896 RVA: 0x000810D6 File Offset: 0x0007F2D6
		public override bool? Disabled
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Disabled;
				}
				PortalComponent_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.Disabled;
			}
			set
			{
				this.GetOrCreatePoco().Disabled = value;
			}
		}

		// Token: 0x17000D3A RID: 3386
		// (get) Token: 0x06003261 RID: 12897 RVA: 0x000810E4 File Offset: 0x0007F2E4
		// (set) Token: 0x06003262 RID: 12898 RVA: 0x0008110E File Offset: 0x0007F30E
		public override bool? EdIsLocked
		{
			get
			{
				if (this.PocoInterface != null)
				{
					return this.PocoInterface.EdIsLocked;
				}
				return null;
			}
			set
			{
				this.GetOrCreatePoco().EdIsLocked = value;
			}
		}

		// Token: 0x17000D3B RID: 3387
		// (get) Token: 0x06003263 RID: 12899 RVA: 0x0008111C File Offset: 0x0007F31C
		// (set) Token: 0x06003264 RID: 12900 RVA: 0x00081143 File Offset: 0x0007F343
		public virtual IPortalMode Config
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Config;
				}
				PortalComponent_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x04002130 RID: 8496
		[Nullable(2)]
		protected new PortalComponent FbInstance;

		// Token: 0x04002131 RID: 8497
		[Nullable(2)]
		protected new PortalComponent_SetValue PocoInterface;
	}
}
