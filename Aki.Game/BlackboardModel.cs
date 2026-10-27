using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;

// Token: 0x0200351B RID: 13595
[NullableContext(1)]
[Nullable(0)]
[Model(0)]
public class BlackboardModel : ModelBase
{
	// Token: 0x0601DCF0 RID: 122096 RVA: 0x0085A849 File Offset: 0x00858A49
	protected override bool OnClear()
	{
		this.GlobalBlackboard.Clear();
		this.WorldBlackboard.Clear();
		this.CreatureDataComponentMap.Clear();
		return true;
	}

	// Token: 0x0601DCF1 RID: 122097 RVA: 0x0085A870 File Offset: 0x00858A70
	[NullableContext(2)]
	public CreatureDataComponent GetCreatureDataComponent(int entityId)
	{
		if (this.CreatureDataComponentMap.ContainsKey(entityId))
		{
			return this.CreatureDataComponentMap.GetValueOrDefault(entityId);
		}
		Entity entity = EntitySystem.Instance.Get(entityId);
		if (entity == null || !entity.Valid)
		{
			return null;
		}
		CreatureDataComponent component = entity.GetComponent<CreatureDataComponent>();
		if (component == null || !component.Valid)
		{
			return null;
		}
		this.CreatureDataComponentMap[entityId] = component;
		return component;
	}

	// Token: 0x0601DCF2 RID: 122098 RVA: 0x0085A8DF File Offset: 0x00858ADF
	public void RemoveCreatureDataComponent(int entityId)
	{
		if (this.CreatureDataComponentMap.ContainsKey(entityId))
		{
			this.CreatureDataComponentMap.Remove(entityId);
		}
	}

	// Token: 0x0601DCF3 RID: 122099 RVA: 0x0085A8FC File Offset: 0x00858AFC
	public int? GetIntValueByGlobal(string key)
	{
		BlackboardMap.BlackboardParam value = this.GlobalBlackboard.GetValue(key);
		if (value == null)
		{
			return null;
		}
		return new int?(value.GetIntValue());
	}

	// Token: 0x0601DCF4 RID: 122100 RVA: 0x0085A930 File Offset: 0x00858B30
	public void SetIntValueByGlobal(string key, int value)
	{
		BlackboardMap.BlackboardParam blackboardParam = this.GlobalBlackboard.GetValue(key);
		if (blackboardParam != null)
		{
			blackboardParam.SetIntValue(value);
			return;
		}
		blackboardParam = new BlackboardMap.BlackboardParam(BlackboardParamType.Int);
		blackboardParam.SetIntValue(value);
		this.GlobalBlackboard.SetValue(key, blackboardParam);
	}

	// Token: 0x0601DCF5 RID: 122101 RVA: 0x0085A970 File Offset: 0x00858B70
	[return: Nullable(2)]
	public IList<int> GetIntValuesByGlobal(string key)
	{
		BlackboardMap.BlackboardParam value = this.GlobalBlackboard.GetValue(key);
		if (value == null)
		{
			return null;
		}
		return value.GetIntValues();
	}

	// Token: 0x0601DCF6 RID: 122102 RVA: 0x0085A98C File Offset: 0x00858B8C
	public void SetIntValuesByGlobal(string key, int[] values)
	{
		BlackboardMap.BlackboardParam blackboardParam = this.GlobalBlackboard.GetValue(key);
		if (blackboardParam != null)
		{
			blackboardParam.SetIntValues(values);
			return;
		}
		blackboardParam = new BlackboardMap.BlackboardParam(BlackboardParamType.IntArray);
		blackboardParam.SetIntValues(values);
		this.GlobalBlackboard.SetValue(key, blackboardParam);
	}

	// Token: 0x0601DCF7 RID: 122103 RVA: 0x0085A9CC File Offset: 0x00858BCC
	public long? GetLongValueByGlobal(string key)
	{
		BlackboardMap.BlackboardParam value = this.GlobalBlackboard.GetValue(key);
		if (value == null)
		{
			return null;
		}
		return value.GetLongValue();
	}

	// Token: 0x0601DCF8 RID: 122104 RVA: 0x0085A9F8 File Offset: 0x00858BF8
	public void SetLongValueByGlobal(string key, long value)
	{
		BlackboardMap.BlackboardParam blackboardParam = this.GlobalBlackboard.GetValue(key);
		if (blackboardParam != null)
		{
			blackboardParam.SetLongValue(value);
			return;
		}
		blackboardParam = new BlackboardMap.BlackboardParam(BlackboardParamType.Long);
		blackboardParam.SetLongValue(value);
		this.GlobalBlackboard.SetValue(key, blackboardParam);
	}

	// Token: 0x0601DCF9 RID: 122105 RVA: 0x0085AA38 File Offset: 0x00858C38
	[return: Nullable(2)]
	public IList<long> GetLongValuesByGlobal(string key)
	{
		BlackboardMap.BlackboardParam value = this.GlobalBlackboard.GetValue(key);
		if (value == null)
		{
			return null;
		}
		return value.GetLongValues();
	}

	// Token: 0x0601DCFA RID: 122106 RVA: 0x0085AA54 File Offset: 0x00858C54
	public void SetLongValuesByGlobal(string key, long[] values)
	{
		BlackboardMap.BlackboardParam blackboardParam = this.GlobalBlackboard.GetValue(key);
		if (blackboardParam != null)
		{
			blackboardParam.SetLongValues(values);
			return;
		}
		blackboardParam = new BlackboardMap.BlackboardParam(BlackboardParamType.LongArray);
		blackboardParam.SetLongValues(values);
		this.GlobalBlackboard.SetValue(key, blackboardParam);
	}

	// Token: 0x0601DCFB RID: 122107 RVA: 0x0085AA94 File Offset: 0x00858C94
	public bool? GetBooleanValueByGlobal(string key)
	{
		BlackboardMap.BlackboardParam value = this.GlobalBlackboard.GetValue(key);
		if (value == null)
		{
			return null;
		}
		return new bool?(value.GetBooleanValue());
	}

