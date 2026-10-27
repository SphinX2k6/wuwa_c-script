using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000857 RID: 2135
	[NullableContext(1)]
	[Nullable(0)]
	public class PortalComponent : IComponentBase
	{
		// Token: 0x06002F1F RID: 12063 RVA: 0x00079B28 File Offset: 0x00077D28
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

		// Token: 0x06002F20 RID: 12064 RVA: 0x00079B60 File Offset: 0x00077D60
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

		// Token: 0x06002F21 RID: 12065 RVA: 0x00079B73 File Offset: 0x00077D73
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

		// Token: 0x06002F22 RID: 12066 RVA: 0x00079B86 File Offset: 0x00077D86
		public new PortalComponent_SetValue ToSetValue()
		{
			return new PortalComponent_SetValue
			{
				Disabled = this.Disabled,
				EdIsLocked = this.EdIsLocked,
				Config = this.Config
			};
		}

		// Token: 0x17000C70 RID: 3184
		// (get) Token: 0x06002F23 RID: 12067 RVA: 0x00079BB4 File Offset: 0x00077DB4
		// (set) Token: 0x06002F24 RID: 12068 RVA: 0x00079BEE File Offset: 0x00077DEE
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

		// Token: 0x17000C71 RID: 3185
		// (get) Token: 0x06002F25 RID: 12069 RVA: 0x00079BFC File Offset: 0x00077DFC
		// (set) Token: 0x06002F26 RID: 12070 RVA: 0x00079C26 File Offset: 0x00077E26
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

		// Token: 0x17000C72 RID: 3186
		// (get) Token: 0x06002F27 RID: 12071 RVA: 0x00079C34 File Offset: 0x00077E34
		// (set) Token: 0x06002F28 RID: 12072 RVA: 0x00079C5B File Offset: 0x00077E5B
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

		// Token: 0x04001F1E RID: 7966
		[Nullable(2)]
		protected new PortalComponent FbInstance;

		// Token: 0x04001F1F RID: 7967
		[Nullable(2)]
		protected new PortalComponent_SetValue PocoInterface;
	}
}
