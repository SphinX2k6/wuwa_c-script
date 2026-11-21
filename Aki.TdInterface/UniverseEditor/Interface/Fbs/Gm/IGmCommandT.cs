using System;

namespace Aki.UniverseEditor.Interface.Fbs.Gm
{
	// Token: 0x02004AC3 RID: 19139
	public class IGmCommandT
	{
		// Token: 0x17008615 RID: 34325
		// (get) Token: 0x0601CC92 RID: 117906 RVA: 0x0040E196 File Offset: 0x0040C396
		// (set) Token: 0x0601CC93 RID: 117907 RVA: 0x0040E19E File Offset: 0x0040C39E
		public EGmCommand Type { get; set; }

		// Token: 0x0601CC94 RID: 117908 RVA: 0x0040E1A7 File Offset: 0x0040C3A7
		public IGmCommandT()
		{
			this.Type = EGmCommand.SkipToLevelPlayNode;
		}
	}
}
