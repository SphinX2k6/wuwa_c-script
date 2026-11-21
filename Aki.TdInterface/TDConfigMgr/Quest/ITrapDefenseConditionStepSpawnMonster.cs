using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Quest.Fb;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x02001314 RID: 4884
	public class ITrapDefenseConditionStepSpawnMonster : ITrapDefenseConditionStepBase
	{
		// Token: 0x06006E07 RID: 28167 RVA: 0x00105CD4 File Offset: 0x00103ED4
		private ITrapDefenseConditionStepSpawnMonster_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ITrapDefenseConditionStepSpawnMonster 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ITrapDefenseConditionStepSpawnMonster_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ITrapDefenseConditionStepSpawnMonster_SetValue());
			}
			return result;
		}

		// Token: 0x06006E08 RID: 28168 RVA: 0x00105D0C File Offset: 0x00103F0C
		public static ITrapDefenseConditionStepSpawnMonster Create([Nullable(2)] ITrapDefenseConditionStepSpawnMonster instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ITrapDefenseConditionStepSpawnMonster
			{
				FbInstance = instance
			};
		}

		// Token: 0x06006E09 RID: 28169 RVA: 0x00105D1F File Offset: 0x00103F1F
		public static ITrapDefenseConditionStepSpawnMonster CreateFromSetValue([Nullable(2)] ITrapDefenseConditionStepSpawnMonster_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ITrapDefenseConditionStepSpawnMonster
			{
				PocoInterface = value
			};
		}

		// Token: 0x06006E0A RID: 28170 RVA: 0x00105D32 File Offset: 0x00103F32
		public new ITrapDefenseConditionStepSpawnMonster_SetValue ToSetValue()
		{
			return new ITrapDefenseConditionStepSpawnMonster_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17002365 RID: 9061
		// (get) Token: 0x06006E0B RID: 28171 RVA: 0x00105D45 File Offset: 0x00103F45
		// (set) Token: 0x06006E0C RID: 28172 RVA: 0x00105D70 File Offset: 0x00103F70
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

		// Token: 0x040041AB RID: 16811
		[Nullable(2)]
		protected new ITrapDefenseConditionStepSpawnMonster FbInstance;

		// Token: 0x040041AC RID: 16812
		[Nullable(2)]
		protected new ITrapDefenseConditionStepSpawnMonster_SetValue PocoInterface;
	}
}
