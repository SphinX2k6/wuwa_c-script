using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.LevelGamePlay.Common;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.SlidingBlocks.View
{
	// Token: 0x02003B3C RID: 15164
	[NullableContext(1)]
	[Nullable(0)]
	public class PrepareCountDownItem : CommonMarkItem
	{
		// Token: 0x06026FAA RID: 159658 RVA: 0x00AE966A File Offset: 0x00AE786A
		public PrepareCountDownItem(FVectorDouble targetPosition) : base(targetPosition, null)
		{
		}

		// Token: 0x06026FAB RID: 159659 RVA: 0x00AE9698 File Offset: 0x00AE7898
		protected unsafe override void OnRegisterComponent()
		{
			int num = 1;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int index = 0;
			*span[index] = new ValueTuple<int, Type>(0, typeof(UUIText));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x06026FAC RID: 159660 RVA: 0x00AE96E0 File Offset: 0x00AE78E0
		protected override void OnStart()
		{
			this.SequencePlayer = new LevelSequencePlayer(this.RootItem);
		}

		// Token: 0x06026FAD RID: 159661 RVA: 0x00AE96F4 File Offset: 0x00AE78F4
		protected override UniTask OnShowAsyncImplementImplement()
		{
			PrepareCountDownItem.<OnShowAsyncImplementImplement>d__9 <OnShowAsyncImplementImplement>d__;
			<OnShowAsyncImplementImplement>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnShowAsyncImplementImplement>d__.<>4__this = this;
			<OnShowAsyncImplementImplement>d__.<>1__state = -1;
			<OnShowAsyncImplementImplement>d__.<>t__builder.Start<PrepareCountDownItem.<OnShowAsyncImplementImplement>d__9>(ref <OnShowAsyncImplementImplement>d__);
			return <OnShowAsyncImplementImplement>d__.<>t__builder.Task;
		}

		// Token: 0x06026FAE RID: 159662 RVA: 0x00AE9738 File Offset: 0x00AE7938
		protected override UniTask OnHideAsyncImplementImplement()
		{
			PrepareCountDownItem.<OnHideAsyncImplementImplement>d__10 <OnHideAsyncImplementImplement>d__;
			<OnHideAsyncImplementImplement>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnHideAsyncImplementImplement>d__.<>4__this = this;
			<OnHideAsyncImplementImplement>d__.<>1__state = -1;
			<OnHideAsyncImplementImplement>d__.<>t__builder.Start<PrepareCountDownItem.<OnHideAsyncImplementImplement>d__10>(ref <OnHideAsyncImplementImplement>d__);
			return <OnHideAsyncImplementImplement>d__.<>t__builder.Task;
		}

		// Token: 0x06026FAF RID: 159663 RVA: 0x00AE977C File Offset: 0x00AE797C
		public override void OnTick(float delta)
		{
			SlidingBlocksGameData gameData = SlidingBlocksModel.Instance.GameData;
			Tetromino curTetromino = gameData.CurTetromino;
			if (curTetromino == null || curTetromino.GetState() != ETetrominoState.Aiming)
			{
				this.SetShowOrHide(false);
				return;
			}
			this.SetShowOrHide(true);
			double num = Math.Ceiling((double)curTetromino.RemainAimTime * TimeUtil.Instance.Millisecond);
			if (!num.Equals(this.LastSecond) && num <= 5.0)
			{
				LevelSequencePlayer sequencePlayer = this.SequencePlayer;
				if (((sequencePlayer != null) ? sequencePlayer.GetCurrentSequence() : null) == null)
				{
					CustomPromise<bool> stopPromise = new CustomPromise<bool>();
					LevelSequencePlayer sequencePlayer2 = this.SequencePlayer;
					if (sequencePlayer2 != null)
					{
						sequencePlayer2.PlaySequenceAsync("Up", stopPromise, false, false, null, false).Forget();
					}
				}
			}
			UUIText text = base.GetText(0);
			if (text != null)
			{
				text.SetText(num.ToString(), true);
			}
			this.LastSecond = num;
			this.GetTargetCoord(curTetromino, this.TargetCoord);
			SlidingBlocksUtil.GetWorldLocationByCoord(this.TargetCoord.X, this.TargetCoord.Y, gameData.OriginTransform, this.TargetWorldLocation);
			this.TargetPosition.Set(this.TargetWorldLocation.X, this.TargetWorldLocation.Y, this.TargetWorldLocation.Z);
			base.OnTick(delta);
		}

		// Token: 0x06026FB0 RID: 159664 RVA: 0x00AE98B5 File Offset: 0x00AE7AB5
		protected override bool ClampToEllipse(Vector2D vector, bool inFront)
		{
			return true;
		}

		// Token: 0x06026FB1 RID: 159665 RVA: 0x00AE98B8 File Offset: 0x00AE7AB8
		private void GetTargetCoord(Tetromino tetromino, Vector2D @out)
		{
			Mino geometricCenterMino = tetromino.GeometricCenterMino;
			if (geometricCenterMino == null)
			{
				return;
			}
			tetromino.GetMinoCoordInGrid(geometricCenterMino.Coord.X, geometricCenterMino.Coord.Y, @out, null, null);
			if (@out.Y > 2.0)
			{
				return;
			}
			foreach (KeyValuePair<string, Mino> keyValuePair in tetromino.MinoDataMap)
			{
				string text;
				Mino mino;
				keyValuePair.Deconstruct(out text, out mino);
				Mino mino2 = mino;
				tetromino.GetMinoCoordInGrid(mino2.Coord.X, mino2.Coord.Y, this.TempCoord, null, null);
				if (this.TempCoord.X.Equals(@out.X) && this.TempCoord.Y > @out.Y)
				{
					@out.Y = this.TempCoord.Y;
				}
			}
		}

		// Token: 0x06026FB2 RID: 159666 RVA: 0x00AE99D8 File Offset: 0x00AE7BD8
		private void SetShowOrHide(bool bShow)
		{
			if (bShow)
			{
				if (base.IsShowOrShowing)
				{
					return;
				}
				base.Show(null);
				return;
			}
			else
			{
				if (base.IsHideOrHiding)
				{
					return;
				}
				base.Hide(null);
				return;
			}
		}

		// Token: 0x040154A2 RID: 87202
		private readonly Vector TargetWorldLocation = Vector.Create();

		// Token: 0x040154A3 RID: 87203
		private readonly Vector2D TargetCoord = Vector2D.Create();

		// Token: 0x040154A4 RID: 87204
		private readonly Vector2D TempCoord = Vector2D.Create();

		// Token: 0x040154A5 RID: 87205
		private double LastSecond;

		// Token: 0x040154A6 RID: 87206
		[Nullable(2)]
		private LevelSequencePlayer SequencePlayer;

		// Token: 0x020097BE RID: 38846
		[NullableContext(0)]
		private enum EViewComponent
		{
			// Token: 0x0402F55D RID: 193885
			CountDownText
		}
	}
}
