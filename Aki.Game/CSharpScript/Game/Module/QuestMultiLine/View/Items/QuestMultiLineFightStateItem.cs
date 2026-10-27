using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

namespace CSharpScript.Game.Module.QuestMultiLine.View.Items
{
	// Token: 0x02004FB6 RID: 20406
	public class QuestMultiLineFightStateItem : UiPanelBase
	{
		// Token: 0x060343C3 RID: 213955 RVA: 0x00C43271 File Offset: 0x00C41471
		protected override void OnStart()
		{
			this.SequencePlayer = new LevelSequencePlayer(base.GetRootItem());
		}

		// Token: 0x060343C4 RID: 213956 RVA: 0x00C43284 File Offset: 0x00C41484
		protected override void OnBeforeDestroy()
		{
			LevelSequencePlayer sequencePlayer = this.SequencePlayer;
			if (sequencePlayer != null)
			{
				sequencePlayer.Clear();
			}
			this.SequencePlayer = null;
		}

		// Token: 0x060343C5 RID: 213957 RVA: 0x00C432A0 File Offset: 0x00C414A0
		public UniTask PlayStartAsync()
		{
			QuestMultiLineFightStateItem.<PlayStartAsync>d__3 <PlayStartAsync>d__;
			<PlayStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<PlayStartAsync>d__.<>4__this = this;
			<PlayStartAsync>d__.<>1__state = -1;
			<PlayStartAsync>d__.<>t__builder.Start<QuestMultiLineFightStateItem.<PlayStartAsync>d__3>(ref <PlayStartAsync>d__);
			return <PlayStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0401BC63 RID: 113763
		[Nullable(2)]
		private LevelSequencePlayer SequencePlayer;
	}
}
