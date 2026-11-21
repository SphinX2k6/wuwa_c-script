using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.PhantomArena.Prepare.DeckBuilder
{
	// Token: 0x02004176 RID: 16758
	[NullableContext(2)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class DeckBuilderSortFilterItem : GridProxyAbstract<IDeckBuilderSortFilterItemData>
	{
		// Token: 0x0602A69A RID: 173722 RVA: 0x00BF6124 File Offset: 0x00BF4324
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

		// Token: 0x0602A69B RID: 173723 RVA: 0x00BF618B File Offset: 0x00BF438B
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

		// Token: 0x0602A69C RID: 173724 RVA: 0x00BF61B2 File Offset: 0x00BF43B2
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

		// Token: 0x0602A69D RID: 173725 RVA: 0x00BF61E9 File Offset: 0x00BF43E9
		public override void OnSelected(bool fireEvent)
		{
			UUIExtendToggle extendToggle = base.GetExtendToggle(1);
			if (extendToggle == null)
			{
				return;
			}
			extendToggle.SetToggleState(EToggleState.ETT_Checked, fireEvent, false, false);
		}

		// Token: 0x0602A69E RID: 173726 RVA: 0x00BF6201 File Offset: 0x00BF4401
		public override void OnDeselected(bool fireEvent)
		{
			UUIExtendToggle extendToggle = base.GetExtendToggle(1);
			if (extendToggle == null)
			{
				return;
			}
			extendToggle.SetToggleState(EToggleState.ETT_UnChecked, fireEvent, false, false);
		}

		// Token: 0x040170AC RID: 94380
		protected IDeckBuilderSortFilterItemData Data;

		// Token: 0x040170AD RID: 94381
		public Action<int> OnToggleSelect;

		// Token: 0x02009D4D RID: 40269
		[NullableContext(0)]
		private static class EComponents
		{
			// Token: 0x04030EBE RID: 200382
			public const int Name = 0;

			// Token: 0x04030EBF RID: 200383
			public const int Toggle = 1;
		}
	}
}
