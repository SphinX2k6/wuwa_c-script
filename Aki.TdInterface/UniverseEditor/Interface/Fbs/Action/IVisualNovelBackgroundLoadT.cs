using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007563 RID: 30051
	public class IVisualNovelBackgroundLoadT
	{
		// Token: 0x1700E3F1 RID: 58353
		// (get) Token: 0x06036ABC RID: 223932 RVA: 0x0076CBE0 File Offset: 0x0076ADE0
		// (set) Token: 0x06036ABD RID: 223933 RVA: 0x0076CBE8 File Offset: 0x0076ADE8
		public EVisualNovelBackgroundType Type { get; set; }

		// Token: 0x1700E3F2 RID: 58354
		// (get) Token: 0x06036ABE RID: 223934 RVA: 0x0076CBF1 File Offset: 0x0076ADF1
		// (set) Token: 0x06036ABF RID: 223935 RVA: 0x0076CBF9 File Offset: 0x0076ADF9
		public int BackgroundId { get; set; }

		// Token: 0x06036AC0 RID: 223936 RVA: 0x0076CC02 File Offset: 0x0076AE02
		public IVisualNovelBackgroundLoadT()
		{
			this.Type = EVisualNovelBackgroundType.Load;
			this.BackgroundId = 0;
		}
	}
}
