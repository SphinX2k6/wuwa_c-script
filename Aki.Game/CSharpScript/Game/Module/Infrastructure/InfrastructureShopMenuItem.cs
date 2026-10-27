using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.Infrastructure
{
	// Token: 0x02005925 RID: 22821
	public class InfrastructureShopMenuItem : GridProxyAbstract<int>
	{
		// Token: 0x06039F7C RID: 237436 RVA: 0x00DC8160 File Offset: 0x00DC6360
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

		// Token: 0x06039F7D RID: 237437 RVA: 0x00DC8208 File Offset: 0x00DC6408
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

		// Token: 0x06039F7E RID: 237438 RVA: 0x00DC824C File Offset: 0x00DC644C
		[NullableContext(1)]
		public void SetOnClickToggleItem(Action<int> onClickToggleItem)
		{
			this.OnClickToggleItem = onClickToggleItem;
		}

		// Token: 0x06039F7F RID: 237439 RVA: 0x00DC8255 File Offset: 0x00DC6455
		public void SetDeselect()
		{
			UUIExtendToggle extendToggle = base.GetExtendToggle(0);
			if (extendToggle == null)
			{
				return;
			}
			extendToggle.SetToggleState(EToggleState.ETT_UnChecked, false, false, false);
		}

		// Token: 0x06039F80 RID: 237440 RVA: 0x00DC826D File Offset: 0x00DC646D
		public void SetSelect()
		{
			UUIExtendToggle extendToggle = base.GetExtendToggle(0);
			if (extendToggle == null)
			{
				return;
			}
			extendToggle.SetToggleState(EToggleState.ETT_Checked, false, false, false);
		}

		// Token: 0x06039F81 RID: 237441 RVA: 0x00DC8285 File Offset: 0x00DC6485
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

		// Token: 0x0401E37E RID: 123774
		public int Level;

		// Token: 0x0401E37F RID: 123775
		[Nullable(2)]
		private Action<int> OnClickToggleItem;

		// Token: 0x0200BBC7 RID: 48071
		private class EChildType
		{
			// Token: 0x04038B3A RID: 232250
			public const int ToggleItem = 0;

			// Token: 0x04038B3B RID: 232251
			public const int TextTitle = 1;
		}
	}
}
