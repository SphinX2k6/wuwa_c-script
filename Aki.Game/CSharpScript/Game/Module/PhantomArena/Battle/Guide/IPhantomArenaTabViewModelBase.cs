using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;

namespace CSharpScript.Game.Module.PhantomArena.Battle.Guide
{
	// Token: 0x020052A4 RID: 21156
	[NullableContext(1)]
	public interface IPhantomArenaTabViewModelBase
	{
		// Token: 0x170082E4 RID: 33508
		// (get) Token: 0x06036244 RID: 221764
		// (set) Token: 0x06036245 RID: 221765
		string Tips { get; set; }

		// Token: 0x170082E5 RID: 33509
		// (get) Token: 0x06036246 RID: 221766
		// (set) Token: 0x06036247 RID: 221767
		EBvbPlayerOperationType Type { get; set; }

		// Token: 0x06036248 RID: 221768
		bool CheckCanExecute(params object[] params_);

		// Token: 0x06036249 RID: 221769
		void CacheGuideData(params object[] params_);

		// Token: 0x0603624A RID: 221770
		bool CheckCanFinishGuide(params object[] params_);
	}
}
