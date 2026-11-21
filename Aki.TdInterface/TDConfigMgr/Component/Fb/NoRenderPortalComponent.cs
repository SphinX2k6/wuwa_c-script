using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000E03 RID: 3587
	public class NoRenderPortalComponent : IComponentBase
	{
		// Token: 0x0600514D RID: 20813 RVA: 0x000C9636 File Offset: 0x000C7836
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

		// Token: 0x17001942 RID: 6466
		// (get) Token: 0x0600514E RID: 20814 RVA: 0x000C9658 File Offset: 0x000C7858
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

		// Token: 0x17001943 RID: 6467
		// (get) Token: 0x0600514F RID: 20815 RVA: 0x000C9690 File Offset: 0x000C7890
		public override bool? EdIsLocked
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001944 RID: 6468
		// (get) Token: 0x06005150 RID: 20816 RVA: 0x000C96A6 File Offset: 0x000C78A6
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

		// Token: 0x04002E5E RID: 11870
		private INoRenderPortalComponent Instance;

		// Token: 0x04002E5F RID: 11871
		[Nullable(2)]
		private IStaticNoRenderPortal _ConfigCache;

		// Token: 0x04002E60 RID: 11872
		private bool _ConfigInited;
	}
}
