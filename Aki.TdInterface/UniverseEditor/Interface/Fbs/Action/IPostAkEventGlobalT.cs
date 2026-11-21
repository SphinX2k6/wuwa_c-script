using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020074ED RID: 29933
	public class IPostAkEventGlobalT
	{
		// Token: 0x1700DC50 RID: 56400
		// (get) Token: 0x060347CA RID: 214986 RVA: 0x00711077 File Offset: 0x0070F277
		// (set) Token: 0x060347CB RID: 214987 RVA: 0x0071107F File Offset: 0x0070F27F
		public EPostAkEvent Type { get; set; }

		// Token: 0x1700DC51 RID: 56401
		// (get) Token: 0x060347CC RID: 214988 RVA: 0x00711088 File Offset: 0x0070F288
		// (set) Token: 0x060347CD RID: 214989 RVA: 0x00711090 File Offset: 0x0070F290
		public string AkEvent { get; set; }

		// Token: 0x060347CE RID: 214990 RVA: 0x00711099 File Offset: 0x0070F299
		public IPostAkEventGlobalT()
		{
			this.Type = EPostAkEvent.Global;
			this.AkEvent = null;
		}
	}
}
