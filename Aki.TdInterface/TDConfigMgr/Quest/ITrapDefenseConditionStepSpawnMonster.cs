using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Quest.Fb;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x020011D8 RID: 4568
	[NullableContext(1)]
	[Nullable(0)]
	public class ITrapDefenseConditionStepSpawnMonster : ITrapDefenseConditionStepBase
	{
		// Token: 0x060067C6 RID: 26566 RVA: 0x000F83C8 File Offset: 0x000F65C8
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

		// Token: 0x060067C7 RID: 26567 RVA: 0x000F8400 File Offset: 0x000F6600
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

		// Token: 0x060067C8 RID: 26568 RVA: 0x000F8413 File Offset: 0x000F6613
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

		// Token: 0x060067C9 RID: 26569 RVA: 0x000F8426 File Offset: 0x000F6626
		public new ITrapDefenseConditionStepSpawnMonster_SetValue ToSetValue()
		{
			return new ITrapDefenseConditionStepSpawnMonster_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x170021A4 RID: 8612
		// (get) Token: 0x060067CA RID: 26570 RVA: 0x000F8439 File Offset: 0x000F6639
		// (set) Token: 0x060067CB RID: 26571 RVA: 0x000F8464 File Offset: 0x000F6664
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

		// Token: 0x04003E3D RID: 15933
		[Nullable(2)]
		protected new ITrapDefenseConditionStepSpawnMonster FbInstance;

		// Token: 0x04003E3E RID: 15934
		[Nullable(2)]
		protected new ITrapDefenseConditionStepSpawnMonster_SetValue PocoInterface;
	}
}
