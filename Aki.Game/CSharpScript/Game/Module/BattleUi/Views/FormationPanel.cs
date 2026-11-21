using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Protocol;
using CSharpScript.Core.Common;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.SkillButtonUi;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.BattleUi.Views
{
	// Token: 0x02004C9E RID: 19614
	[NullableContext(1)]
	[Nullable(0)]
	public class FormationPanel : BattleChildViewPanel
	{
		// Token: 0x06030F6A RID: 200554 RVA: 0x00DA8D70 File Offset: 0x00DA6F70
		public override UniTask InitializeAsync()
		{
			FormationPanel.<InitializeAsync>d__12 <InitializeAsync>d__;
			<InitializeAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitializeAsync>d__.<>4__this = this;
			<InitializeAsync>d__.<>1__state = -1;
			<InitializeAsync>d__.<>t__builder.Start<FormationPanel.<InitializeAsync>d__12>(ref <InitializeAsync>d__);
			return <InitializeAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06030F6B RID: 200555 RVA: 0x00DA8DB3 File Offset: 0x00DA6FB3
		public void SetIsGamepad()
		{
			this.IsGamepad = true;
			base.SetVisible(EBattleUiVisibleReason.Gamepad, Info.Instance.IsInGamepad() == this.IsGamepad);
		}

		// Token: 0x06030F6C RID: 200556 RVA: 0x00DA8DD8 File Offset: 0x00DA6FD8
		[NullableContext(2)]
		public UUIItem GetFormationItemContainer()
		{
			if (this.IsGamepad && base.GetOperationType() == EOperationType.Desktop)
			{
				UUIVerticalLayout verticalLayout = base.GetVerticalLayout(4);
				UUIItem uuiitem = (verticalLayout != null) ? verticalLayout.GetRootComponent() : null;
				if (uuiitem != null)
				{
					return uuiitem;
				}
			}
			return base.GetRootItem();
		}

		// Token: 0x06030F6D RID: 200557 RVA: 0x00DA8E18 File Offset: 0x00DA7018
		public override void Reset()
		{
			foreach (FormationItem formationItem in this.FormationItemList)
			{
				formationItem.ResetItem();
			}
			this.FormationItemList.Clear();
			GuestItem guest = this.Guest;
			if (guest != null)
			{
				guest.Destroy(null);
			}
			this.Guest = null;
			this.FormationHeadIconEnergyBar.Destroy();
			base.Reset();
		}

		// Token: 0x06030F6E RID: 200558 RVA: 0x00DA8EA0 File Offset: 0x00DA70A0
		protected unsafe override void OnRegisterComponent()
		{
			EOperationType operationType = base.GetOperationType();
			if (operationType == EOperationType.Desktop)
			{
				int num = 4;
				List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
				CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
				Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
				int num2 = 0;
				*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
				num2++;
				*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
				num2++;
				*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
				num2++;
				*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
				this.ComponentRegisterInfos = list;
				if (Info.Instance.IsInGamepad())
				{
					this.ComponentRegisterInfos.Add(new ValueTuple<int, Type>(4, typeof(UUIVerticalLayout)));
					return;
				}
			}
			else if (operationType == EOperationType.Pad)
			{
				int num2 = 4;
				List<ValueTuple<int, Type>> list2 = new List<ValueTuple<int, Type>>(num2);
				CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list2, num2);
				Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list2);
				int num = 0;
				*span[num] = new ValueTuple<int, Type>(0, typeof(UUIItem));
				num++;
				*span[num] = new ValueTuple<int, Type>(1, typeof(UUIItem));
				num++;
				*span[num] = new ValueTuple<int, Type>(2, typeof(UUIItem));
				num++;
				*span[num] = new ValueTuple<int, Type>(3, typeof(UUIVerticalLayout));
				this.ComponentRegisterInfos = list2;
			}
		}

		// Token: 0x06030F6F RID: 200559 RVA: 0x00DA902C File Offset: 0x00DA722C
		public override void OnTickBattleChildViewPanel(float delta)
		{
			if (!this.Visible)
			{
				return;
			}
			foreach (FormationItem formationItem in this.FormationItemList)
			{
				formationItem.OnTick(delta);
			}
			this.FormationHeadIconEnergyBar.Tick(delta);
		}

		// Token: 0x06030F70 RID: 200560 RVA: 0x00DA9094 File Offset: 0x00DA7294
		protected override void OnShowBattleChildViewPanel(bool isFirst)
		{
			foreach (FormationItem formationItem in this.FormationItemList)
			{
				formationItem.RefreshCoolDownOnShow();
			}
			this.OnRefreshGuest();
		}

		// Token: 0x06030F71 RID: 200561 RVA: 0x00DA90EC File Offset: 0x00DA72EC
		private UniTask NewFormationItemAsync(AActor rootActor, FormationPanel.EPosition position)
		{
			FormationPanel.<NewFormationItemAsync>d__19 <NewFormationItemAsync>d__;
			<NewFormationItemAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<NewFormationItemAsync>d__.<>4__this = this;
			<NewFormationItemAsync>d__.rootActor = rootActor;
			<NewFormationItemAsync>d__.position = position;
			<NewFormationItemAsync>d__.<>1__state = -1;
			<NewFormationItemAsync>d__.<>t__builder.Start<FormationPanel.<NewFormationItemAsync>d__19>(ref <NewFormationItemAsync>d__);
			return <NewFormationItemAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06030F72 RID: 200562 RVA: 0x00DA9140 File Offset: 0x00DA7340
		private UniTask ActivateAllFormationItems()
		{
			FormationPanel.<ActivateAllFormationItems>d__20 <ActivateAllFormationItems>d__;
			<ActivateAllFormationItems>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<ActivateAllFormationItems>d__.<>4__this = this;
			<ActivateAllFormationItems>d__.<>1__state = -1;
			<ActivateAllFormationItems>d__.<>t__builder.Start<FormationPanel.<ActivateAllFormationItems>d__20>(ref <ActivateAllFormationItems>d__);
			return <ActivateAllFormationItems>d__.<>t__builder.Task;
		}

		// Token: 0x06030F73 RID: 200563 RVA: 0x00DA9184 File Offset: 0x00DA7384
		private UniTask ResetFormationItemAsync()
		{
			FormationPanel.<ResetFormationItemAsync>d__21 <ResetFormationItemAsync>d__;
			<ResetFormationItemAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<ResetFormationItemAsync>d__.<>4__this = this;
			<ResetFormationItemAsync>d__.<>1__state = -1;
			<ResetFormationItemAsync>d__.<>t__builder.Start<FormationPanel.<ResetFormationItemAsync>d__21>(ref <ResetFormationItemAsync>d__);
			return <ResetFormationItemAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06030F74 RID: 200564 RVA: 0x00DA91C8 File Offset: 0x00DA73C8
		[NullableContext(2)]
		private FormationItem GetFormationItemByConfigId(int configId)
		{
			foreach (FormationItem formationItem in this.FormationItemList)
			{
				if (formationItem.RoleConfigId == configId)
				{
					return formationItem;
				}
			}
			return null;
		}

		// Token: 0x06030F75 RID: 200565 RVA: 0x00DA9224 File Offset: 0x00DA7424
		[NullableContext(2)]
		private FormationItem GetFormationItemByEntityId(int entityId)
		{
			foreach (FormationItem formationItem in this.FormationItemList)
			{
				int? entityId2 = formationItem.EntityId;
				if (entityId2.GetValueOrDefault() == entityId & entityId2 != null)
				{
					return formationItem;
				}
			}
			return null;
		}

		// Token: 0x06030F76 RID: 200566 RVA: 0x00DA9298 File Offset: 0x00DA7498
		public List<FormationItem> GetFormationItemList()
		{
			return this.FormationItemList;
		}

		// Token: 0x06030F77 RID: 200567 RVA: 0x00DA92A0 File Offset: 0x00DA74A0
		protected override void AddEvents()
		{
			EventSystem.Instance.Add<int, int>(EEventName.BattleUiCurRoleDataChanged, new Action<int, int>(this.OnChangedRoleCompleted));
			EventSystem.Instance.Add<int, int>(EEventName.BattleUiCurRoleDataChangedNextTick, new Action<int, int>(this.OnChangedRoleNextTick));
			EventSystem.Instance.Add(EEventName.BattleUiAllRoleDataChanged, new Action(this.OnFormationLoadCompleted));
			EventSystem.Instance.Add<int, int, int>(EEventName.CharExecuteMultiQte, new Action<int, int, int>(this.OnExecuteMultiQte));
			EventSystem.Instance.Add(EEventName.FormationPanelUIShowRoleHeal, new Action<Entity>(this.OnRoleCure));
			EventSystem.Instance.Add(EEventName.CharOnRoleDead, new Action<int>(this.OnRoleDead));
			EventSystem.Instance.Add(EEventName.OnFormationPlayLevelUp, new Action<int, int, int>(this.OnRoleLevelUp));
			EventSystem.Instance.Add<ERemoveEntityType, EntityHandle>(EEventName.RemoveEntity, new Action<ERemoveEntityType, EntityHandle>(this.OnRemoveEntity));
			EventSystem.Instance.Add(EEventName.RoleRefreshName, new Action(this.OnRoleRefreshName));
			EventSystem.Instance.Add(EEventName.OnRefreshRoleHp, new Action(this.UpdateRoleHp));
			EventSystem.Instance.Add(EEventName.OnConcertoResponseOpen, new Action<bool>(this.OnConcertoResponseOpen));
			EventSystem.Instance.Add<string, string>(EEventName.TextLanguageChange, new Action<string, string>(this.OnTextLanguageChange));
			EventSystem.Instance.Add(EEventName.OnRefreshPlayerPing, new Action<int, ENetPingState>(this.OnRefreshPlayerPing));
			EventSystem.Instance.Add<EntityHandle, EntityHandle>(EEventName.OnOtherChangeRole, new Action<EntityHandle, EntityHandle>(this.OnOtherChangeRole));
			EventSystem.Instance.Add<EInputControllerType, EInputControllerType>(EEventName.InputControllerChange, new Action<EInputControllerType, EInputControllerType>(this.InputControllerChange));
			EventSystem.Instance.Add(EEventName.RefreshGuest, new Action(this.OnRefreshGuest));
			if (base.GetOperationType() == EOperationType.Desktop)
			{
				EventSystem.Instance.Add<bool>(EEventName.BattleUiPressMotorcycleCombineButtonChanged, new Action<bool>(this.OnPressMotorcycleCombineButtonChanged));
			}
		}

		// Token: 0x06030F78 RID: 200568 RVA: 0x00DA948C File Offset: 0x00DA768C
		protected override void RemoveEvents()
		{
			EventSystem.Instance.Remove(EEventName.BattleUiCurRoleDataChanged, new Action<int, int>(this.OnChangedRoleCompleted));
			EventSystem.Instance.Remove(EEventName.BattleUiCurRoleDataChangedNextTick, new Action<int, int>(this.OnChangedRoleNextTick));
			EventSystem.Instance.Remove(EEventName.BattleUiAllRoleDataChanged, new Action(this.OnFormationLoadCompleted));
			EventSystem.Instance.Remove(EEventName.CharExecuteMultiQte, new Action<int, int, int>(this.OnExecuteMultiQte));
			EventSystem.Instance.Remove(EEventName.FormationPanelUIShowRoleHeal, new Action<Entity>(this.OnRoleCure));
			EventSystem.Instance.Remove(EEventName.CharOnRoleDead, new Action<int>(this.OnRoleDead));
			EventSystem.Instance.Remove(EEventName.OnFormationPlayLevelUp, new Action<int, int, int>(this.OnRoleLevelUp));
			EventSystem.Instance.Remove(EEventName.RemoveEntity, new Action<ERemoveEntityType, EntityHandle>(this.OnRemoveEntity));
			EventSystem.Instance.Remove(EEventName.RoleRefreshName, new Action(this.OnRoleRefreshName));
			EventSystem.Instance.Remove(EEventName.OnRefreshRoleHp, new Action(this.UpdateRoleHp));
			EventSystem.Instance.Remove(EEventName.OnConcertoResponseOpen, new Action<bool>(this.OnConcertoResponseOpen));
			EventSystem.Instance.Remove(EEventName.TextLanguageChange, new Action<string, string>(this.OnTextLanguageChange));
			EventSystem.Instance.Remove(EEventName.OnRefreshPlayerPing, new Action<int, ENetPingState>(this.OnRefreshPlayerPing));
			EventSystem.Instance.Remove(EEventName.OnOtherChangeRole, new Action<EntityHandle, EntityHandle>(this.OnOtherChangeRole));
			EventSystem.Instance.Remove(EEventName.InputControllerChange, new Action<EInputControllerType, EInputControllerType>(this.InputControllerChange));
			EventSystem.Instance.Remove(EEventName.RefreshGuest, new Action(this.OnRefreshGuest));
			if (base.GetOperationType() == EOperationType.Desktop)
			{
				EventSystem.Instance.Remove(EEventName.BattleUiPressMotorcycleCombineButtonChanged, new Action<bool>(this.OnPressMotorcycleCombineButtonChanged));
			}
		}

		// Token: 0x06030F79 RID: 200569 RVA: 0x00DA9678 File Offset: 0x00DA7878
		private void OnChangedRoleCompleted(int newEntityId, int oldEntityId)
		{
			this.ChangeList.Add(new ValueTuple<int, int>(newEntityId, oldEntityId));
		}

		// Token: 0x06030F7A RID: 200570 RVA: 0x00DA968C File Offset: 0x00DA788C
		private void OnChangedRoleNextTick(int i, int i1)
		{
			if (this.ChangeList.Count <= 0)
			{
				return;
			}
			EOperationType operationType = base.GetOperationType();
			foreach (ValueTuple<int, int> valueTuple in this.ChangeList)
			{
				if (operationType == EOperationType.Desktop)
				{
					this.OnDesktopChangedRoleCompleted(valueTuple.Item1, valueTuple.Item2);
				}
				else if (operationType == EOperationType.Pad)
				{
					this.OnPadChangedRoleCompleted(valueTuple.Item1, valueTuple.Item2);
				}
			}
			foreach (FormationItem formationItem in this.FormationItemList)
			{
				formationItem.RefreshQteActive();
			}
			this.ChangeList.Clear();
		}

		// Token: 0x06030F7B RID: 200571 RVA: 0x00DA9768 File Offset: 0x00DA7968
		private void OnDesktopChangedRoleCompleted(int newEntityId, int oldEntityId)
		{
			BattleUiRoleData roleData = BattleUiModel.Instance.GetRoleData(newEntityId);
			FormationItem formationItemByEntityId = this.GetFormationItemByEntityId(this.CurEntityId.Value);
			this.FormationHeadIconEnergyBar.RefreshVisible(this.CurEntityId.Value, false, (formationItemByEntityId != null) ? formationItemByEntityId.PrefabIndex : -1);
			this.CurEntityId = new int?(newEntityId);
			FormationItem formationItemByEntityId2 = this.GetFormationItemByEntityId(this.CurEntityId.Value);
			if (formationItemByEntityId != null)
			{
				formationItemByEntityId.RefreshSelectedRole();
			}
			if (formationItemByEntityId2 == null)
			{
				return;
			}
			formationItemByEntityId2.RefreshSelectedRole();
			this.FormationHeadIconEnergyBar.RefreshVisible(this.CurEntityId.Value, true, -1);
			BattleUiRoleData roleData2 = BattleUiModel.Instance.GetRoleData(oldEntityId);
			if (roleData2 != null && roleData != null && roleData.GameplayTagComponent.HasTag(GameplayTagDefine.EGameplayTagId["功能.功能制作.QTE.CD"]))
			{
				formationItemByEntityId2.ActivateConcertoChangeEffect((int)roleData.ElementType.Value, (int)roleData2.ElementType.Value);
			}
		}

		// Token: 0x06030F7C RID: 200572 RVA: 0x00DA984C File Offset: 0x00DA7A4C
		private void OnPadChangedRoleCompleted(int newEntityId, int oldEntityId)
		{
			BattleUiRoleData roleData = BattleUiModel.Instance.GetRoleData(oldEntityId);
			BattleUiRoleData roleData2 = BattleUiModel.Instance.GetRoleData(newEntityId);
			this.CurEntityId = new int?(newEntityId);
			if (this.CurEntityId == null)
			{
				return;
			}
			FormationItem formationItemByEntityId = this.GetFormationItemByEntityId(this.CurEntityId.Value);
			if (formationItemByEntityId == null)
			{
				Log.Instance.Warn(ELogModule.Battle, ELogAuthor.CFT, "角色上场时找不到之前的头像", default(ReadOnlySpan<ValueTuple<string, object>>));
				return;
			}
			if (roleData != null)
			{
				int valueOrDefault = PlayerInfoModel.Instance.GetId().GetValueOrDefault();
				formationItemByEntityId.Refresh(valueOrDefault, roleData.CreatureRoleId, roleData.CreatureSkinId.GetValueOrDefault(), roleData);
				this.FormationHeadIconEnergyBar.RefreshVisible(oldEntityId, false, formationItemByEntityId.PrefabIndex);
				this.FormationHeadIconEnergyBar.RefreshVisible(newEntityId, true, formationItemByEntityId.PrefabIndex);
			}
			else
			{
				Log.Instance.Warn(ELogModule.Battle, ELogAuthor.LYY, "角色上场时找不到下场角色数据", default(ReadOnlySpan<ValueTuple<string, object>>));
				formationItemByEntityId.ResetItem();
			}
			if (roleData != null && roleData2 != null && roleData2.GameplayTagComponent.HasTag(GameplayTagDefine.EGameplayTagId["功能.功能制作.QTE.CD"]))
			{
				formationItemByEntityId.ActivateConcertoChangeEffect((int)roleData2.ElementType.Value, (int)roleData.ElementType.Value);
			}
		}

		// Token: 0x06030F7D RID: 200573 RVA: 0x00DA9977 File Offset: 0x00DA7B77
		private void OnFormationLoadCompleted()
		{
			if (SceneTeamModel.Instance.IsSeamlessUpdateTeam)
			{
				return;
			}
			this.ActivateAllFormationItems().Forget();
			this.OnRefreshGuest();
			this.ChangeList.Clear();
		}

		// Token: 0x06030F7E RID: 200574 RVA: 0x00DA99A2 File Offset: 0x00DA7BA2
		private void OnExecuteMultiQte(int entityId, int goDownEntityId, int roleQteType)
		{
			FormationItem formationItemByEntityId = this.GetFormationItemByEntityId(goDownEntityId);
			if (formationItemByEntityId == null)
			{
				return;
			}
			formationItemByEntityId.ActivateConcertoChangeEffect(0, 0);
		}

		// Token: 0x06030F7F RID: 200575 RVA: 0x00DA99B7 File Offset: 0x00DA7BB7
		private void OnRoleCure(Entity target)
		{
			FormationItem formationItemByEntityId = this.GetFormationItemByEntityId(target.Id);
			if (formationItemByEntityId == null)
			{
				return;
			}
			formationItemByEntityId.CureRole();
		}

		// Token: 0x06030F80 RID: 200576 RVA: 0x00DA99CF File Offset: 0x00DA7BCF
		private void OnRoleDead(int entityId)
		{
			FormationItem formationItemByEntityId = this.GetFormationItemByEntityId(entityId);
			if (formationItemByEntityId == null)
			{
				return;
			}
			formationItemByEntityId.RefreshRoleHealthPercent();
		}

		// Token: 0x06030F81 RID: 200577 RVA: 0x00DA99E2 File Offset: 0x00DA7BE2
		private void OnRoleLevelUp(int configId, int exp, int level)
		{
			FormationItem formationItemByConfigId = this.GetFormationItemByConfigId(configId);
			if (formationItemByConfigId == null)
			{
				return;
			}
			formationItemByConfigId.LevelUp(level);
		}

		// Token: 0x06030F82 RID: 200578 RVA: 0x00DA99F6 File Offset: 0x00DA7BF6
		private void OnRemoveEntity(ERemoveEntityType removeType, EntityHandle handle)
		{
			FormationItem formationItemByEntityId = this.GetFormationItemByEntityId(handle.Id);
			if (formationItemByEntityId != null)
			{
				formationItemByEntityId.ClearData();
			}
			this.FormationHeadIconEnergyBar.RemoveEntity(handle.Id);
		}

		// Token: 0x06030F83 RID: 200579 RVA: 0x00DA9A20 File Offset: 0x00DA7C20
		private void OnRoleRefreshName()
		{
			foreach (FormationItem formationItem in this.FormationItemList)
			{
				formationItem.RefreshRoleName();
			}
		}

		// Token: 0x06030F84 RID: 200580 RVA: 0x00DA9A70 File Offset: 0x00DA7C70
		private void UpdateRoleHp()
		{
			foreach (FormationItem formationItem in this.FormationItemList)
			{
				formationItem.RefreshRoleHealthPercent();
			}
		}

		// Token: 0x06030F85 RID: 200581 RVA: 0x00DA9AC0 File Offset: 0x00DA7CC0
		private void OnConcertoResponseOpen(bool isOpen)
		{
			foreach (FormationItem formationItem in this.FormationItemList)
			{
				formationItem.RefreshConcertoResponseModule(isOpen);
			}
		}

		// Token: 0x06030F86 RID: 200582 RVA: 0x00DA9B14 File Offset: 0x00DA7D14
		private void OnTextLanguageChange(string s, string s1)
		{
			foreach (FormationItem formationItem in this.FormationItemList)
			{
				formationItem.RefreshRoleName();
			}
		}

		// Token: 0x06030F87 RID: 200583 RVA: 0x00DA9B64 File Offset: 0x00DA7D64
		private void OnRefreshPlayerPing(int playerId, ENetPingState ping)
		{
			foreach (FormationItem formationItem in this.FormationItemList)
			{
				if (formationItem.PlayerId == playerId)
				{
					formationItem.RefreshPlayerPingState(ping);
				}
			}
		}

		// Token: 0x06030F88 RID: 200584 RVA: 0x00DA9BC0 File Offset: 0x00DA7DC0
		private void OnOtherChangeRole(EntityHandle newEntity, [Nullable(2)] EntityHandle oldEntity)
		{
			foreach (FormationItem formationItem in this.FormationItemList)
			{
				if (!formationItem.IsMyRole)
				{
					formationItem.RefreshOnlineItem();
				}
			}
		}

		// Token: 0x06030F89 RID: 200585 RVA: 0x00DA9C1C File Offset: 0x00DA7E1C
		private void InputControllerChange(EInputControllerType last, EInputControllerType now)
		{
			base.SetVisible(EBattleUiVisibleReason.Gamepad, Info.Instance.IsInGamepad() == this.IsGamepad);
		}

		// Token: 0x06030F8A RID: 200586 RVA: 0x00DA9C37 File Offset: 0x00DA7E37
		public void RefreshOnDelayShow()
		{
		}

		// Token: 0x06030F8B RID: 200587 RVA: 0x00DA9C3C File Offset: 0x00DA7E3C
		public void RefreshFormationCooldownExternal(int playerId, int roleId, float? remainCd, float? totalCd)
		{
			foreach (FormationItem formationItem in this.FormationItemList)
			{
				if (playerId == formationItem.PlayerId && (roleId == formationItem.RoleConfigId || roleId == 0))
				{
					formationItem.RefreshCoolDownExternal(remainCd, totalCd);
				}
			}
		}

		// Token: 0x06030F8C RID: 200588 RVA: 0x00DA9CA8 File Offset: 0x00DA7EA8
		public void ResetFormationCooldownExternal()
		{
			foreach (FormationItem formationItem in this.FormationItemList)
			{
				formationItem.RefreshCoolDownExternal(new float?(0f), new float?(0f));
			}
		}

		// Token: 0x06030F8D RID: 200589 RVA: 0x00DA9D0C File Offset: 0x00DA7F0C
		private void OnRefreshGuest()
		{
			if (this.IsOperating)
			{
				this.NeedFresh = true;
				return;
			}
			int guestId = BattleUiModel.Instance.GuestId;
			this.IsOperating = true;
			if (guestId != 0)
			{
				this.SetGuest(guestId).ContinueWith(new Action(this.OnAfterRefresh)).Forget();
				return;
			}
			this.RemoveGuest().ContinueWith(new Action(this.OnAfterRefresh)).Forget();
		}

		// Token: 0x06030F8E RID: 200590 RVA: 0x00DA9D78 File Offset: 0x00DA7F78
		private void OnAfterRefresh()
		{
			this.IsOperating = false;
			if (this.NeedFresh)
			{
				this.NeedFresh = false;
				this.OnRefreshGuest();
			}
		}

		// Token: 0x06030F8F RID: 200591 RVA: 0x00DA9D98 File Offset: 0x00DA7F98
		private UniTask SetGuest(int id)
		{
			FormationPanel.<SetGuest>d__53 <SetGuest>d__;
			<SetGuest>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<SetGuest>d__.<>4__this = this;
			<SetGuest>d__.id = id;
			<SetGuest>d__.<>1__state = -1;
			<SetGuest>d__.<>t__builder.Start<FormationPanel.<SetGuest>d__53>(ref <SetGuest>d__);
			return <SetGuest>d__.<>t__builder.Task;
		}

		// Token: 0x06030F90 RID: 200592 RVA: 0x00DA9DE4 File Offset: 0x00DA7FE4
		private UniTask RemoveGuest()
		{
			FormationPanel.<RemoveGuest>d__54 <RemoveGuest>d__;
			<RemoveGuest>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<RemoveGuest>d__.<>4__this = this;
			<RemoveGuest>d__.<>1__state = -1;
			<RemoveGuest>d__.<>t__builder.Start<FormationPanel.<RemoveGuest>d__54>(ref <RemoveGuest>d__);
			return <RemoveGuest>d__.<>t__builder.Task;
		}

		// Token: 0x06030F91 RID: 200593 RVA: 0x00DA9E27 File Offset: 0x00DA8027
		private void OnPressMotorcycleCombineButtonChanged(bool b)
		{
			this.RefreshKeyItemEnableInMotorcycle();
		}

		// Token: 0x06030F92 RID: 200594 RVA: 0x00DA9E30 File Offset: 0x00DA8030
		public void RefreshKeyItemEnableInMotorcycle()
		{
			if (!Info.Instance.IsInGamepad())
			{
				return;
			}
			BattleUiMotorcycleData motorcycleData = BattleUiModel.Instance.MotorcycleData;
			if (motorcycleData == null || !motorcycleData.IsDriving)
			{
				return;
			}
			SkillButtonUiMotorcycleGamepadData skillButtonUiMotorcycleGamepadData = SkillButtonUiModel.Instance.GetGamepadDataByType(ESkillButtonGamepadDataType.Motorcycle) as SkillButtonUiMotorcycleGamepadData;
			if (skillButtonUiMotorcycleGamepadData != null && skillButtonUiMotorcycleGamepadData.GetIsPressCombineButton())
			{
				using (List<FormationItem>.Enumerator enumerator = this.FormationItemList.GetEnumerator())
				{
					while (enumerator.MoveNext())
					{
						FormationItem formationItem = enumerator.Current;
						formationItem.SetInvisibleByKeyList(skillButtonUiMotorcycleGamepadData.MusicSubKeyList);
					}
					return;
				}
			}
			foreach (FormationItem formationItem2 in this.FormationItemList)
			{
				formationItem2.SetInvisibleByKeyList(null);
			}
		}

		// Token: 0x06030F93 RID: 200595 RVA: 0x00DA9F0C File Offset: 0x00DA810C
		public void AddChildToRoleHeadPanel(UUIItem child)
		{
			EOperationType operationType = base.GetOperationType();
			if (operationType != EOperationType.Desktop)
			{
				if (operationType == EOperationType.Pad)
				{
					UUIVerticalLayout verticalLayout = base.GetVerticalLayout(3);
					child.SetUIParent(verticalLayout.RootUIComp, false);
					child.SetAsLastHierarchy();
				}
				return;
			}
			if (Info.Instance.IsInGamepad())
			{
				UUIVerticalLayout verticalLayout2 = base.GetVerticalLayout(4);
				child.SetUIParent(verticalLayout2.RootUIComp, false);
				child.SetAsLastHierarchy();
				return;
			}
			UUIItem rootItem = base.GetRootItem();
			child.SetUIParent(rootItem, false);
			child.SetAsLastHierarchy();
		}

		// Token: 0x04019FA2 RID: 106402
		[StaticVariableRuleIgnore]
		private static readonly Stat BattleViewTickStatsObject = Stat.Create("[BattleView]FormationPanelTick", "", "");

		// Token: 0x04019FA3 RID: 106403
		[StaticVariableRuleIgnore]
		private static readonly Stat ChangeRoleStat = Stat.Create("[ChangeRole]FormationPanel", "", "");

		// Token: 0x04019FA4 RID: 106404
		private const string GUEST_RESOURCE_ID = "FightRoleHeadGuest";

		// Token: 0x04019FA5 RID: 106405
		private readonly List<FormationItem> FormationItemList = new List<FormationItem>();

		// Token: 0x04019FA6 RID: 106406
		private bool IsUpdatingFormationItem;

		// Token: 0x04019FA7 RID: 106407
		private bool IsGamepad;

		// Token: 0x04019FA8 RID: 106408
		private int? CurEntityId = new int?(0);

		// Token: 0x04019FA9 RID: 106409
		[TupleElementNames(new string[]
		{
			"newEntityId",
			"oldEntityId"
		})]
		[Nullable(new byte[]
		{
			1,
			0
		})]
		private readonly List<ValueTuple<int, int>> ChangeList = new List<ValueTuple<int, int>>();

		// Token: 0x04019FAA RID: 106410
		private readonly FormationHeadIconEnergyBar FormationHeadIconEnergyBar = new FormationHeadIconEnergyBar();

		// Token: 0x04019FAB RID: 106411
		[Nullable(2)]
		private GuestItem Guest;

		// Token: 0x04019FAC RID: 106412
		private int GuestId;

		// Token: 0x04019FAD RID: 106413
		private bool NeedFresh;

		// Token: 0x04019FAE RID: 106414
		private bool IsOperating;

		// Token: 0x0200A8B2 RID: 43186
		[NullableContext(0)]
		private enum EChildType
		{
			// Token: 0x040341C3 RID: 213443
			FormationChildItem1,
			// Token: 0x040341C4 RID: 213444
			FormationChildItem2,
			// Token: 0x040341C5 RID: 213445
			FormationChildItem3,
			// Token: 0x040341C6 RID: 213446
			FormationChildItem4,
			// Token: 0x040341C7 RID: 213447
			Layout
		}

		// Token: 0x0200A8B3 RID: 43187
		[NullableContext(0)]
		private enum EPadType
		{
			// Token: 0x040341C9 RID: 213449
			Layout = 3
		}

		// Token: 0x0200A8B4 RID: 43188
		[NullableContext(0)]
		private enum EPosition
		{
			// Token: 0x040341CB RID: 213451
			OnePlayer,
			// Token: 0x040341CC RID: 213452
			TwoPlayer,
			// Token: 0x040341CD RID: 213453
			ThreePlayer,
			// Token: 0x040341CE RID: 213454
			FourPlayer
		}
	}
}
