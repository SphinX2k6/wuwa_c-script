using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.NewWorld.Character.Common.Component;
using CSharpScript.Game.NewWorld.Common.Component;
using UnrealEngine;

// Token: 0x02003168 RID: 12648
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1
})]
public class CodeAnimNotifyFoxPickUp : CodeAnimNotifyBase<SpecialSkillAnimalFox>
{
	// Token: 0x0601B354 RID: 111444 RVA: 0x0076A5AC File Offset: 0x007687AC
	public CodeAnimNotifyFoxPickUp(SpecialSkillAnimalFox specialSkill) : base(specialSkill)
	{
	}

	// Token: 0x0601B355 RID: 111445 RVA: 0x0076A5C1 File Offset: 0x007687C1
	public override void OnNotify(FKuroCodeFunctionPayload payload)
	{
		this.ConsumePendingOperation(false);
	}

	// Token: 0x0601B356 RID: 111446 RVA: 0x0076A5CC File Offset: 0x007687CC
	private void ConsumePendingOperation(bool isFallback)
	{
		if (this.PendingOperations.Empty)
		{
			return;
		}
		FoxPickUpOperation foxPickUpOperation = this.PendingOperations.Pop();
		if (foxPickUpOperation == null)
		{
			return;
		}
		this.ClearOperationFallbackTimer();
		if (foxPickUpOperation.IsPickUp)
		{
			this.EquipPickUpDecoration(foxPickUpOperation.ItemId, foxPickUpOperation.KeepMouthClosed, foxPickUpOperation.PickUpHandle);
		}
		else
		{
			this.ClearPickUpDecoration(foxPickUpOperation.Handle, foxPickUpOperation.PickUpHandle);
		}
		this.StartOperationFallbackTimer();
	}

	// Token: 0x0601B357 RID: 111447 RVA: 0x0076A638 File Offset: 0x00768838
	public void RequestPickUp(int itemId, bool keepMouthClosed = false)
	{
		if (itemId == 0)
		{
			Log.Instance.Error(ELogModule.Character, ELogAuthor.CWZ, "[FoxPickUp] RequestPickUp: ItemId无效", default(ReadOnlySpan<ValueTuple<string, object>>));
			return;
		}
		Entity ownerEntity = this.SpecialSkill.GetOwnerEntity();
		BaseTagComponent component = ownerEntity.GetComponent<BaseTagComponent>();
		if (component == null)
		{
			Log.Instance.Error(ELogModule.Character, ELogAuthor.CWZ, "[FoxPickUp] RequestPickUp: BaseTagComponent缺失", default(ReadOnlySpan<ValueTuple<string, object>>));
			return;
		}
		int num = GameplayTagDefine.EGameplayTagId["幻象.声骸角色.小狐狸.状态.叼东西"];
		int num2;
		if (!component.HasTag(num))
		{
			num2 = this.LastOperationHandle + 1;
			this.LastOperationHandle = num2;
			int num3 = num2;
			this.CurrentPickUpHandle = num3;
			this.EnqueueOperation(new FoxPickUpOperation(num3, true, num3, itemId, keepMouthClosed));
			component.AddTag(new int?(num));
			return;
		}
		FoxPickUpOperation lastPendingOperation = this.GetLastPendingOperation();
		if (lastPendingOperation != null && lastPendingOperation.IsPickUp)
		{
			lastPendingOperation.ItemId = itemId;
			lastPendingOperation.KeepMouthClosed = keepMouthClosed;
			return;
		}
		CharacterOutlookComponent characterOutlookComponent = ownerEntity.GetComponent<CharacterOutlookComponent>() ?? ownerEntity.GetComponent<BaseOutlookComponent>();
		if (characterOutlookComponent != null && characterOutlookComponent.GetSpecialDecorationConfigId() == itemId && this.PickUpCloseMouth == keepMouthClosed)
		{
			return;
		}
		num2 = this.LastOperationHandle + 1;
		this.LastOperationHandle = num2;
		int num4 = num2;
		this.CurrentPickUpHandle = num4;
		this.EquipPickUpDecoration(itemId, keepMouthClosed, num4);
	}

