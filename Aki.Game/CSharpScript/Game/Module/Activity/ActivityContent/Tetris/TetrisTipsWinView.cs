using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Tetris
{
	// Token: 0x02006021 RID: 24609
	public class TetrisTipsWinView : TetrisTipsBaseView
	{
		// Token: 0x0603E4CC RID: 255180 RVA: 0x00F0C1FD File Offset: 0x00F0A3FD
		[NullableContext(1)]
		public TetrisTipsWinView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x0603E4CD RID: 255181 RVA: 0x00F0C206 File Offset: 0x00F0A406
		protected override void OnStart()
		{
			base.OnStart();
			this.OnWinCallback = (this.OpenParam as Action);
		}

		// Token: 0x0603E4CE RID: 255182 RVA: 0x00F0C21F File Offset: 0x00F0A41F
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

		// Token: 0x04020902 RID: 133378
		[Nullable(2)]
		private Action OnWinCallback;
	}
}
