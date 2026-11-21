using System;
using System.Runtime.CompilerServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

namespace CSharpScript.Game.Module.Plot.Sequence.Assistant
{
	// Token: 0x02004000 RID: 16384
	[NullableContext(2)]
	[Nullable(0)]
	public class SeqBaseAssistant : ControllerAssistantBase
	{
		// Token: 0x06029784 RID: 169860 RVA: 0x00BB1E56 File Offset: 0x00BB0056
		protected void DoCallback(bool result)
		{
			if (this.Callback != null)
			{
				Action<bool> callback = this.Callback;
				this.Callback = null;
				callback(result);
			}
		}

		// Token: 0x06029785 RID: 169861 RVA: 0x00BB1E73 File Offset: 0x00BB0073
		public virtual void End()
		{
		}

		// Token: 0x06029786 RID: 169862 RVA: 0x00BB1E75 File Offset: 0x00BB0075
		public virtual void Load(Action<bool> callback = null)
		{
		}

		// Token: 0x06029787 RID: 169863 RVA: 0x00BB1E78 File Offset: 0x00BB0078
		[NullableContext(0)]
		public virtual UniTask<bool> LoadPromise()
		{
			SeqBaseAssistant.<LoadPromise>d__7 <LoadPromise>d__;
			<LoadPromise>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<LoadPromise>d__.<>4__this = this;
			<LoadPromise>d__.<>1__state = -1;
			<LoadPromise>d__.<>t__builder.Start<SeqBaseAssistant.<LoadPromise>d__7>(ref <LoadPromise>d__);
			return <LoadPromise>d__.<>t__builder.Task;
		}

		// Token: 0x06029788 RID: 169864 RVA: 0x00BB1EBB File Offset: 0x00BB00BB
		public virtual void PreAllPlay(Action<bool> callback = null)
		{
		}

		// Token: 0x06029789 RID: 169865 RVA: 0x00BB1EC0 File Offset: 0x00BB00C0
		[NullableContext(0)]
		public virtual UniTask<bool> PreAllPlayPromise()
		{
			SeqBaseAssistant.<PreAllPlayPromise>d__9 <PreAllPlayPromise>d__;
			<PreAllPlayPromise>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<PreAllPlayPromise>d__.<>4__this = this;
			<PreAllPlayPromise>d__.<>1__state = -1;
			<PreAllPlayPromise>d__.<>t__builder.Start<SeqBaseAssistant.<PreAllPlayPromise>d__9>(ref <PreAllPlayPromise>d__);
			return <PreAllPlayPromise>d__.<>t__builder.Task;
		}

		// Token: 0x0602978A RID: 169866 RVA: 0x00BB1F03 File Offset: 0x00BB0103
		public virtual void PreEachPlay()
		{
		}

		// Token: 0x0602978B RID: 169867 RVA: 0x00BB1F05 File Offset: 0x00BB0105
		public virtual void EachStop()
		{
		}

		// Token: 0x0602978C RID: 169868 RVA: 0x00BB1F07 File Offset: 0x00BB0107
		public virtual void CmdShadowUpdate()
		{
		}

		// Token: 0x0602978D RID: 169869 RVA: 0x00BB1F09 File Offset: 0x00BB0109
		public virtual void AllStop(Action<bool> callback = null)
		{
		}

		// Token: 0x0602978E RID: 169870 RVA: 0x00BB1F0C File Offset: 0x00BB010C
		[NullableContext(0)]
		public virtual UniTask<bool> AllStopPromise()
		{
			SeqBaseAssistant.<AllStopPromise>d__14 <AllStopPromise>d__;
			<AllStopPromise>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<AllStopPromise>d__.<>4__this = this;
			<AllStopPromise>d__.<>1__state = -1;
			<AllStopPromise>d__.<>t__builder.Start<SeqBaseAssistant.<AllStopPromise>d__14>(ref <AllStopPromise>d__);
			return <AllStopPromise>d__.<>t__builder.Task;
		}

		// Token: 0x0602978F RID: 169871 RVA: 0x00BB1F4F File Offset: 0x00BB014F
		public virtual void LoadNecessaryData(Action callback = null)
		{
		}

		// Token: 0x06029790 RID: 169872 RVA: 0x00BB1F51 File Offset: 0x00BB0151
		protected override void OnDestroy()
		{
		}

		// Token: 0x04016A0F RID: 92687
		[Nullable(1)]
		protected SequenceModel Model = SequenceModel.Instance;

		// Token: 0x04016A10 RID: 92688
		protected bool IsRunning;

		// Token: 0x04016A11 RID: 92689
		protected Action<bool> Callback;

		// Token: 0x04016A12 RID: 92690
		protected CustomPromise<bool> Promise;
	}
}
