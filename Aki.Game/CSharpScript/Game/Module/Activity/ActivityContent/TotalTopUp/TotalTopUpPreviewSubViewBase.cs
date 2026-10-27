using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.TotalTopUp
{
	// Token: 0x02005FAC RID: 24492
	public abstract class TotalTopUpPreviewSubViewBase : TotalTopUpPreviewSubView
	{
		// Token: 0x0603E19C RID: 254364 RVA: 0x00EFF018 File Offset: 0x00EFD218
		protected override void OnStart()
		{
			UUIItem rootItem = this.RootItem;
			this.LevelSequencePlayer = new LevelSequencePlayer(rootItem);
			LevelSequencePlayer levelSequencePlayer = this.LevelSequencePlayer;
			if (levelSequencePlayer == null)
			{
				return;
			}
			levelSequencePlayer.PlayLevelSequenceByName("Start", false, null, false);
		}

		// Token: 0x04020710 RID: 132880
		[Nullable(2)]
		private LevelSequencePlayer LevelSequencePlayer;
	}
}
