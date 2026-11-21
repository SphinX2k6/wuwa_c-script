using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Plot.PlotView
{
	// Token: 0x0200403D RID: 16445
	[NullableContext(2)]
	[Nullable(0)]
	public class PlotWordArtCaptionView : UiViewBase
	{
		// Token: 0x06029AFF RID: 170751 RVA: 0x00BC8A45 File Offset: 0x00BC6C45
		[NullableContext(1)]
		public PlotWordArtCaptionView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x06029B00 RID: 170752 RVA: 0x00BC8A50 File Offset: 0x00BC6C50
		protected unsafe override void OnRegisterComponent()
		{
			int num = 3;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x06029B01 RID: 170753 RVA: 0x00BC8ADC File Offset: 0x00BC6CDC
		protected override void OnStart()
		{
			PlotWordArtCaptionViewParams plotWordArtCaptionViewParams = this.OpenParam as PlotWordArtCaptionViewParams;
			if (plotWordArtCaptionViewParams != null && !string.IsNullOrEmpty(plotWordArtCaptionViewParams.TidSubtitleText))
			{
				UUIText text = base.GetText(0);
				if (text != null)
				{
					text.ShowTextNew(plotWordArtCaptionViewParams.TidSubtitleText);
				}
			}
			else
			{
				UUIText text2 = base.GetText(0);
				if (text2 != null)
				{
					text2.SetUIActive(false);
				}
			}
			this.TweenStartComp = (base.GetItem(2).GetOwner().GetComponentByClass(ULGUIPlayTweenComponent.StaticClass()) as ULGUIPlayTweenComponent);
			ULGUIPlayTweenComponent tweenStartComp = this.TweenStartComp;
			if (tweenStartComp != null)
			{
				tweenStartComp.Stop();
			}
			this.TweenCloseComp = (base.GetItem(1).GetOwner().GetComponentByClass(ULGUIPlayTweenComponent.StaticClass()) as ULGUIPlayTweenComponent);
			if (this.TweenCloseComp != null)
			{
				this.TweenCloseComp.Stop();
				this.TweenCloseEndDelegate = DelegateUtils.ToManualReleaseDelegate<FLGUIPlayTweenCompleteDynamicDelegate>(new Action(this.OnTweenCloseEnd));
				this.TweenCloseEndDelegateWrapper = this.TweenCloseComp.GetPlayTween().RegisterOnComplete(this.TweenCloseEndDelegate);
			}
		}

		// Token: 0x06029B02 RID: 170754 RVA: 0x00BC8BD5 File Offset: 0x00BC6DD5
		protected override void OnAfterShow()
		{
			ULGUIPlayTweenComponent tweenStartComp = this.TweenStartComp;
			if (tweenStartComp == null)
			{
				return;
			}
			tweenStartComp.Play();
		}

		// Token: 0x06029B03 RID: 170755 RVA: 0x00BC8BE8 File Offset: 0x00BC6DE8
		protected override UniTask OnBeforeHideAsync()
		{
			PlotWordArtCaptionView.<OnBeforeHideAsync>d__10 <OnBeforeHideAsync>d__;
			<OnBeforeHideAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeHideAsync>d__.<>4__this = this;
			<OnBeforeHideAsync>d__.<>1__state = -1;
			<OnBeforeHideAsync>d__.<>t__builder.Start<PlotWordArtCaptionView.<OnBeforeHideAsync>d__10>(ref <OnBeforeHideAsync>d__);
			return <OnBeforeHideAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06029B04 RID: 170756 RVA: 0x00BC8C2C File Offset: 0x00BC6E2C
		protected override void OnBeforeDestroy()
		{
			if (this.TweenCloseEndDelegate != null)
			{
				DelegateUtils.ReleaseManualReleaseDelegate(new Action(this.OnTweenCloseEnd));
				this.TweenCloseEndDelegate = null;
			}
			if (this.TweenCloseEndDelegateWrapper != null)
			{
				this.TweenCloseComp.GetPlayTween().UnregisterOnComplete(this.TweenCloseEndDelegateWrapper);
				this.TweenCloseEndDelegateWrapper = null;
			}
		}

		// Token: 0x06029B05 RID: 170757 RVA: 0x00BC8C84 File Offset: 0x00BC6E84
		private void OnTweenCloseEnd()
		{
			CustomPromise<bool> tweenClosePromise = this.TweenClosePromise;
			if (tweenClosePromise != null)
			{
				tweenClosePromise.SetResult(true);
			}
			this.TweenClosePromise = null;
		}

		// Token: 0x04016BF2 RID: 93170
		private ULGUIPlayTweenComponent TweenStartComp;

		// Token: 0x04016BF3 RID: 93171
		private ULGUIPlayTweenComponent TweenCloseComp;

		// Token: 0x04016BF4 RID: 93172
		private FLGUIPlayTweenCompleteDynamicDelegate TweenCloseEndDelegate;

		// Token: 0x04016BF5 RID: 93173
		private FLGUIDelegateHandleWrapper TweenCloseEndDelegateWrapper;

		// Token: 0x04016BF6 RID: 93174
		private CustomPromise<bool> TweenClosePromise;

		// Token: 0x02009C42 RID: 40002
		[NullableContext(0)]
		private enum EComponentDefine
		{
			// Token: 0x04030A13 RID: 199187
			Text,
			// Token: 0x04030A14 RID: 199188
			TweenClose,
			// Token: 0x04030A15 RID: 199189
			TweenStart
		}
	}
}
