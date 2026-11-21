using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.AutoAttach;
using CSharpScript.Game.Module.RoleUi;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using CSharpScript.Module.InstanceDungeon;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02000730 RID: 1840
[NullableContext(1)]
[Nullable(0)]
public class FightPhotoMainView : UiTickViewBase
{
	// Token: 0x060054A8 RID: 21672 RVA: 0x001BE530 File Offset: 0x001BC730
	public FightPhotoMainView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x060054A9 RID: 21673 RVA: 0x001BE54C File Offset: 0x001BC74C
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIItem)),
			new ValueTuple<int, Type>(1, typeof(UUITexture)),
			new ValueTuple<int, Type>(2, typeof(UUIText)),
			new ValueTuple<int, Type>(3, typeof(UUITexture)),
			new ValueTuple<int, Type>(4, typeof(UUIText)),
			new ValueTuple<int, Type>(5, typeof(UUIItem)),
			new ValueTuple<int, Type>(6, typeof(UUIItem)),
			new ValueTuple<int, Type>(7, typeof(UUIItem)),
			new ValueTuple<int, Type>(8, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(9, typeof(UUIText)),
			new ValueTuple<int, Type>(10, typeof(UUIItem)),
			new ValueTuple<int, Type>(11, typeof(UUIItem)),
			new ValueTuple<int, Type>(12, typeof(UUIHorizontalLayout)),
			new ValueTuple<int, Type>(13, typeof(UUIItem)),
			new ValueTuple<int, Type>(14, typeof(UUIText)),
			new ValueTuple<int, Type>(15, typeof(UUIVerticalLayout)),
			new ValueTuple<int, Type>(16, typeof(UUIItem)),
			new ValueTuple<int, Type>(17, typeof(UUIHorizontalLayout)),
			new ValueTuple<int, Type>(18, typeof(UUIItem)),
			new ValueTuple<int, Type>(19, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(20, typeof(UUIItem)),
			new ValueTuple<int, Type>(21, typeof(UUIText)),
			new ValueTuple<int, Type>(22, typeof(UUIArtText)),
			new ValueTuple<int, Type>(23, typeof(UUIArtText)),
			new ValueTuple<int, Type>(24, typeof(UUIArtText)),
			new ValueTuple<int, Type>(25, typeof(UUIArtText)),
			new ValueTuple<int, Type>(26, typeof(UUIItem)),
			new ValueTuple<int, Type>(27, typeof(UUIText)),
			new ValueTuple<int, Type>(28, typeof(UUITexture))
		};
		this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
		{
			new ValueTuple<int, Delegate>(19, new Action(this.OnGotoBtnClick)),
			new ValueTuple<int, Delegate>(8, new Action(this.OnRewardBtnClick))
		};
	}

	// Token: 0x060054AA RID: 21674 RVA: 0x001BE834 File Offset: 0x001BCA34
	protected override UniTask OnBeforeStartAsync()
	{
		FightPhotoMainView.<OnBeforeStartAsync>d__17 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<FightPhotoMainView.<OnBeforeStartAsync>d__17>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x060054AB RID: 21675 RVA: 0x001BE878 File Offset: 0x001BCA78
	protected override void OnStart()
	{
		UUIItem item = base.GetItem(5);
		UUIItem item2 = base.GetItem(6);
		this.NoCircleAttachView = new NoCircleAttachView<FightPhotoLevelGroupData, FightPhotoLevelGroupItem>(item.GetOwner(), false);
		this.NoCircleAttachView.SetIfNeedFakeItem(true);
		this.NoCircleAttachView.CreateItems(base.GetItem(7).GetOwner(), 0f, new Func<AActor, int, int, FightPhotoLevelGroupItem>(this.CreateNoCircleAttachItem), EAttachDirection.Vertical);
		NoCircleAttachView<FightPhotoLevelGroupData, FightPhotoLevelGroupItem> noCircleAttachView = this.NoCircleAttachView;
		if (noCircleAttachView != null)
		{
			noCircleAttachView.SetControllerItem(item2);
		}
		base.GetItem(7).SetUIActive(false);
		this.LevelLayout = new GenericLayout<FightPhotoLevelItem, FightPhotoLevelData>(base.GetHorizontalLayout(12), new Func<FightPhotoLevelItem>(this.CreateLevelItem), null, false, true);
		this.TaskTargetLayout = new GenericLayout<FightPhotoTaskTargetItem, string>(base.GetVerticalLayout(15), new Func<FightPhotoTaskTargetItem>(this.CreateTaskTargetItem), null, false, true);
		this.RoleLayout = new GenericLayout<FightPhotoRoleItem, int>(base.GetHorizontalLayout(17), new Func<FightPhotoRoleItem>(this.CreateRoleItem), null, false, true);
		List<FightPhotoLevelGroupData> levelGroupDataList = this.ActivityData.GetLevelGroupDataList();
		int selectLevelGroupDataIndex = this.ActivityData.GetSelectLevelGroupDataIndex();
		this.NoCircleAttachView.ReloadView(levelGroupDataList.Count, levelGroupDataList.ToArray(), selectLevelGroupDataIndex);
	}

	// Token: 0x060054AC RID: 21676 RVA: 0x001BE991 File Offset: 0x001BCB91
	protected override void OnAddEventListener()
	{
		EventSystem.Instance.Add(EEventName.OnRefreshFightPhotoLevelRedDot, new Action(this.OnRefreshFightPhotoLevelRedDot));
	}

	// Token: 0x060054AD RID: 21677 RVA: 0x001BE9B0 File Offset: 0x001BCBB0
	protected override void OnBeforeShow()
	{
		SplashScreenController.Instance.FinishCurTask(ESplashScreenSourceModuleType.None);
		this.ActivityData.IsNeedShowFightPhotoMainView = false;
		int finishedTaskNum = this.ActivityData.GetFinishedTaskNum();
		int totalTaskNum = this.ActivityData.GetTotalTaskNum();
		UUIText text = base.GetText(21);
		if (text != null)
		{
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
			defaultInterpolatedStringHandler.AppendFormatted<int>(finishedTaskNum);
			defaultInterpolatedStringHandler.AppendLiteral("/");
			defaultInterpolatedStringHandler.AppendFormatted<int>(totalTaskNum);
			text.SetText(defaultInterpolatedStringHandler.ToStringAndClear(), true);
		}
		int num = finishedTaskNum / 10;
		UUIArtText artText = base.GetArtText(22);
		if (artText != null)
		{
			artText.SetText(num.ToString());
		}
		int num2 = finishedTaskNum % 10;
		UUIArtText artText2 = base.GetArtText(23);
		if (artText2 != null)
		{
			artText2.SetText(num2.ToString());
		}
		int num3 = totalTaskNum / 10;
		UUIArtText artText3 = base.GetArtText(24);
		if (artText3 != null)
		{
			artText3.SetText(num3.ToString());
		}
		int num4 = totalTaskNum % 10;
		UUIArtText artText4 = base.GetArtText(25);
		if (artText4 != null)
		{
			artText4.SetText(num4.ToString());
		}
		UUIItem item = base.GetItem(20);
		if (item == null)
		{
			return;
		}
		item.SetUIActive(this.ActivityData.IsTaskHasRedDot());
	}

	// Token: 0x060054AE RID: 21678 RVA: 0x001BEAC7 File Offset: 0x001BCCC7
	protected override void OnAfterShow()
	{
		if (this.ActivityData.IsNeedShowTip)
		{
			ScrollingTipsController.Instance.ShowTipsByTextId("FightPhotoUnlockNewLevel", Array.Empty<object>());
			this.ActivityData.IsNeedShowTip = false;
		}
	}

	// Token: 0x060054AF RID: 21679 RVA: 0x001BEAF8 File Offset: 0x001BCCF8
	protected override void OnTick(float delta)
	{
		if (this.CurrentLevelGroupData == null)
		{
			return;
		}
		if (this.CurrentLevelGroupData.IsUnLock)
		{
			if (!this.IsCurrentLevelGroupUnlock)
			{
				this.RefreshView(this.CurrentLevelGroupData);
			}
			return;
		}
		string text = ConfigMultiTextLang.GetLocalTextNew("FightPhotoUnlockTime", null) ?? "{0}后解锁";
		string newText = ActivityModel.Instance.GetRemainTimeText(this.CurrentLevelGroupData.UnlockTime, text) ?? "";
		UUIText text2 = base.GetText(27);
		if (text2 == null)
		{
			return;
		}
		text2.SetText(newText, true);
	}

	// Token: 0x060054B0 RID: 21680 RVA: 0x001BEB7C File Offset: 0x001BCD7C
	private void RefreshView(FightPhotoLevelGroupData data)
	{
		UUIItem item = base.GetItem(10);
		if (item != null)
		{
			item.SetUIActive(!data.IsUnLock);
		}
		UUIItem item2 = base.GetItem(11);
		if (item2 != null)
		{
			item2.SetUIActive(data.IsUnLock);
		}
		UUIText text = base.GetText(9);
		if (text != null)
		{
			text.SetUIActive(data.IsUnLock);
		}
		LguiUtil.Instance.SetLocalTextNew(base.GetText(2), data.TargetRoleName, Array.Empty<object>());
		LguiUtil.Instance.SetLocalTextNew(base.GetText(14), data.TargetRoleName, Array.Empty<object>());
		if (this.CurrentLevelGroupData != null)
		{
			LguiUtil.Instance.SetLocalTextNew(base.GetText(4), this.CurrentLevelGroupData.TargetRoleName, Array.Empty<object>());
		}
		this.CurrentLevelGroupData = data;
		this.IsCurrentLevelGroupUnlock = data.IsUnLock;
		this.LevelLayout.DeselectCurrentGridProxy();
		this.LevelLayout.RefreshByData(data.LevelDataList, delegate
		{
			int currentLevelId = this.ActivityData.GetCurrentLevelId();
			FightPhotoLevelData fightPhotoLevelData = data.FirstUnFinishedLevelData;
			if (currentLevelId != 0)
			{
				this.ActivityData.SetCurrentLevelId(0);
				fightPhotoLevelData = this.ActivityData.GetLevelData(currentLevelId);
			}
			this.LevelLayout.SelectGridProxyByKey(fightPhotoLevelData, false);
			InstanceDungeonEntranceModel.Instance.SelectInstanceId = fightPhotoLevelData.InstanceId;
			this.RefreshRightPanel(fightPhotoLevelData);
		}, false);
	}

	// Token: 0x060054B1 RID: 21681 RVA: 0x001BECB4 File Offset: 0x001BCEB4
	private void RefreshRightPanel(FightPhotoLevelData levelData)
	{
		if (this.CurrentLevelData != null)
		{
			base.SetTextureByPath(this.CurrentLevelData.RoleBigTexture, base.GetTexture(28), null, null);
			base.SetTextureByPath(this.CurrentLevelData.RoleBigTexture, base.GetTexture(3), null, null);
		}
		this.CurrentLevelData = levelData;
		base.SetTextureByPath(levelData.RoleBigTexture, base.GetTexture(1), null, null);
		LguiUtil.Instance.SetLocalTextNew(base.GetText(9), levelData.Name, Array.Empty<object>());
		this.TaskTargetLayout.RefreshByData(levelData.TaskTargetText, delegate
		{
			foreach (FightPhotoTaskTargetItem fightPhotoTaskTargetItem in this.TaskTargetLayout.GetLayoutItemList())
			{
				fightPhotoTaskTargetItem.SetIsFinished(this.CurrentLevelData.IsFinished);
			}
		}, false);
		this.CurrentRoleList = levelData.GetRoleIdListIncludeZero();
		this.RoleLayout.RefreshByData(this.CurrentRoleList, null, false);
		UUIButtonComponent button = base.GetButton(19);
		if (button != null)
		{
			UUIItem uuiitem = button.RootUIComp.Get();
			if (uuiitem != null)
			{
				uuiitem.SetUIActive(levelData.IsUnLock);
			}
		}
		FunctionalPanelConditionLock panelLock = this.PanelLock;
		if (panelLock != null)
		{
			panelLock.SetUiActive(levelData.LevelGroupData.IsUnLock && !levelData.IsUnLock);
		}
		if (!levelData.IsUnLock)
		{
			string localTextNew = ConfigMultiTextLang.GetLocalTextNew(levelData.PreLevelName, null);
			FunctionalPanelConditionLock panelLock2 = this.PanelLock;
			if (panelLock2 == null)
			{
				return;
			}
			panelLock2.SetTextByTextId("PrefabTextItem_28127837_Text", new string[]
			{
				localTextNew
			});
		}
	}

	// Token: 0x060054B2 RID: 21682 RVA: 0x001BEE16 File Offset: 0x001BD016
	protected override void OnRemoveEventListener()
	{
		EventSystem.Instance.Remove(EEventName.OnRefreshFightPhotoLevelRedDot, new Action(this.OnRefreshFightPhotoLevelRedDot));
	}

	// Token: 0x060054B3 RID: 21683 RVA: 0x001BEE34 File Offset: 0x001BD034
	protected override void OnBeforeDestroy()
	{
		InstanceDungeonEntranceModel.Instance.SelectInstanceId = 0;
	}

	// Token: 0x060054B4 RID: 21684 RVA: 0x001BEE44 File Offset: 0x001BD044
	private FightPhotoLevelGroupItem CreateNoCircleAttachItem(AActor actor, int index, int showNum)
	{
		FightPhotoLevelGroupItem fightPhotoLevelGroupItem = new FightPhotoLevelGroupItem(actor);
		fightPhotoLevelGroupItem.CreateByActorAsync(actor, null, false).Forget();
		fightPhotoLevelGroupItem.OnToggleClickCallback = new Action<int, FightPhotoLevelGroupData>(this.OnItemClick);
		fightPhotoLevelGroupItem.OnSelectCallback = new Action<int, FightPhotoLevelGroupData>(this.OnItemSelectCallback);
		fightPhotoLevelGroupItem.CheckToggleCanClick = new Func<bool>(this.CheckToggleCanClick);
		return fightPhotoLevelGroupItem;
	}

	// Token: 0x060054B5 RID: 21685 RVA: 0x001BEE9B File Offset: 0x001BD09B
	private void OnItemClick(int index, FightPhotoLevelGroupData data)
	{
		if (this.NoCircleAttachView.IsVelocityMoveState())
		{
			return;
		}
		if (data == null)
		{
			return;
		}
		this.NoCircleAttachView.AttachToIndex(index, false);
	}

	// Token: 0x060054B6 RID: 21686 RVA: 0x001BEEBC File Offset: 0x001BD0BC
	private void OnItemSelectCallback(int index, FightPhotoLevelGroupData data)
	{
		if (this.SelectedIndex != -1 && this.SelectedIndex != index)
		{
			string sequenceName = (this.SelectedIndex > index) ? "PageUp" : "PageDown";
			base.PlaySequence(sequenceName, null, false);
		}
		if (this.SelectedIndex == -1 || this.SelectedIndex != index)
		{
			this.RefreshView(data);
		}
		this.SelectedIndex = index;
		this.NoCircleAttachView.GetCurrentSelectItem().GetRootItem().SetHierarchyIndex(this.NoCircleAttachView.GetDataLength() + 1);
	}

	// Token: 0x060054B7 RID: 21687 RVA: 0x001BEF3C File Offset: 0x001BD13C
	private bool CheckToggleCanClick()
	{
		return !this.IsQuickRoleSelectViewOpen && !this.NoCircleAttachView.MovingState();
	}

	// Token: 0x060054B8 RID: 21688 RVA: 0x001BEF56 File Offset: 0x001BD156
	private FightPhotoLevelItem CreateLevelItem()
	{
		return new FightPhotoLevelItem
		{
			OnToggleCallBack = new Action<FightPhotoLevelData>(this.OnLevelItemClick),
			CheckToggleCanClick = new Func<bool>(this.CheckLevelToggleCanClick)
		};
	}

	// Token: 0x060054B9 RID: 21689 RVA: 0x001BEF81 File Offset: 0x001BD181
	private bool CheckLevelToggleCanClick()
	{
		return !this.IsQuickRoleSelectViewOpen;
	}

	// Token: 0x060054BA RID: 21690 RVA: 0x001BEF8C File Offset: 0x001BD18C
	private void OnLevelItemClick(FightPhotoLevelData data)
	{
		base.PlaySequence("InfoSwitch", null, false);
		InstanceDungeonEntranceModel.Instance.SelectInstanceId = data.InstanceId;
		this.LevelLayout.SelectGridProxyByKey(data, false);
		this.RefreshRightPanel(data);
	}

	// Token: 0x060054BB RID: 21691 RVA: 0x001BEFBF File Offset: 0x001BD1BF
	private FightPhotoTaskTargetItem CreateTaskTargetItem()
	{
		return new FightPhotoTaskTargetItem();
	}

	// Token: 0x060054BC RID: 21692 RVA: 0x001BEFC6 File Offset: 0x001BD1C6
	private FightPhotoRoleItem CreateRoleItem()
	{
		return new FightPhotoRoleItem
		{
			OnBtnClickCallback = new Action<int>(this.OnRoleBtnClick)
		};
	}

	// Token: 0x060054BD RID: 21693 RVA: 0x001BEFE0 File Offset: 0x001BD1E0
	private unsafe void OnRoleBtnClick(int index)
	{
		if (UiManager.Instance.IsViewOpen(EUiViewName.QuickRoleSelectView))
		{
			return;
		}
		if (!this.NoCircleAttachView.MovingState() && !this.NoCircleAttachView.IsVelocityMoveState())
		{
			GenericLayout<FightPhotoLevelItem, FightPhotoLevelData> levelLayout = this.LevelLayout;
			if (levelLayout == null || !levelLayout.IsLock)
			{
				List<RoleDataBase> list = new List<RoleDataBase>();
				Span<int> trialRoleList = this.CurrentLevelData.TrialRoleList;
				for (int i = 0; i < trialRoleList.Length; i++)
				{
					int id = *trialRoleList[i];
					RoleDataBase roleDataById = RoleModel.Instance.GetRoleDataById(id, true);
					list.Add(roleDataById);
				}
				foreach (RoleInstance roleInstance in RoleModel.Instance.GetRoleList())
				{
					if (roleInstance.GetRoleId() != 0)
					{
						list.Add(roleInstance);
					}
				}
				QuickRoleSelectViewData quickRoleSelectViewData = new QuickRoleSelectViewData(EFilterSortGroupId.FightPhoto, this.CurrentRoleList.ToArray(), list);
				quickRoleSelectViewData.OnConfirm = new Action<int[]>(this.OnQuickSelectConfirm);
				quickRoleSelectViewData.CanConfirm = new Func<int[], bool>(this.CanConfirm);
				quickRoleSelectViewData.IsNeedChangeBtnState = true;
				quickRoleSelectViewData.YellowTipText = this.GetRoleSelectedViewTip();
				quickRoleSelectViewData.OnHideFinish = delegate()
				{
					this.SetLevelSwitchLock(false);
				};
				this.SetLevelSwitchLock(true);
				UiManager.Instance.OpenView(EUiViewName.QuickRoleSelectView, quickRoleSelectViewData, delegate(bool success, int viewId)
				{
					if (!success)
					{
						this.SetLevelSwitchLock(false);
					}
				});
				return;
			}
		}
	}

	// Token: 0x060054BE RID: 21694 RVA: 0x001BF126 File Offset: 0x001BD326
	private void SetLevelSwitchLock(bool locked)
	{
		this.IsQuickRoleSelectViewOpen = locked;
		if (locked)
		{
			NoCircleAttachView<FightPhotoLevelGroupData, FightPhotoLevelGroupItem> noCircleAttachView = this.NoCircleAttachView;
			if (noCircleAttachView == null)
			{
				return;
			}
			noCircleAttachView.DisableDragEvent();
			return;
		}
		else
		{
			NoCircleAttachView<FightPhotoLevelGroupData, FightPhotoLevelGroupItem> noCircleAttachView2 = this.NoCircleAttachView;
			if (noCircleAttachView2 == null)
			{
				return;
			}
			noCircleAttachView2.EnableDragEvent();
			return;
		}
	}

	// Token: 0x060054BF RID: 21695 RVA: 0x001BF154 File Offset: 0x001BD354
	private void OnQuickSelectConfirm(int[] roleIdList)
	{
		List<int> list = new List<int>(roleIdList);
		while (list.Count < 3)
		{
			list.Add(0);
		}
		this.CurrentRoleList = list;
		this.RoleLayout.RefreshByData(this.CurrentRoleList, null, false);
	}

	// Token: 0x060054C0 RID: 21696 RVA: 0x001BF194 File Offset: 0x001BD394
	private bool CanConfirm(int[] roleIdList)
	{
		if (roleIdList.Length == 0)
		{
			return false;
		}
		List<int> list = new List<int>();
		foreach (int num in roleIdList)
		{
			if (num > 100000)
			{
				list.Add(RoleConfig.Instance.GetTrialRoleConfig(num).Value.ParentId);
			}
			else
			{
				list.Add(num);
			}
		}
		HashSet<int> hashSet = new HashSet<int>(list);
		if (hashSet.Count != list.Count)
		{
			ScrollingTipsController.Instance.ShowTipsById("SameRole", Array.Empty<object>());
			return false;
		}
		if (this.CurrentLevelData.IsFinished)
		{
			return true;
		}
		foreach (int item in this.CurrentLevelData.LevelGroupData.TargetRoleIds)
		{
			if (!hashSet.Contains(item))
			{
				return false;
			}
		}
		return true;
	}

	// Token: 0x060054C1 RID: 21697 RVA: 0x001BF294 File Offset: 0x001BD494
	private string GetRoleSelectedViewTip()
	{
		if (this.CurrentLevelData.IsFinished)
		{
			return ConfigMultiTextLang.GetLocalTextNew("FightPhotoCanSelectAnyRole", null) ?? "";
		}
		string targetRoleName = this.CurrentLevelData.LevelGroupData.TargetRoleName;
		return StringUtils.Format(ConfigMultiTextLang.GetLocalTextNew("FightPhotoSelectTip", null) ?? "需要选择共鸣者{0}", new string[]
		{
			ConfigMultiTextLang.GetLocalTextNew(targetRoleName, null) ?? ""
		});
	}

	// Token: 0x060054C2 RID: 21698 RVA: 0x001BF308 File Offset: 0x001BD508
	private void OnGotoBtnClick()
	{
		if (GameModeModel.Instance.IsMulti)
		{
			ScrollingTipsController.Instance.ShowTipsByTextId("ErrorCode_600064_Text", Array.Empty<object>());
			return;
		}
		LoadingModel.Instance.SetSpecifiedLoadingConfigId(new int?(this.CurrentLevelData.LoadingId));
		FightPhotoController.Instance.EnterFightPhotoDungeonDirectly(this.ActivityData.Id, this.CurrentLevelData.LevelId, this.CurrentLevelData.InstanceId, this.CurrentRoleList.ToArray()).Forget();
	}

	// Token: 0x060054C3 RID: 21699 RVA: 0x001BF38B File Offset: 0x001BD58B
	private void OnRefreshFightPhotoLevelRedDot()
	{
		this.NoCircleAttachView.GetCurrentSelectItem().RefreshRedDot();
	}

	// Token: 0x060054C4 RID: 21700 RVA: 0x001BF39D File Offset: 0x001BD59D
	private void OnRewardBtnClick()
	{
		UiManager.Instance.OpenView(EUiViewName.FightPhotoRewardView, this.ActivityData, null);
	}

	// Token: 0x060054C5 RID: 21701 RVA: 0x001BF3B5 File Offset: 0x001BD5B5
	private void OnCloseBtnClick()
	{
		base.CloseMe(null);
	}

	// Token: 0x060054C6 RID: 21702 RVA: 0x001BF3C0 File Offset: 0x001BD5C0
	[return: Nullable(new byte[]
	{
		2,
		1
	})]
	public override UUIItem[] GetGuideUiItemAndUiItemForShowEx(string[] configParams)
	{
		if (!(configParams[0] == "Difficult"))
		{
			return null;
		}
		GenericLayout<FightPhotoLevelItem, FightPhotoLevelData> levelLayout = this.LevelLayout;
		UUIItem uuiitem = (levelLayout != null) ? levelLayout.GetItemByIndex(1) : null;
		if (uuiitem == null)
		{
			return null;
		}
		return new UUIItem[]
		{
			uuiitem,
			uuiitem
		};
	}

	// Token: 0x04003B1E RID: 15134
	private const int TEAM_MAX_NUMBER = 3;

	// Token: 0x04003B1F RID: 15135
	[Nullable(2)]
	private FightPhotoActivityData ActivityData;

	// Token: 0x04003B20 RID: 15136
	[Nullable(2)]
	private FightPhotoLevelGroupData CurrentLevelGroupData;

	// Token: 0x04003B21 RID: 15137
	[Nullable(2)]
	private FightPhotoLevelData CurrentLevelData;

	// Token: 0x04003B22 RID: 15138
	private List<int> CurrentRoleList = new List<int>();

	// Token: 0x04003B23 RID: 15139
	private bool IsCurrentLevelGroupUnlock;

	// Token: 0x04003B24 RID: 15140
	private bool IsQuickRoleSelectViewOpen;

	// Token: 0x04003B25 RID: 15141
	private int SelectedIndex = -1;

	// Token: 0x04003B26 RID: 15142
	[Nullable(2)]
	private PopupCaptionItem CaptionItem;

	// Token: 0x04003B27 RID: 15143
	[Nullable(2)]
	private FunctionalPanelConditionLock PanelLock;

	// Token: 0x04003B28 RID: 15144
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private NoCircleAttachView<FightPhotoLevelGroupData, FightPhotoLevelGroupItem> NoCircleAttachView;

	// Token: 0x04003B29 RID: 15145
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private GenericLayout<FightPhotoLevelItem, FightPhotoLevelData> LevelLayout;

	// Token: 0x04003B2A RID: 15146
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private GenericLayout<FightPhotoTaskTargetItem, string> TaskTargetLayout;

	// Token: 0x04003B2B RID: 15147
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private GenericLayout<FightPhotoRoleItem, int> RoleLayout;

	// Token: 0x02006A1B RID: 27163
	[NullableContext(0)]
	private enum EComponents
	{
		// Token: 0x04022EB3 RID: 143027
		ItemCaption,
		// Token: 0x04022EB4 RID: 143028
		TextureRole,
		// Token: 0x04022EB5 RID: 143029
		TextName,
		// Token: 0x04022EB6 RID: 143030
		TextureLastRoleAni,
		// Token: 0x04022EB7 RID: 143031
		TextLastNameAni,
		// Token: 0x04022EB8 RID: 143032
		ItemDrag,
		// Token: 0x04022EB9 RID: 143033
		ItemLevelGroupContent,
		// Token: 0x04022EBA RID: 143034
		ItemLevelGroup,
		// Token: 0x04022EBB RID: 143035
		BtnReward,
		// Token: 0x04022EBC RID: 143036
		TextLevelGName,
		// Token: 0x04022EBD RID: 143037
		ItemLockPanel,
		// Token: 0x04022EBE RID: 143038
		ItemUnlockPanel,
		// Token: 0x04022EBF RID: 143039
		LayoutLevel,
		// Token: 0x04022EC0 RID: 143040
		ItemContent,
		// Token: 0x04022EC1 RID: 143041
		TextTargetRole,
		// Token: 0x04022EC2 RID: 143042
		LayoutTaskTarget,
		// Token: 0x04022EC3 RID: 143043
		ItemTaskTarget,
		// Token: 0x04022EC4 RID: 143044
		LayoutRole,
		// Token: 0x04022EC5 RID: 143045
		ItemRole,
		// Token: 0x04022EC6 RID: 143046
		BtnGoto,
		// Token: 0x04022EC7 RID: 143047
		ItemRedPoint,
		// Token: 0x04022EC8 RID: 143048
		TextReward,
		// Token: 0x04022EC9 RID: 143049
		ArtTextReward1,
		// Token: 0x04022ECA RID: 143050
		ArtTextReward2,
		// Token: 0x04022ECB RID: 143051
		ArtTextReward3,
		// Token: 0x04022ECC RID: 143052
		ArtTextReward4,
		// Token: 0x04022ECD RID: 143053
		ItemLockTip,
		// Token: 0x04022ECE RID: 143054
		TextLock,
		// Token: 0x04022ECF RID: 143055
		TextureLastRole
	}
}
