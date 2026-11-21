using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x0200032C RID: 812
	public class IDynamicPortal : IPortalMode
	{
		// Token: 0x06000F5F RID: 3935 RVA: 0x00036A70 File Offset: 0x00034C70
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

		// Token: 0x06000F60 RID: 3936 RVA: 0x00036AA8 File Offset: 0x00034CA8
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

		// Token: 0x06000F61 RID: 3937 RVA: 0x00036ABB File Offset: 0x00034CBB
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

		// Token: 0x06000F62 RID: 3938 RVA: 0x00036ACE File Offset: 0x00034CCE
		public new IDynamicPortal_SetValue ToSetValue()
		{
			return new IDynamicPortal_SetValue
			{
				Type = this.Type,
				PortalModel = this.PortalModel,
				RenderConfig = this.RenderConfig
			};
		}

		// Token: 0x1700046A RID: 1130
		// (get) Token: 0x06000F63 RID: 3939 RVA: 0x00036AF9 File Offset: 0x00034CF9
		// (set) Token: 0x06000F64 RID: 3940 RVA: 0x00036B24 File Offset: 0x00034D24
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

		// Token: 0x1700046B RID: 1131
		// (get) Token: 0x06000F65 RID: 3941 RVA: 0x00036B32 File Offset: 0x00034D32
		// (set) Token: 0x06000F66 RID: 3942 RVA: 0x00036B5D File Offset: 0x00034D5D
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

		// Token: 0x1700046C RID: 1132
		// (get) Token: 0x06000F67 RID: 3943 RVA: 0x00036B6C File Offset: 0x00034D6C
		// (set) Token: 0x06000F68 RID: 3944 RVA: 0x00036BCD File Offset: 0x00034DCD
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

		// Token: 0x04000D80 RID: 3456
		[Nullable(2)]
		protected new IDynamicPortal FbInstance;

		// Token: 0x04000D81 RID: 3457
		[Nullable(2)]
		protected new IDynamicPortal_SetValue PocoInterface;

		// Token: 0x04000D82 RID: 3458
		private IPortalRenderConfig _RenderConfigCache;

		// Token: 0x04000D83 RID: 3459
		private bool _RenderConfigInited;
	}
}
