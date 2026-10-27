using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Quest;

namespace Aki.TDConfigMgr.Quest.Fb
{
	// Token: 0x020013D8 RID: 5080
	public class ITrapDefenseConditionStepLoadAndRestoreMap : ITrapDefenseConditionStepBase
	{
		// Token: 0x060073E6 RID: 29670 RVA: 0x00115CBC File Offset: 0x00113EBC
		[NullableContext(1)]
		public static ITrapDefenseConditionStepLoadAndRestoreMap Create(ITrapDefenseConditionStepLoadAndRestoreMap? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ITrapDefenseConditionStepLoadAndRestoreMap
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17002609 RID: 9737
		// (get) Token: 0x060073E7 RID: 29671 RVA: 0x00115CDB File Offset: 0x00113EDB
		public override ETrapDefenseConditionStep Type
		{
			get
			{
				return (ETrapDefenseConditionStep)this.Instance.Type;
			}
		}

		// Token: 0x04004316 RID: 17174
		private ITrapDefenseConditionStepLoadAndRestoreMap Instance;
	}
}
