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
	// Token: 0x02005D26 RID: 23846
	[NullableContext(2)]
	[Nullable(0)]
	public class FormationItem : BattleChildView
	{
		// Token: 0x0603C72E RID: 247598 RVA: 0x00E7EE14 File Offset: 0x00E7D014
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

		// Token: 0x0603C72F RID: 247599 RVA: 0x00E7F1AD File Offset: 0x00E7D3AD
		public override void Initialize(object param = null)
		{
			base.Initialize(param);
			this.PrefabIndex = (int)param;
			this.ConcertoChangeEffectDelay = BattleUiModel.Instance.ConcertoChangeEffectDelay;
			base.GetTexture(9).SetUIActive(false);
			this.AddEvents();
		}

		// Token: 0x0603C730 RID: 247600 RVA: 0x00E7F1E8 File Offset: 0x00E7D3E8
		protected override UniTask InitializeAsync(object param = null)
		{
			FormationItem.<InitializeAsync>d__41 <InitializeAsync>d__;
			<InitializeAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitializeAsync>d__.<>4__this = this;
			<InitializeAsync>d__.<>1__state = -1;
			<InitializeAsync>d__.<>t__builder.Start<FormationItem.<InitializeAsync>d__41>(ref <InitializeAsync>d__);
			return <InitializeAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603C731 RID: 247601 RVA: 0x00E7F22C File Offset: 0x00E7D42C
		private UniTask InitTrialComponent()
		{
			FormationItem.<InitTrialComponent>d__42 <InitTrialComponent>d__;
			<InitTrialComponent>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitTrialComponent>d__.<>4__this = this;
			<InitTrialComponent>d__.<>1__state = -1;
			<InitTrialComponent>d__.<>t__builder.Start<FormationItem.<InitTrialComponent>d__42>(ref <InitTrialComponent>d__);
			return <InitTrialComponent>d__.<>t__builder.Task;
		}

		// Token: 0x0603C732 RID: 247602 RVA: 0x00E7F26F File Offset: 0x00E7D46F
		public void ResetItem()
		{
			this.ClearData();
			this.SetActive(false);
		}

		// Token: 0x0603C733 RID: 247603 RVA: 0x00E7F280 File Offset: 0x00E7D480
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

		// Token: 0x0603C734 RID: 247604 RVA: 0x00E7F420 File Offset: 0x00E7D620
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

		// Token: 0x0603C735 RID: 247605 RVA: 0x00E7F4BC File Offset: 0x00E7D6BC
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

		// Token: 0x0603C736 RID: 247606 RVA: 0x00E7F634 File Offset: 0x00E7D834
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

		// Token: 0x0603C737 RID: 247607 RVA: 0x00E7F7A0 File Offset: 0x00E7D9A0
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

		// Token: 0x0603C738 RID: 247608 RVA: 0x00E7F848 File Offset: 0x00E7DA48
		[NullableContext(1)]
		private void ListenForTagSignificantChanged(BaseTagComponent gameplayTagComponent, int tagId, BaseTagComponent.TTagSwitchedCallback callback)
		{
			ITagTask tagTask = gameplayTagComponent.ListenForTagAddOrRemove(new int?(tagId), callback, null);
			if (tagTask != null)
			{
				this.TagSignificantChangedTaskList.Add(tagTask);
			}
		}

		// Token: 0x0603C739 RID: 247609 RVA: 0x00E7F874 File Offset: 0x00E7DA74
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

		// Token: 0x0603C73A RID: 247610 RVA: 0x00E7F8F0 File Offset: 0x00E7DAF0
		protected override void OnShowBattleChildView()
		{
			this.SetCoolDownItemVisible(false);
		}

		// Token: 0x0603C73B RID: 247611 RVA: 0x00E7F8FC File Offset: 0x00E7DAFC
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

		// Token: 0x0603C73C RID: 247612 RVA: 0x00E7F9D8 File Offset: 0x00E7DBD8
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

		// Token: 0x0603C73D RID: 247613 RVA: 0x00E7FA68 File Offset: 0x00E7DC68
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

		// Token: 0x0603C73E RID: 247614 RVA: 0x00E7FB20 File Offset: 0x00E7DD20
		private void OnEnterChangeCoolDownCallback(double coolDownTime)
		{
			if (Info.Instance.OperationType == global::EOperationType.Desktop)
			{
				double num = coolDownTime * (double)TimeUtil.Instance.InverseMillisecond;
				this.PlayChangeRoleCoolDown(num, num);
			}
		}

		// Token: 0x0603C73F RID: 247615 RVA: 0x00E7FB50 File Offset: 0x00E7DD50
		private void OnShieldChanged(int entityId)
		{
			if (this.RoleData == null)
			{
				return;
			}
			this.RefreshRoleHealthPercent();
		}

		// Token: 0x0603C740 RID: 247616 RVA: 0x00E7FB64 File Offset: 0x00E7DD64
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

		// Token: 0x0603C741 RID: 247617 RVA: 0x00E7FB9E File Offset: 0x00E7DD9E
		private void ResetAllConcertoNiagara()
		{
			this.SetCanUseQte(false, true, ERoleQteType.Normal);
		}

		// Token: 0x0603C742 RID: 247618 RVA: 0x00E7FBA9 File Offset: 0x00E7DDA9
		private void OnQteEnableTagChanged(int entityId, int tagId, bool bTagExists)
		{
			if (FormationDataController.Instance.IsBattleMulti())
			{
				return;
			}
			this.RefreshSingleModeQteEnable();
		}

		// Token: 0x0603C743 RID: 247619 RVA: 0x00E7FBBE File Offset: 0x00E7DDBE
		private void OnTeammateQteEnableTagChanged(int tagId, bool tagExist)
		{
			this.RefreshMultiModeQteEnable();
		}

		// Token: 0x0603C744 RID: 247620 RVA: 0x00E7FBC6 File Offset: 0x00E7DDC6
		private void OnAssistQteCdTagChanged(int tagId, bool tagExist)
		{
			this.RefreshAssistCoolDown();
		}

		// Token: 0x0603C745 RID: 247621 RVA: 0x00E7FBCE File Offset: 0x00E7DDCE
		private void OnAssistRoleTagChanged(int tagId, bool tagExist)
		{
			if (this.IsAssistRole == tagExist)
			{
				return;
			}
			this.IsAssistRole = tagExist;
			this.RefreshIsAssist();
		}

		// Token: 0x0603C746 RID: 247622 RVA: 0x00E7FBE7 File Offset: 0x00E7DDE7
		private void OnBattleUiDeadTagChanged(int entityId, int tagId, bool tagExist)
		{
			this.RefreshQteActive();
		}

		// Token: 0x0603C747 RID: 247623 RVA: 0x00E7FBEF File Offset: 0x00E7DDEF
		private void OnBattleUiQteCdTagChanged(int entityId, int tagId, bool tagExist)
		{
			this.RefreshQteActive();
		}

		// Token: 0x0603C748 RID: 247624 RVA: 0x00E7FBF7 File Offset: 0x00E7DDF7
		private void OnCharInQteChanged(int entityId, bool tagExist)
		{
			this.RefreshQteActive();
		}

		// Token: 0x0603C749 RID: 247625 RVA: 0x00E7FBFF File Offset: 0x00E7DDFF
		private void OnBattleStateChanged(bool isFight)
		{
			this.RefreshQteActive();
		}

		// Token: 0x0603C74A RID: 247626 RVA: 0x00E7FC07 File Offset: 0x00E7DE07
		public void RefreshQteActive()
		{
			if (FormationDataController.Instance.IsBattleMulti())
			{
				this.RefreshMultiModeQteEnable();
				return;
			}
			this.RefreshSingleModeQteEnable();
		}

		// Token: 0x0603C74B RID: 247627 RVA: 0x00E7FC24 File Offset: 0x00E7DE24
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

		// Token: 0x0603C74C RID: 247628 RVA: 0x00E7FCA4 File Offset: 0x00E7DEA4
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

		// Token: 0x0603C74D RID: 247629 RVA: 0x00E7FD28 File Offset: 0x00E7DF28
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

		// Token: 0x0603C74E RID: 247630 RVA: 0x00E7FE28 File Offset: 0x00E7E028
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

		// Token: 0x0603C74F RID: 247631 RVA: 0x00E7FE80 File Offset: 0x00E7E080
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

		// Token: 0x0603C750 RID: 247632 RVA: 0x00E7FEB8 File Offset: 0x00E7E0B8
		private void ResetChangeCoolDown()
		{
			Log.Instance.Info(ELogModule.Battle, ELogAuthor.CFT, "重置换人冷却表现", default(ReadOnlySpan<ValueTuple<string, object>>));
			this.SetCoolDownItemVisible(false);
		}

		// Token: 0x0603C751 RID: 247633 RVA: 0x00E7FEE8 File Offset: 0x00E7E0E8
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

		// Token: 0x0603C752 RID: 247634 RVA: 0x00E7FF64 File Offset: 0x00E7E164
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

		// Token: 0x0603C753 RID: 247635 RVA: 0x00E7FFD0 File Offset: 0x00E7E1D0
		public void RefreshConcertoResponseModule(bool isOpen)
		{
			this.IsConcertoResponseOpen = isOpen;
			this.RefreshElementVisible();
		}

		// Token: 0x0603C754 RID: 247636 RVA: 0x00E7FFE0 File Offset: 0x00E7E1E0
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

		// Token: 0x0603C755 RID: 247637 RVA: 0x00E8006C File Offset: 0x00E7E26C
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

		// Token: 0x0603C756 RID: 247638 RVA: 0x00E80100 File Offset: 0x00E7E300
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

		// Token: 0x0603C757 RID: 247639 RVA: 0x00E80190 File Offset: 0x00E7E390
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

		// Token: 0x0603C758 RID: 247640 RVA: 0x00E80224 File Offset: 0x00E7E424
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

		// Token: 0x0603C759 RID: 247641 RVA: 0x00E80290 File Offset: 0x00E7E490
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

		// Token: 0x0603C75A RID: 247642 RVA: 0x00E803AC File Offset: 0x00E7E5AC
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

		// Token: 0x0603C75B RID: 247643 RVA: 0x00E803ED File Offset: 0x00E7E5ED
		public void RefreshCoolDownOnShow()
		{
			if (this.RoleData == null)
			{
				return;
			}
			this.RefreshChangeCoolDown();
			this.RefreshAssistCoolDown();
		}

		// Token: 0x0603C75C RID: 247644 RVA: 0x00E80404 File Offset: 0x00E7E604
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

		// Token: 0x0603C75D RID: 247645 RVA: 0x00E80484 File Offset: 0x00E7E684
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

		// Token: 0x0603C75E RID: 247646 RVA: 0x00E804C0 File Offset: 0x00E7E6C0
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

		// Token: 0x0603C75F RID: 247647 RVA: 0x00E80506 File Offset: 0x00E7E706
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

		// Token: 0x0603C760 RID: 247648 RVA: 0x00E80524 File Offset: 0x00E7E724
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

		// Token: 0x0603C761 RID: 247649 RVA: 0x00E805E8 File Offset: 0x00E7E7E8
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

		// Token: 0x0603C762 RID: 247650 RVA: 0x00E80680 File Offset: 0x00E7E880
		private void RefreshHeadWithConfig(RoleInfo roleConfig)
		{
			string roleHeadIconBig = roleConfig.RoleHeadIconBig;
			if (string.IsNullOrEmpty(roleHeadIconBig))
			{
				return;
			}
			this.SetRoleHead(roleHeadIconBig, roleConfig.Id);
		}

		// Token: 0x0603C763 RID: 247651 RVA: 0x00E806AC File Offset: 0x00E7E8AC
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

		// Token: 0x0603C764 RID: 247652 RVA: 0x00E80718 File Offset: 0x00E7E918
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

		// Token: 0x0603C765 RID: 247653 RVA: 0x00E80781 File Offset: 0x00E7E981
		private void OnConcertoEffectEnded(float delta)
		{
			this.DeactivateConcertoChangeEffect();
		}

		// Token: 0x0603C766 RID: 247654 RVA: 0x00E8078C File Offset: 0x00E7E98C
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

		// Token: 0x0603C767 RID: 247655 RVA: 0x00E807EE File Offset: 0x00E7E9EE
		private void RefreshIsAssist()
		{
			base.GetItem(10).SetUIActive(!this.IsAssistRole);
			this.RefreshAssistCoolDown();
		}

		// Token: 0x0603C768 RID: 247656 RVA: 0x00E8080C File Offset: 0x00E7EA0C
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

		// Token: 0x0603C769 RID: 247657 RVA: 0x00E808CF File Offset: 0x00E7EACF
		[NullableContext(1)]
		public UUIItem GetExtraContainer()
		{
			return base.GetItem(24);
		}

		// Token: 0x0603C76A RID: 247658 RVA: 0x00E808DC File Offset: 0x00E7EADC
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

		// Token: 0x0603C76B RID: 247659 RVA: 0x00E80A5C File Offset: 0x00E7EC5C
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

		// Token: 0x0603C76C RID: 247660 RVA: 0x00E80AC0 File Offset: 0x00E7ECC0
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

		// Token: 0x0603C76D RID: 247661 RVA: 0x00E80B40 File Offset: 0x00E7ED40
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

		// Token: 0x0603C76E RID: 247662 RVA: 0x00E80C20 File Offset: 0x00E7EE20
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

		// Token: 0x0603C76F RID: 247663 RVA: 0x00E80C56 File Offset: 0x00E7EE56
		private bool CanUseSuperSkill()
		{
			BattleUiRoleData roleData = this.RoleData;
			return roleData != null && roleData.CanUseUltraSkill();
		}

		// Token: 0x0603C770 RID: 247664 RVA: 0x00E80C6C File Offset: 0x00E7EE6C
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

		// Token: 0x0603C771 RID: 247665 RVA: 0x00E80D14 File Offset: 0x00E7EF14
		private void OnElementEnergyChanged(int entityId)
		{
			int? entityId2 = this.EntityId;
			if (!(entityId == entityId2.GetValueOrDefault() & entityId2 != null))
			{
				return;
			}
			this.UpdateElementBar();
		}

		// Token: 0x0603C772 RID: 247666 RVA: 0x00E80D44 File Offset: 0x00E7EF44
		private void OnEnergyChanged(int entityId)
		{
			int? entityId2 = this.EntityId;
			if (!(entityId == entityId2.GetValueOrDefault() & entityId2 != null))
			{
				return;
			}
			this.RefreshSuperSkillVisible();
		}

		// Token: 0x0603C773 RID: 247667 RVA: 0x00E80D74 File Offset: 0x00E7EF74
		private void OnRoleHeadChanged(int entityId)
		{
			int? entityId2 = this.EntityId;
			if (!(entityId == entityId2.GetValueOrDefault() & entityId2 != null))
			{
				return;
			}
			this.RefreshRoleHead();
		}

		// Token: 0x0603C774 RID: 247668 RVA: 0x00E80DA4 File Offset: 0x00E7EFA4
		private void OnElementHideTagChanged(int entityId, int tagId, bool tagExist)
		{
			int? entityId2 = this.EntityId;
			if (!(entityId == entityId2.GetValueOrDefault() & entityId2 != null))
			{
				return;
			}
			this.RefreshElementVisible();
		}

		// Token: 0x0603C775 RID: 247669 RVA: 0x00E80DD4 File Offset: 0x00E7EFD4
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

		// Token: 0x0603C776 RID: 247670 RVA: 0x00E80EA0 File Offset: 0x00E7F0A0
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

		// Token: 0x0603C777 RID: 247671 RVA: 0x00E80F0C File Offset: 0x00E7F10C
		private void UpdateElementBar()
		{
			UUISprite sprite = base.GetSprite(16);
			BattleUiRoleData roleData = this.RoleData;
			float fillAmount = (roleData != null) ? roleData.GetElementAttributePercent() : 0f;
			sprite.SetFillAmount(fillAmount);
		}

		// Token: 0x0603C778 RID: 247672 RVA: 0x00E80F40 File Offset: 0x00E7F140
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

		// Token: 0x0603C779 RID: 247673 RVA: 0x00E8108C File Offset: 0x00E7F28C
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

		// Token: 0x0603C77A RID: 247674 RVA: 0x00E810F4 File Offset: 0x00E7F2F4
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

		// Token: 0x0603C77B RID: 247675 RVA: 0x00E81168 File Offset: 0x00E7F368
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

		// Token: 0x0603C77C RID: 247676 RVA: 0x00E811D0 File Offset: 0x00E7F3D0
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

		// Token: 0x0603C77D RID: 247677 RVA: 0x00E81238 File Offset: 0x00E7F438
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

		// Token: 0x0603C77E RID: 247678 RVA: 0x00E8126C File Offset: 0x00E7F46C
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

		// Token: 0x0603C77F RID: 247679 RVA: 0x00E81308 File Offset: 0x00E7F508
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

		// Token: 0x0603C780 RID: 247680 RVA: 0x00E813DB File Offset: 0x00E7F5DB
		public void SetInvisibleByKeyList([Nullable(new byte[]
		{
			2,
			1
		})] List<string> keyList)
		{
			this.InvisibleKeyList = keyList;
			this.RefreshKeyItemNextTick();
		}

		// Token: 0x0603C781 RID: 247681 RVA: 0x00E813EA File Offset: 0x00E7F5EA
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

		// Token: 0x0603C782 RID: 247682 RVA: 0x00E81413 File Offset: 0x00E7F613
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

		// Token: 0x0401F7FC RID: 129020
		private const int REFRESH_COOLDOWN_INTERVAL = 100;

		// Token: 0x0401F7FD RID: 129021
		private const int CURE_DELAY = 1000;

		// Token: 0x0401F7FE RID: 129022
		private const float LOW_HP_PERCENT = 0.2f;

		// Token: 0x0401F7FF RID: 129023
		private const int LEVE_UP_TIME = 5000;

		// Token: 0x0401F800 RID: 129024
		[Nullable(1)]
		private readonly Dictionary<ERoleQteType, FormationItem.EChildType> QteTypeNiagaraMap;

		// Token: 0x0401F801 RID: 129025
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private Dictionary<int, List<ULGUIPlayTweenComponent>> TweenAnimMap;

		// Token: 0x0401F802 RID: 129026
		public int PrefabIndex;

		// Token: 0x0401F803 RID: 129027
		public int PlayerId;

		// Token: 0x0401F804 RID: 129028
		public bool IsMyRole;

		// Token: 0x0401F805 RID: 129029
		public int RoleConfigId;

		// Token: 0x0401F806 RID: 129030
		public int RoleSkinId;

		// Token: 0x0401F807 RID: 129031
		public BattleUiRoleData RoleData;

		// Token: 0x0401F808 RID: 129032
		public int? EntityId;

		// Token: 0x0401F809 RID: 129033
		public RoleInfo? RoleConfig;

		// Token: 0x0401F80A RID: 129034
		public RoleSkin? RoleSkinConfig;

		// Token: 0x0401F80B RID: 129035
		[Nullable(1)]
		private readonly List<ITagTask> TagSignificantChangedTaskList;

		// Token: 0x0401F80C RID: 129036
		private double CoolDownEndTime;

		// Token: 0x0401F80D RID: 129037
		private double CoolDownTime;

		// Token: 0x0401F80E RID: 129038
		private double LastRefreshTextCoolDownTime;

		// Token: 0x0401F80F RID: 129039
		private TimerHandle CureDelayTimerId;

		// Token: 0x0401F810 RID: 129040
		private EElementType? CurrentElementType;

		// Token: 0x0401F811 RID: 129041
		private ElementInfo? CurrentElementInfo;

		// Token: 0x0401F812 RID: 129042
		[Nullable(1)]
		private string CurrentSetUltimateColor;

		// Token: 0x0401F813 RID: 129043
		private bool IsConcertoResponseOpen;

		// Token: 0x0401F814 RID: 129044
		private TimerHandle ConcertoChangeTimerId;

		// Token: 0x0401F815 RID: 129045
		private int ConcertoChangeEffectDelay;

		// Token: 0x0401F816 RID: 129046
		private CombineKeyItem KeyItem;

		// Token: 0x0401F817 RID: 129047
		private FormationLevelUpItem LevelUpComponent;

		// Token: 0x0401F818 RID: 129048
		private FormationTrialItem TrialComponent;

		// Token: 0x0401F819 RID: 129049
		private FormationOnlineItem RoleHeadOnlineComponent;

		// Token: 0x0401F81A RID: 129050
		private bool IsAssistRole;

		// Token: 0x0401F81B RID: 129051
		private bool QteNiagaraActive;

		// Token: 0x0401F81C RID: 129052
		private ERoleQteType CurrentQteNiagaraType;

		// Token: 0x0401F81D RID: 129053
		private bool SelectedNiagaraActive;

		// Token: 0x0401F81E RID: 129054
		private bool LinkActive;

		// Token: 0x0401F81F RID: 129055
		private bool IsInitLinkEffect;

		// Token: 0x0401F820 RID: 129056
		private bool RefreshCooldownExternalLock;

		// Token: 0x0401F821 RID: 129057
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<string> InvisibleKeyList;

		// Token: 0x0401F822 RID: 129058
		private TimerHandle RefreshKeyItemTimer;

		// Token: 0x0200BFAC RID: 49068
		[NullableContext(0)]
		private enum EChildType
		{
			// Token: 0x04039D2F RID: 236847
			FormationToggle,
			// Token: 0x04039D30 RID: 236848
			ChangeRoleCoolDownItem,
			// Token: 0x04039D31 RID: 236849
			ChangeRoleCoolDownBarTexture,
			// Token: 0x04039D32 RID: 236850
			ChangeRoleCoolDownText,
			// Token: 0x04039D33 RID: 236851
			CureItem,
			// Token: 0x04039D34 RID: 236852
			QTENiagara,
			// Token: 0x04039D35 RID: 236853
			ConcertoChangeItem,
			// Token: 0x04039D36 RID: 236854
			ConcertoChangeNiagara,
			// Token: 0x04039D37 RID: 236855
			ConcertoChangeText,
			// Token: 0x04039D38 RID: 236856
			RoleHeadTexture,
			// Token: 0x04039D39 RID: 236857
			HpItem,
			// Token: 0x04039D3A RID: 236858
			ShieldSprite,
			// Token: 0x04039D3B RID: 236859
			HpBarSprite,
			// Token: 0x04039D3C RID: 236860
			LowHpBarSprite,
			// Token: 0x04039D3D RID: 236861
			ConcertoItem,
			// Token: 0x04039D3E RID: 236862
			ElementTexture,
			// Token: 0x04039D3F RID: 236863
			ElementBarSprite,
			// Token: 0x04039D40 RID: 236864
			UltimateTag,
			// Token: 0x04039D41 RID: 236865
			AnimSelect,
			// Token: 0x04039D42 RID: 236866
			AnimSwitch,
			// Token: 0x04039D43 RID: 236867
			LinkItem,
			// Token: 0x04039D44 RID: 236868
			LinkNiagara,
			// Token: 0x04039D45 RID: 236869
			LinkExplosionNiagara,
			// Token: 0x04039D46 RID: 236870
			QTETongZouNiagara,
			// Token: 0x04039D47 RID: 236871
			ExtraContainer,
			// Token: 0x04039D48 RID: 236872
			KeyItem
		}
	}
}
