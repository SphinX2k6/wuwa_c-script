using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005455 RID: 21589
	public class IBoxAkEventT
	{
		// Token: 0x1700996E RID: 39278
		// (get) Token: 0x06021E1C RID: 138780 RVA: 0x004AB956 File Offset: 0x004A9B56
		// (set) Token: 0x06021E1D RID: 138781 RVA: 0x004AB95E File Offset: 0x004A9B5E
		public EAkEventType Type { get; set; }

		// Token: 0x1700996F RID: 39279
		// (get) Token: 0x06021E1E RID: 138782 RVA: 0x004AB967 File Offset: 0x004A9B67
		// (set) Token: 0x06021E1F RID: 138783 RVA: 0x004AB96F File Offset: 0x004A9B6F
		public EAudioType AudioType { get; set; }

		// Token: 0x17009970 RID: 39280
		// (get) Token: 0x06021E20 RID: 138784 RVA: 0x004AB978 File Offset: 0x004A9B78
		// (set) Token: 0x06021E21 RID: 138785 RVA: 0x004AB980 File Offset: 0x004A9B80
		public int Priority { get; set; }

		// Token: 0x06021E22 RID: 138786 RVA: 0x004AB989 File Offset: 0x004A9B89
		public IBoxAkEventT()
		{
			this.Type = EAkEventType.Point;
			this.AudioType = EAudioType.AudioAMB;
			this.Priority = 0;
		}
	}
}
