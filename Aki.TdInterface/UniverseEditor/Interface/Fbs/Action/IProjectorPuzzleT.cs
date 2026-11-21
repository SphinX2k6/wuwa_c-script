using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007538 RID: 30008
	public class IProjectorPuzzleT
	{
		// Token: 0x1700DCC9 RID: 56521
		// (get) Token: 0x06034A05 RID: 215557 RVA: 0x00714C76 File Offset: 0x00712E76
		// (set) Token: 0x06034A06 RID: 215558 RVA: 0x00714C7E File Offset: 0x00712E7E
		public ESimpleGameplayType Type { get; set; }

		// Token: 0x06034A07 RID: 215559 RVA: 0x00714C87 File Offset: 0x00712E87
		public IProjectorPuzzleT()
		{
			this.Type = ESimpleGameplayType.Cipher;
		}
	}
}
