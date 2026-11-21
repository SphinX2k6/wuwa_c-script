using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using AkiClient.Game.Aki.Character.Role.Common.Data.Enum;
using AkiClient.Game.Aki.Data.UiRoleCamera.Struct;
using CSharpScript.Core.Common;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Effect;
using CSharpScript.Game.InputSetting;
using CSharpScript.Game.Module.RoleUi.Component;
using CSharpScript.Game.Module.UiCamera;
using CSharpScript.Game.Module.UiComponent;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Render;
using CSharpScript.Game.Ui;
using CSharpScript.Game.Utils;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.RoleUi
{
	// Token: 0x02003C95 RID: 15509
	[NullableContext(1)]
	[Nullable(0)]
	public class RoleRootView : UiViewBase
	{
		// Token: 0x06027A9D RID: 162461 RVA: 0x00B1B97C File Offset: 0x00B19B7C
		public RoleRootView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x17005147 RID: 20807
		// (get) Token: 0x06027A9E RID: 162462 RVA: 0x00B1B9CB File Offset: 0x00B19BCB
		private bool IsLock
		{
			get
			{
				return this.Operating;
			}
		}

		// Token: 0x06027A9F RID: 162463 RVA: 0x00B1B9D3 File Offset: 0x00B19BD3
		private void Lock()
		{
			this.Operating = true;
		}

		// Token: 0x06027AA0 RID: 162464 RVA: 0x00B1B9DC File Offset: 0x00B19BDC
		private void Unlock()
		{
			this.Operating = false;
			if (this.ViewOperationQueue.Size == 0)
			{
				return;
			}
			OperationParam operationParam = this.ViewOperationQueue.Pop();
			if (operationParam == null)
			{
				return;
			}
			switch (operationParam.OperationType)
			{
			case EOperationType.RefreshRoleList:
				this.RefreshRoleList();
				return;
			case EOperationType.RefreshTabList:
				this.RefreshTabList();
				return;
			case EOperationType.OnRoleSelect:
				this.OnRoleSelect(0);
				return;
			default:
				return;
			}
		}

		// Token: 0x06027AA1 RID: 162465 RVA: 0x00B1BA40 File Offset: 0x00B19C40
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIButtonComponent)),
				new ValueTuple<int, Type>(1, typeof(UUIButtonComponent)),
				new ValueTuple<int, Type>(2, typeof(UUIItem)),
				new ValueTuple<int, Type>(3, typeof(UUIItem)),
				new ValueTuple<int, Type>(4, typeof(UUIItem)),
				new ValueTuple<int, Type>(6, typeof(UUIDraggableComponent)),
				new ValueTuple<int, Type>(8, typeof(UUIItem)),
				new ValueTuple<int, Type>(9, typeof(UUIItem)),
				new ValueTuple<int, Type>(10, typeof(UUIItem)),
				new ValueTuple<int, Type>(12, typeof(UUIItem)),
				new ValueTuple<int, Type>(13, typeof(UUIExtendToggle)),
				new ValueTuple<int, Type>(14, typeof(UUIButtonComponent)),
				new ValueTuple<int, Type>(15, typeof(UUIItem))
			};
			this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
			{
				new ValueTuple<int, Delegate>(1, new Action(this.RoleListClick)),
				new ValueTuple<int, Delegate>(13, new Action<EToggleState>(this.OnSkillShowTagToggleClick)),
				new ValueTuple<int, Delegate>(14, new Action(this.OnSkillShowTagHelpButtonClick))
			};
		}

		// Token: 0x06027AA2 RID: 162466 RVA: 0x00B1BBD4 File Offset: 0x00B19DD4
		protected override UniTask OnBeforeStartAsync()
		{
			RoleRootView.<OnBeforeStartAsync>d__31 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<RoleRootView.<OnBeforeStartAsync>d__31>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06027AA3 RID: 162467 RVA: 0x00B1BC18 File Offset: 0x00B19E18
		private UniTask InitRoleDevelopEntranceItem()
		{
			RoleRootView.<InitRoleDevelopEntranceItem>d__32 <InitRoleDevelopEntranceItem>d__;
			<InitRoleDevelopEntranceItem>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitRoleDevelopEntranceItem>d__.<>4__this = this;
			<InitRoleDevelopEntranceItem>d__.<>1__state = -1;
			<InitRoleDevelopEntranceItem>d__.<>t__builder.Start<RoleRootView.<InitRoleDevelopEntranceItem>d__32>(ref <InitRoleDevelopEntranceItem>d__);
			return <InitRoleDevelopEntranceItem>d__.<>t__builder.Task;
		}

		// Token: 0x06027AA4 RID: 162468 RVA: 0x00B1BC5C File Offset: 0x00B19E5C
		private UniTask TryRequestTrialRoleInfo()
		{
			RoleRootView.<TryRequestTrialRoleInfo>d__33 <TryRequestTrialRoleInfo>d__;
			<TryRequestTrialRoleInfo>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<TryRequestTrialRoleInfo>d__.<>4__this = this;
			<TryRequestTrialRoleInfo>d__.<>1__state = -1;
			<TryRequestTrialRoleInfo>d__.<>t__builder.Start<RoleRootView.<TryRequestTrialRoleInfo>d__33>(ref <TryRequestTrialRoleInfo>d__);
			return <TryRequestTrialRoleInfo>d__.<>t__builder.Task;
		}

		// Token: 0x06027AA5 RID: 162469 RVA: 0x00B1BCA0 File Offset: 0x00B19EA0
		private void UpdateTrialRoleResonanceData(List<int> trialRoleIdList)
		{
			foreach (int num in trialRoleIdList)
			{
				RoleDataBase roleDataById = RoleModel.Instance.GetRoleDataById(num, true);
				if (roleDataById == null)
				{
					Log instance = Log.Instance;
					ELogModule module = ELogModule.Role;
					ELogAuthor author = ELogAuthor.CXJ;
					string message = "角色数据不存在";
					ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("角色Id", num);
					instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				}
				else
				{
					int parentId = RoleConfig.Instance.GetTrialRoleConfig(num).Value.ParentId;
					RoleDataBase roleDataById2 = RoleModel.Instance.GetRoleDataById(parentId, true);
					roleDataById.GetResonanceData().CopyFrom(roleDataById2.GetResonanceData());
				}
			}
		}

		// Token: 0x06027AA6 RID: 162470 RVA: 0x00B1BD6C File Offset: 0x00B19F6C
		private void ClearTrialRoleResonanceData()
		{
			List<int> list = new List<int>();
			foreach (int num in this.RoleViewAgent.GetRoleIdList(null))
			{
				if (RoleUtils.IsTrialRole(num))
				{
					list.Add(num);
				}
			}
			foreach (int num2 in list)
			{
				RoleDataBase roleDataById = RoleModel.Instance.GetRoleDataById(num2, true);
				if (roleDataById == null)
				{
					Log instance = Log.Instance;
					ELogModule module = ELogModule.Role;
					ELogAuthor author = ELogAuthor.CXJ;
					string message = "角色数据不存在";
					ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("角色Id", num2);
					instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				}
				else
				{
					roleDataById.GetResonanceData().Clear();
				}
			}
		}

		// Token: 0x06027AA7 RID: 162471 RVA: 0x00B1BE54 File Offset: 0x00B1A054
		private void HandleLoadScene()
		{
			if (!this.CanHandleLoadScene)
			{
				TsUiSceneRoleActor roleSystemRoleActor = UiSceneManager.Instance.GetRoleSystemRoleActor();
				if (roleSystemRoleActor != null)
				{
					this.TsUiSceneRoleActor = roleSystemRoleActor;
				}
				return;
			}
			this.CanHandleLoadScene = false;
			if (this.TsUiSceneRoleActor == null)
			{
				this.TsUiSceneRoleActor = UiSceneManager.Instance.InitRoleSystemRoleActor(EUiModelUseWay.RoleInRoleView);
			}
			this.LoadFloorEffect();
			UiModelBase model = this.TsUiSceneRoleActor.Model;
			UiModelActorComponent uiModelActorComponent = (model != null) ? model.CheckGetComponent<UiModelActorComponent>() : null;
			if (uiModelActorComponent == null)
			{
				return;
			}
			uiModelActorComponent.SetTransformByTag("RoleCase");
		}

		// Token: 0x06027AA8 RID: 162472 RVA: 0x00B1BECB File Offset: 0x00B1A0CB
		protected override void OnHandleLoadScene()
		{
			this.HandleLoadScene();
		}

		// Token: 0x06027AA9 RID: 162473 RVA: 0x00B1BED4 File Offset: 0x00B1A0D4
		protected override void OnStart()
		{
			EventSystem.Instance.Add<EUiTabViewName, int>(EEventName.SelectRoleTabOutside, new Action<EUiTabViewName, int>(this.OnSelectRoleTabOutside));
			EventSystem.Instance.Add(EEventName.RoleDevTargetRoleIdChange, new Action(this.OnRoleDevTargetRoleIdChange));
			this.RefreshRoleDevButtonVisibility();
			this.RefreshSkillShowTagRoot();
		}

		// Token: 0x06027AAA RID: 162474 RVA: 0x00B1BF25 File Offset: 0x00B1A125
		protected override void OnBeforeShow()
		{
			this.HandleLoadScene();
			this.RefreshRoleList();
			TabViewComponent<UiDynamicTab> tabViewComponent = this.TabViewComponent;
			if (tabViewComponent == null)
			{
				return;
			}
			tabViewComponent.SetCurrentTabViewState(true);
		}

		// Token: 0x06027AAB RID: 162475 RVA: 0x00B1BF44 File Offset: 0x00B1A144
		protected override void OnAfterShow()
		{
			this.TryShowNoPhantomEquippedConfirm();
		}

		// Token: 0x06027AAC RID: 162476 RVA: 0x00B1BF4C File Offset: 0x00B1A14C
		private void TryShowNoPhantomEquippedConfirm()
		{
			if (!MainRoleModel.Instance.IsElementChanged())
			{
				return;
			}
			int valueOrDefault = RoleModel.Instance.GetCurSelectMainRoleId().GetValueOrDefault();
			if (valueOrDefault != 0 && !this.HasAnyPhantomEquipped(valueOrDefault))
			{
				this.ShowNoPhantomEquippedConfirm();
			}
			MainRoleModel.Instance.ResetElementChangeState();
		}

		// Token: 0x06027AAD RID: 162477 RVA: 0x00B1BF95 File Offset: 0x00B1A195
		private bool HasAnyPhantomEquipped(int roleId)
		{
			return roleId == 0 || PhantomBattleModel.Instance.GetBattleDataById(roleId).GetEquippedNum() > 0;
		}

		// Token: 0x06027AAE RID: 162478 RVA: 0x00B1BFB0 File Offset: 0x00B1A1B0
		private void ShowNoPhantomEquippedConfirm()
		{
			ConfirmBoxDataNew confirmBoxDataNew = new ConfirmBoxDataNew((EConfirmBoxConfigId)591);
			confirmBoxDataNew.FunctionMap[2] = new Action(this.GoEquipPhantom);
			ConfirmBoxController.Instance.ShowConfirmBoxNew(confirmBoxDataNew);
		}

		// Token: 0x06027AAF RID: 162479 RVA: 0x00B1BFEC File Offset: 0x00B1A1EC
		private void GoEquipPhantom()
		{
			int index = 0;
			for (int i = 0; i < this.TabDataList.Count; i++)
			{
				if (this.TabDataList[i].ChildViewName == EUiTabViewName.RolePhantomTabView)
				{
					index = i;
					break;
				}
			}
			this.TabComponent.SelectToggleByIndex(index, false);
		}

		// Token: 0x06027AB0 RID: 162480 RVA: 0x00B1C048 File Offset: 0x00B1A248
		protected void RefreshRoleList()
		{
			if (this.IsLock)
			{
				OperationParam element = new OperationParam(EOperationType.RefreshRoleList, null);
				this.ViewOperationQueue.Push(element);
				return;
			}
			this.Lock();
			this.RefreshRoleListAsync().ContinueWith(new Action(this.Unlock));
		}

		// Token: 0x06027AB1 RID: 162481 RVA: 0x00B1C090 File Offset: 0x00B1A290
		protected UniTask RefreshRoleListAsync()
		{
			RoleRootView.<RefreshRoleListAsync>d__46 <RefreshRoleListAsync>d__;
			<RefreshRoleListAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<RefreshRoleListAsync>d__.<>4__this = this;
			<RefreshRoleListAsync>d__.<>1__state = -1;
			<RefreshRoleListAsync>d__.<>t__builder.Start<RoleRootView.<RefreshRoleListAsync>d__46>(ref <RefreshRoleListAsync>d__);
			return <RefreshRoleListAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06027AB2 RID: 162482 RVA: 0x00B1C0D4 File Offset: 0x00B1A2D4
		private UniTask UpdateRoleListAndScrollAsync(int targetRoleId)
		{
			RoleRootView.<UpdateRoleListAndScrollAsync>d__47 <UpdateRoleListAndScrollAsync>d__;
			<UpdateRoleListAndScrollAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<UpdateRoleListAndScrollAsync>d__.<>4__this = this;
			<UpdateRoleListAndScrollAsync>d__.targetRoleId = targetRoleId;
			<UpdateRoleListAndScrollAsync>d__.<>1__state = -1;
			<UpdateRoleListAndScrollAsync>d__.<>t__builder.Start<RoleRootView.<UpdateRoleListAndScrollAsync>d__47>(ref <UpdateRoleListAndScrollAsync>d__);
			return <UpdateRoleListAndScrollAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06027AB3 RID: 162483 RVA: 0x00B1C120 File Offset: 0x00B1A320
		protected void RefreshTabList()
		{
			if (this.IsLock)
			{
				OperationParam element = new OperationParam(EOperationType.RefreshTabList, null);
				this.ViewOperationQueue.Push(element);
				return;
			}
			this.Lock();
			this.RefreshTabListAsync().ContinueWith(new Action(this.Unlock));
		}

		// Token: 0x06027AB4 RID: 162484 RVA: 0x00B1C168 File Offset: 0x00B1A368
		protected UniTask RefreshTabListAsync()
		{
			RoleRootView.<RefreshTabListAsync>d__49 <RefreshTabListAsync>d__;
			<RefreshTabListAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<RefreshTabListAsync>d__.<>4__this = this;
			<RefreshTabListAsync>d__.<>1__state = -1;
			<RefreshTabListAsync>d__.<>t__builder.Start<RoleRootView.<RefreshTabListAsync>d__49>(ref <RefreshTabListAsync>d__);
			return <RefreshTabListAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06027AB5 RID: 162485 RVA: 0x00B1C1AC File Offset: 0x00B1A3AC
		private static bool HasTabIdChanged(IReadOnlyList<UiDynamicTab> oldTabDataList, IReadOnlyList<UiDynamicTab> newTabDataList)
		{
			int num = Math.Min(oldTabDataList.Count, newTabDataList.Count);
			for (int i = 0; i < num; i++)
			{
				if (oldTabDataList[i].Id != newTabDataList[i].Id)
				{
					return true;
				}
			}
			return oldTabDataList.Count != newTabDataList.Count;
		}

		// Token: 0x06027AB6 RID: 162486 RVA: 0x00B1C20C File Offset: 0x00B1A40C
		protected void OnRoleSelect(int i = 0)
		{
			if (this.IsLock)
			{
				OperationParam element = new OperationParam(EOperationType.OnRoleSelect, null);
				this.ViewOperationQueue.Push(element);
				return;
			}
			this.Lock();
			this.OnRoleSelectAsync().ContinueWith(new Action(this.Unlock));
		}

		// Token: 0x06027AB7 RID: 162487 RVA: 0x00B1C254 File Offset: 0x00B1A454
		protected UniTask OnRoleSelectAsync()
		{
			RoleRootView.<OnRoleSelectAsync>d__52 <OnRoleSelectAsync>d__;
			<OnRoleSelectAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnRoleSelectAsync>d__.<>4__this = this;
			<OnRoleSelectAsync>d__.<>1__state = -1;
			<OnRoleSelectAsync>d__.<>t__builder.Start<RoleRootView.<OnRoleSelectAsync>d__52>(ref <OnRoleSelectAsync>d__);
			return <OnRoleSelectAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06027AB8 RID: 162488 RVA: 0x00B1C297 File Offset: 0x00B1A497
		protected void OnSelectRoleTabOutside(EUiTabViewName tabViewName, int roleId)
		{
			this.Lock();
			this.SelectRoleTabOutSide(tabViewName, roleId).ContinueWith(new Action(this.Unlock));
		}

		// Token: 0x06027AB9 RID: 162489 RVA: 0x00B1C2BC File Offset: 0x00B1A4BC
		protected UniTask SelectRoleTabOutSide(EUiTabViewName tabViewName, int roleId)
		{
			RoleRootView.<SelectRoleTabOutSide>d__54 <SelectRoleTabOutSide>d__;
			<SelectRoleTabOutSide>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<SelectRoleTabOutSide>d__.<>4__this = this;
			<SelectRoleTabOutSide>d__.tabViewName = tabViewName;
			<SelectRoleTabOutSide>d__.roleId = roleId;
			<SelectRoleTabOutSide>d__.<>1__state = -1;
			<SelectRoleTabOutSide>d__.<>t__builder.Start<RoleRootView.<SelectRoleTabOutSide>d__54>(ref <SelectRoleTabOutSide>d__);
			return <SelectRoleTabOutSide>d__.<>t__builder.Task;
		}

		// Token: 0x06027ABA RID: 162490 RVA: 0x00B1C310 File Offset: 0x00B1A510
		protected UniTask SelectRoleOutside(int roleId)
		{
			RoleRootView.<SelectRoleOutside>d__55 <SelectRoleOutside>d__;
			<SelectRoleOutside>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<SelectRoleOutside>d__.<>4__this = this;
			<SelectRoleOutside>d__.roleId = roleId;
			<SelectRoleOutside>d__.<>1__state = -1;
			<SelectRoleOutside>d__.<>t__builder.Start<RoleRootView.<SelectRoleOutside>d__55>(ref <SelectRoleOutside>d__);
			return <SelectRoleOutside>d__.<>t__builder.Task;
		}

		// Token: 0x06027ABB RID: 162491 RVA: 0x00B1C35C File Offset: 0x00B1A55C
		protected void InitTabComponent()
		{
			CommonTabComponentData<RoleTabItem> data = new CommonTabComponentData<RoleTabItem>(new Func<UUIItem, int?, RoleTabItem>(this.ProxyCreate), new Action<int>(this.ToggleCallBack), new Func<int, CommonTabData>(this.GetCommonData));
			this.TabComponent = new TabComponentWithCaptionItem<RoleTabItem>(base.GetItem(2), data, new Action(this.CloseClick), false);
			this.LastClickTime = null;
			this.TabComponent.SetCanChange(new Func<int, bool?, bool>(this.CanToggleChange));
			this.TabViewComponent = new TabViewComponent<UiDynamicTab>(base.GetItem(4), EKeyMode.Default);
		}

		// Token: 0x06027ABC RID: 162492 RVA: 0x00B1C3EC File Offset: 0x00B1A5EC
		protected bool CanToggleChange(int index, bool? forceSwitch = false)
		{
			if (forceSwitch.GetValueOrDefault())
			{
				return true;
			}
			if (this.GetCurrentTabCanNotShowByRoleType(index))
			{
				ScrollingTipsController.Instance.ShowTipsByTextId("Text_RoleInformalTrialTips_Text", Array.Empty<object>());
				return false;
			}
			if (Info.Instance.IsInGamepad())
			{
				return true;
			}
			int? intConfig = ConfigCommonParamById.GetIntConfig("panel_interval_time");
			if (this.LastClickTime != null)
			{
				double? num = Time.Instance.Now - this.LastClickTime;
				int? num2 = intConfig;
				double? num3 = (num2 != null) ? new double?((double)num2.GetValueOrDefault()) : null;
				if (!(num.GetValueOrDefault() >= num3.GetValueOrDefault() & (num != null & num3 != null)))
				{
					return false;
				}
			}
			return true;
		}

		// Token: 0x06027ABD RID: 162493 RVA: 0x00B1C4D4 File Offset: 0x00B1A6D4
		private bool GetCurrentTabCanNotShowByRoleType(int index)
		{
			if (this.TabDataList.Count <= 0)
			{
				return false;
			}
			int curSelectRoleId = this.RoleViewAgent.GetCurSelectRoleId();
			RoleInfo? roleConfig = RoleConfig.Instance.GetRoleConfig(curSelectRoleId);
			ERoleSystemMode roleSystemMode = this.RoleViewAgent.GetRoleSystemMode();
			return (roleSystemMode == ERoleSystemMode.Trial || roleSystemMode == ERoleSystemMode.SpecialTrial) && roleConfig.Value.RoleType == 5 && this.TabDataList[index].ChildViewName != EUiTabViewName.RoleAttributeTabView && this.TabDataList[index].ChildViewName != EUiTabViewName.RolePhantomTabView && this.TabDataList[index].ChildViewName != EUiTabViewName.RolePreviewAttributeTabView;
		}

		// Token: 0x06027ABE RID: 162494 RVA: 0x00B1C5A4 File Offset: 0x00B1A7A4
		private bool IsConflict(int index)
		{
			if (this.RoleViewAgent.Source == ERoleViewSource.WheelTower)
			{
				int curSelectRoleId = this.RoleViewAgent.GetCurSelectRoleId();
				IConflictInfo conflictInfo = WheelTowerModel.Instance.CheckConflict(curSelectRoleId);
				if (conflictInfo == null)
				{
					return false;
				}
				if ((conflictInfo.WeaponConflict && this.TabDataList[index].Id == 4) || (conflictInfo.PhantomConflict && this.TabDataList[index].Id == 5))
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x06027ABF RID: 162495 RVA: 0x00B1C61D File Offset: 0x00B1A81D
		private RoleTabItem ProxyCreate([Nullable(2)] UUIItem uiItem, int? index)
		{
			return new RoleTabItem
			{
				IsConflict = new Func<int, bool>(this.IsConflict)
			};
		}

		// Token: 0x06027AC0 RID: 162496 RVA: 0x00B1C638 File Offset: 0x00B1A838
		private void ToggleCallBack(int index)
		{
			this.ClickTimes++;
			this.LastClickTime = new double?(Time.Instance.Now);
			UiDynamicTab data = this.TabDataList[index];
			EUiTabViewName euiTabViewName = (EUiTabViewName)data.ChildViewName;
			RoleTabItem tabItemByIndex = this.TabComponent.GetTabItemByIndex(index);
			if (this.CurSelectTabView != null)
			{
				this.RoleViewAgent.SetPreSelectTabName(this.CurSelectTabView);
			}
			this.TabViewComponent.ToggleCallBack(data, euiTabViewName, tabItemByIndex, this.RoleViewAgent, null);
			this.RoleViewAgent.SetCurSelectTabName(euiTabViewName);
			this.CurSelectTabIndex = index;
			this.CurSelectTabView = new EUiTabViewName?(euiTabViewName);
			this.PlayLightSequence(index, this.ClickTimes);
			this.CanCameraInput = this.CheckCanCameraInput();
			this.RefreshTabHelpId(euiTabViewName);
			this.RefreshRoleBackgroundMusicSwitchItem();
			this.RefreshRoleDevButtonVisibility();
			this.RefreshSkillShowTagRoot();
		}

		// Token: 0x06027AC1 RID: 162497 RVA: 0x00B1C720 File Offset: 0x00B1A920
		private void RefreshRoleDevButtonVisibility()
		{
			this.RoleDevelopEntranceItem.RefreshView();
		}

		// Token: 0x06027AC2 RID: 162498 RVA: 0x00B1C730 File Offset: 0x00B1A930
		private void RefreshTabHelpId(string currentTabName)
		{
			TabComponentWithCaptionItem<RoleTabItem> tabComponent = this.TabComponent;
			if (tabComponent != null)
			{
				tabComponent.SetHelpButtonShowState(false);
			}
			if (currentTabName == EUiTabViewName.RolePhantomTabView.ToString())
			{
				TabComponentWithCaptionItem<RoleTabItem> tabComponent2 = this.TabComponent;
				if (tabComponent2 != null)
				{
					tabComponent2.SetHelpButtonCallBack(delegate
					{
						HelpController.Instance.OpenHelpById(PhantomBattleConfig.Instance.GetPhantomEquipHelpGroupId());
					});
				}
				TabComponentWithCaptionItem<RoleTabItem> tabComponent3 = this.TabComponent;
				if (tabComponent3 == null)
				{
					return;
				}
				tabComponent3.SetHelpButtonShowState(true);
			}
		}

		// Token: 0x06027AC3 RID: 162499 RVA: 0x00B1C7A8 File Offset: 0x00B1A9A8
		private void UpdateHomeBtnState()
		{
			if (this.TabComponent == null)
			{
				return;
			}
			bool flag = RoleDefine.RoleViewSourceHideHomeInInstance[this.RoleViewAgent.Source];
			this.TabComponent.SetHomeBtnShowState(!flag || !GameModeController.Instance.IsInInstance());
		}

		// Token: 0x06027AC4 RID: 162500 RVA: 0x00B1C7F4 File Offset: 0x00B1A9F4
		private void PlayLightSequence(int tabIndex, int clickTimes)
		{
			string sequencePath = this.TabDataList[tabIndex].LightSequence;
			ALevelSequenceActor alevelSequenceActor;
			if (this.LevelSequenceActorCache.TryGetValue(tabIndex, out alevelSequenceActor))
			{
				if (this.ShowSequencePlayer != null)
				{
					this.ShowSequencePlayer.Stop();
					this.IsLightSequenceLoop = false;
					this.ShowSequencePlayer = null;
				}
				ULevelSequencePlayer sequencePlayer = alevelSequenceActor.SequencePlayer;
				sequencePlayer.Play();
				this.IsLightSequenceLoop = true;
				this.ShowSequencePlayer = sequencePlayer;
				return;
			}
			int num;
			if (this.LevelSequenceActorLoadStatus.TryGetValue(tabIndex, out num) && num == 1)
			{
				return;
			}
			this.LevelSequenceActorLoadStatus[tabIndex] = 1;
			ResourceSystem.Instance.LoadAsync<ULevelSequence>(sequencePath, delegate([Nullable(2)] ULevelSequence levelSequenceObject, string _)
			{
				if (ObjectUtils.IsValid(levelSequenceObject))
				{
					FMovieSceneSequencePlaybackSettings fmovieSceneSequencePlaybackSettings = new FMovieSceneSequencePlaybackSettings();
					fmovieSceneSequencePlaybackSettings.bRestoreState = true;
					ALevelSequenceActor alevelSequenceActor2 = null;
					ULevelSequencePlayer.CreateLevelSequencePlayer(GlobalData.World, levelSequenceObject, new FMovieSceneSequencePlaybackSettings(), ref alevelSequenceActor2);
					alevelSequenceActor2.PlaybackSettings = fmovieSceneSequencePlaybackSettings;
					alevelSequenceActor2.SetSequence(levelSequenceObject);
					this.LevelSequenceActorCache[tabIndex] = alevelSequenceActor2;
					if (this.ShowSequencePlayer != null)
					{
						this.ShowSequencePlayer.Stop();
						this.IsLightSequenceLoop = false;
						this.ShowSequencePlayer = null;
					}
					if (this.CurSelectTabIndex == tabIndex)
					{
						this.ShowSequencePlayer = alevelSequenceActor2.SequencePlayer;
						alevelSequenceActor2.bOverrideInstanceData = true;
						UDefaultLevelSequenceInstanceData udefaultLevelSequenceInstanceData = alevelSequenceActor2.DefaultInstanceData as UDefaultLevelSequenceInstanceData;
						FTransform transformOrigin = UKismetMathLibrary.Conv_TransformDoubleToTransform(RenderModuleController.Instance.GetKuroCurrentUiSceneTransform().Value);
						udefaultLevelSequenceInstanceData.TransformOrigin = transformOrigin;
						this.ShowSequencePlayer.Play();
						this.IsLightSequenceLoop = true;
					}
				}
				else
				{
					Log instance = Log.Instance;
					ELogModule module = ELogModule.Role;
					ELogAuthor author = ELogAuthor.LZK;
					string message = "加载level sequence失败:";
					ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("sequencePath", sequencePath);
					instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				}
				this.LevelSequenceActorLoadStatus[tabIndex] = 0;
			}, 100, this.MemoryTag);
		}

		// Token: 0x06027AC5 RID: 162501 RVA: 0x00B1C8DA File Offset: 0x00B1AADA
		private void OnInputUiLookUp(float value)
		{
			if (value == 0f || !this.CanCameraInput || !Info.Instance.IsInGamepad())
			{
				return;
			}
			this.UiCameraInputComponent.AddPitchInput(-value);
		}

		// Token: 0x06027AC6 RID: 162502 RVA: 0x00B1C906 File Offset: 0x00B1AB06
		private void OnInputUiTurn(float value)
		{
			if (value == 0f || !this.CanCameraInput || !Info.Instance.IsInGamepad())
			{
				return;
			}
			this.UiCameraInputComponent.AddYawInput(value);
		}

		// Token: 0x06027AC7 RID: 162503 RVA: 0x00B1C931 File Offset: 0x00B1AB31
		private void OnInputUiZoom(string axisName, float value)
		{
			if (value == 0f || !this.CanCameraInput || !Info.Instance.IsInGamepad())
			{
				return;
			}
			this.UiCameraInputComponent.AddZoomInput(value);
		}

		// Token: 0x06027AC8 RID: 162504 RVA: 0x00B1C95C File Offset: 0x00B1AB5C
		private void OnRightStickPress()
		{
			if (!this.CanCameraInput)
			{
				return;
			}
			UiCameraModel instance = UiCameraModel.Instance;
			UiCamera camera = instance.Camera;
			UiCameraHandleData lastHandleData = instance.GetLastHandleData();
			if (camera == null || !camera.IsEntered || camera.CurrentMode != EUiCameraMode.Normal || lastHandleData == null || lastHandleData.ShouldSkipApply())
			{
				return;
			}
			UiCameraNormalMode mode = camera.GetMode<UiCameraNormalMode>();
			if (mode.State != EUiCameraNormalState.Active || mode.IsInputBlocked || mode.TryGetLastAppliedData() != lastHandleData)
			{
				return;
			}
			if (camera.RefreshCameraActor())
			{
				UCineCameraComponent cineCameraComponent = camera.CineCameraComponent;
				if (cineCameraComponent != null && cineCameraComponent.IsValid())
				{
					if (!lastHandleData.Refresh(instance) || lastHandleData.GetUiCameraAnimationConfig() == null)
					{
						return;
					}
					if (!mode.PushCameraHandle(lastHandleData, lastHandleData, true, false, "1001", null))
					{
						Log.Instance.Warn(ELogModule.UiCamera, ELogAuthor.BB, "手柄重置角色Ui镜头失败，当前镜头不可重置", default(ReadOnlySpan<ValueTuple<string, object>>));
					}
					return;
				}
			}
		}

		// Token: 0x06027AC9 RID: 162505 RVA: 0x00B1CA2E File Offset: 0x00B1AC2E
		private void OnTouch(string touchIdName, InputDistributeDefine.ITouchData touchData, InputIdentification _)
		{
			if (!this.CanCameraInput)
			{
				return;
			}
			if (touchData.TouchType == InputDistributeDefine.ETouchType.TouchMove)
			{
				this.TouchMoved();
			}
		}

		// Token: 0x06027ACA RID: 162506 RVA: 0x00B1CA48 File Offset: 0x00B1AC48
		private void TouchMoved()
		{
			if (TouchFingerManager.Instance.GetTouchFingerCount() > 1)
			{
				float fingerExpandCloseValue = TouchFingerManager.Instance.GetFingerExpandCloseValue(EFingerIndex.One, EFingerIndex.Two);
				this.UiCameraInputComponent.AddZoomInput(-fingerExpandCloseValue);
			}
		}

		// Token: 0x06027ACB RID: 162507 RVA: 0x00B1CA7C File Offset: 0x00B1AC7C
		private CommonTabData GetCommonData(int index)
		{
			UiDynamicTab uiDynamicTab = this.TabDataList[index];
			return new CommonTabData(uiDynamicTab.Icon, new CommonTabTitleData(uiDynamicTab.TabName, Array.Empty<object>()), null);
		}

		// Token: 0x06027ACC RID: 162508 RVA: 0x00B1CAB4 File Offset: 0x00B1ACB4
		[return: Nullable(new byte[]
		{
			2,
			1
		})]
		public override UUIItem[] GetGuideUiItemAndUiItemForShowEx(string[] configParams)
		{
			RoleRootView.<>c__DisplayClass73_0 CS$<>8__locals1 = new RoleRootView.<>c__DisplayClass73_0();
			CS$<>8__locals1.<>4__this = this;
			if (this.IsLock)
			{
				Log.Instance.Error(ELogModule.Guide, ELogAuthor.LZK, "异步操作执行过程中不能触发引导", default(ReadOnlySpan<ValueTuple<string, object>>));
				return null;
			}
			if (configParams[0] == "Rover")
			{
				RoleRootView.<>c__DisplayClass73_1 CS$<>8__locals2 = new RoleRootView.<>c__DisplayClass73_1();
				CS$<>8__locals2.CS$<>8__locals1 = CS$<>8__locals1;
				RoleListComponent roleListComponent = this.RoleListComponent;
				int num = (roleListComponent != null) ? roleListComponent.FindDisplayIndex(new Predicate<int>(RoleModel.Instance.IsMainRole)) : -1;
				if (num < 0)
				{
					return null;
				}
				RoleRootView.<>c__DisplayClass73_1 CS$<>8__locals3 = CS$<>8__locals2;
				RoleListComponent roleListComponent2 = this.RoleListComponent;
				RoleListItem targetItem;
				if (roleListComponent2 == null)
				{
					targetItem = null;
				}
				else
				{
					GenericScrollViewNew<RoleListItem, RoleListItemData> selfScrollView = roleListComponent2.GetSelfScrollView();
					targetItem = ((selfScrollView != null) ? selfScrollView.GetScrollItemByIndex(num) : null);
				}
				CS$<>8__locals3.targetItem = targetItem;
				if (CS$<>8__locals2.targetItem == null)
				{
					return null;
				}
				TimerSystem.Instance.Next(delegate(float _)
				{
					CS$<>8__locals2.CS$<>8__locals1.<>4__this.RoleListComponent.GetSelfScrollView().ScrollTo(CS$<>8__locals2.targetItem.GetRootItem(), false);
				}, null, null);
				RoleIconItem roleIconItem = CS$<>8__locals2.targetItem.RoleIconItem;
				UUIItem uuiitem = (roleIconItem != null) ? roleIconItem.GetRootItem() : null;
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
			else if (configParams.Length == 2 && configParams[0] == GuideConfig.Instance.TabTag)
			{
				if (this.TabComponent == null)
				{
					CommonTabComponentData<RoleTabItem> data = new CommonTabComponentData<RoleTabItem>(new Func<UUIItem, int?, RoleTabItem>(this.ProxyCreate), new Action<int>(this.ToggleCallBack), new Func<int, CommonTabData>(this.GetCommonData));
					this.TabComponent = new TabComponentWithCaptionItem<RoleTabItem>(base.GetItem(2), data, new Action(this.CloseClick), false);
					this.UpdateHomeBtnState();
				}
				GenericLayout<RoleTabItem, CommonTabItemData> layout = this.TabComponent.GetTabComponent().GetLayout();
				if (layout == null)
				{
					Log instance = Log.Instance;
					ELogModule module = ELogModule.Guide;
					ELogAuthor author = ELogAuthor.TL;
					string message = "角色界面聚焦引导的额外参数配置有误, 找不到Layout";
					ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("configParams", configParams);
					instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
					return null;
				}
				int index = int.Parse(configParams[1]);
				RoleTabItem layoutItemByIndex = layout.GetLayoutItemByIndex(index);
				if (layoutItemByIndex == null)
				{
					Log.Instance.Error(ELogModule.Guide, ELogAuthor.LZK, "Layout加载未完成", default(ReadOnlySpan<ValueTuple<string, object>>));
					return null;
				}
				return new UUIItem[]
				{
					layoutItemByIndex.GetRootItem(),
					layoutItemByIndex.GetIconSprite()
				};
			}
			else
			{
				if (configParams.Length == 2 && configParams[0] == GuideConfig.Instance.SlotTag)
				{
					int index2 = int.Parse(configParams[1]);
					TWeakObjectPtr<UUIItem> rootUIComp = this.RoleListComponent.GetSelfScrollView().GetScrollItemByIndex(index2).GetToggleForGuide().RootUIComp;
					return new UUIItem[]
					{
						rootUIComp,
						rootUIComp
					};
				}
				string text;
				if (configParams.Length == 2)
				{
					text = Array.Find<string>(configParams, (string param) => int.Parse(param) == PlayerInfoModel.Instance.GetPlayerRoleId());
				}
				else
				{
					text = configParams[0];
				}
				string s = text;
				CS$<>8__locals1.roleId = int.Parse(s);
				RoleListComponent roleListComponent3 = this.RoleListComponent;
				int num2 = (roleListComponent3 != null) ? roleListComponent3.FindDisplayIndex((int id) => id == CS$<>8__locals1.roleId) : -1;
				if (num2 < 0)
				{
					Log instance2 = Log.Instance;
					ELogModule module2 = ELogModule.Guide;
					ELogAuthor author2 = ELogAuthor.TL;
					string message2 = "角色界面聚焦引导的额外参数配置有误, 找不到角色Id";
					ValueTuple<string, object> valueTuple2 = new ValueTuple<string, object>("roleId", CS$<>8__locals1.roleId);
					instance2.Error(module2, author2, message2, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple2));
					return null;
				}
				RoleRootView.<>c__DisplayClass73_0 CS$<>8__locals4 = CS$<>8__locals1;
				RoleListComponent roleListComponent4 = this.RoleListComponent;
				RoleListItem targetItem2;
				if (roleListComponent4 == null)
				{
					targetItem2 = null;
				}
				else
				{
					GenericScrollViewNew<RoleListItem, RoleListItemData> selfScrollView2 = roleListComponent4.GetSelfScrollView();
					targetItem2 = ((selfScrollView2 != null) ? selfScrollView2.GetScrollItemByIndex(num2) : null);
				}
				CS$<>8__locals4.targetItem2 = targetItem2;
				if (CS$<>8__locals1.targetItem2 == null)
				{
					Log instance3 = Log.Instance;
					ELogModule module3 = ELogModule.Guide;
					ELogAuthor author3 = ELogAuthor.LZK;
					string message3 = "角色界面聚焦引导的额外参数配置有误, 找不到角色Id";
					ValueTuple<string, object> valueTuple3 = new ValueTuple<string, object>("roleId", CS$<>8__locals1.roleId);
					instance3.Error(module3, author3, message3, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple3));
					return null;
				}
				TimerSystem.Instance.Next(delegate(float _)
				{
					CS$<>8__locals1.<>4__this.RoleListComponent.GetSelfScrollView().ScrollTo(CS$<>8__locals1.targetItem2.GetRootItem(), false);
				}, null, null);
				RoleIconItem roleIconItem2 = CS$<>8__locals1.targetItem2.RoleIconItem;
				UUIItem uuiitem2 = (roleIconItem2 != null) ? roleIconItem2.GetRootItem() : null;
				if (uuiitem2 == null)
				{
					Log instance4 = Log.Instance;
					ELogModule module4 = ELogModule.Guide;
					ELogAuthor author4 = ELogAuthor.LZK;
					string message4 = "角色界面聚焦引导的额外参数配置有误, 找不到角色Id";
					ValueTuple<string, object> valueTuple4 = new ValueTuple<string, object>("roleId", CS$<>8__locals1.roleId);
					instance4.Error(module4, author4, message4, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple4));
					return null;
				}
				return new UUIItem[]
				{
					uuiitem2,
					uuiitem2
				};
			}
		}

		// Token: 0x06027ACD RID: 162509 RVA: 0x00B1CE8F File Offset: 0x00B1B08F
		protected void CloseClick()
		{
			if (this.RoleViewAgent.Source == ERoleViewSource.WheelTower)
			{
				this.ClearTrialRoleResonanceData();
			}
			base.CloseMe(null);
		}

		// Token: 0x06027ACE RID: 162510 RVA: 0x00B1CEAC File Offset: 0x00B1B0AC
		protected void OnInternalViewQuit()
		{
			this.RoleViewAgent.RoleViewState = ERoleViewState.External;
			this.ShowRoleList();
			this.TabComponent.ShowItem();
		}

		// Token: 0x06027ACF RID: 162511 RVA: 0x00B1CECB File Offset: 0x00B1B0CB
		protected void OnInternalViewEnter()
		{
			this.RoleViewAgent.RoleViewState = ERoleViewState.Internal;
			this.HideRoleList();
			this.TabComponent.HideItem();
		}

		// Token: 0x06027AD0 RID: 162512 RVA: 0x00B1CEEC File Offset: 0x00B1B0EC
		private void ShowRoleList()
		{
			this.UiViewSequence.PlaySequence("RoleListStart", false, null);
		}

		// Token: 0x06027AD1 RID: 162513 RVA: 0x00B1CF14 File Offset: 0x00B1B114
		private void HideRoleList()
		{
			this.UiViewSequence.PlaySequence("RoleListClose", false, null);
		}

		// Token: 0x06027AD2 RID: 162514 RVA: 0x00B1CF3B File Offset: 0x00B1B13B
		protected void RoleListClick()
		{
			UiManager.Instance.OpenView(EUiViewName.RoleSelectionView, this.RoleViewAgent, null);
		}

		// Token: 0x06027AD3 RID: 162515 RVA: 0x00B1CF54 File Offset: 0x00B1B154
		protected override void OnAddEventListener()
		{
			EventSystem.Instance.Add<bool>(EEventName.SwitchRootTabState, new Action<bool>(this.SwitchPanelTabState));
			EventSystem.Instance.Add<bool>(EEventName.AttributeComponentEvent, new Action<bool>(this.PlayRightAnimation));
			EventSystem.Instance.Add(EEventName.UiRoleSequenceEndKeyFrame, new Action(this.UiRoleSequenceEndKeyFrame));
			EventSystem.Instance.Add<int>(EEventName.SelectRoleTab, new Action<int>(this.ToggleCallBack));
			EventSystem.Instance.Add(EEventName.OnRoleInternalViewEnter, new Action(this.OnInternalViewEnter));
			EventSystem.Instance.Add(EEventName.OnRoleInternalViewQuit, new Action(this.OnInternalViewQuit));
			EventSystem.Instance.Add<UiCameraHandleData, UiCameraHandleData, string>(EEventName.OnPlayCameraAnimationStart, new Action<UiCameraHandleData, UiCameraHandleData, string>(this.OnPlayCameraAnimationStart));
			EventSystem.Instance.Add<UiCameraHandleData>(EEventName.OnActivateUiCameraAnimationHandle, new Action<UiCameraHandleData>(this.OnActivateUiCameraAnimationHandle));
			EventSystem.Instance.Add<int>(EEventName.RoleSystemChangeRole, new Action<int>(this.OnRoleSelect));
			EventSystem.Instance.Add<EInputControllerType, EInputControllerType>(EEventName.InputControllerChange, new Action<EInputControllerType, EInputControllerType>(this.OnInputControllerChange));
			UUIDraggableComponent draggable = base.GetDraggable(6);
			draggable.OnPointerBeginDragCallBack.Bind(new Action<ULGUIPointerEventData>(this.OnPointerBeginDragCallBack));
			draggable.OnPointerDragCallBack.Bind(new Action<ULGUIPointerEventData>(this.OnPointerDragCallBack));
			draggable.OnPointerEndDragCallBack.Bind(new Action<ULGUIPointerEventData>(this.OnPointerEndDragCallBack));
			draggable.OnPointerScrollCallBack.Bind(new Action<ULGUIPointerEventData>(this.OnPointerScrollCallBack));
			EventSystem.Instance.Add<float>(EEventName.NavigationTriggerRoleLookUp, new Action<float>(this.OnInputUiLookUp));
			EventSystem.Instance.Add<float>(EEventName.NavigationTriggerRoleTurn, new Action<float>(this.OnInputUiTurn));
			EventSystem.Instance.Add<string, float>(EEventName.NavigationTriggerRoleZoom, new Action<string, float>(this.OnInputUiZoom));
			EventSystem.Instance.Add(EEventName.NavigationTriggerRoleReset, new Action(this.OnRightStickPress));
			InputDistributeController.Instance.BindTouches(new int[]
			{
				0,
				1
			}, new TInputHandle<InputDistributeDefine.ITouchData>(this.OnTouch));
		}

		// Token: 0x06027AD4 RID: 162516 RVA: 0x00B1D16C File Offset: 0x00B1B36C
		protected override void OnRemoveEventListener()
		{
			EventSystem.Instance.Remove<bool>(EEventName.SwitchRootTabState, new Action<bool>(this.SwitchPanelTabState));
			EventSystem.Instance.Remove<bool>(EEventName.AttributeComponentEvent, new Action<bool>(this.PlayRightAnimation));
			EventSystem.Instance.Remove(EEventName.UiRoleSequenceEndKeyFrame, new Action(this.UiRoleSequenceEndKeyFrame));
			EventSystem.Instance.Remove<int>(EEventName.SelectRoleTab, new Action<int>(this.ToggleCallBack));
			EventSystem.Instance.Remove(EEventName.OnRoleInternalViewEnter, new Action(this.OnInternalViewEnter));
			EventSystem.Instance.Remove(EEventName.OnRoleInternalViewQuit, new Action(this.OnInternalViewQuit));
			EventSystem.Instance.Remove<int>(EEventName.RoleSystemChangeRole, new Action<int>(this.OnRoleSelect));
			EventSystem.Instance.Remove<EInputControllerType, EInputControllerType>(EEventName.InputControllerChange, new Action<EInputControllerType, EInputControllerType>(this.OnInputControllerChange));
		}

		// Token: 0x06027AD5 RID: 162517 RVA: 0x00B1D25C File Offset: 0x00B1B45C
		private void RemoveCameraEventListener()
		{
			EventSystem.Instance.Remove<UiCameraHandleData, UiCameraHandleData, string>(EEventName.OnPlayCameraAnimationStart, new Action<UiCameraHandleData, UiCameraHandleData, string>(this.OnPlayCameraAnimationStart));
			EventSystem.Instance.Remove<UiCameraHandleData>(EEventName.OnActivateUiCameraAnimationHandle, new Action<UiCameraHandleData>(this.OnActivateUiCameraAnimationHandle));
			UUIDraggableComponent draggable = base.GetDraggable(6);
			draggable.OnPointerBeginDragCallBack.Unbind();
			draggable.OnPointerDragCallBack.Unbind();
			draggable.OnPointerEndDragCallBack.Unbind();
			draggable.OnPointerScrollCallBack.Unbind();
			EventSystem.Instance.Remove<float>(EEventName.NavigationTriggerRoleLookUp, new Action<float>(this.OnInputUiLookUp));
			EventSystem.Instance.Remove<float>(EEventName.NavigationTriggerRoleTurn, new Action<float>(this.OnInputUiTurn));
			EventSystem.Instance.Remove<string, float>(EEventName.NavigationTriggerRoleZoom, new Action<string, float>(this.OnInputUiZoom));
			EventSystem.Instance.Remove(EEventName.NavigationTriggerRoleReset, new Action(this.OnRightStickPress));
			InputDistributeController.Instance.UnBindTouches(new <>z__ReadOnlyArray<int>(new int[]
			{
				0,
				1
			}), new TInputHandle<InputDistributeDefine.ITouchData>(this.OnTouch));
		}

		// Token: 0x06027AD6 RID: 162518 RVA: 0x00B1D368 File Offset: 0x00B1B568
		[NullableContext(2)]
		private void OnPointerBeginDragCallBack(ULGUIPointerEventData eventData)
		{
			if (!this.CanCameraInput)
			{
				return;
			}
			this.CurrentDragPosition = new FVector?(eventData.GetLocalPointInPlane());
		}

		// Token: 0x06027AD7 RID: 162519 RVA: 0x00B1D384 File Offset: 0x00B1B584
		[NullableContext(2)]
		private void OnPointerDragCallBack(ULGUIPointerEventData eventData)
		{
			if (!this.CanCameraInput || TouchFingerManager.Instance.GetTouchFingerCount() > 1 || InputSettings.Instance.IsInputKeyDown("RightMouseButton"))
			{
				this.CurrentDragPosition = null;
				return;
			}
			FVector? currentDragPosition = this.CurrentDragPosition;
			this.CurrentDragPosition = new FVector?(eventData.GetLocalPointInPlane());
			if (currentDragPosition == null)
			{
				return;
			}
			float num = this.CurrentDragPosition.Value.X - currentDragPosition.Value.X;
			float num2 = this.CurrentDragPosition.Value.Y - currentDragPosition.Value.Y;
			if (num != 0f)
			{
				this.UiCameraInputComponent.AddYawInput(num);
			}
			if (num2 != 0f)
			{
				this.UiCameraInputComponent.AddPitchInput(num2);
			}
		}

		// Token: 0x06027AD8 RID: 162520 RVA: 0x00B1D44A File Offset: 0x00B1B64A
		[NullableContext(2)]
		private void OnPointerEndDragCallBack(ULGUIPointerEventData eventData)
		{
			if (!this.CanCameraInput)
			{
				return;
			}
			this.CurrentDragPosition = null;
		}

		// Token: 0x06027AD9 RID: 162521 RVA: 0x00B1D461 File Offset: 0x00B1B661
		[NullableContext(2)]
		private void OnPointerScrollCallBack(ULGUIPointerEventData eventData)
		{
			if (!this.CanCameraInput)
			{
				return;
			}
			if (eventData.scrollAxisValue != 0f)
			{
				this.UiCameraInputComponent.AddZoomInput(-eventData.scrollAxisValue);
			}
		}

		// Token: 0x06027ADA RID: 162522 RVA: 0x00B1D48B File Offset: 0x00B1B68B
		private void OnPlayCameraAnimationStart(UiCameraHandleData uiCameraHandleData, UiCameraHandleData cameraHandleData, string arg3)
		{
			this.CanCameraInput = false;
			UiCameraInputComponent uiCameraInputComponent = this.UiCameraInputComponent;
			if (uiCameraInputComponent == null)
			{
				return;
			}
			uiCameraInputComponent.PauseTick();
		}

		// Token: 0x06027ADB RID: 162523 RVA: 0x00B1D4A4 File Offset: 0x00B1B6A4
		private void OnActivateUiCameraAnimationHandle(UiCameraHandleData handleData)
		{
			if (!this.CheckCameraViewNameInTabView(handleData.GetViewName()))
			{
				return;
			}
			UiCamera orCreateCamera = UiCameraModel.Instance.GetOrCreateCamera();
			this.UiCameraInputComponent = orCreateCamera.GetUiCameraComponent<UiCameraInputComponent>();
			this.UiCameraLogicComponent = orCreateCamera.GetUiCameraComponent<UiCameraLogicComponent>();
			this.RefreshRoleCameraConfig();
		}

		// Token: 0x06027ADC RID: 162524 RVA: 0x00B1D4EC File Offset: 0x00B1B6EC
		private void RefreshRoleCameraConfig()
		{
			if (this.UiCameraInputComponent == null || this.UiCameraLogicComponent == null)
			{
				return;
			}
			TsUiSceneRoleActor tsUiSceneRoleActor = this.TsUiSceneRoleActor;
			UiModelBase model = tsUiSceneRoleActor.Model;
			UiRoleDataComponent uiRoleDataComponent = (model != null) ? model.CheckGetComponent<UiRoleDataComponent>() : null;
			int skinId = (uiRoleDataComponent != null) ? uiRoleDataComponent.RoleSkinId : 0;
			SUiRoleCameraSetting? roleCameraConfigBySkin = UiRoleCameraConfig.Instance.GetRoleCameraConfigBySkin("默认", skinId);
			if (roleCameraConfigBySkin == null)
			{
				return;
			}
			this.UiCameraLogicComponent.InitDataByConfig(roleCameraConfigBySkin.Value);
			this.UiCameraLogicComponent.SetNeedFloorReflection(true);
			this.CanCameraInput = this.CheckCanCameraInput();
			if (this.CanCameraInput)
			{
				FVectorDouble sourceLocation = tsUiSceneRoleActor.D_K2_GetActorLocation();
				int roleConfigId = uiRoleDataComponent.RoleConfigId;
				string roleBody = RoleConfig.Instance.GetRoleConfig(roleConfigId).Value.RoleBody;
				SUiRoleCameraOffsetSetting value = UiRoleCameraConfig.Instance.GetRoleCameraOffsetConfig(roleBody).Value;
				this.UiCameraLogicComponent.UpdateData(sourceLocation, value.镜头浮动最大高度, value.镜头浮动最低高度, value.镜头浮动最长臂长, value.镜头浮动最短臂长);
				this.UiCameraInputComponent.Activate();
				this.UiCameraInputComponent.ResumeTick();
				return;
			}
			TimerSystem.Instance.Next(delegate(float _)
			{
				UiSceneUtils.SetSceneFloorReflection(false, false);
			}, null, null);
		}

		// Token: 0x06027ADD RID: 162525 RVA: 0x00B1D634 File Offset: 0x00B1B834
		private bool CheckCanCameraInput()
		{
			if (UiCameraModel.Instance.IsPlayingAnimation())
			{
				return false;
			}
			EUiTabViewName? currentTabViewName = this.TabViewComponent.GetCurrentTabViewName(null);
			bool result = false;
			EUiTabViewName[] ui_ROLE_CAN_ROTATE_TABVIEW = RoleDefine.UI_ROLE_CAN_ROTATE_TABVIEW;
			for (int i = 0; i < ui_ROLE_CAN_ROTATE_TABVIEW.Length; i++)
			{
				if (currentTabViewName == ui_ROLE_CAN_ROTATE_TABVIEW[i])
				{
					result = true;
				}
			}
			return result;
		}

		// Token: 0x06027ADE RID: 162526 RVA: 0x00B1D6AC File Offset: 0x00B1B8AC
		private bool CheckCameraViewNameInTabView(string viewName)
		{
			foreach (UiDynamicTab uiDynamicTab in this.TabDataList)
			{
				if (uiDynamicTab.ChildViewName == viewName)
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x06027ADF RID: 162527 RVA: 0x00B1D710 File Offset: 0x00B1B910
		private void SwitchPanelTabState(bool bActive)
		{
			base.GetItem(2).SetUIActive(bActive);
		}

		// Token: 0x06027AE0 RID: 162528 RVA: 0x00B1D71F File Offset: 0x00B1B91F
		private void PlayRightAnimation(bool bOpen)
		{
			this.UiViewSequence.PlaySequencePurely(bOpen ? "hide" : "show", false, false);
		}

		// Token: 0x06027AE1 RID: 162529 RVA: 0x00B1D73D File Offset: 0x00B1B93D
		protected void RefreshUiMode()
		{
			this.RefreshRoleSystemModeUiParam();
		}

		// Token: 0x06027AE2 RID: 162530 RVA: 0x00B1D748 File Offset: 0x00B1B948
		protected void RefreshRoleSystemModeUiParam()
		{
			IRoleSystemUiParams roleSystemUiParams = this.RoleViewAgent.GetRoleSystemUiParams();
			this.BindRedDot(roleSystemUiParams.RoleListButtonRedDot);
			this.SetRoleListButtonVisible(roleSystemUiParams.RoleListButton);
			this.RoleListComponent.SetRoleSystemUiParams(roleSystemUiParams);
			this.RefreshRoleBackgroundMusicSwitchItem();
		}

		// Token: 0x06027AE3 RID: 162531 RVA: 0x00B1D78C File Offset: 0x00B1B98C
		protected virtual void LoadFloorEffect()
		{
			AActor actorByTag = UiSceneManager.Instance.GetActorByTag("RoleFloorCase");
			if (actorByTag != null)
			{
				this.FloorEffect = EffectUtil.SpawnUiEffect("RoleSystemFloorEffect", "[RoleRootView.LoadFloorEffect]", new FTransformDouble?(actorByTag.D_GetTransform()), new EffectContext(null, actorByTag, false)).Value;
			}
		}

		// Token: 0x06027AE4 RID: 162532 RVA: 0x00B1D7E4 File Offset: 0x00B1B9E4
		protected ERedDotName? GetRedDotName(EUiTabViewName tabViewName)
		{
			if (tabViewName == EUiTabViewName.RoleAttributeTabView)
			{
				return new ERedDotName?(ERedDotName.RoleAttributeTab);
			}
			if (tabViewName == EUiTabViewName.RoleResonanceTabNewView)
			{
				return new ERedDotName?(ERedDotName.RoleResonanceTab);
			}
			if (tabViewName == EUiTabViewName.RolePhantomTabView)
			{
				return new ERedDotName?(ERedDotName.VisionTabRedDot);
			}
			if (tabViewName == EUiTabViewName.RoleWeaponTabView)
			{
				return new ERedDotName?(ERedDotName.RoleWeaponTabBreakUp);
			}
			if (tabViewName == EUiTabViewName.RoleFavorTabView)
			{
				return new ERedDotName?(ERedDotName.RoleFavorTab);
			}
			return null;
		}

		// Token: 0x06027AE5 RID: 162533 RVA: 0x00B1D863 File Offset: 0x00B1BA63
		protected void BindRedDot(bool roleListButtonRedDot)
		{
			if (roleListButtonRedDot)
			{
				RedDotController.Instance.BindRedDot(ERedDotName.RoleSelectionList, base.GetItem(8), null, 0);
				return;
			}
			RedDotController.Instance.UnBindGivenUi(ERedDotName.RoleSelectionList, base.GetItem(8), 0);
			base.GetItem(8).SetUIActive(false);
		}

		// Token: 0x06027AE6 RID: 162534 RVA: 0x00B1D8A0 File Offset: 0x00B1BAA0
		protected void UnBindRedDot()
		{
			foreach (RoleTabItem roleTabItem in this.TabComponent.GetTabItemMap().Values)
			{
				roleTabItem.UnBindRedDot();
			}
			RedDotController.Instance.UnBindRedDot(ERedDotName.RoleSelectionList);
		}

		// Token: 0x06027AE7 RID: 162535 RVA: 0x00B1D908 File Offset: 0x00B1BB08
		public void SetRoleListButtonVisible(bool bVisible)
		{
			base.GetButton(1).RootUIComp.Get().SetUIActive(bVisible);
		}

		// Token: 0x06027AE8 RID: 162536 RVA: 0x00B1D92F File Offset: 0x00B1BB2F
		public void SetRoleListVisible(bool bVisible)
		{
			base.GetItem(3).SetUIActive(bVisible);
		}

		// Token: 0x06027AE9 RID: 162537 RVA: 0x00B1D940 File Offset: 0x00B1BB40
		public void RefreshRoleBackgroundMusicSwitchItem()
		{
			IRoleSystemUiParams roleSystemUiParams = this.RoleViewAgent.GetRoleSystemUiParams();
			RoleViewAgent roleViewAgent = this.RoleViewAgent;
			RoleDataBase roleDataBase = (roleViewAgent != null) ? roleViewAgent.GetCurSelectRoleData() : null;
			if (this.CurSelectTabView != EUiTabViewName.RoleSkillTabView || !roleSystemUiParams.BackgroundMusicSwitch || roleDataBase == null || roleDataBase.IsTrialRole() || !roleDataBase.GetRoleConfig().EnableOperateSelfBgm)
			{
				base.GetItem(9).SetUIActive(false);
				return;
			}
			base.GetItem(9).SetUIActive(true);
			RoleBackgroundMusicSwitchItem roleBackgroundMusicSwitchItem = this.RoleBackgroundMusicSwitchItem;
			if (roleBackgroundMusicSwitchItem == null)
			{
				return;
			}
			roleBackgroundMusicSwitchItem.RefreshByRoleData(roleDataBase);
		}

		// Token: 0x06027AEA RID: 162538 RVA: 0x00B1D9E8 File Offset: 0x00B1BBE8
		protected override void OnBeforeHide()
		{
			this.RemoveCameraEventListener();
			this.CanCameraInput = false;
			if (this.ShowSequencePlayer != null)
			{
				this.IsLightSequenceLoop = false;
				this.ShowSequencePlayer.Stop();
				this.ShowSequencePlayer = null;
			}
			UiCameraModel.Instance.GetOrCreateCamera();
			UiCameraInputComponent uiCameraInputComponent = this.UiCameraInputComponent;
			if (uiCameraInputComponent != null)
			{
				uiCameraInputComponent.Deactivate();
			}
			this.UiCameraInputComponent = null;
			this.UiCameraLogicComponent = null;
		}

		// Token: 0x06027AEB RID: 162539 RVA: 0x00B1DA4D File Offset: 0x00B1BC4D
		protected override void OnHandleReleaseScene()
		{
			this.HandleReleaseScene();
		}

		// Token: 0x06027AEC RID: 162540 RVA: 0x00B1DA55 File Offset: 0x00B1BC55
		protected override void OnAfterHide()
		{
			this.RoleListComponent.UnBindRedDot();
			this.TabViewComponent.SetCurrentTabViewState(false);
		}

		// Token: 0x06027AED RID: 162541 RVA: 0x00B1DA70 File Offset: 0x00B1BC70
		protected override void OnBeforeDestroy()
		{
			this.UnBindRedDot();
			EventSystem.Instance.Remove(EEventName.SelectRoleTabOutside, new Action<EUiTabViewName, int>(this.OnSelectRoleTabOutside));
			EventSystem.Instance.Remove(EEventName.RoleDevTargetRoleIdChange, new Action(this.OnRoleDevTargetRoleIdChange));
			DynamicMaskButton showTagTipsMaskButton = this.ShowTagTipsMaskButton;
			if (showTagTipsMaskButton == null)
			{
				return;
			}
			showTagTipsMaskButton.Destroy(null);
		}

		// Token: 0x06027AEE RID: 162542 RVA: 0x00B1DACC File Offset: 0x00B1BCCC
		private void HandleReleaseScene()
		{
			if (this.CanHandleLoadScene)
			{
				return;
			}
			this.CanHandleLoadScene = true;
			if (EffectSystem.Instance.IsValid(this.FloorEffect))
			{
				EffectSystem.Instance.StopEffectById(this.FloorEffect, "[RoleRootView.HandleReleaseScene]", false, null);
			}
			UiSceneManager.Instance.DestroyRoleSystemRoleActor(this.TsUiSceneRoleActor);
			this.TsUiSceneRoleActor = null;
			UiSceneManager.Instance.ClearUiSequenceFrame();
			WeaponModel.Instance.SetCurSelectViewName(EWeaponViewName.None);
		}

		// Token: 0x06027AEF RID: 162543 RVA: 0x00B1DB48 File Offset: 0x00B1BD48
		protected override void OnBeforeDestroyImplement()
		{
			this.HandleReleaseScene();
			this.ClearData();
		}

		// Token: 0x06027AF0 RID: 162544 RVA: 0x00B1DB58 File Offset: 0x00B1BD58
		protected void ClearData()
		{
			if (this.TabViewComponent != null)
			{
				this.TabViewComponent.DestroyTabViewComponent();
				this.TabViewComponent = null;
			}
			if (EffectSystem.Instance.IsValid(this.FloorEffect))
			{
				EffectSystem.Instance.StopEffectById(this.FloorEffect, "[RoleRootView.ClearData]", true, null);
				this.FloorEffect = 0;
			}
			foreach (ALevelSequenceActor alevelSequenceActor in this.LevelSequenceActorCache.Values)
			{
				alevelSequenceActor.SetShouldLatentDestroy(true);
			}
			this.LevelSequenceActorCache.Clear();
			this.CurSelectTabIndex = 0;
			this.ClickTimes = 0;
			UiCameraModel.Instance.GetOrCreateCamera();
			UiCameraInputComponent uiCameraInputComponent = this.UiCameraInputComponent;
			if (uiCameraInputComponent != null)
			{
				uiCameraInputComponent.Deactivate();
			}
			foreach (int num in this.RoleViewAgent.GetRoleIdList(null))
			{
				SortModel.Instance.ClearSortConfigData(EFilterSortConfigId.VisionEquipment, 10, num.ToString());
				FilterModel.Instance.ClearFilterConfigData(EFilterSortConfigId.VisionEquipment, 10, num.ToString());
			}
		}

		// Token: 0x06027AF1 RID: 162545 RVA: 0x00B1DC9C File Offset: 0x00B1BE9C
		private void UiRoleSequenceEndKeyFrame()
		{
			if (!this.IsLightSequenceLoop)
			{
				return;
			}
			int uiStartSequenceFrame = UiSceneManager.Instance.GetUiStartSequenceFrame();
			FFrameNumber frameNumber = new FFrameNumber
			{
				Value = uiStartSequenceFrame
			};
			FFrameTime frame = new FFrameTime
			{
				FrameNumber = frameNumber
			};
			FMovieSceneSequencePlaybackParams playbackPosition = new FMovieSceneSequencePlaybackParams
			{
				Frame = frame,
				PositionType = EMovieScenePositionType.Frame,
				UpdateMethod = EUpdatePositionMethod.Jump
			};
			this.ShowSequencePlayer.SetPlaybackPosition(playbackPosition);
		}

		// Token: 0x06027AF2 RID: 162546 RVA: 0x00B1DCFE File Offset: 0x00B1BEFE
		private void OnRoleDevTargetRoleIdChange()
		{
			this.RefreshRoleDevButtonVisibility();
			RoleListComponent roleListComponent = this.RoleListComponent;
			if (roleListComponent == null)
			{
				return;
			}
			roleListComponent.RefreshVisibleItems();
		}

		// Token: 0x06027AF3 RID: 162547 RVA: 0x00B1DD18 File Offset: 0x00B1BF18
		private void RefreshSkillShowTagRoot()
		{
			bool flag = this.CurSelectTabView == EUiTabViewName.RoleSkillTabView;
			base.GetItem(12).SetUIActive(flag);
			if (flag)
			{
				EToggleState state = RoleModel.Instance.IsShowSkillShowTag ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked;
				base.GetExtendToggle(13).SetToggleState(state, false, false, false);
			}
			base.GetItem(15).SetUIActive(false);
		}

		// Token: 0x06027AF4 RID: 162548 RVA: 0x00B1DD90 File Offset: 0x00B1BF90
		private void OnSkillShowTagToggleClick(EToggleState state)
		{
			bool flag = state == EToggleState.ETT_Checked;
			RoleModel.Instance.IsShowSkillShowTag = flag;
			EventSystem.Instance.Emit<bool>(EEventName.OnSkillShowTagToggleChanged, flag);
			RoleController.Instance.LogRoleDevelopSkillRecommendClick(this.RoleViewAgent.GetCurSelectRoleData().GetDataId(), flag);
		}

		// Token: 0x06027AF5 RID: 162549 RVA: 0x00B1DDD9 File Offset: 0x00B1BFD9
		private void OnSkillShowTagHelpButtonClick()
		{
			if (base.GetItem(15).bIsUIActive)
			{
				this.HideShowTagTips();
				return;
			}
			this.ShowShowTagTips();
		}

		// Token: 0x06027AF6 RID: 162550 RVA: 0x00B1DDF8 File Offset: 0x00B1BFF8
		private UniTask ShowShowTagTips()
		{
			RoleRootView.<ShowShowTagTips>d__116 <ShowShowTagTips>d__;
			<ShowShowTagTips>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<ShowShowTagTips>d__.<>4__this = this;
			<ShowShowTagTips>d__.<>1__state = -1;
			<ShowShowTagTips>d__.<>t__builder.Start<RoleRootView.<ShowShowTagTips>d__116>(ref <ShowShowTagTips>d__);
			return <ShowShowTagTips>d__.<>t__builder.Task;
		}

		// Token: 0x06027AF7 RID: 162551 RVA: 0x00B1DE3B File Offset: 0x00B1C03B
		private void HideShowTagTips()
		{
			base.GetItem(15).SetUIActive(false);
			if (this.ShowTagTipsMaskButton != null)
			{
				this.ShowTagTipsMaskButton.ResetItemParent();
				this.ShowTagTipsMaskButton.SetActive(false);
			}
		}

		// Token: 0x06027AF8 RID: 162552 RVA: 0x00B1DE6A File Offset: 0x00B1C06A
		private void OnInputControllerChange(EInputControllerType last, EInputControllerType now)
		{
			if (!Info.Instance.IsInGamepad())
			{
				return;
			}
			if (base.GetItem(15).bIsUIActive)
			{
				this.HideShowTagTips();
			}
		}

		// Token: 0x04015A43 RID: 88643
		[Nullable(2)]
		protected RoleBackgroundMusicSwitchItem RoleBackgroundMusicSwitchItem;

		// Token: 0x04015A44 RID: 88644
		[Nullable(2)]
		protected RoleListComponent RoleListComponent;

		// Token: 0x04015A45 RID: 88645
		[Nullable(2)]
		protected TabViewComponent<UiDynamicTab> TabViewComponent;

		// Token: 0x04015A46 RID: 88646
		[Nullable(new byte[]
		{
			2,
			1
		})]
		protected TabComponentWithCaptionItem<RoleTabItem> TabComponent;

		// Token: 0x04015A47 RID: 88647
		[Nullable(2)]
		private TsUiSceneRoleActor TsUiSceneRoleActor;

		// Token: 0x04015A48 RID: 88648
		protected List<UiDynamicTab> TabDataList = new List<UiDynamicTab>();

		// Token: 0x04015A49 RID: 88649
		private int FloorEffect;

		// Token: 0x04015A4A RID: 88650
		[Nullable(2)]
		protected UiCameraHandleData RoleRootUiCameraHandleData;

		// Token: 0x04015A4B RID: 88651
		private int CurSelectTabIndex;

		// Token: 0x04015A4C RID: 88652
		private EUiTabViewName? CurSelectTabView;

		// Token: 0x04015A4D RID: 88653
		[Nullable(2)]
		private ULevelSequencePlayer ShowSequencePlayer;

		// Token: 0x04015A4E RID: 88654
		private int ClickTimes;

		// Token: 0x04015A4F RID: 88655
		private double? LastClickTime;

		// Token: 0x04015A50 RID: 88656
		private bool IsLightSequenceLoop = true;

		// Token: 0x04015A51 RID: 88657
		private readonly Dictionary<int, ALevelSequenceActor> LevelSequenceActorCache = new Dictionary<int, ALevelSequenceActor>();

		// Token: 0x04015A52 RID: 88658
		private readonly Dictionary<int, int> LevelSequenceActorLoadStatus = new Dictionary<int, int>();

		// Token: 0x04015A53 RID: 88659
		private bool CanCameraInput;

		// Token: 0x04015A54 RID: 88660
		[Nullable(2)]
		private UiCameraInputComponent UiCameraInputComponent;

		// Token: 0x04015A55 RID: 88661
		[Nullable(2)]
		private UiCameraLogicComponent UiCameraLogicComponent;

		// Token: 0x04015A56 RID: 88662
		[Nullable(2)]
		private RoleViewAgent RoleViewAgent;

		// Token: 0x04015A57 RID: 88663
		private readonly Queue<OperationParam> ViewOperationQueue = new Queue<OperationParam>(4);

		// Token: 0x04015A58 RID: 88664
		private bool Operating;

		// Token: 0x04015A59 RID: 88665
		private bool CanHandleLoadScene = true;

		// Token: 0x04015A5A RID: 88666
		private RoleDevelopEntranceItem RoleDevelopEntranceItem;

		// Token: 0x04015A5B RID: 88667
		[Nullable(2)]
		private DynamicMaskButton ShowTagTipsMaskButton;

		// Token: 0x04015A5C RID: 88668
		private FVector? CurrentDragPosition;
	}
}