	// Token: 0x0601B358 RID: 111448 RVA: 0x0076A768 File Offset: 0x00768968
	public void RequestPutDown()
	{
		BaseTagComponent component = this.SpecialSkill.GetOwnerEntity().GetComponent<BaseTagComponent>();
		if (component == null)
		{
			Log.Instance.Error(ELogModule.Character, ELogAuthor.CWZ, "[FoxPickUp] RequestPutDown: BaseTagComponent缺失", default(ReadOnlySpan<ValueTuple<string, object>>));
			return;
		}
		int num = GameplayTagDefine.EGameplayTagId["幻象.声骸角色.小狐狸.状态.叼东西"];
		if (!component.HasTag(num))
		{
			return;
		}
		int num2 = this.LastOperationHandle + 1;
		this.LastOperationHandle = num2;
		int handle = num2;
		this.EnqueueOperation(new FoxPickUpOperation(handle, false, this.CurrentPickUpHandle, 0, this.PickUpCloseMouth));
		this.CurrentPickUpHandle = 0;
		component.RemoveTag(new int?(num));
	}

	// Token: 0x0601B359 RID: 111449 RVA: 0x0076A803 File Offset: 0x00768A03
	private void EnqueueOperation(FoxPickUpOperation operation)
	{
		this.PendingOperations.Push(operation);
		this.StartOperationFallbackTimer();
	}

	// Token: 0x0601B35A RID: 111450 RVA: 0x0076A818 File Offset: 0x00768A18
	private void StartOperationFallbackTimer()
	{
		if (this.OperationFallbackTimer != null || this.PendingOperations.Empty)
		{
			return;
		}
		this.OperationFallbackTimer = TimerSystem.FlowTimeInstance.Delay(delegate(float _)
		{
			this.OperationFallbackTimer = null;
			this.ConsumePendingOperation(true);
		}, 1000f, null, null, true, 1f);
	}

	// Token: 0x0601B35B RID: 111451 RVA: 0x0076A864 File Offset: 0x00768A64
	private void ClearOperationFallbackTimer()
	{
		if (this.OperationFallbackTimer == null)
		{
			return;
		}
		TimerSystem.FlowTimeInstance.Remove(this.OperationFallbackTimer);
		this.OperationFallbackTimer = null;
	}

	// Token: 0x0601B35C RID: 111452 RVA: 0x0076A887 File Offset: 0x00768A87
	public void Clear()
	{
		this.ClearOperationFallbackTimer();
		this.PendingOperations.Clear();
		this.CurrentPickUpHandle = 0;
		this.MouthStateGeneration++;
	}

	// Token: 0x0601B35D RID: 111453 RVA: 0x0076A8AF File Offset: 0x00768AAF
	[NullableContext(2)]
	private FoxPickUpOperation GetLastPendingOperation()
	{
		if (this.PendingOperations.Empty)
		{
			return null;
		}
		return this.PendingOperations.Get(this.PendingOperations.Size - 1);
	}

