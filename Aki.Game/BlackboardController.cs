using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;
using Google.Protobuf;

// Token: 0x02002A4A RID: 10826
[NullableContext(1)]
[Nullable(0)]
[Controller(0)]
public class BlackboardController : ControllerBase
{
	// Token: 0x0601B5DC RID: 112092 RVA: 0x008669D4 File Offset: 0x00864BD4
	protected override bool OnInit()
	{
		Net.Instance.Register(ENotifyMessageId.WorldBlackboardNotify, new Action<IMessage, Net.CallbackStatus>(this.WorldBlackboardNotify));
		Net.Instance.Register(ENotifyMessageId.EntityBlackboardNotify, new Action<IMessage, Net.CallbackStatus>(this.EntityBlackboardNotify));
		EventSystem.Instance.Add(EEventName.RemoveCreatureDataComponentCache, new Action<int>(this.OnRemoveCreatureDataComponent));
		return true;
	}

	// Token: 0x0601B5DD RID: 112093 RVA: 0x00866A36 File Offset: 0x00864C36
	protected override bool OnClear()
	{
		Net.Instance.UnRegister(ENotifyMessageId.WorldBlackboardNotify);
		Net.Instance.UnRegister(ENotifyMessageId.EntityBlackboardNotify);
		EventSystem.Instance.Remove(EEventName.RemoveCreatureDataComponentCache, new Action<int>(this.OnRemoveCreatureDataComponent));
		return true;
	}

	// Token: 0x0601B5DE RID: 112094 RVA: 0x00866A75 File Offset: 0x00864C75
	private void OnRemoveCreatureDataComponent(int entityId)
	{
		BlackboardModel.Instance.RemoveCreatureDataComponent(entityId);
	}

	// Token: 0x0601B5DF RID: 112095 RVA: 0x00866A84 File Offset: 0x00864C84
	private void WorldBlackboardPush(IList<BlackboardParam> blackboardFields)
	{
		WorldBlackboardRequest worldBlackboardRequest = new WorldBlackboardRequest();
		worldBlackboardRequest.Params.AddRange(blackboardFields);
		Net.Instance.Call(ERequestMessageId.WorldBlackboardRequest, worldBlackboardRequest, delegate(IMessage response, Net.CallbackStatus _)
		{
		}, 0);
	}

	// Token: 0x0601B5E0 RID: 112096 RVA: 0x00866AD4 File Offset: 0x00864CD4
	[NullableContext(2)]
	private void WorldBlackboardNotify(IMessage msg, Net.CallbackStatus status)
	{
		WorldBlackboardNotify worldBlackboardNotify = (WorldBlackboardNotify)msg;
		this.SetWorldBlackboardsByProtocol(worldBlackboardNotify.Params);
	}

	// Token: 0x0601B5E1 RID: 112097 RVA: 0x00866AF4 File Offset: 0x00864CF4
	private void EntityBlackboardPush(long creatureDataId, IList<BlackboardParam> blackboardFields)
	{
		if (!this.IsNetworkMode())
		{
			return;
		}
		new EntityBlackboardRequest
		{
			EntityId = creatureDataId
		}.Params.AddRange(blackboardFields);
		if (GameModeModel.Instance.IsMulti)
		{
			this.PushBlackboardParam(creatureDataId, blackboardFields);
		}
	}

	// Token: 0x0601B5E2 RID: 112098 RVA: 0x00866B2C File Offset: 0x00864D2C
	public void PushBlackboardParam(long creatureDataId, IList<BlackboardParam> blackboardFields)
	{
		Dictionary<string, BlackboardParam> dictionary;
		if (!this.PendingBlackboardParams.TryGetValue(creatureDataId, out dictionary))
		{
			dictionary = new Dictionary<string, BlackboardParam>();
			this.PendingBlackboardParams[creatureDataId] = dictionary;
		}
		foreach (BlackboardParam blackboardParam in blackboardFields)
		{
			if (AiConfig.Instance.CheckBlackboardWhiteList(blackboardParam.Key))
			{
				dictionary[blackboardParam.Key] = blackboardParam;
			}
		}
	}

	// Token: 0x0601B5E3 RID: 112099 RVA: 0x00866BB0 File Offset: 0x00864DB0
	[return: Nullable(2)]
	public object GetBlackboardValue(BlackboardParam blackboardParam)
	{
		switch (blackboardParam.ValueCase)
		{
		case BlackboardParam.ValueOneofCase.IntValue:
			return blackboardParam.IntValue;
		case BlackboardParam.ValueOneofCase.IntValues:
			return blackboardParam.IntValues;
		case BlackboardParam.ValueOneofCase.LongValue:
			return blackboardParam.LongValue;
		case BlackboardParam.ValueOneofCase.LongValues:
			return blackboardParam.LongValues;
		case BlackboardParam.ValueOneofCase.BooleanValue:
			return blackboardParam.BooleanValue;
		case BlackboardParam.ValueOneofCase.StringValue:
			return blackboardParam.StringValue;
		case BlackboardParam.ValueOneofCase.StringValues:
			return blackboardParam.StringValues;
		case BlackboardParam.ValueOneofCase.FloatValue:
			return blackboardParam.FloatValue;
		case BlackboardParam.ValueOneofCase.FloatValues:
			return blackboardParam.FloatValues;
		case BlackboardParam.ValueOneofCase.VectorValue:
			return blackboardParam.VectorValue;
		case BlackboardParam.ValueOneofCase.VectorValues:
			return blackboardParam.VectorValues;
		case BlackboardParam.ValueOneofCase.RotatorValue:
			return blackboardParam.RotatorValue;
		case BlackboardParam.ValueOneofCase.RotatorValues:
			return blackboardParam.RotatorValues;
		default:
			return null;
		}
	}

