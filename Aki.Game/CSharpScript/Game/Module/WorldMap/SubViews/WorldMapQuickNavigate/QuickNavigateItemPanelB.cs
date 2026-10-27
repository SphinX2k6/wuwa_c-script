using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.WorldMap.SubViews.WorldMapQuickNavigate
{
	// Token: 0x020047D4 RID: 18388
	public class QuickNavigateItemPanelB : UiPanelBase
	{
		// Token: 0x060302E0 RID: 197344 RVA: 0x00B2A150 File Offset: 0x00B28350
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
			*span2[num] = new ValueTuple<int, Delegate>(0, new Action<EToggleState>(this.OnClickToggle));
			this.BtnBindInfo = list2;
		}

		// Token: 0x060302E1 RID: 197345 RVA: 0x00B2A1F8 File Offset: 0x00B283F8
		[NullableContext(1)]
		public void RefreshByData(QuickNavigateDynamicData data)
		{
			this.NavigateDynamicData = data;
			State? config = ConfigStateByStateId.GetConfig(data.StateId, true);
			if (config == null)
			{
				return;
			}
			UUIText text = base.GetText(1);
			LguiUtil.Instance.SetLocalTextNew(text, config.Value.StateName, Array.Empty<object>());
			UUIExtendToggle extendToggle = base.GetExtendToggle(0);
			if (extendToggle != null)
			{
				EToggleState state = data.IsSelected ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked;
				extendToggle.SetToggleState(state, false, false, false);
			}
		}

		// Token: 0x060302E2 RID: 197346 RVA: 0x00B2A26F File Offset: 0x00B2846F
		private void OnClickToggle(EToggleState toggleState)
		{
			if (this.NavigateDynamicData != null)
			{
				EventSystem instance = EventSystem.Instance;
				if (instance == null)
				{
					return;
				}
				instance.Emit<QuickNavigateDynamicData>(EEventName.WorldMapFirstNavigateSelect, this.NavigateDynamicData);
			}
		}

		// Token: 0x04019F22 RID: 106274
		[Nullable(2)]
		private QuickNavigateDynamicData NavigateDynamicData;

		// Token: 0x0200AA93 RID: 43667
		public static class EComponent
		{
			// Token: 0x04033E54 RID: 212564
			public const int TogList = 0;

			// Token: 0x04033E55 RID: 212565
			public const int TxtList = 1;
		}
	}
}
