using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Character.BaseCharacter;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Input;
using UnrealEngine;

// Token: 0x020026B2 RID: 9906
[NullableContext(1)]
[Nullable(0)]
public class InputBehaviorInputHandler : ICharacterInputObserver
{
	// Token: 0x06018D47 RID: 101703 RVA: 0x00789F84 File Offset: 0x00788184
	public InputBehaviorInputHandler(TArray<SInputBehavior> inputBehaviors, double beginTime, CharacterInputComponent inputComponent)
	{
		this.BeginTime = beginTime;
		this.InputComponent = inputComponent;
		HashSet<EInputAction> hashSet = new HashSet<EInputAction>();
		for (int i = 0; i < inputBehaviors.Num(); i++)
		{
			TArray<SInputBehaviorCondition> behaviorConditionArray = inputBehaviors.Get(i).BehaviorConditionArray;
			for (int j = 0; j < behaviorConditionArray.Num(); j++)
			{
				SInputBehaviorCondition sinputBehaviorCondition = behaviorConditionArray.Get(j);
				if (sinputBehaviorCondition.ConditionType == EInputBehaviorConditionType.按键按下 || sinputBehaviorCondition.ConditionType == EInputBehaviorConditionType.按键抬起 || sinputBehaviorCondition.ConditionType == EInputBehaviorConditionType.按键持续按住)
				{
					EInputAction? inputAction = InputBehaviorInputHandler.GetInputAction(sinputBehaviorCondition.InputType);
					if (inputAction != null)
					{
						hashSet.Add(inputAction.Value);
					}
				}
			}
		}
		this.ObservedActions = hashSet;
	}

	// Token: 0x06018D48 RID: 101704 RVA: 0x0078A068 File Offset: 0x00788268
	private void OnBattleInputEnableChanged(EInputAction action, bool enable)
	{
		if (!this.Registered)
		{
			return;
		}
		if (enable || !this.ObservedActions.Contains(action))
		{
			return;
		}
		this.PressedActions.Remove(action);
		this.PressStateMap.Remove(action);
		for (int i = this.ReleaseEvents.Count - 1; i >= 0; i--)
		{
			if (this.ReleaseEvents[i].Action == action)
			{
				this.ReleaseEvents.RemoveAt(i);
			}
		}
	}

	// Token: 0x06018D49 RID: 101705 RVA: 0x0078A0E8 File Offset: 0x007882E8
	public static EInputAction? GetInputAction(EInputBehaviorInputAction inputType)
	{
		switch (inputType)
		{
		case EInputBehaviorInputAction.攻击:
			return new EInputAction?(EInputAction.攻击);
		case EInputBehaviorInputAction.技能1:
			return new EInputAction?(EInputAction.技能1);
		case EInputBehaviorInputAction.大招:
			return new EInputAction?(EInputAction.大招);
		case EInputBehaviorInputAction.幻象1:
			return new EInputAction?(EInputAction.幻象1);
		case EInputBehaviorInputAction.幻象2:
			return new EInputAction?(EInputAction.幻象2);
		case EInputBehaviorInputAction.闪避:
			return new EInputAction?(EInputAction.闪避);
		case EInputBehaviorInputAction.跳跃:
			return new EInputAction?(EInputAction.跳跃);
		case EInputBehaviorInputAction.锁定目标:
			return new EInputAction?(EInputAction.锁定目标);
		case EInputBehaviorInputAction.瞄准:
			return new EInputAction?(EInputAction.瞄准);
		case EInputBehaviorInputAction.下降:
			return new EInputAction?(EInputAction.下降);
		default:
			return null;
		}
	}

	// Token: 0x06018D4A RID: 101706 RVA: 0x0078A19C File Offset: 0x0078839C
	private bool IsActionInputAvailable(EInputAction action)
	{
		BattleInputModel instance = BattleInputModel.Instance;
		return instance != null && instance.GetInputEnable(action) && !this.InputComponent.GetInputFilter().BlockAction(action);
	}

	// Token: 0x06018D4B RID: 101707 RVA: 0x0078A1C8 File Offset: 0x007883C8
	public void Start()
	{
		if (this.Registered || this.ObservedActions.Count == 0)
		{
			return;
		}
		foreach (EInputAction einputAction in this.ObservedActions)
		{
			if (this.IsActionInputAvailable(einputAction) && InputController.Instance.IsKeyDown(einputAction))
			{
				Dictionary<EInputAction, IInputBehaviorPressState> pressStateMap = this.PressStateMap;
				EInputAction key = einputAction;
				IInputBehaviorPressState inputBehaviorPressState = new IInputBehaviorPressState();
				inputBehaviorPressState.StartTime = this.BeginTime;
				inputBehaviorPressState.PressedInNotify = false;
				int num = this.NextPressId + 1;
				this.NextPressId = num;
				inputBehaviorPressState.PressId = num;
				pressStateMap[key] = inputBehaviorPressState;
			}
		}
		this.InputComponent.AddInputObserver(this);
		EventSystem.Instance.Add<EInputAction, bool>(EEventName.BattleInputEnableChanged, new Action<EInputAction, bool>(this.OnBattleInputEnableChanged));
		this.Registered = true;
	}

