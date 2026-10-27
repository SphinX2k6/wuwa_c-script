using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005100 RID: 20736
	public class IDynamicSpawnMonsterPointComponentT
	{
		// Token: 0x17009714 RID: 38676
		// (get) Token: 0x0602167E RID: 136830 RVA: 0x004A3992 File Offset: 0x004A1B92
		// (set) Token: 0x0602167F RID: 136831 RVA: 0x004A399A File Offset: 0x004A1B9A
		public bool Disabled { get; set; }

		// Token: 0x17009715 RID: 38677
		// (get) Token: 0x06021680 RID: 136832 RVA: 0x004A39A3 File Offset: 0x004A1BA3
		// (set) Token: 0x06021681 RID: 136833 RVA: 0x004A39AB File Offset: 0x004A1BAB
		public int TagId { get; set; }

		// Token: 0x17009716 RID: 38678
		// (get) Token: 0x06021682 RID: 136834 RVA: 0x004A39B4 File Offset: 0x004A1BB4
		// (set) Token: 0x06021683 RID: 136835 RVA: 0x004A39BC File Offset: 0x004A1BBC
		public byte NullMask { get; set; }

		// Token: 0x06021684 RID: 136836 RVA: 0x004A39C5 File Offset: 0x004A1BC5
		public IDynamicSpawnMonsterPointComponentT()
		{
			this.Disabled = false;
			this.TagId = 0;
			this.NullMask = 0;
		}
	}
}
