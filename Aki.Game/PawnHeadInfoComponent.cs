using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using Aki.TDConfigMgr.Component;
using Aki.TDConfigMgr.Quest;
using AkiClient.Game.Aki.Character.BaseCharacter;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.LevelGamePlay;
using CSharpScript.Game.Module.BattleUi.Views;
using CSharpScript.Game.Module.Plot;
using CSharpScript.Game.NewWorld.Common.Component;
using CSharpScript.Game.NewWorld.Pawn.Component;
using CSharpScript.Game.NewWorld.Pawn.Controllers;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x0200266B RID: 9835
[NullableContext(1)]
[Nullable(0)]
public class PawnHeadInfoComponent : EntityComponent, INpcIconFunction
{
	// Token: 0x170026F4 RID: 9972
	// (get) Token: 0x06018A17 RID: 100887 RVA: 0x00779698 File Offset: 0x00777898
	public override Type[] Dependencies
	{
		get
		{
			return new Type[]
			{
				typeof(BaseActorComponent),
				typeof(CreatureDataComponent)
			};
		}
	}

	// Token: 0x06018A18 RID: 100888 RVA: 0x007796BC File Offset: 0x007778BC
	protected override bool OnStart()
	{
		this.PawnInfoManageComp = base.Entity.GetComponent<PawnInfoManageComponent>();
		this.ActorComp = base.Entity.GetComponent<BaseActorComponent>();
		this.PawnPerceptionComp = base.Entity.GetComponent<PawnPerceptionComponent>();
		this.PawnInteractComp = base.Entity.GetComponent<PawnInteractNewComponent>();
		this.SelfLocationVector = global::Vector.Create();
		this.InitBaseInfo();
		CharacterActorComponent characterActorComponent = this.ActorComp as CharacterActorComponent;
		if (characterActorComponent != null)
		{
			EventSystem.Instance.AddWithTarget<int>(base.Entity, EEventName.CharBornFinished, new Action<int>(this.OnCharBornFinished));
			if (this.ActorComp.CreatureData.IsRole() && !characterActorComponent.IsRoleAndCtrlByMe)
			{
				EventSystem.Instance.Add(EEventName.RefreshPlayerInfoVisible, new Action(this.RefreshPlayerInfoState));
				EventSystem.Instance.AddWithTarget(base.Entity, EEventName.OnCharacterMorphTypeChanged, new Action<Entity, EMorphType, EMorphType>(this.OnCharacterMorphTypeChanged));
			}
		}
		else
		{
			this.IsFixBornFinish = true;
			this.InitHeadIcon();
		}
		EventSystem.Instance.AddWithTarget(base.Entity, EEventName.OnAddDynamicOption, new Action(this.UpdateQuestIcon));
		EventSystem.Instance.AddWithTarget(base.Entity, EEventName.OnRemoveDynamicOption, new Action(this.UpdateQuestIcon));
		EventSystem.Instance.Add<int, QuestState, EQuestStatusUpdateReason>(EEventName.OnQuestStateChange, new Action<int, QuestState, EQuestStatusUpdateReason>(this.OnUpdateQuestIcon));
		EventSystem.Instance.AddWithTarget(base.Entity, EEventName.OnInteractionSpotStateChange, new Action<bool>(this.UpdateInteractionSpotVisible));
		EventSystem.Instance.Add<string, string>(EEventName.TextLanguageChange, new Action<string, string>(this.OnTextLanguageChange));
		EventSystem.Instance.AddWithTarget(base.Entity, EEventName.OnEntityNameChanged, new Action(this.ResetCharacterInfo));
		return true;
	}

	// Token: 0x06018A19 RID: 100889 RVA: 0x00779878 File Offset: 0x00777A78
	private void InitBaseInfo()
	{
		CreatureDataComponent creatureData = this.ActorComp.CreatureData;
		if (creatureData == null)
		{
			return;
		}
		BaseInfoComponent baseInfo = creatureData.GetBaseInfo();
		this.IsShowNameOnHead = ((baseInfo != null) ? baseInfo.IsShowNameOnHead : null).GetValueOrDefault();
	}

	// Token: 0x06018A1A RID: 100890 RVA: 0x007798BE File Offset: 0x00777ABE
	private void OnCharBornFinished(int _)
	{
		EventSystem.Instance.RemoveWithTarget<int>(base.Entity, EEventName.CharBornFinished, new Action<int>(this.OnCharBornFinished));
		this.IsFixBornFinish = true;
		this.InitHeadIcon();
	}

	// Token: 0x06018A1B RID: 100891 RVA: 0x007798F0 File Offset: 0x00777AF0
	private void InitHeadIcon()
	{
		bool isPendingCreateBeforeFixBorn = this.IsPendingCreateBeforeFixBorn;
		this.IsPendingCreateBeforeFixBorn = false;
		this.RefreshPlayerInfoState();
		CreatureDataComponent component = base.Entity.GetComponent<CreatureDataComponent>();
		BaseInfoComponent baseInfoComponent = (component != null) ? component.GetBaseInfo() : null;
		if (baseInfoComponent != null && baseInfoComponent.HeadInfo != null)
		{
			this.AutoDestroyCheck = false;
			this.TryCreateIconComponent();
			return;
		}
		string text = (component != null) ? component.GetEntityTidName() : null;
		if (!string.IsNullOrEmpty(text) && PublicUtil.Instance.GetConfigTextByKey(text) != "")
		{
			int num = Math.Max(NpcIconConfig.Instance.GetNpcIconHeadInfoLimitMaxDistance(), 3000);
			int num2 = num + 500;
			uint gameBudgetManagedToken = base.Entity.GameBudgetManagedToken;
			this.PlayerNearbyEvent = EnvironmentalPerceptionController.Instance.CreatePlayerPerceptionEvent();
			this.PlayerNearbyEvent.Init((float)num, gameBudgetManagedToken, delegate
			{
				this.IsHeadNameInUse = true;
				this.TryCreateIconComponent();
			}, delegate
			{
				this.IsHeadNameInUse = false;
			}, new Action(this.DestroyPlayerNearbyEvent), null, (float)num2, null);
			if (gameBudgetManagedToken != 0U)
			{
				UKuroPerceptionInterface.MarkElementDisable(gameBudgetManagedToken, !base.Entity.Active);
			}
			return;
		}
		if (isPendingCreateBeforeFixBorn)
		{
			this.TryCreateIconComponent();
		}
	}

