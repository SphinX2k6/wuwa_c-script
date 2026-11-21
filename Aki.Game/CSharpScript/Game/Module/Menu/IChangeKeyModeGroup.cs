using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Menu
{
	// Token: 0x020043DF RID: 17375
	[NullableContext(1)]
	public interface IChangeKeyModeGroup
	{
		// Token: 0x170057E4 RID: 22500
		// (get) Token: 0x0602BE78 RID: 179832
		// (set) Token: 0x0602BE79 RID: 179833
		string GroupName { get; set; }

		// Token: 0x170057E5 RID: 22501
		// (get) Token: 0x0602BE7A RID: 179834
		// (set) Token: 0x0602BE7B RID: 179835
		int DefaultKeyModeRowIndex { get; set; }

		// Token: 0x170057E6 RID: 22502
		// (get) Token: 0x0602BE7C RID: 179836
		// (set) Token: 0x0602BE7D RID: 179837
		IChangeKeyModeRow[] ChangeKeyModeRowList { get; set; }
	}
}
