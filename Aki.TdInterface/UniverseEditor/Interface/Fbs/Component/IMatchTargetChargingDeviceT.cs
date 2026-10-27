using System;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005528 RID: 21800
	public class IMatchTargetChargingDeviceT
	{
		// Token: 0x1700A0F7 RID: 41207
		// (get) Token: 0x0602404B RID: 147531 RVA: 0x004FA333 File Offset: 0x004F8533
		// (set) Token: 0x0602404C RID: 147532 RVA: 0x004FA33B File Offset: 0x004F853B
		public EProgressBarControlType Type { get; set; }

		// Token: 0x1700A0F8 RID: 41208
		// (get) Token: 0x0602404D RID: 147533 RVA: 0x004FA344 File Offset: 0x004F8544
		// (set) Token: 0x0602404E RID: 147534 RVA: 0x004FA34C File Offset: 0x004F854C
		public int MaxValue { get; set; }

		// Token: 0x1700A0F9 RID: 41209
		// (get) Token: 0x0602404F RID: 147535 RVA: 0x004FA355 File Offset: 0x004F8555
		// (set) Token: 0x06024050 RID: 147536 RVA: 0x004FA35D File Offset: 0x004F855D
		public int InitValue { get; set; }

		// Token: 0x1700A0FA RID: 41210
		// (get) Token: 0x06024051 RID: 147537 RVA: 0x004FA366 File Offset: 0x004F8566
		// (set) Token: 0x06024052 RID: 147538 RVA: 0x004FA36E File Offset: 0x004F856E
		public int ProgressPerformanceAttribute { get; set; }

		// Token: 0x1700A0FB RID: 41211
		// (get) Token: 0x06024053 RID: 147539 RVA: 0x004FA377 File Offset: 0x004F8577
		// (set) Token: 0x06024054 RID: 147540 RVA: 0x004FA37F File Offset: 0x004F857F
		public IEntityMatchT Match { get; set; }

		// Token: 0x1700A0FC RID: 41212
		// (get) Token: 0x06024055 RID: 147541 RVA: 0x004FA388 File Offset: 0x004F8588
		// (set) Token: 0x06024056 RID: 147542 RVA: 0x004FA390 File Offset: 0x004F8590
		public int IncreaseSpeed { get; set; }

		// Token: 0x1700A0FD RID: 41213
		// (get) Token: 0x06024057 RID: 147543 RVA: 0x004FA399 File Offset: 0x004F8599
		// (set) Token: 0x06024058 RID: 147544 RVA: 0x004FA3A1 File Offset: 0x004F85A1
		public int DecreaseSpeed { get; set; }

		// Token: 0x1700A0FE RID: 41214
		// (get) Token: 0x06024059 RID: 147545 RVA: 0x004FA3AA File Offset: 0x004F85AA
		// (set) Token: 0x0602405A RID: 147546 RVA: 0x004FA3B2 File Offset: 0x004F85B2
		public bool RayCastCheck { get; set; }

		// Token: 0x1700A0FF RID: 41215
		// (get) Token: 0x0602405B RID: 147547 RVA: 0x004FA3BB File Offset: 0x004F85BB
		// (set) Token: 0x0602405C RID: 147548 RVA: 0x004FA3C3 File Offset: 0x004F85C3
		public IVectorInfoT RayCastCenter { get; set; }

		// Token: 0x1700A100 RID: 41216
		// (get) Token: 0x0602405D RID: 147549 RVA: 0x004FA3CC File Offset: 0x004F85CC
		// (set) Token: 0x0602405E RID: 147550 RVA: 0x004FA3D4 File Offset: 0x004F85D4
		public byte NullMask { get; set; }

		// Token: 0x0602405F RID: 147551 RVA: 0x004FA3E0 File Offset: 0x004F85E0
		public IMatchTargetChargingDeviceT()
		{
			this.Type = EProgressBarControlType.CaptureStrategicPoint;
			this.MaxValue = 0;
			this.InitValue = 0;
			this.ProgressPerformanceAttribute = 0;
			this.Match = null;
			this.IncreaseSpeed = 0;
			this.DecreaseSpeed = 0;
			this.RayCastCheck = false;
			this.RayCastCenter = null;
			this.NullMask = 0;
		}
	}
}
