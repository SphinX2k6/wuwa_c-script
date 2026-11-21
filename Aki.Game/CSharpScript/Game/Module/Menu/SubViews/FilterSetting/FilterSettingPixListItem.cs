using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Common;
using CSharpScript.Game.Module.AutoAttach;
using UnrealEngine;

namespace CSharpScript.Game.Module.Menu.SubViews.FilterSetting
{
	// Token: 0x0200442A RID: 17450
	[NullableContext(2)]
	[Nullable(0)]
	public class FilterSettingPixListItem : AutoAttachItem<FilterSetting>
	{
		// Token: 0x0602C0A6 RID: 180390 RVA: 0x00C5DDDA File Offset: 0x00C5BFDA
		public FilterSettingPixListItem(AActor uiItem = null) : base(uiItem)
		{
		}

		// Token: 0x0602C0A7 RID: 180391 RVA: 0x00C5DDE4 File Offset: 0x00C5BFE4
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

		// Token: 0x0602C0A8 RID: 180392 RVA: 0x00C5DE34 File Offset: 0x00C5C034
		protected override void OnUnSelect()
		{
			UUIExtendToggle extendToggle = base.GetExtendToggle(1);
			if (extendToggle == null)
			{
				return;
			}
			extendToggle.RootUIComp.Get().SetUIActive(false);
		}

		// Token: 0x0602C0A9 RID: 180393 RVA: 0x00C5DE60 File Offset: 0x00C5C060
		protected override void OnMoveItem()
		{
			float currentMovePercentage = base.GetCurrentMovePercentage();
			this.RefreshScaleByCurve(currentMovePercentage);
			this.RefreshAlphaByCurve(currentMovePercentage);
			this.RefreshHierarchyIndex(currentMovePercentage);
		}

		// Token: 0x0602C0AA RID: 180394 RVA: 0x00C5DE89 File Offset: 0x00C5C089
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUITexture)),
				new ValueTuple<int, Type>(1, typeof(UUIExtendToggle))
			};
		}

		// Token: 0x0602C0AB RID: 180395 RVA: 0x00C5DEC4 File Offset: 0x00C5C0C4
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

		// Token: 0x0602C0AC RID: 180396 RVA: 0x00C5DF20 File Offset: 0x00C5C120
		private void RefreshScaleByCurve(float percentage)
		{
			if (this.ScaleCurve != null)
			{
				float floatValue = this.ScaleCurve.GetFloatValue(percentage);
				FVector uiitemScale = new FVector(floatValue, floatValue, floatValue);
				this.RootItem.SetUIItemScale(uiitemScale);
			}
		}

		// Token: 0x0602C0AD RID: 180397 RVA: 0x00C5DF58 File Offset: 0x00C5C158
		private void RefreshAlphaByCurve(float percentage)
		{
			if (this.AlphaCurve != null)
			{
				float floatValue = this.AlphaCurve.GetFloatValue(percentage);
				this.RootItem.SetUIItemAlpha(floatValue);
			}
		}

		// Token: 0x0602C0AE RID: 180398 RVA: 0x00C5DF88 File Offset: 0x00C5C188
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

		// Token: 0x04017B96 RID: 97174
		private const float INDEXQUARTER = 0.25f;

		// Token: 0x04017B97 RID: 97175
		private const float INDEXTHREEQUARTER = 0.75f;

		// Token: 0x04017B98 RID: 97176
		private const int MAXHIERARCHYINDEX = 2;

		// Token: 0x04017B99 RID: 97177
		private const int MINHIERARCHYINDEX = 1;

		// Token: 0x04017B9A RID: 97178
		public FilterSettingViewModel ParentViewModel;

		// Token: 0x04017B9B RID: 97179
		public UCurveFloat OffsetCurve;

		// Token: 0x04017B9C RID: 97180
		public UCurveFloat ScaleCurve;

		// Token: 0x04017B9D RID: 97181
		public UCurveFloat AlphaCurve;
	}
}
