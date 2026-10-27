using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Quest.Fb;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x0200110A RID: 4362
	[NullableContext(1)]
	[Nullable(0)]
	public class IRoleTowerConditionStepBattle : IRoleTowerConditionStepBase
	{
		// Token: 0x06006292 RID: 25234 RVA: 0x000ED49C File Offset: 0x000EB69C
		private IRoleTowerConditionStepBattle_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IRoleTowerConditionStepBattle 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IRoleTowerConditionStepBattle_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IRoleTowerConditionStepBattle_SetValue());
			}
			return result;
		}

		// Token: 0x06006293 RID: 25235 RVA: 0x000ED4D4 File Offset: 0x000EB6D4
		public static IRoleTowerConditionStepBattle Create([Nullable(2)] IRoleTowerConditionStepBattle instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IRoleTowerConditionStepBattle
			{
				FbInstance = instance
			};
		}

		// Token: 0x06006294 RID: 25236 RVA: 0x000ED4E7 File Offset: 0x000EB6E7
		public static IRoleTowerConditionStepBattle CreateFromSetValue([Nullable(2)] IRoleTowerConditionStepBattle_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IRoleTowerConditionStepBattle
			{
				PocoInterface = value
			};
		}

		// Token: 0x06006295 RID: 25237 RVA: 0x000ED4FA File Offset: 0x000EB6FA
		public new IRoleTowerConditionStepBattle_SetValue ToSetValue()
		{
			return new IRoleTowerConditionStepBattle_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x1700203E RID: 8254
		// (get) Token: 0x06006296 RID: 25238 RVA: 0x000ED50D File Offset: 0x000EB70D
		// (set) Token: 0x06006297 RID: 25239 RVA: 0x000ED538 File Offset: 0x000EB738
		public override ERoleTowerConditionStep Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ERoleTowerConditionStep.Prepare;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x04003B2B RID: 15147
		[Nullable(2)]
		protected new IRoleTowerConditionStepBattle FbInstance;

		// Token: 0x04003B2C RID: 15148
		[Nullable(2)]
		protected new IRoleTowerConditionStepBattle_SetValue PocoInterface;
	}
}
