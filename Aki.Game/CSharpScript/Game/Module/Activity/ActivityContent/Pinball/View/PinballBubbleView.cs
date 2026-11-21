using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Pinball.View
{
	// Token: 0x0200524C RID: 21068
	[NullableContext(1)]
	[Nullable(0)]
	public class PinballBubbleView : UiViewBase
	{
		// Token: 0x06034731 RID: 214833 RVA: 0x00EAD2A0 File Offset: 0x00EAB4A0
		public PinballBubbleView(UiViewInfo info) : base(info)
		{
		}

		// Token: 0x170065F2 RID: 26098
		// (get) Token: 0x06034732 RID: 214834 RVA: 0x00EAD2A9 File Offset: 0x00EAB4A9
		[Nullable(2)]
		private new CustomPromise OpenParam
		{
			[NullableContext(2)]
			get
			{
				return this.OpenParam as CustomPromise;
			}
		}

		// Token: 0x06034733 RID: 214835 RVA: 0x00EAD2B6 File Offset: 0x00EAB4B6
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

		// Token: 0x06034734 RID: 214836 RVA: 0x00EAD2F6 File Offset: 0x00EAB4F6
		private void OnEndSequence()
		{
			base.CloseMe(null);
		}

		// Token: 0x06034735 RID: 214837 RVA: 0x00EAD300 File Offset: 0x00EAB500
		protected override void OnAfterShow()
		{
			UiBehaviorLevelSequence uiViewSequence = this.UiViewSequence;
			if (uiViewSequence == null)
			{
				return;
			}
			uiViewSequence.PlaySequence("Bubble_In", false, null);
		}

		// Token: 0x06034736 RID: 214838 RVA: 0x00EAD32C File Offset: 0x00EAB52C
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
