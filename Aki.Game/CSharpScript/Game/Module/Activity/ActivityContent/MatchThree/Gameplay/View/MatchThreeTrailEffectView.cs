using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.MatchThree.Gameplay.View
{
	// Token: 0x02005466 RID: 21606
	[NullableContext(2)]
	[Nullable(0)]
	public class MatchThreeTrailEffectView : UiPanelBase
	{
		// Token: 0x06035A3E RID: 219710 RVA: 0x00EFC0EB File Offset: 0x00EFA2EB
		public void SetCurves(UCurveFloat curveX, UCurveFloat curveY)
		{
			this.CurveX = curveX;
			this.CurveY = curveY;
		}

		// Token: 0x06035A3F RID: 219711 RVA: 0x00EFC0FB File Offset: 0x00EFA2FB
		public void BindBoard(float originX, float originY, float stepX, float stepY)
		{
			this.BoardOriginX = originX;
			this.BoardOriginY = originY;
			this.CellStepX = stepX;
			this.CellStepY = stepY;
		}

		// Token: 0x06035A40 RID: 219712 RVA: 0x00EFC11C File Offset: 0x00EFA31C
		public void ResetForReuse(GridPosition origin)
		{
			this.KillTween();
			this.MoveToAbs(this.BoardOriginX + (float)origin.Col * this.CellStepX, this.BoardOriginY - (float)origin.Row * this.CellStepY);
			UUIItem rootItem = this.RootItem;
			if (rootItem == null)
			{
				return;
			}
			rootItem.SetUIActive(true);
		}

		// Token: 0x06035A41 RID: 219713 RVA: 0x00EFC170 File Offset: 0x00EFA370
		[NullableContext(1)]
		public void ResetForReuseAt(UUIItem from)
		{
			this.KillTween();
			FVector lguispaceCenterAbsolutePosition = from.GetLGUISpaceCenterAbsolutePosition();
			this.MoveToAbs(lguispaceCenterAbsolutePosition.X, lguispaceCenterAbsolutePosition.Y);
			UUIItem rootItem = this.RootItem;
			if (rootItem == null)
			{
				return;
			}
			rootItem.SetUIActive(true);
		}

		// Token: 0x06035A42 RID: 219714 RVA: 0x00EFC1AD File Offset: 0x00EFA3AD
		public void RecycleToPool()
		{
			this.KillTween();
			UUIItem rootItem = this.RootItem;
			if (rootItem == null)
			{
				return;
			}
			rootItem.SetUIActive(false);
		}

		// Token: 0x06035A43 RID: 219715 RVA: 0x00EFC1C6 File Offset: 0x00EFA3C6
		public UniTask FlyToAsync(GridPosition target, int extraMs = 0)
		{
			return this.FlyToAbsAsync(this.BoardOriginX + (float)target.Col * this.CellStepX, this.BoardOriginY - (float)target.Row * this.CellStepY, extraMs);
		}

		// Token: 0x06035A44 RID: 219716 RVA: 0x00EFC1FC File Offset: 0x00EFA3FC
		[NullableContext(1)]
		public UniTask FlyToAsync(UUIItem target)
		{
			FVector lguispaceCenterAbsolutePosition = target.GetLGUISpaceCenterAbsolutePosition();
			return this.FlyToAbsAsync(lguispaceCenterAbsolutePosition.X, lguispaceCenterAbsolutePosition.Y, 0);
		}

		// Token: 0x06035A45 RID: 219717 RVA: 0x00EFC224 File Offset: 0x00EFA424
		private UniTask FlyToAbsAsync(float centerAbsX, float centerAbsY, int extraMs = 0)
		{
			this.KillTween();
			if (this.RootItem == null)
			{
				return UniTask.CompletedTask;
			}
			float toX;
			float toY;
			this.AbsToOffset(centerAbsX, centerAbsY, out toX, out toY);
			return this.FlyToOffsetAsync(this.RootItem.GetAnchorOffsetX(), this.RootItem.GetAnchorOffsetY(), toX, toY, extraMs);
		}

		// Token: 0x06035A46 RID: 219718 RVA: 0x00EFC270 File Offset: 0x00EFA470
		private UniTask FlyToOffsetAsync(float fromX, float fromY, float toX, float toY, int extraMs)
		{
			int num = MatchThreeTrailEffectView.FlyMs(fromX, fromY, toX, toY) + extraMs;
			if (num <= 0)
			{
				this.SetLocalOffset(toX, toY);
				return UniTask.CompletedTask;
			}
			this.Tweener = ((this.CurveX != null && this.CurveY != null) ? this.StartCurveTween(fromX, fromY, toX, toY, num) : this.StartLineTween(fromX, fromY, toX, toY, num));
			if (this.Tweener == null)
			{
				this.SetLocalOffset(toX, toY);
				return UniTask.CompletedTask;
			}
			this.Tcs = AutoResetUniTaskCompletionSource.Create();
			FLTweenerDynamicDelegate onCompleteCallBack = this.Tweener.OnCompleteCallBack;
			Action callback;
			if ((callback = this.CompleteAction) == null)
			{
				callback = (this.CompleteAction = new Action(this.OnTweenComplete));
			}
			onCompleteCallBack.Bind(callback);
			return this.Tcs.Task;
		}

		// Token: 0x06035A47 RID: 219719 RVA: 0x00EFC32C File Offset: 0x00EFA52C
		private ULTweener StartLineTween(float fromX, float fromY, float toX, float toY, int durationMs)
		{
			if (this.MoveSetter == null)
			{
				this.MoveSetter = DelegateUtils.ToManualReleaseDelegate<FLTweenVector2SetterDynamic>(new Action<FVector2D>(this.OnTweenLocation));
			}
			this.TempFrom.Set((double)fromX, (double)fromY);
			this.TempLocation.Set((double)toX, (double)toY);
			return ULTweenBPLibrary.Vector2To(GlobalData.World, this.MoveSetter, this.TempFrom.ToUeVector2D(true), this.TempLocation.ToUeVector2D(true), (float)durationMs / 1000f, 0f, LTweenEase.InQuad);
		}

		// Token: 0x06035A48 RID: 219720 RVA: 0x00EFC3B0 File Offset: 0x00EFA5B0
		private ULTweener StartCurveTween(float fromX, float fromY, float toX, float toY, int durationMs)
		{
			this.FromX = fromX;
			this.FromY = fromY;
			this.ToX = toX;
			this.ToY = toY;
			if (this.ProgressSetter == null)
			{
				this.ProgressSetter = DelegateUtils.ToManualReleaseDelegate<FLTweenFloatSetterDynamic>(new Action<float>(this.OnTweenProgress));
			}
			return ULTweenBPLibrary.FloatTo(GlobalData.World, this.ProgressSetter, 0f, 1f, (float)durationMs / 1000f, 0f, LTweenEase.Linear);
		}

		// Token: 0x06035A49 RID: 219721 RVA: 0x00EFC424 File Offset: 0x00EFA624
		private void MoveToAbs(float centerAbsX, float centerAbsY)
		{
			if (this.RootItem == null)
			{
				return;
			}
			float x;
			float y;
			this.AbsToOffset(centerAbsX, centerAbsY, out x, out y);
			this.SetLocalOffset(x, y);
		}

		// Token: 0x06035A4A RID: 219722 RVA: 0x00EFC450 File Offset: 0x00EFA650
		private void AbsToOffset(float centerAbsX, float centerAbsY, out float offsetX, out float offsetY)
		{
			FVector relativeLocation = this.RootItem.RelativeLocation;
			float num = 0f;
			float num2 = 0f;
			UUIItem parentAsUIItem = this.RootItem.GetParentAsUIItem();
			if (parentAsUIItem != null)
			{
				FVector lguispaceAbsolutePosition = parentAsUIItem.GetLGUISpaceAbsolutePosition();
				num = lguispaceAbsolutePosition.X;
				num2 = lguispaceAbsolutePosition.Y;
			}
			FVector2D pivot = this.RootItem.GetPivot();
			offsetX = centerAbsX - (0.5f - pivot.X) * this.RootItem.GetWidth() - num - (relativeLocation.X - this.RootItem.GetAnchorOffsetX());
			offsetY = centerAbsY - (0.5f - pivot.Y) * this.RootItem.GetHeight() - num2 - (relativeLocation.Y - this.RootItem.GetAnchorOffsetY());
		}

		// Token: 0x06035A4B RID: 219723 RVA: 0x00EFC509 File Offset: 0x00EFA709
		private void SetLocalOffset(float x, float y)
		{
			this.TempLocation.Set((double)x, (double)y);
			UUIItem rootItem = this.RootItem;
			if (rootItem == null)
			{
				return;
			}
			rootItem.SetAnchorOffset(this.TempLocation.ToUeVector2D(true));
		}

		// Token: 0x06035A4C RID: 219724 RVA: 0x00EFC536 File Offset: 0x00EFA736
		private static int FlyMs(float fromX, float fromY, float toX, float toY)
		{
			return (int)((Math.Abs(toX - fromX) + Math.Abs(toY - fromY)) / 2500f * 1000f);
		}

		// Token: 0x06035A4D RID: 219725 RVA: 0x00EFC556 File Offset: 0x00EFA756
		private void OnTweenLocation(FVector2D value)
		{
			UUIItem rootItem = this.RootItem;
			if (rootItem == null)
			{
				return;
			}
			rootItem.SetAnchorOffset(value);
		}

		// Token: 0x06035A4E RID: 219726 RVA: 0x00EFC56C File Offset: 0x00EFA76C
		private void OnTweenProgress(float t)
		{
			this.SetLocalOffset(this.FromX + (this.ToX - this.FromX) * this.CurveX.GetFloatValue(t), this.FromY + (this.ToY - this.FromY) * this.CurveY.GetFloatValue(t));
		}

		// Token: 0x06035A4F RID: 219727 RVA: 0x00EFC5C1 File Offset: 0x00EFA7C1
		private void OnTweenComplete()
		{
			this.Tweener = null;
			AutoResetUniTaskCompletionSource tcs = this.Tcs;
			this.Tcs = null;
			if (tcs == null)
			{
				return;
			}
			tcs.TrySetResult();
		}

		// Token: 0x06035A50 RID: 219728 RVA: 0x00EFC5E4 File Offset: 0x00EFA7E4
		private void KillTween()
		{
			ULTweener tweener = this.Tweener;
			if (tweener != null && tweener.IsValid())
			{
				this.Tweener.Kill(false);
			}
			this.Tweener = null;
			AutoResetUniTaskCompletionSource tcs = this.Tcs;
			this.Tcs = null;
			if (tcs == null)
			{
				return;
			}
			tcs.TrySetResult();
		}

		// Token: 0x06035A51 RID: 219729 RVA: 0x00EFC630 File Offset: 0x00EFA830
		protected override void OnBeforeDestroy()
		{
			this.KillTween();
			FLTweenVector2SetterDynamic moveSetter = this.MoveSetter;
			if (moveSetter != null && moveSetter.IsBound())
			{
				DelegateUtils.ReleaseManualReleaseDelegate(new Action<FVector2D>(this.OnTweenLocation));
			}
			this.MoveSetter = null;
			FLTweenFloatSetterDynamic progressSetter = this.ProgressSetter;
			if (progressSetter != null && progressSetter.IsBound())
			{
				DelegateUtils.ReleaseManualReleaseDelegate(new Action<float>(this.OnTweenProgress));
			}
			this.ProgressSetter = null;
		}

		// Token: 0x0401C5B0 RID: 116144
		[Nullable(1)]
		private readonly Vector2D TempLocation = Vector2D.Create();

		// Token: 0x0401C5B1 RID: 116145
		[Nullable(1)]
		private readonly Vector2D TempFrom = Vector2D.Create();

		// Token: 0x0401C5B2 RID: 116146
		private ULTweener Tweener;

		// Token: 0x0401C5B3 RID: 116147
		private AutoResetUniTaskCompletionSource Tcs;

		// Token: 0x0401C5B4 RID: 116148
		private FLTweenVector2SetterDynamic MoveSetter;

		// Token: 0x0401C5B5 RID: 116149
		private FLTweenFloatSetterDynamic ProgressSetter;

		// Token: 0x0401C5B6 RID: 116150
		private Action CompleteAction;

		// Token: 0x0401C5B7 RID: 116151
		private UCurveFloat CurveX;

		// Token: 0x0401C5B8 RID: 116152
		private UCurveFloat CurveY;

		// Token: 0x0401C5B9 RID: 116153
		private float FromX;

		// Token: 0x0401C5BA RID: 116154
		private float FromY;

		// Token: 0x0401C5BB RID: 116155
		private float ToX;

		// Token: 0x0401C5BC RID: 116156
		private float ToY;

		// Token: 0x0401C5BD RID: 116157
		private float BoardOriginX;

		// Token: 0x0401C5BE RID: 116158
		private float BoardOriginY;

		// Token: 0x0401C5BF RID: 116159
		private float CellStepX;

		// Token: 0x0401C5C0 RID: 116160
		private float CellStepY;
	}
}
