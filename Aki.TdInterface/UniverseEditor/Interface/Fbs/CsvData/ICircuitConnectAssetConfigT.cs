using System;

namespace Aki.UniverseEditor.Interface.Fbs.CsvData
{
	// Token: 0x02004D6E RID: 19822
	public class ICircuitConnectAssetConfigT
	{
		// Token: 0x17008DD5 RID: 36309
		// (get) Token: 0x0601EB8F RID: 125839 RVA: 0x0044C213 File Offset: 0x0044A413
		// (set) Token: 0x0601EB90 RID: 125840 RVA: 0x0044C21B File Offset: 0x0044A41B
		public string AssetPath { get; set; }

		// Token: 0x17008DD6 RID: 36310
		// (get) Token: 0x0601EB91 RID: 125841 RVA: 0x0044C224 File Offset: 0x0044A424
		// (set) Token: 0x0601EB92 RID: 125842 RVA: 0x0044C22C File Offset: 0x0044A42C
		public TCircuitConnectAssetTypeUnion AssetType { get; set; }

		// Token: 0x0601EB93 RID: 125843 RVA: 0x0044C235 File Offset: 0x0044A435
		public ICircuitConnectAssetConfigT()
		{
			this.AssetPath = null;
			this.AssetType = null;
		}
	}
}
