using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001886 RID: 6278
	public class ExecBattleAction : ActionParams
	{
		// Token: 0x060083DD RID: 33757 RVA: 0x0013B3BC File Offset: 0x001395BC
		private ExecBattleAction_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ExecBattleAction 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ExecBattleAction_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ExecBattleAction_SetValue());
			}
			return result;
		}

		// Token: 0x060083DE RID: 33758 RVA: 0x0013B3F4 File Offset: 0x001395F4
		public static ExecBattleAction Create([Nullable(2)] ExecBattleAction instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ExecBattleAction
			{
				FbInstance = instance
			};
		}

		// Token: 0x060083DF RID: 33759 RVA: 0x0013B407 File Offset: 0x00139607
		public static ExecBattleAction CreateFromSetValue([Nullable(2)] ExecBattleAction_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ExecBattleAction
			{
				PocoInterface = value
			};
		}

		// Token: 0x060083E0 RID: 33760 RVA: 0x0013B41A File Offset: 0x0013961A
		public ExecBattleAction_SetValue ToSetValue()
		{
			return new ExecBattleAction_SetValue
			{
				BattleOption = this.BattleOption
			};
		}

		// Token: 0x17002B2C RID: 11052
		// (get) Token: 0x060083E1 RID: 33761 RVA: 0x0013B42D File Offset: 0x0013962D
		// (set) Token: 0x060083E2 RID: 33762 RVA: 0x0013B454 File Offset: 0x00139654
		public virtual IExecBattleActionType BattleOption
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.BattleOption;
				}
				ExecBattleAction_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.BattleOption;
			}
			set
			{
				this.GetOrCreatePoco().BattleOption = value;
			}
		}

		// Token: 0x04005408 RID: 21512
		[Nullable(2)]
		protected new ExecBattleAction FbInstance;

		// Token: 0x04005409 RID: 21513
		[Nullable(2)]
		protected ExecBattleAction_SetValue PocoInterface;
	}
}
