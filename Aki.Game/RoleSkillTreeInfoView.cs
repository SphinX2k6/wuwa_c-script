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

// Token: 0x020028C3 RID: 10435
public class RoleSkillTreeInfoView : UiViewBase
{
	// Token: 0x06015889 RID: 88201 RVA: 0x00570523 File Offset: 0x0056E723
	[NullableContext(1)]
	public RoleSkillTreeInfoView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x0601588A RID: 88202 RVA: 0x0057052C File Offset: 0x0056E72C
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

	// Token: 0x0601588B RID: 88203 RVA: 0x00570574 File Offset: 0x0056E774
	protected override UniTask OnBeforeStartAsync()
	{
		RoleSkillTreeInfoView.<OnBeforeStartAsync>d__4 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<RoleSkillTreeInfoView.<OnBeforeStartAsync>d__4>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0601588C RID: 88204 RVA: 0x005705B8 File Offset: 0x0056E7B8
	protected override void OnAddEventListener()
	{
		EventSystem.Instance.Add<int, int>(EEventName.OnCommonItemCountAnyChange, new Action<int, int>(this.OnCommonItemCountAnyChange));
		EventSystem.Instance.Add(EEventName.OnRoleInternalViewQuit, new Action(this.OnRoleInternalViewQuit));
		EventSystem.Instance.Add<int>(EEventName.OnRoleSkillBranchChanged, new Action<int>(this.OnRoleSkillBranchChanged));
		EventSystem.Instance.Add<int>(EEventName.SkillTreeNodeLevelUp, new Action<int>(this.OnSkillTreeNodeLevelUp));
	}

	// Token: 0x0601588D RID: 88205 RVA: 0x00570638 File Offset: 0x0056E838
	protected override void OnRemoveEventListener()
	{
		EventSystem.Instance.Remove<int, int>(EEventName.OnCommonItemCountAnyChange, new Action<int, int>(this.OnCommonItemCountAnyChange));
		EventSystem.Instance.Remove(EEventName.OnRoleInternalViewQuit, new Action(this.OnRoleInternalViewQuit));
		EventSystem.Instance.Remove<int>(EEventName.OnRoleSkillBranchChanged, new Action<int>(this.OnRoleSkillBranchChanged));
		EventSystem.Instance.Remove<int>(EEventName.SkillTreeNodeLevelUp, new Action<int>(this.OnSkillTreeNodeLevelUp));
	}

	// Token: 0x0601588E RID: 88206 RVA: 0x005706B5 File Offset: 0x0056E8B5
	protected override void OnBeforeShow()
	{
		this.Refresh();
	}

	// Token: 0x0601588F RID: 88207 RVA: 0x005706C0 File Offset: 0x0056E8C0
	protected override UniTask OnPlayingStartSequenceAsync()
	{
		RoleSkillTreeInfoView.<OnPlayingStartSequenceAsync>d__8 <OnPlayingStartSequenceAsync>d__;
		<OnPlayingStartSequenceAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnPlayingStartSequenceAsync>d__.<>4__this = this;
		<OnPlayingStartSequenceAsync>d__.<>1__state = -1;
		<OnPlayingStartSequenceAsync>d__.<>t__builder.Start<RoleSkillTreeInfoView.<OnPlayingStartSequenceAsync>d__8>(ref <OnPlayingStartSequenceAsync>d__);
		return <OnPlayingStartSequenceAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06015890 RID: 88208 RVA: 0x00570704 File Offset: 0x0056E904
	protected override UniTask OnPlayingCloseSequenceAsync()
	{
		RoleSkillTreeInfoView.<OnPlayingCloseSequenceAsync>d__9 <OnPlayingCloseSequenceAsync>d__;
		<OnPlayingCloseSequenceAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnPlayingCloseSequenceAsync>d__.<>4__this = this;
		<OnPlayingCloseSequenceAsync>d__.<>1__state = -1;
		<OnPlayingCloseSequenceAsync>d__.<>t__builder.Start<RoleSkillTreeInfoView.<OnPlayingCloseSequenceAsync>d__9>(ref <OnPlayingCloseSequenceAsync>d__);
		return <OnPlayingCloseSequenceAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06015891 RID: 88209 RVA: 0x00570748 File Offset: 0x0056E948
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

	// Token: 0x06015892 RID: 88210 RVA: 0x0057078E File Offset: 0x0056E98E
	private void OnCommonItemCountAnyChange(int i, int i1)
	{
		RoleSkillTreeInfoItem roleSkillTreeInfoItem = this.RoleSkillTreeInfoItem;
		if (roleSkillTreeInfoItem == null)
		{
			return;
		}
		roleSkillTreeInfoItem.OnCommonItemCountAnyChange();
	}

	// Token: 0x06015893 RID: 88211 RVA: 0x005707A0 File Offset: 0x0056E9A0
	private void OnRoleInternalViewQuit()
	{
		base.CloseMe(null);
	}

	// Token: 0x06015894 RID: 88212 RVA: 0x005707A9 File Offset: 0x0056E9A9
	private void OnRoleSkillBranchChanged(int i)
	{
		RoleSkillTreeInfoItem roleSkillTreeInfoItem = this.RoleSkillTreeInfoItem;
		if (roleSkillTreeInfoItem == null)
		{
			return;
		}
		roleSkillTreeInfoItem.OnRoleSkillBranchChanged();
	}

	// Token: 0x06015895 RID: 88213 RVA: 0x005707BB File Offset: 0x0056E9BB
	private void OnSkillTreeNodeLevelUp(int i)
	{
		RoleSkillTreeInfoItem roleSkillTreeInfoItem = this.RoleSkillTreeInfoItem;
		if (roleSkillTreeInfoItem == null)
		{
			return;
		}
		roleSkillTreeInfoItem.OnSkillTreeNodeLevelUp();
	}

	// Token: 0x0400A076 RID: 41078
	[Nullable(2)]
	private RoleSkillTreeInfoItem RoleSkillTreeInfoItem;

	// Token: 0x02008ECE RID: 36558
	private enum EComponent
	{
		// Token: 0x0402E50F RID: 189711
		RoleSkillTreeInfoItem
	}
}
