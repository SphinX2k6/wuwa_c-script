using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007A77 RID: 31351
	public class ITalkBackgroundSpineImageT
	{
		// Token: 0x1700E5A2 RID: 58786
		// (get) Token: 0x0603741D RID: 226333 RVA: 0x007610E8 File Offset: 0x0075F2E8
		// (set) Token: 0x0603741E RID: 226334 RVA: 0x007610F0 File Offset: 0x0075F2F0
		public ETalkBackgroundType Type { get; set; }

		// Token: 0x1700E5A3 RID: 58787
		// (get) Token: 0x0603741F RID: 226335 RVA: 0x007610F9 File Offset: 0x0075F2F9
		// (set) Token: 0x06037420 RID: 226336 RVA: 0x00761101 File Offset: 0x0075F301
		public int Id { get; set; }

		// Token: 0x1700E5A4 RID: 58788
		// (get) Token: 0x06037421 RID: 226337 RVA: 0x0076110A File Offset: 0x0075F30A
		// (set) Token: 0x06037422 RID: 226338 RVA: 0x00761112 File Offset: 0x0075F312
		public bool IsLoop { get; set; }

		// Token: 0x1700E5A5 RID: 58789
		// (get) Token: 0x06037423 RID: 226339 RVA: 0x0076111B File Offset: 0x0075F31B
		// (set) Token: 0x06037424 RID: 226340 RVA: 0x00761123 File Offset: 0x0075F323
		public byte NullMask { get; set; }

		// Token: 0x06037425 RID: 226341 RVA: 0x0076112C File Offset: 0x0075F32C
		public ITalkBackgroundSpineImageT()
		{
			this.Type = ETalkBackgroundType.Clean;
			this.Id = 0;
			this.IsLoop = false;
			this.NullMask = 0;
		}
	}
}
