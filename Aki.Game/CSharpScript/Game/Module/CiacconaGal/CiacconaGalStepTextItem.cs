using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.CiacconaGal
{
	// Token: 0x02004BC2 RID: 19394
	[NullableContext(2)]
	[Nullable(0)]
	public class CiacconaGalStepTextItem : UiPanelBase
	{
		// Token: 0x060306A3 RID: 198307 RVA: 0x00D7DA30 File Offset: 0x00D7BC30
		protected unsafe override void OnRegisterComponent()
		{
			int num = 1;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int index = 0;
			*span[index] = new ValueTuple<int, Type>(0, typeof(UUIText));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x060306A4 RID: 198308 RVA: 0x00D7DA78 File Offset: 0x00D7BC78
		protected override void OnStart()
		{
			this.TextContent = base.GetText(0);
			this.AnimComp = (ULGUIPlayTweenComponent)this.TextContent.GetOwner().GetComponentByClass(ULGUIPlayTweenComponent.StaticClass());
			this.OnAnimEndDelegate = DelegateUtils.ToManualReleaseDelegate<FLGUIPlayTweenCompleteDynamicDelegate>(new Action(this.OnAnimEnd));
			this.OnAnimEndDelegateWrapper = this.AnimComp.GetPlayTween().RegisterOnComplete(this.OnAnimEndDelegate);
			this.AnimHandler = new CiacconaGalTextAnimHandler(this.AnimComp);
		}

		// Token: 0x060306A5 RID: 198309 RVA: 0x00D7DAFC File Offset: 0x00D7BCFC
		protected override void OnBeforeDestroy()
		{
			ULGUIPlayTweenComponent animComp = this.AnimComp;
			if (animComp != null)
			{
				ULGUIPlayTween playTween = animComp.GetPlayTween();
				if (playTween != null)
				{
					playTween.UnregisterOnComplete(this.OnAnimEndDelegateWrapper);
				}
			}
			DelegateUtils.ReleaseManualReleaseDelegate(new Action(this.OnAnimEnd));
			this.OnAnimEndDelegateWrapper = null;
			ULGUIPlayTweenComponent animComp2 = this.AnimComp;
			if (animComp2 != null)
			{
				animComp2.Stop();
			}
			if (this.AnimDelayTimerHandle != null && TimerSystem.Instance.Has(this.AnimDelayTimerHandle))
			{
				TimerSystem.Instance.Remove(this.AnimDelayTimerHandle);
				this.AnimDelayTimerHandle = null;
			}
		}

		// Token: 0x060306A6 RID: 198310 RVA: 0x00D7DB88 File Offset: 0x00D7BD88
		[NullableContext(1)]
		public void Refresh(CiacconaGalStepData data)
		{
			LguiUtil.Instance.SetLocalTextNew(this.TextContent, data.TalkTid, Array.Empty<object>());
			if (data.Id == CiacconaGalController.Instance.GalPlayer.CurHandlingStepId)
			{
				UUIItem textContent = this.TextContent;
				bool bUseChangeColor = false;
				FColor? fcolor = new FColor?(this.TextContent.changeColor);
				textContent.SetChangeColor(bUseChangeColor, fcolor);
				if (!CiacconaGalController.Instance.GalPlayer.HasPlayedStepAnim(data.Id))
				{
					this.TextContent.SetUIActive(false);
					this.AnimHandler.SetData(data);
					CiacconaGalController.Instance.GalPlayer.SetAnimHandler(this.AnimHandler);
					this.AnimHandler.Play();
					if (this.AnimDelayTimerHandle != null && TimerSystem.Instance.Has(this.AnimDelayTimerHandle))
					{
						TimerSystem.Instance.Remove(this.AnimDelayTimerHandle);
						this.AnimDelayTimerHandle = null;
					}
					this.AnimDelayTimerHandle = TimerSystem.Instance.Delay(delegate(float _)
					{
						if (this.TextContent == null || !this.TextContent.IsValid())
						{
							return;
						}
						this.TextContent.SetUIActive(true);
					}, 100f, null, null, true, 1f);
					return;
				}
			}
			else
			{
				this.TextContent.SetUIActive(true);
				UUIItem textContent2 = this.TextContent;
				bool bUseChangeColor2 = true;
				FColor? fcolor = new FColor?(this.TextContent.changeColor);
				textContent2.SetChangeColor(bUseChangeColor2, fcolor);
			}
		}

		// Token: 0x060306A7 RID: 198311 RVA: 0x00D7DCC2 File Offset: 0x00D7BEC2
		private void OnAnimEnd()
		{
			CiacconaGalController.Instance.GalPlayer.OnAnimEnd();
		}

		// Token: 0x04019A56 RID: 105046
		private ULGUIPlayTweenComponent AnimComp;

		// Token: 0x04019A57 RID: 105047
		private UUIText TextContent;

		// Token: 0x04019A58 RID: 105048
		private FLGUIPlayTweenCompleteDynamicDelegate OnAnimEndDelegate;

		// Token: 0x04019A59 RID: 105049
		private FLGUIDelegateHandleWrapper OnAnimEndDelegateWrapper;

		// Token: 0x04019A5A RID: 105050
		private CiacconaGalTextAnimHandler AnimHandler;

		// Token: 0x04019A5B RID: 105051
		private TimerHandle AnimDelayTimerHandle;

		// Token: 0x0200A7CD RID: 42957
		[NullableContext(0)]
		private class EComponentDefine
		{
			// Token: 0x04033D50 RID: 212304
			public const int TextContent = 0;
		}
	}
}
