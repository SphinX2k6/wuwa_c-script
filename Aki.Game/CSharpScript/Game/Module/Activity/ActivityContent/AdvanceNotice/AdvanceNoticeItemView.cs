using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;

namespace CSharpScript.Game.Module.Activity.ActivityContent.AdvanceNotice
{
	// Token: 0x0200587A RID: 22650
	public class AdvanceNoticeItemView : UiPanelBase
	{
		// Token: 0x06037D2A RID: 228650 RVA: 0x00F9CC6C File Offset: 0x00F9AE6C
		protected override void OnStart()
		{
			this.LevelSequencePlayer = new LevelSequencePlayer(base.GetRootItem());
		}

		// Token: 0x06037D2B RID: 228651 RVA: 0x00F9CC80 File Offset: 0x00F9AE80
		protected override void OnAfterShow()
		{
			LevelSequencePlayer levelSequencePlayer = this.LevelSequencePlayer;
			if (levelSequencePlayer == null)
			{
				return;
			}
			levelSequencePlayer.PlayOrReplaySequenceByName("Start", false, null);
		}

		// Token: 0x06037D2C RID: 228652 RVA: 0x00F9CCAC File Offset: 0x00F9AEAC
		protected override void OnBeforeDestroy()
		{
			LevelSequencePlayer levelSequencePlayer = this.LevelSequencePlayer;
			if (levelSequencePlayer == null)
			{
				return;
			}
			levelSequencePlayer.Clear();
		}

		// Token: 0x0401D75D RID: 120669
		[Nullable(2)]
		protected LevelSequencePlayer LevelSequencePlayer;
	}
}
