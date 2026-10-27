using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Item;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x020011AF RID: 4527
[NullableContext(1)]
[Nullable(0)]
public class BlackCoastActivityMainView : UiViewBase
{
	// Token: 0x06007809 RID: 30729 RVA: 0x00191DDF File Offset: 0x0018FFDF
	public BlackCoastActivityMainView(UiViewInfo info) : base(info)
	{
	}

	// Token: 0x0600780A RID: 30730 RVA: 0x00191DE8 File Offset: 0x0018FFE8
	protected unsafe override void OnRegisterComponent()
	{
		int num = 10;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUITexture));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIHorizontalLayout));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(8, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(9, typeof(UUIButtonComponent));
		this.ComponentRegisterInfos = list;
		num2 = 3;
		List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
		CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
		Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
		num = 0;
		*span2[num] = new ValueTuple<int, Delegate>(1, new Action(this.ButtonWeaponFunction));
		num++;
		*span2[num] = new ValueTuple<int, Delegate>(6, new Action(this.ButtonQuestFunction));
		num++;
		*span2[num] = new ValueTuple<int, Delegate>(9, new Action(this.ButtonIconFunction));
		this.BtnBindInfo = list2;
	}

	// Token: 0x0600780B RID: 30731 RVA: 0x00191FE0 File Offset: 0x001901E0
	protected override UniTask OnBeforeStartAsync()
	{
		BlackCoastActivityMainView.<OnBeforeStartAsync>d__8 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<BlackCoastActivityMainView.<OnBeforeStartAsync>d__8>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600780C RID: 30732 RVA: 0x00192024 File Offset: 0x00190224
	protected override void OnStart()
	{
		UUITexture textureIcon = base.GetTexture(2);
		textureIcon.SetUIActive(false);
		base.SetItemIcon(textureIcon, this.ActivityBaseData.GetProgressItemId, null, delegate(bool _)
		{
			textureIcon.SetUIActive(true);
		});
	}

	// Token: 0x0600780D RID: 30733 RVA: 0x0019207C File Offset: 0x0019027C
	protected override void OnBeforeShow()
	{
		ActivityController.Instance.CheckIsActivityClose(null, new int?(this.ActivityBaseData.Id));
		this.RefreshDataProgress();
		this.RefreshStageLayout();
		base.GetButton(6).RootUIComp.Get().SetUIActive(this.ActivityBaseData.GetCurrentLockQuestId() != null);
	}

	// Token: 0x0600780E RID: 30734 RVA: 0x001920E4 File Offset: 0x001902E4
	protected override void OnAddEventListener()
	{
		EventSystem.Instance.Add<RewardPopupData>(EEventName.RefreshRewardPopUp, new Action<RewardPopupData>(this.OnRefreshRewardPopUp));
		EventSystem.Instance.Add<int>(EEventName.RefreshCommonActivityRedDot, new Action<int>(this.OnRefreshRewardLayout));
	}

	// Token: 0x0600780F RID: 30735 RVA: 0x0019211E File Offset: 0x0019031E
	protected override void OnRemoveEventListener()
	{
		EventSystem.Instance.Remove(EEventName.RefreshRewardPopUp, new Action<RewardPopupData>(this.OnRefreshRewardPopUp));
		EventSystem.Instance.Remove(EEventName.RefreshCommonActivityRedDot, new Action<int>(this.OnRefreshRewardLayout));
	}

	// Token: 0x06007810 RID: 30736 RVA: 0x00192158 File Offset: 0x00190358
	private void RefreshDataProgress()
	{
		base.GetText(3).SetText(this.ActivityBaseData.GetProgressItemCount().ToString() + "/", true);
		base.GetText(4).SetText(this.ActivityBaseData.GetProgressItemTotal().ToString(), true);
		this.RewardPanel.Refresh();
	}

	// Token: 0x06007811 RID: 30737 RVA: 0x001921BA File Offset: 0x001903BA
	private void RefreshStageLayout()
	{
		this.StageLayout.RefreshByData(this.ActivityBaseData.GetAllStages().ToList<BlackCoastStageInfo>(), null, false);
	}

	// Token: 0x06007812 RID: 30738 RVA: 0x001921D9 File Offset: 0x001903D9
	private BlackCoastStageItem OnCreateStageItem()
	{
		return new BlackCoastStageItem
		{
			OpenTaskView = new Action<int>(this.OnOpenTaskView),
			NewFlagRedDot = ((int stageId) => this.ActivityBaseData.HasNewStageFlag(stageId))
		};
	}

	// Token: 0x06007813 RID: 30739 RVA: 0x00192204 File Offset: 0x00190404
	private void OnRefreshRewardLayout(int activityId)
	{
		if (this.ActivityBaseData != null && this.ActivityBaseData.Id == activityId)
		{
			this.RewardPanel.RefreshLayout();
		}
	}

	// Token: 0x06007814 RID: 30740 RVA: 0x00192227 File Offset: 0x00190427
	private void OnRefreshRewardPopUp(RewardPopupData data)
	{
		this.RewardPopup.Refresh(data);
	}

	// Token: 0x06007815 RID: 30741 RVA: 0x00192235 File Offset: 0x00190435
	private void OnCloseBtnClick()
	{
		base.CloseMe(null);
	}

	// Token: 0x06007816 RID: 30742 RVA: 0x0019223E File Offset: 0x0019043E
	private void OnOpenTaskView(int stageId)
	{
		UiManager.Instance.OpenView(EUiViewName.BlackCoastActivityTaskView, new object[]
		{
			this.ActivityBaseData,
			stageId
		}, null);
	}

	// Token: 0x06007817 RID: 30743 RVA: 0x00192268 File Offset: 0x00190468
	private void ButtonWeaponFunction()
	{
		WeaponPreviewViewParam weaponPreviewViewParam = new WeaponPreviewViewParam();
		WeaponDataBase[] previewWeaponDataList = this.ActivityBaseData.GetPreviewWeaponDataList();
		weaponPreviewViewParam.WeaponDataList = previewWeaponDataList;
		weaponPreviewViewParam.SelectedIndex = 0;
		WeaponPreviewViewParam param = weaponPreviewViewParam;
		UiManager.Instance.OpenView(EUiViewName.WeaponPreviewView, param, null);
	}

	// Token: 0x06007818 RID: 30744 RVA: 0x001922A6 File Offset: 0x001904A6
	private void ButtonQuestFunction()
	{
		UiManager.Instance.OpenView(EUiViewName.QuestView, this.ActivityBaseData.GetCurrentLockQuestId(), null);
	}

	// Token: 0x06007819 RID: 30745 RVA: 0x001922C8 File Offset: 0x001904C8
	private void ButtonIconFunction()
	{
		ItemController.Instance.OpenItemTipsByItemId(this.ActivityBaseData.GetProgressItemId, true, null);
	}

	// Token: 0x04003741 RID: 14145
	protected ActivityBlackCoastData ActivityBaseData;

	// Token: 0x04003742 RID: 14146
	private PopupCaptionItem CaptionItem;

	// Token: 0x04003743 RID: 14147
	private BlackCoastRewardPanel RewardPanel;

	// Token: 0x04003744 RID: 14148
	private CommonRewardPopup RewardPopup;

	// Token: 0x04003745 RID: 14149
	private GenericLayout<BlackCoastStageItem, BlackCoastStageInfo> StageLayout;

	// Token: 0x0200778F RID: 30607
	[NullableContext(0)]
	private class EComponents
	{
		// Token: 0x040276C2 RID: 161474
		public const int Caption = 0;

		// Token: 0x040276C3 RID: 161475
		public const int ButtonWeapon = 1;

		// Token: 0x040276C4 RID: 161476
		public const int DataIcon = 2;

		// Token: 0x040276C5 RID: 161477
		public const int DataCount = 3;

		// Token: 0x040276C6 RID: 161478
		public const int DataTotal = 4;

		// Token: 0x040276C7 RID: 161479
		public const int ProgressBar = 5;

		// Token: 0x040276C8 RID: 161480
		public const int ButtonQuest = 6;

		// Token: 0x040276C9 RID: 161481
		public const int StageLayout = 7;

		// Token: 0x040276CA RID: 161482
		public const int StageCard = 8;

		// Token: 0x040276CB RID: 161483
		public const int ButtonIcon = 9;
	}
}
