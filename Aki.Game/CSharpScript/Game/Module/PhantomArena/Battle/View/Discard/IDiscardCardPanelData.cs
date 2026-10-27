using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using CSharpScript.Game.Module.PhantomArena.Battle.Model;
using Cysharp.Threading.Tasks;

namespace CSharpScript.Game.Module.PhantomArena.Battle.View.Discard
{
	// Token: 0x02005265 RID: 21093
	[NullableContext(1)]
	public interface IDiscardCardPanelData
	{
		// Token: 0x17008264 RID: 33380
		// (get) Token: 0x06035EDB RID: 220891
		// (set) Token: 0x06035EDC RID: 220892
		Func<List<int>, UniTask> ConfirmFunc { get; set; }

		// Token: 0x17008265 RID: 33381
		// (get) Token: 0x06035EDD RID: 220893
		// (set) Token: 0x06035EDE RID: 220894
		int LimitCount { get; set; }

		// Token: 0x17008266 RID: 33382
		// (get) Token: 0x06035EDF RID: 220895
		// (set) Token: 0x06035EE0 RID: 220896
		List<PhantomCardData> CardDataList { get; set; }

		// Token: 0x17008267 RID: 33383
		// (get) Token: 0x06035EE1 RID: 220897
		// (set) Token: 0x06035EE2 RID: 220898
		string TitleTips { get; set; }

		// Token: 0x17008268 RID: 33384
		// (get) Token: 0x06035EE3 RID: 220899
		// (set) Token: 0x06035EE4 RID: 220900
		string SelectedTips { get; set; }

		// Token: 0x17008269 RID: 33385
		// (get) Token: 0x06035EE5 RID: 220901
		// (set) Token: 0x06035EE6 RID: 220902
		EBvbPlayerOperationType? GuideType { get; set; }
	}
}
