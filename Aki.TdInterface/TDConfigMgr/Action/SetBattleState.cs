using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200219F RID: 8607
	[NullableContext(1)]
	[Nullable(0)]
	public class SetBattleState : ActionParams
	{
		// Token: 0x0600BD06 RID: 48390 RVA: 0x001B3794 File Offset: 0x001B1994
		private SetBattleState_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("SetBattleState 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			SetBattleState_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new SetBattleState_SetValue());
			}
			return result;
		}

		// Token: 0x0600BD07 RID: 48391 RVA: 0x001B37CC File Offset: 0x001B19CC
		public static SetBattleState Create([Nullable(2)] SetBattleState instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new SetBattleState
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600BD08 RID: 48392 RVA: 0x001B37DF File Offset: 0x001B19DF
		public static SetBattleState CreateFromSetValue([Nullable(2)] SetBattleState_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new SetBattleState
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600BD09 RID: 48393 RVA: 0x001B37F2 File Offset: 0x001B19F2
		public SetBattleState_SetValue ToSetValue()
		{
			return new SetBattleState_SetValue
			{
				StateOption = this.StateOption
			};
		}

		// Token: 0x17003975 RID: 14709
		// (get) Token: 0x0600BD0A RID: 48394 RVA: 0x001B3805 File Offset: 0x001B1A05
		// (set) Token: 0x0600BD0B RID: 48395 RVA: 0x001B382C File Offset: 0x001B1A2C
		public virtual ISendBattleStateType StateOption
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.StateOption;
				}
				SetBattleState_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.StateOption;
			}
			set
			{
				this.GetOrCreatePoco().StateOption = value;
			}
		}

		// Token: 0x040070D2 RID: 28882
		[Nullable(2)]
		protected new SetBattleState FbInstance;

		// Token: 0x040070D3 RID: 28883
		[Nullable(2)]
		protected SetBattleState_SetValue PocoInterface;
	}
}
