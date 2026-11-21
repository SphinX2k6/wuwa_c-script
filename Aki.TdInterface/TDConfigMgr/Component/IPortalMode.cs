using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020006B3 RID: 1715
	public class IPortalMode
	{
		// Token: 0x06002440 RID: 9280 RVA: 0x00062E4C File Offset: 0x0006104C
		private IPortalMode_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IPortalMode 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IPortalMode_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IPortalMode_SetValue());
			}
			return result;
		}

		// Token: 0x06002441 RID: 9281 RVA: 0x00062E84 File Offset: 0x00061084
		public static IPortalMode Create([Nullable(2)] IPortalMode instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IPortalMode
			{
				FbInstance = instance
			};
		}

		// Token: 0x06002442 RID: 9282 RVA: 0x00062E97 File Offset: 0x00061097
		public static IPortalMode CreateFromSetValue([Nullable(2)] IPortalMode_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IPortalMode
			{
				PocoInterface = value
			};
		}

		// Token: 0x06002443 RID: 9283 RVA: 0x00062EAA File Offset: 0x000610AA
		public IPortalMode_SetValue ToSetValue()
		{
			return new IPortalMode_SetValue
			{
				Type = this.Type,
				PortalModel = this.PortalModel,
				RenderConfig = this.RenderConfig
			};
		}

		// Token: 0x17000992 RID: 2450
		// (get) Token: 0x06002444 RID: 9284 RVA: 0x00062ED5 File Offset: 0x000610D5
		// (set) Token: 0x06002445 RID: 9285 RVA: 0x00062F00 File Offset: 0x00061100
		public virtual EPortalType Type
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

		// Token: 0x17000993 RID: 2451
		// (get) Token: 0x06002446 RID: 9286 RVA: 0x00062F0E File Offset: 0x0006110E
		// (set) Token: 0x06002447 RID: 9287 RVA: 0x00062F39 File Offset: 0x00061139
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

		// Token: 0x17000994 RID: 2452
		// (get) Token: 0x06002448 RID: 9288 RVA: 0x00062F48 File Offset: 0x00061148
		// (set) Token: 0x06002449 RID: 9289 RVA: 0x00062FA9 File Offset: 0x000611A9
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
					IPortalMode_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x0400192B RID: 6443
		[Nullable(2)]
		protected IPortalMode FbInstance;

		// Token: 0x0400192C RID: 6444
		[Nullable(2)]
		protected IPortalMode_SetValue PocoInterface;

		// Token: 0x0400192D RID: 6445
		private IPortalRenderConfig _RenderConfigCache;

		// Token: 0x0400192E RID: 6446
		private bool _RenderConfigInited;
	}
}
