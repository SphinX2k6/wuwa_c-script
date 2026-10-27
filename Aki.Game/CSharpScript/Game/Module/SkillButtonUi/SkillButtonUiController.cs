using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Core.Common;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Input;
using CSharpScript.Game.Module.Battle;
using CSharpScript.Game.Module.BattleUi;
using CSharpScript.Game.Module.RoleUi;
using CSharpScript.Game.Ui;

namespace CSharpScript.Game.Module.SkillButtonUi
{
	// Token: 0x02004C0C RID: 19468
	[NullableContext(1)]
	[Nullable(0)]
	public class SkillButtonUiController : UiControllerBase
	{
		// Token: 0x0603261B RID: 206363 RVA: 0x00BBA8BA File Offset: 0x00BB8ABA
		protected override bool OnInit()
		{
			return true;
		}

		// Token: 0x0603261C RID: 206364 RVA: 0x00BBA8BD File Offset: 0x00BB8ABD
		protected override bool OnClear()
		{
			this.EventInterfaceMap.Clear();
			return true;
		}

		// Token: 0x0603261D RID: 206365 RVA: 0x00BBA8CC File Offset: 0x00BB8ACC
		protected override void OnAddEvents()
		{
			EventSystem.Instance.Add<EntityHandle, EntityHandle>(EEventName.OnChangeRole, new Action<EntityHandle, EntityHandle>(this.OnChangeRole));
			EventSystem instance = EventSystem.Instance;
			EEventName name = EEventName.OnUpdateSceneTeam;
			Action handle;
			if ((handle = SkillButtonUiController.<>O.<0>__OnFormationLoaded) == null)
			{
				handle = (SkillButtonUiController.<>O.<0>__OnFormationLoaded = new Action(SkillButtonUiController.OnFormationLoaded));
			}
			instance.Add(name, handle);
			EventSystem.Instance.Add<global::EOperationType, global::EOperationType>(EEventName.ShowTypeChange, new Action<global::EOperationType, global::EOperationType>(this.ShowTypeChange));
			EventSystem instance2 = EventSystem.Instance;
			EEventName name2 = EEventName.RemoveEntity;
			Action<ERemoveEntityType, EntityHandle> handle2;
			if ((handle2 = SkillButtonUiController.<>O.<1>__OnRemoveEntity) == null)
			{
				handle2 = (SkillButtonUiController.<>O.<1>__OnRemoveEntity = new Action<ERemoveEntityType, EntityHandle>(SkillButtonUiController.OnRemoveEntity));
			}
			instance2.Add<ERemoveEntityType, EntityHandle>(name2, handle2);
			EventSystem instance3 = EventSystem.Instance;
			EEventName name3 = EEventName.OnMultiSkillIdChanged;
			Action<int, MultiSkillInfo, int> handle3;
			if ((handle3 = SkillButtonUiController.<>O.<2>__MultiSkillIdChanged) == null)
			{
				handle3 = (SkillButtonUiController.<>O.<2>__MultiSkillIdChanged = new Action<int, MultiSkillInfo, int>(SkillButtonUiController.MultiSkillIdChanged));
			}
			instance3.Add(name3, handle3);
			EventSystem instance4 = EventSystem.Instance;
			EEventName name4 = EEventName.OnMultiSkillEnable;
			Action<int, MultiSkillInfo, int> handle4;
			if ((handle4 = SkillButtonUiController.<>O.<3>__MultiSkillEnable) == null)
			{
				handle4 = (SkillButtonUiController.<>O.<3>__MultiSkillEnable = new Action<int, MultiSkillInfo, int>(SkillButtonUiController.MultiSkillEnable));
			}
			instance4.Add(name4, handle4);
			EventSystem.Instance.Add(EEventName.OnChangeSelectedExploreId, new Action(this.OnEquipExplorePhantomSkill));
			EventSystem.Instance.Add(EEventName.CharSkillCountChanged, new Action<GroupSkillCdInfo>(this.OnSkillCountChanged));
			EventSystem.Instance.Add(EEventName.CharSkillRemainCdChanged, new Action<GroupSkillCdInfo>(this.OnSkillRemainCdChanged));
			EventSystem instance5 = EventSystem.Instance;
			EEventName name5 = EEventName.OnAimStateChanged;
			Action handle5;
			if ((handle5 = SkillButtonUiController.<>O.<4>__OnAimStateChanged) == null)
			{
				handle5 = (SkillButtonUiController.<>O.<4>__OnAimStateChanged = new Action(SkillButtonUiController.OnAimStateChanged));
			}
			instance5.Add(name5, handle5);
			EventSystem instance6 = EventSystem.Instance;
			EEventName name6 = EEventName.BattleUiFollowerAimStateChanged;
			Action<bool, bool> handle6;
			if ((handle6 = SkillButtonUiController.<>O.<5>__OnBattleUiFollowerAimStateChanged) == null)
			{
				handle6 = (SkillButtonUiController.<>O.<5>__OnBattleUiFollowerAimStateChanged = new Action<bool, bool>(SkillButtonUiController.OnBattleUiFollowerAimStateChanged));
			}
			instance6.Add<bool, bool>(name6, handle6);
			EventSystem instance7 = EventSystem.Instance;
			EEventName name7 = EEventName.OnActionKeyChanged;
			Action<string> handle7;
			if ((handle7 = SkillButtonUiController.<>O.<6>__OnActionKeyChanged) == null)
			{
				handle7 = (SkillButtonUiController.<>O.<6>__OnActionKeyChanged = new Action<string>(SkillButtonUiController.OnActionKeyChanged));
			}
			instance7.Add(name7, handle7);
			EventSystem instance8 = EventSystem.Instance;
			EEventName name8 = EEventName.BattleInputEnableChanged;
			Action<EInputAction, bool> handle8;
			if ((handle8 = SkillButtonUiController.<>O.<7>__OnInputEnableChanged) == null)
			{
				handle8 = (SkillButtonUiController.<>O.<7>__OnInputEnableChanged = new Action<EInputAction, bool>(SkillButtonUiController.OnInputEnableChanged));
			}
			instance8.Add<EInputAction, bool>(name8, handle8);
			EventSystem instance9 = EventSystem.Instance;
			EEventName name9 = EEventName.BattleInputVisibleChanged;
			Action<EInputAction, bool> handle9;
			if ((handle9 = SkillButtonUiController.<>O.<8>__OnInputVisibleChanged) == null)
			{
				handle9 = (SkillButtonUiController.<>O.<8>__OnInputVisibleChanged = new Action<EInputAction, bool>(SkillButtonUiController.OnInputVisibleChanged));
			}
			instance9.Add<EInputAction, bool>(name9, handle9);
			EventSystem instance10 = EventSystem.Instance;
			EEventName name10 = EEventName.BattleUiFollowerAimStateChanged;
			Action<bool, bool> handle10;
			if ((handle10 = SkillButtonUiController.<>O.<9>__OnFollowerAimStateChanged) == null)
			{
				handle10 = (SkillButtonUiController.<>O.<9>__OnFollowerAimStateChanged = new Action<bool, bool>(SkillButtonUiController.OnFollowerAimStateChanged));
			}
			instance10.Add<bool, bool>(name10, handle10);
			EventSystem instance11 = EventSystem.Instance;
			EEventName name11 = EEventName.OnPlayerFollowerPossessed;
			Action<EntityHandle> handle11;
			if ((handle11 = SkillButtonUiController.<>O.<10>__OnFollowShooterPossessed) == null)
			{
				handle11 = (SkillButtonUiController.<>O.<10>__OnFollowShooterPossessed = new Action<EntityHandle>(SkillButtonUiController.OnFollowShooterPossessed));
			}
			instance11.Add(name11, handle11);
			EventSystem instance12 = EventSystem.Instance;
			EEventName name12 = EEventName.OnPlayerFollowerUnPossessed;
			Action handle12;
			if ((handle12 = SkillButtonUiController.<>O.<11>__OnFollowShooterUnPossessed) == null)
			{
				handle12 = (SkillButtonUiController.<>O.<11>__OnFollowShooterUnPossessed = new Action(SkillButtonUiController.OnFollowShooterUnPossessed));
			}
			instance12.Add(name12, handle12);
			EventSystem instance13 = EventSystem.Instance;
			EEventName name13 = EEventName.OnEnterVehicle;
			Action<VehiclePassengerInfo, bool> handle13;
			if ((handle13 = SkillButtonUiController.<>O.<12>__OnEnterVehicle) == null)
			{
				handle13 = (SkillButtonUiController.<>O.<12>__OnEnterVehicle = new Action<VehiclePassengerInfo, bool>(SkillButtonUiController.OnEnterVehicle));
			}
			instance13.Add<VehiclePassengerInfo, bool>(name13, handle13);
			EventSystem instance14 = EventSystem.Instance;
			EEventName name14 = EEventName.OnLeaveVehicle;
			Action<VehiclePassengerInfo, bool> handle14;
			if ((handle14 = SkillButtonUiController.<>O.<13>__OnLeaveVehicle) == null)
			{
				handle14 = (SkillButtonUiController.<>O.<13>__OnLeaveVehicle = new Action<VehiclePassengerInfo, bool>(SkillButtonUiController.OnLeaveVehicle));
			}
			instance14.Add<VehiclePassengerInfo, bool>(name14, handle14);
			EventSystem instance15 = EventSystem.Instance;
			EEventName name15 = EEventName.OpenView;
			Action<EUiViewName, int> handle15;
			if ((handle15 = SkillButtonUiController.<>O.<14>__OnOpenView) == null)
			{
				handle15 = (SkillButtonUiController.<>O.<14>__OnOpenView = new Action<EUiViewName, int>(SkillButtonUiController.OnOpenView));
			}
			instance15.Add<EUiViewName, int>(name15, handle15);
			EventSystem instance16 = EventSystem.Instance;
			EEventName name16 = EEventName.CloseView;
			Action<EUiViewName, int> handle16;
			if ((handle16 = SkillButtonUiController.<>O.<15>__OnCloseView) == null)
			{
				handle16 = (SkillButtonUiController.<>O.<15>__OnCloseView = new Action<EUiViewName, int>(SkillButtonUiController.OnCloseView));
			}
			instance16.Add<EUiViewName, int>(name16, handle16);
			EventSystem.Instance.Add(EEventName.GuideLimitActionInput, new Action<string, bool>(this.OnGuideLimitActionInput));
			EventSystem.Instance.Add<bool>(EEventName.BattleUiMotorcycleStateChanged, new Action<bool>(this.OnBattleUiMotorcycleStateChanged));
			EventSystem instance17 = EventSystem.Instance;
			EEventName name17 = EEventName.InputControllerChange;
			Action<EInputControllerType, EInputControllerType> handle17;
			if ((handle17 = SkillButtonUiController.<>O.<16>__InputControllerChange) == null)
			{
				handle17 = (SkillButtonUiController.<>O.<16>__InputControllerChange = new Action<EInputControllerType, EInputControllerType>(SkillButtonUiController.InputControllerChange));
			}
			instance17.Add<EInputControllerType, EInputControllerType>(name17, handle17);
			InputDistributeController.Instance.BindAction("组合主键", new TInputHandle<InputDistributeDefine.EActionType>(this.OnInputCombineButton));
			InputDistributeController.Instance.BindActionIgnoreLimit("通用交互", new TInputHandle<InputDistributeDefine.EActionType>(this.OnInputInteractButton));
		}

