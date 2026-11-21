using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;

namespace CSharpScript.Game.LevelGamePlay.BigStuffedDoll.View
{
	// Token: 0x020060D5 RID: 24789
	public class BigStuffedDollChallengeSuccessItem : UiPanelBase
	{
		// Token: 0x0603B711 RID: 243473 RVA: 0x010D2040 File Offset: 0x010D0240
		protected override void OnStart()
		{
			base.OnStart();
			this.LevelSequencePlayer = new LevelSequencePlayer(this.RootItem);
			this.LevelSequencePlayer.BindSequenceCloseEvent(new TSequenceEndEvent(this.OnSequenceClose), false);
		}

		// Token: 0x0603B712 RID: 243474 RVA: 0x010D2071 File Offset: 0x010D0271
		protected override void OnBeforeDestroy()
		{
			LevelSequencePlayer levelSequencePlayer = this.LevelSequencePlayer;
			if (levelSequencePlayer != null)
			{
				levelSequencePlayer.Clear();
			}
			this.LevelSequencePlayer = null;
		}

		// Token: 0x0603B713 RID: 243475 RVA: 0x010D208C File Offset: 0x010D028C
		public void ShowTip()
		{
			base.ShowAsync();
			this.LevelSequencePlayer.PlayLevelSequenceByName("Start", false, null, false);
		}

		// Token: 0x0603B714 RID: 243476 RVA: 0x010D20BC File Offset: 0x010D02BC
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

		// Token: 0x0401F553 RID: 128339
		[Nullable(2)]
		protected LevelSequencePlayer LevelSequencePlayer;
	}
}
