using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200603C RID: 24636
	public class ITargetGearGroupFailureConditionT
	{
		// Token: 0x1700B6E3 RID: 46819
		// (get) Token: 0x06029974 RID: 170356 RVA: 0x005ADA82 File Offset: 0x005ABC82
		// (set) Token: 0x06029975 RID: 170357 RVA: 0x005ADA8A File Offset: 0x005ABC8A
		public ETargetGearGroupFailureCondition Type { get; set; }

		// Token: 0x06029976 RID: 170358 RVA: 0x005ADA93 File Offset: 0x005ABC93
		public ITargetGearGroupFailureConditionT()
		{
			this.Type = ETargetGearGroupFailureCondition.ArbitraryState;
		}
	}
}
