using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006DF2 RID: 28146
	public class IFadeBackgroundFadeOutEffectScreenEffectT
	{
		// Token: 0x1700CE4B RID: 52811
		// (get) Token: 0x06030973 RID: 199027 RVA: 0x00698EBB File Offset: 0x006970BB
		// (set) Token: 0x06030974 RID: 199028 RVA: 0x00698EC3 File Offset: 0x006970C3
		public EFadeBackgroundFadeOutEffectType Type { get; set; }

		// Token: 0x1700CE4C RID: 52812
		// (get) Token: 0x06030975 RID: 199029 RVA: 0x00698ECC File Offset: 0x006970CC
		// (set) Token: 0x06030976 RID: 199030 RVA: 0x00698ED4 File Offset: 0x006970D4
		public string ScreenEffect { get; set; }

		// Token: 0x06030977 RID: 199031 RVA: 0x00698EDD File Offset: 0x006970DD
		public IFadeBackgroundFadeOutEffectScreenEffectT()
		{
			this.Type = EFadeBackgroundFadeOutEffectType.Black;
			this.ScreenEffect = null;
		}
	}
}
