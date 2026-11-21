using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200236E RID: 9070
	public class PlayerInput : ActionParams
	{
		// Token: 0x0600C5AC RID: 50604 RVA: 0x001C5350 File Offset: 0x001C3550
		private PlayerInput_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("PlayerInput 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			PlayerInput_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new PlayerInput_SetValue());
			}
			return result;
		}

		// Token: 0x0600C5AD RID: 50605 RVA: 0x001C5388 File Offset: 0x001C3588
		public static PlayerInput Create([Nullable(2)] PlayerInput instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new PlayerInput
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600C5AE RID: 50606 RVA: 0x001C539B File Offset: 0x001C359B
		public static PlayerInput CreateFromSetValue([Nullable(2)] PlayerInput_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new PlayerInput
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600C5AF RID: 50607 RVA: 0x001C53AE File Offset: 0x001C35AE
		public PlayerInput_SetValue ToSetValue()
		{
			return new PlayerInput_SetValue
			{
				Input = this.Input
			};
		}

		// Token: 0x17003BC2 RID: 15298
		// (get) Token: 0x0600C5B0 RID: 50608 RVA: 0x001C53C1 File Offset: 0x001C35C1
		// (set) Token: 0x0600C5B1 RID: 50609 RVA: 0x001C53EC File Offset: 0x001C35EC
		public virtual EPlayerInputType Input
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Input;
				}
				if (this.PocoInterface == null)
				{
					return (EPlayerInputType)0;
				}
				return this.PocoInterface.Input;
			}
			set
			{
				this.GetOrCreatePoco().Input = value;
			}
		}

		// Token: 0x0400759F RID: 30111
		[Nullable(2)]
		protected new PlayerInput FbInstance;

		// Token: 0x040075A0 RID: 30112
		[Nullable(2)]
		protected PlayerInput_SetValue PocoInterface;
	}
}
