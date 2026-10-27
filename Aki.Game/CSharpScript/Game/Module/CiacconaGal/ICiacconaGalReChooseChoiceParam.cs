using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.CiacconaGal
{
	// Token: 0x02005BDB RID: 23515
	[NullableContext(1)]
	public interface ICiacconaGalReChooseChoiceParam
	{
		// Token: 0x17008D5B RID: 36187
		// (get) Token: 0x0603B71F RID: 243487
		// (set) Token: 0x0603B720 RID: 243488
		string Text { get; set; }

		// Token: 0x17008D5C RID: 36188
		// (get) Token: 0x0603B721 RID: 243489
		// (set) Token: 0x0603B722 RID: 243490
		EToggleState TogState { get; set; }

		// Token: 0x17008D5D RID: 36189
		// (get) Token: 0x0603B723 RID: 243491
		// (set) Token: 0x0603B724 RID: 243492
		string IconResId { get; set; }

		// Token: 0x17008D5E RID: 36190
		// (get) Token: 0x0603B725 RID: 243493
		// (set) Token: 0x0603B726 RID: 243494
		Action OnClick { get; set; }
	}
}
