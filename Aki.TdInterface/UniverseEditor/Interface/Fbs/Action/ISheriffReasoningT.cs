using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020070C5 RID: 28869
	public class ISheriffReasoningT
	{
		// Token: 0x1700D676 RID: 54902
		// (get) Token: 0x06033224 RID: 209444 RVA: 0x006E5284 File Offset: 0x006E3484
		// (set) Token: 0x06033225 RID: 209445 RVA: 0x006E528C File Offset: 0x006E348C
		public ESimpleGameplayType Type { get; set; }

		// Token: 0x1700D677 RID: 54903
		// (get) Token: 0x06033226 RID: 209446 RVA: 0x006E5295 File Offset: 0x006E3495
		// (set) Token: 0x06033227 RID: 209447 RVA: 0x006E529D File Offset: 0x006E349D
		public int Id { get; set; }

		// Token: 0x06033228 RID: 209448 RVA: 0x006E52A6 File Offset: 0x006E34A6
		public ISheriffReasoningT()
		{
			this.Type = ESimpleGameplayType.Cipher;
			this.Id = 0;
		}
	}
}
