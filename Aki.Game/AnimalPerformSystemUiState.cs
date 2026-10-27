using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.NewWorld.Pawn.Component;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02002E2E RID: 11822
[NullableContext(1)]
[Nullable(0)]
public class AnimalPerformSystemUiState : AnimalPerformStateBase
{
	// Token: 0x06018E62 RID: 101986 RVA: 0x0066AFC1 File Offset: 0x006691C1
	public AnimalPerformSystemUiState(Entity owner, EAnimalPerformState state, [Nullable(new byte[]
	{
		2,
		1
	})] StateMachine<Entity, EAnimalPerformState> stateMachine = null) : base(owner, state, stateMachine)
	{
	}

	// Token: 0x17002280 RID: 8832
	// (get) Token: 0x06018E63 RID: 101987 RVA: 0x0066AFD7 File Offset: 0x006691D7
	// (set) Token: 0x06018E64 RID: 101988 RVA: 0x0066AFDF File Offset: 0x006691DF
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

	// Token: 0x06018E65 RID: 101989 RVA: 0x0066AFE8 File Offset: 0x006691E8
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

	// Token: 0x06018E66 RID: 101990 RVA: 0x0066B09C File Offset: 0x0066929C
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

	// Token: 0x06018E67 RID: 101991 RVA: 0x0066B118 File Offset: 0x00669318
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

	// Token: 0x06018E68 RID: 101992 RVA: 0x0066B1B4 File Offset: 0x006693B4
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

	// Token: 0x06018E69 RID: 101993 RVA: 0x0066B238 File Offset: 0x00669438
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

	// Token: 0x06018E6A RID: 101994 RVA: 0x0066B27C File Offset: 0x0066947C
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

	// Token: 0x06018E6B RID: 101995 RVA: 0x0066B2B8 File Offset: 0x006694B8
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

	// Token: 0x0400BAE1 RID: 47841
	private readonly Dictionary<int, string> DeliveryPropsConfig = new Dictionary<int, string>();

	// Token: 0x0400BAE2 RID: 47842
	private bool IsViewOpening;

	// Token: 0x0400BAE3 RID: 47843
	private EUiViewName? UiViewName;
}
