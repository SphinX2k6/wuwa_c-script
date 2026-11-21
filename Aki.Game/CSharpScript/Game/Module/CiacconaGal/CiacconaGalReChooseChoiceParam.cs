using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.CiacconaGal
{
	// Token: 0x02004BBC RID: 19388
	[NullableContext(1)]
	[Nullable(0)]
	public class CiacconaGalReChooseChoiceParam : ICiacconaGalReChooseChoiceParam
	{
		// Token: 0x17006131 RID: 24881
		// (get) Token: 0x06030672 RID: 198258 RVA: 0x00D7D056 File Offset: 0x00D7B256
		// (set) Token: 0x06030673 RID: 198259 RVA: 0x00D7D05E File Offset: 0x00D7B25E
		public string Text { get; set; }

		// Token: 0x17006132 RID: 24882
		// (get) Token: 0x06030674 RID: 198260 RVA: 0x00D7D067 File Offset: 0x00D7B267
		// (set) Token: 0x06030675 RID: 198261 RVA: 0x00D7D06F File Offset: 0x00D7B26F
		public EToggleState TogState { get; set; }

		// Token: 0x17006133 RID: 24883
		// (get) Token: 0x06030676 RID: 198262 RVA: 0x00D7D078 File Offset: 0x00D7B278
		// (set) Token: 0x06030677 RID: 198263 RVA: 0x00D7D080 File Offset: 0x00D7B280
		public string IconResId { get; set; }

		// Token: 0x17006134 RID: 24884
		// (get) Token: 0x06030678 RID: 198264 RVA: 0x00D7D089 File Offset: 0x00D7B289
		// (set) Token: 0x06030679 RID: 198265 RVA: 0x00D7D091 File Offset: 0x00D7B291
		public Action OnClick { get; set; }
	}
}
