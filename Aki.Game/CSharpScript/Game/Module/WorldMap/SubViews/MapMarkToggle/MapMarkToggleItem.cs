using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.WorldMap.SubViews.MapMarkToggle
{
	// Token: 0x02004805 RID: 18437
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class MapMarkToggleItem : GridProxyAbstract<IMapMarkToggleItemData>
	{
		// Token: 0x0603046E RID: 197742 RVA: 0x00B32A04 File Offset: 0x00B30C04
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

		// Token: 0x0603046F RID: 197743 RVA: 0x00B32AAC File Offset: 0x00B30CAC
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

		// Token: 0x06030470 RID: 197744 RVA: 0x00B32AFF File Offset: 0x00B30CFF
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

		// Token: 0x04019FB2 RID: 106418
		[Nullable(2)]
		private IMapMarkToggleItemData DataParam;

		// Token: 0x0200AAD4 RID: 43732
		public static class EChildType
		{
			// Token: 0x04033F3D RID: 212797
			public const int Toggle = 0;

			// Token: 0x04033F3E RID: 212798
			public const int TxtName = 1;
		}
	}
}
