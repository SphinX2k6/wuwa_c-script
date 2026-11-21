using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using CSharpScript.Game.Module.PhantomArena.Battle.Model;
using Cysharp.Threading.Tasks;

namespace CSharpScript.Game.Module.PhantomArena.Battle.View.Choose
{
	// Token: 0x0200423A RID: 16954
	[NullableContext(1)]
	public interface IChooseCardPanelData
	{
		// Token: 0x17005630 RID: 22064
		// (get) Token: 0x0602AE1C RID: 175644
		// (set) Token: 0x0602AE1D RID: 175645
		Func<List<int>, UniTask> ConfirmFunc { get; set; }

		// Token: 0x17005631 RID: 22065
		// (get) Token: 0x0602AE1E RID: 175646
		// (set) Token: 0x0602AE1F RID: 175647
		int LimitCount { get; set; }

		// Token: 0x17005632 RID: 22066
		// (get) Token: 0x0602AE20 RID: 175648
		// (set) Token: 0x0602AE21 RID: 175649
		List<PhantomCardData> CardDataList { get; set; }

		// Token: 0x17005633 RID: 22067
		// (get) Token: 0x0602AE22 RID: 175650
		// (set) Token: 0x0602AE23 RID: 175651
		EBvbPlayerOperationType? GuideType { get; set; }
	}
}
