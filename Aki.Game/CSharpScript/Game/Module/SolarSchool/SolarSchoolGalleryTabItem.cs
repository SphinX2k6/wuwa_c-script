using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.SolarSchool
{
	// Token: 0x02005A26 RID: 23078
	public class SolarSchoolGalleryTabItem : UiPanelBase
	{
		// Token: 0x06038D5E RID: 232798 RVA: 0x00FE955C File Offset: 0x00FE775C
		protected unsafe override void OnRegisterComponent()
		{
			int num = 2;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIExtendToggle));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
			num2 = 1;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(0, new Action<EToggleState>(this.OnClickItem));
			this.BtnBindInfo = list2;
		}

		// Token: 0x06038D5F RID: 232799 RVA: 0x00FE9602 File Offset: 0x00FE7802
		private void OnClickItem(EToggleState toggleState)
		{
			if (this.TabType == null)
			{
				return;
			}
			Action<SolarSchoolGalleryType> callBack = this.CallBack;
			if (callBack == null)
			{
				return;
			}
			callBack(this.TabType.Value);
		}

		// Token: 0x06038D60 RID: 232800 RVA: 0x00FE962D File Offset: 0x00FE782D
		public SolarSchoolGalleryTabItem(SolarSchoolGalleryType tabType)
		{
			this.TabType = new SolarSchoolGalleryType?(tabType);
		}

		// Token: 0x06038D61 RID: 232801 RVA: 0x00FE9641 File Offset: 0x00FE7841
		[NullableContext(1)]
		public void SetClickCallback(Action<SolarSchoolGalleryType> callback)
		{
			this.CallBack = callback;
		}

		// Token: 0x06038D62 RID: 232802 RVA: 0x00FE964A File Offset: 0x00FE784A
		protected override void OnStart()
		{
			this.ActivityData = SolarSchoolModel.Instance.GetCurrentActivityData();
			if (this.TabType != null)
			{
				this.RefreshRedDot();
			}
		}

		// Token: 0x06038D63 RID: 232803 RVA: 0x00FE966F File Offset: 0x00FE786F
		public void RefreshRedDot()
		{
			base.GetItem(1).SetUIActive(this.HasRedDot());
		}

		// Token: 0x06038D64 RID: 232804 RVA: 0x00FE9684 File Offset: 0x00FE7884
		private bool HasRedDot()
		{
			if (this.TabType == null)
			{
				return false;
			}
			if (this.TabType.Value != SolarSchoolGalleryType.Ending)
			{
				return this.ActivityData.HasUnackedGalleryItem(this.TabType.Value);
			}
			return this.ActivityData.GetGalleryHasReward(SolarSchoolGalleryType.Ending);
		}

		// Token: 0x06038D65 RID: 232805 RVA: 0x00FE96D4 File Offset: 0x00FE78D4
		public void SetSelect(bool isSelected)
		{
			EToggleState state = isSelected ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked;
			base.GetExtendToggle(0).SetToggleState(state, false, false, false);
		}

		// Token: 0x0401DE98 RID: 122520
		[Nullable(2)]
		private Action<SolarSchoolGalleryType> CallBack;

		// Token: 0x0401DE99 RID: 122521
		private SolarSchoolGalleryType? TabType;

		// Token: 0x0401DE9A RID: 122522
		[Nullable(2)]
		private SolarSchoolActivityData ActivityData;

		// Token: 0x0200B5F5 RID: 46581
		private class EComponents
		{
			// Token: 0x04038446 RID: 230470
			public const int Toggle = 0;

			// Token: 0x04038447 RID: 230471
			public const int RedDodItem = 1;
		}
	}
}