		// Token: 0x0603261E RID: 206366 RVA: 0x00BBAC9C File Offset: 0x00BB8E9C
		protected override void OnRemoveEvents()
		{
			EventSystem.Instance.Remove(EEventName.OnChangeRole, new Action<EntityHandle, EntityHandle>(this.OnChangeRole));
			EventSystem instance = EventSystem.Instance;
			EEventName name = EEventName.OnUpdateSceneTeam;
			Action handle;
			if ((handle = SkillButtonUiController.<>O.<0>__OnFormationLoaded) == null)
			{
				handle = (SkillButtonUiController.<>O.<0>__OnFormationLoaded = new Action(SkillButtonUiController.OnFormationLoaded));
			}
			instance.Remove(name, handle);
			EventSystem.Instance.Remove(EEventName.ShowTypeChange, new Action<global::EOperationType, global::EOperationType>(this.ShowTypeChange));
			EventSystem instance2 = EventSystem.Instance;
			EEventName name2 = EEventName.RemoveEntity;
			Action<ERemoveEntityType, EntityHandle> handle2;
			if ((handle2 = SkillButtonUiController.<>O.<1>__OnRemoveEntity) == null)
			{
				Action<ERemoveEntityType, EntityHandle> action = SkillButtonUiController.<>O.<1>__OnRemoveEntity = new Action<ERemoveEntityType, EntityHandle>(SkillButtonUiController.OnRemoveEntity);
				handle2 = action;
			}
			instance2.Remove(name2, handle2);
			EventSystem instance3 = EventSystem.Instance;
			EEventName name3 = EEventName.OnMultiSkillIdChanged;
			Action<int, MultiSkillInfo, int> handle3;
			if ((handle3 = SkillButtonUiController.<>O.<2>__MultiSkillIdChanged) == null)
			{
				handle3 = (SkillButtonUiController.<>O.<2>__MultiSkillIdChanged = new Action<int, MultiSkillInfo, int>(SkillButtonUiController.MultiSkillIdChanged));
			}
			instance3.Remove(name3, handle3);
			EventSystem instance4 = EventSystem.Instance;
			EEventName name4 = EEventName.OnMultiSkillEnable;
			Action<int, MultiSkillInfo, int> handle4;
			if ((handle4 = SkillButtonUiController.<>O.<3>__MultiSkillEnable) == null)
			{
				handle4 = (SkillButtonUiController.<>O.<3>__MultiSkillEnable = new Action<int, MultiSkillInfo, int>(SkillButtonUiController.MultiSkillEnable));
			}
			instance4.Remove(name4, handle4);
			EventSystem.Instance.Remove(EEventName.OnChangeSelectedExploreId, new Action(this.OnEquipExplorePhantomSkill));
			EventSystem.Instance.Remove(EEventName.CharSkillCountChanged, new Action<GroupSkillCdInfo>(this.OnSkillCountChanged));
			EventSystem.Instance.Remove(EEventName.CharSkillRemainCdChanged, new Action<GroupSkillCdInfo>(this.OnSkillRemainCdChanged));
			EventSystem instance5 = EventSystem.Instance;
			EEventName name5 = EEventName.OnAimStateChanged;
			Action handle5;
			if ((handle5 = SkillButtonUiController.<>O.<4>__OnAimStateChanged) == null)
			{
				handle5 = (SkillButtonUiController.<>O.<4>__OnAimStateChanged = new Action(SkillButtonUiController.OnAimStateChanged));
			}
			instance5.Remove(name5, handle5);
			EventSystem instance6 = EventSystem.Instance;
			EEventName name6 = EEventName.BattleUiFollowerAimStateChanged;
			Action<bool, bool> handle6;
			if ((handle6 = SkillButtonUiController.<>O.<5>__OnBattleUiFollowerAimStateChanged) == null)
			{
				handle6 = (SkillButtonUiController.<>O.<5>__OnBattleUiFollowerAimStateChanged = new Action<bool, bool>(SkillButtonUiController.OnBattleUiFollowerAimStateChanged));
			}
			instance6.Remove(name6, handle6);
			EventSystem instance7 = EventSystem.Instance;
			EEventName name7 = EEventName.OnActionKeyChanged;
			Action<string> handle7;
			if ((handle7 = SkillButtonUiController.<>O.<6>__OnActionKeyChanged) == null)
			{
				handle7 = (SkillButtonUiController.<>O.<6>__OnActionKeyChanged = new Action<string>(SkillButtonUiController.OnActionKeyChanged));
			}
			instance7.Remove(name7, handle7);
			EventSystem instance8 = EventSystem.Instance;
			EEventName name8 = EEventName.BattleInputEnableChanged;
			Action<EInputAction, bool> handle8;
			if ((handle8 = SkillButtonUiController.<>O.<7>__OnInputEnableChanged) == null)
			{
				handle8 = (SkillButtonUiController.<>O.<7>__OnInputEnableChanged = new Action<EInputAction, bool>(SkillButtonUiController.OnInputEnableChanged));
			}
			instance8.Remove(name8, handle8);
			EventSystem instance9 = EventSystem.Instance;
			EEventName name9 = EEventName.BattleInputVisibleChanged;
			Action<EInputAction, bool> handle9;
			if ((handle9 = SkillButtonUiController.<>O.<8>__OnInputVisibleChanged) == null)
			{
				handle9 = (SkillButtonUiController.<>O.<8>__OnInputVisibleChanged = new Action<EInputAction, bool>(SkillButtonUiController.OnInputVisibleChanged));
			}
			instance9.Remove(name9, handle9);
			EventSystem instance10 = EventSystem.Instance;
			EEventName name10 = EEventName.BattleUiFollowerAimStateChanged;
			Action<bool, bool> handle10;
			if ((handle10 = SkillButtonUiController.<>O.<9>__OnFollowerAimStateChanged) == null)
			{
				handle10 = (SkillButtonUiController.<>O.<9>__OnFollowerAimStateChanged = new Action<bool, bool>(SkillButtonUiController.OnFollowerAimStateChanged));
			}
			instance10.Remove(name10, handle10);
			EventSystem instance11 = EventSystem.Instance;
			EEventName name11 = EEventName.OnPlayerFollowerPossessed;
			Action<EntityHandle> handle11;
			if ((handle11 = SkillButtonUiController.<>O.<10>__OnFollowShooterPossessed) == null)
			{
				handle11 = (SkillButtonUiController.<>O.<10>__OnFollowShooterPossessed = new Action<EntityHandle>(SkillButtonUiController.OnFollowShooterPossessed));
			}
			instance11.Remove(name11, handle11);
			EventSystem instance12 = EventSystem.Instance;
			EEventName name12 = EEventName.OnPlayerFollowerUnPossessed;
			Action handle12;
			if ((handle12 = SkillButtonUiController.<>O.<11>__OnFollowShooterUnPossessed) == null)
			{
				handle12 = (SkillButtonUiController.<>O.<11>__OnFollowShooterUnPossessed = new Action(SkillButtonUiController.OnFollowShooterUnPossessed));
			}
			instance12.Remove(name12, handle12);
			EventSystem instance13 = EventSystem.Instance;
			EEventName name13 = EEventName.OnEnterVehicle;
			Action<VehiclePassengerInfo, bool> handle13;
			if ((handle13 = SkillButtonUiController.<>O.<12>__OnEnterVehicle) == null)
			{
				handle13 = (SkillButtonUiController.<>O.<12>__OnEnterVehicle = new Action<VehiclePassengerInfo, bool>(SkillButtonUiController.OnEnterVehicle));
			}
			instance13.Remove<VehiclePassengerInfo, bool>(name13, handle13);
			EventSystem instance14 = EventSystem.Instance;
			EEventName name14 = EEventName.OnLeaveVehicle;
			Action<VehiclePassengerInfo, bool> handle14;
			if ((handle14 = SkillButtonUiController.<>O.<13>__OnLeaveVehicle) == null)
			{
				handle14 = (SkillButtonUiController.<>O.<13>__OnLeaveVehicle = new Action<VehiclePassengerInfo, bool>(SkillButtonUiController.OnLeaveVehicle));
			}
			instance14.Remove<VehiclePassengerInfo, bool>(name14, handle14);
			EventSystem instance15 = EventSystem.Instance;
			EEventName name15 = EEventName.OpenView;
			Action<EUiViewName, int> handle15;
			if ((handle15 = SkillButtonUiController.<>O.<14>__OnOpenView) == null)
			{
				handle15 = (SkillButtonUiController.<>O.<14>__OnOpenView = new Action<EUiViewName, int>(SkillButtonUiController.OnOpenView));
			}
			instance15.Remove(name15, handle15);
			EventSystem instance16 = EventSystem.Instance;
			EEventName name16 = EEventName.CloseView;
			Action<EUiViewName, int> handle16;
			if ((handle16 = SkillButtonUiController.<>O.<15>__OnCloseView) == null)
			{
				handle16 = (SkillButtonUiController.<>O.<15>__OnCloseView = new Action<EUiViewName, int>(SkillButtonUiController.OnCloseView));
			}
			instance16.Remove(name16, handle16);
			EventSystem.Instance.Remove(EEventName.GuideLimitActionInput, new Action<string, bool>(this.OnGuideLimitActionInput));
			EventSystem.Instance.Remove(EEventName.BattleUiMotorcycleStateChanged, new Action<bool>(this.OnBattleUiMotorcycleStateChanged));
			EventSystem instance17 = EventSystem.Instance;
			EEventName name17 = EEventName.InputControllerChange;
			Action<EInputControllerType, EInputControllerType> handle17;
			if ((handle17 = SkillButtonUiController.<>O.<16>__InputControllerChange) == null)
			{
				handle17 = (SkillButtonUiController.<>O.<16>__InputControllerChange = new Action<EInputControllerType, EInputControllerType>(SkillButtonUiController.InputControllerChange));
			}
			instance17.Remove(name17, handle17);
			InputDistributeController.Instance.UnBindAction("组合主键", new TInputHandle<InputDistributeDefine.EActionType>(this.OnInputCombineButton));
			InputDistributeController.Instance.UnBindActionIgnoreLimit("通用交互", new TInputHandle<InputDistributeDefine.EActionType>(this.OnInputInteractButton));
		}

