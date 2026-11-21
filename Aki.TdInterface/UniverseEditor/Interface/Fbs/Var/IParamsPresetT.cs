using System;

namespace Aki.UniverseEditor.Interface.Fbs.Var
{
	// Token: 0x02003EAE RID: 16046
	public class IParamsPresetT
	{
		// Token: 0x17006C9C RID: 27804
		// (get) Token: 0x06015B36 RID: 88886 RVA: 0x0031FE52 File Offset: 0x0031E052
		// (set) Token: 0x06015B37 RID: 88887 RVA: 0x0031FE5A File Offset: 0x0031E05A
		public EParamsPreset Type { get; set; }

		// Token: 0x06015B38 RID: 88888 RVA: 0x0031FE63 File Offset: 0x0031E063
		public IParamsPresetT()
		{
			this.Type = EParamsPreset.Decal;
		}
	}
}
