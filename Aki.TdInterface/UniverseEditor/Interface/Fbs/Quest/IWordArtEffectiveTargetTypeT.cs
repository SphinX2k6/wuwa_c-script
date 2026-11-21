using System;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004701 RID: 18177
	public class IWordArtEffectiveTargetTypeT
	{
		// Token: 0x17007F4F RID: 32591
		// (get) Token: 0x0601ABF1 RID: 109553 RVA: 0x003CCD4A File Offset: 0x003CAF4A
		// (set) Token: 0x0601ABF2 RID: 109554 RVA: 0x003CCD52 File Offset: 0x003CAF52
		public EWordArtEffectiveTargetType Type { get; set; }

		// Token: 0x0601ABF3 RID: 109555 RVA: 0x003CCD5B File Offset: 0x003CAF5B
		public IWordArtEffectiveTargetTypeT()
		{
			this.Type = EWordArtEffectiveTargetType.Number;
		}
	}
}
