using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;

namespace CSharpScript.Game.LevelGamePlay.LevelPickControl
{
	// Token: 0x02005C4E RID: 23630
	[NullableContext(1)]
	[Nullable(0)]
	public class MazeTipsWinView : UiViewBase
	{
		// Token: 0x0603A092 RID: 237714 RVA: 0x0105434A File Offset: 0x0105254A
		public MazeTipsWinView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x0603A093 RID: 237715 RVA: 0x01054353 File Offset: 0x01052553
		protected override void OnStart()
		{
			this.UiViewSequence.AddSequenceFinishEvent(this.UiViewSequence.StartSequenceName, new Action<string>(this.OnStartSequenceEnd), false);
		}

		// Token: 0x0603A094 RID: 237716 RVA: 0x01054378 File Offset: 0x01052578
		private void OnStartSequenceEnd(string _)
		{
			this.UiViewSequence.RemoveSequenceFinishEvent(this.UiViewSequence.StartSequenceName, new Action<string>(this.OnStartSequenceEnd));
			base.CloseMe(null);
		}
	}
}
