using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000C35 RID: 3125
	public class PullingFoundation : IComponentBase
	{
		// Token: 0x0600478B RID: 18315 RVA: 0x000B55A5 File Offset: 0x000B37A5
		public static PullingFoundation Create(IPullingFoundation? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new PullingFoundation
			{
				Instance = instance.Value
			};
		}

		// Token: 0x1700131C RID: 4892
		// (get) Token: 0x0600478C RID: 18316 RVA: 0x000B55C4 File Offset: 0x000B37C4
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

		// Token: 0x1700131D RID: 4893
		// (get) Token: 0x0600478D RID: 18317 RVA: 0x000B55FC File Offset: 0x000B37FC
		public override bool? EdIsLocked
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700131E RID: 4894
		// (get) Token: 0x0600478E RID: 18318 RVA: 0x000B5612 File Offset: 0x000B3812
		public virtual IPullingCategoryMatchingFoundation Config
		{
			get
			{
				if (this._ConfigInited)
				{
					return this._ConfigCache;
				}
				this._ConfigInited = true;
				this._ConfigCache = IPullingCategoryMatchingFoundation.Create(this.Instance.Config);
				return this._ConfigCache;
			}
		}

		// Token: 0x0400283A RID: 10298
		private IPullingFoundation Instance;

		// Token: 0x0400283B RID: 10299
		[Nullable(2)]
		private IPullingCategoryMatchingFoundation _ConfigCache;

		// Token: 0x0400283C RID: 10300
		private bool _ConfigInited;
	}
}
