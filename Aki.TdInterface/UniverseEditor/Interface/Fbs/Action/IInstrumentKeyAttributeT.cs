using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007020 RID: 28704
	public class IInstrumentKeyAttributeT
	{
		// Token: 0x1700D22B RID: 53803
		// (get) Token: 0x06031BCC RID: 203724 RVA: 0x006BBE76 File Offset: 0x006BA076
		// (set) Token: 0x06031BCD RID: 203725 RVA: 0x006BBE7E File Offset: 0x006BA07E
		public string FundamentalToneAssetPath { get; set; }

		// Token: 0x1700D22C RID: 53804
		// (get) Token: 0x06031BCE RID: 203726 RVA: 0x006BBE87 File Offset: 0x006BA087
		// (set) Token: 0x06031BCF RID: 203727 RVA: 0x006BBE8F File Offset: 0x006BA08F
		public string OverToneAssetPath { get; set; }

		// Token: 0x1700D22D RID: 53805
		// (get) Token: 0x06031BD0 RID: 203728 RVA: 0x006BBE98 File Offset: 0x006BA098
		// (set) Token: 0x06031BD1 RID: 203729 RVA: 0x006BBEA0 File Offset: 0x006BA0A0
		public string TextureAssetPath { get; set; }

		// Token: 0x06031BD2 RID: 203730 RVA: 0x006BBEA9 File Offset: 0x006BA0A9
		public IInstrumentKeyAttributeT()
		{
			this.FundamentalToneAssetPath = null;
			this.OverToneAssetPath = null;
			this.TextureAssetPath = null;
		}
	}
}
