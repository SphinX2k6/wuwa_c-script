using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;

// Token: 0x020024D3 RID: 9427
[NullableContext(1)]
[Nullable(0)]
public class ModifySquadProp : BuffEffect
{
	// Token: 0x0601764C RID: 95820 RVA: 0x006E346C File Offset: 0x006E166C
	public ModifySquadProp(int activeHandleId, int index, RequireAndLimits requireAndLimits, BaseBuffComponent ownerBuffComponent, [Nullable(2)] CharacterBuffComponent instigatorBuffComponent) : base(activeHandleId, index, requireAndLimits, ownerBuffComponent, instigatorBuffComponent)
	{
	}

	// Token: 0x0601764D RID: 95821 RVA: 0x006E3491 File Offset: 0x006E1691
	protected bool HasBuffAuthority()
	{
		IBuffComponent ownerBuffComponent = this.OwnerBuffComponent;
		return ownerBuffComponent != null && ownerBuffComponent.HasBuffAuthority();
	}

	// Token: 0x0601764E RID: 95822 RVA: 0x006E34A4 File Offset: 0x006E16A4
	protected override void InitParameters(ExtraEffectParameters parameters)
	{
		string[] extraEffectParameters_ = parameters.ExtraEffectParameters_;
		if (extraEffectParameters_ == null || extraEffectParameters_.Length < 2)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Battle;
			ELogAuthor author = ELogAuthor.GHY;
			string message = "ModifySquadProp 参数不足（至少需要 param0/param1）";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("buffId", this.BuffId);
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return;
		}
		this.AttributeId = ModifySquadProp.ParseIntOr(extraEffectParameters_, 0, 0);
		this.ModifyType = (EModifyType)ModifySquadProp.ParseIntOr(extraEffectParameters_, 1, 0);
		this.RefAttributeId = ModifySquadProp.ParseIntOr(extraEffectParameters_, 2, 0);
		this.RefSource = (ERefSource)ModifySquadProp.ParseIntOr(extraEffectParameters_, 3, 0);
		this.RefCalcType = (ERefCalcType)ModifySquadProp.ParseIntOr(extraEffectParameters_, 4, 0);
		this.RefPropSystem = (EPropSystemType)ModifySquadProp.ParseIntOr(extraEffectParameters_, 5, 0);
		this.ParseTransformRule((extraEffectParameters_.Length > 6) ? extraEffectParameters_[6] : null);
		this.PropSystem = (EPropSystemType)ModifySquadProp.ParseIntOr(extraEffectParameters_, 7, 0);
		this.Magnitude = AbilityUtils.GetLevelValue<float>(parameters.ExtraEffectGrowParameters1, this.Level, 0f);
		this.Magnitude2 = AbilityUtils.GetLevelValue<float>(parameters.ExtraEffectGrowParameters2, this.Level, 0f);
	}

	// Token: 0x0601764F RID: 95823 RVA: 0x006E359F File Offset: 0x006E179F
	private static int ParseIntOr(string[] baseParams, int index, int defaultValue)
	{
		if (index < baseParams.Length && !string.IsNullOrEmpty(baseParams[index]))
		{
			return int.Parse(baseParams[index]);
		}
		return defaultValue;
	}

	// Token: 0x06017650 RID: 95824 RVA: 0x006E35BC File Offset: 0x006E17BC
	[NullableContext(2)]
	protected void ParseTransformRule(string rule)
	{
		if (string.IsNullOrEmpty(rule))
		{
			return;
		}
		ModifySquadProp.<>c__DisplayClass18_0 CS$<>8__locals1;
		CS$<>8__locals1.segments = rule.Split('#', StringSplitOptions.None);
		this.TransformRuleData = new TransformRule
		{
			LowerLimit = ModifySquadProp.<ParseTransformRule>g__ParseNum|18_0(0, ref CS$<>8__locals1),
			Ratio = ModifySquadProp.<ParseTransformRule>g__ParseNum|18_0(1, ref CS$<>8__locals1),
			UpperLimit = ModifySquadProp.<ParseTransformRule>g__ParseNum|18_0(2, ref CS$<>8__locals1),
			IsFloor = ((3 < CS$<>8__locals1.segments.Length && !string.IsNullOrEmpty(CS$<>8__locals1.segments[3])) ? new bool?(int.Parse(CS$<>8__locals1.segments[3]) == 1) : null)
		};
	}

	// Token: 0x06017651 RID: 95825 RVA: 0x006E3658 File Offset: 0x006E1858
	public override void OnCreated()
	{
		if (!this.HasBuffAuthority())
		{
			return;
		}
		SceneTeamModel instance = SceneTeamModel.Instance;
		if (instance != null && instance.IsTeamReady)
		{
			this.SnapshotAndApply();
			return;
		}
		EventSystem.Instance.Add(EEventName.OnUpdateSceneTeam, new Action(this.OnTeamReady));
		this.ListeningTeamReady = true;
		Log instance2 = Log.Instance;
		ELogModule module = ELogModule.Battle;
		ELogAuthor author = ELogAuthor.GHY;
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(47, 1);
		defaultInterpolatedStringHandler.AppendLiteral("[SquadProp] OnCreated 编队未就绪，注册监听等待就绪后施加 buffId=");
		defaultInterpolatedStringHandler.AppendFormatted<long>(this.BuffId);
		instance2.Info(module, author, defaultInterpolatedStringHandler.ToStringAndClear(), default(ReadOnlySpan<ValueTuple<string, object>>));
	}

	// Token: 0x06017652 RID: 95826 RVA: 0x006E36EC File Offset: 0x006E18EC
	private void OnTeamReady()
	{
		SceneTeamModel instance = SceneTeamModel.Instance;
		if (instance == null || !instance.IsTeamReady)
		{
			return;
		}
		this.UnregisterTeamReadyListener();
		Log instance2 = Log.Instance;
		ELogModule module = ELogModule.Battle;
		ELogAuthor author = ELogAuthor.GHY;
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(42, 1);
		defaultInterpolatedStringHandler.AppendLiteral("[SquadProp] OnTeamReady 编队就绪，开始补施加 buffId=");
		defaultInterpolatedStringHandler.AppendFormatted<long>(this.BuffId);
		instance2.Info(module, author, defaultInterpolatedStringHandler.ToStringAndClear(), default(ReadOnlySpan<ValueTuple<string, object>>));
		this.SnapshotAndApply();
	}

	// Token: 0x06017653 RID: 95827 RVA: 0x006E3760 File Offset: 0x006E1960
	private unsafe void SnapshotAndApply()
	{
		if (this.SnapshotOk || !this.HasBuffAuthority())
		{
			return;
		}
		float? num = this.CalcPerStackValue();
		if (num == null)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Battle;
			ELogAuthor author = ELogAuthor.GHY;
			string message = "[SquadProp] 基于属性快照失败，跳过施加";
			<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray3<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("buffId", this.BuffId);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("refAttrId", this.RefAttributeId);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("refSource", this.RefSource);
			instance.Warn(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 3));
			return;
		}
		this.PerStackValue = num.Value;
		this.SnapshotOk = true;
		IActiveBuff buff = base.Buff;
		int num2 = (buff != null) ? buff.StackCount : 1;
		Log instance2 = Log.Instance;
		ELogModule module2 = ELogModule.Battle;
		ELogAuthor author2 = ELogAuthor.GHY;
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(51, 4);
		defaultInterpolatedStringHandler.AppendLiteral("[SquadProp] SnapshotAndApply 生效 buffId=");
		defaultInterpolatedStringHandler.AppendFormatted<long>(this.BuffId);
		defaultInterpolatedStringHandler.AppendLiteral(" 单层值=");
		defaultInterpolatedStringHandler.AppendFormatted<float>(this.PerStackValue);
		defaultInterpolatedStringHandler.AppendLiteral(" 层数=");
		defaultInterpolatedStringHandler.AppendFormatted<int>(num2);
		defaultInterpolatedStringHandler.AppendLiteral(" | ");
		defaultInterpolatedStringHandler.AppendFormatted(this.GetDebugEffectString());
		instance2.Info(module2, author2, defaultInterpolatedStringHandler.ToStringAndClear(), default(ReadOnlySpan<ValueTuple<string, object>>));
		this.ApplyDeltaModifier(this.PerStackValue * (float)num2);
	}

	// Token: 0x06017654 RID: 95828 RVA: 0x006E38D9 File Offset: 0x006E1AD9
	private void UnregisterTeamReadyListener()
	{
		if (this.ListeningTeamReady)
		{
			EventSystem.Instance.Remove(EEventName.OnUpdateSceneTeam, new Action(this.OnTeamReady));
			this.ListeningTeamReady = false;
		}
	}

	// Token: 0x06017655 RID: 95829 RVA: 0x006E3906 File Offset: 0x006E1B06
	[return: Nullable(2)]
	public override object OnExecute(params object[] parameters)
	{
		return null;
	}

	// Token: 0x06017656 RID: 95830 RVA: 0x006E3909 File Offset: 0x006E1B09
	public override void OnStackIncreased(int newCount, int oldCount, long? instigatorId)
	{
		this.RefreshByStack(newCount, oldCount);
	}

	// Token: 0x06017657 RID: 95831 RVA: 0x006E3913 File Offset: 0x006E1B13
	public override void OnStackDecreased(int newCount, int oldCount, bool bPremature)
	{
		this.RefreshByStack(newCount, oldCount);
	}

	// Token: 0x06017658 RID: 95832 RVA: 0x006E391D File Offset: 0x006E1B1D
	public override void OnRemoved(bool bPremature)
	{
		this.UnregisterTeamReadyListener();
		this.RemoveFromTargets();
	}

	// Token: 0x06017659 RID: 95833 RVA: 0x006E392B File Offset: 0x006E1B2B
	protected void RefreshByStack(int newCount, int oldCount)
	{
		if (!this.SnapshotOk || !this.HasBuffAuthority() || newCount == oldCount)
		{
			return;
		}
		this.ApplyDeltaModifier(this.PerStackValue * (float)(newCount - oldCount));
	}

	// Token: 0x0601765A RID: 95834 RVA: 0x006E3954 File Offset: 0x006E1B54
	protected float? CalcPerStackValue()
	{
		if (!this.IsRefAttributeMode())
		{
			return new float?(this.Magnitude);
		}
		float? num = this.SnapshotRefAttribute();
		if (num == null)
		{
			return null;
		}
		float num2 = this.ApplyTransformRule(num.Value) * (this.Magnitude * 0.0001f) + this.Magnitude2;
		float? upperLimit = this.TransformRuleData.UpperLimit;
		if (upperLimit != null && upperLimit.Value > 0f)
		{
			num2 = Math.Min(num2, upperLimit.Value);
		}
		if (this.ModifyType == EModifyType.MultiPercent)
		{
			num2 *= 0.0001f;
		}
		return new float?(num2);
	}

	// Token: 0x0601765B RID: 95835 RVA: 0x006E39FC File Offset: 0x006E1BFC
	protected float ApplyTransformRule(float snapshot)
	{
		TransformRule transformRuleData = this.TransformRuleData;
		if (transformRuleData.LowerLimit == null || transformRuleData.LowerLimit.Value < 0f)
		{
			return snapshot;
		}
		float num = Math.Max(0f, snapshot - transformRuleData.LowerLimit.Value);
		if (transformRuleData.Ratio != null && transformRuleData.Ratio.Value >= 1f)
		{
			num /= transformRuleData.Ratio.Value;
			if (transformRuleData.IsFloor.GetValueOrDefault())
			{
				num = (float)Math.Floor((double)num);
			}
		}
		return num;
	}

	// Token: 0x0601765C RID: 95836 RVA: 0x006E3A8D File Offset: 0x006E1C8D
	protected bool IsRefAttributeMode()
	{
		return this.ModifyType == EModifyType.AddAttribute || this.ModifyType == EModifyType.OverrideAttribute || this.ModifyType == EModifyType.MultiPercent;
	}

	// Token: 0x0601765D RID: 95837 RVA: 0x006E3AB0 File Offset: 0x006E1CB0
	protected float? SnapshotRefAttribute()
	{
		Entity entity;
		if (this.RefSource != ERefSource.Instigator)
		{
			entity = base.OwnerEntity;
		}
		else
		{
			EntityHandle instigatorEntity = base.InstigatorEntity;
			entity = ((instigatorEntity != null) ? instigatorEntity.Entity : null);
		}
		Entity entity2 = entity;
		if (entity2 == null)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Battle;
			ELogAuthor author = ELogAuthor.GHY;
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(51, 2);
			defaultInterpolatedStringHandler.AppendLiteral("[SquadProp] SnapshotRefAttribute 来源实体缺失 buffId=");
			defaultInterpolatedStringHandler.AppendFormatted<long>(this.BuffId);
			defaultInterpolatedStringHandler.AppendLiteral(" 来源=");
			defaultInterpolatedStringHandler.AppendFormatted<ERefSource>(this.RefSource);
			instance.Warn(module, author, defaultInterpolatedStringHandler.ToStringAndClear(), default(ReadOnlySpan<ValueTuple<string, object>>));
			return null;
		}
		if (this.RefPropSystem == EPropSystemType.Squad)
		{
			Entity squadEntityOf = this.GetSquadEntityOf(entity2);
			SquadPropComponent squadPropComponent = (squadEntityOf != null) ? squadEntityOf.GetComponent<SquadPropComponent>() : null;
			if (squadPropComponent == null)
			{
				Log instance2 = Log.Instance;
				ELogModule module2 = ELogModule.Battle;
				ELogAuthor author2 = ELogAuthor.GHY;
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(59, 2);
				defaultInterpolatedStringHandler.AppendLiteral("[SquadProp] SnapshotRefAttribute 来源小队属性组件缺失 buffId=");
				defaultInterpolatedStringHandler.AppendFormatted<long>(this.BuffId);
				defaultInterpolatedStringHandler.AppendLiteral(" 引用属性Id=");
				defaultInterpolatedStringHandler.AppendFormatted<int>(this.RefAttributeId);
				instance2.Warn(module2, author2, defaultInterpolatedStringHandler.ToStringAndClear(), default(ReadOnlySpan<ValueTuple<string, object>>));
				return null;
			}
			return new float?(this.PickValue(squadPropComponent.GetBaseValue((ESquadAttributeType)this.RefAttributeId), squadPropComponent.GetCurrentValue((ESquadAttributeType)this.RefAttributeId)));
		}
		else
		{
			BaseAttributeComponent baseAttributeComponent = entity2.CheckGetComponent<BaseAttributeComponent>();
			if (baseAttributeComponent == null)
			{
				Log instance3 = Log.Instance;
				ELogModule module3 = ELogModule.Battle;
				ELogAuthor author3 = ELogAuthor.GHY;
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(59, 2);
				defaultInterpolatedStringHandler.AppendLiteral("[SquadProp] SnapshotRefAttribute 来源角色属性组件缺失 buffId=");
				defaultInterpolatedStringHandler.AppendFormatted<long>(this.BuffId);
				defaultInterpolatedStringHandler.AppendLiteral(" 引用属性Id=");
				defaultInterpolatedStringHandler.AppendFormatted<int>(this.RefAttributeId);
				instance3.Warn(module3, author3, defaultInterpolatedStringHandler.ToStringAndClear(), default(ReadOnlySpan<ValueTuple<string, object>>));
				return null;
			}
			return new float?(this.PickValue(baseAttributeComponent.GetBaseValue((EAttributeType)this.RefAttributeId), baseAttributeComponent.GetCurrentValue((EAttributeType)this.RefAttributeId)));
		}
	}

	// Token: 0x0601765E RID: 95838 RVA: 0x006E3C8C File Offset: 0x006E1E8C
	protected float PickValue(float baseValue, float curValue)
	{
		switch (this.RefCalcType)
		{
		case ERefCalcType.Base:
			return baseValue;
		case ERefCalcType.Current:
			return curValue;
		case ERefCalcType.CurrentMinusBase:
			return curValue - baseValue;
		default:
			return baseValue;
		}
	}

	// Token: 0x0601765F RID: 95839 RVA: 0x006E3CC0 File Offset: 0x006E1EC0
	protected void ApplyDeltaModifier(float value)
	{
		int attributeId = this.AttributeId;
		if (this.PropSystem == EPropSystemType.Squad)
		{
			Entity entity = (base.OwnerEntity != null) ? this.GetSquadEntityOf(base.OwnerEntity) : null;
			SquadPropComponent squadPropComponent = (entity != null) ? entity.GetComponent<SquadPropComponent>() : null;
			long? num;
			if (entity == null)
			{
				num = null;
			}
			else
			{
				CreatureDataComponent creatureDataComponent = entity.CheckGetComponent<CreatureDataComponent>();
				num = ((creatureDataComponent != null) ? new long?(creatureDataComponent.GetCreatureDataId()) : null);
			}
			long? num2 = num;
			long valueOrDefault = num2.GetValueOrDefault();
			if (squadPropComponent == null || valueOrDefault <= 0L)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.Battle;
				ELogAuthor author = ELogAuthor.GHY;
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(78, 4);
				defaultInterpolatedStringHandler.AppendLiteral("[SquadProp] ApplyDeltaModifier 小队目标缺失，未施加 buffId=");
				defaultInterpolatedStringHandler.AppendFormatted<long>(this.BuffId);
				defaultInterpolatedStringHandler.AppendLiteral(" 属性Id=");
				defaultInterpolatedStringHandler.AppendFormatted<int>(attributeId);
				defaultInterpolatedStringHandler.AppendLiteral(" squadComp=");
				defaultInterpolatedStringHandler.AppendFormatted<bool>(squadPropComponent != null);
				defaultInterpolatedStringHandler.AppendLiteral(" creatureId=");
				defaultInterpolatedStringHandler.AppendFormatted<long>(valueOrDefault);
				instance.Warn(module, author, defaultInterpolatedStringHandler.ToStringAndClear(), default(ReadOnlySpan<ValueTuple<string, object>>));
				return;
			}
			if (!squadPropComponent.IsWritableAttribute((ESquadAttributeType)attributeId))
			{
				return;
			}
			int num3 = squadPropComponent.AddModifier((ESquadAttributeType)attributeId, this.MakeSquadModifier(value));
			if (num3 >= 0)
			{
				this.PushHandle(valueOrDefault, num3);
				return;
			}
		}
		else
		{
			Entity exactOwnerEntity = base.ExactOwnerEntity;
			BaseBuffComponent baseBuffComponent = (exactOwnerEntity != null) ? exactOwnerEntity.CheckGetComponent<BaseBuffComponent>() : null;
			List<BaseAttributeComponent> list = ((baseBuffComponent != null) ? baseBuffComponent.GetTargetComponents<BaseAttributeComponent>(EComponent.BaseAttributeComponent, null) : null) ?? new List<BaseAttributeComponent>();
			if (list.Count == 0)
			{
				Log instance2 = Log.Instance;
				ELogModule module2 = ELogModule.Battle;
				ELogAuthor author2 = ELogAuthor.GHY;
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(57, 2);
				defaultInterpolatedStringHandler.AppendLiteral("[SquadProp] ApplyDeltaModifier 角色扇出目标为空，未施加 buffId=");
				defaultInterpolatedStringHandler.AppendFormatted<long>(this.BuffId);
				defaultInterpolatedStringHandler.AppendLiteral(" 属性Id=");
				defaultInterpolatedStringHandler.AppendFormatted<int>(attributeId);
				instance2.Warn(module2, author2, defaultInterpolatedStringHandler.ToStringAndClear(), default(ReadOnlySpan<ValueTuple<string, object>>));
				return;
			}
			foreach (BaseAttributeComponent baseAttributeComponent in list)
			{
				Entity entity2 = baseAttributeComponent.Entity;
				long? num4;
				if (entity2 == null)
				{
					num4 = null;
				}
				else
				{
					CreatureDataComponent creatureDataComponent2 = entity2.CheckGetComponent<CreatureDataComponent>();
					num4 = ((creatureDataComponent2 != null) ? new long?(creatureDataComponent2.GetCreatureDataId()) : null);
				}
				long? num2 = num4;
				long valueOrDefault2 = num2.GetValueOrDefault();
				if (valueOrDefault2 > 0L && baseAttributeComponent.IsWritableAttribute((EAttributeType)attributeId))
				{
					int num5 = baseAttributeComponent.AddModifier((EAttributeType)attributeId, this.MakeCharacterModifier(value));
					if (num5 >= 0)
					{
						this.PushHandle(valueOrDefault2, num5);
					}
				}
			}
		}
	}

	// Token: 0x06017660 RID: 95840 RVA: 0x006E3F30 File Offset: 0x006E2130
	protected void PushHandle(long key, int handle)
	{
		List<int> list;
		if (this.AppliedModifiers.TryGetValue(key, out list))
		{
			list.Add(handle);
			return;
		}
		this.AppliedModifiers[key] = new List<int>
		{
			handle
		};
	}

	// Token: 0x06017661 RID: 95841 RVA: 0x006E3F70 File Offset: 0x006E2170
	protected void RemoveFromTargets()
	{
		foreach (KeyValuePair<long, List<int>> keyValuePair in this.AppliedModifiers)
		{
			foreach (int handle in keyValuePair.Value)
			{
				this.RemoveOneHandle(keyValuePair.Key, handle);
			}
		}
		this.AppliedModifiers.Clear();
	}

	// Token: 0x06017662 RID: 95842 RVA: 0x006E4014 File Offset: 0x006E2214
	protected void RemoveOneHandle(long key, int handle)
	{
		if (this.PropSystem == EPropSystemType.Squad)
		{
			SquadPropComponent squadPropComponent;
			if (base.OwnerEntity == null)
			{
				squadPropComponent = null;
			}
			else
			{
				Entity squadEntityOf = this.GetSquadEntityOf(base.OwnerEntity);
				squadPropComponent = ((squadEntityOf != null) ? squadEntityOf.GetComponent<SquadPropComponent>() : null);
			}
			SquadPropComponent squadPropComponent2 = squadPropComponent;
			if (squadPropComponent2 != null && squadPropComponent2.Valid)
			{
				squadPropComponent2.RemoveModifier((ESquadAttributeType)this.AttributeId, handle);
				return;
			}
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Battle;
			ELogAuthor author = ELogAuthor.GHY;
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(62, 3);
			defaultInterpolatedStringHandler.AppendLiteral("[SquadProp] RemoveOneHandle 小队组件已失效，跳过移除 buffId=");
			defaultInterpolatedStringHandler.AppendFormatted<long>(this.BuffId);
			defaultInterpolatedStringHandler.AppendLiteral(" 属性Id=");
			defaultInterpolatedStringHandler.AppendFormatted<int>(this.AttributeId);
			defaultInterpolatedStringHandler.AppendLiteral(" handle=");
			defaultInterpolatedStringHandler.AppendFormatted<int>(handle);
			instance.Info(module, author, defaultInterpolatedStringHandler.ToStringAndClear(), default(ReadOnlySpan<ValueTuple<string, object>>));
			return;
		}
		else
		{
			CreatureModel instance2 = CreatureModel.Instance;
			BaseAttributeComponent baseAttributeComponent;
			if (instance2 == null)
			{
				baseAttributeComponent = null;
			}
			else
			{
				EntityHandle entity = instance2.GetEntity(key);
				if (entity == null)
				{
					baseAttributeComponent = null;
				}
				else
				{
					WorldEntity entity2 = entity.Entity;
					baseAttributeComponent = ((entity2 != null) ? entity2.CheckGetComponent<BaseAttributeComponent>() : null);
				}
			}
			BaseAttributeComponent baseAttributeComponent2 = baseAttributeComponent;
			if (baseAttributeComponent2 != null && baseAttributeComponent2.Valid)
			{
				baseAttributeComponent2.RemoveModifier((EAttributeType)this.AttributeId, handle);
				return;
			}
			Log instance3 = Log.Instance;
			ELogModule module2 = ELogModule.Battle;
			ELogAuthor author2 = ELogAuthor.GHY;
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(74, 4);
			defaultInterpolatedStringHandler.AppendLiteral("[SquadProp] RemoveOneHandle 角色组件已失效，跳过移除 buffId=");
			defaultInterpolatedStringHandler.AppendFormatted<long>(this.BuffId);
			defaultInterpolatedStringHandler.AppendLiteral(" 属性Id=");
			defaultInterpolatedStringHandler.AppendFormatted<int>(this.AttributeId);
			defaultInterpolatedStringHandler.AppendLiteral(" handle=");
			defaultInterpolatedStringHandler.AppendFormatted<int>(handle);
			defaultInterpolatedStringHandler.AppendLiteral(" creatureId=");
			defaultInterpolatedStringHandler.AppendFormatted<long>(key);
			instance3.Info(module2, author2, defaultInterpolatedStringHandler.ToStringAndClear(), default(ReadOnlySpan<ValueTuple<string, object>>));
			return;
		}
	}

	// Token: 0x06017663 RID: 95843 RVA: 0x006E41A0 File Offset: 0x006E23A0
	protected ISquadModifier MakeSquadModifier(float value)
	{
		switch (this.ModifyType)
		{
		case EModifyType.AddPercent:
		case EModifyType.MultiPercent:
			return new SquadAddRateModifier
			{
				Value = value
			};
		case EModifyType.Override:
		case EModifyType.OverrideAttribute:
			return new SquadOverrideModifier
			{
				Value = value
			};
		}
		return new SquadAddValueModifier
		{
			Value = value
		};
	}

	// Token: 0x06017664 RID: 95844 RVA: 0x006E420C File Offset: 0x006E240C
	protected CharacterAttributeTypes.IModifier MakeCharacterModifier(float value)
	{
		switch (this.ModifyType)
		{
		case EModifyType.AddPercent:
		case EModifyType.MultiPercent:
			return new CharacterAttributeTypes.AttributeModifier
			{
				Type = ECalculationPolicyType.AddRate,
				Value1 = value
			};
		case EModifyType.Override:
		case EModifyType.OverrideAttribute:
			return new CharacterAttributeTypes.AttributeModifier
			{
				Type = ECalculationPolicyType.OverrideValue,
				Value1 = value
			};
		}
		return new CharacterAttributeTypes.AttributeModifier
		{
			Type = ECalculationPolicyType.AddValue,
			Value1 = value
		};
	}

	// Token: 0x06017665 RID: 95845 RVA: 0x006E428C File Offset: 0x006E248C
	[return: Nullable(2)]
	protected Entity GetSquadEntityOf(Entity entity)
	{
		CreatureDataComponent creatureDataComponent = entity.CheckGetComponent<CreatureDataComponent>();
		int num = (creatureDataComponent != null) ? creatureDataComponent.GetPlayerId() : 0;
		if (num <= 0)
		{
			return null;
		}
		return FormationDataController.Instance.GetPlayerEntity(num);
	}

	// Token: 0x06017666 RID: 95846 RVA: 0x006E42C0 File Offset: 0x006E24C0
	public override string GetDebugEffectString()
	{
		string value = (this.PropSystem == EPropSystemType.Squad) ? "小队共享属性" : "角色属性";
		string text;
		switch (this.ModifyType)
		{
		case EModifyType.Add:
			text = "加";
			goto IL_BB;
		case EModifyType.AddPercent:
			text = "乘";
			goto IL_BB;
		case EModifyType.AddAttribute:
			text = "基于属性加";
			goto IL_BB;
		case EModifyType.Override:
			text = "覆盖";
			goto IL_BB;
		case EModifyType.OverrideAttribute:
			text = "基于属性覆盖";
			goto IL_BB;
		case EModifyType.MultiPercent:
			text = "基于属性乘";
			goto IL_BB;
		}
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(4, 1);
		defaultInterpolatedStringHandler.AppendLiteral("未知(");
		defaultInterpolatedStringHandler.AppendFormatted<EModifyType>(this.ModifyType);
		defaultInterpolatedStringHandler.AppendLiteral(")");
		text = defaultInterpolatedStringHandler.ToStringAndClear();
		IL_BB:
		string value2 = text;
		IActiveBuff buff = base.Buff;
		int value3 = (buff != null) ? buff.StackCount : 1;
		defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(16, 5);
		defaultInterpolatedStringHandler.AppendLiteral("修改");
		defaultInterpolatedStringHandler.AppendFormatted(value);
		defaultInterpolatedStringHandler.AppendLiteral("[");
		defaultInterpolatedStringHandler.AppendFormatted<int>(this.AttributeId);
		defaultInterpolatedStringHandler.AppendLiteral("] 方式[");
		defaultInterpolatedStringHandler.AppendFormatted(value2);
		defaultInterpolatedStringHandler.AppendLiteral("] 单层值");
		defaultInterpolatedStringHandler.AppendFormatted<float>(this.PerStackValue);
		defaultInterpolatedStringHandler.AppendLiteral(" 层数");
		defaultInterpolatedStringHandler.AppendFormatted<int>(value3);
		string text2 = defaultInterpolatedStringHandler.ToStringAndClear();
		if (this.IsRefAttributeMode())
		{
			string value4 = (this.RefSource == ERefSource.Instigator) ? "施加者" : "持有者";
			string value5 = (this.RefPropSystem == EPropSystemType.Squad) ? "小队" : "角色";
			string str = text2;
			defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(16, 5);
			defaultInterpolatedStringHandler.AppendLiteral(" 基于");
			defaultInterpolatedStringHandler.AppendFormatted(value4);
			defaultInterpolatedStringHandler.AppendFormatted(value5);
			defaultInterpolatedStringHandler.AppendLiteral("属性[");
			defaultInterpolatedStringHandler.AppendFormatted<int>(this.RefAttributeId);
			defaultInterpolatedStringHandler.AppendLiteral("](系数");
			defaultInterpolatedStringHandler.AppendFormatted<float>(this.Magnitude);
			defaultInterpolatedStringHandler.AppendLiteral("/万,常数");
			defaultInterpolatedStringHandler.AppendFormatted<float>(this.Magnitude2);
			defaultInterpolatedStringHandler.AppendLiteral(")");
			text2 = str + defaultInterpolatedStringHandler.ToStringAndClear();
		}
		return text2;
	}

	// Token: 0x06017667 RID: 95847 RVA: 0x006E44E4 File Offset: 0x006E26E4
	[CompilerGenerated]
	internal static float? <ParseTransformRule>g__ParseNum|18_0(int idx, ref ModifySquadProp.<>c__DisplayClass18_0 A_1)
	{
		if (idx >= A_1.segments.Length || string.IsNullOrEmpty(A_1.segments[idx]))
		{
			return null;
		}
		return new float?(float.Parse(A_1.segments[idx]));
	}

	// Token: 0x0400C6B4 RID: 50868
	protected int AttributeId;

	// Token: 0x0400C6B5 RID: 50869
	protected EModifyType ModifyType;

	// Token: 0x0400C6B6 RID: 50870
	protected int RefAttributeId;

	// Token: 0x0400C6B7 RID: 50871
	protected ERefSource RefSource;

	// Token: 0x0400C6B8 RID: 50872
	protected ERefCalcType RefCalcType;

	// Token: 0x0400C6B9 RID: 50873
	protected EPropSystemType RefPropSystem;

	// Token: 0x0400C6BA RID: 50874
	protected TransformRule TransformRuleData = new TransformRule();

	// Token: 0x0400C6BB RID: 50875
	protected EPropSystemType PropSystem;

	// Token: 0x0400C6BC RID: 50876
	protected float Magnitude;

	// Token: 0x0400C6BD RID: 50877
	protected float Magnitude2;

	// Token: 0x0400C6BE RID: 50878
	protected float PerStackValue;

	// Token: 0x0400C6BF RID: 50879
	protected bool SnapshotOk;

	// Token: 0x0400C6C0 RID: 50880
	protected readonly Dictionary<long, List<int>> AppliedModifiers = new Dictionary<long, List<int>>();

	// Token: 0x0400C6C1 RID: 50881
	private bool ListeningTeamReady;
}
