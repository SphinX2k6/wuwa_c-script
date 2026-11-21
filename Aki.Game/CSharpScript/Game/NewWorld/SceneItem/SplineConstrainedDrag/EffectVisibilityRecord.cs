using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.NewWorld.SceneItem.SplineConstrainedDrag
{
	// Token: 0x02006259 RID: 25177
	[NullableContext(2)]
	[Nullable(0)]
	[RequiredMember]
	public class EffectVisibilityRecord : IEffectVisibilityRecord
	{
		// Token: 0x170072EE RID: 29422
		// (get) Token: 0x0603CBFD RID: 248829 RVA: 0x0117112B File Offset: 0x0116F32B
		// (set) Token: 0x0603CBFE RID: 248830 RVA: 0x01171133 File Offset: 0x0116F333
		[Nullable(1)]
		[RequiredMember]
		public DragPlayEffectVisibilityProvider Provider { [NullableContext(1)] get; [NullableContext(1)] set; }

		// Token: 0x170072EF RID: 29423
		// (get) Token: 0x0603CBFF RID: 248831 RVA: 0x0117113C File Offset: 0x0116F33C
		// (set) Token: 0x0603CC00 RID: 248832 RVA: 0x01171144 File Offset: 0x0116F344
		public IGuidePathVisibilityHost Attached { get; set; }

		// Token: 0x170072F0 RID: 29424
		// (get) Token: 0x0603CC01 RID: 248833 RVA: 0x0117114D File Offset: 0x0116F34D
		// (set) Token: 0x0603CC02 RID: 248834 RVA: 0x01171155 File Offset: 0x0116F355
		public Action CancelPending { get; set; }

		// Token: 0x0603CC03 RID: 248835 RVA: 0x0117115E File Offset: 0x0116F35E
		[Obsolete("Constructors of types with required members are not supported in this version of your compiler.", true)]
		[CompilerFeatureRequired("RequiredMembers")]
		public EffectVisibilityRecord()
		{
		}
	}
}
