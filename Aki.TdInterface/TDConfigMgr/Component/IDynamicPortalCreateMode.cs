using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000332 RID: 818
	public class IDynamicPortalCreateMode
	{
		// Token: 0x06000F89 RID: 3977 RVA: 0x000370A4 File Offset: 0x000352A4
		private IDynamicPortalCreateMode_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IDynamicPortalCreateMode 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IDynamicPortalCreateMode_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IDynamicPortalCreateMode_SetValue());
			}
			return result;
		}

		// Token: 0x06000F8A RID: 3978 RVA: 0x000370DC File Offset: 0x000352DC
		public static IDynamicPortalCreateMode Create([Nullable(2)] IDynamicPortalCreateMode instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IDynamicPortalCreateMode
			{
				FbInstance = instance
			};
		}

		// Token: 0x06000F8B RID: 3979 RVA: 0x000370EF File Offset: 0x000352EF
		public static IDynamicPortalCreateMode CreateFromSetValue([Nullable(2)] IDynamicPortalCreateMode_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IDynamicPortalCreateMode
			{
				PocoInterface = value
			};
		}

		// Token: 0x06000F8C RID: 3980 RVA: 0x00037104 File Offset: 0x00035304
		public IDynamicPortalCreateMode_SetValue ToSetValue()
		{
			return new IDynamicPortalCreateMode_SetValue
			{
				Type = this.Type,
				PortalA = this.PortalA,
				PortalB = this.PortalB,
				InitOpenPortal = this.InitOpenPortal,
				RenderConfig = this.RenderConfig
			};
		}

		// Token: 0x17000476 RID: 1142
		// (get) Token: 0x06000F8D RID: 3981 RVA: 0x00037152 File Offset: 0x00035352
		// (set) Token: 0x06000F8E RID: 3982 RVA: 0x0003717D File Offset: 0x0003537D
		public virtual EDynamicPortalCreateType Type
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

		// Token: 0x17000477 RID: 1143
		// (get) Token: 0x06000F8F RID: 3983 RVA: 0x0003718C File Offset: 0x0003538C
		// (set) Token: 0x06000F90 RID: 3984 RVA: 0x000371ED File Offset: 0x000353ED
		public virtual IDynamicPortalConfig PortalA
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
					IDynamicPortalCreateMode_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x17000478 RID: 1144
		// (get) Token: 0x06000F91 RID: 3985 RVA: 0x00037204 File Offset: 0x00035404
		// (set) Token: 0x06000F92 RID: 3986 RVA: 0x00037265 File Offset: 0x00035465
		public virtual IDynamicPortalConfig PortalB
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
					IDynamicPortalCreateMode_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x17000479 RID: 1145
		// (get) Token: 0x06000F93 RID: 3987 RVA: 0x0003727C File Offset: 0x0003547C
		// (set) Token: 0x06000F94 RID: 3988 RVA: 0x000372B6 File Offset: 0x000354B6
		public virtual EPortalModel? InitOpenPortal
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.InitOpenPortal;
				}
				IDynamicPortalCreateMode_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x1700047A RID: 1146
		// (get) Token: 0x06000F95 RID: 3989 RVA: 0x000372C4 File Offset: 0x000354C4
		// (set) Token: 0x06000F96 RID: 3990 RVA: 0x00037325 File Offset: 0x00035525
		[Nullable(2)]
		public virtual IPortalRenderConfig RenderConfig
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
					IDynamicPortalCreateMode_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x04000D9E RID: 3486
		[Nullable(2)]
		protected IDynamicPortalCreateMode FbInstance;

		// Token: 0x04000D9F RID: 3487
		[Nullable(2)]
		protected IDynamicPortalCreateMode_SetValue PocoInterface;

		// Token: 0x04000DA0 RID: 3488
		private IDynamicPortalConfig _PortalACache;

		// Token: 0x04000DA1 RID: 3489
		private bool _PortalAInited;

		// Token: 0x04000DA2 RID: 3490
		private IDynamicPortalConfig _PortalBCache;

		// Token: 0x04000DA3 RID: 3491
		private bool _PortalBInited;

		// Token: 0x04000DA4 RID: 3492
		private IPortalRenderConfig _RenderConfigCache;

		// Token: 0x04000DA5 RID: 3493
		private bool _RenderConfigInited;
	}
}
