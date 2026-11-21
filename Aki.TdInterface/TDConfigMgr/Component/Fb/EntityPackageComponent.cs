using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000CC7 RID: 3271
	[NullableContext(2)]
	[Nullable(0)]
	public class EntityPackageComponent : IComponentBase
	{
		// Token: 0x06004ABF RID: 19135 RVA: 0x000BBE2E File Offset: 0x000BA02E
		[NullableContext(0)]
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

		// Token: 0x1700152C RID: 5420
		// (get) Token: 0x06004AC0 RID: 19136 RVA: 0x000BBE50 File Offset: 0x000BA050
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

		// Token: 0x1700152D RID: 5421
		// (get) Token: 0x06004AC1 RID: 19137 RVA: 0x000BBE88 File Offset: 0x000BA088
		public override bool? EdIsLocked
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700152E RID: 5422
		// (get) Token: 0x06004AC2 RID: 19138 RVA: 0x000BBE9E File Offset: 0x000BA09E
		public virtual bool BindTemplate
		{
			get
			{
				return this.Instance.BindTemplate;
			}
		}

		// Token: 0x1700152F RID: 5423
		// (get) Token: 0x06004AC3 RID: 19139 RVA: 0x000BBEAB File Offset: 0x000BA0AB
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

		// Token: 0x04002A5A RID: 10842
		private IEntityPackageComponent Instance;

		// Token: 0x04002A5B RID: 10843
		private IEntityPackageData _PackageDataCache;

		// Token: 0x04002A5C RID: 10844
		private bool _PackageDataInited;
	}
}
