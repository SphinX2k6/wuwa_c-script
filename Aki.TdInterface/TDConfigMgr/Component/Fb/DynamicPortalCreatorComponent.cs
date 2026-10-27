using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000D05 RID: 3333
	[NullableContext(1)]
	[Nullable(0)]
	public class DynamicPortalCreatorComponent : IComponentBase
	{
		// Token: 0x06004C17 RID: 19479 RVA: 0x000BDB76 File Offset: 0x000BBD76
		public static DynamicPortalCreatorComponent Create(IDynamicPortalCreatorComponent? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new DynamicPortalCreatorComponent
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170017CA RID: 6090
		// (get) Token: 0x06004C18 RID: 19480 RVA: 0x000BDB98 File Offset: 0x000BBD98
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

		// Token: 0x170017CB RID: 6091
		// (get) Token: 0x06004C19 RID: 19481 RVA: 0x000BDBD0 File Offset: 0x000BBDD0
		public override bool? EdIsLocked
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170017CC RID: 6092
		// (get) Token: 0x06004C1A RID: 19482 RVA: 0x000BDBE6 File Offset: 0x000BBDE6
		public virtual IDynamicPortalByBullet Model
		{
			get
			{
				if (this._ModelInited)
				{
					return this._ModelCache;
				}
				this._ModelInited = true;
				this._ModelCache = IDynamicPortalByBullet.Create(this.Instance.Model);
				return this._ModelCache;
			}
		}

		// Token: 0x04002B86 RID: 11142
		private IDynamicPortalCreatorComponent Instance;

		// Token: 0x04002B87 RID: 11143
		[Nullable(2)]
		private IDynamicPortalByBullet _ModelCache;

		// Token: 0x04002B88 RID: 11144
		private bool _ModelInited;
	}
}
