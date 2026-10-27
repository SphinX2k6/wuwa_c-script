using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02004FBC RID: 20412
	public class IColorChangeStrategyOfRGBT
	{
		// Token: 0x170093D9 RID: 37849
		// (get) Token: 0x060207F5 RID: 133109 RVA: 0x00485490 File Offset: 0x00483690
		// (set) Token: 0x060207F6 RID: 133110 RVA: 0x00485498 File Offset: 0x00483698
		public EColorChangeStrategyOfSplineEffect Type { get; set; }

		// Token: 0x170093DA RID: 37850
		// (get) Token: 0x060207F7 RID: 133111 RVA: 0x004854A1 File Offset: 0x004836A1
		// (set) Token: 0x060207F8 RID: 133112 RVA: 0x004854A9 File Offset: 0x004836A9
		public string BlueState { get; set; }

		// Token: 0x170093DB RID: 37851
		// (get) Token: 0x060207F9 RID: 133113 RVA: 0x004854B2 File Offset: 0x004836B2
		// (set) Token: 0x060207FA RID: 133114 RVA: 0x004854BA File Offset: 0x004836BA
		public string YellowState { get; set; }

		// Token: 0x170093DC RID: 37852
		// (get) Token: 0x060207FB RID: 133115 RVA: 0x004854C3 File Offset: 0x004836C3
		// (set) Token: 0x060207FC RID: 133116 RVA: 0x004854CB File Offset: 0x004836CB
		public string RedState { get; set; }

		// Token: 0x060207FD RID: 133117 RVA: 0x004854D4 File Offset: 0x004836D4
		public IColorChangeStrategyOfRGBT()
		{
			this.Type = EColorChangeStrategyOfSplineEffect.RGB;
			this.BlueState = null;
			this.YellowState = null;
			this.RedState = null;
		}
	}
}
