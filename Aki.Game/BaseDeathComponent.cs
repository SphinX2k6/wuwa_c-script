using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.NewWorld.Pawn.Component;
using UnrealEngine;

// Token: 0x020023C6 RID: 9158
[NullableContext(1)]
[Nullable(0)]
public class BaseDeathComponent : EntityComponent
{
	// Token: 0x06016F78 RID: 94072 RVA: 0x006B5815 File Offset: 0x006B3A15
	protected override bool OnStart()
	{
		this.MontageComponent = base.Entity.GetComponent<BaseMontageComponent>();
		this.TimeScaleComponent = base.Entity.GetComponent<PawnTimeScaleComponent>();
		this.LoadDeathMontage();
		return true;
	}

	// Token: 0x06016F79 RID: 94073 RVA: 0x006B5840 File Offset: 0x006B3A40
	public bool IsDead()
	{
		return this.IsDeadInternal;
	}

	// Token: 0x06016F7A RID: 94074 RVA: 0x006B5848 File Offset: 0x006B3A48
	public bool IsDying()
	{
		return this.IsDyingInternal;
	}

	// Token: 0x06016F7B RID: 94075 RVA: 0x006B5850 File Offset: 0x006B3A50
	public bool IsDeadOrDying()
	{
		return this.IsDeadInternal || this.IsDyingInternal;
	}

