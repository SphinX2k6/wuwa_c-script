using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.GenericPrompt.View
{
	// Token: 0x02004981 RID: 18817
	[NullableContext(2)]
	[Nullable(0)]
	public class FloatLineFloatTips : GenericPromptFloatTipsBase
	{
		// Token: 0x0602F2A2 RID: 193186 RVA: 0x00D25486 File Offset: 0x00D23686
		[NullableContext(1)]
		public FloatLineFloatTips(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x0602F2A3 RID: 193187 RVA: 0x00D25490 File Offset: 0x00D23690
		protected override void OnStart()
		{
			base.OnStart();
			this.TextAnimDataComp = (base.MainText.GetOwner().GetComponentByClass(UUIEffectTextAnimation.StaticClass()) as UUIEffectTextAnimation);
			this.TextPlayTweenComp = (base.ExtraText.GetOwner().GetComponentByClass(ULGUIPlayTweenComponent.StaticClass()) as ULGUIPlayTweenComponent);
			UUIEffectTextAnimation textAnimDataComp = this.TextAnimDataComp;
			if (textAnimDataComp != null)
			{
				textAnimDataComp.SetSelectorOffset(1f);
			}
			if (this.TextPlayTweenComp != null)
			{
				double num = 0.5 * this.TickDuration;
				double num2 = ((double)this.TextPlayTweenComp.GetPlayTween().duration > num) ? num : ((double)this.TextPlayTweenComp.GetPlayTween().duration);
				this.TextPlayTweenComp.GetPlayTween().duration = (float)num2;
				ULGUIPlayTweenComponent textPlayTweenComp = this.TextPlayTweenComp;
				if (textPlayTweenComp == null)
				{
					return;
				}
				textPlayTweenComp.Play();
			}
		}

		// Token: 0x04019085 RID: 102533
		private UUIEffectTextAnimation TextAnimDataComp;

		// Token: 0x04019086 RID: 102534
		private ULGUIPlayTweenComponent TextPlayTweenComp;
	}
}
