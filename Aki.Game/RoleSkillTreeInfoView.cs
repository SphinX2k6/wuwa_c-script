using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.RoleUi.RoleSkill;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02001E3E RID: 7742
public class RoleSkillTreeInfoView : UiViewBase
{
	// Token: 0x06013289 RID: 78473 RVA: 0x0059B3E7 File Offset: 0x005995E7
	[NullableContext(1)]
	public RoleSkillTreeInfoView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x0601328A RID: 78474 RVA: 0x0059B3F0 File Offset: 0x005995F0
	protected unsafe override void OnRegisterComponent()
	{
		int num = 1;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int index = 0;
		*span[index] = new ValueTuple<int, Type>(0, typeof(UUIItem));
		this.ComponentRegisterInfos = list;
	}

	// Token: 0x0601328B RID: 78475 RVA: 0x0059B438 File Offset: 0x00599638
	protected override UniTask OnBeforeStartAsync()
	{
		RoleSkillTreeInfoView.<OnBeforeStartAsync>d__4 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<RoleSkillTreeInfoView.<OnBeforeStartAsync>d__4>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0601328C RID: 78476 RVA: 0x0059B47C File Offset: 0x0059967C
	protected override void OnAddEventListener()
	{
		EventSystem.Instance.Add<int, int>(EEventName.OnCommonItemCountAnyChange, new Action<int, int>(this.OnCommonItemCountAnyChange));
		EventSystem.Instance.Add(EEventName.OnRoleInternalViewQuit, new Action(this.OnRoleInternalViewQuit));
		EventSystem.Instance.Add<int>(EEventName.OnRoleSkillBranchChanged, new Action<int>(this.OnRoleSkillBranchChanged));
		EventSystem.Instance.Add<int>(EEventName.SkillTreeNodeLevelUp, new Action<int>(this.OnSkillTreeNodeLevelUp));
	}

	// Token: 0x0601328D RID: 78477 RVA: 0x0059B4FC File Offset: 0x005996FC
	protected override void OnRemoveEventListener()
	{
		EventSystem.Instance.Remove<int, int>(EEventName.OnCommonItemCountAnyChange, new Action<int, int>(this.OnCommonItemCountAnyChange));
		EventSystem.Instance.Remove(EEventName.OnRoleInternalViewQuit, new Action(this.OnRoleInternalViewQuit));
		EventSystem.Instance.Remove<int>(EEventName.OnRoleSkillBranchChanged, new Action<int>(this.OnRoleSkillBranchChanged));
		EventSystem.Instance.Remove<int>(EEventName.SkillTreeNodeLevelUp, new Action<int>(this.OnSkillTreeNodeLevelUp));
	}

	// Token: 0x0601328E RID: 78478 RVA: 0x0059B579 File Offset: 0x00599779
	protected override void OnBeforeShow()
	{
		this.Refresh();
	}

	// Token: 0x0601328F RID: 78479 RVA: 0x0059B584 File Offset: 0x00599784
	protected override UniTask OnPlayingStartSequenceAsync()
	{
		RoleSkillTreeInfoView.<OnPlayingStartSequenceAsync>d__8 <OnPlayingStartSequenceAsync>d__;
		<OnPlayingStartSequenceAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnPlayingStartSequenceAsync>d__.<>4__this = this;
		<OnPlayingStartSequenceAsync>d__.<>1__state = -1;
		<OnPlayingStartSequenceAsync>d__.<>t__builder.Start<RoleSkillTreeInfoView.<OnPlayingStartSequenceAsync>d__8>(ref <OnPlayingStartSequenceAsync>d__);
		return <OnPlayingStartSequenceAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06013290 RID: 78480 RVA: 0x0059B5C8 File Offset: 0x005997C8
	protected override UniTask OnPlayingCloseSequenceAsync()
	{
		RoleSkillTreeInfoView.<OnPlayingCloseSequenceAsync>d__9 <OnPlayingCloseSequenceAsync>d__;
		<OnPlayingCloseSequenceAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnPlayingCloseSequenceAsync>d__.<>4__this = this;
		<OnPlayingCloseSequenceAsync>d__.<>1__state = -1;
		<OnPlayingCloseSequenceAsync>d__.<>t__builder.Start<RoleSkillTreeInfoView.<OnPlayingCloseSequenceAsync>d__9>(ref <OnPlayingCloseSequenceAsync>d__);
		return <OnPlayingCloseSequenceAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06013291 RID: 78481 RVA: 0x0059B60C File Offset: 0x0059980C
	public void Refresh()
	{
		IRoleSkillTreeInfoItemData data = this.OpenParam as IRoleSkillTreeInfoItemData;
		RoleSkillTreeInfoItem roleSkillTreeInfoItem = this.RoleSkillTreeInfoItem;
		if (roleSkillTreeInfoItem != null)
		{
			roleSkillTreeInfoItem.Update(data);
		}
		RoleSkillTreeInfoItem roleSkillTreeInfoItem2 = this.RoleSkillTreeInfoItem;
		if (roleSkillTreeInfoItem2 == null)
		{
			return;
		}
		roleSkillTreeInfoItem2.ShowLeftPanelByTabType(this.RoleSkillTreeInfoItem.GetCurSkillTabShowType());
	}

	// Token: 0x06013292 RID: 78482 RVA: 0x0059B652 File Offset: 0x00599852
	private void OnCommonItemCountAnyChange(int i, int i1)
	{
		RoleSkillTreeInfoItem roleSkillTreeInfoItem = this.RoleSkillTreeInfoItem;
		if (roleSkillTreeInfoItem == null)
		{
			return;
		}
		roleSkillTreeInfoItem.OnCommonItemCountAnyChange();
	}

	// Token: 0x06013293 RID: 78483 RVA: 0x0059B664 File Offset: 0x00599864
	private void OnRoleInternalViewQuit()
	{
		base.CloseMe(null);
	}

	// Token: 0x06013294 RID: 78484 RVA: 0x0059B66D File Offset: 0x0059986D
	private void OnRoleSkillBranchChanged(int i)
	{
		RoleSkillTreeInfoItem roleSkillTreeInfoItem = this.RoleSkillTreeInfoItem;
		if (roleSkillTreeInfoItem == null)
		{
			return;
		}
		roleSkillTreeInfoItem.OnRoleSkillBranchChanged();
	}

	// Token: 0x06013295 RID: 78485 RVA: 0x0059B67F File Offset: 0x0059987F
	private void OnSkillTreeNodeLevelUp(int i)
	{
		RoleSkillTreeInfoItem roleSkillTreeInfoItem = this.RoleSkillTreeInfoItem;
		if (roleSkillTreeInfoItem == null)
		{
			return;
		}
		roleSkillTreeInfoItem.OnSkillTreeNodeLevelUp();
	}

	// Token: 0x0400A45F RID: 42079
	[Nullable(2)]
	private RoleSkillTreeInfoItem RoleSkillTreeInfoItem;

	// Token: 0x02008116 RID: 33046
	private enum EComponent
	{
		// Token: 0x04029C0A RID: 171018
		RoleSkillTreeInfoItem
	}
}
