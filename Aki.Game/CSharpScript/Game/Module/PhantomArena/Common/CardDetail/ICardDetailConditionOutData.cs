using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.PhantomArena.Common.CardDetail
{
	// Token: 0x020041E8 RID: 16872
	[NullableContext(1)]
	public interface ICardDetailConditionOutData
	{
		// Token: 0x170055D1 RID: 21969
		// (get) Token: 0x0602AAD9 RID: 174809
		// (set) Token: 0x0602AADA RID: 174810
		int CurrentProgress { get; set; }

		// Token: 0x170055D2 RID: 21970
		// (get) Token: 0x0602AADB RID: 174811
		// (set) Token: 0x0602AADC RID: 174812
		int MaxProgress { get; set; }

		// Token: 0x170055D3 RID: 21971
		// (get) Token: 0x0602AADD RID: 174813
		// (set) Token: 0x0602AADE RID: 174814
		string Icon { get; set; }

		// Token: 0x170055D4 RID: 21972
		// (get) Token: 0x0602AADF RID: 174815
		// (set) Token: 0x0602AAE0 RID: 174816
		string ConditionDesc { get; set; }

		// Token: 0x170055D5 RID: 21973
		// (get) Token: 0x0602AAE1 RID: 174817
		// (set) Token: 0x0602AAE2 RID: 174818
		string Title { get; set; }

		// Token: 0x170055D6 RID: 21974
		// (get) Token: 0x0602AAE3 RID: 174819
		// (set) Token: 0x0602AAE4 RID: 174820
		bool? TitleChangeColor { get; set; }
	}
}
