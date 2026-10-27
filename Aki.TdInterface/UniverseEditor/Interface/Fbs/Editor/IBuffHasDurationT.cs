using System;

namespace Aki.UniverseEditor.Interface.Fbs.Editor
{
	// Token: 0x02004836 RID: 18486
	public class IBuffHasDurationT
	{
		// Token: 0x170084A8 RID: 33960
		// (get) Token: 0x0601C937 RID: 117047 RVA: 0x0040A540 File Offset: 0x00408740
		// (set) Token: 0x0601C938 RID: 117048 RVA: 0x0040A548 File Offset: 0x00408748
		public EBuffDurationType Type { get; set; }

		// Token: 0x170084A9 RID: 33961
		// (get) Token: 0x0601C939 RID: 117049 RVA: 0x0040A551 File Offset: 0x00408751
		// (set) Token: 0x0601C93A RID: 117050 RVA: 0x0040A559 File Offset: 0x00408759
		public int Duration { get; set; }

		// Token: 0x0601C93B RID: 117051 RVA: 0x0040A562 File Offset: 0x00408762
		public IBuffHasDurationT()
		{
			this.Type = EBuffDurationType.Instant;
			this.Duration = 0;
		}
	}
}
