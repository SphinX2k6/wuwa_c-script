using System;

namespace Aki.UniverseEditor.Interface.Fbs.Var
{
	// Token: 0x02003AEE RID: 15086
	public class ITimeDisplayMaterialParamsT
	{
		// Token: 0x17006778 RID: 26488
		// (get) Token: 0x060148E8 RID: 84200 RVA: 0x002FE4C7 File Offset: 0x002FC6C7
		// (set) Token: 0x060148E9 RID: 84201 RVA: 0x002FE4CF File Offset: 0x002FC6CF
		public EParamsPreset Type { get; set; }

		// Token: 0x17006779 RID: 26489
		// (get) Token: 0x060148EA RID: 84202 RVA: 0x002FE4D8 File Offset: 0x002FC6D8
		// (set) Token: 0x060148EB RID: 84203 RVA: 0x002FE4E0 File Offset: 0x002FC6E0
		public TTimeDisplayParamsUnion TimeDisplayParams { get; set; }

		// Token: 0x060148EC RID: 84204 RVA: 0x002FE4E9 File Offset: 0x002FC6E9
		public ITimeDisplayMaterialParamsT()
		{
			this.Type = EParamsPreset.Decal;
			this.TimeDisplayParams = null;
		}
	}
}
