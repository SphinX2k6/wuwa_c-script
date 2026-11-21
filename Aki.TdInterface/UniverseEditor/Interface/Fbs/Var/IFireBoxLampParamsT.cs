using System;

namespace Aki.UniverseEditor.Interface.Fbs.Var
{
	// Token: 0x02003E84 RID: 16004
	public class IFireBoxLampParamsT
	{
		// Token: 0x17006C20 RID: 27680
		// (get) Token: 0x06015978 RID: 88440 RVA: 0x0031C9EC File Offset: 0x0031ABEC
		// (set) Token: 0x06015979 RID: 88441 RVA: 0x0031C9F4 File Offset: 0x0031ABF4
		public EParamsPreset Type { get; set; }

		// Token: 0x17006C21 RID: 27681
		// (get) Token: 0x0601597A RID: 88442 RVA: 0x0031C9FD File Offset: 0x0031ABFD
		// (set) Token: 0x0601597B RID: 88443 RVA: 0x0031CA05 File Offset: 0x0031AC05
		public float RangeRadius { get; set; }

		// Token: 0x0601597C RID: 88444 RVA: 0x0031CA0E File Offset: 0x0031AC0E
		public IFireBoxLampParamsT()
		{
			this.Type = EParamsPreset.Decal;
			this.RangeRadius = 0f;
		}
	}
}