	// Token: 0x06018A1C RID: 100892 RVA: 0x00779A18 File Offset: 0x00777C18
	protected void DestroyPlayerNearbyEvent()
	{
		if (this.PlayerNearbyEvent != null)
		{
			EnvironmentalPerceptionController.Instance.DestroyPlayerPerceptionEvent(this.PlayerNearbyEvent);
			this.PlayerNearbyEvent = null;
		}
	}

	// Token: 0x06018A1D RID: 100893 RVA: 0x00779A39 File Offset: 0x00777C39
	private void TryCreateIconComponent()
	{
		if (this.IconCompCreatedPromise != null)
		{
			return;
		}
		this.IconCompCreatedPromise = new CustomPromise();
		if (!this.IsFixBornFinish)
		{
			this.IsPendingCreateBeforeFixBorn = true;
			return;
		}
		this.CreateIconComponent();
	}

	// Token: 0x06018A1E RID: 100894 RVA: 0x00779A68 File Offset: 0x00777C68
	protected void TryDestroyIconComponent(float delta)
	{
		if (!this.AutoDestroyCheck)
		{
			return;
		}
		if (this.IconComponent == null)
		{
			this.DestroyIconCompCountDown = 0f;
			return;
		}
		if (this.IsHeadNameInUse)
		{
			this.DestroyIconCompCountDown = 0f;
			return;
		}
		if (this.IsQuestIconInUse || this.IconComponent.IsHeadIconActive())
		{
			this.DestroyIconCompCountDown = 0f;
			return;
		}
		if (this.IsPlayerInfoInUse)
		{
			this.DestroyIconCompCountDown = 0f;
			return;
		}
		if (this.IconComponent.IsDialogueTextActive())
		{
			this.DestroyIconCompCountDown = 0f;
			return;
		}
		this.DestroyIconCompCountDown += delta;
		if (this.DestroyIconCompCountDown >= 6000f)
		{
			this.DestroyIconComponent();
		}
	}

	// Token: 0x06018A1F RID: 100895 RVA: 0x00779B18 File Offset: 0x00777D18
	protected void DestroyIconComponent()
	{
		if (this.IconCompCreatedPromise == null)
		{
			return;
		}
		if (this.IconCompCreatedPromise.IsPending)
		{
			this.IconCompCreatedPromise.SetResult();
		}
		if (this.CreatingIconComponent != null)
		{
			this.CreatingIconComponent.Destroy();
			this.CreatingIconComponent = null;
		}
		this.IconCompCreatedPromise = null;
		NpcIconComponent iconComponent = this.IconComponent;
		if (iconComponent != null)
		{
			iconComponent.Destroy();
		}
		this.IconComponent = null;
		CreatureDataComponent component = base.Entity.GetComponent<CreatureDataComponent>();
		if (component != null)
		{
			component.GetPbDataId();
		}
		EventSystem.Instance.Remove(EEventName.DisActiveBattleView, new Action(this.DisActiveBattleView));
	}

	// Token: 0x06018A20 RID: 100896 RVA: 0x00779BB4 File Offset: 0x00777DB4
	private UniTask CreateIconComponent()
	{
		PawnHeadInfoComponent.<CreateIconComponent>d__39 <CreateIconComponent>d__;
		<CreateIconComponent>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<CreateIconComponent>d__.<>4__this = this;
		<CreateIconComponent>d__.<>1__state = -1;
		<CreateIconComponent>d__.<>t__builder.Start<PawnHeadInfoComponent.<CreateIconComponent>d__39>(ref <CreateIconComponent>d__);
		return <CreateIconComponent>d__.<>t__builder.Task;
	}

	// Token: 0x06018A21 RID: 100897 RVA: 0x00779BF8 File Offset: 0x00777DF8
	[NullableContext(0)]
	private UniTask<bool> CreateIconComponentImp()
	{
		PawnHeadInfoComponent.<CreateIconComponentImp>d__40 <CreateIconComponentImp>d__;
		<CreateIconComponentImp>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
		<CreateIconComponentImp>d__.<>4__this = this;
		<CreateIconComponentImp>d__.<>1__state = -1;
		<CreateIconComponentImp>d__.<>t__builder.Start<PawnHeadInfoComponent.<CreateIconComponentImp>d__40>(ref <CreateIconComponentImp>d__);
		return <CreateIconComponentImp>d__.<>t__builder.Task;
	}

