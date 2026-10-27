using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020059E7 RID: 23015
	public class ISuccessConditionSameArbitraryStateT
	{
		// Token: 0x1700ACE6 RID: 44262
		// (get) Token: 0x060270BE RID: 159934 RVA: 0x0055F38A File Offset: 0x0055D58A
		// (set) Token: 0x060270BF RID: 159935 RVA: 0x0055F392 File Offset: 0x0055D592
		public ETargetGearGroupSuccessCondition Type { get; set; }

		// Token: 0x060270C0 RID: 159936 RVA: 0x0055F39B File Offset: 0x0055D59B
		public ISuccessConditionSameArbitraryStateT()
		{
			this.Type = ETargetGearGroupSuccessCondition.SameSpecificState;
		}
	}
}
