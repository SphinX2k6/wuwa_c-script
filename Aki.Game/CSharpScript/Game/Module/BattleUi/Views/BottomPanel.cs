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
	// Token: 0x02004C99 RID: 19609
	[NullableContext(2)]
	[Nullable(0)]
	public class BottomPanel : BattleChildViewPanel
	{
		// Token: 0x06030EDC RID: 200412 RVA: 0x00DA5B40 File Offset: 0x00DA3D40
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

		// Token: 0x06030EDD RID: 200413 RVA: 0x00DA5C50 File Offset: 0x00DA3E50
		public override UniTask InitializeAsync()
		{
			BottomPanel.<InitializeAsync>d__18 <InitializeAsync>d__;
			<InitializeAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitializeAsync>d__.<>4__this = this;
			<InitializeAsync>d__.<>1__state = -1;
			<InitializeAsync>d__.<>t__builder.Start<BottomPanel.<InitializeAsync>d__18>(ref <InitializeAsync>d__);
			return <InitializeAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06030EDE RID: 200414 RVA: 0x00DA5C93 File Offset: 0x00DA3E93
		private void RefreshBuffView(BattleUiRoleData roleData)
		{
			this.RoleBuffView.Refresh(roleData);
			this.RoleUniqueBuffView.Refresh(roleData);
		}

		// Token: 0x06030EDF RID: 200415 RVA: 0x00DA5CB0 File Offset: 0x00DA3EB0
		private void OnSeamlessTravelRefresh()
		{
			BattleUiRoleData curRoleData = BattleUiModel.Instance.GetCurRoleData();
			this.RefreshBuffView(curRoleData);
		}

		// Token: 0x06030EE0 RID: 200416 RVA: 0x00DA5CD0 File Offset: 0x00DA3ED0
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

		// Token: 0x06030EE1 RID: 200417 RVA: 0x00DA5D1F File Offset: 0x00DA3F1F
		protected override void OnShowBattleChildViewPanel(bool isFirst)
		{
			RoleStateView roleStateView = this.RoleStateView;
			if (roleStateView == null)
			{
				return;
			}
			roleStateView.SetNiagaraActive(false);
		}

		// Token: 0x06030EE2 RID: 200418 RVA: 0x00DA5D34 File Offset: 0x00DA3F34
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

		// Token: 0x06030EE3 RID: 200419 RVA: 0x00DA5D9C File Offset: 0x00DA3F9C
		private UniTask NewRoleStateViewAsync()
		{
			BottomPanel.<NewRoleStateViewAsync>d__24 <NewRoleStateViewAsync>d__;
			<NewRoleStateViewAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<NewRoleStateViewAsync>d__.<>4__this = this;
			<NewRoleStateViewAsync>d__.<>1__state = -1;
			<NewRoleStateViewAsync>d__.<>t__builder.Start<BottomPanel.<NewRoleStateViewAsync>d__24>(ref <NewRoleStateViewAsync>d__);
			return <NewRoleStateViewAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06030EE4 RID: 200420 RVA: 0x00DA5DE0 File Offset: 0x00DA3FE0
		private UniTask NewElementBallItemAsync()
		{
			BottomPanel.<NewElementBallItemAsync>d__25 <NewElementBallItemAsync>d__;
			<NewElementBallItemAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<NewElementBallItemAsync>d__.<>4__this = this;
			<NewElementBallItemAsync>d__.<>1__state = -1;
			<NewElementBallItemAsync>d__.<>t__builder.Start<BottomPanel.<NewElementBallItemAsync>d__25>(ref <NewElementBallItemAsync>d__);
			return <NewElementBallItemAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06030EE5 RID: 200421 RVA: 0x00DA5E24 File Offset: 0x00DA4024
		private UniTask NewRoleBuffViewAsync()
		{
			BottomPanel.<NewRoleBuffViewAsync>d__26 <NewRoleBuffViewAsync>d__;
			<NewRoleBuffViewAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<NewRoleBuffViewAsync>d__.<>4__this = this;
			<NewRoleBuffViewAsync>d__.<>1__state = -1;
			<NewRoleBuffViewAsync>d__.<>t__builder.Start<BottomPanel.<NewRoleBuffViewAsync>d__26>(ref <NewRoleBuffViewAsync>d__);
			return <NewRoleBuffViewAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06030EE6 RID: 200422 RVA: 0x00DA5E68 File Offset: 0x00DA4068
		private UniTask NewSpecialEnergyBarAsync()
		{
			BottomPanel.<NewSpecialEnergyBarAsync>d__27 <NewSpecialEnergyBarAsync>d__;
			<NewSpecialEnergyBarAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<NewSpecialEnergyBarAsync>d__.<>4__this = this;
			<NewSpecialEnergyBarAsync>d__.<>1__state = -1;
			<NewSpecialEnergyBarAsync>d__.<>t__builder.Start<BottomPanel.<NewSpecialEnergyBarAsync>d__27>(ref <NewSpecialEnergyBarAsync>d__);
			return <NewSpecialEnergyBarAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06030EE7 RID: 200423 RVA: 0x00DA5EAC File Offset: 0x00DA40AC
		private UniTask NewRoleTopBuffViewAsync()
		{
			BottomPanel.<NewRoleTopBuffViewAsync>d__28 <NewRoleTopBuffViewAsync>d__;
			<NewRoleTopBuffViewAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<NewRoleTopBuffViewAsync>d__.<>4__this = this;
			<NewRoleTopBuffViewAsync>d__.<>1__state = -1;
			<NewRoleTopBuffViewAsync>d__.<>t__builder.Start<BottomPanel.<NewRoleTopBuffViewAsync>d__28>(ref <NewRoleTopBuffViewAsync>d__);
			return <NewRoleTopBuffViewAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06030EE8 RID: 200424 RVA: 0x00DA5EF0 File Offset: 0x00DA40F0
		private UniTask NewHonamiStoryViewAsync()
		{
			BottomPanel.<NewHonamiStoryViewAsync>d__29 <NewHonamiStoryViewAsync>d__;
			<NewHonamiStoryViewAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<NewHonamiStoryViewAsync>d__.<>4__this = this;
			<NewHonamiStoryViewAsync>d__.<>1__state = -1;
			<NewHonamiStoryViewAsync>d__.<>t__builder.Start<BottomPanel.<NewHonamiStoryViewAsync>d__29>(ref <NewHonamiStoryViewAsync>d__);
			return <NewHonamiStoryViewAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06030EE9 RID: 200425 RVA: 0x00DA5F34 File Offset: 0x00DA4134
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

		// Token: 0x06030EEA RID: 200426 RVA: 0x00DA6078 File Offset: 0x00DA4278
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

		// Token: 0x06030EEB RID: 200427 RVA: 0x00DA61B9 File Offset: 0x00DA43B9
		private void OnConcertoResponseOpen(bool isOpen)
		{
			ConcertoResponseItem concertoResponseItem = this.ConcertoResponseItem;
			if (concertoResponseItem == null)
			{
				return;
			}
			concertoResponseItem.RefreshVisible();
		}

		// Token: 0x06030EEC RID: 200428 RVA: 0x00DA61CC File Offset: 0x00DA43CC
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

		// Token: 0x06030EED RID: 200429 RVA: 0x00DA6260 File Offset: 0x00DA4460
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

		// Token: 0x06030EEE RID: 200430 RVA: 0x00DA62CC File Offset: 0x00DA44CC
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

		// Token: 0x06030EEF RID: 200431 RVA: 0x00DA6390 File Offset: 0x00DA4590
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

		// Token: 0x06030EF0 RID: 200432 RVA: 0x00DA6414 File Offset: 0x00DA4614
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

		// Token: 0x06030EF1 RID: 200433 RVA: 0x00DA64A7 File Offset: 0x00DA46A7
		private void OnDriveFishingShipStateChanged(bool isDriving)
		{
			this.SetRoleViewVisible(2, !isDriving);
			this.SetFishingStateViewActive(isDriving);
		}

		// Token: 0x06030EF2 RID: 200434 RVA: 0x00DA64BB File Offset: 0x00DA46BB
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

		// Token: 0x06030EF3 RID: 200435 RVA: 0x00DA64E3 File Offset: 0x00DA46E3
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

		// Token: 0x06030EF4 RID: 200436 RVA: 0x00DA6503 File Offset: 0x00DA4703
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

		// Token: 0x06030EF5 RID: 200437 RVA: 0x00DA6524 File Offset: 0x00DA4724
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

		// Token: 0x06030EF6 RID: 200438 RVA: 0x00DA6590 File Offset: 0x00DA4790
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

		// Token: 0x06030EF7 RID: 200439 RVA: 0x00DA65E0 File Offset: 0x00DA47E0
		private UniTask NewMoraleTempExpViewAsync()
		{
			BottomPanel.<NewMoraleTempExpViewAsync>d__44 <NewMoraleTempExpViewAsync>d__;
			<NewMoraleTempExpViewAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<NewMoraleTempExpViewAsync>d__.<>4__this = this;
			<NewMoraleTempExpViewAsync>d__.<>1__state = -1;
			<NewMoraleTempExpViewAsync>d__.<>t__builder.Start<BottomPanel.<NewMoraleTempExpViewAsync>d__44>(ref <NewMoraleTempExpViewAsync>d__);
			return <NewMoraleTempExpViewAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06030EF8 RID: 200440 RVA: 0x00DA6624 File Offset: 0x00DA4824
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

		// Token: 0x06030EF9 RID: 200441 RVA: 0x00DA667C File Offset: 0x00DA487C
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

		// Token: 0x06030EFA RID: 200442 RVA: 0x00DA66CC File Offset: 0x00DA48CC
		private UniTask NewFlagChallengeTempExpViewAsync()
		{
			BottomPanel.<NewFlagChallengeTempExpViewAsync>d__47 <NewFlagChallengeTempExpViewAsync>d__;
			<NewFlagChallengeTempExpViewAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<NewFlagChallengeTempExpViewAsync>d__.<>4__this = this;
			<NewFlagChallengeTempExpViewAsync>d__.<>1__state = -1;
			<NewFlagChallengeTempExpViewAsync>d__.<>t__builder.Start<BottomPanel.<NewFlagChallengeTempExpViewAsync>d__47>(ref <NewFlagChallengeTempExpViewAsync>d__);
			return <NewFlagChallengeTempExpViewAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06030EFB RID: 200443 RVA: 0x00DA6710 File Offset: 0x00DA4910
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

		// Token: 0x06030EFC RID: 200444 RVA: 0x00DA6764 File Offset: 0x00DA4964
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

		// Token: 0x06030EFD RID: 200445 RVA: 0x00DA67DC File Offset: 0x00DA49DC
		private UniTask CreateBossBuffNumItem()
		{
			BottomPanel.<CreateBossBuffNumItem>d__51 <CreateBossBuffNumItem>d__;
			<CreateBossBuffNumItem>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<CreateBossBuffNumItem>d__.<>4__this = this;
			<CreateBossBuffNumItem>d__.<>1__state = -1;
			<CreateBossBuffNumItem>d__.<>t__builder.Start<BottomPanel.<CreateBossBuffNumItem>d__51>(ref <CreateBossBuffNumItem>d__);
			return <CreateBossBuffNumItem>d__.<>t__builder.Task;
		}

		// Token: 0x06030EFE RID: 200446 RVA: 0x00DA6820 File Offset: 0x00DA4A20
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

		// Token: 0x06030EFF RID: 200447 RVA: 0x00DA688C File Offset: 0x00DA4A8C
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

		// Token: 0x04019F6D RID: 106349
		private RoleStateView RoleStateView;

		// Token: 0x04019F6E RID: 106350
		private RoleBuffView RoleBuffView;

		// Token: 0x04019F6F RID: 106351
		private ConcertoResponseItem ConcertoResponseItem;

		// Token: 0x04019F70 RID: 106352
		private SpecialEnergyBarContainer SpecialEnergyBarContainer;

		// Token: 0x04019F71 RID: 106353
		private RoleUniqueBuffView RoleUniqueBuffView;

		// Token: 0x04019F72 RID: 106354
		private FishingStateView FishingStateView;

		// Token: 0x04019F73 RID: 106355
		private MoraleTempExpView MoraleTempExpView;

		// Token: 0x04019F74 RID: 106356
		private FlagChallengeTempExpView FlagChallengeTempExpView;

		// Token: 0x04019F75 RID: 106357
		private HonamiStoryView HonamiStoryView;

		// Token: 0x04019F76 RID: 106358
		private HonamiStoryMainQuestView HonamiStoryMainQuestView;

		// Token: 0x04019F77 RID: 106359
		private bool IsLoadingMoraleView;

		// Token: 0x04019F78 RID: 106360
		private bool IsLoadingFlagChallengeView;

		// Token: 0x04019F79 RID: 106361
		private BossBuffNumItem BossBuffNumItem;

		// Token: 0x04019F7A RID: 106362
		private bool IsLoadingBossBuffNumView;

		// Token: 0x04019F7B RID: 106363
		[Nullable(1)]
		[StaticVariableRuleIgnore]
		private static readonly Stat BattleViewTickStatsObject = Stat.Create("[BattleView]BottomPanelTick", "", "");

		// Token: 0x04019F7C RID: 106364
		[Nullable(1)]
		[StaticVariableRuleIgnore]
		private static readonly Stat ChangeRoleStat = Stat.Create("[ChangeRole]BottomPanel", "", "");

		// Token: 0x04019F7D RID: 106365
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

		// Token: 0x0200A899 RID: 43161
		[NullableContext(0)]
		private enum EChildType
		{
			// Token: 0x0403414D RID: 213325
			RoleStateItem,
			// Token: 0x0403414E RID: 213326
			ConcertoResponseItem,
			// Token: 0x0403414F RID: 213327
			SpecialEnergyItem,
			// Token: 0x04034150 RID: 213328
			RoleBuffItem,
			// Token: 0x04034151 RID: 213329
			PhantomContainerItem,
			// Token: 0x04034152 RID: 213330
			RoleTopBuffItem,
			// Token: 0x04034153 RID: 213331
			MoraleTempExpItem
		}
	}
}