	// Token: 0x0601DCFC RID: 122108 RVA: 0x0085AAC8 File Offset: 0x00858CC8
	public void SetBooleanValueByGlobal(string key, bool value)
	{
		BlackboardMap.BlackboardParam blackboardParam = this.GlobalBlackboard.GetValue(key);
		if (blackboardParam != null)
		{
			blackboardParam.SetBooleanValue(value);
			return;
		}
		blackboardParam = new BlackboardMap.BlackboardParam(BlackboardParamType.Boolean);
		blackboardParam.SetBooleanValue(value);
		this.GlobalBlackboard.SetValue(key, blackboardParam);
	}

	// Token: 0x0601DCFD RID: 122109 RVA: 0x0085AB08 File Offset: 0x00858D08
	public float? GetFloatValueByGlobal(string key)
	{
		BlackboardMap.BlackboardParam value = this.GlobalBlackboard.GetValue(key);
		if (value == null)
		{
			return null;
		}
		return new float?(value.GetFloatValue());
	}

	// Token: 0x0601DCFE RID: 122110 RVA: 0x0085AB3C File Offset: 0x00858D3C
	public void SetFloatValueByGlobal(string key, float value)
	{
		BlackboardMap.BlackboardParam blackboardParam = this.GlobalBlackboard.GetValue(key);
		if (blackboardParam != null)
		{
			blackboardParam.SetFloatValue(value);
			return;
		}
		blackboardParam = new BlackboardMap.BlackboardParam(BlackboardParamType.Float);
		blackboardParam.SetFloatValue(value);
		this.GlobalBlackboard.SetValue(key, blackboardParam);
	}

	// Token: 0x0601DCFF RID: 122111 RVA: 0x0085AB7C File Offset: 0x00858D7C
	[return: Nullable(2)]
	public IList<float> GetFloatValuesByGlobal(string key)
	{
		BlackboardMap.BlackboardParam value = this.GlobalBlackboard.GetValue(key);
		if (value == null)
		{
			return null;
		}
		return value.GetFloatValues();
	}

	// Token: 0x0601DD00 RID: 122112 RVA: 0x0085AB98 File Offset: 0x00858D98
	public void SetFloatValuesByGlobal(string key, float[] values)
	{
		BlackboardMap.BlackboardParam blackboardParam = this.GlobalBlackboard.GetValue(key);
		if (blackboardParam != null)
		{
			blackboardParam.SetFloatValues(values);
			return;
		}
		blackboardParam = new BlackboardMap.BlackboardParam(BlackboardParamType.FloatArray);
		blackboardParam.SetFloatValues(values);
		this.GlobalBlackboard.SetValue(key, blackboardParam);
	}

	// Token: 0x0601DD01 RID: 122113 RVA: 0x0085ABD9 File Offset: 0x00858DD9
	[return: Nullable(2)]
	public string GetStringValueByGlobal(string key)
	{
		BlackboardMap.BlackboardParam value = this.GlobalBlackboard.GetValue(key);
		if (value == null)
		{
			return null;
		}
		return value.GetStringValue();
	}

	// Token: 0x0601DD02 RID: 122114 RVA: 0x0085ABF4 File Offset: 0x00858DF4
	public void SetStringValueByGlobal(string key, string value)
	{
		BlackboardMap.BlackboardParam blackboardParam = this.GlobalBlackboard.GetValue(key);
		if (blackboardParam != null)
		{
			blackboardParam.SetStringValue(value);
			return;
		}
		blackboardParam = new BlackboardMap.BlackboardParam(BlackboardParamType.String);
		blackboardParam.SetStringValue(value);
		this.GlobalBlackboard.SetValue(key, blackboardParam);
	}

	// Token: 0x0601DD03 RID: 122115 RVA: 0x0085AC34 File Offset: 0x00858E34
	[return: Nullable(new byte[]
	{
		2,
		1
	})]
	public IList<string> GetStringValuesByGlobal(string key)
	{
		BlackboardMap.BlackboardParam value = this.GlobalBlackboard.GetValue(key);
		if (value == null)
		{
			return null;
		}
		return value.GetStringValues();
	}

	// Token: 0x0601DD04 RID: 122116 RVA: 0x0085AC50 File Offset: 0x00858E50
	public void SetStringValuesByGlobal(string key, string[] values)
	{
		BlackboardMap.BlackboardParam blackboardParam = this.GlobalBlackboard.GetValue(key);
		if (blackboardParam != null)
		{
			blackboardParam.SetStringValues(values);
			return;
		}
		blackboardParam = new BlackboardMap.BlackboardParam(BlackboardParamType.StringArray);
		blackboardParam.SetStringValues(values);
		this.GlobalBlackboard.SetValue(key, blackboardParam);
	}

	// Token: 0x0601DD05 RID: 122117 RVA: 0x0085AC90 File Offset: 0x00858E90
	public void SetValueByGlobal(string key, BlackboardMap.BlackboardParam blackboard)
	{
		this.GlobalBlackboard.SetValue(key, blackboard);
	}

	// Token: 0x0601DD06 RID: 122118 RVA: 0x0085AC9F File Offset: 0x00858E9F
	public void RemoveValueByGlobal(string key)
	{
		this.GlobalBlackboard.RemoveValue(key);
	}

	// Token: 0x0601DD07 RID: 122119 RVA: 0x0085ACAE File Offset: 0x00858EAE
	public void SetWorldBlackboardByProtocol(IList<BlackboardParam> worldBlackboard)
	{
	}

	// Token: 0x0601DD08 RID: 122120 RVA: 0x0085ACB0 File Offset: 0x00858EB0
	public int? GetIntValueByWorld(string key)
	{
		BlackboardMap.BlackboardParam value = this.WorldBlackboard.GetValue(key);
		if (value == null)
		{
			return null;
		}
		return new int?(value.GetIntValue());
	}

	// Token: 0x0601DD09 RID: 122121 RVA: 0x0085ACE4 File Offset: 0x00858EE4
	public void SetIntValueByWorld(string key, int value)
	{
		BlackboardMap.BlackboardParam blackboardParam = this.WorldBlackboard.GetValue(key);
		if (blackboardParam != null)
		{
			blackboardParam.SetIntValue(value);
			return;
		}
		blackboardParam = new BlackboardMap.BlackboardParam(BlackboardParamType.Int);
		blackboardParam.SetIntValue(value);
		this.WorldBlackboard.SetValue(key, blackboardParam);
	}

