using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.WorldMap.SubViews.MapMarkToggle
{
	// Token: 0x02003738 RID: 14136
	[NullableContext(2)]
	[Nullable(0)]
	public class MapMarkToggleItemData : IMapMarkToggleItemData
	{
		// Token: 0x17004B94 RID: 19348
		// (get) Token: 0x06024C52 RID: 150610 RVA: 0x00A62D8C File Offset: 0x00A60F8C
		// (set) Token: 0x06024C53 RID: 150611 RVA: 0x00A62D94 File Offset: 0x00A60F94
		[Nullable(1)]
		public string NameId { [NullableContext(1)] get; [NullableContext(1)] set; } = "";

		// Token: 0x17004B95 RID: 19349
		// (get) Token: 0x06024C54 RID: 150612 RVA: 0x00A62D9D File Offset: 0x00A60F9D
		// (set) Token: 0x06024C55 RID: 150613 RVA: 0x00A62DA5 File Offset: 0x00A60FA5
		public Func<EToggleState> GetToggleResultCallback { get; set; }

		// Token: 0x17004B96 RID: 19350
		// (get) Token: 0x06024C56 RID: 150614 RVA: 0x00A62DAE File Offset: 0x00A60FAE
		// (set) Token: 0x06024C57 RID: 150615 RVA: 0x00A62DB6 File Offset: 0x00A60FB6
		public Func<EToggleState, bool> SetToggleStateCallback { get; set; }

		// Token: 0x17004B97 RID: 19351
		// (get) Token: 0x06024C58 RID: 150616 RVA: 0x00A62DBF File Offset: 0x00A60FBF
		// (set) Token: 0x06024C59 RID: 150617 RVA: 0x00A62DC7 File Offset: 0x00A60FC7
		public bool? ShowInRecallInstance { get; set; }
	}
}
