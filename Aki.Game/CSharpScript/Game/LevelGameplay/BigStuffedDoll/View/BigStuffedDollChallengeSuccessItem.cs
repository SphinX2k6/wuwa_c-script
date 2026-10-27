using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;

namespace CSharpScript.Game.LevelGamePlay.BigStuffedDoll.View
{
	// Token: 0x02006F54 RID: 28500
	public class BigStuffedDollChallengeSuccessItem : UiPanelBase
	{
		// Token: 0x06045563 RID: 284003 RVA: 0x01128260 File Offset: 0x01126460
		protected override void OnStart()
		{
			base.OnStart();
			this.LevelSequencePlayer = new LevelSequencePlayer(this.RootItem);
			this.LevelSequencePlayer.BindSequenceCloseEvent(new TSequenceEndEvent(this.OnSequenceClose), false);
		}

		// Token: 0x06045564 RID: 284004 RVA: 0x01128291 File Offset: 0x01126491
		protected override void OnBeforeDestroy()
		{
			LevelSequencePlayer levelSequencePlayer = this.LevelSequencePlayer;
			if (levelSequencePlayer != null)
			{
				levelSequencePlayer.Clear();
			}
			this.LevelSequencePlayer = null;
		}

		// Token: 0x06045565 RID: 284005 RVA: 0x011282AC File Offset: 0x011264AC
		public void ShowTip()
		{
			base.ShowAsync();
			this.LevelSequencePlayer.PlayLevelSequenceByName("Start", false, null, false);
		}

		// Token: 0x06045566 RID: 284006 RVA: 0x011282DC File Offset: 0x011264DC
		[NullableContext(1)]
		private void OnSequenceClose(string sequenceName)
		{
			if (sequenceName == "Start")
			{
				this.LevelSequencePlayer.PlayLevelSequenceByName("Close", false, null, false);
				return;
			}
			if (sequenceName == "Close")
			{
				base.HideAsync();
				BigStuffedDollModel.Instance.EnterNextGameStage();
			}
		}

		// Token: 0x0402429E RID: 148126
		[Nullable(2)]
		protected LevelSequencePlayer LevelSequencePlayer;
	}
}
