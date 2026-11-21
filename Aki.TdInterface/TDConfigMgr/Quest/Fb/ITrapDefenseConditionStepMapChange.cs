using System;
using Aki.UniverseEditor.Interface.Fbs.Quest;

namespace Aki.TDConfigMgr.Quest.Fb
{
	// Token: 0x0200152C RID: 5420
	public class ITrapDefenseConditionStepMapChange : ITrapDefenseConditionStepBase
	{
		// Token: 0x06007A9E RID: 31390 RVA: 0x00124604 File Offset: 0x00122804
		public static ITrapDefenseConditionStepMapChange Create(ITrapDefenseConditionStepMapChange? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ITrapDefenseConditionStepMapChange
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170027E8 RID: 10216
		// (get) Token: 0x06007A9F RID: 31391 RVA: 0x00124623 File Offset: 0x00122823
		public override ETrapDefenseConditionStep Type
		{
			get
			{
				return (ETrapDefenseConditionStep)this.Instance.Type;
			}
		}

		// Token: 0x040046A4 RID: 18084
		private ITrapDefenseConditionStepMapChange Instance;
	}
}
