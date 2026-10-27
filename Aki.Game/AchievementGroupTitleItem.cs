using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02000F28 RID: 3880
[NullableContext(1)]
[Nullable(0)]
public class AchievementGroupTitleItem : UiPanelBase
{
	// Token: 0x06006248 RID: 25160 RVA: 0x00133507 File Offset: 0x00131707
	public void Initialize(UUIItem uiItem)
	{
		base.CreateThenShowByActor(uiItem.GetOwner(), null);
	}

	// Token: 0x06006249 RID: 25161 RVA: 0x00133518 File Offset: 0x00131718
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

	// Token: 0x0600624A RID: 25162 RVA: 0x00133648 File Offset: 0x00131848
	protected override void OnStart()
	{
		this.AchievementGridItem = new AchievementGridItem();
		this.AchievementGridItem.Initialize(base.GetItem(1).GetOwner());
		this.AchievementGridItem.SetActive(false);
		this.ProgressConfirmItem = new AchievementProgressConfirmItem(base.GetItem(0));
		this.ProgressConfirmItem.SetClickCallback(new Action(this.OnClickButton));
		this.AddEventListener();
	}

	// Token: 0x0600624B RID: 25163 RVA: 0x001336B2 File Offset: 0x001318B2
	protected void AddEventListener()
	{
		EventSystem.Instance.Add<int>(EEventName.OnAchievementGroupDataNotify, new Action<int>(this.OnAchievementGroupDataNotify));
	}

	// Token: 0x0600624C RID: 25164 RVA: 0x001336D0 File Offset: 0x001318D0
	public void Update(AchievementGroupData groupData)
	{
		this.GroupData = groupData;
		this.RefreshUi(groupData);
	}

	// Token: 0x0600624D RID: 25165 RVA: 0x001336E0 File Offset: 0x001318E0
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

	// Token: 0x0600624E RID: 25166 RVA: 0x00133830 File Offset: 0x00131A30
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

	// Token: 0x0600624F RID: 25167 RVA: 0x001338A1 File Offset: 0x00131AA1
	protected override void OnBeforeDestroy()
	{
		this.RemoveEventListener();
	}

	// Token: 0x06006250 RID: 25168 RVA: 0x001338A9 File Offset: 0x00131AA9
	protected void RemoveEventListener()
	{
		EventSystem.Instance.Remove(EEventName.OnAchievementGroupDataNotify, new Action<int>(this.OnAchievementGroupDataNotify));
	}

	// Token: 0x06006251 RID: 25169 RVA: 0x001338C7 File Offset: 0x00131AC7
	private void OnAchievementGroupDataNotify(int groupId)
	{
		this.RefreshUi(this.GroupData);
	}

	// Token: 0x06006252 RID: 25170 RVA: 0x001338D5 File Offset: 0x00131AD5
	private void OnClickButton()
	{
		AchievementController.Instance.RequestGetAchievementReward(true, this.GroupData.GetId());
	}

	// Token: 0x04002C9F RID: 11423
	[Nullable(2)]
	private AchievementGroupData GroupData;

	// Token: 0x04002CA0 RID: 11424
	[Nullable(2)]
	private AchievementGridItem AchievementGridItem;

	// Token: 0x04002CA1 RID: 11425
	[Nullable(2)]
	private AchievementProgressConfirmItem ProgressConfirmItem;

	// Token: 0x0200756F RID: 30063
	[NullableContext(0)]
	private enum EComponents
	{
		// Token: 0x04026D37 RID: 159031
		Confirm,
		// Token: 0x04026D38 RID: 159032
		CommonGridItem,
		// Token: 0x04026D39 RID: 159033
		Title,
		// Token: 0x04026D3A RID: 159034
		Progress,
		// Token: 0x04026D3B RID: 159035
		IconTexture,
		// Token: 0x04026D3C RID: 159036
		ProgressingText,
		// Token: 0x04026D3D RID: 159037
		ProgressPreText,
		// Token: 0x04026D3E RID: 159038
		BackgroundTexture
	}
}
