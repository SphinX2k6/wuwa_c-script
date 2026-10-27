using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Inventory.Views
{
	// Token: 0x0200583A RID: 22586
	[NullableContext(2)]
	[Nullable(0)]
	public class ToggleSwitch : UiPanelBase
	{
		// Token: 0x06039676 RID: 235126 RVA: 0x00D9F67C File Offset: 0x00D9D87C
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

		// Token: 0x06039677 RID: 235127 RVA: 0x00D9F6E3 File Offset: 0x00D9D8E3
		protected override void OnStart()
		{
			base.GetExtendToggle(0).CanExecuteChange.Bind(new Func<bool>(this.CheckCanChange));
		}

		// Token: 0x06039678 RID: 235128 RVA: 0x00D9F704 File Offset: 0x00D9D904
		private bool CheckCanChange()
		{
			if (this.OnCheckCanChange != null)
			{
				EToggleState toggleState = base.GetExtendToggle(0).GetToggleState();
				return this.OnCheckCanChange(toggleState);
			}
			return true;
		}

		// Token: 0x06039679 RID: 235129 RVA: 0x00D9F734 File Offset: 0x00D9D934
		private void OnClickedBtnSwitch(EToggleState toggleState)
		{
			if (this.OnClickedSwitch != null)
			{
				EToggleState toggleState2 = base.GetExtendToggle(0).GetToggleState();
				this.OnClickedSwitch(toggleState2);
			}
		}

		// Token: 0x0603967A RID: 235130 RVA: 0x00D9F764 File Offset: 0x00D9D964
		public void SetConfigType(PhantomSettingType type)
		{
			string textStringId = (type == PhantomSettingType.AutoLock) ? "PhantomProject_LockProjectTip" : "PhantomProject_DiscardProjectTip";
			LguiUtil.Instance.SetLocalTextNew(base.GetText(1), textStringId, Array.Empty<object>());
		}

		// Token: 0x0603967B RID: 235131 RVA: 0x00D9F798 File Offset: 0x00D9D998
		public void SetConfigState(bool isOn)
		{
			EToggleState state = isOn ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked;
			base.GetExtendToggle(0).SetToggleState(state, false, false, false);
		}

		// Token: 0x0401E04E RID: 122958
		public Action<EToggleState> OnClickedSwitch;

		// Token: 0x0401E04F RID: 122959
		public Func<EToggleState, bool> OnCheckCanChange;
	}
}
