using System;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004587 RID: 17799
	public class IStalkingGamePlayConfigT
	{
		// Token: 0x17007C5C RID: 31836
		// (get) Token: 0x06019ED6 RID: 106198 RVA: 0x003B26FA File Offset: 0x003B08FA
		// (set) Token: 0x06019ED7 RID: 106199 RVA: 0x003B2702 File Offset: 0x003B0902
		public ESpecialGamePlayConfigType Type { get; set; }

		// Token: 0x06019ED8 RID: 106200 RVA: 0x003B270B File Offset: 0x003B090B
		public IStalkingGamePlayConfigT()
		{
			this.Type = ESpecialGamePlayConfigType.Stalking;
		}
	}
}
