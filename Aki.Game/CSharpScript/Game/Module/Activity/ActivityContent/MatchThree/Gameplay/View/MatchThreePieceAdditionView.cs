using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Activity.ActivityContent.MatchThree.Gameplay.Core;
using CSharpScript.Game.Module.Activity.ActivityContent.MatchThree.Gameplay.Core.Components;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;

namespace CSharpScript.Game.Module.Activity.ActivityContent.MatchThree.Gameplay.View
{
	// Token: 0x0200545C RID: 21596
	[NullableContext(2)]
	[Nullable(0)]
	public class MatchThreePieceAdditionView : UiPanelBase
	{
		// Token: 0x060359B3 RID: 219571 RVA: 0x00EF993C File Offset: 0x00EF7B3C
		[NullableContext(1)]
		public void Refresh(Piece piece, IPieceComponent comp)
		{
			this.Piece = piece;
			this.Component = comp;
			this.RefreshAppearance();
		}

		// Token: 0x060359B4 RID: 219572 RVA: 0x00EF9952 File Offset: 0x00EF7B52
		protected override void OnStart()
		{
			this.SequencePlayer = new UiSequencePlayer(this.RootItem);
			this.RefreshAppearance();
		}

		// Token: 0x060359B5 RID: 219573 RVA: 0x00EF996B File Offset: 0x00EF7B6B
		protected override void OnBeforeDestroy()
		{
			UiSequencePlayer sequencePlayer = this.SequencePlayer;
			if (sequencePlayer != null)
			{
				sequencePlayer.Clear();
			}
			this.SequencePlayer = null;
		}

		// Token: 0x060359B6 RID: 219574 RVA: 0x00EF9985 File Offset: 0x00EF7B85
		protected virtual void RefreshAppearance()
		{
		}

		// Token: 0x060359B7 RID: 219575 RVA: 0x00EF9988 File Offset: 0x00EF7B88
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

		// Token: 0x0401C563 RID: 116067
		protected Piece Piece;

		// Token: 0x0401C564 RID: 116068
		protected IPieceComponent Component;

		// Token: 0x0401C565 RID: 116069
		protected UiSequencePlayer SequencePlayer;
	}
}