		// Token: 0x0603261F RID: 206367 RVA: 0x00BBB06D File Offset: 0x00BB926D
		[NullableContext(2)]
		private static void MultiSkillIdChanged(int entityId, MultiSkillInfo info, int visionEntityId)
		{
			SkillButtonUiModel.Instance.ExecuteMultiSkillIdChanged(entityId, info, visionEntityId);
		}

		// Token: 0x06032620 RID: 206368 RVA: 0x00BBB07C File Offset: 0x00BB927C
		[NullableContext(2)]
		private static void MultiSkillEnable(int entityId, MultiSkillInfo info, int visionEntityId)
		{
			SkillButtonUiModel.Instance.ExecuteMultiSkillEnable(entityId, info, visionEntityId);
		}

		// Token: 0x06032621 RID: 206369 RVA: 0x00BBB08B File Offset: 0x00BB928B
		private void OnChangeRole(EntityHandle newEntityHandle, [Nullable(2)] EntityHandle oldEntityHandle)
		{
			SkillButtonUiController.RefreshSkillButtonData(newEntityHandle, ESkillButtonRefreshReason.ChangeRole);
		}

		// Token: 0x06032622 RID: 206370 RVA: 0x00BBB094 File Offset: 0x00BB9294
		private static void OnFormationLoaded()
		{
			SkillButtonUiModel.Instance.CheckAndRemoveInvalidEntityData();
			SkillButtonUiModel.Instance.CreateAllSkillButtonEntityData();
		}

