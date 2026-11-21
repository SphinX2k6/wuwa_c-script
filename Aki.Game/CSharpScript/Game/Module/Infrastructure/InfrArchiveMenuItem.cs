using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.Infrastructure
{
	// Token: 0x020048E0 RID: 18656
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class InfrArchiveMenuItem : GridProxyAbstract<IInfrArchiveMenuItemData>
	{
		// Token: 0x17005EA4 RID: 24228
		// (get) Token: 0x0602ED2B RID: 191787 RVA: 0x00D0E23A File Offset: 0x00D0C43A
		public InfrastructureDefine.EInfrArchiveTabType CardType
		{
			get
			{
				return this.Data.CardType;
			}
		}

		// Token: 0x0602ED2C RID: 191788 RVA: 0x00D0E248 File Offset: 0x00D0C448
		protected unsafe override void OnRegisterComponent()
		{
			int num = 2;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIExtendToggle));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
			this.ComponentRegisterInfos = list;
			num2 = 1;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(0, new Action<EToggleState>(this.ToggleClick));
			this.BtnBindInfo = list2;
		}

		// Token: 0x0602ED2D RID: 191789 RVA: 0x00D0E2EE File Offset: 0x00D0C4EE
		public override void Refresh(IInfrArchiveMenuItemData data, bool isSelected, int gridIndex)
		{
			this.Data = data;
			base.GetText(1).ShowTextNew(data.DesText);
		}

		// Token: 0x0602ED2E RID: 191790 RVA: 0x00D0E309 File Offset: 0x00D0C509
		public void SetToggleClickCb(Action<int> callback)
		{
			this.SelectedCallBack = callback;
		}

		// Token: 0x0602ED2F RID: 191791 RVA: 0x00D0E312 File Offset: 0x00D0C512
		public void SetToggleSelected(EToggleState state)
		{
			base.GetExtendToggle(0).SetToggleState(state, false, false, false);
		}

		// Token: 0x0602ED30 RID: 191792 RVA: 0x00D0E325 File Offset: 0x00D0C525
		private void ToggleClick(EToggleState state)
		{
			if (state == EToggleState.ETT_Checked)
			{
				this.SelectedCallBack((int)this.Data.CardType);
				return;
			}
			base.GetExtendToggle(0).SetToggleState(EToggleState.ETT_Checked, false, false, false);
		}

		// Token: 0x0602ED31 RID: 191793 RVA: 0x00D0E358 File Offset: 0x00D0C558
		[return: Nullable(new byte[]
		{
			2,
			1
		})]
		public override UUIItem[] GetGuideUiItemAndUiItemForShowEx(string[] configParams)
		{
			UUIExtendToggle extendToggle = base.GetExtendToggle(0);
			UUIItem uuiitem = (extendToggle != null) ? extendToggle.GetRootComponent() : null;
			if (uuiitem == null)
			{
				return null;
			}
			return new UUIItem[]
			{
				uuiitem,
				uuiitem
			};
		}

		// Token: 0x04018DA4 RID: 101796
		private IInfrArchiveMenuItemData Data;

		// Token: 0x04018DA5 RID: 101797
		public Action<int> SelectedCallBack;

		// Token: 0x0200A57E RID: 42366
		[NullableContext(0)]
		private class EChildType
		{
			// Token: 0x0403331D RID: 209693
			public const int ToggleItem = 0;

			// Token: 0x0403331E RID: 209694
			public const int TextTitle = 1;
		}
	}
}
