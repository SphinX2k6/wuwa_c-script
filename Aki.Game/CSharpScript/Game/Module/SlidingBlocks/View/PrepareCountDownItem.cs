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
	// Token: 0x02004B92 RID: 19346
	[NullableContext(1)]
	[Nullable(0)]
	public class PrepareCountDownItem : CommonMarkItem
	{
		// Token: 0x0603221A RID: 205338 RVA: 0x00BA551E File Offset: 0x00BA371E
		public PrepareCountDownItem(FVectorDouble targetPosition) : base(targetPosition, null)
		{
		}

		// Token: 0x0603221B RID: 205339 RVA: 0x00BA554C File Offset: 0x00BA374C
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

		// Token: 0x0603221C RID: 205340 RVA: 0x00BA5594 File Offset: 0x00BA3794
		protected override void OnStart()
		{
			this.SequencePlayer = new LevelSequencePlayer(this.RootItem);
		}

		// Token: 0x0603221D RID: 205341 RVA: 0x00BA55A8 File Offset: 0x00BA37A8
		protected override UniTask OnShowAsyncImplementImplement()
		{
			PrepareCountDownItem.<OnShowAsyncImplementImplement>d__9 <OnShowAsyncImplementImplement>d__;
			<OnShowAsyncImplementImplement>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnShowAsyncImplementImplement>d__.<>4__this = this;
			<OnShowAsyncImplementImplement>d__.<>1__state = -1;
			<OnShowAsyncImplementImplement>d__.<>t__builder.Start<PrepareCountDownItem.<OnShowAsyncImplementImplement>d__9>(ref <OnShowAsyncImplementImplement>d__);
			return <OnShowAsyncImplementImplement>d__.<>t__builder.Task;
		}

		// Token: 0x0603221E RID: 205342 RVA: 0x00BA55EC File Offset: 0x00BA37EC
		protected override UniTask OnHideAsyncImplementImplement()
		{
			PrepareCountDownItem.<OnHideAsyncImplementImplement>d__10 <OnHideAsyncImplementImplement>d__;
			<OnHideAsyncImplementImplement>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnHideAsyncImplementImplement>d__.<>4__this = this;
			<OnHideAsyncImplementImplement>d__.<>1__state = -1;
			<OnHideAsyncImplementImplement>d__.<>t__builder.Start<PrepareCountDownItem.<OnHideAsyncImplementImplement>d__10>(ref <OnHideAsyncImplementImplement>d__);
			return <OnHideAsyncImplementImplement>d__.<>t__builder.Task;
		}

		// Token: 0x0603221F RID: 205343 RVA: 0x00BA5630 File Offset: 0x00BA3830
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

		// Token: 0x06032220 RID: 205344 RVA: 0x00BA5769 File Offset: 0x00BA3969
		protected override bool ClampToEllipse(Vector2D vector, bool inFront)
		{
			return true;
		}

		// Token: 0x06032221 RID: 205345 RVA: 0x00BA576C File Offset: 0x00BA396C
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

		// Token: 0x06032222 RID: 205346 RVA: 0x00BA588C File Offset: 0x00BA3A8C
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

		// Token: 0x0401AB4E RID: 109390
		private readonly Vector TargetWorldLocation = Vector.Create();

		// Token: 0x0401AB4F RID: 109391
		private readonly Vector2D TargetCoord = Vector2D.Create();

		// Token: 0x0401AB50 RID: 109392
		private readonly Vector2D TempCoord = Vector2D.Create();

		// Token: 0x0401AB51 RID: 109393
		private double LastSecond;

		// Token: 0x0401AB52 RID: 109394
		[Nullable(2)]
		private LevelSequencePlayer SequencePlayer;

		// Token: 0x0200AD9F RID: 44447
		[NullableContext(0)]
		private enum EViewComponent
		{
			// Token: 0x04034BB6 RID: 215990
			CountDownText
		}
	}
}
