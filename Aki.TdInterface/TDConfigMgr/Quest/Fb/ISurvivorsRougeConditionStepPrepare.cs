using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Quest;

namespace Aki.TDConfigMgr.Quest.Fb
{
	// Token: 0x020013DF RID: 5087
	public class ISurvivorsRougeConditionStepPrepare : ISurvivorsRougeConditionStepBase
	{
		// Token: 0x06007402 RID: 29698 RVA: 0x00115F62 File Offset: 0x00114162
		[NullableContext(1)]
		public static ISurvivorsRougeConditionStepPrepare Create(ISurvivorsRougeConditionStepPrepare? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ISurvivorsRougeConditionStepPrepare
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17002617 RID: 9751
		// (get) Token: 0x06007403 RID: 29699 RVA: 0x00115F81 File Offset: 0x00114181
		public override ESurvivorsRougeConditionStep Type
		{
			get
			{
				return (ESurvivorsRougeConditionStep)this.Instance.Type;
			}
		}

		// Token: 0x04004327 RID: 17191
		private ISurvivorsRougeConditionStepPrepare Instance;
	}
}
