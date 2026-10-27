using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.Menu.SubViews.EyeProtect
{
	// Token: 0x0200544C RID: 21580
	[NullableContext(2)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class EyeProtectItem : GridProxyAbstract<EyeProtectItemData>
	{
		// Token: 0x0603718B RID: 225675 RVA: 0x00D0F1B4 File Offset: 0x00D0D3B4
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIExtendToggle)),
				new ValueTuple<int, Type>(1, typeof(UUIItem)),
				new ValueTuple<int, Type>(2, typeof(UUIText)),
				new ValueTuple<int, Type>(3, typeof(UUIItem)),
				new ValueTuple<int, Type>(4, typeof(UUIScrollViewWithScrollbarComponent)),
				new ValueTuple<int, Type>(5, typeof(UUIItem)),
				new ValueTuple<int, Type>(6, typeof(UUIItem)),
				new ValueTuple<int, Type>(7, typeof(UUIItem)),
				new ValueTuple<int, Type>(8, typeof(UUIItem))
			};
			this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
			{
				new ValueTuple<int, Delegate>(0, new Action<EToggleState>(this.TagToggle))
			};
		}

		// Token: 0x0603718C RID: 225676 RVA: 0x00D0F2B5 File Offset: 0x00D0D4B5
		private void TagToggle(EToggleState toggleState)
		{
			Action<int> selectCallback = this.SelectCallback;
			if (selectCallback == null)
			{
				return;
			}
			selectCallback(base.GridIndex);
		}

		// Token: 0x0603718D RID: 225677 RVA: 0x00D0F2CD File Offset: 0x00D0D4CD
		public void SetSelected(bool selected)
		{
			base.GetExtendToggle(0).SetToggleState(selected ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked, false, false, false);
			base.GetItem(3).SetUIActive(selected);
		}

		// Token: 0x0603718E RID: 225678 RVA: 0x00D0F2F3 File Offset: 0x00D0D4F3
		[NullableContext(1)]
		public override void Refresh(EyeProtectItemData data, bool isSelected, int gridIndex)
		{
			this.Data = data;
			this.InitData();
			if (isSelected)
			{
				this.OnSelected(false);
				return;
			}
			this.OnDeselected(false);
		}

		// Token: 0x0603718F RID: 225679 RVA: 0x00D0F314 File Offset: 0x00D0D514
		public void InitData()
		{
			if (this.Data == null)
			{
				return;
			}
			LguiUtil.Instance.TrySetLocalTextNew(base.GetText(2), this.Data.GetModeName(), Array.Empty<object>());
			if (this.Data.IsCustom())
			{
				base.GetItem(6).SetUIActive(false);
				base.GetItem(8).SetUIActive(true);
			}
			else
			{
				base.GetItem(6).SetUIActive(true);
				base.GetItem(8).SetUIActive(false);
			}
			this.ScrollView = new GenericScrollViewNew<EyeProtectSliderItem, EyeProtectSliderData>(base.GetScrollViewWithScrollbar(4), new Func<EyeProtectSliderItem>(this.CreateSliderItem), null, false, null);
			List<EyeProtectSliderData> sliderDataList = this.Data.GetViewModel().GetSliderDataList((EModeValue)this.Data.GetModeValue());
			if (sliderDataList != null)
			{
				this.ScrollView.RefreshByData(sliderDataList, null, false);
			}
			this.OnApply(GameSettingsManager.Instance.GetCurrentValueSafely(EFunction.EyeProtectionMode, 0, true));
		}

		// Token: 0x06037190 RID: 225680 RVA: 0x00D0F3F3 File Offset: 0x00D0D5F3
		[NullableContext(1)]
		private EyeProtectSliderItem CreateSliderItem()
		{
			return new EyeProtectSliderItem();
		}

		// Token: 0x06037191 RID: 225681 RVA: 0x00D0F3FA File Offset: 0x00D0D5FA
		public override void OnSelected(bool fireEvent)
		{
			this.SetSelected(true);
		}

		// Token: 0x06037192 RID: 225682 RVA: 0x00D0F403 File Offset: 0x00D0D603
		public override void OnDeselected(bool fireEvent)
		{
			this.SetSelected(false);
		}

		// Token: 0x06037193 RID: 225683 RVA: 0x00D0F40C File Offset: 0x00D0D60C
		public void OnApply(int value)
		{
			UUIItem item = base.GetItem(7);
			EyeProtectItemData data = this.Data;
			int? num = (data != null) ? new int?(data.GetModeValue()) : null;
			item.SetUIActive(value == num.GetValueOrDefault() & num != null);
		}

		// Token: 0x0401D118 RID: 119064
		public EyeProtectItemData Data;

		// Token: 0x0401D119 RID: 119065
		public Action<int> SelectCallback;

		// Token: 0x0401D11A RID: 119066
		public Func<int, bool> CanExecuteChange;

		// Token: 0x0401D11B RID: 119067
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		public GenericScrollViewNew<EyeProtectSliderItem, EyeProtectSliderData> ScrollView;

		// Token: 0x0200B6C6 RID: 46790
		[NullableContext(0)]
		public class EComponent
		{
			// Token: 0x040375F2 RID: 226802
			public const int ItemSelf = 0;

			// Token: 0x040375F3 RID: 226803
			public const int RedPoint = 1;

			// Token: 0x040375F4 RID: 226804
			public const int Title = 2;

			// Token: 0x040375F5 RID: 226805
			public const int SliderLayout = 3;

			// Token: 0x040375F6 RID: 226806
			public const int Scroll = 4;

			// Token: 0x040375F7 RID: 226807
			public const int SliderItem = 5;

			// Token: 0x040375F8 RID: 226808
			public const int Mask = 6;

			// Token: 0x040375F9 RID: 226809
			public const int Toggle = 7;

			// Token: 0x040375FA RID: 226810
			public const int GamePadKey = 8;
		}
	}
}
