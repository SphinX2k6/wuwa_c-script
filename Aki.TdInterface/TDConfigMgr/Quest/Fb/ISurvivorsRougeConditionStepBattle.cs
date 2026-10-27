using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Quest;

namespace Aki.TDConfigMgr.Quest.Fb
{
	// Token: 0x020013E0 RID: 5088
	public class ISurvivorsRougeConditionStepBattle : ISurvivorsRougeConditionStepBase
	{
		// Token: 0x06007405 RID: 29701 RVA: 0x00115F96 File Offset: 0x00114196
		[NullableContext(1)]
		public static ISurvivorsRougeConditionStepBattle Create(ISurvivorsRougeConditionStepBattle? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ISurvivorsRougeConditionStepBattle
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17002618 RID: 9752
		// (get) Token: 0x06007406 RID: 29702 RVA: 0x00115FB5 File Offset: 0x001141B5
		public override ESurvivorsRougeConditionStep Type
		{
			get
			{
				return (ESurvivorsRougeConditionStep)this.Instance.Type;
			}
		}

		// Token: 0x04004328 RID: 17192
		private ISurvivorsRougeConditionStepBattle Instance;
	}
}
