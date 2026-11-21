using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007365 RID: 29541
	public class IOpenGlobalTimeScaleT
	{
		// Token: 0x1700D8AA RID: 55466
		// (get) Token: 0x060338DE RID: 211166 RVA: 0x006F2CFA File Offset: 0x006F0EFA
		// (set) Token: 0x060338DF RID: 211167 RVA: 0x006F2D02 File Offset: 0x006F0F02
		public ESetTimeScaleType Type { get; set; }

		// Token: 0x1700D8AB RID: 55467
		// (get) Token: 0x060338E0 RID: 211168 RVA: 0x006F2D0B File Offset: 0x006F0F0B
		// (set) Token: 0x060338E1 RID: 211169 RVA: 0x006F2D13 File Offset: 0x006F0F13
		public float TimeScale { get; set; }

		// Token: 0x1700D8AC RID: 55468
		// (get) Token: 0x060338E2 RID: 211170 RVA: 0x006F2D1C File Offset: 0x006F0F1C
		// (set) Token: 0x060338E3 RID: 211171 RVA: 0x006F2D24 File Offset: 0x006F0F24
		public float Duration { get; set; }

		// Token: 0x060338E4 RID: 211172 RVA: 0x006F2D2D File Offset: 0x006F0F2D
		public IOpenGlobalTimeScaleT()
		{
			this.Type = ESetTimeScaleType.Open;
			this.TimeScale = 0f;
			this.Duration = 0f;
		}
	}
}
