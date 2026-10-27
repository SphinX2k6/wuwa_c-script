using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Tetris
{
	// Token: 0x02005FE1 RID: 24545
	[NullableContext(1)]
	[Nullable(0)]
	public class ComboData : IComboData
	{
		// Token: 0x1700903E RID: 36926
		// (get) Token: 0x0603E2F8 RID: 254712 RVA: 0x00F02CEB File Offset: 0x00F00EEB
		// (set) Token: 0x0603E2F9 RID: 254713 RVA: 0x00F02CF3 File Offset: 0x00F00EF3
		public int ClearedLines { get; set; }

		// Token: 0x1700903F RID: 36927
		// (get) Token: 0x0603E2FA RID: 254714 RVA: 0x00F02CFC File Offset: 0x00F00EFC
		// (set) Token: 0x0603E2FB RID: 254715 RVA: 0x00F02D04 File Offset: 0x00F00F04
		public bool IsBoardEmpty { get; set; }

		// Token: 0x17009040 RID: 36928
		// (get) Token: 0x0603E2FC RID: 254716 RVA: 0x00F02D0D File Offset: 0x00F00F0D
		// (set) Token: 0x0603E2FD RID: 254717 RVA: 0x00F02D15 File Offset: 0x00F00F15
		public int ComboCount { get; set; }

		// Token: 0x17009041 RID: 36929
		// (get) Token: 0x0603E2FE RID: 254718 RVA: 0x00F02D1E File Offset: 0x00F00F1E
		// (set) Token: 0x0603E2FF RID: 254719 RVA: 0x00F02D26 File Offset: 0x00F00F26
		public int Score { get; set; }

		// Token: 0x17009042 RID: 36930
		// (get) Token: 0x0603E300 RID: 254720 RVA: 0x00F02D2F File Offset: 0x00F00F2F
		// (set) Token: 0x0603E301 RID: 254721 RVA: 0x00F02D37 File Offset: 0x00F00F37
		public List<ITetrisGemGetData> GemList { get; set; }

		// Token: 0x17009043 RID: 36931
		// (get) Token: 0x0603E302 RID: 254722 RVA: 0x00F02D40 File Offset: 0x00F00F40
		// (set) Token: 0x0603E303 RID: 254723 RVA: 0x00F02D48 File Offset: 0x00F00F48
		public List<int> ClearedRows { get; set; }

		// Token: 0x17009044 RID: 36932
		// (get) Token: 0x0603E304 RID: 254724 RVA: 0x00F02D51 File Offset: 0x00F00F51
		// (set) Token: 0x0603E305 RID: 254725 RVA: 0x00F02D59 File Offset: 0x00F00F59
		public List<int> ClearedCols { get; set; }

		// Token: 0x17009045 RID: 36933
		// (get) Token: 0x0603E306 RID: 254726 RVA: 0x00F02D62 File Offset: 0x00F00F62
		// (set) Token: 0x0603E307 RID: 254727 RVA: 0x00F02D6A File Offset: 0x00F00F6A
		public EGameMode GameMode { get; set; }
	}
}
