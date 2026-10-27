using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Quest;

namespace Aki.TDConfigMgr.Quest.Fb
{
	// Token: 0x020013D7 RID: 5079
	public class ITrapDefenseConditionStepSpawnMonster : ITrapDefenseConditionStepBase
	{
		// Token: 0x060073E3 RID: 29667 RVA: 0x00115C88 File Offset: 0x00113E88
		[NullableContext(1)]
		public static ITrapDefenseConditionStepSpawnMonster Create(ITrapDefenseConditionStepSpawnMonster? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ITrapDefenseConditionStepSpawnMonster
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17002608 RID: 9736
		// (get) Token: 0x060073E4 RID: 29668 RVA: 0x00115CA7 File Offset: 0x00113EA7
		public override ETrapDefenseConditionStep Type
		{
			get
			{
				return (ETrapDefenseConditionStep)this.Instance.Type;
			}
		}

		// Token: 0x04004315 RID: 17173
		private ITrapDefenseConditionStepSpawnMonster Instance;
	}
}
