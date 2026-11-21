using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;

namespace CSharpScript.Game.LevelGamePlay.LevelPickControl
{
	// Token: 0x02005C4D RID: 23629
	[NullableContext(1)]
	[Nullable(0)]
	public class MazeTipsLoseView : UiViewBase
	{
		// Token: 0x0603A08F RID: 237711 RVA: 0x010542F1 File Offset: 0x010524F1
		public MazeTipsLoseView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x0603A090 RID: 237712 RVA: 0x010542FA File Offset: 0x010524FA
		protected override void OnStart()
		{
			this.UiViewSequence.AddSequenceFinishEvent(this.UiViewSequence.StartSequenceName, new Action<string>(this.OnStartSequenceEnd), false);
		}

		// Token: 0x0603A091 RID: 237713 RVA: 0x0105431F File Offset: 0x0105251F
		private void OnStartSequenceEnd(string _)
		{
			this.UiViewSequence.RemoveSequenceFinishEvent(this.UiViewSequence.StartSequenceName, new Action<string>(this.OnStartSequenceEnd));
			base.CloseMe(null);
		}
	}
}
