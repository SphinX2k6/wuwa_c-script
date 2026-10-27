using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;

namespace CSharpScript.Game.Ui
{
	// Token: 0x0200464A RID: 17994
	public class CommonSwitchItem : UiPanelBase
	{
		// Token: 0x0602E711 RID: 190225 RVA: 0x00ABAF14 File Offset: 0x00AB9114
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
			*span2[num] = new ValueTuple<int, Delegate>(0, new Action<EToggleState>(this.OnToggleStateChange));
			this.BtnBindInfo = list2;
		}

		// Token: 0x0602E712 RID: 190226 RVA: 0x00ABAFBA File Offset: 0x00AB91BA
		protected override void OnStart()
		{
			base.GetExtendToggle(0).SetToggleGroup(null);
		}

		// Token: 0x0602E713 RID: 190227 RVA: 0x00ABAFCC File Offset: 0x00AB91CC
		public void SetToggleState(bool bOpen)
		{
			EToggleState state = bOpen ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked;
			base.GetExtendToggle(0).SetToggleStateForce(state, false, false, false);
		}

		// Token: 0x0602E714 RID: 190228 RVA: 0x00ABAFF1 File Offset: 0x00AB91F1
		[NullableContext(2)]
		public void SetOnStateChangedCallback(Action<EToggleState> callback)
		{
			this.OnStateChangedInternal = callback;
		}

		// Token: 0x0602E715 RID: 190229 RVA: 0x00ABAFFA File Offset: 0x00AB91FA
		private void OnToggleStateChange(EToggleState state)
		{
			Action<EToggleState> onStateChangedInternal = this.OnStateChangedInternal;
			if (onStateChangedInternal == null)
			{
				return;
			}
			onStateChangedInternal(state);
		}

		// Token: 0x0602E716 RID: 190230 RVA: 0x00ABB010 File Offset: 0x00AB9210
		[NullableContext(1)]
		[return: Nullable(new byte[]
		{
			2,
			1
		})]
		public override UUIItem[] GetGuideUiItemAndUiItemForShowEx(string[] configParams)
		{
			if (configParams == null || configParams.Length == 0)
			{
				return null;
			}
			if (configParams[0] == "SwitchItem")
			{
				UUIItem rootComponent = base.GetExtendToggle(0).GetRootComponent();
				UUIItem rootItem = base.GetRootItem();
				if (rootComponent != null && rootItem != null)
				{
					return new UUIItem[]
					{
						rootComponent,
						rootItem
					};
				}
			}
			return null;
		}

		// Token: 0x04018E21 RID: 101921
		[Nullable(2)]
		private Action<EToggleState> OnStateChangedInternal;

		// Token: 0x0200A8A5 RID: 43173
		private class EChildType
		{
			// Token: 0x0403357C RID: 210300
			public const int SwitchToggle = 0;

			// Token: 0x0403357D RID: 210301
			public const int TitleText = 1;
		}
	}
}
