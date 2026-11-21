using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020079F3 RID: 31219
	public class ISubScreenPresetInitDataT
	{
		// Token: 0x1700E4D8 RID: 58584
		// (get) Token: 0x06037032 RID: 225330 RVA: 0x0075AAB1 File Offset: 0x00758CB1
		// (set) Token: 0x06037033 RID: 225331 RVA: 0x0075AAB9 File Offset: 0x00758CB9
		public ESubScreenInitDataType Type { get; set; }

		// Token: 0x1700E4D9 RID: 58585
		// (get) Token: 0x06037034 RID: 225332 RVA: 0x0075AAC2 File Offset: 0x00758CC2
		// (set) Token: 0x06037035 RID: 225333 RVA: 0x0075AACA File Offset: 0x00758CCA
		public string SubScreenKey { get; set; }

		// Token: 0x1700E4DA RID: 58586
		// (get) Token: 0x06037036 RID: 225334 RVA: 0x0075AAD3 File Offset: 0x00758CD3
		// (set) Token: 0x06037037 RID: 225335 RVA: 0x0075AADB File Offset: 0x00758CDB
		public ESubScreenInitPreset AnchorType { get; set; }

		// Token: 0x06037038 RID: 225336 RVA: 0x0075AAE4 File Offset: 0x00758CE4
		public ISubScreenPresetInitDataT()
		{
			this.Type = ESubScreenInitDataType.Preset;
			this.SubScreenKey = null;
			this.AnchorType = ESubScreenInitPreset.Left;
		}
	}
}
