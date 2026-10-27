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
using CSharpScript.Game.Module.UiCameraAnimation.UiCameraContext;
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
	// Token: 0x02004CE3 RID: 19683
	[NullableContext(1)]
	[Nullable(0)]
	public class RoleRootView : UiViewBase
	{
		// Token: 0x06032CC8 RID: 208072 RVA: 0x00BD6274 File Offset: 0x00BD4474
		public RoleRootView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x17007D9D RID: 32157
		// (get) Token: 0x06032CC9 RID: 208073 RVA: 0x00BD62C3 File Offset: 0x00BD44C3
		private bool IsLock
		{
			get
			{
				return this.Operating;
			}
		}

		// Token: 0x06032CCA RID: 208074 RVA: 0x00BD62CB File Offset: 0x00BD44CB
		private void Lock()
		{
			this.Operating = true;
		}

		// Token: 0x06032CCB RID: 208075 RVA: 0x00BD62D4 File Offset: 0x00BD44D4
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

		// Token: 0x06032CCC RID: 208076 RVA: 0x00BD6338 File Offset: 0x00BD4538
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

		// Token: 0x06032CCD RID: 208077 RVA: 0x00BD64CC File Offset: 0x00BD46CC
		protected override UniTask OnBeforeStartAsync()
		{
			RoleRootView.<OnBeforeStartAsync>d__30 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<RoleRootView.<OnBeforeStartAsync>d__30>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06032CCE RID: 208078 RVA: 0x00BD6510 File Offset: 0x00BD4710
		private UniTask InitRoleDevelopEntranceItem()
		{
			RoleRootView.<InitRoleDevelopEntranceItem>d__31 <InitRoleDevelopEntranceItem>d__;
			<InitRoleDevelopEntranceItem>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitRoleDevelopEntranceItem>d__.<>4__this = this;
			<InitRoleDevelopEntranceItem>d__.<>1__state = -1;
			<InitRoleDevelopEntranceItem>d__.<>t__builder.Start<RoleRootView.<InitRoleDevelopEntranceItem>d__31>(ref <InitRoleDevelopEntranceItem>d__);
			return <InitRoleDevelopEntranceItem>d__.<>t__builder.Task;
		}

		// Token: 0x06032CCF RID: 208079 RVA: 0x00BD6554 File Offset: 0x00BD4754
		private UniTask TryRequestTrialRoleInfo()
		{
			RoleRootView.<TryRequestTrialRoleInfo>d__32 <TryRequestTrialRoleInfo>d__;
			<TryRequestTrialRoleInfo>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<TryRequestTrialRoleInfo>d__.<>4__this = this;
			<TryRequestTrialRoleInfo>d__.<>1__state = -1;
			<TryRequestTrialRoleInfo>d__.<>t__builder.Start<RoleRootView.<TryRequestTrialRoleInfo>d__32>(ref <TryRequestTrialRoleInfo>d__);
			return <TryRequestTrialRoleInfo>d__.<>t__builder.Task;
		}

		// Token: 0x06032CD0 RID: 208080 RVA: 0x00BD6598 File Offset: 0x00BD4798
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

		// Token: 0x06032CD1 RID: 208081 RVA: 0x00BD6664 File Offset: 0x00BD4864
		private void ClearTrialRoleResonanceData()
		{
			List<int> list = new List<int>();
			foreach (int num in this.RoleViewAgent.GetRoleIdList())
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

		// Token: 0x06032CD2 RID: 208082 RVA: 0x00BD674C File Offset: 0x00BD494C
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

		// Token: 0x06032CD3 RID: 208083 RVA: 0x00BD67C3 File Offset: 0x00BD49C3
		protected override void OnHandleLoadScene()
		{
			this.HandleLoadScene();
		}

		// Token: 0x06032CD4 RID: 208084 RVA: 0x00BD67CC File Offset: 0x00BD49CC
		protected override void OnStart()
		{
			EventSystem.Instance.Add<EUiTabViewName, int>(EEventName.SelectRoleTabOutside, new Action<EUiTabViewName, int>(this.OnSelectRoleTabOutside));
			EventSystem.Instance.Add(EEventName.RoleDevTargetRoleIdChange, new Action(this.OnRoleDevTargetRoleIdChange));
			this.RefreshRoleDevButtonVisibility();
			this.RefreshSkillShowTagRoot();
		}

		// Token: 0x06032CD5 RID: 208085 RVA: 0x00BD681D File Offset: 0x00BD4A1D
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

		// Token: 0x06032CD6 RID: 208086 RVA: 0x00BD683C File Offset: 0x00BD4A3C
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

		// Token: 0x06032CD7 RID: 208087 RVA: 0x00BD6884 File Offset: 0x00BD4A84
		protected UniTask RefreshRoleListAsync()
		{
			RoleRootView.<RefreshRoleListAsync>d__40 <RefreshRoleListAsync>d__;
			<RefreshRoleListAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<RefreshRoleListAsync>d__.<>4__this = this;
			<RefreshRoleListAsync>d__.<>1__state = -1;
			<RefreshRoleListAsync>d__.<>t__builder.Start<RoleRootView.<RefreshRoleListAsync>d__40>(ref <RefreshRoleListAsync>d__);
			return <RefreshRoleListAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06032CD8 RID: 208088 RVA: 0x00BD68C8 File Offset: 0x00BD4AC8
		private UniTask UpdateRoleListAndScrollAsync(int targetRoleId)
		{
			RoleRootView.<UpdateRoleListAndScrollAsync>d__41 <UpdateRoleListAndScrollAsync>d__;
			<UpdateRoleListAndScrollAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<UpdateRoleListAndScrollAsync>d__.<>4__this = this;
			<UpdateRoleListAndScrollAsync>d__.targetRoleId = targetRoleId;
			<UpdateRoleListAndScrollAsync>d__.<>1__state = -1;
			<UpdateRoleListAndScrollAsync>d__.<>t__builder.Start<RoleRootView.<UpdateRoleListAndScrollAsync>d__41>(ref <UpdateRoleListAndScrollAsync>d__);
			return <UpdateRoleListAndScrollAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06032CD9 RID: 208089 RVA: 0x00BD6914 File Offset: 0x00BD4B14
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

		// Token: 0x06032CDA RID: 208090 RVA: 0x00BD695C File Offset: 0x00BD4B5C
		protected UniTask RefreshTabListAsync()
		{
			RoleRootView.<RefreshTabListAsync>d__43 <RefreshTabListAsync>d__;
			<RefreshTabListAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<RefreshTabListAsync>d__.<>4__this = this;
			<RefreshTabListAsync>d__.<>1__state = -1;
			<RefreshTabListAsync>d__.<>t__builder.Start<RoleRootView.<RefreshTabListAsync>d__43>(ref <RefreshTabListAsync>d__);
			return <RefreshTabListAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06032CDB RID: 208091 RVA: 0x00BD69A0 File Offset: 0x00BD4BA0
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

		// Token: 0x06032CDC RID: 208092 RVA: 0x00BD69E8 File Offset: 0x00BD4BE8
		protected UniTask OnRoleSelectAsync()
		{
			RoleRootView.<OnRoleSelectAsync>d__45 <OnRoleSelectAsync>d__;
			<OnRoleSelectAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnRoleSelectAsync>d__.<>4__this = this;
			<OnRoleSelectAsync>d__.<>1__state = -1;
			<OnRoleSelectAsync>d__.<>t__builder.Start<RoleRootView.<OnRoleSelectAsync>d__45>(ref <OnRoleSelectAsync>d__);
			return <OnRoleSelectAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06032CDD RID: 208093 RVA: 0x00BD6A2B File Offset: 0x00BD4C2B
		protected void OnSelectRoleTabOutside(EUiTabViewName tabViewName, int roleId)
		{
			this.Lock();
			this.SelectRoleTabOutSide(tabViewName, roleId).ContinueWith(new Action(this.Unlock));
		}

		// Token: 0x06032CDE RID: 208094 RVA: 0x00BD6A50 File Offset: 0x00BD4C50
		protected UniTask SelectRoleTabOutSide(EUiTabViewName tabViewName, int roleId)
		{
			RoleRootView.<SelectRoleTabOutSide>d__47 <SelectRoleTabOutSide>d__;
			<SelectRoleTabOutSide>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<SelectRoleTabOutSide>d__.<>4__this = this;
			<SelectRoleTabOutSide>d__.tabViewName = tabViewName;
			<SelectRoleTabOutSide>d__.roleId = roleId;
			<SelectRoleTabOutSide>d__.<>1__state = -1;
			<SelectRoleTabOutSide>d__.<>t__builder.Start<RoleRootView.<SelectRoleTabOutSide>d__47>(ref <SelectRoleTabOutSide>d__);
			return <SelectRoleTabOutSide>d__.<>t__builder.Task;
		}

		// Token: 0x06032CDF RID: 208095 RVA: 0x00BD6AA4 File Offset: 0x00BD4CA4
		protected UniTask SelectRoleOutside(int roleId)
		{
			RoleRootView.<SelectRoleOutside>d__48 <SelectRoleOutside>d__;
			<SelectRoleOutside>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<SelectRoleOutside>d__.<>4__this = this;
			<SelectRoleOutside>d__.roleId = roleId;
			<SelectRoleOutside>d__.<>1__state = -1;
			<SelectRoleOutside>d__.<>t__builder.Start<RoleRootView.<SelectRoleOutside>d__48>(ref <SelectRoleOutside>d__);
			return <SelectRoleOutside>d__.<>t__builder.Task;
		}

		// Token: 0x06032CE0 RID: 208096 RVA: 0x00BD6AF0 File Offset: 0x00BD4CF0
		protected void InitTabComponent()
		{
			CommonTabComponentData<RoleTabItem> data = new CommonTabComponentData<RoleTabItem>(new Func<UUIItem, int?, RoleTabItem>(this.ProxyCreate), new Action<int>(this.ToggleCallBack), new Func<int, CommonTabData>(this.GetCommonData));
			this.TabComponent = new TabComponentWithCaptionItem<RoleTabItem>(base.GetItem(2), data, new Action(this.CloseClick), false);
			this.LastClickTime = null;
			this.TabComponent.SetCanChange(new Func<int, bool?, bool>(this.CanToggleChange));
			this.TabViewComponent = new TabViewComponent<UiDynamicTab>(base.GetItem(4), EKeyMode.Default);
		}

		// Token: 0x06032CE1 RID: 208097 RVA: 0x00BD6B80 File Offset: 0x00BD4D80
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

		// Token: 0x06032CE2 RID: 208098 RVA: 0x00BD6C68 File Offset: 0x00BD4E68
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

		// Token: 0x06032CE3 RID: 208099 RVA: 0x00BD6D38 File Offset: 0x00BD4F38
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

		// Token: 0x06032CE4 RID: 208100 RVA: 0x00BD6DB1 File Offset: 0x00BD4FB1
		private RoleTabItem ProxyCreate([Nullable(2)] UUIItem uiItem, int? index)
		{
			return new RoleTabItem
			{
				IsConflict = new Func<int, bool>(this.IsConflict)
			};
		}

		// Token: 0x06032CE5 RID: 208101 RVA: 0x00BD6DCC File Offset: 0x00BD4FCC
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

		// Token: 0x06032CE6 RID: 208102 RVA: 0x00BD6EB4 File Offset: 0x00BD50B4
		private void RefreshRoleDevButtonVisibility()
		{
			this.RoleDevelopEntranceItem.RefreshView();
		}

		// Token: 0x06032CE7 RID: 208103 RVA: 0x00BD6EC4 File Offset: 0x00BD50C4
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

		// Token: 0x06032CE8 RID: 208104 RVA: 0x00BD6F3C File Offset: 0x00BD513C
		private void UpdateHomeBtnState()
		{
			if (this.TabComponent == null)
			{
				return;
			}
			bool flag = RoleDefine.RoleViewSourceHideHomeInInstance[this.RoleViewAgent.Source];
			this.TabComponent.SetHomeBtnShowState(!flag || !GameModeController.Instance.IsInInstance());
		}

		// Token: 0x06032CE9 RID: 208105 RVA: 0x00BD6F88 File Offset: 0x00BD5188
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

		// Token: 0x06032CEA RID: 208106 RVA: 0x00BD706E File Offset: 0x00BD526E
		private void OnInputUiLookUp(float value)
		{
			if (value == 0f || !this.CanCameraInput || !Info.Instance.IsInGamepad())
			{
				return;
			}
			this.UiCameraControlRotationComponent.AddPitchInput(-value);
		}

		// Token: 0x06032CEB RID: 208107 RVA: 0x00BD709A File Offset: 0x00BD529A
		private void OnInputUiTurn(float value)
		{
			if (value == 0f || !this.CanCameraInput || !Info.Instance.IsInGamepad())
			{
				return;
			}
			this.UiCameraControlRotationComponent.AddYawInput(value);
		}

		// Token: 0x06032CEC RID: 208108 RVA: 0x00BD70C5 File Offset: 0x00BD52C5
		private void OnInputUiZoom(string axisName, float value)
		{
			if (value == 0f || !this.CanCameraInput || !Info.Instance.IsInGamepad())
			{
				return;
			}
			this.UiCameraControlRotationComponent.AddZoomInput(value);
		}

		// Token: 0x06032CED RID: 208109 RVA: 0x00BD70F0 File Offset: 0x00BD52F0
		private void OnRightStickPress()
		{
			if (!this.CanCameraInput)
			{
				return;
			}
			UiCameraHandleData lastHandleData = UiCameraAnimationManager.Instance.GetLastHandleData();
			if (lastHandleData != null)
			{
				UiCameraAnimationManager.Instance.PushCameraHandleByHandleName(lastHandleData.HandleName, true, true, "1001", false, null, null);
			}
		}

		// Token: 0x06032CEE RID: 208110 RVA: 0x00BD7137 File Offset: 0x00BD5337
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

		// Token: 0x06032CEF RID: 208111 RVA: 0x00BD7154 File Offset: 0x00BD5354
		private void TouchMoved()
		{
			if (TouchFingerManager.Instance.GetTouchFingerCount() > 1)
			{
				float fingerExpandCloseValue = TouchFingerManager.Instance.GetFingerExpandCloseValue(EFingerIndex.One, EFingerIndex.Two);
				this.UiCameraControlRotationComponent.AddZoomInput(-fingerExpandCloseValue);
			}
		}

		// Token: 0x06032CF0 RID: 208112 RVA: 0x00BD7188 File Offset: 0x00BD5388
		private CommonTabData GetCommonData(int index)
		{
			UiDynamicTab uiDynamicTab = this.TabDataList[index];
			return new CommonTabData(uiDynamicTab.Icon, new CommonTabTitleData(uiDynamicTab.TabName, Array.Empty<object>()), null);
		}

		// Token: 0x06032CF1 RID: 208113 RVA: 0x00BD71C0 File Offset: 0x00BD53C0
		[return: Nullable(new byte[]
		{
			2,
			1
		})]
		public override UUIItem[] GetGuideUiItemAndUiItemForShowEx(string[] configParams)
		{
			RoleRootView.<>c__DisplayClass66_0 CS$<>8__locals1 = new RoleRootView.<>c__DisplayClass66_0();
			CS$<>8__locals1.<>4__this = this;
			if (this.IsLock)
			{
				Log.Instance.Error(ELogModule.Guide, ELogAuthor.LZK, "异步操作执行过程中不能触发引导", default(ReadOnlySpan<ValueTuple<string, object>>));
				return null;
			}
			if (configParams[0] == "Rover")
			{
				RoleRootView.<>c__DisplayClass66_1 CS$<>8__locals2 = new RoleRootView.<>c__DisplayClass66_1();
				CS$<>8__locals2.CS$<>8__locals1 = CS$<>8__locals1;
				IReadOnlyList<int> roleIdList = this.RoleViewAgent.GetRoleIdList();
				int num = -1;
				for (int i = 0; i < roleIdList.Count; i++)
				{
					int roleId = roleIdList[i];
					if (RoleModel.Instance.IsMainRole(roleId))
					{
						num = i;
						break;
					}
				}
				if (num < 0 || num >= roleIdList.Count)
				{
					return null;
				}
				RoleRootView.<>c__DisplayClass66_1 CS$<>8__locals3 = CS$<>8__locals2;
				RoleListComponent roleListComponent = this.RoleListComponent;
				RoleListItem targetItem;
				if (roleListComponent == null)
				{
					targetItem = null;
				}
				else
				{
					GenericScrollViewNew<RoleListItem, RoleListItemData> selfScrollView = roleListComponent.GetSelfScrollView();
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
				string s;
				if (configParams.Length == 2)
				{
					s = Array.Find<string>(configParams, (string param) => int.Parse(param) == PlayerInfoModel.Instance.GetPlayerRoleId());
				}
				else
				{
					s = configParams[0];
				}
				int num2 = int.Parse(s);
				IReadOnlyList<int> roleIdList2 = this.RoleViewAgent.GetRoleIdList();
				int num3 = -1;
				for (int j = 0; j < roleIdList2.Count; j++)
				{
					if (roleIdList2[j] == num2)
					{
						num3 = j;
						break;
					}
				}
				if (num3 < 0 || num3 >= roleIdList2.Count)
				{
					Log instance2 = Log.Instance;
					ELogModule module2 = ELogModule.Guide;
					ELogAuthor author2 = ELogAuthor.TL;
					string message2 = "角色界面聚焦引导的额外参数配置有误, 找不到角色Id";
					ValueTuple<string, object> valueTuple2 = new ValueTuple<string, object>("roleId", num2);
					instance2.Error(module2, author2, message2, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple2));
					return null;
				}
				RoleRootView.<>c__DisplayClass66_0 CS$<>8__locals4 = CS$<>8__locals1;
				RoleListComponent roleListComponent2 = this.RoleListComponent;
				RoleListItem targetItem2;
				if (roleListComponent2 == null)
				{
					targetItem2 = null;
				}
				else
				{
					GenericScrollViewNew<RoleListItem, RoleListItemData> selfScrollView2 = roleListComponent2.GetSelfScrollView();
					targetItem2 = ((selfScrollView2 != null) ? selfScrollView2.GetScrollItemByIndex(num3) : null);
				}
				CS$<>8__locals4.targetItem2 = targetItem2;
				if (CS$<>8__locals1.targetItem2 == null)
				{
					Log instance3 = Log.Instance;
					ELogModule module3 = ELogModule.Guide;
					ELogAuthor author3 = ELogAuthor.LZK;
					string message3 = "角色界面聚焦引导的额外参数配置有误, 找不到角色Id";
					ValueTuple<string, object> valueTuple3 = new ValueTuple<string, object>("roleId", num2);
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
					ValueTuple<string, object> valueTuple4 = new ValueTuple<string, object>("roleId", num2);
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

		// Token: 0x06032CF2 RID: 208114 RVA: 0x00BD75D2 File Offset: 0x00BD57D2
		protected void CloseClick()
		{
			if (this.RoleViewAgent.Source == ERoleViewSource.WheelTower)
			{
				this.ClearTrialRoleResonanceData();
			}
			base.CloseMe(null);
		}

		// Token: 0x06032CF3 RID: 208115 RVA: 0x00BD75EF File Offset: 0x00BD57EF
		protected void OnInternalViewQuit()
		{
			this.RoleViewAgent.RoleViewState = ERoleViewState.External;
			this.ShowRoleList();
			this.TabComponent.ShowItem();
		}

		// Token: 0x06032CF4 RID: 208116 RVA: 0x00BD760E File Offset: 0x00BD580E
		protected void OnInternalViewEnter()
		{
			this.RoleViewAgent.RoleViewState = ERoleViewState.Internal;
			this.HideRoleList();
			this.TabComponent.HideItem();
		}

		// Token: 0x06032CF5 RID: 208117 RVA: 0x00BD7630 File Offset: 0x00BD5830
		private void ShowRoleList()
		{
			this.UiViewSequence.PlaySequence("RoleListStart", false, null);
		}

		// Token: 0x06032CF6 RID: 208118 RVA: 0x00BD7658 File Offset: 0x00BD5858
		private void HideRoleList()
		{
			this.UiViewSequence.PlaySequence("RoleListClose", false, null);
		}

		// Token: 0x06032CF7 RID: 208119 RVA: 0x00BD767F File Offset: 0x00BD587F
		protected void RoleListClick()
		{
			UiManager.Instance.OpenView(EUiViewName.RoleSelectionView, this.RoleViewAgent, null);
		}

		// Token: 0x06032CF8 RID: 208120 RVA: 0x00BD7698 File Offset: 0x00BD5898
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

		// Token: 0x06032CF9 RID: 208121 RVA: 0x00BD78B0 File Offset: 0x00BD5AB0
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

		// Token: 0x06032CFA RID: 208122 RVA: 0x00BD79A0 File Offset: 0x00BD5BA0
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

		// Token: 0x06032CFB RID: 208123 RVA: 0x00BD7AAC File Offset: 0x00BD5CAC
		[NullableContext(2)]
		private void OnPointerBeginDragCallBack(ULGUIPointerEventData eventData)
		{
			if (!this.CanCameraInput)
			{
				return;
			}
			this.CurrentDragPosition = new FVector?(eventData.GetLocalPointInPlane());
		}

		// Token: 0x06032CFC RID: 208124 RVA: 0x00BD7AC8 File Offset: 0x00BD5CC8
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
				this.UiCameraControlRotationComponent.AddYawInput(num);
			}
			if (num2 != 0f)
			{
				this.UiCameraControlRotationComponent.AddPitchInput(num2);
			}
		}

		// Token: 0x06032CFD RID: 208125 RVA: 0x00BD7B8E File Offset: 0x00BD5D8E
		[NullableContext(2)]
		private void OnPointerEndDragCallBack(ULGUIPointerEventData eventData)
		{
			if (!this.CanCameraInput)
			{
				return;
			}
			this.CurrentDragPosition = null;
		}

		// Token: 0x06032CFE RID: 208126 RVA: 0x00BD7BA5 File Offset: 0x00BD5DA5
		[NullableContext(2)]
		private void OnPointerScrollCallBack(ULGUIPointerEventData eventData)
		{
			if (!this.CanCameraInput)
			{
				return;
			}
			if (eventData.scrollAxisValue != 0f)
			{
				this.UiCameraControlRotationComponent.AddZoomInput(-eventData.scrollAxisValue);
			}
		}

		// Token: 0x06032CFF RID: 208127 RVA: 0x00BD7BCF File Offset: 0x00BD5DCF
		private void OnPlayCameraAnimationStart(UiCameraHandleData uiCameraHandleData, UiCameraHandleData cameraHandleData, string arg3)
		{
			this.CanCameraInput = false;
			UiCameraControlRotationComponent uiCameraControlRotationComponent = this.UiCameraControlRotationComponent;
			if (uiCameraControlRotationComponent == null)
			{
				return;
			}
			uiCameraControlRotationComponent.PauseTick();
		}

		// Token: 0x06032D00 RID: 208128 RVA: 0x00BD7BE8 File Offset: 0x00BD5DE8
		private void OnActivateUiCameraAnimationHandle(UiCameraHandleData handleData)
		{
			if (!this.CheckCameraViewNameInTabView(handleData.ViewName))
			{
				return;
			}
			UiCamera uiCamera = UiCameraManager.Get();
			this.UiCameraControlRotationComponent = (uiCamera.AddUiCameraComponent(typeof(UiCameraControlRotationComponent), false) as UiCameraControlRotationComponent);
			this.RefreshRoleCameraConfig();
		}

		// Token: 0x06032D01 RID: 208129 RVA: 0x00BD7C2C File Offset: 0x00BD5E2C
		private void RefreshRoleCameraConfig()
		{
			if (this.UiCameraControlRotationComponent == null)
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
			this.UiCameraControlRotationComponent.InitDataByConfig(roleCameraConfigBySkin.Value);
			this.UiCameraControlRotationComponent.SetNeedFloorReflection(true);
			this.CanCameraInput = this.CheckCanCameraInput();
			if (this.CanCameraInput)
			{
				FVectorDouble sourceLocation = tsUiSceneRoleActor.D_K2_GetActorLocation();
				int roleConfigId = uiRoleDataComponent.RoleConfigId;
				string roleBody = RoleConfig.Instance.GetRoleConfig(roleConfigId).Value.RoleBody;
				SUiRoleCameraOffsetSetting value = UiRoleCameraConfig.Instance.GetRoleCameraOffsetConfig(roleBody).Value;
				this.UiCameraControlRotationComponent.UpdateData(sourceLocation, value.镜头浮动最大高度, value.镜头浮动最低高度, value.镜头浮动最长臂长, value.镜头浮动最短臂长);
				this.UiCameraControlRotationComponent.Activate();
				this.UiCameraControlRotationComponent.ResumeTick();
				return;
			}
			TimerSystem.Instance.Next(delegate(float _)
			{
				UiSceneUtils.SetSceneFloorReflection(false, false);
			}, null, null);
		}

		// Token: 0x06032D02 RID: 208130 RVA: 0x00BD7D6C File Offset: 0x00BD5F6C
		private bool CheckCanCameraInput()
		{
			if (UiCameraAnimationManager.Instance.IsPlayingAnimation())
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

		// Token: 0x06032D03 RID: 208131 RVA: 0x00BD7DE4 File Offset: 0x00BD5FE4
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

		// Token: 0x06032D04 RID: 208132 RVA: 0x00BD7E48 File Offset: 0x00BD6048
		private void SwitchPanelTabState(bool bActive)
		{
			base.GetItem(2).SetUIActive(bActive);
		}

		// Token: 0x06032D05 RID: 208133 RVA: 0x00BD7E57 File Offset: 0x00BD6057
		private void PlayRightAnimation(bool bOpen)
		{
			this.UiViewSequence.PlaySequencePurely(bOpen ? "hide" : "show", false, false);
		}

		// Token: 0x06032D06 RID: 208134 RVA: 0x00BD7E75 File Offset: 0x00BD6075
		protected void RefreshUiMode()
		{
			this.RefreshRoleSystemModeUiParam();
		}

		// Token: 0x06032D07 RID: 208135 RVA: 0x00BD7E80 File Offset: 0x00BD6080
		protected void RefreshRoleSystemModeUiParam()
		{
			IRoleSystemUiParams roleSystemUiParams = this.RoleViewAgent.GetRoleSystemUiParams();
			this.BindRedDot(roleSystemUiParams.RoleListButtonRedDot);
			this.SetRoleListButtonVisible(roleSystemUiParams.RoleListButton);
			this.RoleListComponent.SetRoleSystemUiParams(roleSystemUiParams);
			this.RefreshRoleBackgroundMusicSwitchItem();
		}

		// Token: 0x06032D08 RID: 208136 RVA: 0x00BD7EC4 File Offset: 0x00BD60C4
		protected virtual void LoadFloorEffect()
		{
			AActor actorByTag = UiSceneManager.Instance.GetActorByTag("RoleFloorCase");
			if (actorByTag != null)
			{
				this.FloorEffect = EffectUtil.SpawnUiEffect("RoleSystemFloorEffect", "[RoleRootView.LoadFloorEffect]", new FTransformDouble?(actorByTag.D_GetTransform()), new EffectContext(null, actorByTag, false)).Value;
			}
		}

		// Token: 0x06032D09 RID: 208137 RVA: 0x00BD7F1C File Offset: 0x00BD611C
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

		// Token: 0x06032D0A RID: 208138 RVA: 0x00BD7F9B File Offset: 0x00BD619B
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

		// Token: 0x06032D0B RID: 208139 RVA: 0x00BD7FD8 File Offset: 0x00BD61D8
		protected void UnBindRedDot()
		{
			foreach (RoleTabItem roleTabItem in this.TabComponent.GetTabItemMap().Values)
			{
				roleTabItem.UnBindRedDot();
			}
			RedDotController.Instance.UnBindRedDot(ERedDotName.RoleSelectionList);
		}

		// Token: 0x06032D0C RID: 208140 RVA: 0x00BD8040 File Offset: 0x00BD6240
		public void SetRoleListButtonVisible(bool bVisible)
		{
			base.GetButton(1).RootUIComp.Get().SetUIActive(bVisible);
		}

		// Token: 0x06032D0D RID: 208141 RVA: 0x00BD8067 File Offset: 0x00BD6267
		public void SetRoleListVisible(bool bVisible)
		{
			base.GetItem(3).SetUIActive(bVisible);
		}

		// Token: 0x06032D0E RID: 208142 RVA: 0x00BD8078 File Offset: 0x00BD6278
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

		// Token: 0x06032D0F RID: 208143 RVA: 0x00BD8120 File Offset: 0x00BD6320
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
			UiCameraManager.Get().DestroyUiCameraComponent(typeof(UiCameraControlRotationComponent));
			this.UiCameraControlRotationComponent = null;
		}

		// Token: 0x06032D10 RID: 208144 RVA: 0x00BD8176 File Offset: 0x00BD6376
		protected override void OnHandleReleaseScene()
		{
			this.HandleReleaseScene();
		}

		// Token: 0x06032D11 RID: 208145 RVA: 0x00BD817E File Offset: 0x00BD637E
		protected override void OnAfterHide()
		{
			this.RoleListComponent.UnBindRedDot();
			this.TabViewComponent.SetCurrentTabViewState(false);
		}

		// Token: 0x06032D12 RID: 208146 RVA: 0x00BD8198 File Offset: 0x00BD6398
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

		// Token: 0x06032D13 RID: 208147 RVA: 0x00BD81F4 File Offset: 0x00BD63F4
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

		// Token: 0x06032D14 RID: 208148 RVA: 0x00BD8270 File Offset: 0x00BD6470
		protected override void OnBeforeDestroyImplement()
		{
			this.HandleReleaseScene();
			this.ClearData();
		}

		// Token: 0x06032D15 RID: 208149 RVA: 0x00BD8280 File Offset: 0x00BD6480
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
			UiCameraManager.Get().DestroyUiCameraComponent(typeof(UiCameraControlRotationComponent));
			foreach (int num in this.RoleViewAgent.GetRoleIdList())
			{
				SortModel.Instance.ClearSortConfigData(EFilterSortConfigId.VisionEquipment, 10, num.ToString());
				FilterModel.Instance.ClearFilterConfigData(EFilterSortConfigId.VisionEquipment, 10, num.ToString());
			}
		}

		// Token: 0x06032D16 RID: 208150 RVA: 0x00BD83B8 File Offset: 0x00BD65B8
		private void UiRoleSequenceEndKeyFrame()
		{
			if (!this.IsLightSequenceLoop)
			{
				return;
			}
			FMovieSceneSequencePlaybackParams playbackPosition = new FMovieSceneSequencePlaybackParams(new FFrameTime(new FFrameNumber(UiSceneManager.Instance.GetUiStartSequenceFrame()), 0f), 0f, "", EMovieScenePositionType.Frame, EUpdatePositionMethod.Jump);
			this.ShowSequencePlayer.SetPlaybackPosition(playbackPosition);
		}

		// Token: 0x06032D17 RID: 208151 RVA: 0x00BD8405 File Offset: 0x00BD6605
		private void OnRoleDevTargetRoleIdChange()
		{
			this.RefreshRoleDevButtonVisibility();
		}

		// Token: 0x06032D18 RID: 208152 RVA: 0x00BD8410 File Offset: 0x00BD6610
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

		// Token: 0x06032D19 RID: 208153 RVA: 0x00BD8488 File Offset: 0x00BD6688
		private void OnSkillShowTagToggleClick(EToggleState state)
		{
			bool flag = state == EToggleState.ETT_Checked;
			RoleModel.Instance.IsShowSkillShowTag = flag;
			EventSystem.Instance.Emit<bool>(EEventName.OnSkillShowTagToggleChanged, flag);
			RoleController.Instance.LogRoleDevelopSkillRecommendClick(this.RoleViewAgent.GetCurSelectRoleData().GetDataId(), flag);
		}

		// Token: 0x06032D1A RID: 208154 RVA: 0x00BD84D1 File Offset: 0x00BD66D1
		private void OnSkillShowTagHelpButtonClick()
		{
			if (base.GetItem(15).bIsUIActive)
			{
				this.HideShowTagTips();
				return;
			}
			this.ShowShowTagTips();
		}

		// Token: 0x06032D1B RID: 208155 RVA: 0x00BD84F0 File Offset: 0x00BD66F0
		private UniTask ShowShowTagTips()
		{
			RoleRootView.<ShowShowTagTips>d__109 <ShowShowTagTips>d__;
			<ShowShowTagTips>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<ShowShowTagTips>d__.<>4__this = this;
			<ShowShowTagTips>d__.<>1__state = -1;
			<ShowShowTagTips>d__.<>t__builder.Start<RoleRootView.<ShowShowTagTips>d__109>(ref <ShowShowTagTips>d__);
			return <ShowShowTagTips>d__.<>t__builder.Task;
		}

		// Token: 0x06032D1C RID: 208156 RVA: 0x00BD8533 File Offset: 0x00BD6733
		private void HideShowTagTips()
		{
			base.GetItem(15).SetUIActive(false);
			if (this.ShowTagTipsMaskButton != null)
			{
				this.ShowTagTipsMaskButton.ResetItemParent();
				this.ShowTagTipsMaskButton.SetActive(false);
			}
		}

		// Token: 0x06032D1D RID: 208157 RVA: 0x00BD8562 File Offset: 0x00BD6762
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

		// Token: 0x0401B0BF RID: 110783
		[Nullable(2)]
		protected RoleBackgroundMusicSwitchItem RoleBackgroundMusicSwitchItem;

		// Token: 0x0401B0C0 RID: 110784
		[Nullable(2)]
		protected RoleListComponent RoleListComponent;

		// Token: 0x0401B0C1 RID: 110785
		[Nullable(2)]
		protected TabViewComponent<UiDynamicTab> TabViewComponent;

		// Token: 0x0401B0C2 RID: 110786
		[Nullable(new byte[]
		{
			2,
			1
		})]
		protected TabComponentWithCaptionItem<RoleTabItem> TabComponent;

		// Token: 0x0401B0C3 RID: 110787
		[Nullable(2)]
		private TsUiSceneRoleActor TsUiSceneRoleActor;

		// Token: 0x0401B0C4 RID: 110788
		protected List<UiDynamicTab> TabDataList = new List<UiDynamicTab>();

		// Token: 0x0401B0C5 RID: 110789
		private int FloorEffect;

		// Token: 0x0401B0C6 RID: 110790
		[Nullable(2)]
		protected UiCameraHandleData RoleRootUiCameraHandleData;

		// Token: 0x0401B0C7 RID: 110791
		private int CurSelectTabIndex;

		// Token: 0x0401B0C8 RID: 110792
		private EUiTabViewName? CurSelectTabView;

		// Token: 0x0401B0C9 RID: 110793
		[Nullable(2)]
		private ULevelSequencePlayer ShowSequencePlayer;

		// Token: 0x0401B0CA RID: 110794
		private int ClickTimes;

		// Token: 0x0401B0CB RID: 110795
		private double? LastClickTime;

		// Token: 0x0401B0CC RID: 110796
		private bool IsLightSequenceLoop = true;

		// Token: 0x0401B0CD RID: 110797
		private readonly Dictionary<int, ALevelSequenceActor> LevelSequenceActorCache = new Dictionary<int, ALevelSequenceActor>();

		// Token: 0x0401B0CE RID: 110798
		private readonly Dictionary<int, int> LevelSequenceActorLoadStatus = new Dictionary<int, int>();

		// Token: 0x0401B0CF RID: 110799
		private bool CanCameraInput;

		// Token: 0x0401B0D0 RID: 110800
		[Nullable(2)]
		private UiCameraControlRotationComponent UiCameraControlRotationComponent;

		// Token: 0x0401B0D1 RID: 110801
		[Nullable(2)]
		private RoleViewAgent RoleViewAgent;

		// Token: 0x0401B0D2 RID: 110802
		private readonly Queue<OperationParam> ViewOperationQueue = new Queue<OperationParam>(4);

		// Token: 0x0401B0D3 RID: 110803
		private bool Operating;

		// Token: 0x0401B0D4 RID: 110804
		private bool CanHandleLoadScene = true;

		// Token: 0x0401B0D5 RID: 110805
		private RoleDevelopEntranceItem RoleDevelopEntranceItem;

		// Token: 0x0401B0D6 RID: 110806
		[Nullable(2)]
		private DynamicMaskButton ShowTagTipsMaskButton;

		// Token: 0x0401B0D7 RID: 110807
		private FVector? CurrentDragPosition;
	}
}
