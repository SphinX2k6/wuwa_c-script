using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007226 RID: 29222
	public class IMontageAssetT
	{
		// Token: 0x1700D5E6 RID: 54758
		// (get) Token: 0x06032D9E RID: 208286 RVA: 0x006DDAB3 File Offset: 0x006DBCB3
		// (set) Token: 0x06032D9F RID: 208287 RVA: 0x006DDABB File Offset: 0x006DBCBB
		public EMontageConfigType Type { get; set; }

		// Token: 0x1700D5E7 RID: 54759
		// (get) Token: 0x06032DA0 RID: 208288 RVA: 0x006DDAC4 File Offset: 0x006DBCC4
		// (set) Token: 0x06032DA1 RID: 208289 RVA: 0x006DDACC File Offset: 0x006DBCCC
		public string Asset { get; set; }

		// Token: 0x06032DA2 RID: 208290 RVA: 0x006DDAD5 File Offset: 0x006DBCD5
		public IMontageAssetT()
		{
			this.Type = EMontageConfigType.Asset;
			this.Asset = null;
		}
	}
}
