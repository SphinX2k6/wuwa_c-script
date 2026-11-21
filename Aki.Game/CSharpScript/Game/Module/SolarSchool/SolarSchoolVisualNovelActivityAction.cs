using System;
using System.Runtime.CompilerServices;
using System.Threading;
using Aki.TDConfigMgr.Action;
using CSharpScript.Game.Module.VisualNovel;
using CSharpScript.Game.Module.VisualNovel.Action;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

namespace CSharpScript.Game.Module.SolarSchool
{
	// Token: 0x02005A67 RID: 23143
	[NullableContext(1)]
	[Nullable(0)]
	public sealed class SolarSchoolVisualNovelActivityAction : VisualNovelAction
	{
		// Token: 0x06039029 RID: 233513 RVA: 0x00FF822F File Offset: 0x00FF642F
		public SolarSchoolVisualNovelActivityAction(VisualNovelContext context, IVisualNovelPerformanceBase performance) : base(context)
		{
			this.Performance = (IVisualNovelPerformanceActivityAction)performance;
		}

		// Token: 0x0603902A RID: 233514 RVA: 0x00FF8244 File Offset: 0x00FF6444
		protected override UniTask ExecuteCoreAsync()
		{
			SolarSchoolVisualNovelActivityAction.<ExecuteCoreAsync>d__3 <ExecuteCoreAsync>d__;
			<ExecuteCoreAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<ExecuteCoreAsync>d__.<>4__this = this;
			<ExecuteCoreAsync>d__.<>1__state = -1;
			<ExecuteCoreAsync>d__.<>t__builder.Start<SolarSchoolVisualNovelActivityAction.<ExecuteCoreAsync>d__3>(ref <ExecuteCoreAsync>d__);
			return <ExecuteCoreAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603902B RID: 233515 RVA: 0x00FF8287 File Offset: 0x00FF6487
		public override bool TryComplete()
		{
			if (!base.IsExecuting || base.Context.PlaybackMode != EVisualNovelPlaybackMode.Skip)
			{
				return false;
			}
			CancellationTokenSource cancellation = this.Cancellation;
			if (cancellation != null)
			{
				cancellation.Cancel();
			}
			return true;
		}

		// Token: 0x0603902C RID: 233516 RVA: 0x00FF82B3 File Offset: 0x00FF64B3
		internal override void Release()
		{
			if (base.IsExecuting)
			{
				CancellationTokenSource cancellation = this.Cancellation;
				if (cancellation == null)
				{
					return;
				}
				cancellation.Cancel();
			}
		}

		// Token: 0x0401E010 RID: 122896
		private readonly IVisualNovelPerformanceActivityAction Performance;

		// Token: 0x0401E011 RID: 122897
		[Nullable(2)]
		private CancellationTokenSource Cancellation;
	}
}
