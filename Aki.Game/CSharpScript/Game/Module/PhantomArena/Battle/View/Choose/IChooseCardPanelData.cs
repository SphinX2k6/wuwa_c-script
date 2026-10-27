using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using CSharpScript.Game.Module.PhantomArena.Battle.Model;
using Cysharp.Threading.Tasks;

namespace CSharpScript.Game.Module.PhantomArena.Battle.View.Choose
{
	// Token: 0x0200526A RID: 21098
	[NullableContext(1)]
	public interface IChooseCardPanelData
	{
		// Token: 0x17008270 RID: 33392
		// (get) Token: 0x06035F21 RID: 220961
		// (set) Token: 0x06035F22 RID: 220962
		Func<List<int>, UniTask> ConfirmFunc { get; set; }

		// Token: 0x17008271 RID: 33393
		// (get) Token: 0x06035F23 RID: 220963
		// (set) Token: 0x06035F24 RID: 220964
		int LimitCount { get; set; }

		// Token: 0x17008272 RID: 33394
		// (get) Token: 0x06035F25 RID: 220965
		// (set) Token: 0x06035F26 RID: 220966
		List<PhantomCardData> CardDataList { get; set; }

		// Token: 0x17008273 RID: 33395
		// (get) Token: 0x06035F27 RID: 220967
		// (set) Token: 0x06035F28 RID: 220968
		EBvbPlayerOperationType? GuideType { get; set; }
	}
}
