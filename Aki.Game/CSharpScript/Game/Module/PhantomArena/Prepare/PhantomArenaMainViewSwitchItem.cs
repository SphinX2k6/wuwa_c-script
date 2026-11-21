using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.PhantomArena.Prepare
{
	// Token: 0x02004117 RID: 16663
	public class PhantomArenaMainViewSwitchItem : UiPanelBase
	{
		// Token: 0x0602A1C1 RID: 172481 RVA: 0x00BE69F4 File Offset: 0x00BE4BF4
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

		// Token: 0x0602A1C2 RID: 172482 RVA: 0x00BE6A5B File Offset: 0x00BE4C5B
		protected override void OnStart()
		{
			base.GetExtendToggle(0).SetToggleGroup(null);
		}

		// Token: 0x0602A1C3 RID: 172483 RVA: 0x00BE6A6C File Offset: 0x00BE4C6C
		public void SetToggleState(bool bOpen)
		{
			EToggleState state = bOpen ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked;
			base.GetExtendToggle(0).SetToggleStateForce(state, false, false, false);
		}

		// Token: 0x0602A1C4 RID: 172484 RVA: 0x00BE6A91 File Offset: 0x00BE4C91
		[NullableContext(2)]
		public void SetOnStateChangedCallback(Action<EToggleState> callback)
		{
			this.OnStateChangedInternal = callback;
		}

		// Token: 0x0602A1C5 RID: 172485 RVA: 0x00BE6A9A File Offset: 0x00BE4C9A
		private void OnToggleStateChange(EToggleState state)
		{
			Action<EToggleState> onStateChangedInternal = this.OnStateChangedInternal;
			if (onStateChangedInternal == null)
			{
				return;
			}
			onStateChangedInternal(state);
		}

		// Token: 0x0602A1C6 RID: 172486 RVA: 0x00BE6AB0 File Offset: 0x00BE4CB0
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

		// Token: 0x04016F55 RID: 94037
		[Nullable(2)]
		private Action<EToggleState> OnStateChangedInternal;

		// Token: 0x02009CE3 RID: 40163
		private class EChildType
		{
			// Token: 0x04030C58 RID: 199768
			public const int SwitchToggle = 0;

			// Token: 0x04030C59 RID: 199769
			public const int TitleText = 1;
		}
	}
}
