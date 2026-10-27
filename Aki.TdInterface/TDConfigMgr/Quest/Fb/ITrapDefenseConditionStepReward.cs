using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Quest;

namespace Aki.TDConfigMgr.Quest.Fb
{
	// Token: 0x020013D4 RID: 5076
	public class ITrapDefenseConditionStepReward : ITrapDefenseConditionStepBase
	{
		// Token: 0x060073DA RID: 29658 RVA: 0x00115BEC File Offset: 0x00113DEC
		[NullableContext(1)]
		public static ITrapDefenseConditionStepReward Create(ITrapDefenseConditionStepReward? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ITrapDefenseConditionStepReward
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17002605 RID: 9733
		// (get) Token: 0x060073DB RID: 29659 RVA: 0x00115C0B File Offset: 0x00113E0B
		public override ETrapDefenseConditionStep Type
		{
			get
			{
				return (ETrapDefenseConditionStep)this.Instance.Type;
			}
		}

		// Token: 0x04004312 RID: 17170
		private ITrapDefenseConditionStepReward Instance;
	}
}
