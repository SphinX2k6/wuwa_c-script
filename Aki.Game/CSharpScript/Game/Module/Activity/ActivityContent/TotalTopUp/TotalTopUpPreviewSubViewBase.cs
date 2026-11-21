using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.TotalTopUp
{
	// Token: 0x02004F93 RID: 20371
	public abstract class TotalTopUpPreviewSubViewBase : TotalTopUpPreviewSubView
	{
		// Token: 0x06033136 RID: 209206 RVA: 0x00E50CD4 File Offset: 0x00E4EED4
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

		// Token: 0x0401B1E2 RID: 111074
		[Nullable(2)]
		private LevelSequencePlayer LevelSequencePlayer;
	}
}
