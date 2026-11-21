using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020070B6 RID: 28854
	public class ILiftMoveTypeCustomSpeedT
	{
		// Token: 0x1700D361 RID: 54113
		// (get) Token: 0x060321AF RID: 205231 RVA: 0x006C7FE1 File Offset: 0x006C61E1
		// (set) Token: 0x060321B0 RID: 205232 RVA: 0x006C7FE9 File Offset: 0x006C61E9
		public ELiftMoveType Type { get; set; }

		// Token: 0x1700D362 RID: 54114
		// (get) Token: 0x060321B1 RID: 205233 RVA: 0x006C7FF2 File Offset: 0x006C61F2
		// (set) Token: 0x060321B2 RID: 205234 RVA: 0x006C7FFA File Offset: 0x006C61FA
		public float TotalTime { get; set; }

		// Token: 0x1700D363 RID: 54115
		// (get) Token: 0x060321B3 RID: 205235 RVA: 0x006C8003 File Offset: 0x006C6203
		// (set) Token: 0x060321B4 RID: 205236 RVA: 0x006C800B File Offset: 0x006C620B
		public string TimePathCurve { get; set; }

		// Token: 0x060321B5 RID: 205237 RVA: 0x006C8014 File Offset: 0x006C6214
		public ILiftMoveTypeCustomSpeedT()
		{
			this.Type = ELiftMoveType.Default;
			this.TotalTime = 0f;
			this.TimePathCurve = null;
		}
	}
}
