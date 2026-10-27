using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;

namespace CSharpScript.Game.Module.Activity.ActivityContent.MatchThree.Gameplay.View
{
	// Token: 0x020064D8 RID: 25816
	public class MatchThreeFailPopView : UiViewBase
	{
		// Token: 0x06040C5A RID: 265306 RVA: 0x00FAF559 File Offset: 0x00FAD759
		[NullableContext(1)]
		public MatchThreeFailPopView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x06040C5B RID: 265307 RVA: 0x00FAF562 File Offset: 0x00FAD762
		protected override void OnStart()
		{
			this.ClosedCallback = (this.OpenParam as Action);
		}

		// Token: 0x06040C5C RID: 265308 RVA: 0x00FAF575 File Offset: 0x00FAD775
		protected override void OnFinishShow()
		{
			base.CloseMe(new Action<bool>(this.OnCloseFinish));
		}

		// Token: 0x06040C5D RID: 265309 RVA: 0x00FAF589 File Offset: 0x00FAD789
		private void OnCloseFinish(bool _)
		{
			Action closedCallback = this.ClosedCallback;
			if (closedCallback == null)
			{
				return;
			}
			closedCallback();
		}

		// Token: 0x04021BE4 RID: 138212
		[Nullable(2)]
		private Action ClosedCallback;
	}
}
