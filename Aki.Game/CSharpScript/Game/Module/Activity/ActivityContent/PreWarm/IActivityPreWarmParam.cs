using System;

namespace CSharpScript.Game.Module.Activity.ActivityContent.PreWarm
{
	// Token: 0x020062BB RID: 25275
	public class IActivityPreWarmParam
	{
		// Token: 0x17009272 RID: 37490
		// (get) Token: 0x0603F8F5 RID: 260341 RVA: 0x00F5F768 File Offset: 0x00F5D968
		// (set) Token: 0x0603F8F6 RID: 260342 RVA: 0x00F5F770 File Offset: 0x00F5D970
		public int Id { get; set; }

		// Token: 0x17009273 RID: 37491
		// (get) Token: 0x0603F8F7 RID: 260343 RVA: 0x00F5F779 File Offset: 0x00F5D979
		// (set) Token: 0x0603F8F8 RID: 260344 RVA: 0x00F5F781 File Offset: 0x00F5D981
		public bool IsParsing { get; set; }

		// Token: 0x17009274 RID: 37492
		// (get) Token: 0x0603F8F9 RID: 260345 RVA: 0x00F5F78A File Offset: 0x00F5D98A
		// (set) Token: 0x0603F8FA RID: 260346 RVA: 0x00F5F792 File Offset: 0x00F5D992
		public int? ActivityId { get; set; }
	}
}
