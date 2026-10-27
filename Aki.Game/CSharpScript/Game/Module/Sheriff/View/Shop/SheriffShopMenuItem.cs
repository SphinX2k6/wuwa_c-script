using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.Sheriff.View.Shop
{
	// Token: 0x02004C60 RID: 19552
	public class SheriffShopMenuItem : GridProxyAbstract<int>
	{
		// Token: 0x060328AD RID: 207021 RVA: 0x00BC67A0 File Offset: 0x00BC49A0
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

		// Token: 0x060328AE RID: 207022 RVA: 0x00BC6848 File Offset: 0x00BC4A48
		public override void Refresh(int dataId, bool isSelected, int gridIndex)
		{
			this.Level = dataId;
			string text;
			SheriffShopDefine.SheriffShopTabMenuName.TryGetValue(this.Level, out text);
			base.GetText(1).ShowTextNew(text ?? "");
		}

		// Token: 0x060328AF RID: 207023 RVA: 0x00BC6885 File Offset: 0x00BC4A85
		[NullableContext(1)]
		public void SetOnClickToggleItem(Action<int> onClickToggleItem)
		{
			this.OnClickToggleItem = onClickToggleItem;
		}

		// Token: 0x060328B0 RID: 207024 RVA: 0x00BC688E File Offset: 0x00BC4A8E
		public void SetDeselect()
		{
			base.GetExtendToggle(0).SetToggleState(EToggleState.ETT_UnChecked, false, false, false);
		}

		// Token: 0x060328B1 RID: 207025 RVA: 0x00BC68A1 File Offset: 0x00BC4AA1
		public void SetSelect()
		{
			base.GetExtendToggle(0).SetToggleState(EToggleState.ETT_Checked, false, false, false);
		}

		// Token: 0x060328B2 RID: 207026 RVA: 0x00BC68B4 File Offset: 0x00BC4AB4
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

		// Token: 0x0401AE6B RID: 110187
		public int Level;

		// Token: 0x0401AE6C RID: 110188
		[Nullable(2)]
		private Action<int> OnClickToggleItem;

		// Token: 0x0200AE05 RID: 44549
		private class EMenuComponents
		{
			// Token: 0x04034DAF RID: 216495
			public const int ToggleItem = 0;

			// Token: 0x04034DB0 RID: 216496
			public const int TextTitle = 1;
		}
	}
}
