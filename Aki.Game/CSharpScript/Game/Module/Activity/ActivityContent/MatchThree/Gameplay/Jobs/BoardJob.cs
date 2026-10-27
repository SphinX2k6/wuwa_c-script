using System;
using System.Runtime.CompilerServices;
using Cysharp.Threading.Tasks;

namespace CSharpScript.Game.Module.Activity.ActivityContent.MatchThree.Gameplay.Jobs
{
	// Token: 0x0200651A RID: 25882
	public sealed class BoardJob : IJob
	{
		// Token: 0x1700951C RID: 38172
		// (get) Token: 0x06040EB0 RID: 265904 RVA: 0x00FBB84D File Offset: 0x00FB9A4D
		public int ExecutionOrder
		{
			get
			{
				return 10;
			}
		}

		// Token: 0x06040EB1 RID: 265905 RVA: 0x00FBB851 File Offset: 0x00FB9A51
		[NullableContext(1)]
		public UniTask ExecuteAsync(IMatchThreePresentation view)
		{
			return view.PlayBoardAsync(this.Segment);
		}

		// Token: 0x04021DC5 RID: 138693
		[Nullable(1)]
		public readonly BoardSegment Segment = new BoardSegment();
	}
}
