using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000721 RID: 1825
	[NullableContext(1)]
	[Nullable(0)]
	public class IStaticPortal : IPortalMode
	{
		// Token: 0x0600275B RID: 10075 RVA: 0x00068C48 File Offset: 0x00066E48
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

		// Token: 0x0600275C RID: 10076 RVA: 0x00068C80 File Offset: 0x00066E80
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

		// Token: 0x0600275D RID: 10077 RVA: 0x00068C93 File Offset: 0x00066E93
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

		// Token: 0x0600275E RID: 10078 RVA: 0x00068CA8 File Offset: 0x00066EA8
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

		// Token: 0x17000A5C RID: 2652
		// (get) Token: 0x0600275F RID: 10079 RVA: 0x00068CF6 File Offset: 0x00066EF6
		// (set) Token: 0x06002760 RID: 10080 RVA: 0x00068D21 File Offset: 0x00066F21
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

		// Token: 0x17000A5D RID: 2653
		// (get) Token: 0x06002761 RID: 10081 RVA: 0x00068D2F File Offset: 0x00066F2F
		// (set) Token: 0x06002762 RID: 10082 RVA: 0x00068D5A File Offset: 0x00066F5A
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

		// Token: 0x17000A5E RID: 2654
		// (get) Token: 0x06002763 RID: 10083 RVA: 0x00068D68 File Offset: 0x00066F68
		// (set) Token: 0x06002764 RID: 10084 RVA: 0x00068DC9 File Offset: 0x00066FC9
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

		// Token: 0x17000A5F RID: 2655
		// (get) Token: 0x06002765 RID: 10085 RVA: 0x00068DDE File Offset: 0x00066FDE
		// (set) Token: 0x06002766 RID: 10086 RVA: 0x00068E09 File Offset: 0x00067009
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

		// Token: 0x17000A60 RID: 2656
		// (get) Token: 0x06002767 RID: 10087 RVA: 0x00068E18 File Offset: 0x00067018
		// (set) Token: 0x06002768 RID: 10088 RVA: 0x00068E52 File Offset: 0x00067052
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

		// Token: 0x04001A92 RID: 6802
		[Nullable(2)]
		protected new IStaticPortal FbInstance;

		// Token: 0x04001A93 RID: 6803
		[Nullable(2)]
		protected new IStaticPortal_SetValue PocoInterface;

		// Token: 0x04001A94 RID: 6804
		private IPortalRenderConfig _RenderConfigCache;

		// Token: 0x04001A95 RID: 6805
		private bool _RenderConfigInited;
	}
}
