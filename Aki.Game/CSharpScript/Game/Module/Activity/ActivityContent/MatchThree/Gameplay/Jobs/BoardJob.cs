using System;
using System.Runtime.CompilerServices;
using Cysharp.Threading.Tasks;

namespace CSharpScript.Game.Module.Activity.ActivityContent.MatchThree.Gameplay.Jobs
{
	// Token: 0x02005498 RID: 21656
	public sealed class BoardJob : IJob
	{
		// Token: 0x1700687E RID: 26750
		// (get) Token: 0x06035B74 RID: 220020 RVA: 0x00F0287D File Offset: 0x00F00A7D
		public int ExecutionOrder
		{
			get
			{
				return 10;
			}
		}

		// Token: 0x06035B75 RID: 220021 RVA: 0x00F02881 File Offset: 0x00F00A81
		[NullableContext(1)]
		public UniTask ExecuteAsync(IMatchThreePresentation view)
		{
			return view.PlayBoardAsync(this.Segment);
		}

		// Token: 0x0401C6F6 RID: 116470
		[Nullable(1)]
		public readonly BoardSegment Segment = new BoardSegment();
	}
}
