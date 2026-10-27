using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.WorldMap.SubViews.MapMarkToggle
{
	// Token: 0x02004807 RID: 18439
	[NullableContext(2)]
	[Nullable(0)]
	public class MapMarkToggleItemData : IMapMarkToggleItemData
	{
		// Token: 0x170078D7 RID: 30935
		// (get) Token: 0x06030482 RID: 197762 RVA: 0x00B32E28 File Offset: 0x00B31028
		// (set) Token: 0x06030483 RID: 197763 RVA: 0x00B32E30 File Offset: 0x00B31030
		[Nullable(1)]
		public string NameId { [NullableContext(1)] get; [NullableContext(1)] set; } = "";

		// Token: 0x170078D8 RID: 30936
		// (get) Token: 0x06030484 RID: 197764 RVA: 0x00B32E39 File Offset: 0x00B31039
		// (set) Token: 0x06030485 RID: 197765 RVA: 0x00B32E41 File Offset: 0x00B31041
		public Func<EToggleState> GetToggleResultCallback { get; set; }

		// Token: 0x170078D9 RID: 30937
		// (get) Token: 0x06030486 RID: 197766 RVA: 0x00B32E4A File Offset: 0x00B3104A
		// (set) Token: 0x06030487 RID: 197767 RVA: 0x00B32E52 File Offset: 0x00B31052
		public Func<EToggleState, bool> SetToggleStateCallback { get; set; }

		// Token: 0x170078DA RID: 30938
		// (get) Token: 0x06030488 RID: 197768 RVA: 0x00B32E5B File Offset: 0x00B3105B
		// (set) Token: 0x06030489 RID: 197769 RVA: 0x00B32E63 File Offset: 0x00B31063
		public bool? ShowInRecallInstance { get; set; }
	}
}
