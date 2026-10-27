using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Battle;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.BattleUi.Views
{
	// Token: 0x02005CB7 RID: 23735
	[NullableContext(2)]
	[Nullable(0)]
	public class BottomPanel : BattleChildViewPanel
	{
		// Token: 0x0603BF89 RID: 245641 RVA: 0x00E55498 File Offset: 0x00E53698
		protected unsafe override void OnRegisterComponent()
		{
			int num = 7;
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
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x0603BF8A RID: 245642 RVA: 0x00E555A8 File Offset: 0x00E537A8
		public override UniTask InitializeAsync()
		{
			BottomPanel.<InitializeAsync>d__18 <InitializeAsync>d__;
			<InitializeAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitializeAsync>d__.<>4__this = this;
			<InitializeAsync>d__.<>1__state = -1;
			<InitializeAsync>d__.<>t__builder.Start<BottomPanel.<InitializeAsync>d__18>(ref <InitializeAsync>d__);
			return <InitializeAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603BF8B RID: 245643 RVA: 0x00E555EB File Offset: 0x00E537EB
		private void RefreshBuffView(BattleUiRoleData roleData)
		{
			this.RoleBuffView.Refresh(roleData);
			this.RoleUniqueBuffView.Refresh(roleData);
		}

		// Token: 0x0603BF8C RID: 245644 RVA: 0x00E55608 File Offset: 0x00E53808
		private void OnSeamlessTravelRefresh()
		{
			BattleUiRoleData curRoleData = BattleUiModel.Instance.GetCurRoleData();
			this.RefreshBuffView(curRoleData);
		}

		// Token: 0x0603BF8D RID: 245645 RVA: 0x00E55628 File Offset: 0x00E53828
		public override void Reset()
		{
			this.RoleStateView = null;
			this.ConcertoResponseItem = null;
			this.RoleBuffView = null;
			this.SpecialEnergyBarContainer = null;
			this.RoleUniqueBuffView = null;
			this.BossBuffNumItem = null;
			this.PendingBossBuffCues.Clear();
			this.SetFishingStateViewActive(false);
			base.Reset();
		}

		// Token: 0x0603BF8E RID: 245646 RVA: 0x00E55677 File Offset: 0x00E53877
		protected override void OnShowBattleChildViewPanel(bool isFirst)
		{
			RoleStateView roleStateView = this.RoleStateView;
			if (roleStateView == null)
			{
				return;
			}
			roleStateView.SetNiagaraActive(false);
		}

		// Token: 0x0603BF8F RID: 245647 RVA: 0x00E5568C File Offset: 0x00E5388C
		public override void OnTickBattleChildViewPanel(float delta)
		{
			RoleStateView roleStateView = this.RoleStateView;
			if (roleStateView != null)
			{
				roleStateView.Tick(delta);
			}
			RoleBuffView roleBuffView = this.RoleBuffView;
			if (roleBuffView != null)
			{
				roleBuffView.Tick(delta);
			}
			SpecialEnergyBarContainer specialEnergyBarContainer = this.SpecialEnergyBarContainer;
			if (specialEnergyBarContainer != null)
			{
				specialEnergyBarContainer.Tick(delta);
			}
			RoleUniqueBuffView roleUniqueBuffView = this.RoleUniqueBuffView;
			if (roleUniqueBuffView != null)
			{
				roleUniqueBuffView.Tick(delta);
			}
			BossBuffNumItem bossBuffNumItem = this.BossBuffNumItem;
			if (bossBuffNumItem == null)
			{
				return;
			}
			bossBuffNumItem.Tick(delta);
		}

		// Token: 0x0603BF90 RID: 245648 RVA: 0x00E556F4 File Offset: 0x00E538F4
		private UniTask NewRoleStateViewAsync()
		{
			BottomPanel.<NewRoleStateViewAsync>d__24 <NewRoleStateViewAsync>d__;
			<NewRoleStateViewAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<NewRoleStateViewAsync>d__.<>4__this = this;
			<NewRoleStateViewAsync>d__.<>1__state = -1;
			<NewRoleStateViewAsync>d__.<>t__builder.Start<BottomPanel.<NewRoleStateViewAsync>d__24>(ref <NewRoleStateViewAsync>d__);
			return <NewRoleStateViewAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603BF91 RID: 245649 RVA: 0x00E55738 File Offset: 0x00E53938
		private UniTask NewElementBallItemAsync()
		{
			BottomPanel.<NewElementBallItemAsync>d__25 <NewElementBallItemAsync>d__;
			<NewElementBallItemAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<NewElementBallItemAsync>d__.<>4__this = this;
			<NewElementBallItemAsync>d__.<>1__state = -1;
			<NewElementBallItemAsync>d__.<>t__builder.Start<BottomPanel.<NewElementBallItemAsync>d__25>(ref <NewElementBallItemAsync>d__);
			return <NewElementBallItemAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603BF92 RID: 245650 RVA: 0x00E5577C File Offset: 0x00E5397C
		private UniTask NewRoleBuffViewAsync()
		{
			BottomPanel.<NewRoleBuffViewAsync>d__26 <NewRoleBuffViewAsync>d__;
			<NewRoleBuffViewAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<NewRoleBuffViewAsync>d__.<>4__this = this;
			<NewRoleBuffViewAsync>d__.<>1__state = -1;
			<NewRoleBuffViewAsync>d__.<>t__builder.Start<BottomPanel.<NewRoleBuffViewAsync>d__26>(ref <NewRoleBuffViewAsync>d__);
			return <NewRoleBuffViewAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603BF93 RID: 245651 RVA: 0x00E557C0 File Offset: 0x00E539C0
		private UniTask NewSpecialEnergyBarAsync()
		{
			BottomPanel.<NewSpecialEnergyBarAsync>d__27 <NewSpecialEnergyBarAsync>d__;
			<NewSpecialEnergyBarAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<NewSpecialEnergyBarAsync>d__.<>4__this = this;
			<NewSpecialEnergyBarAsync>d__.<>1__state = -1;
			<NewSpecialEnergyBarAsync>d__.<>t__builder.Start<BottomPanel.<NewSpecialEnergyBarAsync>d__27>(ref <NewSpecialEnergyBarAsync>d__);
			return <NewSpecialEnergyBarAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603BF94 RID: 245652 RVA: 0x00E55804 File Offset: 0x00E53A04
		private UniTask NewRoleTopBuffViewAsync()
		{
			BottomPanel.<NewRoleTopBuffViewAsync>d__28 <NewRoleTopBuffViewAsync>d__;
			<NewRoleTopBuffViewAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<NewRoleTopBuffViewAsync>d__.<>4__this = this;
			<NewRoleTopBuffViewAsync>d__.<>1__state = -1;
			<NewRoleTopBuffViewAsync>d__.<>t__builder.Start<BottomPanel.<NewRoleTopBuffViewAsync>d__28>(ref <NewRoleTopBuffViewAsync>d__);
			return <NewRoleTopBuffViewAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603BF95 RID: 245653 RVA: 0x00E55848 File Offset: 0x00E53A48
		private UniTask NewHonamiStoryViewAsync()
		{
			BottomPanel.<NewHonamiStoryViewAsync>d__29 <NewHonamiStoryViewAsync>d__;
			<NewHonamiStoryViewAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<NewHonamiStoryViewAsync>d__.<>4__this = this;
			<NewHonamiStoryViewAsync>d__.<>1__state = -1;
			<NewHonamiStoryViewAsync>d__.<>t__builder.Start<BottomPanel.<NewHonamiStoryViewAsync>d__29>(ref <NewHonamiStoryViewAsync>d__);
			return <NewHonamiStoryViewAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603BF96 RID: 245654 RVA: 0x00E5588C File Offset: 0x00E53A8C
		protected override void AddEvents()
		{
			EventSystem.Instance.Add<int, int>(EEventName.BattleUiCurRoleDataChangedNextTick, new Action<int, int>(this.OnChangeRole));
			EventSystem.Instance.Add<bool>(EEventName.BattleUiEnergyBarVisible, new Action<bool>(this.OnEnergyBarVisibleChange));
			EventSystem.Instance.Add<Entity>(EEventName.BattleUiRemoveRoleData, new Action<Entity>(this.OnRemoveEntity));
			EventSystem.Instance.Add(EEventName.CharOnBuffAddUITexture, new Action<int, GameplayCue, bool, int>(this.OnAddOrRemoveBuff));
			EventSystem.Instance.Add(EEventName.OnServerAttributeChange, new Action<int, AttributeChangedNotify>(this.OnServerAttributeChange));
			EventSystem.Instance.Add(EEventName.OnConcertoResponseOpen, new Action<bool>(this.OnConcertoResponseOpen));
			EventSystem.Instance.Add(EEventName.DriveFishingShipStateChanged, new Action<bool>(this.OnDriveFishingShipStateChanged));
			EventSystem.Instance.Add(EEventName.OnBattleStateChanged, new Action<bool>(this.OnBattleStateChanged));
			EventSystem.Instance.Add(EEventName.OnMoraleActiveChanged, new Action<bool>(this.OnMoraleActiveChanged));
			EventSystem.Instance.Add<bool>(EEventName.OnFlagChallengeDungeonActiveChanged, new Action<bool>(this.OnFlagChallengeDungeonActiveChanged));
			EventSystem.Instance.Add(EEventName.SeamlessTravelUIRefresh, new Action(this.OnSeamlessTravelRefresh));
		}

		// Token: 0x0603BF97 RID: 245655 RVA: 0x00E559D0 File Offset: 0x00E53BD0
		protected override void RemoveEvents()
		{
			EventSystem.Instance.Remove(EEventName.BattleUiCurRoleDataChangedNextTick, new Action<int, int>(this.OnChangeRole));
			EventSystem.Instance.Remove(EEventName.BattleUiEnergyBarVisible, new Action<bool>(this.OnEnergyBarVisibleChange));
			EventSystem.Instance.Remove(EEventName.BattleUiRemoveRoleData, new Action<Entity>(this.OnRemoveEntity));
			EventSystem.Instance.Remove(EEventName.OnServerAttributeChange, new Action<int, AttributeChangedNotify>(this.OnServerAttributeChange));
			EventSystem.Instance.Remove(EEventName.CharOnBuffAddUITexture, new Action<int, GameplayCue, bool, int>(this.OnAddOrRemoveBuff));
			EventSystem.Instance.Remove(EEventName.OnConcertoResponseOpen, new Action<bool>(this.OnConcertoResponseOpen));
			EventSystem.Instance.Remove(EEventName.DriveFishingShipStateChanged, new Action<bool>(this.OnDriveFishingShipStateChanged));
			EventSystem.Instance.Remove(EEventName.OnBattleStateChanged, new Action<bool>(this.OnBattleStateChanged));
			EventSystem.Instance.Remove(EEventName.OnMoraleActiveChanged, new Action<bool>(this.OnMoraleActiveChanged));
			EventSystem.Instance.Remove(EEventName.OnFlagChallengeDungeonActiveChanged, new Action<bool>(this.OnFlagChallengeDungeonActiveChanged));
			EventSystem.Instance.Remove(EEventName.SeamlessTravelUIRefresh, new Action(this.OnSeamlessTravelRefresh));
		}

		// Token: 0x0603BF98 RID: 245656 RVA: 0x00E55B11 File Offset: 0x00E53D11
		private void OnConcertoResponseOpen(bool isOpen)
		{
			ConcertoResponseItem concertoResponseItem = this.ConcertoResponseItem;
			if (concertoResponseItem == null)
			{
				return;
			}
			concertoResponseItem.RefreshVisible();
		}

		// Token: 0x0603BF99 RID: 245657 RVA: 0x00E55B24 File Offset: 0x00E53D24
		private void OnChangeRole(int i, int i1)
		{
			BattleUiRoleData curRoleData = BattleUiModel.Instance.GetCurRoleData();
			if (curRoleData == null)
			{
				return;
			}
			if (curRoleData.IsPhantom() && curRoleData.RoleConfig.Value.SpecialEnergyBarId > 0 && curRoleData.MorphShowSpecialEnergyBar)
			{
				this.RoleStateView.Refresh(null);
				this.ConcertoResponseItem.Refresh(null);
			}
			else
			{
				this.RoleStateView.Refresh(curRoleData);
				this.ConcertoResponseItem.Refresh(curRoleData);
			}
			this.SpecialEnergyBarContainer.OnChangeRole(curRoleData.MorphShowSpecialEnergyBar ? curRoleData : null);
			this.RefreshBuffView(curRoleData);
		}

		// Token: 0x0603BF9A RID: 245658 RVA: 0x00E55BB8 File Offset: 0x00E53DB8
		private void OnEnergyBarVisibleChange(bool visible)
		{
			BattleUiRoleData curRoleData = BattleUiModel.Instance.GetCurRoleData();
			if (curRoleData == null)
			{
				return;
			}
			if (curRoleData.IsPhantom() && !visible)
			{
				this.RoleStateView.Refresh(null);
				this.ConcertoResponseItem.Refresh(null);
			}
			else
			{
				this.RoleStateView.Refresh(curRoleData);
				this.ConcertoResponseItem.Refresh(curRoleData);
			}
			this.SpecialEnergyBarContainer.OnChangeRole(visible ? curRoleData : null);
		}

		// Token: 0x0603BF9B RID: 245659 RVA: 0x00E55C24 File Offset: 0x00E53E24
		[NullableContext(1)]
		private void OnRemoveEntity(Entity entity)
		{
			int? entityId = this.RoleStateView.GetEntityId();
			int id = entity.Id;
			if (entityId.GetValueOrDefault() == id & entityId != null)
			{
				this.RoleStateView.Refresh(null);
			}
			entityId = this.ConcertoResponseItem.GetEntityId();
			id = entity.Id;
			if (entityId.GetValueOrDefault() == id & entityId != null)
			{
				this.ConcertoResponseItem.Refresh(null);
			}
			entityId = this.RoleBuffView.GetEntityId();
			id = entity.Id;
			if (entityId.GetValueOrDefault() == id & entityId != null)
			{
				this.RefreshBuffView(null);
			}
			this.RoleUniqueBuffView.OnRemoveEntity(entity.Id);
			this.SpecialEnergyBarContainer.OnRemoveEntity(entity.Id);
		}

		// Token: 0x0603BF9C RID: 245660 RVA: 0x00E55CE8 File Offset: 0x00E53EE8
		[NullableContext(1)]
		private void OnServerAttributeChange(int entityId, AttributeChangedNotify attributeData)
		{
			EntityHandle getCurrentEntity = SceneTeamModel.Instance.GetCurrentEntity;
			if (getCurrentEntity == null || !getCurrentEntity.Valid || attributeData == null)
			{
				return;
			}
			if (getCurrentEntity.Id != entityId)
			{
				return;
			}
			using (IEnumerator<GameplayAttributeData> enumerator = attributeData.Attributes.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					if (enumerator.Current.AttributeType == 3)
					{
						this.RoleStateView.RefreshHpAndShield(true);
					}
				}
			}
		}

		// Token: 0x0603BF9D RID: 245661 RVA: 0x00E55D6C File Offset: 0x00E53F6C
		private void OnAddOrRemoveBuff(int entityId, GameplayCue cue, bool isAdd, int handleId)
		{
			if (cue.CueType == 38)
			{
				this.OnBossBuffCueChanged(cue, isAdd, handleId, entityId);
				return;
			}
			int? entityId2 = this.RoleBuffView.GetEntityId();
			if (!(entityId2.GetValueOrDefault() == entityId & entityId2 != null))
			{
				return;
			}
			if (cue.CueType == 24)
			{
				if (isAdd)
				{
					this.RoleUniqueBuffView.AddBuff(cue, handleId);
					return;
				}
				this.RoleUniqueBuffView.RemoveBuff(cue, handleId);
				return;
			}
			else
			{
				if (isAdd)
				{
					this.RoleBuffView.AddBuff(cue, handleId);
					return;
				}
				this.RoleBuffView.RemoveBuff(cue, handleId);
				return;
			}
		}

		// Token: 0x0603BF9E RID: 245662 RVA: 0x00E55DFF File Offset: 0x00E53FFF
		private void OnDriveFishingShipStateChanged(bool isDriving)
		{
			this.SetRoleViewVisible(2, !isDriving);
			this.SetFishingStateViewActive(isDriving);
		}

		// Token: 0x0603BF9F RID: 245663 RVA: 0x00E55E13 File Offset: 0x00E54013
		private void OnBattleStateChanged(bool isInBattleState)
		{
			if (MoraleBattleModel.Instance.IsMoraleActive())
			{
				this.SetMoraleTempExpViewActive(isInBattleState);
			}
			if (FlagChallengeBattleModel.Instance.IsFlagChallengeBattleActive())
			{
				this.SetFlagChallengeTempExpViewActive(isInBattleState);
			}
		}

		// Token: 0x0603BFA0 RID: 245664 RVA: 0x00E55E3B File Offset: 0x00E5403B
		private void OnMoraleActiveChanged(bool active)
		{
			if (!active)
			{
				this.SetMoraleTempExpViewActive(false);
				return;
			}
			if (FormationDataController.Instance.GlobalIsInFight)
			{
				this.SetMoraleTempExpViewActive(true);
			}
		}

		// Token: 0x0603BFA1 RID: 245665 RVA: 0x00E55E5B File Offset: 0x00E5405B
		private void OnFlagChallengeDungeonActiveChanged(bool active)
		{
			if (!active)
			{
				this.SetFlagChallengeTempExpViewActive(false);
				return;
			}
			if (FormationDataController.Instance.GlobalIsInFight)
			{
				this.SetFlagChallengeTempExpViewActive(true);
			}
		}

		// Token: 0x0603BFA2 RID: 245666 RVA: 0x00E55E7C File Offset: 0x00E5407C
		private void SetRoleViewVisible(int reason, bool bVisible)
		{
			RoleStateView roleStateView = this.RoleStateView;
			if (roleStateView != null)
			{
				roleStateView.SetVisible(reason, bVisible);
			}
			ConcertoResponseItem concertoResponseItem = this.ConcertoResponseItem;
			if (concertoResponseItem != null)
			{
				concertoResponseItem.SetVisible(reason, bVisible);
			}
			RoleBuffView roleBuffView = this.RoleBuffView;
			if (roleBuffView != null)
			{
				roleBuffView.SetVisible(reason, bVisible);
			}
			SpecialEnergyBarContainer specialEnergyBarContainer = this.SpecialEnergyBarContainer;
			if (specialEnergyBarContainer != null)
			{
				specialEnergyBarContainer.SetVisible(reason, bVisible);
			}
			RoleUniqueBuffView roleUniqueBuffView = this.RoleUniqueBuffView;
			if (roleUniqueBuffView == null)
			{
				return;
			}
			roleUniqueBuffView.SetVisible(reason, bVisible);
		}

		// Token: 0x0603BFA3 RID: 245667 RVA: 0x00E55EE8 File Offset: 0x00E540E8
		private void SetFishingStateViewActive(bool bActive)
		{
			if (bActive)
			{
				if (this.FishingStateView == null)
				{
					this.FishingStateView = base.NewDynamicChildViewByResourceIdWithCallback<FishingStateView>(this.RootItem, "UiItem_NavigationFightHp", false, null, null);
					return;
				}
			}
			else if (this.FishingStateView != null)
			{
				this.FishingStateView.Destroy(null);
				this.FishingStateView = null;
			}
		}

		// Token: 0x0603BFA4 RID: 245668 RVA: 0x00E55F38 File Offset: 0x00E54138
		private UniTask NewMoraleTempExpViewAsync()
		{
			BottomPanel.<NewMoraleTempExpViewAsync>d__44 <NewMoraleTempExpViewAsync>d__;
			<NewMoraleTempExpViewAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<NewMoraleTempExpViewAsync>d__.<>4__this = this;
			<NewMoraleTempExpViewAsync>d__.<>1__state = -1;
			<NewMoraleTempExpViewAsync>d__.<>t__builder.Start<BottomPanel.<NewMoraleTempExpViewAsync>d__44>(ref <NewMoraleTempExpViewAsync>d__);
			return <NewMoraleTempExpViewAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603BFA5 RID: 245669 RVA: 0x00E55F7C File Offset: 0x00E5417C
		private void SetMoraleTempExpViewActive(bool active)
		{
			if (active)
			{
				if (this.MoraleTempExpView == null)
				{
					this.NewMoraleTempExpViewAsync().ContinueWith(delegate()
					{
						if (MoraleBattleModel.Instance.IsMoraleActive() && FormationDataController.Instance.GlobalIsInFight)
						{
							MoraleTempExpView moraleTempExpView3 = this.MoraleTempExpView;
							if (moraleTempExpView3 == null)
							{
								return;
							}
							moraleTempExpView3.ShowBattleVisibleChildView(false);
						}
					}).Forget();
					return;
				}
				MoraleTempExpView moraleTempExpView = this.MoraleTempExpView;
				if (moraleTempExpView == null)
				{
					return;
				}
				moraleTempExpView.ShowBattleVisibleChildView(false);
				return;
			}
			else
			{
				MoraleTempExpView moraleTempExpView2 = this.MoraleTempExpView;
				if (moraleTempExpView2 == null)
				{
					return;
				}
				moraleTempExpView2.HideBattleVisibleChildView();
				return;
			}
		}

		// Token: 0x0603BFA6 RID: 245670 RVA: 0x00E55FD4 File Offset: 0x00E541D4
		[NullableContext(1)]
		[return: Nullable(new byte[]
		{
			2,
			1
		})]
		public override UUIItem[] GetGuideUiItemAndUiItemForShowEx(string[] configParams)
		{
			if (configParams == null || configParams.Length == 0)
			{
				return null;
			}
			if (!(configParams[0] == "MoraleTempExp"))
			{
				return null;
			}
			MoraleTempExpView moraleTempExpView = this.MoraleTempExpView;
			UUIItem uuiitem = (moraleTempExpView != null) ? moraleTempExpView.GetRootItem() : null;
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

		// Token: 0x0603BFA7 RID: 245671 RVA: 0x00E56024 File Offset: 0x00E54224
		private UniTask NewFlagChallengeTempExpViewAsync()
		{
			BottomPanel.<NewFlagChallengeTempExpViewAsync>d__47 <NewFlagChallengeTempExpViewAsync>d__;
			<NewFlagChallengeTempExpViewAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<NewFlagChallengeTempExpViewAsync>d__.<>4__this = this;
			<NewFlagChallengeTempExpViewAsync>d__.<>1__state = -1;
			<NewFlagChallengeTempExpViewAsync>d__.<>t__builder.Start<BottomPanel.<NewFlagChallengeTempExpViewAsync>d__47>(ref <NewFlagChallengeTempExpViewAsync>d__);
			return <NewFlagChallengeTempExpViewAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603BFA8 RID: 245672 RVA: 0x00E56068 File Offset: 0x00E54268
		private void SetFlagChallengeTempExpViewActive(bool active)
		{
			if (active)
			{
				if (this.FlagChallengeTempExpView == null)
				{
					this.NewFlagChallengeTempExpViewAsync().ContinueWith(delegate()
					{
						if (FlagChallengeBattleModel.Instance.IsFlagChallengeBattleActive() && FormationDataController.Instance.GlobalIsInFight)
						{
							FlagChallengeTempExpView flagChallengeTempExpView3 = this.FlagChallengeTempExpView;
							if (flagChallengeTempExpView3 == null)
							{
								return;
							}
							flagChallengeTempExpView3.ShowBattleVisibleChildView(false);
						}
					});
					return;
				}
				FlagChallengeTempExpView flagChallengeTempExpView = this.FlagChallengeTempExpView;
				if (flagChallengeTempExpView == null)
				{
					return;
				}
				flagChallengeTempExpView.ShowBattleVisibleChildView(false);
				return;
			}
			else
			{
				FlagChallengeTempExpView flagChallengeTempExpView2 = this.FlagChallengeTempExpView;
				if (flagChallengeTempExpView2 == null)
				{
					return;
				}
				flagChallengeTempExpView2.HideBattleVisibleChildView();
				return;
			}
		}

		// Token: 0x0603BFA9 RID: 245673 RVA: 0x00E560BC File Offset: 0x00E542BC
		private void OnBossBuffCueChanged(GameplayCue cueConfig, bool isAdd, int handleId, int entityId)
		{
			if (isAdd && !this.ValidateFormationBuff(entityId, handleId))
			{
				return;
			}
			EBossBuffNumMode ebossBuffNumMode = (cueConfig.ParametersLength > 0 && cueConfig.Parameters(0) == "1") ? EBossBuffNumMode.PresenceMode : EBossBuffNumMode.StackMode;
			if (this.BossBuffNumItem != null)
			{
				this.BossBuffNumItem.OnCueChanged(handleId, entityId, ebossBuffNumMode, isAdd);
				return;
			}
			this.PendingBossBuffCues.Add(new ValueTuple<int, int, EBossBuffNumMode, bool>(handleId, entityId, ebossBuffNumMode, isAdd));
			this.CreateBossBuffNumItem().Forget();
		}

		// Token: 0x0603BFAA RID: 245674 RVA: 0x00E56134 File Offset: 0x00E54334
		private UniTask CreateBossBuffNumItem()
		{
			BottomPanel.<CreateBossBuffNumItem>d__51 <CreateBossBuffNumItem>d__;
			<CreateBossBuffNumItem>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<CreateBossBuffNumItem>d__.<>4__this = this;
			<CreateBossBuffNumItem>d__.<>1__state = -1;
			<CreateBossBuffNumItem>d__.<>t__builder.Start<BottomPanel.<CreateBossBuffNumItem>d__51>(ref <CreateBossBuffNumItem>d__);
			return <CreateBossBuffNumItem>d__.<>t__builder.Task;
		}

		// Token: 0x0603BFAB RID: 245675 RVA: 0x00E56178 File Offset: 0x00E54378
		private IActiveBuff GetBuffByHandleId(int entityId, int handleId)
		{
			EntityHandle entityById = CreatureModel.Instance.GetEntityById(entityId);
			if (((entityById != null) ? entityById.Entity : null) == null)
			{
				return null;
			}
			CharacterBuffComponent component = entityById.Entity.GetComponent<CharacterBuffComponent>();
			IActiveBuff activeBuff = (component != null) ? component.GetBuffByHandle(handleId) : null;
			if (activeBuff == null)
			{
				RoleBuffComponent component2 = entityById.Entity.GetComponent<RoleBuffComponent>();
				IActiveBuff activeBuff2;
				if (component2 == null)
				{
					activeBuff2 = null;
				}
				else
				{
					PlayerBuffComponent formationBuffComp = component2.GetFormationBuffComp();
					activeBuff2 = ((formationBuffComp != null) ? formationBuffComp.GetBuffByHandle(handleId) : null);
				}
				activeBuff = activeBuff2;
			}
			return activeBuff;
		}

		// Token: 0x0603BFAC RID: 245676 RVA: 0x00E561E4 File Offset: 0x00E543E4
		private bool ValidateFormationBuff(int entityId, int handleId)
		{
			IActiveBuff buffByHandleId = this.GetBuffByHandleId(entityId, handleId);
			if (buffByHandleId != null)
			{
				BuffDefinition config = buffByHandleId.Config;
				if (config == null || config.FormationPolicy != EBuffFormationPolicy.FormationBuff)
				{
					Log instance = Log.Instance;
					ELogModule module = ELogModule.Battle;
					ELogAuthor author = ELogAuthor.GHY;
					string message = "BottomPanel: BossBuffNum关联的buff不是编队buff，请检查buff配置";
					<>y__InlineArray4<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray4<ValueTuple<string, object>>);
					ref ValueTuple<string, object> ptr = ref <PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0);
					string item = "buffId";
					DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(0, 1);
					defaultInterpolatedStringHandler.AppendFormatted<long>(buffByHandleId.Id);
					ptr = new ValueTuple<string, object>(item, defaultInterpolatedStringHandler.ToStringAndClear());
					ref ValueTuple<string, object> ptr2 = ref <PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1);
					string item2 = "formationPolicy";
					defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(0, 1);
					BuffDefinition config2 = buffByHandleId.Config;
					defaultInterpolatedStringHandler.AppendFormatted<EBuffFormationPolicy?>((config2 != null) ? new EBuffFormationPolicy?(config2.FormationPolicy) : null);
					ptr2 = new ValueTuple<string, object>(item2, defaultInterpolatedStringHandler.ToStringAndClear());
					ref ValueTuple<string, object> ptr3 = ref <PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2);
					string item3 = "handleId";
					defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(0, 1);
					defaultInterpolatedStringHandler.AppendFormatted<int>(handleId);
					ptr3 = new ValueTuple<string, object>(item3, defaultInterpolatedStringHandler.ToStringAndClear());
					ref ValueTuple<string, object> ptr4 = ref <PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 3);
					string item4 = "entityId";
					defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(0, 1);
					defaultInterpolatedStringHandler.AppendFormatted<int>(entityId);
					ptr4 = new ValueTuple<string, object>(item4, defaultInterpolatedStringHandler.ToStringAndClear());
					instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 4));
					return false;
				}
			}
			return true;
		}

		// Token: 0x0401F4B4 RID: 128180
		private RoleStateView RoleStateView;

		// Token: 0x0401F4B5 RID: 128181
		private RoleBuffView RoleBuffView;

		// Token: 0x0401F4B6 RID: 128182
		private ConcertoResponseItem ConcertoResponseItem;

		// Token: 0x0401F4B7 RID: 128183
		private SpecialEnergyBarContainer SpecialEnergyBarContainer;

		// Token: 0x0401F4B8 RID: 128184
		private RoleUniqueBuffView RoleUniqueBuffView;

		// Token: 0x0401F4B9 RID: 128185
		private FishingStateView FishingStateView;

		// Token: 0x0401F4BA RID: 128186
		private MoraleTempExpView MoraleTempExpView;

		// Token: 0x0401F4BB RID: 128187
		private FlagChallengeTempExpView FlagChallengeTempExpView;

		// Token: 0x0401F4BC RID: 128188
		private HonamiStoryView HonamiStoryView;

		// Token: 0x0401F4BD RID: 128189
		private HonamiStoryMainQuestView HonamiStoryMainQuestView;

		// Token: 0x0401F4BE RID: 128190
		private bool IsLoadingMoraleView;

		// Token: 0x0401F4BF RID: 128191
		private bool IsLoadingFlagChallengeView;

		// Token: 0x0401F4C0 RID: 128192
		private BossBuffNumItem BossBuffNumItem;

		// Token: 0x0401F4C1 RID: 128193
		private bool IsLoadingBossBuffNumView;

		// Token: 0x0401F4C2 RID: 128194
		[Nullable(1)]
		[StaticVariableRuleIgnore]
		private static readonly Stat BattleViewTickStatsObject = Stat.Create("[BattleView]BottomPanelTick", "", "");

		// Token: 0x0401F4C3 RID: 128195
		[Nullable(1)]
		[StaticVariableRuleIgnore]
		private static readonly Stat ChangeRoleStat = Stat.Create("[ChangeRole]BottomPanel", "", "");

		// Token: 0x0401F4C4 RID: 128196
		[TupleElementNames(new string[]
		{
			"HandleId",
			"EntityId",
			"Mode",
			"IsAdd"
		})]
		[Nullable(new byte[]
		{
			1,
			0
		})]
		private readonly List<ValueTuple<int, int, EBossBuffNumMode, bool>> PendingBossBuffCues = new List<ValueTuple<int, int, EBossBuffNumMode, bool>>();

		// Token: 0x0200BE93 RID: 48787
		[NullableContext(0)]
		private enum EChildType
		{
			// Token: 0x0403978C RID: 235404
			RoleStateItem,
			// Token: 0x0403978D RID: 235405
			ConcertoResponseItem,
			// Token: 0x0403978E RID: 235406
			SpecialEnergyItem,
			// Token: 0x0403978F RID: 235407
			RoleBuffItem,
			// Token: 0x04039790 RID: 235408
			PhantomContainerItem,
			// Token: 0x04039791 RID: 235409
			RoleTopBuffItem,
			// Token: 0x04039792 RID: 235410
			MoraleTempExpItem
		}
	}
}
