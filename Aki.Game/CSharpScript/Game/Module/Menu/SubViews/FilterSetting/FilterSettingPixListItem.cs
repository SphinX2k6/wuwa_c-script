using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Common;
using CSharpScript.Game.Module.AutoAttach;
using UnrealEngine;

namespace CSharpScript.Game.Module.Menu.SubViews.FilterSetting
{
	// Token: 0x02005447 RID: 21575
	[NullableContext(2)]
	[Nullable(0)]
	public class FilterSettingPixListItem : AutoAttachItem<FilterSetting>
	{
		// Token: 0x0603715D RID: 225629 RVA: 0x00D0E9C2 File Offset: 0x00D0CBC2
		public FilterSettingPixListItem(AActor uiItem = null) : base(uiItem)
		{
		}

		// Token: 0x0603715E RID: 225630 RVA: 0x00D0E9CC File Offset: 0x00D0CBCC
		public override void OnSelect()
		{
			FilterSettingViewModel parentViewModel = this.ParentViewModel;
			if (parentViewModel != null)
			{
				Action<int> onIndexChanged = parentViewModel.OnIndexChanged;
				if (onIndexChanged != null)
				{
					onIndexChanged(base.GetCurrentShowItemIndex());
				}
			}
			UUIExtendToggle extendToggle = base.GetExtendToggle(1);
			if (extendToggle == null)
			{
				return;
			}
			extendToggle.RootUIComp.Get().SetUIActive(true);
		}

		// Token: 0x0603715F RID: 225631 RVA: 0x00D0EA1C File Offset: 0x00D0CC1C
		protected override void OnUnSelect()
		{
			UUIExtendToggle extendToggle = base.GetExtendToggle(1);
			if (extendToggle == null)
			{
				return;
			}
			extendToggle.RootUIComp.Get().SetUIActive(false);
		}

		// Token: 0x06037160 RID: 225632 RVA: 0x00D0EA48 File Offset: 0x00D0CC48
		protected override void OnMoveItem()
		{
			float currentMovePercentage = base.GetCurrentMovePercentage();
			this.RefreshScaleByCurve(currentMovePercentage);
			this.RefreshAlphaByCurve(currentMovePercentage);
			this.RefreshHierarchyIndex(currentMovePercentage);
		}

		// Token: 0x06037161 RID: 225633 RVA: 0x00D0EA71 File Offset: 0x00D0CC71
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUITexture)),
				new ValueTuple<int, Type>(1, typeof(UUIExtendToggle))
			};
		}

		// Token: 0x06037162 RID: 225634 RVA: 0x00D0EAAC File Offset: 0x00D0CCAC
		protected override void OnRefreshItem(FilterSetting data)
		{
			base.TrySetTextureByPath(data.SpritePath, base.GetTexture(0), null, null);
			EToggleState state = (LocalStorage.GetGlobal<int>(ELocalStorageGlobalKey.FilterSettingId, 1) == data.Id) ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked;
			UUIExtendToggle extendToggle = base.GetExtendToggle(1);
			if (extendToggle == null)
			{
				return;
			}
			extendToggle.SetToggleStateForce(state, false, false, false);
		}

		// Token: 0x06037163 RID: 225635 RVA: 0x00D0EB08 File Offset: 0x00D0CD08
		private void RefreshScaleByCurve(float percentage)
		{
			if (this.ScaleCurve != null)
			{
				float floatValue = this.ScaleCurve.GetFloatValue(percentage);
				FVector uiitemScale = new FVector(floatValue, floatValue, floatValue);
				this.RootItem.SetUIItemScale(uiitemScale);
			}
		}

		// Token: 0x06037164 RID: 225636 RVA: 0x00D0EB40 File Offset: 0x00D0CD40
		private void RefreshAlphaByCurve(float percentage)
		{
			if (this.AlphaCurve != null)
			{
				float floatValue = this.AlphaCurve.GetFloatValue(percentage);
				this.RootItem.SetUIItemAlpha(floatValue);
			}
		}

		// Token: 0x06037165 RID: 225637 RVA: 0x00D0EB70 File Offset: 0x00D0CD70
		private void RefreshHierarchyIndex(float percentage)
		{
			int num = 2;
			if (percentage <= 0.25f)
			{
				num = 1;
			}
			else if (percentage >= 0.75f)
			{
				num = 1;
			}
			if (this.RootItem.GetHierarchyIndex() != num)
			{
				this.RootItem.SetHierarchyIndex(num);
			}
		}

		// Token: 0x0401D0FD RID: 119037
		private const float INDEXQUARTER = 0.25f;

		// Token: 0x0401D0FE RID: 119038
		private const float INDEXTHREEQUARTER = 0.75f;

		// Token: 0x0401D0FF RID: 119039
		private const int MAXHIERARCHYINDEX = 2;

		// Token: 0x0401D100 RID: 119040
		private const int MINHIERARCHYINDEX = 1;

		// Token: 0x0401D101 RID: 119041
		public FilterSettingViewModel ParentViewModel;

		// Token: 0x0401D102 RID: 119042
		public UCurveFloat OffsetCurve;

		// Token: 0x0401D103 RID: 119043
		public UCurveFloat ScaleCurve;

		// Token: 0x0401D104 RID: 119044
		public UCurveFloat AlphaCurve;
	}
}
