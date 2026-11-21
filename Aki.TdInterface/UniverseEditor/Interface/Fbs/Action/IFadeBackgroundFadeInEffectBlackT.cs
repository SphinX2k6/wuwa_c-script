using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006DE0 RID: 28128
	public class IFadeBackgroundFadeInEffectBlackT
	{
		// Token: 0x1700CE2B RID: 52779
		// (get) Token: 0x060308E5 RID: 198885 RVA: 0x00698046 File Offset: 0x00696246
		// (set) Token: 0x060308E6 RID: 198886 RVA: 0x0069804E File Offset: 0x0069624E
		public EFadeBackgroundFadeInEffectType Type { get; set; }

		// Token: 0x1700CE2C RID: 52780
		// (get) Token: 0x060308E7 RID: 198887 RVA: 0x00698057 File Offset: 0x00696257
		// (set) Token: 0x060308E8 RID: 198888 RVA: 0x0069805F File Offset: 0x0069625F
		public EFadeInScreenShowType FadeColor { get; set; }

		// Token: 0x1700CE2D RID: 52781
		// (get) Token: 0x060308E9 RID: 198889 RVA: 0x00698068 File Offset: 0x00696268
		// (set) Token: 0x060308EA RID: 198890 RVA: 0x00698070 File Offset: 0x00696270
		public float FadeInTime { get; set; }

		// Token: 0x1700CE2E RID: 52782
		// (get) Token: 0x060308EB RID: 198891 RVA: 0x00698079 File Offset: 0x00696279
		// (set) Token: 0x060308EC RID: 198892 RVA: 0x00698081 File Offset: 0x00696281
		public float FadeOutTime { get; set; }

		// Token: 0x1700CE2F RID: 52783
		// (get) Token: 0x060308ED RID: 198893 RVA: 0x0069808A File Offset: 0x0069628A
		// (set) Token: 0x060308EE RID: 198894 RVA: 0x00698092 File Offset: 0x00696292
		public byte NullMask { get; set; }

		// Token: 0x060308EF RID: 198895 RVA: 0x0069809B File Offset: 0x0069629B
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
