using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;

namespace Aki.Game.Module.Activity.ActivityContent.Tetris.View
{
	// Token: 0x02002FE5 RID: 12261
	public class TetrisTipsWinView : TetrisTipsBaseView
	{
		// Token: 0x0601D194 RID: 119188 RVA: 0x008E5102 File Offset: 0x008E3302
		[NullableContext(1)]
		public TetrisTipsWinView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x0601D195 RID: 119189 RVA: 0x008E510B File Offset: 0x008E330B
		protected override void OnStart()
		{
			base.OnStart();
			this.OnWinCallback = (this.OpenParam as Action);
		}

		// Token: 0x0601D196 RID: 119190 RVA: 0x008E5124 File Offset: 0x008E3324
		protected override void OnClose()
		{
			base.CloseMe(delegate(bool _)
			{
				Action onWinCallback = this.OnWinCallback;
				if (onWinCallback == null)
				{
					return;
				}
				onWinCallback();
			});
		}

		// Token: 0x0400F540 RID: 62784
		[Nullable(2)]
		private Action OnWinCallback;
	}
}
