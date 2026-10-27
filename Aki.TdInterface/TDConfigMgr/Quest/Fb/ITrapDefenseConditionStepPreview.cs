using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Quest;

namespace Aki.TDConfigMgr.Quest.Fb
{
	// Token: 0x020013D6 RID: 5078
	public class ITrapDefenseConditionStepPreview : ITrapDefenseConditionStepBase
	{
		// Token: 0x060073E0 RID: 29664 RVA: 0x00115C54 File Offset: 0x00113E54
		[NullableContext(1)]
		public static ITrapDefenseConditionStepPreview Create(ITrapDefenseConditionStepPreview? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ITrapDefenseConditionStepPreview
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17002607 RID: 9735
		// (get) Token: 0x060073E1 RID: 29665 RVA: 0x00115C73 File Offset: 0x00113E73
		public override ETrapDefenseConditionStep Type
		{
			get
			{
				return (ETrapDefenseConditionStep)this.Instance.Type;
			}
		}

		// Token: 0x04004314 RID: 17172
		private ITrapDefenseConditionStepPreview Instance;
	}
}
