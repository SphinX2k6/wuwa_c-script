using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.NewWorld.SceneItem.SplineConstrainedDrag
{
	// Token: 0x020071AB RID: 29099
	[RequiredMember]
	public class SampleBufferEntry
	{
		// Token: 0x17009DAD RID: 40365
		// (get) Token: 0x0604734C RID: 291660 RVA: 0x01218A61 File Offset: 0x01216C61
		// (set) Token: 0x0604734D RID: 291661 RVA: 0x01218A69 File Offset: 0x01216C69
		[RequiredMember]
		public float Distance { get; set; }

		// Token: 0x17009DAE RID: 40366
		// (get) Token: 0x0604734E RID: 291662 RVA: 0x01218A72 File Offset: 0x01216C72
		// (set) Token: 0x0604734F RID: 291663 RVA: 0x01218A7A File Offset: 0x01216C7A
		[RequiredMember]
		public FVector2D ScreenPos { get; set; }

		// Token: 0x17009DAF RID: 40367
		// (get) Token: 0x06047350 RID: 291664 RVA: 0x01218A83 File Offset: 0x01216C83
		// (set) Token: 0x06047351 RID: 291665 RVA: 0x01218A8B File Offset: 0x01216C8B
		[RequiredMember]
		public bool Valid { get; set; }

		// Token: 0x06047352 RID: 291666 RVA: 0x01218A94 File Offset: 0x01216C94
		[Obsolete("Constructors of types with required members are not supported in this version of your compiler.", true)]
		[CompilerFeatureRequired("RequiredMembers")]
		public SampleBufferEntry()
		{
		}
	}
}
