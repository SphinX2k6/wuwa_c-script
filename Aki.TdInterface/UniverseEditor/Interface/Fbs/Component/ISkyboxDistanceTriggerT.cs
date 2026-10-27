using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200591E RID: 22814
	public class ISkyboxDistanceTriggerT
	{
		// Token: 0x1700AB22 RID: 43810
		// (get) Token: 0x06026944 RID: 158020 RVA: 0x00550608 File Offset: 0x0054E808
		// (set) Token: 0x06026945 RID: 158021 RVA: 0x00550610 File Offset: 0x0054E810
		public ETriggerMode Type { get; set; }

		// Token: 0x1700AB23 RID: 43811
		// (get) Token: 0x06026946 RID: 158022 RVA: 0x00550619 File Offset: 0x0054E819
		// (set) Token: 0x06026947 RID: 158023 RVA: 0x00550621 File Offset: 0x0054E821
		public float Distance { get; set; }

		// Token: 0x06026948 RID: 158024 RVA: 0x0055062A File Offset: 0x0054E82A
		public ISkyboxDistanceTriggerT()
		{
			this.Type = ETriggerMode.Distance;
			this.Distance = 0f;
		}
	}
}
