using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Item;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02000663 RID: 1635
[NullableContext(1)]
[Nullable(0)]
public class BlackCoastActivityMainView : UiViewBase
{
	// Token: 0x06004BA0 RID: 19360 RVA: 0x0019A9BB File Offset: 0x00198BBB
	public BlackCoastActivityMainView(UiViewInfo info) : base(info)
	{
	}

	// Token: 0x06004BA1 RID: 19361 RVA: 0x0019A9C4 File Offset: 0x00198BC4
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

	// Token: 0x06004BA2 RID: 19362 RVA: 0x0019ABBC File Offset: 0x00198DBC
	protected override UniTask OnBeforeStartAsync()
	{
		BlackCoastActivityMainView.<OnBeforeStartAsync>d__8 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<BlackCoastActivityMainView.<OnBeforeStartAsync>d__8>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06004BA3 RID: 19363 RVA: 0x0019AC00 File Offset: 0x00198E00
	protected override void OnStart()
	{
		UUITexture textureIcon = base.GetTexture(2);
		textureIcon.SetUIActive(false);
		base.SetItemIcon(textureIcon, this.ActivityBaseData.GetProgressItemId, null, delegate(bool _)
		{
			textureIcon.SetUIActive(true);
		});
	}

	// Token: 0x06004BA4 RID: 19364 RVA: 0x0019AC58 File Offset: 0x00198E58
	protected override void OnBeforeShow()
	{
		ActivityController.Instance.CheckIsActivityClose(null, new int?(this.ActivityBaseData.Id));
		this.RefreshDataProgress();
		this.RefreshStageLayout();
		base.GetButton(6).RootUIComp.Get().SetUIActive(this.ActivityBaseData.GetCurrentLockQuestId() != null);
	}

	// Token: 0x06004BA5 RID: 19365 RVA: 0x0019ACC0 File Offset: 0x00198EC0
	protected override void OnAddEventListener()
	{
		EventSystem.Instance.Add<RewardPopupData>(EEventName.RefreshRewardPopUp, new Action<RewardPopupData>(this.OnRefreshRewardPopUp));
		EventSystem.Instance.Add<int>(EEventName.RefreshCommonActivityRedDot, new Action<int>(this.OnRefreshRewardLayout));
	}

	// Token: 0x06004BA6 RID: 19366 RVA: 0x0019ACFA File Offset: 0x00198EFA
	protected override void OnRemoveEventListener()
	{
		EventSystem.Instance.Remove(EEventName.RefreshRewardPopUp, new Action<RewardPopupData>(this.OnRefreshRewardPopUp));
		EventSystem.Instance.Remove(EEventName.RefreshCommonActivityRedDot, new Action<int>(this.OnRefreshRewardLayout));
	}

	// Token: 0x06004BA7 RID: 19367 RVA: 0x0019AD34 File Offset: 0x00198F34
	private void RefreshDataProgress()
	{
		base.GetText(3).SetText(this.ActivityBaseData.GetProgressItemCount().ToString() + "/", true);
		base.GetText(4).SetText(this.ActivityBaseData.GetProgressItemTotal().ToString(), true);
		this.RewardPanel.Refresh();
	}

	// Token: 0x06004BA8 RID: 19368 RVA: 0x0019AD96 File Offset: 0x00198F96
	private void RefreshStageLayout()
	{
		this.StageLayout.RefreshByData(this.ActivityBaseData.GetAllStages(), null, false);
	}

	// Token: 0x06004BA9 RID: 19369 RVA: 0x0019ADB0 File Offset: 0x00198FB0
	private BlackCoastStageItem OnCreateStageItem()
	{
		return new BlackCoastStageItem
		{
			OpenTaskView = new Action<int>(this.OnOpenTaskView),
			NewFlagRedDot = ((int stageId) => this.ActivityBaseData.HasNewStageFlag(stageId))
		};
	}

	// Token: 0x06004BAA RID: 19370 RVA: 0x0019ADDB File Offset: 0x00198FDB
	private void OnRefreshRewardLayout(int activityId)
	{
		if (this.ActivityBaseData != null && this.ActivityBaseData.Id == activityId)
		{
			this.RewardPanel.RefreshLayout();
		}
	}

	// Token: 0x06004BAB RID: 19371 RVA: 0x0019ADFE File Offset: 0x00198FFE
	private void OnRefreshRewardPopUp(RewardPopupData data)
	{
		this.RewardPopup.Refresh(data);
	}

	// Token: 0x06004BAC RID: 19372 RVA: 0x0019AE0C File Offset: 0x0019900C
	private void OnCloseBtnClick()
	{
		base.CloseMe(null);
	}

	// Token: 0x06004BAD RID: 19373 RVA: 0x0019AE15 File Offset: 0x00199015
	private void OnOpenTaskView(int stageId)
	{
		UiManager.Instance.OpenView(EUiViewName.BlackCoastActivityTaskView, new object[]
		{
			this.ActivityBaseData,
			stageId
		}, null);
	}

	// Token: 0x06004BAE RID: 19374 RVA: 0x0019AE40 File Offset: 0x00199040
	private void ButtonWeaponFunction()
	{
		WeaponPreviewViewParam weaponPreviewViewParam = new WeaponPreviewViewParam();
		WeaponDataBase[] previewWeaponDataList = this.ActivityBaseData.GetPreviewWeaponDataList();
		weaponPreviewViewParam.WeaponDataList = previewWeaponDataList;
		weaponPreviewViewParam.SelectedIndex = 0;
		WeaponPreviewViewParam param = weaponPreviewViewParam;
		UiManager.Instance.OpenView(EUiViewName.WeaponPreviewView, param, null);
	}

	// Token: 0x06004BAF RID: 19375 RVA: 0x0019AE7E File Offset: 0x0019907E
	private void ButtonQuestFunction()
	{
		UiManager.Instance.OpenView(EUiViewName.QuestView, this.ActivityBaseData.GetCurrentLockQuestId(), null);
	}

	// Token: 0x06004BB0 RID: 19376 RVA: 0x0019AEA0 File Offset: 0x001990A0
	private void ButtonIconFunction()
	{
		ItemController.Instance.OpenItemTipsByItemId(this.ActivityBaseData.GetProgressItemId, true, null, false);
	}

	// Token: 0x040037DA RID: 14298
	protected ActivityBlackCoastData ActivityBaseData;

	// Token: 0x040037DB RID: 14299
	private PopupCaptionItem CaptionItem;

	// Token: 0x040037DC RID: 14300
	private BlackCoastRewardPanel RewardPanel;

	// Token: 0x040037DD RID: 14301
	private CommonRewardPopup RewardPopup;

	// Token: 0x040037DE RID: 14302
	private GenericLayout<BlackCoastStageItem, BlackCoastStageInfo> StageLayout;

	// Token: 0x0200691B RID: 26907
	[NullableContext(0)]
	private class EComponents
	{
		// Token: 0x040229F8 RID: 141816
		public const int Caption = 0;

		// Token: 0x040229F9 RID: 141817
		public const int ButtonWeapon = 1;

		// Token: 0x040229FA RID: 141818
		public const int DataIcon = 2;

		// Token: 0x040229FB RID: 141819
		public const int DataCount = 3;

		// Token: 0x040229FC RID: 141820
		public const int DataTotal = 4;

		// Token: 0x040229FD RID: 141821
		public const int ProgressBar = 5;

		// Token: 0x040229FE RID: 141822
		public const int ButtonQuest = 6;

		// Token: 0x040229FF RID: 141823
		public const int StageLayout = 7;

		// Token: 0x04022A00 RID: 141824
		public const int StageCard = 8;

		// Token: 0x04022A01 RID: 141825
		public const int ButtonIcon = 9;
	}
}
