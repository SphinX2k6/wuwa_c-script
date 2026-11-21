using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Module.RoleUi;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02001E21 RID: 7713
[NullableContext(1)]
[Nullable(0)]
public class RoleSkillBranchTipsItem : UiPanelBase
{
	// Token: 0x17001D2E RID: 7470
	// (get) Token: 0x06013195 RID: 78229 RVA: 0x005954FF File Offset: 0x005936FF
	public bool IsTipsVisible
	{
		get
		{
			return this.IsTipsVisibleIntl;
		}
	}

	// Token: 0x06013196 RID: 78230 RVA: 0x00595508 File Offset: 0x00593708
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

	// Token: 0x06013197 RID: 78231 RVA: 0x00595594 File Offset: 0x00593794
	protected override void OnStart()
	{
		this.LevelSequencePlayer = new LevelSequencePlayer(this.RootItem);
		this.LevelSequencePlayer.BindSequenceStartEvent(new TSequenceStartEvent(this.OnSequenceStart));
		this.LevelSequencePlayer.BindSequenceCloseEvent(new TSequenceEndEvent(this.OnSequenceClose), false);
		this.ContentLayout = new GenericLayout<RoleSkillBranchTipsContentItem, IRoleSkillBranchTipsContentItemData>(base.GetVerticalLayout(1), new Func<RoleSkillBranchTipsContentItem>(this.CreateItem), null, false, true);
	}

	// Token: 0x06013198 RID: 78232 RVA: 0x00595602 File Offset: 0x00593802
	private RoleSkillBranchTipsContentItem CreateItem()
	{
		return new RoleSkillBranchTipsContentItem();
	}

	// Token: 0x06013199 RID: 78233 RVA: 0x0059560C File Offset: 0x0059380C
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

	// Token: 0x0601319A RID: 78234 RVA: 0x005956CC File Offset: 0x005938CC
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

	// Token: 0x0601319B RID: 78235 RVA: 0x00595737 File Offset: 0x00593937
	private void OnSequenceStart(string sequenceName)
	{
		if (sequenceName == "Start".ToString())
		{
			base.GetRootItem().SetUIActive(true);
		}
	}

	// Token: 0x0601319C RID: 78236 RVA: 0x00595757 File Offset: 0x00593957
	private void OnSequenceClose(string sequenceName)
	{
		if (sequenceName == "Close".ToString())
		{
			base.GetRootItem().SetUIActive(false);
		}
	}

	// Token: 0x0400A3F4 RID: 41972
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private GenericLayout<RoleSkillBranchTipsContentItem, IRoleSkillBranchTipsContentItemData> ContentLayout;

	// Token: 0x0400A3F5 RID: 41973
	[Nullable(2)]
	private LevelSequencePlayer LevelSequencePlayer;

	// Token: 0x0400A3F6 RID: 41974
	private bool IsTipsVisibleIntl;

	// Token: 0x020080F5 RID: 33013
	[NullableContext(0)]
	private enum EComponent
	{
		// Token: 0x04029B38 RID: 170808
		RootItem,
		// Token: 0x04029B39 RID: 170809
		ContentLayout,
		// Token: 0x04029B3A RID: 170810
		ContentItem
	}
}
