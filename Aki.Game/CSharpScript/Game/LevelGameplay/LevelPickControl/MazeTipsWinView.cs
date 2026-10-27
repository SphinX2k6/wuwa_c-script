using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;

namespace CSharpScript.Game.LevelGamePlay.LevelPickControl
{
	// Token: 0x02006AD6 RID: 27350
	[NullableContext(1)]
	[Nullable(0)]
	public class MazeTipsWinView : UiViewBase
	{
		// Token: 0x06043F49 RID: 278345 RVA: 0x010AAC9A File Offset: 0x010A8E9A
		public MazeTipsWinView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x06043F4A RID: 278346 RVA: 0x010AACA3 File Offset: 0x010A8EA3
		protected override void OnStart()
		{
			this.UiViewSequence.AddSequenceFinishEvent(this.UiViewSequence.StartSequenceName, new Action<string>(this.OnStartSequenceEnd), false);
		}

		// Token: 0x06043F4B RID: 278347 RVA: 0x010AACC8 File Offset: 0x010A8EC8
		private void OnStartSequenceEnd(string _)
		{
			this.UiViewSequence.RemoveSequenceFinishEvent(this.UiViewSequence.StartSequenceName, new Action<string>(this.OnStartSequenceEnd));
			base.CloseMe(null);
		}
	}
}
