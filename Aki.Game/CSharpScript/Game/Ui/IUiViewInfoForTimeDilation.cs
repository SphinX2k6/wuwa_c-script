using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Ui
{
	// Token: 0x0200463B RID: 17979
	[NullableContext(1)]
	public interface IUiViewInfoForTimeDilation
	{
		// Token: 0x170075E9 RID: 30185
		// (get) Token: 0x0602E5C3 RID: 189891
		// (set) Token: 0x0602E5C4 RID: 189892
		float TimeDilation { get; set; }

		// Token: 0x170075EA RID: 30186
		// (get) Token: 0x0602E5C5 RID: 189893
		// (set) Token: 0x0602E5C6 RID: 189894
		int ViewId { get; set; }

		// Token: 0x170075EB RID: 30187
		// (get) Token: 0x0602E5C7 RID: 189895
		// (set) Token: 0x0602E5C8 RID: 189896
		EUiViewName? DebugName { get; set; }

		// Token: 0x170075EC RID: 30188
		// (get) Token: 0x0602E5C9 RID: 189897
		// (set) Token: 0x0602E5CA RID: 189898
		string Reason { get; set; }
	}
}
