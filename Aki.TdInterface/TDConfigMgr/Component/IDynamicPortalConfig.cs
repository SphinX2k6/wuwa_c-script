using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000330 RID: 816
	public class IDynamicPortalConfig
	{
		// Token: 0x06000F7F RID: 3967 RVA: 0x00036FA4 File Offset: 0x000351A4
		private IDynamicPortalConfig_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IDynamicPortalConfig 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IDynamicPortalConfig_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IDynamicPortalConfig_SetValue());
			}
			return result;
		}

		// Token: 0x06000F80 RID: 3968 RVA: 0x00036FDC File Offset: 0x000351DC
		public static IDynamicPortalConfig Create([Nullable(2)] IDynamicPortalConfig instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IDynamicPortalConfig
			{
				FbInstance = instance
			};
		}

		// Token: 0x06000F81 RID: 3969 RVA: 0x00036FEF File Offset: 0x000351EF
		public static IDynamicPortalConfig CreateFromSetValue([Nullable(2)] IDynamicPortalConfig_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IDynamicPortalConfig
			{
				PocoInterface = value
			};
		}

		// Token: 0x06000F82 RID: 3970 RVA: 0x00037002 File Offset: 0x00035202
		public IDynamicPortalConfig_SetValue ToSetValue()
		{
			return new IDynamicPortalConfig_SetValue
			{
				PortalModel = this.PortalModel,
				TemplateId = this.TemplateId
			};
		}

		// Token: 0x17000474 RID: 1140
		// (get) Token: 0x06000F83 RID: 3971 RVA: 0x00037021 File Offset: 0x00035221
		// (set) Token: 0x06000F84 RID: 3972 RVA: 0x0003704C File Offset: 0x0003524C
		public virtual EPortalModel PortalModel
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.PortalModel;
				}
				if (this.PocoInterface == null)
				{
					return EPortalModel.A;
				}
				return this.PocoInterface.PortalModel;
			}
			set
			{
				this.GetOrCreatePoco().PortalModel = value;
			}
		}

		// Token: 0x17000475 RID: 1141
		// (get) Token: 0x06000F85 RID: 3973 RVA: 0x0003705A File Offset: 0x0003525A
		// (set) Token: 0x06000F86 RID: 3974 RVA: 0x00037085 File Offset: 0x00035285
		public virtual string TemplateId
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.TemplateId;
				}
				if (this.PocoInterface == null)
				{
					return null;
				}
				return this.PocoInterface.TemplateId;
			}
			set
			{
				this.GetOrCreatePoco().TemplateId = value;
			}
		}

		// Token: 0x04000D9A RID: 3482
		[Nullable(2)]
		protected IDynamicPortalConfig FbInstance;

		// Token: 0x04000D9B RID: 3483
		[Nullable(2)]
		protected IDynamicPortalConfig_SetValue PocoInterface;
	}
}
