using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;

namespace CSharpScript.Game.Module.Activity.ActivityContent.AdvanceNotice
{
	// Token: 0x0200692A RID: 26922
	public class AdvanceNoticeItemView : UiPanelBase
	{
		// Token: 0x060431D2 RID: 274898 RVA: 0x0105B640 File Offset: 0x01059840
		protected override void OnStart()
		{
			this.LevelSequencePlayer = new LevelSequencePlayer(base.GetRootItem());
		}

		// Token: 0x060431D3 RID: 274899 RVA: 0x0105B654 File Offset: 0x01059854
		protected override void OnAfterShow()
		{
			LevelSequencePlayer levelSequencePlayer = this.LevelSequencePlayer;
			if (levelSequencePlayer == null)
			{
				return;
			}
			levelSequencePlayer.PlayOrReplaySequenceByName("Start", false, null);
		}

		// Token: 0x060431D4 RID: 274900 RVA: 0x0105B680 File Offset: 0x01059880
		protected override void OnBeforeDestroy()
		{
			LevelSequencePlayer levelSequencePlayer = this.LevelSequencePlayer;
			if (levelSequencePlayer == null)
			{
				return;
			}
			levelSequencePlayer.Clear();
		}

		// Token: 0x04022F01 RID: 143105
		[Nullable(2)]
		protected LevelSequencePlayer LevelSequencePlayer;
	}
}
