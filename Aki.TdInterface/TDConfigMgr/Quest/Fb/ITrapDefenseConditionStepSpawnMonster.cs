using System;
using Aki.UniverseEditor.Interface.Fbs.Quest;

namespace Aki.TDConfigMgr.Quest.Fb
{
	// Token: 0x0200152E RID: 5422
	public class ITrapDefenseConditionStepSpawnMonster : ITrapDefenseConditionStepBase
	{
		// Token: 0x06007AA4 RID: 31396 RVA: 0x0012466C File Offset: 0x0012286C
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

		// Token: 0x170027EA RID: 10218
		// (get) Token: 0x06007AA5 RID: 31397 RVA: 0x0012468B File Offset: 0x0012288B
		public override ETrapDefenseConditionStep Type
		{
			get
			{
				return (ETrapDefenseConditionStep)this.Instance.Type;
			}
		}

		// Token: 0x040046A6 RID: 18086
		private ITrapDefenseConditionStepSpawnMonster Instance;
	}
}
