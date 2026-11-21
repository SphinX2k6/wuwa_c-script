using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.RoleDev
{
	// Token: 0x02003C7F RID: 15487
	[NullableContext(1)]
	public interface IButtonState
	{
		// Token: 0x1700511D RID: 20765
		// (get) Token: 0x060279E5 RID: 162277
		// (set) Token: 0x060279E6 RID: 162278
		string Text { get; set; }

		// Token: 0x1700511E RID: 20766
		// (get) Token: 0x060279E7 RID: 162279
		// (set) Token: 0x060279E8 RID: 162280
		bool IsHighlight { get; set; }
	}
}
