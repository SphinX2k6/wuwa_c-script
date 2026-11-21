using System;

namespace Aki.UniverseEditor.Interface.Fbs.ShowTimeline
{
	// Token: 0x02003FC8 RID: 16328
	public class IShowTimelineInputT
	{
		// Token: 0x17006E90 RID: 28304
		// (get) Token: 0x060164D7 RID: 91351 RVA: 0x003320F2 File Offset: 0x003302F2
		// (set) Token: 0x060164D8 RID: 91352 RVA: 0x003320FA File Offset: 0x003302FA
		public EShowTimelineType Type { get; set; }

		// Token: 0x17006E91 RID: 28305
		// (get) Token: 0x060164D9 RID: 91353 RVA: 0x00332103 File Offset: 0x00330303
		// (set) Token: 0x060164DA RID: 91354 RVA: 0x0033210B File Offset: 0x0033030B
		public int InputAction { get; set; }

		// Token: 0x17006E92 RID: 28306
		// (get) Token: 0x060164DB RID: 91355 RVA: 0x00332114 File Offset: 0x00330314
		// (set) Token: 0x060164DC RID: 91356 RVA: 0x0033211C File Offset: 0x0033031C
		public EShowTimelineInputType InputType { get; set; }

		// Token: 0x060164DD RID: 91357 RVA: 0x00332125 File Offset: 0x00330325
		public IShowTimelineInputT()
		{
			this.Type = EShowTimelineType.Checkpoint;
			this.InputAction = 0;
			this.InputType = EShowTimelineInputType.Press;
		}
	}
}