	// Token: 0x06016F7C RID: 94076 RVA: 0x006B5864 File Offset: 0x006B3A64
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
		this.IsDyingInternal = false;
		PawnTimeScaleComponent timeScaleComponent = this.TimeScaleComponent;
		if (timeScaleComponent != null)
		{
			timeScaleComponent.RemoveAllTimeScale();
		}
		return true;
	}

	// Token: 0x06016F7D RID: 94077 RVA: 0x006B5958 File Offset: 0x006B3B58
	public unsafe virtual bool ExecuteDying(long? contextId)
	{
		if (this.IsDyingInternal)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Character;
			ELogAuthor author = ELogAuthor.WWJ;
			string message = "实体重复濒死";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("entityId", base.Entity.Id);
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return false;
		}
		Log instance2 = Log.Instance;
		ELogModule module2 = ELogModule.Battle;
		ELogAuthor author2 = ELogAuthor.WWJ;
		string message2 = "[DeathComponent]执行角色濒死逻辑";
		<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("Entity", base.Entity.ToString());
		ref ValueTuple<string, object> ptr = ref <PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1);
		string item = "PbDataId";
		CreatureDataComponent component = base.Entity.GetComponent<CreatureDataComponent>();
		ptr = new ValueTuple<string, object>(item, (component != null) ? new int?(component.GetPbDataId()) : null);
		instance2.Info(module2, author2, message2, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
		this.IsDyingInternal = true;
		PawnTimeScaleComponent timeScaleComponent = this.TimeScaleComponent;
		if (timeScaleComponent != null)
		{
			timeScaleComponent.RemoveAllTimeScale();
		}
		return true;
	}

	// Token: 0x06016F7E RID: 94078 RVA: 0x006B5A43 File Offset: 0x006B3C43
	protected bool HasDeathMontage(ECharacterDeathMontageType montageType)
	{
		return this.DeathMontageMap.ContainsKey(montageType) || this.ReplaceDeathMontageMap.ContainsKey(montageType);
	}

	// Token: 0x06016F7F RID: 94079 RVA: 0x006B5A61 File Offset: 0x006B3C61
	[NullableContext(2)]
	protected virtual UAnimMontage GetDeathMontage(ECharacterDeathMontageType montageType)
	{
		return this.DeathMontageMap.GetValueOrDefault(montageType);
	}

	// Token: 0x06016F80 RID: 94080 RVA: 0x006B5A6F File Offset: 0x006B3C6F
	[NullableContext(2)]
	protected string GetDeathMontageName(ECharacterDeathMontageType montageType)
	{
		return BaseDeathComponent.DeathMontagePathMap.GetValueOrDefault(montageType);
	}

	// Token: 0x06016F81 RID: 94081 RVA: 0x006B5A7C File Offset: 0x006B3C7C
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

	// Token: 0x06016F82 RID: 94082 RVA: 0x006B5BEC File Offset: 0x006B3DEC
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

	// Token: 0x06016F83 RID: 94083 RVA: 0x006B5CEC File Offset: 0x006B3EEC
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

	// Token: 0x06016F84 RID: 94084 RVA: 0x006B5D3C File Offset: 0x006B3F3C
	public void ResetDeathMontage(int handle)
	{
		foreach (OrderedDictionary<int, string> orderedDictionary in this.ReplaceDeathMontageMap.Values)
		{
			orderedDictionary.Remove(handle);
		}
	}

	// Token: 0x06016F85 RID: 94085 RVA: 0x006B5D94 File Offset: 0x006B3F94
	public int RegisterTagDeathMontage(int tagId, string tagName, string montageName)
	{
		int num = this.TagReplaceHandleId + 1;
		this.TagReplaceHandleId = num;
		int num2 = num;
		this.TagDeathMontageConfigMap[num2] = new ValueTuple<int, string, string>(tagId, tagName, montageName);
		return num2;
	}

	// Token: 0x06016F86 RID: 94086 RVA: 0x006B5DC8 File Offset: 0x006B3FC8
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

	// Token: 0x06016F87 RID: 94087 RVA: 0x006B5FC4 File Offset: 0x006B41C4
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

	// Token: 0x06016F88 RID: 94088 RVA: 0x006B604C File Offset: 0x006B424C
	public override bool ClearComponent(EntityComponent componentTemplate)
	{
		if (!base.ClearComponent(componentTemplate))
		{
			return false;
		}
		BaseDeathComponent baseDeathComponent = (BaseDeathComponent)componentTemplate;
		this.IsDeadInternal = baseDeathComponent.IsDeadInternal;
		this.IsDyingInternal = baseDeathComponent.IsDyingInternal;
		if (baseDeathComponent.MontageComponent == null)
		{
			this.MontageComponent = null;
		}
		else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.MontageComponent), "MontageComponent"))
		{
			return false;
		}
		if (baseDeathComponent.TimeScaleComponent == null)
		{
			this.TimeScaleComponent = null;
		}
		else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.TimeScaleComponent), "TimeScaleComponent"))
		{
			return false;
		}
		if (baseDeathComponent.DeathMontageMap != null && !base.CheckClearObject(EntityComponentSystem.ClearObject(this.DeathMontageMap), "DeathMontageMap"))
		{
			return false;
		}
		this.ReplaceHandleId = baseDeathComponent.ReplaceHandleId;
		if (baseDeathComponent.ReplaceDeathMontageMap != null && !base.CheckClearObject(EntityComponentSystem.ClearObject(this.ReplaceDeathMontageMap), "ReplaceDeathMontageMap"))
		{
			return false;
		}
		if (baseDeathComponent.TagDeathMontageConfigMap != null && !base.CheckClearObject(EntityComponentSystem.ClearObject(this.TagDeathMontageConfigMap), "TagDeathMontageConfigMap"))
		{
			return false;
		}
		this.TagReplaceHandleId = baseDeathComponent.TagReplaceHandleId;
		return true;
	}

	// Token: 0x17002375 RID: 9077
	// (get) Token: 0x06016F89 RID: 94089 RVA: 0x006B6158 File Offset: 0x006B4358
	public override bool NeedStartInternal
	{
		get
		{
			return true;
		}
	}

	// Token: 0x0400C070 RID: 49264
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

	// Token: 0x0400C071 RID: 49265
	protected bool IsDeadInternal;

	// Token: 0x0400C072 RID: 49266
	protected bool IsDyingInternal;

	// Token: 0x0400C073 RID: 49267
	[Nullable(2)]
	protected BaseMontageComponent MontageComponent;

	// Token: 0x0400C074 RID: 49268
	[Nullable(2)]
	protected PawnTimeScaleComponent TimeScaleComponent;

	// Token: 0x0400C075 RID: 49269
	private readonly Dictionary<ECharacterDeathMontageType, UAnimMontage> DeathMontageMap = new Dictionary<ECharacterDeathMontageType, UAnimMontage>();

	// Token: 0x0400C076 RID: 49270
	private int ReplaceHandleId;

	// Token: 0x0400C077 RID: 49271
	private readonly Dictionary<ECharacterDeathMontageType, OrderedDictionary<int, string>> ReplaceDeathMontageMap = new Dictionary<ECharacterDeathMontageType, OrderedDictionary<int, string>>();

	// Token: 0x0400C078 RID: 49272
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

	// Token: 0x0400C079 RID: 49273
	private int TagReplaceHandleId;
}
