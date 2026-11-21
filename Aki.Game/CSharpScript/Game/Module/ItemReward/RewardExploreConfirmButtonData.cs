using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.ItemReward
{
	// Token: 0x020047AA RID: 18346
	[NullableContext(2)]
	[Nullable(0)]
	public class RewardExploreConfirmButtonData : IRewardExploreConfirmButton
	{
		// Token: 0x17005D8D RID: 23949
		// (get) Token: 0x0602E1A7 RID: 188839 RVA: 0x00CDEFEA File Offset: 0x00CDD1EA
		// (set) Token: 0x0602E1A8 RID: 188840 RVA: 0x00CDEFF2 File Offset: 0x00CDD1F2
		[Nullable(1)]
		public string ButtonTextId { [NullableContext(1)] get; [NullableContext(1)] set; }

		// Token: 0x17005D8E RID: 23950
		// (get) Token: 0x0602E1A9 RID: 188841 RVA: 0x00CDEFFB File Offset: 0x00CDD1FB
		// (set) Token: 0x0602E1AA RID: 188842 RVA: 0x00CDF003 File Offset: 0x00CDD203
		public string DescriptionTextId { get; set; }

		// Token: 0x17005D8F RID: 23951
		// (get) Token: 0x0602E1AB RID: 188843 RVA: 0x00CDF00C File Offset: 0x00CDD20C
		// (set) Token: 0x0602E1AC RID: 188844 RVA: 0x00CDF014 File Offset: 0x00CDD214
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public List<object> DescriptionArgs { [return: Nullable(new byte[]
		{
			2,
			1
		})] get; [param: Nullable(new byte[]
		{
			2,
			1
		})] set; }

		// Token: 0x17005D90 RID: 23952
		// (get) Token: 0x0602E1AD RID: 188845 RVA: 0x00CDF01D File Offset: 0x00CDD21D
		// (set) Token: 0x0602E1AE RID: 188846 RVA: 0x00CDF025 File Offset: 0x00CDD225
		public int? TimeDown { get; set; }

		// Token: 0x17005D91 RID: 23953
		// (get) Token: 0x0602E1AF RID: 188847 RVA: 0x00CDF02E File Offset: 0x00CDD22E
		// (set) Token: 0x0602E1B0 RID: 188848 RVA: 0x00CDF036 File Offset: 0x00CDD236
		public bool IsTimeDownCloseView { get; set; }

		// Token: 0x17005D92 RID: 23954
		// (get) Token: 0x0602E1B1 RID: 188849 RVA: 0x00CDF03F File Offset: 0x00CDD23F
		// (set) Token: 0x0602E1B2 RID: 188850 RVA: 0x00CDF047 File Offset: 0x00CDD247
		public Action OnTimeDownOnCallback { get; set; }

		// Token: 0x17005D93 RID: 23955
		// (get) Token: 0x0602E1B3 RID: 188851 RVA: 0x00CDF050 File Offset: 0x00CDD250
		// (set) Token: 0x0602E1B4 RID: 188852 RVA: 0x00CDF058 File Offset: 0x00CDD258
		public bool IsClickedCloseView { get; set; }

		// Token: 0x17005D94 RID: 23956
		// (get) Token: 0x0602E1B5 RID: 188853 RVA: 0x00CDF061 File Offset: 0x00CDD261
		// (set) Token: 0x0602E1B6 RID: 188854 RVA: 0x00CDF069 File Offset: 0x00CDD269
		public Action<int> OnClickedCallback { get; set; }

		// Token: 0x17005D95 RID: 23957
		// (get) Token: 0x0602E1B7 RID: 188855 RVA: 0x00CDF072 File Offset: 0x00CDD272
		// (set) Token: 0x0602E1B8 RID: 188856 RVA: 0x00CDF07A File Offset: 0x00CDD27A
		public int? ClickCd { get; set; }
	}
}
