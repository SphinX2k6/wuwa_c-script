using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007101 RID: 28929
	public class ILiveInteractDanmakuTriggerBattleEventT
	{
		// Token: 0x1700D3DD RID: 54237
		// (get) Token: 0x060323ED RID: 205805 RVA: 0x006CB9FE File Offset: 0x006C9BFE
		// (set) Token: 0x060323EE RID: 205806 RVA: 0x006CBA06 File Offset: 0x006C9C06
		public ELiveInteractDanmakuTriggerType Type { get; set; }

		// Token: 0x1700D3DE RID: 54238
		// (get) Token: 0x060323EF RID: 205807 RVA: 0x006CBA0F File Offset: 0x006C9C0F
		// (set) Token: 0x060323F0 RID: 205808 RVA: 0x006CBA17 File Offset: 0x006C9C17
		public int EntityId { get; set; }

		// Token: 0x1700D3DF RID: 54239
		// (get) Token: 0x060323F1 RID: 205809 RVA: 0x006CBA20 File Offset: 0x006C9C20
		// (set) Token: 0x060323F2 RID: 205810 RVA: 0x006CBA28 File Offset: 0x006C9C28
		public int BattleEventId { get; set; }

		// Token: 0x060323F3 RID: 205811 RVA: 0x006CBA31 File Offset: 0x006C9C31
		public ILiveInteractDanmakuTriggerBattleEventT()
		{
			this.Type = ELiveInteractDanmakuTriggerType.SkillGenre;
			this.EntityId = 0;
			this.BattleEventId = 0;
		}
	}
}
