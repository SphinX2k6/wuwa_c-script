using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006D42 RID: 27970
	public class IPlaySpineAnimationT
	{
		// Token: 0x1700D096 RID: 53398
		// (get) Token: 0x0603161B RID: 202267 RVA: 0x006B27F9 File Offset: 0x006B09F9
		// (set) Token: 0x0603161C RID: 202268 RVA: 0x006B2801 File Offset: 0x006B0A01
		public ESetSpineAnimation Type { get; set; }

		// Token: 0x1700D097 RID: 53399
		// (get) Token: 0x0603161D RID: 202269 RVA: 0x006B280A File Offset: 0x006B0A0A
		// (set) Token: 0x0603161E RID: 202270 RVA: 0x006B2812 File Offset: 0x006B0A12
		public string Name { get; set; }

		// Token: 0x1700D098 RID: 53400
		// (get) Token: 0x0603161F RID: 202271 RVA: 0x006B281B File Offset: 0x006B0A1B
		// (set) Token: 0x06031620 RID: 202272 RVA: 0x006B2823 File Offset: 0x006B0A23
		public bool IsLoop { get; set; }

		// Token: 0x06031621 RID: 202273 RVA: 0x006B282C File Offset: 0x006B0A2C
		public IPlaySpineAnimationT()
		{
			this.Type = ESetSpineAnimation.Play;
			this.Name = null;
			this.IsLoop = false;
		}
	}
}
