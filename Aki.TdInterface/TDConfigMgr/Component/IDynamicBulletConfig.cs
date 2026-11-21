using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000326 RID: 806
	public class IDynamicBulletConfig
	{
		// Token: 0x06000F39 RID: 3897 RVA: 0x000365CC File Offset: 0x000347CC
		private IDynamicBulletConfig_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IDynamicBulletConfig 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IDynamicBulletConfig_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IDynamicBulletConfig_SetValue());
			}
			return result;
		}

		// Token: 0x06000F3A RID: 3898 RVA: 0x00036604 File Offset: 0x00034804
		public static IDynamicBulletConfig Create([Nullable(2)] IDynamicBulletConfig instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IDynamicBulletConfig
			{
				FbInstance = instance
			};
		}

		// Token: 0x06000F3B RID: 3899 RVA: 0x00036617 File Offset: 0x00034817
		public static IDynamicBulletConfig CreateFromSetValue([Nullable(2)] IDynamicBulletConfig_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IDynamicBulletConfig
			{
				PocoInterface = value
			};
		}

		// Token: 0x06000F3C RID: 3900 RVA: 0x0003662A File Offset: 0x0003482A
		public IDynamicBulletConfig_SetValue ToSetValue()
		{
			return new IDynamicBulletConfig_SetValue
			{
				BulletId = this.BulletId,
				PortalModel = this.PortalModel,
				TemplateId = this.TemplateId
			};
		}

		// Token: 0x17000460 RID: 1120
		// (get) Token: 0x06000F3D RID: 3901 RVA: 0x00036655 File Offset: 0x00034855
		// (set) Token: 0x06000F3E RID: 3902 RVA: 0x00036680 File Offset: 0x00034880
		public virtual int BulletId
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.BulletId;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.BulletId;
			}
			set
			{
				this.GetOrCreatePoco().BulletId = value;
			}
		}

		// Token: 0x17000461 RID: 1121
		// (get) Token: 0x06000F3F RID: 3903 RVA: 0x0003668E File Offset: 0x0003488E
		// (set) Token: 0x06000F40 RID: 3904 RVA: 0x000366B9 File Offset: 0x000348B9
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

		// Token: 0x17000462 RID: 1122
		// (get) Token: 0x06000F41 RID: 3905 RVA: 0x000366C7 File Offset: 0x000348C7
		// (set) Token: 0x06000F42 RID: 3906 RVA: 0x000366F2 File Offset: 0x000348F2
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

		// Token: 0x04000D6C RID: 3436
		[Nullable(2)]
		protected IDynamicBulletConfig FbInstance;

		// Token: 0x04000D6D RID: 3437
		[Nullable(2)]
		protected IDynamicBulletConfig_SetValue PocoInterface;
	}
}
