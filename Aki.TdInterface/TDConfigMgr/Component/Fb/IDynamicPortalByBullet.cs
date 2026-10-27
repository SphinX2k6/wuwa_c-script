using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000D04 RID: 3332
	[NullableContext(1)]
	[Nullable(0)]
	public class IDynamicPortalByBullet : IDynamicPortalCreateMode
	{
		// Token: 0x06004C0E RID: 19470 RVA: 0x000BDA08 File Offset: 0x000BBC08
		public static IDynamicPortalByBullet Create(IDynamicPortalByBullet? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IDynamicPortalByBullet
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170017C3 RID: 6083
		// (get) Token: 0x06004C0F RID: 19471 RVA: 0x000BDA27 File Offset: 0x000BBC27
		public override EDynamicPortalCreateType Type
		{
			get
			{
				return (EDynamicPortalCreateType)this.Instance.Type;
			}
		}

		// Token: 0x170017C4 RID: 6084
		// (get) Token: 0x06004C10 RID: 19472 RVA: 0x000BDA34 File Offset: 0x000BBC34
		public override IDynamicPortalConfig PortalA
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

		// Token: 0x170017C5 RID: 6085
		// (get) Token: 0x06004C11 RID: 19473 RVA: 0x000BDA68 File Offset: 0x000BBC68
		public override IDynamicPortalConfig PortalB
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

		// Token: 0x170017C6 RID: 6086
		// (get) Token: 0x06004C12 RID: 19474 RVA: 0x000BDA9C File Offset: 0x000BBC9C
		public override EPortalModel? InitOpenPortal
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

		// Token: 0x170017C7 RID: 6087
		// (get) Token: 0x06004C13 RID: 19475 RVA: 0x000BDAD2 File Offset: 0x000BBCD2
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
				this._RenderConfigCache = IPortalRenderConfig.Create(this.Instance.RenderConfig);
				return this._RenderConfigCache;
			}
		}

		// Token: 0x170017C8 RID: 6088
		// (get) Token: 0x06004C14 RID: 19476 RVA: 0x000BDB06 File Offset: 0x000BBD06
		public virtual IDynamicBulletConfig TypeA
		{
			get
			{
				if (this._TypeAInited)
				{
					return this._TypeACache;
				}
				this._TypeAInited = true;
				this._TypeACache = IDynamicBulletConfig.Create(this.Instance.TypeA);
				return this._TypeACache;
			}
		}

		// Token: 0x170017C9 RID: 6089
		// (get) Token: 0x06004C15 RID: 19477 RVA: 0x000BDB3A File Offset: 0x000BBD3A
		public virtual IDynamicBulletConfig TypeB
		{
			get
			{
				if (this._TypeBInited)
				{
					return this._TypeBCache;
				}
				this._TypeBInited = true;
				this._TypeBCache = IDynamicBulletConfig.Create(this.Instance.TypeB);
				return this._TypeBCache;
			}
		}

		// Token: 0x04002B7B RID: 11131
		private IDynamicPortalByBullet Instance;

		// Token: 0x04002B7C RID: 11132
		[Nullable(2)]
		private IDynamicPortalConfig _PortalACache;

		// Token: 0x04002B7D RID: 11133
		private bool _PortalAInited;

		// Token: 0x04002B7E RID: 11134
		[Nullable(2)]
		private IDynamicPortalConfig _PortalBCache;

		// Token: 0x04002B7F RID: 11135
		private bool _PortalBInited;

		// Token: 0x04002B80 RID: 11136
		[Nullable(2)]
		private IPortalRenderConfig _RenderConfigCache;

		// Token: 0x04002B81 RID: 11137
		private bool _RenderConfigInited;

		// Token: 0x04002B82 RID: 11138
		[Nullable(2)]
		private IDynamicBulletConfig _TypeACache;

		// Token: 0x04002B83 RID: 11139
		private bool _TypeAInited;

		// Token: 0x04002B84 RID: 11140
		[Nullable(2)]
		private IDynamicBulletConfig _TypeBCache;

		// Token: 0x04002B85 RID: 11141
		private bool _TypeBInited;
	}
}
