using System;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x0200492A RID: 18730
	public class IFindSunSpiritGridMutableFloorT
	{
		// Token: 0x17008277 RID: 33399
		// (get) Token: 0x0601BCA5 RID: 113829 RVA: 0x003EDAE8 File Offset: 0x003EBCE8
		// (set) Token: 0x0601BCA6 RID: 113830 RVA: 0x003EDAF0 File Offset: 0x003EBCF0
		public EFindSunSpiritGridType Type { get; set; }

		// Token: 0x17008278 RID: 33400
		// (get) Token: 0x0601BCA7 RID: 113831 RVA: 0x003EDAF9 File Offset: 0x003EBCF9
		// (set) Token: 0x0601BCA8 RID: 113832 RVA: 0x003EDB01 File Offset: 0x003EBD01
		public EFindSunSpiritGridState State { get; set; }

		// Token: 0x17008279 RID: 33401
		// (get) Token: 0x0601BCA9 RID: 113833 RVA: 0x003EDB0A File Offset: 0x003EBD0A
		// (set) Token: 0x0601BCAA RID: 113834 RVA: 0x003EDB12 File Offset: 0x003EBD12
		public bool SpreadDevice { get; set; }

		// Token: 0x1700827A RID: 33402
		// (get) Token: 0x0601BCAB RID: 113835 RVA: 0x003EDB1B File Offset: 0x003EBD1B
		// (set) Token: 0x0601BCAC RID: 113836 RVA: 0x003EDB23 File Offset: 0x003EBD23
		public byte NullMask { get; set; }

		// Token: 0x0601BCAD RID: 113837 RVA: 0x003EDB2C File Offset: 0x003EBD2C
		public IFindSunSpiritGridMutableFloorT()
		{
			this.Type = EFindSunSpiritGridType.Empty;
			this.State = EFindSunSpiritGridState.Virtual;
			this.SpreadDevice = false;
			this.NullMask = 0;
		}
	}
}
