using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020061B6 RID: 25014
	public class IAudioTypeBaseT
	{
		// Token: 0x1700BA83 RID: 47747
		// (get) Token: 0x0602B1AE RID: 176558 RVA: 0x005F180E File Offset: 0x005EFA0E
		// (set) Token: 0x0602B1AF RID: 176559 RVA: 0x005F1816 File Offset: 0x005EFA16
		public EAudioType Type { get; set; }

		// Token: 0x0602B1B0 RID: 176560 RVA: 0x005F181F File Offset: 0x005EFA1F
		public IAudioTypeBaseT()
		{
			this.Type = EAudioType.RoleSceneVoice;
		}
	}
}
