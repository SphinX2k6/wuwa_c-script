using System;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x0200504D RID: 20557
	public class ICheckTreasureBeenClaimedConditionT
	{
		// Token: 0x17009323 RID: 37667
		// (get) Token: 0x06020223 RID: 131619 RVA: 0x00475010 File Offset: 0x00473210
		// (set) Token: 0x06020224 RID: 131620 RVA: 0x00475018 File Offset: 0x00473218
		public ECondition Type { get; set; }

		// Token: 0x17009324 RID: 37668
		// (get) Token: 0x06020225 RID: 131621 RVA: 0x00475021 File Offset: 0x00473221
		// (set) Token: 0x06020226 RID: 131622 RVA: 0x00475029 File Offset: 0x00473229
		public int EntityId { get; set; }

		// Token: 0x06020227 RID: 131623 RVA: 0x00475032 File Offset: 0x00473232
		public ICheckTreasureBeenClaimedConditionT()
		{
			this.Type = ECondition.CompareVar;
			this.EntityId = 0;
		}
	}
}
