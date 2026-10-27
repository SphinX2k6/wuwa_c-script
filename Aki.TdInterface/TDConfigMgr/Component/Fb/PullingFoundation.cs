using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000B67 RID: 2919
	[NullableContext(1)]
	[Nullable(0)]
	public class PullingFoundation : IComponentBase
	{
		// Token: 0x06004332 RID: 17202 RVA: 0x000AB4E1 File Offset: 0x000A96E1
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

		// Token: 0x17001221 RID: 4641
		// (get) Token: 0x06004333 RID: 17203 RVA: 0x000AB500 File Offset: 0x000A9700
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

		// Token: 0x17001222 RID: 4642
		// (get) Token: 0x06004334 RID: 17204 RVA: 0x000AB538 File Offset: 0x000A9738
		public override bool? EdIsLocked
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001223 RID: 4643
		// (get) Token: 0x06004335 RID: 17205 RVA: 0x000AB54E File Offset: 0x000A974E
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

		// Token: 0x040025F2 RID: 9714
		private IPullingFoundation Instance;

		// Token: 0x040025F3 RID: 9715
		[Nullable(2)]
		private IPullingCategoryMatchingFoundation _ConfigCache;

		// Token: 0x040025F4 RID: 9716
		private bool _ConfigInited;
	}
}
