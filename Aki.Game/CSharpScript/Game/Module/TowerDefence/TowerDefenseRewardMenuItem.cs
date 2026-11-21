using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.TowerDefence
{
	// Token: 0x02003B0A RID: 15114
	[NullableContext(2)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class TowerDefenseRewardMenuItem : GridProxyAbstract<TowerDefenseRewardMenuItemData>
	{
		// Token: 0x06026CFB RID: 158971 RVA: 0x00ADC98C File Offset: 0x00ADAB8C
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

		// Token: 0x06026CFC RID: 158972 RVA: 0x00ADCA54 File Offset: 0x00ADAC54
		[NullableContext(1)]
		public override void Refresh(TowerDefenseRewardMenuItemData data, bool isSelected, int gridIndex)
		{
			this.Data = data;
			base.GetText(1).SetText(data.Page.TabName ?? "", true);
			base.GetExtendToggle(0).SetToggleState(data.IsSelected ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked, false, false, false);
			base.GetItem(2).SetUIActive(data.HasRedDot);
		}

		// Token: 0x06026CFD RID: 158973 RVA: 0x00ADCAB7 File Offset: 0x00ADACB7
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

		// Token: 0x06026CFE RID: 158974 RVA: 0x00ADCAE9 File Offset: 0x00ADACE9
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

		// Token: 0x06026CFF RID: 158975 RVA: 0x00ADCB11 File Offset: 0x00ADAD11
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

		// Token: 0x0401538D RID: 86925
		public Action<int> OnClick;

		// Token: 0x0401538E RID: 86926
		private TowerDefenseRewardMenuItemData Data;

		// Token: 0x02009712 RID: 38674
		[NullableContext(0)]
		private class EMenuComponent
		{
			// Token: 0x0402F276 RID: 193142
			public const int Toggle = 0;

			// Token: 0x0402F277 RID: 193143
			public const int Text = 1;

			// Token: 0x0402F278 RID: 193144
			public const int RedDotItem = 2;
		}
	}
}
