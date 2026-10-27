using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000317 RID: 791
	[NullableContext(1)]
	[Nullable(0)]
	public class IEntityCategoryWeight
	{
		// Token: 0x06000F8A RID: 3978 RVA: 0x00037010 File Offset: 0x00035210
		private IEntityCategoryWeight_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IEntityCategoryWeight 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IEntityCategoryWeight_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IEntityCategoryWeight_SetValue());
			}
			return result;
		}

		// Token: 0x06000F8B RID: 3979 RVA: 0x00037048 File Offset: 0x00035248
		public static IEntityCategoryWeight Create([Nullable(2)] IEntityCategoryWeight instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IEntityCategoryWeight
			{
				FbInstance = instance
			};
		}

		// Token: 0x06000F8C RID: 3980 RVA: 0x0003705B File Offset: 0x0003525B
		public static IEntityCategoryWeight CreateFromSetValue([Nullable(2)] IEntityCategoryWeight_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IEntityCategoryWeight
			{
				PocoInterface = value
			};
		}

		// Token: 0x06000F8D RID: 3981 RVA: 0x0003706E File Offset: 0x0003526E
		public IEntityCategoryWeight_SetValue ToSetValue()
		{
			return new IEntityCategoryWeight_SetValue
			{
				EntitiyMatch = this.EntitiyMatch,
				Weight = this.Weight
			};
		}

		// Token: 0x1700047F RID: 1151
		// (get) Token: 0x06000F8E RID: 3982 RVA: 0x00037090 File Offset: 0x00035290
		// (set) Token: 0x06000F8F RID: 3983 RVA: 0x000370F1 File Offset: 0x000352F1
		public virtual IStaticEntitiyMatch EntitiyMatch
		{
			get
			{
				if (this._EntitiyMatchInited)
				{
					return this._EntitiyMatchCache;
				}
				this._EntitiyMatchInited = true;
				if (this.FbInstance != null)
				{
					this._EntitiyMatchCache = IStaticEntitiyMatch.Create(this.FbInstance.EntitiyMatch);
				}
				else
				{
					IEntityCategoryWeight_SetValue pocoInterface = this.PocoInterface;
					this._EntitiyMatchCache = ((pocoInterface != null) ? pocoInterface.EntitiyMatch : null);
				}
				return this._EntitiyMatchCache;
			}
			set
			{
				this.GetOrCreatePoco().EntitiyMatch = value;
				this._EntitiyMatchInited = false;
			}
		}

		// Token: 0x17000480 RID: 1152
		// (get) Token: 0x06000F90 RID: 3984 RVA: 0x00037106 File Offset: 0x00035306
		// (set) Token: 0x06000F91 RID: 3985 RVA: 0x00037131 File Offset: 0x00035331
		public virtual int Weight
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Weight;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.Weight;
			}
			set
			{
				this.GetOrCreatePoco().Weight = value;
			}
		}

		// Token: 0x04000D50 RID: 3408
		[Nullable(2)]
		protected IEntityCategoryWeight FbInstance;

		// Token: 0x04000D51 RID: 3409
		[Nullable(2)]
		protected IEntityCategoryWeight_SetValue PocoInterface;

		// Token: 0x04000D52 RID: 3410
		private IStaticEntitiyMatch _EntitiyMatchCache;

		// Token: 0x04000D53 RID: 3411
		private bool _EntitiyMatchInited;
	}
}
