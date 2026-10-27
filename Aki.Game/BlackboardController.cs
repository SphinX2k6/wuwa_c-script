using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;
using Google.Protobuf;

// Token: 0x020034D6 RID: 13526
[NullableContext(1)]
[Nullable(0)]
[Controller(0)]
public class BlackboardController : ControllerBase
{
	// Token: 0x0601D8DD RID: 121053 RVA: 0x0083F430 File Offset: 0x0083D630
	protected override bool OnInit()
	{
		Net.Instance.Register(ENotifyMessageId.WorldBlackboardNotify, new Action<IMessage, Net.CallbackStatus>(this.WorldBlackboardNotify));
		Net.Instance.Register(ENotifyMessageId.EntityBlackboardNotify, new Action<IMessage, Net.CallbackStatus>(this.EntityBlackboardNotify));
		EventSystem.Instance.Add(EEventName.RemoveCreatureDataComponentCache, new Action<int>(this.OnRemoveCreatureDataComponent));
		return true;
	}

	// Token: 0x0601D8DE RID: 121054 RVA: 0x0083F492 File Offset: 0x0083D692
	protected override bool OnClear()
	{
		Net.Instance.UnRegister(ENotifyMessageId.WorldBlackboardNotify);
		Net.Instance.UnRegister(ENotifyMessageId.EntityBlackboardNotify);
		EventSystem.Instance.Remove(EEventName.RemoveCreatureDataComponentCache, new Action<int>(this.OnRemoveCreatureDataComponent));
		return true;
	}

	// Token: 0x0601D8DF RID: 121055 RVA: 0x0083F4D1 File Offset: 0x0083D6D1
	private void OnRemoveCreatureDataComponent(int entityId)
	{
		BlackboardModel.Instance.RemoveCreatureDataComponent(entityId);
	}

	// Token: 0x0601D8E0 RID: 121056 RVA: 0x0083F4E0 File Offset: 0x0083D6E0
	private void WorldBlackboardPush(IList<BlackboardParam> blackboardFields)
	{
		WorldBlackboardRequest worldBlackboardRequest = new WorldBlackboardRequest();
		worldBlackboardRequest.Params.AddRange(blackboardFields);
		Net.Instance.Call(ERequestMessageId.WorldBlackboardRequest, worldBlackboardRequest, delegate(IMessage response, Net.CallbackStatus _)
		{
		}, 0);
	}

	// Token: 0x0601D8E1 RID: 121057 RVA: 0x0083F530 File Offset: 0x0083D730
	[NullableContext(2)]
	private void WorldBlackboardNotify(IMessage msg, Net.CallbackStatus status)
	{
		WorldBlackboardNotify worldBlackboardNotify = (WorldBlackboardNotify)msg;
		this.SetWorldBlackboardsByProtocol(worldBlackboardNotify.Params);
	}

	// Token: 0x0601D8E2 RID: 121058 RVA: 0x0083F550 File Offset: 0x0083D750
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

	// Token: 0x0601D8E3 RID: 121059 RVA: 0x0083F588 File Offset: 0x0083D788
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

	// Token: 0x0601D8E4 RID: 121060 RVA: 0x0083F60C File Offset: 0x0083D80C
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

	// Token: 0x0601D8E5 RID: 121061 RVA: 0x0083F6D0 File Offset: 0x0083D8D0
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

	// Token: 0x0601D8E6 RID: 121062 RVA: 0x0083F748 File Offset: 0x0083D948
	public int? GetIntValueByWorld(string key)
	{
		return BlackboardModel.Instance.GetIntValueByWorld(key);
	}

	// Token: 0x0601D8E7 RID: 121063 RVA: 0x0083F758 File Offset: 0x0083D958
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

	// Token: 0x0601D8E8 RID: 121064 RVA: 0x0083F7A7 File Offset: 0x0083D9A7
	[return: Nullable(2)]
	public IList<int> GetIntValuesByWorld(string key)
	{
		return BlackboardModel.Instance.GetIntValuesByWorld(key);
	}

	// Token: 0x0601D8E9 RID: 121065 RVA: 0x0083F7B4 File Offset: 0x0083D9B4
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

