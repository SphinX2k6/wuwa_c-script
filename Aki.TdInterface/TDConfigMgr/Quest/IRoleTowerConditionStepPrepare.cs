using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Quest.Fb;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x0200110E RID: 4366
	[NullableContext(1)]
	[Nullable(0)]
	public class IRoleTowerConditionStepPrepare : IRoleTowerConditionStepBase
	{
		// Token: 0x060062A2 RID: 25250 RVA: 0x000ED614 File Offset: 0x000EB814
		private IRoleTowerConditionStepPrepare_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IRoleTowerConditionStepPrepare 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IRoleTowerConditionStepPrepare_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IRoleTowerConditionStepPrepare_SetValue());
			}
			return result;
		}

		// Token: 0x060062A3 RID: 25251 RVA: 0x000ED64C File Offset: 0x000EB84C
		public static IRoleTowerConditionStepPrepare Create([Nullable(2)] IRoleTowerConditionStepPrepare instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IRoleTowerConditionStepPrepare
			{
				FbInstance = instance
			};
		}

		// Token: 0x060062A4 RID: 25252 RVA: 0x000ED65F File Offset: 0x000EB85F
		public static IRoleTowerConditionStepPrepare CreateFromSetValue([Nullable(2)] IRoleTowerConditionStepPrepare_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IRoleTowerConditionStepPrepare
			{
				PocoInterface = value
			};
		}

		// Token: 0x060062A5 RID: 25253 RVA: 0x000ED672 File Offset: 0x000EB872
		public new IRoleTowerConditionStepPrepare_SetValue ToSetValue()
		{
			return new IRoleTowerConditionStepPrepare_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17002040 RID: 8256
		// (get) Token: 0x060062A6 RID: 25254 RVA: 0x000ED685 File Offset: 0x000EB885
		// (set) Token: 0x060062A7 RID: 25255 RVA: 0x000ED6B0 File Offset: 0x000EB8B0
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

		// Token: 0x04003B31 RID: 15153
		[Nullable(2)]
		protected new IRoleTowerConditionStepPrepare FbInstance;

		// Token: 0x04003B32 RID: 15154
		[Nullable(2)]
		protected new IRoleTowerConditionStepPrepare_SetValue PocoInterface;
	}
}
