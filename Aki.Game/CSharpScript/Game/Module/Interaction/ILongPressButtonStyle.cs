using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Interaction
{
	// Token: 0x02005858 RID: 22616
	[NullableContext(1)]
	public interface ILongPressButtonStyle
	{
		// Token: 0x17008A52 RID: 35410
		// (get) Token: 0x06039809 RID: 235529
		// (set) Token: 0x0603980A RID: 235530
		string ResourceId { get; set; }

		// Token: 0x17008A53 RID: 35411
		// (get) Token: 0x0603980B RID: 235531
		// (set) Token: 0x0603980C RID: 235532
		Func<InteractionLongPressButton> Create { get; set; }

		// Token: 0x17008A54 RID: 35412
		// (get) Token: 0x0603980D RID: 235533
		// (set) Token: 0x0603980E RID: 235534
		Func<ILongPressInteractRestriction> CreateRestriction { get; set; }
	}
}
