using System;
using Aki.UniverseEditor.Interface.Fbs.Common;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020044D9 RID: 17625
	public class IRecallFishingBoatT
	{
		// Token: 0x17007AB5 RID: 31413
		// (get) Token: 0x060197CA RID: 104394 RVA: 0x003A2942 File Offset: 0x003A0B42
		// (set) Token: 0x060197CB RID: 104395 RVA: 0x003A294A File Offset: 0x003A0B4A
		public EVehicleType Type { get; set; }

		// Token: 0x060197CC RID: 104396 RVA: 0x003A2953 File Offset: 0x003A0B53
		public IRecallFishingBoatT()
		{
			this.Type = EVehicleType.Gongduola;
		}
	}
}
