using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;

namespace CSharpScript.Game.LevelGamePlay.LevelPickControl
{
	// Token: 0x02006AD5 RID: 27349
	[NullableContext(1)]
	[Nullable(0)]
	public class MazeTipsLoseView : UiViewBase
	{
		// Token: 0x06043F46 RID: 278342 RVA: 0x010AAC41 File Offset: 0x010A8E41
		public MazeTipsLoseView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x06043F47 RID: 278343 RVA: 0x010AAC4A File Offset: 0x010A8E4A
		protected override void OnStart()
		{
			this.UiViewSequence.AddSequenceFinishEvent(this.UiViewSequence.StartSequenceName, new Action<string>(this.OnStartSequenceEnd), false);
		}

		// Token: 0x06043F48 RID: 278344 RVA: 0x010AAC6F File Offset: 0x010A8E6F
		private void OnStartSequenceEnd(string _)
		{
			this.UiViewSequence.RemoveSequenceFinishEvent(this.UiViewSequence.StartSequenceName, new Action<string>(this.OnStartSequenceEnd));
			base.CloseMe(null);
		}
	}
}
