using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Protocol;
using CSharpScript.Core.Common;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x020004BE RID: 1214
public class GolemHackingLevelDetailToggle : UiPanelBase
{
	// Token: 0x06003CE6 RID: 15590 RVA: 0x00158939 File Offset: 0x00156B39
	public GolemHackingLevelDetailToggle(int levelId)
	{
		this.LevelId = levelId;
	}

	// Token: 0x06003CE7 RID: 15591 RVA: 0x00158948 File Offset: 0x00156B48
	protected unsafe override void OnRegisterComponent()
	{
		int num = 3;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIExtendToggle));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
		this.ComponentRegisterInfos = list;
	}

	// Token: 0x06003CE8 RID: 15592 RVA: 0x001589D2 File Offset: 0x00156BD2
	protected override void OnStart()
	{
		UUIExtendToggle extendToggle = base.GetExtendToggle(0);
		if (extendToggle == null)
		{
			return;
		}
		extendToggle.OnStateChange.Add(new Action<EToggleState>(this.OnToggleStateChange));
	}

	// Token: 0x06003CE9 RID: 15593 RVA: 0x001589F6 File Offset: 0x00156BF6
	protected override void OnBeforeDestroy()
	{
		UUIExtendToggle extendToggle = base.GetExtendToggle(0);
		if (extendToggle != null)
		{
			extendToggle.CanExecuteChange.Unbind();
		}
		UUIExtendToggle extendToggle2 = base.GetExtendToggle(0);
		if (extendToggle2 == null)
		{
			return;
		}
		extendToggle2.OnStateChange.Clear();
	}

	// Token: 0x06003CEA RID: 15594 RVA: 0x00158A25 File Offset: 0x00156C25
	public void SetSelected(bool selected)
	{
		UUIExtendToggle extendToggle = base.GetExtendToggle(0);
		if (extendToggle == null)
		{
			return;
		}
		extendToggle.SetToggleState(selected ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked, true, false, false);
	}

	// Token: 0x06003CEB RID: 15595 RVA: 0x00158A44 File Offset: 0x00156C44
	public void SetFocusGamepad()
	{
		UUIItem toggle = base.GetExtendToggle(0).RootUIComp.Get();
		if (Info.Instance.IsInGamepad())
		{
			TimerSystem.Instance.Next(delegate(float _)
			{
				UiNavigationNewController.Instance.SetNavigationFocusForView(toggle, true, false, false);
			}, null, null);
		}
	}

	// Token: 0x06003CEC RID: 15596 RVA: 0x00158A98 File Offset: 0x00156C98
	public virtual bool RefreshState(bool needAnim = false)
	{
		GolemHackingActivityData activityData = GolemHackingController.Instance.GetActivityData();
		UUIItem item = base.GetItem(2);
		if (item != null)
		{
			item.SetUIActive(activityData.CheckLevelRedDot(this.LevelId));
		}
		bool flag = activityData.GetLevelInfo(this.LevelId).State == GolemCrackState.GolemCrackFinished;
		UUIItem item2 = base.GetItem(1);
		if (item2 != null)
		{
			item2.SetUIActive(flag);
		}
		return flag;
	}

	// Token: 0x06003CED RID: 15597 RVA: 0x00158AF7 File Offset: 0x00156CF7
	private void OnToggleStateChange(EToggleState state)
	{
		if (state != EToggleState.ETT_Checked)
		{
			return;
		}
		Action<int, bool> onClickedCallback = this.OnClickedCallback;
		if (onClickedCallback == null)
		{
			return;
		}
		onClickedCallback(this.LevelId, this.IsHard);
	}

	// Token: 0x04003124 RID: 12580
	[Nullable(2)]
	public Action<int, bool> OnClickedCallback;

	// Token: 0x04003125 RID: 12581
	protected bool IsHard;

	// Token: 0x04003126 RID: 12582
	public int LevelId;
}
