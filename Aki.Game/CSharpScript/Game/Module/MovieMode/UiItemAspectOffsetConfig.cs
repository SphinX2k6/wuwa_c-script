using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.MovieMode
{
	// Token: 0x02005386 RID: 21382
	[NullableContext(1)]
	[Nullable(0)]
	[RequiredMember]
	public class UiItemAspectOffsetConfig : IUiItemAspectOffsetConfig
	{
		// Token: 0x1700838D RID: 33677
		// (get) Token: 0x06036A10 RID: 223760 RVA: 0x00CEE834 File Offset: 0x00CECA34
		// (set) Token: 0x06036A11 RID: 223761 RVA: 0x00CEE83C File Offset: 0x00CECA3C
		[RequiredMember]
		public UUIItem UiItem { get; set; }

		// Token: 0x1700838E RID: 33678
		// (get) Token: 0x06036A12 RID: 223762 RVA: 0x00CEE845 File Offset: 0x00CECA45
		// (set) Token: 0x06036A13 RID: 223763 RVA: 0x00CEE84D File Offset: 0x00CECA4D
		[RequiredMember]
		public Vector2D OriginalOffset { get; set; }

		// Token: 0x1700838F RID: 33679
		// (get) Token: 0x06036A14 RID: 223764 RVA: 0x00CEE856 File Offset: 0x00CECA56
		// (set) Token: 0x06036A15 RID: 223765 RVA: 0x00CEE85E File Offset: 0x00CECA5E
		[RequiredMember]
		public float OffsetWidthDirection { get; set; }

		// Token: 0x17008390 RID: 33680
		// (get) Token: 0x06036A16 RID: 223766 RVA: 0x00CEE867 File Offset: 0x00CECA67
		// (set) Token: 0x06036A17 RID: 223767 RVA: 0x00CEE86F File Offset: 0x00CECA6F
		[RequiredMember]
		public float OffsetHeightDirection { get; set; }

		// Token: 0x06036A18 RID: 223768 RVA: 0x00CEE878 File Offset: 0x00CECA78
		[Obsolete("Constructors of types with required members are not supported in this version of your compiler.", true)]
		[CompilerFeatureRequired("RequiredMembers")]
		public UiItemAspectOffsetConfig()
		{
		}
	}
}
