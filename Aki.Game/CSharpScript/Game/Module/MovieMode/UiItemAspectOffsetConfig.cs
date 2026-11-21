using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.MovieMode
{
	// Token: 0x02004369 RID: 17257
	[NullableContext(1)]
	[Nullable(0)]
	[RequiredMember]
	public class UiItemAspectOffsetConfig : IUiItemAspectOffsetConfig
	{
		// Token: 0x17005759 RID: 22361
		// (get) Token: 0x0602B956 RID: 178518 RVA: 0x00C3D75C File Offset: 0x00C3B95C
		// (set) Token: 0x0602B957 RID: 178519 RVA: 0x00C3D764 File Offset: 0x00C3B964
		[RequiredMember]
		public UUIItem UiItem { get; set; }

		// Token: 0x1700575A RID: 22362
		// (get) Token: 0x0602B958 RID: 178520 RVA: 0x00C3D76D File Offset: 0x00C3B96D
		// (set) Token: 0x0602B959 RID: 178521 RVA: 0x00C3D775 File Offset: 0x00C3B975
		[RequiredMember]
		public Vector2D OriginalOffset { get; set; }

		// Token: 0x1700575B RID: 22363
		// (get) Token: 0x0602B95A RID: 178522 RVA: 0x00C3D77E File Offset: 0x00C3B97E
		// (set) Token: 0x0602B95B RID: 178523 RVA: 0x00C3D786 File Offset: 0x00C3B986
		[RequiredMember]
		public float OffsetWidthDirection { get; set; }

		// Token: 0x1700575C RID: 22364
		// (get) Token: 0x0602B95C RID: 178524 RVA: 0x00C3D78F File Offset: 0x00C3B98F
		// (set) Token: 0x0602B95D RID: 178525 RVA: 0x00C3D797 File Offset: 0x00C3B997
		[RequiredMember]
		public float OffsetHeightDirection { get; set; }

		// Token: 0x0602B95E RID: 178526 RVA: 0x00C3D7A0 File Offset: 0x00C3B9A0
		[Obsolete("Constructors of types with required members are not supported in this version of your compiler.", true)]
		[CompilerFeatureRequired("RequiredMembers")]
		public UiItemAspectOffsetConfig()
		{
		}
	}
}
