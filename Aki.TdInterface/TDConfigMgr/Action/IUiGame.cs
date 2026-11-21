using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002257 RID: 8791
	public class IUiGame
	{
		// Token: 0x0600BF9C RID: 49052 RVA: 0x001BA138 File Offset: 0x001B8338
		private IUiGame_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IUiGame 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IUiGame_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IUiGame_SetValue());
			}
			return result;
		}

		// Token: 0x0600BF9D RID: 49053 RVA: 0x001BA170 File Offset: 0x001B8370
		public static IUiGame Create([Nullable(2)] IUiGame instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IUiGame
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600BF9E RID: 49054 RVA: 0x001BA183 File Offset: 0x001B8383
		public static IUiGame CreateFromSetValue([Nullable(2)] IUiGame_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IUiGame
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600BF9F RID: 49055 RVA: 0x001BA196 File Offset: 0x001B8396
		public IUiGame_SetValue ToSetValue()
		{
			return new IUiGame_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17003A5B RID: 14939
		// (get) Token: 0x0600BFA0 RID: 49056 RVA: 0x001BA1A9 File Offset: 0x001B83A9
		// (set) Token: 0x0600BFA1 RID: 49057 RVA: 0x001BA1D4 File Offset: 0x001B83D4
		public virtual ESimpleGameplayType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ESimpleGameplayType.Cipher;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x040072CA RID: 29386
		[Nullable(2)]
		protected IUiGame FbInstance;

		// Token: 0x040072CB RID: 29387
		[Nullable(2)]
		protected IUiGame_SetValue PocoInterface;
	}
}
