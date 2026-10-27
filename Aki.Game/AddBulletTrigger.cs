using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

// Token: 0x02002EF6 RID: 12022
[NullableContext(1)]
[Nullable(0)]
public class AddBulletTrigger : PassiveEffects
{
	// Token: 0x06019AF1 RID: 105201 RVA: 0x006AF3DF File Offset: 0x006AD5DF
	public AddBulletTrigger(int activeHandleId, int index, RequireAndLimits requireAndLimits, BaseBuffComponent ownerBuffComponent, [Nullable(2)] CharacterBuffComponent instigatorBuffComponent) : base(activeHandleId, index, requireAndLimits, ownerBuffComponent, instigatorBuffComponent)
	{
	}

	// Token: 0x06019AF2 RID: 105202 RVA: 0x006AF3FC File Offset: 0x006AD5FC
	protected override void InitParameters(ExtraEffectParameters parameters)
	{
		string[] extraEffectParameters_ = parameters.ExtraEffectParameters_;
		this.EventType = (EBuffTriggerType)int.Parse(extraEffectParameters_[0]);
		this.TargetType = (EPassiveEffectTargetType)int.Parse(extraEffectParameters_[1]);
		string[] array = extraEffectParameters_[2].Split('#', StringSplitOptions.None);
		this.BulletIds = new long[array.Length];
		for (int i = 0; i < array.Length; i++)
		{
			this.BulletIds[i] = long.Parse(array[i]);
		}
	}

	// Token: 0x06019AF3 RID: 105203 RVA: 0x006AF464 File Offset: 0x006AD664
	[return: Nullable(2)]
	public unsafe override object OnExecute(params object[] parameters)
	{
		IBuffComponent effectTarget = base.GetEffectTarget();
		Entity entity = (effectTarget != null) ? effectTarget.GetEntity() : null;
		FTransformDouble? ftransformDouble;
		if (entity == null)
		{
			ftransformDouble = null;
		}
		else
		{
			BaseActorComponent baseActorComponent = entity.CheckGetComponent<BaseActorComponent>();
			ftransformDouble = ((baseActorComponent != null) ? new FTransformDouble?(baseActorComponent.ActorTransform) : null);
		}
		FTransformDouble? initialTransform = ftransformDouble;
		BaseBuffComponent instigatorBuffComponent = base.InstigatorBuffComponent;
		Entity entity2;
		if (instigatorBuffComponent == null)
		{
			entity2 = null;
		}
		else
		{
			BaseActorComponent actorComponent = instigatorBuffComponent.GetActorComponent();
			entity2 = ((actorComponent != null) ? actorComponent.Entity : null);
		}
		Entity entity3 = entity2;
		IActiveBuff buff = base.Buff;
		if (entity == null || entity3 == null || initialTransform == null || buff == null)
		{
			if (buff == null && base.ActiveHandleId >= 0)
			{
				CombatLog instance = CombatLog.Instance;
				CombatLog.EDebugModule flag = CombatLog.EDebugModule.Buff;
				Entity entity4 = entity;
				string message = "AddBulletTrigger 执行时所属buff已不存在，跳过创建子弹";
				<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("handleId", base.ActiveHandleId);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("eventType", this.EventType);
				instance.Warn(flag, entity4, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
			}
			return null;
		}
		long? messageId = buff.MessageId;
		for (int i = 0; i < this.BulletIds.Length; i++)
		{
			BulletController.Instance.CreateBulletCustomTarget(entity3, this.BulletIds[i].ToString(), initialTransform, new BulletController.BulletCreateParams
			{
				SyncType = EBulletSyncType.SyncCreate,
				CreateOnAuthority = false
			}, messageId, EBulletCreateSource.Others);
		}
		return null;
	}

	// Token: 0x06019AF4 RID: 105204 RVA: 0x006AF5B4 File Offset: 0x006AD7B4
	public override string GetDebugEffectString()
	{
		return string.Empty;
	}

	// Token: 0x0400C0B1 RID: 49329
	private long[] BulletIds = Array.Empty<long>();
}
