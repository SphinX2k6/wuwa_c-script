using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;

namespace CSharpScript.Game.Module.Infrastructure
{
	// Token: 0x020048EA RID: 18666
	[NullableContext(1)]
	[Nullable(0)]
	public class InfrastructureLoadingPanel : UiPanelBase
	{
		// Token: 0x0602ED8B RID: 191883 RVA: 0x00D10324 File Offset: 0x00D0E524
		protected override void OnStart()
		{
			this.SeqPlayer = new LevelSequencePlayer(this.RootItem);
			this.SeqPlayer.BindSequenceCloseEvent(new TSequenceEndEvent(this.OnSequenceClose), false);
			this.SeqPlayer.PlayLevelSequenceByName("Start", false, null, false);
		}

		// Token: 0x0602ED8C RID: 191884 RVA: 0x00D10378 File Offset: 0x00D0E578
		public void CloseSelf()
		{
			LevelSequencePlayer seqPlayer = this.SeqPlayer;
			if (seqPlayer == null)
			{
				return;
			}
			seqPlayer.PlayLevelSequenceByName("Close", false, null, false);
		}

		// Token: 0x0602ED8D RID: 191885 RVA: 0x00D103A5 File Offset: 0x00D0E5A5
		private void OnSequenceClose(string sequenceName)
		{
			if (sequenceName == "Close")
			{
				InfrastructureModel.Instance.DestroyLoadingPanel();
			}
		}

		// Token: 0x04018DBF RID: 101823
		private LevelSequencePlayer SeqPlayer;
	}
}
