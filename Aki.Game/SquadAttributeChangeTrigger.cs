using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using CSharpScript.Utils;

// Token: 0x02002553 RID: 9555
[NullableContext(2)]
[Nullable(0)]
public class SquadAttributeChangeTrigger : Trigger
{
	// Token: 0x060179AE RID: 96686 RVA: 0x006F8E76 File Offset: 0x006F7076
	public SquadAttributeChangeTrigger(ITriggerConfig c, int h, CharacterTriggerComponent o, [Nullable(1)] Dictionary<string, Func<TFormulaValue[], TFormulaValue>> f, TTriggerCallback cb, TTriggerChecker ck) : base(c, h, o, f, cb, ck)
	{
	}

	// Token: 0x060179AF RID: 96687 RVA: 0x006F8E90 File Offset: 0x006F7090
	[NullableContext(1)]
	public unsafe override void OnInitParams(string[] triggerParams)
	{
		this.TargetType = (ETriggerTargetType)Convert.ToInt32((triggerParams.Length != 0) ? triggerParams[0] : "0");
		this.AttributeId = (ESquadAttributeType)Convert.ToInt32((triggerParams.Length > 1) ? triggerParams[1] : "0");
		if (this.AttributeId <= ESquadAttributeType.None || this.AttributeId >= ESquadAttributeType.Max)
		{
			this.HasValidConfig = false;
			CombatLog instance = CombatLog.Instance;
			CombatLog.EDebugModule flag = CombatLog.EDebugModule.PassiveSkill;
			CharacterTriggerComponent ownerTriggerComp = base.OwnerTriggerComp;
			Entity entity = (ownerTriggerComp != null) ? ownerTriggerComp.Entity : null;
			string message = "SquadAttributeChangeTrigger 非法的小队属性 Id";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("triggerName", this.GetDebugName());
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("attributeId", (int)this.AttributeId);
			instance.Error(flag, entity, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
			return;
		}
		if (this.TargetType == ETriggerTargetType.AllFormation)
		{
			this.HasValidConfig = false;
			CombatLog instance2 = CombatLog.Instance;
			CombatLog.EDebugModule flag2 = CombatLog.EDebugModule.PassiveSkill;
			CharacterTriggerComponent ownerTriggerComp2 = base.OwnerTriggerComp;
			Entity entity2 = (ownerTriggerComp2 != null) ? ownerTriggerComp2.Entity : null;
			string message2 = "SquadAttributeChangeTrigger 暂不支持 2-队伍(AllFormation) 监听对象";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray2 = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 0) = new ValueTuple<string, object>("triggerName", this.GetDebugName());
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 1) = new ValueTuple<string, object>("params", string.Join(",", triggerParams));
			instance2.Error(flag2, entity2, message2, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray2, 2));
		}
	}

	// Token: 0x060179B0 RID: 96688 RVA: 0x006F8FE0 File Offset: 0x006F71E0
	private int ResolvePlayerId()
	{
		CharacterTriggerComponent ownerTriggerComp = base.OwnerTriggerComp;
		int? num;
		if (ownerTriggerComp == null)
		{
			num = null;
		}
		else
		{
			Entity entity = ownerTriggerComp.Entity;
			if (entity == null)
			{
				num = null;
			}
			else
			{
				CreatureDataComponent component = entity.GetComponent<CreatureDataComponent>();
				num = ((component != null) ? new int?(component.GetPlayerId()) : null);
			}
		}
		int? num2 = num;
		return num2.GetValueOrDefault();
	}

	// Token: 0x060179B1 RID: 96689 RVA: 0x006F903C File Offset: 0x006F723C
	private SquadPropComponent GetSquadCompByPlayerId(int playerId)
	{
		if (playerId <= 0)
		{
			return null;
		}
		WorldEntity playerEntity = FormationDataController.Instance.GetPlayerEntity(playerId);
		if (playerEntity == null)
		{
			return null;
		}
		return playerEntity.GetComponent<SquadPropComponent>();
	}

	// Token: 0x060179B2 RID: 96690 RVA: 0x006F905C File Offset: 0x006F725C
	protected override void OnActive()
	{
		if (!this.HasValidConfig)
		{
			return;
		}
		this.ListeningSquadComp = this.GetSquadCompByPlayerId(this.ResolvePlayerId());
		if (this.ListeningSquadComp == null)
		{
			return;
		}
		this.ListeningSquadComp.AddListener(this.AttributeId, new SquadAttrChangeListener(this.OnEvent));
		float currentValue = this.ListeningSquadComp.GetCurrentValue(this.AttributeId);
		this.OnEvent(this.AttributeId, currentValue, currentValue);
	}

	// Token: 0x060179B3 RID: 96691 RVA: 0x006F90CA File Offset: 0x006F72CA
	protected override void OnInactive()
	{
		SquadPropComponent listeningSquadComp = this.ListeningSquadComp;
		if (listeningSquadComp != null)
		{
			listeningSquadComp.RemoveListener(this.AttributeId, new SquadAttrChangeListener(this.OnEvent));
		}
		this.ListeningSquadComp = null;
	}

	// Token: 0x060179B4 RID: 96692 RVA: 0x006F90F8 File Offset: 0x006F72F8
	protected void OnEvent(ESquadAttributeType _attrId, float newValue, float oldValue)
	{
		if (base.Checker != null && !base.Checker())
		{
			return;
		}
		Dictionary<string, TFormulaValue> dictionary = new Dictionary<string, TFormulaValue>();
		dictionary["NewValue"] = newValue;
		dictionary["OldValue"] = oldValue;
		base.EvaluateAndExecute(dictionary);
	}

	// Token: 0x060179B5 RID: 96693 RVA: 0x006F9148 File Offset: 0x006F7348
	[NullableContext(1)]
	public override string GetDebugTriggerType()
	{
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler;
		if (this.TargetType == ETriggerTargetType.AllFormation)
		{
			defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(17, 1);
			defaultInterpolatedStringHandler.AppendLiteral("全部编队小队共享属性 #");
			defaultInterpolatedStringHandler.AppendFormatted<ESquadAttributeType>(this.AttributeId);
			defaultInterpolatedStringHandler.AppendLiteral("变化时触发");
			return defaultInterpolatedStringHandler.ToStringAndClear();
		}
		defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(13, 1);
		defaultInterpolatedStringHandler.AppendLiteral("小队共享属性 #");
		defaultInterpolatedStringHandler.AppendFormatted<ESquadAttributeType>(this.AttributeId);
		defaultInterpolatedStringHandler.AppendLiteral("变化时触发");
		return defaultInterpolatedStringHandler.ToStringAndClear();
	}

	// Token: 0x0400C8BC RID: 51388
	protected ETriggerTargetType TargetType;

	// Token: 0x0400C8BD RID: 51389
	protected ESquadAttributeType AttributeId;

	// Token: 0x0400C8BE RID: 51390
	protected bool HasValidConfig = true;

	// Token: 0x0400C8BF RID: 51391
	private SquadPropComponent ListeningSquadComp;
}