	// Token: 0x0601D8EA RID: 121066 RVA: 0x0083F818 File Offset: 0x0083DA18
	public long? GetLongValueByWorld(string key)
	{
		return BlackboardModel.Instance.GetLongValueByWorld(key);
	}

	// Token: 0x0601D8EB RID: 121067 RVA: 0x0083F828 File Offset: 0x0083DA28
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

	// Token: 0x0601D8EC RID: 121068 RVA: 0x0083F881 File Offset: 0x0083DA81
	[return: Nullable(2)]
	public IList<long> GetLongValuesByWorld(string key)
	{
		return BlackboardModel.Instance.GetLongValuesByWorld(key);
	}

	// Token: 0x0601D8ED RID: 121069 RVA: 0x0083F890 File Offset: 0x0083DA90
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

	// Token: 0x0601D8EE RID: 121070 RVA: 0x0083F910 File Offset: 0x0083DB10
	public bool? GetBooleanValueByWorld(string key)
	{
		return BlackboardModel.Instance.GetBooleanValueByWorld(key);
	}

	// Token: 0x0601D8EF RID: 121071 RVA: 0x0083F920 File Offset: 0x0083DB20
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

	// Token: 0x0601D8F0 RID: 121072 RVA: 0x0083F96F File Offset: 0x0083DB6F
	public float? GetFloatValueByWorld(string key)
	{
		return BlackboardModel.Instance.GetFloatValueByWorld(key);
	}

	// Token: 0x0601D8F1 RID: 121073 RVA: 0x0083F97C File Offset: 0x0083DB7C
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

	// Token: 0x0601D8F2 RID: 121074 RVA: 0x0083F9CB File Offset: 0x0083DBCB
	[return: Nullable(2)]
	public IList<float> GetFloatValuesByWorld(string key)
	{
		return BlackboardModel.Instance.GetFloatValuesByWorld(key);
	}

	// Token: 0x0601D8F3 RID: 121075 RVA: 0x0083F9D8 File Offset: 0x0083DBD8
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

	// Token: 0x0601D8F4 RID: 121076 RVA: 0x0083FA3D File Offset: 0x0083DC3D
	[return: Nullable(2)]
	public string GetStringValueByWorld(string key)
	{
		return BlackboardModel.Instance.GetStringValueByWorld(key);
	}

	// Token: 0x0601D8F5 RID: 121077 RVA: 0x0083FA4C File Offset: 0x0083DC4C
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

	// Token: 0x0601D8F6 RID: 121078 RVA: 0x0083FA9B File Offset: 0x0083DC9B
	[return: Nullable(new byte[]
	{
		2,
		1
	})]
	public IList<string> GetStringValuesByWorld(string key)
	{
		return BlackboardModel.Instance.GetStringValuesByWorld(key);
	}

	// Token: 0x0601D8F7 RID: 121079 RVA: 0x0083FAA8 File Offset: 0x0083DCA8
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

	// Token: 0x0601D8F8 RID: 121080 RVA: 0x0083FB0C File Offset: 0x0083DD0C
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

	// Token: 0x0601D8F9 RID: 121081 RVA: 0x0083FB54 File Offset: 0x0083DD54
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

	// Token: 0x0601D8FA RID: 121082 RVA: 0x0083FBA0 File Offset: 0x0083DDA0
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

	// Token: 0x0601D8FB RID: 121083 RVA: 0x0083FBCC File Offset: 0x0083DDCC
	public int? GetIntValueByEntity(int entityId, string key)
	{
		return BlackboardModel.Instance.GetIntValueByEntity(entityId, key);
	}

	// Token: 0x0601D8FC RID: 121084 RVA: 0x0083FBDC File Offset: 0x0083DDDC
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

	// Token: 0x0601D8FD RID: 121085 RVA: 0x0083FC44 File Offset: 0x0083DE44
	[return: Nullable(2)]
	public IList<int> GetIntValuesByEntity(int entityId, string key)
	{
		return BlackboardModel.Instance.GetIntValuesByEntity(entityId, key);
	}

	// Token: 0x0601D8FE RID: 121086 RVA: 0x0083FC54 File Offset: 0x0083DE54
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

