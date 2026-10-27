using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Giant.View
{
	// Token: 0x02005982 RID: 22914
	[NullableContext(1)]
	public interface IGiantNodeScaleData
	{
		// Token: 0x17008B44 RID: 35652
		// (get) Token: 0x0603A250 RID: 238160
		// (set) Token: 0x0603A251 RID: 238161
		int NodeIndex { get; set; }

		// Token: 0x17008B45 RID: 35653
		// (get) Token: 0x0603A252 RID: 238162
		// (set) Token: 0x0603A253 RID: 238163
		int Value { get; set; }

		// Token: 0x17008B46 RID: 35654
		// (get) Token: 0x0603A254 RID: 238164
		// (set) Token: 0x0603A255 RID: 238165
		EGiantNodeScaleState State { get; set; }

		// Token: 0x17008B47 RID: 35655
		// (get) Token: 0x0603A256 RID: 238166
		// (set) Token: 0x0603A257 RID: 238167
		bool IsGot { get; set; }

		// Token: 0x17008B48 RID: 35656
		// (get) Token: 0x0603A258 RID: 238168
		// (set) Token: 0x0603A259 RID: 238169
		bool CanClaim { get; set; }

		// Token: 0x17008B49 RID: 35657
		// (get) Token: 0x0603A25A RID: 238170
		// (set) Token: 0x0603A25B RID: 238171
		bool ShowCurrentMark { get; set; }

		// Token: 0x17008B4A RID: 35658
		// (get) Token: 0x0603A25C RID: 238172
		// (set) Token: 0x0603A25D RID: 238173
		Action<int, bool, UUIItem> OnClick { get; set; }
	}
}
