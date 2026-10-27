using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020002EB RID: 747
	[NullableContext(1)]
	[Nullable(0)]
	public class IDynamicPortalCreateMode
	{
		// Token: 0x06000E59 RID: 3673 RVA: 0x00034170 File Offset: 0x00032370
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

		// Token: 0x06000E5A RID: 3674 RVA: 0x000341A8 File Offset: 0x000323A8
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

		// Token: 0x06000E5B RID: 3675 RVA: 0x000341BB File Offset: 0x000323BB
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

		// Token: 0x06000E5C RID: 3676 RVA: 0x000341D0 File Offset: 0x000323D0
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

		// Token: 0x17000429 RID: 1065
		// (get) Token: 0x06000E5D RID: 3677 RVA: 0x0003421E File Offset: 0x0003241E
		// (set) Token: 0x06000E5E RID: 3678 RVA: 0x00034249 File Offset: 0x00032449
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

		// Token: 0x1700042A RID: 1066
		// (get) Token: 0x06000E5F RID: 3679 RVA: 0x00034258 File Offset: 0x00032458
		// (set) Token: 0x06000E60 RID: 3680 RVA: 0x000342B9 File Offset: 0x000324B9
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

		// Token: 0x1700042B RID: 1067
		// (get) Token: 0x06000E61 RID: 3681 RVA: 0x000342D0 File Offset: 0x000324D0
		// (set) Token: 0x06000E62 RID: 3682 RVA: 0x00034331 File Offset: 0x00032531
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

		// Token: 0x1700042C RID: 1068
		// (get) Token: 0x06000E63 RID: 3683 RVA: 0x00034348 File Offset: 0x00032548
		// (set) Token: 0x06000E64 RID: 3684 RVA: 0x00034382 File Offset: 0x00032582
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

		// Token: 0x1700042D RID: 1069
		// (get) Token: 0x06000E65 RID: 3685 RVA: 0x00034390 File Offset: 0x00032590
		// (set) Token: 0x06000E66 RID: 3686 RVA: 0x000343F1 File Offset: 0x000325F1
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

		// Token: 0x04000CB4 RID: 3252
		[Nullable(2)]
		protected IDynamicPortalCreateMode FbInstance;

		// Token: 0x04000CB5 RID: 3253
		[Nullable(2)]
		protected IDynamicPortalCreateMode_SetValue PocoInterface;

		// Token: 0x04000CB6 RID: 3254
		private IDynamicPortalConfig _PortalACache;

		// Token: 0x04000CB7 RID: 3255
		private bool _PortalAInited;

		// Token: 0x04000CB8 RID: 3256
		private IDynamicPortalConfig _PortalBCache;

		// Token: 0x04000CB9 RID: 3257
		private bool _PortalBInited;

		// Token: 0x04000CBA RID: 3258
		private IPortalRenderConfig _RenderConfigCache;

		// Token: 0x04000CBB RID: 3259
		private bool _RenderConfigInited;
	}
}
