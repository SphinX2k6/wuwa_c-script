using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Menu
{
	// Token: 0x020043E1 RID: 17377
	[NullableContext(1)]
	public interface IChangeKeyMode
	{
		// Token: 0x170057EA RID: 22506
		// (get) Token: 0x0602BE85 RID: 179845
		// (set) Token: 0x0602BE86 RID: 179846
		string TitleName { get; set; }

		// Token: 0x170057EB RID: 22507
		// (get) Token: 0x0602BE87 RID: 179847
		// (set) Token: 0x0602BE88 RID: 179848
		int DefaultGroupIndex { get; set; }

		// Token: 0x170057EC RID: 22508
		// (get) Token: 0x0602BE89 RID: 179849
		// (set) Token: 0x0602BE8A RID: 179850
		IChangeKeyModeGroup[] ChangeKeyModeGroupList { get; set; }

		// Token: 0x170057ED RID: 22509
		// (get) Token: 0x0602BE8B RID: 179851
		// (set) Token: 0x0602BE8C RID: 179852
		[Nullable(new byte[]
		{
			2,
			1
		})]
		Action<Dictionary<int, int>> OnConfirmCallback { [return: Nullable(new byte[]
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
