using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

// Token: 0x020024E5 RID: 9445
[NullableContext(1)]
[Nullable(0)]
public class ExecuteBulletOrBuff : PeriodExecution
{
	// Token: 0x060176B2 RID: 95922 RVA: 0x006E639E File Offset: 0x006E459E
	public ExecuteBulletOrBuff(RequireAndLimits requireAndLimits) : base(requireAndLimits)
	{
	}

	// Token: 0x060176B3 RID: 95923 RVA: 0x006E63B4 File Offset: 0x006E45B4
	protected override void InitParameters(ExtraEffectParameters parameters)
	{
		string[] extraEffectParameters_ = parameters.ExtraEffectParameters_;
		if (extraEffectParameters_ == null || extraEffectParameters_.Length < 2)
		{
			return;
		}
		this.TargetType = EExecutionTargetType.Self;
		this.GoalType = (EPassiveEffectGoalType)int.Parse(extraEffectParameters_[0]);
		string[] array = extraEffectParameters_[1].Split('#', StringSplitOptions.None);
		Converter<string, long> converter;
		if ((converter = ExecuteBulletOrBuff.<>O.<0>__Parse) == null)
		{
			converter = (ExecuteBulletOrBuff.<>O.<0>__Parse = new Converter<string, long>(long.Parse));
		}
		this.Ids = Array.ConvertAll<string, long>(array, converter);
		double[] times;
		if (extraEffectParameters_.Length <= 2 || string.IsNullOrEmpty(extraEffectParameters_[2]))
		{
			times = Array.Empty<double>();
		}
		else
		{
			string[] array2 = extraEffectParameters_[2].Split('#', StringSplitOptions.None);
			Converter<string, double> converter2;
			if ((converter2 = ExecuteBulletOrBuff.<>O.<1>__Parse) == null)
			{
				converter2 = (ExecuteBulletOrBuff.<>O.<1>__Parse = new Converter<string, double>(double.Parse));
			}
			times = Array.ConvertAll<string, double>(array2, converter2);
		}
		this.Times = times;
		this.UseCustomTimes = (extraEffectParameters_.Length > 3 && !string.IsNullOrEmpty(extraEffectParameters_[3]) && int.Parse(extraEffectParameters_[3]) == 1);
		this.BulletPosType = (EPassiveEffectTargetType)int.Parse((extraEffectParameters_.Length > 4 && !string.IsNullOrEmpty(extraEffectParameters_[4])) ? extraEffectParameters_[4] : 0.ToString());
		if (this.UseCustomTimes)
		{
			this.CustomTimesConfigs = CustomTimesConfigParser.ParseConfigs(parameters.ExtraEffectGrowParameters3, this.BuffId);
		}
	}

	// Token: 0x060176B4 RID: 95924 RVA: 0x006E64CC File Offset: 0x006E46CC
	[return: Nullable(2)]
	public override object OnExecute(params object[] args)
	{
		switch (this.GoalType)
		{
		case EPassiveEffectGoalType.Buff:
			this.ExecutePerId(new Action<long, float, IBuffComponent>(this.ProcessBuffId));
			break;
		case EPassiveEffectGoalType.Bullet:
			this.ExecutePerId(new Action<long, float, IBuffComponent>(this.ProcessBulletId));
			break;
		case EPassiveEffectGoalType.RemoveBuff:
			this.ExecutePerId(new Action<long, float, IBuffComponent>(this.ProcessBuffRemoveId));
			break;
		}
		return null;
	}

	// Token: 0x060176B5 RID: 95925 RVA: 0x006E6530 File Offset: 0x006E4730
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

	// Token: 0x060176B6 RID: 95926 RVA: 0x006E6584 File Offset: 0x006E4784
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

