using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x020003DD RID: 989
[NullableContext(1)]
[Nullable(0)]
public class AchievementGroupTitleItem : UiPanelBase
{
	// Token: 0x060035E0 RID: 13792 RVA: 0x0013BE2F File Offset: 0x0013A02F
	public void Initialize(UUIItem uiItem)
	{
		base.CreateThenShowByActor(uiItem.GetOwner(), null);
	}

	// Token: 0x060035E1 RID: 13793 RVA: 0x0013BE40 File Offset: 0x0013A040
	protected unsafe override void OnRegisterComponent()
	{
		int num = 8;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(4, typeof(UUITexture));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(7, typeof(UUITexture));
		this.ComponentRegisterInfos = list;
	}

	// Token: 0x060035E2 RID: 13794 RVA: 0x0013BF70 File Offset: 0x0013A170
	protected override void OnStart()
	{
		this.AchievementGridItem = new AchievementGridItem();
		this.AchievementGridItem.Initialize(base.GetItem(1).GetOwner());
		this.AchievementGridItem.SetActive(false);
		this.ProgressConfirmItem = new AchievementProgressConfirmItem(base.GetItem(0));
		this.ProgressConfirmItem.SetClickCallback(new Action(this.OnClickButton));
		this.AddEventListener();
	}

	// Token: 0x060035E3 RID: 13795 RVA: 0x0013BFDA File Offset: 0x0013A1DA
	protected void AddEventListener()
	{
		EventSystem.Instance.Add<int>(EEventName.OnAchievementGroupDataNotify, new Action<int>(this.OnAchievementGroupDataNotify));
	}

	// Token: 0x060035E4 RID: 13796 RVA: 0x0013BFF8 File Offset: 0x0013A1F8
	public void Update(AchievementGroupData groupData)
	{
		this.GroupData = groupData;
		this.RefreshUi(groupData);
	}

	// Token: 0x060035E5 RID: 13797 RVA: 0x0013C008 File Offset: 0x0013A208
	private void RefreshUi(AchievementGroupData groupData)
	{
		if (groupData == null)
		{
			return;
		}
		UUIText text = base.GetText(3);
		UUIText text2 = base.GetText(5);
		UUIText text3 = base.GetText(6);
		EAchievementStateEnum finishState = groupData.GetFinishState();
		bool flag = groupData.GetRewards().Count > 0;
		UUIText text4 = base.GetText(2);
		if (text4 != null)
		{
			text4.SetText(groupData.GetTitle(), true);
		}
		text.SetText(groupData.GetAchievementGroupProgress(), true);
		if (text != null)
		{
			text.SetUIActive(flag);
		}
		if (text3 != null)
		{
			text3.SetUIActive(flag);
		}
		base.SetTextureByPath(groupData.GetTexture(), base.GetTexture(4), null, null);
		base.SetTextureByPath(groupData.GetBackgroundIcon(), base.GetTexture(7), null, null);
		AchievementProgressConfirmItem progressConfirmItem = this.ProgressConfirmItem;
		if (progressConfirmItem != null)
		{
			progressConfirmItem.SetActive(finishState == EAchievementStateEnum.CanGetReward && flag);
		}
		AchievementProgressConfirmItem progressConfirmItem2 = this.ProgressConfirmItem;
		if (progressConfirmItem2 != null)
		{
			progressConfirmItem2.RefreshRedPoint(groupData.RedPoint());
		}
		if (!flag)
		{
			if (text2 != null)
			{
				text2.SetUIActive(false);
			}
		}
		else if (finishState == EAchievementStateEnum.CanGetReward)
		{
			if (text2 != null)
			{
				text2.SetUIActive(false);
			}
		}
		else if (finishState == EAchievementStateEnum.HaveGetReward)
		{
			if (text2 != null)
			{
				text2.SetUIActive(true);
			}
			LguiUtil.Instance.SetLocalTextNew(text2, "CollectActivity_state_recived", Array.Empty<object>());
		}
		else
		{
			if (text2 != null)
			{
				text2.SetUIActive(true);
			}
			LguiUtil.Instance.SetLocalTextNew(text2, "Text_Doing_Text", Array.Empty<object>());
		}
		this.RefreshReward(groupData);
	}

	// Token: 0x060035E6 RID: 13798 RVA: 0x0013C158 File Offset: 0x0013A358
	private void RefreshReward(AchievementGroupData groupData)
	{
		List<TItem> list = (groupData != null) ? groupData.GetRewards() : null;
		if (list.Count > 0)
		{
			this.AchievementGridItem.SetActive(true);
			AchievementGridItemData achievementGridItemData = new AchievementGridItemData();
			achievementGridItemData.Data = new TItem?(list[0]);
			achievementGridItemData.GetRewardState = (groupData.GetFinishState() == EAchievementStateEnum.HaveGetReward);
			this.AchievementGridItem.Refresh(achievementGridItemData, false, 0);
			return;
		}
		this.AchievementGridItem.SetActive(false);
	}

	// Token: 0x060035E7 RID: 13799 RVA: 0x0013C1C9 File Offset: 0x0013A3C9
	protected override void OnBeforeDestroy()
	{
		this.RemoveEventListener();
	}

	// Token: 0x060035E8 RID: 13800 RVA: 0x0013C1D1 File Offset: 0x0013A3D1
	protected void RemoveEventListener()
	{
		EventSystem.Instance.Remove(EEventName.OnAchievementGroupDataNotify, new Action<int>(this.OnAchievementGroupDataNotify));
	}

	// Token: 0x060035E9 RID: 13801 RVA: 0x0013C1EF File Offset: 0x0013A3EF
	private void OnAchievementGroupDataNotify(int groupId)
	{
		this.RefreshUi(this.GroupData);
	}

	// Token: 0x060035EA RID: 13802 RVA: 0x0013C1FD File Offset: 0x0013A3FD
	private void OnClickButton()
	{
		AchievementController.Instance.RequestGetAchievementReward(true, this.GroupData.GetId());
	}

	// Token: 0x04002D38 RID: 11576
	[Nullable(2)]
	private AchievementGroupData GroupData;

	// Token: 0x04002D39 RID: 11577
	[Nullable(2)]
	private AchievementGridItem AchievementGridItem;

	// Token: 0x04002D3A RID: 11578
	[Nullable(2)]
	private AchievementProgressConfirmItem ProgressConfirmItem;

	// Token: 0x02006703 RID: 26371
	[NullableContext(0)]
	private enum EComponents
	{
		// Token: 0x04022082 RID: 139394
		Confirm,
		// Token: 0x04022083 RID: 139395
		CommonGridItem,
		// Token: 0x04022084 RID: 139396
		Title,
		// Token: 0x04022085 RID: 139397
		Progress,
		// Token: 0x04022086 RID: 139398
		IconTexture,
		// Token: 0x04022087 RID: 139399
		ProgressingText,
		// Token: 0x04022088 RID: 139400
		ProgressPreText,
		// Token: 0x04022089 RID: 139401
		BackgroundTexture
	}
}
