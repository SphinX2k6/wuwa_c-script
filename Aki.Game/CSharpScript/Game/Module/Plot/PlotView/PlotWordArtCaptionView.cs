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
	// Token: 0x0200506D RID: 20589
	[NullableContext(2)]
	[Nullable(0)]
	public class PlotWordArtCaptionView : UiViewBase
	{
		// Token: 0x06034C0A RID: 216074 RVA: 0x00C7B66D File Offset: 0x00C7986D
		[NullableContext(1)]
		public PlotWordArtCaptionView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x06034C0B RID: 216075 RVA: 0x00C7B678 File Offset: 0x00C79878
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

		// Token: 0x06034C0C RID: 216076 RVA: 0x00C7B704 File Offset: 0x00C79904
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

		// Token: 0x06034C0D RID: 216077 RVA: 0x00C7B7FD File Offset: 0x00C799FD
		protected override void OnAfterShow()
		{
			ULGUIPlayTweenComponent tweenStartComp = this.TweenStartComp;
			if (tweenStartComp == null)
			{
				return;
			}
			tweenStartComp.Play();
		}

		// Token: 0x06034C0E RID: 216078 RVA: 0x00C7B810 File Offset: 0x00C79A10
		protected override UniTask OnBeforeHideAsync()
		{
			PlotWordArtCaptionView.<OnBeforeHideAsync>d__10 <OnBeforeHideAsync>d__;
			<OnBeforeHideAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeHideAsync>d__.<>4__this = this;
			<OnBeforeHideAsync>d__.<>1__state = -1;
			<OnBeforeHideAsync>d__.<>t__builder.Start<PlotWordArtCaptionView.<OnBeforeHideAsync>d__10>(ref <OnBeforeHideAsync>d__);
			return <OnBeforeHideAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06034C0F RID: 216079 RVA: 0x00C7B854 File Offset: 0x00C79A54
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

		// Token: 0x06034C10 RID: 216080 RVA: 0x00C7B8AC File Offset: 0x00C79AAC
		private void OnTweenCloseEnd()
		{
			CustomPromise<bool> tweenClosePromise = this.TweenClosePromise;
			if (tweenClosePromise != null)
			{
				tweenClosePromise.SetResult(true);
			}
			this.TweenClosePromise = null;
		}

		// Token: 0x0401C1C7 RID: 115143
		private ULGUIPlayTweenComponent TweenStartComp;

		// Token: 0x0401C1C8 RID: 115144
		private ULGUIPlayTweenComponent TweenCloseComp;

		// Token: 0x0401C1C9 RID: 115145
		private FLGUIPlayTweenCompleteDynamicDelegate TweenCloseEndDelegate;

		// Token: 0x0401C1CA RID: 115146
		private FLGUIDelegateHandleWrapper TweenCloseEndDelegateWrapper;

		// Token: 0x0401C1CB RID: 115147
		private CustomPromise<bool> TweenClosePromise;

		// Token: 0x0200B209 RID: 45577
		[NullableContext(0)]
		private enum EComponentDefine
		{
			// Token: 0x04035FBF RID: 221119
			Text,
			// Token: 0x04035FC0 RID: 221120
			TweenClose,
			// Token: 0x04035FC1 RID: 221121
			TweenStart
		}
	}
}
