using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.WorldMap.SubViews.LordGymPanel
{
	// Token: 0x0200373F RID: 14143
	[NullableContext(1)]
	[Nullable(0)]
	public class DifficultyItemData : IDifficultyItemData
	{
		// Token: 0x17004BA0 RID: 19360
		// (get) Token: 0x06024C7D RID: 150653 RVA: 0x00A63BCC File Offset: 0x00A61DCC
		// (set) Token: 0x06024C7E RID: 150654 RVA: 0x00A63BD4 File Offset: 0x00A61DD4
		public string NameTextId { get; set; } = "";

		// Token: 0x17004BA1 RID: 19361
		// (get) Token: 0x06024C7F RID: 150655 RVA: 0x00A63BDD File Offset: 0x00A61DDD
		// (set) Token: 0x06024C80 RID: 150656 RVA: 0x00A63BE5 File Offset: 0x00A61DE5
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public object[] NameTextArg { [return: Nullable(new byte[]
		{
			2,
			1
		})] get; [param: Nullable(new byte[]
		{
			2,
			1
		})] set; }

		// Token: 0x17004BA2 RID: 19362
		// (get) Token: 0x06024C81 RID: 150657 RVA: 0x00A63BEE File Offset: 0x00A61DEE
		// (set) Token: 0x06024C82 RID: 150658 RVA: 0x00A63BF6 File Offset: 0x00A61DF6
		public List<ELordGymDifficultyState> StateList { get; set; }
	}
}
