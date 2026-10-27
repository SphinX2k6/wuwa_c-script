using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Quest.Fb;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x02000F6F RID: 3951
	[NullableContext(1)]
	[Nullable(0)]
	public class IFavoriteBtNodeInfo
	{
		// Token: 0x060057D4 RID: 22484 RVA: 0x000D68B0 File Offset: 0x000D4AB0
		private IFavoriteBtNodeInfo_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IFavoriteBtNodeInfo 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IFavoriteBtNodeInfo_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IFavoriteBtNodeInfo_SetValue());
			}
			return result;
		}

		// Token: 0x060057D5 RID: 22485 RVA: 0x000D68E8 File Offset: 0x000D4AE8
		public static IFavoriteBtNodeInfo Create([Nullable(2)] IFavoriteBtNodeInfo instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IFavoriteBtNodeInfo
			{
				FbInstance = instance
			};
		}

		// Token: 0x060057D6 RID: 22486 RVA: 0x000D68FB File Offset: 0x000D4AFB
		public static IFavoriteBtNodeInfo CreateFromSetValue([Nullable(2)] IFavoriteBtNodeInfo_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IFavoriteBtNodeInfo
			{
				PocoInterface = value
			};
		}

		// Token: 0x060057D7 RID: 22487 RVA: 0x000D690E File Offset: 0x000D4B0E
		public IFavoriteBtNodeInfo_SetValue ToSetValue()
		{
			return new IFavoriteBtNodeInfo_SetValue
			{
				Id = this.Id,
				Desc = this.Desc
			};
		}

		// Token: 0x17001D45 RID: 7493
		// (get) Token: 0x060057D8 RID: 22488 RVA: 0x000D692D File Offset: 0x000D4B2D
		// (set) Token: 0x060057D9 RID: 22489 RVA: 0x000D6958 File Offset: 0x000D4B58
		public virtual int Id
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Id;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.Id;
			}
			set
			{
				this.GetOrCreatePoco().Id = value;
			}
		}

		// Token: 0x17001D46 RID: 7494
		// (get) Token: 0x060057DA RID: 22490 RVA: 0x000D6966 File Offset: 0x000D4B66
		// (set) Token: 0x060057DB RID: 22491 RVA: 0x000D6991 File Offset: 0x000D4B91
		public virtual string Desc
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Desc;
				}
				if (this.PocoInterface == null)
				{
					return null;
				}
				return this.PocoInterface.Desc;
			}
			set
			{
				this.GetOrCreatePoco().Desc = value;
			}
		}

		// Token: 0x04003512 RID: 13586
		[Nullable(2)]
		protected IFavoriteBtNodeInfo FbInstance;

		// Token: 0x04003513 RID: 13587
		[Nullable(2)]
		protected IFavoriteBtNodeInfo_SetValue PocoInterface;
	}
}
