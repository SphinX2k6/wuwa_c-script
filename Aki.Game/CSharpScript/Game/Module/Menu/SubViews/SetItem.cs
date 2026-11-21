using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.Menu.SubViews
{
	// Token: 0x02004422 RID: 17442
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class SetItem : GridProxyAbstract<ISetItemData>
	{
		// Token: 0x0602C061 RID: 180321 RVA: 0x00C5C41C File Offset: 0x00C5A61C
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

		// Token: 0x0602C062 RID: 180322 RVA: 0x00C5C484 File Offset: 0x00C5A684
		public override void Refresh(ISetItemData data, bool isSelected, int gridIndex)
		{
			this.Data = data;
			LguiUtil.Instance.SetLocalTextNew(base.GetText(1), data.Name, Array.Empty<object>());
			EToggleState state = isSelected ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked;
			base.GetExtendToggle(0).SetToggleState(state, false, false, false);
		}

		// Token: 0x0602C063 RID: 180323 RVA: 0x00C5C4CD File Offset: 0x00C5A6CD
		public override void OnSelected(bool fireEvent)
		{
			base.GetExtendToggle(0).SetToggleState(EToggleState.ETT_Checked, false, false, false);
		}

		// Token: 0x0602C064 RID: 180324 RVA: 0x00C5C4E0 File Offset: 0x00C5A6E0
		public override void OnDeselected(bool fireEvent)
		{
			base.GetExtendToggle(0).SetToggleState(EToggleState.ETT_UnChecked, false, false, false);
		}

		// Token: 0x0602C065 RID: 180325 RVA: 0x00C5C4F3 File Offset: 0x00C5A6F3
		private void OnClickItemToggle(EToggleState toggleState)
		{
			if (this.Data != null && this.CallbackClickItem != null)
			{
				this.CallbackClickItem(this.Data);
			}
		}

		// Token: 0x04017B7B RID: 97147
		[Nullable(2)]
		private ISetItemData Data;

		// Token: 0x04017B7C RID: 97148
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public Action<ISetItemData> CallbackClickItem;
	}
}
