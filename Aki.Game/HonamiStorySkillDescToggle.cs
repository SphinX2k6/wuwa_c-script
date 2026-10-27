using System;
using System.Collections.Generic;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02001EB1 RID: 7857
public class HonamiStorySkillDescToggle : UiPanelBase
{
	// Token: 0x0600F1B3 RID: 61875 RVA: 0x003A2F20 File Offset: 0x003A1120
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

	// Token: 0x0600F1B4 RID: 61876 RVA: 0x003A2F87 File Offset: 0x003A1187
	protected override void OnStart()
	{
		this.RefreshState();
	}

	// Token: 0x0600F1B5 RID: 61877 RVA: 0x003A2F90 File Offset: 0x003A1190
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

	// Token: 0x0600F1B6 RID: 61878 RVA: 0x003A2FC4 File Offset: 0x003A11C4
	private void OnClickedToggle(EToggleState toggleState)
	{
		UUIExtendToggle extendToggle = base.GetExtendToggle(0);
		bool skillDescMode = extendToggle != null && extendToggle.GetToggleState() == EToggleState.ETT_Checked;
		HonamiStoryModel.Instance.SetSkillDescMode(skillDescMode);
	}

	// Token: 0x0200848F RID: 33935
	private enum EToggle
	{
		// Token: 0x0402B269 RID: 176745
		Tog,
		// Token: 0x0402B26A RID: 176746
		Txt
	}
}
