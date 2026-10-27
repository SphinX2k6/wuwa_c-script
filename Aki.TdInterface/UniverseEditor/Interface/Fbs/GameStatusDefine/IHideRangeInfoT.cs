using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.GameStatusDefine
{
	// Token: 0x020046F8 RID: 18168
	public class IHideRangeInfoT
	{
		// Token: 0x170081E5 RID: 33253
		// (get) Token: 0x0601BD23 RID: 113955 RVA: 0x003F17E1 File Offset: 0x003EF9E1
		// (set) Token: 0x0601BD24 RID: 113956 RVA: 0x003F17E9 File Offset: 0x003EF9E9
		public string Path { get; set; }

		// Token: 0x170081E6 RID: 33254
		// (get) Token: 0x0601BD25 RID: 113957 RVA: 0x003F17F2 File Offset: 0x003EF9F2
		// (set) Token: 0x0601BD26 RID: 113958 RVA: 0x003F17FA File Offset: 0x003EF9FA
		public List<int> HideRangeEntities { get; set; }

		// Token: 0x170081E7 RID: 33255
		// (get) Token: 0x0601BD27 RID: 113959 RVA: 0x003F1803 File Offset: 0x003EFA03
		// (set) Token: 0x0601BD28 RID: 113960 RVA: 0x003F180B File Offset: 0x003EFA0B
		public List<int> HideRangeLevelPlay { get; set; }

		// Token: 0x170081E8 RID: 33256
		// (get) Token: 0x0601BD29 RID: 113961 RVA: 0x003F1814 File Offset: 0x003EFA14
		// (set) Token: 0x0601BD2A RID: 113962 RVA: 0x003F181C File Offset: 0x003EFA1C
		public List<int> ShowRangeEntities { get; set; }

		// Token: 0x170081E9 RID: 33257
		// (get) Token: 0x0601BD2B RID: 113963 RVA: 0x003F1825 File Offset: 0x003EFA25
		// (set) Token: 0x0601BD2C RID: 113964 RVA: 0x003F182D File Offset: 0x003EFA2D
		public List<int> ShowRangeLevelPlay { get; set; }

		// Token: 0x0601BD2D RID: 113965 RVA: 0x003F1836 File Offset: 0x003EFA36
		public IHideRangeInfoT()
		{
			this.Path = null;
			this.HideRangeEntities = null;
			this.HideRangeLevelPlay = null;
			this.ShowRangeEntities = null;
			this.ShowRangeLevelPlay = null;
		}
	}
}
