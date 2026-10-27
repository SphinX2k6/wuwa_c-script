using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000D02 RID: 3330
	[NullableContext(1)]
	[Nullable(0)]
	public class IDynamicPortalCreateMode
	{
		// Token: 0x06004C02 RID: 19458 RVA: 0x000BD8B2 File Offset: 0x000BBAB2
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

		// Token: 0x170017BB RID: 6075
		// (get) Token: 0x06004C03 RID: 19459 RVA: 0x000BD8D1 File Offset: 0x000BBAD1
		public virtual EDynamicPortalCreateType Type
		{
			get
			{
				return (EDynamicPortalCreateType)this.Instance.Type;
			}
		}

		// Token: 0x170017BC RID: 6076
		// (get) Token: 0x06004C04 RID: 19460 RVA: 0x000BD8DE File Offset: 0x000BBADE
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

		// Token: 0x170017BD RID: 6077
		// (get) Token: 0x06004C05 RID: 19461 RVA: 0x000BD912 File Offset: 0x000BBB12
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

		// Token: 0x170017BE RID: 6078
		// (get) Token: 0x06004C06 RID: 19462 RVA: 0x000BD948 File Offset: 0x000BBB48
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

		// Token: 0x170017BF RID: 6079
		// (get) Token: 0x06004C07 RID: 19463 RVA: 0x000BD97E File Offset: 0x000BBB7E
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

		// Token: 0x04002B73 RID: 11123
		private IDynamicPortalCreateMode Instance;

		// Token: 0x04002B74 RID: 11124
		[Nullable(2)]
		private IDynamicPortalConfig _PortalACache;

		// Token: 0x04002B75 RID: 11125
		private bool _PortalAInited;

		// Token: 0x04002B76 RID: 11126
		[Nullable(2)]
		private IDynamicPortalConfig _PortalBCache;

		// Token: 0x04002B77 RID: 11127
		private bool _PortalBInited;

		// Token: 0x04002B78 RID: 11128
		[Nullable(2)]
		private IPortalRenderConfig _RenderConfigCache;

		// Token: 0x04002B79 RID: 11129
		private bool _RenderConfigInited;
	}
}
