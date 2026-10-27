using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.CiacconaGal
{
	// Token: 0x02005BE2 RID: 23522
	[NullableContext(2)]
	[Nullable(0)]
	public class CiacconaGalStepTextItem : UiPanelBase
	{
		// Token: 0x0603B758 RID: 243544 RVA: 0x00E2D728 File Offset: 0x00E2B928
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

		// Token: 0x0603B759 RID: 243545 RVA: 0x00E2D770 File Offset: 0x00E2B970
		protected override void OnStart()
		{
			this.TextContent = base.GetText(0);
			this.AnimComp = (ULGUIPlayTweenComponent)this.TextContent.GetOwner().GetComponentByClass(ULGUIPlayTweenComponent.StaticClass());
			this.OnAnimEndDelegate = DelegateUtils.ToManualReleaseDelegate<FLGUIPlayTweenCompleteDynamicDelegate>(new Action(this.OnAnimEnd));
			this.OnAnimEndDelegateWrapper = this.AnimComp.GetPlayTween().RegisterOnComplete(this.OnAnimEndDelegate);
			this.AnimHandler = new CiacconaGalTextAnimHandler(this.AnimComp);
		}

		// Token: 0x0603B75A RID: 243546 RVA: 0x00E2D7F4 File Offset: 0x00E2B9F4
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

		// Token: 0x0603B75B RID: 243547 RVA: 0x00E2D880 File Offset: 0x00E2BA80
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

		// Token: 0x0603B75C RID: 243548 RVA: 0x00E2D9BA File Offset: 0x00E2BBBA
		private void OnAnimEnd()
		{
			CiacconaGalController.Instance.GalPlayer.OnAnimEnd();
		}

		// Token: 0x0401EFA5 RID: 126885
		private ULGUIPlayTweenComponent AnimComp;

		// Token: 0x0401EFA6 RID: 126886
		private UUIText TextContent;

		// Token: 0x0401EFA7 RID: 126887
		private FLGUIPlayTweenCompleteDynamicDelegate OnAnimEndDelegate;

		// Token: 0x0401EFA8 RID: 126888
		private FLGUIDelegateHandleWrapper OnAnimEndDelegateWrapper;

		// Token: 0x0401EFA9 RID: 126889
		private CiacconaGalTextAnimHandler AnimHandler;

		// Token: 0x0401EFAA RID: 126890
		private TimerHandle AnimDelayTimerHandle;

		// Token: 0x0200BDC4 RID: 48580
		[NullableContext(0)]
		private class EComponentDefine
		{
			// Token: 0x0403938B RID: 234379
			public const int TextContent = 0;
		}
	}
}
