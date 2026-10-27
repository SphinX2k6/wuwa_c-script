using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.PhantomArena.Prepare.DeckBuilder
{
	// Token: 0x020051A6 RID: 20902
	[NullableContext(2)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class DeckBuilderSortFilterItem : GridProxyAbstract<IDeckBuilderSortFilterItemData>
	{
		// Token: 0x0603579F RID: 219039 RVA: 0x00CA8AEC File Offset: 0x00CA6CEC
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIText)),
				new ValueTuple<int, Type>(1, typeof(UUIExtendToggle))
			};
			this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
			{
				new ValueTuple<int, Delegate>(1, new Action<EToggleState>(this.ToggleEvent))
			};
		}

		// Token: 0x060357A0 RID: 219040 RVA: 0x00CA8B53 File Offset: 0x00CA6D53
		private void ToggleEvent(EToggleState toggleState)
		{
			if (base.GetExtendToggle(1).GetToggleState() == EToggleState.ETT_Checked)
			{
				Action<int> onToggleSelect = this.OnToggleSelect;
				if (onToggleSelect == null)
				{
					return;
				}
				onToggleSelect(base.GridIndex);
			}
		}

		// Token: 0x060357A1 RID: 219041 RVA: 0x00CA8B7A File Offset: 0x00CA6D7A
		[NullableContext(1)]
		public override void Refresh(IDeckBuilderSortFilterItemData data, bool isSelected, int gridIndex)
		{
			this.Data = data;
			LguiUtil.Instance.SetLocalTextNew(base.GetText(0), data.Name, Array.Empty<object>());
			if (isSelected)
			{
				this.OnSelected(false);
				return;
			}
			this.OnDeselected(false);
		}

		// Token: 0x060357A2 RID: 219042 RVA: 0x00CA8BB1 File Offset: 0x00CA6DB1
		public override void OnSelected(bool fireEvent)
		{
			UUIExtendToggle extendToggle = base.GetExtendToggle(1);
			if (extendToggle == null)
			{
				return;
			}
			extendToggle.SetToggleState(EToggleState.ETT_Checked, fireEvent, false, false);
		}

		// Token: 0x060357A3 RID: 219043 RVA: 0x00CA8BC9 File Offset: 0x00CA6DC9
		public override void OnDeselected(bool fireEvent)
		{
			UUIExtendToggle extendToggle = base.GetExtendToggle(1);
			if (extendToggle == null)
			{
				return;
			}
			extendToggle.SetToggleState(EToggleState.ETT_UnChecked, fireEvent, false, false);
		}

		// Token: 0x0401C677 RID: 116343
		protected IDeckBuilderSortFilterItemData Data;

		// Token: 0x0401C678 RID: 116344
		public Action<int> OnToggleSelect;

		// Token: 0x0200B315 RID: 45845
		[NullableContext(0)]
		private static class EComponents
		{
			// Token: 0x0403646B RID: 222315
			public const int Name = 0;

			// Token: 0x0403646C RID: 222316
			public const int Toggle = 1;
		}
	}
}
