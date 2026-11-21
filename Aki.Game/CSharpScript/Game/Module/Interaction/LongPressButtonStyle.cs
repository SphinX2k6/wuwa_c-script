using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Interaction
{
	// Token: 0x02004831 RID: 18481
	[NullableContext(1)]
	[Nullable(0)]
	[RequiredMember]
	public class LongPressButtonStyle : ILongPressButtonStyle
	{
		// Token: 0x17005E21 RID: 24097
		// (get) Token: 0x0602E72C RID: 190252 RVA: 0x00CF5DAF File Offset: 0x00CF3FAF
		// (set) Token: 0x0602E72D RID: 190253 RVA: 0x00CF5DB7 File Offset: 0x00CF3FB7
		[RequiredMember]
		public string ResourceId { get; set; }

		// Token: 0x17005E22 RID: 24098
		// (get) Token: 0x0602E72E RID: 190254 RVA: 0x00CF5DC0 File Offset: 0x00CF3FC0
		// (set) Token: 0x0602E72F RID: 190255 RVA: 0x00CF5DC8 File Offset: 0x00CF3FC8
		[RequiredMember]
		public Func<InteractionLongPressButton> Create { get; set; }

		// Token: 0x17005E23 RID: 24099
		// (get) Token: 0x0602E730 RID: 190256 RVA: 0x00CF5DD1 File Offset: 0x00CF3FD1
		// (set) Token: 0x0602E731 RID: 190257 RVA: 0x00CF5DD9 File Offset: 0x00CF3FD9
		[RequiredMember]
		public Func<ILongPressInteractRestriction> CreateRestriction { get; set; }

		// Token: 0x0602E732 RID: 190258 RVA: 0x00CF5DE2 File Offset: 0x00CF3FE2
		[Obsolete("Constructors of types with required members are not supported in this version of your compiler.", true)]
		[CompilerFeatureRequired("RequiredMembers")]
		public LongPressButtonStyle()
		{
		}
	}
}
