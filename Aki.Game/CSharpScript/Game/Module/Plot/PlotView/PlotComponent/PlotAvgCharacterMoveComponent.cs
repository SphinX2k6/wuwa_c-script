using System;
using System.Runtime.CompilerServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

namespace CSharpScript.Game.Module.Plot.PlotView.PlotComponent
{
	// Token: 0x0200507B RID: 20603
	public class PlotAvgCharacterMoveComponent
	{
		// Token: 0x06034CB6 RID: 216246 RVA: 0x00C7D98C File Offset: 0x00C7BB8C
		public UniTask<bool> PlayCharacterMoveAsync([Nullable(1)] IPlotAvgMoveComponentPlayContext context)
		{
			PlotAvgCharacterMoveComponent.<PlayCharacterMoveAsync>d__7 <PlayCharacterMoveAsync>d__;
			<PlayCharacterMoveAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<PlayCharacterMoveAsync>d__.<>4__this = this;
			<PlayCharacterMoveAsync>d__.context = context;
			<PlayCharacterMoveAsync>d__.<>1__state = -1;
			<PlayCharacterMoveAsync>d__.<>t__builder.Start<PlotAvgCharacterMoveComponent.<PlayCharacterMoveAsync>d__7>(ref <PlayCharacterMoveAsync>d__);
			return <PlayCharacterMoveAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06034CB7 RID: 216247 RVA: 0x00C7D9D7 File Offset: 0x00C7BBD7
		public void StopCharacterMove()
		{
			this.ResetMove(false);
			this.Tweener.KillTween();
		}

		// Token: 0x06034CB8 RID: 216248 RVA: 0x00C7D9EB File Offset: 0x00C7BBEB
		private void OnValueUpdate(float value)
		{
			IPlotAvgCharacterMove movingCharacter = this.MovingCharacter;
			if (movingCharacter == null)
			{
				return;
			}
			movingCharacter.SetPosition(value);
		}

		// Token: 0x06034CB9 RID: 216249 RVA: 0x00C7D9FE File Offset: 0x00C7BBFE
		private void OnMoveComplete()
		{
			this.ResetMove(true);
		}

		// Token: 0x06034CBA RID: 216250 RVA: 0x00C7DA08 File Offset: 0x00C7BC08
		private void ResetMove(bool bComplete)
		{
			this.IsMoving = false;
			this.MovingCharacter = null;
			this.MoveDuration = 0f;
			this.MoveStartPosition = 0f;
			this.MoveEndPosition = 0f;
			this.Tweener.KillTween();
			CustomPromise<bool> movingPromise = this.MovingPromise;
			if (movingPromise != null)
			{
				movingPromise.SetResult(bComplete);
			}
			this.MovingPromise = null;
		}

		// Token: 0x06034CBB RID: 216251 RVA: 0x00C7DA68 File Offset: 0x00C7BC68
		public void Clear()
		{
			this.ResetMove(false);
			this.Tweener.Destroy();
		}

		// Token: 0x06034CBC RID: 216252 RVA: 0x00C7DA7C File Offset: 0x00C7BC7C
		public bool GetIsMoving()
		{
			return this.IsMoving;
		}

		// Token: 0x0401C214 RID: 115220
		[Nullable(2)]
		private IPlotAvgCharacterMove MovingCharacter;

		// Token: 0x0401C215 RID: 115221
		private bool IsMoving;

		// Token: 0x0401C216 RID: 115222
		private float MoveDuration;

		// Token: 0x0401C217 RID: 115223
		private float MoveStartPosition;

		// Token: 0x0401C218 RID: 115224
		private float MoveEndPosition;

		// Token: 0x0401C219 RID: 115225
		[Nullable(1)]
		private readonly LguiFloatTween Tweener = new LguiFloatTween();

		// Token: 0x0401C21A RID: 115226
		[Nullable(2)]
		private CustomPromise<bool> MovingPromise;
	}
}
