using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200522F RID: 21039
	public class IFanEffectConfigT
	{
		// Token: 0x17009A2B RID: 39467
		// (get) Token: 0x06022385 RID: 140165 RVA: 0x004BF5F0 File Offset: 0x004BD7F0
		// (set) Token: 0x06022386 RID: 140166 RVA: 0x004BF5F8 File Offset: 0x004BD7F8
		public string EffectPath { get; set; }

		// Token: 0x17009A2C RID: 39468
		// (get) Token: 0x06022387 RID: 140167 RVA: 0x004BF601 File Offset: 0x004BD801
		// (set) Token: 0x06022388 RID: 140168 RVA: 0x004BF609 File Offset: 0x004BD809
		public float DefaultEffectLength { get; set; }

		// Token: 0x17009A2D RID: 39469
		// (get) Token: 0x06022389 RID: 140169 RVA: 0x004BF612 File Offset: 0x004BD812
		// (set) Token: 0x0602238A RID: 140170 RVA: 0x004BF61A File Offset: 0x004BD81A
		public string HitEffectPath { get; set; }

		// Token: 0x0602238B RID: 140171 RVA: 0x004BF623 File Offset: 0x004BD823
		public IFanEffectConfigT()
		{
			this.EffectPath = null;
			this.DefaultEffectLength = 0f;
			this.HitEffectPath = null;
		}
	}
}
