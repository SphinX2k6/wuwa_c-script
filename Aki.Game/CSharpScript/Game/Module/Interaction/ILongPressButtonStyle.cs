using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Interaction
{
	// Token: 0x02004830 RID: 18480
	[NullableContext(1)]
	public interface ILongPressButtonStyle
	{
		// Token: 0x17005E1E RID: 24094
		// (get) Token: 0x0602E726 RID: 190246
		// (set) Token: 0x0602E727 RID: 190247
		string ResourceId { get; set; }

		// Token: 0x17005E1F RID: 24095
		// (get) Token: 0x0602E728 RID: 190248
		// (set) Token: 0x0602E729 RID: 190249
		Func<InteractionLongPressButton> Create { get; set; }

		// Token: 0x17005E20 RID: 24096
		// (get) Token: 0x0602E72A RID: 190250
		// (set) Token: 0x0602E72B RID: 190251
		Func<ILongPressInteractRestriction> CreateRestriction { get; set; }
	}
}