	// Token: 0x0601DD0A RID: 122122 RVA: 0x0085AD24 File Offset: 0x00858F24
	[return: Nullable(2)]
	public IList<int> GetIntValuesByWorld(string key)
	{
		BlackboardMap.BlackboardParam value = this.WorldBlackboard.GetValue(key);
		if (value == null)
		{
			return null;
		}
		return value.GetIntValues();
	}

	// Token: 0x0601DD0B RID: 122123 RVA: 0x0085AD40 File Offset: 0x00858F40
	public void SetIntValuesByWorld(string key, int[] values)
	{
		BlackboardMap.BlackboardParam blackboardParam = this.WorldBlackboard.GetValue(key);
		if (blackboardParam != null)
		{
			blackboardParam.SetIntValues(values);
			return;
		}
		blackboardParam = new BlackboardMap.BlackboardParam(BlackboardParamType.IntArray);
		blackboardParam.SetIntValues(values);
		this.WorldBlackboard.SetValue(key, blackboardParam);
	}

	// Token: 0x0601DD0C RID: 122124 RVA: 0x0085AD80 File Offset: 0x00858F80
	public long? GetLongValueByWorld(string key)
	{
		BlackboardMap.BlackboardParam value = this.WorldBlackboard.GetValue(key);
		if (value == null)
		{
			return null;
		}
		return value.GetLongValue();
	}

	// Token: 0x0601DD0D RID: 122125 RVA: 0x0085ADAC File Offset: 0x00858FAC
	public void SetLongValueByWorld(string key, long value)
	{
		BlackboardMap.BlackboardParam blackboardParam = this.WorldBlackboard.GetValue(key);
		if (blackboardParam != null)
		{
			blackboardParam.SetLongValue(value);
			return;
		}
		blackboardParam = new BlackboardMap.BlackboardParam(BlackboardParamType.Long);
		blackboardParam.SetLongValue(value);
		this.WorldBlackboard.SetValue(key, blackboardParam);
	}

	// Token: 0x0601DD0E RID: 122126 RVA: 0x0085ADEC File Offset: 0x00858FEC
	[return: Nullable(2)]
	public IList<long> GetLongValuesByWorld(string key)
	{
		BlackboardMap.BlackboardParam value = this.WorldBlackboard.GetValue(key);
		if (value == null)
		{
			return null;
		}
		return value.GetLongValues();
	}

	// Token: 0x0601DD0F RID: 122127 RVA: 0x0085AE08 File Offset: 0x00859008
	public void SetLongValuesByWorld(string key, long[] values)
	{
		BlackboardMap.BlackboardParam blackboardParam = this.WorldBlackboard.GetValue(key);
		if (blackboardParam != null)
		{
			blackboardParam.SetLongValues(values);
			return;
		}
		blackboardParam = new BlackboardMap.BlackboardParam(BlackboardParamType.LongArray);
		blackboardParam.SetLongValues(values);
		this.WorldBlackboard.SetValue(key, blackboardParam);
	}

	// Token: 0x0601DD10 RID: 122128 RVA: 0x0085AE48 File Offset: 0x00859048
	public bool? GetBooleanValueByWorld(string key)
	{
		BlackboardMap.BlackboardParam value = this.WorldBlackboard.GetValue(key);
		if (value == null)
		{
			return null;
		}
		return new bool?(value.GetBooleanValue());
	}

	// Token: 0x0601DD11 RID: 122129 RVA: 0x0085AE7C File Offset: 0x0085907C
	public void SetBooleanValueByWorld(string key, bool value)
	{
		BlackboardMap.BlackboardParam blackboardParam = this.WorldBlackboard.GetValue(key);
		if (blackboardParam != null)
		{
			blackboardParam.SetBooleanValue(value);
			return;
		}
		blackboardParam = new BlackboardMap.BlackboardParam(BlackboardParamType.Boolean);
		blackboardParam.SetBooleanValue(value);
		this.WorldBlackboard.SetValue(key, blackboardParam);
	}

	// Token: 0x0601DD12 RID: 122130 RVA: 0x0085AEBC File Offset: 0x008590BC
	public float? GetFloatValueByWorld(string key)
	{
		BlackboardMap.BlackboardParam value = this.WorldBlackboard.GetValue(key);
		if (value == null)
		{
			return null;
		}
		return new float?(value.GetFloatValue());
	}

	// Token: 0x0601DD13 RID: 122131 RVA: 0x0085AEF0 File Offset: 0x008590F0
	public void SetFloatValueByWorld(string key, float value)
	{
		BlackboardMap.BlackboardParam blackboardParam = this.WorldBlackboard.GetValue(key);
		if (blackboardParam != null)
		{
			blackboardParam.SetFloatValue(value);
			return;
		}
		blackboardParam = new BlackboardMap.BlackboardParam(BlackboardParamType.Float);
		blackboardParam.SetFloatValue(value);
		this.WorldBlackboard.SetValue(key, blackboardParam);
	}

	// Token: 0x0601DD14 RID: 122132 RVA: 0x0085AF30 File Offset: 0x00859130
	[return: Nullable(2)]
	public IList<float> GetFloatValuesByWorld(string key)
	{
		BlackboardMap.BlackboardParam value = this.WorldBlackboard.GetValue(key);
		if (value == null)
		{
			return null;
		}
		return value.GetFloatValues();
	}

	// Token: 0x0601DD15 RID: 122133 RVA: 0x0085AF4C File Offset: 0x0085914C
	public void SetFloatValuesByWorld(string key, float[] values)
	{
		BlackboardMap.BlackboardParam blackboardParam = this.WorldBlackboard.GetValue(key);
		if (blackboardParam != null)
		{
			blackboardParam.SetFloatValues(values);
			return;
		}
		blackboardParam = new BlackboardMap.BlackboardParam(BlackboardParamType.FloatArray);
		blackboardParam.SetFloatValues(values);
		this.WorldBlackboard.SetValue(key, blackboardParam);
	}

	// Token: 0x0601DD16 RID: 122134 RVA: 0x0085AF8D File Offset: 0x0085918D
	[return: Nullable(2)]
	public string GetStringValueByWorld(string key)
	{
		BlackboardMap.BlackboardParam value = this.WorldBlackboard.GetValue(key);
		if (value == null)
		{
			return null;
		}
		return value.GetStringValue();
	}

