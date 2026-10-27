using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Module.RoleUi;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x020028A6 RID: 10406
[NullableContext(1)]
[Nullable(0)]
public class RoleSkillBranchTipsItem : UiPanelBase
{
	// Token: 0x17001CD6 RID: 7382
	// (get) Token: 0x06015795 RID: 87957 RVA: 0x0056A6B7 File Offset: 0x005688B7
	public bool IsTipsVisible
	{
		get
		{
			return this.IsTipsVisibleIntl;
		}
	}

	// Token: 0x06015796 RID: 87958 RVA: 0x0056A6C0 File Offset: 0x005688C0
	protected unsafe override void OnRegisterComponent()
	{
		int num = 3;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIVerticalLayout));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
		this.ComponentRegisterInfos = list;
	}

	// Token: 0x06015797 RID: 87959 RVA: 0x0056A74C File Offset: 0x0056894C
	protected override void OnStart()
	{
		this.LevelSequencePlayer = new LevelSequencePlayer(this.RootItem);
		this.LevelSequencePlayer.BindSequenceStartEvent(new TSequenceStartEvent(this.OnSequenceStart));
		this.LevelSequencePlayer.BindSequenceCloseEvent(new TSequenceEndEvent(this.OnSequenceClose), false);
		this.ContentLayout = new GenericLayout<RoleSkillBranchTipsContentItem, IRoleSkillBranchTipsContentItemData>(base.GetVerticalLayout(1), new Func<RoleSkillBranchTipsContentItem>(this.CreateItem), null, false, true);
	}

	// Token: 0x06015798 RID: 87960 RVA: 0x0056A7BA File Offset: 0x005689BA
	private RoleSkillBranchTipsContentItem CreateItem()
	{
		return new RoleSkillBranchTipsContentItem();
	}

	// Token: 0x06015799 RID: 87961 RVA: 0x0056A7C4 File Offset: 0x005689C4
	public void RefreshView(int roleId, bool showActivated = true)
	{
		int roleCurrentBranchId = RoleModel.Instance.GetRoleCurrentBranchId(roleId);
		List<SkillBranch> roleBranchList = RoleConfig.Instance.GetRoleBranchList(roleId);
		List<IRoleSkillBranchTipsContentItemData> list = new List<IRoleSkillBranchTipsContentItemData>();
		foreach (SkillBranch skillBranch in roleBranchList)
		{
			RoleSkillBranchTipsContentItemData item = new RoleSkillBranchTipsContentItemData
			{
				IconPath = skillBranch.Icon,
				TitleKey = skillBranch.Name,
				DescKey = skillBranch.Desc,
				IsHighlight = (showActivated && skillBranch.Id == roleCurrentBranchId)
			};
			list.Add(item);
		}
		this.ContentLayout.RefreshByData(list, null, false);
	}

	// Token: 0x0601579A RID: 87962 RVA: 0x0056A884 File Offset: 0x00568A84
	public void SetTipsVisible(bool isVisible, bool playAnim = true)
	{
		this.IsTipsVisibleIntl = isVisible;
		if (!playAnim)
		{
			base.GetRootItem().SetUIActive(isVisible);
			return;
		}
		this.LevelSequencePlayer.StopCurrentSequence(false, true);
		if (isVisible)
		{
			this.LevelSequencePlayer.PlayLevelSequenceByName("Start", false, null, false);
			return;
		}
		this.LevelSequencePlayer.PlayLevelSequenceByName("Close", false, null, false);
	}

	// Token: 0x0601579B RID: 87963 RVA: 0x0056A8EF File Offset: 0x00568AEF
	private void OnSequenceStart(string sequenceName)
	{
		if (sequenceName == "Start".ToString())
		{
			base.GetRootItem().SetUIActive(true);
		}
	}

	// Token: 0x0601579C RID: 87964 RVA: 0x0056A90F File Offset: 0x00568B0F
	private void OnSequenceClose(string sequenceName)
	{
		if (sequenceName == "Close".ToString())
		{
			base.GetRootItem().SetUIActive(false);
		}
	}

	// Token: 0x0400A00B RID: 40971
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private GenericLayout<RoleSkillBranchTipsContentItem, IRoleSkillBranchTipsContentItemData> ContentLayout;

	// Token: 0x0400A00C RID: 40972
	[Nullable(2)]
	private LevelSequencePlayer LevelSequencePlayer;

	// Token: 0x0400A00D RID: 40973
	private bool IsTipsVisibleIntl;

	// Token: 0x02008EAE RID: 36526
	[NullableContext(0)]
	private enum EComponent
	{
		// Token: 0x0402E43B RID: 189499
		RootItem,
		// Token: 0x0402E43C RID: 189500
		ContentLayout,
		// Token: 0x0402E43D RID: 189501
		ContentItem
	}
}
