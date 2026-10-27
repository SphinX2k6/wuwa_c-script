using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cysharp.Threading.Tasks;

namespace CSharpScript.Game.Module.Activity.ActivityContent.MatchThree.Gameplay.Jobs
{
	// Token: 0x02006518 RID: 25880
	[NullableContext(1)]
	[Nullable(0)]
	public sealed class BatchJob<[Nullable(2)] T> : IJob
	{
		// Token: 0x06040EAA RID: 265898 RVA: 0x00FBB798 File Offset: 0x00FB9998
		public BatchJob(int order, Func<IMatchThreePresentation, List<T>, UniTask> play)
		{
		}

		// Token: 0x1700951A RID: 38170
		// (get) Token: 0x06040EAB RID: 265899 RVA: 0x00FBB7B9 File Offset: 0x00FB99B9
		public int ExecutionOrder
		{
			get
			{
				return this.<order>P;
			}
		} = order;

		// Token: 0x06040EAC RID: 265900 RVA: 0x00FBB7C1 File Offset: 0x00FB99C1
		public UniTask ExecuteAsync(IMatchThreePresentation view)
		{
			return this.<play>P(view, this.Events);
		}

		// Token: 0x04021DBF RID: 138687
		[CompilerGenerated]
		private int <order>P;

		// Token: 0x04021DC0 RID: 138688
		[CompilerGenerated]
		private Func<IMatchThreePresentation, List<T>, UniTask> <play>P = play;

		// Token: 0x04021DC1 RID: 138689
		public readonly List<T> Events = new List<T>();
	}
}
