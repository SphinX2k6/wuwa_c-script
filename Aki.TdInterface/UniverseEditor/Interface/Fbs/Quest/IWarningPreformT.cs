using System;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020046E9 RID: 18153
	public class IWarningPreformT
	{
		// Token: 0x17007F30 RID: 32560
		// (get) Token: 0x0601AB4D RID: 109389 RVA: 0x003CBD15 File Offset: 0x003C9F15
		// (set) Token: 0x0601AB4E RID: 109390 RVA: 0x003CBD1D File Offset: 0x003C9F1D
		public TWarningPreformConfigUnion Type { get; set; }

		// Token: 0x0601AB4F RID: 109391 RVA: 0x003CBD26 File Offset: 0x003C9F26
		public IWarningPreformT()
		{
			this.Type = null;
		}
	}
}
