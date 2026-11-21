using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.TrapDefense
{
	// Token: 0x020039F5 RID: 14837
	[NullableContext(2)]
	[Nullable(0)]
	public class TrapDefenseDevelopOpenParam : ITrapDefenseDevelopOpenParam
	{
		// Token: 0x17004E08 RID: 19976
		// (get) Token: 0x0602633E RID: 156478 RVA: 0x00AB6323 File Offset: 0x00AB4523
		// (set) Token: 0x0602633F RID: 156479 RVA: 0x00AB632B File Offset: 0x00AB452B
		public bool IsInDungeon { get; set; }

		// Token: 0x17004E09 RID: 19977
		// (get) Token: 0x06026340 RID: 156480 RVA: 0x00AB6334 File Offset: 0x00AB4534
		// (set) Token: 0x06026341 RID: 156481 RVA: 0x00AB633C File Offset: 0x00AB453C
		public int SelectedIndex { get; set; }

		// Token: 0x17004E0A RID: 19978
		// (get) Token: 0x06026342 RID: 156482 RVA: 0x00AB6345 File Offset: 0x00AB4545
		// (set) Token: 0x06026343 RID: 156483 RVA: 0x00AB634D File Offset: 0x00AB454D
		public TrapDefenseLevelData LevelData { get; set; }
	}
}
