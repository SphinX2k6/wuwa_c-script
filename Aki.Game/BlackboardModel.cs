using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;

// Token: 0x02002A90 RID: 10896
[NullableContext(1)]
[Nullable(0)]
[Model(0)]
public class BlackboardModel : ModelBase
{
	// Token: 0x0601BA0A RID: 113162 RVA: 0x00882DF1 File Offset: 0x00880FF1
	protected override bool OnClear()
	{
		this.GlobalBlackboard.Clear();
		this.WorldBlackboard.Clear();
		this.CreatureDataComponentMap.Clear();
		return true;
	}

	// Token: 0x0601BA0B RID: 113163 RVA: 0x00882E18 File Offset: 0x00881018
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

	// Token: 0x0601BA0C RID: 113164 RVA: 0x00882E87 File Offset: 0x00881087
	public void RemoveCreatureDataComponent(int entityId)
	{
		if (this.CreatureDataComponentMap.ContainsKey(entityId))
		{
			this.CreatureDataComponentMap.Remove(entityId);
		}
	}

	// Token: 0x0601BA0D RID: 113165 RVA: 0x00882EA4 File Offset: 0x008810A4
	public int? GetIntValueByGlobal(string key)
	{
		BlackboardMap.BlackboardParam value = this.GlobalBlackboard.GetValue(key);
		if (value == null)
		{
			return null;
		}
		return new int?(value.GetIntValue());
	}

	// Token: 0x0601BA0E RID: 113166 RVA: 0x00882ED8 File Offset: 0x008810D8
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

	// Token: 0x0601BA0F RID: 113167 RVA: 0x00882F18 File Offset: 0x00881118
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

	// Token: 0x0601BA10 RID: 113168 RVA: 0x00882F34 File Offset: 0x00881134
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

	// Token: 0x0601BA11 RID: 113169 RVA: 0x00882F74 File Offset: 0x00881174
	public long? GetLongValueByGlobal(string key)
	{
		BlackboardMap.BlackboardParam value = this.GlobalBlackboard.GetValue(key);
		if (value == null)
		{
			return null;
		}
		return value.GetLongValue();
	}

	// Token: 0x0601BA12 RID: 113170 RVA: 0x00882FA0 File Offset: 0x008811A0
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

	// Token: 0x0601BA13 RID: 113171 RVA: 0x00882FE0 File Offset: 0x008811E0
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

	// Token: 0x0601BA14 RID: 113172 RVA: 0x00882FFC File Offset: 0x008811FC
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

	// Token: 0x0601BA15 RID: 113173 RVA: 0x0088303C File Offset: 0x0088123C
	public bool? GetBooleanValueByGlobal(string key)
	{
		BlackboardMap.BlackboardParam value = this.GlobalBlackboard.GetValue(key);
		if (value == null)
		{
			return null;
		}
		return new bool?(value.GetBooleanValue());
	}

	// Token: 0x0601BA16 RID: 113174 RVA: 0x00883070 File Offset: 0x00881270
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

	// Token: 0x0601BA17 RID: 113175 RVA: 0x008830B0 File Offset: 0x008812B0
	public float? GetFloatValueByGlobal(string key)
	{
		BlackboardMap.BlackboardParam value = this.GlobalBlackboard.GetValue(key);
		if (value == null)
		{
			return null;
		}
		return new float?(value.GetFloatValue());
	}

	// Token: 0x0601BA18 RID: 113176 RVA: 0x008830E4 File Offset: 0x008812E4
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

	// Token: 0x0601BA19 RID: 113177 RVA: 0x00883124 File Offset: 0x00881324
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

	// Token: 0x0601BA1A RID: 113178 RVA: 0x00883140 File Offset: 0x00881340
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

	// Token: 0x0601BA1B RID: 113179 RVA: 0x00883181 File Offset: 0x00881381
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

	// Token: 0x0601BA1C RID: 113180 RVA: 0x0088319C File Offset: 0x0088139C
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

	// Token: 0x0601BA1D RID: 113181 RVA: 0x008831DC File Offset: 0x008813DC
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

	// Token: 0x0601BA1E RID: 113182 RVA: 0x008831F8 File Offset: 0x008813F8
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

	// Token: 0x0601BA1F RID: 113183 RVA: 0x00883238 File Offset: 0x00881438
	public void SetValueByGlobal(string key, BlackboardMap.BlackboardParam blackboard)
	{
		this.GlobalBlackboard.SetValue(key, blackboard);
	}

	// Token: 0x0601BA20 RID: 113184 RVA: 0x00883247 File Offset: 0x00881447
	public void RemoveValueByGlobal(string key)
	{
		this.GlobalBlackboard.RemoveValue(key);
	}

	// Token: 0x0601BA21 RID: 113185 RVA: 0x00883256 File Offset: 0x00881456
	public void SetWorldBlackboardByProtocol(IList<BlackboardParam> worldBlackboard)
	{
	}

