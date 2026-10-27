using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020063B3 RID: 25523
	public class IClientEventUiT
	{
		// Token: 0x1700BE39 RID: 48697
		// (get) Token: 0x0602C26D RID: 180845 RVA: 0x0061012A File Offset: 0x0060E32A
		// (set) Token: 0x0602C26E RID: 180846 RVA: 0x00610132 File Offset: 0x0060E332
		public EClientEventUiType Type { get; set; }

		// Token: 0x0602C26F RID: 180847 RVA: 0x0061013B File Offset: 0x0060E33B
		public IClientEventUiT()
		{
			this.Type = EClientEventUiType.PlayPiano;
		}
	}
}