	// Token: 0x0601D8FF RID: 121087 RVA: 0x0083FCD1 File Offset: 0x0083DED1
	public long? GetLongValueByEntity(int entityId, string key)
	{
		return BlackboardModel.Instance.GetLongValueByEntity(entityId, key);
	}

	// Token: 0x0601D900 RID: 121088 RVA: 0x0083FCE0 File Offset: 0x0083DEE0
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

	// Token: 0x0601D901 RID: 121089 RVA: 0x0083FD52 File Offset: 0x0083DF52
	[return: Nullable(2)]
	public IList<long> GetLongValuesByEntity(int entityId, string key)
	{
		return BlackboardModel.Instance.GetLongValuesByEntity(entityId, key);
	}

	// Token: 0x0601D902 RID: 121090 RVA: 0x0083FD60 File Offset: 0x0083DF60
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

	// Token: 0x0601D903 RID: 121091 RVA: 0x0083FDF9 File Offset: 0x0083DFF9
	public bool? GetBooleanValueByEntity(int entityId, string key)
	{
		return BlackboardModel.Instance.GetBooleanValueByEntity(entityId, key);
	}

	// Token: 0x0601D904 RID: 121092 RVA: 0x0083FE08 File Offset: 0x0083E008
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

	// Token: 0x0601D905 RID: 121093 RVA: 0x0083FE70 File Offset: 0x0083E070
	public float? GetFloatValueByEntity(int entityId, string key)
	{
		return BlackboardModel.Instance.GetFloatValueByEntity(entityId, key);
	}

	// Token: 0x0601D906 RID: 121094 RVA: 0x0083FE80 File Offset: 0x0083E080
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

	// Token: 0x0601D907 RID: 121095 RVA: 0x0083FEE8 File Offset: 0x0083E0E8
	[return: Nullable(2)]
	public IList<float> GetFloatValuesByEntity(int entityId, string key)
	{
		return BlackboardModel.Instance.GetFloatValuesByEntity(entityId, key);
	}

	// Token: 0x0601D908 RID: 121096 RVA: 0x0083FEF8 File Offset: 0x0083E0F8
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

	// Token: 0x0601D909 RID: 121097 RVA: 0x0083FF76 File Offset: 0x0083E176
	[return: Nullable(2)]
	public string GetStringValueByEntity(int entityId, string key)
	{
		return BlackboardModel.Instance.GetStringValueByEntity(entityId, key);
	}

	// Token: 0x0601D90A RID: 121098 RVA: 0x0083FF84 File Offset: 0x0083E184
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

	// Token: 0x0601D90B RID: 121099 RVA: 0x0083FFEC File Offset: 0x0083E1EC
	[return: Nullable(new byte[]
	{
		2,
		1
	})]
	public IList<string> GetStringValuesByEntity(int entityId, string key)
	{
		return BlackboardModel.Instance.GetStringValuesByEntity(entityId, key);
	}

	// Token: 0x0601D90C RID: 121100 RVA: 0x0083FFFC File Offset: 0x0083E1FC
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

	// Token: 0x0601D90D RID: 121101 RVA: 0x00840079 File Offset: 0x0083E279
	[return: Nullable(2)]
	public Aki.Protocol.Vector GetVectorValueByEntity(int entityId, string key)
	{
		return BlackboardModel.Instance.GetVectorValueByEntity(entityId, key);
	}

	// Token: 0x0601D90E RID: 121102 RVA: 0x00840087 File Offset: 0x0083E287
	public void SetVectorValueByGlobal(string key, float x, float y, float z)
	{
		BlackboardModel.Instance.SetVectorValueByWorld(key, x, y, z);
	}

	// Token: 0x0601D90F RID: 121103 RVA: 0x00840098 File Offset: 0x0083E298
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

	// Token: 0x0601D910 RID: 121104 RVA: 0x00840135 File Offset: 0x0083E335
	[return: Nullable(new byte[]
	{
		2,
		1
	})]
	public IList<Aki.Protocol.Vector> GetVectorValuesByEntity(int entityId, string key)
	{
		return BlackboardModel.Instance.GetVectorValuesByEntity(entityId, key);
	}

