using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007CF0 RID: 31984
	public class IVehicleControlTypeT
	{
		// Token: 0x1700EF62 RID: 61282
		// (get) Token: 0x06039B5A RID: 236378 RVA: 0x007C8F16 File Offset: 0x007C7116
		// (set) Token: 0x06039B5B RID: 236379 RVA: 0x007C8F1E File Offset: 0x007C711E
		public EVehicleControlType Type { get; set; }

		// Token: 0x06039B5C RID: 236380 RVA: 0x007C8F27 File Offset: 0x007C7127
		public IVehicleControlTypeT()
		{
			this.Type = EVehicleControlType.EnterPathMoving;
		}
	}
}
