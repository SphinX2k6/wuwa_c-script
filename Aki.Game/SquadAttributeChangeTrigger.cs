using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using CSharpScript.Utils;

// Token: 0x02002FFE RID: 12286
[NullableContext(2)]
[Nullable(0)]
public class SquadAttributeChangeTrigger : Trigger
{
	// Token: 0x0601A07A RID: 106618 RVA: 0x006D0FDA File Offset: 0x006CF1DA
	public SquadAttributeChangeTrigger(ITriggerConfig c, int h, CharacterTriggerComponent o, [Nullable(1)] Dictionary<string, Func<TFormulaValue[], TFormulaValue>> f, TTriggerCallback cb, TTriggerChecker ck) : base(c, h, o, f, cb, ck)
	{
	}

	// Token: 0x0601A07B RID: 106619 RVA: 0x006D0FF4 File Offset: 0x006CF1F4
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

	// Token: 0x0601A07C RID: 106620 RVA: 0x006D1144 File Offset: 0x006CF344
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

	// Token: 0x0601A07D RID: 106621 RVA: 0x006D11A0 File Offset: 0x006CF3A0
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

	// Token: 0x0601A07E RID: 106622 RVA: 0x006D11C0 File Offset: 0x006CF3C0
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

	// Token: 0x0601A07F RID: 106623 RVA: 0x006D122E File Offset: 0x006CF42E
	protected override void OnInactive()
	{
		SquadPropComponent listeningSquadComp = this.ListeningSquadComp;
		if (listeningSquadComp != null)
		{
			listeningSquadComp.RemoveListener(this.AttributeId, new SquadAttrChangeListener(this.OnEvent));
		}
		this.ListeningSquadComp = null;
	}

	// Token: 0x0601A080 RID: 106624 RVA: 0x006D125C File Offset: 0x006CF45C
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

	// Token: 0x0601A081 RID: 106625 RVA: 0x006D12AC File Offset: 0x006CF4AC
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

	// Token: 0x0400C4F4 RID: 50420
	protected ETriggerTargetType TargetType;

	// Token: 0x0400C4F5 RID: 50421
	protected ESquadAttributeType AttributeId;

	// Token: 0x0400C4F6 RID: 50422
	protected bool HasValidConfig = true;

	// Token: 0x0400C4F7 RID: 50423
	private SquadPropComponent ListeningSquadComp;
}
