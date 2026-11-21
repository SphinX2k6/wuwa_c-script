using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cysharp.Threading.Tasks;

namespace CSharpScript.Game.Module.Activity.ActivityContent.MatchThree.Gameplay.Jobs
{
	// Token: 0x02005496 RID: 21654
	[NullableContext(1)]
	[Nullable(0)]
	public sealed class BatchJob<[Nullable(2)] T> : IJob
	{
		// Token: 0x06035B6E RID: 220014 RVA: 0x00F027C8 File Offset: 0x00F009C8
		public BatchJob(int order, Func<IMatchThreePresentation, List<T>, UniTask> play)
		{
		}

		// Token: 0x1700687C RID: 26748
		// (get) Token: 0x06035B6F RID: 220015 RVA: 0x00F027E9 File Offset: 0x00F009E9
		public int ExecutionOrder
		{
			get
			{
				return this.<order>P;
			}
		} = order;

		// Token: 0x06035B70 RID: 220016 RVA: 0x00F027F1 File Offset: 0x00F009F1
		public UniTask ExecuteAsync(IMatchThreePresentation view)
		{
			return this.<play>P(view, this.Events);
		}

		// Token: 0x0401C6F0 RID: 116464
		[CompilerGenerated]
		private int <order>P;

		// Token: 0x0401C6F1 RID: 116465
		[CompilerGenerated]
		private Func<IMatchThreePresentation, List<T>, UniTask> <play>P = play;

		// Token: 0x0401C6F2 RID: 116466
		public readonly List<T> Events = new List<T>();
	}
}
