using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200240A RID: 9226
	public class SetBattleState : ActionParams
	{
		// Token: 0x0600C8C0 RID: 51392 RVA: 0x001CADCC File Offset: 0x001C8FCC
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

		// Token: 0x0600C8C1 RID: 51393 RVA: 0x001CAE04 File Offset: 0x001C9004
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

		// Token: 0x0600C8C2 RID: 51394 RVA: 0x001CAE17 File Offset: 0x001C9017
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

		// Token: 0x0600C8C3 RID: 51395 RVA: 0x001CAE2A File Offset: 0x001C902A
		public SetBattleState_SetValue ToSetValue()
		{
			return new SetBattleState_SetValue
			{
				StateOption = this.StateOption
			};
		}

		// Token: 0x17003C69 RID: 15465
		// (get) Token: 0x0600C8C4 RID: 51396 RVA: 0x001CAE3D File Offset: 0x001C903D
		// (set) Token: 0x0600C8C5 RID: 51397 RVA: 0x001CAE64 File Offset: 0x001C9064
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

		// Token: 0x0400771A RID: 30490
		[Nullable(2)]
		protected new SetBattleState FbInstance;

		// Token: 0x0400771B RID: 30491
		[Nullable(2)]
		protected SetBattleState_SetValue PocoInterface;
	}
}
