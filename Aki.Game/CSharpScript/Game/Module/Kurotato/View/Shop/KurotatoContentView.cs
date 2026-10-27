using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;

namespace CSharpScript.Game.Module.Kurotato.View.Shop
{
	// Token: 0x0200571D RID: 22301
	public class KurotatoContentView : UiViewBase
	{
		// Token: 0x06038B29 RID: 232233 RVA: 0x00D73986 File Offset: 0x00D71B86
		[NullableContext(1)]
		public KurotatoContentView(UiViewInfo info) : base(info)
		{
		}

		// Token: 0x06038B2A RID: 232234 RVA: 0x00D7398F File Offset: 0x00D71B8F
		protected override void OnBeforeShow()
		{
			if (KurotatoModel.Instance.GetStep() == EKurotatoStep.Combat)
			{
				base.CloseMe(null);
			}
		}

		// Token: 0x06038B2B RID: 232235 RVA: 0x00D739A4 File Offset: 0x00D71BA4
		protected override void OnAfterShow()
		{
			this.ClearTimeoutTimer();
			this.TimeoutHandle = TimerSystem.Instance.Delay(new TTimerAction(this.OnTimeout), 5000f, null, null, true, 1f);
		}

		// Token: 0x06038B2C RID: 232236 RVA: 0x00D739D5 File Offset: 0x00D71BD5
		protected override void OnBeforeHide()
		{
			this.ClearTimeoutTimer();
		}

		// Token: 0x06038B2D RID: 232237 RVA: 0x00D739DD File Offset: 0x00D71BDD
		private void OnTimeout(float delta)
		{
			this.TimeoutHandle = null;
			base.CloseMe(null);
		}

		// Token: 0x06038B2E RID: 232238 RVA: 0x00D739ED File Offset: 0x00D71BED
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

		// Token: 0x0401DC23 RID: 121891
		private const int ContentViewTimeoutMs = 5000;

		// Token: 0x0401DC24 RID: 121892
		[Nullable(2)]
		private TimerHandle TimeoutHandle;
	}
}
