using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Quest.Fb;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x020011CE RID: 4558
	[NullableContext(1)]
	[Nullable(0)]
	public class ITrapDefenseConditionStepBase
	{
		// Token: 0x0600679E RID: 26526 RVA: 0x000F801C File Offset: 0x000F621C
		private ITrapDefenseConditionStepBase_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ITrapDefenseConditionStepBase 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ITrapDefenseConditionStepBase_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ITrapDefenseConditionStepBase_SetValue());
			}
			return result;
		}

		// Token: 0x0600679F RID: 26527 RVA: 0x000F8054 File Offset: 0x000F6254
		public static ITrapDefenseConditionStepBase Create([Nullable(2)] ITrapDefenseConditionStepBase instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ITrapDefenseConditionStepBase
			{
				FbInstance = instance
			};
		}

		// Token: 0x060067A0 RID: 26528 RVA: 0x000F8067 File Offset: 0x000F6267
		public static ITrapDefenseConditionStepBase CreateFromSetValue([Nullable(2)] ITrapDefenseConditionStepBase_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ITrapDefenseConditionStepBase
			{
				PocoInterface = value
			};
		}

		// Token: 0x060067A1 RID: 26529 RVA: 0x000F807A File Offset: 0x000F627A
		public ITrapDefenseConditionStepBase_SetValue ToSetValue()
		{
			return new ITrapDefenseConditionStepBase_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x1700219F RID: 8607
		// (get) Token: 0x060067A2 RID: 26530 RVA: 0x000F808D File Offset: 0x000F628D
		// (set) Token: 0x060067A3 RID: 26531 RVA: 0x000F80B8 File Offset: 0x000F62B8
		public virtual ETrapDefenseConditionStep Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ETrapDefenseConditionStep.Reward;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x04003E2E RID: 15918
		[Nullable(2)]
		protected ITrapDefenseConditionStepBase FbInstance;

		// Token: 0x04003E2F RID: 15919
		[Nullable(2)]
		protected ITrapDefenseConditionStepBase_SetValue PocoInterface;
	}
}