	// Token: 0x0601DD17 RID: 122135 RVA: 0x0085AFA8 File Offset: 0x008591A8
	public void SetStringValueByWorld(string key, string value)
	{
		BlackboardMap.BlackboardParam blackboardParam = this.WorldBlackboard.GetValue(key);
		if (blackboardParam != null)
		{
			blackboardParam.SetStringValue(value);
			return;
		}
		blackboardParam = new BlackboardMap.BlackboardParam(BlackboardParamType.String);
		blackboardParam.SetStringValue(value);
		this.WorldBlackboard.SetValue(key, blackboardParam);
	}

	// Token: 0x0601DD18 RID: 122136 RVA: 0x0085AFE8 File Offset: 0x008591E8
	[return: Nullable(new byte[]
	{
		2,
		1
	})]
	public IList<string> GetStringValuesByWorld(string key)
	{
		BlackboardMap.BlackboardParam value = this.WorldBlackboard.GetValue(key);
		if (value == null)
		{
			return null;
		}
		return value.GetStringValues();
	}

	// Token: 0x0601DD19 RID: 122137 RVA: 0x0085B004 File Offset: 0x00859204
	public void SetStringValuesByWorld(string key, string[] values)
	{
		BlackboardMap.BlackboardParam blackboardParam = this.WorldBlackboard.GetValue(key);
		if (blackboardParam != null)
		{
			blackboardParam.SetStringValues(values);
			return;
		}
		blackboardParam = new BlackboardMap.BlackboardParam(BlackboardParamType.StringArray);
		blackboardParam.SetStringValues(values);
		this.WorldBlackboard.SetValue(key, blackboardParam);
	}

	// Token: 0x0601DD1A RID: 122138 RVA: 0x0085B044 File Offset: 0x00859244
	public void SetValueByWorld(string key, BlackboardMap.BlackboardParam blackboard)
	{
		this.WorldBlackboard.SetValue(key, blackboard);
	}

	// Token: 0x0601DD1B RID: 122139 RVA: 0x0085B053 File Offset: 0x00859253
	public void RemoveValueByWorld(string key)
	{
		this.WorldBlackboard.RemoveValue(key);
	}

	// Token: 0x0601DD1C RID: 122140 RVA: 0x0085B064 File Offset: 0x00859264
	public void SetVectorValueByWorld(string key, float x, float y, float z)
	{
		BlackboardMap.BlackboardParam blackboardParam = this.WorldBlackboard.GetValue(key);
		if (blackboardParam != null)
		{
			blackboardParam.SetVectorValue(x, y, z);
			return;
		}
		blackboardParam = new BlackboardMap.BlackboardParam(BlackboardParamType.Vector);
		blackboardParam.SetVectorValue(x, y, z);
		this.WorldBlackboard.SetValue(key, blackboardParam);
	}

	// Token: 0x0601DD1D RID: 122141 RVA: 0x0085B0AB File Offset: 0x008592AB
	[return: Nullable(2)]
	public Aki.Protocol.Vector GetVectorValueByWorld(string key)
	{
		BlackboardMap.BlackboardParam value = this.WorldBlackboard.GetValue(key);
		if (value == null)
		{
			return null;
		}
		return value.GetVectorValue();
	}

	// Token: 0x0601DD1E RID: 122142 RVA: 0x0085B0C4 File Offset: 0x008592C4
	public int? GetIntValueByEntity(int entityId, string key)
	{
		CreatureDataComponent creatureDataComponent = this.GetCreatureDataComponent(entityId);
		if (creatureDataComponent == null)
		{
			return null;
		}
		BlackboardMap blackboard = creatureDataComponent.GetBlackboard();
		BlackboardMap.BlackboardParam blackboardParam = (blackboard != null) ? blackboard.GetValue(key) : null;
		if (blackboardParam == null)
		{
			return null;
		}
		return new int?(blackboardParam.GetIntValue());
	}

	// Token: 0x0601DD1F RID: 122143 RVA: 0x0085B114 File Offset: 0x00859314
	public void SetIntValueByEntity(int entityId, string key, int value)
	{
		CreatureDataComponent creatureDataComponent = this.GetCreatureDataComponent(entityId);
		if (creatureDataComponent == null)
		{
			return;
		}
		BlackboardMap blackboard = creatureDataComponent.GetBlackboard();
		if (blackboard == null)
		{
			return;
		}
		BlackboardMap.BlackboardParam blackboardParam = blackboard.GetValue(key);
		if (blackboardParam != null)
		{
			BlackboardMap.CheckValueType(key, blackboardParam, BlackboardParamType.Int);
			blackboardParam.SetIntValue(value);
			return;
		}
		blackboardParam = new BlackboardMap.BlackboardParam(BlackboardParamType.Int);
		blackboardParam.SetIntValue(value);
		blackboard.SetValue(key, blackboardParam);
	}

	// Token: 0x0601DD20 RID: 122144 RVA: 0x0085B16C File Offset: 0x0085936C
	[return: Nullable(2)]
	public IList<int> GetIntValuesByEntity(int entityId, string key)
	{
		CreatureDataComponent creatureDataComponent = this.GetCreatureDataComponent(entityId);
		if (creatureDataComponent == null)
		{
			return null;
		}
		BlackboardMap blackboard = creatureDataComponent.GetBlackboard();
		BlackboardMap.BlackboardParam blackboardParam = (blackboard != null) ? blackboard.GetValue(key) : null;
		if (blackboardParam == null)
		{
			return null;
		}
		return blackboardParam.GetIntValues();
	}

	// Token: 0x0601DD21 RID: 122145 RVA: 0x0085B1A4 File Offset: 0x008593A4
	public void SetIntValuesByEntity(int entityId, string key, IList<int> values)
	{
		CreatureDataComponent creatureDataComponent = this.GetCreatureDataComponent(entityId);
		if (creatureDataComponent == null)
		{
			return;
		}
		BlackboardMap blackboard = creatureDataComponent.GetBlackboard();
		if (blackboard == null)
		{
			return;
		}
		BlackboardMap.BlackboardParam blackboardParam = blackboard.GetValue(key);
		if (blackboardParam != null)
		{
			BlackboardMap.CheckValueType(key, blackboardParam, BlackboardParamType.IntArray);
			blackboardParam.SetIntValues(values);
			return;
		}
		blackboardParam = new BlackboardMap.BlackboardParam(BlackboardParamType.IntArray);
		blackboardParam.SetIntValues(values);
		blackboard.SetValue(key, blackboardParam);
	}

