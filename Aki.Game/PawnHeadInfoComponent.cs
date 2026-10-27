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

// Token: 0x02003110 RID: 12560
[NullableContext(1)]
[Nullable(0)]
public class PawnHeadInfoComponent : EntityComponent, INpcIconFunction, IComponentDependency
{
	// Token: 0x1700254F RID: 9551
	// (get) Token: 0x0601AFC1 RID: 110529 RVA: 0x00753560 File Offset: 0x00751760
	public static Type[] Dependencies
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

	// Token: 0x0601AFC2 RID: 110530 RVA: 0x00753584 File Offset: 0x00751784
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

	// Token: 0x0601AFC3 RID: 110531 RVA: 0x00753740 File Offset: 0x00751940
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

	// Token: 0x0601AFC4 RID: 110532 RVA: 0x00753786 File Offset: 0x00751986
	private void OnCharBornFinished(int _)
	{
		EventSystem.Instance.RemoveWithTarget<int>(base.Entity, EEventName.CharBornFinished, new Action<int>(this.OnCharBornFinished));
		this.IsFixBornFinish = true;
		this.InitHeadIcon();
	}

	// Token: 0x0601AFC5 RID: 110533 RVA: 0x007537B8 File Offset: 0x007519B8
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

	// Token: 0x0601AFC6 RID: 110534 RVA: 0x007538E0 File Offset: 0x00751AE0
	protected void DestroyPlayerNearbyEvent()
	{
		if (this.PlayerNearbyEvent != null)
		{
			EnvironmentalPerceptionController.Instance.DestroyPlayerPerceptionEvent(this.PlayerNearbyEvent);
			this.PlayerNearbyEvent = null;
		}
	}

	// Token: 0x0601AFC7 RID: 110535 RVA: 0x00753901 File Offset: 0x00751B01
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

	// Token: 0x0601AFC8 RID: 110536 RVA: 0x00753930 File Offset: 0x00751B30
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

	// Token: 0x0601AFC9 RID: 110537 RVA: 0x007539E0 File Offset: 0x00751BE0
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

	// Token: 0x0601AFCA RID: 110538 RVA: 0x00753A60 File Offset: 0x00751C60
	private UniTask CreateIconComponent()
	{
		PawnHeadInfoComponent.<CreateIconComponent>d__38 <CreateIconComponent>d__;
		<CreateIconComponent>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<CreateIconComponent>d__.<>4__this = this;
		<CreateIconComponent>d__.<>1__state = -1;
		<CreateIconComponent>d__.<>t__builder.Start<PawnHeadInfoComponent.<CreateIconComponent>d__38>(ref <CreateIconComponent>d__);
		return <CreateIconComponent>d__.<>t__builder.Task;
	}

	// Token: 0x0601AFCB RID: 110539 RVA: 0x00753AA4 File Offset: 0x00751CA4
	private UniTask CreateIconComponentImp()
	{
		PawnHeadInfoComponent.<CreateIconComponentImp>d__39 <CreateIconComponentImp>d__;
		<CreateIconComponentImp>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<CreateIconComponentImp>d__.<>4__this = this;
		<CreateIconComponentImp>d__.<>1__state = -1;
		<CreateIconComponentImp>d__.<>t__builder.Start<PawnHeadInfoComponent.<CreateIconComponentImp>d__39>(ref <CreateIconComponentImp>d__);
		return <CreateIconComponentImp>d__.<>t__builder.Task;
	}

	// Token: 0x0601AFCC RID: 110540 RVA: 0x00753AE8 File Offset: 0x00751CE8
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

	// Token: 0x0601AFCD RID: 110541 RVA: 0x00753D28 File Offset: 0x00751F28
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

	// Token: 0x0601AFCE RID: 110542 RVA: 0x00753D8A File Offset: 0x00751F8A
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

	// Token: 0x0601AFCF RID: 110543 RVA: 0x00753DB4 File Offset: 0x00751FB4
	protected void SetCharacterIconLocation()
	{
		NpcIconComponent iconComponent = this.IconComponent;
		if (iconComponent == null)
		{
			return;
		}
		iconComponent.SetCharacterIconLocation();
	}

	// Token: 0x0601AFD0 RID: 110544 RVA: 0x00753DC6 File Offset: 0x00751FC6
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

	// Token: 0x0601AFD1 RID: 110545 RVA: 0x00753DF1 File Offset: 0x00751FF1
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

	// Token: 0x0601AFD2 RID: 110546 RVA: 0x00753E15 File Offset: 0x00752015
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

