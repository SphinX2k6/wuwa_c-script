using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006AEF RID: 27375
	public class IMontageAssetT
	{
		// Token: 0x1700CB17 RID: 51991
		// (get) Token: 0x0602FFCA RID: 196554 RVA: 0x006863FB File Offset: 0x006845FB
		// (set) Token: 0x0602FFCB RID: 196555 RVA: 0x00686403 File Offset: 0x00684603
		public EMontageConfigType Type { get; set; }

		// Token: 0x1700CB18 RID: 51992
		// (get) Token: 0x0602FFCC RID: 196556 RVA: 0x0068640C File Offset: 0x0068460C
		// (set) Token: 0x0602FFCD RID: 196557 RVA: 0x00686414 File Offset: 0x00684614
		public string Asset { get; set; }

		// Token: 0x0602FFCE RID: 196558 RVA: 0x0068641D File Offset: 0x0068461D
		public IMontageAssetT()
		{
			this.Type = EMontageConfigType.Asset;
			this.Asset = null;
		}
	}
}
