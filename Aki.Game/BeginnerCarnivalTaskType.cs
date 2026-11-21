using System;
using System.Collections.Generic;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02000650 RID: 1616
public class BeginnerCarnivalTaskType : UiPanelBase
{
	// Token: 0x06004AFE RID: 19198 RVA: 0x00197874 File Offset: 0x00195A74
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

	// Token: 0x06004AFF RID: 19199 RVA: 0x00197908 File Offset: 0x00195B08
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

	// Token: 0x06004B00 RID: 19200 RVA: 0x001979C8 File Offset: 0x00195BC8
	private void OnClickBtn()
	{
		UiManager.Instance.OpenView(EUiViewName.BeginnerCarnivalTaskView, this.TypeId, null);
	}

	// Token: 0x06004B01 RID: 19201 RVA: 0x001979E5 File Offset: 0x00195BE5
	protected override void OnBeforeDestroy()
	{
		RedDotController.Instance.UnBindGivenUi(ERedDotName.BeginnerCarnivalTaskTabRedDot, base.GetItem(3), this.TypeId);
	}

	// Token: 0x04003768 RID: 14184
	private int TypeId;
}