	// Token: 0x0601AFD3 RID: 110547 RVA: 0x00753E39 File Offset: 0x00752039
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

	// Token: 0x0601AFD4 RID: 110548 RVA: 0x00753E66 File Offset: 0x00752066
	protected void SetCharacterQuestIcon(TaskMark mark)
	{
		if (!this.IsQuestIconInUse)
		{
			return;
		}
		this.IconComponent.SetNpcQuest(mark.NpcTaskIcon);
		this.IconComponent.MaxShowQuestDisSquared = (float)mark.IconDistant;
	}

	// Token: 0x0601AFD5 RID: 110549 RVA: 0x00753E96 File Offset: 0x00752096
	protected void SetPlayerInfoIcon(string path)
	{
		this.IconComponent.SetPlayerInfoIcon(path);
	}

	// Token: 0x0601AFD6 RID: 110550 RVA: 0x00753EA4 File Offset: 0x007520A4
	protected override void OnEnable()
	{
		NpcIconComponent iconComponent = this.IconComponent;
		if (iconComponent == null)
		{
			return;
		}
		iconComponent.SetHeadItemState(true);
	}

	// Token: 0x0601AFD7 RID: 110551 RVA: 0x00753EB7 File Offset: 0x007520B7
	protected override void OnDisable(string reason)
	{
		NpcIconComponent iconComponent = this.IconComponent;
		if (iconComponent == null)
		{
			return;
		}
		iconComponent.SetHeadItemState(false);
	}

	// Token: 0x0601AFD8 RID: 110552 RVA: 0x00753ECA File Offset: 0x007520CA
	private EEntityType GetEntityType()
	{
		return base.Entity.GetComponent<CreatureDataComponent>().GetEntityType();
	}

	// Token: 0x0601AFD9 RID: 110553 RVA: 0x00753EDC File Offset: 0x007520DC
	private void OnTextLanguageChange(string oldLang, string newLang)
	{
		this.SetCharacterName();
		this.SetCharacterSecondName();
	}

	// Token: 0x0601AFDA RID: 110554 RVA: 0x00753EEA File Offset: 0x007520EA
	private void DisActiveBattleView()
	{
		NpcIconComponent iconComponent = this.IconComponent;
		if (iconComponent == null)
		{
			return;
		}
		iconComponent.SetRootItemState(false);
	}

	// Token: 0x0601AFDB RID: 110555 RVA: 0x00753F00 File Offset: 0x00752100
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

	// Token: 0x0601AFDC RID: 110556 RVA: 0x00753F56 File Offset: 0x00752156
	private void OnUpdateQuestIcon(int id, QuestState status, EQuestStatusUpdateReason _)
	{
		this.UpdateQuestIcon();
	}

	// Token: 0x0601AFDD RID: 110557 RVA: 0x00753F60 File Offset: 0x00752160
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

	// Token: 0x0601AFDE RID: 110558 RVA: 0x00754058 File Offset: 0x00752258
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

	// Token: 0x0601AFDF RID: 110559 RVA: 0x007540A4 File Offset: 0x007522A4
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

	// Token: 0x0601AFE0 RID: 110560 RVA: 0x007541A3 File Offset: 0x007523A3
	private void UpdateInteractionSpotVisible(bool isVisible)
	{
		if (this.IconComponent != null)
		{
			this.IconComponent.SetInteractionSpotVisible(isVisible);
			return;
		}
		this.PendingInteractionSpotVisible = isVisible;
	}

	// Token: 0x0601AFE1 RID: 110561 RVA: 0x007541C4 File Offset: 0x007523C4
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

	// Token: 0x0601AFE2 RID: 110562 RVA: 0x0075421F File Offset: 0x0075241F
	public void UpdateDialogUseState(bool value)
	{
		this.IsDialogIconInUse = value;
	}

	// Token: 0x0601AFE3 RID: 110563 RVA: 0x00754228 File Offset: 0x00752428
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

	// Token: 0x0601AFE4 RID: 110564 RVA: 0x00754253 File Offset: 0x00752453
	public float GetDialogWorldScale3D()
	{
		return this.DialogWorldScale3D;
	}

	// Token: 0x0601AFE5 RID: 110565 RVA: 0x0075425B File Offset: 0x0075245B
	public void HideDialogueText()
	{
		NpcIconComponent iconComponent = this.IconComponent;
		if (iconComponent == null)
		{
			return;
		}
		iconComponent.HideDialogueText();
	}

	// Token: 0x0601AFE6 RID: 110566 RVA: 0x0075426D File Offset: 0x0075246D
	public global::Vector GetSelfLocation()
	{
		return this.ActorComp.ActorLocationProxy;
	}

