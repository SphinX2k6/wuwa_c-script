using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006D72 RID: 28018
	public class IPostAkEventGlobalT
	{
		// Token: 0x1700D108 RID: 53512
		// (get) Token: 0x060317CE RID: 202702 RVA: 0x006B598F File Offset: 0x006B3B8F
		// (set) Token: 0x060317CF RID: 202703 RVA: 0x006B5997 File Offset: 0x006B3B97
		public EPostAkEvent Type { get; set; }

		// Token: 0x1700D109 RID: 53513
		// (get) Token: 0x060317D0 RID: 202704 RVA: 0x006B59A0 File Offset: 0x006B3BA0
		// (set) Token: 0x060317D1 RID: 202705 RVA: 0x006B59A8 File Offset: 0x006B3BA8
		public string AkEvent { get; set; }

		// Token: 0x060317D2 RID: 202706 RVA: 0x006B59B1 File Offset: 0x006B3BB1
		public IPostAkEventGlobalT()
		{
			this.Type = EPostAkEvent.Global;
			this.AkEvent = null;
		}
	}
}
