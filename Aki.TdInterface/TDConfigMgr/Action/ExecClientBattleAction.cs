using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200170D RID: 5901
	[NullableContext(1)]
	[Nullable(0)]
	public class ExecClientBattleAction : ActionParams
	{
		// Token: 0x06007D0F RID: 32015 RVA: 0x0012C480 File Offset: 0x0012A680
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

		// Token: 0x06007D10 RID: 32016 RVA: 0x0012C4B8 File Offset: 0x0012A6B8
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

		// Token: 0x06007D11 RID: 32017 RVA: 0x0012C4CB File Offset: 0x0012A6CB
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

		// Token: 0x06007D12 RID: 32018 RVA: 0x0012C4DE File Offset: 0x0012A6DE
		public ExecClientBattleAction_SetValue ToSetValue()
		{
			return new ExecClientBattleAction_SetValue
			{
				ClientBattleOption = this.ClientBattleOption
			};
		}

		// Token: 0x17002943 RID: 10563
		// (get) Token: 0x06007D13 RID: 32019 RVA: 0x0012C4F1 File Offset: 0x0012A6F1
		// (set) Token: 0x06007D14 RID: 32020 RVA: 0x0012C518 File Offset: 0x0012A718
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

		// Token: 0x04004FDF RID: 20447
		[Nullable(2)]
		protected new ExecClientBattleAction FbInstance;

		// Token: 0x04004FE0 RID: 20448
		[Nullable(2)]
		protected ExecClientBattleAction_SetValue PocoInterface;
	}
}
