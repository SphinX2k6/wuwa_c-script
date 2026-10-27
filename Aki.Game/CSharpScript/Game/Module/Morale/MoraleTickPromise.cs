using System;
using System.Runtime.CompilerServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

namespace CSharpScript.Game.Module.Morale
{
	// Token: 0x020053BD RID: 21437
	[NullableContext(2)]
	[Nullable(0)]
	public class MoraleTickPromise
	{
		// Token: 0x06036C67 RID: 224359 RVA: 0x00CF6DA6 File Offset: 0x00CF4FA6
		private MoraleTickPromise()
		{
		}

		// Token: 0x06036C68 RID: 224360 RVA: 0x00CF6DAE File Offset: 0x00CF4FAE
		[NullableContext(1)]
		public static MoraleTickPromise Create(MoraleTickPromiseParams params_)
		{
			return new MoraleTickPromise
			{
				PlayStartCallback = params_.StartCallback,
				PlayTickCallback = params_.TickCallback,
				PlayEndCallback = params_.EndCallback
			};
		}

		// Token: 0x06036C69 RID: 224361 RVA: 0x00CF6DDC File Offset: 0x00CF4FDC
		public UniTask PlayStart(float totalTime)
		{
			MoraleTickPromise.<PlayStart>d__9 <PlayStart>d__;
			<PlayStart>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<PlayStart>d__.<>4__this = this;
			<PlayStart>d__.totalTime = totalTime;
			<PlayStart>d__.<>1__state = -1;
			<PlayStart>d__.<>t__builder.Start<MoraleTickPromise.<PlayStart>d__9>(ref <PlayStart>d__);
			return <PlayStart>d__.<>t__builder.Task;
		}

		// Token: 0x06036C6A RID: 224362 RVA: 0x00CF6E28 File Offset: 0x00CF5028
		public void Tick(float deltaTime)
		{
			if (!this.IsPlaying)
			{
				return;
			}
			this.AddDeltaTime += deltaTime;
			bool flag = this.AddDeltaTime >= this.TotalTime;
			Action<float> playTickCallback = this.PlayTickCallback;
			if (playTickCallback != null)
			{
				playTickCallback(flag ? this.TotalTime : this.AddDeltaTime);
			}
			if (flag)
			{
				this.Finish();
			}
		}

		// Token: 0x06036C6B RID: 224363 RVA: 0x00CF6E89 File Offset: 0x00CF5089
		private void Finish()
		{
			this.IsPlaying = false;
			this.AddDeltaTime = this.TotalTime;
			CustomPromise promise = this.Promise;
			if (promise != null)
			{
				promise.SetResult();
			}
			Action playEndCallback = this.PlayEndCallback;
			if (playEndCallback == null)
			{
				return;
			}
			playEndCallback();
		}

		// Token: 0x06036C6C RID: 224364 RVA: 0x00CF6EBF File Offset: 0x00CF50BF
		public void Stop()
		{
			if (this.IsPlaying)
			{
				this.Finish();
			}
		}

		// Token: 0x06036C6D RID: 224365 RVA: 0x00CF6ECF File Offset: 0x00CF50CF
		public void Destroy()
		{
			this.PlayStartCallback = null;
			this.PlayTickCallback = null;
			this.PlayEndCallback = null;
			this.Stop();
		}

		// Token: 0x0401CE81 RID: 118401
		public CustomPromise Promise;

		// Token: 0x0401CE82 RID: 118402
		public bool IsPlaying;

		// Token: 0x0401CE83 RID: 118403
		public float AddDeltaTime;

		// Token: 0x0401CE84 RID: 118404
		public float TotalTime;

		// Token: 0x0401CE85 RID: 118405
		public Action PlayStartCallback;

		// Token: 0x0401CE86 RID: 118406
		public Action<float> PlayTickCallback;

		// Token: 0x0401CE87 RID: 118407
		public Action PlayEndCallback;
	}
}
