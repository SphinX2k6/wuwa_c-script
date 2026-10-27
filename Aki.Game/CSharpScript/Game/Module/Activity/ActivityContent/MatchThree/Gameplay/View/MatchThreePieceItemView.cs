using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Activity.ActivityContent.MatchThree.Gameplay.Core;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.MatchThree.Gameplay.View
{
	// Token: 0x020064DF RID: 25823
	[NullableContext(2)]
	[Nullable(0)]
	public class MatchThreePieceItemView : UiPanelBase
	{
		// Token: 0x06040CF5 RID: 265461 RVA: 0x00FB2993 File Offset: 0x00FB0B93
		public void BindData(EPieceType type, bool skipInitialVisualReset = false)
		{
			this.Type = type;
			this.SkipInitialVisualReset = skipInitialVisualReset;
		}

		// Token: 0x06040CF6 RID: 265462 RVA: 0x00FB29A3 File Offset: 0x00FB0BA3
		public void SetType(EPieceType type)
		{
			this.Type = type;
			this.RefreshAppearance();
		}

		// Token: 0x06040CF7 RID: 265463 RVA: 0x00FB29B2 File Offset: 0x00FB0BB2
		public void RefreshState(Piece piece)
		{
			this.Piece = piece;
			this.RefreshAppearance();
		}

		// Token: 0x06040CF8 RID: 265464 RVA: 0x00FB29C4 File Offset: 0x00FB0BC4
		protected override UniTask OnBeforeStartAsync()
		{
			MatchThreePieceItemView.<OnBeforeStartAsync>d__7 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<MatchThreePieceItemView.<OnBeforeStartAsync>d__7>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06040CF9 RID: 265465 RVA: 0x00FB2A07 File Offset: 0x00FB0C07
		protected override void OnStart()
		{
			this.SequencePlayer = new UiSequencePlayer(this.RootItem);
			if (this.SkipInitialVisualReset)
			{
				this.SkipInitialVisualReset = false;
				return;
			}
			this.ResetVisualState();
		}

		// Token: 0x06040CFA RID: 265466 RVA: 0x00FB2A30 File Offset: 0x00FB0C30
		protected virtual UniTask PrepareAppearanceAsync()
		{
			this.RefreshAppearance();
			return UniTask.CompletedTask;
		}

		// Token: 0x06040CFB RID: 265467 RVA: 0x00FB2A40 File Offset: 0x00FB0C40
		public virtual void ResetVisualState()
		{
			if (!UiManager.Instance.IsViewShow(EUiViewName.MatchThreeGameplayView))
			{
				AUIBaseActor rootActor = this.RootActor;
				ALevelSequenceActor alevelSequenceActor = (rootActor != null) ? rootActor.GetSequencePlayerByKey("Start") : null;
				if (this.RootActor != null)
				{
					bool flag;
					if (alevelSequenceActor == null)
					{
						flag = true;
					}
					else
					{
						ULevelSequencePlayer sequencePlayer = alevelSequenceActor.SequencePlayer;
						flag = !((sequencePlayer != null) ? new bool?(sequencePlayer.IsValid()) : null).GetValueOrDefault();
					}
					if (!flag)
					{
						AUIBaseActor rootActor2 = this.RootActor;
						string name = "Start";
						FFrameTime time = alevelSequenceActor.SequencePlayer.GetDuration().Time;
						rootActor2.SequenceJumpToSecondByKey(name, time);
						return;
					}
				}
				return;
			}
			UiSequencePlayer sequencePlayer2 = this.SequencePlayer;
			if (sequencePlayer2 != null)
			{
				sequencePlayer2.PlaySequencePurely("Start", false, false);
			}
			UiSequencePlayer sequencePlayer3 = this.SequencePlayer;
			if (sequencePlayer3 == null)
			{
				return;
			}
			sequencePlayer3.StopSequenceByKey("Start", false, true);
		}

		// Token: 0x06040CFC RID: 265468 RVA: 0x00FB2B04 File Offset: 0x00FB0D04
		protected override void OnBeforeDestroy()
		{
			UiSequencePlayer sequencePlayer = this.SequencePlayer;
			if (sequencePlayer != null)
			{
				sequencePlayer.Clear();
			}
			this.SequencePlayer = null;
		}

		// Token: 0x06040CFD RID: 265469 RVA: 0x00FB2B1E File Offset: 0x00FB0D1E
		protected virtual void RefreshAppearance()
		{
		}

		// Token: 0x06040CFE RID: 265470 RVA: 0x00FB2B20 File Offset: 0x00FB0D20
		public virtual void RefreshLives(int lives)
		{
		}

		// Token: 0x06040CFF RID: 265471 RVA: 0x00FB2B24 File Offset: 0x00FB0D24
		[NullableContext(1)]
		public UniTask PlayAnimAsync(string sequence)
		{
			UiSequencePlayer sequencePlayer = this.SequencePlayer;
			if (sequencePlayer == null)
			{
				return UniTask.CompletedTask;
			}
			return sequencePlayer.PlaySequenceAsync(sequence, new CustomPromise<bool>(), false, false, null);
		}

		// Token: 0x06040D00 RID: 265472 RVA: 0x00FB2B58 File Offset: 0x00FB0D58
		public UniTask PlayBoardRefreshAsync()
		{
			string text = EMatchThreePieceSequence.Born.ToEnumString();
			AUIBaseActor rootActor = this.RootActor;
			if (((rootActor != null) ? rootActor.GetSequencePlayContextOfKey(text) : null) == null)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.MatchThree;
				ELogAuthor author = ELogAuthor.HMQ;
				string message = "[PlayBoardRefreshAsync] 棋子缺少 Born 动效";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("Type", this.Type);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return UniTask.CompletedTask;
			}
			return this.PlayAnimAsync(text);
		}

		// Token: 0x04021C35 RID: 138293
		protected EPieceType Type;

		// Token: 0x04021C36 RID: 138294
		protected Piece Piece;

		// Token: 0x04021C37 RID: 138295
		protected UiSequencePlayer SequencePlayer;

		// Token: 0x04021C38 RID: 138296
		private bool SkipInitialVisualReset;
	}
}
