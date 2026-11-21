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
	// Token: 0x02003BBD RID: 15293
	[NullableContext(1)]
	[Nullable(0)]
	public class SkillButtonUiController : UiControllerBase
	{
		// Token: 0x060273CB RID: 160715 RVA: 0x00AFF43E File Offset: 0x00AFD63E
		protected override bool OnInit()
		{
			return true;
		}

		// Token: 0x060273CC RID: 160716 RVA: 0x00AFF441 File Offset: 0x00AFD641
		protected override bool OnClear()
		{
			this.EventInterfaceMap.Clear();
			return true;
		}

		// Token: 0x060273CD RID: 160717 RVA: 0x00AFF450 File Offset: 0x00AFD650
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

		// Token: 0x060273CE RID: 160718 RVA: 0x00AFF820 File Offset: 0x00AFDA20
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

		// Token: 0x060273CF RID: 160719 RVA: 0x00AFFBF1 File Offset: 0x00AFDDF1
		[NullableContext(2)]
		private static void MultiSkillIdChanged(int entityId, MultiSkillInfo info, int visionEntityId)
		{
			SkillButtonUiModel.Instance.ExecuteMultiSkillIdChanged(entityId, info, visionEntityId);
		}

		// Token: 0x060273D0 RID: 160720 RVA: 0x00AFFC00 File Offset: 0x00AFDE00
		[NullableContext(2)]
		private static void MultiSkillEnable(int entityId, MultiSkillInfo info, int visionEntityId)
		{
			SkillButtonUiModel.Instance.ExecuteMultiSkillEnable(entityId, info, visionEntityId);
		}

		// Token: 0x060273D1 RID: 160721 RVA: 0x00AFFC0F File Offset: 0x00AFDE0F
		private void OnChangeRole(EntityHandle newEntityHandle, [Nullable(2)] EntityHandle oldEntityHandle)
		{
			SkillButtonUiController.RefreshSkillButtonData(newEntityHandle, ESkillButtonRefreshReason.ChangeRole);
		}

		// Token: 0x060273D2 RID: 160722 RVA: 0x00AFFC18 File Offset: 0x00AFDE18
		private static void OnFormationLoaded()
		{
			SkillButtonUiModel.Instance.CheckAndRemoveInvalidEntityData();
			SkillButtonUiModel.Instance.CreateAllSkillButtonEntityData();
		}

		// Token: 0x060273D3 RID: 160723 RVA: 0x00AFFC30 File Offset: 0x00AFDE30
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

		// Token: 0x060273D4 RID: 160724 RVA: 0x00AFFC5D File Offset: 0x00AFDE5D
		[NullableContext(2)]
		private static void OnRemoveEntity(ERemoveEntityType removeType, EntityHandle handle)
		{
			SkillButtonUiModel.Instance.OnRemoveEntity(handle);
		}

		// Token: 0x060273D5 RID: 160725 RVA: 0x00AFFC6C File Offset: 0x00AFDE6C
		[NullableContext(2)]
		private static void RefreshSkillButtonData(EntityHandle entityHandle, ESkillButtonRefreshReason refreshReason = ESkillButtonRefreshReason.None)
		{
			bool desktopOrPad = Info.Instance.OperationType == global::EOperationType.Desktop;
			SkillButtonUiModel.Instance.RefreshSkillButtonData(entityHandle, desktopOrPad, refreshReason);
		}

		// Token: 0x060273D6 RID: 160726 RVA: 0x00AFFC94 File Offset: 0x00AFDE94
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

		// Token: 0x060273D7 RID: 160727 RVA: 0x00AFFCBF File Offset: 0x00AFDEBF
		public void AddEventInterface(ISkillButtonUiEventInterface eventInterface)
		{
			if (eventInterface == null)
			{
				return;
			}
			this.EventInterfaceMap.Add(eventInterface);
		}

		// Token: 0x060273D8 RID: 160728 RVA: 0x00AFFCD2 File Offset: 0x00AFDED2
		public void RemoveEventInterface(ISkillButtonUiEventInterface eventInterface)
		{
			if (eventInterface == null)
			{
				return;
			}
			this.EventInterfaceMap.Remove(eventInterface);
		}

		// Token: 0x060273D9 RID: 160729 RVA: 0x00AFFCE8 File Offset: 0x00AFDEE8
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

		// Token: 0x060273DA RID: 160730 RVA: 0x00AFFD78 File Offset: 0x00AFDF78
		[NullableContext(2)]
		private void OnSkillCountChanged(GroupSkillCdInfo groupSkillCdInfo)
		{
			SkillButtonUiModel.Instance.OnSkillCdChanged(groupSkillCdInfo);
			foreach (ISkillButtonUiEventInterface skillButtonUiEventInterface in this.EventInterfaceMap)
			{
				skillButtonUiEventInterface.SkillCountChanged(groupSkillCdInfo);
			}
		}

		// Token: 0x060273DB RID: 160731 RVA: 0x00AFFDD4 File Offset: 0x00AFDFD4
		[NullableContext(2)]
		private void OnSkillRemainCdChanged(GroupSkillCdInfo groupSkillCdInfo)
		{
			SkillButtonUiModel.Instance.OnSkillCdChanged(groupSkillCdInfo);
			foreach (ISkillButtonUiEventInterface skillButtonUiEventInterface in this.EventInterfaceMap)
			{
				skillButtonUiEventInterface.SkillRemainCdChanged(groupSkillCdInfo);
			}
		}

		// Token: 0x060273DC RID: 160732 RVA: 0x00AFFE30 File Offset: 0x00AFE030
		private static void OnBattleUiFollowerAimStateChanged(bool b, bool b1)
		{
			SkillButtonUiController.OnAimStateChanged();
		}

		// Token: 0x060273DD RID: 160733 RVA: 0x00AFFE37 File Offset: 0x00AFE037
		private static void OnAimStateChanged()
		{
			SkillButtonUiModel.Instance.OnAimStateChanged();
		}

		// Token: 0x060273DE RID: 160734 RVA: 0x00AFFE43 File Offset: 0x00AFE043
		private static void OnActionKeyChanged(string actionName)
		{
			SkillButtonUiModel.Instance.OnActionKeyChanged(actionName);
		}

		// Token: 0x060273DF RID: 160735 RVA: 0x00AFFE50 File Offset: 0x00AFE050
		private static void OnInputEnableChanged(EInputAction inputAction, bool enable)
		{
			SkillButtonUiModel.Instance.OnInputEnableChanged(inputAction, enable);
		}

		// Token: 0x060273E0 RID: 160736 RVA: 0x00AFFE5E File Offset: 0x00AFE05E
		private static void OnFollowerAimStateChanged(bool isAiming, bool b)
		{
			SkillButtonFormationData skillButtonFormationData = SkillButtonUiModel.Instance.SkillButtonFormationData;
			if (skillButtonFormationData == null)
			{
				return;
			}
			skillButtonFormationData.RefreshOnFollowerAimStateChange(isAiming);
		}

		// Token: 0x060273E1 RID: 160737 RVA: 0x00AFFE75 File Offset: 0x00AFE075
		private static void OnInputVisibleChanged(EInputAction inputAction, bool visible)
		{
			SkillButtonUiModel.Instance.OnInputVisibleChanged(inputAction, visible);
		}

		// Token: 0x060273E2 RID: 160738 RVA: 0x00AFFE83 File Offset: 0x00AFE083
		private static void OnFollowShooterPossessed(EntityHandle follower)
		{
			SkillButtonUiModel.Instance.CreateSkillButtonFollowerEntityData(follower);
		}

		// Token: 0x060273E3 RID: 160739 RVA: 0x00AFFE90 File Offset: 0x00AFE090
		private static void OnFollowShooterUnPossessed()
		{
			SkillButtonUiModel.Instance.ClearSkillButtonFollowerEntityData();
		}

		// Token: 0x060273E4 RID: 160740 RVA: 0x00AFFE9C File Offset: 0x00AFE09C
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

		// Token: 0x060273E5 RID: 160741 RVA: 0x00AFFEEC File Offset: 0x00AFE0EC
		private static void OnLeaveVehicle(VehiclePassengerInfo info, bool byChangeRole)
		{
			if (!info.IsRolePassenger(true))
			{
				return;
			}
			SkillButtonUiModel.Instance.ClearSkillButtonVehicleEntityData();
		}

		// Token: 0x060273E6 RID: 160742 RVA: 0x00AFFF04 File Offset: 0x00AFE104
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

		// Token: 0x060273E7 RID: 160743 RVA: 0x00AFFF6C File Offset: 0x00AFE16C
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

		// Token: 0x060273E8 RID: 160744 RVA: 0x00AFFFDC File Offset: 0x00AFE1DC
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

		// Token: 0x060273E9 RID: 160745 RVA: 0x00B00013 File Offset: 0x00AFE213
		private void OnGuideLimitActionInput(string actionName, bool bPress)
		{
			this.HandlePressCombineButton(actionName, bPress);
		}

		// Token: 0x060273EA RID: 160746 RVA: 0x00B00020 File Offset: 0x00AFE220
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

		// Token: 0x060273EB RID: 160747 RVA: 0x00B0006C File Offset: 0x00AFE26C
		private static void InputControllerChange(EInputControllerType last, EInputControllerType now)
		{
			SkillButtonUiModel.Instance.OnInputControllerChange(last, now);
		}

		// Token: 0x060273EC RID: 160748 RVA: 0x00B0007A File Offset: 0x00AFE27A
		private void OnInputCombineButton(string actionName, InputDistributeDefine.EActionType actionType, InputIdentification inputIdentification)
		{
			this.HandlePressCombineButton(actionName, actionType == InputDistributeDefine.EActionType.Press);
		}

		// Token: 0x060273ED RID: 160749 RVA: 0x00B00087 File Offset: 0x00AFE287
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

		// Token: 0x060273EE RID: 160750 RVA: 0x00B000B8 File Offset: 0x00AFE2B8
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

		// Token: 0x060273EF RID: 160751 RVA: 0x00B000EC File Offset: 0x00AFE2EC
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

		// Token: 0x060273F0 RID: 160752 RVA: 0x00B00118 File Offset: 0x00AFE318
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

		// Token: 0x17005035 RID: 20533
		// (get) Token: 0x060273F1 RID: 160753 RVA: 0x00B00160 File Offset: 0x00AFE360
		public static SkillButtonUiController Instance
		{
			get
			{
				return SkillButtonUiController._Instance;
			}
		}

		// Token: 0x060273F2 RID: 160754 RVA: 0x00B00167 File Offset: 0x00AFE367
		public static SkillButtonUiController GetOrCreateInstance()
		{
			if (SkillButtonUiController._Instance == null)
			{
				SkillButtonUiController.CreateInstance();
			}
			return SkillButtonUiController._Instance;
		}

		// Token: 0x060273F3 RID: 160755 RVA: 0x00B0017B File Offset: 0x00AFE37B
		public static bool CreateInstance()
		{
			if (SkillButtonUiController._Instance != null)
			{
				return true;
			}
			SkillButtonUiController._Instance = new SkillButtonUiController();
			return true;
		}

		// Token: 0x060273F4 RID: 160756 RVA: 0x00B00191 File Offset: 0x00AFE391
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x060273F5 RID: 160757 RVA: 0x00B00193 File Offset: 0x00AFE393
		public static void ResetStaticDefaultValue()
		{
			SkillButtonUiController._Instance = null;
		}

		// Token: 0x060273F6 RID: 160758 RVA: 0x00B0019B File Offset: 0x00AFE39B
		static SkillButtonUiController()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(SkillButtonUiController.CreateStaticDefaultValue), new Action(SkillButtonUiController.ResetStaticDefaultValue));
		}

		// Token: 0x04015655 RID: 87637
		private readonly Stat ChangeRoleStat = Stat.Create("[ChangeRole]SkillButtonUiController", "", "");

		// Token: 0x04015656 RID: 87638
		private readonly HashSet<ISkillButtonUiEventInterface> EventInterfaceMap = new HashSet<ISkillButtonUiEventInterface>();

		// Token: 0x04015657 RID: 87639
		private ESkillButtonStatusType StatusType;

		// Token: 0x04015658 RID: 87640
		[Nullable(2)]
		private static SkillButtonUiController _Instance;

		// Token: 0x02009811 RID: 38929
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0402F6FD RID: 194301
			[Nullable(0)]
			public static Action <0>__OnFormationLoaded;

			// Token: 0x0402F6FE RID: 194302
			[Nullable(new byte[]
			{
				0,
				1
			})]
			public static Action<ERemoveEntityType, EntityHandle> <1>__OnRemoveEntity;

			// Token: 0x0402F6FF RID: 194303
			[Nullable(new byte[]
			{
				0,
				2
			})]
			public static Action<int, MultiSkillInfo, int> <2>__MultiSkillIdChanged;

			// Token: 0x0402F700 RID: 194304
			[Nullable(new byte[]
			{
				0,
				2
			})]
			public static Action<int, MultiSkillInfo, int> <3>__MultiSkillEnable;

			// Token: 0x0402F701 RID: 194305
			[Nullable(0)]
			public static Action <4>__OnAimStateChanged;

			// Token: 0x0402F702 RID: 194306
			[Nullable(0)]
			public static Action<bool, bool> <5>__OnBattleUiFollowerAimStateChanged;

			// Token: 0x0402F703 RID: 194307
			[Nullable(new byte[]
			{
				0,
				1
			})]
			public static Action<string> <6>__OnActionKeyChanged;

			// Token: 0x0402F704 RID: 194308
			[Nullable(0)]
			public static Action<EInputAction, bool> <7>__OnInputEnableChanged;

			// Token: 0x0402F705 RID: 194309
			[Nullable(0)]
			public static Action<EInputAction, bool> <8>__OnInputVisibleChanged;

			// Token: 0x0402F706 RID: 194310
			[Nullable(0)]
			public static Action<bool, bool> <9>__OnFollowerAimStateChanged;

			// Token: 0x0402F707 RID: 194311
			[Nullable(new byte[]
			{
				0,
				1
			})]
			public static Action<EntityHandle> <10>__OnFollowShooterPossessed;

			// Token: 0x0402F708 RID: 194312
			[Nullable(0)]
			public static Action <11>__OnFollowShooterUnPossessed;

			// Token: 0x0402F709 RID: 194313
			[Nullable(new byte[]
			{
				0,
				1
			})]
			public static Action<VehiclePassengerInfo, bool> <12>__OnEnterVehicle;

			// Token: 0x0402F70A RID: 194314
			[Nullable(new byte[]
			{
				0,
				1
			})]
			public static Action<VehiclePassengerInfo, bool> <13>__OnLeaveVehicle;

			// Token: 0x0402F70B RID: 194315
			[Nullable(0)]
			public static Action<EUiViewName, int> <14>__OnOpenView;

			// Token: 0x0402F70C RID: 194316
			[Nullable(0)]
			public static Action<EUiViewName, int> <15>__OnCloseView;

			// Token: 0x0402F70D RID: 194317
			[Nullable(0)]
			public static Action<EInputControllerType, EInputControllerType> <16>__InputControllerChange;
		}
	}
}
