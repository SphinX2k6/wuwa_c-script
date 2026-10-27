using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006A66 RID: 27238
	public class ILoopSeasonChangeT
	{
		// Token: 0x1700CA15 RID: 51733
		// (get) Token: 0x0602FB44 RID: 195396 RVA: 0x0067E05D File Offset: 0x0067C25D
		// (set) Token: 0x0602FB45 RID: 195397 RVA: 0x0067E065 File Offset: 0x0067C265
		public EClientSetSeasonStateType Type { get; set; }

		// Token: 0x1700CA16 RID: 51734
		// (get) Token: 0x0602FB46 RID: 195398 RVA: 0x0067E06E File Offset: 0x0067C26E
		// (set) Token: 0x0602FB47 RID: 195399 RVA: 0x0067E076 File Offset: 0x0067C276
		public bool EnableLoop { get; set; }

		// Token: 0x1700CA17 RID: 51735
		// (get) Token: 0x0602FB48 RID: 195400 RVA: 0x0067E07F File Offset: 0x0067C27F
		// (set) Token: 0x0602FB49 RID: 195401 RVA: 0x0067E087 File Offset: 0x0067C287
		public ISeasonLoopConfigT SpringConfig { get; set; }

		// Token: 0x1700CA18 RID: 51736
		// (get) Token: 0x0602FB4A RID: 195402 RVA: 0x0067E090 File Offset: 0x0067C290
		// (set) Token: 0x0602FB4B RID: 195403 RVA: 0x0067E098 File Offset: 0x0067C298
		public ISeasonLoopConfigT SummerConfig { get; set; }

		// Token: 0x1700CA19 RID: 51737
		// (get) Token: 0x0602FB4C RID: 195404 RVA: 0x0067E0A1 File Offset: 0x0067C2A1
		// (set) Token: 0x0602FB4D RID: 195405 RVA: 0x0067E0A9 File Offset: 0x0067C2A9
		public ISeasonLoopConfigT AutumnConfig { get; set; }

		// Token: 0x1700CA1A RID: 51738
		// (get) Token: 0x0602FB4E RID: 195406 RVA: 0x0067E0B2 File Offset: 0x0067C2B2
		// (set) Token: 0x0602FB4F RID: 195407 RVA: 0x0067E0BA File Offset: 0x0067C2BA
		public ISeasonLoopConfigT WinterConfig { get; set; }

		// Token: 0x0602FB50 RID: 195408 RVA: 0x0067E0C3 File Offset: 0x0067C2C3
		public ILoopSeasonChangeT()
		{
			this.Type = EClientSetSeasonStateType.SwitchSeason;
			this.EnableLoop = false;
			this.SpringConfig = null;
			this.SummerConfig = null;
			this.AutumnConfig = null;
			this.WinterConfig = null;
		}
	}
}
