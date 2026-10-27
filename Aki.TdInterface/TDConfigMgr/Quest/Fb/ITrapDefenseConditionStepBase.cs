using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Quest;

namespace Aki.TDConfigMgr.Quest.Fb
{
	// Token: 0x020013D3 RID: 5075
	public class ITrapDefenseConditionStepBase
	{
		// Token: 0x060073D7 RID: 29655 RVA: 0x00115BB8 File Offset: 0x00113DB8
		[NullableContext(1)]
		public static ITrapDefenseConditionStepBase Create(ITrapDefenseConditionStepBase? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ITrapDefenseConditionStepBase
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17002604 RID: 9732
		// (get) Token: 0x060073D8 RID: 29656 RVA: 0x00115BD7 File Offset: 0x00113DD7
		public virtual ETrapDefenseConditionStep Type
		{
			get
			{
				return (ETrapDefenseConditionStep)this.Instance.Type;
			}
		}

		// Token: 0x04004311 RID: 17169
		private ITrapDefenseConditionStepBase Instance;
	}
}
