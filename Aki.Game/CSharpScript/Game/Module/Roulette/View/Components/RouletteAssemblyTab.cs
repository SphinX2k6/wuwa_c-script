using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.Roulette.View.Components
{
	// Token: 0x02004CA6 RID: 19622
	public class RouletteAssemblyTab : GridProxyAbstract<int>
	{
		// Token: 0x06032B4C RID: 207692 RVA: 0x00BD4E20 File Offset: 0x00BD3020
		protected unsafe override void OnRegisterComponent()
		{
			int num = 3;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIExtendToggle));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIText));
			this.ComponentRegisterInfos = list;
			num2 = 1;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(0, new Action<EToggleState>(this.OnClickToggle));
			this.BtnBindInfo = list2;
		}

		// Token: 0x06032B4D RID: 207693 RVA: 0x00BD4EE7 File Offset: 0x00BD30E7
		private void OnClickToggle(EToggleState toggleState)
		{
			Action<int, bool> toggleCallBack = this.ToggleCallBack;
			if (toggleCallBack == null)
			{
				return;
			}
			toggleCallBack(this.TypeId, toggleState == EToggleState.ETT_Checked);
		}

		// Token: 0x06032B4E RID: 207694 RVA: 0x00BD4F04 File Offset: 0x00BD3104
		public override void Refresh(int typeId, bool isSelected, int gridIndex)
		{
			this.TypeId = typeId;
			ExploreRouletteType value = RouletteConfig.Instance.GetExploreRouletteTypeById(typeId).Value;
			base.SetTextureShowUntilLoaded(value.TabIcon, base.GetTexture(1), null);
			LguiUtil.Instance.SetLocalTextNew(base.GetText(2), value.TabName, Array.Empty<object>());
			this.SetToggleState(isSelected, false);
		}

		// Token: 0x06032B4F RID: 207695 RVA: 0x00BD4F68 File Offset: 0x00BD3168
		public void SetToggleState(bool isSelected, bool bFireEvent)
		{
			EToggleState state = isSelected ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked;
			base.GetExtendToggle(0).SetToggleState(state, bFireEvent, false, false);
		}

		// Token: 0x06032B50 RID: 207696 RVA: 0x00BD4F8E File Offset: 0x00BD318E
		[NullableContext(1)]
		public override object GetKey(int data, int displayIndex)
		{
			return data;
		}

		// Token: 0x0401AFEA RID: 110570
		private int TypeId;

		// Token: 0x0401AFEB RID: 110571
		[Nullable(2)]
		public Action<int, bool> ToggleCallBack;
	}
}
