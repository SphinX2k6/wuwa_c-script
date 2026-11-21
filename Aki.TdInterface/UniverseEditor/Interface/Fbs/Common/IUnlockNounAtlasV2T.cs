using System;

namespace Aki.UniverseEditor.Interface.Fbs.Common
{
	// Token: 0x020064A4 RID: 25764
	public class IUnlockNounAtlasV2T
	{
		// Token: 0x1700BE17 RID: 48663
		// (get) Token: 0x0602BCC1 RID: 179393 RVA: 0x005F516C File Offset: 0x005F336C
		// (set) Token: 0x0602BCC2 RID: 179394 RVA: 0x005F5174 File Offset: 0x005F3374
		public EUnlockAtlasSystemTypeV2 Type { get; set; }

		// Token: 0x1700BE18 RID: 48664
		// (get) Token: 0x0602BCC3 RID: 179395 RVA: 0x005F517D File Offset: 0x005F337D
		// (set) Token: 0x0602BCC4 RID: 179396 RVA: 0x005F5185 File Offset: 0x005F3385
		public int Id { get; set; }

		// Token: 0x0602BCC5 RID: 179397 RVA: 0x005F518E File Offset: 0x005F338E
		public IUnlockNounAtlasV2T()
		{
			this.Type = EUnlockAtlasSystemTypeV2.GeographicalAtlas;
			this.Id = 0;
		}
	}
}