	// Token: 0x0601BA22 RID: 113186 RVA: 0x00883258 File Offset: 0x00881458
	public int? GetIntValueByWorld(string key)
	{
		BlackboardMap.BlackboardParam value = this.WorldBlackboard.GetValue(key);
		if (value == null)
		{
			return null;
		}
		return new int?(value.GetIntValue());
	}

	// Token: 0x0601BA23 RID: 113187 RVA: 0x0088328C File Offset: 0x0088148C
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

	// Token: 0x0601BA24 RID: 113188 RVA: 0x008832CC File Offset: 0x008814CC
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

	// Token: 0x0601BA25 RID: 113189 RVA: 0x008832E8 File Offset: 0x008814E8
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

	// Token: 0x0601BA26 RID: 113190 RVA: 0x00883328 File Offset: 0x00881528
	public long? GetLongValueByWorld(string key)
	{
		BlackboardMap.BlackboardParam value = this.WorldBlackboard.GetValue(key);
		if (value == null)
		{
			return null;
		}
		return value.GetLongValue();
	}

	// Token: 0x0601BA27 RID: 113191 RVA: 0x00883354 File Offset: 0x00881554
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

	// Token: 0x0601BA28 RID: 113192 RVA: 0x00883394 File Offset: 0x00881594
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

	// Token: 0x0601BA29 RID: 113193 RVA: 0x008833B0 File Offset: 0x008815B0
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

	// Token: 0x0601BA2A RID: 113194 RVA: 0x008833F0 File Offset: 0x008815F0
	public bool? GetBooleanValueByWorld(string key)
	{
		BlackboardMap.BlackboardParam value = this.WorldBlackboard.GetValue(key);
		if (value == null)
		{
			return null;
		}
		return new bool?(value.GetBooleanValue());
	}

	// Token: 0x0601BA2B RID: 113195 RVA: 0x00883424 File Offset: 0x00881624
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

	// Token: 0x0601BA2C RID: 113196 RVA: 0x00883464 File Offset: 0x00881664
	public float? GetFloatValueByWorld(string key)
	{
		BlackboardMap.BlackboardParam value = this.WorldBlackboard.GetValue(key);
		if (value == null)
		{
			return null;
		}
		return new float?(value.GetFloatValue());
	}

	// Token: 0x0601BA2D RID: 113197 RVA: 0x00883498 File Offset: 0x00881698
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

	// Token: 0x0601BA2E RID: 113198 RVA: 0x008834D8 File Offset: 0x008816D8
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

	// Token: 0x0601BA2F RID: 113199 RVA: 0x008834F4 File Offset: 0x008816F4
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

	// Token: 0x0601BA30 RID: 113200 RVA: 0x00883535 File Offset: 0x00881735
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

	// Token: 0x0601BA31 RID: 113201 RVA: 0x00883550 File Offset: 0x00881750
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

	// Token: 0x0601BA32 RID: 113202 RVA: 0x00883590 File Offset: 0x00881790
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

	// Token: 0x0601BA33 RID: 113203 RVA: 0x008835AC File Offset: 0x008817AC
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

	// Token: 0x0601BA34 RID: 113204 RVA: 0x008835EC File Offset: 0x008817EC
	public void SetValueByWorld(string key, BlackboardMap.BlackboardParam blackboard)
	{
		this.WorldBlackboard.SetValue(key, blackboard);
	}

	// Token: 0x0601BA35 RID: 113205 RVA: 0x008835FB File Offset: 0x008817FB
	public void RemoveValueByWorld(string key)
	{
		this.WorldBlackboard.RemoveValue(key);
	}

	// Token: 0x0601BA36 RID: 113206 RVA: 0x0088360C File Offset: 0x0088180C
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

	// Token: 0x0601BA37 RID: 113207 RVA: 0x00883653 File Offset: 0x00881853
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

	// Token: 0x0601BA38 RID: 113208 RVA: 0x0088366C File Offset: 0x0088186C
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

	// Token: 0x0601BA39 RID: 113209 RVA: 0x008836BC File Offset: 0x008818BC
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

	// Token: 0x0601BA3A RID: 113210 RVA: 0x00883714 File Offset: 0x00881914
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

	// Token: 0x0601BA3B RID: 113211 RVA: 0x0088374C File Offset: 0x0088194C
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

	// Token: 0x0601BA3C RID: 113212 RVA: 0x008837A4 File Offset: 0x008819A4
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

	// Token: 0x0601BA3D RID: 113213 RVA: 0x008837EC File Offset: 0x008819EC
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

	// Token: 0x0601BA3E RID: 113214 RVA: 0x00883844 File Offset: 0x00881A44
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

	// Token: 0x0601BA3F RID: 113215 RVA: 0x0088387C File Offset: 0x00881A7C
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

	// Token: 0x0601BA40 RID: 113216 RVA: 0x008838D4 File Offset: 0x00881AD4
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

	// Token: 0x0601BA41 RID: 113217 RVA: 0x00883924 File Offset: 0x00881B24
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

