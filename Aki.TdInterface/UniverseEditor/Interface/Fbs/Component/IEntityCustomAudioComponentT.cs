using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020056DA RID: 22234
	public class IEntityCustomAudioComponentT
	{
		// Token: 0x1700A040 RID: 41024
		// (get) Token: 0x06023AA1 RID: 146081 RVA: 0x004E75E9 File Offset: 0x004E57E9
		// (set) Token: 0x06023AA2 RID: 146082 RVA: 0x004E75F1 File Offset: 0x004E57F1
		public bool Disabled { get; set; }

		// Token: 0x1700A041 RID: 41025
		// (get) Token: 0x06023AA3 RID: 146083 RVA: 0x004E75FA File Offset: 0x004E57FA
		// (set) Token: 0x06023AA4 RID: 146084 RVA: 0x004E7602 File Offset: 0x004E5802
		public TAkEventTypeUnion AkEventType { get; set; }

		// Token: 0x1700A042 RID: 41026
		// (get) Token: 0x06023AA5 RID: 146085 RVA: 0x004E760B File Offset: 0x004E580B
		// (set) Token: 0x06023AA6 RID: 146086 RVA: 0x004E7613 File Offset: 0x004E5813
		public EAudioRangeType AudioRangeType { get; set; }

		// Token: 0x1700A043 RID: 41027
		// (get) Token: 0x06023AA7 RID: 146087 RVA: 0x004E761C File Offset: 0x004E581C
		// (set) Token: 0x06023AA8 RID: 146088 RVA: 0x004E7624 File Offset: 0x004E5824
		public TAudioControlTypeUnion AudioControlType { get; set; }

		// Token: 0x1700A044 RID: 41028
		// (get) Token: 0x06023AA9 RID: 146089 RVA: 0x004E762D File Offset: 0x004E582D
		// (set) Token: 0x06023AAA RID: 146090 RVA: 0x004E7635 File Offset: 0x004E5835
		public byte NullMask { get; set; }

		// Token: 0x06023AAB RID: 146091 RVA: 0x004E763E File Offset: 0x004E583E
		public IEntityCustomAudioComponentT()
		{
			this.Disabled = false;
			this.AkEventType = null;
			this.AudioRangeType = EAudioRangeType.SceneActorRefComp;
			this.AudioControlType = null;
			this.NullMask = 0;
		}
	}
}
