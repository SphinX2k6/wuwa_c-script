using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x0200035E RID: 862
	public class IEntityCategoryWeight
	{
		// Token: 0x060010BC RID: 4284 RVA: 0x00039FDC File Offset: 0x000381DC
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

		// Token: 0x060010BD RID: 4285 RVA: 0x0003A014 File Offset: 0x00038214
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

		// Token: 0x060010BE RID: 4286 RVA: 0x0003A027 File Offset: 0x00038227
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

		// Token: 0x060010BF RID: 4287 RVA: 0x0003A03A File Offset: 0x0003823A
		public IEntityCategoryWeight_SetValue ToSetValue()
		{
			return new IEntityCategoryWeight_SetValue
			{
				EntitiyMatch = this.EntitiyMatch,
				Weight = this.Weight
			};
		}

		// Token: 0x170004CD RID: 1229
		// (get) Token: 0x060010C0 RID: 4288 RVA: 0x0003A05C File Offset: 0x0003825C
		// (set) Token: 0x060010C1 RID: 4289 RVA: 0x0003A0BD File Offset: 0x000382BD
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

		// Token: 0x170004CE RID: 1230
		// (get) Token: 0x060010C2 RID: 4290 RVA: 0x0003A0D2 File Offset: 0x000382D2
		// (set) Token: 0x060010C3 RID: 4291 RVA: 0x0003A0FD File Offset: 0x000382FD
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

		// Token: 0x04000E3B RID: 3643
		[Nullable(2)]
		protected IEntityCategoryWeight FbInstance;

		// Token: 0x04000E3C RID: 3644
		[Nullable(2)]
		protected IEntityCategoryWeight_SetValue PocoInterface;

		// Token: 0x04000E3D RID: 3645
		private IStaticEntitiyMatch _EntitiyMatchCache;

		// Token: 0x04000E3E RID: 3646
		private bool _EntitiyMatchInited;
	}
}
