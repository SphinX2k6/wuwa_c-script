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
	// Token: 0x0200443B RID: 17467
	[NullableContext(1)]
	[Nullable(0)]
	public class BasicGraphicSettingView : UiViewBase
	{
		// Token: 0x0602C12E RID: 180526 RVA: 0x00C5FE31 File Offset: 0x00C5E031
		public BasicGraphicSettingView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x0602C12F RID: 180527 RVA: 0x00C5FE48 File Offset: 0x00C5E048
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

		// Token: 0x0602C130 RID: 180528 RVA: 0x00C5FF10 File Offset: 0x00C5E110
		protected override UniTask OnBeforeStartAsync()
		{
			BasicGraphicSettingView.<OnBeforeStartAsync>d__10 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<BasicGraphicSettingView.<OnBeforeStartAsync>d__10>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0602C131 RID: 180529 RVA: 0x00C5FF54 File Offset: 0x00C5E154
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

		// Token: 0x0602C132 RID: 180530 RVA: 0x00C5FFE8 File Offset: 0x00C5E1E8
		protected override void OnAddEventListener()
		{
			EventSystem.Instance.Add<string>(EEventName.OnActivitySequenceEmitEvent, new Action<string>(this.OnActivitySequenceEmitEvent));
		}

		// Token: 0x0602C133 RID: 180531 RVA: 0x00C60006 File Offset: 0x00C5E206
		protected override void OnRemoveEventListener()
		{
			EventSystem.Instance.Remove(EEventName.OnActivitySequenceEmitEvent, new Action<string>(this.OnActivitySequenceEmitEvent));
		}

		// Token: 0x0602C134 RID: 180532 RVA: 0x00C60024 File Offset: 0x00C5E224
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

		// Token: 0x0602C135 RID: 180533 RVA: 0x00C6007C File Offset: 0x00C5E27C
		private void PlayAnim(string name)
		{
			UUIInturnAnimController uiAnimController = this.LayoutSlideBars.GetUiAnimController();
			if (uiAnimController == null)
			{
				return;
			}
			uiAnimController.Play(name, -1, false);
		}

		// Token: 0x0602C136 RID: 180534 RVA: 0x00C60096 File Offset: 0x00C5E296
		private void OnActivitySequenceEmitEvent(string param)
		{
			this.LayoutSlideBars.SetActive(true);
			this.PlayAnim(param);
		}

		// Token: 0x0602C137 RID: 180535 RVA: 0x00C600AC File Offset: 0x00C5E2AC
		private void OnReset(int _)
		{
			foreach (BasicGraphicSettingSliderData basicGraphicSettingSliderData in this.SliderBarDataList)
			{
				basicGraphicSettingSliderData.OnChangeValue(basicGraphicSettingSliderData.DefaultCurValue);
			}
			this.LayoutSlideBars.RefreshByData(this.SliderBarDataList, null, false);
		}

		// Token: 0x0602C138 RID: 180536 RVA: 0x00C6011C File Offset: 0x00C5E31C
		private void OnConfirm(int _)
		{
			GenericPromptController.Instance.ShowPromptByCode("ImageColorSetting", Array.Empty<object>());
			this.HasConfirmed = true;
			base.CloseMe(null);
		}

		// Token: 0x0602C139 RID: 180537 RVA: 0x00C60140 File Offset: 0x00C5E340
		private BasicGraphicSettingSliderItem CreateSliderBar()
		{
			return new BasicGraphicSettingSliderItem();
		}

		// Token: 0x04017BDF RID: 97247
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private GenericLayout<BasicGraphicSettingSliderItem, BasicGraphicSettingSliderData> LayoutSlideBars;

		// Token: 0x04017BE0 RID: 97248
		private List<BasicGraphicSettingSliderData> SliderBarDataList = new List<BasicGraphicSettingSliderData>();

		// Token: 0x04017BE1 RID: 97249
		[Nullable(2)]
		private PopupCaptionItem CaptionItem;

		// Token: 0x04017BE2 RID: 97250
		[Nullable(2)]
		private ButtonItem ResetBtnItem;

		// Token: 0x04017BE3 RID: 97251
		[Nullable(2)]
		private ButtonItem ConfirmBtnItem;

		// Token: 0x04017BE4 RID: 97252
		private bool HasConfirmed;

		// Token: 0x04017BE5 RID: 97253
		[Nullable(2)]
		private MenuData SettingData;

		// Token: 0x0200A106 RID: 41222
		[NullableContext(0)]
		public class EComponentDefine
		{
			// Token: 0x04032070 RID: 204912
			public const int TexLeft = 0;

			// Token: 0x04032071 RID: 204913
			public const int TexMid = 1;

			// Token: 0x04032072 RID: 204914
			public const int TexRight = 2;

			// Token: 0x04032073 RID: 204915
			public const int ItemCaption = 3;

			// Token: 0x04032074 RID: 204916
			public const int BtnReset = 4;

			// Token: 0x04032075 RID: 204917
			public const int BtnConfirm = 5;

			// Token: 0x04032076 RID: 204918
			public const int VLayoutSlideBars = 6;

			// Token: 0x04032077 RID: 204919
			public const int SlideBar = 7;
		}
	}
}