	// Token: 0x0601DD22 RID: 122146 RVA: 0x0085B1FC File Offset: 0x008593FC
	public long? GetLongValueByEntity(int entityId, string key)
	{
		CreatureDataComponent creatureDataComponent = this.GetCreatureDataComponent(entityId);
		if (creatureDataComponent == null)
		{
			return null;
		}
		BlackboardMap blackboard = creatureDataComponent.GetBlackboard();
		BlackboardMap.BlackboardParam blackboardParam = (blackboard != null) ? blackboard.GetValue(key) : null;
		if (blackboardParam == null)
		{
			return null;
		}
		return blackboardParam.GetLongValue();
	}

	// Token: 0x0601DD23 RID: 122147 RVA: 0x0085B244 File Offset: 0x00859444
	public void SetLongValueByEntity(int entityId, string key, long value)
	{
		CreatureDataComponent creatureDataComponent = this.GetCreatureDataComponent(entityId);
		if (creatureDataComponent == null)
		{
			return;
		}
		BlackboardMap blackboard = creatureDataComponent.GetBlackboard();
		if (blackboard == null)
		{
			return;
		}
		BlackboardMap.BlackboardParam blackboardParam = blackboard.GetValue(key);
		if (blackboardParam != null)
		{
			BlackboardMap.CheckValueType(key, blackboardParam, BlackboardParamType.Long);
			blackboardParam.SetLongValue(value);
			return;
		}
		blackboardParam = new BlackboardMap.BlackboardParam(BlackboardParamType.Long);
		blackboardParam.SetLongValue(value);
		blackboard.SetValue(key, blackboardParam);
	}

	// Token: 0x0601DD24 RID: 122148 RVA: 0x0085B29C File Offset: 0x0085949C
	[return: Nullable(2)]
	public IList<long> GetLongValuesByEntity(int entityId, string key)
	{
		CreatureDataComponent creatureDataComponent = this.GetCreatureDataComponent(entityId);
		if (creatureDataComponent == null)
		{
			return null;
		}
		BlackboardMap blackboard = creatureDataComponent.GetBlackboard();
		BlackboardMap.BlackboardParam blackboardParam = (blackboard != null) ? blackboard.GetValue(key) : null;
		if (blackboardParam == null)
		{
			return null;
		}
		return blackboardParam.GetLongValues();
	}

	// Token: 0x0601DD25 RID: 122149 RVA: 0x0085B2D4 File Offset: 0x008594D4
	public void SetLongValuesByEntity(int entityId, string key, IList<long> values)
	{
		CreatureDataComponent creatureDataComponent = this.GetCreatureDataComponent(entityId);
		if (creatureDataComponent == null)
		{
			return;
		}
		BlackboardMap blackboard = creatureDataComponent.GetBlackboard();
		if (blackboard == null)
		{
			return;
		}
		BlackboardMap.BlackboardParam blackboardParam = blackboard.GetValue(key);
		if (blackboardParam != null)
		{
			BlackboardMap.CheckValueType(key, blackboardParam, BlackboardParamType.LongArray);
			blackboardParam.SetLongValues(values);
			return;
		}
		blackboardParam = new BlackboardMap.BlackboardParam(BlackboardParamType.LongArray);
		blackboardParam.SetLongValues(values);
		blackboard.SetValue(key, blackboardParam);
	}

	// Token: 0x0601DD26 RID: 122150 RVA: 0x0085B32C File Offset: 0x0085952C
	public bool? GetBooleanValueByEntity(int entityId, string key)
	{
		CreatureDataComponent creatureDataComponent = this.GetCreatureDataComponent(entityId);
		if (creatureDataComponent == null)
		{
			return null;
		}
		BlackboardMap blackboard = creatureDataComponent.GetBlackboard();
		BlackboardMap.BlackboardParam blackboardParam = (blackboard != null) ? blackboard.GetValue(key) : null;
		if (blackboardParam == null)
		{
			return null;
		}
		return new bool?(blackboardParam.GetBooleanValue());
	}

	// Token: 0x0601DD27 RID: 122151 RVA: 0x0085B37C File Offset: 0x0085957C
	public void SetBooleanValueByEntity(int entityId, string key, bool value)
	{
		CreatureDataComponent creatureDataComponent = this.GetCreatureDataComponent(entityId);
		if (creatureDataComponent == null)
		{
			return;
		}
		BlackboardMap blackboard = creatureDataComponent.GetBlackboard();
		if (blackboard == null)
		{
			return;
		}
		BlackboardMap.BlackboardParam blackboardParam = blackboard.GetValue(key);
		if (blackboardParam != null)
		{
			BlackboardMap.CheckValueType(key, blackboardParam, BlackboardParamType.Boolean);
			blackboardParam.SetBooleanValue(value);
			return;
		}
		blackboardParam = new BlackboardMap.BlackboardParam(BlackboardParamType.Boolean);
		blackboardParam.SetBooleanValue(value);
		blackboard.SetValue(key, blackboardParam);
	}

	// Token: 0x0601DD28 RID: 122152 RVA: 0x0085B3D4 File Offset: 0x008595D4
	public float? GetFloatValueByEntity(int entityId, string key)
	{
		CreatureDataComponent creatureDataComponent = this.GetCreatureDataComponent(entityId);
		if (creatureDataComponent == null)
		{
			return null;
		}
		BlackboardMap blackboard = creatureDataComponent.GetBlackboard();
		BlackboardMap.BlackboardParam blackboardParam = (blackboard != null) ? blackboard.GetValue(key) : null;
		if (blackboardParam == null)
		{
			return null;
		}
		return new float?(blackboardParam.GetFloatValue());
	}

