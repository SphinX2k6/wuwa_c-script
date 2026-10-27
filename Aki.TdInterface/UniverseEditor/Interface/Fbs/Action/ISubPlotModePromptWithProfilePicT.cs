using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020071FD RID: 29181
	public class ISubPlotModePromptWithProfilePicT
	{
		// Token: 0x1700D8A9 RID: 55465
		// (get) Token: 0x06033C20 RID: 212000 RVA: 0x006F77AA File Offset: 0x006F59AA
		// (set) Token: 0x06033C21 RID: 212001 RVA: 0x006F77B2 File Offset: 0x006F59B2
		public ESubPlotModeType Type { get; set; }

		// Token: 0x06033C22 RID: 212002 RVA: 0x006F77BB File Offset: 0x006F59BB
		public ISubPlotModePromptWithProfilePicT()
		{
			this.Type = ESubPlotModeType.PromptWithProfilePic;
		}
	}
}
