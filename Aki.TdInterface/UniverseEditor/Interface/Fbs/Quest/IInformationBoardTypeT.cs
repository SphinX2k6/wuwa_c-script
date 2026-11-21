using System;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020042DB RID: 17115
	public class IInformationBoardTypeT
	{
		// Token: 0x17007539 RID: 30009
		// (get) Token: 0x0601806F RID: 98415 RVA: 0x0036DECA File Offset: 0x0036C0CA
		// (set) Token: 0x06018070 RID: 98416 RVA: 0x0036DED2 File Offset: 0x0036C0D2
		public EInformationBoardType Type { get; set; }

		// Token: 0x06018071 RID: 98417 RVA: 0x0036DEDB File Offset: 0x0036C0DB
		public IInformationBoardTypeT()
		{
			this.Type = EInformationBoardType.DangoAbyss;
		}
	}
}
