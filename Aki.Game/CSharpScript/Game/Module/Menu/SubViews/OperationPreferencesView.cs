using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Menu.SubViews
{
	// Token: 0x0200440F RID: 17423
	public class OperationPreferencesView : UiViewBase
	{
		// Token: 0x0602BFFA RID: 180218 RVA: 0x00C5A8C5 File Offset: 0x00C58AC5
		[NullableContext(1)]
		public OperationPreferencesView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x0602BFFB RID: 180219 RVA: 0x00C5A8D0 File Offset: 0x00C58AD0
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

		// Token: 0x0602BFFC RID: 180220 RVA: 0x00C5A950 File Offset: 0x00C58B50
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

		// Token: 0x0602BFFD RID: 180221 RVA: 0x00C5A9A0 File Offset: 0x00C58BA0
		private void OnCloseClick()
		{
			base.CloseMe(null);
		}

		// Token: 0x0602BFFE RID: 180222 RVA: 0x00C5A9AC File Offset: 0x00C58BAC
		private void OnSwitchClick(EToggleState state)
		{
			bool value = state == EToggleState.ETT_Checked;
			LocalStorage.SetGlobal<bool>(ELocalStorageGlobalKey.GamepadOperationPreferences, value);
		}
	}
}