	// Token: 0x0601D911 RID: 121105 RVA: 0x00840144 File Offset: 0x0083E344
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

	// Token: 0x0601D912 RID: 121106 RVA: 0x008401C2 File Offset: 0x0083E3C2
	[return: Nullable(2)]
	public Aki.Protocol.Rotator GetRotatorValueByEntity(int entityId, string key)
	{
		return BlackboardModel.Instance.GetRotatorValueByEntity(entityId, key);
	}

	// Token: 0x0601D913 RID: 121107 RVA: 0x008401D0 File Offset: 0x0083E3D0
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

	// Token: 0x0601D914 RID: 121108 RVA: 0x00840267 File Offset: 0x0083E467
	[return: Nullable(new byte[]
	{
		2,
		1
	})]
	public IList<Aki.Protocol.Rotator> GetRotatorValuesByEntity(int entityId, string key)
	{
		return BlackboardModel.Instance.GetRotatorValuesByEntity(entityId, key);
	}

	// Token: 0x0601D915 RID: 121109 RVA: 0x00840278 File Offset: 0x0083E478
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

	// Token: 0x0601D916 RID: 121110 RVA: 0x008402F8 File Offset: 0x0083E4F8
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

	// Token: 0x0601D917 RID: 121111 RVA: 0x00840348 File Offset: 0x0083E548
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

	// Token: 0x0601D918 RID: 121112 RVA: 0x008403B2 File Offset: 0x0083E5B2
	[return: Nullable(2)]
	public IList<int> GetEntityIdsByEntity(int entityId, string key)
	{
		return BlackboardModel.Instance.GetEntityIdsByEntity(entityId, key);
	}

	// Token: 0x0601D919 RID: 121113 RVA: 0x008403C0 File Offset: 0x0083E5C0
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

	// Token: 0x0601D91A RID: 121114 RVA: 0x00840434 File Offset: 0x0083E634
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

	// Token: 0x0601D91B RID: 121115 RVA: 0x00840494 File Offset: 0x0083E694
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

	// Token: 0x0601D91C RID: 121116 RVA: 0x008404C4 File Offset: 0x0083E6C4
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

	// Token: 0x0601D91D RID: 121117 RVA: 0x008405A0 File Offset: 0x0083E7A0
	private bool IsNetworkMode()
	{
		return GlobalData.Networking();
	}

	// Token: 0x170028DE RID: 10462
	// (get) Token: 0x0601D91E RID: 121118 RVA: 0x008405A7 File Offset: 0x0083E7A7
	public static BlackboardController Instance
	{
		get
		{
			return BlackboardController._Instance;
		}
	}

	// Token: 0x0601D91F RID: 121119 RVA: 0x008405AE File Offset: 0x0083E7AE
	public static BlackboardController GetOrCreateInstance()
	{
		if (BlackboardController._Instance == null)
		{
			BlackboardController.CreateInstance();
		}
		return BlackboardController._Instance;
	}

	// Token: 0x0601D920 RID: 121120 RVA: 0x008405C2 File Offset: 0x0083E7C2
	public static bool CreateInstance()
	{
		if (BlackboardController._Instance != null)
		{
			return true;
		}
		BlackboardController._Instance = new BlackboardController();
		return true;
	}

	// Token: 0x0601D921 RID: 121121 RVA: 0x008405D8 File Offset: 0x0083E7D8
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x0601D922 RID: 121122 RVA: 0x008405DA File Offset: 0x0083E7DA
	public static void ResetStaticDefaultValue()
	{
		BlackboardController._Instance = null;
	}

	// Token: 0x0601D923 RID: 121123 RVA: 0x008405E2 File Offset: 0x0083E7E2
	static BlackboardController()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(BlackboardController.CreateStaticDefaultValue), new Action(BlackboardController.ResetStaticDefaultValue));
	}

	// Token: 0x0400E82F RID: 59439
	public readonly Dictionary<long, Dictionary<string, BlackboardParam>> PendingBlackboardParams = new Dictionary<long, Dictionary<string, BlackboardParam>>();

	// Token: 0x0400E830 RID: 59440
	[Nullable(2)]
	private static BlackboardController _Instance;
}
