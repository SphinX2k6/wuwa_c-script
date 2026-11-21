using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;

namespace CSharpScript.Game.Module.PhantomArena.Prepare.Entrance
{
	// Token: 0x02004133 RID: 16691
	[NullableContext(1)]
	[Nullable(0)]
	public class PhantomArenaEntranceShopTabData : CommonTabData
	{
		// Token: 0x0602A344 RID: 172868 RVA: 0x00BEAA15 File Offset: 0x00BE8C15
		public PhantomArenaEntranceShopTabData(string icon, [Nullable(2)] CommonTabTitleData titleData, string realTitleId, EUiTabViewName tabViewName) : base(icon, titleData, null)
		{
			this.RealTitleId = realTitleId;
			this.TabViewName = tabViewName;
		}

		// Token: 0x0602A345 RID: 172869 RVA: 0x00BEAA2F File Offset: 0x00BE8C2F
		public string GetRealTitle()
		{
			return this.RealTitleId;
		}

		// Token: 0x0602A346 RID: 172870 RVA: 0x00BEAA37 File Offset: 0x00BE8C37
		public EUiTabViewName GetTabViewName()
		{
			return this.TabViewName;
		}

		// Token: 0x04016F9B RID: 94107
		private readonly string RealTitleId;

		// Token: 0x04016F9C RID: 94108
		private readonly EUiTabViewName TabViewName;
	}
}
