using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.GenericPrompt.View
{
	// Token: 0x020059A8 RID: 22952
	[NullableContext(2)]
	[Nullable(0)]
	public class FloatLineFloatTips : GenericPromptFloatTipsBase
	{
		// Token: 0x0603A37C RID: 238460 RVA: 0x00DD5FF6 File Offset: 0x00DD41F6
		[NullableContext(1)]
		public FloatLineFloatTips(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x0603A37D RID: 238461 RVA: 0x00DD6000 File Offset: 0x00DD4200
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

		// Token: 0x0401E5E7 RID: 124391
		private UUIEffectTextAnimation TextAnimDataComp;

		// Token: 0x0401E5E8 RID: 124392
		private ULGUIPlayTweenComponent TextPlayTweenComp;
	}
}
