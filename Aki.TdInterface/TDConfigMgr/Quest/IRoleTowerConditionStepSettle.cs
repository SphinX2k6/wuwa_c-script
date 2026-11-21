using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Quest.Fb;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x0200123E RID: 4670
	public class IRoleTowerConditionStepSettle : IRoleTowerConditionStepBase
	{
		// Token: 0x060068A5 RID: 26789 RVA: 0x000FA844 File Offset: 0x000F8A44
		private IRoleTowerConditionStepSettle_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IRoleTowerConditionStepSettle 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IRoleTowerConditionStepSettle_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IRoleTowerConditionStepSettle_SetValue());
			}
			return result;
		}

		// Token: 0x060068A6 RID: 26790 RVA: 0x000FA87C File Offset: 0x000F8A7C
		public static IRoleTowerConditionStepSettle Create([Nullable(2)] IRoleTowerConditionStepSettle instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IRoleTowerConditionStepSettle
			{
				FbInstance = instance
			};
		}

		// Token: 0x060068A7 RID: 26791 RVA: 0x000FA88F File Offset: 0x000F8A8F
		public static IRoleTowerConditionStepSettle CreateFromSetValue([Nullable(2)] IRoleTowerConditionStepSettle_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IRoleTowerConditionStepSettle
			{
				PocoInterface = value
			};
		}

		// Token: 0x060068A8 RID: 26792 RVA: 0x000FA8A2 File Offset: 0x000F8AA2
		public new IRoleTowerConditionStepSettle_SetValue ToSetValue()
		{
			return new IRoleTowerConditionStepSettle_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x170021F4 RID: 8692
		// (get) Token: 0x060068A9 RID: 26793 RVA: 0x000FA8B5 File Offset: 0x000F8AB5
		// (set) Token: 0x060068AA RID: 26794 RVA: 0x000FA8E0 File Offset: 0x000F8AE0
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

		// Token: 0x04003E82 RID: 16002
		[Nullable(2)]
		protected new IRoleTowerConditionStepSettle FbInstance;

		// Token: 0x04003E83 RID: 16003
		[Nullable(2)]
		protected new IRoleTowerConditionStepSettle_SetValue PocoInterface;
	}
}
