using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Menu.SubViews
{
	// Token: 0x0200542C RID: 21548
	public class OperationPreferencesView : UiViewBase
	{
		// Token: 0x060370B1 RID: 225457 RVA: 0x00D0B4A5 File Offset: 0x00D096A5
		[NullableContext(1)]
		public OperationPreferencesView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x060370B2 RID: 225458 RVA: 0x00D0B4B0 File Offset: 0x00D096B0
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIButtonComponent)),
				new ValueTuple<int, Type>(1, typeof(UUIExtendToggle))
			};
			this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
			{
				new ValueTuple<int, Delegate>(0, new Action(this.OnCloseClick)),
				new ValueTuple<int, Delegate>(1, new Action<EToggleState>(this.OnSwitchClick))
			};
		}

		// Token: 0x060370B3 RID: 225459 RVA: 0x00D0B530 File Offset: 0x00D09730
		protected override void OnStart()
		{
			MenuModel instance = MenuModel.Instance;
			EToggleState state = ((instance != null) ? new bool?(instance.GetGamepadOperationPreferences()) : null).GetValueOrDefault() ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked;
			UUIExtendToggle extendToggle = base.GetExtendToggle(1);
			if (extendToggle == null)
			{
				return;
			}
			extendToggle.SetToggleState(state, false, false, false);
		}

		// Token: 0x060370B4 RID: 225460 RVA: 0x00D0B580 File Offset: 0x00D09780
		private void OnCloseClick()
		{
			base.CloseMe(null);
		}

		// Token: 0x060370B5 RID: 225461 RVA: 0x00D0B58C File Offset: 0x00D0978C
		private void OnSwitchClick(EToggleState state)
		{
			bool value = state == EToggleState.ETT_Checked;
			LocalStorage.SetGlobal<bool>(ELocalStorageGlobalKey.GamepadOperationPreferences, value);
		}
	}
}
