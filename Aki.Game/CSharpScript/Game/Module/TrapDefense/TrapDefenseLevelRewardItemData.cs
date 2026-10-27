using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.TrapDefense
{
	// Token: 0x02004A6B RID: 19051
	[NullableContext(1)]
	[Nullable(0)]
	public class TrapDefenseLevelRewardItemData : ITrapDefenseLevelRewardItemData
	{
		// Token: 0x17007AB3 RID: 31411
		// (get) Token: 0x06031655 RID: 202325 RVA: 0x00B72775 File Offset: 0x00B70975
		// (set) Token: 0x06031656 RID: 202326 RVA: 0x00B7277D File Offset: 0x00B7097D
		public ETrapDefenseLevelRewardItemType ItemType { get; set; }

		// Token: 0x17007AB4 RID: 31412
		// (get) Token: 0x06031657 RID: 202327 RVA: 0x00B72786 File Offset: 0x00B70986
		// (set) Token: 0x06031658 RID: 202328 RVA: 0x00B7278E File Offset: 0x00B7098E
		public string TypeNameKey { get; set; } = "";

		// Token: 0x17007AB5 RID: 31413
		// (get) Token: 0x06031659 RID: 202329 RVA: 0x00B72797 File Offset: 0x00B70997
		// (set) Token: 0x0603165A RID: 202330 RVA: 0x00B7279F File Offset: 0x00B7099F
		public TrapDefenseLevelData LevelData { get; set; }
	}
}
