using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007CF6 RID: 31990
	public class IVehicleCruisingParamsT
	{
		// Token: 0x1700EF6A RID: 61290
		// (get) Token: 0x06039B80 RID: 236416 RVA: 0x007C9314 File Offset: 0x007C7514
		// (set) Token: 0x06039B81 RID: 236417 RVA: 0x007C931C File Offset: 0x007C751C
		public float ForwardSpeed { get; set; }

		// Token: 0x1700EF6B RID: 61291
		// (get) Token: 0x06039B82 RID: 236418 RVA: 0x007C9325 File Offset: 0x007C7525
		// (set) Token: 0x06039B83 RID: 236419 RVA: 0x007C932D File Offset: 0x007C752D
		public float ForwardAcceleration { get; set; }

		// Token: 0x1700EF6C RID: 61292
		// (get) Token: 0x06039B84 RID: 236420 RVA: 0x007C9336 File Offset: 0x007C7536
		// (set) Token: 0x06039B85 RID: 236421 RVA: 0x007C933E File Offset: 0x007C753E
		public bool DisableSprint { get; set; }

		// Token: 0x1700EF6D RID: 61293
		// (get) Token: 0x06039B86 RID: 236422 RVA: 0x007C9347 File Offset: 0x007C7547
		// (set) Token: 0x06039B87 RID: 236423 RVA: 0x007C934F File Offset: 0x007C754F
		public byte NullMask { get; set; }

		// Token: 0x06039B88 RID: 236424 RVA: 0x007C9358 File Offset: 0x007C7558
		public IVehicleCruisingParamsT()
		{
			this.ForwardSpeed = 0f;
			this.ForwardAcceleration = 0f;
			this.DisableSprint = false;
			this.NullMask = 0;
		}
	}
}
