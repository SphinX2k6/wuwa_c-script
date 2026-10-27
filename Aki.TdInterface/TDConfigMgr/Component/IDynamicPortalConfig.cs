using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020002E9 RID: 745
	[NullableContext(1)]
	[Nullable(0)]
	public class IDynamicPortalConfig
	{
		// Token: 0x06000E4F RID: 3663 RVA: 0x00034070 File Offset: 0x00032270
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

		// Token: 0x06000E50 RID: 3664 RVA: 0x000340A8 File Offset: 0x000322A8
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

		// Token: 0x06000E51 RID: 3665 RVA: 0x000340BB File Offset: 0x000322BB
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

		// Token: 0x06000E52 RID: 3666 RVA: 0x000340CE File Offset: 0x000322CE
		public IDynamicPortalConfig_SetValue ToSetValue()
		{
			return new IDynamicPortalConfig_SetValue
			{
				PortalModel = this.PortalModel,
				TemplateId = this.TemplateId
			};
		}

		// Token: 0x17000427 RID: 1063
		// (get) Token: 0x06000E53 RID: 3667 RVA: 0x000340ED File Offset: 0x000322ED
		// (set) Token: 0x06000E54 RID: 3668 RVA: 0x00034118 File Offset: 0x00032318
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

		// Token: 0x17000428 RID: 1064
		// (get) Token: 0x06000E55 RID: 3669 RVA: 0x00034126 File Offset: 0x00032326
		// (set) Token: 0x06000E56 RID: 3670 RVA: 0x00034151 File Offset: 0x00032351
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

		// Token: 0x04000CB0 RID: 3248
		[Nullable(2)]
		protected IDynamicPortalConfig FbInstance;

		// Token: 0x04000CB1 RID: 3249
		[Nullable(2)]
		protected IDynamicPortalConfig_SetValue PocoInterface;
	}
}
