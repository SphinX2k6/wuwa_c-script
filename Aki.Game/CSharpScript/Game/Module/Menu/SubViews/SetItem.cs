using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.Menu.SubViews
{
	// Token: 0x0200543F RID: 21567
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class SetItem : GridProxyAbstract<ISetItemData>
	{
		// Token: 0x06037118 RID: 225560 RVA: 0x00D0CFFC File Offset: 0x00D0B1FC
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIExtendToggle)),
				new ValueTuple<int, Type>(1, typeof(UUIText))
			};
			this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
			{
				new ValueTuple<int, Delegate>(0, new Action<EToggleState>(this.OnClickItemToggle))
			};
		}

		// Token: 0x06037119 RID: 225561 RVA: 0x00D0D064 File Offset: 0x00D0B264
		public override void Refresh(ISetItemData data, bool isSelected, int gridIndex)
		{
			this.Data = data;
			LguiUtil.Instance.SetLocalTextNew(base.GetText(1), data.Name, Array.Empty<object>());
			EToggleState state = isSelected ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked;
			base.GetExtendToggle(0).SetToggleState(state, false, false, false);
		}

		// Token: 0x0603711A RID: 225562 RVA: 0x00D0D0AD File Offset: 0x00D0B2AD
		public override void OnSelected(bool fireEvent)
		{
			base.GetExtendToggle(0).SetToggleState(EToggleState.ETT_Checked, false, false, false);
		}

		// Token: 0x0603711B RID: 225563 RVA: 0x00D0D0C0 File Offset: 0x00D0B2C0
		public override void OnDeselected(bool fireEvent)
		{
			base.GetExtendToggle(0).SetToggleState(EToggleState.ETT_UnChecked, false, false, false);
		}

		// Token: 0x0603711C RID: 225564 RVA: 0x00D0D0D3 File Offset: 0x00D0B2D3
		private void OnClickItemToggle(EToggleState toggleState)
		{
			if (this.Data != null && this.CallbackClickItem != null)
			{
				this.CallbackClickItem(this.Data);
			}
		}

		// Token: 0x0401D0E2 RID: 119010
		[Nullable(2)]
		private ISetItemData Data;

		// Token: 0x0401D0E3 RID: 119011
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public Action<ISetItemData> CallbackClickItem;
	}
}
