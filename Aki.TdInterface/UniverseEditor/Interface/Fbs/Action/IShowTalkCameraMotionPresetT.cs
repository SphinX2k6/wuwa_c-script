using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020078BE RID: 30910
	public class IShowTalkCameraMotionPresetT
	{
		// Token: 0x1700E2D0 RID: 58064
		// (get) Token: 0x060366A5 RID: 222885 RVA: 0x007496D1 File Offset: 0x007478D1
		// (set) Token: 0x060366A6 RID: 222886 RVA: 0x007496D9 File Offset: 0x007478D9
		public EShowTalkCameraMotionType Type { get; set; }

		// Token: 0x1700E2D1 RID: 58065
		// (get) Token: 0x060366A7 RID: 222887 RVA: 0x007496E2 File Offset: 0x007478E2
		// (set) Token: 0x060366A8 RID: 222888 RVA: 0x007496EA File Offset: 0x007478EA
		public string Sequence { get; set; }

		// Token: 0x1700E2D2 RID: 58066
		// (get) Token: 0x060366A9 RID: 222889 RVA: 0x007496F3 File Offset: 0x007478F3
		// (set) Token: 0x060366AA RID: 222890 RVA: 0x007496FB File Offset: 0x007478FB
		public IFlowCameraShakeT CamShake { get; set; }

		// Token: 0x060366AB RID: 222891 RVA: 0x00749704 File Offset: 0x00747904
		public IShowTalkCameraMotionPresetT()
		{
			this.Type = EShowTalkCameraMotionType.Preset;
			this.Sequence = null;
			this.CamShake = null;
		}
	}
}