	// Token: 0x0601DD29 RID: 122153 RVA: 0x0085B424 File Offset: 0x00859624
	public void SetFloatValueByEntity(int entityId, string key, float value)
	{
		CreatureDataComponent creatureDataComponent = this.GetCreatureDataComponent(entityId);
		if (creatureDataComponent == null)
		{
			return;
		}
		BlackboardMap blackboard = creatureDataComponent.GetBlackboard();
		if (blackboard == null)
		{
			return;
		}
		BlackboardMap.BlackboardParam blackboardParam = blackboard.GetValue(key);
		if (blackboardParam != null)
		{
			BlackboardMap.CheckValueType(key, blackboardParam, BlackboardParamType.Float);
			blackboardParam.SetFloatValue(value);
			return;
		}
		blackboardParam = new BlackboardMap.BlackboardParam(BlackboardParamType.Float);
		blackboardParam.SetFloatValue(value);
		blackboard.SetValue(key, blackboardParam);
	}

	// Token: 0x0601DD2A RID: 122154 RVA: 0x0085B47C File Offset: 0x0085967C
	[return: Nullable(2)]
	public IList<float> GetFloatValuesByEntity(int entityId, string key)
	{
		CreatureDataComponent creatureDataComponent = this.GetCreatureDataComponent(entityId);
		if (creatureDataComponent == null)
		{
			return null;
		}
		BlackboardMap blackboard = creatureDataComponent.GetBlackboard();
		BlackboardMap.BlackboardParam blackboardParam = (blackboard != null) ? blackboard.GetValue(key) : null;
		if (blackboardParam == null)
		{
			return null;
		}
		return blackboardParam.GetFloatValues();
	}

	// Token: 0x0601DD2B RID: 122155 RVA: 0x0085B4B4 File Offset: 0x008596B4
	public void SetFloatValuesByEntity(int entityId, string key, IList<float> values)
	{
		CreatureDataComponent creatureDataComponent = this.GetCreatureDataComponent(entityId);
		if (creatureDataComponent == null)
		{
			return;
		}
		BlackboardMap blackboard = creatureDataComponent.GetBlackboard();
		if (blackboard == null)
		{
			return;
		}
		BlackboardMap.BlackboardParam blackboardParam = blackboard.GetValue(key);
		if (blackboardParam != null)
		{
			BlackboardMap.CheckValueType(key, blackboardParam, BlackboardParamType.FloatArray);
			blackboardParam.SetFloatValues(values);
			return;
		}
		blackboardParam = new BlackboardMap.BlackboardParam(BlackboardParamType.FloatArray);
		blackboardParam.SetFloatValues(values);
		blackboard.SetValue(key, blackboardParam);
	}

	// Token: 0x0601DD2C RID: 122156 RVA: 0x0085B50C File Offset: 0x0085970C
	[return: Nullable(2)]
	public string GetStringValueByEntity(int entityId, string key)
	{
		CreatureDataComponent creatureDataComponent = this.GetCreatureDataComponent(entityId);
		if (creatureDataComponent == null)
		{
			return null;
		}
		BlackboardMap blackboard = creatureDataComponent.GetBlackboard();
		BlackboardMap.BlackboardParam blackboardParam = (blackboard != null) ? blackboard.GetValue(key) : null;
		if (blackboardParam == null)
		{
			return null;
		}
		return blackboardParam.GetStringValue();
	}

	// Token: 0x0601DD2D RID: 122157 RVA: 0x0085B544 File Offset: 0x00859744
	public void SetStringValueByEntity(int entityId, string key, string value)
	{
		CreatureDataComponent creatureDataComponent = this.GetCreatureDataComponent(entityId);
		if (creatureDataComponent == null)
		{
			return;
		}
		BlackboardMap blackboard = creatureDataComponent.GetBlackboard();
		if (blackboard == null)
		{
			return;
		}
		BlackboardMap.BlackboardParam blackboardParam = blackboard.GetValue(key);
		if (blackboardParam != null)
		{
			BlackboardMap.CheckValueType(key, blackboardParam, BlackboardParamType.String);
			blackboardParam.SetStringValue(value);
			return;
		}
		blackboardParam = new BlackboardMap.BlackboardParam(BlackboardParamType.String);
		blackboardParam.SetStringValue(value);
		blackboard.SetValue(key, blackboardParam);
	}

	// Token: 0x0601DD2E RID: 122158 RVA: 0x0085B59C File Offset: 0x0085979C
	[return: Nullable(new byte[]
	{
		2,
		1
	})]
	public IList<string> GetStringValuesByEntity(int entityId, string key)
	{
		CreatureDataComponent creatureDataComponent = this.GetCreatureDataComponent(entityId);
		if (creatureDataComponent == null)
		{
			return null;
		}
		BlackboardMap blackboard = creatureDataComponent.GetBlackboard();
		BlackboardMap.BlackboardParam blackboardParam = (blackboard != null) ? blackboard.GetValue(key) : null;
		if (blackboardParam == null)
		{
			return null;
		}
		return blackboardParam.GetStringValues();
	}

	// Token: 0x0601DD2F RID: 122159 RVA: 0x0085B5D4 File Offset: 0x008597D4
	public void SetStringValuesByEntity(int entityId, string key, IList<string> values)
	{
		CreatureDataComponent creatureDataComponent = this.GetCreatureDataComponent(entityId);
		if (creatureDataComponent == null)
		{
			return;
		}
		BlackboardMap blackboard = creatureDataComponent.GetBlackboard();
		if (blackboard == null)
		{
			return;
		}
		BlackboardMap.BlackboardParam blackboardParam = blackboard.GetValue(key);
		if (blackboardParam != null)
		{
			BlackboardMap.CheckValueType(key, blackboardParam, BlackboardParamType.StringArray);
			blackboardParam.SetStringValues(values);
			return;
		}
		blackboardParam = new BlackboardMap.BlackboardParam(BlackboardParamType.StringArray);
		blackboardParam.SetStringValues(values);
		blackboard.SetValue(key, blackboardParam);
	}

	// Token: 0x0601DD30 RID: 122160 RVA: 0x0085B62C File Offset: 0x0085982C
	[return: Nullable(2)]
	public Aki.Protocol.Vector GetVectorValueByEntity(int entityId, string key)
	{
		CreatureDataComponent creatureDataComponent = this.GetCreatureDataComponent(entityId);
		if (creatureDataComponent == null)
		{
			return null;
		}
		BlackboardMap blackboard = creatureDataComponent.GetBlackboard();
		BlackboardMap.BlackboardParam blackboardParam = (blackboard != null) ? blackboard.GetValue(key) : null;
		if (blackboardParam == null)
		{
			return null;
		}
		return blackboardParam.GetVectorValue();
	}

