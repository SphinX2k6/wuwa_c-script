using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Quest;

namespace Aki.TDConfigMgr.Quest.Fb
{
	// Token: 0x020013D5 RID: 5077
	public class ITrapDefenseConditionStepMapChange : ITrapDefenseConditionStepBase
	{
		// Token: 0x060073DD RID: 29661 RVA: 0x00115C20 File Offset: 0x00113E20
		[NullableContext(1)]
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

		// Token: 0x17002606 RID: 9734
		// (get) Token: 0x060073DE RID: 29662 RVA: 0x00115C3F File Offset: 0x00113E3F
		public override ETrapDefenseConditionStep Type
		{
			get
			{
				return (ETrapDefenseConditionStep)this.Instance.Type;
			}
		}

		// Token: 0x04004313 RID: 17171
		private ITrapDefenseConditionStepMapChange Instance;
	}
}
