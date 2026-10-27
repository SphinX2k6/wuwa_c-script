using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;

namespace CSharpScript.Game.Module.Activity.ActivityContent.MatchThree.Gameplay.View
{
	// Token: 0x020064E4 RID: 25828
	[NullableContext(2)]
	[Nullable(0)]
	public class MatchThreeSuccessPopParams : UiPopViewData
	{
		// Token: 0x04021C70 RID: 138352
		public bool IsEndless;

		// Token: 0x04021C71 RID: 138353
		public int Score;

		// Token: 0x04021C72 RID: 138354
		public bool IsNewRecord;

		// Token: 0x04021C73 RID: 138355
		public IReadOnlyList<TItem> Rewards;

		// Token: 0x04021C74 RID: 138356
		public Action OnExit;

		// Token: 0x04021C75 RID: 138357
		[Nullable(new byte[]
		{
			2,
			0
		})]
		public Func<UniTask<bool>> OnPrepareRetry;

		// Token: 0x04021C76 RID: 138358
		public Action OnRetryAfterClose;
	}
}
