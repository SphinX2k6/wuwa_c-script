using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Menu
{
	// Token: 0x020053F5 RID: 21493
	[NullableContext(1)]
	[Nullable(0)]
	public class ChangeActionInfo : IChangeActionInfo
	{
		// Token: 0x17008407 RID: 33799
		// (get) Token: 0x06036F0B RID: 225035 RVA: 0x00D04DE1 File Offset: 0x00D02FE1
		// (set) Token: 0x06036F0C RID: 225036 RVA: 0x00D04DE9 File Offset: 0x00D02FE9
		public EInputControllerType InputControllerType { get; set; }

		// Token: 0x17008408 RID: 33800
		// (get) Token: 0x06036F0D RID: 225037 RVA: 0x00D04DF2 File Offset: 0x00D02FF2
		// (set) Token: 0x06036F0E RID: 225038 RVA: 0x00D04DFA File Offset: 0x00D02FFA
		public KeySettingRowData KeySettingRowData { get; set; }

		// Token: 0x17008409 RID: 33801
		// (get) Token: 0x06036F0F RID: 225039 RVA: 0x00D04E03 File Offset: 0x00D03003
		// (set) Token: 0x06036F10 RID: 225040 RVA: 0x00D04E0B File Offset: 0x00D0300B
		public Action<bool> OnConfirmCallback { get; set; }
	}
}
