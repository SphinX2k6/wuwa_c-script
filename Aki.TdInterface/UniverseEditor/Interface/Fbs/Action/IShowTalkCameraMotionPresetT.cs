using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020070F2 RID: 28914
	public class IShowTalkCameraMotionPresetT
	{
		// Token: 0x1700D6ED RID: 55021
		// (get) Token: 0x06033403 RID: 209923 RVA: 0x006E90C5 File Offset: 0x006E72C5
		// (set) Token: 0x06033404 RID: 209924 RVA: 0x006E90CD File Offset: 0x006E72CD
		public EShowTalkCameraMotionType Type { get; set; }

		// Token: 0x1700D6EE RID: 55022
		// (get) Token: 0x06033405 RID: 209925 RVA: 0x006E90D6 File Offset: 0x006E72D6
		// (set) Token: 0x06033406 RID: 209926 RVA: 0x006E90DE File Offset: 0x006E72DE
		public string Sequence { get; set; }

		// Token: 0x1700D6EF RID: 55023
		// (get) Token: 0x06033407 RID: 209927 RVA: 0x006E90E7 File Offset: 0x006E72E7
		// (set) Token: 0x06033408 RID: 209928 RVA: 0x006E90EF File Offset: 0x006E72EF
		public IFlowCameraShakeT CamShake { get; set; }

		// Token: 0x06033409 RID: 209929 RVA: 0x006E90F8 File Offset: 0x006E72F8
		public IShowTalkCameraMotionPresetT()
		{
			this.Type = EShowTalkCameraMotionType.Preset;
			this.Sequence = null;
			this.CamShake = null;
		}
	}
}
