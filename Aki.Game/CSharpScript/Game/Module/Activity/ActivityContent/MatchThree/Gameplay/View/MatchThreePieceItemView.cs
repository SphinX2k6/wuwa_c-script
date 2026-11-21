using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Activity.ActivityContent.MatchThree.Gameplay.Core;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.MatchThree.Gameplay.View
{
	// Token: 0x0200545D RID: 21597
	[NullableContext(2)]
	[Nullable(0)]
	public class MatchThreePieceItemView : UiPanelBase
	{
		// Token: 0x060359B9 RID: 219577 RVA: 0x00EF99C3 File Offset: 0x00EF7BC3
		public void BindData(EPieceType type, bool skipInitialVisualReset = false)
		{
			this.Type = type;
			this.SkipInitialVisualReset = skipInitialVisualReset;
		}

		// Token: 0x060359BA RID: 219578 RVA: 0x00EF99D3 File Offset: 0x00EF7BD3
		public void SetType(EPieceType type)
		{
			this.Type = type;
			this.RefreshAppearance();
		}

		// Token: 0x060359BB RID: 219579 RVA: 0x00EF99E2 File Offset: 0x00EF7BE2
		public void RefreshState(Piece piece)
		{
			this.Piece = piece;
			this.RefreshAppearance();
		}

		// Token: 0x060359BC RID: 219580 RVA: 0x00EF99F4 File Offset: 0x00EF7BF4
		protected override UniTask OnBeforeStartAsync()
		{
			MatchThreePieceItemView.<OnBeforeStartAsync>d__7 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<MatchThreePieceItemView.<OnBeforeStartAsync>d__7>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x060359BD RID: 219581 RVA: 0x00EF9A37 File Offset: 0x00EF7C37
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

		// Token: 0x060359BE RID: 219582 RVA: 0x00EF9A60 File Offset: 0x00EF7C60
		protected virtual UniTask PrepareAppearanceAsync()
		{
			this.RefreshAppearance();
			return UniTask.CompletedTask;
		}

		// Token: 0x060359BF RID: 219583 RVA: 0x00EF9A70 File Offset: 0x00EF7C70
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

		// Token: 0x060359C0 RID: 219584 RVA: 0x00EF9B34 File Offset: 0x00EF7D34
		protected override void OnBeforeDestroy()
		{
			UiSequencePlayer sequencePlayer = this.SequencePlayer;
			if (sequencePlayer != null)
			{
				sequencePlayer.Clear();
			}
			this.SequencePlayer = null;
		}

		// Token: 0x060359C1 RID: 219585 RVA: 0x00EF9B4E File Offset: 0x00EF7D4E
		protected virtual void RefreshAppearance()
		{
		}

		// Token: 0x060359C2 RID: 219586 RVA: 0x00EF9B50 File Offset: 0x00EF7D50
		public virtual void RefreshLives(int lives)
		{
		}

		// Token: 0x060359C3 RID: 219587 RVA: 0x00EF9B54 File Offset: 0x00EF7D54
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

		// Token: 0x060359C4 RID: 219588 RVA: 0x00EF9B88 File Offset: 0x00EF7D88
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

		// Token: 0x0401C566 RID: 116070
		protected EPieceType Type;

		// Token: 0x0401C567 RID: 116071
		protected Piece Piece;

		// Token: 0x0401C568 RID: 116072
		protected UiSequencePlayer SequencePlayer;

		// Token: 0x0401C569 RID: 116073
		private bool SkipInitialVisualReset;
	}
}
