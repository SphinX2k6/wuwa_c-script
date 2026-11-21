using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.PhantomArena.Prepare.DeckBuilder
{
	// Token: 0x0200415C RID: 16732
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class DeckBuilderCardInfoTabItem : GridProxyAbstract<DeckBuilderCardInfoTabItemData>
	{
		// Token: 0x0602A543 RID: 173379 RVA: 0x00BF2E14 File Offset: 0x00BF1014
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIExtendToggle)),
				new ValueTuple<int, Type>(1, typeof(UUIText))
			};
			this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
			{
				new ValueTuple<int, Delegate>(0, new Action<EToggleState>(this.OnItemToggleStateChange))
			};
		}

		// Token: 0x0602A544 RID: 173380 RVA: 0x00BF2E7B File Offset: 0x00BF107B
		private void OnItemToggleStateChange(EToggleState toggleState)
		{
			if (base.GetExtendToggle(0).GetToggleState() == EToggleState.ETT_Checked)
			{
				Action<int> onSelect = this.Data.OnSelect;
				if (onSelect == null)
				{
					return;
				}
				onSelect(this.Data.TabIndex);
			}
		}

		// Token: 0x0602A545 RID: 173381 RVA: 0x00BF2EAC File Offset: 0x00BF10AC
		[NullableContext(1)]
		public override void Refresh(DeckBuilderCardInfoTabItemData data, bool isSelected, int gridIndex)
		{
			this.Data = data;
			LguiUtil.Instance.SetLocalTextNew(base.GetText(1), data.TabNameTextId, Array.Empty<object>());
		}

		// Token: 0x0602A546 RID: 173382 RVA: 0x00BF2ED1 File Offset: 0x00BF10D1
		public override void OnSelected(bool fireEvent)
		{
			base.GetExtendToggle(0).SetToggleState(EToggleState.ETT_Checked, fireEvent, false, false);
		}

		// Token: 0x0602A547 RID: 173383 RVA: 0x00BF2EE4 File Offset: 0x00BF10E4
		public override void OnDeselected(bool fireEvent)
		{
			base.GetExtendToggle(0).SetToggleState(EToggleState.ETT_UnChecked, fireEvent, false, false);
		}

		// Token: 0x04017035 RID: 94261
		[Nullable(2)]
		private DeckBuilderCardInfoTabItemData Data;

		// Token: 0x02009D39 RID: 40249
		private static class EComponents
		{
			// Token: 0x04030E54 RID: 200276
			public const int ItemToggle = 0;

			// Token: 0x04030E55 RID: 200277
			public const int NameText = 1;
		}
	}
}
