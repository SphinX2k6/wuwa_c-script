using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.DangoBrawl
{
	// Token: 0x0200575B RID: 22363
	public class DangoBrawlHandBookTabItem : UiPanelBase
	{
		// Token: 0x06037245 RID: 225861 RVA: 0x00F64210 File Offset: 0x00F62410
		protected unsafe override void OnRegisterComponent()
		{
			int num = 2;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIExtendToggle));
			this.ComponentRegisterInfos = list;
			num2 = 1;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(1, new Action<EToggleState>(this.OnToggleClick));
			this.BtnBindInfo = list2;
		}

		// Token: 0x06037246 RID: 225862 RVA: 0x00F642B6 File Offset: 0x00F624B6
		public void SetRedDotVisible(bool visible)
		{
			UUIItem item = base.GetItem(0);
			if (item == null)
			{
				return;
			}
			item.SetUIActive(visible);
		}

		// Token: 0x06037247 RID: 225863 RVA: 0x00F642CA File Offset: 0x00F624CA
		public void RefreshTabIndex(int index)
		{
			this.TabIndex = index;
		}

		// Token: 0x06037248 RID: 225864 RVA: 0x00F642D3 File Offset: 0x00F624D3
		public void SetToggleState(EToggleState state, bool bFire)
		{
			UUIExtendToggle extendToggle = base.GetExtendToggle(1);
			if (extendToggle == null)
			{
				return;
			}
			extendToggle.SetToggleStateForce(state, bFire, false, false);
		}

		// Token: 0x06037249 RID: 225865 RVA: 0x00F642EA File Offset: 0x00F624EA
		private void OnToggleClick(EToggleState state)
		{
			Action<int, UUIExtendToggle> onClickToggleBack = this.OnClickToggleBack;
			if (onClickToggleBack == null)
			{
				return;
			}
			onClickToggleBack(this.TabIndex, base.GetExtendToggle(1));
		}

		// Token: 0x0401D25D RID: 119389
		private int TabIndex;

		// Token: 0x0401D25E RID: 119390
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public Action<int, UUIExtendToggle> OnClickToggleBack;

		// Token: 0x0200B352 RID: 45906
		private enum ETabItemComponent
		{
			// Token: 0x040376B2 RID: 226994
			RedDotItem,
			// Token: 0x040376B3 RID: 226995
			TogItem
		}
	}
}
