using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

namespace CSharpScript.Game.Module.QuestMultiLine.View.Items
{
	// Token: 0x02003F7F RID: 16255
	public class QuestMultiLineFightStateItem : UiPanelBase
	{
		// Token: 0x06029231 RID: 168497 RVA: 0x00B8CA1D File Offset: 0x00B8AC1D
		protected override void OnStart()
		{
			this.SequencePlayer = new LevelSequencePlayer(base.GetRootItem());
		}

		// Token: 0x06029232 RID: 168498 RVA: 0x00B8CA30 File Offset: 0x00B8AC30
		protected override void OnBeforeDestroy()
		{
			LevelSequencePlayer sequencePlayer = this.SequencePlayer;
			if (sequencePlayer != null)
			{
				sequencePlayer.Clear();
			}
			this.SequencePlayer = null;
		}

		// Token: 0x06029233 RID: 168499 RVA: 0x00B8CA4C File Offset: 0x00B8AC4C
		public UniTask PlayStartAsync()
		{
			QuestMultiLineFightStateItem.<PlayStartAsync>d__3 <PlayStartAsync>d__;
			<PlayStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<PlayStartAsync>d__.<>4__this = this;
			<PlayStartAsync>d__.<>1__state = -1;
			<PlayStartAsync>d__.<>t__builder.Start<QuestMultiLineFightStateItem.<PlayStartAsync>d__3>(ref <PlayStartAsync>d__);
			return <PlayStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x04016638 RID: 91704
		[Nullable(2)]
		private LevelSequencePlayer SequencePlayer;
	}
}
