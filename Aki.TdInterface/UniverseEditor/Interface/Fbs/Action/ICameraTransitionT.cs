using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020062A9 RID: 25257
	public class ICameraTransitionT
	{
		// Token: 0x1700BC87 RID: 48263
		// (get) Token: 0x0602BA41 RID: 178753 RVA: 0x00601D5A File Offset: 0x005FFF5A
		// (set) Token: 0x0602BA42 RID: 178754 RVA: 0x00601D62 File Offset: 0x005FFF62
		public ELevelSequenceTransition Type { get; set; }

		// Token: 0x1700BC88 RID: 48264
		// (get) Token: 0x0602BA43 RID: 178755 RVA: 0x00601D6B File Offset: 0x005FFF6B
		// (set) Token: 0x0602BA44 RID: 178756 RVA: 0x00601D73 File Offset: 0x005FFF73
		public float Duration { get; set; }

		// Token: 0x1700BC89 RID: 48265
		// (get) Token: 0x0602BA45 RID: 178757 RVA: 0x00601D7C File Offset: 0x005FFF7C
		// (set) Token: 0x0602BA46 RID: 178758 RVA: 0x00601D84 File Offset: 0x005FFF84
		public byte NullMask { get; set; }

		// Token: 0x0602BA47 RID: 178759 RVA: 0x00601D8D File Offset: 0x005FFF8D
		public ICameraTransitionT()
		{
			this.Type = ELevelSequenceTransition.Camera;
			this.Duration = 0f;
			this.NullMask = 0;
		}
	}
}