	// Token: 0x0601AFE7 RID: 110567 RVA: 0x0075427C File Offset: 0x0075247C
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

	// Token: 0x0601AFE8 RID: 110568 RVA: 0x007542CC File Offset: 0x007524CC
	public string GetAttachToSocketName()
	{
		PawnInfoManageComponent pawnInfoManageComp = this.PawnInfoManageComp;
		return ((pawnInfoManageComp != null) ? pawnInfoManageComp.GetHeadStateSocketName() : null) ?? NpcIconConfig.Instance.GetNpcIconSocketName();
	}

	// Token: 0x0601AFE9 RID: 110569 RVA: 0x007542F0 File Offset: 0x007524F0
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

	// Token: 0x0601AFEA RID: 110570 RVA: 0x00754445 File Offset: 0x00752645
	public double GetAddOffsetZ()
	{
		PawnInfoManageComponent pawnInfoManageComp = this.PawnInfoManageComp;
		return (double)((pawnInfoManageComp != null) ? pawnInfoManageComp.GetHeadStateOffset() : 0f);
	}

	// Token: 0x0601AFEB RID: 110571 RVA: 0x0075445E File Offset: 0x0075265E
	public bool IsShowNameInfo()
	{
		return this.IsShowNameOnHead;
	}

	// Token: 0x0601AFEC RID: 110572 RVA: 0x00754466 File Offset: 0x00752666
	public bool IsShowPlayerInfo()
	{
		return this.IsPlayerInfoInUse;
	}

	// Token: 0x0601AFED RID: 110573 RVA: 0x0075446E File Offset: 0x0075266E
	public bool IsShowQuestInfo()
	{
		return this.InternalIsShowQuestInfo;
	}

	// Token: 0x0601AFEE RID: 110574 RVA: 0x00754476 File Offset: 0x00752676
	public bool IsDialogTextActive()
	{
		NpcIconComponent iconComponent = this.IconComponent;
		return iconComponent != null && iconComponent.IsDialogueTextActive();
	}

	// Token: 0x0601AFEF RID: 110575 RVA: 0x0075448C File Offset: 0x0075268C
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

	// Token: 0x0601AFF0 RID: 110576 RVA: 0x007544EC File Offset: 0x007526EC
	public bool CanShowHeadItem()
	{
		return this.ShowHeadInfo && !PlotModel.Instance.IsInHighLevelPlot() && UiModel.Instance.IsInMainView && base.Entity.Active;
	}

	// Token: 0x0601AFF1 RID: 110577 RVA: 0x00754524 File Offset: 0x00752724
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

	// Token: 0x0601AFF2 RID: 110578 RVA: 0x00754663 File Offset: 0x00752863
	public bool TryGetHeadStateFollowData(HeadStateFollowData outData)
	{
		BattleView battleView = UiManager.Instance.GetViewByName(EUiViewName.BattleView) as BattleView;
		BattleHeadStatePanel battleHeadStatePanel = (battleView != null) ? battleView.Proxy.HeadStatePanel : null;
		return battleHeadStatePanel != null && battleHeadStatePanel.TryGetFollowData(base.Entity.Id, outData);
	}

	// Token: 0x0601AFF3 RID: 110579 RVA: 0x007546A1 File Offset: 0x007528A1
	public bool GetRootItemState()
	{
		NpcIconComponent iconComponent = this.IconComponent;
		return iconComponent != null && iconComponent.GetRootItemState();
	}

	// Token: 0x0601AFF4 RID: 110580 RVA: 0x007546B4 File Offset: 0x007528B4
	public void EnableHeadInfo(bool enable)
	{
		if (this.ShowHeadInfo == enable)
		{
			return;
		}
		this.ShowHeadInfo = enable;
	}

	// Token: 0x0601AFF5 RID: 110581 RVA: 0x007546C8 File Offset: 0x007528C8
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

	// Token: 0x0601AFF6 RID: 110582 RVA: 0x00754748 File Offset: 0x00752948
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

	// Token: 0x0601AFF7 RID: 110583 RVA: 0x007547A2 File Offset: 0x007529A2
	private void OnCharacterMorphTypeChanged(Entity entity, EMorphType newMorphType, EMorphType oldMorphType)
	{
		this.SetCharacterIconLocation();
	}

	// Token: 0x0601AFF8 RID: 110584 RVA: 0x007547AC File Offset: 0x007529AC
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

