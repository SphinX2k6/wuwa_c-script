using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Common.NumberSelect
{
	// Token: 0x02005B4E RID: 23374
	[NullableContext(2)]
	[Nullable(0)]
	public class NumberSelectComponent : UiPanelBase
	{
		// Token: 0x0603B2C6 RID: 242374 RVA: 0x00E1BE0C File Offset: 0x00E1A00C
		[NullableContext(1)]
		public NumberSelectComponent(UUIItem uiItem)
		{
			base.CreateThenShowByActor(uiItem.GetOwner(), null);
		}

		// Token: 0x0603B2C7 RID: 242375 RVA: 0x00E1BE34 File Offset: 0x00E1A034
		protected unsafe override void OnRegisterComponent()
		{
			int num = 8;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUISliderComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIButtonComponent));
			this.ComponentRegisterInfos = list;
			num2 = 1;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(7, new Action(this.OnClickMax));
			this.BtnBindInfo = list2;
		}

		// Token: 0x0603B2C8 RID: 242376 RVA: 0x00E1BFA0 File Offset: 0x00E1A1A0
		private void OnClickMax()
		{
			this.SelectMax();
		}

		// Token: 0x0603B2C9 RID: 242377 RVA: 0x00E1BFA8 File Offset: 0x00E1A1A8
		protected override void OnStart()
		{
			this.Slider = base.GetSlider(4);
			this.Slider.OnValueChangeCb.Bind(new Action<float>(this.SliderValueChange));
			this.ReduceLongPress = new LongPressButtonItem(new OneOf<UUIButtonComponent, UUIExtendToggle>?(base.GetButton(0)), new LongPressButtonItem.ELongPressConfigId?(LongPressButtonItem.ELongPressConfigId.LongPressOne), new Action<bool>(this.ReducePointClick));
			this.AddLongPress = new LongPressButtonItem(new OneOf<UUIButtonComponent, UUIExtendToggle>?(base.GetButton(1)), new LongPressButtonItem.ELongPressConfigId?(LongPressButtonItem.ELongPressConfigId.LongPressOne), new Action<bool>(this.AddPointClick));
			this.BuyNumberTips = base.GetText(5);
			this.SelectNumber = 1;
			this.ReduceLongPress.ShouldPlayLongPressSound = true;
			this.AddLongPress.ShouldPlayLongPressSound = true;
		}

		// Token: 0x0603B2CA RID: 242378 RVA: 0x00E1C068 File Offset: 0x00E1A268
		private void SliderValueChange(float value)
		{
			this.SelectNumber = (int)value;
			this.AddLongPress.SetInteractive(value != this.Slider.MaxValue);
			this.ReduceLongPress.SetInteractive(value != this.Slider.MinValue);
			base.GetButton(7).SetSelfInteractive(value != this.Slider.MaxValue);
			Func<int, TableTextArgNew> getExchangeTableText = this.Data.GetExchangeTableText;
			TableTextArgNew tableTextArgNew = (getExchangeTableText != null) ? getExchangeTableText(this.SelectNumber) : null;
			if (tableTextArgNew != null)
			{
				LguiUtil.Instance.SetLocalTextNew(this.BuyNumberTips, tableTextArgNew.TextKey, tableTextArgNew.Params);
			}
			Action<int> valueChangeFunction = this.Data.ValueChangeFunction;
			if (valueChangeFunction == null)
			{
				return;
			}
			valueChangeFunction(this.SelectNumber);
		}

		// Token: 0x0603B2CB RID: 242379 RVA: 0x00E1C12A File Offset: 0x00E1A32A
		private void ReducePointClick(bool _)
		{
			this.Slider.SetValue((float)(this.SelectNumber - 1), true);
		}

		// Token: 0x0603B2CC RID: 242380 RVA: 0x00E1C141 File Offset: 0x00E1A341
		private void AddPointClick(bool _)
		{
			this.Slider.SetValue((float)(this.SelectNumber + 1), true);
		}

		// Token: 0x0603B2CD RID: 242381 RVA: 0x00E1C158 File Offset: 0x00E1A358
		protected override void OnBeforeDestroy()
		{
			this.Slider.OnValueChangeCb.Unbind();
			this.AddLongPress.ShouldPlayLongPressSound = false;
			this.ReduceLongPress.ShouldPlayLongPressSound = false;
			this.ReduceLongPress.Clear();
			this.AddLongPress.Clear();
		}

		// Token: 0x0603B2CE RID: 242382 RVA: 0x00E1C198 File Offset: 0x00E1A398
		private void InitSlider()
		{
			UUIText text = base.GetText(2);
			UUIText text2 = base.GetText(3);
			bool ifLimit = this.GetIfLimit();
			int num = (!ifLimit) ? 1 : 0;
			int num2 = this.UseCustomMinValue ? this.MinValue : num;
			int num3 = this.UseCustomMinValue ? this.MinValue : 1;
			text.SetText(num2.ToString(), true);
			text2.SetText(this.MaxValue.ToString(), true);
			this.Slider.SetMaxValue((float)this.MaxValue, false, true);
			this.Slider.SetMinValue((float)num2, false, true);
			this.Slider.SetValue((float)num3, false);
			this.SliderValueChange((float)num3);
			this.SetComponentLimitState(ifLimit);
		}

		// Token: 0x0603B2CF RID: 242383 RVA: 0x00E1C248 File Offset: 0x00E1A448
		public void SetMaxBtnShowState(bool state)
		{
			UUIButtonComponent button = base.GetButton(7);
			if (button == null)
			{
				return;
			}
			button.RootUIComp.Get().SetUIActive(state);
		}

		// Token: 0x0603B2D0 RID: 242384 RVA: 0x00E1C274 File Offset: 0x00E1A474
		public bool GetIfLimit()
		{
			return this.MaxValue <= 1;
		}

		// Token: 0x0603B2D1 RID: 242385 RVA: 0x00E1C282 File Offset: 0x00E1A482
		public bool GetIfSelectMax()
		{
			return this.SelectNumber == this.MaxValue;
		}

		// Token: 0x0603B2D2 RID: 242386 RVA: 0x00E1C292 File Offset: 0x00E1A492
		public void SelectMax()
		{
			this.Slider.SetValue((float)this.MaxValue, false);
			this.SliderValueChange((float)this.MaxValue);
		}

		// Token: 0x0603B2D3 RID: 242387 RVA: 0x00E1C2B4 File Offset: 0x00E1A4B4
		[NullableContext(1)]
		public void SetNumberSelectTipsText(string text)
		{
			this.BuyNumberTips.SetText(text, true);
		}

		// Token: 0x0603B2D4 RID: 242388 RVA: 0x00E1C2C3 File Offset: 0x00E1A4C3
		public void SetNumberSelectTipsVisible(bool bVisible)
		{
			this.BuyNumberTips.SetUIActive(bVisible);
		}

		// Token: 0x0603B2D5 RID: 242389 RVA: 0x00E1C2D1 File Offset: 0x00E1A4D1
		public virtual void SetComponentLimitState(bool isLimit)
		{
			this.SetMinTextShowState(!isLimit);
			base.GetItem(6).SetRaycastTarget(!isLimit);
			this.Slider.SetSelfInteractive(!isLimit);
			this.SetAddReduceButtonActive(!isLimit);
		}

		// Token: 0x0603B2D6 RID: 242390 RVA: 0x00E1C306 File Offset: 0x00E1A506
		public void SetMinTextShowState(bool state)
		{
			base.GetText(2).SetUIActive(state);
		}

		// Token: 0x0603B2D7 RID: 242391 RVA: 0x00E1C315 File Offset: 0x00E1A515
		public void SetAddReduceButtonActive(bool state)
		{
			this.ReduceLongPress.SetActive(state);
			this.AddLongPress.SetActive(state);
		}

		// Token: 0x0603B2D8 RID: 242392 RVA: 0x00E1C32F File Offset: 0x00E1A52F
		public void SetAddReduceButtonInteractive(bool state)
		{
			this.SetAddButtonInteractive(state);
			this.SetReduceButtonInteractive(state);
		}

		// Token: 0x0603B2D9 RID: 242393 RVA: 0x00E1C33F File Offset: 0x00E1A53F
		public void SetAddButtonInteractive(bool state)
		{
			base.GetButton(1).SetSelfInteractive(state);
		}

		// Token: 0x0603B2DA RID: 242394 RVA: 0x00E1C34E File Offset: 0x00E1A54E
		public void SetReduceButtonInteractive(bool state)
		{
			base.GetButton(0).SetSelfInteractive(state);
		}

		// Token: 0x0603B2DB RID: 242395 RVA: 0x00E1C35D File Offset: 0x00E1A55D
		[NullableContext(1)]
		public void Init(INumberSelectData data)
		{
			this.Data = data;
			this.Refresh(this.Data.MaxNumber);
		}

		// Token: 0x0603B2DC RID: 242396 RVA: 0x00E1C377 File Offset: 0x00E1A577
		public int GetSelectNumber()
		{
			return this.SelectNumber;
		}

		// Token: 0x0603B2DD RID: 242397 RVA: 0x00E1C37F File Offset: 0x00E1A57F
		public void SetLimitMaxValue(int value)
		{
			this.LimitMaxValue = Math.Min(value, 9999);
		}

		// Token: 0x0603B2DE RID: 242398 RVA: 0x00E1C392 File Offset: 0x00E1A592
		public void SetLimitMaxValueForce(int value)
		{
			this.LimitMaxValue = value;
		}

		// Token: 0x0603B2DF RID: 242399 RVA: 0x00E1C39B File Offset: 0x00E1A59B
		public void ResetLimitMaxValue()
		{
			this.LimitMaxValue = 9999;
		}

		// Token: 0x0603B2E0 RID: 242400 RVA: 0x00E1C3A8 File Offset: 0x00E1A5A8
		public void SetMinValue(int value)
		{
			this.MinValue = value;
		}

		// Token: 0x0603B2E1 RID: 242401 RVA: 0x00E1C3B1 File Offset: 0x00E1A5B1
		public void EnableUseCustomMinValue(bool enable)
		{
			this.UseCustomMinValue = enable;
		}

		// Token: 0x0603B2E2 RID: 242402 RVA: 0x00E1C3BA File Offset: 0x00E1A5BA
		public void Refresh(int maxNumber)
		{
			this.MaxValue = MathUtils.Instance.Clamp(maxNumber, this.MinValue, this.LimitMaxValue);
			this.InitSlider();
		}

		// Token: 0x0603B2E3 RID: 242403 RVA: 0x00E1C3DF File Offset: 0x00E1A5DF
		public void ChangeValue(int value, bool forceRefresh = true)
		{
			if (!forceRefresh && this.SelectNumber == value)
			{
				return;
			}
			this.Slider.SetValue((float)value, false);
			this.SliderValueChange((float)value);
		}

		// Token: 0x0603B2E4 RID: 242404 RVA: 0x00E1C404 File Offset: 0x00E1A604
		public void SetSliderAndButtonInteractive(bool state)
		{
			this.ReduceLongPress.SetInteractive(state);
			this.AddLongPress.SetInteractive(state);
			this.Slider.SetSelfInteractive(state);
			base.GetItem(6).SetRaycastTarget(state);
		}

		// Token: 0x0401ED6A RID: 126314
		private const int MAX_VALUE = 9999;

		// Token: 0x0401ED6B RID: 126315
		private LongPressButtonItem ReduceLongPress;

		// Token: 0x0401ED6C RID: 126316
		private LongPressButtonItem AddLongPress;

		// Token: 0x0401ED6D RID: 126317
		private UUISliderComponent Slider;

		// Token: 0x0401ED6E RID: 126318
		private UUIText BuyNumberTips;

		// Token: 0x0401ED6F RID: 126319
		private INumberSelectData Data;

		// Token: 0x0401ED70 RID: 126320
		private int SelectNumber;

		// Token: 0x0401ED71 RID: 126321
		private int MaxValue;

		// Token: 0x0401ED72 RID: 126322
		private int LimitMaxValue = 9999;

		// Token: 0x0401ED73 RID: 126323
		private int MinValue = 1;

		// Token: 0x0401ED74 RID: 126324
		private bool UseCustomMinValue;

		// Token: 0x0200BD78 RID: 48504
		[NullableContext(0)]
		public enum ECompDefine
		{
			// Token: 0x0403926E RID: 234094
			ReduceButton,
			// Token: 0x0403926F RID: 234095
			AddButton,
			// Token: 0x04039270 RID: 234096
			MinText,
			// Token: 0x04039271 RID: 234097
			MaxText,
			// Token: 0x04039272 RID: 234098
			Slider,
			// Token: 0x04039273 RID: 234099
			BuyNumberTips,
			// Token: 0x04039274 RID: 234100
			SpriteHandle,
			// Token: 0x04039275 RID: 234101
			MaxButton
		}
	}
}
