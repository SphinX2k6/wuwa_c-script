using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.NewWorld.Character.Common.Component;
using CSharpScript.Game.NewWorld.Common.Component;
using UnrealEngine;

// Token: 0x020026D5 RID: 9941
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1
})]
public class CodeAnimNotifyFoxPickUp : CodeAnimNotifyBase<SpecialSkillAnimalFox>
{
	// Token: 0x06018E59 RID: 101977 RVA: 0x00791F10 File Offset: 0x00790110
	public CodeAnimNotifyFoxPickUp(SpecialSkillAnimalFox specialSkill) : base(specialSkill)
	{
	}

	// Token: 0x06018E5A RID: 101978 RVA: 0x00791F25 File Offset: 0x00790125
	public override void OnNotify(FKuroCodeFunctionPayload payload)
	{
		this.ConsumePendingOperation(false);
	}

	// Token: 0x06018E5B RID: 101979 RVA: 0x00791F30 File Offset: 0x00790130
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

	// Token: 0x06018E5C RID: 101980 RVA: 0x00791F9C File Offset: 0x0079019C
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

	// Token: 0x06018E5D RID: 101981 RVA: 0x007920CC File Offset: 0x007902CC
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

	// Token: 0x06018E5E RID: 101982 RVA: 0x00792167 File Offset: 0x00790367
	private void EnqueueOperation(FoxPickUpOperation operation)
	{
		this.PendingOperations.Push(operation);
		this.StartOperationFallbackTimer();
	}

	// Token: 0x06018E5F RID: 101983 RVA: 0x0079217C File Offset: 0x0079037C
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

	// Token: 0x06018E60 RID: 101984 RVA: 0x007921C8 File Offset: 0x007903C8
	private void ClearOperationFallbackTimer()
	{
		if (this.OperationFallbackTimer == null)
		{
			return;
		}
		TimerSystem.FlowTimeInstance.Remove(this.OperationFallbackTimer);
		this.OperationFallbackTimer = null;
	}

	// Token: 0x06018E61 RID: 101985 RVA: 0x007921EB File Offset: 0x007903EB
	public void Clear()
	{
		this.ClearOperationFallbackTimer();
		this.PendingOperations.Clear();
		this.CurrentPickUpHandle = 0;
		this.MouthStateGeneration++;
	}

	// Token: 0x06018E62 RID: 101986 RVA: 0x00792213 File Offset: 0x00790413
	[NullableContext(2)]
	private FoxPickUpOperation GetLastPendingOperation()
	{
		if (this.PendingOperations.Empty)
		{
			return null;
		}
		return this.PendingOperations.Get(this.PendingOperations.Size - 1);
	}

	// Token: 0x06018E63 RID: 101987 RVA: 0x0079223C File Offset: 0x0079043C
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

	// Token: 0x06018E64 RID: 101988 RVA: 0x00792300 File Offset: 0x00790500
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

	// Token: 0x06018E65 RID: 101989 RVA: 0x007923F8 File Offset: 0x007905F8
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

	// Token: 0x0400D866 RID: 55398
	public const string EventName = "Fox.PickUp";

	// Token: 0x0400D867 RID: 55399
	private const int DELAY_CLOSED_MOUTH = 200;

	// Token: 0x0400D868 RID: 55400
	private const int OPERATION_FALLBACK_DELAY = 1000;

	// Token: 0x0400D869 RID: 55401
	private bool PickUpCloseMouth;

	// Token: 0x0400D86A RID: 55402
	private int MouthStateGeneration;

	// Token: 0x0400D86B RID: 55403
	private int LastOperationHandle;

	// Token: 0x0400D86C RID: 55404
	private int CurrentPickUpHandle;

	// Token: 0x0400D86D RID: 55405
	private readonly Queue<FoxPickUpOperation> PendingOperations = new Queue<FoxPickUpOperation>(4);

	// Token: 0x0400D86E RID: 55406
	[Nullable(2)]
	private TimerHandle OperationFallbackTimer;
}
