using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020079CC RID: 31180
	public class ISubPlotModeBaseT
	{
		// Token: 0x1700E49D RID: 58525
		// (get) Token: 0x06036F04 RID: 225028 RVA: 0x00758896 File Offset: 0x00756A96
		// (set) Token: 0x06036F05 RID: 225029 RVA: 0x0075889E File Offset: 0x00756A9E
		public ESubPlotModeType Type { get; set; }

		// Token: 0x06036F06 RID: 225030 RVA: 0x007588A7 File Offset: 0x00756AA7
		public ISubPlotModeBaseT()
		{
			this.Type = ESubPlotModeType.PromptWithProfilePic;
		}
	}
}
