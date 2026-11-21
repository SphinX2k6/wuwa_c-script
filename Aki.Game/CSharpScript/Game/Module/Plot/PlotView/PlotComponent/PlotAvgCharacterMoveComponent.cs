using System;
using System.Runtime.CompilerServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

namespace CSharpScript.Game.Module.Plot.PlotView.PlotComponent
{
	// Token: 0x0200404B RID: 16459
	public class PlotAvgCharacterMoveComponent
	{
		// Token: 0x06029BAB RID: 170923 RVA: 0x00BCAD64 File Offset: 0x00BC8F64
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

		// Token: 0x06029BAC RID: 170924 RVA: 0x00BCADAF File Offset: 0x00BC8FAF
		public void StopCharacterMove()
		{
			this.ResetMove(false);
			this.Tweener.KillTween();
		}

		// Token: 0x06029BAD RID: 170925 RVA: 0x00BCADC3 File Offset: 0x00BC8FC3
		private void OnValueUpdate(float value)
		{
			IPlotAvgCharacterMove movingCharacter = this.MovingCharacter;
			if (movingCharacter == null)
			{
				return;
			}
			movingCharacter.SetPosition(value);
		}

		// Token: 0x06029BAE RID: 170926 RVA: 0x00BCADD6 File Offset: 0x00BC8FD6
		private void OnMoveComplete()
		{
			this.ResetMove(true);
		}

		// Token: 0x06029BAF RID: 170927 RVA: 0x00BCADE0 File Offset: 0x00BC8FE0
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

		// Token: 0x06029BB0 RID: 170928 RVA: 0x00BCAE40 File Offset: 0x00BC9040
		public void Clear()
		{
			this.ResetMove(false);
			this.Tweener.Destroy();
		}

		// Token: 0x06029BB1 RID: 170929 RVA: 0x00BCAE54 File Offset: 0x00BC9054
		public bool GetIsMoving()
		{
			return this.IsMoving;
		}

		// Token: 0x04016C3F RID: 93247
		[Nullable(2)]
		private IPlotAvgCharacterMove MovingCharacter;

		// Token: 0x04016C40 RID: 93248
		private bool IsMoving;

		// Token: 0x04016C41 RID: 93249
		private float MoveDuration;

		// Token: 0x04016C42 RID: 93250
		private float MoveStartPosition;

		// Token: 0x04016C43 RID: 93251
		private float MoveEndPosition;

		// Token: 0x04016C44 RID: 93252
		[Nullable(1)]
		private readonly LguiFloatTween Tweener = new LguiFloatTween();

		// Token: 0x04016C45 RID: 93253
		[Nullable(2)]
		private CustomPromise<bool> MovingPromise;
	}
}
