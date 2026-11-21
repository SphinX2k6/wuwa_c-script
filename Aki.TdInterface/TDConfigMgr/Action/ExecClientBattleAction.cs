using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200188A RID: 6282
	public class ExecClientBattleAction : ActionParams
	{
		// Token: 0x060083ED RID: 33773 RVA: 0x0013B52C File Offset: 0x0013972C
		private ExecClientBattleAction_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ExecClientBattleAction 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ExecClientBattleAction_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ExecClientBattleAction_SetValue());
			}
			return result;
		}

		// Token: 0x060083EE RID: 33774 RVA: 0x0013B564 File Offset: 0x00139764
		public static ExecClientBattleAction Create([Nullable(2)] ExecClientBattleAction instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ExecClientBattleAction
			{
				FbInstance = instance
			};
		}

		// Token: 0x060083EF RID: 33775 RVA: 0x0013B577 File Offset: 0x00139777
		public static ExecClientBattleAction CreateFromSetValue([Nullable(2)] ExecClientBattleAction_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ExecClientBattleAction
			{
				PocoInterface = value
			};
		}

		// Token: 0x060083F0 RID: 33776 RVA: 0x0013B58A File Offset: 0x0013978A
		public ExecClientBattleAction_SetValue ToSetValue()
		{
			return new ExecClientBattleAction_SetValue
			{
				ClientBattleOption = this.ClientBattleOption
			};
		}

		// Token: 0x17002B2E RID: 11054
		// (get) Token: 0x060083F1 RID: 33777 RVA: 0x0013B59D File Offset: 0x0013979D
		// (set) Token: 0x060083F2 RID: 33778 RVA: 0x0013B5C4 File Offset: 0x001397C4
		public virtual IExecClientBattleActionType ClientBattleOption
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.ClientBattleOption;
				}
				ExecClientBattleAction_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.ClientBattleOption;
			}
			set
			{
				this.GetOrCreatePoco().ClientBattleOption = value;
			}
		}

		// Token: 0x0400540E RID: 21518
		[Nullable(2)]
		protected new ExecClientBattleAction FbInstance;

		// Token: 0x0400540F RID: 21519
		[Nullable(2)]
		protected ExecClientBattleAction_SetValue PocoInterface;
	}
}
