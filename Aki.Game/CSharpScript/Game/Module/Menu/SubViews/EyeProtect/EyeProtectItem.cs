using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.Menu.SubViews.EyeProtect
{
	// Token: 0x0200442F RID: 17455
	[NullableContext(2)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class EyeProtectItem : GridProxyAbstract<EyeProtectItemData>
	{
		// Token: 0x0602C0D4 RID: 180436 RVA: 0x00C5E5CC File Offset: 0x00C5C7CC
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

		// Token: 0x0602C0D5 RID: 180437 RVA: 0x00C5E6CD File Offset: 0x00C5C8CD
		private void TagToggle(EToggleState toggleState)
		{
			Action<int> selectCallback = this.SelectCallback;
			if (selectCallback == null)
			{
				return;
			}
			selectCallback(base.GridIndex);
		}

		// Token: 0x0602C0D6 RID: 180438 RVA: 0x00C5E6E5 File Offset: 0x00C5C8E5
		public void SetSelected(bool selected)
		{
			base.GetExtendToggle(0).SetToggleState(selected ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked, false, false, false);
			base.GetItem(3).SetUIActive(selected);
		}

		// Token: 0x0602C0D7 RID: 180439 RVA: 0x00C5E70B File Offset: 0x00C5C90B
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

		// Token: 0x0602C0D8 RID: 180440 RVA: 0x00C5E72C File Offset: 0x00C5C92C
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

		// Token: 0x0602C0D9 RID: 180441 RVA: 0x00C5E80B File Offset: 0x00C5CA0B
		[NullableContext(1)]
		private EyeProtectSliderItem CreateSliderItem()
		{
			return new EyeProtectSliderItem();
		}

		// Token: 0x0602C0DA RID: 180442 RVA: 0x00C5E812 File Offset: 0x00C5CA12
		public override void OnSelected(bool fireEvent)
		{
			this.SetSelected(true);
		}

		// Token: 0x0602C0DB RID: 180443 RVA: 0x00C5E81B File Offset: 0x00C5CA1B
		public override void OnDeselected(bool fireEvent)
		{
			this.SetSelected(false);
		}

		// Token: 0x0602C0DC RID: 180444 RVA: 0x00C5E824 File Offset: 0x00C5CA24
		public void OnApply(int value)
		{
			UUIItem item = base.GetItem(7);
			EyeProtectItemData data = this.Data;
			int? num = (data != null) ? new int?(data.GetModeValue()) : null;
			item.SetUIActive(value == num.GetValueOrDefault() & num != null);
		}

		// Token: 0x04017BB1 RID: 97201
		public EyeProtectItemData Data;

		// Token: 0x04017BB2 RID: 97202
		public Action<int> SelectCallback;

		// Token: 0x04017BB3 RID: 97203
		public Func<int, bool> CanExecuteChange;

		// Token: 0x04017BB4 RID: 97204
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		public GenericScrollViewNew<EyeProtectSliderItem, EyeProtectSliderData> ScrollView;

		// Token: 0x0200A0FE RID: 41214
		[NullableContext(0)]
		public class EComponent
		{
			// Token: 0x04032047 RID: 204871
			public const int ItemSelf = 0;

			// Token: 0x04032048 RID: 204872
			public const int RedPoint = 1;

			// Token: 0x04032049 RID: 204873
			public const int Title = 2;

			// Token: 0x0403204A RID: 204874
			public const int SliderLayout = 3;

			// Token: 0x0403204B RID: 204875
			public const int Scroll = 4;

			// Token: 0x0403204C RID: 204876
			public const int SliderItem = 5;

			// Token: 0x0403204D RID: 204877
			public const int Mask = 6;

			// Token: 0x0403204E RID: 204878
			public const int Toggle = 7;

			// Token: 0x0403204F RID: 204879
			public const int GamePadKey = 8;
		}
	}
}
