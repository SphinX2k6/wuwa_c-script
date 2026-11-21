using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000060 RID: 96
	public class DynamicPortalCreatorComponent : IComponentBase
	{
		// Token: 0x06000326 RID: 806 RVA: 0x0001BC10 File Offset: 0x00019E10
		private DynamicPortalCreatorComponent_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("DynamicPortalCreatorComponent 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			DynamicPortalCreatorComponent_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new DynamicPortalCreatorComponent_SetValue());
			}
			return result;
		}

		// Token: 0x06000327 RID: 807 RVA: 0x0001BC48 File Offset: 0x00019E48
		public static DynamicPortalCreatorComponent Create([Nullable(2)] DynamicPortalCreatorComponent instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new DynamicPortalCreatorComponent
			{
				FbInstance = instance
			};
		}

		// Token: 0x06000328 RID: 808 RVA: 0x0001BC5B File Offset: 0x00019E5B
		public static DynamicPortalCreatorComponent CreateFromSetValue([Nullable(2)] DynamicPortalCreatorComponent_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new DynamicPortalCreatorComponent
			{
				PocoInterface = value
			};
		}

		// Token: 0x06000329 RID: 809 RVA: 0x0001BC6E File Offset: 0x00019E6E
		public new DynamicPortalCreatorComponent_SetValue ToSetValue()
		{
			return new DynamicPortalCreatorComponent_SetValue
			{
				Disabled = this.Disabled,
				EdIsLocked = this.EdIsLocked,
				Model = this.Model
			};
		}

		// Token: 0x17000115 RID: 277
		// (get) Token: 0x0600032A RID: 810 RVA: 0x0001BC9C File Offset: 0x00019E9C
		// (set) Token: 0x0600032B RID: 811 RVA: 0x0001BCD6 File Offset: 0x00019ED6
		public override bool? Disabled
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Disabled;
				}
				DynamicPortalCreatorComponent_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x17000116 RID: 278
		// (get) Token: 0x0600032C RID: 812 RVA: 0x0001BCE4 File Offset: 0x00019EE4
		// (set) Token: 0x0600032D RID: 813 RVA: 0x0001BD0E File Offset: 0x00019F0E
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

		// Token: 0x17000117 RID: 279
		// (get) Token: 0x0600032E RID: 814 RVA: 0x0001BD1C File Offset: 0x00019F1C
		// (set) Token: 0x0600032F RID: 815 RVA: 0x0001BD7D File Offset: 0x00019F7D
		public virtual IDynamicPortalByBullet Model
		{
			get
			{
				if (this._ModelInited)
				{
					return this._ModelCache;
				}
				this._ModelInited = true;
				if (this.FbInstance != null)
				{
					this._ModelCache = IDynamicPortalByBullet.Create(this.FbInstance.Model);
				}
				else
				{
					DynamicPortalCreatorComponent_SetValue pocoInterface = this.PocoInterface;
					this._ModelCache = ((pocoInterface != null) ? pocoInterface.Model : null);
				}
				return this._ModelCache;
			}
			set
			{
				this.GetOrCreatePoco().Model = value;
				this._ModelInited = false;
			}
		}

		// Token: 0x04000201 RID: 513
		[Nullable(2)]
		protected new DynamicPortalCreatorComponent FbInstance;

		// Token: 0x04000202 RID: 514
		[Nullable(2)]
		protected new DynamicPortalCreatorComponent_SetValue PocoInterface;

		// Token: 0x04000203 RID: 515
		private IDynamicPortalByBullet _ModelCache;

		// Token: 0x04000204 RID: 516
		private bool _ModelInited;
	}
}
