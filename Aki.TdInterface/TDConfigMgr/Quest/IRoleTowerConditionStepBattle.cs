using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Quest.Fb;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x02001238 RID: 4664
	public class IRoleTowerConditionStepBattle : IRoleTowerConditionStepBase
	{
		// Token: 0x0600688D RID: 26765 RVA: 0x000FA610 File Offset: 0x000F8810
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

		// Token: 0x0600688E RID: 26766 RVA: 0x000FA648 File Offset: 0x000F8848
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

		// Token: 0x0600688F RID: 26767 RVA: 0x000FA65B File Offset: 0x000F885B
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

		// Token: 0x06006890 RID: 26768 RVA: 0x000FA66E File Offset: 0x000F886E
		public new IRoleTowerConditionStepBattle_SetValue ToSetValue()
		{
			return new IRoleTowerConditionStepBattle_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x170021F1 RID: 8689
		// (get) Token: 0x06006891 RID: 26769 RVA: 0x000FA681 File Offset: 0x000F8881
		// (set) Token: 0x06006892 RID: 26770 RVA: 0x000FA6AC File Offset: 0x000F88AC
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

		// Token: 0x04003E79 RID: 15993
		[Nullable(2)]
		protected new IRoleTowerConditionStepBattle FbInstance;

		// Token: 0x04003E7A RID: 15994
		[Nullable(2)]
		protected new IRoleTowerConditionStepBattle_SetValue PocoInterface;
	}
}
