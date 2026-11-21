using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006DDD RID: 28125
	public class IFadeBackgroundFadeInEffectT
	{
		// Token: 0x1700CE24 RID: 52772
		// (get) Token: 0x060308CB RID: 198859 RVA: 0x00697CF9 File Offset: 0x00695EF9
		// (set) Token: 0x060308CC RID: 198860 RVA: 0x00697D01 File Offset: 0x00695F01
		public TFadeBackgroundFadeInEffectUnion FadeInEffect { get; set; }

		// Token: 0x060308CD RID: 198861 RVA: 0x00697D0A File Offset: 0x00695F0A
		public IFadeBackgroundFadeInEffectT()
		{
			this.FadeInEffect = null;
		}
	}
}
