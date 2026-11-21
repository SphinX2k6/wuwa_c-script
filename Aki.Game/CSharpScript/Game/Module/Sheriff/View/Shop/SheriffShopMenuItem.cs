using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.Sheriff.View.Shop
{
	// Token: 0x02003C11 RID: 15377
	public class SheriffShopMenuItem : GridProxyAbstract<int>
	{
		// Token: 0x06027660 RID: 161376 RVA: 0x00B0B3EC File Offset: 0x00B095EC
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

		// Token: 0x06027661 RID: 161377 RVA: 0x00B0B494 File Offset: 0x00B09694
		public override void Refresh(int dataId, bool isSelected, int gridIndex)
		{
			this.Level = dataId;
			string text;
			SheriffShopDefine.SheriffShopTabMenuName.TryGetValue(this.Level, out text);
			base.GetText(1).ShowTextNew(text ?? "");
		}

		// Token: 0x06027662 RID: 161378 RVA: 0x00B0B4D1 File Offset: 0x00B096D1
		[NullableContext(1)]
		public void SetOnClickToggleItem(Action<int> onClickToggleItem)
		{
			this.OnClickToggleItem = onClickToggleItem;
		}

		// Token: 0x06027663 RID: 161379 RVA: 0x00B0B4DA File Offset: 0x00B096DA
		public void SetDeselect()
		{
			base.GetExtendToggle(0).SetToggleState(EToggleState.ETT_UnChecked, false, false, false);
		}

		// Token: 0x06027664 RID: 161380 RVA: 0x00B0B4ED File Offset: 0x00B096ED
		public void SetSelect()
		{
			base.GetExtendToggle(0).SetToggleState(EToggleState.ETT_Checked, false, false, false);
		}

		// Token: 0x06027665 RID: 161381 RVA: 0x00B0B500 File Offset: 0x00B09700
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

		// Token: 0x040157C8 RID: 88008
		public int Level;

		// Token: 0x040157C9 RID: 88009
		[Nullable(2)]
		private Action<int> OnClickToggleItem;

		// Token: 0x02009823 RID: 38947
		private class EMenuComponents
		{
			// Token: 0x0402F754 RID: 194388
			public const int ToggleItem = 0;

			// Token: 0x0402F755 RID: 194389
			public const int TextTitle = 1;
		}
	}
}
