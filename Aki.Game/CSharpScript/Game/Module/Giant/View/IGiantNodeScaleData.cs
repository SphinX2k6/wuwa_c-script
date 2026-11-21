using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Giant.View
{
	// Token: 0x0200495B RID: 18779
	[NullableContext(1)]
	public interface IGiantNodeScaleData
	{
		// Token: 0x17005F11 RID: 24337
		// (get) Token: 0x0602F176 RID: 192886
		// (set) Token: 0x0602F177 RID: 192887
		int NodeIndex { get; set; }

		// Token: 0x17005F12 RID: 24338
		// (get) Token: 0x0602F178 RID: 192888
		// (set) Token: 0x0602F179 RID: 192889
		int Value { get; set; }

		// Token: 0x17005F13 RID: 24339
		// (get) Token: 0x0602F17A RID: 192890
		// (set) Token: 0x0602F17B RID: 192891
		EGiantNodeScaleState State { get; set; }

		// Token: 0x17005F14 RID: 24340
		// (get) Token: 0x0602F17C RID: 192892
		// (set) Token: 0x0602F17D RID: 192893
		bool IsGot { get; set; }

		// Token: 0x17005F15 RID: 24341
		// (get) Token: 0x0602F17E RID: 192894
		// (set) Token: 0x0602F17F RID: 192895
		bool CanClaim { get; set; }

		// Token: 0x17005F16 RID: 24342
		// (get) Token: 0x0602F180 RID: 192896
		// (set) Token: 0x0602F181 RID: 192897
		bool ShowCurrentMark { get; set; }

		// Token: 0x17005F17 RID: 24343
		// (get) Token: 0x0602F182 RID: 192898
		// (set) Token: 0x0602F183 RID: 192899
		Action<int, bool, UUIItem> OnClick { get; set; }
	}
}
