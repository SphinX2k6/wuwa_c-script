using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200721E RID: 29214
	public class ISubScreenPresetInitDataT
	{
		// Token: 0x1700D8DF RID: 55519
		// (get) Token: 0x06033D30 RID: 212272 RVA: 0x006F9751 File Offset: 0x006F7951
		// (set) Token: 0x06033D31 RID: 212273 RVA: 0x006F9759 File Offset: 0x006F7959
		public ESubScreenInitDataType Type { get; set; }

		// Token: 0x1700D8E0 RID: 55520
		// (get) Token: 0x06033D32 RID: 212274 RVA: 0x006F9762 File Offset: 0x006F7962
		// (set) Token: 0x06033D33 RID: 212275 RVA: 0x006F976A File Offset: 0x006F796A
		public string SubScreenKey { get; set; }

		// Token: 0x1700D8E1 RID: 55521
		// (get) Token: 0x06033D34 RID: 212276 RVA: 0x006F9773 File Offset: 0x006F7973
		// (set) Token: 0x06033D35 RID: 212277 RVA: 0x006F977B File Offset: 0x006F797B
		public ESubScreenInitPreset AnchorType { get; set; }

		// Token: 0x06033D36 RID: 212278 RVA: 0x006F9784 File Offset: 0x006F7984
		public ISubScreenPresetInitDataT()
		{
			this.Type = ESubScreenInitDataType.Preset;
			this.SubScreenKey = null;
			this.AnchorType = ESubScreenInitPreset.Left;
		}
	}
}
