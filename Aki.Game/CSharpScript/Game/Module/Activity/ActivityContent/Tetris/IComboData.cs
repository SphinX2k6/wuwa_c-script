using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Tetris
{
	// Token: 0x02005FE0 RID: 24544
	[NullableContext(1)]
	public interface IComboData
	{
		// Token: 0x17009036 RID: 36918
		// (get) Token: 0x0603E2E8 RID: 254696
		// (set) Token: 0x0603E2E9 RID: 254697
		int ClearedLines { get; set; }

		// Token: 0x17009037 RID: 36919
		// (get) Token: 0x0603E2EA RID: 254698
		// (set) Token: 0x0603E2EB RID: 254699
		bool IsBoardEmpty { get; set; }

		// Token: 0x17009038 RID: 36920
		// (get) Token: 0x0603E2EC RID: 254700
		// (set) Token: 0x0603E2ED RID: 254701
		int ComboCount { get; set; }

		// Token: 0x17009039 RID: 36921
		// (get) Token: 0x0603E2EE RID: 254702
		// (set) Token: 0x0603E2EF RID: 254703
		int Score { get; set; }

		// Token: 0x1700903A RID: 36922
		// (get) Token: 0x0603E2F0 RID: 254704
		// (set) Token: 0x0603E2F1 RID: 254705
		List<ITetrisGemGetData> GemList { get; set; }

		// Token: 0x1700903B RID: 36923
		// (get) Token: 0x0603E2F2 RID: 254706
		// (set) Token: 0x0603E2F3 RID: 254707
		List<int> ClearedRows { get; set; }

		// Token: 0x1700903C RID: 36924
		// (get) Token: 0x0603E2F4 RID: 254708
		// (set) Token: 0x0603E2F5 RID: 254709
		List<int> ClearedCols { get; set; }

		// Token: 0x1700903D RID: 36925
		// (get) Token: 0x0603E2F6 RID: 254710
		// (set) Token: 0x0603E2F7 RID: 254711
		EGameMode GameMode { get; set; }
	}
}
