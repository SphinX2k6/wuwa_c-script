using System;

namespace Aki.UniverseEditor.Interface.Fbs.Var
{
	// Token: 0x02003EC3 RID: 16067
	public class IRushWarningEffectParamsT
	{
		// Token: 0x17006CCD RID: 27853
		// (get) Token: 0x06015BF8 RID: 89080 RVA: 0x00321468 File Offset: 0x0031F668
		// (set) Token: 0x06015BF9 RID: 89081 RVA: 0x00321470 File Offset: 0x0031F670
		public EParamsPreset Type { get; set; }

		// Token: 0x17006CCE RID: 27854
		// (get) Token: 0x06015BFA RID: 89082 RVA: 0x00321479 File Offset: 0x0031F679
		// (set) Token: 0x06015BFB RID: 89083 RVA: 0x00321481 File Offset: 0x0031F681
		public int Length { get; set; }

		// Token: 0x17006CCF RID: 27855
		// (get) Token: 0x06015BFC RID: 89084 RVA: 0x0032148A File Offset: 0x0031F68A
		// (set) Token: 0x06015BFD RID: 89085 RVA: 0x00321492 File Offset: 0x0031F692
		public int Width { get; set; }

		// Token: 0x17006CD0 RID: 27856
		// (get) Token: 0x06015BFE RID: 89086 RVA: 0x0032149B File Offset: 0x0031F69B
		// (set) Token: 0x06015BFF RID: 89087 RVA: 0x003214A3 File Offset: 0x0031F6A3
		public float Time { get; set; }

		// Token: 0x06015C00 RID: 89088 RVA: 0x003214AC File Offset: 0x0031F6AC
		public IRushWarningEffectParamsT()
		{
			this.Type = EParamsPreset.Decal;
			this.Length = 0;
			this.Width = 0;
			this.Time = 0f;
		}
	}
}
