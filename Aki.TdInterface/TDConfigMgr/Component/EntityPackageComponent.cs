using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x0200010A RID: 266
	public class EntityPackageComponent : IComponentBase
	{
		// Token: 0x06000424 RID: 1060 RVA: 0x0001DF50 File Offset: 0x0001C150
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

		// Token: 0x06000425 RID: 1061 RVA: 0x0001DF88 File Offset: 0x0001C188
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

		// Token: 0x06000426 RID: 1062 RVA: 0x0001DF9B File Offset: 0x0001C19B
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

		// Token: 0x06000427 RID: 1063 RVA: 0x0001DFAE File Offset: 0x0001C1AE
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

		// Token: 0x17000161 RID: 353
		// (get) Token: 0x06000428 RID: 1064 RVA: 0x0001DFE8 File Offset: 0x0001C1E8
		// (set) Token: 0x06000429 RID: 1065 RVA: 0x0001E022 File Offset: 0x0001C222
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

		// Token: 0x17000162 RID: 354
		// (get) Token: 0x0600042A RID: 1066 RVA: 0x0001E030 File Offset: 0x0001C230
		// (set) Token: 0x0600042B RID: 1067 RVA: 0x0001E05A File Offset: 0x0001C25A
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

		// Token: 0x17000163 RID: 355
		// (get) Token: 0x0600042C RID: 1068 RVA: 0x0001E068 File Offset: 0x0001C268
		// (set) Token: 0x0600042D RID: 1069 RVA: 0x0001E093 File Offset: 0x0001C293
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

		// Token: 0x17000164 RID: 356
		// (get) Token: 0x0600042E RID: 1070 RVA: 0x0001E0A4 File Offset: 0x0001C2A4
		// (set) Token: 0x0600042F RID: 1071 RVA: 0x0001E105 File Offset: 0x0001C305
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

		// Token: 0x04000583 RID: 1411
		[Nullable(2)]
		protected new EntityPackageComponent FbInstance;

		// Token: 0x04000584 RID: 1412
		[Nullable(2)]
		protected new EntityPackageComponent_SetValue PocoInterface;

		// Token: 0x04000585 RID: 1413
		private IEntityPackageData _PackageDataCache;

		// Token: 0x04000586 RID: 1414
		private bool _PackageDataInited;
	}
}
