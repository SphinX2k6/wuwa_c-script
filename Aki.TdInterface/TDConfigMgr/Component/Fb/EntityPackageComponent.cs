using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000BF7 RID: 3063
	[NullableContext(2)]
	[Nullable(0)]
	public class EntityPackageComponent : IComponentBase
	{
		// Token: 0x0600465C RID: 18012 RVA: 0x000B1C62 File Offset: 0x000AFE62
		[NullableContext(1)]
		public static EntityPackageComponent Create(IEntityPackageComponent? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new EntityPackageComponent
			{
				Instance = instance.Value
			};
		}

		// Token: 0x1700142B RID: 5163
		// (get) Token: 0x0600465D RID: 18013 RVA: 0x000B1C84 File Offset: 0x000AFE84
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

		// Token: 0x1700142C RID: 5164
		// (get) Token: 0x0600465E RID: 18014 RVA: 0x000B1CBC File Offset: 0x000AFEBC
		public override bool? EdIsLocked
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700142D RID: 5165
		// (get) Token: 0x0600465F RID: 18015 RVA: 0x000B1CD2 File Offset: 0x000AFED2
		public virtual bool BindTemplate
		{
			get
			{
				return this.Instance.BindTemplate;
			}
		}

		// Token: 0x1700142E RID: 5166
		// (get) Token: 0x06004660 RID: 18016 RVA: 0x000B1CDF File Offset: 0x000AFEDF
		public virtual IEntityPackageData PackageData
		{
			get
			{
				if (this._PackageDataInited)
				{
					return this._PackageDataCache;
				}
				this._PackageDataInited = true;
				this._PackageDataCache = IEntityPackageData.Create(this.Instance.PackageData);
				return this._PackageDataCache;
			}
		}

		// Token: 0x0400280E RID: 10254
		private IEntityPackageComponent Instance;

		// Token: 0x0400280F RID: 10255
		private IEntityPackageData _PackageDataCache;

		// Token: 0x04002810 RID: 10256
		private bool _PackageDataInited;
	}
}
