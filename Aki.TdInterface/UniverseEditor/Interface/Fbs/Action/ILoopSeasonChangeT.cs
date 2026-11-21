using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007188 RID: 29064
	public class ILoopSeasonChangeT
	{
		// Token: 0x1700D4C0 RID: 54464
		// (get) Token: 0x0603286A RID: 206954 RVA: 0x006D411D File Offset: 0x006D231D
		// (set) Token: 0x0603286B RID: 206955 RVA: 0x006D4125 File Offset: 0x006D2325
		public EClientSetSeasonStateType Type { get; set; }

		// Token: 0x1700D4C1 RID: 54465
		// (get) Token: 0x0603286C RID: 206956 RVA: 0x006D412E File Offset: 0x006D232E
		// (set) Token: 0x0603286D RID: 206957 RVA: 0x006D4136 File Offset: 0x006D2336
		public bool EnableLoop { get; set; }

		// Token: 0x1700D4C2 RID: 54466
		// (get) Token: 0x0603286E RID: 206958 RVA: 0x006D413F File Offset: 0x006D233F
		// (set) Token: 0x0603286F RID: 206959 RVA: 0x006D4147 File Offset: 0x006D2347
		public ISeasonLoopConfigT SpringConfig { get; set; }

		// Token: 0x1700D4C3 RID: 54467
		// (get) Token: 0x06032870 RID: 206960 RVA: 0x006D4150 File Offset: 0x006D2350
		// (set) Token: 0x06032871 RID: 206961 RVA: 0x006D4158 File Offset: 0x006D2358
		public ISeasonLoopConfigT SummerConfig { get; set; }

		// Token: 0x1700D4C4 RID: 54468
		// (get) Token: 0x06032872 RID: 206962 RVA: 0x006D4161 File Offset: 0x006D2361
		// (set) Token: 0x06032873 RID: 206963 RVA: 0x006D4169 File Offset: 0x006D2369
		public ISeasonLoopConfigT AutumnConfig { get; set; }

		// Token: 0x1700D4C5 RID: 54469
		// (get) Token: 0x06032874 RID: 206964 RVA: 0x006D4172 File Offset: 0x006D2372
		// (set) Token: 0x06032875 RID: 206965 RVA: 0x006D417A File Offset: 0x006D237A
		public ISeasonLoopConfigT WinterConfig { get; set; }

		// Token: 0x06032876 RID: 206966 RVA: 0x006D4183 File Offset: 0x006D2383
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
