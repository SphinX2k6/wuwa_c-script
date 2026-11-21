using System;

namespace Aki.UniverseEditor.Interface.Fbs.Combat
{
	// Token: 0x02006528 RID: 25896
	public class IBuffConfigT
	{
		// Token: 0x1700BF12 RID: 48914
		// (get) Token: 0x0602C238 RID: 180792 RVA: 0x0060319B File Offset: 0x0060139B
		// (set) Token: 0x0602C239 RID: 180793 RVA: 0x006031A3 File Offset: 0x006013A3
		public int Id { get; set; }

		// Token: 0x1700BF13 RID: 48915
		// (get) Token: 0x0602C23A RID: 180794 RVA: 0x006031AC File Offset: 0x006013AC
		// (set) Token: 0x0602C23B RID: 180795 RVA: 0x006031B4 File Offset: 0x006013B4
		public string Name { get; set; }

		// Token: 0x0602C23C RID: 180796 RVA: 0x006031BD File Offset: 0x006013BD
		public IBuffConfigT()
		{
			this.Id = 0;
			this.Name = null;
		}
	}
}
