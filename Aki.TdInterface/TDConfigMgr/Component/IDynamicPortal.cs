using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020002E5 RID: 741
	[NullableContext(1)]
	[Nullable(0)]
	public class IDynamicPortal : IPortalMode
	{
		// Token: 0x06000E2F RID: 3631 RVA: 0x00033B3C File Offset: 0x00031D3C
		private IDynamicPortal_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IDynamicPortal 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IDynamicPortal_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IDynamicPortal_SetValue());
			}
			return result;
		}

		// Token: 0x06000E30 RID: 3632 RVA: 0x00033B74 File Offset: 0x00031D74
		public static IDynamicPortal Create([Nullable(2)] IDynamicPortal instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IDynamicPortal
			{
				FbInstance = instance
			};
		}

		// Token: 0x06000E31 RID: 3633 RVA: 0x00033B87 File Offset: 0x00031D87
		public static IDynamicPortal CreateFromSetValue([Nullable(2)] IDynamicPortal_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IDynamicPortal
			{
				PocoInterface = value
			};
		}

		// Token: 0x06000E32 RID: 3634 RVA: 0x00033B9A File Offset: 0x00031D9A
		public new IDynamicPortal_SetValue ToSetValue()
		{
			return new IDynamicPortal_SetValue
			{
				Type = this.Type,
				PortalModel = this.PortalModel,
				RenderConfig = this.RenderConfig
			};
		}

		// Token: 0x1700041D RID: 1053
		// (get) Token: 0x06000E33 RID: 3635 RVA: 0x00033BC5 File Offset: 0x00031DC5
		// (set) Token: 0x06000E34 RID: 3636 RVA: 0x00033BF0 File Offset: 0x00031DF0
		public override EPortalType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EPortalType.Static;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x1700041E RID: 1054
		// (get) Token: 0x06000E35 RID: 3637 RVA: 0x00033BFE File Offset: 0x00031DFE
		// (set) Token: 0x06000E36 RID: 3638 RVA: 0x00033C29 File Offset: 0x00031E29
		public override EPortalModel PortalModel
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

		// Token: 0x1700041F RID: 1055
		// (get) Token: 0x06000E37 RID: 3639 RVA: 0x00033C38 File Offset: 0x00031E38
		// (set) Token: 0x06000E38 RID: 3640 RVA: 0x00033C99 File Offset: 0x00031E99
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
					IDynamicPortal_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x04000C96 RID: 3222
		[Nullable(2)]
		protected new IDynamicPortal FbInstance;

		// Token: 0x04000C97 RID: 3223
		[Nullable(2)]
		protected new IDynamicPortal_SetValue PocoInterface;

		// Token: 0x04000C98 RID: 3224
		private IPortalRenderConfig _RenderConfigCache;

		// Token: 0x04000C99 RID: 3225
		private bool _RenderConfigInited;
	}
}