	// Token: 0x0601BA42 RID: 113218 RVA: 0x0088397C File Offset: 0x00881B7C
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

	// Token: 0x0601BA43 RID: 113219 RVA: 0x008839CC File Offset: 0x00881BCC
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

	// Token: 0x0601BA44 RID: 113220 RVA: 0x00883A24 File Offset: 0x00881C24
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

	// Token: 0x0601BA45 RID: 113221 RVA: 0x00883A5C File Offset: 0x00881C5C
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

	// Token: 0x0601BA46 RID: 113222 RVA: 0x00883AB4 File Offset: 0x00881CB4
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

	// Token: 0x0601BA47 RID: 113223 RVA: 0x00883AEC File Offset: 0x00881CEC
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

	// Token: 0x0601BA48 RID: 113224 RVA: 0x00883B44 File Offset: 0x00881D44
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

	// Token: 0x0601BA49 RID: 113225 RVA: 0x00883B7C File Offset: 0x00881D7C
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

	// Token: 0x0601BA4A RID: 113226 RVA: 0x00883BD4 File Offset: 0x00881DD4
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

	// Token: 0x0601BA4B RID: 113227 RVA: 0x00883C0C File Offset: 0x00881E0C
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

	// Token: 0x0601BA4C RID: 113228 RVA: 0x00883C6C File Offset: 0x00881E6C
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

	// Token: 0x0601BA4D RID: 113229 RVA: 0x00883CA4 File Offset: 0x00881EA4
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

	// Token: 0x0601BA4E RID: 113230 RVA: 0x00883CFC File Offset: 0x00881EFC
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

	// Token: 0x0601BA4F RID: 113231 RVA: 0x00883D34 File Offset: 0x00881F34
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

	// Token: 0x0601BA50 RID: 113232 RVA: 0x00883D94 File Offset: 0x00881F94
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

	// Token: 0x0601BA51 RID: 113233 RVA: 0x00883DCC File Offset: 0x00881FCC
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

	// Token: 0x0601BA52 RID: 113234 RVA: 0x00883E24 File Offset: 0x00882024
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

	// Token: 0x0601BA53 RID: 113235 RVA: 0x00883E6C File Offset: 0x0088206C
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

	// Token: 0x0601BA54 RID: 113236 RVA: 0x00883EC4 File Offset: 0x008820C4
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

	// Token: 0x0601BA55 RID: 113237 RVA: 0x00883EFC File Offset: 0x008820FC
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

	// Token: 0x0601BA56 RID: 113238 RVA: 0x00883F54 File Offset: 0x00882154
	public void SetValueByEntity(int entityId, string key, BlackboardMap.BlackboardParam blackboard)
	{
		CreatureDataComponent creatureDataComponent = this.GetCreatureDataComponent(entityId);
		if (creatureDataComponent == null)
		{
			return;
		}
		creatureDataComponent.SetBlackboard(key, blackboard);
	}

	// Token: 0x17002CAC RID: 11436
	// (get) Token: 0x0601BA57 RID: 113239 RVA: 0x00883F75 File Offset: 0x00882175
	public static BlackboardModel Instance
	{
		get
		{
			return BlackboardModel._Instance;
		}
	}

	// Token: 0x0601BA58 RID: 113240 RVA: 0x00883F7C File Offset: 0x0088217C
	public static BlackboardModel GetOrCreateInstance()
	{
		if (BlackboardModel._Instance == null)
		{
			BlackboardModel.CreateInstance();
		}
		return BlackboardModel._Instance;
	}

	// Token: 0x0601BA59 RID: 113241 RVA: 0x00883F90 File Offset: 0x00882190
	public static bool CreateInstance()
	{
		if (BlackboardModel._Instance != null)
		{
			return true;
		}
		BlackboardModel._Instance = new BlackboardModel();
		return true;
	}

	// Token: 0x0601BA5A RID: 113242 RVA: 0x00883FA6 File Offset: 0x008821A6
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x0601BA5B RID: 113243 RVA: 0x00883FA8 File Offset: 0x008821A8
	public static void ResetStaticDefaultValue()
	{
		BlackboardModel._Instance = null;
	}

	// Token: 0x0601BA5C RID: 113244 RVA: 0x00883FB0 File Offset: 0x008821B0
	static BlackboardModel()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(BlackboardModel.CreateStaticDefaultValue), new Action(BlackboardModel.ResetStaticDefaultValue));
	}

	// Token: 0x0400EEAF RID: 61103
	private readonly BlackboardMap GlobalBlackboard = new BlackboardMap();

	// Token: 0x0400EEB0 RID: 61104
	private readonly BlackboardMap WorldBlackboard = new BlackboardMap();

	// Token: 0x0400EEB1 RID: 61105
	private readonly Dictionary<int, CreatureDataComponent> CreatureDataComponentMap = new Dictionary<int, CreatureDataComponent>();

	// Token: 0x0400EEB2 RID: 61106
	[Nullable(2)]
	private static BlackboardModel _Instance;
}
