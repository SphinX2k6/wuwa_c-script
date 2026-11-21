using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;

namespace CSharpScript.Game.Module.Activity.ActivityContent.MatchThree.Gameplay.View
{
	// Token: 0x02005456 RID: 21590
	public class MatchThreeFailPopView : UiViewBase
	{
		// Token: 0x0603591E RID: 219422 RVA: 0x00EF65A1 File Offset: 0x00EF47A1
		[NullableContext(1)]
		public MatchThreeFailPopView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x0603591F RID: 219423 RVA: 0x00EF65AA File Offset: 0x00EF47AA
		protected override void OnStart()
		{
			this.ClosedCallback = (this.OpenParam as Action);
		}

		// Token: 0x06035920 RID: 219424 RVA: 0x00EF65BD File Offset: 0x00EF47BD
		protected override void OnFinishShow()
		{
			base.CloseMe(new Action<bool>(this.OnCloseFinish));
		}

		// Token: 0x06035921 RID: 219425 RVA: 0x00EF65D1 File Offset: 0x00EF47D1
		private void OnCloseFinish(bool _)
		{
			Action closedCallback = this.ClosedCallback;
			if (closedCallback == null)
			{
				return;
			}
			closedCallback();
		}

		// Token: 0x0401C515 RID: 115989
		[Nullable(2)]
		private Action ClosedCallback;
	}
}
