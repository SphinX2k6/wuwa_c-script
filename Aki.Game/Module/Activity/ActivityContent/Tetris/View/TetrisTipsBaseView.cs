using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;

namespace Aki.Game.Module.Activity.ActivityContent.Tetris.View
{
	// Token: 0x02002FE4 RID: 12260
	public class TetrisTipsBaseView : UiViewBase
	{
		// Token: 0x0601D191 RID: 119185 RVA: 0x008E50E8 File Offset: 0x008E32E8
		[NullableContext(1)]
		public TetrisTipsBaseView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x0601D192 RID: 119186 RVA: 0x008E50F1 File Offset: 0x008E32F1
		protected override void OnFinishShow()
		{
			this.OnClose();
		}

		// Token: 0x0601D193 RID: 119187 RVA: 0x008E50F9 File Offset: 0x008E32F9
		protected virtual void OnClose()
		{
			base.CloseMe(null);
		}
	}
}
