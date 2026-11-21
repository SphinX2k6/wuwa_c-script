using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.WorldMap.SubViews.MapMarkToggle
{
	// Token: 0x02003736 RID: 14134
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class MapMarkToggleItem : GridProxyAbstract<IMapMarkToggleItemData>
	{
		// Token: 0x06024C3E RID: 150590 RVA: 0x00A6296C File Offset: 0x00A60B6C
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
			*span2[num] = new ValueTuple<int, Delegate>(0, new Action<EToggleState>(this.OnToggle));
			this.BtnBindInfo = list2;
		}

		// Token: 0x06024C3F RID: 150591 RVA: 0x00A62A14 File Offset: 0x00A60C14
		[NullableContext(1)]
		public override void Refresh(IMapMarkToggleItemData data, bool isSelected, int gridIndex)
		{
			this.DataParam = data;
			UUIExtendToggle extendToggle = base.GetExtendToggle(0);
			if (extendToggle != null)
			{
				Func<EToggleState> getToggleResultCallback = data.GetToggleResultCallback;
				extendToggle.SetToggleState((getToggleResultCallback != null) ? getToggleResultCallback() : EToggleState.ETT_UnChecked, false, false, false);
			}
			UUIText text = base.GetText(1);
			if (text == null)
			{
				return;
			}
			text.ShowTextNew(data.NameId);
		}

		// Token: 0x06024C40 RID: 150592 RVA: 0x00A62A67 File Offset: 0x00A60C67
		private void OnToggle(EToggleState state)
		{
			IMapMarkToggleItemData dataParam = this.DataParam;
			if (dataParam == null)
			{
				return;
			}
			Func<EToggleState, bool> setToggleStateCallback = dataParam.SetToggleStateCallback;
			if (setToggleStateCallback == null)
			{
				return;
			}
			setToggleStateCallback(state);
		}

		// Token: 0x04014666 RID: 83558
		[Nullable(2)]
		private IMapMarkToggleItemData DataParam;

		// Token: 0x02009485 RID: 38021
		public static class EChildType
		{
			// Token: 0x0402E6C0 RID: 190144
			public const int Toggle = 0;

			// Token: 0x0402E6C1 RID: 190145
			public const int TxtName = 1;
		}
	}
}