	// Token: 0x0601DD31 RID: 122161 RVA: 0x0085B664 File Offset: 0x00859864
	public void SetVectorValueByEntity(int entityId, string key, float x, float y, float z)
	{
		CreatureDataComponent creatureDataComponent = this.GetCreatureDataComponent(entityId);
		if (creatureDataComponent == null)
		{
			return;
		}
		BlackboardMap blackboard = creatureDataComponent.GetBlackboard();
		if (blackboard == null)
		{
			return;
		}
		BlackboardMap.BlackboardParam blackboardParam = blackboard.GetValue(key);
		if (blackboardParam != null)
		{
			BlackboardMap.CheckValueType(key, blackboardParam, BlackboardParamType.Vector);
			blackboardParam.SetVectorValue(x, y, z);
			return;
		}
		blackboardParam = new BlackboardMap.BlackboardParam(BlackboardParamType.Vector);
		blackboardParam.SetVectorValue(x, y, z);
		blackboard.SetValue(key, blackboardParam);
	}

	// Token: 0x0601DD32 RID: 122162 RVA: 0x0085B6C4 File Offset: 0x008598C4
	[return: Nullable(new byte[]
	{
		2,
		1
	})]
	public IList<Aki.Protocol.Vector> GetVectorValuesByEntity(int entityId, string key)
	{
		CreatureDataComponent creatureDataComponent = this.GetCreatureDataComponent(entityId);
		if (creatureDataComponent == null)
		{
			return null;
		}
		BlackboardMap blackboard = creatureDataComponent.GetBlackboard();
		BlackboardMap.BlackboardParam blackboardParam = (blackboard != null) ? blackboard.GetValue(key) : null;
		if (blackboardParam == null)
		{
			return null;
		}
		return blackboardParam.GetVectorValues();
	}

	// Token: 0x0601DD33 RID: 122163 RVA: 0x0085B6FC File Offset: 0x008598FC
	public void SetVectorValuesByEntity(int entityId, string key, IList<Aki.Protocol.Vector> values)
	{
		CreatureDataComponent creatureDataComponent = this.GetCreatureDataComponent(entityId);
		if (creatureDataComponent == null)
		{
			return;
		}
		BlackboardMap blackboard = creatureDataComponent.GetBlackboard();
		if (blackboard == null)
		{
			return;
		}
		BlackboardMap.BlackboardParam blackboardParam = blackboard.GetValue(key);
		if (blackboardParam != null)
		{
			BlackboardMap.CheckValueType(key, blackboardParam, BlackboardParamType.VectorArray);
			blackboardParam.SetVectorValues(values);
			return;
		}
		blackboardParam = new BlackboardMap.BlackboardParam(BlackboardParamType.VectorArray);
		blackboardParam.SetVectorValues(values);
		blackboard.SetValue(key, blackboardParam);
	}

	// Token: 0x0601DD34 RID: 122164 RVA: 0x0085B754 File Offset: 0x00859954
	[return: Nullable(2)]
	public Aki.Protocol.Rotator GetRotatorValueByEntity(int entityId, string key)
	{
		CreatureDataComponent creatureDataComponent = this.GetCreatureDataComponent(entityId);
		if (creatureDataComponent == null)
		{
			return null;
		}
		BlackboardMap blackboard = creatureDataComponent.GetBlackboard();
		BlackboardMap.BlackboardParam blackboardParam = (blackboard != null) ? blackboard.GetValue(key) : null;
		if (blackboardParam == null)
		{
			return null;
		}
		return blackboardParam.GetRotatorValue();
	}

	// Token: 0x0601DD35 RID: 122165 RVA: 0x0085B78C File Offset: 0x0085998C
	public void SetRotatorValueByEntity(int entityId, string key, float pitch, float roll, float yaw)
	{
		CreatureDataComponent creatureDataComponent = this.GetCreatureDataComponent(entityId);
		if (creatureDataComponent == null)
		{
			return;
		}
		BlackboardMap blackboard = creatureDataComponent.GetBlackboard();
		if (blackboard == null)
		{
			return;
		}
		BlackboardMap.BlackboardParam blackboardParam = blackboard.GetValue(key);
		if (blackboardParam != null)
		{
			BlackboardMap.CheckValueType(key, blackboardParam, BlackboardParamType.Rotator);
			blackboardParam.SetRotatorValue(pitch, roll, yaw);
			return;
		}
		blackboardParam = new BlackboardMap.BlackboardParam(BlackboardParamType.Rotator);
		blackboardParam.SetRotatorValue(pitch, roll, yaw);
		blackboard.SetValue(key, blackboardParam);
	}

	// Token: 0x0601DD36 RID: 122166 RVA: 0x0085B7EC File Offset: 0x008599EC
	[return: Nullable(new byte[]
	{
		2,
		1
	})]
	public IList<Aki.Protocol.Rotator> GetRotatorValuesByEntity(int entityId, string key)
	{
		CreatureDataComponent creatureDataComponent = this.GetCreatureDataComponent(entityId);
		if (creatureDataComponent == null)
		{
			return null;
		}
		BlackboardMap blackboard = creatureDataComponent.GetBlackboard();
		BlackboardMap.BlackboardParam blackboardParam = (blackboard != null) ? blackboard.GetValue(key) : null;
		if (blackboardParam == null)
		{
			return null;
		}
		return blackboardParam.GetRotatorValues();
	}

	// Token: 0x0601DD37 RID: 122167 RVA: 0x0085B824 File Offset: 0x00859A24
	public void SetRotatorValuesByEntity(int entityId, string key, IList<Aki.Protocol.Rotator> values)
	{
		CreatureDataComponent creatureDataComponent = this.GetCreatureDataComponent(entityId);
		if (creatureDataComponent == null)
		{
			return;
		}
		BlackboardMap blackboard = creatureDataComponent.GetBlackboard();
		if (blackboard == null)
		{
			return;
		}
		BlackboardMap.BlackboardParam blackboardParam = blackboard.GetValue(key);
		if (blackboardParam != null)
		{
			BlackboardMap.CheckValueType(key, blackboardParam, BlackboardParamType.RotatorArray);
			blackboardParam.SetRotatorValues(values);
			return;
		}
		blackboardParam = new BlackboardMap.BlackboardParam(BlackboardParamType.RotatorArray);
		blackboardParam.SetRotatorValues(values);
		blackboard.SetValue(key, blackboardParam);
	}

