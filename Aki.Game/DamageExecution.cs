using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

// Token: 0x02002F89 RID: 12169
[NullableContext(1)]
[Nullable(0)]
public class DamageExecution : PeriodExecution
{
	// Token: 0x06019D8E RID: 105870 RVA: 0x006BEE18 File Offset: 0x006BD018
	public DamageExecution(RequireAndLimits requireAndLimits) : base(requireAndLimits)
	{
	}

	// Token: 0x06019D8F RID: 105871 RVA: 0x006BEE24 File Offset: 0x006BD024
	protected override void InitParameters(ExtraEffectParameters parameters)
	{
		string[] extraEffectParameters_ = parameters.ExtraEffectParameters_;
		if (extraEffectParameters_ == null)
		{
			this.DamageIdList = Array.Empty<long[]>();
			return;
		}
		this.DamageIdList = new long[extraEffectParameters_.Length][];
		for (int i = 0; i < extraEffectParameters_.Length; i++)
		{
			string[] array = extraEffectParameters_[i].Split('|', StringSplitOptions.None);
			long[] array2 = new long[array.Length];
			for (int j = 0; j < array.Length; j++)
			{
				string[] array3 = array[j].Split('#', StringSplitOptions.None);
				array2[j] = long.Parse(array3[0]);
			}
			this.DamageIdList[i] = array2;
		}
	}

	// Token: 0x06019D90 RID: 105872 RVA: 0x006BEEB0 File Offset: 0x006BD0B0
	[return: Nullable(2)]
	public unsafe override object OnExecute(params object[] args)
	{
		int stackCount = this.Buff.StackCount;
		long[] levelValue = AbilityUtils.GetLevelValue<long[]>(this.DamageIdList, stackCount, Array.Empty<long>());
		if (this.OwnerBuffComponent == null)
		{
			CombatLog instance = CombatLog.Instance;
			CombatLog.EDebugModule flag = CombatLog.EDebugModule.Buff;
			Entity ownerEntity = base.OwnerEntity;
			string message = "触发结算异常,OwnerBuffComponent为空";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
			ref ValueTuple<string, object> ptr = ref <PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0);
			string item = "handle";
			IActiveBuff buff = this.Buff;
			ptr = new ValueTuple<string, object>(item, (buff != null) ? new int?(buff.Handle) : null);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("buffId", this.BuffId);
			instance.Warn(flag, ownerEntity, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
			return null;
		}
		Entity entity = this.OwnerBuffComponent.GetEntity();
		BaseDamageComponent baseDamageComponent = (entity != null) ? entity.CheckGetComponent<BaseDamageComponent>() : null;
		BaseActorComponent actorComponent = this.OwnerBuffComponent.GetActorComponent();
		FVectorDouble? fvectorDouble = (actorComponent != null) ? new FVectorDouble?(actorComponent.ActorLocation) : null;
		EntityHandle instigatorEntity = base.InstigatorEntity;
		Entity entity2 = (instigatorEntity != null && instigatorEntity.Valid) ? base.InstigatorEntity.Entity : base.OwnerEntity;
		if (baseDamageComponent == null || fvectorDouble == null || entity2 == null || !entity2.IsInit)
		{
			CombatLog instance2 = CombatLog.Instance;
			CombatLog.EDebugModule flag2 = CombatLog.EDebugModule.Buff;
			Entity ownerEntity2 = base.OwnerEntity;
			string message2 = "结算触发异常";
			<>y__InlineArray6<ValueTuple<string, object>> <>y__InlineArray2 = default(<>y__InlineArray6<ValueTuple<string, object>>);
			ref ValueTuple<string, object> ptr2 = ref <PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray6<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 0);
			string item2 = "handle";
			IActiveBuff buff2 = this.Buff;
			ptr2 = new ValueTuple<string, object>(item2, (buff2 != null) ? new int?(buff2.Handle) : null);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray6<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 1) = new ValueTuple<string, object>("buffId", this.BuffId);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray6<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 2) = new ValueTuple<string, object>("damageComponent", baseDamageComponent == null);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray6<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 3) = new ValueTuple<string, object>("hitPosition", fvectorDouble == null);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray6<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 4) = new ValueTuple<string, object>("attacker", entity2 == null);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray6<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 5) = new ValueTuple<string, object>("IsInit", (entity2 != null) ? new bool?(entity2.IsInit) : null);
			instance2.Warn(flag2, ownerEntity2, message2, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray6<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray2, 6));
			return null;
		}
		foreach (long damageDataId in levelValue)
		{
			baseDamageComponent.ExecuteBuffDamage(new BuffDamageParam
			{
				DamageDataId = damageDataId,
				SkillLevel = this.Level,
				Attacker = entity2,
				HitPosition = fvectorDouble.Value,
				BuffId = new long?(this.BuffId)
			}, new Partial_RequirementPayload(), this.Buff.MessageId.Value);
		}
		return null;
	}

	// Token: 0x0400C330 RID: 49968
	[Nullable(new byte[]
	{
		2,
		1
	})]
	public long[][] DamageIdList;
}
