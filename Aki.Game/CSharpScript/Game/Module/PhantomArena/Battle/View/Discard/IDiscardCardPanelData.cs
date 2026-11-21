using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using CSharpScript.Game.Module.PhantomArena.Battle.Model;
using Cysharp.Threading.Tasks;

namespace CSharpScript.Game.Module.PhantomArena.Battle.View.Discard
{
	// Token: 0x02004235 RID: 16949
	[NullableContext(1)]
	public interface IDiscardCardPanelData
	{
		// Token: 0x17005624 RID: 22052
		// (get) Token: 0x0602ADD6 RID: 175574
		// (set) Token: 0x0602ADD7 RID: 175575
		Func<List<int>, UniTask> ConfirmFunc { get; set; }

		// Token: 0x17005625 RID: 22053
		// (get) Token: 0x0602ADD8 RID: 175576
		// (set) Token: 0x0602ADD9 RID: 175577
		int LimitCount { get; set; }

		// Token: 0x17005626 RID: 22054
		// (get) Token: 0x0602ADDA RID: 175578
		// (set) Token: 0x0602ADDB RID: 175579
		List<PhantomCardData> CardDataList { get; set; }

		// Token: 0x17005627 RID: 22055
		// (get) Token: 0x0602ADDC RID: 175580
		// (set) Token: 0x0602ADDD RID: 175581
		string TitleTips { get; set; }

		// Token: 0x17005628 RID: 22056
		// (get) Token: 0x0602ADDE RID: 175582
		// (set) Token: 0x0602ADDF RID: 175583
		string SelectedTips { get; set; }

		// Token: 0x17005629 RID: 22057
		// (get) Token: 0x0602ADE0 RID: 175584
		// (set) Token: 0x0602ADE1 RID: 175585
		EBvbPlayerOperationType? GuideType { get; set; }
	}
}
