using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;

namespace CSharpScript.Game.Module.Infrastructure
{
	// Token: 0x02005911 RID: 22801
	[NullableContext(1)]
	[Nullable(0)]
	public class InfrastructureLoadingPanel : UiPanelBase
	{
		// Token: 0x06039E68 RID: 237160 RVA: 0x00DC1024 File Offset: 0x00DBF224
		protected override void OnStart()
		{
			this.SeqPlayer = new LevelSequencePlayer(this.RootItem);
			this.SeqPlayer.BindSequenceCloseEvent(new TSequenceEndEvent(this.OnSequenceClose), false);
			this.SeqPlayer.PlayLevelSequenceByName("Start", false, null, false);
		}

		// Token: 0x06039E69 RID: 237161 RVA: 0x00DC1078 File Offset: 0x00DBF278
		public void CloseSelf()
		{
			LevelSequencePlayer seqPlayer = this.SeqPlayer;
			if (seqPlayer == null)
			{
				return;
			}
			seqPlayer.PlayLevelSequenceByName("Close", false, null, false);
		}

		// Token: 0x06039E6A RID: 237162 RVA: 0x00DC10A5 File Offset: 0x00DBF2A5
		private void OnSequenceClose(string sequenceName)
		{
			if (sequenceName == "Close")
			{
				InfrastructureModel.Instance.DestroyLoadingPanel();
			}
		}

		// Token: 0x0401E322 RID: 123682
		private LevelSequencePlayer SeqPlayer;
	}
}
