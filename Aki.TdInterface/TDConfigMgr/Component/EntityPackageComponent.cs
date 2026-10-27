using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000101 RID: 257
	[NullableContext(1)]
	[Nullable(0)]
	public class EntityPackageComponent : IComponentBase
	{
		// Token: 0x06000420 RID: 1056 RVA: 0x0001D5DC File Offset: 0x0001B7DC
		private EntityPackageComponent_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("EntityPackageComponent 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			EntityPackageComponent_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new EntityPackageComponent_SetValue());
			}
			return result;
		}

		// Token: 0x06000421 RID: 1057 RVA: 0x0001D614 File Offset: 0x0001B814
		public static EntityPackageComponent Create([Nullable(2)] EntityPackageComponent instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new EntityPackageComponent
			{
				FbInstance = instance
			};
		}

		// Token: 0x06000422 RID: 1058 RVA: 0x0001D627 File Offset: 0x0001B827
		public static EntityPackageComponent CreateFromSetValue([Nullable(2)] EntityPackageComponent_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new EntityPackageComponent
			{
				PocoInterface = value
			};
		}

		// Token: 0x06000423 RID: 1059 RVA: 0x0001D63A File Offset: 0x0001B83A
		public new EntityPackageComponent_SetValue ToSetValue()
		{
			return new EntityPackageComponent_SetValue
			{
				Disabled = this.Disabled,
				EdIsLocked = this.EdIsLocked,
				BindTemplate = this.BindTemplate,
				PackageData = this.PackageData
			};
		}

		// Token: 0x1700015F RID: 351
		// (get) Token: 0x06000424 RID: 1060 RVA: 0x0001D674 File Offset: 0x0001B874
		// (set) Token: 0x06000425 RID: 1061 RVA: 0x0001D6AE File Offset: 0x0001B8AE
		public override bool? Disabled
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Disabled;
				}
				EntityPackageComponent_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.Disabled;
			}
			set
			{
				this.GetOrCreatePoco().Disabled = value;
			}
		}

		// Token: 0x17000160 RID: 352
		// (get) Token: 0x06000426 RID: 1062 RVA: 0x0001D6BC File Offset: 0x0001B8BC
		// (set) Token: 0x06000427 RID: 1063 RVA: 0x0001D6E6 File Offset: 0x0001B8E6
		public override bool? EdIsLocked
		{
			get
			{
				if (this.PocoInterface != null)
				{
					return this.PocoInterface.EdIsLocked;
				}
				return null;
			}
			set
			{
				this.GetOrCreatePoco().EdIsLocked = value;
			}
		}

		// Token: 0x17000161 RID: 353
		// (get) Token: 0x06000428 RID: 1064 RVA: 0x0001D6F4 File Offset: 0x0001B8F4
		// (set) Token: 0x06000429 RID: 1065 RVA: 0x0001D71F File Offset: 0x0001B91F
		public virtual bool BindTemplate
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.BindTemplate;
				}
				return this.PocoInterface != null && this.PocoInterface.BindTemplate;
			}
			set
			{
				this.GetOrCreatePoco().BindTemplate = value;
			}
		}

		// Token: 0x17000162 RID: 354
		// (get) Token: 0x0600042A RID: 1066 RVA: 0x0001D730 File Offset: 0x0001B930
		// (set) Token: 0x0600042B RID: 1067 RVA: 0x0001D791 File Offset: 0x0001B991
		[Nullable(2)]
		public virtual IEntityPackageData PackageData
		{
			[NullableContext(2)]
			get
			{
				if (this._PackageDataInited)
				{
					return this._PackageDataCache;
				}
				this._PackageDataInited = true;
				if (this.FbInstance != null)
				{
					this._PackageDataCache = IEntityPackageData.Create(this.FbInstance.PackageData);
				}
				else
				{
					EntityPackageComponent_SetValue pocoInterface = this.PocoInterface;
					this._PackageDataCache = ((pocoInterface != null) ? pocoInterface.PackageData : null);
				}
				return this._PackageDataCache;
			}
			[NullableContext(2)]
			set
			{
				this.GetOrCreatePoco().PackageData = value;
				this._PackageDataInited = false;
			}
		}

		// Token: 0x04000559 RID: 1369
		[Nullable(2)]
		protected new EntityPackageComponent FbInstance;

		// Token: 0x0400055A RID: 1370
		[Nullable(2)]
		protected new EntityPackageComponent_SetValue PocoInterface;

		// Token: 0x0400055B RID: 1371
		private IEntityPackageData _PackageDataCache;

		// Token: 0x0400055C RID: 1372
		private bool _PackageDataInited;
	}
}
