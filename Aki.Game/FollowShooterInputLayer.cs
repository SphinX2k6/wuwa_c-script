using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Character.Input.Blueprints;
using AkiClient.Game.Aki.Character.Input.Enum;
using AkiClient.Game.Aki.Character.Input.Structures;
using CSharpScript.Game.Input;
using CSharpScript.Game.NewWorld.Character.Common.Component.Abilities.Follow;
using UnrealEngine;

// Token: 0x020030C5 RID: 12485
[NullableContext(2)]
[Nullable(0)]
public class FollowShooterInputLayer : InputLayer
{
	// Token: 0x0601ABC5 RID: 109509 RVA: 0x00734EC0 File Offset: 0x007330C0
	[NullableContext(1)]
	public void Start(FollowShooterComponent followShooterComp)
	{
		FollowShooterInputLayer.<>c__DisplayClass6_0 CS$<>8__locals1 = new FollowShooterInputLayer.<>c__DisplayClass6_0();
		CS$<>8__locals1.<>4__this = this;
		this.FollowShooterComp = followShooterComp;
		Entity entity = followShooterComp.Entity;
		FollowShooterInputLayer.<>c__DisplayClass6_0 CS$<>8__locals2 = CS$<>8__locals1;
		CharacterActorComponent component = entity.GetComponent<CharacterActorComponent>();
		CS$<>8__locals2.actor = ((component != null) ? component.Actor : null);
		TsBaseCharacter actor = CS$<>8__locals1.actor;
		if (((actor != null) ? actor.InputComponentClass : null) != null)
		{
			ResourceSystem.Instance.LoadAsync<UClass>(CS$<>8__locals1.actor.InputComponentClass.AssetPathName.ToString(), delegate([Nullable(2)] UClass inputComponentClass, string _)
			{
				CS$<>8__locals1.<>4__this.BpInputComp = (CS$<>8__locals1.actor.AddComponentByClass(inputComponentClass, false, MathUtils.Instance.DefaultTransform, false, default(FName)) as BP_InputBase_C);
				CS$<>8__locals1.<>4__this.BpInputComp.OwnerActor = CS$<>8__locals1.actor;
			}, 100, "js_undefined");
		}
		BaseTagComponent component2 = entity.GetComponent<BaseTagComponent>();
		if (component2 == null)
		{
			return;
		}
		foreach (KeyValuePair<int, CSharpScript.Game.Input.EInputAction> keyValuePair in FollowShooterInputLayer.BlockInputTagToActionMap)
		{
			if (component2.HasTag(keyValuePair.Key))
			{
				this.BlockInputActions.Add(keyValuePair.Value);
			}
			ITagTask tagTask = component2.ListenForTagAddOrRemove(new int?(keyValuePair.Key), new BaseTagComponent.TTagSwitchedCallback(this.OnBlockInputTagChanged), null);
			if (tagTask != null)
			{
				this.BlockInputTagListeners.Add(tagTask);
			}
		}
	}

	// Token: 0x0601ABC6 RID: 109510 RVA: 0x00734FF4 File Offset: 0x007331F4
	private void OnBlockInputTagChanged(int tagId, bool tagExists)
	{
		CSharpScript.Game.Input.EInputAction item;
		if (!FollowShooterInputLayer.BlockInputTagToActionMap.TryGetValue(tagId, out item))
		{
			return;
		}
		if (tagExists)
		{
			this.BlockInputActions.Add(item);
			return;
		}
		this.BlockInputActions.Remove(item);
	}

	// Token: 0x0601ABC7 RID: 109511 RVA: 0x0073502F File Offset: 0x0073322F
	public void ClearInputActions()
	{
		this.InputActions.Clear();
	}

	// Token: 0x0601ABC8 RID: 109512 RVA: 0x0073503C File Offset: 0x0073323C
	[NullableContext(0)]
	public void RegisterInputAction(ValueTuple<AkiClient.Game.Aki.Character.Input.Enum.EInputAction, EInputState> action)
	{
		this.InputActions.Add(new ValueTuple<CSharpScript.Game.Input.EInputAction, EInputState>(action.Item1, action.Item2));
	}

	// Token: 0x0601ABC9 RID: 109513 RVA: 0x0073506D File Offset: 0x0073326D
	public override void Clear()
	{
		this.FollowShooterComp = null;
		this.BpInputComp = null;
		this.InputActions.Clear();
	}

	// Token: 0x0601ABCA RID: 109514 RVA: 0x00735088 File Offset: 0x00733288
	public override EInputLayer GetLayerType()
	{
		return EInputLayer.FollowShooter;
	}

	// Token: 0x0601ABCB RID: 109515 RVA: 0x0073508B File Offset: 0x0073328B
	public override BP_InputBase_C GetBpInputComp()
	{
		if (this.BpInputComp != null)
		{
			FollowShooterComponent followShooterComp = this.FollowShooterComp;
			if (followShooterComp != null && followShooterComp.Active)
			{
				return this.BpInputComp;
			}
		}
		return null;
	}

	// Token: 0x0601ABCC RID: 109516 RVA: 0x007350B4 File Offset: 0x007332B4
	public override SInputCommand HandlePress(CSharpScript.Game.Input.EInputAction action, float time)
	{
		if (!this.IsNeedInput(action, EInputState.Press))
		{
			return null;
		}
		SInputCommand command = null;
		switch (action)
		{
		case 4:
			command = this.BpInputComp.攻击按下(time);
			break;
		case 6:
			command = this.BpInputComp.技能1按下(time);
			break;
		case 7:
			command = this.BpInputComp.幻象1按下(time);
			break;
		case 8:
			command = this.BpInputComp.大招按下(time);
			break;
		case 9:
			command = this.BpInputComp.幻象2按下(time);
			break;
		}
		this.FollowShooterComp.ExecuteCommand(command);
		return InputLayer.GetSwallowCommand();
	}

