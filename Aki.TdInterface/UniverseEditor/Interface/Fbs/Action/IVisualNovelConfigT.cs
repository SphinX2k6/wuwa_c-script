using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007D6B RID: 32107
	public class IVisualNovelConfigT
	{
		// Token: 0x1700F03B RID: 61499
		// (get) Token: 0x06039F62 RID: 237410 RVA: 0x007D0E47 File Offset: 0x007CF047
		// (set) Token: 0x06039F63 RID: 237411 RVA: 0x007D0E4F File Offset: 0x007CF04F
		public EVisualNovelSubType VisualNovelSubType { get; set; }

		// Token: 0x1700F03C RID: 61500
		// (get) Token: 0x06039F64 RID: 237412 RVA: 0x007D0E58 File Offset: 0x007CF058
		// (set) Token: 0x06039F65 RID: 237413 RVA: 0x007D0E60 File Offset: 0x007CF060
		public bool EnableReadRecord { get; set; }

		// Token: 0x1700F03D RID: 61501
		// (get) Token: 0x06039F66 RID: 237414 RVA: 0x007D0E69 File Offset: 0x007CF069
		// (set) Token: 0x06039F67 RID: 237415 RVA: 0x007D0E71 File Offset: 0x007CF071
		public bool EnableFastForward { get; set; }

		// Token: 0x1700F03E RID: 61502
		// (get) Token: 0x06039F68 RID: 237416 RVA: 0x007D0E7A File Offset: 0x007CF07A
		// (set) Token: 0x06039F69 RID: 237417 RVA: 0x007D0E82 File Offset: 0x007CF082
		public bool HideControlUi { get; set; }

		// Token: 0x1700F03F RID: 61503
		// (get) Token: 0x06039F6A RID: 237418 RVA: 0x007D0E8B File Offset: 0x007CF08B
		// (set) Token: 0x06039F6B RID: 237419 RVA: 0x007D0E93 File Offset: 0x007CF093
		public int InitialBackgroundId { get; set; }

		// Token: 0x1700F040 RID: 61504
		// (get) Token: 0x06039F6C RID: 237420 RVA: 0x007D0E9C File Offset: 0x007CF09C
		// (set) Token: 0x06039F6D RID: 237421 RVA: 0x007D0EA4 File Offset: 0x007CF0A4
		public List<string> InitialAudioEvents { get; set; }

		// Token: 0x1700F041 RID: 61505
		// (get) Token: 0x06039F6E RID: 237422 RVA: 0x007D0EAD File Offset: 0x007CF0AD
		// (set) Token: 0x06039F6F RID: 237423 RVA: 0x007D0EB5 File Offset: 0x007CF0B5
		public ISolarSchoolTimeT InitialTime { get; set; }

		// Token: 0x1700F042 RID: 61506
		// (get) Token: 0x06039F70 RID: 237424 RVA: 0x007D0EBE File Offset: 0x007CF0BE
		// (set) Token: 0x06039F71 RID: 237425 RVA: 0x007D0EC6 File Offset: 0x007CF0C6
		public float EndFadeOutTime { get; set; }

		// Token: 0x1700F043 RID: 61507
		// (get) Token: 0x06039F72 RID: 237426 RVA: 0x007D0ECF File Offset: 0x007CF0CF
		// (set) Token: 0x06039F73 RID: 237427 RVA: 0x007D0ED7 File Offset: 0x007CF0D7
		public byte NullMask { get; set; }

		// Token: 0x06039F74 RID: 237428 RVA: 0x007D0EE0 File Offset: 0x007CF0E0
		public IVisualNovelConfigT()
		{
			this.VisualNovelSubType = EVisualNovelSubType.SolarSchool;
			this.EnableReadRecord = false;
			this.EnableFastForward = false;
			this.HideControlUi = false;
			this.InitialBackgroundId = 0;
			this.InitialAudioEvents = null;
			this.InitialTime = null;
			this.EndFadeOutTime = 0f;
			this.NullMask = 0;
		}
	}
}