	// Token: 0x06018A22 RID: 100898 RVA: 0x00779C3C File Offset: 0x00777E3C
	protected override bool OnEnd()
	{
		this.DestroyIconComponent();
		if (EventSystem.Instance.HasWithTarget(base.Entity, EEventName.CharBornFinished, new Action<int>(this.OnCharBornFinished)))
		{
			EventSystem.Instance.RemoveWithTarget(base.Entity, EEventName.CharBornFinished, new Action<int>(this.OnCharBornFinished));
		}
		if (EventSystem.Instance.HasWithTarget(base.Entity, EEventName.OnAddDynamicOption, new Action(this.UpdateQuestIcon)))
		{
			EventSystem.Instance.RemoveWithTarget(base.Entity, EEventName.OnAddDynamicOption, new Action(this.UpdateQuestIcon));
		}
		if (EventSystem.Instance.HasWithTarget(base.Entity, EEventName.OnRemoveDynamicOption, new Action(this.UpdateQuestIcon)))
		{
			EventSystem.Instance.RemoveWithTarget(base.Entity, EEventName.OnRemoveDynamicOption, new Action(this.UpdateQuestIcon));
		}
		if (EventSystem.Instance.Has(EEventName.RefreshPlayerInfoVisible, new Action(this.RefreshPlayerInfoState)))
		{
			EventSystem.Instance.Remove(EEventName.RefreshPlayerInfoVisible, new Action(this.RefreshPlayerInfoState));
		}
		if (EventSystem.Instance.HasWithTarget(base.Entity, EEventName.OnCharacterMorphTypeChanged, new Action<Entity, EMorphType, EMorphType>(this.OnCharacterMorphTypeChanged)))
		{
			EventSystem.Instance.RemoveWithTarget(base.Entity, EEventName.OnCharacterMorphTypeChanged, new Action<Entity, EMorphType, EMorphType>(this.OnCharacterMorphTypeChanged));
		}
		EventSystem.Instance.Remove(EEventName.OnQuestStateChange, new Action<int, QuestState, EQuestStatusUpdateReason>(this.OnUpdateQuestIcon));
		if (EventSystem.Instance.HasWithTarget(base.Entity, EEventName.OnInteractionSpotStateChange, new Action<bool>(this.UpdateInteractionSpotVisible)))
		{
			EventSystem.Instance.RemoveWithTarget(base.Entity, EEventName.OnInteractionSpotStateChange, new Action<bool>(this.UpdateInteractionSpotVisible));
		}
		if (EventSystem.Instance.Has(EEventName.TextLanguageChange, new Action<string, string>(this.OnTextLanguageChange)))
		{
			EventSystem.Instance.Remove(EEventName.TextLanguageChange, new Action<string, string>(this.OnTextLanguageChange));
		}
		if (EventSystem.Instance.HasWithTarget(base.Entity, EEventName.OnEntityNameChanged, new Action(this.ResetCharacterInfo)))
		{
			EventSystem.Instance.RemoveWithTarget(base.Entity, EEventName.OnEntityNameChanged, new Action(this.ResetCharacterInfo));
		}
		return true;
	}

	// Token: 0x06018A23 RID: 100899 RVA: 0x00779E7C File Offset: 0x0077807C
	public override void OnEntityWasRecentlyRenderedOnScreenChange(bool wasRecentlyRenderedOnScreen)
	{
		if (this.GetEntityType() == EEntityType.SceneItem)
		{
			SceneItemActorComponent sceneItemActorComponent = this.ActorComp as SceneItemActorComponent;
			if (sceneItemActorComponent == null || sceneItemActorComponent.PrefabRadius == 0f || sceneItemActorComponent.CurLevelPrefabShowActor is AEffectSystemActor)
			{
				NpcIconComponent iconComponent = this.IconComponent;
				if (iconComponent == null)
				{
					return;
				}
				iconComponent.OnNpcWasRecentlyRenderedOnScreenChange(true);
				return;
			}
		}
		NpcIconComponent iconComponent2 = this.IconComponent;
		if (iconComponent2 == null)
		{
			return;
		}
		iconComponent2.OnNpcWasRecentlyRenderedOnScreenChange(wasRecentlyRenderedOnScreen);
	}

	// Token: 0x06018A24 RID: 100900 RVA: 0x00779EDE File Offset: 0x007780DE
	private void InitNpcIcon()
	{
		this.SetCharacterIconLocation();
		this.UpdateQuestIcon();
		this.ResetCharacterInfo();
		NpcIconComponent iconComponent = this.IconComponent;
		if (iconComponent == null)
		{
			return;
		}
		iconComponent.SetInteractionSpotVisible(this.PendingInteractionSpotVisible);
	}

	// Token: 0x06018A25 RID: 100901 RVA: 0x00779F08 File Offset: 0x00778108
	protected void SetCharacterIconLocation()
	{
		NpcIconComponent iconComponent = this.IconComponent;
		if (iconComponent == null)
		{
			return;
		}
		iconComponent.SetCharacterIconLocation();
	}

	// Token: 0x06018A26 RID: 100902 RVA: 0x00779F1A File Offset: 0x0077811A
	private void ResetCharacterInfo()
	{
		this.TryCreateIconComponent();
		PawnInfoManageComponent pawnInfoManageComp = this.PawnInfoManageComp;
		if (pawnInfoManageComp != null)
		{
			pawnInfoManageComp.UpdateNameAndHeadInfo();
		}
		this.SetCharacterName();
		this.SetCharacterSecondName();
		this.SetCharacterFunctionIcon();
	}

	// Token: 0x06018A27 RID: 100903 RVA: 0x00779F45 File Offset: 0x00778145
	private void SetCharacterName()
	{
		NpcIconComponent iconComponent = this.IconComponent;
		if (iconComponent == null)
		{
			return;
		}
		PawnInfoManageComponent pawnInfoManageComp = this.PawnInfoManageComp;
		iconComponent.SetCharacterName((pawnInfoManageComp != null) ? pawnInfoManageComp.PawnName : null);
	}

	// Token: 0x06018A28 RID: 100904 RVA: 0x00779F69 File Offset: 0x00778169
	protected void SetCharacterSecondName()
	{
		NpcIconComponent iconComponent = this.IconComponent;
		if (iconComponent == null)
		{
			return;
		}
		PawnInfoManageComponent pawnInfoManageComp = this.PawnInfoManageComp;
		iconComponent.SetCharacterSecondName((pawnInfoManageComp != null) ? pawnInfoManageComp.SecondName : null);
	}

