using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004668 RID: 18024
	public class ITrackReturnDungeonT
	{
		// Token: 0x17007E4C RID: 32332
		// (get) Token: 0x0601A729 RID: 108329 RVA: 0x003C40F5 File Offset: 0x003C22F5
		// (set) Token: 0x0601A72A RID: 108330 RVA: 0x003C40FD File Offset: 0x003C22FD
		public int DungeonId { get; set; }

		// Token: 0x17007E4D RID: 32333
		// (get) Token: 0x0601A72B RID: 108331 RVA: 0x003C4106 File Offset: 0x003C2306
		// (set) Token: 0x0601A72C RID: 108332 RVA: 0x003C410E File Offset: 0x003C230E
		public bool IsRegroup { get; set; }

		// Token: 0x17007E4E RID: 32334
		// (get) Token: 0x0601A72D RID: 108333 RVA: 0x003C4117 File Offset: 0x003C2317
		// (set) Token: 0x0601A72E RID: 108334 RVA: 0x003C411F File Offset: 0x003C231F
		public TTeleportTransitionOptionUnion TransitionOption { get; set; }

		// Token: 0x17007E4F RID: 32335
		// (get) Token: 0x0601A72F RID: 108335 RVA: 0x003C4128 File Offset: 0x003C2328
		// (set) Token: 0x0601A730 RID: 108336 RVA: 0x003C4130 File Offset: 0x003C2330
		public string TidTip { get; set; }

		// Token: 0x17007E50 RID: 32336
		// (get) Token: 0x0601A731 RID: 108337 RVA: 0x003C4139 File Offset: 0x003C2339
		// (set) Token: 0x0601A732 RID: 108338 RVA: 0x003C4141 File Offset: 0x003C2341
		public byte NullMask { get; set; }

		// Token: 0x0601A733 RID: 108339 RVA: 0x003C414A File Offset: 0x003C234A
		public ITrackReturnDungeonT()
		{
			this.DungeonId = 0;
			this.IsRegroup = false;
			this.TransitionOption = null;
			this.TidTip = null;
			this.NullMask = 0;
		}
	}
}
