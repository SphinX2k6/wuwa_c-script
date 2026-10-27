using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000D0A RID: 3338
	[NullableContext(1)]
	[Nullable(0)]
	public class NoRenderPortalComponent : IComponentBase
	{
		// Token: 0x06004C3A RID: 19514 RVA: 0x000BE08E File Offset: 0x000BC28E
		public static NoRenderPortalComponent Create(INoRenderPortalComponent? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new NoRenderPortalComponent
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170017E3 RID: 6115
		// (get) Token: 0x06004C3B RID: 19515 RVA: 0x000BE0B0 File Offset: 0x000BC2B0
		public override bool? Disabled
		{
			get
			{
				if ((this.Instance.NullMask & 1) == 0)
				{
					return null;
				}
				return new bool?(this.Instance.Disabled);
			}
		}

		// Token: 0x170017E4 RID: 6116
		// (get) Token: 0x06004C3C RID: 19516 RVA: 0x000BE0E8 File Offset: 0x000BC2E8
		public override bool? EdIsLocked
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170017E5 RID: 6117
		// (get) Token: 0x06004C3D RID: 19517 RVA: 0x000BE0FE File Offset: 0x000BC2FE
		public virtual IStaticNoRenderPortal Config
		{
			get
			{
				if (this._ConfigInited)
				{
					return this._ConfigCache;
				}
				this._ConfigInited = true;
				this._ConfigCache = IStaticNoRenderPortal.Create(this.Instance.Config);
				return this._ConfigCache;
			}
		}

		// Token: 0x04002BA1 RID: 11169
		private INoRenderPortalComponent Instance;

		// Token: 0x04002BA2 RID: 11170
		[Nullable(2)]
		private IStaticNoRenderPortal _ConfigCache;

		// Token: 0x04002BA3 RID: 11171
		private bool _ConfigInited;
	}
}
