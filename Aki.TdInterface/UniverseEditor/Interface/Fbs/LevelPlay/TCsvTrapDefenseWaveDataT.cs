using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x020045F7 RID: 17911
	public class TCsvTrapDefenseWaveDataT
	{
		// Token: 0x17007F59 RID: 32601
		// (get) Token: 0x0601B22D RID: 111149 RVA: 0x003DDF97 File Offset: 0x003DC197
		// (set) Token: 0x0601B22E RID: 111150 RVA: 0x003DDF9F File Offset: 0x003DC19F
		public int Id { get; set; }

		// Token: 0x17007F5A RID: 32602
		// (get) Token: 0x0601B22F RID: 111151 RVA: 0x003DDFA8 File Offset: 0x003DC1A8
		// (set) Token: 0x0601B230 RID: 111152 RVA: 0x003DDFB0 File Offset: 0x003DC1B0
		public List<ITrapDefenseSpawnMonsterT> SpawnMonsters { get; set; }

		// Token: 0x0601B231 RID: 111153 RVA: 0x003DDFB9 File Offset: 0x003DC1B9
		public TCsvTrapDefenseWaveDataT()
		{
			this.Id = 0;
			this.SpawnMonsters = null;
		}
	}
}