	// Token: 0x06018A29 RID: 100905 RVA: 0x00779F8D File Offset: 0x0077818D
	protected void SetCharacterFunctionIcon()
	{
		if (this.IsQuestIconInUse)
		{
			return;
		}
		NpcIconComponent iconComponent = this.IconComponent;
		if (iconComponent == null)
		{
			return;
		}
		PawnInfoManageComponent pawnInfoManageComp = this.PawnInfoManageComp;
		iconComponent.SetCharacterFunctionIcon((pawnInfoManageComp != null) ? pawnInfoManageComp.FunctionIcon : null);
	}

	// Token: 0x06018A2A RID: 100906 RVA: 0x00779FBA File Offset: 0x007781BA
	protected void SetCharacterQuestIcon(TaskMark mark)
	{
		if (!this.IsQuestIconInUse)
		{
			return;
		}
		if (this.IconComponent != null)
		{
			this.IconComponent.SetNpcQuest(mark.NpcTaskIcon);
			this.IconComponent.MaxShowQuestDisSquared = (float)mark.IconDistant;
		}
	}

	// Token: 0x06018A2B RID: 100907 RVA: 0x00779FF2 File Offset: 0x007781F2
	protected override void OnEnable()
	{
		NpcIconComponent iconComponent = this.IconComponent;
		if (iconComponent == null)
		{
			return;
		}
		iconComponent.SetHeadItemState(true);
	}

	// Token: 0x06018A2C RID: 100908 RVA: 0x0077A005 File Offset: 0x00778205
	protected override void OnDisable(string reason)
	{
		NpcIconComponent iconComponent = this.IconComponent;
		if (iconComponent == null)
		{
			return;
		}
		iconComponent.SetHeadItemState(false);
	}

	// Token: 0x06018A2D RID: 100909 RVA: 0x0077A018 File Offset: 0x00778218
	private EEntityType GetEntityType()
	{
		return base.Entity.GetComponent<CreatureDataComponent>().GetEntityType();
	}

	// Token: 0x06018A2E RID: 100910 RVA: 0x0077A02A File Offset: 0x0077822A
	private void OnTextLanguageChange(string oldLang, string newLang)
	{
		this.SetCharacterName();
		this.SetCharacterSecondName();
	}

	// Token: 0x06018A2F RID: 100911 RVA: 0x0077A038 File Offset: 0x00778238
	private void DisActiveBattleView()
	{
		NpcIconComponent iconComponent = this.IconComponent;
		if (iconComponent == null)
		{
			return;
		}
		iconComponent.SetRootItemState(false);
	}

	// Token: 0x06018A30 RID: 100912 RVA: 0x0077A04C File Offset: 0x0077824C
	protected override void OnTick(float deltaTime)
	{
		base.OnTick(deltaTime);
		if (this.IsNeedTickCheckQuestIcon)
		{
			this.TickTime += deltaTime;
			if (this.TickTime > 1000f)
			{
				this.TickTime -= 1000f;
				this.UpdateQuestIcon();
			}
		}
		this.TryDestroyIconComponent(deltaTime);
	}

	// Token: 0x06018A31 RID: 100913 RVA: 0x0077A0A2 File Offset: 0x007782A2
	private void OnUpdateQuestIcon(int id, QuestState status, EQuestStatusUpdateReason _)
	{
		this.UpdateQuestIcon();
	}

	// Token: 0x06018A32 RID: 100914 RVA: 0x0077A0AC File Offset: 0x007782AC
	private void UpdateQuestIcon()
	{
		PawnInteractNewComponent pawnInteractComp = this.PawnInteractComp;
		PawnInteractController pawnInteractController = (pawnInteractComp != null) ? pawnInteractComp.GetInteractController() : null;
		if (pawnInteractController == null || pawnInteractController.QuestOptionList.Count == 0)
		{
			this.RefreshNpcQuest(null);
			return;
		}
		bool flag = false;
		foreach (CommonInteractOption commonInteractOption in pawnInteractController.QuestOptionList)
		{
			if (commonInteractOption.Context != null)
			{
				int? questMarkIdByContext = this.GetQuestMarkIdByContext(commonInteractOption.Context);
				if (questMarkIdByContext != null)
				{
					if (LevelGeneralController.Instance.CheckConditionNew(commonInteractOption.Condition, this.ActorComp.Owner, null, null))
					{
						this.RefreshNpcQuest(new int?(questMarkIdByContext.Value));
						this.IsNeedTickCheckQuestIcon = false;
						return;
					}
					flag = true;
				}
			}
		}
		if (flag)
		{
			this.IsNeedTickCheckQuestIcon = true;
		}
	}

	// Token: 0x06018A33 RID: 100915 RVA: 0x0077A1A4 File Offset: 0x007783A4
	private UniTask RefreshNpcQuest(int? markId = null)
	{
		PawnHeadInfoComponent.<RefreshNpcQuest>d__58 <RefreshNpcQuest>d__;
		<RefreshNpcQuest>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<RefreshNpcQuest>d__.<>4__this = this;
		<RefreshNpcQuest>d__.markId = markId;
		<RefreshNpcQuest>d__.<>1__state = -1;
		<RefreshNpcQuest>d__.<>t__builder.Start<PawnHeadInfoComponent.<RefreshNpcQuest>d__58>(ref <RefreshNpcQuest>d__);
		return <RefreshNpcQuest>d__.<>t__builder.Task;
	}

