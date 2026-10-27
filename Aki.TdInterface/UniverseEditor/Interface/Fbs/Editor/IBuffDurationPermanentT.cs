using System;

namespace Aki.UniverseEditor.Interface.Fbs.Editor
{
	// Token: 0x02004833 RID: 18483
	public class IBuffDurationPermanentT
	{
		// Token: 0x170084A4 RID: 33956
		// (get) Token: 0x0601C923 RID: 117027 RVA: 0x0040A366 File Offset: 0x00408566
		// (set) Token: 0x0601C924 RID: 117028 RVA: 0x0040A36E File Offset: 0x0040856E
		public EBuffDurationType Type { get; set; }

		// Token: 0x0601C925 RID: 117029 RVA: 0x0040A377 File Offset: 0x00408577
		public IBuffDurationPermanentT()
		{
			this.Type = EBuffDurationType.Instant;
		}
	}
}
