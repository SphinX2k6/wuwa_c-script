using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.GenericPrompt;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Menu.SubViews.BasicGraphicSetting
{
	// Token: 0x02005458 RID: 21592
	[NullableContext(1)]
	[Nullable(0)]
	public class BasicGraphicSettingView : UiViewBase
	{
		// Token: 0x060371E5 RID: 225765 RVA: 0x00D10A19 File Offset: 0x00D0EC19
		public BasicGraphicSettingView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x060371E6 RID: 225766 RVA: 0x00D10A30 File Offset: 0x00D0EC30
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUITexture)),
				new ValueTuple<int, Type>(1, typeof(UUITexture)),
				new ValueTuple<int, Type>(2, typeof(UUITexture)),
				new ValueTuple<int, Type>(3, typeof(UUIItem)),
				new ValueTuple<int, Type>(4, typeof(UUIItem)),
				new ValueTuple<int, Type>(5, typeof(UUIItem)),
				new ValueTuple<int, Type>(6, typeof(UUIVerticalLayout)),
				new ValueTuple<int, Type>(7, typeof(UUIItem))
			};
		}

		// Token: 0x060371E7 RID: 225767 RVA: 0x00D10AF8 File Offset: 0x00D0ECF8
		protected override UniTask OnBeforeStartAsync()
		{
			BasicGraphicSettingView.<OnBeforeStartAsync>d__10 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<BasicGraphicSettingView.<OnBeforeStartAsync>d__10>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x060371E8 RID: 225768 RVA: 0x00D10B3C File Offset: 0x00D0ED3C
		protected override void OnStart()
		{
			this.LayoutSlideBars = new GenericLayout<BasicGraphicSettingSliderItem, BasicGraphicSettingSliderData>(base.GetVerticalLayout(6), new Func<BasicGraphicSettingSliderItem>(this.CreateSliderBar), null, false, true);
			this.SliderBarDataList = BasicGraphicSettingData.GetBasicGraphicSettingSliderDataList();
			this.LayoutSlideBars.RefreshByData(this.SliderBarDataList, null, false);
			this.SettingData = MenuModel.Instance.GetMenuDataByFunctionId(20203);
			this.CaptionItem.SetTitleByTextIdAndArgNew(this.SettingData.FunctionName, Array.Empty<object>());
			this.CaptionItem.SetHelpBtnActive(false);
			this.LayoutSlideBars.SetActive(false);
		}

		// Token: 0x060371E9 RID: 225769 RVA: 0x00D10BD0 File Offset: 0x00D0EDD0
		protected override void OnAddEventListener()
		{
			EventSystem.Instance.Add<string>(EEventName.OnActivitySequenceEmitEvent, new Action<string>(this.OnActivitySequenceEmitEvent));
		}

		// Token: 0x060371EA RID: 225770 RVA: 0x00D10BEE File Offset: 0x00D0EDEE
		protected override void OnRemoveEventListener()
		{
			EventSystem.Instance.Remove(EEventName.OnActivitySequenceEmitEvent, new Action<string>(this.OnActivitySequenceEmitEvent));
		}

		// Token: 0x060371EB RID: 225771 RVA: 0x00D10C0C File Offset: 0x00D0EE0C
		protected override void OnBeforeDestroy()
		{
			if (this.HasConfirmed)
			{
				foreach (BasicGraphicSettingSliderData basicGraphicSettingSliderData in this.SliderBarDataList)
				{
					basicGraphicSettingSliderData.OnApplyValue();
				}
			}
		}

		// Token: 0x060371EC RID: 225772 RVA: 0x00D10C64 File Offset: 0x00D0EE64
		private void PlayAnim(string name)
		{
			UUIInturnAnimController uiAnimController = this.LayoutSlideBars.GetUiAnimController();
			if (uiAnimController == null)
			{
				return;
			}
			uiAnimController.Play(name, -1, false);
		}

		// Token: 0x060371ED RID: 225773 RVA: 0x00D10C7E File Offset: 0x00D0EE7E
		private void OnActivitySequenceEmitEvent(string param)
		{
			this.LayoutSlideBars.SetActive(true);
			this.PlayAnim(param);
		}

		// Token: 0x060371EE RID: 225774 RVA: 0x00D10C94 File Offset: 0x00D0EE94
		private void OnReset(int _)
		{
			foreach (BasicGraphicSettingSliderData basicGraphicSettingSliderData in this.SliderBarDataList)
			{
				basicGraphicSettingSliderData.OnChangeValue(basicGraphicSettingSliderData.DefaultCurValue);
			}
			this.LayoutSlideBars.RefreshByData(this.SliderBarDataList, null, false);
		}

		// Token: 0x060371EF RID: 225775 RVA: 0x00D10D04 File Offset: 0x00D0EF04
		private void OnConfirm(int _)
		{
			GenericPromptController.Instance.ShowPromptByCode("ImageColorSetting", Array.Empty<object>());
			this.HasConfirmed = true;
			base.CloseMe(null);
		}

		// Token: 0x060371F0 RID: 225776 RVA: 0x00D10D28 File Offset: 0x00D0EF28
		private BasicGraphicSettingSliderItem CreateSliderBar()
		{
			return new BasicGraphicSettingSliderItem();
		}

		// Token: 0x0401D146 RID: 119110
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private GenericLayout<BasicGraphicSettingSliderItem, BasicGraphicSettingSliderData> LayoutSlideBars;

		// Token: 0x0401D147 RID: 119111
		private List<BasicGraphicSettingSliderData> SliderBarDataList = new List<BasicGraphicSettingSliderData>();

		// Token: 0x0401D148 RID: 119112
		[Nullable(2)]
		private PopupCaptionItem CaptionItem;

		// Token: 0x0401D149 RID: 119113
		[Nullable(2)]
		private ButtonItem ResetBtnItem;

		// Token: 0x0401D14A RID: 119114
		[Nullable(2)]
		private ButtonItem ConfirmBtnItem;

		// Token: 0x0401D14B RID: 119115
		private bool HasConfirmed;

		// Token: 0x0401D14C RID: 119116
		[Nullable(2)]
		private MenuData SettingData;

		// Token: 0x0200B6CE RID: 46798
		[NullableContext(0)]
		public class EComponentDefine
		{
			// Token: 0x0403761B RID: 226843
			public const int TexLeft = 0;

			// Token: 0x0403761C RID: 226844
			public const int TexMid = 1;

			// Token: 0x0403761D RID: 226845
			public const int TexRight = 2;

			// Token: 0x0403761E RID: 226846
			public const int ItemCaption = 3;

			// Token: 0x0403761F RID: 226847
			public const int BtnReset = 4;

			// Token: 0x04037620 RID: 226848
			public const int BtnConfirm = 5;

			// Token: 0x04037621 RID: 226849
			public const int VLayoutSlideBars = 6;

			// Token: 0x04037622 RID: 226850
			public const int SlideBar = 7;
		}
	}
}
