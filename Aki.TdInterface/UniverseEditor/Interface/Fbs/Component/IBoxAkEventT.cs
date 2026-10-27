using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02004F23 RID: 20259
	public class IBoxAkEventT
	{
		// Token: 0x170091EC RID: 37356
		// (get) Token: 0x060200AC RID: 131244 RVA: 0x004755C2 File Offset: 0x004737C2
		// (set) Token: 0x060200AD RID: 131245 RVA: 0x004755CA File Offset: 0x004737CA
		public EAkEventType Type { get; set; }

		// Token: 0x170091ED RID: 37357
		// (get) Token: 0x060200AE RID: 131246 RVA: 0x004755D3 File Offset: 0x004737D3
		// (set) Token: 0x060200AF RID: 131247 RVA: 0x004755DB File Offset: 0x004737DB
		public EAudioType AudioType { get; set; }

		// Token: 0x170091EE RID: 37358
		// (get) Token: 0x060200B0 RID: 131248 RVA: 0x004755E4 File Offset: 0x004737E4
		// (set) Token: 0x060200B1 RID: 131249 RVA: 0x004755EC File Offset: 0x004737EC
		public int Priority { get; set; }

		// Token: 0x060200B2 RID: 131250 RVA: 0x004755F5 File Offset: 0x004737F5
		public IBoxAkEventT()
		{
			this.Type = EAkEventType.Point;
			this.AudioType = EAudioType.AudioAMB;
			this.Priority = 0;
		}
	}
}
