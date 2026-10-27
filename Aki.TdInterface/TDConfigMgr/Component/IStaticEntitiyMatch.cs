using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x0200071D RID: 1821
	[NullableContext(1)]
	[Nullable(0)]
	public class IStaticEntitiyMatch
	{
		// Token: 0x06002731 RID: 10033 RVA: 0x00068590 File Offset: 0x00066790
		private IStaticEntitiyMatch_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IStaticEntitiyMatch 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IStaticEntitiyMatch_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IStaticEntitiyMatch_SetValue());
			}
			return result;
		}

		// Token: 0x06002732 RID: 10034 RVA: 0x000685C8 File Offset: 0x000667C8
		public static IStaticEntitiyMatch Create([Nullable(2)] IStaticEntitiyMatch instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IStaticEntitiyMatch
			{
				FbInstance = instance
			};
		}

		// Token: 0x06002733 RID: 10035 RVA: 0x000685DB File Offset: 0x000667DB
		public static IStaticEntitiyMatch CreateFromSetValue([Nullable(2)] IStaticEntitiyMatch_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IStaticEntitiyMatch
			{
				PocoInterface = value
			};
		}

		// Token: 0x06002734 RID: 10036 RVA: 0x000685EE File Offset: 0x000667EE
		public IStaticEntitiyMatch_SetValue ToSetValue()
		{
			return new IStaticEntitiyMatch_SetValue
			{
				Category = this.Category,
				CategoryType = this.CategoryType
			};
		}

		// Token: 0x17000A4D RID: 2637
		// (get) Token: 0x06002735 RID: 10037 RVA: 0x00068610 File Offset: 0x00066810
		// (set) Token: 0x06002736 RID: 10038 RVA: 0x00068671 File Offset: 0x00066871
		[Nullable(2)]
		public virtual IEntityCategory Category
		{
			[NullableContext(2)]
			get
			{
				if (this._CategoryInited)
				{
					return this._CategoryCache;
				}
				this._CategoryInited = true;
				if (this.FbInstance != null)
				{
					this._CategoryCache = IEntityCategory.Create(this.FbInstance.Category);
				}
				else
				{
					IStaticEntitiyMatch_SetValue pocoInterface = this.PocoInterface;
					this._CategoryCache = ((pocoInterface != null) ? pocoInterface.Category : null);
				}
				return this._CategoryCache;
			}
			[NullableContext(2)]
			set
			{
				this.GetOrCreatePoco().Category = value;
				this._CategoryInited = false;
			}
		}

		// Token: 0x17000A4E RID: 2638
		// (get) Token: 0x06002737 RID: 10039 RVA: 0x00068688 File Offset: 0x00066888
		// (set) Token: 0x06002738 RID: 10040 RVA: 0x000686C2 File Offset: 0x000668C2
		public virtual EEntityCategory? CategoryType
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.CategoryType;
				}
				IStaticEntitiyMatch_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.CategoryType;
			}
			set
			{
				this.GetOrCreatePoco().CategoryType = value;
			}
		}

		// Token: 0x04001A73 RID: 6771
		[Nullable(2)]
		protected IStaticEntitiyMatch FbInstance;

		// Token: 0x04001A74 RID: 6772
		[Nullable(2)]
		protected IStaticEntitiyMatch_SetValue PocoInterface;

		// Token: 0x04001A75 RID: 6773
		private IEntityCategory _CategoryCache;

		// Token: 0x04001A76 RID: 6774
		private bool _CategoryInited;
	}
}
