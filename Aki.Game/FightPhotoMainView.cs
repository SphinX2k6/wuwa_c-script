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

// Token: 0x0200127C RID: 4732
[NullableContext(1)]
[Nullable(0)]
public class FightPhotoMainView : UiTickViewBase
{
	// Token: 0x06008111 RID: 33041 RVA: 0x001B5860 File Offset: 0x001B3A60
	public FightPhotoMainView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x06008112 RID: 33042 RVA: 0x001B587C File Offset: 0x001B3A7C
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

	// Token: 0x06008113 RID: 33043 RVA: 0x001B5B64 File Offset: 0x001B3D64
	protected override UniTask OnBeforeStartAsync()
	{
		FightPhotoMainView.<OnBeforeStartAsync>d__17 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<FightPhotoMainView.<OnBeforeStartAsync>d__17>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06008114 RID: 33044 RVA: 0x001B5BA8 File Offset: 0x001B3DA8
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

	// Token: 0x06008115 RID: 33045 RVA: 0x001B5CC1 File Offset: 0x001B3EC1
	protected override void OnAddEventListener()
	{
		EventSystem.Instance.Add(EEventName.OnRefreshFightPhotoLevelRedDot, new Action(this.OnRefreshFightPhotoLevelRedDot));
	}

	// Token: 0x06008116 RID: 33046 RVA: 0x001B5CE0 File Offset: 0x001B3EE0
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

	// Token: 0x06008117 RID: 33047 RVA: 0x001B5DF7 File Offset: 0x001B3FF7
	protected override void OnAfterShow()
	{
		if (this.ActivityData.IsNeedShowTip)
		{
			ScrollingTipsController.Instance.ShowTipsByTextId("FightPhotoUnlockNewLevel", Array.Empty<object>());
			this.ActivityData.IsNeedShowTip = false;
		}
	}

	// Token: 0x06008118 RID: 33048 RVA: 0x001B5E28 File Offset: 0x001B4028
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

	// Token: 0x06008119 RID: 33049 RVA: 0x001B5EAC File Offset: 0x001B40AC
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

	// Token: 0x0600811A RID: 33050 RVA: 0x001B5FE4 File Offset: 0x001B41E4
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

	// Token: 0x0600811B RID: 33051 RVA: 0x001B6146 File Offset: 0x001B4346
	protected override void OnRemoveEventListener()
	{
		EventSystem.Instance.Remove(EEventName.OnRefreshFightPhotoLevelRedDot, new Action(this.OnRefreshFightPhotoLevelRedDot));
	}

	// Token: 0x0600811C RID: 33052 RVA: 0x001B6164 File Offset: 0x001B4364
	protected override void OnBeforeDestroy()
	{
		InstanceDungeonEntranceModel.Instance.SelectInstanceId = 0;
	}

	// Token: 0x0600811D RID: 33053 RVA: 0x001B6174 File Offset: 0x001B4374
	private FightPhotoLevelGroupItem CreateNoCircleAttachItem(AActor actor, int index, int showNum)
	{
		FightPhotoLevelGroupItem fightPhotoLevelGroupItem = new FightPhotoLevelGroupItem(actor);
		fightPhotoLevelGroupItem.CreateByActorAsync(actor, null, false).Forget();
		fightPhotoLevelGroupItem.OnToggleClickCallback = new Action<int, FightPhotoLevelGroupData>(this.OnItemClick);
		fightPhotoLevelGroupItem.OnSelectCallback = new Action<int, FightPhotoLevelGroupData>(this.OnItemSelectCallback);
		fightPhotoLevelGroupItem.CheckToggleCanClick = new Func<bool>(this.CheckToggleCanClick);
		return fightPhotoLevelGroupItem;
	}

	// Token: 0x0600811E RID: 33054 RVA: 0x001B61CB File Offset: 0x001B43CB
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

	// Token: 0x0600811F RID: 33055 RVA: 0x001B61EC File Offset: 0x001B43EC
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

	// Token: 0x06008120 RID: 33056 RVA: 0x001B626C File Offset: 0x001B446C
	private bool CheckToggleCanClick()
	{
		return !this.IsQuickRoleSelectViewOpen && !this.NoCircleAttachView.MovingState();
	}

	// Token: 0x06008121 RID: 33057 RVA: 0x001B6286 File Offset: 0x001B4486
	private FightPhotoLevelItem CreateLevelItem()
	{
		return new FightPhotoLevelItem
		{
			OnToggleCallBack = new Action<FightPhotoLevelData>(this.OnLevelItemClick),
			CheckToggleCanClick = new Func<bool>(this.CheckLevelToggleCanClick)
		};
	}

	// Token: 0x06008122 RID: 33058 RVA: 0x001B62B1 File Offset: 0x001B44B1
	private bool CheckLevelToggleCanClick()
	{
		return !this.IsQuickRoleSelectViewOpen;
	}

	// Token: 0x06008123 RID: 33059 RVA: 0x001B62BC File Offset: 0x001B44BC
	private void OnLevelItemClick(FightPhotoLevelData data)
	{
		base.PlaySequence("InfoSwitch", null, false);
		InstanceDungeonEntranceModel.Instance.SelectInstanceId = data.InstanceId;
		this.LevelLayout.SelectGridProxyByKey(data, false);
		this.RefreshRightPanel(data);
	}

	// Token: 0x06008124 RID: 33060 RVA: 0x001B62EF File Offset: 0x001B44EF
	private FightPhotoTaskTargetItem CreateTaskTargetItem()
	{
		return new FightPhotoTaskTargetItem();
	}

	// Token: 0x06008125 RID: 33061 RVA: 0x001B62F6 File Offset: 0x001B44F6
	private FightPhotoRoleItem CreateRoleItem()
	{
		return new FightPhotoRoleItem
		{
			OnBtnClickCallback = new Action<int>(this.OnRoleBtnClick)
		};
	}

	// Token: 0x06008126 RID: 33062 RVA: 0x001B6310 File Offset: 0x001B4510
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

	// Token: 0x06008127 RID: 33063 RVA: 0x001B6456 File Offset: 0x001B4656
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

	// Token: 0x06008128 RID: 33064 RVA: 0x001B6484 File Offset: 0x001B4684
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

	// Token: 0x06008129 RID: 33065 RVA: 0x001B64C4 File Offset: 0x001B46C4
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

	// Token: 0x0600812A RID: 33066 RVA: 0x001B65C4 File Offset: 0x001B47C4
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

	// Token: 0x0600812B RID: 33067 RVA: 0x001B6638 File Offset: 0x001B4838
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

	// Token: 0x0600812C RID: 33068 RVA: 0x001B66BB File Offset: 0x001B48BB
	private void OnRefreshFightPhotoLevelRedDot()
	{
		this.NoCircleAttachView.GetCurrentSelectItem().RefreshRedDot();
	}

	// Token: 0x0600812D RID: 33069 RVA: 0x001B66CD File Offset: 0x001B48CD
	private void OnRewardBtnClick()
	{
		UiManager.Instance.OpenView(EUiViewName.FightPhotoRewardView, this.ActivityData, null);
	}

	// Token: 0x0600812E RID: 33070 RVA: 0x001B66E5 File Offset: 0x001B48E5
	private void OnCloseBtnClick()
	{
		base.CloseMe(null);
	}

	// Token: 0x0600812F RID: 33071 RVA: 0x001B66F0 File Offset: 0x001B48F0
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

	// Token: 0x04003A86 RID: 14982
	private const int TEAM_MAX_NUMBER = 3;

	// Token: 0x04003A87 RID: 14983
	[Nullable(2)]
	private FightPhotoActivityData ActivityData;

	// Token: 0x04003A88 RID: 14984
	[Nullable(2)]
	private FightPhotoLevelGroupData CurrentLevelGroupData;

	// Token: 0x04003A89 RID: 14985
	[Nullable(2)]
	private FightPhotoLevelData CurrentLevelData;

	// Token: 0x04003A8A RID: 14986
	private List<int> CurrentRoleList = new List<int>();

	// Token: 0x04003A8B RID: 14987
	private bool IsCurrentLevelGroupUnlock;

	// Token: 0x04003A8C RID: 14988
	private bool IsQuickRoleSelectViewOpen;

	// Token: 0x04003A8D RID: 14989
	private int SelectedIndex = -1;

	// Token: 0x04003A8E RID: 14990
	[Nullable(2)]
	private PopupCaptionItem CaptionItem;

	// Token: 0x04003A8F RID: 14991
	[Nullable(2)]
	private FunctionalPanelConditionLock PanelLock;

	// Token: 0x04003A90 RID: 14992
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private NoCircleAttachView<FightPhotoLevelGroupData, FightPhotoLevelGroupItem> NoCircleAttachView;

	// Token: 0x04003A91 RID: 14993
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private GenericLayout<FightPhotoLevelItem, FightPhotoLevelData> LevelLayout;

	// Token: 0x04003A92 RID: 14994
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private GenericLayout<FightPhotoTaskTargetItem, string> TaskTargetLayout;

	// Token: 0x04003A93 RID: 14995
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private GenericLayout<FightPhotoRoleItem, int> RoleLayout;

	// Token: 0x02007890 RID: 30864
	[NullableContext(0)]
	private enum EComponents
	{
		// Token: 0x04027B82 RID: 162690
		ItemCaption,
		// Token: 0x04027B83 RID: 162691
		TextureRole,
		// Token: 0x04027B84 RID: 162692
		TextName,
		// Token: 0x04027B85 RID: 162693
		TextureLastRoleAni,
		// Token: 0x04027B86 RID: 162694
		TextLastNameAni,
		// Token: 0x04027B87 RID: 162695
		ItemDrag,
		// Token: 0x04027B88 RID: 162696
		ItemLevelGroupContent,
		// Token: 0x04027B89 RID: 162697
		ItemLevelGroup,
		// Token: 0x04027B8A RID: 162698
		BtnReward,
		// Token: 0x04027B8B RID: 162699
		TextLevelGName,
		// Token: 0x04027B8C RID: 162700
		ItemLockPanel,
		// Token: 0x04027B8D RID: 162701
		ItemUnlockPanel,
		// Token: 0x04027B8E RID: 162702
		LayoutLevel,
		// Token: 0x04027B8F RID: 162703
		ItemContent,
		// Token: 0x04027B90 RID: 162704
		TextTargetRole,
		// Token: 0x04027B91 RID: 162705
		LayoutTaskTarget,
		// Token: 0x04027B92 RID: 162706
		ItemTaskTarget,
		// Token: 0x04027B93 RID: 162707
		LayoutRole,
		// Token: 0x04027B94 RID: 162708
		ItemRole,
		// Token: 0x04027B95 RID: 162709
		BtnGoto,
		// Token: 0x04027B96 RID: 162710
		ItemRedPoint,
		// Token: 0x04027B97 RID: 162711
		TextReward,
		// Token: 0x04027B98 RID: 162712
		ArtTextReward1,
		// Token: 0x04027B99 RID: 162713
		ArtTextReward2,
		// Token: 0x04027B9A RID: 162714
		ArtTextReward3,
		// Token: 0x04027B9B RID: 162715
		ArtTextReward4,
		// Token: 0x04027B9C RID: 162716
		ItemLockTip,
		// Token: 0x04027B9D RID: 162717
		TextLock,
		// Token: 0x04027B9E RID: 162718
		TextureLastRole
	}
}
