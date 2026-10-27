using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200696D RID: 26989
	public class IInstrumentKeyAttributeT
	{
		// Token: 0x1700C828 RID: 51240
		// (get) Token: 0x0602F1FC RID: 193020 RVA: 0x0066B98E File Offset: 0x00669B8E
		// (set) Token: 0x0602F1FD RID: 193021 RVA: 0x0066B996 File Offset: 0x00669B96
		public string FundamentalToneAssetPath { get; set; }

		// Token: 0x1700C829 RID: 51241
		// (get) Token: 0x0602F1FE RID: 193022 RVA: 0x0066B99F File Offset: 0x00669B9F
		// (set) Token: 0x0602F1FF RID: 193023 RVA: 0x0066B9A7 File Offset: 0x00669BA7
		public string OverToneAssetPath { get; set; }

		// Token: 0x1700C82A RID: 51242
		// (get) Token: 0x0602F200 RID: 193024 RVA: 0x0066B9B0 File Offset: 0x00669BB0
		// (set) Token: 0x0602F201 RID: 193025 RVA: 0x0066B9B8 File Offset: 0x00669BB8
		public string TextureAssetPath { get; set; }

		// Token: 0x0602F202 RID: 193026 RVA: 0x0066B9C1 File Offset: 0x00669BC1
		public IInstrumentKeyAttributeT()
		{
			this.FundamentalToneAssetPath = null;
			this.OverToneAssetPath = null;
			this.TextureAssetPath = null;
		}
	}
}
