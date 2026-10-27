using System;
using Aki.UniverseEditor.Interface.Fbs.Common;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020075AE RID: 30126
	public class IVisualNovelPerformanceLeaveBlackScreenT
	{
		// Token: 0x1700E49D RID: 58525
		// (get) Token: 0x06036D6A RID: 224618 RVA: 0x00771BF9 File Offset: 0x0076FDF9
		// (set) Token: 0x06036D6B RID: 224619 RVA: 0x00771C01 File Offset: 0x0076FE01
		public EVisualNovelPerformanceType Type { get; set; }

		// Token: 0x1700E49E RID: 58526
		// (get) Token: 0x06036D6C RID: 224620 RVA: 0x00771C0A File Offset: 0x0076FE0A
		// (set) Token: 0x06036D6D RID: 224621 RVA: 0x00771C12 File Offset: 0x0076FE12
		public float StartTime { get; set; }

		// Token: 0x1700E49F RID: 58527
		// (get) Token: 0x06036D6E RID: 224622 RVA: 0x00771C1B File Offset: 0x0076FE1B
		// (set) Token: 0x06036D6F RID: 224623 RVA: 0x00771C23 File Offset: 0x0076FE23
		public TEaseCurveTypeUnion EaseCurve { get; set; }

		// Token: 0x1700E4A0 RID: 58528
		// (get) Token: 0x06036D70 RID: 224624 RVA: 0x00771C2C File Offset: 0x0076FE2C
		// (set) Token: 0x06036D71 RID: 224625 RVA: 0x00771C34 File Offset: 0x0076FE34
		public float FadeOutTime { get; set; }

		// Token: 0x1700E4A1 RID: 58529
		// (get) Token: 0x06036D72 RID: 224626 RVA: 0x00771C3D File Offset: 0x0076FE3D
		// (set) Token: 0x06036D73 RID: 224627 RVA: 0x00771C45 File Offset: 0x0076FE45
		public byte NullMask { get; set; }

		// Token: 0x06036D74 RID: 224628 RVA: 0x00771C4E File Offset: 0x0076FE4E
		public IVisualNovelPerformanceLeaveBlackScreenT()
		{
			this.Type = EVisualNovelPerformanceType.Enter;
			this.StartTime = 0f;
			this.EaseCurve = null;
			this.FadeOutTime = 0f;
			this.NullMask = 0;
		}
	}
}
