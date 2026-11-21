using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

// Token: 0x020024E8 RID: 9448
[NullableContext(1)]
[Nullable(0)]
public class ExecuteAddBulletByTagStackCount : PeriodExecution
{
	// Token: 0x060176C6 RID: 95942 RVA: 0x006E6E5F File Offset: 0x006E505F
	public ExecuteAddBulletByTagStackCount(RequireAndLimits requireAndLimits) : base(requireAndLimits)
	{
	}

	// Token: 0x060176C7 RID: 95943 RVA: 0x006E6E68 File Offset: 0x006E5068
	protected unsafe override void InitParameters(ExtraEffectParameters parameters)
	{
		this.TargetType = EExecutionTargetType.Self;
		string[] extraEffectParameters_ = parameters.ExtraEffectParameters_;
		if (extraEffectParameters_ == null || extraEffectParameters_.Length < 2)
		{
			return;
		}
		this.BulletPosType = (EPassiveEffectTargetType)int.Parse(extraEffectParameters_[0]);
		this.TagIdGetStackCount = GameplayTagUtils.GetTagIdByName(extraEffectParameters_[1]);
		int num = extraEffectParameters_.Length - 2;
		if (num <= 0)
		{
			this.BulletCreateInfos = Array.Empty<string[]>();
			return;
		}
		this.BulletCreateInfos = new string[num][];
		for (int i = 2; i < extraEffectParameters_.Length; i++)
		{
			string[] array = extraEffectParameters_[i].Split('#', StringSplitOptions.None);
			string[] array2 = new string[array.Length];
			for (int j = 0; j < array.Length; j++)
			{
				array2[j] = array[j].Trim();
			}
			if (array2.Length < 3)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.BuffItem;
				ELogAuthor author = ELogAuthor.HCW;
				string message = "ExecuteAddBulletByTagStackCount的参数个数错误";
				<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("BuffId", this.BuffId);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("参数", extraEffectParameters_);
				instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
			}
			else
			{
				this.BulletCreateInfos[i - 2] = array2;
			}
		}
	}

	// Token: 0x060176C8 RID: 95944 RVA: 0x006E6F8C File Offset: 0x006E518C
	[return: Nullable(2)]
	public unsafe override object OnExecute(params object[] args)
	{
		Entity ownerEntity = base.OwnerEntity;
		BaseTagComponent baseTagComponent = (ownerEntity != null) ? ownerEntity.GetComponent<BaseTagComponent>() : null;
		int? num = (baseTagComponent != null) ? new int?(baseTagComponent.GetTagCount(this.TagIdGetStackCount)) : null;
		if (num != null)
		{
			int? num2 = num;
			int i = 0;
			if (!(num2.GetValueOrDefault() <= i & num2 != null))
			{
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
				if (initialTransform == null || this.BulletCreateInfos == null)
				{
					Log instance = Log.Instance;
					ELogModule module = ELogModule.BuffItem;
					ELogAuthor author = ELogAuthor.HCW;
					string message = "ExecuteAddBulletByTagStackCount尝试执行添加子弹的额外效果时找不到对应的buff施加者或接收者";
					<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray3<ValueTuple<string, object>>);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("BuffId", this.BuffId);
					ref ValueTuple<string, object> ptr = ref <PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1);
					string item = "持有者";
					IActiveBuff buff = this.Buff;
					ptr = new ValueTuple<string, object>(item, (buff != null) ? buff.GetOwnerDebugName() : null);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("BulletCreateInfos", this.BulletCreateInfos);
					instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 3));
					return null;
				}
				long? messageId = this.Buff.MessageId;
				foreach (string[] array in this.BulletCreateInfos)
				{
					float stackCountNeed = float.Parse(array[0]);
					string @operator = array[1];
					if (this.CompareStackCount(@operator, (float)num.Value, stackCountNeed))
					{
						for (int j = 2; j < array.Length; j++)
						{
							string bulletRowName = array[j];
							BulletController.Instance.CreateBulletCustomTarget(base.OwnerEntity, bulletRowName, initialTransform, new BulletController.BulletCreateParams
							{
								SyncType = EBulletSyncType.SyncCreate,
								CreateOnAuthority = false
							}, messageId, EBulletCreateSource.Others);
						}
					}
				}
				return null;
			}
		}
		return null;
	}

	// Token: 0x060176C9 RID: 95945 RVA: 0x006E7164 File Offset: 0x006E5364
	protected unsafe bool CompareStackCount(string @operator, float stackCountByOwner, float stackCountNeed)
	{
		if (@operator == ">")
		{
			return stackCountByOwner > stackCountNeed;
		}
		if (@operator == ">=")
		{
			return stackCountByOwner >= stackCountNeed;
		}
		if (@operator == "<")
		{
			return stackCountByOwner < stackCountNeed;
		}
		if (@operator == "<=")
		{
			return stackCountByOwner <= stackCountNeed;
		}
		if (@operator == "==")
		{
			return stackCountByOwner == stackCountNeed;
		}
		if (!(@operator == "!="))
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.BuffItem;
			ELogAuthor author = ELogAuthor.HCW;
			string message = "ExecuteAddBulletByTagStackCount的比较运算符错误";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("buffId", this.BuffId);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("operator", @operator);
			instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
			return false;
		}
		return stackCountByOwner != stackCountNeed;
	}

	// Token: 0x060176CA RID: 95946 RVA: 0x006E7248 File Offset: 0x006E5448
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

	// Token: 0x060176CB RID: 95947 RVA: 0x006E729C File Offset: 0x006E549C
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

	// Token: 0x0400C6FE RID: 50942
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	public string[][] BulletCreateInfos;

	// Token: 0x0400C6FF RID: 50943
	public EPassiveEffectTargetType BulletPosType;

	// Token: 0x0400C700 RID: 50944
	public int TagIdGetStackCount;
}
