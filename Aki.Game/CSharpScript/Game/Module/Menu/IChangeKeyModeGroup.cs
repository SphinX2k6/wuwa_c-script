using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Menu
{
	// Token: 0x020053FC RID: 21500
	[NullableContext(1)]
	public interface IChangeKeyModeGroup
	{
		// Token: 0x17008418 RID: 33816
		// (get) Token: 0x06036F30 RID: 225072
		// (set) Token: 0x06036F31 RID: 225073
		string GroupName { get; set; }

		// Token: 0x17008419 RID: 33817
		// (get) Token: 0x06036F32 RID: 225074
		// (set) Token: 0x06036F33 RID: 225075
		int DefaultKeyModeRowIndex { get; set; }

		// Token: 0x1700841A RID: 33818
		// (get) Token: 0x06036F34 RID: 225076
		// (set) Token: 0x06036F35 RID: 225077
		IChangeKeyModeRow[] ChangeKeyModeRowList { get; set; }
	}
}
