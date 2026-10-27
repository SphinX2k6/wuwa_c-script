using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x0200420C RID: 16908
	public class ITrackReturnDungeonT
	{
		// Token: 0x1700781B RID: 30747
		// (get) Token: 0x06018FBD RID: 102333 RVA: 0x00398A1D File Offset: 0x00396C1D
		// (set) Token: 0x06018FBE RID: 102334 RVA: 0x00398A25 File Offset: 0x00396C25
		public int DungeonId { get; set; }

		// Token: 0x1700781C RID: 30748
		// (get) Token: 0x06018FBF RID: 102335 RVA: 0x00398A2E File Offset: 0x00396C2E
		// (set) Token: 0x06018FC0 RID: 102336 RVA: 0x00398A36 File Offset: 0x00396C36
		public bool IsRegroup { get; set; }

		// Token: 0x1700781D RID: 30749
		// (get) Token: 0x06018FC1 RID: 102337 RVA: 0x00398A3F File Offset: 0x00396C3F
		// (set) Token: 0x06018FC2 RID: 102338 RVA: 0x00398A47 File Offset: 0x00396C47
		public TTeleportTransitionOptionUnion TransitionOption { get; set; }

		// Token: 0x1700781E RID: 30750
		// (get) Token: 0x06018FC3 RID: 102339 RVA: 0x00398A50 File Offset: 0x00396C50
		// (set) Token: 0x06018FC4 RID: 102340 RVA: 0x00398A58 File Offset: 0x00396C58
		public string TidTip { get; set; }

		// Token: 0x1700781F RID: 30751
		// (get) Token: 0x06018FC5 RID: 102341 RVA: 0x00398A61 File Offset: 0x00396C61
		// (set) Token: 0x06018FC6 RID: 102342 RVA: 0x00398A69 File Offset: 0x00396C69
		public byte NullMask { get; set; }

		// Token: 0x06018FC7 RID: 102343 RVA: 0x00398A72 File Offset: 0x00396C72
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
