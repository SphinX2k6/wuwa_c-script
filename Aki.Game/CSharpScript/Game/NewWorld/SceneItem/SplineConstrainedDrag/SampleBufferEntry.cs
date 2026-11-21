using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.NewWorld.SceneItem.SplineConstrainedDrag
{
	// Token: 0x02006260 RID: 25184
	[RequiredMember]
	public class SampleBufferEntry
	{
		// Token: 0x170072FD RID: 29437
		// (get) Token: 0x0603CC47 RID: 248903 RVA: 0x01172965 File Offset: 0x01170B65
		// (set) Token: 0x0603CC48 RID: 248904 RVA: 0x0117296D File Offset: 0x01170B6D
		[RequiredMember]
		public float Distance { get; set; }

		// Token: 0x170072FE RID: 29438
		// (get) Token: 0x0603CC49 RID: 248905 RVA: 0x01172976 File Offset: 0x01170B76
		// (set) Token: 0x0603CC4A RID: 248906 RVA: 0x0117297E File Offset: 0x01170B7E
		[RequiredMember]
		public FVector2D ScreenPos { get; set; }

		// Token: 0x170072FF RID: 29439
		// (get) Token: 0x0603CC4B RID: 248907 RVA: 0x01172987 File Offset: 0x01170B87
		// (set) Token: 0x0603CC4C RID: 248908 RVA: 0x0117298F File Offset: 0x01170B8F
		[RequiredMember]
		public bool Valid { get; set; }

		// Token: 0x0603CC4D RID: 248909 RVA: 0x01172998 File Offset: 0x01170B98
		[Obsolete("Constructors of types with required members are not supported in this version of your compiler.", true)]
		[CompilerFeatureRequired("RequiredMembers")]
		public SampleBufferEntry()
		{
		}
	}
}
