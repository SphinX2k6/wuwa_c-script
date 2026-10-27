using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.TrapDefense
{
	// Token: 0x02004A24 RID: 18980
	[NullableContext(1)]
	[Nullable(0)]
	public class TrapDefenseSelectBranchData : ITrapDefenseSelectBranchData
	{
		// Token: 0x17007A2B RID: 31275
		// (get) Token: 0x0603146A RID: 201834 RVA: 0x00B6D74D File Offset: 0x00B6B94D
		// (set) Token: 0x0603146B RID: 201835 RVA: 0x00B6D755 File Offset: 0x00B6B955
		public bool IsInDungeon { get; set; }

		// Token: 0x17007A2C RID: 31276
		// (get) Token: 0x0603146C RID: 201836 RVA: 0x00B6D75E File Offset: 0x00B6B95E
		// (set) Token: 0x0603146D RID: 201837 RVA: 0x00B6D766 File Offset: 0x00B6B966
		public TrapDefenseBuildingDevelopItemData Data { get; set; }
	}
}
