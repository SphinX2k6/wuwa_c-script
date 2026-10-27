using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Menu
{
	// Token: 0x020053FE RID: 21502
	[NullableContext(1)]
	public interface IChangeKeyMode
	{
		// Token: 0x1700841E RID: 33822
		// (get) Token: 0x06036F3D RID: 225085
		// (set) Token: 0x06036F3E RID: 225086
		string TitleName { get; set; }

		// Token: 0x1700841F RID: 33823
		// (get) Token: 0x06036F3F RID: 225087
		// (set) Token: 0x06036F40 RID: 225088
		int DefaultGroupIndex { get; set; }

		// Token: 0x17008420 RID: 33824
		// (get) Token: 0x06036F41 RID: 225089
		// (set) Token: 0x06036F42 RID: 225090
		IChangeKeyModeGroup[] ChangeKeyModeGroupList { get; set; }

		// Token: 0x17008421 RID: 33825
		// (get) Token: 0x06036F43 RID: 225091
		// (set) Token: 0x06036F44 RID: 225092
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
