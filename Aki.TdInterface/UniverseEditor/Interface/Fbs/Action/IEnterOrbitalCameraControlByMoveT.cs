using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020066C4 RID: 26308
	public class IEnterOrbitalCameraControlByMoveT
	{
		// Token: 0x1700C37A RID: 50042
		// (get) Token: 0x0602DBC2 RID: 187330 RVA: 0x00641BF3 File Offset: 0x0063FDF3
		// (set) Token: 0x0602DBC3 RID: 187331 RVA: 0x00641BFB File Offset: 0x0063FDFB
		public EEnterOrbitalCameraType Type { get; set; }

		// Token: 0x1700C37B RID: 50043
		// (get) Token: 0x0602DBC4 RID: 187332 RVA: 0x00641C04 File Offset: 0x0063FE04
		// (set) Token: 0x0602DBC5 RID: 187333 RVA: 0x00641C0C File Offset: 0x0063FE0C
		public string LevelSequence { get; set; }

		// Token: 0x1700C37C RID: 50044
		// (get) Token: 0x0602DBC6 RID: 187334 RVA: 0x00641C15 File Offset: 0x0063FE15
		// (set) Token: 0x0602DBC7 RID: 187335 RVA: 0x00641C1D File Offset: 0x0063FE1D
		public float BlendInTime { get; set; }

		// Token: 0x1700C37D RID: 50045
		// (get) Token: 0x0602DBC8 RID: 187336 RVA: 0x00641C26 File Offset: 0x0063FE26
		// (set) Token: 0x0602DBC9 RID: 187337 RVA: 0x00641C2E File Offset: 0x0063FE2E
		public float BlendOutTime { get; set; }

		// Token: 0x1700C37E RID: 50046
		// (get) Token: 0x0602DBCA RID: 187338 RVA: 0x00641C37 File Offset: 0x0063FE37
		// (set) Token: 0x0602DBCB RID: 187339 RVA: 0x00641C3F File Offset: 0x0063FE3F
		public int BegEntity { get; set; }

		// Token: 0x1700C37F RID: 50047
		// (get) Token: 0x0602DBCC RID: 187340 RVA: 0x00641C48 File Offset: 0x0063FE48
		// (set) Token: 0x0602DBCD RID: 187341 RVA: 0x00641C50 File Offset: 0x0063FE50
		public int EndEntity { get; set; }

		// Token: 0x0602DBCE RID: 187342 RVA: 0x00641C59 File Offset: 0x0063FE59
		public IEnterOrbitalCameraControlByMoveT()
		{
			this.Type = EEnterOrbitalCameraType.ControlByMove;
			this.LevelSequence = null;
			this.BlendInTime = 0f;
			this.BlendOutTime = 0f;
			this.BegEntity = 0;
			this.EndEntity = 0;
		}
	}
}
