using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Activity.ActivityContent.MatchThree.Gameplay.Core;
using CSharpScript.Game.Module.Activity.ActivityContent.MatchThree.Gameplay.Core.Components;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;

namespace CSharpScript.Game.Module.Activity.ActivityContent.MatchThree.Gameplay.View
{
	// Token: 0x020064DE RID: 25822
	[NullableContext(2)]
	[Nullable(0)]
	public class MatchThreePieceAdditionView : UiPanelBase
	{
		// Token: 0x06040CEF RID: 265455 RVA: 0x00FB290C File Offset: 0x00FB0B0C
		[NullableContext(1)]
		public void Refresh(Piece piece, IPieceComponent comp)
		{
			this.Piece = piece;
			this.Component = comp;
			this.RefreshAppearance();
		}

		// Token: 0x06040CF0 RID: 265456 RVA: 0x00FB2922 File Offset: 0x00FB0B22
		protected override void OnStart()
		{
			this.SequencePlayer = new UiSequencePlayer(this.RootItem);
			this.RefreshAppearance();
		}

		// Token: 0x06040CF1 RID: 265457 RVA: 0x00FB293B File Offset: 0x00FB0B3B
		protected override void OnBeforeDestroy()
		{
			UiSequencePlayer sequencePlayer = this.SequencePlayer;
			if (sequencePlayer != null)
			{
				sequencePlayer.Clear();
			}
			this.SequencePlayer = null;
		}

		// Token: 0x06040CF2 RID: 265458 RVA: 0x00FB2955 File Offset: 0x00FB0B55
		protected virtual void RefreshAppearance()
		{
		}

		// Token: 0x06040CF3 RID: 265459 RVA: 0x00FB2958 File Offset: 0x00FB0B58
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

		// Token: 0x04021C32 RID: 138290
		protected Piece Piece;

		// Token: 0x04021C33 RID: 138291
		protected IPieceComponent Component;

		// Token: 0x04021C34 RID: 138292
		protected UiSequencePlayer SequencePlayer;
	}
}
