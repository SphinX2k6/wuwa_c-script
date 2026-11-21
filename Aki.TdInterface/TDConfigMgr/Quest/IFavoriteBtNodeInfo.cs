using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Quest.Fb;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x02001099 RID: 4249
	public class IFavoriteBtNodeInfo
	{
		// Token: 0x06005DA8 RID: 23976 RVA: 0x000E331C File Offset: 0x000E151C
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

		// Token: 0x06005DA9 RID: 23977 RVA: 0x000E3354 File Offset: 0x000E1554
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

		// Token: 0x06005DAA RID: 23978 RVA: 0x000E3367 File Offset: 0x000E1567
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

		// Token: 0x06005DAB RID: 23979 RVA: 0x000E337A File Offset: 0x000E157A
		public IFavoriteBtNodeInfo_SetValue ToSetValue()
		{
			return new IFavoriteBtNodeInfo_SetValue
			{
				Id = this.Id,
				Desc = this.Desc
			};
		}

		// Token: 0x17001EEB RID: 7915
		// (get) Token: 0x06005DAC RID: 23980 RVA: 0x000E3399 File Offset: 0x000E1599
		// (set) Token: 0x06005DAD RID: 23981 RVA: 0x000E33C4 File Offset: 0x000E15C4
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

		// Token: 0x17001EEC RID: 7916
		// (get) Token: 0x06005DAE RID: 23982 RVA: 0x000E33D2 File Offset: 0x000E15D2
		// (set) Token: 0x06005DAF RID: 23983 RVA: 0x000E33FD File Offset: 0x000E15FD
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

		// Token: 0x04003843 RID: 14403
		[Nullable(2)]
		protected IFavoriteBtNodeInfo FbInstance;

		// Token: 0x04003844 RID: 14404
		[Nullable(2)]
		protected IFavoriteBtNodeInfo_SetValue PocoInterface;
	}
}
