using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.NewWorld.Pawn.Component;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x0200238A RID: 9098
[NullableContext(1)]
[Nullable(0)]
public class AnimalPerformSystemUiState : AnimalPerformStateBase
{
	// Token: 0x0601672F RID: 91951 RVA: 0x00690EB1 File Offset: 0x0068F0B1
	public AnimalPerformSystemUiState(Entity owner, EAnimalPerformState state, [Nullable(new byte[]
	{
		2,
		1
	})] StateMachine<Entity, EAnimalPerformState> stateMachine = null) : base(owner, state, stateMachine)
	{
	}

	// Token: 0x170022F3 RID: 8947
	// (get) Token: 0x06016730 RID: 91952 RVA: 0x00690EC7 File Offset: 0x0068F0C7
	// (set) Token: 0x06016731 RID: 91953 RVA: 0x00690ECF File Offset: 0x0068F0CF
	public EUiViewName? SystemUiViewName
	{
		get
		{
			return this.UiViewName;
		}
		set
		{
			this.UiViewName = value;
		}
	}

	// Token: 0x06016732 RID: 91954 RVA: 0x00690ED8 File Offset: 0x0068F0D8
	protected override void OnEnter(EAnimalPerformState? lastState)
	{
		if (this.EcologicalInterface == null)
		{
			return;
		}
		if (this.UiViewName == null)
		{
			return;
		}
		if (UiManager.Instance.IsViewShow(this.UiViewName.Value))
		{
			this.OnOpenView(this.UiViewName.Value, 0);
		}
		else
		{
			this.IsViewOpening = false;
			EventSystem.Instance.Add<EUiViewName, int>(EEventName.OpenView, new Action<EUiViewName, int>(this.OnOpenView));
		}
		EAnimalPerformState? eanimalPerformState = lastState;
		EAnimalPerformState eanimalPerformState2 = EAnimalPerformState.Born;
		if (eanimalPerformState.GetValueOrDefault() == eanimalPerformState2 & eanimalPerformState != null)
		{
			base.AnimalEcologicalInterface.StateMachineInitializationComplete();
		}
		BaseTagComponent component = this.Owner.GetComponent<BaseTagComponent>();
		if (component != null)
		{
			this.ProcessGameplayTag(component);
		}
		this.EcologicalInterface.SystemUiStart();
	}

	// Token: 0x06016733 RID: 91955 RVA: 0x00690F8C File Offset: 0x0068F18C
	protected override void OnExit(EAnimalPerformState nextState)
	{
		if (this.EcologicalInterface == null)
		{
			return;
		}
		PawnInteractNewComponent component = this.Owner.GetComponent<PawnInteractNewComponent>();
		if (component != null)
		{
			component.SetInteractionState(true, "AnimalPerformSystemUiState OnExit");
		}
		this.EcologicalInterface.SystemUiEnd();
		BaseTagComponent component2 = this.Owner.GetComponent<BaseTagComponent>();
		if (component2 != null)
		{
			component2.RemoveTag(new int?(GameplayTagDefine.EGameplayTagId["动物.Common.通知标识.系统UI"]));
		}
		this.IsViewOpening = false;
		this.UiViewName = null;
	}

	// Token: 0x06016734 RID: 91956 RVA: 0x00691008 File Offset: 0x0068F208
	private void OnOpenView(EUiViewName viewName, int viewId)
	{
		if (this.UiViewName == null || this.UiViewName != viewName)
		{
			return;
		}
		if (!this.IsViewOpening)
		{
			EventSystem.Instance.Remove<EUiViewName, int>(EEventName.OpenView, new Action<EUiViewName, int>(this.OnOpenView));
		}
		this.IsViewOpening = true;
		EventSystem.Instance.Add<EUiViewName, int>(EEventName.CloseView, new Action<EUiViewName, int>(this.OnCloseView));
		EventSystem.Instance.Add<int>(EEventName.OnDeliveryProps, new Action<int>(this.OnDeliveryProps));
	}

