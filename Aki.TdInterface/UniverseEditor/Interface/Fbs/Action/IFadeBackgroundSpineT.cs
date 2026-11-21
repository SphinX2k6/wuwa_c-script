using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006DFE RID: 28158
	public class IFadeBackgroundSpineT
	{
		// Token: 0x1700CE60 RID: 52832
		// (get) Token: 0x060309CD RID: 199117 RVA: 0x00699963 File Offset: 0x00697B63
		// (set) Token: 0x060309CE RID: 199118 RVA: 0x0069996B File Offset: 0x00697B6B
		public EFadeBackgroundType Type { get; set; }

		// Token: 0x1700CE61 RID: 52833
		// (get) Token: 0x060309CF RID: 199119 RVA: 0x00699974 File Offset: 0x00697B74
		// (set) Token: 0x060309D0 RID: 199120 RVA: 0x0069997C File Offset: 0x00697B7C
		public int SpineId { get; set; }

		// Token: 0x1700CE62 RID: 52834
		// (get) Token: 0x060309D1 RID: 199121 RVA: 0x00699985 File Offset: 0x00697B85
		// (set) Token: 0x060309D2 RID: 199122 RVA: 0x0069998D File Offset: 0x00697B8D
		public IFadeBackgroundFadeInEffectT FadeInEffect { get; set; }

		// Token: 0x1700CE63 RID: 52835
		// (get) Token: 0x060309D3 RID: 199123 RVA: 0x00699996 File Offset: 0x00697B96
		// (set) Token: 0x060309D4 RID: 199124 RVA: 0x0069999E File Offset: 0x00697B9E
		public IFadeBackgroundFadeOutEffectT FadeOutEffect { get; set; }

		// Token: 0x060309D5 RID: 199125 RVA: 0x006999A7 File Offset: 0x00697BA7
		public IFadeBackgroundSpineT()
		{
			this.Type = EFadeBackgroundType.Spine;
			this.SpineId = 0;
			this.FadeInEffect = null;
			this.FadeOutEffect = null;
		}
	}
}
