using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

namespace CSharpScript.Game.LevelGamePlay.BigStuffedDoll.View
{
	// Token: 0x020060E0 RID: 24800
	public class PrepareCountDownItem : UiPanelBase
	{
		// Token: 0x0603B75B RID: 243547 RVA: 0x010D48D0 File Offset: 0x010D2AD0
		protected override void OnRegisterComponent()
		{
		}

		// Token: 0x0603B75C RID: 243548 RVA: 0x010D48D2 File Offset: 0x010D2AD2
		protected override void OnStart()
		{
			this.LevelSequencePlayer = new LevelSequencePlayer(this.RootItem);
			this.LevelSequencePlayer.BindSequenceCloseEvent(new TSequenceEndEvent(this.OnSequenceClose), false);
		}

		// Token: 0x0603B75D RID: 243549 RVA: 0x010D48FD File Offset: 0x010D2AFD
		[NullableContext(1)]
		private void OnSequenceClose(string sequenceName)
		{
			if (sequenceName == "Start")
			{
				base.HideAsync();
				BigStuffedDollModel.Instance.EnterNextGameStage();
			}
		}

		// Token: 0x0603B75E RID: 243550 RVA: 0x010D4920 File Offset: 0x010D2B20
		public UniTask StartCountDown()
		{
			PrepareCountDownItem.<StartCountDown>d__5 <StartCountDown>d__;
			<StartCountDown>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<StartCountDown>d__.<>4__this = this;
			<StartCountDown>d__.<>1__state = -1;
			<StartCountDown>d__.<>t__builder.Start<PrepareCountDownItem.<StartCountDown>d__5>(ref <StartCountDown>d__);
			return <StartCountDown>d__.<>t__builder.Task;
		}

		// Token: 0x0401F59E RID: 128414
		protected float RemainTime;

		// Token: 0x0401F59F RID: 128415
		[Nullable(2)]
		protected LevelSequencePlayer LevelSequencePlayer;
	}
}
