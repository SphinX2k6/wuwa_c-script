using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Quest.Fb;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x02001110 RID: 4368
	[NullableContext(1)]
	[Nullable(0)]
	public class IRoleTowerConditionStepSettle : IRoleTowerConditionStepBase
	{
		// Token: 0x060062AA RID: 25258 RVA: 0x000ED6D0 File Offset: 0x000EB8D0
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

		// Token: 0x060062AB RID: 25259 RVA: 0x000ED708 File Offset: 0x000EB908
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

		// Token: 0x060062AC RID: 25260 RVA: 0x000ED71B File Offset: 0x000EB91B
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

		// Token: 0x060062AD RID: 25261 RVA: 0x000ED72E File Offset: 0x000EB92E
		public new IRoleTowerConditionStepSettle_SetValue ToSetValue()
		{
			return new IRoleTowerConditionStepSettle_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17002041 RID: 8257
		// (get) Token: 0x060062AE RID: 25262 RVA: 0x000ED741 File Offset: 0x000EB941
		// (set) Token: 0x060062AF RID: 25263 RVA: 0x000ED76C File Offset: 0x000EB96C
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

		// Token: 0x04003B34 RID: 15156
		[Nullable(2)]
		protected new IRoleTowerConditionStepSettle FbInstance;

		// Token: 0x04003B35 RID: 15157
		[Nullable(2)]
		protected new IRoleTowerConditionStepSettle_SetValue PocoInterface;
	}
}
