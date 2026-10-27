using System;
using System.Collections.Generic;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x0200119C RID: 4508
public class BeginnerCarnivalTaskType : UiPanelBase
{
	// Token: 0x06007767 RID: 30567 RVA: 0x0018EC90 File Offset: 0x0018CE90
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(1, typeof(UUIText)),
			new ValueTuple<int, Type>(2, typeof(UUIItem)),
			new ValueTuple<int, Type>(3, typeof(UUIItem))
		};
		this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
		{
			new ValueTuple<int, Delegate>(0, new Action(this.OnClickBtn))
		};
	}

	// Token: 0x06007768 RID: 30568 RVA: 0x0018ED24 File Offset: 0x0018CF24
	public void RefreshItem(int typeId)
	{
		this.TypeId = typeId;
		ValueTuple<int, int> progress = BeginnerCarnivalController.Instance.GetBeginnerCarnivalData().GetProgress(this.TypeId);
		bool flag = progress.Item1 == progress.Item2;
		base.GetText(1).SetUIActive(!flag);
		base.GetItem(2).SetUIActive(flag);
		if (!flag)
		{
			base.GetText(1).SetText("<color=#f5cf47>" + progress.Item1.ToString() + "</color>/" + progress.Item2.ToString(), true);
		}
		RedDotController.Instance.BindRedDot(ERedDotName.BeginnerCarnivalTaskTabRedDot, base.GetItem(3), null, this.TypeId);
		EventSystem.Instance.Emit<int>(EEventName.RefreshBeginnerCarnivalTask, this.TypeId);
	}

	// Token: 0x06007769 RID: 30569 RVA: 0x0018EDE4 File Offset: 0x0018CFE4
	private void OnClickBtn()
	{
		UiManager.Instance.OpenView(EUiViewName.BeginnerCarnivalTaskView, this.TypeId, null);
	}

	// Token: 0x0600776A RID: 30570 RVA: 0x0018EE01 File Offset: 0x0018D001
	protected override void OnBeforeDestroy()
	{
		RedDotController.Instance.UnBindGivenUi(ERedDotName.BeginnerCarnivalTaskTabRedDot, base.GetItem(3), this.TypeId);
	}

	// Token: 0x040036CF RID: 14031
	private int TypeId;
}