		// Token: 0x06032623 RID: 206371 RVA: 0x00BBB0AC File Offset: 0x00BB92AC
		private void ShowTypeChange(global::EOperationType eOperationType, global::EOperationType operationType)
		{
			SkillButtonUiModel.Instance.RefreshSkillButtonIndexOnOperationTypeChanged();
			EntityHandle getCurrentEntity = SceneTeamModel.Instance.GetCurrentEntity;
			if (getCurrentEntity == null)
			{
				return;
			}
			SkillButtonUiController.RefreshSkillButtonData(getCurrentEntity, ESkillButtonRefreshReason.None);
		}

		// Token: 0x06032624 RID: 206372 RVA: 0x00BBB0D9 File Offset: 0x00BB92D9
		[NullableContext(2)]
		private static void OnRemoveEntity(ERemoveEntityType removeType, EntityHandle handle)
		{
			SkillButtonUiModel.Instance.OnRemoveEntity(handle);
		}

		// Token: 0x06032625 RID: 206373 RVA: 0x00BBB0E8 File Offset: 0x00BB92E8
		[NullableContext(2)]
		private static void RefreshSkillButtonData(EntityHandle entityHandle, ESkillButtonRefreshReason refreshReason = ESkillButtonRefreshReason.None)
		{
			bool desktopOrPad = Info.Instance.OperationType == global::EOperationType.Desktop;
			SkillButtonUiModel.Instance.RefreshSkillButtonData(entityHandle, desktopOrPad, refreshReason);
		}

