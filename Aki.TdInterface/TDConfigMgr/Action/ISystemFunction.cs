using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001F0F RID: 7951
	[NullableContext(1)]
	[Nullable(0)]
	public class ISystemFunction
	{
		// Token: 0x0600AA0A RID: 43530 RVA: 0x0017F0B0 File Offset: 0x0017D2B0
		private ISystemFunction_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ISystemFunction 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ISystemFunction_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ISystemFunction_SetValue());
			}
			return result;
		}

		// Token: 0x0600AA0B RID: 43531 RVA: 0x0017F0E8 File Offset: 0x0017D2E8
		public static ISystemFunction Create([Nullable(2)] ISystemFunction instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ISystemFunction
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600AA0C RID: 43532 RVA: 0x0017F0FB File Offset: 0x0017D2FB
		public static ISystemFunction CreateFromSetValue([Nullable(2)] ISystemFunction_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ISystemFunction
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600AA0D RID: 43533 RVA: 0x0017F10E File Offset: 0x0017D30E
		public ISystemFunction_SetValue ToSetValue()
		{
			return new ISystemFunction_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x170033C6 RID: 13254
		// (get) Token: 0x0600AA0E RID: 43534 RVA: 0x0017F121 File Offset: 0x0017D321
		// (set) Token: 0x0600AA0F RID: 43535 RVA: 0x0017F14C File Offset: 0x0017D34C
		public virtual ESystemFunction Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ESystemFunction.BuyGoods;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x0400650D RID: 25869
		[Nullable(2)]
		protected ISystemFunction FbInstance;

		// Token: 0x0400650E RID: 25870
		[Nullable(2)]
		protected ISystemFunction_SetValue PocoInterface;
	}
}
