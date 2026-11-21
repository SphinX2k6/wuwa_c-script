using System;

namespace CSharpScript.Game.Module.Activity.ActivityContent.DropCatch.Item
{
	// Token: 0x0200562C RID: 22060
	public class DropCatchLevelItemData : IDropCatchLevelItemData
	{
		// Token: 0x17006987 RID: 27015
		// (get) Token: 0x06036874 RID: 223348 RVA: 0x00F37F54 File Offset: 0x00F36154
		// (set) Token: 0x06036875 RID: 223349 RVA: 0x00F37F5C File Offset: 0x00F3615C
		public int CfgId { get; set; }

		// Token: 0x17006988 RID: 27016
		// (get) Token: 0x06036876 RID: 223350 RVA: 0x00F37F65 File Offset: 0x00F36165
		// (set) Token: 0x06036877 RID: 223351 RVA: 0x00F37F6D File Offset: 0x00F3616D
		public EDropCatchLevelState? State { get; set; }

		// Token: 0x17006989 RID: 27017
		// (get) Token: 0x06036878 RID: 223352 RVA: 0x00F37F76 File Offset: 0x00F36176
		// (set) Token: 0x06036879 RID: 223353 RVA: 0x00F37F7E File Offset: 0x00F3617E
		public bool HasRedPoint { get; set; }
	}
}
