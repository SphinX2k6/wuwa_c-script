using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.PhantomArena.Prepare
{
	// Token: 0x02005147 RID: 20807
	public class PhantomArenaMainViewSwitchItem : UiPanelBase
	{
		// Token: 0x060352C5 RID: 217797 RVA: 0x00C994F4 File Offset: 0x00C976F4
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIExtendToggle)),
				new ValueTuple<int, Type>(1, typeof(UUIText))
			};
			this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
			{
				new ValueTuple<int, Delegate>(0, new Action<EToggleState>(this.OnToggleStateChange))
			};
		}

		// Token: 0x060352C6 RID: 217798 RVA: 0x00C9955B File Offset: 0x00C9775B
		protected override void OnStart()
		{
			base.GetExtendToggle(0).SetToggleGroup(null);
		}

		// Token: 0x060352C7 RID: 217799 RVA: 0x00C9956C File Offset: 0x00C9776C
		public void SetToggleState(bool bOpen)
		{
			EToggleState state = bOpen ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked;
			base.GetExtendToggle(0).SetToggleStateForce(state, false, false, false);
		}

		// Token: 0x060352C8 RID: 217800 RVA: 0x00C99591 File Offset: 0x00C97791
		[NullableContext(2)]
		public void SetOnStateChangedCallback(Action<EToggleState> callback)
		{
			this.OnStateChangedInternal = callback;
		}

		// Token: 0x060352C9 RID: 217801 RVA: 0x00C9959A File Offset: 0x00C9779A
		private void OnToggleStateChange(EToggleState state)
		{
			Action<EToggleState> onStateChangedInternal = this.OnStateChangedInternal;
			if (onStateChangedInternal == null)
			{
				return;
			}
			onStateChangedInternal(state);
		}

		// Token: 0x060352CA RID: 217802 RVA: 0x00C995B0 File Offset: 0x00C977B0
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

		// Token: 0x0401C520 RID: 116000
		[Nullable(2)]
		private Action<EToggleState> OnStateChangedInternal;

		// Token: 0x0200B2AA RID: 45738
		private class EChildType
		{
			// Token: 0x04036203 RID: 221699
			public const int SwitchToggle = 0;

			// Token: 0x04036204 RID: 221700
			public const int TitleText = 1;
		}
	}
}
