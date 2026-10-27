using System;
using Aki.UniverseEditor.Interface.Fbs.Common;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x0200409B RID: 16539
	public class IRecallVehicleT
	{
		// Token: 0x170074B6 RID: 29878
		// (get) Token: 0x06018143 RID: 98627 RVA: 0x00378C82 File Offset: 0x00376E82
		// (set) Token: 0x06018144 RID: 98628 RVA: 0x00378C8A File Offset: 0x00376E8A
		public EVehicleType Type { get; set; }

		// Token: 0x06018145 RID: 98629 RVA: 0x00378C93 File Offset: 0x00376E93
		public IRecallVehicleT()
		{
			this.Type = EVehicleType.Gongduola;
		}
	}
}