	// Token: 0x06018D4C RID: 101708 RVA: 0x0078A2AC File Offset: 0x007884AC
	public void Clear()
	{
		if (this.Registered)
		{
			this.InputComponent.RemoveInputObserver(this);
		}
		this.OnObserverCleared();
	}

	// Token: 0x06018D4D RID: 101709 RVA: 0x0078A2C8 File Offset: 0x007884C8
	public void OnObserverCleared()
	{
		if (this.Registered)
		{
			EventSystem.Instance.Remove(EEventName.BattleInputEnableChanged, new Action<EInputAction, bool>(this.OnBattleInputEnableChanged));
			this.Registered = false;
		}
		this.PressedActions.Clear();
		this.ReleaseEvents.Clear();
		this.PressStateMap.Clear();
	}

	// Token: 0x06018D4E RID: 101710 RVA: 0x0078A324 File Offset: 0x00788524
	[NullableContext(2)]
	public IInputBehaviorInputFrame ConsumeInputFrame()
	{
		foreach (EInputAction einputAction in this.ObservedActions)
		{
			if (this.PressStateMap.ContainsKey(einputAction) && (!InputController.Instance.IsKeyDown(einputAction) || !this.IsActionInputAvailable(einputAction)))
			{
				this.PressStateMap.Remove(einputAction);
			}
		}
		if (this.PressedActions.Count == 0 && this.ReleaseEvents.Count == 0 && this.PressStateMap.Count == 0)
		{
			return null;
		}
		double worldTimeSeconds = Time.Instance.WorldTimeSeconds;
		List<IInputBehaviorHoldState> list = new List<IInputBehaviorHoldState>();
		foreach (KeyValuePair<EInputAction, IInputBehaviorPressState> keyValuePair in this.PressStateMap)
		{
			list.Add(new IInputBehaviorHoldState
			{
				Action = keyValuePair.Key,
				HoldDuration = Math.Max(0.0, worldTimeSeconds - keyValuePair.Value.StartTime),
				PressedInNotify = keyValuePair.Value.PressedInNotify,
				PressId = keyValuePair.Value.PressId
			});
		}
		IInputBehaviorInputFrame inputBehaviorInputFrame = new IInputBehaviorInputFrame();
		inputBehaviorInputFrame.PressedActions = new HashSet<EInputAction>(this.PressedActions);
		inputBehaviorInputFrame.ReleaseEvents = new List<IInputBehaviorReleaseEvent>(this.ReleaseEvents);
		inputBehaviorInputFrame.HoldStates = list;
		this.PressedActions.Clear();
		this.ReleaseEvents.Clear();
		return inputBehaviorInputFrame;
	}

	// Token: 0x06018D4F RID: 101711 RVA: 0x0078A4BC File Offset: 0x007886BC
	public void OnInputPress(EInputAction action, float time)
	{
		if (!this.ObservedActions.Contains(action))
		{
			return;
		}
		this.PressedActions.Add(action);
		Dictionary<EInputAction, IInputBehaviorPressState> pressStateMap = this.PressStateMap;
		IInputBehaviorPressState inputBehaviorPressState = new IInputBehaviorPressState();
		inputBehaviorPressState.StartTime = (double)time;
		inputBehaviorPressState.PressedInNotify = true;
		int num = this.NextPressId + 1;
		this.NextPressId = num;
		inputBehaviorPressState.PressId = num;
		pressStateMap[action] = inputBehaviorPressState;
	}

	// Token: 0x06018D50 RID: 101712 RVA: 0x0078A51C File Offset: 0x0078871C
	public void OnInputRelease(EInputAction action, float time)
	{
		if (!this.ObservedActions.Contains(action))
		{
			return;
		}
		double worldTimeSeconds = Time.Instance.WorldTimeSeconds;
		this.ReleaseEvents.Add(new IInputBehaviorReleaseEvent
		{
			Action = action,
			ElapsedSinceAnsBegin = Math.Max(0.0, worldTimeSeconds - this.BeginTime)
		});
		this.PressStateMap.Remove(action);
	}

	// Token: 0x0400D780 RID: 55168
	private readonly HashSet<EInputAction> ObservedActions;

	// Token: 0x0400D781 RID: 55169
	private readonly HashSet<EInputAction> PressedActions = new HashSet<EInputAction>();

	// Token: 0x0400D782 RID: 55170
	private readonly List<IInputBehaviorReleaseEvent> ReleaseEvents = new List<IInputBehaviorReleaseEvent>();

	// Token: 0x0400D783 RID: 55171
	private readonly Dictionary<EInputAction, IInputBehaviorPressState> PressStateMap = new Dictionary<EInputAction, IInputBehaviorPressState>();

	// Token: 0x0400D784 RID: 55172
	private readonly double BeginTime;

	// Token: 0x0400D785 RID: 55173
	private readonly CharacterInputComponent InputComponent;

	// Token: 0x0400D786 RID: 55174
	private bool Registered;

	// Token: 0x0400D787 RID: 55175
	private int NextPressId;
}
