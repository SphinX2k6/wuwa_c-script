using System;

namespace Aki.UniverseEditor.Interface.Fbs.Var
{
	// Token: 0x02003AAC RID: 15020
	public class IParamsPresetT
	{
		// Token: 0x17006701 RID: 26369
		// (get) Token: 0x06014690 RID: 83600 RVA: 0x002F9C46 File Offset: 0x002F7E46
		// (set) Token: 0x06014691 RID: 83601 RVA: 0x002F9C4E File Offset: 0x002F7E4E
		public EParamsPreset Type { get; set; }

		// Token: 0x06014692 RID: 83602 RVA: 0x002F9C57 File Offset: 0x002F7E57
		public IParamsPresetT()
		{
			this.Type = EParamsPreset.Decal;
		}
	}
}
