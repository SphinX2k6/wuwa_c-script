using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006BAD RID: 27565
	public class INotifyMonsterPerceptionT
	{
		// Token: 0x1700CCE1 RID: 52449
		// (get) Token: 0x060306C1 RID: 198337 RVA: 0x00693892 File Offset: 0x00691A92
		// (set) Token: 0x060306C2 RID: 198338 RVA: 0x0069389A File Offset: 0x00691A9A
		public ESetBattleStateType Type { get; set; }

		// Token: 0x1700CCE2 RID: 52450
		// (get) Token: 0x060306C3 RID: 198339 RVA: 0x006938A3 File Offset: 0x00691AA3
		// (set) Token: 0x060306C4 RID: 198340 RVA: 0x006938AB File Offset: 0x00691AAB
		public List<int> EntityIds { get; set; }

		// Token: 0x1700CCE3 RID: 52451
		// (get) Token: 0x060306C5 RID: 198341 RVA: 0x006938B4 File Offset: 0x00691AB4
		// (set) Token: 0x060306C6 RID: 198342 RVA: 0x006938BC File Offset: 0x00691ABC
		public TBattleStatePerceptionBehaviorUnion PerceptionBehaviorOption { get; set; }

		// Token: 0x060306C7 RID: 198343 RVA: 0x006938C5 File Offset: 0x00691AC5
		public INotifyMonsterPerceptionT()
		{
			this.Type = ESetBattleStateType.SetBattleTag;
			this.EntityIds = null;
			this.PerceptionBehaviorOption = null;
		}
	}
}
