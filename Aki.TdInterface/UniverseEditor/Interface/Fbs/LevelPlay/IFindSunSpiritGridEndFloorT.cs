using System;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x02004927 RID: 18727
	public class IFindSunSpiritGridEndFloorT
	{
		// Token: 0x17008271 RID: 33393
		// (get) Token: 0x0601BC8D RID: 113805 RVA: 0x003ED84A File Offset: 0x003EBA4A
		// (set) Token: 0x0601BC8E RID: 113806 RVA: 0x003ED852 File Offset: 0x003EBA52
		public EFindSunSpiritGridType Type { get; set; }

		// Token: 0x0601BC8F RID: 113807 RVA: 0x003ED85B File Offset: 0x003EBA5B
		public IFindSunSpiritGridEndFloorT()
		{
			this.Type = EFindSunSpiritGridType.Empty;
		}
	}
}