		// Token: 0x06032626 RID: 206374 RVA: 0x00BBB110 File Offset: 0x00BB9310
		[NullableContext(2)]
		public int GetRoleId(Entity entity)
		{
			CreatureDataComponent component = entity.GetComponent<CreatureDataComponent>();
			if (component == null)
			{
				return 0;
			}
			int roleId = component.GetRoleId();
			return RoleConfig.Instance.GetBaseRoleId(roleId);
		}

		// Token: 0x06032627 RID: 206375 RVA: 0x00BBB13B File Offset: 0x00BB933B
		public void AddEventInterface(ISkillButtonUiEventInterface eventInterface)
		{
			if (eventInterface == null)
			{
				return;
			}
			this.EventInterfaceMap.Add(eventInterface);
		}

		// Token: 0x06032628 RID: 206376 RVA: 0x00BBB14E File Offset: 0x00BB934E
		public void RemoveEventInterface(ISkillButtonUiEventInterface eventInterface)
		{
			if (eventInterface == null)
			{
				return;
			}
			this.EventInterfaceMap.Remove(eventInterface);
		}

		// Token: 0x06032629 RID: 206377 RVA: 0x00BBB164 File Offset: 0x00BB9364
		private void OnEquipExplorePhantomSkill()
		{
			int currentExploreSkillId = RouletteModel.Instance.CurrentExploreSkillId;
			ExploreTools? exploreConfigById = RouletteConfig.Instance.GetExploreConfigById(currentExploreSkillId);
			if (exploreConfigById == null || exploreConfigById.Value.SkillType != 5)
			{
				SkillButtonUiModel.Instance.RefreshSkillButtonExplorePhantomSkillId(ESkillButtonType.幻象1);
			}
			foreach (ISkillButtonUiEventInterface skillButtonUiEventInterface in this.EventInterfaceMap)
			{
				skillButtonUiEventInterface.EquipExplorePhantomSkill();
			}
		}

