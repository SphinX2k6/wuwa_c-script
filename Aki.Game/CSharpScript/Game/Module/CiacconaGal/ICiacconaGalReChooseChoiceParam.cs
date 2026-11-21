using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.CiacconaGal
{
	// Token: 0x02004BBB RID: 19387
	[NullableContext(1)]
	public interface ICiacconaGalReChooseChoiceParam
	{
		// Token: 0x1700612D RID: 24877
		// (get) Token: 0x0603066A RID: 198250
		// (set) Token: 0x0603066B RID: 198251
		string Text { get; set; }

		// Token: 0x1700612E RID: 24878
		// (get) Token: 0x0603066C RID: 198252
		// (set) Token: 0x0603066D RID: 198253
		EToggleState TogState { get; set; }

		// Token: 0x1700612F RID: 24879
		// (get) Token: 0x0603066E RID: 198254
		// (set) Token: 0x0603066F RID: 198255
		string IconResId { get; set; }

		// Token: 0x17006130 RID: 24880
		// (get) Token: 0x06030670 RID: 198256
		// (set) Token: 0x06030671 RID: 198257
		Action OnClick { get; set; }
	}
}
