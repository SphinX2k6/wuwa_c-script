using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001709 RID: 5897
	[NullableContext(1)]
	[Nullable(0)]
	public class ExecBattleAction : ActionParams
	{
		// Token: 0x06007CFF RID: 31999 RVA: 0x0012C310 File Offset: 0x0012A510
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

		// Token: 0x06007D00 RID: 32000 RVA: 0x0012C348 File Offset: 0x0012A548
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

		// Token: 0x06007D01 RID: 32001 RVA: 0x0012C35B File Offset: 0x0012A55B
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

		// Token: 0x06007D02 RID: 32002 RVA: 0x0012C36E File Offset: 0x0012A56E
		public ExecBattleAction_SetValue ToSetValue()
		{
			return new ExecBattleAction_SetValue
			{
				BattleOption = this.BattleOption
			};
		}

		// Token: 0x17002941 RID: 10561
		// (get) Token: 0x06007D03 RID: 32003 RVA: 0x0012C381 File Offset: 0x0012A581
		// (set) Token: 0x06007D04 RID: 32004 RVA: 0x0012C3A8 File Offset: 0x0012A5A8
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

		// Token: 0x04004FD9 RID: 20441
		[Nullable(2)]
		protected new ExecBattleAction FbInstance;

		// Token: 0x04004FDA RID: 20442
		[Nullable(2)]
		protected ExecBattleAction_SetValue PocoInterface;
	}
}
