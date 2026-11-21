using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Aki.UniverseEditor.Interface.Fbs.Condition;

namespace Aki.UniverseEditor.Interface.Fbs.CsvData
{
	// Token: 0x02004DB0 RID: 19888
	public class ILoopTeleportVolumeFunctionT
	{
		// Token: 0x17008E4C RID: 36428
		// (get) Token: 0x0601EDB7 RID: 126391 RVA: 0x0045005F File Offset: 0x0044E25F
		// (set) Token: 0x0601EDB8 RID: 126392 RVA: 0x00450067 File Offset: 0x0044E267
		public int Id { get; set; }

		// Token: 0x17008E4D RID: 36429
		// (get) Token: 0x0601EDB9 RID: 126393 RVA: 0x00450070 File Offset: 0x0044E270
		// (set) Token: 0x0601EDBA RID: 126394 RVA: 0x00450078 File Offset: 0x0044E278
		public string Desc { get; set; }

		// Token: 0x17008E4E RID: 36430
		// (get) Token: 0x0601EDBB RID: 126395 RVA: 0x00450081 File Offset: 0x0044E281
		// (set) Token: 0x0601EDBC RID: 126396 RVA: 0x00450089 File Offset: 0x0044E289
		public int DungeonId { get; set; }

		// Token: 0x17008E4F RID: 36431
		// (get) Token: 0x0601EDBD RID: 126397 RVA: 0x00450092 File Offset: 0x0044E292
		// (set) Token: 0x0601EDBE RID: 126398 RVA: 0x0045009A File Offset: 0x0044E29A
		public int VolumeId { get; set; }

		// Token: 0x17008E50 RID: 36432
		// (get) Token: 0x0601EDBF RID: 126399 RVA: 0x004500A3 File Offset: 0x0044E2A3
		// (set) Token: 0x0601EDC0 RID: 126400 RVA: 0x004500AB File Offset: 0x0044E2AB
		public IConditionGroupT Conditions { get; set; }

		// Token: 0x17008E51 RID: 36433
		// (get) Token: 0x0601EDC1 RID: 126401 RVA: 0x004500B4 File Offset: 0x0044E2B4
		// (set) Token: 0x0601EDC2 RID: 126402 RVA: 0x004500BC File Offset: 0x0044E2BC
		public List<IActionInfoT> Actions { get; set; }

		// Token: 0x17008E52 RID: 36434
		// (get) Token: 0x0601EDC3 RID: 126403 RVA: 0x004500C5 File Offset: 0x0044E2C5
		// (set) Token: 0x0601EDC4 RID: 126404 RVA: 0x004500CD File Offset: 0x0044E2CD
		public List<ILoopTeleportClientPlayEffectLogicT> ClientLogic { get; set; }

		// Token: 0x17008E53 RID: 36435
		// (get) Token: 0x0601EDC5 RID: 126405 RVA: 0x004500D6 File Offset: 0x0044E2D6
		// (set) Token: 0x0601EDC6 RID: 126406 RVA: 0x004500DE File Offset: 0x0044E2DE
		public byte NullMask { get; set; }

		// Token: 0x0601EDC7 RID: 126407 RVA: 0x004500E7 File Offset: 0x0044E2E7
		public ILoopTeleportVolumeFunctionT()
		{
			this.Id = 0;
			this.Desc = null;
			this.DungeonId = 0;
			this.VolumeId = 0;
			this.Conditions = null;
			this.Actions = null;
			this.ClientLogic = null;
			this.NullMask = 0;
		}
	}
}
