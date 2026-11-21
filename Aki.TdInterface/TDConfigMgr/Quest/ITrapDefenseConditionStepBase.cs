using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Quest.Fb;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x0200130A RID: 4874
	public class ITrapDefenseConditionStepBase
	{
		// Token: 0x06006DDF RID: 28127 RVA: 0x00105928 File Offset: 0x00103B28
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

		// Token: 0x06006DE0 RID: 28128 RVA: 0x00105960 File Offset: 0x00103B60
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

		// Token: 0x06006DE1 RID: 28129 RVA: 0x00105973 File Offset: 0x00103B73
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

		// Token: 0x06006DE2 RID: 28130 RVA: 0x00105986 File Offset: 0x00103B86
		public ITrapDefenseConditionStepBase_SetValue ToSetValue()
		{
			return new ITrapDefenseConditionStepBase_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17002360 RID: 9056
		// (get) Token: 0x06006DE3 RID: 28131 RVA: 0x00105999 File Offset: 0x00103B99
		// (set) Token: 0x06006DE4 RID: 28132 RVA: 0x001059C4 File Offset: 0x00103BC4
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

		// Token: 0x0400419C RID: 16796
		[Nullable(2)]
		protected ITrapDefenseConditionStepBase FbInstance;

		// Token: 0x0400419D RID: 16797
		[Nullable(2)]
		protected ITrapDefenseConditionStepBase_SetValue PocoInterface;
	}
}
