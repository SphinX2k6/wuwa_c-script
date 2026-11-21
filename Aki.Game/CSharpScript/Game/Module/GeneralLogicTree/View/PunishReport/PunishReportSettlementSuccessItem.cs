using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

namespace CSharpScript.Game.Module.GeneralLogicTree.View.PunishReport
{
	// Token: 0x02004995 RID: 18837
	[NullableContext(1)]
	[Nullable(0)]
	public class PunishReportSettlementSuccessItem : UiPanelBase
	{
		// Token: 0x0602F2EF RID: 193263 RVA: 0x00D267ED File Offset: 0x00D249ED
		protected override void OnStart()
		{
			base.OnStart();
			this.LevelSequencePlayer = new LevelSequencePlayer(this.RootItem);
			this.LevelSequencePlayer.BindSequenceCloseEvent(new TSequenceEndEvent(this.OnSequenceClose), false);
		}

		// Token: 0x0602F2F0 RID: 193264 RVA: 0x00D2681E File Offset: 0x00D24A1E
		protected override void OnBeforeDestroy()
		{
			LevelSequencePlayer levelSequencePlayer = this.LevelSequencePlayer;
			if (levelSequencePlayer != null)
			{
				levelSequencePlayer.Clear();
			}
			this.LevelSequencePlayer = null;
		}

		// Token: 0x0602F2F1 RID: 193265 RVA: 0x00D26838 File Offset: 0x00D24A38
		public UniTask ShowTip()
		{
			PunishReportSettlementSuccessItem.<ShowTip>d__4 <ShowTip>d__;
			<ShowTip>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<ShowTip>d__.<>4__this = this;
			<ShowTip>d__.<>1__state = -1;
			<ShowTip>d__.<>t__builder.Start<PunishReportSettlementSuccessItem.<ShowTip>d__4>(ref <ShowTip>d__);
			return <ShowTip>d__.<>t__builder.Task;
		}

		// Token: 0x0602F2F2 RID: 193266 RVA: 0x00D2687B File Offset: 0x00D24A7B
		private void OnSequenceClose(string sequenceName)
		{
			if (sequenceName == "Start")
			{
				this.CustomPromise.SetResult(true);
			}
		}

		// Token: 0x040190A3 RID: 102563
		[Nullable(2)]
		private LevelSequencePlayer LevelSequencePlayer;

		// Token: 0x040190A4 RID: 102564
		private readonly CustomPromise<bool> CustomPromise = new CustomPromise<bool>();
	}
}
