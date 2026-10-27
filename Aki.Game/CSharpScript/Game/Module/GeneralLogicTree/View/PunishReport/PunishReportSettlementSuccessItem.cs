using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

namespace CSharpScript.Game.Module.GeneralLogicTree.View.PunishReport
{
	// Token: 0x020059BC RID: 22972
	[NullableContext(1)]
	[Nullable(0)]
	public class PunishReportSettlementSuccessItem : UiPanelBase
	{
		// Token: 0x0603A3C8 RID: 238536 RVA: 0x00DD7315 File Offset: 0x00DD5515
		protected override void OnStart()
		{
			base.OnStart();
			this.LevelSequencePlayer = new LevelSequencePlayer(this.RootItem);
			this.LevelSequencePlayer.BindSequenceCloseEvent(new TSequenceEndEvent(this.OnSequenceClose), false);
		}

		// Token: 0x0603A3C9 RID: 238537 RVA: 0x00DD7346 File Offset: 0x00DD5546
		protected override void OnBeforeDestroy()
		{
			LevelSequencePlayer levelSequencePlayer = this.LevelSequencePlayer;
			if (levelSequencePlayer != null)
			{
				levelSequencePlayer.Clear();
			}
			this.LevelSequencePlayer = null;
		}

		// Token: 0x0603A3CA RID: 238538 RVA: 0x00DD7360 File Offset: 0x00DD5560
		public UniTask ShowTip()
		{
			PunishReportSettlementSuccessItem.<ShowTip>d__4 <ShowTip>d__;
			<ShowTip>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<ShowTip>d__.<>4__this = this;
			<ShowTip>d__.<>1__state = -1;
			<ShowTip>d__.<>t__builder.Start<PunishReportSettlementSuccessItem.<ShowTip>d__4>(ref <ShowTip>d__);
			return <ShowTip>d__.<>t__builder.Task;
		}

		// Token: 0x0603A3CB RID: 238539 RVA: 0x00DD73A3 File Offset: 0x00DD55A3
		private void OnSequenceClose(string sequenceName)
		{
			if (sequenceName == "Start")
			{
				this.CustomPromise.SetResult(true);
			}
		}

		// Token: 0x0401E604 RID: 124420
		[Nullable(2)]
		private LevelSequencePlayer LevelSequencePlayer;

		// Token: 0x0401E605 RID: 124421
		private readonly CustomPromise<bool> CustomPromise = new CustomPromise<bool>();
	}
}
