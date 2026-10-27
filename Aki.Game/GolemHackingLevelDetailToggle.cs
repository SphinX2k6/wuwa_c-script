using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Protocol;
using CSharpScript.Core.Common;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x0200100A RID: 4106
public class GolemHackingLevelDetailToggle : UiPanelBase
{
	// Token: 0x06006951 RID: 26961 RVA: 0x00150011 File Offset: 0x0014E211
	public GolemHackingLevelDetailToggle(int levelId)
	{
		this.LevelId = levelId;
	}

	// Token: 0x06006952 RID: 26962 RVA: 0x00150020 File Offset: 0x0014E220
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

	// Token: 0x06006953 RID: 26963 RVA: 0x001500AA File Offset: 0x0014E2AA
	protected override void OnStart()
	{
		UUIExtendToggle extendToggle = base.GetExtendToggle(0);
		if (extendToggle == null)
		{
			return;
		}
		extendToggle.OnStateChange.Add(new Action<EToggleState>(this.OnToggleStateChange));
	}

	// Token: 0x06006954 RID: 26964 RVA: 0x001500CE File Offset: 0x0014E2CE
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

	// Token: 0x06006955 RID: 26965 RVA: 0x001500FD File Offset: 0x0014E2FD
	public void SetSelected(bool selected)
	{
		UUIExtendToggle extendToggle = base.GetExtendToggle(0);
		if (extendToggle == null)
		{
			return;
		}
		extendToggle.SetToggleState(selected ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked, true, false, false);
	}

	// Token: 0x06006956 RID: 26966 RVA: 0x0015011C File Offset: 0x0014E31C
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

	// Token: 0x06006957 RID: 26967 RVA: 0x00150170 File Offset: 0x0014E370
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

	// Token: 0x06006958 RID: 26968 RVA: 0x001501CF File Offset: 0x0014E3CF
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

	// Token: 0x0400308B RID: 12427
	[Nullable(2)]
	public Action<int, bool> OnClickedCallback;

	// Token: 0x0400308C RID: 12428
	protected bool IsHard;

	// Token: 0x0400308D RID: 12429
	public int LevelId;
}