	// Token: 0x0601B35E RID: 111454 RVA: 0x0076A8D8 File Offset: 0x00768AD8
	private unsafe void EquipPickUpDecoration(int decorationConfigId, bool keepMouthClosed, int pickUpHandle)
	{
		if (decorationConfigId == 0)
		{
			Log.Instance.Error(ELogModule.Character, ELogAuthor.CWZ, "[FoxPickUp] EquipPickUpDecoration: DecorationConfigId未设置", default(ReadOnlySpan<ValueTuple<string, object>>));
			return;
		}
		Entity ownerEntity = this.SpecialSkill.GetOwnerEntity();
		BaseOutlookComponent baseOutlookComponent = ownerEntity.GetComponent<CharacterOutlookComponent>() ?? ownerEntity.GetComponent<BaseOutlookComponent>();
		if (baseOutlookComponent == null)
		{
			return;
		}
		if (!baseOutlookComponent.SetSpecialDecoration(decorationConfigId))
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Character;
			ELogAuthor author = ELogAuthor.CWZ;
			string message = "[FoxPickUp] EquipPickUpDecoration: SetSpecialDecoration失败";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("pickUpHandle", pickUpHandle);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("decorationConfigId", decorationConfigId);
			instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
			return;
		}
		this.PickUpCloseMouth = keepMouthClosed;
		this.ChangeMouthState(false);
	}

	// Token: 0x0601B35F RID: 111455 RVA: 0x0076A99C File Offset: 0x00768B9C
	private void ChangeMouthState(bool remove)
	{
		CodeAnimNotifyFoxPickUp.<>c__DisplayClass20_0 CS$<>8__locals1 = new CodeAnimNotifyFoxPickUp.<>c__DisplayClass20_0();
		CS$<>8__locals1.<>4__this = this;
		CodeAnimNotifyFoxPickUp.<>c__DisplayClass20_0 CS$<>8__locals2 = CS$<>8__locals1;
		int num = this.MouthStateGeneration + 1;
		this.MouthStateGeneration = num;
		CS$<>8__locals2.gen = num;
		Entity ownerEntity = this.SpecialSkill.GetOwnerEntity();
		CS$<>8__locals1.tagComp = ownerEntity.GetComponent<BaseTagComponent>();
		CS$<>8__locals1.keepMouth = GameplayTagDefine.EGameplayTagId["幻象.声骸角色.小狐狸.状态.保持张嘴"];
		if (remove)
		{
			BaseTagComponent tagComp = CS$<>8__locals1.tagComp;
			if (tagComp != null && tagComp.HasTag(CS$<>8__locals1.keepMouth))
			{
				CS$<>8__locals1.tagComp.RemoveTag(new int?(CS$<>8__locals1.keepMouth));
			}
			return;
		}
		BaseTagComponent tagComp2 = CS$<>8__locals1.tagComp;
		if (tagComp2 == null || !tagComp2.HasTag(CS$<>8__locals1.keepMouth))
		{
			BaseTagComponent tagComp3 = CS$<>8__locals1.tagComp;
			if (tagComp3 != null)
			{
				tagComp3.AddTag(new int?(CS$<>8__locals1.keepMouth));
			}
		}
		if (this.PickUpCloseMouth)
		{
			TimerSystem.FlowTimeInstance.Delay(delegate(float _)
			{
				if (CS$<>8__locals1.gen != CS$<>8__locals1.<>4__this.MouthStateGeneration)
				{
					return;
				}
				BaseTagComponent tagComp4 = CS$<>8__locals1.tagComp;
				if (tagComp4 != null && tagComp4.HasTag(CS$<>8__locals1.keepMouth))
				{
					CS$<>8__locals1.tagComp.RemoveTag(new int?(CS$<>8__locals1.keepMouth));
				}
			}, 200f, null, null, true, 1f);
		}
	}

	// Token: 0x0601B360 RID: 111456 RVA: 0x0076AA94 File Offset: 0x00768C94
	private void ClearPickUpDecoration(int operationHandle, int pickUpHandle)
	{
		Entity ownerEntity = this.SpecialSkill.GetOwnerEntity();
		CharacterOutlookComponent characterOutlookComponent = ownerEntity.GetComponent<CharacterOutlookComponent>() ?? ownerEntity.GetComponent<BaseOutlookComponent>();
		if (characterOutlookComponent != null)
		{
			characterOutlookComponent.SetSpecialDecoration(0);
		}
		this.ChangeMouthState(!this.PickUpCloseMouth);
	}

	// Token: 0x0400D403 RID: 54275
	public const string EventName = "Fox.PickUp";

	// Token: 0x0400D404 RID: 54276
	private const int DELAY_CLOSED_MOUTH = 200;

	// Token: 0x0400D405 RID: 54277
	private const int OPERATION_FALLBACK_DELAY = 1000;

	// Token: 0x0400D406 RID: 54278
	private bool PickUpCloseMouth;

	// Token: 0x0400D407 RID: 54279
	private int MouthStateGeneration;

	// Token: 0x0400D408 RID: 54280
	private int LastOperationHandle;

	// Token: 0x0400D409 RID: 54281
	private int CurrentPickUpHandle;

	// Token: 0x0400D40A RID: 54282
	private readonly Queue<FoxPickUpOperation> PendingOperations = new Queue<FoxPickUpOperation>(4);

	// Token: 0x0400D40B RID: 54283
	[Nullable(2)]
	private TimerHandle OperationFallbackTimer;
}
