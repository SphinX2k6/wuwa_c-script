using System;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020042A5 RID: 17061
	public class IWordArtEffectiveTargetTypeT
	{
		// Token: 0x1700791E RID: 31006
		// (get) Token: 0x06019485 RID: 103557 RVA: 0x003A1672 File Offset: 0x0039F872
		// (set) Token: 0x06019486 RID: 103558 RVA: 0x003A167A File Offset: 0x0039F87A
		public EWordArtEffectiveTargetType Type { get; set; }

		// Token: 0x06019487 RID: 103559 RVA: 0x003A1683 File Offset: 0x0039F883
		public IWordArtEffectiveTargetTypeT()
		{
			this.Type = EWordArtEffectiveTargetType.Number;
		}
	}
}