	// Token: 0x06018A34 RID: 100916 RVA: 0x0077A1F0 File Offset: 0x007783F0
	private int? GetQuestMarkIdByContext(GeneralContext context)
	{
		int? result = null;
		EGeneralContextType? type = context.Type;
		if (type != null)
		{
			EGeneralContextType valueOrDefault = type.GetValueOrDefault();
			if (valueOrDefault != EGeneralContextType.Quest)
			{
				if (valueOrDefault == EGeneralContextType.GeneralLogicTree)
				{
					GeneralLogicTreeContext generalLogicTreeContext = context as GeneralLogicTreeContext;
					BaseBehaviorTree behaviorTree = GeneralLogicTreeModel.Instance.GetBehaviorTree(new long?(generalLogicTreeContext.TreeIncId), false);
					if (behaviorTree != null && behaviorTree.BtType == BtType.Quest)
					{
						global::Quest quest = QuestNewModel.Instance.GetQuest(generalLogicTreeContext.TreeConfigId);
						if (quest != null && quest.Type == EQuest.Daily)
						{
							BehaviorNodeBase node = behaviorTree.GetNode(generalLogicTreeContext.NodeId);
							if (node != null && node.ContainTag(EBehaviorTreeTag.CanShow))
							{
								result = new int?(behaviorTree.GetTrackIconId());
							}
						}
					}
				}
			}
			else
			{
				QuestContext questContext = context as QuestContext;
				global::Quest quest2 = QuestNewModel.Instance.GetQuest(questContext.QuestId);
				if (quest2 != null && !quest2.HideAcceptQuestMark.GetValueOrDefault())
				{
					result = new int?(quest2.QuestMarkId);
				}
			}
		}
		return result;
	}

	// Token: 0x06018A35 RID: 100917 RVA: 0x0077A2EF File Offset: 0x007784EF
	private void UpdateInteractionSpotVisible(bool isVisible)
	{
		if (this.IconComponent != null)
		{
			this.IconComponent.SetInteractionSpotVisible(isVisible);
			return;
		}
		this.PendingInteractionSpotVisible = isVisible;
	}

	// Token: 0x06018A36 RID: 100918 RVA: 0x0077A310 File Offset: 0x00778510
	public UniTask SetDialogueText(string text, float removeSeconds = -1f, bool redDot = false)
	{
		PawnHeadInfoComponent.<SetDialogueText>d__61 <SetDialogueText>d__;
		<SetDialogueText>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<SetDialogueText>d__.<>4__this = this;
		<SetDialogueText>d__.text = text;
		<SetDialogueText>d__.removeSeconds = removeSeconds;
		<SetDialogueText>d__.redDot = redDot;
		<SetDialogueText>d__.<>1__state = -1;
		<SetDialogueText>d__.<>t__builder.Start<PawnHeadInfoComponent.<SetDialogueText>d__61>(ref <SetDialogueText>d__);
		return <SetDialogueText>d__.<>t__builder.Task;
	}

	// Token: 0x06018A37 RID: 100919 RVA: 0x0077A36B File Offset: 0x0077856B
	public void UpdateDialogUseState(bool value)
	{
		this.IsDialogIconInUse = value;
	}

	// Token: 0x06018A38 RID: 100920 RVA: 0x0077A374 File Offset: 0x00778574
	public void UpdateDialogScale(float newScale)
	{
		if (newScale <= 0f || this.DialogWorldScale3D == newScale)
		{
			return;
		}
		this.DialogWorldScale3D = newScale;
		NpcIconComponent iconComponent = this.IconComponent;
		if (iconComponent == null)
		{
			return;
		}
		iconComponent.UpdateDialogWorldScale();
	}

	// Token: 0x06018A39 RID: 100921 RVA: 0x0077A39F File Offset: 0x0077859F
	public float GetDialogWorldScale3D()
	{
		return this.DialogWorldScale3D;
	}

	// Token: 0x06018A3A RID: 100922 RVA: 0x0077A3A7 File Offset: 0x007785A7
	public void HideDialogueText()
	{
		NpcIconComponent iconComponent = this.IconComponent;
		if (iconComponent == null)
		{
			return;
		}
		iconComponent.HideDialogueText();
	}

	// Token: 0x06018A3B RID: 100923 RVA: 0x0077A3B9 File Offset: 0x007785B9
	public global::Vector GetSelfLocation()
	{
		return this.ActorComp.ActorLocationProxy;
	}

	// Token: 0x06018A3C RID: 100924 RVA: 0x0077A3C8 File Offset: 0x007785C8
	[NullableContext(2)]
	public UPrimitiveComponent GetAttachToMeshComponent()
	{
		if (this.GetEntityType() != EEntityType.SceneItem)
		{
			return this.ActorComp.SkeletalMesh;
		}
		CSharpScript.Game.NewWorld.Common.Component.RoadNetworkNavigationComponent component = base.Entity.GetComponent<CSharpScript.Game.NewWorld.Common.Component.RoadNetworkNavigationComponent>();
		if (component != null && component.Valid)
		{
			return component.GetSkeletalMeshComponent();
		}
		return (this.ActorComp as SceneItemActorComponent).GetStaticMeshComponent();
	}

	// Token: 0x06018A3D RID: 100925 RVA: 0x0077A418 File Offset: 0x00778618
	public string GetAttachToSocketName()
	{
		PawnInfoManageComponent pawnInfoManageComp = this.PawnInfoManageComp;
		return ((pawnInfoManageComp != null) ? pawnInfoManageComp.GetHeadStateSocketName() : null) ?? NpcIconConfig.Instance.GetNpcIconSocketName();
	}

