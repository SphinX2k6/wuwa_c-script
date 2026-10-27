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
	// Token: 0x02005CBC RID: 23740
	[NullableContext(1)]
	[Nullable(0)]
	public class FormationPanel : BattleChildViewPanel
	{
		// Token: 0x0603C017 RID: 245783 RVA: 0x00E586C8 File Offset: 0x00E568C8
		public override UniTask InitializeAsync()
		{
			FormationPanel.<InitializeAsync>d__12 <InitializeAsync>d__;
			<InitializeAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitializeAsync>d__.<>4__this = this;
			<InitializeAsync>d__.<>1__state = -1;
			<InitializeAsync>d__.<>t__builder.Start<FormationPanel.<InitializeAsync>d__12>(ref <InitializeAsync>d__);
			return <InitializeAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603C018 RID: 245784 RVA: 0x00E5870B File Offset: 0x00E5690B
		public void SetIsGamepad()
		{
			this.IsGamepad = true;
			base.SetVisible(EBattleUiVisibleReason.Gamepad, Info.Instance.IsInGamepad() == this.IsGamepad);
		}

		// Token: 0x0603C019 RID: 245785 RVA: 0x00E58730 File Offset: 0x00E56930
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

		// Token: 0x0603C01A RID: 245786 RVA: 0x00E587B8 File Offset: 0x00E569B8
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

		// Token: 0x0603C01B RID: 245787 RVA: 0x00E58944 File Offset: 0x00E56B44
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

		// Token: 0x0603C01C RID: 245788 RVA: 0x00E589AC File Offset: 0x00E56BAC
		protected override void OnShowBattleChildViewPanel(bool isFirst)
		{
			foreach (FormationItem formationItem in this.FormationItemList)
			{
				formationItem.RefreshCoolDownOnShow();
			}
			this.OnRefreshGuest();
		}

		// Token: 0x0603C01D RID: 245789 RVA: 0x00E58A04 File Offset: 0x00E56C04
		private UniTask NewFormationItemAsync(AActor rootActor, FormationPanel.EPosition position)
		{
			FormationPanel.<NewFormationItemAsync>d__18 <NewFormationItemAsync>d__;
			<NewFormationItemAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<NewFormationItemAsync>d__.<>4__this = this;
			<NewFormationItemAsync>d__.rootActor = rootActor;
			<NewFormationItemAsync>d__.position = position;
			<NewFormationItemAsync>d__.<>1__state = -1;
			<NewFormationItemAsync>d__.<>t__builder.Start<FormationPanel.<NewFormationItemAsync>d__18>(ref <NewFormationItemAsync>d__);
			return <NewFormationItemAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603C01E RID: 245790 RVA: 0x00E58A58 File Offset: 0x00E56C58
		private UniTask ActivateAllFormationItems()
		{
			FormationPanel.<ActivateAllFormationItems>d__19 <ActivateAllFormationItems>d__;
			<ActivateAllFormationItems>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<ActivateAllFormationItems>d__.<>4__this = this;
			<ActivateAllFormationItems>d__.<>1__state = -1;
			<ActivateAllFormationItems>d__.<>t__builder.Start<FormationPanel.<ActivateAllFormationItems>d__19>(ref <ActivateAllFormationItems>d__);
			return <ActivateAllFormationItems>d__.<>t__builder.Task;
		}

		// Token: 0x0603C01F RID: 245791 RVA: 0x00E58A9C File Offset: 0x00E56C9C
		private UniTask ResetFormationItemAsync()
		{
			FormationPanel.<ResetFormationItemAsync>d__20 <ResetFormationItemAsync>d__;
			<ResetFormationItemAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<ResetFormationItemAsync>d__.<>4__this = this;
			<ResetFormationItemAsync>d__.<>1__state = -1;
			<ResetFormationItemAsync>d__.<>t__builder.Start<FormationPanel.<ResetFormationItemAsync>d__20>(ref <ResetFormationItemAsync>d__);
			return <ResetFormationItemAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603C020 RID: 245792 RVA: 0x00E58AE0 File Offset: 0x00E56CE0
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

		// Token: 0x0603C021 RID: 245793 RVA: 0x00E58B3C File Offset: 0x00E56D3C
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

		// Token: 0x0603C022 RID: 245794 RVA: 0x00E58BB0 File Offset: 0x00E56DB0
		public List<FormationItem> GetFormationItemList()
		{
			return this.FormationItemList;
		}

		// Token: 0x0603C023 RID: 245795 RVA: 0x00E58BB8 File Offset: 0x00E56DB8
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

		// Token: 0x0603C024 RID: 245796 RVA: 0x00E58DA4 File Offset: 0x00E56FA4
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

		// Token: 0x0603C025 RID: 245797 RVA: 0x00E58F90 File Offset: 0x00E57190
		private void OnChangedRoleCompleted(int newEntityId, int oldEntityId)
		{
			this.ChangeList.Add(new ValueTuple<int, int>(newEntityId, oldEntityId));
		}

		// Token: 0x0603C026 RID: 245798 RVA: 0x00E58FA4 File Offset: 0x00E571A4
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

		// Token: 0x0603C027 RID: 245799 RVA: 0x00E59080 File Offset: 0x00E57280
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

		// Token: 0x0603C028 RID: 245800 RVA: 0x00E59164 File Offset: 0x00E57364
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

		// Token: 0x0603C029 RID: 245801 RVA: 0x00E5928F File Offset: 0x00E5748F
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

		// Token: 0x0603C02A RID: 245802 RVA: 0x00E592BA File Offset: 0x00E574BA
		private void OnExecuteMultiQte(int entityId, int goDownEntityId, int roleQteType)
		{
			FormationItem formationItemByEntityId = this.GetFormationItemByEntityId(goDownEntityId);
			if (formationItemByEntityId == null)
			{
				return;
			}
			formationItemByEntityId.ActivateConcertoChangeEffect(0, 0);
		}

		// Token: 0x0603C02B RID: 245803 RVA: 0x00E592CF File Offset: 0x00E574CF
		private void OnRoleCure(Entity target)
		{
			FormationItem formationItemByEntityId = this.GetFormationItemByEntityId(target.Id);
			if (formationItemByEntityId == null)
			{
				return;
			}
			formationItemByEntityId.CureRole();
		}

		// Token: 0x0603C02C RID: 245804 RVA: 0x00E592E7 File Offset: 0x00E574E7
		private void OnRoleDead(int entityId)
		{
			FormationItem formationItemByEntityId = this.GetFormationItemByEntityId(entityId);
			if (formationItemByEntityId == null)
			{
				return;
			}
			formationItemByEntityId.RefreshRoleHealthPercent();
		}

		// Token: 0x0603C02D RID: 245805 RVA: 0x00E592FA File Offset: 0x00E574FA
		private void OnRoleLevelUp(int configId, int exp, int level)
		{
			FormationItem formationItemByConfigId = this.GetFormationItemByConfigId(configId);
			if (formationItemByConfigId == null)
			{
				return;
			}
			formationItemByConfigId.LevelUp(level);
		}

		// Token: 0x0603C02E RID: 245806 RVA: 0x00E5930E File Offset: 0x00E5750E
		private void OnRemoveEntity(ERemoveEntityType removeType, EntityHandle handle)
		{
			FormationItem formationItemByEntityId = this.GetFormationItemByEntityId(handle.Id);
			if (formationItemByEntityId != null)
			{
				formationItemByEntityId.ClearData();
			}
			this.FormationHeadIconEnergyBar.RemoveEntity(handle.Id);
		}

		// Token: 0x0603C02F RID: 245807 RVA: 0x00E59338 File Offset: 0x00E57538
		private void OnRoleRefreshName()
		{
			foreach (FormationItem formationItem in this.FormationItemList)
			{
				formationItem.RefreshRoleName();
			}
		}

		// Token: 0x0603C030 RID: 245808 RVA: 0x00E59388 File Offset: 0x00E57588
		private void UpdateRoleHp()
		{
			foreach (FormationItem formationItem in this.FormationItemList)
			{
				formationItem.RefreshRoleHealthPercent();
			}
		}

		// Token: 0x0603C031 RID: 245809 RVA: 0x00E593D8 File Offset: 0x00E575D8
		private void OnConcertoResponseOpen(bool isOpen)
		{
			foreach (FormationItem formationItem in this.FormationItemList)
			{
				formationItem.RefreshConcertoResponseModule(isOpen);
			}
		}

		// Token: 0x0603C032 RID: 245810 RVA: 0x00E5942C File Offset: 0x00E5762C
		private void OnTextLanguageChange(string s, string s1)
		{
			foreach (FormationItem formationItem in this.FormationItemList)
			{
				formationItem.RefreshRoleName();
			}
		}

		// Token: 0x0603C033 RID: 245811 RVA: 0x00E5947C File Offset: 0x00E5767C
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

		// Token: 0x0603C034 RID: 245812 RVA: 0x00E594D8 File Offset: 0x00E576D8
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

		// Token: 0x0603C035 RID: 245813 RVA: 0x00E59534 File Offset: 0x00E57734
		private void InputControllerChange(EInputControllerType last, EInputControllerType now)
		{
			base.SetVisible(EBattleUiVisibleReason.Gamepad, Info.Instance.IsInGamepad() == this.IsGamepad);
		}

		// Token: 0x0603C036 RID: 245814 RVA: 0x00E5954F File Offset: 0x00E5774F
		public void RefreshOnDelayShow()
		{
		}

		// Token: 0x0603C037 RID: 245815 RVA: 0x00E59554 File Offset: 0x00E57754
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

		// Token: 0x0603C038 RID: 245816 RVA: 0x00E595C0 File Offset: 0x00E577C0
		public void ResetFormationCooldownExternal()
		{
			foreach (FormationItem formationItem in this.FormationItemList)
			{
				formationItem.RefreshCoolDownExternal(new float?(0f), new float?(0f));
			}
		}

		// Token: 0x0603C039 RID: 245817 RVA: 0x00E59624 File Offset: 0x00E57824
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

		// Token: 0x0603C03A RID: 245818 RVA: 0x00E59690 File Offset: 0x00E57890
		private void OnAfterRefresh()
		{
			this.IsOperating = false;
			if (this.NeedFresh)
			{
				this.NeedFresh = false;
				this.OnRefreshGuest();
			}
		}

		// Token: 0x0603C03B RID: 245819 RVA: 0x00E596B0 File Offset: 0x00E578B0
		private UniTask SetGuest(int id)
		{
			FormationPanel.<SetGuest>d__52 <SetGuest>d__;
			<SetGuest>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<SetGuest>d__.<>4__this = this;
			<SetGuest>d__.id = id;
			<SetGuest>d__.<>1__state = -1;
			<SetGuest>d__.<>t__builder.Start<FormationPanel.<SetGuest>d__52>(ref <SetGuest>d__);
			return <SetGuest>d__.<>t__builder.Task;
		}

		// Token: 0x0603C03C RID: 245820 RVA: 0x00E596FC File Offset: 0x00E578FC
		private UniTask RemoveGuest()
		{
			FormationPanel.<RemoveGuest>d__53 <RemoveGuest>d__;
			<RemoveGuest>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<RemoveGuest>d__.<>4__this = this;
			<RemoveGuest>d__.<>1__state = -1;
			<RemoveGuest>d__.<>t__builder.Start<FormationPanel.<RemoveGuest>d__53>(ref <RemoveGuest>d__);
			return <RemoveGuest>d__.<>t__builder.Task;
		}

		// Token: 0x0603C03D RID: 245821 RVA: 0x00E5973F File Offset: 0x00E5793F
		private void OnPressMotorcycleCombineButtonChanged(bool b)
		{
			this.RefreshKeyItemEnableInMotorcycle();
		}

		// Token: 0x0603C03E RID: 245822 RVA: 0x00E59748 File Offset: 0x00E57948
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

		// Token: 0x0603C03F RID: 245823 RVA: 0x00E59824 File Offset: 0x00E57A24
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

		// Token: 0x0401F4E9 RID: 128233
		[StaticVariableRuleIgnore]
		private static readonly Stat BattleViewTickStatsObject = Stat.Create("[BattleView]FormationPanelTick", "", "");

		// Token: 0x0401F4EA RID: 128234
		[StaticVariableRuleIgnore]
		private static readonly Stat ChangeRoleStat = Stat.Create("[ChangeRole]FormationPanel", "", "");

		// Token: 0x0401F4EB RID: 128235
		private const string GUEST_RESOURCE_ID = "FightRoleHeadGuest";

		// Token: 0x0401F4EC RID: 128236
		private readonly List<FormationItem> FormationItemList = new List<FormationItem>();

		// Token: 0x0401F4ED RID: 128237
		private bool IsUpdatingFormationItem;

		// Token: 0x0401F4EE RID: 128238
		private bool IsGamepad;

		// Token: 0x0401F4EF RID: 128239
		private int? CurEntityId = new int?(0);

		// Token: 0x0401F4F0 RID: 128240
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

		// Token: 0x0401F4F1 RID: 128241
		private readonly FormationHeadIconEnergyBar FormationHeadIconEnergyBar = new FormationHeadIconEnergyBar();

		// Token: 0x0401F4F2 RID: 128242
		[Nullable(2)]
		private GuestItem Guest;

		// Token: 0x0401F4F3 RID: 128243
		private int GuestId;

		// Token: 0x0401F4F4 RID: 128244
		private bool NeedFresh;

		// Token: 0x0401F4F5 RID: 128245
		private bool IsOperating;

		// Token: 0x0200BEAC RID: 48812
		[NullableContext(0)]
		private enum EChildType
		{
			// Token: 0x04039802 RID: 235522
			FormationChildItem1,
			// Token: 0x04039803 RID: 235523
			FormationChildItem2,
			// Token: 0x04039804 RID: 235524
			FormationChildItem3,
			// Token: 0x04039805 RID: 235525
			FormationChildItem4,
			// Token: 0x04039806 RID: 235526
			Layout
		}

		// Token: 0x0200BEAD RID: 48813
		[NullableContext(0)]
		private enum EPadType
		{
			// Token: 0x04039808 RID: 235528
			Layout = 3
		}

		// Token: 0x0200BEAE RID: 48814
		[NullableContext(0)]
		private enum EPosition
		{
			// Token: 0x0403980A RID: 235530
			OnePlayer,
			// Token: 0x0403980B RID: 235531
			TwoPlayer,
			// Token: 0x0403980C RID: 235532
			ThreePlayer,
			// Token: 0x0403980D RID: 235533
			FourPlayer
		}
	}
}
