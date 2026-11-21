using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.Roulette.View.Components
{
	// Token: 0x02003C57 RID: 15447
	public class RouletteAssemblyTab : GridProxyAbstract<int>
	{
		// Token: 0x06027900 RID: 162048 RVA: 0x00B19BB8 File Offset: 0x00B17DB8
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

		// Token: 0x06027901 RID: 162049 RVA: 0x00B19C7F File Offset: 0x00B17E7F
		private void OnClickToggle(EToggleState toggleState)
		{
			Action<int, bool> toggleCallBack = this.ToggleCallBack;
			if (toggleCallBack == null)
			{
				return;
			}
			toggleCallBack(this.TypeId, toggleState == EToggleState.ETT_Checked);
		}

		// Token: 0x06027902 RID: 162050 RVA: 0x00B19C9C File Offset: 0x00B17E9C
		public override void Refresh(int typeId, bool isSelected, int gridIndex)
		{
			this.TypeId = typeId;
			ExploreRouletteType value = RouletteConfig.Instance.GetExploreRouletteTypeById(typeId).Value;
			base.SetTextureShowUntilLoaded(value.TabIcon, base.GetTexture(1), null);
			LguiUtil.Instance.SetLocalTextNew(base.GetText(2), value.TabName, Array.Empty<object>());
			this.SetToggleState(isSelected, false);
		}

		// Token: 0x06027903 RID: 162051 RVA: 0x00B19D00 File Offset: 0x00B17F00
		public void SetToggleState(bool isSelected, bool bFireEvent)
		{
			EToggleState state = isSelected ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked;
			base.GetExtendToggle(0).SetToggleState(state, bFireEvent, false, false);
		}

		// Token: 0x06027904 RID: 162052 RVA: 0x00B19D26 File Offset: 0x00B17F26
		[NullableContext(1)]
		public override object GetKey(int data, int displayIndex)
		{
			return data;
		}

		// Token: 0x0401594B RID: 88395
		private int TypeId;

		// Token: 0x0401594C RID: 88396
		[Nullable(2)]
		public Action<int, bool> ToggleCallBack;
	}
}
