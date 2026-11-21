using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x0200032E RID: 814
	public class IDynamicPortalByBullet : IDynamicPortalCreateMode
	{
		// Token: 0x06000F6B RID: 3947 RVA: 0x00036BF4 File Offset: 0x00034DF4
		private IDynamicPortalByBullet_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IDynamicPortalByBullet 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IDynamicPortalByBullet_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IDynamicPortalByBullet_SetValue());
			}
			return result;
		}

		// Token: 0x06000F6C RID: 3948 RVA: 0x00036C2C File Offset: 0x00034E2C
		public static IDynamicPortalByBullet Create([Nullable(2)] IDynamicPortalByBullet instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IDynamicPortalByBullet
			{
				FbInstance = instance
			};
		}

		// Token: 0x06000F6D RID: 3949 RVA: 0x00036C3F File Offset: 0x00034E3F
		public static IDynamicPortalByBullet CreateFromSetValue([Nullable(2)] IDynamicPortalByBullet_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IDynamicPortalByBullet
			{
				PocoInterface = value
			};
		}

		// Token: 0x06000F6E RID: 3950 RVA: 0x00036C54 File Offset: 0x00034E54
		public new IDynamicPortalByBullet_SetValue ToSetValue()
		{
			return new IDynamicPortalByBullet_SetValue
			{
				Type = this.Type,
				PortalA = this.PortalA,
				PortalB = this.PortalB,
				InitOpenPortal = this.InitOpenPortal,
				RenderConfig = this.RenderConfig,
				TypeA = this.TypeA,
				TypeB = this.TypeB
			};
		}

		// Token: 0x1700046D RID: 1133
		// (get) Token: 0x06000F6F RID: 3951 RVA: 0x00036CBA File Offset: 0x00034EBA
		// (set) Token: 0x06000F70 RID: 3952 RVA: 0x00036CE5 File Offset: 0x00034EE5
		public override EDynamicPortalCreateType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EDynamicPortalCreateType.Bullet;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x1700046E RID: 1134
		// (get) Token: 0x06000F71 RID: 3953 RVA: 0x00036CF4 File Offset: 0x00034EF4
		// (set) Token: 0x06000F72 RID: 3954 RVA: 0x00036D55 File Offset: 0x00034F55
		public override IDynamicPortalConfig PortalA
		{
			get
			{
				if (this._PortalAInited)
				{
					return this._PortalACache;
				}
				this._PortalAInited = true;
				if (this.FbInstance != null)
				{
					this._PortalACache = IDynamicPortalConfig.Create(this.FbInstance.PortalA);
				}
				else
				{
					IDynamicPortalByBullet_SetValue pocoInterface = this.PocoInterface;
					this._PortalACache = ((pocoInterface != null) ? pocoInterface.PortalA : null);
				}
				return this._PortalACache;
			}
			set
			{
				this.GetOrCreatePoco().PortalA = value;
				this._PortalAInited = false;
			}
		}

		// Token: 0x1700046F RID: 1135
		// (get) Token: 0x06000F73 RID: 3955 RVA: 0x00036D6C File Offset: 0x00034F6C
		// (set) Token: 0x06000F74 RID: 3956 RVA: 0x00036DCD File Offset: 0x00034FCD
		public override IDynamicPortalConfig PortalB
		{
			get
			{
				if (this._PortalBInited)
				{
					return this._PortalBCache;
				}
				this._PortalBInited = true;
				if (this.FbInstance != null)
				{
					this._PortalBCache = IDynamicPortalConfig.Create(this.FbInstance.PortalB);
				}
				else
				{
					IDynamicPortalByBullet_SetValue pocoInterface = this.PocoInterface;
					this._PortalBCache = ((pocoInterface != null) ? pocoInterface.PortalB : null);
				}
				return this._PortalBCache;
			}
			set
			{
				this.GetOrCreatePoco().PortalB = value;
				this._PortalBInited = false;
			}
		}

		// Token: 0x17000470 RID: 1136
		// (get) Token: 0x06000F75 RID: 3957 RVA: 0x00036DE4 File Offset: 0x00034FE4
		// (set) Token: 0x06000F76 RID: 3958 RVA: 0x00036E1E File Offset: 0x0003501E
		public override EPortalModel? InitOpenPortal
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.InitOpenPortal;
				}
				IDynamicPortalByBullet_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.InitOpenPortal;
			}
			set
			{
				this.GetOrCreatePoco().InitOpenPortal = value;
			}
		}

		// Token: 0x17000471 RID: 1137
		// (get) Token: 0x06000F77 RID: 3959 RVA: 0x00036E2C File Offset: 0x0003502C
		// (set) Token: 0x06000F78 RID: 3960 RVA: 0x00036E8D File Offset: 0x0003508D
		[Nullable(2)]
		public override IPortalRenderConfig RenderConfig
		{
			[NullableContext(2)]
			get
			{
				if (this._RenderConfigInited)
				{
					return this._RenderConfigCache;
				}
				this._RenderConfigInited = true;
				if (this.FbInstance != null)
				{
					this._RenderConfigCache = IPortalRenderConfig.Create(this.FbInstance.RenderConfig);
				}
				else
				{
					IDynamicPortalByBullet_SetValue pocoInterface = this.PocoInterface;
					this._RenderConfigCache = ((pocoInterface != null) ? pocoInterface.RenderConfig : null);
				}
				return this._RenderConfigCache;
			}
			[NullableContext(2)]
			set
			{
				this.GetOrCreatePoco().RenderConfig = value;
				this._RenderConfigInited = false;
			}
		}

		// Token: 0x17000472 RID: 1138
		// (get) Token: 0x06000F79 RID: 3961 RVA: 0x00036EA4 File Offset: 0x000350A4
		// (set) Token: 0x06000F7A RID: 3962 RVA: 0x00036F05 File Offset: 0x00035105
		public virtual IDynamicBulletConfig TypeA
		{
			get
			{
				if (this._TypeAInited)
				{
					return this._TypeACache;
				}
				this._TypeAInited = true;
				if (this.FbInstance != null)
				{
					this._TypeACache = IDynamicBulletConfig.Create(this.FbInstance.TypeA);
				}
				else
				{
					IDynamicPortalByBullet_SetValue pocoInterface = this.PocoInterface;
					this._TypeACache = ((pocoInterface != null) ? pocoInterface.TypeA : null);
				}
				return this._TypeACache;
			}
			set
			{
				this.GetOrCreatePoco().TypeA = value;
				this._TypeAInited = false;
			}
		}

		// Token: 0x17000473 RID: 1139
		// (get) Token: 0x06000F7B RID: 3963 RVA: 0x00036F1C File Offset: 0x0003511C
		// (set) Token: 0x06000F7C RID: 3964 RVA: 0x00036F7D File Offset: 0x0003517D
		public virtual IDynamicBulletConfig TypeB
		{
			get
			{
				if (this._TypeBInited)
				{
					return this._TypeBCache;
				}
				this._TypeBInited = true;
				if (this.FbInstance != null)
				{
					this._TypeBCache = IDynamicBulletConfig.Create(this.FbInstance.TypeB);
				}
				else
				{
					IDynamicPortalByBullet_SetValue pocoInterface = this.PocoInterface;
					this._TypeBCache = ((pocoInterface != null) ? pocoInterface.TypeB : null);
				}
				return this._TypeBCache;
			}
			set
			{
				this.GetOrCreatePoco().TypeB = value;
				this._TypeBInited = false;
			}
		}

		// Token: 0x04000D87 RID: 3463
		[Nullable(2)]
		protected new IDynamicPortalByBullet FbInstance;

		// Token: 0x04000D88 RID: 3464
		[Nullable(2)]
		protected new IDynamicPortalByBullet_SetValue PocoInterface;

		// Token: 0x04000D89 RID: 3465
		private IDynamicPortalConfig _PortalACache;

		// Token: 0x04000D8A RID: 3466
		private bool _PortalAInited;

		// Token: 0x04000D8B RID: 3467
		private IDynamicPortalConfig _PortalBCache;

		// Token: 0x04000D8C RID: 3468
		private bool _PortalBInited;

		// Token: 0x04000D8D RID: 3469
		private IPortalRenderConfig _RenderConfigCache;

		// Token: 0x04000D8E RID: 3470
		private bool _RenderConfigInited;

		// Token: 0x04000D8F RID: 3471
		private IDynamicBulletConfig _TypeACache;

		// Token: 0x04000D90 RID: 3472
		private bool _TypeAInited;

		// Token: 0x04000D91 RID: 3473
		private IDynamicBulletConfig _TypeBCache;

		// Token: 0x04000D92 RID: 3474
		private bool _TypeBInited;
	}
}
