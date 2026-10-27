using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020002E7 RID: 743
	[NullableContext(1)]
	[Nullable(0)]
	public class IDynamicPortalByBullet : IDynamicPortalCreateMode
	{
		// Token: 0x06000E3B RID: 3643 RVA: 0x00033CC0 File Offset: 0x00031EC0
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

		// Token: 0x06000E3C RID: 3644 RVA: 0x00033CF8 File Offset: 0x00031EF8
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

		// Token: 0x06000E3D RID: 3645 RVA: 0x00033D0B File Offset: 0x00031F0B
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

		// Token: 0x06000E3E RID: 3646 RVA: 0x00033D20 File Offset: 0x00031F20
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

		// Token: 0x17000420 RID: 1056
		// (get) Token: 0x06000E3F RID: 3647 RVA: 0x00033D86 File Offset: 0x00031F86
		// (set) Token: 0x06000E40 RID: 3648 RVA: 0x00033DB1 File Offset: 0x00031FB1
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

		// Token: 0x17000421 RID: 1057
		// (get) Token: 0x06000E41 RID: 3649 RVA: 0x00033DC0 File Offset: 0x00031FC0
		// (set) Token: 0x06000E42 RID: 3650 RVA: 0x00033E21 File Offset: 0x00032021
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

		// Token: 0x17000422 RID: 1058
		// (get) Token: 0x06000E43 RID: 3651 RVA: 0x00033E38 File Offset: 0x00032038
		// (set) Token: 0x06000E44 RID: 3652 RVA: 0x00033E99 File Offset: 0x00032099
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

		// Token: 0x17000423 RID: 1059
		// (get) Token: 0x06000E45 RID: 3653 RVA: 0x00033EB0 File Offset: 0x000320B0
		// (set) Token: 0x06000E46 RID: 3654 RVA: 0x00033EEA File Offset: 0x000320EA
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

		// Token: 0x17000424 RID: 1060
		// (get) Token: 0x06000E47 RID: 3655 RVA: 0x00033EF8 File Offset: 0x000320F8
		// (set) Token: 0x06000E48 RID: 3656 RVA: 0x00033F59 File Offset: 0x00032159
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

		// Token: 0x17000425 RID: 1061
		// (get) Token: 0x06000E49 RID: 3657 RVA: 0x00033F70 File Offset: 0x00032170
		// (set) Token: 0x06000E4A RID: 3658 RVA: 0x00033FD1 File Offset: 0x000321D1
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

		// Token: 0x17000426 RID: 1062
		// (get) Token: 0x06000E4B RID: 3659 RVA: 0x00033FE8 File Offset: 0x000321E8
		// (set) Token: 0x06000E4C RID: 3660 RVA: 0x00034049 File Offset: 0x00032249
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

		// Token: 0x04000C9D RID: 3229
		[Nullable(2)]
		protected new IDynamicPortalByBullet FbInstance;

		// Token: 0x04000C9E RID: 3230
		[Nullable(2)]
		protected new IDynamicPortalByBullet_SetValue PocoInterface;

		// Token: 0x04000C9F RID: 3231
		private IDynamicPortalConfig _PortalACache;

		// Token: 0x04000CA0 RID: 3232
		private bool _PortalAInited;

		// Token: 0x04000CA1 RID: 3233
		private IDynamicPortalConfig _PortalBCache;

		// Token: 0x04000CA2 RID: 3234
		private bool _PortalBInited;

		// Token: 0x04000CA3 RID: 3235
		private IPortalRenderConfig _RenderConfigCache;

		// Token: 0x04000CA4 RID: 3236
		private bool _RenderConfigInited;

		// Token: 0x04000CA5 RID: 3237
		private IDynamicBulletConfig _TypeACache;

		// Token: 0x04000CA6 RID: 3238
		private bool _TypeAInited;

		// Token: 0x04000CA7 RID: 3239
		private IDynamicBulletConfig _TypeBCache;

		// Token: 0x04000CA8 RID: 3240
		private bool _TypeBInited;
	}
}
