using System;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004C59 RID: 19545
	public class IMusicBeatsConditionBaseT
	{
		// Token: 0x17008E02 RID: 36354
		// (get) Token: 0x0601EFE3 RID: 126947 RVA: 0x00455A16 File Offset: 0x00453C16
		// (set) Token: 0x0601EFE4 RID: 126948 RVA: 0x00455A1E File Offset: 0x00453C1E
		public EMusicEventType Type { get; set; }

		// Token: 0x0601EFE5 RID: 126949 RVA: 0x00455A27 File Offset: 0x00453C27
		public IMusicBeatsConditionBaseT()
		{
			this.Type = EMusicEventType.HcMusicBattle;
		}
	}
}
