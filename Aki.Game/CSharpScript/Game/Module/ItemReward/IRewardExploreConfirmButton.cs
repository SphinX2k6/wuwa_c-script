using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.ItemReward
{
	// Token: 0x020047A9 RID: 18345
	[NullableContext(2)]
	public interface IRewardExploreConfirmButton
	{
		// Token: 0x17005D84 RID: 23940
		// (get) Token: 0x0602E195 RID: 188821
		// (set) Token: 0x0602E196 RID: 188822
		[Nullable(1)]
		string ButtonTextId { [NullableContext(1)] get; [NullableContext(1)] set; }

		// Token: 0x17005D85 RID: 23941
		// (get) Token: 0x0602E197 RID: 188823
		// (set) Token: 0x0602E198 RID: 188824
		string DescriptionTextId { get; set; }

		// Token: 0x17005D86 RID: 23942
		// (get) Token: 0x0602E199 RID: 188825
		// (set) Token: 0x0602E19A RID: 188826
		[Nullable(new byte[]
		{
			2,
			1
		})]
		List<object> DescriptionArgs { [return: Nullable(new byte[]
		{
			2,
			1
		})] get; [param: Nullable(new byte[]
		{
			2,
			1
		})] set; }

		// Token: 0x17005D87 RID: 23943
		// (get) Token: 0x0602E19B RID: 188827
		// (set) Token: 0x0602E19C RID: 188828
		int? TimeDown { get; set; }

		// Token: 0x17005D88 RID: 23944
		// (get) Token: 0x0602E19D RID: 188829
		// (set) Token: 0x0602E19E RID: 188830
		bool IsTimeDownCloseView { get; set; }

		// Token: 0x17005D89 RID: 23945
		// (get) Token: 0x0602E19F RID: 188831
		// (set) Token: 0x0602E1A0 RID: 188832
		Action OnTimeDownOnCallback { get; set; }

		// Token: 0x17005D8A RID: 23946
		// (get) Token: 0x0602E1A1 RID: 188833
		// (set) Token: 0x0602E1A2 RID: 188834
		bool IsClickedCloseView { get; set; }

		// Token: 0x17005D8B RID: 23947
		// (get) Token: 0x0602E1A3 RID: 188835
		// (set) Token: 0x0602E1A4 RID: 188836
		Action<int> OnClickedCallback { get; set; }

		// Token: 0x17005D8C RID: 23948
		// (get) Token: 0x0602E1A5 RID: 188837
		// (set) Token: 0x0602E1A6 RID: 188838
		int? ClickCd { get; set; }
	}
}
