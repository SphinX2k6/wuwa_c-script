using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006760 RID: 26464
	public class IFadeBackgroundFadeInEffectBlackT
	{
		// Token: 0x1700C475 RID: 50293
		// (get) Token: 0x0602E09F RID: 188575 RVA: 0x0064A902 File Offset: 0x00648B02
		// (set) Token: 0x0602E0A0 RID: 188576 RVA: 0x0064A90A File Offset: 0x00648B0A
		public EFadeBackgroundFadeInEffectType Type { get; set; }

		// Token: 0x1700C476 RID: 50294
		// (get) Token: 0x0602E0A1 RID: 188577 RVA: 0x0064A913 File Offset: 0x00648B13
		// (set) Token: 0x0602E0A2 RID: 188578 RVA: 0x0064A91B File Offset: 0x00648B1B
		public EFadeInScreenShowType FadeColor { get; set; }

		// Token: 0x1700C477 RID: 50295
		// (get) Token: 0x0602E0A3 RID: 188579 RVA: 0x0064A924 File Offset: 0x00648B24
		// (set) Token: 0x0602E0A4 RID: 188580 RVA: 0x0064A92C File Offset: 0x00648B2C
		public float FadeInTime { get; set; }

		// Token: 0x1700C478 RID: 50296
		// (get) Token: 0x0602E0A5 RID: 188581 RVA: 0x0064A935 File Offset: 0x00648B35
		// (set) Token: 0x0602E0A6 RID: 188582 RVA: 0x0064A93D File Offset: 0x00648B3D
		public float FadeOutTime { get; set; }

		// Token: 0x1700C479 RID: 50297
		// (get) Token: 0x0602E0A7 RID: 188583 RVA: 0x0064A946 File Offset: 0x00648B46
		// (set) Token: 0x0602E0A8 RID: 188584 RVA: 0x0064A94E File Offset: 0x00648B4E
		public byte NullMask { get; set; }

		// Token: 0x0602E0A9 RID: 188585 RVA: 0x0064A957 File Offset: 0x00648B57
		public IFadeBackgroundFadeInEffectBlackT()
		{
			this.Type = EFadeBackgroundFadeInEffectType.Black;
			this.FadeColor = EFadeInScreenShowType.White;
			this.FadeInTime = 0f;
			this.FadeOutTime = 0f;
			this.NullMask = 0;
		}
	}
}
