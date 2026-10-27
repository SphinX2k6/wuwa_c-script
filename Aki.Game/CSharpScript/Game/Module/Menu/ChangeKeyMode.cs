using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Menu
{
	// Token: 0x020053FF RID: 21503
	[NullableContext(1)]
	[Nullable(0)]
	public class ChangeKeyMode : IChangeKeyMode
	{
		// Token: 0x17008422 RID: 33826
		// (get) Token: 0x06036F45 RID: 225093 RVA: 0x00D04F21 File Offset: 0x00D03121
		// (set) Token: 0x06036F46 RID: 225094 RVA: 0x00D04F29 File Offset: 0x00D03129
		public string TitleName { get; set; } = "";

		// Token: 0x17008423 RID: 33827
		// (get) Token: 0x06036F47 RID: 225095 RVA: 0x00D04F32 File Offset: 0x00D03132
		// (set) Token: 0x06036F48 RID: 225096 RVA: 0x00D04F3A File Offset: 0x00D0313A
		public int DefaultGroupIndex { get; set; }

		// Token: 0x17008424 RID: 33828
		// (get) Token: 0x06036F49 RID: 225097 RVA: 0x00D04F43 File Offset: 0x00D03143
		// (set) Token: 0x06036F4A RID: 225098 RVA: 0x00D04F4B File Offset: 0x00D0314B
		public IChangeKeyModeGroup[] ChangeKeyModeGroupList { get; set; } = new IChangeKeyModeGroup[0];

		// Token: 0x17008425 RID: 33829
		// (get) Token: 0x06036F4B RID: 225099 RVA: 0x00D04F54 File Offset: 0x00D03154
		// (set) Token: 0x06036F4C RID: 225100 RVA: 0x00D04F5C File Offset: 0x00D0315C
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public Action<Dictionary<int, int>> OnConfirmCallback { [return: Nullable(new byte[]
		{
			2,
			1
		})] get; [param: Nullable(new byte[]
		{
			2,
			1
		})] set; }
	}
}
