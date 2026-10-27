using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using CSharpScript.Game.Module.Battle;
using CSharpScript.Utils;

// Token: 0x02002EE9 RID: 12009
[NullableContext(1)]
[Nullable(0)]
public class CharacterTriggerComponent : EntityComponent, IStaticVariableResetter
{
	// Token: 0x06019A77 RID: 105079 RVA: 0x006AB218 File Offset: 0x006A9418
	static CharacterTriggerComponent()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(CharacterTriggerComponent.CreateStaticDefaultValue), new Action(CharacterTriggerComponent.ResetStaticDefaultValue));
	}

	// Token: 0x1700237E RID: 9086
	// (get) Token: 0x06019A78 RID: 105080 RVA: 0x006AB237 File Offset: 0x006A9437
	public Dictionary<string, Func<TFormulaValue[], TFormulaValue>> TriggerFormulaFunc
	{
		get
		{
			return this.BuildInFunctions;
		}
	}

	// Token: 0x06019A79 RID: 105081 RVA: 0x006AB23F File Offset: 0x006A943F
	protected override bool OnInit()
	{
		return true;
	}

	// Token: 0x06019A7A RID: 105082 RVA: 0x006AB244 File Offset: 0x006A9444
	protected override bool OnStart()
	{
		if (CharacterTriggerComponent._builtinFunc != null)
		{
			foreach (KeyValuePair<string, Func<TFormulaValue[], TFormulaValue>> keyValuePair in CharacterTriggerComponent._builtinFunc)
			{
				this.BuildInFunctions[keyValuePair.Key] = keyValuePair.Value;
			}
		}
		this.BuildInFunctions["GetSelfTeamAttributeByID"] = delegate(TFormulaValue[] args)
		{
			int attrId = (int)args[0];
			SceneTeamItem teamItem = SceneTeamModel.Instance.GetTeamItem((long)base.Entity.Id, new GetTeamItemOptions
			{
				ParamType = ETeamParamType.EntityId
			});
			if (teamItem != null && teamItem.IsMyRole())
			{
				return TFormulaValue.FromFloat(FormationAttributeController.Instance.GetValue((EFormationAttributeId)attrId));
			}
			return TFormulaValue.FromFloat(0f);
		};
		this.BuildInFunctions["GetSelfTeamMaxAttributeByID"] = delegate(TFormulaValue[] args)
		{
			int attrId = (int)args[0];
			SceneTeamItem teamItem = SceneTeamModel.Instance.GetTeamItem((long)base.Entity.Id, new GetTeamItemOptions
			{
				ParamType = ETeamParamType.EntityId
			});
			if (teamItem != null && teamItem.IsMyRole())
			{
				return TFormulaValue.FromFloat(FormationAttributeController.Instance.GetMax((EFormationAttributeId)attrId));
			}
			return TFormulaValue.FromFloat(0f);
		};
		return true;
	}

	// Token: 0x06019A7B RID: 105083 RVA: 0x006AB2E8 File Offset: 0x006A94E8
	protected override bool OnClear()
	{
		this.BuildInFunctions.Clear();
		foreach (int handle in new List<int>(this.TriggerMap.Keys))
		{
			this.RemoveTrigger(handle);
		}
		this.TriggerMap.Clear();
		return true;
	}

	// Token: 0x06019A7C RID: 105084 RVA: 0x006AB35C File Offset: 0x006A955C
	[NullableContext(2)]
	public unsafe int AddTrigger(ITriggerConfig config, [Nullable(1)] TTriggerCallback callback, TTriggerChecker checker = null)
	{
		if (config == null)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Battle;
			ELogAuthor author = ELogAuthor.ZQR;
			string message = "添加Trigger失败，找不到对应配置";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("owner", base.Entity.Id);
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return -1;
		}
		ETriggerEvent triggerType;
		if (!Enum.TryParse<ETriggerEvent>(config.Type, out triggerType))
		{
			Log instance2 = Log.Instance;
			ELogModule module2 = ELogModule.Battle;
			ELogAuthor author2 = ELogAuthor.ZQR;
			string message2 = "添加Trigger失败, 找不到对应的Trigger类型或客户端未作实现";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("owner", base.Entity.Id);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("triggerType", config.Type);
			instance2.Error(module2, author2, message2, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
			return -1;
		}
		int num = CharacterTriggerComponent._triggerHandleCounter++;
		try
		{
			Dictionary<string, Func<TFormulaValue[], TFormulaValue>> functions = new Dictionary<string, Func<TFormulaValue[], TFormulaValue>>(this.BuildInFunctions);
			Trigger trigger = Trigger.Create(triggerType, config, num, this, functions, callback, checker);
			if (trigger == null)
			{
				Log instance3 = Log.Instance;
				ELogModule module3 = ELogModule.Battle;
				ELogAuthor author3 = ELogAuthor.ZQR;
				string message3 = "创建Trigger实例失败";
				<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray2 = default(<>y__InlineArray3<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 0) = new ValueTuple<string, object>("owner", base.Entity.Id);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 1) = new ValueTuple<string, object>("triggerType", config.Type);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 2) = new ValueTuple<string, object>("formula", config.Formula);
				instance3.Error(module3, author3, message3, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray2, 3));
				return -1;
			}
			trigger.OnInitParams(config.Preset);
			this.TriggerMap[num] = trigger;
		}
		catch (Exception ex)
		{
			Log instance4 = Log.Instance;
			ELogModule module4 = ELogModule.Battle;
			ELogAuthor author4 = ELogAuthor.ZQR;
			string message4 = "创建Trigger实例失败";
			Exception error = ex;
			<>y__InlineArray4<ValueTuple<string, object>> <>y__InlineArray3 = default(<>y__InlineArray4<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray3, 0) = new ValueTuple<string, object>("owner", base.Entity.Id);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray3, 1) = new ValueTuple<string, object>("triggerType", config.Type);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray3, 2) = new ValueTuple<string, object>("formula", config.Formula);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray3, 3) = new ValueTuple<string, object>("error", ex.Message);
			instance4.ErrorWithStack(module4, author4, message4, error, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray3, 4));
			return -1;
		}
		return num;
	}

	// Token: 0x06019A7D RID: 105085 RVA: 0x006AB5B8 File Offset: 0x006A97B8
	[NullableContext(2)]
	public Trigger GetTrigger(int handle)
	{
		return this.TriggerMap.GetValueOrDefault(handle);
	}

	// Token: 0x06019A7E RID: 105086 RVA: 0x006AB5C8 File Offset: 0x006A97C8
	public void RemoveTrigger(int handle)
	{
		Trigger valueOrDefault = this.TriggerMap.GetValueOrDefault(handle);
		if (valueOrDefault != null)
		{
			valueOrDefault.Destroy();
			this.TriggerMap.Remove(handle);
		}
	}

	// Token: 0x06019A7F RID: 105087 RVA: 0x006AB5F8 File Offset: 0x006A97F8
	public void SetTriggerActive(int handle, bool active)
	{
		Trigger valueOrDefault = this.TriggerMap.GetValueOrDefault(handle);
		if (valueOrDefault == null)
		{
			return;
		}
		valueOrDefault.SetActive(active);
	}

	// Token: 0x06019A80 RID: 105088 RVA: 0x006AB614 File Offset: 0x006A9814
	public static void CreateStaticDefaultValue()
	{
		Dictionary<string, Func<TFormulaValue[], TFormulaValue>> dictionary = new Dictionary<string, Func<TFormulaValue[], TFormulaValue>>();
		dictionary["GetTags"] = delegate(TFormulaValue[] args)
		{
			IEnumerable<int> allExactTags = ((Entity)args[0]).CheckGetComponent<BaseTagComponent>().TagContainer.GetAllExactTags();
			List<string> list = new List<string>();
			if (allExactTags != null)
			{
				foreach (int tagId in allExactTags)
				{
					string nameByTagId = GameplayTagUtils.GetNameByTagId(tagId);
					if (nameByTagId != null)
					{
						list.Add(nameByTagId);
					}
				}
			}
			return TFormulaValue.FromStringArray(list.ToArray());
		};
		dictionary["GetAttributeByID"] = delegate(TFormulaValue[] args)
		{
			Entity entity = (Entity)args[0];
			int attrId = (int)args[1];
			return TFormulaValue.FromFloat(entity.CheckGetComponent<BaseAttributeComponent>().GetCurrentValue((EAttributeType)attrId));
		};
		dictionary["HasInt"] = delegate(TFormulaValue[] args)
		{
			long num = (long)args[0];
			long[] array = args[1];
			if (array.Length == 0)
			{
				return TFormulaValue.FromBool(false);
			}
			long[] array2 = array;
			for (int i = 0; i < array2.Length; i++)
			{
				if (array2[i] == num)
				{
					return TFormulaValue.FromBool(true);
				}
			}
			return TFormulaValue.FromBool(false);
		};
		dictionary["MatchAnyInt"] = delegate(TFormulaValue[] args)
		{
			long[] array = args[0];
			long[] array2 = args[1];
			if (array.Length == 0 || array2.Length == 0)
			{
				return TFormulaValue.FromBool(false);
			}
			foreach (long num in array)
			{
				foreach (long num2 in array2)
				{
					if (num == num2)
					{
						return TFormulaValue.FromBool(true);
					}
				}
			}
			return TFormulaValue.FromBool(false);
		};
		dictionary["MatchAllInt"] = delegate(TFormulaValue[] args)
		{
			long[] array = args[0];
			long[] array2 = args[1];
			if (array.Length == 0 || array2.Length == 0)
			{
				return TFormulaValue.FromBool(false);
			}
			foreach (long num in array)
			{
				bool flag = false;
				foreach (long num2 in array2)
				{
					if (num == num2)
					{
						flag = true;
						break;
					}
				}
				if (!flag)
				{
					return TFormulaValue.FromBool(false);
				}
			}
			return TFormulaValue.FromBool(true);
		};
		dictionary["MatchAnyTag"] = delegate(TFormulaValue[] args)
		{
			Entity entity = (Entity)args[0];
			string[] array = (string[])args[1];
			List<int> list = new List<int>();
			foreach (string tagName in array)
			{
				list.Add(GameplayTagUtils.GetTagIdByName(tagName));
			}
			return TFormulaValue.FromBool(entity.CheckGetComponent<BaseTagComponent>().HasAnyTag(list));
		};
		dictionary["MatchAllTags"] = delegate(TFormulaValue[] args)
		{
			Entity entity = (Entity)args[0];
			string[] array = (string[])args[1];
			List<int> list = new List<int>();
			foreach (string tagName in array)
			{
				list.Add(GameplayTagUtils.GetTagIdByName(tagName));
			}
			return TFormulaValue.FromBool(entity.CheckGetComponent<BaseTagComponent>().HasAllTag(list));
		};
		dictionary["GetShieldValue"] = delegate(TFormulaValue[] args)
		{
			CharacterShieldComponent characterShieldComponent = ((Entity)args[0]).CheckGetComponent<CharacterShieldComponent>();
			return TFormulaValue.FromFloat((characterShieldComponent != null) ? characterShieldComponent.ShieldTotal : 0f);
		};
		dictionary["Distance"] = delegate(TFormulaValue[] args)
		{
			Entity entity2;
			Entity entity = args[0].TryGetEntity(out entity2) ? entity2 : null;
			Entity entity4;
			Entity entity3 = args[1].TryGetEntity(out entity4) ? entity4 : null;
			CreatureModel instance = CreatureModel.Instance;
			CreatureDataComponent creatureDataComponent = (entity != null) ? entity.GetComponent<CreatureDataComponent>() : null;
			CreatureDataComponent creatureDataComponent2 = (entity3 != null) ? entity3.GetComponent<CreatureDataComponent>() : null;
			global::Vector vector;
			if (creatureDataComponent == null || !creatureDataComponent.IsRole())
			{
				if (entity == null)
				{
					vector = null;
				}
				else
				{
					CharacterActorComponent characterActorComponent = entity.CheckGetComponent<CharacterActorComponent>();
					vector = ((characterActorComponent != null) ? characterActorComponent.ActorLocationProxy : null);
				}
			}
			else
			{
				ScenePlayerData scenePlayerData = instance.GetScenePlayerData(creatureDataComponent.GetPlayerId());
				vector = ((scenePlayerData != null) ? scenePlayerData.GetLocation() : null);
			}
			global::Vector vector2 = vector;
			global::Vector vector3;
			if (creatureDataComponent2 == null || !creatureDataComponent2.IsRole())
			{
				if (entity3 == null)
				{
					vector3 = null;
				}
				else
				{
					CharacterActorComponent characterActorComponent2 = entity3.CheckGetComponent<CharacterActorComponent>();
					vector3 = ((characterActorComponent2 != null) ? characterActorComponent2.ActorLocationProxy : null);
				}
			}
			else
			{
				ScenePlayerData scenePlayerData2 = instance.GetScenePlayerData(creatureDataComponent2.GetPlayerId());
				vector3 = ((scenePlayerData2 != null) ? scenePlayerData2.GetLocation() : null);
			}
			global::Vector vector4 = vector3;
			if (vector2 == null || vector4 == null)
			{
				return TFormulaValue.FromFloat(float.PositiveInfinity);
			}
			return TFormulaValue.FromFloat((float)global::Vector.Dist(vector2, vector4));
		};
		dictionary["Distance2D"] = delegate(TFormulaValue[] args)
		{
			Entity entity = (Entity)args[0];
			Entity entity2 = (Entity)args[1];
			CreatureModel instance = CreatureModel.Instance;
			CreatureDataComponent component = entity.GetComponent<CreatureDataComponent>();
			CreatureDataComponent component2 = entity2.GetComponent<CreatureDataComponent>();
			global::Vector vector;
			if (component == null || !component.IsRole())
			{
				CharacterActorComponent characterActorComponent = entity.CheckGetComponent<CharacterActorComponent>();
				vector = ((characterActorComponent != null) ? characterActorComponent.ActorLocationProxy : null);
			}
			else
			{
				ScenePlayerData scenePlayerData = instance.GetScenePlayerData(component.GetPlayerId());
				vector = ((scenePlayerData != null) ? scenePlayerData.GetLocation() : null);
			}
			global::Vector vector2 = vector;
			global::Vector vector3;
			if (component2 == null || !component2.IsRole())
			{
				CharacterActorComponent characterActorComponent2 = entity2.CheckGetComponent<CharacterActorComponent>();
				vector3 = ((characterActorComponent2 != null) ? characterActorComponent2.ActorLocationProxy : null);
			}
			else
			{
				ScenePlayerData scenePlayerData2 = instance.GetScenePlayerData(component2.GetPlayerId());
				vector3 = ((scenePlayerData2 != null) ? scenePlayerData2.GetLocation() : null);
			}
			global::Vector vector4 = vector3;
			if (vector2 == null || vector4 == null)
			{
				return TFormulaValue.FromFloat(float.PositiveInfinity);
			}
			return TFormulaValue.FromFloat((float)global::Vector.Dist2D(vector2, vector4));
		};
		dictionary["GetBattleScore"] = ((TFormulaValue[] args) => TFormulaValue.FromFloat((float)BattleScoreModel.Instance.GetCurScore()));
		dictionary["GetBuffStack"] = delegate(TFormulaValue[] args)
		{
			Entity entity = (Entity)args[0];
			long buffId = (long)args[1];
			RoleBuffComponent component = entity.GetComponent<RoleBuffComponent>();
			if (component != null)
			{
				PlayerBuffComponent formationBuffComp = component.GetFormationBuffComp();
				return TFormulaValue.FromInt(((formationBuffComp != null) ? formationBuffComp.GetFormationBuffTotalStackById(buffId, false) : 0) + component.GetBuffTotalStackById(buffId, false));
			}
			BaseBuffComponent baseBuffComponent = entity.CheckGetComponent<BaseBuffComponent>();
			return TFormulaValue.FromInt((baseBuffComponent != null) ? baseBuffComponent.GetBuffTotalStackById(buffId, false) : 0);
		};
		dictionary["MatchAnyBattleFlags"] = delegate(TFormulaValue[] args)
		{
			string[] array = (string[])args[0];
			string[] array2 = (string[])args[1];
			if (array.Length == 0 || array2.Length == 0)
			{
				return TFormulaValue.FromBool(false);
			}
			foreach (string a in array)
			{
				foreach (string b in array2)
				{
					if (a == b)
					{
						return TFormulaValue.FromBool(true);
					}
				}
			}
			return TFormulaValue.FromBool(false);
		};
		dictionary["GetTagStackCount"] = delegate(TFormulaValue[] args)
		{
			Entity entity = (Entity)args[0];
			string tagName = (string)args[1];
			BaseTagComponent component = entity.GetComponent<BaseTagComponent>();
			return TFormulaValue.FromInt((component != null) ? component.GetTagCount(GameplayTagUtils.GetTagIdByName(tagName)) : 0);
		};
		dictionary["MatchAnyBuff"] = delegate(TFormulaValue[] args)
		{
			Entity entity;
			object obj = args[0].TryGetEntity(out entity) ? entity : null;
			long[] array = args[1];
			bool excludeRequestRemove = args.Length > 2 && (bool)args[2];
			object obj2 = obj;
			BaseBuffComponent baseBuffComponent = (obj2 != null) ? obj2.GetComponent<BaseBuffComponent>() : null;
			if (baseBuffComponent == null || array.Length == 0)
			{
				return TFormulaValue.FromBool(false);
			}
			foreach (long buffId in array)
			{
				if (baseBuffComponent.HasBuff(buffId, excludeRequestRemove))
				{
					return TFormulaValue.FromBool(true);
				}
			}
			return TFormulaValue.FromBool(false);
		};
		dictionary["MatchAllBuff"] = delegate(TFormulaValue[] args)
		{
			Entity entity;
			object obj = args[0].TryGetEntity(out entity) ? entity : null;
			long[] array = args[1];
			bool excludeRequestRemove = args.Length > 2 && (bool)args[2];
			object obj2 = obj;
			BaseBuffComponent baseBuffComponent = (obj2 != null) ? obj2.GetComponent<BaseBuffComponent>() : null;
			if (baseBuffComponent == null || array.Length == 0)
			{
				return TFormulaValue.FromBool(false);
			}
			foreach (long buffId in array)
			{
				if (!baseBuffComponent.HasBuff(buffId, excludeRequestRemove))
				{
					return TFormulaValue.FromBool(false);
				}
			}
			return TFormulaValue.FromBool(true);
		};
		dictionary["GetMaxTagCountIndex"] = delegate(TFormulaValue[] args)
		{
			Entity entity = (Entity)args[0];
			string[] array = (string[])args[1];
			int value = 0;
			int num = 0;
			BaseTagComponent component = entity.GetComponent<BaseTagComponent>();
			if (component == null || array.Length == 0)
			{
				return TFormulaValue.FromInt(value);
			}
			for (int i = 0; i < array.Length; i++)
			{
				string tagName = array[i];
				int tagCount = component.GetTagCount(GameplayTagUtils.GetTagIdByName(tagName));
				if (tagCount > num)
				{
					num = tagCount;
					value = i;
				}
			}
			return TFormulaValue.FromInt(value);
		};
		dictionary["GetEntityCountCheckAttr"] = delegate(TFormulaValue[] args)
		{
			Entity entity = (Entity)args[0];
			long num = (long)args[1];
			int attrId = (int)args[2];
			int checkType = (int)args[3];
			float num2 = (float)args[4];
			int num3 = 0;
			if (num == 0L)
			{
				return TFormulaValue.FromInt(CharacterTriggerComponent.CheckRoleAttr(entity, checkType, attrId, num2));
			}
			List<EntityHandle> teamEntities = SceneTeamModel.Instance.GetTeamEntities(false);
			int playerId = entity.GetComponent<CreatureDataComponent>().GetPlayerId();
			foreach (EntityHandle entityHandle in teamEntities)
			{
				if (num == 1L)
				{
					WorldEntity entity2 = entityHandle.Entity;
					if (entity2 == null || entity2.GetComponent<CreatureDataComponent>().GetPlayerId() != playerId)
					{
						continue;
					}
				}
				num3 += CharacterTriggerComponent.CheckRoleAttr(entityHandle.Entity, checkType, attrId, num2);
			}
			return TFormulaValue.FromInt(num3);
		};
		dictionary["GetContainTagEntityCount"] = delegate(TFormulaValue[] args)
		{
			Entity entity = (Entity)args[0];
			int num = (int)args[1];
			string tagName = (string)args[2];
			int num2 = 0;
			if (num != 0)
			{
				List<EntityHandle> teamEntities = SceneTeamModel.Instance.GetTeamEntities(false);
				int playerId = entity.GetComponent<CreatureDataComponent>().GetPlayerId();
				foreach (EntityHandle entityHandle in teamEntities)
				{
					if (num == 1)
					{
						WorldEntity entity2 = entityHandle.Entity;
						if (entity2 == null || entity2.GetComponent<CreatureDataComponent>().GetPlayerId() != playerId)
						{
							continue;
						}
					}
					WorldEntity entity3 = entityHandle.Entity;
					bool flag;
					if (entity3 == null)
					{
						flag = false;
					}
					else
					{
						BaseTagComponent component = entity3.GetComponent<BaseTagComponent>();
						flag = ((component != null) ? new bool?(component.HasTag(GameplayTagUtils.GetTagIdByName(tagName))) : null).GetValueOrDefault();
					}
					if (flag)
					{
						num2++;
					}
				}
				return TFormulaValue.FromInt(num2);
			}
			BaseTagComponent component2 = entity.GetComponent<BaseTagComponent>();
			if (component2 != null && component2.HasTag(GameplayTagUtils.GetTagIdByName(tagName)))
			{
				return TFormulaValue.FromInt(1);
			}
			return TFormulaValue.FromInt(0);
		};
		dictionary["GetArrayElement"] = delegate(TFormulaValue[] args)
		{
			int num = (int)args[1];
			TFormulaValue result;
			if (args[0].TryGetArrayElement(num, out result))
			{
				return result;
			}
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Battle;
			ELogAuthor author = ELogAuthor.TZQ;
			string message = "被动获取数组元素异常index不合法";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("index", num);
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return default(TFormulaValue);
		};
		dictionary["Max"] = delegate(TFormulaValue[] args)
		{
			if (args.Length == 0)
			{
				return TFormulaValue.FromDouble(0.0);
			}
			double num = (double)args[0];
			for (int i = 1; i < args.Length; i++)
			{
				num = Math.Max(num, (double)args[i]);
			}
			return TFormulaValue.FromDouble(num);
		};
		dictionary["Min"] = delegate(TFormulaValue[] args)
		{
			if (args.Length == 0)
			{
				return TFormulaValue.FromDouble(0.0);
			}
			double num = (double)args[0];
			for (int i = 1; i < args.Length; i++)
			{
				num = Math.Min(num, (double)args[i]);
			}
			return TFormulaValue.FromDouble(num);
		};
		CharacterTriggerComponent._builtinFunc = dictionary;
	}

	// Token: 0x06019A81 RID: 105089 RVA: 0x006AB9C7 File Offset: 0x006A9BC7
	public static void ResetStaticDefaultValue()
	{
		CharacterTriggerComponent._builtinFunc = null;
		CharacterTriggerComponent._triggerHandleCounter = 0;
	}

	// Token: 0x06019A82 RID: 105090 RVA: 0x006AB9D8 File Offset: 0x006A9BD8
	[NullableContext(2)]
	private unsafe static int CheckRoleAttr(Entity entity, int checkType, int attrId, float threshold)
	{
		BaseAttributeComponent baseAttributeComponent = (entity != null) ? entity.GetComponent<BaseAttributeComponent>() : null;
		float? num = (baseAttributeComponent != null) ? new float?(baseAttributeComponent.GetCurrentValue((EAttributeType)attrId)) : null;
		if (num == null || num.Value == 0f)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Battle;
			ELogAuthor author = ELogAuthor.TZQ;
			string message = "被动获取不到属性";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("owner", (entity != null) ? new int?(entity.Id) : null);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("attrId", attrId);
			instance.Warn(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
			return 0;
		}
		if (checkType == 0)
		{
			return (num.Value < threshold) ? 1 : 0;
		}
		if (checkType == 1)
		{
			return (Math.Abs(num.Value - threshold) < 1.1754944E-38f) ? 1 : 0;
		}
		return (checkType == 2 && num.Value > threshold) ? 1 : 0;
	}

	// Token: 0x06019A83 RID: 105091 RVA: 0x006ABAD4 File Offset: 0x006A9CD4
	public override bool ClearComponent(EntityComponent componentTemplate)
	{
		if (!base.ClearComponent(componentTemplate))
		{
			return false;
		}
		CharacterTriggerComponent characterTriggerComponent = (CharacterTriggerComponent)componentTemplate;
		return (!base.CanResetComponentProperty("TriggerMap") || characterTriggerComponent.TriggerMap == null || base.CheckClearObject(EntityComponentSystem.ClearObject<Dictionary<int, Trigger>>(this.TriggerMap), "TriggerMap")) && (!base.CanResetComponentProperty("BuildInFunctions") || characterTriggerComponent.BuildInFunctions == null || base.CheckClearObject(EntityComponentSystem.ClearObject<Dictionary<string, Func<TFormulaValue[], TFormulaValue>>>(this.BuildInFunctions), "BuildInFunctions"));
	}

	// Token: 0x0400C038 RID: 49208
	private readonly Dictionary<int, Trigger> TriggerMap = new Dictionary<int, Trigger>();

	// Token: 0x0400C039 RID: 49209
	private readonly Dictionary<string, Func<TFormulaValue[], TFormulaValue>> BuildInFunctions = new Dictionary<string, Func<TFormulaValue[], TFormulaValue>>();

	// Token: 0x0400C03A RID: 49210
	[Nullable(new byte[]
	{
		2,
		1,
		1,
		1
	})]
	private static Dictionary<string, Func<TFormulaValue[], TFormulaValue>> _builtinFunc;

	// Token: 0x0400C03B RID: 49211
	private static int _triggerHandleCounter;
}
