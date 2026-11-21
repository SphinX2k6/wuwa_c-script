using System;
using System.Collections.Generic;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02001373 RID: 4979
public class HonamiStorySkillDescToggle : UiPanelBase
{
	// Token: 0x0600C5D2 RID: 50642 RVA: 0x003AEA20 File Offset: 0x003ACC20
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIExtendToggle)),
			new ValueTuple<int, Type>(1, typeof(UUIText))
		};
		this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
		{
			new ValueTuple<int, Delegate>(0, new Action<EToggleState>(this.OnClickedToggle))
		};
	}

	// Token: 0x0600C5D3 RID: 50643 RVA: 0x003AEA87 File Offset: 0x003ACC87
	protected override void OnStart()
	{
		this.RefreshState();
	}

	// Token: 0x0600C5D4 RID: 50644 RVA: 0x003AEA90 File Offset: 0x003ACC90
	public void RefreshState()
	{
		EToggleState state = HonamiStoryModel.Instance.GetSkillDescMode() ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked;
		UUIExtendToggle extendToggle = base.GetExtendToggle(0);
		if (extendToggle == null)
		{
			return;
		}
		extendToggle.SetToggleState(state, false, false, false);
	}

	// Token: 0x0600C5D5 RID: 50645 RVA: 0x003AEAC4 File Offset: 0x003ACCC4
	private void OnClickedToggle(EToggleState toggleState)
	{
		UUIExtendToggle extendToggle = base.GetExtendToggle(0);
		bool skillDescMode = extendToggle != null && extendToggle.GetToggleState() == EToggleState.ETT_Checked;
		HonamiStoryModel.Instance.SetSkillDescMode(skillDescMode);
	}

	// Token: 0x02007614 RID: 30228
	private enum EToggle
	{
		// Token: 0x0402658D RID: 157069
		Tog,
		// Token: 0x0402658E RID: 157070
		Txt
	}
}
