using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007158 RID: 29016
	public class ILogT
	{
		// Token: 0x1700D457 RID: 54359
		// (get) Token: 0x0603268A RID: 206474 RVA: 0x006D0316 File Offset: 0x006CE516
		// (set) Token: 0x0603268B RID: 206475 RVA: 0x006D031E File Offset: 0x006CE51E
		public string Level { get; set; }

		// Token: 0x1700D458 RID: 54360
		// (get) Token: 0x0603268C RID: 206476 RVA: 0x006D0327 File Offset: 0x006CE527
		// (set) Token: 0x0603268D RID: 206477 RVA: 0x006D032F File Offset: 0x006CE52F
		public string Content { get; set; }

		// Token: 0x0603268E RID: 206478 RVA: 0x006D0338 File Offset: 0x006CE538
		public ILogT()
		{
			this.Level = null;
			this.Content = null;
		}
	}
}
