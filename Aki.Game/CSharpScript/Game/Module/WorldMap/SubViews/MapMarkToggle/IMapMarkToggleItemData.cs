using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.WorldMap.SubViews.MapMarkToggle
{
	// Token: 0x02003735 RID: 14133
	[NullableContext(1)]
	public interface IMapMarkToggleItemData
	{
		// Token: 0x17004B90 RID: 19344
		// (get) Token: 0x06024C36 RID: 150582
		// (set) Token: 0x06024C37 RID: 150583
		string NameId { get; set; }

		// Token: 0x17004B91 RID: 19345
		// (get) Token: 0x06024C38 RID: 150584
		// (set) Token: 0x06024C39 RID: 150585
		Func<EToggleState> GetToggleResultCallback { get; set; }

		// Token: 0x17004B92 RID: 19346
		// (get) Token: 0x06024C3A RID: 150586
		// (set) Token: 0x06024C3B RID: 150587
		Func<EToggleState, bool> SetToggleStateCallback { get; set; }

		// Token: 0x17004B93 RID: 19347
		// (get) Token: 0x06024C3C RID: 150588
		// (set) Token: 0x06024C3D RID: 150589
		bool? ShowInRecallInstance { get; set; }
	}
}
