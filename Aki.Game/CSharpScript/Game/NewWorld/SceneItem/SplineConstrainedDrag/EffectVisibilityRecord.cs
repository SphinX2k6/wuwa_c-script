using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.NewWorld.SceneItem.SplineConstrainedDrag
{
	// Token: 0x020071A4 RID: 29092
	[NullableContext(2)]
	[Nullable(0)]
	[RequiredMember]
	public class EffectVisibilityRecord : IEffectVisibilityRecord
	{
		// Token: 0x17009DA1 RID: 40353
		// (get) Token: 0x06047305 RID: 291589 RVA: 0x012171C7 File Offset: 0x012153C7
		// (set) Token: 0x06047306 RID: 291590 RVA: 0x012171CF File Offset: 0x012153CF
		[Nullable(1)]
		[RequiredMember]
		public DragPlayEffectVisibilityProvider Provider { [NullableContext(1)] get; [NullableContext(1)] set; }

		// Token: 0x17009DA2 RID: 40354
		// (get) Token: 0x06047307 RID: 291591 RVA: 0x012171D8 File Offset: 0x012153D8
		// (set) Token: 0x06047308 RID: 291592 RVA: 0x012171E0 File Offset: 0x012153E0
		public IGuidePathVisibilityHost Attached { get; set; }

		// Token: 0x17009DA3 RID: 40355
		// (get) Token: 0x06047309 RID: 291593 RVA: 0x012171E9 File Offset: 0x012153E9
		// (set) Token: 0x0604730A RID: 291594 RVA: 0x012171F1 File Offset: 0x012153F1
		public Action CancelPending { get; set; }

		// Token: 0x0604730B RID: 291595 RVA: 0x012171FA File Offset: 0x012153FA
		[Obsolete("Constructors of types with required members are not supported in this version of your compiler.", true)]
		[CompilerFeatureRequired("RequiredMembers")]
		public EffectVisibilityRecord()
		{
		}
	}
}
