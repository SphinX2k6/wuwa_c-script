using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200577F RID: 22399
	public class IExtraRangeTypeT
	{
		// Token: 0x1700A1EB RID: 41451
		// (get) Token: 0x0602420E RID: 147982 RVA: 0x004F7C9A File Offset: 0x004F5E9A
		// (set) Token: 0x0602420F RID: 147983 RVA: 0x004F7CA2 File Offset: 0x004F5EA2
		public EExtraRangeType Type { get; set; }

		// Token: 0x06024210 RID: 147984 RVA: 0x004F7CAB File Offset: 0x004F5EAB
		public IExtraRangeTypeT()
		{
			this.Type = EExtraRangeType.SunSpiritBlock;
		}
	}
}
