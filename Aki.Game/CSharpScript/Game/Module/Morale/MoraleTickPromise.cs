using System;
using System.Runtime.CompilerServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

namespace CSharpScript.Game.Module.Morale
{
	// Token: 0x020043A0 RID: 17312
	[NullableContext(2)]
	[Nullable(0)]
	public class MoraleTickPromise
	{
		// Token: 0x0602BBAD RID: 179117 RVA: 0x00C45E4E File Offset: 0x00C4404E
		private MoraleTickPromise()
		{
		}

		// Token: 0x0602BBAE RID: 179118 RVA: 0x00C45E56 File Offset: 0x00C44056
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

		// Token: 0x0602BBAF RID: 179119 RVA: 0x00C45E84 File Offset: 0x00C44084
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

		// Token: 0x0602BBB0 RID: 179120 RVA: 0x00C45ED0 File Offset: 0x00C440D0
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

		// Token: 0x0602BBB1 RID: 179121 RVA: 0x00C45F31 File Offset: 0x00C44131
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

		// Token: 0x0602BBB2 RID: 179122 RVA: 0x00C45F67 File Offset: 0x00C44167
		public void Stop()
		{
			if (this.IsPlaying)
			{
				this.Finish();
			}
		}

		// Token: 0x0602BBB3 RID: 179123 RVA: 0x00C45F77 File Offset: 0x00C44177
		public void Destroy()
		{
			this.PlayStartCallback = null;
			this.PlayTickCallback = null;
			this.PlayEndCallback = null;
			this.Stop();
		}

		// Token: 0x04017919 RID: 96537
		public CustomPromise Promise;

		// Token: 0x0401791A RID: 96538
		public bool IsPlaying;

		// Token: 0x0401791B RID: 96539
		public float AddDeltaTime;

		// Token: 0x0401791C RID: 96540
		public float TotalTime;

		// Token: 0x0401791D RID: 96541
		public Action PlayStartCallback;

		// Token: 0x0401791E RID: 96542
		public Action<float> PlayTickCallback;

		// Token: 0x0401791F RID: 96543
		public Action PlayEndCallback;
	}
}