		// Token: 0x0603262A RID: 206378 RVA: 0x00BBB1F4 File Offset: 0x00BB93F4
		[NullableContext(2)]
		private void OnSkillCountChanged(GroupSkillCdInfo groupSkillCdInfo)
		{
			SkillButtonUiModel.Instance.OnSkillCdChanged(groupSkillCdInfo);
			foreach (ISkillButtonUiEventInterface skillButtonUiEventInterface in this.EventInterfaceMap)
			{
				skillButtonUiEventInterface.SkillCountChanged(groupSkillCdInfo);
			}
		}

		// Token: 0x0603262B RID: 206379 RVA: 0x00BBB250 File Offset: 0x00BB9450
		[NullableContext(2)]
		private void OnSkillRemainCdChanged(GroupSkillCdInfo groupSkillCdInfo)
		{
			SkillButtonUiModel.Instance.OnSkillCdChanged(groupSkillCdInfo);
			foreach (ISkillButtonUiEventInterface skillButtonUiEventInterface in this.EventInterfaceMap)
			{
				skillButtonUiEventInterface.SkillRemainCdChanged(groupSkillCdInfo);
			}
		}

		// Token: 0x0603262C RID: 206380 RVA: 0x00BBB2AC File Offset: 0x00BB94AC
		private static void OnBattleUiFollowerAimStateChanged(bool b, bool b1)
		{
			SkillButtonUiController.OnAimStateChanged();
		}

		// Token: 0x0603262D RID: 206381 RVA: 0x00BBB2B3 File Offset: 0x00BB94B3
		private static void OnAimStateChanged()
		{
			SkillButtonUiModel.Instance.OnAimStateChanged();
		}

		// Token: 0x0603262E RID: 206382 RVA: 0x00BBB2BF File Offset: 0x00BB94BF
		private static void OnActionKeyChanged(string actionName)
		{
			SkillButtonUiModel.Instance.OnActionKeyChanged(actionName);
		}

		// Token: 0x0603262F RID: 206383 RVA: 0x00BBB2CC File Offset: 0x00BB94CC
		private static void OnInputEnableChanged(EInputAction inputAction, bool enable)
		{
			SkillButtonUiModel.Instance.OnInputEnableChanged(inputAction, enable);
		}

		// Token: 0x06032630 RID: 206384 RVA: 0x00BBB2DA File Offset: 0x00BB94DA
		private static void OnFollowerAimStateChanged(bool isAiming, bool b)
		{
			SkillButtonFormationData skillButtonFormationData = SkillButtonUiModel.Instance.SkillButtonFormationData;
			if (skillButtonFormationData == null)
			{
				return;
			}
			skillButtonFormationData.RefreshOnFollowerAimStateChange(isAiming);
		}

		// Token: 0x06032631 RID: 206385 RVA: 0x00BBB2F1 File Offset: 0x00BB94F1
		private static void OnInputVisibleChanged(EInputAction inputAction, bool visible)
		{
			SkillButtonUiModel.Instance.OnInputVisibleChanged(inputAction, visible);
		}

		// Token: 0x06032632 RID: 206386 RVA: 0x00BBB2FF File Offset: 0x00BB94FF
		private static void OnFollowShooterPossessed(EntityHandle follower)
		{
			SkillButtonUiModel.Instance.CreateSkillButtonFollowerEntityData(follower);
		}

		// Token: 0x06032633 RID: 206387 RVA: 0x00BBB30C File Offset: 0x00BB950C
		private static void OnFollowShooterUnPossessed()
		{
			SkillButtonUiModel.Instance.ClearSkillButtonFollowerEntityData();
		}

		// Token: 0x06032634 RID: 206388 RVA: 0x00BBB318 File Offset: 0x00BB9518
		private static void OnEnterVehicle(VehiclePassengerInfo info, bool byChangeRole)
		{
			if (!info.IsRolePassenger(true))
			{
				return;
			}
			CreatureModel instance = CreatureModel.Instance;
			Entity vehicleEntity = info.VehicleEntity;
			EntityHandle entityById = instance.GetEntityById((vehicleEntity != null) ? vehicleEntity.Id : 0);
			if (entityById != null && entityById.Valid)
			{
				SkillButtonUiModel.Instance.CreateSkillButtonVehicleEntityData(entityById, info.VehicleType);
			}
		}

		// Token: 0x06032635 RID: 206389 RVA: 0x00BBB368 File Offset: 0x00BB9568
		private static void OnLeaveVehicle(VehiclePassengerInfo info, bool byChangeRole)
		{
			if (!info.IsRolePassenger(true))
			{
				return;
			}
			SkillButtonUiModel.Instance.ClearSkillButtonVehicleEntityData();
		}

		// Token: 0x06032636 RID: 206390 RVA: 0x00BBB380 File Offset: 0x00BB9580
		private static void OnOpenView(EUiViewName viewName, int viewId)
		{
			if (viewName == EUiViewName.MenuView)
			{
				foreach (SkillButtonUiGamepadDataBase skillButtonUiGamepadDataBase in SkillButtonUiModel.Instance.GamepadDataMap.Values)
				{
					skillButtonUiGamepadDataBase.AddChangeKeyReason(EGamepadChangeKeyReason.MenuView);
				}
			}
		}

