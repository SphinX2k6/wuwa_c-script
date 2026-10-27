using System;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004143 RID: 16707
	public class IStalkingGamePlayConfigT
	{
		// Token: 0x1700764D RID: 30285
		// (get) Token: 0x0601880E RID: 100366 RVA: 0x0038813E File Offset: 0x0038633E
		// (set) Token: 0x0601880F RID: 100367 RVA: 0x00388146 File Offset: 0x00386346
		public ESpecialGamePlayConfigType Type { get; set; }

		// Token: 0x06018810 RID: 100368 RVA: 0x0038814F File Offset: 0x0038634F
		public IStalkingGamePlayConfigT()
		{
			this.Type = ESpecialGamePlayConfigType.Stalking;
		}
	}
}
