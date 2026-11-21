using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Core.Common;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Battle;
using CSharpScript.Game.Module.RoleUi;
using CSharpScript.Game.Module.Skin;
using CSharpScript.Game.NewWorld.Character.Common.Component.Abilities;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.BattleUi.Views
{
	// Token: 0x02004D08 RID: 19720
	[NullableContext(2)]
	[Nullable(0)]
	public class FormationItem : BattleChildView
	{
		// Token: 0x06031687 RID: 202375 RVA: 0x00DCF5B4 File Offset: 0x00DCD7B4
		protected unsafe override void OnRegisterComponent()
		{
			int num = 25;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIExtendToggle));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUINiagara));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(9, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(12, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(17, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(13, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(14, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(15, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(16, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(10, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(7, typeof(UUINiagara));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(8, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(11, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(18, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(19, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(20, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(21, typeof(UUINiagara));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(22, typeof(UUINiagara));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(23, typeof(UUINiagara));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(24, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
			if (!Info.Instance.IsInTouch())
			{
				this.ComponentRegisterInfos.Add(new ValueTuple<int, Type>(25, typeof(UUIItem)));
			}
		}

		// Token: 0x06031688 RID: 202376 RVA: 0x00DCF94D File Offset: 0x00DCDB4D
		public override void Initialize(object param = null)
		{
			base.Initialize(param);
			this.PrefabIndex = (int)param;
			this.ConcertoChangeEffectDelay = BattleUiModel.Instance.ConcertoChangeEffectDelay;
			base.GetTexture(9).SetUIActive(false);
			this.AddEvents();
		}

		// Token: 0x06031689 RID: 202377 RVA: 0x00DCF988 File Offset: 0x00DCDB88
		protected override UniTask InitializeAsync(object param = null)
		{
			FormationItem.<InitializeAsync>d__41 <InitializeAsync>d__;
			<InitializeAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitializeAsync>d__.<>4__this = this;
			<InitializeAsync>d__.<>1__state = -1;
			<InitializeAsync>d__.<>t__builder.Start<FormationItem.<InitializeAsync>d__41>(ref <InitializeAsync>d__);
			return <InitializeAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603168A RID: 202378 RVA: 0x00DCF9CC File Offset: 0x00DCDBCC
		private UniTask InitTrialComponent()
		{
			FormationItem.<InitTrialComponent>d__42 <InitTrialComponent>d__;
			<InitTrialComponent>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitTrialComponent>d__.<>4__this = this;
			<InitTrialComponent>d__.<>1__state = -1;
			<InitTrialComponent>d__.<>t__builder.Start<FormationItem.<InitTrialComponent>d__42>(ref <InitTrialComponent>d__);
			return <InitTrialComponent>d__.<>t__builder.Task;
		}

		// Token: 0x0603168B RID: 202379 RVA: 0x00DCFA0F File Offset: 0x00DCDC0F
		public void ResetItem()
		{
			this.ClearData();
			this.SetActive(false);
		}

		// Token: 0x0603168C RID: 202380 RVA: 0x00DCFA20 File Offset: 0x00DCDC20
		public void Refresh(int playerId, int roleConfigId, int roleSkinId, BattleUiRoleData roleData)
		{
			this.ClearData();
			this.PlayerId = playerId;
			int? id = PlayerInfoModel.Instance.GetId();
			this.IsMyRole = (playerId == id.GetValueOrDefault() & id != null);
			this.RoleData = roleData;
			if (this.RoleConfigId != roleConfigId || this.RoleSkinId != roleSkinId)
			{
				this.RoleConfigId = roleConfigId;
				this.RoleSkinId = roleSkinId;
				this.RoleConfig = CSharpScript.Game.Module.RoleUi.RoleConfig.Instance.GetRoleConfig(this.RoleConfigId);
				if (this.RoleConfig.Value.RoleType == 1)
				{
					this.RoleSkinConfig = SkinConfig.Instance.GetRoleSkinConfig(this.RoleSkinId);
				}
				else
				{
					this.RoleSkinConfig = null;
				}
				this.RefreshRoleHead();
				this.RefreshRoleName();
			}
			this.RefreshOnlineItem();
			WorldEntity worldEntity;
			if (roleData == null)
			{
				worldEntity = null;
			}
			else
			{
				EntityHandle entityHandle = roleData.EntityHandle;
				worldEntity = ((entityHandle != null) ? entityHandle.Entity : null);
			}
			WorldEntity worldEntity2 = worldEntity;
			if (worldEntity2 == null || !worldEntity2.IsInit)
			{
				this.RefreshRoleHealthPercent();
				base.GetItem(14).SetUIActive(false);
				base.GetSprite(17).SetUIActive(false);
				this.SetActive(true);
				return;
			}
			this.EntityId = new int?(worldEntity2.Id);
			BattleUiRoleData roleData2 = this.RoleData;
			this.IsAssistRole = (roleData2 != null && roleData2.GameplayTagComponent.HasTag(GameplayTagDefine.EGameplayTagId["功能.功能制作.QTE.辅战QTE状态"]));
			this.AddEntityEvents(worldEntity2);
			this.RefreshRoleHealthPercent();
			this.RefreshFormationConcertoItem();
			this.RefreshSuperSkillVisible();
			this.RefreshUltimateColor();
			this.RefreshKeyItem();
			this.RefreshChangeCoolDown();
			this.RefreshQteActive();
			this.RefreshLinkEffect();
			this.RefreshIsAssist();
			this.SetActive(true);
		}

		// Token: 0x0603168D RID: 202381 RVA: 0x00DCFBC0 File Offset: 0x00DCDDC0
		public void ClearData()
		{
			BattleUiRoleData roleData = this.RoleData;
			WorldEntity worldEntity;
			if (roleData == null)
			{
				worldEntity = null;
			}
			else
			{
				EntityHandle entityHandle = roleData.EntityHandle;
				worldEntity = ((entityHandle != null) ? entityHandle.Entity : null);
			}
			WorldEntity worldEntity2 = worldEntity;
			if (worldEntity2 == null && this.EntityId != null)
			{
				EntityHandle handle = CharacterModel.Instance.GetHandle(this.EntityId.Value);
				worldEntity2 = ((handle != null) ? handle.Entity : null);
			}
			this.RemoveEntityEvents(worldEntity2);
			this.RoleData = null;
			this.EntityId = null;
			this.PlayerId = 0;
			this.IsMyRole = false;
			this.RoleConfigId = 0;
			this.RoleConfig = null;
		}

		// Token: 0x0603168E RID: 202382 RVA: 0x00DCFC5C File Offset: 0x00DCDE5C
		private void AddEvents()
		{
			base.GetExtendToggle(0).OnPointDownCallBack.Bind(new Action<EToggleState>(this.OnFormationTogglePointDown));
			EventSystem.Instance.Add<int>(EEventName.BattleUiElementEnergyChanged, new Action<int>(this.OnElementEnergyChanged));
			EventSystem.Instance.Add<int>(EEventName.BattleUiEnergyChanged, new Action<int>(this.OnEnergyChanged));
			EventSystem.Instance.Add<int>(EEventName.BattleUiRoleHeadChanged, new Action<int>(this.OnRoleHeadChanged));
			EventSystem.Instance.Add<int, int, bool>(EEventName.BattleUiElementHideTagChanged, new Action<int, int, bool>(this.OnElementHideTagChanged));
			EventSystem.Instance.Add<int>(EEventName.BattleUiHealthChanged, new Action<int>(this.OnHealthChanged));
			EventSystem.Instance.Add<int>(EEventName.BattleUiShieldChanged, new Action<int>(this.OnShieldChanged));
			EventSystem.Instance.Add<int, int, bool>(EEventName.BattleUiQteEnableTagChanged, new Action<int, int, bool>(this.OnQteEnableTagChanged));
			EventSystem.Instance.Add<int, int, bool>(EEventName.BattleUiDeadTagChanged, new Action<int, int, bool>(this.OnBattleUiDeadTagChanged));
			EventSystem.Instance.Add<int, int, bool>(EEventName.BattleUiQteCdTagChanged, new Action<int, int, bool>(this.OnBattleUiQteCdTagChanged));
			EventSystem.Instance.Add<int, bool>(EEventName.CharInQteChanged, new Action<int, bool>(this.OnCharInQteChanged));
			EventSystem.Instance.Add(EEventName.OnBattleStateChanged, new Action<bool>(this.OnBattleStateChanged));
			EventSystem.Instance.Add<ELinkStatus>(EEventName.OnBattleLinkStatusChanged, new Action<ELinkStatus>(this.OnBattleLinkStatusChanged));
		}

		// Token: 0x0603168F RID: 202383 RVA: 0x00DCFDD4 File Offset: 0x00DCDFD4
		private void RemoveEvents()
		{
			base.GetExtendToggle(0).OnPointDownCallBack.Unbind();
			EventSystem.Instance.Remove(EEventName.BattleUiElementEnergyChanged, new Action<int>(this.OnElementEnergyChanged));
			EventSystem.Instance.Remove(EEventName.BattleUiEnergyChanged, new Action<int>(this.OnEnergyChanged));
			EventSystem.Instance.Remove(EEventName.BattleUiRoleHeadChanged, new Action<int>(this.OnRoleHeadChanged));
			EventSystem.Instance.Remove(EEventName.BattleUiElementHideTagChanged, new Action<int, int, bool>(this.OnElementHideTagChanged));
			EventSystem.Instance.Remove(EEventName.BattleUiHealthChanged, new Action<int>(this.OnHealthChanged));
			EventSystem.Instance.Remove(EEventName.BattleUiShieldChanged, new Action<int>(this.OnShieldChanged));
			EventSystem.Instance.Remove(EEventName.BattleUiQteEnableTagChanged, new Action<int, int, bool>(this.OnQteEnableTagChanged));
			EventSystem.Instance.Remove(EEventName.BattleUiDeadTagChanged, new Action<int, int, bool>(this.OnBattleUiDeadTagChanged));
			EventSystem.Instance.Remove(EEventName.BattleUiQteCdTagChanged, new Action<int, int, bool>(this.OnBattleUiQteCdTagChanged));
			EventSystem.Instance.Remove(EEventName.CharInQteChanged, new Action<int, bool>(this.OnCharInQteChanged));
			EventSystem.Instance.Remove(EEventName.OnBattleStateChanged, new Action<bool>(this.OnBattleStateChanged));
			EventSystem.Instance.Remove(EEventName.OnBattleLinkStatusChanged, new Action<ELinkStatus>(this.OnBattleLinkStatusChanged));
		}

		// Token: 0x06031690 RID: 202384 RVA: 0x00DCFF40 File Offset: 0x00DCE140
		[NullableContext(1)]
		private void AddEntityEvents(Entity entity)
		{
			EventSystem.Instance.AddWithTarget<double>(entity, EEventName.OnChangeRoleCoolDownChanged, new Action<double>(this.OnEnterChangeCoolDownCallback));
			if (!this.IsMyRole)
			{
				BaseTagComponent component = entity.GetComponent<BaseTagComponent>();
				this.ListenForTagSignificantChanged(component, GameplayTagDefine.EGameplayTagId["功能.功能制作.QTE.激活QTE"], new BaseTagComponent.TTagSwitchedCallback(this.OnTeammateQteEnableTagChanged));
				return;
			}
			BaseTagComponent component2 = entity.GetComponent<BaseTagComponent>();
			this.ListenForTagSignificantChanged(component2, GameplayTagDefine.EGameplayTagId["功能.功能制作.QTE.辅战CD"], new BaseTagComponent.TTagSwitchedCallback(this.OnAssistQteCdTagChanged));
			this.ListenForTagSignificantChanged(component2, GameplayTagDefine.EGameplayTagId["功能.功能制作.QTE.辅战QTE状态"], new BaseTagComponent.TTagSwitchedCallback(this.OnAssistRoleTagChanged));
		}

		// Token: 0x06031691 RID: 202385 RVA: 0x00DCFFE8 File Offset: 0x00DCE1E8
		[NullableContext(1)]
		private void ListenForTagSignificantChanged(BaseTagComponent gameplayTagComponent, int tagId, BaseTagComponent.TTagSwitchedCallback callback)
		{
			ITagTask tagTask = gameplayTagComponent.ListenForTagAddOrRemove(new int?(tagId), callback, null);
			if (tagTask != null)
			{
				this.TagSignificantChangedTaskList.Add(tagTask);
			}
		}

		// Token: 0x06031692 RID: 202386 RVA: 0x00DD0014 File Offset: 0x00DCE214
		protected void RemoveEntityEvents(Entity entity)
		{
			if (entity != null)
			{
				EventSystem.Instance.RemoveWithTarget<double>(entity, EEventName.OnChangeRoleCoolDownChanged, new Action<double>(this.OnEnterChangeCoolDownCallback));
			}
			foreach (ITagTask tagTask in this.TagSignificantChangedTaskList)
			{
				tagTask.EndTask();
			}
			this.TagSignificantChangedTaskList.Clear();
		}

		// Token: 0x06031693 RID: 202387 RVA: 0x00DD0090 File Offset: 0x00DCE290
		protected override void OnShowBattleChildView()
		{
			this.SetCoolDownItemVisible(false);
		}

		// Token: 0x06031694 RID: 202388 RVA: 0x00DD009C File Offset: 0x00DCE29C
		public override void Reset()
		{
			this.KeyItem = null;
			this.RemoveEvents();
			this.CoolDownTime = 0.0;
			this.ResetChangeCoolDown();
			this.DeactivateConcertoChangeEffect();
			if (TimerSystem.Instance.Has(this.CureDelayTimerId))
			{
				TimerSystem.Instance.Remove(this.CureDelayTimerId);
			}
			if (this.TrialComponent != null)
			{
				this.TrialComponent.Destroy(null);
				this.TrialComponent = null;
			}
			if (this.LevelUpComponent != null)
			{
				this.LevelUpComponent.Destroy(null);
				this.LevelUpComponent = null;
			}
			if (this.RoleHeadOnlineComponent != null)
			{
				this.RoleHeadOnlineComponent.Destroy(null);
				this.RoleHeadOnlineComponent = null;
			}
			if (TimerSystem.Instance.Has(this.RefreshKeyItemTimer))
			{
				TimerSystem.Instance.Remove(this.RefreshKeyItemTimer);
				this.RefreshKeyItemTimer = null;
			}
			base.Reset();
		}

		// Token: 0x06031695 RID: 202389 RVA: 0x00DD0178 File Offset: 0x00DCE378
		public void OnTick(float delta)
		{
			if (this.CoolDownTime > 0.0)
			{
				double num = this.CoolDownEndTime - Time.Instance.PlayerWorldTime;
				if (num <= 0.0)
				{
					this.CoolDownTime = 0.0;
					this.ResetChangeCoolDown();
					return;
				}
				if (Math.Abs(this.LastRefreshTextCoolDownTime - num) > 100.0)
				{
					this.LastRefreshTextCoolDownTime -= 100.0;
					this.RefreshCoolDownText();
				}
				this.UpdateChangeRoleCoolDownAnim(num);
			}
		}

		// Token: 0x06031696 RID: 202390 RVA: 0x00DD0208 File Offset: 0x00DCE408
		private bool IsCurrentRole()
		{
			SceneTeamPlayer teamPlayerData = SceneTeamModel.Instance.GetTeamPlayerData(this.PlayerId);
			BattleUiFormationPanelData formationPanelData = BattleUiModel.Instance.FormationPanelData;
			ETeamGroupType groupType = (formationPanelData != null) ? formationPanelData.DataSource : ETeamGroupType.Battle;
			int? num2;
			if (teamPlayerData != null)
			{
				SceneTeamGroup group = teamPlayerData.GetGroup(groupType);
				int? num;
				if (group == null)
				{
					num = null;
				}
				else
				{
					SceneTeamRole currentRole = group.GetCurrentRole();
					num = ((currentRole != null) ? new int?(currentRole.RoleId) : null);
				}
				num2 = num;
			}
			else
			{
				global::WorldTeamPlayerFightInfo worldTeamPlayerFightInfo = OnlineModel.Instance.GetWorldTeamPlayerFightInfo(this.PlayerId);
				num2 = ((worldTeamPlayerFightInfo != null) ? new int?(worldTeamPlayerFightInfo.CurRoleId) : null);
			}
			int? num3 = num2;
			int roleConfigId = this.RoleConfigId;
			return num3.GetValueOrDefault() == roleConfigId & num3 != null;
		}

		// Token: 0x06031697 RID: 202391 RVA: 0x00DD02C0 File Offset: 0x00DCE4C0
		private void OnEnterChangeCoolDownCallback(double coolDownTime)
		{
			if (Info.Instance.OperationType == global::EOperationType.Desktop)
			{
				double num = coolDownTime * (double)TimeUtil.Instance.InverseMillisecond;
				this.PlayChangeRoleCoolDown(num, num);
			}
		}

		// Token: 0x06031698 RID: 202392 RVA: 0x00DD02F0 File Offset: 0x00DCE4F0
		private void OnShieldChanged(int entityId)
		{
			if (this.RoleData == null)
			{
				return;
			}
			this.RefreshRoleHealthPercent();
		}

		// Token: 0x06031699 RID: 202393 RVA: 0x00DD0304 File Offset: 0x00DCE504
		private void OnHealthChanged(int entityId)
		{
			if (this.RoleData == null)
			{
				return;
			}
			int? entityId2 = this.EntityId;
			if (!(entityId2.GetValueOrDefault() == entityId & entityId2 != null))
			{
				return;
			}
			this.RefreshRoleHealthPercent();
		}

		// Token: 0x0603169A RID: 202394 RVA: 0x00DD033E File Offset: 0x00DCE53E
		private void ResetAllConcertoNiagara()
		{
			this.SetCanUseQte(false, true, ERoleQteType.Normal);
		}

		// Token: 0x0603169B RID: 202395 RVA: 0x00DD0349 File Offset: 0x00DCE549
		private void OnQteEnableTagChanged(int entityId, int tagId, bool bTagExists)
		{
			if (FormationDataController.Instance.IsBattleMulti())
			{
				return;
			}
			this.RefreshSingleModeQteEnable();
		}

		// Token: 0x0603169C RID: 202396 RVA: 0x00DD035E File Offset: 0x00DCE55E
		private void OnTeammateQteEnableTagChanged(int tagId, bool tagExist)
		{
			this.RefreshMultiModeQteEnable();
		}

		// Token: 0x0603169D RID: 202397 RVA: 0x00DD0366 File Offset: 0x00DCE566
		private void OnAssistQteCdTagChanged(int tagId, bool tagExist)
		{
			this.RefreshAssistCoolDown();
		}

		// Token: 0x0603169E RID: 202398 RVA: 0x00DD036E File Offset: 0x00DCE56E
		private void OnAssistRoleTagChanged(int tagId, bool tagExist)
		{
			if (this.IsAssistRole == tagExist)
			{
				return;
			}
			this.IsAssistRole = tagExist;
			this.RefreshIsAssist();
		}

		// Token: 0x0603169F RID: 202399 RVA: 0x00DD0387 File Offset: 0x00DCE587
		private void OnBattleUiDeadTagChanged(int entityId, int tagId, bool tagExist)
		{
			this.RefreshQteActive();
		}

		// Token: 0x060316A0 RID: 202400 RVA: 0x00DD038F File Offset: 0x00DCE58F
		private void OnBattleUiQteCdTagChanged(int entityId, int tagId, bool tagExist)
		{
			this.RefreshQteActive();
		}

		// Token: 0x060316A1 RID: 202401 RVA: 0x00DD0397 File Offset: 0x00DCE597
		private void OnCharInQteChanged(int entityId, bool tagExist)
		{
			this.RefreshQteActive();
		}

		// Token: 0x060316A2 RID: 202402 RVA: 0x00DD039F File Offset: 0x00DCE59F
		private void OnBattleStateChanged(bool isFight)
		{
			this.RefreshQteActive();
		}

		// Token: 0x060316A3 RID: 202403 RVA: 0x00DD03A7 File Offset: 0x00DCE5A7
		public void RefreshQteActive()
		{
			if (FormationDataController.Instance.IsBattleMulti())
			{
				this.RefreshMultiModeQteEnable();
				return;
			}
			this.RefreshSingleModeQteEnable();
		}

		// Token: 0x060316A4 RID: 202404 RVA: 0x00DD03C4 File Offset: 0x00DCE5C4
		private void RefreshSingleModeQteEnable()
		{
			if (this.RoleData == null)
			{
				this.ResetAllConcertoNiagara();
				return;
			}
			bool flag = false;
			ERoleQteType qteType = ERoleQteType.Normal;
			if (this.IsConcertoResponseOpen)
			{
				BattleUiRoleData curRoleData = BattleUiModel.Instance.GetCurRoleData();
				EntityHandle entityHandle = (curRoleData != null) ? curRoleData.EntityHandle : null;
				if (entityHandle != null && this.RoleData.EntityHandle != entityHandle)
				{
					RoleQteComponent roleQteComponent = this.RoleData.RoleQteComponent;
					flag = (roleQteComponent != null && roleQteComponent.IsQteReady(entityHandle));
					if (flag)
					{
						qteType = roleQteComponent.GetRoleQteType(entityHandle);
					}
				}
			}
			this.SetCanUseQte(flag, false, qteType);
		}

		// Token: 0x060316A5 RID: 202405 RVA: 0x00DD0444 File Offset: 0x00DCE644
		private void RefreshMultiModeQteEnable()
		{
			if (this.RoleData == null || this.IsMyRole)
			{
				this.ResetAllConcertoNiagara();
				return;
			}
			bool flag = false;
			ERoleQteType qteType = ERoleQteType.Normal;
			BattleUiRoleData curRoleData = BattleUiModel.Instance.GetCurRoleData();
			EntityHandle entityHandle = (curRoleData != null) ? curRoleData.EntityHandle : null;
			EntityHandle entityHandle2 = this.RoleData.EntityHandle;
			if (entityHandle != null && entityHandle2 != null && entityHandle2.IsInit)
			{
				RoleQteComponent component = entityHandle.Entity.GetComponent<RoleQteComponent>();
				flag = component.IsQteReady(entityHandle2);
				if (flag)
				{
					qteType = component.GetMultiRoleQteType();
				}
			}
			this.SetCanUseQte(flag, false, qteType);
		}

		// Token: 0x060316A6 RID: 202406 RVA: 0x00DD04C8 File Offset: 0x00DCE6C8
		private void SetCanUseQte(bool bCanUseQte, bool isInit, ERoleQteType qteType = ERoleQteType.Normal)
		{
			if (this.QteNiagaraActive == bCanUseQte && this.CurrentQteNiagaraType == qteType)
			{
				this.RefreshKeyItemGray();
				return;
			}
			this.QteNiagaraActive = bCanUseQte;
			this.CurrentQteNiagaraType = qteType;
			foreach (KeyValuePair<ERoleQteType, FormationItem.EChildType> keyValuePair in this.QteTypeNiagaraMap)
			{
				ERoleQteType eroleQteType;
				FormationItem.EChildType echildType;
				keyValuePair.Deconstruct(out eroleQteType, out echildType);
				ERoleQteType eroleQteType2 = eroleQteType;
				FormationItem.EChildType name = echildType;
				UUINiagara uiNiagara = base.GetUiNiagara((int)name);
				if (uiNiagara != null)
				{
					if (bCanUseQte && eroleQteType2 == qteType)
					{
						uiNiagara.SetUIActive(true);
						uiNiagara.ActivateSystem(true);
					}
					else
					{
						uiNiagara.Deactivate();
						uiNiagara.SetUIActive(false);
					}
				}
			}
			if (bCanUseQte && !isInit)
			{
				EBattleUiAudioType type = this.IsAssistRole ? EBattleUiAudioType.QteCanUseRogue : EBattleUiAudioType.QteCanUse;
				EBattleUiChild uiChildType = Info.Instance.IsInGamepad() ? EBattleUiChild.GamepadFormation : EBattleUiChild.Formation;
				BattleUiModel.Instance.AudioData.PlayAudio(type, uiChildType);
			}
			this.RefreshKeyItemGray();
		}

		// Token: 0x060316A7 RID: 202407 RVA: 0x00DD05C8 File Offset: 0x00DCE7C8
		private void RefreshChangeCoolDown()
		{
			BattleUiRoleData roleData = this.RoleData;
			RoleTeamComponent roleTeamComponent;
			if (roleData == null)
			{
				roleTeamComponent = null;
			}
			else
			{
				EntityHandle entityHandle = roleData.EntityHandle;
				if (entityHandle == null)
				{
					roleTeamComponent = null;
				}
				else
				{
					WorldEntity entity = entityHandle.Entity;
					roleTeamComponent = ((entity != null) ? entity.GetComponent<RoleTeamComponent>() : null);
				}
			}
			RoleTeamComponent roleTeamComponent2 = roleTeamComponent;
			if (roleTeamComponent2 == null)
			{
				return;
			}
			double changeRoleCoolDown = roleTeamComponent2.GetChangeRoleCoolDown();
			if (changeRoleCoolDown <= 0.0)
			{
				return;
			}
			this.PlayChangeRoleCoolDown(changeRoleCoolDown, changeRoleCoolDown);
		}

		// Token: 0x060316A8 RID: 202408 RVA: 0x00DD0620 File Offset: 0x00DCE820
		private void SetSelectedNiagara(bool bSelected)
		{
			if (this.SelectedNiagaraActive == bSelected)
			{
				return;
			}
			this.SelectedNiagaraActive = bSelected;
			if (bSelected)
			{
				this.StopTweenAnim(19);
				this.PlayTweenAnim(18);
				return;
			}
			this.StopTweenAnim(18);
			this.PlayTweenAnim(19);
		}

		// Token: 0x060316A9 RID: 202409 RVA: 0x00DD0658 File Offset: 0x00DCE858
		private void ResetChangeCoolDown()
		{
			Log.Instance.Info(ELogModule.Battle, ELogAuthor.CFT, "重置换人冷却表现", default(ReadOnlySpan<ValueTuple<string, object>>));
			this.SetCoolDownItemVisible(false);
		}

		// Token: 0x060316AA RID: 202410 RVA: 0x00DD0688 File Offset: 0x00DCE888
		private void OnFormationTogglePointDown(EToggleState state)
		{
			BattleUiRoleData roleData = this.RoleData;
			long? num = (roleData != null) ? new long?(roleData.CreatureDataId) : null;
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Formation;
			ELogAuthor author = ELogAuthor.CFT;
			string message = "当点击阵容头像按钮时";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("CreatureDataId", num);
			instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			if (GlobalData.GameInstance != null && num != null)
			{
				CooperationController.Instance.TryCooperate(num.Value);
			}
		}

		// Token: 0x060316AB RID: 202411 RVA: 0x00DD0704 File Offset: 0x00DCE904
		public void LevelUp(int level)
		{
			string levelText = level.ToString();
			if (this.LevelUpComponent == null)
			{
				this.LevelUpComponent = new FormationLevelUpItem(this.RootItem);
			}
			else
			{
				this.LevelUpComponent.SetActive(true);
			}
			this.LevelUpComponent.SetLevelText(levelText);
			TimerSystem.Instance.Delay(delegate(float _)
			{
				FormationLevelUpItem levelUpComponent = this.LevelUpComponent;
				if (levelUpComponent == null)
				{
					return;
				}
				levelUpComponent.SetActive(false);
			}, 5000f, null, null, true, 1f);
		}

		// Token: 0x060316AC RID: 202412 RVA: 0x00DD0770 File Offset: 0x00DCE970
		public void RefreshConcertoResponseModule(bool isOpen)
		{
			this.IsConcertoResponseOpen = isOpen;
			this.RefreshElementVisible();
		}

		// Token: 0x060316AD RID: 202413 RVA: 0x00DD0780 File Offset: 0x00DCE980
		public void CureRole()
		{
			if (!this.IsCurrentRole())
			{
				BattleUiRoleData roleData = this.RoleData;
				bool? flag;
				if (roleData == null)
				{
					flag = null;
				}
				else
				{
					BaseDeathComponent baseDeathComponent = roleData.BaseDeathComponent;
					flag = ((baseDeathComponent != null) ? new bool?(baseDeathComponent.IsDead()) : null);
				}
				bool? flag2 = flag;
				if (!flag2.GetValueOrDefault(true))
				{
					base.GetItem(4).SetUIActive(true);
					this.CureDelayTimerId = TimerSystem.Instance.Delay(delegate(float _)
					{
						base.GetItem(4).SetUIActive(false);
					}, 1000f, null, null, true, 1f);
					return;
				}
			}
		}

		// Token: 0x060316AE RID: 202414 RVA: 0x00DD080C File Offset: 0x00DCEA0C
		[NullableContext(1)]
		private void SetRoleHead(string roleTexturePath, int roleConfigId)
		{
			FormationItem.<>c__DisplayClass78_0 CS$<>8__locals1 = new FormationItem.<>c__DisplayClass78_0();
			CS$<>8__locals1.roleTexture = base.GetTexture(9);
			if (CS$<>8__locals1.roleTexture == null)
			{
				return;
			}
			CS$<>8__locals1.changeRoleCoolDownBarTexture = base.GetTexture(2);
			if (CS$<>8__locals1.changeRoleCoolDownBarTexture == null)
			{
				return;
			}
			base.SetRoleIcon(roleTexturePath, CS$<>8__locals1.roleTexture, roleConfigId, null, new Action<bool>(CS$<>8__locals1.<SetRoleHead>g__IconCallback|0));
			CS$<>8__locals1.changeRoleCoolDownBarTexture.SetUIActive(false);
			base.SetRoleIcon(roleTexturePath, CS$<>8__locals1.changeRoleCoolDownBarTexture, roleConfigId, null, new Action<bool>(CS$<>8__locals1.<SetRoleHead>g__MaskCallback|1));
		}

		// Token: 0x060316AF RID: 202415 RVA: 0x00DD08A0 File Offset: 0x00DCEAA0
		[NullableContext(1)]
		public void SetRoleHeadByPathOnly(string path)
		{
			FormationItem.<>c__DisplayClass79_0 CS$<>8__locals1 = new FormationItem.<>c__DisplayClass79_0();
			CS$<>8__locals1.roleTexture = base.GetTexture(9);
			if (CS$<>8__locals1.roleTexture == null)
			{
				return;
			}
			CS$<>8__locals1.changeRoleCoolDownBarTexture = base.GetTexture(2);
			if (CS$<>8__locals1.changeRoleCoolDownBarTexture == null)
			{
				return;
			}
			base.SetTextureByPath(path, CS$<>8__locals1.roleTexture, null, new Action<bool>(CS$<>8__locals1.<SetRoleHeadByPathOnly>g__IconCallback|0));
			CS$<>8__locals1.changeRoleCoolDownBarTexture.SetUIActive(false);
			base.SetTextureByPath(path, CS$<>8__locals1.changeRoleCoolDownBarTexture, null, new Action<bool>(CS$<>8__locals1.<SetRoleHeadByPathOnly>g__MaskCallback|1));
		}

		// Token: 0x060316B0 RID: 202416 RVA: 0x00DD0930 File Offset: 0x00DCEB30
		[NullableContext(1)]
		private void SetRoleSkinHead(string roleTexturePath, int roleSkinId)
		{
			FormationItem.<>c__DisplayClass80_0 CS$<>8__locals1 = new FormationItem.<>c__DisplayClass80_0();
			CS$<>8__locals1.roleTexture = base.GetTexture(9);
			if (CS$<>8__locals1.roleTexture == null)
			{
				return;
			}
			CS$<>8__locals1.changeRoleCoolDownBarTexture = base.GetTexture(2);
			if (CS$<>8__locals1.changeRoleCoolDownBarTexture == null)
			{
				return;
			}
			base.SetRoleSkinIcon(roleTexturePath, CS$<>8__locals1.roleTexture, roleSkinId, null, new Action<bool>(CS$<>8__locals1.<SetRoleSkinHead>g__IconCallback|0));
			CS$<>8__locals1.changeRoleCoolDownBarTexture.SetUIActive(false);
			base.SetRoleSkinIcon(roleTexturePath, CS$<>8__locals1.changeRoleCoolDownBarTexture, roleSkinId, null, new Action<bool>(CS$<>8__locals1.<SetRoleSkinHead>g__MaskCallback|1));
		}

		// Token: 0x060316B1 RID: 202417 RVA: 0x00DD09C4 File Offset: 0x00DCEBC4
		private void SetHealthPercent(float healthPercent)
		{
			UUISprite sprite;
			if (healthPercent <= 0.2f)
			{
				sprite = base.GetSprite(13);
				base.GetSprite(12).SetUIActive(false);
				base.GetSprite(13).SetUIActive(true);
			}
			else
			{
				sprite = base.GetSprite(12);
				base.GetSprite(12).SetUIActive(true);
				base.GetSprite(13).SetUIActive(false);
			}
			if (sprite != null)
			{
				sprite.SetFillAmount(healthPercent);
			}
		}

		// Token: 0x060316B2 RID: 202418 RVA: 0x00DD0A30 File Offset: 0x00DCEC30
		public void RefreshRoleName()
		{
			int roleConfigId = this.RoleConfigId;
			if (roleConfigId <= 100000)
			{
				FormationTrialItem trialComponent = this.TrialComponent;
				if (trialComponent == null)
				{
					return;
				}
				trialComponent.SetActive(false);
				return;
			}
			else
			{
				TrialRoleInfo? trialRoleConfig = CSharpScript.Game.Module.RoleUi.RoleConfig.Instance.GetTrialRoleConfig(roleConfigId);
				if (trialRoleConfig != null && trialRoleConfig.GetValueOrDefault().HideTrialLabel)
				{
					FormationTrialItem trialComponent2 = this.TrialComponent;
					if (trialComponent2 == null)
					{
						return;
					}
					trialComponent2.SetActive(false);
					return;
				}
				else
				{
					FormationTrialItem trialComponent3 = this.TrialComponent;
					if (trialComponent3 != null)
					{
						trialComponent3.SetActive(true);
					}
					string nameText;
					if (this.IsMyRole)
					{
						nameText = (RoleUtils.IsSpecialTrialRole(roleConfigId) ? string.Empty : RoleModel.Instance.GetRoleName(roleConfigId, null));
					}
					else
					{
						OnlineTeamData currentTeamListById = OnlineModel.Instance.GetCurrentTeamListById(this.PlayerId);
						nameText = (((currentTeamListById != null) ? currentTeamListById.Name : null) ?? string.Empty);
					}
					FormationTrialItem trialComponent4 = this.TrialComponent;
					if (trialComponent4 != null)
					{
						trialComponent4.SetNameText(nameText);
					}
					ETrialRoleType trialRoleType = ETrialRoleType.NormalTrial;
					if (trialRoleConfig != null)
					{
						trialRoleType = (ETrialRoleType)trialRoleConfig.Value.Type;
					}
					string trialRoleLabelIconByType = RoleUtils.GetTrialRoleLabelIconByType(trialRoleType);
					FormationTrialItem trialComponent5 = this.TrialComponent;
					if (trialComponent5 == null)
					{
						return;
					}
					trialComponent5.SetTrialIcon(trialRoleLabelIconByType);
					return;
				}
			}
		}

		// Token: 0x060316B3 RID: 202419 RVA: 0x00DD0B4C File Offset: 0x00DCED4C
		public void SetRoleSelected(bool bSelected)
		{
			if (Info.Instance.OperationType == global::EOperationType.Desktop)
			{
				bool selectedNiagara = false;
				if (SceneTeamModel.Instance.GetTeamLength() > 1)
				{
					selectedNiagara = bSelected;
				}
				this.SetSelectedNiagara(selectedNiagara);
			}
			else
			{
				this.SetSelectedNiagara(bSelected);
			}
			this.RefreshSuperSkillVisible();
		}

		// Token: 0x060316B4 RID: 202420 RVA: 0x00DD0B8D File Offset: 0x00DCED8D
		public void RefreshCoolDownOnShow()
		{
			if (this.RoleData == null)
			{
				return;
			}
			this.RefreshChangeCoolDown();
			this.RefreshAssistCoolDown();
		}

		// Token: 0x060316B5 RID: 202421 RVA: 0x00DD0BA4 File Offset: 0x00DCEDA4
		private void PlayChangeRoleCoolDown(double coolDownTime, double coolDownTimeRemain)
		{
			if (coolDownTime <= 0.0)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.Formation;
				ELogAuthor author = ELogAuthor.CFT;
				string message = "播放换人冷却CD时，CD时间小于0，不会播放换人冷却CD表现";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("coolDownTime", coolDownTime);
				instance.Warn(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				this.ResetChangeCoolDown();
				return;
			}
			this.CoolDownEndTime = Time.Instance.PlayerWorldTime + coolDownTimeRemain;
			this.CoolDownTime = coolDownTime;
			this.LastRefreshTextCoolDownTime = coolDownTimeRemain;
			this.RefreshCoolDownText();
			this.UpdateChangeRoleCoolDownAnim(coolDownTimeRemain);
			this.SetCoolDownItemVisible(true);
		}

		// Token: 0x060316B6 RID: 202422 RVA: 0x00DD0C24 File Offset: 0x00DCEE24
		private void UpdateChangeRoleCoolDownAnim(double coolDownTimeRemain)
		{
			if (this.RefreshCooldownExternalLock)
			{
				return;
			}
			if (coolDownTimeRemain <= 0.0)
			{
				return;
			}
			double num = coolDownTimeRemain / this.CoolDownTime;
			base.GetTexture(2).SetFillAmount((float)num);
		}

		// Token: 0x060316B7 RID: 202423 RVA: 0x00DD0C60 File Offset: 0x00DCEE60
		private void RefreshCoolDownText()
		{
			if (this.RefreshCooldownExternalLock)
			{
				return;
			}
			UUIText text = base.GetText(3);
			if (text == null)
			{
				return;
			}
			text.SetText((this.LastRefreshTextCoolDownTime * TimeUtil.Instance.Millisecond).ToString("F1"), true);
		}

		// Token: 0x060316B8 RID: 202424 RVA: 0x00DD0CA6 File Offset: 0x00DCEEA6
		private void SetCoolDownItemVisible(bool bVisible)
		{
			if (this.RefreshCooldownExternalLock)
			{
				return;
			}
			UUIItem item = base.GetItem(1);
			if (item == null)
			{
				return;
			}
			item.SetUIActive(bVisible);
		}

		// Token: 0x060316B9 RID: 202425 RVA: 0x00DD0CC4 File Offset: 0x00DCEEC4
		public void RefreshCoolDownExternal(float? remainCd = 0f, float? totalCd = 0f)
		{
			UUIItem item = base.GetItem(1);
			if (remainCd == null || totalCd == null)
			{
				if (this.RefreshCooldownExternalLock)
				{
					this.RefreshCooldownExternalLock = false;
					if (item != null)
					{
						item.SetUIActive(false);
					}
				}
				return;
			}
			this.RefreshCooldownExternalLock = true;
			if (item != null)
			{
				item.SetUIActive(true);
			}
			UUIText text = base.GetText(3);
			if (text != null)
			{
				text.SetText(remainCd.Value.ToString("F1"), true);
			}
			float? num = remainCd / totalCd;
			base.GetTexture(2).SetFillAmount(num.Value);
		}

		// Token: 0x060316BA RID: 202426 RVA: 0x00DD0D88 File Offset: 0x00DCEF88
		private void RefreshRoleHead()
		{
			BattleUiRoleData roleData = this.RoleData;
			if (((roleData != null) ? roleData.OverrideRoleHeadIcon : null) != null)
			{
				this.SetRoleHeadByPathOnly(this.RoleData.OverrideRoleHeadIcon);
				return;
			}
			if (this.RoleSkinConfig != null)
			{
				string roleHeadIconBig = this.RoleSkinConfig.Value.RoleHeadIconBig;
				if (!string.IsNullOrEmpty(roleHeadIconBig))
				{
					this.SetRoleSkinHead(roleHeadIconBig, this.RoleSkinConfig.Value.Id);
					return;
				}
			}
			if (this.RoleConfig == null)
			{
				return;
			}
			this.RefreshHeadWithConfig(this.RoleConfig.Value);
		}

		// Token: 0x060316BB RID: 202427 RVA: 0x00DD0E20 File Offset: 0x00DCF020
		private void RefreshHeadWithConfig(RoleInfo roleConfig)
		{
			string roleHeadIconBig = roleConfig.RoleHeadIconBig;
			if (string.IsNullOrEmpty(roleHeadIconBig))
			{
				return;
			}
			this.SetRoleHead(roleHeadIconBig, roleConfig.Id);
		}

		// Token: 0x060316BC RID: 202428 RVA: 0x00DD0E4C File Offset: 0x00DCF04C
		public void RefreshSelectedRole()
		{
			BattleUiRoleData roleData = this.RoleData;
			if (((roleData != null) ? roleData.AttributeComponent : null) == null)
			{
				return;
			}
			if (!this.IsMyRole)
			{
				this.SetRoleSelected(false);
				return;
			}
			this.RefreshKeyItem();
			if (this.RoleData.AttributeComponent.GetCurrentValue(EAttributeType.Life) <= 0f)
			{
				this.SetRoleSelected(false);
				return;
			}
			bool roleSelected = this.IsCurrentRole();
			this.SetRoleSelected(roleSelected);
			this.RefreshElementVisible();
		}

		// Token: 0x060316BD RID: 202429 RVA: 0x00DD0EB8 File Offset: 0x00DCF0B8
		public void ActivateConcertoChangeEffect(int elementId1, int elementId2)
		{
			base.GetText(8).SetUIActive(false);
			base.GetUiNiagara(7).ActivateSystem(true);
			UUIItem item = base.GetItem(6);
			if (!item.IsUIActiveSelf())
			{
				item.SetUIActive(true);
			}
			this.ConcertoChangeTimerId = TimerSystem.Instance.Delay(new TTimerAction(this.OnConcertoEffectEnded), (float)this.ConcertoChangeEffectDelay, null, null, true, 1f);
		}

		// Token: 0x060316BE RID: 202430 RVA: 0x00DD0F21 File Offset: 0x00DCF121
		private void OnConcertoEffectEnded(float delta)
		{
			this.DeactivateConcertoChangeEffect();
		}

		// Token: 0x060316BF RID: 202431 RVA: 0x00DD0F2C File Offset: 0x00DCF12C
		private void DeactivateConcertoChangeEffect()
		{
			UUIItem item = base.GetItem(6);
			if (item.IsUIActiveSelf())
			{
				item.SetUIActive(false);
			}
			base.GetUiNiagara(7).DeactivateSystem();
			if (this.ConcertoChangeTimerId != null && TimerSystem.Instance.Has(this.ConcertoChangeTimerId))
			{
				TimerSystem.Instance.Remove(this.ConcertoChangeTimerId);
				this.ConcertoChangeTimerId = null;
			}
		}

		// Token: 0x060316C0 RID: 202432 RVA: 0x00DD0F8E File Offset: 0x00DCF18E
		private void RefreshIsAssist()
		{
			base.GetItem(10).SetUIActive(!this.IsAssistRole);
			this.RefreshAssistCoolDown();
		}

		// Token: 0x060316C1 RID: 202433 RVA: 0x00DD0FAC File Offset: 0x00DCF1AC
		private void RefreshAssistCoolDown()
		{
			if (!this.IsAssistRole)
			{
				return;
			}
			BattleUiRoleData roleData = this.RoleData;
			if (roleData == null || !roleData.GameplayTagComponent.HasTag(GameplayTagDefine.EGameplayTagId["功能.功能制作.QTE.辅战CD"]))
			{
				this.ResetChangeCoolDown();
				return;
			}
			BattleUiRoleData roleData2 = this.RoleData;
			ActiveBuffInternal activeBuffInternal = (roleData2 != null) ? roleData2.BuffComponent.GetBuffById(900000000012L) : null;
			float num = (activeBuffInternal != null) ? activeBuffInternal.GetRemainDuration() : 0f;
			float num2 = (activeBuffInternal != null) ? activeBuffInternal.Duration : 0f;
			if (num <= 0f || num2 <= 0f)
			{
				this.ResetChangeCoolDown();
				return;
			}
			this.PlayChangeRoleCoolDown((double)((int)(num2 * (float)TimeUtil.Instance.InverseMillisecond)), (double)((int)(num * (float)TimeUtil.Instance.InverseMillisecond)));
		}

		// Token: 0x060316C2 RID: 202434 RVA: 0x00DD106F File Offset: 0x00DCF26F
		[NullableContext(1)]
		public UUIItem GetExtraContainer()
		{
			return base.GetItem(24);
		}

		// Token: 0x060316C3 RID: 202435 RVA: 0x00DD107C File Offset: 0x00DCF27C
		public void RefreshRoleHealthPercent()
		{
			UUIExtendToggle extendToggle = base.GetExtendToggle(0);
			if (extendToggle == null)
			{
				return;
			}
			BattleUiRoleData roleData = this.RoleData;
			float? num;
			if (roleData == null)
			{
				num = null;
			}
			else
			{
				BaseAttributeComponent attributeComponent = roleData.AttributeComponent;
				num = ((attributeComponent != null) ? new float?(attributeComponent.GetCurrentValue(EAttributeType.Life)) : null);
			}
			float? num2 = num;
			float valueOrDefault = num2.GetValueOrDefault(1f);
			BattleUiRoleData roleData2 = this.RoleData;
			float? num3;
			if (roleData2 == null)
			{
				num3 = null;
			}
			else
			{
				BaseAttributeComponent attributeComponent2 = roleData2.AttributeComponent;
				num3 = ((attributeComponent2 != null) ? new float?(attributeComponent2.GetCurrentValue(EAttributeType.LifeMax)) : null);
			}
			num2 = num3;
			float valueOrDefault2 = num2.GetValueOrDefault(1f);
			BattleUiRoleData roleData3 = this.RoleData;
			float num4 = (roleData3 != null) ? roleData3.ShieldComponent.ShieldTotal : 0f;
			if (valueOrDefault <= 0f || valueOrDefault2 <= 0f)
			{
				extendToggle.SetToggleState(EToggleState.ETT_UnDetermined, false, false, false);
				base.GetTexture(9).SetIsGray(true);
				UUITexture texture = base.GetTexture(2);
				if (texture != null)
				{
					texture.SetIsGray(true);
				}
				base.GetSprite(11).SetUIActive(false);
				this.SetHealthPercent(0f);
				return;
			}
			if (num4 > 0f)
			{
				UUISprite sprite = base.GetSprite(11);
				sprite.SetUIActive(true);
				sprite.SetFillAmount(num4 / valueOrDefault2);
			}
			else
			{
				base.GetSprite(11).SetUIActive(false);
			}
			extendToggle.SetToggleState(EToggleState.ETT_UnChecked, false, false, false);
			base.GetTexture(9).SetIsGray(false);
			UUITexture texture2 = base.GetTexture(2);
			if (texture2 != null)
			{
				texture2.SetIsGray(false);
			}
			this.SetHealthPercent(valueOrDefault / valueOrDefault2);
			this.RefreshSelectedRole();
		}

		// Token: 0x060316C4 RID: 202436 RVA: 0x00DD11FC File Offset: 0x00DCF3FC
		private void RefreshSuperSkillVisible()
		{
			if (Info.Instance.OperationType != global::EOperationType.Desktop)
			{
				bool uiactive = this.CanUseSuperSkill();
				base.GetSprite(17).SetUIActive(uiactive);
				return;
			}
			if (this.IsMyRole && this.IsCurrentRole())
			{
				base.GetSprite(17).SetUIActive(false);
				return;
			}
			bool uiactive2 = this.CanUseSuperSkill();
			base.GetSprite(17).SetUIActive(uiactive2);
		}

		// Token: 0x060316C5 RID: 202437 RVA: 0x00DD1260 File Offset: 0x00DCF460
		private void RefreshUltimateColor()
		{
			BattleUiRoleData roleData = this.RoleData;
			ElementInfo? elementInfo = (roleData != null) ? roleData.ElementConfig : null;
			if (elementInfo == null)
			{
				return;
			}
			if (this.CurrentSetUltimateColor != elementInfo.Value.UltimateSkillColor)
			{
				this.CurrentSetUltimateColor = elementInfo.Value.UltimateSkillColor;
				base.GetSprite(17).SetColor(this.RoleData.UltimateSkillColor.Value);
			}
		}

		// Token: 0x060316C6 RID: 202438 RVA: 0x00DD12E0 File Offset: 0x00DCF4E0
		private void RefreshKeyItem()
		{
			if (Info.Instance.OperationType == global::EOperationType.Desktop)
			{
				if (this.IsMyRole && this.IsCurrentRole())
				{
					this.KeyItem.SetActive(false);
					return;
				}
				BattleUiFormationPanelData formationPanelData = BattleUiModel.Instance.FormationPanelData;
				int num = (formationPanelData != null) ? formationPanelData.GetRolePosition(this.PlayerId, this.RoleConfigId) : 0;
				if (num <= 0)
				{
					this.KeyItem.SetActive(false);
					return;
				}
				KeyItemBase keyItem = this.KeyItem;
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(4, 1);
				defaultInterpolatedStringHandler.AppendLiteral("切换角色");
				defaultInterpolatedStringHandler.AppendFormatted<int>(num);
				keyItem.RefreshAction(defaultInterpolatedStringHandler.ToStringAndClear());
				string keyName = this.KeyItem.GetKeyName();
				if (!string.IsNullOrEmpty(keyName))
				{
					List<string> invisibleKeyList = this.InvisibleKeyList;
					if (invisibleKeyList != null && invisibleKeyList.Contains(keyName))
					{
						this.KeyItem.SetActive(false);
						return;
					}
				}
				this.KeyItem.SetActive(true);
			}
		}

		// Token: 0x060316C7 RID: 202439 RVA: 0x00DD13C0 File Offset: 0x00DCF5C0
		private void RefreshKeyItemGray()
		{
			if (this.KeyItem == null)
			{
				return;
			}
			bool gray = false;
			if (!this.IsMyRole)
			{
				gray = !this.QteNiagaraActive;
			}
			this.KeyItem.SetGray(gray);
		}

		// Token: 0x060316C8 RID: 202440 RVA: 0x00DD13F6 File Offset: 0x00DCF5F6
		private bool CanUseSuperSkill()
		{
			BattleUiRoleData roleData = this.RoleData;
			return roleData != null && roleData.CanUseUltraSkill();
		}

		// Token: 0x060316C9 RID: 202441 RVA: 0x00DD140C File Offset: 0x00DCF60C
		private void RefreshFormationConcertoItem()
		{
			if (this.RoleData == null)
			{
				base.GetItem(14).SetUIActive(false);
				return;
			}
			EElementType? currentElementType = this.CurrentElementType;
			EElementType? elementType = this.RoleData.ElementType;
			if (!(currentElementType.GetValueOrDefault() == elementType.GetValueOrDefault() & currentElementType != null == (elementType != null)))
			{
				this.CurrentElementType = this.RoleData.ElementType;
				this.CurrentElementInfo = this.RoleData.ElementConfig;
				ElementInfo value = this.CurrentElementInfo.Value;
				this.SetElementStyle(value, this.CurrentElementType.Value);
			}
			this.UpdateElementBar();
			this.RefreshElementVisible();
		}

		// Token: 0x060316CA RID: 202442 RVA: 0x00DD14B4 File Offset: 0x00DCF6B4
		private void OnElementEnergyChanged(int entityId)
		{
			int? entityId2 = this.EntityId;
			if (!(entityId == entityId2.GetValueOrDefault() & entityId2 != null))
			{
				return;
			}
			this.UpdateElementBar();
		}

		// Token: 0x060316CB RID: 202443 RVA: 0x00DD14E4 File Offset: 0x00DCF6E4
		private void OnEnergyChanged(int entityId)
		{
			int? entityId2 = this.EntityId;
			if (!(entityId == entityId2.GetValueOrDefault() & entityId2 != null))
			{
				return;
			}
			this.RefreshSuperSkillVisible();
		}

		// Token: 0x060316CC RID: 202444 RVA: 0x00DD1514 File Offset: 0x00DCF714
		private void OnRoleHeadChanged(int entityId)
		{
			int? entityId2 = this.EntityId;
			if (!(entityId == entityId2.GetValueOrDefault() & entityId2 != null))
			{
				return;
			}
			this.RefreshRoleHead();
		}

		// Token: 0x060316CD RID: 202445 RVA: 0x00DD1544 File Offset: 0x00DCF744
		private void OnElementHideTagChanged(int entityId, int tagId, bool tagExist)
		{
			int? entityId2 = this.EntityId;
			if (!(entityId == entityId2.GetValueOrDefault() & entityId2 != null))
			{
				return;
			}
			this.RefreshElementVisible();
		}

		// Token: 0x060316CE RID: 202446 RVA: 0x00DD1574 File Offset: 0x00DCF774
		public void RefreshElementVisible()
		{
			if (this.RoleData == null)
			{
				return;
			}
			UUIItem item = base.GetItem(14);
			if (!this.IsConcertoResponseOpen)
			{
				item.SetUIActive(false);
				return;
			}
			if (this.RoleConfig != null && this.RoleConfig.GetValueOrDefault().RoleType == 2)
			{
				item.SetUIActive(false);
				this.ResetAllConcertoNiagara();
				return;
			}
			if (Info.Instance.OperationType == global::EOperationType.Desktop && this.IsMyRole && this.IsCurrentRole())
			{
				item.SetUIActive(false);
				return;
			}
			foreach (int tagId in BattleUiRoleData.HideElementTagList)
			{
				BaseTagComponent gameplayTagComponent = this.RoleData.GameplayTagComponent;
				if (gameplayTagComponent != null && gameplayTagComponent.HasTag(tagId))
				{
					item.SetUIActive(false);
					return;
				}
			}
			item.SetUIActive(true);
		}

		// Token: 0x060316CF RID: 202447 RVA: 0x00DD1640 File Offset: 0x00DCF840
		private void SetElementStyle(in ElementInfo elementConfig, EElementType elementType)
		{
			ElementInfo elementInfo = elementConfig;
			string icon = elementInfo.Icon5;
			UUIItem sprite = base.GetSprite(16);
			UUITexture texture = base.GetTexture(15);
			base.SetElementIcon(icon, texture, (int)elementType, null);
			texture.SetColor(this.RoleData.ElementColor.Value);
			sprite.SetColor(this.RoleData.ElementColor.Value);
		}

		// Token: 0x060316D0 RID: 202448 RVA: 0x00DD16AC File Offset: 0x00DCF8AC
		private void UpdateElementBar()
		{
			UUISprite sprite = base.GetSprite(16);
			BattleUiRoleData roleData = this.RoleData;
			float fillAmount = (roleData != null) ? roleData.GetElementAttributePercent() : 0f;
			sprite.SetFillAmount(fillAmount);
		}

		// Token: 0x060316D1 RID: 202449 RVA: 0x00DD16E0 File Offset: 0x00DCF8E0
		public void RefreshOnlineItem()
		{
			if (!GameModeModel.Instance.IsMulti)
			{
				FormationOnlineItem roleHeadOnlineComponent = this.RoleHeadOnlineComponent;
				if (roleHeadOnlineComponent != null)
				{
					roleHeadOnlineComponent.Destroy(null);
				}
				this.RoleHeadOnlineComponent = null;
				return;
			}
			if (this.RoleHeadOnlineComponent == null)
			{
				this.RoleHeadOnlineComponent = new FormationOnlineItem(this.RootItem);
			}
			OnlineTeamData currentTeamListById = OnlineModel.Instance.GetCurrentTeamListById(this.PlayerId);
			if (currentTeamListById != null)
			{
				this.RefreshPlayerPingState(currentTeamListById.PingState);
			}
			if (this.IsMyRole)
			{
				this.RoleHeadOnlineComponent.SetOnlineNumber(-1);
				this.RoleHeadOnlineComponent.SetNameText(string.Empty);
				this.RoleHeadOnlineComponent.RefreshThirdPartyItem(PlayerInfoModel.Instance.GetThirdPartyUserId() ?? string.Empty);
				return;
			}
			this.RoleHeadOnlineComponent.SetOnlineNumber((currentTeamListById != null) ? currentTeamListById.PlayerNumber : -1);
			this.RoleHeadOnlineComponent.SetNameText(((currentTeamListById != null) ? currentTeamListById.GetFormationName() : null) ?? string.Empty);
			string thirdPartyAccountId = Info.Instance.IsPs5Platform() ? (((currentTeamListById != null) ? currentTeamListById.PlayerDetails.PsnAccountId : null) ?? string.Empty) : (((currentTeamListById != null) ? currentTeamListById.PlayerDetails.XboxAccountId : null) ?? string.Empty);
			this.RoleHeadOnlineComponent.RefreshThirdPartyItem(thirdPartyAccountId);
			this.RoleHeadOnlineComponent.SetIsGrayByOtherControl(!this.IsCurrentRole());
		}

		// Token: 0x060316D2 RID: 202450 RVA: 0x00DD182C File Offset: 0x00DCFA2C
		public void RefreshPlayerPingState(ENetPingState pingState)
		{
			if (this.RoleHeadOnlineComponent == null)
			{
				return;
			}
			if (pingState == ENetPingState.Poor)
			{
				this.RoleHeadOnlineComponent.SetNetWeak(true);
				this.RoleHeadOnlineComponent.SetNetDisconnect(false);
				return;
			}
			if (pingState == ENetPingState.Unknown)
			{
				this.RoleHeadOnlineComponent.SetNetDisconnect(true);
				this.RoleHeadOnlineComponent.SetNetWeak(false);
				return;
			}
			this.RoleHeadOnlineComponent.SetNetWeak(false);
			this.RoleHeadOnlineComponent.SetNetDisconnect(false);
		}

		// Token: 0x060316D3 RID: 202451 RVA: 0x00DD1894 File Offset: 0x00DCFA94
		private void InitTweenAnim(int componentType)
		{
			List<ULGUIPlayTweenComponent> list = new List<ULGUIPlayTweenComponent>();
			TArray<UActorComponent> tarray = base.GetItem(componentType).GetOwner().K2_GetComponentsByClass(ULGUIPlayTweenComponent.StaticClass());
			int num = tarray.Num();
			for (int i = 0; i < num; i++)
			{
				list.Add((ULGUIPlayTweenComponent)tarray.Get(i));
			}
			if (this.TweenAnimMap == null)
			{
				this.TweenAnimMap = new Dictionary<int, List<ULGUIPlayTweenComponent>>();
			}
			this.TweenAnimMap[componentType] = list;
		}

		// Token: 0x060316D4 RID: 202452 RVA: 0x00DD1908 File Offset: 0x00DCFB08
		private void PlayTweenAnim(int componentType)
		{
			if (this.TweenAnimMap == null)
			{
				return;
			}
			List<ULGUIPlayTweenComponent> list;
			if (!this.TweenAnimMap.TryGetValue(componentType, out list))
			{
				return;
			}
			foreach (ULGUIPlayTweenComponent ulguiplayTweenComponent in list)
			{
				ulguiplayTweenComponent.Play();
			}
		}

		// Token: 0x060316D5 RID: 202453 RVA: 0x00DD1970 File Offset: 0x00DCFB70
		private void StopTweenAnim(int componentType)
		{
			if (this.TweenAnimMap == null)
			{
				return;
			}
			List<ULGUIPlayTweenComponent> list;
			if (!this.TweenAnimMap.TryGetValue(componentType, out list))
			{
				return;
			}
			foreach (ULGUIPlayTweenComponent ulguiplayTweenComponent in list)
			{
				ulguiplayTweenComponent.Stop();
			}
		}

		// Token: 0x060316D6 RID: 202454 RVA: 0x00DD19D8 File Offset: 0x00DCFBD8
		public void RefreshLinkEffect()
		{
			if (BattleLinkModel.Instance.CheckInDreamLink())
			{
				ELinkStatus linkStatus = BattleLinkModel.Instance.GetLinkStatus();
				this.OnBattleLinkStatusChanged(linkStatus);
				return;
			}
			this.OnBattleLinkStatusChanged(ELinkStatus.None);
		}

		// Token: 0x060316D7 RID: 202455 RVA: 0x00DD1A0C File Offset: 0x00DCFC0C
		public void RefreshLinkActive(bool isActive, bool isExplosion = false)
		{
			if (this.LinkActive == isActive && this.IsInitLinkEffect)
			{
				return;
			}
			this.LinkActive = isActive;
			this.IsInitLinkEffect = true;
			UUIItem item = base.GetItem(20);
			if (item != null)
			{
				item.SetUIActive(isActive);
			}
			UUINiagara uiNiagara = base.GetUiNiagara(21);
			UUINiagara uiNiagara2 = base.GetUiNiagara(22);
			bool flag = isExplosion && isActive;
			bool flag2 = isActive && !flag;
			if (uiNiagara != null)
			{
				if (flag2)
				{
					uiNiagara.ActivateSystem(true);
				}
				else
				{
					uiNiagara.Deactivate();
				}
				uiNiagara.SetUIActive(flag2);
			}
			if (uiNiagara2 != null)
			{
				if (flag)
				{
					uiNiagara2.ActivateSystem(true);
				}
				else
				{
					uiNiagara2.Deactivate();
				}
				uiNiagara2.SetUIActive(flag);
			}
		}

		// Token: 0x060316D8 RID: 202456 RVA: 0x00DD1AA8 File Offset: 0x00DCFCA8
		private void OnBattleLinkStatusChanged(ELinkStatus state)
		{
			if (WeeklyRogueModel.Instance.CheckIsInWeeklyRogue())
			{
				this.RefreshLinkActive(false, false);
				return;
			}
			EntityHandle getCurrentEntity = SceneTeamModel.Instance.GetCurrentEntity;
			WorldEntity worldEntity = (getCurrentEntity != null) ? getCurrentEntity.Entity : null;
			if (worldEntity != null)
			{
				int id = worldEntity.Id;
				int? entityId = this.EntityId;
				if ((id == entityId.GetValueOrDefault() & entityId != null) && state != ELinkStatus.Explosion)
				{
					this.RefreshLinkActive(false, false);
					return;
				}
			}
			if (state == ELinkStatus.Ready)
			{
				this.RefreshLinkActive(true, false);
				return;
			}
			if (state == ELinkStatus.Link)
			{
				if (this.EntityId != null)
				{
					bool isActive = !BattleLinkModel.Instance.HasLinkEntityId(this.EntityId.Value);
					this.RefreshLinkActive(isActive, false);
					return;
				}
				this.RefreshLinkActive(false, false);
				return;
			}
			else
			{
				if (state == ELinkStatus.Explosion)
				{
					this.RefreshLinkActive(true, true);
					return;
				}
				if (state == ELinkStatus.None)
				{
					this.RefreshLinkActive(false, false);
					return;
				}
				this.RefreshLinkActive(false, false);
				return;
			}
		}

		// Token: 0x060316D9 RID: 202457 RVA: 0x00DD1B7B File Offset: 0x00DCFD7B
		public void SetInvisibleByKeyList([Nullable(new byte[]
		{
			2,
			1
		})] List<string> keyList)
		{
			this.InvisibleKeyList = keyList;
			this.RefreshKeyItemNextTick();
		}

		// Token: 0x060316DA RID: 202458 RVA: 0x00DD1B8A File Offset: 0x00DCFD8A
		private void RefreshKeyItemNextTick()
		{
			if (this.RefreshKeyItemTimer != null)
			{
				return;
			}
			this.RefreshKeyItemTimer = TimerSystem.Instance.Next(delegate(float _)
			{
				this.RefreshKeyItem();
				this.RefreshKeyItemTimer = null;
			}, null, null);
		}

		// Token: 0x060316DB RID: 202459 RVA: 0x00DD1BB3 File Offset: 0x00DCFDB3
		public FormationItem()
		{
			Dictionary<ERoleQteType, FormationItem.EChildType> dictionary = new Dictionary<ERoleQteType, FormationItem.EChildType>();
			dictionary[ERoleQteType.Normal] = FormationItem.EChildType.QTENiagara;
			dictionary[ERoleQteType.TongZou] = FormationItem.EChildType.QTETongZouNiagara;
			this.QteTypeNiagaraMap = dictionary;
			this.TagSignificantChangedTaskList = new List<ITagTask>();
			this.CurrentSetUltimateColor = string.Empty;
			base..ctor();
		}

		// Token: 0x0401A2B5 RID: 107189
		private const int REFRESH_COOLDOWN_INTERVAL = 100;

		// Token: 0x0401A2B6 RID: 107190
		private const int CURE_DELAY = 1000;

		// Token: 0x0401A2B7 RID: 107191
		private const float LOW_HP_PERCENT = 0.2f;

		// Token: 0x0401A2B8 RID: 107192
		private const int LEVE_UP_TIME = 5000;

		// Token: 0x0401A2B9 RID: 107193
		[Nullable(1)]
		private readonly Dictionary<ERoleQteType, FormationItem.EChildType> QteTypeNiagaraMap;

		// Token: 0x0401A2BA RID: 107194
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private Dictionary<int, List<ULGUIPlayTweenComponent>> TweenAnimMap;

		// Token: 0x0401A2BB RID: 107195
		public int PrefabIndex;

		// Token: 0x0401A2BC RID: 107196
		public int PlayerId;

		// Token: 0x0401A2BD RID: 107197
		public bool IsMyRole;

		// Token: 0x0401A2BE RID: 107198
		public int RoleConfigId;

		// Token: 0x0401A2BF RID: 107199
		public int RoleSkinId;

		// Token: 0x0401A2C0 RID: 107200
		public BattleUiRoleData RoleData;

		// Token: 0x0401A2C1 RID: 107201
		public int? EntityId;

		// Token: 0x0401A2C2 RID: 107202
		public RoleInfo? RoleConfig;

		// Token: 0x0401A2C3 RID: 107203
		public RoleSkin? RoleSkinConfig;

		// Token: 0x0401A2C4 RID: 107204
		[Nullable(1)]
		private readonly List<ITagTask> TagSignificantChangedTaskList;

		// Token: 0x0401A2C5 RID: 107205
		private double CoolDownEndTime;

		// Token: 0x0401A2C6 RID: 107206
		private double CoolDownTime;

		// Token: 0x0401A2C7 RID: 107207
		private double LastRefreshTextCoolDownTime;

		// Token: 0x0401A2C8 RID: 107208
		private TimerHandle CureDelayTimerId;

		// Token: 0x0401A2C9 RID: 107209
		private EElementType? CurrentElementType;

		// Token: 0x0401A2CA RID: 107210
		private ElementInfo? CurrentElementInfo;

		// Token: 0x0401A2CB RID: 107211
		[Nullable(1)]
		private string CurrentSetUltimateColor;

		// Token: 0x0401A2CC RID: 107212
		private bool IsConcertoResponseOpen;

		// Token: 0x0401A2CD RID: 107213
		private TimerHandle ConcertoChangeTimerId;

		// Token: 0x0401A2CE RID: 107214
		private int ConcertoChangeEffectDelay;

		// Token: 0x0401A2CF RID: 107215
		private CombineKeyItem KeyItem;

		// Token: 0x0401A2D0 RID: 107216
		private FormationLevelUpItem LevelUpComponent;

		// Token: 0x0401A2D1 RID: 107217
		private FormationTrialItem TrialComponent;

		// Token: 0x0401A2D2 RID: 107218
		private FormationOnlineItem RoleHeadOnlineComponent;

		// Token: 0x0401A2D3 RID: 107219
		private bool IsAssistRole;

		// Token: 0x0401A2D4 RID: 107220
		private bool QteNiagaraActive;

		// Token: 0x0401A2D5 RID: 107221
		private ERoleQteType CurrentQteNiagaraType;

		// Token: 0x0401A2D6 RID: 107222
		private bool SelectedNiagaraActive;

		// Token: 0x0401A2D7 RID: 107223
		private bool LinkActive;

		// Token: 0x0401A2D8 RID: 107224
		private bool IsInitLinkEffect;

		// Token: 0x0401A2D9 RID: 107225
		private bool RefreshCooldownExternalLock;

		// Token: 0x0401A2DA RID: 107226
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<string> InvisibleKeyList;

		// Token: 0x0401A2DB RID: 107227
		private TimerHandle RefreshKeyItemTimer;

		// Token: 0x0200A9B2 RID: 43442
		[NullableContext(0)]
		private enum EChildType
		{
			// Token: 0x040346F1 RID: 214769
			FormationToggle,
			// Token: 0x040346F2 RID: 214770
			ChangeRoleCoolDownItem,
			// Token: 0x040346F3 RID: 214771
			ChangeRoleCoolDownBarTexture,
			// Token: 0x040346F4 RID: 214772
			ChangeRoleCoolDownText,
			// Token: 0x040346F5 RID: 214773
			CureItem,
			// Token: 0x040346F6 RID: 214774
			QTENiagara,
			// Token: 0x040346F7 RID: 214775
			ConcertoChangeItem,
			// Token: 0x040346F8 RID: 214776
			ConcertoChangeNiagara,
			// Token: 0x040346F9 RID: 214777
			ConcertoChangeText,
			// Token: 0x040346FA RID: 214778
			RoleHeadTexture,
			// Token: 0x040346FB RID: 214779
			HpItem,
			// Token: 0x040346FC RID: 214780
			ShieldSprite,
			// Token: 0x040346FD RID: 214781
			HpBarSprite,
			// Token: 0x040346FE RID: 214782
			LowHpBarSprite,
			// Token: 0x040346FF RID: 214783
			ConcertoItem,
			// Token: 0x04034700 RID: 214784
			ElementTexture,
			// Token: 0x04034701 RID: 214785
			ElementBarSprite,
			// Token: 0x04034702 RID: 214786
			UltimateTag,
			// Token: 0x04034703 RID: 214787
			AnimSelect,
			// Token: 0x04034704 RID: 214788
			AnimSwitch,
			// Token: 0x04034705 RID: 214789
			LinkItem,
			// Token: 0x04034706 RID: 214790
			LinkNiagara,
			// Token: 0x04034707 RID: 214791
			LinkExplosionNiagara,
			// Token: 0x04034708 RID: 214792
			QTETongZouNiagara,
			// Token: 0x04034709 RID: 214793
			ExtraContainer,
			// Token: 0x0403470A RID: 214794
			KeyItem
		}
	}
}
