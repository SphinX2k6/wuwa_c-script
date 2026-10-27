using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200677E RID: 26494
	public class IFadeBackgroundSpineT
	{
		// Token: 0x1700C4AA RID: 50346
		// (get) Token: 0x0602E187 RID: 188807 RVA: 0x0064C21F File Offset: 0x0064A41F
		// (set) Token: 0x0602E188 RID: 188808 RVA: 0x0064C227 File Offset: 0x0064A427
		public EFadeBackgroundType Type { get; set; }

		// Token: 0x1700C4AB RID: 50347
		// (get) Token: 0x0602E189 RID: 188809 RVA: 0x0064C230 File Offset: 0x0064A430
		// (set) Token: 0x0602E18A RID: 188810 RVA: 0x0064C238 File Offset: 0x0064A438
		public int SpineId { get; set; }

		// Token: 0x1700C4AC RID: 50348
		// (get) Token: 0x0602E18B RID: 188811 RVA: 0x0064C241 File Offset: 0x0064A441
		// (set) Token: 0x0602E18C RID: 188812 RVA: 0x0064C249 File Offset: 0x0064A449
		public IFadeBackgroundFadeInEffectT FadeInEffect { get; set; }

		// Token: 0x1700C4AD RID: 50349
		// (get) Token: 0x0602E18D RID: 188813 RVA: 0x0064C252 File Offset: 0x0064A452
		// (set) Token: 0x0602E18E RID: 188814 RVA: 0x0064C25A File Offset: 0x0064A45A
		public IFadeBackgroundFadeOutEffectT FadeOutEffect { get; set; }

		// Token: 0x0602E18F RID: 188815 RVA: 0x0064C263 File Offset: 0x0064A463
		public IFadeBackgroundSpineT()
		{
			this.Type = EFadeBackgroundType.Spine;
			this.SpineId = 0;
			this.FadeInEffect = null;
			this.FadeOutEffect = null;
		}
	}
}
