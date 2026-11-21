using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000DFA RID: 3578
	public class IDynamicPortalCreateMode
	{
		// Token: 0x06005110 RID: 20752 RVA: 0x000C8DE2 File Offset: 0x000C6FE2
		public static IDynamicPortalCreateMode Create(IDynamicPortalCreateMode? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IDynamicPortalCreateMode
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17001917 RID: 6423
		// (get) Token: 0x06005111 RID: 20753 RVA: 0x000C8E01 File Offset: 0x000C7001
		public virtual EDynamicPortalCreateType Type
		{
			get
			{
				return (EDynamicPortalCreateType)this.Instance.Type;
			}
		}

		// Token: 0x17001918 RID: 6424
		// (get) Token: 0x06005112 RID: 20754 RVA: 0x000C8E0E File Offset: 0x000C700E
		public virtual IDynamicPortalConfig PortalA
		{
			get
			{
				if (this._PortalAInited)
				{
					return this._PortalACache;
				}
				this._PortalAInited = true;
				this._PortalACache = IDynamicPortalConfig.Create(this.Instance.PortalA);
				return this._PortalACache;
			}
		}

		// Token: 0x17001919 RID: 6425
		// (get) Token: 0x06005113 RID: 20755 RVA: 0x000C8E42 File Offset: 0x000C7042
		public virtual IDynamicPortalConfig PortalB
		{
			get
			{
				if (this._PortalBInited)
				{
					return this._PortalBCache;
				}
				this._PortalBInited = true;
				this._PortalBCache = IDynamicPortalConfig.Create(this.Instance.PortalB);
				return this._PortalBCache;
			}
		}

		// Token: 0x1700191A RID: 6426
		// (get) Token: 0x06005114 RID: 20756 RVA: 0x000C8E78 File Offset: 0x000C7078
		public virtual EPortalModel? InitOpenPortal
		{
			get
			{
				if ((this.Instance.NullMask & 1) == 0)
				{
					return null;
				}
				return new EPortalModel?((EPortalModel)this.Instance.InitOpenPortal);
			}
		}

		// Token: 0x1700191B RID: 6427
		// (get) Token: 0x06005115 RID: 20757 RVA: 0x000C8EAE File Offset: 0x000C70AE
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
				this._RenderConfigCache = IPortalRenderConfig.Create(this.Instance.RenderConfig);
				return this._RenderConfigCache;
			}
		}

		// Token: 0x04002E2D RID: 11821
		private IDynamicPortalCreateMode Instance;

		// Token: 0x04002E2E RID: 11822
		[Nullable(2)]
		private IDynamicPortalConfig _PortalACache;

		// Token: 0x04002E2F RID: 11823
		private bool _PortalAInited;

		// Token: 0x04002E30 RID: 11824
		[Nullable(2)]
		private IDynamicPortalConfig _PortalBCache;

		// Token: 0x04002E31 RID: 11825
		private bool _PortalBInited;

		// Token: 0x04002E32 RID: 11826
		[Nullable(2)]
		private IPortalRenderConfig _RenderConfigCache;

		// Token: 0x04002E33 RID: 11827
		private bool _RenderConfigInited;
	}
}