	// Token: 0x0601ABCD RID: 109517 RVA: 0x00735154 File Offset: 0x00733354
	public override SInputCommand HandleHold(CSharpScript.Game.Input.EInputAction action, float time)
	{
		if (!this.IsNeedInput(action, EInputState.Hold))
		{
			return null;
		}
		SInputCommand command = null;
		switch (action)
		{
		case 4:
			command = this.BpInputComp.攻击长按(time);
			break;
		case 6:
			command = this.BpInputComp.技能1长按(time);
			break;
		case 7:
			command = this.BpInputComp.幻象1长按(time);
			break;
		case 8:
			command = this.BpInputComp.大招长按(time);
			break;
		case 9:
			command = this.BpInputComp.幻象2长按(time);
			break;
		}
		this.FollowShooterComp.ExecuteCommand(command);
		return InputLayer.GetSwallowCommand();
	}

	// Token: 0x0601ABCE RID: 109518 RVA: 0x007351F4 File Offset: 0x007333F4
	public override SInputCommand HandleRelease(CSharpScript.Game.Input.EInputAction action, float time)
	{
		if (!this.IsNeedInput(action, EInputState.Release))
		{
			return null;
		}
		SInputCommand command = null;
		switch (action)
		{
		case 4:
			command = this.BpInputComp.攻击抬起(time);
			break;
		case 6:
			command = this.BpInputComp.技能1抬起(time);
			break;
		case 7:
			command = this.BpInputComp.幻象1抬起(time);
			break;
		case 8:
			command = this.BpInputComp.大招抬起(time);
			break;
		case 9:
			command = this.BpInputComp.幻象2抬起(time);
			break;
		}
		this.FollowShooterComp.ExecuteCommand(command);
		return InputLayer.GetSwallowCommand();
	}

	// Token: 0x0601ABCF RID: 109519 RVA: 0x00735294 File Offset: 0x00733494
	private bool IsNeedInput(CSharpScript.Game.Input.EInputAction actionType, EInputState stateType)
	{
		if (this.BpInputComp == null)
		{
			return false;
		}
		FollowShooterComponent followShooterComp = this.FollowShooterComp;
		if (followShooterComp == null || !followShooterComp.Active)
		{
			return false;
		}
		if (this.BlockInputActions.Contains(actionType))
		{
			return false;
		}
		foreach (ValueTuple<CSharpScript.Game.Input.EInputAction, EInputState> valueTuple in this.InputActions)
		{
			CSharpScript.Game.Input.EInputAction item = valueTuple.Item1;
			EInputState item2 = valueTuple.Item2;
			if (item == actionType && item2 == stateType)
			{
				return true;
			}
		}
		return false;
	}

	// Token: 0x0601ABD1 RID: 109521 RVA: 0x00735360 File Offset: 0x00733560
	// Note: this type is marked as 'beforefieldinit'.
	static FollowShooterInputLayer()
	{
		Dictionary<int, CSharpScript.Game.Input.EInputAction> dictionary = new Dictionary<int, CSharpScript.Game.Input.EInputAction>();
		int key = GameplayTagDefine.EGameplayTagId["战斗状态.输入限制.禁止攻击"];
		dictionary[key] = CSharpScript.Game.Input.EInputAction.攻击;
		int key2 = GameplayTagDefine.EGameplayTagId["战斗状态.输入限制.禁止技能"];
		dictionary[key2] = CSharpScript.Game.Input.EInputAction.技能1;
		int key3 = GameplayTagDefine.EGameplayTagId["战斗状态.输入限制.禁止大招"];
		dictionary[key3] = CSharpScript.Game.Input.EInputAction.大招;
		int key4 = GameplayTagDefine.EGameplayTagId["战斗状态.输入限制.禁止幻象1"];
		dictionary[key4] = CSharpScript.Game.Input.EInputAction.幻象1;
		int key5 = GameplayTagDefine.EGameplayTagId["战斗状态.输入限制.禁止幻象2"];
		dictionary[key5] = CSharpScript.Game.Input.EInputAction.幻象2;
		FollowShooterInputLayer.BlockInputTagToActionMap = dictionary;
	}

	// Token: 0x0400CE6E RID: 52846
	[Nullable(1)]
	[StaticVariableRuleIgnore]
	private static readonly IReadOnlyDictionary<int, CSharpScript.Game.Input.EInputAction> BlockInputTagToActionMap;

	// Token: 0x0400CE6F RID: 52847
	private FollowShooterComponent FollowShooterComp;

	// Token: 0x0400CE70 RID: 52848
	private BP_InputBase_C BpInputComp;

	// Token: 0x0400CE71 RID: 52849
	[Nullable(new byte[]
	{
		1,
		0
	})]
	private readonly HashSet<ValueTuple<CSharpScript.Game.Input.EInputAction, EInputState>> InputActions = new HashSet<ValueTuple<CSharpScript.Game.Input.EInputAction, EInputState>>();

	// Token: 0x0400CE72 RID: 52850
	[Nullable(1)]
	private readonly List<ITagTask> BlockInputTagListeners = new List<ITagTask>();

	// Token: 0x0400CE73 RID: 52851
	[Nullable(1)]
	private readonly HashSet<CSharpScript.Game.Input.EInputAction> BlockInputActions = new HashSet<CSharpScript.Game.Input.EInputAction>();
}