	// Token: 0x06018A3E RID: 100926 RVA: 0x0077A43C File Offset: 0x0077863C
	public unsafe void GetAttachToLocation(global::Vector outVec)
	{
		BaseCharacterComponent baseCharacterComponent = this.ActorComp as BaseCharacterComponent;
		if (baseCharacterComponent != null)
		{
			FVectorDouble fvectorDouble = baseCharacterComponent.SkeletalMesh.D_K2_GetComponentLocation();
			outVec.Set(fvectorDouble.X, fvectorDouble.Y, fvectorDouble.Z + (double)(2f * baseCharacterComponent.HalfHeight));
			Log instance = Log.Instance;
			ELogModule module = ELogModule.HudUnit;
			ELogAuthor author = ELogAuthor.YJX;
			string message = "获取根头顶组件位置";
			<>y__InlineArray4<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray4<ValueTuple<string, object>>);
			ref ValueTuple<string, object> ptr = ref <PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0);
			string item = "PbDataId";
			BaseActorComponent actorComp = this.ActorComp;
			ptr = new ValueTuple<string, object>(item, (actorComp != null) ? new int?(actorComp.CreatureData.GetPbDataId()) : null);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("RootLocation", outVec);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("ActorLocation", baseCharacterComponent.ActorLocationProxy);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 3) = new ValueTuple<string, object>("MeshLocation", fvectorDouble);
			instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 4));
			return;
		}
		USkeletalMeshComponent uskeletalMeshComponent = this.ActorComp.SkeletalMesh;
		SceneItemActorComponent sceneItemActorComponent = this.ActorComp as SceneItemActorComponent;
		if (sceneItemActorComponent != null && uskeletalMeshComponent == null)
		{
			ASkeletalMeshActor interactionSkeletalMeshActor = sceneItemActorComponent.GetInteractionSkeletalMeshActor();
			uskeletalMeshComponent = ((interactionSkeletalMeshActor != null) ? interactionSkeletalMeshActor.SkeletalMeshComponent : null);
		}
		if (uskeletalMeshComponent == null)
		{
			return;
		}
		FVectorDouble fvectorDouble2 = uskeletalMeshComponent.D_K2_GetComponentLocation();
		outVec.FromUeVector(fvectorDouble2);
	}

	// Token: 0x06018A3F RID: 100927 RVA: 0x0077A591 File Offset: 0x00778791
	public double GetAddOffsetZ()
	{
		PawnInfoManageComponent pawnInfoManageComp = this.PawnInfoManageComp;
		return (double)((pawnInfoManageComp != null) ? pawnInfoManageComp.GetHeadStateOffset() : 0f);
	}

	// Token: 0x06018A40 RID: 100928 RVA: 0x0077A5AA File Offset: 0x007787AA
	public bool IsShowNameInfo()
	{
		return this.IsShowNameOnHead;
	}

	// Token: 0x06018A41 RID: 100929 RVA: 0x0077A5B2 File Offset: 0x007787B2
	public bool IsShowPlayerInfo()
	{
		return this.IsPlayerInfoInUse;
	}

	// Token: 0x06018A42 RID: 100930 RVA: 0x0077A5BA File Offset: 0x007787BA
	public bool IsShowQuestInfo()
	{
		return this.InternalIsShowQuestInfo;
	}

	// Token: 0x06018A43 RID: 100931 RVA: 0x0077A5C2 File Offset: 0x007787C2
	public bool IsDialogTextActive()
	{
		NpcIconComponent iconComponent = this.IconComponent;
		return iconComponent != null && iconComponent.IsDialogueTextActive();
	}

	// Token: 0x06018A44 RID: 100932 RVA: 0x0077A5D8 File Offset: 0x007787D8
	public bool CanTick(float deltaTime)
	{
		if (this.IconComponent == null)
		{
			return false;
		}
		BaseActorComponent actorComp = this.ActorComp;
		if ((actorComp == null || !actorComp.CreatureData.IsRole()) && this.PawnPerceptionComp == null)
		{
			return false;
		}
		if (!this.CanShowHeadItem())
		{
			this.IconComponent.SetRootItemState(false);
			return false;
		}
		this.IconComponent.SetRootItemState(true);
		return true;
	}

	// Token: 0x06018A45 RID: 100933 RVA: 0x0077A638 File Offset: 0x00778838
	public bool CanShowHeadItem()
	{
		return this.ShowHeadInfo && !PlotModel.Instance.IsInHighLevelPlot() && UiModel.Instance.IsInMainView && base.Entity.Active;
	}

	// Token: 0x06018A46 RID: 100934 RVA: 0x0077A670 File Offset: 0x00778870
	public bool IsInHeadItemShowRange(double disSquared, double maxShowRangeDisSquared, double minShowRangeDisSquared)
	{
		CreatureDataComponent component = base.Entity.GetComponent<CreatureDataComponent>();
		int? num = (component != null) ? new int?(component.GetPbDataId()) : null;
		ITrackData trackData = TrackModel.Instance.IsTargetTracking(num.GetValueOrDefault());
		if (trackData != null && trackData.TrackSource != ETrackSource.MapMark)
		{
			global::Vector playerLocation = GeneralLogicTreeUtil.Instance.GetPlayerLocation();
			if (playerLocation != null)
			{
				this.SelfLocationVector.DeepCopy(this.GetSelfLocation());
				double num2 = global::Vector.DistSquared(playerLocation, this.SelfLocationVector);
				float? num3 = trackData.TrackHideDis * trackData.TrackHideDis * (float)100;
				float num4 = (float)100;
				double? num5 = (num3 != null) ? new double?((double)(num3.GetValueOrDefault() * num4)) : null;
				return num2 < num5.GetValueOrDefault() & num5 != null;
			}
		}
		return disSquared < maxShowRangeDisSquared && disSquared > minShowRangeDisSquared;
	}

	// Token: 0x06018A47 RID: 100935 RVA: 0x0077A7AF File Offset: 0x007789AF
	public bool TryGetHeadStateFollowData(HeadStateFollowData outData)
	{
		BattleView battleView = UiManager.Instance.GetViewByName(EUiViewName.BattleView) as BattleView;
		BattleHeadStatePanel battleHeadStatePanel = (battleView != null) ? battleView.Proxy.HeadStatePanel : null;
		return battleHeadStatePanel != null && battleHeadStatePanel.TryGetFollowData(base.Entity.Id, outData);
	}

	// Token: 0x06018A48 RID: 100936 RVA: 0x0077A7ED File Offset: 0x007789ED
	public bool GetRootItemState()
	{
		NpcIconComponent iconComponent = this.IconComponent;
		return iconComponent != null && iconComponent.GetRootItemState();
	}

	// Token: 0x06018A49 RID: 100937 RVA: 0x0077A800 File Offset: 0x00778A00
	public void EnableHeadInfo(bool enable)
	{
		if (this.ShowHeadInfo == enable)
		{
			return;
		}
		this.ShowHeadInfo = enable;
	}

	// Token: 0x06018A4A RID: 100938 RVA: 0x0077A814 File Offset: 0x00778A14
	public bool CanShowPlayerInfo()
	{
		BaseActorComponent actorComp = this.ActorComp;
		if (actorComp == null || !actorComp.CreatureData.IsRole())
		{
			return false;
		}
		if (!GameModeModel.Instance.IsMulti)
		{
			return false;
		}
		int playerId = this.ActorComp.CreatureData.GetPlayerId();
		int? id = PlayerInfoModel.Instance.GetId();
		int num = playerId;
		return !(id.GetValueOrDefault() == num & id != null) && OnlineModel.Instance.GetCurrentTeamListById(playerId) != null;
	}

	// Token: 0x06018A4B RID: 100939 RVA: 0x0077A894 File Offset: 0x00778A94
	public void RefreshPlayerInfoState()
	{
		bool flag = GameSettingsManager.Instance.GetCurrentValue(EFunction.ShowOtherName, true, true) > 0 && this.CanShowPlayerInfo();
		if (this.IsPlayerInfoInUse == flag)
		{
			return;
		}
		this.IsPlayerInfoInUse = flag;
		this.UpdatePlayerInfoIcon(flag);
	}

	// Token: 0x06018A4C RID: 100940 RVA: 0x0077A8EE File Offset: 0x00778AEE
	private void OnCharacterMorphTypeChanged(Entity entity, EMorphType newMorphType, EMorphType oldMorphType)
	{
		this.SetCharacterIconLocation();
	}

	// Token: 0x06018A4D RID: 100941 RVA: 0x0077A8F8 File Offset: 0x00778AF8
	protected UniTask UpdatePlayerInfoIcon(bool active)
	{
		PawnHeadInfoComponent.<UpdatePlayerInfoIcon>d__84 <UpdatePlayerInfoIcon>d__;
		<UpdatePlayerInfoIcon>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<UpdatePlayerInfoIcon>d__.<>4__this = this;
		<UpdatePlayerInfoIcon>d__.active = active;
		<UpdatePlayerInfoIcon>d__.<>1__state = -1;
		<UpdatePlayerInfoIcon>d__.<>t__builder.Start<PawnHeadInfoComponent.<UpdatePlayerInfoIcon>d__84>(ref <UpdatePlayerInfoIcon>d__);
		return <UpdatePlayerInfoIcon>d__.<>t__builder.Task;
	}

	// Token: 0x06018A4E RID: 100942 RVA: 0x0077A944 File Offset: 0x00778B44
	public override bool ClearComponent(EntityComponent componentTemplate)
	{
		if (!base.ClearComponent(componentTemplate))
		{
			return false;
		}
		PawnHeadInfoComponent pawnHeadInfoComponent = (PawnHeadInfoComponent)componentTemplate;
		if (pawnHeadInfoComponent.ActorComp == null)
		{
			this.ActorComp = null;
		}
		else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.ActorComp), "ActorComp"))
		{
			return false;
		}
		if (pawnHeadInfoComponent.PawnInfoManageComp == null)
		{
			this.PawnInfoManageComp = null;
		}
		else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.PawnInfoManageComp), "PawnInfoManageComp"))
		{
			return false;
		}
		if (pawnHeadInfoComponent.PawnPerceptionComp == null)
		{
			this.PawnPerceptionComp = null;
		}
		else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.PawnPerceptionComp), "PawnPerceptionComp"))
		{
			return false;
		}
		if (pawnHeadInfoComponent.PawnInteractComp == null)
		{
			this.PawnInteractComp = null;
		}
		else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.PawnInteractComp), "PawnInteractComp"))
		{
			return false;
		}
		if (pawnHeadInfoComponent.SelfLocationVector == null)
		{
			this.SelfLocationVector = null;
		}
		else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.SelfLocationVector), "SelfLocationVector"))
		{
			return false;
		}
		if (pawnHeadInfoComponent.IconComponent == null)
		{
			this.IconComponent = null;
		}
		else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.IconComponent), "IconComponent"))
		{
			return false;
		}
		if (pawnHeadInfoComponent.CreatingIconComponent == null)
		{
			this.CreatingIconComponent = null;
		}
		else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.CreatingIconComponent), "CreatingIconComponent"))
		{
			return false;
		}
		if (pawnHeadInfoComponent.IconCompCreatedPromise == null)
		{
			this.IconCompCreatedPromise = null;
		}
		else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.IconCompCreatedPromise), "IconCompCreatedPromise"))
		{
			return false;
		}
		if (pawnHeadInfoComponent.PlayerNearbyEvent == null)
		{
			this.PlayerNearbyEvent = null;
		}
		else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.PlayerNearbyEvent), "PlayerNearbyEvent"))
		{
			return false;
		}
		this.AutoDestroyCheck = pawnHeadInfoComponent.AutoDestroyCheck;
		this.DestroyIconCompCountDown = pawnHeadInfoComponent.DestroyIconCompCountDown;
		this.IsFixBornFinish = pawnHeadInfoComponent.IsFixBornFinish;
		this.IsPendingCreateBeforeFixBorn = pawnHeadInfoComponent.IsPendingCreateBeforeFixBorn;
		this.IsQuestIconInUse = pawnHeadInfoComponent.IsQuestIconInUse;
		this.IsDialogIconInUse = pawnHeadInfoComponent.IsDialogIconInUse;
		this.DialogWorldScale3D = pawnHeadInfoComponent.DialogWorldScale3D;
		this.IsHeadNameInUse = pawnHeadInfoComponent.IsHeadNameInUse;
		this.IsPlayerInfoInUse = pawnHeadInfoComponent.IsPlayerInfoInUse;
		this.IsShowNameOnHead = pawnHeadInfoComponent.IsShowNameOnHead;
		this.ShowHeadInfo = pawnHeadInfoComponent.ShowHeadInfo;
		this.TickTime = pawnHeadInfoComponent.TickTime;
		this.IsNeedTickCheckQuestIcon = pawnHeadInfoComponent.IsNeedTickCheckQuestIcon;
		this.PendingInteractionSpotVisible = pawnHeadInfoComponent.PendingInteractionSpotVisible;
		return true;
	}

	// Token: 0x170026F5 RID: 9973
	// (get) Token: 0x06018A4F RID: 100943 RVA: 0x0077AB8F File Offset: 0x00778D8F
	public override bool NeedStartInternal
	{
		get
		{
			return true;
		}
	}

	// Token: 0x170026F6 RID: 9974
	// (get) Token: 0x06018A50 RID: 100944 RVA: 0x0077AB92 File Offset: 0x00778D92
	public override bool NeedEndInternal
	{
		get
		{
			return true;
		}
	}

	// Token: 0x170026F7 RID: 9975
	// (get) Token: 0x06018A51 RID: 100945 RVA: 0x0077AB95 File Offset: 0x00778D95
	public override bool NeedEnableInternal
	{
		get
		{
			return true;
		}
	}

	// Token: 0x170026F8 RID: 9976
	// (get) Token: 0x06018A52 RID: 100946 RVA: 0x0077AB98 File Offset: 0x00778D98
	public override bool NeedDisableInternal
	{
		get
		{
			return true;
		}
	}

	// Token: 0x170026F9 RID: 9977
	// (get) Token: 0x06018A53 RID: 100947 RVA: 0x0077AB9B File Offset: 0x00778D9B
	public override bool NeedTickInternal
	{
		get
		{
			return true;
		}
	}

	// Token: 0x170026FA RID: 9978
	// (get) Token: 0x06018A54 RID: 100948 RVA: 0x0077AB9E File Offset: 0x00778D9E
	public override bool NeedEntityWasRecentlyRenderedOnScreenChangeInternal
	{
		get
		{
			return true;
		}
	}

	// Token: 0x0400D5FC RID: 54780
	private const int CHECK_QUEST_ICON_INTERVAL = 1000;

	// Token: 0x0400D5FD RID: 54781
	private const int DESTROY_ICON_COMP_TIME = 6000;

	// Token: 0x0400D5FE RID: 54782
	private const int MAX_ICON_COMP_DISTANCE = 3000;

	// Token: 0x0400D5FF RID: 54783
	private const string PLAYER_INFO_DECORATOR_KEY = "PrefabTextItem_PlayerName_Text";

	// Token: 0x0400D600 RID: 54784
	[StaticVariableRuleIgnore]
	private static readonly string[] playerInfoIconPaths = new string[]
	{
		"/Game/Aki/UI/UIResources/Common/Atlas/SP_Common1P.SP_Common1P",
		"/Game/Aki/UI/UIResources/Common/Atlas/SP_Common2P.SP_Common2P",
		"/Game/Aki/UI/UIResources/Common/Atlas/SP_Common3P.SP_Common3P"
	};

	// Token: 0x0400D601 RID: 54785
	[Nullable(2)]
	private BaseActorComponent ActorComp;

	// Token: 0x0400D602 RID: 54786
	[Nullable(2)]
	private PawnInfoManageComponent PawnInfoManageComp;

	// Token: 0x0400D603 RID: 54787
	[Nullable(2)]
	private PawnPerceptionComponent PawnPerceptionComp;

	// Token: 0x0400D604 RID: 54788
	[Nullable(2)]
	private PawnInteractNewComponent PawnInteractComp;

	// Token: 0x0400D605 RID: 54789
	[Nullable(2)]
	private global::Vector SelfLocationVector;

	// Token: 0x0400D606 RID: 54790
	[Nullable(2)]
	private NpcIconComponent IconComponent;

	// Token: 0x0400D607 RID: 54791
	[Nullable(2)]
	private NpcIconComponent CreatingIconComponent;

	// Token: 0x0400D608 RID: 54792
	[Nullable(2)]
	private CustomPromise IconCompCreatedPromise;

	// Token: 0x0400D609 RID: 54793
	[Nullable(2)]
	private PlayerPerceptionEvent PlayerNearbyEvent;

	// Token: 0x0400D60A RID: 54794
	private bool AutoDestroyCheck = true;

	// Token: 0x0400D60B RID: 54795
	private float DestroyIconCompCountDown;

	// Token: 0x0400D60C RID: 54796
	private bool IsFixBornFinish;

	// Token: 0x0400D60D RID: 54797
	private bool IsPendingCreateBeforeFixBorn;

	// Token: 0x0400D60E RID: 54798
	private bool IsQuestIconInUse;

	// Token: 0x0400D60F RID: 54799
	protected bool IsDialogIconInUse;

	// Token: 0x0400D610 RID: 54800
	protected float DialogWorldScale3D = 0.5f;

	// Token: 0x0400D611 RID: 54801
	private bool IsHeadNameInUse;

	// Token: 0x0400D612 RID: 54802
	private bool IsPlayerInfoInUse;

	// Token: 0x0400D613 RID: 54803
	private readonly bool InternalIsShowQuestInfo;

	// Token: 0x0400D614 RID: 54804
	private bool IsShowNameOnHead;

	// Token: 0x0400D615 RID: 54805
	private bool ShowHeadInfo = true;

	// Token: 0x0400D616 RID: 54806
	private float TickTime;

	// Token: 0x0400D617 RID: 54807
	private bool IsNeedTickCheckQuestIcon;

	// Token: 0x0400D618 RID: 54808
	private bool PendingInteractionSpotVisible;
}
