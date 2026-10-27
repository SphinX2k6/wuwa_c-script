using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020002DF RID: 735
	[NullableContext(1)]
	[Nullable(0)]
	public class IDynamicBulletConfig
	{
		// Token: 0x06000E09 RID: 3593 RVA: 0x00033698 File Offset: 0x00031898
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

		// Token: 0x06000E0A RID: 3594 RVA: 0x000336D0 File Offset: 0x000318D0
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

		// Token: 0x06000E0B RID: 3595 RVA: 0x000336E3 File Offset: 0x000318E3
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

		// Token: 0x06000E0C RID: 3596 RVA: 0x000336F6 File Offset: 0x000318F6
		public IDynamicBulletConfig_SetValue ToSetValue()
		{
			return new IDynamicBulletConfig_SetValue
			{
				BulletId = this.BulletId,
				PortalModel = this.PortalModel,
				TemplateId = this.TemplateId
			};
		}

		// Token: 0x17000413 RID: 1043
		// (get) Token: 0x06000E0D RID: 3597 RVA: 0x00033721 File Offset: 0x00031921
		// (set) Token: 0x06000E0E RID: 3598 RVA: 0x0003374C File Offset: 0x0003194C
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

		// Token: 0x17000414 RID: 1044
		// (get) Token: 0x06000E0F RID: 3599 RVA: 0x0003375A File Offset: 0x0003195A
		// (set) Token: 0x06000E10 RID: 3600 RVA: 0x00033785 File Offset: 0x00031985
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

		// Token: 0x17000415 RID: 1045
		// (get) Token: 0x06000E11 RID: 3601 RVA: 0x00033793 File Offset: 0x00031993
		// (set) Token: 0x06000E12 RID: 3602 RVA: 0x000337BE File Offset: 0x000319BE
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

		// Token: 0x04000C82 RID: 3202
		[Nullable(2)]
		protected IDynamicBulletConfig FbInstance;

		// Token: 0x04000C83 RID: 3203
		[Nullable(2)]
		protected IDynamicBulletConfig_SetValue PocoInterface;
	}
}