	// Token: 0x0601B5E4 RID: 112100 RVA: 0x00866C74 File Offset: 0x00864E74
	[NullableContext(2)]
	private void EntityBlackboardNotify(IMessage msg, Net.CallbackStatus status)
	{
		EntityBlackboardNotify entityBlackboardNotify = (EntityBlackboardNotify)msg;
		long entityId = entityBlackboardNotify.EntityId;
		EntityHandle entity = CreatureModel.Instance.GetEntity(entityId);
		if (entity == null)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.World;
			ELogAuthor author = ELogAuthor.LFJW;
			string message = "[CreatureController.EntityBlackboardNotify] 不存在实体数据CreatureData。";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("CreatureDataId", entityId);
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return;
		}
		WorldEntity entity2 = entity.Entity;
		CreatureDataComponent creatureDataComponent = (entity2 != null) ? entity2.GetComponent<CreatureDataComponent>() : null;
		if (creatureDataComponent == null)
		{
			return;
		}
		creatureDataComponent.SetBlackboardsByProtocol(entityBlackboardNotify.Params);
	}

	// Token: 0x0601B5E5 RID: 112101 RVA: 0x00866CEC File Offset: 0x00864EEC
	public int? GetIntValueByWorld(string key)
	{
		return BlackboardModel.Instance.GetIntValueByWorld(key);
	}

	// Token: 0x0601B5E6 RID: 112102 RVA: 0x00866CFC File Offset: 0x00864EFC
	public void SetIntValueByWorld(string key, int value)
	{
		BlackboardModel.Instance.SetIntValueByWorld(key, value);
		if (!this.IsNetworkMode())
		{
			return;
		}
		BlackboardParam[] blackboardFields = new BlackboardParam[]
		{
			new BlackboardParam
			{
				Type = BlackboardParamType.Int,
				Key = key,
				IntValue = value
			}
		};
		this.WorldBlackboardPush(blackboardFields);
	}

	// Token: 0x0601B5E7 RID: 112103 RVA: 0x00866D4B File Offset: 0x00864F4B
	[return: Nullable(2)]
	public IList<int> GetIntValuesByWorld(string key)
	{
		return BlackboardModel.Instance.GetIntValuesByWorld(key);
	}

	// Token: 0x0601B5E8 RID: 112104 RVA: 0x00866D58 File Offset: 0x00864F58
	public void SetIntValuesByWorld(string key, int[] values)
	{
		BlackboardModel.Instance.SetIntValuesByWorld(key, values);
		if (!this.IsNetworkMode())
		{
			return;
		}
		BlackboardParam blackboardParam = new BlackboardParam();
		blackboardParam.Type = BlackboardParamType.IntArray;
		blackboardParam.Key = key;
		blackboardParam.IntValues = new IntArrayBlackboard();
		blackboardParam.IntValues.Values.AddRange(values);
		BlackboardParam[] blackboardFields = new BlackboardParam[]
		{
			blackboardParam
		};
		this.WorldBlackboardPush(blackboardFields);
	}

	// Token: 0x0601B5E9 RID: 112105 RVA: 0x00866DBC File Offset: 0x00864FBC
	public long? GetLongValueByWorld(string key)
	{
		return BlackboardModel.Instance.GetLongValueByWorld(key);
	}

	// Token: 0x0601B5EA RID: 112106 RVA: 0x00866DCC File Offset: 0x00864FCC
	public void SetLongValueByWorld(string key, long value)
	{
		BlackboardModel.Instance.SetLongValueByWorld(key, value);
		if (!this.IsNetworkMode())
		{
			return;
		}
		BlackboardParam[] blackboardFields = new BlackboardParam[]
		{
			new BlackboardParam
			{
				Type = BlackboardParamType.Long,
				Key = key,
				LongValue = MathUtils.Instance.BigIntToLong(value)
			}
		};
		this.WorldBlackboardPush(blackboardFields);
	}

	// Token: 0x0601B5EB RID: 112107 RVA: 0x00866E25 File Offset: 0x00865025
	[return: Nullable(2)]
	public IList<long> GetLongValuesByWorld(string key)
	{
		return BlackboardModel.Instance.GetLongValuesByWorld(key);
	}

	// Token: 0x0601B5EC RID: 112108 RVA: 0x00866E34 File Offset: 0x00865034
	public void SetLongValuesByWorld(string key, long[] values)
	{
		BlackboardModel.Instance.SetLongValuesByWorld(key, values);
		if (!this.IsNetworkMode())
		{
			return;
		}
		BlackboardParam blackboardParam = new BlackboardParam();
		blackboardParam.Type = BlackboardParamType.LongArray;
		blackboardParam.Key = key;
		blackboardParam.LongValues = new LongArrayBlackboard();
		for (int i = 0; i < values.Length; i++)
		{
			long item = MathUtils.Instance.BigIntToLong(values[i]);
			blackboardParam.LongValues.Values.Add(item);
		}
		BlackboardParam[] blackboardFields = new BlackboardParam[]
		{
			blackboardParam
		};
		this.WorldBlackboardPush(blackboardFields);
	}

	// Token: 0x0601B5ED RID: 112109 RVA: 0x00866EB4 File Offset: 0x008650B4
	public bool? GetBooleanValueByWorld(string key)
	{
		return BlackboardModel.Instance.GetBooleanValueByWorld(key);
	}

	// Token: 0x0601B5EE RID: 112110 RVA: 0x00866EC4 File Offset: 0x008650C4
	public void SetBooleanValueByWorld(string key, bool value)
	{
		BlackboardModel.Instance.SetBooleanValueByWorld(key, value);
		if (!this.IsNetworkMode())
		{
			return;
		}
		BlackboardParam[] blackboardFields = new BlackboardParam[]
		{
			new BlackboardParam
			{
				Type = BlackboardParamType.Boolean,
				Key = key,
				BooleanValue = value
			}
		};
		this.WorldBlackboardPush(blackboardFields);
	}

	// Token: 0x0601B5EF RID: 112111 RVA: 0x00866F13 File Offset: 0x00865113
	public float? GetFloatValueByWorld(string key)
	{
		return BlackboardModel.Instance.GetFloatValueByWorld(key);
	}

	// Token: 0x0601B5F0 RID: 112112 RVA: 0x00866F20 File Offset: 0x00865120
	public void SetFloatValueByWorld(string key, float value)
	{
		BlackboardModel.Instance.SetFloatValueByWorld(key, value);
		if (!this.IsNetworkMode())
		{
			return;
		}
		BlackboardParam[] blackboardFields = new BlackboardParam[]
		{
			new BlackboardParam
			{
				Type = BlackboardParamType.Float,
				Key = key,
				FloatValue = value
			}
		};
		this.WorldBlackboardPush(blackboardFields);
	}

	// Token: 0x0601B5F1 RID: 112113 RVA: 0x00866F6F File Offset: 0x0086516F
	[return: Nullable(2)]
	public IList<float> GetFloatValuesByWorld(string key)
	{
		return BlackboardModel.Instance.GetFloatValuesByWorld(key);
	}

	// Token: 0x0601B5F2 RID: 112114 RVA: 0x00866F7C File Offset: 0x0086517C
	public void SetFloatValuesByWorld(string key, float[] values)
	{
		BlackboardModel.Instance.SetFloatValuesByWorld(key, values);
		if (!this.IsNetworkMode())
		{
			return;
		}
		BlackboardParam blackboardParam = new BlackboardParam();
		blackboardParam.Type = BlackboardParamType.FloatArray;
		blackboardParam.Key = key;
		blackboardParam.FloatValues = new FloatArrayBlackboard();
		blackboardParam.FloatValues.Values.AddRange(values);
		BlackboardParam[] blackboardFields = new BlackboardParam[]
		{
			blackboardParam
		};
		this.WorldBlackboardPush(blackboardFields);
	}

	// Token: 0x0601B5F3 RID: 112115 RVA: 0x00866FE1 File Offset: 0x008651E1
	[return: Nullable(2)]
	public string GetStringValueByWorld(string key)
	{
		return BlackboardModel.Instance.GetStringValueByWorld(key);
	}

	// Token: 0x0601B5F4 RID: 112116 RVA: 0x00866FF0 File Offset: 0x008651F0
	public void SetStringValueByWorld(string key, string value)
	{
		BlackboardModel.Instance.SetStringValueByWorld(key, value);
		if (!this.IsNetworkMode())
		{
			return;
		}
		BlackboardParam[] blackboardFields = new BlackboardParam[]
		{
			new BlackboardParam
			{
				Type = BlackboardParamType.String,
				Key = key,
				StringValue = value
			}
		};
		this.WorldBlackboardPush(blackboardFields);
	}

	// Token: 0x0601B5F5 RID: 112117 RVA: 0x0086703F File Offset: 0x0086523F
	[return: Nullable(new byte[]
	{
		2,
		1
	})]
	public IList<string> GetStringValuesByWorld(string key)
	{
		return BlackboardModel.Instance.GetStringValuesByWorld(key);
	}

	// Token: 0x0601B5F6 RID: 112118 RVA: 0x0086704C File Offset: 0x0086524C
	public void SetStringValuesByWorld(string key, string[] values)
	{
		BlackboardModel.Instance.SetStringValuesByWorld(key, values);
		if (!this.IsNetworkMode())
		{
			return;
		}
		BlackboardParam blackboardParam = new BlackboardParam();
		blackboardParam.Type = BlackboardParamType.StringArray;
		blackboardParam.Key = key;
		blackboardParam.StringValues = new StringArrayBlackboard();
		blackboardParam.StringValues.Values.AddRange(values);
		BlackboardParam[] blackboardFields = new BlackboardParam[]
		{
			blackboardParam
		};
		this.WorldBlackboardPush(blackboardFields);
	}

	// Token: 0x0601B5F7 RID: 112119 RVA: 0x008670B0 File Offset: 0x008652B0
	public void RemoveValueByWorld(string key)
	{
		BlackboardModel.Instance.RemoveValueByWorld(key);
		if (!this.IsNetworkMode())
		{
			return;
		}
		BlackboardParam[] blackboardFields = new BlackboardParam[]
		{
			new BlackboardParam
			{
				Type = BlackboardParamType.None,
				Key = key
			}
		};
		this.WorldBlackboardPush(blackboardFields);
	}

	// Token: 0x0601B5F8 RID: 112120 RVA: 0x008670F8 File Offset: 0x008652F8
	public void SetWorldBlackboardsByProtocol([Nullable(new byte[]
	{
		2,
		1
	})] IList<BlackboardParam> blackboards)
	{
		if (blackboards == null)
		{
			return;
		}
		foreach (BlackboardParam worldBlackboardByProtocol in blackboards)
		{
			this.SetWorldBlackboardByProtocol(worldBlackboardByProtocol);
		}
	}

	// Token: 0x0601B5F9 RID: 112121 RVA: 0x00867144 File Offset: 0x00865344
	[NullableContext(2)]
	public void SetWorldBlackboardByProtocol(BlackboardParam blackboard)
	{
		if (blackboard == null)
		{
			return;
		}
		BlackboardMap.BlackboardParam blackboardParam = BlackboardMap.BlackboardParam.CreateByProtocol(blackboard);
		if (blackboardParam != null)
		{
			BlackboardModel.Instance.SetValueByWorld(blackboardParam.GetKey(), blackboardParam);
		}
	}

	// Token: 0x0601B5FA RID: 112122 RVA: 0x00867170 File Offset: 0x00865370
	public int? GetIntValueByEntity(int entityId, string key)
	{
		return BlackboardModel.Instance.GetIntValueByEntity(entityId, key);
	}

	// Token: 0x0601B5FB RID: 112123 RVA: 0x00867180 File Offset: 0x00865380
	public void SetIntValueByEntity(int entityId, string key, int value)
	{
		CreatureDataComponent creatureDataComponent = BlackboardModel.Instance.GetCreatureDataComponent(entityId);
		if (creatureDataComponent == null)
		{
			return;
		}
		BlackboardModel.Instance.SetIntValueByEntity(entityId, key, value);
		if (!this.IsNetworkMode())
		{
			return;
		}
		BlackboardParam blackboardParam = new BlackboardParam();
		blackboardParam.Type = BlackboardParamType.Int;
		blackboardParam.Key = key;
		blackboardParam.IntValue = value;
		long creatureDataId = creatureDataComponent.GetCreatureDataId();
		BlackboardParam[] blackboardFields = new BlackboardParam[]
		{
			blackboardParam
		};
		this.EntityBlackboardPush(creatureDataId, blackboardFields);
	}

	// Token: 0x0601B5FC RID: 112124 RVA: 0x008671E8 File Offset: 0x008653E8
	[return: Nullable(2)]
	public IList<int> GetIntValuesByEntity(int entityId, string key)
	{
		return BlackboardModel.Instance.GetIntValuesByEntity(entityId, key);
	}

	// Token: 0x0601B5FD RID: 112125 RVA: 0x008671F8 File Offset: 0x008653F8
	public void SetIntValuesByEntity(int entityId, string key, IList<int> values)
	{
		CreatureDataComponent creatureDataComponent = BlackboardModel.Instance.GetCreatureDataComponent(entityId);
		if (creatureDataComponent == null)
		{
			return;
		}
		BlackboardModel.Instance.SetIntValuesByEntity(entityId, key, values);
		if (!this.IsNetworkMode())
		{
			return;
		}
		BlackboardParam blackboardParam = new BlackboardParam();
		blackboardParam.Type = BlackboardParamType.IntArray;
		blackboardParam.Key = key;
		blackboardParam.IntValues = new IntArrayBlackboard();
		blackboardParam.IntValues.Values.AddRange(values);
		long creatureDataId = creatureDataComponent.GetCreatureDataId();
		BlackboardParam[] blackboardFields = new BlackboardParam[]
		{
			blackboardParam
		};
		this.EntityBlackboardPush(creatureDataId, blackboardFields);
	}

	// Token: 0x0601B5FE RID: 112126 RVA: 0x00867275 File Offset: 0x00865475
	public long? GetLongValueByEntity(int entityId, string key)
	{
		return BlackboardModel.Instance.GetLongValueByEntity(entityId, key);
	}

	// Token: 0x0601B5FF RID: 112127 RVA: 0x00867284 File Offset: 0x00865484
	public void SetLongValueByEntity(int entityId, string key, long value)
	{
		CreatureDataComponent creatureDataComponent = BlackboardModel.Instance.GetCreatureDataComponent(entityId);
		if (creatureDataComponent == null)
		{
			return;
		}
		BlackboardModel.Instance.SetLongValueByEntity(entityId, key, value);
		if (!this.IsNetworkMode())
		{
			return;
		}
		BlackboardParam blackboardParam = new BlackboardParam();
		blackboardParam.Type = BlackboardParamType.Long;
		blackboardParam.Key = key;
		blackboardParam.LongValue = MathUtils.Instance.BigIntToLong(value);
		long creatureDataId = creatureDataComponent.GetCreatureDataId();
		BlackboardParam[] blackboardFields = new BlackboardParam[]
		{
			blackboardParam
		};
		this.EntityBlackboardPush(creatureDataId, blackboardFields);
	}

	// Token: 0x0601B600 RID: 112128 RVA: 0x008672F6 File Offset: 0x008654F6
	[return: Nullable(2)]
	public IList<long> GetLongValuesByEntity(int entityId, string key)
	{
		return BlackboardModel.Instance.GetLongValuesByEntity(entityId, key);
	}

	// Token: 0x0601B601 RID: 112129 RVA: 0x00867304 File Offset: 0x00865504
	public void SetLongValuesByEntity(int entityId, string key, IList<long> values)
	{
		CreatureDataComponent creatureDataComponent = BlackboardModel.Instance.GetCreatureDataComponent(entityId);
		if (creatureDataComponent == null)
		{
			return;
		}
		BlackboardModel.Instance.SetLongValuesByEntity(entityId, key, values);
		if (!this.IsNetworkMode())
		{
			return;
		}
		BlackboardParam blackboardParam = new BlackboardParam();
		blackboardParam.Type = BlackboardParamType.LongArray;
		blackboardParam.Key = key;
		blackboardParam.LongValues = new LongArrayBlackboard();
		for (int i = 0; i < values.Count; i++)
		{
			blackboardParam.LongValues.Values.Add(values[i]);
		}
		long creatureDataId = creatureDataComponent.GetCreatureDataId();
		BlackboardParam[] blackboardFields = new BlackboardParam[]
		{
			blackboardParam
		};
		this.EntityBlackboardPush(creatureDataId, blackboardFields);
	}

	// Token: 0x0601B602 RID: 112130 RVA: 0x0086739D File Offset: 0x0086559D
	public bool? GetBooleanValueByEntity(int entityId, string key)
	{
		return BlackboardModel.Instance.GetBooleanValueByEntity(entityId, key);
	}

	// Token: 0x0601B603 RID: 112131 RVA: 0x008673AC File Offset: 0x008655AC
	public void SetBooleanValueByEntity(int entityId, string key, bool value)
	{
		CreatureDataComponent creatureDataComponent = BlackboardModel.Instance.GetCreatureDataComponent(entityId);
		if (creatureDataComponent == null)
		{
			return;
		}
		BlackboardModel.Instance.SetBooleanValueByEntity(entityId, key, value);
		if (!this.IsNetworkMode())
		{
			return;
		}
		BlackboardParam blackboardParam = new BlackboardParam();
		blackboardParam.Type = BlackboardParamType.Boolean;
		blackboardParam.Key = key;
		blackboardParam.BooleanValue = value;
		long creatureDataId = creatureDataComponent.GetCreatureDataId();
		BlackboardParam[] blackboardFields = new BlackboardParam[]
		{
			blackboardParam
		};
		this.EntityBlackboardPush(creatureDataId, blackboardFields);
	}

	// Token: 0x0601B604 RID: 112132 RVA: 0x00867414 File Offset: 0x00865614
	public float? GetFloatValueByEntity(int entityId, string key)
	{
		return BlackboardModel.Instance.GetFloatValueByEntity(entityId, key);
	}

	// Token: 0x0601B605 RID: 112133 RVA: 0x00867424 File Offset: 0x00865624
	public void SetFloatValueByEntity(int entityId, string key, float value)
	{
		CreatureDataComponent creatureDataComponent = BlackboardModel.Instance.GetCreatureDataComponent(entityId);
		if (creatureDataComponent == null)
		{
			return;
		}
		BlackboardModel.Instance.SetFloatValueByEntity(entityId, key, value);
		if (!this.IsNetworkMode())
		{
			return;
		}
		BlackboardParam blackboardParam = new BlackboardParam();
		blackboardParam.Type = BlackboardParamType.Float;
		blackboardParam.Key = key;
		blackboardParam.FloatValue = value;
		long creatureDataId = creatureDataComponent.GetCreatureDataId();
		BlackboardParam[] blackboardFields = new BlackboardParam[]
		{
			blackboardParam
		};
		this.EntityBlackboardPush(creatureDataId, blackboardFields);
	}

	// Token: 0x0601B606 RID: 112134 RVA: 0x0086748C File Offset: 0x0086568C
	[return: Nullable(2)]
	public IList<float> GetFloatValuesByEntity(int entityId, string key)
	{
		return BlackboardModel.Instance.GetFloatValuesByEntity(entityId, key);
	}

	// Token: 0x0601B607 RID: 112135 RVA: 0x0086749C File Offset: 0x0086569C
	public void SetFloatValuesByEntity(int entityId, string key, IList<float> values)
	{
		CreatureDataComponent creatureDataComponent = BlackboardModel.Instance.GetCreatureDataComponent(entityId);
		if (creatureDataComponent == null)
		{
			return;
		}
		BlackboardModel.Instance.SetFloatValuesByEntity(entityId, key, values);
		if (!this.IsNetworkMode())
		{
			return;
		}
		BlackboardParam blackboardParam = new BlackboardParam();
		blackboardParam.Type = BlackboardParamType.FloatArray;
		blackboardParam.Key = key;
		blackboardParam.FloatValues = new FloatArrayBlackboard();
		blackboardParam.FloatValues.Values.AddRange(values);
		long creatureDataId = creatureDataComponent.GetCreatureDataId();
		BlackboardParam[] blackboardFields = new BlackboardParam[]
		{
			blackboardParam
		};
		this.EntityBlackboardPush(creatureDataId, blackboardFields);
	}

	// Token: 0x0601B608 RID: 112136 RVA: 0x0086751A File Offset: 0x0086571A
	[return: Nullable(2)]
	public string GetStringValueByEntity(int entityId, string key)
	{
		return BlackboardModel.Instance.GetStringValueByEntity(entityId, key);
	}

	// Token: 0x0601B609 RID: 112137 RVA: 0x00867528 File Offset: 0x00865728
	public void SetStringValueByEntity(int entityId, string key, string value)
	{
		CreatureDataComponent creatureDataComponent = BlackboardModel.Instance.GetCreatureDataComponent(entityId);
		if (creatureDataComponent == null)
		{
			return;
		}
		BlackboardModel.Instance.SetStringValueByEntity(entityId, key, value);
		if (!this.IsNetworkMode())
		{
			return;
		}
		BlackboardParam blackboardParam = new BlackboardParam();
		blackboardParam.Type = BlackboardParamType.String;
		blackboardParam.Key = key;
		blackboardParam.StringValue = value;
		long creatureDataId = creatureDataComponent.GetCreatureDataId();
		BlackboardParam[] blackboardFields = new BlackboardParam[]
		{
			blackboardParam
		};
		this.EntityBlackboardPush(creatureDataId, blackboardFields);
	}

	// Token: 0x0601B60A RID: 112138 RVA: 0x00867590 File Offset: 0x00865790
	[return: Nullable(new byte[]
	{
		2,
		1
	})]
	public IList<string> GetStringValuesByEntity(int entityId, string key)
	{
		return BlackboardModel.Instance.GetStringValuesByEntity(entityId, key);
	}

	// Token: 0x0601B60B RID: 112139 RVA: 0x008675A0 File Offset: 0x008657A0
	public void SetStringValuesByEntity(int entityId, string key, IList<string> values)
	{
		CreatureDataComponent creatureDataComponent = BlackboardModel.Instance.GetCreatureDataComponent(entityId);
		if (creatureDataComponent == null)
		{
			return;
		}
		BlackboardModel.Instance.SetStringValuesByEntity(entityId, key, values);
		if (!this.IsNetworkMode())
		{
			return;
		}
		BlackboardParam blackboardParam = new BlackboardParam();
		blackboardParam.Type = BlackboardParamType.StringArray;
		blackboardParam.Key = key;
		blackboardParam.StringValues = new StringArrayBlackboard();
		blackboardParam.StringValues.Values.AddRange(values);
		long creatureDataId = creatureDataComponent.GetCreatureDataId();
		BlackboardParam[] blackboardFields = new BlackboardParam[]
		{
			blackboardParam
		};
		this.EntityBlackboardPush(creatureDataId, blackboardFields);
	}

	// Token: 0x0601B60C RID: 112140 RVA: 0x0086761D File Offset: 0x0086581D
	[return: Nullable(2)]
	public Aki.Protocol.Vector GetVectorValueByEntity(int entityId, string key)
	{
		return BlackboardModel.Instance.GetVectorValueByEntity(entityId, key);
	}

	// Token: 0x0601B60D RID: 112141 RVA: 0x0086762B File Offset: 0x0086582B
	public void SetVectorValueByGlobal(string key, float x, float y, float z)
	{
		BlackboardModel.Instance.SetVectorValueByWorld(key, x, y, z);
	}

	// Token: 0x0601B60E RID: 112142 RVA: 0x0086763C File Offset: 0x0086583C
	public void SetVectorValueByEntity(int entityId, string key, double x, double y, double z)
	{
		CreatureDataComponent creatureDataComponent = BlackboardModel.Instance.GetCreatureDataComponent(entityId);
		if (creatureDataComponent == null)
		{
			return;
		}
		BlackboardModel.Instance.SetVectorValueByEntity(entityId, key, (float)x, (float)y, (float)z);
		if (!this.IsNetworkMode())
		{
			return;
		}
		BlackboardParam blackboardParam = new BlackboardParam();
		blackboardParam.Type = BlackboardParamType.Vector;
		blackboardParam.Key = key;
		blackboardParam.VectorValue = Aki.Protocol.Vector.Create();
		blackboardParam.VectorValue.X = (float)x;
		blackboardParam.VectorValue.Y = (float)y;
		blackboardParam.VectorValue.Z = (float)z;
		long creatureDataId = creatureDataComponent.GetCreatureDataId();
		BlackboardParam[] blackboardFields = new BlackboardParam[]
		{
			blackboardParam
		};
		this.EntityBlackboardPush(creatureDataId, blackboardFields);
	}

	// Token: 0x0601B60F RID: 112143 RVA: 0x008676D9 File Offset: 0x008658D9
	[return: Nullable(new byte[]
	{
		2,
		1
	})]
	public IList<Aki.Protocol.Vector> GetVectorValuesByEntity(int entityId, string key)
	{
		return BlackboardModel.Instance.GetVectorValuesByEntity(entityId, key);
	}

	// Token: 0x0601B610 RID: 112144 RVA: 0x008676E8 File Offset: 0x008658E8
	public void SetVectorValuesByEntity(int entityId, string key, IList<Aki.Protocol.Vector> values)
	{
		CreatureDataComponent creatureDataComponent = BlackboardModel.Instance.GetCreatureDataComponent(entityId);
		if (creatureDataComponent == null)
		{
			return;
		}
		BlackboardModel.Instance.SetVectorValuesByEntity(entityId, key, values);
		if (!this.IsNetworkMode())
		{
			return;
		}
		BlackboardParam blackboardParam = new BlackboardParam();
		blackboardParam.Type = BlackboardParamType.VectorArray;
		blackboardParam.Key = key;
		blackboardParam.VectorValues = new VectorArrayBlackboard();
		blackboardParam.VectorValues.Values.Add(values);
		long creatureDataId = creatureDataComponent.GetCreatureDataId();
		BlackboardParam[] blackboardFields = new BlackboardParam[]
		{
			blackboardParam
		};
		this.EntityBlackboardPush(creatureDataId, blackboardFields);
	}

	// Token: 0x0601B611 RID: 112145 RVA: 0x00867766 File Offset: 0x00865966
	[return: Nullable(2)]
	public Aki.Protocol.Rotator GetRotatorValueByEntity(int entityId, string key)
	{
		return BlackboardModel.Instance.GetRotatorValueByEntity(entityId, key);
	}

	// Token: 0x0601B612 RID: 112146 RVA: 0x00867774 File Offset: 0x00865974
	public void SetRotatorValueByEntity(int entityId, string key, float pitch, float roll, float yaw)
	{
		CreatureDataComponent creatureDataComponent = BlackboardModel.Instance.GetCreatureDataComponent(entityId);
		if (creatureDataComponent == null)
		{
			return;
		}
		BlackboardModel.Instance.SetRotatorValueByEntity(entityId, key, pitch, roll, yaw);
		if (!this.IsNetworkMode())
		{
			return;
		}
		BlackboardParam blackboardParam = new BlackboardParam();
		blackboardParam.Type = BlackboardParamType.Rotator;
		blackboardParam.Key = key;
		blackboardParam.RotatorValue = Aki.Protocol.Rotator.Create();
		blackboardParam.RotatorValue.Pitch = pitch;
		blackboardParam.RotatorValue.Roll = roll;
		blackboardParam.RotatorValue.Yaw = yaw;
		long creatureDataId = creatureDataComponent.GetCreatureDataId();
		BlackboardParam[] blackboardFields = new BlackboardParam[]
		{
			blackboardParam
		};
		this.EntityBlackboardPush(creatureDataId, blackboardFields);
	}

	// Token: 0x0601B613 RID: 112147 RVA: 0x0086780B File Offset: 0x00865A0B
	[return: Nullable(new byte[]
	{
		2,
		1
	})]
	public IList<Aki.Protocol.Rotator> GetRotatorValuesByEntity(int entityId, string key)
	{
		return BlackboardModel.Instance.GetRotatorValuesByEntity(entityId, key);
	}

	// Token: 0x0601B614 RID: 112148 RVA: 0x0086781C File Offset: 0x00865A1C
	public void SetRotatorValuesByEntity(int entityId, string key, IList<Aki.Protocol.Rotator> values)
	{
		CreatureDataComponent creatureDataComponent = BlackboardModel.Instance.GetCreatureDataComponent(entityId);
		if (creatureDataComponent == null)
		{
			return;
		}
		BlackboardModel.Instance.SetRotatorValuesByEntity(entityId, key, values);
		if (!this.IsNetworkMode())
		{
			return;
		}
		BlackboardParam blackboardParam = new BlackboardParam();
		blackboardParam.Type = BlackboardParamType.RotatorArray;
		blackboardParam.Key = key;
		blackboardParam.RotatorValues = new RotatorArrayBlackboard();
		blackboardParam.RotatorValues.Values.AddRange(values);
		long creatureDataId = creatureDataComponent.GetCreatureDataId();
		BlackboardParam[] blackboardFields = new BlackboardParam[]
		{
			blackboardParam
		};
		this.EntityBlackboardPush(creatureDataId, blackboardFields);
	}

	// Token: 0x0601B615 RID: 112149 RVA: 0x0086789C File Offset: 0x00865A9C
	public int? GetEntityIdByEntity(int entityId, string key)
	{
		long? entityIdByEntity = BlackboardModel.Instance.GetEntityIdByEntity(entityId, key);
		if (entityIdByEntity == null)
		{
			return null;
		}
		EntityHandle entity = CreatureModel.Instance.GetEntity(entityIdByEntity.Value);
		return new int?((entity != null) ? entity.Id : 0);
	}

	// Token: 0x0601B616 RID: 112150 RVA: 0x008678EC File Offset: 0x00865AEC
	public void SetEntityIdByEntity(int entityId, string key, int value)
	{
		CreatureDataComponent creatureDataComponent = BlackboardModel.Instance.GetCreatureDataComponent(value);
		if (creatureDataComponent == null)
		{
			return;
		}
		long creatureDataId = creatureDataComponent.GetCreatureDataId();
		BlackboardModel.Instance.SetEntityIdByEntity(entityId, key, creatureDataId);
		if (!this.IsNetworkMode())
		{
			return;
		}
		BlackboardParam[] blackboardFields = new BlackboardParam[]
		{
			new BlackboardParam
			{
				Type = BlackboardParamType.Entity,
				Key = key,
				LongValue = (long)value
			}
		};
		this.EntityBlackboardPush(creatureDataId, blackboardFields);
	}

	// Token: 0x0601B617 RID: 112151 RVA: 0x00867956 File Offset: 0x00865B56
	[return: Nullable(2)]
	public IList<int> GetEntityIdsByEntity(int entityId, string key)
	{
		return BlackboardModel.Instance.GetEntityIdsByEntity(entityId, key);
	}

	// Token: 0x0601B618 RID: 112152 RVA: 0x00867964 File Offset: 0x00865B64
	public void SetEntityIdsByEntity(int entityId, string key, IList<int> values)
	{
		CreatureDataComponent creatureDataComponent = BlackboardModel.Instance.GetCreatureDataComponent(entityId);
		if (creatureDataComponent == null)
		{
			return;
		}
		BlackboardModel.Instance.SetEntityIdsByEntity(entityId, key, values);
		if (!this.IsNetworkMode())
		{
			return;
		}
		BlackboardParam blackboardParam = new BlackboardParam();
		blackboardParam.Type = BlackboardParamType.EntityArray;
		blackboardParam.Key = key;
		blackboardParam.IntValues.Values.AddRange(values);
		long creatureDataId = creatureDataComponent.GetCreatureDataId();
		BlackboardParam[] blackboardFields = new BlackboardParam[]
		{
			blackboardParam
		};
		this.EntityBlackboardPush(creatureDataId, blackboardFields);
	}

	// Token: 0x0601B619 RID: 112153 RVA: 0x008679D8 File Offset: 0x00865BD8
	public void RemoveValueByEntity(int entityId, string key)
	{
		CreatureDataComponent creatureDataComponent = BlackboardModel.Instance.GetCreatureDataComponent(entityId);
		if (creatureDataComponent == null)
		{
			return;
		}
		if (!creatureDataComponent.RemoveBlackboard(key) && !this.IsNetworkMode())
		{
			return;
		}
		long creatureDataId = creatureDataComponent.GetCreatureDataId();
		BlackboardParam[] blackboardFields = new BlackboardParam[]
		{
			new BlackboardParam
			{
				Type = BlackboardParamType.None,
				Key = key
			}
		};
		this.EntityBlackboardPush(creatureDataId, blackboardFields);
	}

	// Token: 0x0601B61A RID: 112154 RVA: 0x00867A38 File Offset: 0x00865C38
	public bool HasValueByEntity(int entityId, string key)
	{
		CreatureDataComponent creatureDataComponent = BlackboardModel.Instance.GetCreatureDataComponent(entityId);
		if (creatureDataComponent == null)
		{
			return false;
		}
		BlackboardMap blackboard = creatureDataComponent.GetBlackboard();
		return blackboard != null && blackboard.HasValue(key);
	}

	// Token: 0x0601B61B RID: 112155 RVA: 0x00867A68 File Offset: 0x00865C68
	public void ClearValuesByEntity(int entityId, string key)
	{
		CreatureDataComponent creatureDataComponent = BlackboardModel.Instance.GetCreatureDataComponent(entityId);
		if (creatureDataComponent == null)
		{
			return;
		}
		BlackboardMap blackboard = creatureDataComponent.GetBlackboard();
		if (!this.IsNetworkMode())
		{
			if (blackboard != null)
			{
				blackboard.Clear();
				return;
			}
		}
		else
		{
			List<BlackboardParam> list = new List<BlackboardParam>();
			if (((blackboard != null) ? blackboard.Map : null) != null)
			{
				foreach (string key2 in blackboard.Map.Keys)
				{
					list.Add(new BlackboardParam
					{
						Type = BlackboardParamType.None,
						Key = key2
					});
				}
			}
			if (list.Count > 0)
			{
				long creatureDataId = CreatureModel.Instance.GetCreatureDataId(entityId);
				this.EntityBlackboardPush(creatureDataId, list);
			}
			if (blackboard != null)
			{
				blackboard.Clear();
			}
		}
	}

	// Token: 0x0601B61C RID: 112156 RVA: 0x00867B44 File Offset: 0x00865D44
	private bool IsNetworkMode()
	{
		return GlobalData.Networking();
	}

	// Token: 0x17002C76 RID: 11382
	// (get) Token: 0x0601B61D RID: 112157 RVA: 0x00867B4B File Offset: 0x00865D4B
	public static BlackboardController Instance
	{
		get
		{
			return BlackboardController._Instance;
		}
	}

	// Token: 0x0601B61E RID: 112158 RVA: 0x00867B52 File Offset: 0x00865D52
	public static BlackboardController GetOrCreateInstance()
	{
		if (BlackboardController._Instance == null)
		{
			BlackboardController.CreateInstance();
		}
		return BlackboardController._Instance;
	}

	// Token: 0x0601B61F RID: 112159 RVA: 0x00867B66 File Offset: 0x00865D66
	public static bool CreateInstance()
	{
		if (BlackboardController._Instance != null)
		{
			return true;
		}
		BlackboardController._Instance = new BlackboardController();
		return true;
	}

	// Token: 0x0601B620 RID: 112160 RVA: 0x00867B7C File Offset: 0x00865D7C
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x0601B621 RID: 112161 RVA: 0x00867B7E File Offset: 0x00865D7E
	public static void ResetStaticDefaultValue()
	{
		BlackboardController._Instance = null;
	}

	// Token: 0x0601B622 RID: 112162 RVA: 0x00867B86 File Offset: 0x00865D86
	static BlackboardController()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(BlackboardController.CreateStaticDefaultValue), new Action(BlackboardController.ResetStaticDefaultValue));
	}

	// Token: 0x0400ECE4 RID: 60644
	public readonly Dictionary<long, Dictionary<string, BlackboardParam>> PendingBlackboardParams = new Dictionary<long, Dictionary<string, BlackboardParam>>();

	// Token: 0x0400ECE5 RID: 60645
	[Nullable(2)]
	private static BlackboardController _Instance;
}
