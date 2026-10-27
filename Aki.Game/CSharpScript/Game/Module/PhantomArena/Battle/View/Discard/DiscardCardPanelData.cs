using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using CSharpScript.Game.Module.PhantomArena.Battle.Model;
using Cysharp.Threading.Tasks;

namespace CSharpScript.Game.Module.PhantomArena.Battle.View.Discard
{
	// Token: 0x02005266 RID: 21094
	[NullableContext(1)]
	[Nullable(0)]
	public class DiscardCardPanelData : IDiscardCardPanelData
	{
		// Token: 0x1700826A RID: 33386
		// (get) Token: 0x06035EE7 RID: 220903 RVA: 0x00CC2BB8 File Offset: 0x00CC0DB8
		// (set) Token: 0x06035EE8 RID: 220904 RVA: 0x00CC2BC0 File Offset: 0x00CC0DC0
		public Func<List<int>, UniTask> ConfirmFunc { get; set; }

		// Token: 0x1700826B RID: 33387
		// (get) Token: 0x06035EE9 RID: 220905 RVA: 0x00CC2BC9 File Offset: 0x00CC0DC9
		// (set) Token: 0x06035EEA RID: 220906 RVA: 0x00CC2BD1 File Offset: 0x00CC0DD1
		public int LimitCount { get; set; }

		// Token: 0x1700826C RID: 33388
		// (get) Token: 0x06035EEB RID: 220907 RVA: 0x00CC2BDA File Offset: 0x00CC0DDA
		// (set) Token: 0x06035EEC RID: 220908 RVA: 0x00CC2BE2 File Offset: 0x00CC0DE2
		public List<PhantomCardData> CardDataList { get; set; }

		// Token: 0x1700826D RID: 33389
		// (get) Token: 0x06035EED RID: 220909 RVA: 0x00CC2BEB File Offset: 0x00CC0DEB
		// (set) Token: 0x06035EEE RID: 220910 RVA: 0x00CC2BF3 File Offset: 0x00CC0DF3
		public string TitleTips { get; set; }

		// Token: 0x1700826E RID: 33390
		// (get) Token: 0x06035EEF RID: 220911 RVA: 0x00CC2BFC File Offset: 0x00CC0DFC
		// (set) Token: 0x06035EF0 RID: 220912 RVA: 0x00CC2C04 File Offset: 0x00CC0E04
		public string SelectedTips { get; set; }

		// Token: 0x1700826F RID: 33391
		// (get) Token: 0x06035EF1 RID: 220913 RVA: 0x00CC2C0D File Offset: 0x00CC0E0D
		// (set) Token: 0x06035EF2 RID: 220914 RVA: 0x00CC2C15 File Offset: 0x00CC0E15
		public EBvbPlayerOperationType? GuideType { get; set; }
	}
}
