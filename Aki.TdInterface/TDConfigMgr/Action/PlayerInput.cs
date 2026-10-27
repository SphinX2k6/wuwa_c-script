using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200210D RID: 8461
	[NullableContext(1)]
	[Nullable(0)]
	public class PlayerInput : ActionParams
	{
		// Token: 0x0600BA20 RID: 47648 RVA: 0x001AE1F0 File Offset: 0x001AC3F0
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

		// Token: 0x0600BA21 RID: 47649 RVA: 0x001AE228 File Offset: 0x001AC428
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

		// Token: 0x0600BA22 RID: 47650 RVA: 0x001AE23B File Offset: 0x001AC43B
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

		// Token: 0x0600BA23 RID: 47651 RVA: 0x001AE24E File Offset: 0x001AC44E
		public PlayerInput_SetValue ToSetValue()
		{
			return new PlayerInput_SetValue
			{
				Input = this.Input
			};
		}

		// Token: 0x170038D6 RID: 14550
		// (get) Token: 0x0600BA24 RID: 47652 RVA: 0x001AE261 File Offset: 0x001AC461
		// (set) Token: 0x0600BA25 RID: 47653 RVA: 0x001AE28C File Offset: 0x001AC48C
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

		// Token: 0x04006F6B RID: 28523
		[Nullable(2)]
		protected new PlayerInput FbInstance;

		// Token: 0x04006F6C RID: 28524
		[Nullable(2)]
		protected PlayerInput_SetValue PocoInterface;
	}
}
