using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;

namespace CSharpScript.Game.Module.PhantomArena.Prepare.Entrance
{
	// Token: 0x02005163 RID: 20835
	[NullableContext(1)]
	[Nullable(0)]
	public class PhantomArenaEntranceShopTabData : CommonTabData
	{
		// Token: 0x06035448 RID: 218184 RVA: 0x00C9D4E5 File Offset: 0x00C9B6E5
		public PhantomArenaEntranceShopTabData(string icon, [Nullable(2)] CommonTabTitleData titleData, string realTitleId, EUiTabViewName tabViewName) : base(icon, titleData, null)
		{
			this.RealTitleId = realTitleId;
			this.TabViewName = tabViewName;
		}

		// Token: 0x06035449 RID: 218185 RVA: 0x00C9D4FF File Offset: 0x00C9B6FF
		public string GetRealTitle()
		{
			return this.RealTitleId;
		}

		// Token: 0x0603544A RID: 218186 RVA: 0x00C9D507 File Offset: 0x00C9B707
		public EUiTabViewName GetTabViewName()
		{
			return this.TabViewName;
		}

		// Token: 0x0401C566 RID: 116070
		private readonly string RealTitleId;

		// Token: 0x0401C567 RID: 116071
		private readonly EUiTabViewName TabViewName;
	}
}