		// Token: 0x06032637 RID: 206391 RVA: 0x00BBB3E8 File Offset: 0x00BB95E8
		private static void OnCloseView(EUiViewName viewName, int viewId)
		{
			if (viewName == EUiViewName.MenuView)
			{
				foreach (SkillButtonUiGamepadDataBase skillButtonUiGamepadDataBase in SkillButtonUiModel.Instance.GamepadDataMap.Values)
				{
					skillButtonUiGamepadDataBase.RemoveChangeKeyReason(EGamepadChangeKeyReason.MenuView);
					skillButtonUiGamepadDataBase.RefreshSwitchInteractOpen(false);
				}
			}
		}

		// Token: 0x06032638 RID: 206392 RVA: 0x00BBB458 File Offset: 0x00BB9658
		private void HandlePressCombineButton(string actionName, bool bPress)
		{
			if (actionName != "组合主键")
			{
				return;
			}
			BattleUiMotorcycleData motorcycleData = BattleUiModel.Instance.MotorcycleData;
			if (motorcycleData != null && motorcycleData.LastDriving)
			{
				this.SetIsPressMotorcycleCombineButton(bPress);
				return;
			}
			this.SetIsPressCombineButton(bPress);
		}

		// Token: 0x06032639 RID: 206393 RVA: 0x00BBB48F File Offset: 0x00BB968F
		private void OnGuideLimitActionInput(string actionName, bool bPress)
		{
			this.HandlePressCombineButton(actionName, bPress);
		}

		// Token: 0x0603263A RID: 206394 RVA: 0x00BBB49C File Offset: 0x00BB969C
		private void OnBattleUiMotorcycleStateChanged(bool isDriving)
		{
			if (InputDistributeModel.Instance.IsActionInPress("组合主键"))
			{
				if (this.StatusType == ESkillButtonStatusType.Motorcycle)
				{
					this.SetIsPressMotorcycleCombineButton(false);
					this.SetIsPressCombineButton(true);
					return;
				}
				if (this.StatusType == ESkillButtonStatusType.Normal)
				{
					this.SetIsPressCombineButton(false);
					this.SetIsPressMotorcycleCombineButton(true);
				}
			}
		}

		// Token: 0x0603263B RID: 206395 RVA: 0x00BBB4E8 File Offset: 0x00BB96E8
		private static void InputControllerChange(EInputControllerType last, EInputControllerType now)
		{
			SkillButtonUiModel.Instance.OnInputControllerChange(last, now);
		}

		// Token: 0x0603263C RID: 206396 RVA: 0x00BBB4F6 File Offset: 0x00BB96F6
		private void OnInputCombineButton(string actionName, InputDistributeDefine.EActionType actionType, InputIdentification inputIdentification)
		{
			this.HandlePressCombineButton(actionName, actionType == InputDistributeDefine.EActionType.Press);
		}

		// Token: 0x0603263D RID: 206397 RVA: 0x00BBB503 File Offset: 0x00BB9703
		private void SetIsPressCombineButton(bool isPress)
		{
			this.StatusType = ESkillButtonStatusType.Normal;
			SkillButtonUiGamepadDataBase gamepadDataByType = SkillButtonUiModel.Instance.GetGamepadDataByType(ESkillButtonGamepadDataType.Normal);
			if (gamepadDataByType != null)
			{
				gamepadDataByType.SetIsPressCombineButton(isPress);
			}
			EventSystem.Instance.Emit<bool>(EEventName.BattleUiPressCombineButtonChanged, isPress);
		}

		// Token: 0x0603263E RID: 206398 RVA: 0x00BBB534 File Offset: 0x00BB9734
		private void SetIsPressMotorcycleCombineButton(bool isPress)
		{
			this.StatusType = ESkillButtonStatusType.Motorcycle;
			SkillButtonUiGamepadDataBase gamepadDataByType = SkillButtonUiModel.Instance.GetGamepadDataByType(ESkillButtonGamepadDataType.Motorcycle);
			if (gamepadDataByType != null)
			{
				gamepadDataByType.SetIsPressCombineButton(isPress);
			}
			EventSystem.Instance.Emit<bool>(EEventName.BattleUiPressMotorcycleCombineButtonChanged, isPress);
		}

		// Token: 0x0603263F RID: 206399 RVA: 0x00BBB568 File Offset: 0x00BB9768
		private void OnInputInteractButton(string actionName, InputDistributeDefine.EActionType actionType, InputIdentification inputIdentification)
		{
			bool bPress = actionType == InputDistributeDefine.EActionType.Press;
			SkillButtonUiGamepadDataBase gamepadData = SkillButtonUiModel.Instance.GamepadData;
			if (gamepadData == null)
			{
				return;
			}
			gamepadData.SwitchInteractData.InputInteractButton(bPress);
		}

		// Token: 0x06032640 RID: 206400 RVA: 0x00BBB594 File Offset: 0x00BB9794
		public void PlayExtraEffect(ESkillButtonType buttonType, ESkillButtonExtraEffect effectType, float duration = 0f)
		{
			SkillButtonFormationData skillButtonFormationData = SkillButtonUiModel.Instance.SkillButtonFormationData;
			SkillButtonTypeFormationData skillButtonTypeFormationData = (skillButtonFormationData != null) ? skillButtonFormationData.GetSkillButtonTypeFormationData(buttonType) : null;
			if (skillButtonTypeFormationData == null)
			{
				return;
			}
			skillButtonTypeFormationData.ExtraEffect = effectType;
			skillButtonTypeFormationData.ExtraEffectDuration = duration;
			EventSystem.Instance.Emit<ESkillButtonType>(EEventName.OnSkillButtonExtraEffectRefresh, buttonType);
		}

