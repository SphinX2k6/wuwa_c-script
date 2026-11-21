using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;

namespace CSharpScript.Game.Module.PhantomArena.Battle.Guide
{
	// Token: 0x02004274 RID: 17012
	[NullableContext(1)]
	public interface IPhantomArenaTabViewModelBase
	{
		// Token: 0x170056A4 RID: 22180
		// (get) Token: 0x0602B13F RID: 176447
		// (set) Token: 0x0602B140 RID: 176448
		string Tips { get; set; }

		// Token: 0x170056A5 RID: 22181
		// (get) Token: 0x0602B141 RID: 176449
		// (set) Token: 0x0602B142 RID: 176450
		EBvbPlayerOperationType Type { get; set; }

		// Token: 0x0602B143 RID: 176451
		bool CheckCanExecute(params object[] params_);

		// Token: 0x0602B144 RID: 176452
		void CacheGuideData(params object[] params_);

		// Token: 0x0602B145 RID: 176453
		bool CheckCanFinishGuide(params object[] params_);
	}
}
