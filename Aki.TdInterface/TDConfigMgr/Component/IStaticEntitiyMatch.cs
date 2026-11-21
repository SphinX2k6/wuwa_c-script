using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020007BE RID: 1982
	public class IStaticEntitiyMatch
	{
		// Token: 0x06002A53 RID: 10835 RVA: 0x0006F6B4 File Offset: 0x0006D8B4
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

		// Token: 0x06002A54 RID: 10836 RVA: 0x0006F6EC File Offset: 0x0006D8EC
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

		// Token: 0x06002A55 RID: 10837 RVA: 0x0006F6FF File Offset: 0x0006D8FF
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

		// Token: 0x06002A56 RID: 10838 RVA: 0x0006F712 File Offset: 0x0006D912
		public IStaticEntitiyMatch_SetValue ToSetValue()
		{
			return new IStaticEntitiyMatch_SetValue
			{
				Category = this.Category,
				CategoryType = this.CategoryType
			};
		}

		// Token: 0x17000B0C RID: 2828
		// (get) Token: 0x06002A57 RID: 10839 RVA: 0x0006F734 File Offset: 0x0006D934
		// (set) Token: 0x06002A58 RID: 10840 RVA: 0x0006F795 File Offset: 0x0006D995
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

		// Token: 0x17000B0D RID: 2829
		// (get) Token: 0x06002A59 RID: 10841 RVA: 0x0006F7AC File Offset: 0x0006D9AC
		// (set) Token: 0x06002A5A RID: 10842 RVA: 0x0006F7E6 File Offset: 0x0006D9E6
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

		// Token: 0x04001C75 RID: 7285
		[Nullable(2)]
		protected IStaticEntitiyMatch FbInstance;

		// Token: 0x04001C76 RID: 7286
		[Nullable(2)]
		protected IStaticEntitiyMatch_SetValue PocoInterface;

		// Token: 0x04001C77 RID: 7287
		private IEntityCategory _CategoryCache;

		// Token: 0x04001C78 RID: 7288
		private bool _CategoryInited;
	}
}
