using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.TowerDefence
{
	// Token: 0x02004B62 RID: 19298
	[NullableContext(2)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class TowerDefenseRewardMenuItem : GridProxyAbstract<TowerDefenseRewardMenuItemData>
	{
		// Token: 0x06031F6C RID: 204652 RVA: 0x00B98750 File Offset: 0x00B96950
		protected unsafe override void OnRegisterComponent()
		{
			int num = 3;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIExtendToggle));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
			num2 = 1;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(0, new Action<EToggleState>(this.OnClickToggle));
			this.BtnBindInfo = list2;
		}

		// Token: 0x06031F6D RID: 204653 RVA: 0x00B98818 File Offset: 0x00B96A18
		[NullableContext(1)]
		public override void Refresh(TowerDefenseRewardMenuItemData data, bool isSelected, int gridIndex)
		{
			this.Data = data;
			base.GetText(1).SetText(data.Page.TabName ?? "", true);
			base.GetExtendToggle(0).SetToggleState(data.IsSelected ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked, false, false, false);
			base.GetItem(2).SetUIActive(data.HasRedDot);
		}

		// Token: 0x06031F6E RID: 204654 RVA: 0x00B9887B File Offset: 0x00B96A7B
		public void SetSelected(bool isSelected)
		{
			if (this.Data != null)
			{
				this.Data.IsSelected = isSelected;
			}
			UUIExtendToggle extendToggle = base.GetExtendToggle(0);
			if (extendToggle == null)
			{
				return;
			}
			extendToggle.SetToggleState(isSelected ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked, false, false, false);
		}

		// Token: 0x06031F6F RID: 204655 RVA: 0x00B988AD File Offset: 0x00B96AAD
		public void SetRedDot(bool hasRedDot)
		{
			if (this.Data != null)
			{
				this.Data.HasRedDot = hasRedDot;
			}
			UUIItem item = base.GetItem(2);
			if (item == null)
			{
				return;
			}
			item.SetUIActive(hasRedDot);
		}

		// Token: 0x06031F70 RID: 204656 RVA: 0x00B988D5 File Offset: 0x00B96AD5
		private void OnClickToggle(EToggleState state)
		{
			if (this.Data != null)
			{
				Action<int> onClick = this.OnClick;
				if (onClick == null)
				{
					return;
				}
				onClick(this.Data.Index);
			}
		}

		// Token: 0x0401AA3B RID: 109115
		public Action<int> OnClick;

		// Token: 0x0401AA3C RID: 109116
		private TowerDefenseRewardMenuItemData Data;

		// Token: 0x0200ACF3 RID: 44275
		[NullableContext(0)]
		private class EMenuComponent
		{
			// Token: 0x040348CD RID: 215245
			public const int Toggle = 0;

			// Token: 0x040348CE RID: 215246
			public const int Text = 1;

			// Token: 0x040348CF RID: 215247
			public const int RedDotItem = 2;
		}
	}
}
