using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Quest.Fb;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x020011D0 RID: 4560
	[NullableContext(1)]
	[Nullable(0)]
	public class ITrapDefenseConditionStepLoadAndRestoreMap : ITrapDefenseConditionStepBase
	{
		// Token: 0x060067A6 RID: 26534 RVA: 0x000F80D8 File Offset: 0x000F62D8
		private ITrapDefenseConditionStepLoadAndRestoreMap_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ITrapDefenseConditionStepLoadAndRestoreMap 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ITrapDefenseConditionStepLoadAndRestoreMap_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ITrapDefenseConditionStepLoadAndRestoreMap_SetValue());
			}
			return result;
		}

		// Token: 0x060067A7 RID: 26535 RVA: 0x000F8110 File Offset: 0x000F6310
		public static ITrapDefenseConditionStepLoadAndRestoreMap Create([Nullable(2)] ITrapDefenseConditionStepLoadAndRestoreMap instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ITrapDefenseConditionStepLoadAndRestoreMap
			{
				FbInstance = instance
			};
		}

		// Token: 0x060067A8 RID: 26536 RVA: 0x000F8123 File Offset: 0x000F6323
		public static ITrapDefenseConditionStepLoadAndRestoreMap CreateFromSetValue([Nullable(2)] ITrapDefenseConditionStepLoadAndRestoreMap_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ITrapDefenseConditionStepLoadAndRestoreMap
			{
				PocoInterface = value
			};
		}

		// Token: 0x060067A9 RID: 26537 RVA: 0x000F8136 File Offset: 0x000F6336
		public new ITrapDefenseConditionStepLoadAndRestoreMap_SetValue ToSetValue()
		{
			return new ITrapDefenseConditionStepLoadAndRestoreMap_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x170021A0 RID: 8608
		// (get) Token: 0x060067AA RID: 26538 RVA: 0x000F8149 File Offset: 0x000F6349
		// (set) Token: 0x060067AB RID: 26539 RVA: 0x000F8174 File Offset: 0x000F6374
		public override ETrapDefenseConditionStep Type
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

		// Token: 0x04003E31 RID: 15921
		[Nullable(2)]
		protected new ITrapDefenseConditionStepLoadAndRestoreMap FbInstance;

		// Token: 0x04003E32 RID: 15922
		[Nullable(2)]
		protected new ITrapDefenseConditionStepLoadAndRestoreMap_SetValue PocoInterface;
	}
}
