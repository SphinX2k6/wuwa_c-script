using System;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x020048DC RID: 18652
	public class IDartHitJudgeT
	{
		// Token: 0x170081EF RID: 33263
		// (get) Token: 0x0601B9CD RID: 113101 RVA: 0x003E790E File Offset: 0x003E5B0E
		// (set) Token: 0x0601B9CE RID: 113102 RVA: 0x003E7916 File Offset: 0x003E5B16
		public IDartPreciseJudgeT Precise { get; set; }

		// Token: 0x170081F0 RID: 33264
		// (get) Token: 0x0601B9CF RID: 113103 RVA: 0x003E791F File Offset: 0x003E5B1F
		// (set) Token: 0x0601B9D0 RID: 113104 RVA: 0x003E7927 File Offset: 0x003E5B27
		public IDartScatterJudgeT Scatter { get; set; }

		// Token: 0x170081F1 RID: 33265
		// (get) Token: 0x0601B9D1 RID: 113105 RVA: 0x003E7930 File Offset: 0x003E5B30
		// (set) Token: 0x0601B9D2 RID: 113106 RVA: 0x003E7938 File Offset: 0x003E5B38
		public IDartMissJudgeT Miss { get; set; }

		// Token: 0x0601B9D3 RID: 113107 RVA: 0x003E7941 File Offset: 0x003E5B41
		public IDartHitJudgeT()
		{
			this.Precise = null;
			this.Scatter = null;
			this.Miss = null;
		}
	}
}
