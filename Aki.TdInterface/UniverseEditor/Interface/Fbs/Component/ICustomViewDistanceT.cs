using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005061 RID: 20577
	public class ICustomViewDistanceT
	{
		// Token: 0x1700954B RID: 38219
		// (get) Token: 0x06020FAB RID: 135083 RVA: 0x00495488 File Offset: 0x00493688
		// (set) Token: 0x06020FAC RID: 135084 RVA: 0x00495490 File Offset: 0x00493690
		public EViewDistanceType Type { get; set; }

		// Token: 0x1700954C RID: 38220
		// (get) Token: 0x06020FAD RID: 135085 RVA: 0x00495499 File Offset: 0x00493699
		// (set) Token: 0x06020FAE RID: 135086 RVA: 0x004954A1 File Offset: 0x004936A1
		public int Distance { get; set; }

		// Token: 0x06020FAF RID: 135087 RVA: 0x004954AA File Offset: 0x004936AA
		public ICustomViewDistanceT()
		{
			this.Type = EViewDistanceType.Low;
			this.Distance = 0;
		}
	}
}
