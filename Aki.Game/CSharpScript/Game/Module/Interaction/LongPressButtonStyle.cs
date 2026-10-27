using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Interaction
{
	// Token: 0x02005859 RID: 22617
	[NullableContext(1)]
	[Nullable(0)]
	[RequiredMember]
	public class LongPressButtonStyle : ILongPressButtonStyle
	{
		// Token: 0x17008A55 RID: 35413
		// (get) Token: 0x0603980F RID: 235535 RVA: 0x00DA7087 File Offset: 0x00DA5287
		// (set) Token: 0x06039810 RID: 235536 RVA: 0x00DA708F File Offset: 0x00DA528F
		[RequiredMember]
		public string ResourceId { get; set; }

		// Token: 0x17008A56 RID: 35414
		// (get) Token: 0x06039811 RID: 235537 RVA: 0x00DA7098 File Offset: 0x00DA5298
		// (set) Token: 0x06039812 RID: 235538 RVA: 0x00DA70A0 File Offset: 0x00DA52A0
		[RequiredMember]
		public Func<InteractionLongPressButton> Create { get; set; }

		// Token: 0x17008A57 RID: 35415
		// (get) Token: 0x06039813 RID: 235539 RVA: 0x00DA70A9 File Offset: 0x00DA52A9
		// (set) Token: 0x06039814 RID: 235540 RVA: 0x00DA70B1 File Offset: 0x00DA52B1
		[RequiredMember]
		public Func<ILongPressInteractRestriction> CreateRestriction { get; set; }

		// Token: 0x06039815 RID: 235541 RVA: 0x00DA70BA File Offset: 0x00DA52BA
		[Obsolete("Constructors of types with required members are not supported in this version of your compiler.", true)]
		[CompilerFeatureRequired("RequiredMembers")]
		public LongPressButtonStyle()
		{
		}
	}
}
