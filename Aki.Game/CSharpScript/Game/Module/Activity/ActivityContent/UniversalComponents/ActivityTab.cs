using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Activity.ActivityContent.UniversalComponents
{
	// Token: 0x02005F7D RID: 24445
	[NullableContext(1)]
	[Nullable(0)]
	public class ActivityTab : IActivityTab
	{
		// Token: 0x17008FDA RID: 36826
		// (get) Token: 0x0603E0A4 RID: 254116 RVA: 0x00EFAB10 File Offset: 0x00EF8D10
		// (set) Token: 0x0603E0A5 RID: 254117 RVA: 0x00EFAB18 File Offset: 0x00EF8D18
		public IActivityRewardDataPage TabData { get; set; }

		// Token: 0x17008FDB RID: 36827
		// (get) Token: 0x0603E0A6 RID: 254118 RVA: 0x00EFAB21 File Offset: 0x00EF8D21
		// (set) Token: 0x0603E0A7 RID: 254119 RVA: 0x00EFAB29 File Offset: 0x00EF8D29
		public Action<int> TabFunction { get; set; }

		// Token: 0x17008FDC RID: 36828
		// (get) Token: 0x0603E0A8 RID: 254120 RVA: 0x00EFAB32 File Offset: 0x00EF8D32
		// (set) Token: 0x0603E0A9 RID: 254121 RVA: 0x00EFAB3A File Offset: 0x00EF8D3A
		public Func<bool, int, bool> TabCanExecuteFunction { get; set; }
	}
}
