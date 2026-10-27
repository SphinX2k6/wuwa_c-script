using System;

namespace Aki.UniverseEditor.Interface.Fbs.ShowTimeline
{
	// Token: 0x02003BC0 RID: 15296
	public class IShowTimelineInputT
	{
		// Token: 0x170068ED RID: 26861
		// (get) Token: 0x06014FFF RID: 86015 RVA: 0x0030B896 File Offset: 0x00309A96
		// (set) Token: 0x06015000 RID: 86016 RVA: 0x0030B89E File Offset: 0x00309A9E
		public EShowTimelineType Type { get; set; }

		// Token: 0x170068EE RID: 26862
		// (get) Token: 0x06015001 RID: 86017 RVA: 0x0030B8A7 File Offset: 0x00309AA7
		// (set) Token: 0x06015002 RID: 86018 RVA: 0x0030B8AF File Offset: 0x00309AAF
		public int InputAction { get; set; }

		// Token: 0x170068EF RID: 26863
		// (get) Token: 0x06015003 RID: 86019 RVA: 0x0030B8B8 File Offset: 0x00309AB8
		// (set) Token: 0x06015004 RID: 86020 RVA: 0x0030B8C0 File Offset: 0x00309AC0
		public EShowTimelineInputType InputType { get; set; }

		// Token: 0x06015005 RID: 86021 RVA: 0x0030B8C9 File Offset: 0x00309AC9
		public IShowTimelineInputT()
		{
			this.Type = EShowTimelineType.Checkpoint;
			this.InputAction = 0;
			this.InputType = EShowTimelineInputType.Press;
		}
	}
}
