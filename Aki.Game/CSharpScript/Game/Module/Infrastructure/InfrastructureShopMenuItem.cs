using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.Infrastructure
{
	// Token: 0x020048FE RID: 18686
	public class InfrastructureShopMenuItem : GridProxyAbstract<int>
	{
		// Token: 0x0602EE9F RID: 192159 RVA: 0x00D17458 File Offset: 0x00D15658
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
			*span2[num] = new ValueTuple<int, Delegate>(0, new Action<EToggleState>(this.OnClickToggleItemInner));
			this.BtnBindInfo = list2;
		}

		// Token: 0x0602EEA0 RID: 192160 RVA: 0x00D17500 File Offset: 0x00D15700
		public override void Refresh(int dataId, bool isSelected, int gridIndex)
		{
			this.Level = dataId;
			UUIText text = base.GetText(1);
			if (text == null)
			{
				return;
			}
			string text2;
			text.ShowTextNew((InfrastructureDefine.infrShopTabMenuName.TryGetValue(this.Level, out text2) && text2 != null) ? text2 : "");
		}

		// Token: 0x0602EEA1 RID: 192161 RVA: 0x00D17544 File Offset: 0x00D15744
		[NullableContext(1)]
		public void SetOnClickToggleItem(Action<int> onClickToggleItem)
		{
			this.OnClickToggleItem = onClickToggleItem;
		}

		// Token: 0x0602EEA2 RID: 192162 RVA: 0x00D1754D File Offset: 0x00D1574D
		public void SetDeselect()
		{
			UUIExtendToggle extendToggle = base.GetExtendToggle(0);
			if (extendToggle == null)
			{
				return;
			}
			extendToggle.SetToggleState(EToggleState.ETT_UnChecked, false, false, false);
		}

		// Token: 0x0602EEA3 RID: 192163 RVA: 0x00D17565 File Offset: 0x00D15765
		public void SetSelect()
		{
			UUIExtendToggle extendToggle = base.GetExtendToggle(0);
			if (extendToggle == null)
			{
				return;
			}
			extendToggle.SetToggleState(EToggleState.ETT_Checked, false, false, false);
		}

		// Token: 0x0602EEA4 RID: 192164 RVA: 0x00D1757D File Offset: 0x00D1577D
		private void OnClickToggleItemInner(EToggleState state)
		{
			if (state == EToggleState.ETT_Checked)
			{
				Action<int> onClickToggleItem = this.OnClickToggleItem;
				if (onClickToggleItem == null)
				{
					return;
				}
				onClickToggleItem(this.Level);
			}
		}

		// Token: 0x04018E1B RID: 101915
		public int Level;

		// Token: 0x04018E1C RID: 101916
		[Nullable(2)]
		private Action<int> OnClickToggleItem;

		// Token: 0x0200A5D6 RID: 42454
		private class EChildType
		{
			// Token: 0x04033519 RID: 210201
			public const int ToggleItem = 0;

			// Token: 0x0403351A RID: 210202
			public const int TextTitle = 1;
		}
	}
}