	// Token: 0x060176B7 RID: 95927 RVA: 0x006E65D8 File Offset: 0x006E47D8
	protected void ExecutePerId(Action<long, float, IBuffComponent> execFunction)
	{
		for (int i = 0; i < this.Ids.Length; i++)
		{
			IBuffComponent buffComponent = base.GetEffectTarget();
			PlayerBuffComponent playerBuffComponent = buffComponent as PlayerBuffComponent;
			if (playerBuffComponent != null)
			{
				buffComponent = playerBuffComponent.GetCurrentBuffComponent();
			}
			if (buffComponent != null)
			{
				float times = this.GetTimes(i);
				if (!this.UseCustomTimes || times != 0f)
				{
					execFunction(this.Ids[i], times, buffComponent);
				}
			}
		}
	}

	// Token: 0x060176B8 RID: 95928 RVA: 0x006E663C File Offset: 0x006E483C
	protected unsafe void ProcessBulletId(long id, float times, IBuffComponent target)
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
		EntityHandle instigatorEntity = base.InstigatorEntity;
		TsBaseCharacter tsBaseCharacter;
		if (instigatorEntity == null)
		{
			tsBaseCharacter = null;
		}
		else
		{
			WorldEntity entity = instigatorEntity.Entity;
			if (entity == null)
			{
				tsBaseCharacter = null;
			}
			else
			{
				CharacterActorComponent component = entity.GetComponent<CharacterActorComponent>();
				tsBaseCharacter = ((component != null) ? component.Actor : null);
			}
		}
		TsBaseCharacter tsBaseCharacter2 = tsBaseCharacter;
		if (tsBaseCharacter2 == null)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Battle;
			ELogAuthor author = ELogAuthor.ZQR;
			string message = "尝试执行添加子弹的额外效果时找不到对应的buff施加者";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("buffId", this.BuffId);
			ref ValueTuple<string, object> ptr = ref <PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1);
			string item = "持有者";
			IBuffComponent ownerBuffComponent = this.OwnerBuffComponent;
			ptr = new ValueTuple<string, object>(item, (ownerBuffComponent != null) ? ownerBuffComponent.GetDebugName() : null);
			instance.Warn(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
			return;
		}
		if (initialTransform == null)
		{
			return;
		}
		long? messageId = this.Buff.MessageId;
		int num = 0;
		while ((float)num < times)
		{
			BulletController.Instance.CreateBulletCustomTarget(tsBaseCharacter2, id.ToString(), initialTransform, new BulletController.BulletCreateParams
			{
				SyncType = EBulletSyncType.SyncCreate,
				CreateOnAuthority = false
			}, messageId, EBulletCreateSource.Others);
			num++;
		}
	}

	// Token: 0x060176B9 RID: 95929 RVA: 0x006E676C File Offset: 0x006E496C
	private void ProcessBuffId(long id, float stackNum, IBuffComponent target)
	{
		IActiveBuff buff = this.Buff;
		int? stackCount = new int?((int)stackNum);
		bool isIterable = true;
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(23, 1);
		defaultInterpolatedStringHandler.AppendLiteral("瞬间型额外效果迭代添加（前置buff Id=");
		defaultInterpolatedStringHandler.AppendFormatted<long>(this.BuffId);
		defaultInterpolatedStringHandler.AppendLiteral("）");
		target.AddIterativeBuff(id, buff, stackCount, isIterable, defaultInterpolatedStringHandler.ToStringAndClear(), null, null);
	}

	// Token: 0x060176BA RID: 95930 RVA: 0x006E67D0 File Offset: 0x006E49D0
	private void ProcessBuffRemoveId(long id, float stackNum, IBuffComponent target)
	{
		int stackCount = (int)stackNum;
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(21, 1);
		defaultInterpolatedStringHandler.AppendLiteral("瞬间型额外效果移除（前置buff Id=");
		defaultInterpolatedStringHandler.AppendFormatted<long>(this.BuffId);
		defaultInterpolatedStringHandler.AppendLiteral("）");
		string reason = defaultInterpolatedStringHandler.ToStringAndClear();
		long? preMessageId = null;
		bool? isServerRequest = null;
		IActiveBuff buff = this.Buff;
		target.RemoveBuff(id, stackCount, reason, preMessageId, isServerRequest, (buff != null) ? buff.InstigatorId : null);
	}

	// Token: 0x060176BB RID: 95931 RVA: 0x006E6848 File Offset: 0x006E4A48
	private float GetTimes(int index)
	{
		if (this.UseCustomTimes)
		{
			float? customTimes = this.GetCustomTimes();
			if (customTimes != null)
			{
				return customTimes.Value;
			}
		}
		float result;
		switch (this.GoalType)
		{
		case EPassiveEffectGoalType.Buff:
			result = (float)AbilityUtils.GetArrayValue(this.Times, index, 0.0);
			break;
		case EPassiveEffectGoalType.Bullet:
			result = (float)AbilityUtils.GetArrayValue(this.Times, index, 1.0);
			break;
		case EPassiveEffectGoalType.RemoveBuff:
			result = (float)AbilityUtils.GetArrayValue(this.Times, index, -1.0);
			break;
		default:
			result = 0f;
			break;
		}
		return result;
	}

	// Token: 0x060176BC RID: 95932 RVA: 0x006E68E4 File Offset: 0x006E4AE4
	private float? GetCustomTimes()
	{
		CustomTimesConfig customTimesConfig = Array.Find<CustomTimesConfig>(this.CustomTimesConfigs ?? Array.Empty<CustomTimesConfig>(), (CustomTimesConfig v) => v != null && v.CalcType == ECustomTimesCalcType.DependAttribute);
		if (customTimesConfig == null)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Battle;
			ELogAuthor author = ELogAuthor.GHY;
			string message = "自定义Times已开启(UseCustomTimes)，但未找到有效的依赖属性(DependAttribute)配置，将回退到默认Times";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("buffId", this.BuffId);
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return null;
		}
		BaseAttributeComponent customTimesAttributeComponent = this.GetCustomTimesAttributeComponent(customTimesConfig.ValueTarget);
		if (customTimesAttributeComponent == null)
		{
			return null;
		}
		return new float?(CustomTimesConfigParser.CalcCustomTimes(customTimesConfig, customTimesAttributeComponent));
	}

	// Token: 0x060176BD RID: 95933 RVA: 0x006E698C File Offset: 0x006E4B8C
	[NullableContext(2)]
	private BaseAttributeComponent GetCustomTimesAttributeComponent(ECustomTimesValueTarget valueTarget)
	{
		BaseAttributeComponent result;
		if (valueTarget != ECustomTimesValueTarget.Owner)
		{
			if (valueTarget != ECustomTimesValueTarget.Instigator)
			{
				result = null;
			}
			else
			{
				CharacterBuffComponent instigatorBuffComponent = base.InstigatorBuffComponent;
				result = ((instigatorBuffComponent != null) ? instigatorBuffComponent.GetAttributeComponent() : null);
			}
		}
		else
		{
			IBuffComponent ownerBuffComponent = this.OwnerBuffComponent;
			result = ((ownerBuffComponent != null) ? ownerBuffComponent.GetAttributeComponent() : null);
		}
		return result;
	}

	// Token: 0x0400C6F4 RID: 50932
	public EPassiveEffectGoalType GoalType;

	// Token: 0x0400C6F5 RID: 50933
	public long[] Ids = Array.Empty<long>();

	// Token: 0x0400C6F6 RID: 50934
	[Nullable(2)]
	public double[] Times;

	// Token: 0x0400C6F7 RID: 50935
	public bool UseCustomTimes;

	// Token: 0x0400C6F8 RID: 50936
	[Nullable(2)]
	private CustomTimesConfig[] CustomTimesConfigs;

	// Token: 0x0400C6F9 RID: 50937
	public EPassiveEffectTargetType BulletPosType;

	// Token: 0x0400C6FA RID: 50938
	private const int DEFAULT_PASSIVE_BUFF_REMOVE_TIMES = -1;

	// Token: 0x0200882E RID: 34862
	[CompilerGenerated]
	private static class <>O
	{
		// Token: 0x0402B906 RID: 178438
		[Nullable(0)]
		public static Converter<string, long> <0>__Parse;

		// Token: 0x0402B907 RID: 178439
		[Nullable(0)]
		public static Converter<string, double> <1>__Parse;
	}
}
