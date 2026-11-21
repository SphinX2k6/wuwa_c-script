using System;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x02004A23 RID: 18979
	public class ITrapDefenseSpawnMonsterT
	{
		// Token: 0x17008526 RID: 34086
		// (get) Token: 0x0601C7D2 RID: 116690 RVA: 0x00405AE7 File Offset: 0x00403CE7
		// (set) Token: 0x0601C7D3 RID: 116691 RVA: 0x00405AEF File Offset: 0x00403CEF
		public int Id { get; set; }

		// Token: 0x17008527 RID: 34087
		// (get) Token: 0x0601C7D4 RID: 116692 RVA: 0x00405AF8 File Offset: 0x00403CF8
		// (set) Token: 0x0601C7D5 RID: 116693 RVA: 0x00405B00 File Offset: 0x00403D00
		public ITrapDefenseSpawnMonsterGroupT MonsterGroup { get; set; }

		// Token: 0x17008528 RID: 34088
		// (get) Token: 0x0601C7D6 RID: 116694 RVA: 0x00405B09 File Offset: 0x00403D09
		// (set) Token: 0x0601C7D7 RID: 116695 RVA: 0x00405B11 File Offset: 0x00403D11
		public ITrapDefenseSpawnMonsterConditionGroupT Condition { get; set; }

		// Token: 0x17008529 RID: 34089
		// (get) Token: 0x0601C7D8 RID: 116696 RVA: 0x00405B1A File Offset: 0x00403D1A
		// (set) Token: 0x0601C7D9 RID: 116697 RVA: 0x00405B22 File Offset: 0x00403D22
		public string SplineEntityId { get; set; }

		// Token: 0x1700852A RID: 34090
		// (get) Token: 0x0601C7DA RID: 116698 RVA: 0x00405B2B File Offset: 0x00403D2B
		// (set) Token: 0x0601C7DB RID: 116699 RVA: 0x00405B33 File Offset: 0x00403D33
		public float DelayTime { get; set; }

		// Token: 0x1700852B RID: 34091
		// (get) Token: 0x0601C7DC RID: 116700 RVA: 0x00405B3C File Offset: 0x00403D3C
		// (set) Token: 0x0601C7DD RID: 116701 RVA: 0x00405B44 File Offset: 0x00403D44
		public int EndingCountdown { get; set; }

		// Token: 0x1700852C RID: 34092
		// (get) Token: 0x0601C7DE RID: 116702 RVA: 0x00405B4D File Offset: 0x00403D4D
		// (set) Token: 0x0601C7DF RID: 116703 RVA: 0x00405B55 File Offset: 0x00403D55
		public string Desc { get; set; }

		// Token: 0x0601C7E0 RID: 116704 RVA: 0x00405B5E File Offset: 0x00403D5E
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
