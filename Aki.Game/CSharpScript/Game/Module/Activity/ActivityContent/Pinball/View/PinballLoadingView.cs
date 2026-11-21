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
	// Token: 0x0200524F RID: 21071
	public class PinballLoadingView : LoadingViewBase
	{
		// Token: 0x06034756 RID: 214870 RVA: 0x00EAE137 File Offset: 0x00EAC337
		[NullableContext(1)]
		public PinballLoadingView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x06034757 RID: 214871 RVA: 0x00EAE140 File Offset: 0x00EAC340
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

		// Token: 0x06034758 RID: 214872 RVA: 0x00EAE20C File Offset: 0x00EAC40C
		protected override UniTask OnBeforeStartAsync()
		{
			PinballLoadingView.<OnBeforeStartAsync>d__4 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<PinballLoadingView.<OnBeforeStartAsync>d__4>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06034759 RID: 214873 RVA: 0x00EAE250 File Offset: 0x00EAC450
		private UniTask InitLoopAutoScrollViewAsync()
		{
			PinballLoadingView.<InitLoopAutoScrollViewAsync>d__5 <InitLoopAutoScrollViewAsync>d__;
			<InitLoopAutoScrollViewAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitLoopAutoScrollViewAsync>d__.<>4__this = this;
			<InitLoopAutoScrollViewAsync>d__.<>1__state = -1;
			<InitLoopAutoScrollViewAsync>d__.<>t__builder.Start<PinballLoadingView.<InitLoopAutoScrollViewAsync>d__5>(ref <InitLoopAutoScrollViewAsync>d__);
			return <InitLoopAutoScrollViewAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603475A RID: 214874 RVA: 0x00EAE293 File Offset: 0x00EAC493
		[NullableContext(1)]
		private PinballLoadingTexView CreateGrid()
		{
			return new PinballLoadingTexView();
		}

		// Token: 0x0603475B RID: 214875 RVA: 0x00EAE29A File Offset: 0x00EAC49A
		protected override void UpdateProgressRate(float rate)
		{
			UUISliderComponent slider = base.GetSlider(0);
			if (slider == null)
			{
				return;
			}
			slider.SetValue(rate, true);
		}

		// Token: 0x0603475C RID: 214876 RVA: 0x00EAE2AF File Offset: 0x00EAC4AF
		protected override void UpdateProgressValue(float value)
		{
			this.SetTextProgressValue(1, value, "%");
		}

		// Token: 0x0603475D RID: 214877 RVA: 0x00EAE2C0 File Offset: 0x00EAC4C0
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

		// Token: 0x0603475E RID: 214878 RVA: 0x00EAE344 File Offset: 0x00EAC544
		protected override void OnBeforeDestroy()
		{
			LoopAutoScrollView<PinballLoadingTexView, string> loopAutoScrollView = this.LoopAutoScrollView;
			if (loopAutoScrollView != null)
			{
				loopAutoScrollView.StopAutoScroll();
			}
			this.LoopAutoScrollView = null;
		}

		// Token: 0x0401BD62 RID: 114018
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private LoopAutoScrollView<PinballLoadingTexView, string> LoopAutoScrollView;

		// Token: 0x0200AE9F RID: 44703
		private enum EComponent
		{
			// Token: 0x04035F27 RID: 220967
			Slider,
			// Token: 0x04035F28 RID: 220968
			TextProgress,
			// Token: 0x04035F29 RID: 220969
			Scroll,
			// Token: 0x04035F2A RID: 220970
			ScrollItem,
			// Token: 0x04035F2B RID: 220971
			TexDecoration
		}
	}
}
