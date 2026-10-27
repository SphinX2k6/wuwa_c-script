using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006D75 RID: 28021
	public class IPostAkEventMapT
	{
		// Token: 0x1700D10E RID: 53518
		// (get) Token: 0x060317E8 RID: 202728 RVA: 0x006B5C95 File Offset: 0x006B3E95
		// (set) Token: 0x060317E9 RID: 202729 RVA: 0x006B5C9D File Offset: 0x006B3E9D
		public EPostAkEvent Type { get; set; }

		// Token: 0x1700D10F RID: 53519
		// (get) Token: 0x060317EA RID: 202730 RVA: 0x006B5CA6 File Offset: 0x006B3EA6
		// (set) Token: 0x060317EB RID: 202731 RVA: 0x006B5CAE File Offset: 0x006B3EAE
		public IPlayMapMusicT MapEventType { get; set; }

		// Token: 0x1700D110 RID: 53520
		// (get) Token: 0x060317EC RID: 202732 RVA: 0x006B5CB7 File Offset: 0x006B3EB7
		// (set) Token: 0x060317ED RID: 202733 RVA: 0x006B5CBF File Offset: 0x006B3EBF
		public string AkEvent { get; set; }

		// Token: 0x060317EE RID: 202734 RVA: 0x006B5CC8 File Offset: 0x006B3EC8
		public IPostAkEventMapT()
		{
			this.Type = EPostAkEvent.Global;
			this.MapEventType = null;
			this.AkEvent = null;
		}
	}
}
