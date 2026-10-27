using System;
using System.Runtime.CompilerServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

namespace CSharpScript.Game.Module.Plot.Sequence.Assistant
{
	// Token: 0x02005033 RID: 20531
	[NullableContext(2)]
	[Nullable(0)]
	public class SeqBaseAssistant : ControllerAssistantBase
	{
		// Token: 0x060348C6 RID: 215238 RVA: 0x00C65AF7 File Offset: 0x00C63CF7
		protected void DoCallback(bool result)
		{
			if (this.Callback != null)
			{
				Action<bool> callback = this.Callback;
				this.Callback = null;
				callback(result);
			}
		}

		// Token: 0x060348C7 RID: 215239 RVA: 0x00C65B14 File Offset: 0x00C63D14
		public virtual void End()
		{
		}

		// Token: 0x060348C8 RID: 215240 RVA: 0x00C65B16 File Offset: 0x00C63D16
		public virtual void Load(Action<bool> callback = null)
		{
		}

		// Token: 0x060348C9 RID: 215241 RVA: 0x00C65B18 File Offset: 0x00C63D18
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

		// Token: 0x060348CA RID: 215242 RVA: 0x00C65B5B File Offset: 0x00C63D5B
		public virtual void PreAllPlay(Action<bool> callback = null)
		{
		}

		// Token: 0x060348CB RID: 215243 RVA: 0x00C65B60 File Offset: 0x00C63D60
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

		// Token: 0x060348CC RID: 215244 RVA: 0x00C65BA3 File Offset: 0x00C63DA3
		public virtual void PreEachPlay()
		{
		}

		// Token: 0x060348CD RID: 215245 RVA: 0x00C65BA5 File Offset: 0x00C63DA5
		public virtual void EachStop()
		{
		}

		// Token: 0x060348CE RID: 215246 RVA: 0x00C65BA7 File Offset: 0x00C63DA7
		public virtual void CmdShadowUpdate()
		{
		}

		// Token: 0x060348CF RID: 215247 RVA: 0x00C65BA9 File Offset: 0x00C63DA9
		public virtual void AllStop(Action<bool> callback = null)
		{
		}

		// Token: 0x060348D0 RID: 215248 RVA: 0x00C65BAC File Offset: 0x00C63DAC
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

		// Token: 0x060348D1 RID: 215249 RVA: 0x00C65BEF File Offset: 0x00C63DEF
		public virtual void LoadNecessaryData(Action callback = null)
		{
		}

		// Token: 0x060348D2 RID: 215250 RVA: 0x00C65BF1 File Offset: 0x00C63DF1
		protected override void OnDestroy()
		{
		}

		// Token: 0x0401C004 RID: 114692
		[Nullable(1)]
		protected SequenceModel Model = SequenceModel.Instance;

		// Token: 0x0401C005 RID: 114693
		protected bool IsRunning;

		// Token: 0x0401C006 RID: 114694
		protected Action<bool> Callback;

		// Token: 0x0401C007 RID: 114695
		protected CustomPromise<bool> Promise;
	}
}
