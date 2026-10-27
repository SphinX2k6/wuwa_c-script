using System;
using Aki.UniverseEditor.Interface.Fbs.Common;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004098 RID: 16536
	public class IRecallFishingBoatT
	{
		// Token: 0x170074B3 RID: 29875
		// (get) Token: 0x06018131 RID: 98609 RVA: 0x00378B0A File Offset: 0x00376D0A
		// (set) Token: 0x06018132 RID: 98610 RVA: 0x00378B12 File Offset: 0x00376D12
		public EVehicleType Type { get; set; }

		// Token: 0x06018133 RID: 98611 RVA: 0x00378B1B File Offset: 0x00376D1B
		public IRecallFishingBoatT()
		{
			this.Type = EVehicleType.Gongduola;
		}
	}
}
