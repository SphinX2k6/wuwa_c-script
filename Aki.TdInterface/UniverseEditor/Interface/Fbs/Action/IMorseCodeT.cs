using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007241 RID: 29249
	public class IMorseCodeT
	{
		// Token: 0x1700D648 RID: 54856
		// (get) Token: 0x06032EDE RID: 208606 RVA: 0x006E02B7 File Offset: 0x006DE4B7
		// (set) Token: 0x06032EDF RID: 208607 RVA: 0x006E02BF File Offset: 0x006DE4BF
		public ESimpleGameplayType Type { get; set; }

		// Token: 0x1700D649 RID: 54857
		// (get) Token: 0x06032EE0 RID: 208608 RVA: 0x006E02C8 File Offset: 0x006DE4C8
		// (set) Token: 0x06032EE1 RID: 208609 RVA: 0x006E02D0 File Offset: 0x006DE4D0
		public string MorseCodeId { get; set; }

		// Token: 0x06032EE2 RID: 208610 RVA: 0x006E02D9 File Offset: 0x006DE4D9
		public IMorseCodeT()
		{
			this.Type = ESimpleGameplayType.Cipher;
			this.MorseCodeId = null;
		}
	}
}
