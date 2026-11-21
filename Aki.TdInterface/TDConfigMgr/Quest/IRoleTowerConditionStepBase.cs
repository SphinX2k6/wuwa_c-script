using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Quest.Fb;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x02001236 RID: 4662
	public class IRoleTowerConditionStepBase
	{
		// Token: 0x06006885 RID: 26757 RVA: 0x000FA554 File Offset: 0x000F8754
		private IRoleTowerConditionStepBase_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IRoleTowerConditionStepBase 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IRoleTowerConditionStepBase_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IRoleTowerConditionStepBase_SetValue());
			}
			return result;
		}

		// Token: 0x06006886 RID: 26758 RVA: 0x000FA58C File Offset: 0x000F878C
		public static IRoleTowerConditionStepBase Create([Nullable(2)] IRoleTowerConditionStepBase instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IRoleTowerConditionStepBase
			{
				FbInstance = instance
			};
		}

		// Token: 0x06006887 RID: 26759 RVA: 0x000FA59F File Offset: 0x000F879F
		public static IRoleTowerConditionStepBase CreateFromSetValue([Nullable(2)] IRoleTowerConditionStepBase_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IRoleTowerConditionStepBase
			{
				PocoInterface = value
			};
		}

		// Token: 0x06006888 RID: 26760 RVA: 0x000FA5B2 File Offset: 0x000F87B2
		public IRoleTowerConditionStepBase_SetValue ToSetValue()
		{
			return new IRoleTowerConditionStepBase_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x170021F0 RID: 8688
		// (get) Token: 0x06006889 RID: 26761 RVA: 0x000FA5C5 File Offset: 0x000F87C5
		// (set) Token: 0x0600688A RID: 26762 RVA: 0x000FA5F0 File Offset: 0x000F87F0
		public virtual ERoleTowerConditionStep Type
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

		// Token: 0x04003E76 RID: 15990
		[Nullable(2)]
		protected IRoleTowerConditionStepBase FbInstance;

		// Token: 0x04003E77 RID: 15991
		[Nullable(2)]
		protected IRoleTowerConditionStepBase_SetValue PocoInterface;
	}
}
