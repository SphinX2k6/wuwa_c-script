using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Pinball.View
{
	// Token: 0x020062CE RID: 25294
	[NullableContext(1)]
	[Nullable(0)]
	public class PinballBubbleView : UiViewBase
	{
		// Token: 0x0603FA70 RID: 260720 RVA: 0x00F66344 File Offset: 0x00F64544
		public PinballBubbleView(UiViewInfo info) : base(info)
		{
		}

		// Token: 0x17009290 RID: 37520
		// (get) Token: 0x0603FA71 RID: 260721 RVA: 0x00F6634D File Offset: 0x00F6454D
		[Nullable(2)]
		private new CustomPromise OpenParam
		{
			[NullableContext(2)]
			get
			{
				return this.OpenParam as CustomPromise;
			}
		}

		// Token: 0x0603FA72 RID: 260722 RVA: 0x00F6635A File Offset: 0x00F6455A
		protected override void OnStart()
		{
			this.RootActor.OnSequencePlayEvent.Bind(new Action<string, string>(this.OnEventSequence));
			UiBehaviorLevelSequence uiViewSequence = this.UiViewSequence;
			if (uiViewSequence == null)
			{
				return;
			}
			uiViewSequence.AddSequenceFinishEvent("Bubble_In", delegate(string _)
			{
				this.OnEndSequence();
			}, false);
		}

		// Token: 0x0603FA73 RID: 260723 RVA: 0x00F6639A File Offset: 0x00F6459A
		private void OnEndSequence()
		{
			base.CloseMe(null);
		}

		// Token: 0x0603FA74 RID: 260724 RVA: 0x00F663A4 File Offset: 0x00F645A4
		protected override void OnAfterShow()
		{
			UiBehaviorLevelSequence uiViewSequence = this.UiViewSequence;
			if (uiViewSequence == null)
			{
				return;
			}
			uiViewSequence.PlaySequence("Bubble_In", false, null);
		}

		// Token: 0x0603FA75 RID: 260725 RVA: 0x00F663D0 File Offset: 0x00F645D0
		private void OnEventSequence(string sequenceName, string eventName)
		{
			if (eventName == "Sequence_Bubble_Switch_In")
			{
				CustomPromise openParam = this.OpenParam;
				if (openParam == null)
				{
					return;
				}
				openParam.SetResult();
			}
		}
	}
}
