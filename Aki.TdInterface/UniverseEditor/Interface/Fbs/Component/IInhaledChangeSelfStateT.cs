using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200598E RID: 22926
	public class IInhaledChangeSelfStateT
	{
		// Token: 0x1700A681 RID: 42625
		// (get) Token: 0x06025601 RID: 153089 RVA: 0x00520FEB File Offset: 0x0051F1EB
		// (set) Token: 0x06025602 RID: 153090 RVA: 0x00520FF3 File Offset: 0x0051F1F3
		public EInhaledPerResultType Type { get; set; }

		// Token: 0x1700A682 RID: 42626
		// (get) Token: 0x06025603 RID: 153091 RVA: 0x00520FFC File Offset: 0x0051F1FC
		// (set) Token: 0x06025604 RID: 153092 RVA: 0x00521004 File Offset: 0x0051F204
		public string ChangeSelfState { get; set; }

		// Token: 0x06025605 RID: 153093 RVA: 0x0052100D File Offset: 0x0051F20D
		public IInhaledChangeSelfStateT()
		{
			this.Type = EInhaledPerResultType.DestroySelf;
			this.ChangeSelfState = null;
		}
	}
}
