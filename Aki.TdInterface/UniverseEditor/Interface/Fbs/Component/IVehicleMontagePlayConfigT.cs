using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005B24 RID: 23332
	public class IVehicleMontagePlayConfigT
	{
		// Token: 0x1700B020 RID: 45088
		// (get) Token: 0x06027E0A RID: 163338 RVA: 0x0057C045 File Offset: 0x0057A245
		// (set) Token: 0x06027E0B RID: 163339 RVA: 0x0057C04D File Offset: 0x0057A24D
		public float MinMontageSpeedFactor { get; set; }

		// Token: 0x1700B021 RID: 45089
		// (get) Token: 0x06027E0C RID: 163340 RVA: 0x0057C056 File Offset: 0x0057A256
		// (set) Token: 0x06027E0D RID: 163341 RVA: 0x0057C05E File Offset: 0x0057A25E
		public float MaxMontageSpeedFactor { get; set; }

		// Token: 0x1700B022 RID: 45090
		// (get) Token: 0x06027E0E RID: 163342 RVA: 0x0057C067 File Offset: 0x0057A267
		// (set) Token: 0x06027E0F RID: 163343 RVA: 0x0057C06F File Offset: 0x0057A26F
		public float MinVehicleSpeed { get; set; }

		// Token: 0x1700B023 RID: 45091
		// (get) Token: 0x06027E10 RID: 163344 RVA: 0x0057C078 File Offset: 0x0057A278
		// (set) Token: 0x06027E11 RID: 163345 RVA: 0x0057C080 File Offset: 0x0057A280
		public float MaxVehicleSpeed { get; set; }

		// Token: 0x1700B024 RID: 45092
		// (get) Token: 0x06027E12 RID: 163346 RVA: 0x0057C089 File Offset: 0x0057A289
		// (set) Token: 0x06027E13 RID: 163347 RVA: 0x0057C091 File Offset: 0x0057A291
		public string TargetState { get; set; }

		// Token: 0x06027E14 RID: 163348 RVA: 0x0057C09A File Offset: 0x0057A29A
		public IVehicleMontagePlayConfigT()
		{
			this.MinMontageSpeedFactor = 0f;
			this.MaxMontageSpeedFactor = 0f;
			this.MinVehicleSpeed = 0f;
			this.MaxVehicleSpeed = 0f;
			this.TargetState = null;
		}
	}
}
