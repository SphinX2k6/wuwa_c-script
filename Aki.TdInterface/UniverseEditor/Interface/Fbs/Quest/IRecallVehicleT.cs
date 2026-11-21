using System;
using Aki.UniverseEditor.Interface.Fbs.Common;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020044DC RID: 17628
	public class IRecallVehicleT
	{
		// Token: 0x17007AB8 RID: 31416
		// (get) Token: 0x060197DC RID: 104412 RVA: 0x003A2ABA File Offset: 0x003A0CBA
		// (set) Token: 0x060197DD RID: 104413 RVA: 0x003A2AC2 File Offset: 0x003A0CC2
		public EVehicleType Type { get; set; }

		// Token: 0x060197DE RID: 104414 RVA: 0x003A2ACB File Offset: 0x003A0CCB
		public IRecallVehicleT()
		{
			this.Type = EVehicleType.Gongduola;
		}
	}
}
