using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Inventory.Views
{
	// Token: 0x02004811 RID: 18449
	[NullableContext(2)]
	[Nullable(0)]
	public class ToggleSwitch : UiPanelBase
	{
		// Token: 0x0602E589 RID: 189833 RVA: 0x00CEE510 File Offset: 0x00CEC710
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIExtendToggle)),
				new ValueTuple<int, Type>(1, typeof(UUIText))
			};
			this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
			{
				new ValueTuple<int, Delegate>(0, new Action<EToggleState>(this.OnClickedBtnSwitch))
			};
		}

		// Token: 0x0602E58A RID: 189834 RVA: 0x00CEE577 File Offset: 0x00CEC777
		protected override void OnStart()
		{
			base.GetExtendToggle(0).CanExecuteChange.Bind(new Func<bool>(this.CheckCanChange));
		}

		// Token: 0x0602E58B RID: 189835 RVA: 0x00CEE598 File Offset: 0x00CEC798
		private bool CheckCanChange()
		{
			if (this.OnCheckCanChange != null)
			{
				EToggleState toggleState = base.GetExtendToggle(0).GetToggleState();
				return this.OnCheckCanChange(toggleState);
			}
			return true;
		}

		// Token: 0x0602E58C RID: 189836 RVA: 0x00CEE5C8 File Offset: 0x00CEC7C8
		private void OnClickedBtnSwitch(EToggleState toggleState)
		{
			if (this.OnClickedSwitch != null)
			{
				EToggleState toggleState2 = base.GetExtendToggle(0).GetToggleState();
				this.OnClickedSwitch(toggleState2);
			}
		}

		// Token: 0x0602E58D RID: 189837 RVA: 0x00CEE5F8 File Offset: 0x00CEC7F8
		public void SetConfigType(PhantomSettingType type)
		{
			string textStringId = (type == PhantomSettingType.AutoLock) ? "PhantomProject_LockProjectTip" : "PhantomProject_DiscardProjectTip";
			LguiUtil.Instance.SetLocalTextNew(base.GetText(1), textStringId, Array.Empty<object>());
		}

		// Token: 0x0602E58E RID: 189838 RVA: 0x00CEE62C File Offset: 0x00CEC82C
		public void SetConfigState(bool isOn)
		{
			EToggleState state = isOn ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked;
			base.GetExtendToggle(0).SetToggleState(state, false, false, false);
		}

		// Token: 0x04018AE7 RID: 101095
		public Action<EToggleState> OnClickedSwitch;

		// Token: 0x04018AE8 RID: 101096
		public Func<EToggleState, bool> OnCheckCanChange;
	}
}
