using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.WorldMap.SubViews.MapMarkToggle
{
	// Token: 0x02004804 RID: 18436
	[NullableContext(1)]
	public interface IMapMarkToggleItemData
	{
		// Token: 0x170078D3 RID: 30931
		// (get) Token: 0x06030466 RID: 197734
		// (set) Token: 0x06030467 RID: 197735
		string NameId { get; set; }

		// Token: 0x170078D4 RID: 30932
		// (get) Token: 0x06030468 RID: 197736
		// (set) Token: 0x06030469 RID: 197737
		Func<EToggleState> GetToggleResultCallback { get; set; }

		// Token: 0x170078D5 RID: 30933
		// (get) Token: 0x0603046A RID: 197738
		// (set) Token: 0x0603046B RID: 197739
		Func<EToggleState, bool> SetToggleStateCallback { get; set; }

		// Token: 0x170078D6 RID: 30934
		// (get) Token: 0x0603046C RID: 197740
		// (set) Token: 0x0603046D RID: 197741
		bool? ShowInRecallInstance { get; set; }
	}
}
