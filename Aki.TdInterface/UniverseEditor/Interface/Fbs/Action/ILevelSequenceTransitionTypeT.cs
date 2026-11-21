using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020070A1 RID: 28833
	public class ILevelSequenceTransitionTypeT
	{
		// Token: 0x1700D337 RID: 54071
		// (get) Token: 0x060320F5 RID: 205045 RVA: 0x006C6A9A File Offset: 0x006C4C9A
		// (set) Token: 0x060320F6 RID: 205046 RVA: 0x006C6AA2 File Offset: 0x006C4CA2
		public ELevelSequenceTransition Type { get; set; }

		// Token: 0x1700D338 RID: 54072
		// (get) Token: 0x060320F7 RID: 205047 RVA: 0x006C6AAB File Offset: 0x006C4CAB
		// (set) Token: 0x060320F8 RID: 205048 RVA: 0x006C6AB3 File Offset: 0x006C4CB3
		public float Duration { get; set; }

		// Token: 0x1700D339 RID: 54073
		// (get) Token: 0x060320F9 RID: 205049 RVA: 0x006C6ABC File Offset: 0x006C4CBC
		// (set) Token: 0x060320FA RID: 205050 RVA: 0x006C6AC4 File Offset: 0x006C4CC4
		public byte NullMask { get; set; }

		// Token: 0x060320FB RID: 205051 RVA: 0x006C6ACD File Offset: 0x006C4CCD
		public ILevelSequenceTransitionTypeT()
		{
			this.Type = ELevelSequenceTransition.Camera;
			this.Duration = 0f;
			this.NullMask = 0;
		}
	}
}