	// Token: 0x0601DD38 RID: 122168 RVA: 0x0085B87C File Offset: 0x00859A7C
	public long? GetEntityIdByEntity(int entityId, string key)
	{
		CreatureDataComponent creatureDataComponent = this.GetCreatureDataComponent(entityId);
		if (creatureDataComponent == null)
		{
			return null;
		}
		BlackboardMap blackboard = creatureDataComponent.GetBlackboard();
		BlackboardMap.BlackboardParam blackboardParam = (blackboard != null) ? blackboard.GetValue(key) : null;
		if (blackboardParam == null)
		{
			return null;
		}
		return blackboardParam.GetLongValue();
	}

	// Token: 0x0601DD39 RID: 122169 RVA: 0x0085B8C4 File Offset: 0x00859AC4
	public void SetEntityIdByEntity(int entityId, string key, long value)
	{
		CreatureDataComponent creatureDataComponent = this.GetCreatureDataComponent(entityId);
		if (creatureDataComponent == null)
		{
			return;
		}
		BlackboardMap blackboard = creatureDataComponent.GetBlackboard();
		if (blackboard == null)
		{
			return;
		}
		BlackboardMap.BlackboardParam blackboardParam = blackboard.GetValue(key);
		if (blackboardParam != null)
		{
			BlackboardMap.CheckValueType(key, blackboardParam, BlackboardParamType.Entity);
			blackboardParam.SetLongValue(value);
			return;
		}
		blackboardParam = new BlackboardMap.BlackboardParam(BlackboardParamType.Entity);
		blackboardParam.SetLongValue(value);
		blackboard.SetValue(key, blackboardParam);
	}

	// Token: 0x0601DD3A RID: 122170 RVA: 0x0085B91C File Offset: 0x00859B1C
	[return: Nullable(2)]
	public IList<int> GetEntityIdsByEntity(int entityId, string key)
	{
		CreatureDataComponent creatureDataComponent = this.GetCreatureDataComponent(entityId);
		if (creatureDataComponent == null)
		{
			return null;
		}
		BlackboardMap blackboard = creatureDataComponent.GetBlackboard();
		BlackboardMap.BlackboardParam blackboardParam = (blackboard != null) ? blackboard.GetValue(key) : null;
		if (blackboardParam == null)
		{
			return null;
		}
		return blackboardParam.GetIntValues();
	}

	// Token: 0x0601DD3B RID: 122171 RVA: 0x0085B954 File Offset: 0x00859B54
	public void SetEntityIdsByEntity(int entityId, string key, IList<int> values)
	{
		CreatureDataComponent creatureDataComponent = this.GetCreatureDataComponent(entityId);
		if (creatureDataComponent == null)
		{
			return;
		}
		BlackboardMap blackboard = creatureDataComponent.GetBlackboard();
		if (blackboard == null)
		{
			return;
		}
		BlackboardMap.BlackboardParam blackboardParam = blackboard.GetValue(key);
		if (blackboardParam != null)
		{
			BlackboardMap.CheckValueType(key, blackboardParam, BlackboardParamType.EntityArray);
			blackboardParam.SetIntValues(values);
			return;
		}
		blackboardParam = new BlackboardMap.BlackboardParam(BlackboardParamType.EntityArray);
		blackboardParam.SetIntValues(values);
		blackboard.SetValue(key, blackboardParam);
	}

	// Token: 0x0601DD3C RID: 122172 RVA: 0x0085B9AC File Offset: 0x00859BAC
	public void SetValueByEntity(int entityId, string key, BlackboardMap.BlackboardParam blackboard)
	{
		CreatureDataComponent creatureDataComponent = this.GetCreatureDataComponent(entityId);
		if (creatureDataComponent == null)
		{
			return;
		}
		creatureDataComponent.SetBlackboard(key, blackboard);
	}

	// Token: 0x17002913 RID: 10515
	// (get) Token: 0x0601DD3D RID: 122173 RVA: 0x0085B9CD File Offset: 0x00859BCD
	public static BlackboardModel Instance
	{
		get
		{
			return BlackboardModel._Instance;
		}
	}

	// Token: 0x0601DD3E RID: 122174 RVA: 0x0085B9D4 File Offset: 0x00859BD4
	public static BlackboardModel GetOrCreateInstance()
	{
		if (BlackboardModel._Instance == null)
		{
			BlackboardModel.CreateInstance();
		}
		return BlackboardModel._Instance;
	}

	// Token: 0x0601DD3F RID: 122175 RVA: 0x0085B9E8 File Offset: 0x00859BE8
	public static bool CreateInstance()
	{
		if (BlackboardModel._Instance != null)
		{
			return true;
		}
		BlackboardModel._Instance = new BlackboardModel();
		return true;
	}

	// Token: 0x0601DD40 RID: 122176 RVA: 0x0085B9FE File Offset: 0x00859BFE
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x0601DD41 RID: 122177 RVA: 0x0085BA00 File Offset: 0x00859C00
	public static void ResetStaticDefaultValue()
	{
		BlackboardModel._Instance = null;
	}

	// Token: 0x0601DD42 RID: 122178 RVA: 0x0085BA08 File Offset: 0x00859C08
	static BlackboardModel()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(BlackboardModel.CreateStaticDefaultValue), new Action(BlackboardModel.ResetStaticDefaultValue));
	}

	// Token: 0x0400E9F4 RID: 59892
	private readonly BlackboardMap GlobalBlackboard = new BlackboardMap();

	// Token: 0x0400E9F5 RID: 59893
	private readonly BlackboardMap WorldBlackboard = new BlackboardMap();

	// Token: 0x0400E9F6 RID: 59894
	private readonly Dictionary<int, CreatureDataComponent> CreatureDataComponentMap = new Dictionary<int, CreatureDataComponent>();

	// Token: 0x0400E9F7 RID: 59895
	[Nullable(2)]
	private static BlackboardModel _Instance;
}
