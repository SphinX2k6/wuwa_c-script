using System;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x020045BB RID: 17851
	public class ITrapDefenseSpawnMonsterT
	{
		// Token: 0x17007EE5 RID: 32485
		// (get) Token: 0x0601AFFD RID: 110589 RVA: 0x003D984B File Offset: 0x003D7A4B
		// (set) Token: 0x0601AFFE RID: 110590 RVA: 0x003D9853 File Offset: 0x003D7A53
		public int Id { get; set; }

		// Token: 0x17007EE6 RID: 32486
		// (get) Token: 0x0601AFFF RID: 110591 RVA: 0x003D985C File Offset: 0x003D7A5C
		// (set) Token: 0x0601B000 RID: 110592 RVA: 0x003D9864 File Offset: 0x003D7A64
		public ITrapDefenseSpawnMonsterGroupT MonsterGroup { get; set; }

		// Token: 0x17007EE7 RID: 32487
		// (get) Token: 0x0601B001 RID: 110593 RVA: 0x003D986D File Offset: 0x003D7A6D
		// (set) Token: 0x0601B002 RID: 110594 RVA: 0x003D9875 File Offset: 0x003D7A75
		public ITrapDefenseSpawnMonsterConditionGroupT Condition { get; set; }

		// Token: 0x17007EE8 RID: 32488
		// (get) Token: 0x0601B003 RID: 110595 RVA: 0x003D987E File Offset: 0x003D7A7E
		// (set) Token: 0x0601B004 RID: 110596 RVA: 0x003D9886 File Offset: 0x003D7A86
		public string SplineEntityId { get; set; }

		// Token: 0x17007EE9 RID: 32489
		// (get) Token: 0x0601B005 RID: 110597 RVA: 0x003D988F File Offset: 0x003D7A8F
		// (set) Token: 0x0601B006 RID: 110598 RVA: 0x003D9897 File Offset: 0x003D7A97
		public float DelayTime { get; set; }

		// Token: 0x17007EEA RID: 32490
		// (get) Token: 0x0601B007 RID: 110599 RVA: 0x003D98A0 File Offset: 0x003D7AA0
		// (set) Token: 0x0601B008 RID: 110600 RVA: 0x003D98A8 File Offset: 0x003D7AA8
		public int EndingCountdown { get; set; }

		// Token: 0x17007EEB RID: 32491
		// (get) Token: 0x0601B009 RID: 110601 RVA: 0x003D98B1 File Offset: 0x003D7AB1
		// (set) Token: 0x0601B00A RID: 110602 RVA: 0x003D98B9 File Offset: 0x003D7AB9
		public string Desc { get; set; }

		// Token: 0x0601B00B RID: 110603 RVA: 0x003D98C2 File Offset: 0x003D7AC2
		public ITrapDefenseSpawnMonsterT()
		{
			this.Id = 0;
			this.MonsterGroup = null;
			this.Condition = null;
			this.SplineEntityId = null;
			this.DelayTime = 0f;
			this.EndingCountdown = 0;
			this.Desc = null;
		}
	}
}
