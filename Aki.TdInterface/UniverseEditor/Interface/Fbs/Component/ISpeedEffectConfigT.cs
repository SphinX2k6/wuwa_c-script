using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005F88 RID: 24456
	public class ISpeedEffectConfigT
	{
		// Token: 0x1700B514 RID: 46356
		// (get) Token: 0x060291D7 RID: 168407 RVA: 0x0059D385 File Offset: 0x0059B585
		// (set) Token: 0x060291D8 RID: 168408 RVA: 0x0059D38D File Offset: 0x0059B58D
		public float MinVehicleSpeed { get; set; }

		// Token: 0x1700B515 RID: 46357
		// (get) Token: 0x060291D9 RID: 168409 RVA: 0x0059D396 File Offset: 0x0059B596
		// (set) Token: 0x060291DA RID: 168410 RVA: 0x0059D39E File Offset: 0x0059B59E
		public float MaxVehicleSpeed { get; set; }

		// Token: 0x1700B516 RID: 46358
		// (get) Token: 0x060291DB RID: 168411 RVA: 0x0059D3A7 File Offset: 0x0059B5A7
		// (set) Token: 0x060291DC RID: 168412 RVA: 0x0059D3AF File Offset: 0x0059B5AF
		public List<long> GameplayCueIds { get; set; }

		// Token: 0x060291DD RID: 168413 RVA: 0x0059D3B8 File Offset: 0x0059B5B8
		public ISpeedEffectConfigT()
		{
			this.MinVehicleSpeed = 0f;
			this.MaxVehicleSpeed = 0f;
			this.GameplayCueIds = null;
		}
	}
}