		// Token: 0x17007C8B RID: 31883
		// (get) Token: 0x06032641 RID: 206401 RVA: 0x00BBB5DC File Offset: 0x00BB97DC
		public static SkillButtonUiController Instance
		{
			get
			{
				return SkillButtonUiController._Instance;
			}
		}

		// Token: 0x06032642 RID: 206402 RVA: 0x00BBB5E3 File Offset: 0x00BB97E3
		public static SkillButtonUiController GetOrCreateInstance()
		{
			if (SkillButtonUiController._Instance == null)
			{
				SkillButtonUiController.CreateInstance();
			}
			return SkillButtonUiController._Instance;
		}

		// Token: 0x06032643 RID: 206403 RVA: 0x00BBB5F7 File Offset: 0x00BB97F7
		public static bool CreateInstance()
		{
			if (SkillButtonUiController._Instance != null)
			{
				return true;
			}
			SkillButtonUiController._Instance = new SkillButtonUiController();
			return true;
		}

		// Token: 0x06032644 RID: 206404 RVA: 0x00BBB60D File Offset: 0x00BB980D
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x06032645 RID: 206405 RVA: 0x00BBB60F File Offset: 0x00BB980F
		public static void ResetStaticDefaultValue()
		{
			SkillButtonUiController._Instance = null;
		}

		// Token: 0x06032646 RID: 206406 RVA: 0x00BBB617 File Offset: 0x00BB9817
		static SkillButtonUiController()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(SkillButtonUiController.CreateStaticDefaultValue), new Action(SkillButtonUiController.ResetStaticDefaultValue));
		}

		// Token: 0x0401ACF9 RID: 109817
		private readonly Stat ChangeRoleStat = Stat.Create("[ChangeRole]SkillButtonUiController", "", "");

		// Token: 0x0401ACFA RID: 109818
		private readonly HashSet<ISkillButtonUiEventInterface> EventInterfaceMap = new HashSet<ISkillButtonUiEventInterface>();

		// Token: 0x0401ACFB RID: 109819
		private ESkillButtonStatusType StatusType;

		// Token: 0x0401ACFC RID: 109820
		[Nullable(2)]
		private static SkillButtonUiController _Instance;

		// Token: 0x0200ADF2 RID: 44530
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04034D56 RID: 216406
			[Nullable(0)]
			public static Action <0>__OnFormationLoaded;

			// Token: 0x04034D57 RID: 216407
			[Nullable(new byte[]
			{
				0,
				1
			})]
			public static Action<ERemoveEntityType, EntityHandle> <1>__OnRemoveEntity;

			// Token: 0x04034D58 RID: 216408
			[Nullable(new byte[]
			{
				0,
				2
			})]
			public static Action<int, MultiSkillInfo, int> <2>__MultiSkillIdChanged;

			// Token: 0x04034D59 RID: 216409
			[Nullable(new byte[]
			{
				0,
				2
			})]
			public static Action<int, MultiSkillInfo, int> <3>__MultiSkillEnable;

			// Token: 0x04034D5A RID: 216410
			[Nullable(0)]
			public static Action <4>__OnAimStateChanged;

			// Token: 0x04034D5B RID: 216411
			[Nullable(0)]
			public static Action<bool, bool> <5>__OnBattleUiFollowerAimStateChanged;

			// Token: 0x04034D5C RID: 216412
			[Nullable(new byte[]
			{
				0,
				1
			})]
			public static Action<string> <6>__OnActionKeyChanged;

			// Token: 0x04034D5D RID: 216413
			[Nullable(0)]
			public static Action<EInputAction, bool> <7>__OnInputEnableChanged;

			// Token: 0x04034D5E RID: 216414
			[Nullable(0)]
			public static Action<EInputAction, bool> <8>__OnInputVisibleChanged;

			// Token: 0x04034D5F RID: 216415
			[Nullable(0)]
			public static Action<bool, bool> <9>__OnFollowerAimStateChanged;

			// Token: 0x04034D60 RID: 216416
			[Nullable(new byte[]
			{
				0,
				1
			})]
			public static Action<EntityHandle> <10>__OnFollowShooterPossessed;

			// Token: 0x04034D61 RID: 216417
			[Nullable(0)]
			public static Action <11>__OnFollowShooterUnPossessed;

			// Token: 0x04034D62 RID: 216418
			[Nullable(new byte[]
			{
				0,
				1
			})]
			public static Action<VehiclePassengerInfo, bool> <12>__OnEnterVehicle;

			// Token: 0x04034D63 RID: 216419
			[Nullable(new byte[]
			{
				0,
				1
			})]
			public static Action<VehiclePassengerInfo, bool> <13>__OnLeaveVehicle;

			// Token: 0x04034D64 RID: 216420
			[Nullable(0)]
			public static Action<EUiViewName, int> <14>__OnOpenView;

			// Token: 0x04034D65 RID: 216421
			[Nullable(0)]
			public static Action<EUiViewName, int> <15>__OnCloseView;

			// Token: 0x04034D66 RID: 216422
			[Nullable(0)]
			public static Action<EInputControllerType, EInputControllerType> <16>__InputControllerChange;
		}
	}
}
