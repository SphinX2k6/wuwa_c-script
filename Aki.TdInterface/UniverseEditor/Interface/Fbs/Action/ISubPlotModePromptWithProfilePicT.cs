using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020079D2 RID: 31186
	public class ISubPlotModePromptWithProfilePicT
	{
		// Token: 0x1700E4A2 RID: 58530
		// (get) Token: 0x06036F22 RID: 225058 RVA: 0x00758B0A File Offset: 0x00756D0A
		// (set) Token: 0x06036F23 RID: 225059 RVA: 0x00758B12 File Offset: 0x00756D12
		public ESubPlotModeType Type { get; set; }

		// Token: 0x06036F24 RID: 225060 RVA: 0x00758B1B File Offset: 0x00756D1B
		public ISubPlotModePromptWithProfilePicT()
		{
			this.Type = ESubPlotModeType.PromptWithProfilePic;
		}
	}
}
