using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020072F9 RID: 29433
	public class INotifyMonsterPerceptionT
	{
		// Token: 0x1700D7CD RID: 55245
		// (get) Token: 0x0603353B RID: 210235 RVA: 0x006EC232 File Offset: 0x006EA432
		// (set) Token: 0x0603353C RID: 210236 RVA: 0x006EC23A File Offset: 0x006EA43A
		public ESetBattleStateType Type { get; set; }

		// Token: 0x1700D7CE RID: 55246
		// (get) Token: 0x0603353D RID: 210237 RVA: 0x006EC243 File Offset: 0x006EA443
		// (set) Token: 0x0603353E RID: 210238 RVA: 0x006EC24B File Offset: 0x006EA44B
		public List<int> EntityIds { get; set; }

		// Token: 0x1700D7CF RID: 55247
		// (get) Token: 0x0603353F RID: 210239 RVA: 0x006EC254 File Offset: 0x006EA454
		// (set) Token: 0x06033540 RID: 210240 RVA: 0x006EC25C File Offset: 0x006EA45C
		public TBattleStatePerceptionBehaviorUnion PerceptionBehaviorOption { get; set; }

		// Token: 0x06033541 RID: 210241 RVA: 0x006EC265 File Offset: 0x006EA465
		public INotifyMonsterPerceptionT()
		{
			this.Type = ESetBattleStateType.SetBattleTag;
			this.EntityIds = null;
			this.PerceptionBehaviorOption = null;
		}
	}
}
