using System;
using System.Linq;
using System.Runtime.CompilerServices;
using UnrealEngine;

// Token: 0x02002F93 RID: 12179
[NullableContext(1)]
[Nullable(0)]
public class ExecuteAddBulletByStackCount : PeriodExecution
{
	// Token: 0x06019DAF RID: 105903 RVA: 0x006C02C7 File Offset: 0x006BE4C7
	public ExecuteAddBulletByStackCount(RequireAndLimits requireAndLimits) : base(requireAndLimits)
	{
	}

	// Token: 0x06019DB0 RID: 105904 RVA: 0x006C02D0 File Offset: 0x006BE4D0
	protected override void InitParameters(ExtraEffectParameters parameters)
	{
		this.TargetType = EExecutionTargetType.Self;
		string[] extraEffectParameters_ = parameters.ExtraEffectParameters_;
		if (extraEffectParameters_ == null || extraEffectParameters_.Length == 0)
		{
			this.Ids = Array.Empty<string[]>();
			this.BulletPosType = EPassiveEffectTargetType.ForSelf;
			return;
		}
		this.BulletPosType = (EPassiveEffectTargetType)int.Parse(extraEffectParameters_[0]);
		this.Ids = new string[Math.Max(0, extraEffectParameters_.Length - 1)][];
		for (int i = 1; i < extraEffectParameters_.Length; i++)
		{
			this.Ids[i - 1] = (from v in extraEffectParameters_[i].Split('#', StringSplitOptions.None)
			select v.Trim()).ToArray<string>();
		}
	}

	// Token: 0x06019DB1 RID: 105905 RVA: 0x006C0378 File Offset: 0x006BE578
	[return: Nullable(2)]
	public unsafe override object OnExecute(params object[] args)
	{
		int stackCount = this.Buff.StackCount;
		string[] levelValue = AbilityUtils.GetLevelValue<string[]>(this.Ids, stackCount, Array.Empty<string>());
		IBuffComponent bulletTarget = this.GetBulletTarget();
		FTransformDouble? ftransformDouble;
		if (bulletTarget == null)
		{
			ftransformDouble = null;
		}
		else
		{
			BaseActorComponent actorComponent = bulletTarget.GetActorComponent();
			ftransformDouble = ((actorComponent != null) ? new FTransformDouble?(actorComponent.ActorTransform) : null);
		}
		FTransformDouble? initialTransform = ftransformDouble;
		CharacterBuffComponent instigatorBuffComponent = base.InstigatorBuffComponent;
		Entity entity;
		if (instigatorBuffComponent == null)
		{
			entity = null;
		}
		else
		{
			BaseActorComponent actorComponent2 = instigatorBuffComponent.GetActorComponent();
			entity = ((actorComponent2 != null) ? actorComponent2.Entity : null);
		}
		Entity entity2 = entity;
		if (entity2 == null || initialTransform == null)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Battle;
			ELogAuthor author = ELogAuthor.ZQR;
			string message = "尝试执行添加子弹的额外效果时找不到对应的buff施加者或接收者";
			<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray3<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("buffId", this.BuffId);
			ref ValueTuple<string, object> ptr = ref <PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1);
			string item = "持有者";
			IActiveBuff buff = this.Buff;
			ptr = new ValueTuple<string, object>(item, (buff != null) ? buff.GetOwnerDebugName() : null);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("施加者", this.Buff.InstigatorId);
			instance.Warn(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 3));
			return null;
		}
		long? messageId = this.Buff.MessageId;
		foreach (string bulletRowName in levelValue)
		{
			BulletController.Instance.CreateBulletCustomTarget(entity2, bulletRowName, initialTransform, new BulletController.BulletCreateParams
			{
				SyncType = EBulletSyncType.SyncCreate,
				CreateOnAuthority = false
			}, messageId, EBulletCreateSource.Others);
		}
		return null;
	}

	// Token: 0x06019DB2 RID: 105906 RVA: 0x006C04F0 File Offset: 0x006BE6F0
	[NullableContext(2)]
	protected IBuffComponent GetBulletTarget()
	{
		IBuffComponent result;
		switch (this.BulletPosType)
		{
		case EPassiveEffectTargetType.ForSelf:
			result = this.OwnerBuffComponent;
			break;
		case EPassiveEffectTargetType.ForTarget:
			result = base.OpponentBuffComponent;
			break;
		case EPassiveEffectTargetType.ForBuffInstigator:
			result = base.InstigatorBuffComponent;
			break;
		case EPassiveEffectTargetType.ForBuffHolderTarget:
			result = this.GetBuffHolderSkillTarget();
			break;
		default:
			result = null;
			break;
		}
		return result;
	}

	// Token: 0x06019DB3 RID: 105907 RVA: 0x006C0544 File Offset: 0x006BE744
	[NullableContext(2)]
	protected IBuffComponent GetBuffHolderSkillTarget()
	{
		IBuffComponent ownerBuffComponent = this.OwnerBuffComponent;
		EntityHandle entityHandle;
		if (ownerBuffComponent == null)
		{
			entityHandle = null;
		}
		else
		{
			Entity entity = ownerBuffComponent.GetEntity();
			if (entity == null)
			{
				entityHandle = null;
			}
			else
			{
				CharacterSkillComponent characterSkillComponent = entity.CheckGetComponent<CharacterSkillComponent>();
				entityHandle = ((characterSkillComponent != null) ? characterSkillComponent.SkillTarget : null);
			}
		}
		EntityHandle entityHandle2 = entityHandle;
		if (entityHandle2 == null)
		{
			return this.OwnerBuffComponent;
		}
		WorldEntity entity2 = entityHandle2.Entity;
		if (entity2 == null)
		{
			return null;
		}
		return entity2.CheckGetComponent<BaseBuffComponent>();
	}

	// Token: 0x0400C353 RID: 50003
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	public string[][] Ids;

	// Token: 0x0400C354 RID: 50004
	public EPassiveEffectTargetType BulletPosType;
}
