using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005518 RID: 21784
	public class IColorChangeStrategyOfRGBT
	{
		// Token: 0x17009BB1 RID: 39857
		// (get) Token: 0x060226E9 RID: 141033 RVA: 0x004BE974 File Offset: 0x004BCB74
		// (set) Token: 0x060226EA RID: 141034 RVA: 0x004BE97C File Offset: 0x004BCB7C
		public EColorChangeStrategyOfSplineEffect Type { get; set; }

		// Token: 0x17009BB2 RID: 39858
		// (get) Token: 0x060226EB RID: 141035 RVA: 0x004BE985 File Offset: 0x004BCB85
		// (set) Token: 0x060226EC RID: 141036 RVA: 0x004BE98D File Offset: 0x004BCB8D
		public string BlueState { get; set; }

		// Token: 0x17009BB3 RID: 39859
		// (get) Token: 0x060226ED RID: 141037 RVA: 0x004BE996 File Offset: 0x004BCB96
		// (set) Token: 0x060226EE RID: 141038 RVA: 0x004BE99E File Offset: 0x004BCB9E
		public string YellowState { get; set; }

		// Token: 0x17009BB4 RID: 39860
		// (get) Token: 0x060226EF RID: 141039 RVA: 0x004BE9A7 File Offset: 0x004BCBA7
		// (set) Token: 0x060226F0 RID: 141040 RVA: 0x004BE9AF File Offset: 0x004BCBAF
		public string RedState { get; set; }

		// Token: 0x060226F1 RID: 141041 RVA: 0x004BE9B8 File Offset: 0x004BCBB8
		public IColorChangeStrategyOfRGBT()
		{
			this.Type = EColorChangeStrategyOfSplineEffect.RGB;
			this.BlueState = null;
			this.YellowState = null;
			this.RedState = null;
		}
	}
}
