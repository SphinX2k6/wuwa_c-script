using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Common.NumberSelect
{
	// Token: 0x02004B2D RID: 19245
	[NullableContext(2)]
	[Nullable(0)]
	public class NumberSelectComponent : UiPanelBase
	{
		// Token: 0x0603020F RID: 197135 RVA: 0x00D6C254 File Offset: 0x00D6A454
		[NullableContext(1)]
		public NumberSelectComponent(UUIItem uiItem)
		{
			base.CreateThenShowByActor(uiItem.GetOwner(), null);
		}

		// Token: 0x06030210 RID: 197136 RVA: 0x00D6C27C File Offset: 0x00D6A47C
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

		// Token: 0x06030211 RID: 197137 RVA: 0x00D6C3E8 File Offset: 0x00D6A5E8
		private void OnClickMax()
		{
			this.SelectMax();
		}

		// Token: 0x06030212 RID: 197138 RVA: 0x00D6C3F0 File Offset: 0x00D6A5F0
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

		// Token: 0x06030213 RID: 197139 RVA: 0x00D6C4B0 File Offset: 0x00D6A6B0
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

		// Token: 0x06030214 RID: 197140 RVA: 0x00D6C572 File Offset: 0x00D6A772
		private void ReducePointClick(bool _)
		{
			this.Slider.SetValue((float)(this.SelectNumber - 1), true);
		}

		// Token: 0x06030215 RID: 197141 RVA: 0x00D6C589 File Offset: 0x00D6A789
		private void AddPointClick(bool _)
		{
			this.Slider.SetValue((float)(this.SelectNumber + 1), true);
		}

		// Token: 0x06030216 RID: 197142 RVA: 0x00D6C5A0 File Offset: 0x00D6A7A0
		protected override void OnBeforeDestroy()
		{
			this.Slider.OnValueChangeCb.Unbind();
			this.AddLongPress.ShouldPlayLongPressSound = false;
			this.ReduceLongPress.ShouldPlayLongPressSound = false;
			this.ReduceLongPress.Clear();
			this.AddLongPress.Clear();
		}

		// Token: 0x06030217 RID: 197143 RVA: 0x00D6C5E0 File Offset: 0x00D6A7E0
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

		// Token: 0x06030218 RID: 197144 RVA: 0x00D6C690 File Offset: 0x00D6A890
		public void SetMaxBtnShowState(bool state)
		{
			UUIButtonComponent button = base.GetButton(7);
			if (button == null)
			{
				return;
			}
			button.RootUIComp.Get().SetUIActive(state);
		}

		// Token: 0x06030219 RID: 197145 RVA: 0x00D6C6BC File Offset: 0x00D6A8BC
		public bool GetIfLimit()
		{
			return this.MaxValue <= 1;
		}

		// Token: 0x0603021A RID: 197146 RVA: 0x00D6C6CA File Offset: 0x00D6A8CA
		public bool GetIfSelectMax()
		{
			return this.SelectNumber == this.MaxValue;
		}

		// Token: 0x0603021B RID: 197147 RVA: 0x00D6C6DA File Offset: 0x00D6A8DA
		public void SelectMax()
		{
			this.Slider.SetValue((float)this.MaxValue, false);
			this.SliderValueChange((float)this.MaxValue);
		}

		// Token: 0x0603021C RID: 197148 RVA: 0x00D6C6FC File Offset: 0x00D6A8FC
		[NullableContext(1)]
		public void SetNumberSelectTipsText(string text)
		{
			this.BuyNumberTips.SetText(text, true);
		}

		// Token: 0x0603021D RID: 197149 RVA: 0x00D6C70B File Offset: 0x00D6A90B
		public void SetNumberSelectTipsVisible(bool bVisible)
		{
			this.BuyNumberTips.SetUIActive(bVisible);
		}

		// Token: 0x0603021E RID: 197150 RVA: 0x00D6C719 File Offset: 0x00D6A919
		public virtual void SetComponentLimitState(bool isLimit)
		{
			this.SetMinTextShowState(!isLimit);
			base.GetItem(6).SetRaycastTarget(!isLimit);
			this.Slider.SetSelfInteractive(!isLimit);
			this.SetAddReduceButtonActive(!isLimit);
		}

		// Token: 0x0603021F RID: 197151 RVA: 0x00D6C74E File Offset: 0x00D6A94E
		public void SetMinTextShowState(bool state)
		{
			base.GetText(2).SetUIActive(state);
		}

		// Token: 0x06030220 RID: 197152 RVA: 0x00D6C75D File Offset: 0x00D6A95D
		public void SetAddReduceButtonActive(bool state)
		{
			this.ReduceLongPress.SetActive(state);
			this.AddLongPress.SetActive(state);
		}

		// Token: 0x06030221 RID: 197153 RVA: 0x00D6C777 File Offset: 0x00D6A977
		public void SetAddReduceButtonInteractive(bool state)
		{
			this.SetAddButtonInteractive(state);
			this.SetReduceButtonInteractive(state);
		}

		// Token: 0x06030222 RID: 197154 RVA: 0x00D6C787 File Offset: 0x00D6A987
		public void SetAddButtonInteractive(bool state)
		{
			base.GetButton(1).SetSelfInteractive(state);
		}

		// Token: 0x06030223 RID: 197155 RVA: 0x00D6C796 File Offset: 0x00D6A996
		public void SetReduceButtonInteractive(bool state)
		{
			base.GetButton(0).SetSelfInteractive(state);
		}

		// Token: 0x06030224 RID: 197156 RVA: 0x00D6C7A5 File Offset: 0x00D6A9A5
		[NullableContext(1)]
		public void Init(INumberSelectData data)
		{
			this.Data = data;
			this.Refresh(this.Data.MaxNumber);
		}

		// Token: 0x06030225 RID: 197157 RVA: 0x00D6C7BF File Offset: 0x00D6A9BF
		public int GetSelectNumber()
		{
			return this.SelectNumber;
		}

		// Token: 0x06030226 RID: 197158 RVA: 0x00D6C7C7 File Offset: 0x00D6A9C7
		public void SetLimitMaxValue(int value)
		{
			this.LimitMaxValue = Math.Min(value, 9999);
		}

		// Token: 0x06030227 RID: 197159 RVA: 0x00D6C7DA File Offset: 0x00D6A9DA
		public void SetLimitMaxValueForce(int value)
		{
			this.LimitMaxValue = value;
		}

		// Token: 0x06030228 RID: 197160 RVA: 0x00D6C7E3 File Offset: 0x00D6A9E3
		public void ResetLimitMaxValue()
		{
			this.LimitMaxValue = 9999;
		}

		// Token: 0x06030229 RID: 197161 RVA: 0x00D6C7F0 File Offset: 0x00D6A9F0
		public void SetMinValue(int value)
		{
			this.MinValue = value;
		}

		// Token: 0x0603022A RID: 197162 RVA: 0x00D6C7F9 File Offset: 0x00D6A9F9
		public void EnableUseCustomMinValue(bool enable)
		{
			this.UseCustomMinValue = enable;
		}

		// Token: 0x0603022B RID: 197163 RVA: 0x00D6C802 File Offset: 0x00D6AA02
		public void Refresh(int maxNumber)
		{
			this.MaxValue = MathUtils.Instance.Clamp(maxNumber, this.MinValue, this.LimitMaxValue);
			this.InitSlider();
		}

		// Token: 0x0603022C RID: 197164 RVA: 0x00D6C827 File Offset: 0x00D6AA27
		public void ChangeValue(int value, bool forceRefresh = true)
		{
			if (!forceRefresh && this.SelectNumber == value)
			{
				return;
			}
			this.Slider.SetValue((float)value, false);
			this.SliderValueChange((float)value);
		}

		// Token: 0x0603022D RID: 197165 RVA: 0x00D6C84C File Offset: 0x00D6AA4C
		public void SetSliderAndButtonInteractive(bool state)
		{
			this.ReduceLongPress.SetInteractive(state);
			this.AddLongPress.SetInteractive(state);
			this.Slider.SetSelfInteractive(state);
			base.GetItem(6).SetRaycastTarget(state);
		}

		// Token: 0x04019816 RID: 104470
		private const int MAX_VALUE = 9999;

		// Token: 0x04019817 RID: 104471
		private LongPressButtonItem ReduceLongPress;

		// Token: 0x04019818 RID: 104472
		private LongPressButtonItem AddLongPress;

		// Token: 0x04019819 RID: 104473
		private UUISliderComponent Slider;

		// Token: 0x0401981A RID: 104474
		private UUIText BuyNumberTips;

		// Token: 0x0401981B RID: 104475
		private INumberSelectData Data;

		// Token: 0x0401981C RID: 104476
		private int SelectNumber;

		// Token: 0x0401981D RID: 104477
		private int MaxValue;

		// Token: 0x0401981E RID: 104478
		private int LimitMaxValue = 9999;

		// Token: 0x0401981F RID: 104479
		private int MinValue = 1;

		// Token: 0x04019820 RID: 104480
		private bool UseCustomMinValue;

		// Token: 0x0200A782 RID: 42882
		[NullableContext(0)]
		public enum ECompDefine
		{
			// Token: 0x04033C3C RID: 212028
			ReduceButton,
			// Token: 0x04033C3D RID: 212029
			AddButton,
			// Token: 0x04033C3E RID: 212030
			MinText,
			// Token: 0x04033C3F RID: 212031
			MaxText,
			// Token: 0x04033C40 RID: 212032
			Slider,
			// Token: 0x04033C41 RID: 212033
			BuyNumberTips,
			// Token: 0x04033C42 RID: 212034
			SpriteHandle,
			// Token: 0x04033C43 RID: 212035
			MaxButton
		}
	}
}
