using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Module.Plot.PlotView.PlotComponent;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.SolarSchool
{
	// Token: 0x02005905 RID: 22789
	[NullableContext(2)]
	[Nullable(0)]
	public class SolarSchoolEventInfoPanel : UiPanelBase
	{
		// Token: 0x060382E2 RID: 230114 RVA: 0x00FB4614 File Offset: 0x00FB2814
		protected unsafe override void OnRegisterComponent()
		{
			int num = 8;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIVerticalLayout));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(7, typeof(UUITexture));
			this.ComponentRegisterInfos = list;
			num2 = 1;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(6, new Action(this.OnBtnConfirmClick));
			this.BtnBindInfo = list2;
		}

		// Token: 0x060382E3 RID: 230115 RVA: 0x00FB4780 File Offset: 0x00FB2980
		protected override void OnStart()
		{
			this.ChoiceLayout = new GenericLayout<SolarSchoolEventChoiceItem, int>(base.GetVerticalLayout(3), new Func<SolarSchoolEventChoiceItem>(this.CreateChoiceItem), base.GetItem(4).GetOwner() as AUIBaseActor, false, true);
			UUISprite sprite = base.GetSprite(0);
			if (sprite != null)
			{
				sprite.SetUIActive(false);
			}
			UUISprite sprite2 = base.GetSprite(1);
			if (sprite2 != null)
			{
				sprite2.SetUIActive(false);
			}
			this.SetConfirmActive(false);
		}

		// Token: 0x060382E4 RID: 230116 RVA: 0x00FB47EC File Offset: 0x00FB29EC
		protected override UniTask OnBeforeStartAsync()
		{
			SolarSchoolEventInfoPanel.<OnBeforeStartAsync>d__10 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<SolarSchoolEventInfoPanel.<OnBeforeStartAsync>d__10>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x060382E5 RID: 230117 RVA: 0x00FB4830 File Offset: 0x00FB2A30
		[NullableContext(1)]
		public void RefreshEvent(SolarSchoolEventCheck evt, IReadOnlyList<int> optionIds)
		{
			this.ChoiceInteractable = true;
			LguiUtil.Instance.SetLocalTextNew(base.GetText(2), evt.DescKey, Array.Empty<object>());
			base.SetTextureByPath(evt.BgImage, base.GetTexture(7), null, null);
			this.ChoiceLayout.RefreshByData(optionIds, null, true);
		}

		// Token: 0x060382E6 RID: 230118 RVA: 0x00FB488D File Offset: 0x00FB2A8D
		public void SetChoiceInteractable(bool interactable)
		{
			this.ChoiceInteractable = interactable;
		}

		// Token: 0x060382E7 RID: 230119 RVA: 0x00FB4898 File Offset: 0x00FB2A98
		public void SetConfirmActive(bool active)
		{
			UUIButtonComponent button = base.GetButton(6);
			if (button == null)
			{
				return;
			}
			UUIItem uuiitem = button.RootUIComp.Get();
			if (uuiitem == null)
			{
				return;
			}
			uuiitem.SetUIActive(active);
		}

		// Token: 0x060382E8 RID: 230120 RVA: 0x00FB48C9 File Offset: 0x00FB2AC9
		public void SetResultMark(bool success)
		{
			UUISprite sprite = base.GetSprite(0);
			if (sprite != null)
			{
				sprite.SetUIActive(success);
			}
			UUISprite sprite2 = base.GetSprite(1);
			if (sprite2 == null)
			{
				return;
			}
			sprite2.SetUIActive(!success);
		}

		// Token: 0x060382E9 RID: 230121 RVA: 0x00FB48F3 File Offset: 0x00FB2AF3
		public void SetResultDesc(string descKey, bool useChangeColor = false)
		{
			GenericLayout<SolarSchoolEventChoiceItem, int> choiceLayout = this.ChoiceLayout;
			if (choiceLayout != null)
			{
				choiceLayout.SetActive(false);
			}
			UUIText text = base.GetText(2);
			if (text != null)
			{
				text.SetUIActive(false);
			}
			SolarSchoolEventInfoPanel.ResultText resultDescText = this.ResultDescText;
			if (resultDescText == null)
			{
				return;
			}
			resultDescText.SetText(descKey, useChangeColor);
		}

		// Token: 0x060382EA RID: 230122 RVA: 0x00FB492C File Offset: 0x00FB2B2C
		public void PlayResultDescTyping()
		{
			SolarSchoolEventInfoPanel.ResultText resultDescText = this.ResultDescText;
			if (resultDescText == null)
			{
				return;
			}
			resultDescText.Play();
		}

		// Token: 0x060382EB RID: 230123 RVA: 0x00FB493E File Offset: 0x00FB2B3E
		public void SkipResultDescTyping()
		{
			SolarSchoolEventInfoPanel.ResultText resultDescText = this.ResultDescText;
			if (resultDescText == null)
			{
				return;
			}
			resultDescText.SkipToEnd();
		}

		// Token: 0x060382EC RID: 230124 RVA: 0x00FB4950 File Offset: 0x00FB2B50
		[NullableContext(1)]
		private SolarSchoolEventChoiceItem CreateChoiceItem()
		{
			return new SolarSchoolEventChoiceItem
			{
				OnClickChoiceBack = new Action<int, int>(this.OnChoiceItemClicked),
				CanSelectFunc = (() => this.ChoiceInteractable)
			};
		}

		// Token: 0x060382ED RID: 230125 RVA: 0x00FB497B File Offset: 0x00FB2B7B
		private void OnChoiceItemClicked(int gridIndex, int optionId)
		{
			GenericLayout<SolarSchoolEventChoiceItem, int> choiceLayout = this.ChoiceLayout;
			if (choiceLayout != null)
			{
				choiceLayout.SelectGridProxy(gridIndex, false);
			}
			Action<int> onChoiceSelected = this.OnChoiceSelected;
			if (onChoiceSelected == null)
			{
				return;
			}
			onChoiceSelected(optionId);
		}

		// Token: 0x060382EE RID: 230126 RVA: 0x00FB49A1 File Offset: 0x00FB2BA1
		private void OnBtnConfirmClick()
		{
			Action onConfirmClick = this.OnConfirmClick;
			if (onConfirmClick == null)
			{
				return;
			}
			onConfirmClick();
		}

		// Token: 0x060382EF RID: 230127 RVA: 0x00FB49B3 File Offset: 0x00FB2BB3
		private void OnResultDescTypingComplete()
		{
			Action onResultDescTypingFinished = this.OnResultDescTypingFinished;
			if (onResultDescTypingFinished == null)
			{
				return;
			}
			onResultDescTypingFinished();
		}

		// Token: 0x0401D942 RID: 121154
		public Action<int> OnChoiceSelected;

		// Token: 0x0401D943 RID: 121155
		public Action OnConfirmClick;

		// Token: 0x0401D944 RID: 121156
		public Action OnResultDescTypingFinished;

		// Token: 0x0401D945 RID: 121157
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private GenericLayout<SolarSchoolEventChoiceItem, int> ChoiceLayout;

		// Token: 0x0401D946 RID: 121158
		private SolarSchoolEventInfoPanel.ResultText ResultDescText;

		// Token: 0x0401D947 RID: 121159
		private bool ChoiceInteractable = true;

		// Token: 0x0200B4C2 RID: 46274
		[NullableContext(0)]
		private sealed class ResultText : UiPanelBase
		{
			// Token: 0x06047A66 RID: 293478 RVA: 0x015CBC26 File Offset: 0x015C9E26
			[NullableContext(1)]
			public ResultText(Action onFinished)
			{
				this.OnFinishedCallback = onFinished;
			}

			// Token: 0x06047A67 RID: 293479 RVA: 0x015CBC38 File Offset: 0x015C9E38
			protected unsafe override void OnRegisterComponent()
			{
				int num = 3;
				List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
				CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
				Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
				int num2 = 0;
				*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIText));
				num2++;
				*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIEffectTextAnimation));
				num2++;
				*span[num2] = new ValueTuple<int, Type>(2, typeof(ULGUIPlayTweenComponent));
				this.ComponentRegisterInfos = list;
			}

			// Token: 0x06047A68 RID: 293480 RVA: 0x015CBCC4 File Offset: 0x015C9EC4
			protected override void OnStart()
			{
				UUIText text = base.GetText(0);
				UUIEffectTextAnimation uieffectTextAnimation = base.GetUIEffectTextAnimation(1);
				ULGUIPlayTweenComponent tween = base.GetTween(2);
				if (text == null || uieffectTextAnimation == null || tween == null)
				{
					return;
				}
				this.WriterComp = new PlotTextWriterComponent();
				this.WriterComp.Init(new PlotTextWriterComponentContext
				{
					TextComponent = text,
					TextAnimComp = uieffectTextAnimation,
					TweenComp = tween,
					OnAnimCompleteDelegate = new Action(this.FireFinished)
				});
			}

			// Token: 0x06047A69 RID: 293481 RVA: 0x015CBD35 File Offset: 0x015C9F35
			public void SetTxtActive(bool active)
			{
				UUIText text = base.GetText(0);
				if (text == null)
				{
					return;
				}
				text.SetUIActive(active);
			}

			// Token: 0x06047A6A RID: 293482 RVA: 0x015CBD4C File Offset: 0x015C9F4C
			[NullableContext(2)]
			public void SetText(string descKey, bool useChangeColor)
			{
				PlotTextWriterComponent writerComp = this.WriterComp;
				if (writerComp != null)
				{
					writerComp.Stop();
				}
				UUIText text = base.GetText(0);
				if (text != null)
				{
					text.SetUIActive(true);
				}
				LguiUtil.Instance.SetLocalTextNew(text, descKey, Array.Empty<object>());
				if (text != null)
				{
					UUIItem uuiitem = text;
					FColor? fcolor = new FColor?(text.changeColor);
					uuiitem.SetChangeColor(useChangeColor, fcolor);
				}
			}

			// Token: 0x06047A6B RID: 293483 RVA: 0x015CBDA8 File Offset: 0x015C9FA8
			public unsafe void Play()
			{
				this.HasFiredFinished = false;
				UUIText text = base.GetText(0);
				if (text == null || this.WriterComp == null)
				{
					this.FireFinished();
					return;
				}
				int activityId = SolarSchoolGamePlayModel.Instance.ActivityId;
				int paramInt = SolarSchoolConfig.Instance.GetParamInt(activityId, "TextAnimSpeed", 0);
				if (paramInt <= 0)
				{
					Log instance = Log.Instance;
					ELogModule module = ELogModule.SolarSchool;
					ELogAuthor author = ELogAuthor.YYZ;
					string message = "SolarSchoolEventInfoPanel 打字机速度参数无效";
					<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("activityId", activityId);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("speed", paramInt);
					instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
					this.SkipToEnd();
					return;
				}
				float num = (float)text.GetDisplayCharLength() / (float)paramInt;
				if (num <= 0f)
				{
					this.SkipToEnd();
					return;
				}
				PlotTextWriterComponent writerComp = this.WriterComp;
				if (writerComp != null)
				{
					writerComp.SetPlayDuration(num);
				}
				PlotTextWriterComponent writerComp2 = this.WriterComp;
				if (writerComp2 == null)
				{
					return;
				}
				writerComp2.Play();
			}

			// Token: 0x06047A6C RID: 293484 RVA: 0x015CBE9A File Offset: 0x015CA09A
			public void SkipToEnd()
			{
				if (this.HasFiredFinished)
				{
					return;
				}
				PlotTextWriterComponent writerComp = this.WriterComp;
				if (writerComp != null)
				{
					writerComp.JumpToEnd();
				}
				this.FireFinished();
			}

			// Token: 0x06047A6D RID: 293485 RVA: 0x015CBEBC File Offset: 0x015CA0BC
			protected override void OnBeforeDestroy()
			{
				PlotTextWriterComponent writerComp = this.WriterComp;
				if (writerComp != null)
				{
					writerComp.Clear();
				}
				this.WriterComp = null;
			}

			// Token: 0x06047A6E RID: 293486 RVA: 0x015CBED6 File Offset: 0x015CA0D6
			private void FireFinished()
			{
				if (this.HasFiredFinished)
				{
					return;
				}
				this.HasFiredFinished = true;
				this.OnFinishedCallback();
			}

			// Token: 0x04037E46 RID: 228934
			[Nullable(2)]
			private PlotTextWriterComponent WriterComp;

			// Token: 0x04037E47 RID: 228935
			[Nullable(1)]
			private readonly Action OnFinishedCallback;

			// Token: 0x04037E48 RID: 228936
			private bool HasFiredFinished;

			// Token: 0x0200BD88 RID: 48520
			private class EComponents
			{
				// Token: 0x0403A2E3 RID: 238307
				public const int TxtResultDesc = 0;

				// Token: 0x0403A2E4 RID: 238308
				public const int EffectTextAnimation = 1;

				// Token: 0x0403A2E5 RID: 238309
				public const int TweenText = 2;
			}
		}

		// Token: 0x0200B4C3 RID: 46275
		[NullableContext(0)]
		private class EComponents
		{
			// Token: 0x04037E49 RID: 228937
			public const int SprSuccess = 0;

			// Token: 0x04037E4A RID: 228938
			public const int SprFail = 1;

			// Token: 0x04037E4B RID: 228939
			public const int TxtDesc = 2;

			// Token: 0x04037E4C RID: 228940
			public const int ChoiceLayout = 3;

			// Token: 0x04037E4D RID: 228941
			public const int ChoiceItem = 4;

			// Token: 0x04037E4E RID: 228942
			public const int TxtResultDesc = 5;

			// Token: 0x04037E4F RID: 228943
			public const int BtnConfirm = 6;

			// Token: 0x04037E50 RID: 228944
			public const int TexInfo = 7;
		}
	}
}
