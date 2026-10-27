using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.NewWorld.Pawn.Component;
using UnrealEngine;

// Token: 0x02002E74 RID: 11892
[NullableContext(1)]
[Nullable(0)]
public class BaseDeathComponent : EntityComponent
{
	// Token: 0x060196AF RID: 104111 RVA: 0x0068F45D File Offset: 0x0068D65D
	protected override bool OnStart()
	{
		this.MontageComponent = base.Entity.GetComponent<BaseMontageComponent>();
		this.TimeScaleComponent = base.Entity.GetComponent<PawnTimeScaleComponent>();
		this.LoadDeathMontage();
		return true;
	}

	// Token: 0x060196B0 RID: 104112 RVA: 0x0068F488 File Offset: 0x0068D688
	public bool IsDead()
	{
		return this.IsDeadInternal;
	}

	// Token: 0x060196B1 RID: 104113 RVA: 0x0068F490 File Offset: 0x0068D690
	public unsafe virtual bool ExecuteDeath(long? contextId)
	{
		if (this.IsDeadInternal)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Character;
			ELogAuthor author = ELogAuthor.ZQR;
			string message = "实体重复死亡";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("entityId", base.Entity.Id);
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return false;
		}
		Log instance2 = Log.Instance;
		ELogModule module2 = ELogModule.Battle;
		ELogAuthor author2 = ELogAuthor.ZQR;
		string message2 = "[DeathComponent]执行角色死亡逻辑";
		<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("Entity", base.Entity.ToString());
		ref ValueTuple<string, object> ptr = ref <PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1);
		string item = "PbDataId";
		CreatureDataComponent component = base.Entity.GetComponent<CreatureDataComponent>();
		ptr = new ValueTuple<string, object>(item, (component != null) ? new int?(component.GetPbDataId()) : null);
		instance2.Info(module2, author2, message2, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
		this.IsDeadInternal = true;
		PawnTimeScaleComponent timeScaleComponent = this.TimeScaleComponent;
		if (timeScaleComponent != null)
		{
			timeScaleComponent.RemoveAllTimeScale();
		}
		return true;
	}

	// Token: 0x060196B2 RID: 104114 RVA: 0x0068F57B File Offset: 0x0068D77B
	protected bool HasDeathMontage(ECharacterDeathMontageType montageType)
	{
		return this.DeathMontageMap.ContainsKey(montageType) || this.ReplaceDeathMontageMap.ContainsKey(montageType);
	}

	// Token: 0x060196B3 RID: 104115 RVA: 0x0068F599 File Offset: 0x0068D799
	[NullableContext(2)]
	protected virtual UAnimMontage GetDeathMontage(ECharacterDeathMontageType montageType)
	{
		return this.DeathMontageMap.GetValueOrDefault(montageType);
	}

	// Token: 0x060196B4 RID: 104116 RVA: 0x0068F5A7 File Offset: 0x0068D7A7
	[NullableContext(2)]
	protected string GetDeathMontageName(ECharacterDeathMontageType montageType)
	{
		return BaseDeathComponent.DeathMontagePathMap.GetValueOrDefault(montageType);
	}

	// Token: 0x060196B5 RID: 104117 RVA: 0x0068F5B4 File Offset: 0x0068D7B4
	[NullableContext(2)]
	protected unsafe void PlayDeathMontageWithType(ECharacterDeathMontageType montageType, Action<bool> endCallback = null, long? contextId = null, bool? forceDisableAnimOptimization = null)
	{
		int? num = null;
		OrderedDictionary<int, string> orderedDictionary;
		if (this.ReplaceDeathMontageMap.TryGetValue(montageType, out orderedDictionary) && orderedDictionary.Count > 0)
		{
			if (orderedDictionary.Count > 0)
			{
				string value = orderedDictionary.GetAt(orderedDictionary.Count - 1).Value;
				if (!string.IsNullOrEmpty(value))
				{
					BaseMontageComponent montageComponent = this.MontageComponent;
					num = ((montageComponent != null) ? montageComponent.CreateTaskWithName(value, null, endCallback, -1f) : null);
				}
			}
		}
		else
		{
			UAnimMontage deathMontage = this.GetDeathMontage(montageType);
			if (deathMontage != null)
			{
				BaseMontageComponent montageComponent2 = this.MontageComponent;
				num = ((montageComponent2 != null) ? montageComponent2.CreateTaskWithMontage(deathMontage, null, endCallback, -1f) : null);
			}
		}
		if (num == null)
		{
			string item = BaseDeathComponent.DeathMontagePathMap[montageType];
			CombatLog instance = CombatLog.Instance;
			CombatLog.EDebugModule flag = CombatLog.EDebugModule.Animation;
			Entity entity = base.Entity;
			string message = "蒙太奇播放失败";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("montageType", montageType);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("path", item);
			instance.Warn(flag, entity, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
			if (endCallback != null)
			{
				endCallback(true);
			}
			return;
		}
		if (forceDisableAnimOptimization.GetValueOrDefault())
		{
			BaseAnimationComponent component = base.Entity.GetComponent<BaseAnimationComponent>();
			if (component != null)
			{
				component.StartForceDisableAnimOptimization(EForceDisableAnimOptimization.Death, false);
			}
		}
		BaseMontageComponent montageComponent3 = this.MontageComponent;
		if (montageComponent3 == null)
		{
			return;
		}
		montageComponent3.PlayMontageTaskWhenReady(num.Value, 0f, contextId, -1f);
	}

	// Token: 0x060196B6 RID: 104118 RVA: 0x0068F724 File Offset: 0x0068D924
	[NullableContext(2)]
	protected bool TryPlayDeathMontageWithTag(Action<bool> endCallback = null, long? contextId = null, bool? forceDisableAnimOptimization = null)
	{
		int? num = null;
		BaseTagComponent component = base.Entity.GetComponent<BaseTagComponent>();
		if (component != null && this.TagDeathMontageConfigMap.Count > 0)
		{
			foreach (ValueTuple<int, string, string> valueTuple in this.TagDeathMontageConfigMap.Values)
			{
				if (component.HasTag(valueTuple.Item1))
				{
					BaseMontageComponent montageComponent = this.MontageComponent;
					num = ((montageComponent != null) ? montageComponent.CreateTaskWithName(valueTuple.Item3, null, endCallback, -1f) : null);
					break;
				}
			}
		}
		if (num != null)
		{
			if (forceDisableAnimOptimization.GetValueOrDefault())
			{
				BaseAnimationComponent component2 = base.Entity.GetComponent<BaseAnimationComponent>();
				if (component2 != null)
				{
					component2.StartForceDisableAnimOptimization(EForceDisableAnimOptimization.Death, false);
				}
			}
			BaseMontageComponent montageComponent2 = this.MontageComponent;
			if (montageComponent2 != null)
			{
				montageComponent2.PlayMontageTaskWhenReady(num.Value, 0f, contextId, -1f);
			}
			return true;
		}
		return false;
	}

	// Token: 0x060196B7 RID: 104119 RVA: 0x0068F824 File Offset: 0x0068DA24
	public int ReplaceDeathMontage(ECharacterDeathMontageType montageType, string montageName)
	{
		OrderedDictionary<int, string> orderedDictionary;
		if (!this.ReplaceDeathMontageMap.TryGetValue(montageType, out orderedDictionary))
		{
			orderedDictionary = (this.ReplaceDeathMontageMap[montageType] = new OrderedDictionary<int, string>());
		}
		OrderedDictionary<int, string> orderedDictionary2 = orderedDictionary;
		int num = this.ReplaceHandleId + 1;
		this.ReplaceHandleId = num;
		orderedDictionary2.TryAdd(num, montageName);
		return this.ReplaceHandleId;
	}

	// Token: 0x060196B8 RID: 104120 RVA: 0x0068F874 File Offset: 0x0068DA74
	public void ResetDeathMontage(int handle)
	{
		foreach (OrderedDictionary<int, string> orderedDictionary in this.ReplaceDeathMontageMap.Values)
		{
			orderedDictionary.Remove(handle);
		}
	}

	// Token: 0x060196B9 RID: 104121 RVA: 0x0068F8CC File Offset: 0x0068DACC
	public int RegisterTagDeathMontage(int tagId, string tagName, string montageName)
	{
		int num = this.TagReplaceHandleId + 1;
		this.TagReplaceHandleId = num;
		int num2 = num;
		this.TagDeathMontageConfigMap[num2] = new ValueTuple<int, string, string>(tagId, tagName, montageName);
		return num2;
	}

	// Token: 0x060196BA RID: 104122 RVA: 0x0068F900 File Offset: 0x0068DB00
	public unsafe void UnregisterTagDeathMontage(int tagId, string montageName)
	{
		int? num = null;
		foreach (KeyValuePair<int, ValueTuple<int, string, string>> keyValuePair in this.TagDeathMontageConfigMap)
		{
			ValueTuple<int, string, string> value = keyValuePair.Value;
			if (value.Item1 == tagId && value.Item3 == montageName)
			{
				num = new int?(keyValuePair.Key);
				break;
			}
		}
		if (num != null)
		{
			this.TagDeathMontageConfigMap.Remove(num.Value);
		}
		if (this.TagDeathMontageConfigMap.Count > 0)
		{
			CombatLog instance = CombatLog.Instance;
			CombatLog.EDebugModule flag = CombatLog.EDebugModule.StateMachineNew;
			Entity entity = base.Entity;
			string message = "[DeathComponent]标签蒙太奇配置Map未正确清空,可能同时激活了多个状态机BindState:替换死亡动画_Tag";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("剩余数量", this.TagDeathMontageConfigMap.Count);
			instance.Error(flag, entity, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			int num2 = 0;
			foreach (ValueTuple<int, string, string> valueTuple2 in this.TagDeathMontageConfigMap.Values)
			{
				num2++;
				CombatLog instance2 = CombatLog.Instance;
				CombatLog.EDebugModule flag2 = CombatLog.EDebugModule.StateMachineNew;
				Entity entity2 = base.Entity;
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(6, 1);
				defaultInterpolatedStringHandler.AppendLiteral("[剩余配置");
				defaultInterpolatedStringHandler.AppendFormatted<int>(num2);
				defaultInterpolatedStringHandler.AppendLiteral("]");
				string message2 = defaultInterpolatedStringHandler.ToStringAndClear();
				<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray3<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("TagId", valueTuple2.Item1);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("TagName", valueTuple2.Item2);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("MontageName", valueTuple2.Item3);
				instance2.Error(flag2, entity2, message2, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 3));
			}
			this.TagDeathMontageConfigMap.Clear();
		}
	}

	// Token: 0x060196BB RID: 104123 RVA: 0x0068FAFC File Offset: 0x0068DCFC
	private void LoadDeathMontage()
	{
		foreach (KeyValuePair<ECharacterDeathMontageType, string> keyValuePair in BaseDeathComponent.DeathMontagePathMap)
		{
			ECharacterDeathMontageType echaracterDeathMontageType;
			string text;
			keyValuePair.Deconstruct(out echaracterDeathMontageType, out text);
			ECharacterDeathMontageType key = echaracterDeathMontageType;
			string name = text;
			BaseMontageComponent montageComponent = this.MontageComponent;
			UAnimMontage uanimMontage = (montageComponent != null) ? montageComponent.GetMontageByName(name, true, false) : null;
			if (uanimMontage != null)
			{
				this.DeathMontageMap[key] = uanimMontage;
			}
		}
	}

	// Token: 0x060196BC RID: 104124 RVA: 0x0068FB84 File Offset: 0x0068DD84
	public override bool ClearComponent(EntityComponent componentTemplate)
	{
		if (!base.ClearComponent(componentTemplate))
		{
			return false;
		}
		BaseDeathComponent baseDeathComponent = (BaseDeathComponent)componentTemplate;
		if (base.CanResetComponentProperty("IsDeadInternal"))
		{
			this.IsDeadInternal = baseDeathComponent.IsDeadInternal;
		}
		if (base.CanResetComponentProperty("MontageComponent"))
		{
			if (baseDeathComponent.MontageComponent == null)
			{
				this.MontageComponent = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<BaseMontageComponent>(this.MontageComponent), "MontageComponent"))
			{
				return false;
			}
		}
		if (base.CanResetComponentProperty("TimeScaleComponent"))
		{
			if (baseDeathComponent.TimeScaleComponent == null)
			{
				this.TimeScaleComponent = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<PawnTimeScaleComponent>(this.TimeScaleComponent), "TimeScaleComponent"))
			{
				return false;
			}
		}
		if (base.CanResetComponentProperty("DeathMontageMap") && baseDeathComponent.DeathMontageMap != null && !base.CheckClearObject(EntityComponentSystem.ClearObject<Dictionary<ECharacterDeathMontageType, UAnimMontage>>(this.DeathMontageMap), "DeathMontageMap"))
		{
			return false;
		}
		if (base.CanResetComponentProperty("ReplaceHandleId"))
		{
			this.ReplaceHandleId = baseDeathComponent.ReplaceHandleId;
		}
		if (base.CanResetComponentProperty("ReplaceDeathMontageMap") && baseDeathComponent.ReplaceDeathMontageMap != null && !base.CheckClearObject(EntityComponentSystem.ClearObject<Dictionary<ECharacterDeathMontageType, OrderedDictionary<int, string>>>(this.ReplaceDeathMontageMap), "ReplaceDeathMontageMap"))
		{
			return false;
		}
		if (base.CanResetComponentProperty("TagDeathMontageConfigMap") && baseDeathComponent.TagDeathMontageConfigMap != null && !base.CheckClearObject(EntityComponentSystem.ClearObject<OrderedDictionary<int, ValueTuple<int, string, string>>>(this.TagDeathMontageConfigMap), "TagDeathMontageConfigMap"))
		{
			return false;
		}
		if (base.CanResetComponentProperty("TagReplaceHandleId"))
		{
			this.TagReplaceHandleId = baseDeathComponent.TagReplaceHandleId;
		}
		return true;
	}

	// Token: 0x0400BCDB RID: 48347
	[StaticVariableRuleIgnore]
	private static readonly Dictionary<ECharacterDeathMontageType, string> DeathMontagePathMap = new Dictionary<ECharacterDeathMontageType, string>
	{
		{
			ECharacterDeathMontageType.Die,
			"AM_Death"
		},
		{
			ECharacterDeathMontageType.DieInWater,
			"AM_Death_InWater"
		},
		{
			ECharacterDeathMontageType.DieInAir,
			"AM_Death_InAir"
		},
		{
			ECharacterDeathMontageType.DieFalling,
			"AM_Death_Falling"
		}
	};

	// Token: 0x0400BCDC RID: 48348
	protected bool IsDeadInternal;

	// Token: 0x0400BCDD RID: 48349
	[Nullable(2)]
	protected BaseMontageComponent MontageComponent;

	// Token: 0x0400BCDE RID: 48350
	[Nullable(2)]
	protected PawnTimeScaleComponent TimeScaleComponent;

	// Token: 0x0400BCDF RID: 48351
	private readonly Dictionary<ECharacterDeathMontageType, UAnimMontage> DeathMontageMap = new Dictionary<ECharacterDeathMontageType, UAnimMontage>();

	// Token: 0x0400BCE0 RID: 48352
	private int ReplaceHandleId;

	// Token: 0x0400BCE1 RID: 48353
	private readonly Dictionary<ECharacterDeathMontageType, OrderedDictionary<int, string>> ReplaceDeathMontageMap = new Dictionary<ECharacterDeathMontageType, OrderedDictionary<int, string>>();

	// Token: 0x0400BCE2 RID: 48354
	[TupleElementNames(new string[]
	{
		"TagId",
		"TagName",
		"MontageName"
	})]
	[Nullable(new byte[]
	{
		1,
		0,
		1,
		1
	})]
	private readonly OrderedDictionary<int, ValueTuple<int, string, string>> TagDeathMontageConfigMap = new OrderedDictionary<int, ValueTuple<int, string, string>>();

	// Token: 0x0400BCE3 RID: 48355
	private int TagReplaceHandleId;
}