	// Token: 0x06016735 RID: 91957 RVA: 0x006910A4 File Offset: 0x0068F2A4
	private void OnCloseView(EUiViewName viewName, int viewId)
	{
		if (this.UiViewName == null)
		{
			return;
		}
		if (this.UiViewName != viewName)
		{
			return;
		}
		EventSystem.Instance.Remove<EUiViewName, int>(EEventName.CloseView, new Action<EUiViewName, int>(this.OnCloseView));
		EventSystem.Instance.Remove<int>(EEventName.OnDeliveryProps, new Action<int>(this.OnDeliveryProps));
		this.StateMachine.Switch(EAnimalPerformState.Stand);
	}

	// Token: 0x06016736 RID: 91958 RVA: 0x00691128 File Offset: 0x0068F328
	public void InitFeedingAnimalConfig(int[] itemIds, string[] gameplayTags)
	{
		if (itemIds == null || gameplayTags == null)
		{
			return;
		}
		int num = itemIds.Length;
		for (int i = 0; i < num; i++)
		{
			int key = itemIds[i];
			string value = gameplayTags[i];
			if (!string.IsNullOrEmpty(value))
			{
				this.DeliveryPropsConfig[key] = value;
			}
		}
	}

	// Token: 0x06016737 RID: 91959 RVA: 0x0069116C File Offset: 0x0068F36C
	private void OnDeliveryProps(int itemId)
	{
		if (itemId == 0)
		{
			return;
		}
		string tagName;
		if (this.DeliveryPropsConfig.TryGetValue(itemId, out tagName))
		{
			FGameplayTag? gameplayTagByName = GameplayTagUtils.GetGameplayTagByName(tagName);
			this.EcologicalInterface.FeedStart(gameplayTagByName.Value);
		}
	}

	// Token: 0x06016738 RID: 91960 RVA: 0x006911A8 File Offset: 0x0068F3A8
	private void ProcessGameplayTag(BaseTagComponent gameplayTagComponent)
	{
		if (gameplayTagComponent == null || !gameplayTagComponent.Valid)
		{
			return;
		}
		if (gameplayTagComponent.HasTag(GameplayTagDefine.EGameplayTagId["动物.Common.状态标识.交互.随机表演"]))
		{
			gameplayTagComponent.RemoveTag(new int?(GameplayTagDefine.EGameplayTagId["动物.Common.状态标识.交互.随机表演"]));
			gameplayTagComponent.AddTag(new int?(GameplayTagDefine.EGameplayTagId["动物.Common.状态标识.交互.站起"]));
		}
		if (gameplayTagComponent.HasTag(GameplayTagDefine.EGameplayTagId["动物.Common.状态标识.交互.坐下"]))
		{
			gameplayTagComponent.RemoveTag(new int?(GameplayTagDefine.EGameplayTagId["动物.Common.状态标识.交互.坐下"]));
			gameplayTagComponent.AddTag(new int?(GameplayTagDefine.EGameplayTagId["动物.Common.状态标识.交互.站起"]));
		}
		if (gameplayTagComponent.HasTag(GameplayTagDefine.EGameplayTagId["动物.Common.状态标识.交互.趴下"]))
		{
			gameplayTagComponent.RemoveTag(new int?(GameplayTagDefine.EGameplayTagId["动物.Common.状态标识.交互.趴下"]));
			gameplayTagComponent.AddTag(new int?(GameplayTagDefine.EGameplayTagId["动物.Common.状态标识.交互.趴下起身"]));
		}
		gameplayTagComponent.AddTag(new int?(GameplayTagDefine.EGameplayTagId["动物.Common.通知标识.系统UI"]));
	}

	// Token: 0x0400BE6F RID: 48751
	private readonly Dictionary<int, string> DeliveryPropsConfig = new Dictionary<int, string>();

	// Token: 0x0400BE70 RID: 48752
	private bool IsViewOpening;

	// Token: 0x0400BE71 RID: 48753
	private EUiViewName? UiViewName;
}
