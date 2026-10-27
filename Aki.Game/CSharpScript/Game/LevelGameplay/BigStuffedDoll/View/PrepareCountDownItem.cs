using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

namespace CSharpScript.Game.LevelGamePlay.BigStuffedDoll.View
{
	// Token: 0x02006F5F RID: 28511
	public class PrepareCountDownItem : UiPanelBase
	{
		// Token: 0x060455AD RID: 284077 RVA: 0x0112AAF0 File Offset: 0x01128CF0
		protected override void OnRegisterComponent()
		{
		}

		// Token: 0x060455AE RID: 284078 RVA: 0x0112AAF2 File Offset: 0x01128CF2
		protected override void OnStart()
		{
			this.LevelSequencePlayer = new LevelSequencePlayer(this.RootItem);
			this.LevelSequencePlayer.BindSequenceCloseEvent(new TSequenceEndEvent(this.OnSequenceClose), false);
		}

		// Token: 0x060455AF RID: 284079 RVA: 0x0112AB1D File Offset: 0x01128D1D
		[NullableContext(1)]
		private void OnSequenceClose(string sequenceName)
		{
			if (sequenceName == "Start")
			{
				base.HideAsync();
				BigStuffedDollModel.Instance.EnterNextGameStage();
			}
		}

		// Token: 0x060455B0 RID: 284080 RVA: 0x0112AB40 File Offset: 0x01128D40
		public UniTask StartCountDown()
		{
			PrepareCountDownItem.<StartCountDown>d__5 <StartCountDown>d__;
			<StartCountDown>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<StartCountDown>d__.<>4__this = this;
			<StartCountDown>d__.<>1__state = -1;
			<StartCountDown>d__.<>t__builder.Start<PrepareCountDownItem.<StartCountDown>d__5>(ref <StartCountDown>d__);
			return <StartCountDown>d__.<>t__builder.Task;
		}

		// Token: 0x040242E9 RID: 148201
		protected float RemainTime;

		// Token: 0x040242EA RID: 148202
		[Nullable(2)]
		protected LevelSequencePlayer LevelSequencePlayer;
	}
}
