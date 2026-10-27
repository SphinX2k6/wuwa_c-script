using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.PhantomArena.Prepare.DeckBuilder
{
	// Token: 0x0200518C RID: 20876
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class DeckBuilderCardInfoTabItem : GridProxyAbstract<DeckBuilderCardInfoTabItemData>
	{
		// Token: 0x06035648 RID: 218696 RVA: 0x00CA5860 File Offset: 0x00CA3A60
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

		// Token: 0x06035649 RID: 218697 RVA: 0x00CA58C7 File Offset: 0x00CA3AC7
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

		// Token: 0x0603564A RID: 218698 RVA: 0x00CA58F8 File Offset: 0x00CA3AF8
		[NullableContext(1)]
		public override void Refresh(DeckBuilderCardInfoTabItemData data, bool isSelected, int gridIndex)
		{
			this.Data = data;
			LguiUtil.Instance.SetLocalTextNew(base.GetText(1), data.TabNameTextId, Array.Empty<object>());
		}

		// Token: 0x0603564B RID: 218699 RVA: 0x00CA591D File Offset: 0x00CA3B1D
		public override void OnSelected(bool fireEvent)
		{
			base.GetExtendToggle(0).SetToggleState(EToggleState.ETT_Checked, fireEvent, false, false);
		}

		// Token: 0x0603564C RID: 218700 RVA: 0x00CA5930 File Offset: 0x00CA3B30
		public override void OnDeselected(bool fireEvent)
		{
			base.GetExtendToggle(0).SetToggleState(EToggleState.ETT_UnChecked, fireEvent, false, false);
		}

		// Token: 0x0401C600 RID: 116224
		[Nullable(2)]
		private DeckBuilderCardInfoTabItemData Data;

		// Token: 0x0200B300 RID: 45824
		private static class EComponents
		{
			// Token: 0x040363FF RID: 222207
			public const int ItemToggle = 0;

			// Token: 0x04036400 RID: 222208
			public const int NameText = 1;
		}
	}
}
