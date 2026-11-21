using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020074F0 RID: 29936
	public class IPostAkEventMapT
	{
		// Token: 0x1700DC56 RID: 56406
		// (get) Token: 0x060347E4 RID: 215012 RVA: 0x0071137D File Offset: 0x0070F57D
		// (set) Token: 0x060347E5 RID: 215013 RVA: 0x00711385 File Offset: 0x0070F585
		public EPostAkEvent Type { get; set; }

		// Token: 0x1700DC57 RID: 56407
		// (get) Token: 0x060347E6 RID: 215014 RVA: 0x0071138E File Offset: 0x0070F58E
		// (set) Token: 0x060347E7 RID: 215015 RVA: 0x00711396 File Offset: 0x0070F596
		public IPlayMapMusicT MapEventType { get; set; }

		// Token: 0x1700DC58 RID: 56408
		// (get) Token: 0x060347E8 RID: 215016 RVA: 0x0071139F File Offset: 0x0070F59F
		// (set) Token: 0x060347E9 RID: 215017 RVA: 0x007113A7 File Offset: 0x0070F5A7
		public string AkEvent { get; set; }

		// Token: 0x060347EA RID: 215018 RVA: 0x007113B0 File Offset: 0x0070F5B0
		public IPostAkEventMapT()
		{
			this.Type = EPostAkEvent.Global;
			this.MapEventType = null;
			this.AkEvent = null;
		}
	}
}
