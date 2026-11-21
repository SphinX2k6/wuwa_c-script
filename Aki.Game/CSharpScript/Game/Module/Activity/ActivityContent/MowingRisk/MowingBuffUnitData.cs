using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Activity.ActivityContent.MowingRisk
{
	// Token: 0x02005332 RID: 21298
	[NullableContext(1)]
	[Nullable(0)]
	public class MowingBuffUnitData : IMowingBuffUnitData
	{
		// Token: 0x170066E0 RID: 26336
		// (get) Token: 0x06035016 RID: 217110 RVA: 0x00ED24F2 File Offset: 0x00ED06F2
		// (set) Token: 0x06035017 RID: 217111 RVA: 0x00ED24FA File Offset: 0x00ED06FA
		public int Index { get; set; }

		// Token: 0x170066E1 RID: 26337
		// (get) Token: 0x06035018 RID: 217112 RVA: 0x00ED2503 File Offset: 0x00ED0703
		// (set) Token: 0x06035019 RID: 217113 RVA: 0x00ED250B File Offset: 0x00ED070B
		public int BuffId { get; set; }

		// Token: 0x170066E2 RID: 26338
		// (get) Token: 0x0603501A RID: 217114 RVA: 0x00ED2514 File Offset: 0x00ED0714
		// (set) Token: 0x0603501B RID: 217115 RVA: 0x00ED251C File Offset: 0x00ED071C
		public bool IsActive { get; set; }

		// Token: 0x170066E3 RID: 26339
		// (get) Token: 0x0603501C RID: 217116 RVA: 0x00ED2525 File Offset: 0x00ED0725
		// (set) Token: 0x0603501D RID: 217117 RVA: 0x00ED252D File Offset: 0x00ED072D
		public bool IsChosen { get; set; }

		// Token: 0x170066E4 RID: 26340
		// (get) Token: 0x0603501E RID: 217118 RVA: 0x00ED2536 File Offset: 0x00ED0736
		// (set) Token: 0x0603501F RID: 217119 RVA: 0x00ED253E File Offset: 0x00ED073E
		public string IconPath { get; set; }

		// Token: 0x170066E5 RID: 26341
		// (get) Token: 0x06035020 RID: 217120 RVA: 0x00ED2547 File Offset: 0x00ED0747
		// (set) Token: 0x06035021 RID: 217121 RVA: 0x00ED254F File Offset: 0x00ED074F
		public string NameTextId { get; set; }

		// Token: 0x170066E6 RID: 26342
		// (get) Token: 0x06035022 RID: 217122 RVA: 0x00ED2558 File Offset: 0x00ED0758
		// (set) Token: 0x06035023 RID: 217123 RVA: 0x00ED2560 File Offset: 0x00ED0760
		public int ThresholdCount { get; set; }
	}
}
