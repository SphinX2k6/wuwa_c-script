using System;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x0200491E RID: 18718
	public class IFindSunSpiritGridBeginFloorT
	{
		// Token: 0x17008261 RID: 33377
		// (get) Token: 0x0601BC3B RID: 113723 RVA: 0x003ECD32 File Offset: 0x003EAF32
		// (set) Token: 0x0601BC3C RID: 113724 RVA: 0x003ECD3A File Offset: 0x003EAF3A
		public EFindSunSpiritGridType Type { get; set; }

		// Token: 0x0601BC3D RID: 113725 RVA: 0x003ECD43 File Offset: 0x003EAF43
		public IFindSunSpiritGridBeginFloorT()
		{
			this.Type = EFindSunSpiritGridType.Empty;
		}
	}
}
