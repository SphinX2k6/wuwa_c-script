using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001D4D RID: 7501
	public class ILiveDanmakuOperation
	{
		// Token: 0x06009F45 RID: 40773 RVA: 0x0016DDBC File Offset: 0x0016BFBC
		private ILiveDanmakuOperation_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ILiveDanmakuOperation 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ILiveDanmakuOperation_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ILiveDanmakuOperation_SetValue());
			}
			return result;
		}

		// Token: 0x06009F46 RID: 40774 RVA: 0x0016DDF4 File Offset: 0x0016BFF4
		public static ILiveDanmakuOperation Create([Nullable(2)] ILiveDanmakuOperation instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ILiveDanmakuOperation
			{
				FbInstance = instance
			};
		}

		// Token: 0x06009F47 RID: 40775 RVA: 0x0016DE07 File Offset: 0x0016C007
		public static ILiveDanmakuOperation CreateFromSetValue([Nullable(2)] ILiveDanmakuOperation_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ILiveDanmakuOperation
			{
				PocoInterface = value
			};
		}

		// Token: 0x06009F48 RID: 40776 RVA: 0x0016DE1A File Offset: 0x0016C01A
		public ILiveDanmakuOperation_SetValue ToSetValue()
		{
			return new ILiveDanmakuOperation_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x170031BD RID: 12733
		// (get) Token: 0x06009F49 RID: 40777 RVA: 0x0016DE2D File Offset: 0x0016C02D
		// (set) Token: 0x06009F4A RID: 40778 RVA: 0x0016DE58 File Offset: 0x0016C058
		public virtual ELiveDanmakuOperationType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ELiveDanmakuOperationType.Load;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x040060FC RID: 24828
		[Nullable(2)]
		protected ILiveDanmakuOperation FbInstance;

		// Token: 0x040060FD RID: 24829
		[Nullable(2)]
		protected ILiveDanmakuOperation_SetValue PocoInterface;
	}
}
