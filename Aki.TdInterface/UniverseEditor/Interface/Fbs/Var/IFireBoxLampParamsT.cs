using System;

namespace Aki.UniverseEditor.Interface.Fbs.Var
{
	// Token: 0x02003A97 RID: 14999
	public class IFireBoxLampParamsT
	{
		// Token: 0x170066C3 RID: 26307
		// (get) Token: 0x060145AE RID: 83374 RVA: 0x002F8318 File Offset: 0x002F6518
		// (set) Token: 0x060145AF RID: 83375 RVA: 0x002F8320 File Offset: 0x002F6520
		public EParamsPreset Type { get; set; }

		// Token: 0x170066C4 RID: 26308
		// (get) Token: 0x060145B0 RID: 83376 RVA: 0x002F8329 File Offset: 0x002F6529
		// (set) Token: 0x060145B1 RID: 83377 RVA: 0x002F8331 File Offset: 0x002F6531
		public float RangeRadius { get; set; }

		// Token: 0x060145B2 RID: 83378 RVA: 0x002F833A File Offset: 0x002F653A
		public IFireBoxLampParamsT()
		{
			this.Type = EParamsPreset.Decal;
			this.RangeRadius = 0f;
		}
	}
}
