using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002148 RID: 8520
	public class ISystemFunction
	{
		// Token: 0x0600B4DC RID: 46300 RVA: 0x001950A8 File Offset: 0x001932A8
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

		// Token: 0x0600B4DD RID: 46301 RVA: 0x001950E0 File Offset: 0x001932E0
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

		// Token: 0x0600B4DE RID: 46302 RVA: 0x001950F3 File Offset: 0x001932F3
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

		// Token: 0x0600B4DF RID: 46303 RVA: 0x00195106 File Offset: 0x00193306
		public ISystemFunction_SetValue ToSetValue()
		{
			return new ISystemFunction_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17003691 RID: 13969
		// (get) Token: 0x0600B4E0 RID: 46304 RVA: 0x00195119 File Offset: 0x00193319
		// (set) Token: 0x0600B4E1 RID: 46305 RVA: 0x00195144 File Offset: 0x00193344
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

		// Token: 0x04006AFC RID: 27388
		[Nullable(2)]
		protected ISystemFunction FbInstance;

		// Token: 0x04006AFD RID: 27389
		[Nullable(2)]
		protected ISystemFunction_SetValue PocoInterface;
	}
}
