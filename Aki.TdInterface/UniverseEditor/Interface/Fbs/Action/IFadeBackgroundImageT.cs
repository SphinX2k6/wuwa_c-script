using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200677B RID: 26491
	public class IFadeBackgroundImageT
	{
		// Token: 0x1700C4A1 RID: 50337
		// (get) Token: 0x0602E169 RID: 188777 RVA: 0x0064BE04 File Offset: 0x0064A004
		// (set) Token: 0x0602E16A RID: 188778 RVA: 0x0064BE0C File Offset: 0x0064A00C
		public EFadeBackgroundType Type { get; set; }

		// Token: 0x1700C4A2 RID: 50338
		// (get) Token: 0x0602E16B RID: 188779 RVA: 0x0064BE15 File Offset: 0x0064A015
		// (set) Token: 0x0602E16C RID: 188780 RVA: 0x0064BE1D File Offset: 0x0064A01D
		public string BackgroundImage { get; set; }

		// Token: 0x1700C4A3 RID: 50339
		// (get) Token: 0x0602E16D RID: 188781 RVA: 0x0064BE26 File Offset: 0x0064A026
		// (set) Token: 0x0602E16E RID: 188782 RVA: 0x0064BE2E File Offset: 0x0064A02E
		public IFadeBackgroundFadeInEffectT FadeInEffect { get; set; }

		// Token: 0x1700C4A4 RID: 50340
		// (get) Token: 0x0602E16F RID: 188783 RVA: 0x0064BE37 File Offset: 0x0064A037
		// (set) Token: 0x0602E170 RID: 188784 RVA: 0x0064BE3F File Offset: 0x0064A03F
		public IFadeBackgroundFadeOutEffectT FadeOutEffect { get; set; }

		// Token: 0x0602E171 RID: 188785 RVA: 0x0064BE48 File Offset: 0x0064A048
		public IFadeBackgroundImageT()
		{
			this.Type = EFadeBackgroundType.Spine;
			this.BackgroundImage = null;
			this.FadeInEffect = null;
			this.FadeOutEffect = null;
		}
	}
}
