using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000616 RID: 1558
	[NullableContext(1)]
	[Nullable(0)]
	public class IPortalMode
	{
		// Token: 0x0600213A RID: 8506 RVA: 0x0005C138 File Offset: 0x0005A338
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

		// Token: 0x0600213B RID: 8507 RVA: 0x0005C170 File Offset: 0x0005A370
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

		// Token: 0x0600213C RID: 8508 RVA: 0x0005C183 File Offset: 0x0005A383
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

		// Token: 0x0600213D RID: 8509 RVA: 0x0005C196 File Offset: 0x0005A396
		public IPortalMode_SetValue ToSetValue()
		{
			return new IPortalMode_SetValue
			{
				Type = this.Type,
				PortalModel = this.PortalModel,
				RenderConfig = this.RenderConfig
			};
		}

		// Token: 0x170008DB RID: 2267
		// (get) Token: 0x0600213E RID: 8510 RVA: 0x0005C1C1 File Offset: 0x0005A3C1
		// (set) Token: 0x0600213F RID: 8511 RVA: 0x0005C1EC File Offset: 0x0005A3EC
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

		// Token: 0x170008DC RID: 2268
		// (get) Token: 0x06002140 RID: 8512 RVA: 0x0005C1FA File Offset: 0x0005A3FA
		// (set) Token: 0x06002141 RID: 8513 RVA: 0x0005C225 File Offset: 0x0005A425
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

		// Token: 0x170008DD RID: 2269
		// (get) Token: 0x06002142 RID: 8514 RVA: 0x0005C234 File Offset: 0x0005A434
		// (set) Token: 0x06002143 RID: 8515 RVA: 0x0005C295 File Offset: 0x0005A495
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

		// Token: 0x04001739 RID: 5945
		[Nullable(2)]
		protected IPortalMode FbInstance;

		// Token: 0x0400173A RID: 5946
		[Nullable(2)]
		protected IPortalMode_SetValue PocoInterface;

		// Token: 0x0400173B RID: 5947
		private IPortalRenderConfig _RenderConfigCache;

		// Token: 0x0400173C RID: 5948
		private bool _RenderConfigInited;
	}
}
