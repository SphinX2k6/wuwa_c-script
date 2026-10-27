using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Pinball.View
{
	// Token: 0x020062D1 RID: 25297
	public class PinballLoadingView : LoadingViewBase
	{
		// Token: 0x0603FA95 RID: 260757 RVA: 0x00F671DB File Offset: 0x00F653DB
		[NullableContext(1)]
		public PinballLoadingView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x0603FA96 RID: 260758 RVA: 0x00F671E4 File Offset: 0x00F653E4
		protected unsafe override void OnRegisterComponent()
		{
			int num = 5;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUISliderComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIScrollViewWithScrollbarComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUITexture));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x0603FA97 RID: 260759 RVA: 0x00F672B0 File Offset: 0x00F654B0
		protected override UniTask OnBeforeStartAsync()
		{
			PinballLoadingView.<OnBeforeStartAsync>d__4 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<PinballLoadingView.<OnBeforeStartAsync>d__4>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603FA98 RID: 260760 RVA: 0x00F672F4 File Offset: 0x00F654F4
		private UniTask InitLoopAutoScrollViewAsync()
		{
			PinballLoadingView.<InitLoopAutoScrollViewAsync>d__5 <InitLoopAutoScrollViewAsync>d__;
			<InitLoopAutoScrollViewAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitLoopAutoScrollViewAsync>d__.<>4__this = this;
			<InitLoopAutoScrollViewAsync>d__.<>1__state = -1;
			<InitLoopAutoScrollViewAsync>d__.<>t__builder.Start<PinballLoadingView.<InitLoopAutoScrollViewAsync>d__5>(ref <InitLoopAutoScrollViewAsync>d__);
			return <InitLoopAutoScrollViewAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603FA99 RID: 260761 RVA: 0x00F67337 File Offset: 0x00F65537
		[NullableContext(1)]
		private PinballLoadingTexView CreateGrid()
		{
			return new PinballLoadingTexView();
		}

		// Token: 0x0603FA9A RID: 260762 RVA: 0x00F6733E File Offset: 0x00F6553E
		protected override void UpdateProgressRate(float rate)
		{
			UUISliderComponent slider = base.GetSlider(0);
			if (slider == null)
			{
				return;
			}
			slider.SetValue(rate, true);
		}

		// Token: 0x0603FA9B RID: 260763 RVA: 0x00F67353 File Offset: 0x00F65553
		protected override void UpdateProgressValue(float value)
		{
			this.SetTextProgressValue(1, value, "%");
		}

		// Token: 0x0603FA9C RID: 260764 RVA: 0x00F67364 File Offset: 0x00F65564
		private void SetDecorationTexture()
		{
			IReadOnlyList<string> stringArrayConfig = ConfigCommonParamById.GetStringArrayConfig("PinballLoadingDecorationTex");
			List<string> list = new List<string>();
			if (stringArrayConfig != null)
			{
				foreach (string item in stringArrayConfig)
				{
					list.Add(item);
				}
			}
			string randomItem = MathUtils.Instance.GetRandomItem<string>(list);
			base.TrySetTextureByPath(randomItem, base.GetTexture(4), new EUiViewName?(EUiViewName.PinballLoadingView), null);
		}

		// Token: 0x0603FA9D RID: 260765 RVA: 0x00F673E8 File Offset: 0x00F655E8
		protected override void OnBeforeDestroy()
		{
			LoopAutoScrollView<PinballLoadingTexView, string> loopAutoScrollView = this.LoopAutoScrollView;
			if (loopAutoScrollView != null)
			{
				loopAutoScrollView.StopAutoScroll();
			}
			this.LoopAutoScrollView = null;
		}

		// Token: 0x04021433 RID: 136243
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private LoopAutoScrollView<PinballLoadingTexView, string> LoopAutoScrollView;

		// Token: 0x0200C4B8 RID: 50360
		private enum EComponent
		{
			// Token: 0x0403B5C5 RID: 243141
			Slider,
			// Token: 0x0403B5C6 RID: 243142
			TextProgress,
			// Token: 0x0403B5C7 RID: 243143
			Scroll,
			// Token: 0x0403B5C8 RID: 243144
			ScrollItem,
			// Token: 0x0403B5C9 RID: 243145
			TexDecoration
		}
	}
}