	// Token: 0x0601AFF9 RID: 110585 RVA: 0x007547F8 File Offset: 0x007529F8
	public override bool ClearComponent(EntityComponent componentTemplate)
	{
		if (!base.ClearComponent(componentTemplate))
		{
			return false;
		}
		PawnHeadInfoComponent pawnHeadInfoComponent = (PawnHeadInfoComponent)componentTemplate;
		if (base.CanResetComponentProperty("ActorComp"))
		{
			if (pawnHeadInfoComponent.ActorComp == null)
			{
				this.ActorComp = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<BaseActorComponent>(this.ActorComp), "ActorComp"))
			{
				return false;
			}
		}
		if (base.CanResetComponentProperty("PawnInfoManageComp"))
		{
			if (pawnHeadInfoComponent.PawnInfoManageComp == null)
			{
				this.PawnInfoManageComp = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<PawnInfoManageComponent>(this.PawnInfoManageComp), "PawnInfoManageComp"))
			{
				return false;
			}
		}
		if (base.CanResetComponentProperty("PawnPerceptionComp"))
		{
			if (pawnHeadInfoComponent.PawnPerceptionComp == null)
			{
				this.PawnPerceptionComp = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<PawnPerceptionComponent>(this.PawnPerceptionComp), "PawnPerceptionComp"))
			{
				return false;
			}
		}
		if (base.CanResetComponentProperty("PawnInteractComp"))
		{
			if (pawnHeadInfoComponent.PawnInteractComp == null)
			{
				this.PawnInteractComp = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<PawnInteractNewComponent>(this.PawnInteractComp), "PawnInteractComp"))
			{
				return false;
			}
		}
		if (base.CanResetComponentProperty("SelfLocationVector"))
		{
			if (pawnHeadInfoComponent.SelfLocationVector == null)
			{
				this.SelfLocationVector = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<global::Vector>(this.SelfLocationVector), "SelfLocationVector"))
			{
				return false;
			}
		}
		if (base.CanResetComponentProperty("IconComponent"))
		{
			if (pawnHeadInfoComponent.IconComponent == null)
			{
				this.IconComponent = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<NpcIconComponent>(this.IconComponent), "IconComponent"))
			{
				return false;
			}
		}
		if (base.CanResetComponentProperty("IconCompCreatedPromise"))
		{
			if (pawnHeadInfoComponent.IconCompCreatedPromise == null)
			{
				this.IconCompCreatedPromise = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<CustomPromise>(this.IconCompCreatedPromise), "IconCompCreatedPromise"))
			{
				return false;
			}
		}
		if (base.CanResetComponentProperty("PlayerNearbyEvent"))
		{
			if (pawnHeadInfoComponent.PlayerNearbyEvent == null)
			{
				this.PlayerNearbyEvent = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<PlayerPerceptionEvent>(this.PlayerNearbyEvent), "PlayerNearbyEvent"))
			{
				return false;
			}
		}
		if (base.CanResetComponentProperty("AutoDestroyCheck"))
		{
			this.AutoDestroyCheck = pawnHeadInfoComponent.AutoDestroyCheck;
		}
		if (base.CanResetComponentProperty("DestroyIconCompCountDown"))
		{
			this.DestroyIconCompCountDown = pawnHeadInfoComponent.DestroyIconCompCountDown;
		}
		if (base.CanResetComponentProperty("IsFixBornFinish"))
		{
			this.IsFixBornFinish = pawnHeadInfoComponent.IsFixBornFinish;
		}
		if (base.CanResetComponentProperty("IsPendingCreateBeforeFixBorn"))
		{
			this.IsPendingCreateBeforeFixBorn = pawnHeadInfoComponent.IsPendingCreateBeforeFixBorn;
		}
		if (base.CanResetComponentProperty("IsQuestIconInUse"))
		{
			this.IsQuestIconInUse = pawnHeadInfoComponent.IsQuestIconInUse;
		}
		if (base.CanResetComponentProperty("IsDialogIconInUse"))
		{
			this.IsDialogIconInUse = pawnHeadInfoComponent.IsDialogIconInUse;
		}
		if (base.CanResetComponentProperty("DialogWorldScale3D"))
		{
			this.DialogWorldScale3D = pawnHeadInfoComponent.DialogWorldScale3D;
		}
		if (base.CanResetComponentProperty("IsHeadNameInUse"))
		{
			this.IsHeadNameInUse = pawnHeadInfoComponent.IsHeadNameInUse;
		}
		if (base.CanResetComponentProperty("IsPlayerInfoInUse"))
		{
			this.IsPlayerInfoInUse = pawnHeadInfoComponent.IsPlayerInfoInUse;
		}
		if (base.CanResetComponentProperty("IsShowNameOnHead"))
		{
			this.IsShowNameOnHead = pawnHeadInfoComponent.IsShowNameOnHead;
		}
		if (base.CanResetComponentProperty("ShowHeadInfo"))
		{
			this.ShowHeadInfo = pawnHeadInfoComponent.ShowHeadInfo;
		}
		if (base.CanResetComponentProperty("TickTime"))
		{
			this.TickTime = pawnHeadInfoComponent.TickTime;
		}
		if (base.CanResetComponentProperty("IsNeedTickCheckQuestIcon"))
		{
			this.IsNeedTickCheckQuestIcon = pawnHeadInfoComponent.IsNeedTickCheckQuestIcon;
		}
		if (base.CanResetComponentProperty("PendingInteractionSpotVisible"))
		{
			this.PendingInteractionSpotVisible = pawnHeadInfoComponent.PendingInteractionSpotVisible;
		}
		return true;
	}

	// Token: 0x0400D1DB RID: 53723
	private const int CHECK_QUEST_ICON_INTERVAL = 1000;

	// Token: 0x0400D1DC RID: 53724
	private const int DESTROY_ICON_COMP_TIME = 6000;

	// Token: 0x0400D1DD RID: 53725
	private const int MAX_ICON_COMP_DISTANCE = 3000;

	// Token: 0x0400D1DE RID: 53726
	private const string PLAYER_INFO_DECORATOR_KEY = "PrefabTextItem_PlayerName_Text";

	// Token: 0x0400D1DF RID: 53727
	[StaticVariableRuleIgnore]
	private static readonly string[] playerInfoIconPaths = new string[]
	{
		"/Game/Aki/UI/UIResources/Common/Atlas/SP_Common1P.SP_Common1P",
		"/Game/Aki/UI/UIResources/Common/Atlas/SP_Common2P.SP_Common2P",
		"/Game/Aki/UI/UIResources/Common/Atlas/SP_Common3P.SP_Common3P"
	};

	// Token: 0x0400D1E0 RID: 53728
	[Nullable(2)]
	private BaseActorComponent ActorComp;

	// Token: 0x0400D1E1 RID: 53729
	[Nullable(2)]
	private PawnInfoManageComponent PawnInfoManageComp;

	// Token: 0x0400D1E2 RID: 53730
	[Nullable(2)]
	private PawnPerceptionComponent PawnPerceptionComp;

	// Token: 0x0400D1E3 RID: 53731
	[Nullable(2)]
	private PawnInteractNewComponent PawnInteractComp;

	// Token: 0x0400D1E4 RID: 53732
	[Nullable(2)]
	private global::Vector SelfLocationVector;

	// Token: 0x0400D1E5 RID: 53733
	[Nullable(2)]
	private NpcIconComponent IconComponent;

	// Token: 0x0400D1E6 RID: 53734
	[Nullable(2)]
	private CustomPromise IconCompCreatedPromise;

	// Token: 0x0400D1E7 RID: 53735
	[Nullable(2)]
	private PlayerPerceptionEvent PlayerNearbyEvent;

	// Token: 0x0400D1E8 RID: 53736
	private bool AutoDestroyCheck = true;

	// Token: 0x0400D1E9 RID: 53737
	private float DestroyIconCompCountDown;

	// Token: 0x0400D1EA RID: 53738
	private bool IsFixBornFinish;

	// Token: 0x0400D1EB RID: 53739
	private bool IsPendingCreateBeforeFixBorn;

	// Token: 0x0400D1EC RID: 53740
	private bool IsQuestIconInUse;

	// Token: 0x0400D1ED RID: 53741
	protected bool IsDialogIconInUse;

	// Token: 0x0400D1EE RID: 53742
	protected float DialogWorldScale3D = 0.5f;

	// Token: 0x0400D1EF RID: 53743
	private bool IsHeadNameInUse;

	// Token: 0x0400D1F0 RID: 53744
	private bool IsPlayerInfoInUse;

	// Token: 0x0400D1F1 RID: 53745
	private readonly bool InternalIsShowQuestInfo;

	// Token: 0x0400D1F2 RID: 53746
	private bool IsShowNameOnHead;

	// Token: 0x0400D1F3 RID: 53747
	private bool ShowHeadInfo = true;

	// Token: 0x0400D1F4 RID: 53748
	private float TickTime;

	// Token: 0x0400D1F5 RID: 53749
	private bool IsNeedTickCheckQuestIcon;

	// Token: 0x0400D1F6 RID: 53750
	private bool PendingInteractionSpotVisible;
}
