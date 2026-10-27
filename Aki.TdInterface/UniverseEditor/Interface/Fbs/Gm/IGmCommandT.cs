using System;

namespace Aki.UniverseEditor.Interface.Fbs.Gm
{
	// Token: 0x0200465B RID: 18011
	public class IGmCommandT
	{
		// Token: 0x17007FD4 RID: 32724
		// (get) Token: 0x0601B4BD RID: 111805 RVA: 0x003E1EFA File Offset: 0x003E00FA
		// (set) Token: 0x0601B4BE RID: 111806 RVA: 0x003E1F02 File Offset: 0x003E0102
		public EGmCommand Type { get; set; }

		// Token: 0x0601B4BF RID: 111807 RVA: 0x003E1F0B File Offset: 0x003E010B
		public IGmCommandT()
		{
			this.Type = EGmCommand.SkipToLevelPlayNode;
		}
	}
}
