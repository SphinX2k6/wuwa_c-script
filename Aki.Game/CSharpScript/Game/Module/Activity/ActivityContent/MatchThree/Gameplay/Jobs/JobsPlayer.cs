using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

namespace CSharpScript.Game.Module.Activity.ActivityContent.MatchThree.Gameplay.Jobs
{
	// Token: 0x0200549F RID: 21663
	[NullableContext(1)]
	[Nullable(0)]
	public class JobsPlayer
	{
		// Token: 0x06035B92 RID: 220050 RVA: 0x00F02B6F File Offset: 0x00F00D6F
		public void BindPresenter(IMatchThreePresentation presenter)
		{
			this.Presenter = presenter;
		}

		// Token: 0x06035B93 RID: 220051 RVA: 0x00F02B78 File Offset: 0x00F00D78
		public UniTask RunAsync(List<IJob> jobs)
		{
			JobsPlayer.<RunAsync>d__5 <RunAsync>d__;
			<RunAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<RunAsync>d__.<>4__this = this;
			<RunAsync>d__.jobs = jobs;
			<RunAsync>d__.<>1__state = -1;
			<RunAsync>d__.<>t__builder.Start<JobsPlayer.<RunAsync>d__5>(ref <RunAsync>d__);
			return <RunAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0401C70F RID: 116495
		private readonly Comparison<IJob> OrderComparison = (IJob a, IJob b) => a.ExecutionOrder.CompareTo(b.ExecutionOrder);

		// Token: 0x0401C710 RID: 116496
		private readonly List<UniTask> Batch = new List<UniTask>();

		// Token: 0x0401C711 RID: 116497
		[Nullable(2)]
		private IMatchThreePresentation Presenter;

		// Token: 0x0401C712 RID: 116498
		public bool Muted;
	}
}
