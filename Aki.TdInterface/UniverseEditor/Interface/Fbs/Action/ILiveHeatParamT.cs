using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020070F8 RID: 28920
	public class ILiveHeatParamT
	{
		// Token: 0x1700D3CA RID: 54218
		// (get) Token: 0x0603239E RID: 205726 RVA: 0x006CB0FA File Offset: 0x006C92FA
		// (set) Token: 0x0603239F RID: 205727 RVA: 0x006CB102 File Offset: 0x006C9302
		public ELiveParamType Type { get; set; }

		// Token: 0x1700D3CB RID: 54219
		// (get) Token: 0x060323A0 RID: 205728 RVA: 0x006CB10B File Offset: 0x006C930B
		// (set) Token: 0x060323A1 RID: 205729 RVA: 0x006CB113 File Offset: 0x006C9313
		public int MinHeat { get; set; }

		// Token: 0x1700D3CC RID: 54220
		// (get) Token: 0x060323A2 RID: 205730 RVA: 0x006CB11C File Offset: 0x006C931C
		// (set) Token: 0x060323A3 RID: 205731 RVA: 0x006CB124 File Offset: 0x006C9324
		public int MaxHeat { get; set; }

		// Token: 0x060323A4 RID: 205732 RVA: 0x006CB12D File Offset: 0x006C932D
		public ILiveHeatParamT()
		{
			this.Type = ELiveParamType.Heat;
			this.MinHeat = 0;
			this.MaxHeat = 0;
		}
	}
}
