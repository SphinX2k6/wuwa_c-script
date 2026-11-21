using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;

namespace CSharpScript.Game.Module.Activity.ActivityContent.MatchThree.Gameplay.View
{
	// Token: 0x02005462 RID: 21602
	[NullableContext(2)]
	[Nullable(0)]
	public class MatchThreeSuccessPopParams : UiPopViewData
	{
		// Token: 0x0401C5A1 RID: 116129
		public bool IsEndless;

		// Token: 0x0401C5A2 RID: 116130
		public int Score;

		// Token: 0x0401C5A3 RID: 116131
		public bool IsNewRecord;

		// Token: 0x0401C5A4 RID: 116132
		public IReadOnlyList<TItem> Rewards;

		// Token: 0x0401C5A5 RID: 116133
		public Action OnExit;

		// Token: 0x0401C5A6 RID: 116134
		[Nullable(new byte[]
		{
			2,
			0
		})]
		public Func<UniTask<bool>> OnPrepareRetry;

		// Token: 0x0401C5A7 RID: 116135
		public Action OnRetryAfterClose;
	}
}
