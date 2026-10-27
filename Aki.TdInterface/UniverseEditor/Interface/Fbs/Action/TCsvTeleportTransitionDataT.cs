using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200769C RID: 30364
	public class TCsvTeleportTransitionDataT
	{
		// Token: 0x1700E601 RID: 58881
		// (get) Token: 0x0603740C RID: 226316 RVA: 0x0077CFCF File Offset: 0x0077B1CF
		// (set) Token: 0x0603740D RID: 226317 RVA: 0x0077CFD7 File Offset: 0x0077B1D7
		public int Id { get; set; }

		// Token: 0x1700E602 RID: 58882
		// (get) Token: 0x0603740E RID: 226318 RVA: 0x0077CFE0 File Offset: 0x0077B1E0
		// (set) Token: 0x0603740F RID: 226319 RVA: 0x0077CFE8 File Offset: 0x0077B1E8
		public ITeleportTransitionType_UnionUnion Data { get; set; }

		// Token: 0x06037410 RID: 226320 RVA: 0x0077CFF1 File Offset: 0x0077B1F1
		public TCsvTeleportTransitionDataT()
		{
			this.Id = 0;
			this.Data = null;
		}
	}
}
