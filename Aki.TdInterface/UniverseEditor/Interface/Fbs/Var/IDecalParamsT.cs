using System;

namespace Aki.UniverseEditor.Interface.Fbs.Var
{
	// Token: 0x02003A94 RID: 14996
	public class IDecalParamsT
	{
		// Token: 0x170066BD RID: 26301
		// (get) Token: 0x06014596 RID: 83350 RVA: 0x002F80D2 File Offset: 0x002F62D2
		// (set) Token: 0x06014597 RID: 83351 RVA: 0x002F80DA File Offset: 0x002F62DA
		public EParamsPreset Type { get; set; }

		// Token: 0x170066BE RID: 26302
		// (get) Token: 0x06014598 RID: 83352 RVA: 0x002F80E3 File Offset: 0x002F62E3
		// (set) Token: 0x06014599 RID: 83353 RVA: 0x002F80EB File Offset: 0x002F62EB
		public float SpreadRadius { get; set; }

		// Token: 0x170066BF RID: 26303
		// (get) Token: 0x0601459A RID: 83354 RVA: 0x002F80F4 File Offset: 0x002F62F4
		// (set) Token: 0x0601459B RID: 83355 RVA: 0x002F80FC File Offset: 0x002F62FC
		public float SpreadTime { get; set; }

		// Token: 0x0601459C RID: 83356 RVA: 0x002F8105 File Offset: 0x002F6305
		public IDecalParamsT()
		{
			this.Type = EParamsPreset.Decal;
			this.SpreadRadius = 0f;
			this.SpreadTime = 0f;
		}
	}
}
