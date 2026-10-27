using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

namespace CSharpScript.Game.Module.Activity.ActivityContent.MatchThree.Gameplay.Jobs
{
	// Token: 0x02006521 RID: 25889
	[NullableContext(1)]
	[Nullable(0)]
	public class JobsPlayer
	{
		// Token: 0x06040ECE RID: 265934 RVA: 0x00FBBB3F File Offset: 0x00FB9D3F
		public void BindPresenter(IMatchThreePresentation presenter)
		{
			this.Presenter = presenter;
		}

		// Token: 0x06040ECF RID: 265935 RVA: 0x00FBBB48 File Offset: 0x00FB9D48
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

		// Token: 0x04021DDE RID: 138718
		private readonly Comparison<IJob> OrderComparison = (IJob a, IJob b) => a.ExecutionOrder.CompareTo(b.ExecutionOrder);

		// Token: 0x04021DDF RID: 138719
		private readonly List<UniTask> Batch = new List<UniTask>();

		// Token: 0x04021DE0 RID: 138720
		[Nullable(2)]
		private IMatchThreePresentation Presenter;

		// Token: 0x04021DE1 RID: 138721
		public bool Muted;
	}
}
