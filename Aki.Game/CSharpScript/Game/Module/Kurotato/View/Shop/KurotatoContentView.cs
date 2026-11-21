using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;

namespace CSharpScript.Game.Module.Kurotato.View.Shop
{
	// Token: 0x020046F4 RID: 18164
	public class KurotatoContentView : UiViewBase
	{
		// Token: 0x0602DA38 RID: 186936 RVA: 0x00CC1F66 File Offset: 0x00CC0166
		[NullableContext(1)]
		public KurotatoContentView(UiViewInfo info) : base(info)
		{
		}

		// Token: 0x0602DA39 RID: 186937 RVA: 0x00CC1F6F File Offset: 0x00CC016F
		protected override void OnBeforeShow()
		{
			if (KurotatoModel.Instance.GetStep() == EKurotatoStep.Combat)
			{
				base.CloseMe(null);
			}
		}

		// Token: 0x0602DA3A RID: 186938 RVA: 0x00CC1F84 File Offset: 0x00CC0184
		protected override void OnAfterShow()
		{
			this.ClearTimeoutTimer();
			this.TimeoutHandle = TimerSystem.Instance.Delay(new TTimerAction(this.OnTimeout), 5000f, null, null, true, 1f);
		}

		// Token: 0x0602DA3B RID: 186939 RVA: 0x00CC1FB5 File Offset: 0x00CC01B5
		protected override void OnBeforeHide()
		{
			this.ClearTimeoutTimer();
		}

		// Token: 0x0602DA3C RID: 186940 RVA: 0x00CC1FBD File Offset: 0x00CC01BD
		private void OnTimeout(float delta)
		{
			this.TimeoutHandle = null;
			base.CloseMe(null);
		}

		// Token: 0x0602DA3D RID: 186941 RVA: 0x00CC1FCD File Offset: 0x00CC01CD
		private void ClearTimeoutTimer()
		{
			if (this.TimeoutHandle != null)
			{
				if (this.TimeoutHandle.Valid())
				{
					this.TimeoutHandle.Remove();
				}
				this.TimeoutHandle = null;
			}
		}

		// Token: 0x040186B9 RID: 100025
		private const int ContentViewTimeoutMs = 5000;

		// Token: 0x040186BA RID: 100026
		[Nullable(2)]
		private TimerHandle TimeoutHandle;
	}
}
