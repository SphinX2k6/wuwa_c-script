using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020071F7 RID: 29175
	public class ISubPlotModeBaseT
	{
		// Token: 0x1700D8A4 RID: 55460
		// (get) Token: 0x06033C02 RID: 211970 RVA: 0x006F7536 File Offset: 0x006F5736
		// (set) Token: 0x06033C03 RID: 211971 RVA: 0x006F753E File Offset: 0x006F573E
		public ESubPlotModeType Type { get; set; }

		// Token: 0x06033C04 RID: 211972 RVA: 0x006F7547 File Offset: 0x006F5747
		public ISubPlotModeBaseT()
		{
			this.Type = ESubPlotModeType.PromptWithProfilePic;
		}
	}
}
