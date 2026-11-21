using System;
using System.Runtime.CompilerServices;
using Cysharp.Threading.Tasks;

namespace CSharpScript.Game.Module.Activity.ActivityContent.MatchThree.Gameplay.Jobs
{
	// Token: 0x02005484 RID: 21636
	[NullableContext(1)]
	public interface IJob
	{
		// Token: 0x1700687B RID: 26747
		// (get) Token: 0x06035B5F RID: 219999
		int ExecutionOrder { get; }

		// Token: 0x06035B60 RID: 220000
		UniTask ExecuteAsync(IMatchThreePresentation presenter);
	}
}
