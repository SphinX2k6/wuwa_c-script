using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020007C2 RID: 1986
	public class IStaticPortal : IPortalMode
	{
		// Token: 0x06002A7F RID: 10879 RVA: 0x0006FDF0 File Offset: 0x0006DFF0
		private IStaticPortal_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IStaticPortal 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IStaticPortal_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IStaticPortal_SetValue());
			}
			return result;
		}

		// Token: 0x06002A80 RID: 10880 RVA: 0x0006FE28 File Offset: 0x0006E028
		public static IStaticPortal Create([Nullable(2)] IStaticPortal instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IStaticPortal
			{
				FbInstance = instance
			};
		}

		// Token: 0x06002A81 RID: 10881 RVA: 0x0006FE3B File Offset: 0x0006E03B
		public static IStaticPortal CreateFromSetValue([Nullable(2)] IStaticPortal_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IStaticPortal
			{
				PocoInterface = value
			};
		}

		// Token: 0x06002A82 RID: 10882 RVA: 0x0006FE50 File Offset: 0x0006E050
		public new IStaticPortal_SetValue ToSetValue()
		{
			return new IStaticPortal_SetValue
			{
				Type = this.Type,
				PortalModel = this.PortalModel,
				RenderConfig = this.RenderConfig,
				LinkPortalEntityId = this.LinkPortalEntityId,
				IsStreamSource = this.IsStreamSource
			};
		}

		// Token: 0x17000B1C RID: 2844
		// (get) Token: 0x06002A83 RID: 10883 RVA: 0x0006FE9E File Offset: 0x0006E09E
		// (set) Token: 0x06002A84 RID: 10884 RVA: 0x0006FEC9 File Offset: 0x0006E0C9
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

		// Token: 0x17000B1D RID: 2845
		// (get) Token: 0x06002A85 RID: 10885 RVA: 0x0006FED7 File Offset: 0x0006E0D7
		// (set) Token: 0x06002A86 RID: 10886 RVA: 0x0006FF02 File Offset: 0x0006E102
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

		// Token: 0x17000B1E RID: 2846
		// (get) Token: 0x06002A87 RID: 10887 RVA: 0x0006FF10 File Offset: 0x0006E110
		// (set) Token: 0x06002A88 RID: 10888 RVA: 0x0006FF71 File Offset: 0x0006E171
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
					IStaticPortal_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x17000B1F RID: 2847
		// (get) Token: 0x06002A89 RID: 10889 RVA: 0x0006FF86 File Offset: 0x0006E186
		// (set) Token: 0x06002A8A RID: 10890 RVA: 0x0006FFB1 File Offset: 0x0006E1B1
		public virtual int LinkPortalEntityId
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.LinkPortalEntityId;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.LinkPortalEntityId;
			}
			set
			{
				this.GetOrCreatePoco().LinkPortalEntityId = value;
			}
		}

		// Token: 0x17000B20 RID: 2848
		// (get) Token: 0x06002A8B RID: 10891 RVA: 0x0006FFC0 File Offset: 0x0006E1C0
		// (set) Token: 0x06002A8C RID: 10892 RVA: 0x0006FFFA File Offset: 0x0006E1FA
		public virtual bool? IsStreamSource
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.IsStreamSource;
				}
				IStaticPortal_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.IsStreamSource;
			}
			set
			{
				this.GetOrCreatePoco().IsStreamSource = value;
			}
		}

		// Token: 0x04001C97 RID: 7319
		[Nullable(2)]
		protected new IStaticPortal FbInstance;

		// Token: 0x04001C98 RID: 7320
		[Nullable(2)]
		protected new IStaticPortal_SetValue PocoInterface;

		// Token: 0x04001C99 RID: 7321
		private IPortalRenderConfig _RenderConfigCache;

		// Token: 0x04001C9A RID: 7322
		private bool _RenderConfigInited;
	}
}
