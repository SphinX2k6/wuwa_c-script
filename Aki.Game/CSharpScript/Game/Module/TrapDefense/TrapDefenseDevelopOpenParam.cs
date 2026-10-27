using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.TrapDefense
{
	// Token: 0x02004A4D RID: 19021
	[NullableContext(2)]
	[Nullable(0)]
	public class TrapDefenseDevelopOpenParam : ITrapDefenseDevelopOpenParam
	{
		// Token: 0x17007A5B RID: 31323
		// (get) Token: 0x060315AE RID: 202158 RVA: 0x00B7239F File Offset: 0x00B7059F
		// (set) Token: 0x060315AF RID: 202159 RVA: 0x00B723A7 File Offset: 0x00B705A7
		public bool IsInDungeon { get; set; }

		// Token: 0x17007A5C RID: 31324
		// (get) Token: 0x060315B0 RID: 202160 RVA: 0x00B723B0 File Offset: 0x00B705B0
		// (set) Token: 0x060315B1 RID: 202161 RVA: 0x00B723B8 File Offset: 0x00B705B8
		public int SelectedIndex { get; set; }

		// Token: 0x17007A5D RID: 31325
		// (get) Token: 0x060315B2 RID: 202162 RVA: 0x00B723C1 File Offset: 0x00B705C1
		// (set) Token: 0x060315B3 RID: 202163 RVA: 0x00B723C9 File Offset: 0x00B705C9
		public TrapDefenseLevelData LevelData { get; set; }
	}
}
