using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Core.Framework;
using CSharpScript.Game;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Input;
using Google.Protobuf;
using Google.Protobuf.Collections;
using UnrealEngine;

// Token: 0x02002A46 RID: 10822
[NullableContext(1)]
[Nullable(0)]
[TickController(0)]
public class AceAntiCheatController : ControllerBase
{
	// Token: 0x0601B585 RID: 112005 RVA: 0x00863508 File Offset: 0x00861708
	protected override bool OnInit()
	{
		Net.Instance.Register(ENotifyMessageId.BattleAntiCheatingLogNotify, new Action<IMessage, Net.CallbackStatus>(this.BattleAntiCheatingLogNotify));
		return true;
	}

	// Token: 0x0601B586 RID: 112006 RVA: 0x00863527 File Offset: 0x00861727
	protected override bool OnClear()
	{
		Net.Instance.UnRegister(ENotifyMessageId.BattleAntiCheatingLogNotify);
		return true;
	}

	// Token: 0x0601B587 RID: 112007 RVA: 0x0086353C File Offset: 0x0086173C
	protected override void OnTick(float delta)
	{
		if (this.NeedColletSpeed)
		{
			TsBaseCharacter baseCharacter = Global.BaseCharacter;
			double? num;
			if (baseCharacter == null)
			{
				num = null;
			}
			else
			{
				CharacterActorComponent characterActorComponent = baseCharacter.CharacterActorComponent;
				num = ((characterActorComponent != null) ? new double?(characterActorComponent.ActorVelocityProxy.Size()) : null);
			}
			double? num2 = num;
			int num3 = (int)num2.GetValueOrDefault();
			if (num3 > 0)
			{
				this.AvgSpeed = (this.CurSpeedCount * this.AvgSpeed + num3) / (this.CurSpeedCount + 1);
				this.CurSpeedCount++;
				if (num3 < this.MinSpeed)
				{
					this.MinSpeed = num3;
				}
				if (num3 > this.MaxSpeed)
				{
					this.MaxSpeed = num3;
				}
			}
		}
		if (this.NeedColletPos && this.FightRoleInfoMap != null)
		{
			this.PosTickTime += delta;
			if (this.PosTickTime > 1000f)
			{
				this.PosTickTime -= 1000f;
				foreach (long num4 in this.FightRoleInfoMap.Keys)
				{
					EntityHandle entity = CreatureModel.Instance.GetEntity(num4);
					global::Vector vector;
					if (entity == null)
					{
						vector = null;
					}
					else
					{
						WorldEntity entity2 = entity.Entity;
						if (entity2 == null)
						{
							vector = null;
						}
						else
						{
							BaseActorComponent component = entity2.GetComponent<BaseActorComponent>();
							vector = ((component != null) ? component.ActorLocationProxy : null);
						}
					}
					global::Vector vector2 = vector;
					if (vector2 != null)
					{
						RepeatedField<Aki.Protocol.Vector> posList = this.FightRoleInfoMap[num4].PosList;
						posList.Add(vector2.ToProtocolVector());
						if (posList.Count > 120)
						{
							this.NeedColletPos = false;
						}
					}
				}
			}
		}
	}

	// Token: 0x0601B588 RID: 112008 RVA: 0x008636D4 File Offset: 0x008618D4
	[NullableContext(2)]
	private void BattleAntiCheatingLogNotify(IMessage msg, Net.CallbackStatus _)
	{
		BattleAntiCheatingLogNotify battleAntiCheatingLogNotify = (BattleAntiCheatingLogNotify)msg;
		long logId = battleAntiCheatingLogNotify.LogId;
		switch (battleAntiCheatingLogNotify.LogType)
		{
		case 0:
			break;
		case 1:
			this.StartSecFbRound(logId);
			return;
		case 2:
			this.EndSecFbRound(logId);
			return;
		case 3:
			this.StartSecRoleFightFlowBigWorld(logId);
			return;
		case 4:
			this.EndSecRoleFightFlowBigWorld(logId);
			return;
		case 5:
			this.StartSecRoleFightFlowInst(logId);
			return;
		case 6:
			this.EndSecRoleFightFlowInst(logId);
			return;
		case 7:
			this.StartSecWorldInfoFlow(logId, battleAntiCheatingLogNotify.TimoutSpan);
			return;
		case 8:
			this.EndSecWorldInfoFlow(logId);
			return;
		case 9:
			this.StartSecWorldFlow(logId);
			return;
		case 10:
			this.EndSecWorldFlow(logId);
			return;
		default:
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Net;
			ELogAuthor author = ELogAuthor.ZFJ;
			string message = "UnknownAntiCheatingLogType";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("Type", battleAntiCheatingLogNotify.LogType);
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			break;
		}
		}
	}

	// Token: 0x0601B589 RID: 112009 RVA: 0x008637B4 File Offset: 0x008619B4
	[return: Nullable(new byte[]
	{
		2,
		1
	})]
	private List<SceneTeamRole> GetRoleList()
	{
		int? id = PlayerInfoModel.Instance.GetId();
		int? num = id;
		int num2 = 0;
		if (num.GetValueOrDefault() == num2 & num != null)
		{
			Log.Instance.Error(ELogModule.Net, ELogAuthor.ZFJ, "StartSecFbRound playerId Error", default(ReadOnlySpan<ValueTuple<string, object>>));
			return null;
		}
		SceneTeamModel instance = SceneTeamModel.Instance;
		if (instance == null)
		{
			return null;
		}
		SceneTeamPlayer teamPlayerData = instance.GetTeamPlayerData(id.GetValueOrDefault());
		if (teamPlayerData == null)
		{
			return null;
		}
		SceneTeamGroup group = teamPlayerData.GetGroup(ETeamGroupType.Battle);
		if (group == null)
		{
			return null;
		}
		return group.GetRoleList();
	}

	// Token: 0x0601B58A RID: 112010 RVA: 0x00863830 File Offset: 0x00861A30
	private void StartSecFbRound(long logId)
	{
		if (this.SecFbRoundLogId > 0L)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Net;
			ELogAuthor author = ELogAuthor.ZFJ;
			string message = "StartSecFbRound repeat";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("logId", logId);
			instance.Warn(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return;
		}
		this.SecFbRoundLogId = logId;
		this.SecFbRoundStartTime = Time.Instance.WorldTime;
		SecFBRoundStartFlowRequest secFBRoundStartFlowRequest = SecFBRoundStartFlowRequest.Create();
		secFBRoundStartFlowRequest.LogId = logId;
		secFBRoundStartFlowRequest.ClientStartTime = TimeUtil.Instance.DateFormat2(DateTime.Now);
		List<SceneTeamRole> roleList = this.GetRoleList();
		if (roleList == null)
		{
			Log instance2 = Log.Instance;
			ELogModule module2 = ELogModule.Net;
			ELogAuthor author2 = ELogAuthor.ZFJ;
			string message2 = "StartSecFbRound roleList Error";
			ValueTuple<string, object> valueTuple2 = new ValueTuple<string, object>("logId", logId);
			instance2.Error(module2, author2, message2, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple2));
			return;
		}
		secFBRoundStartFlowRequest.SrvFighter1Info = ((roleList.Count > 0) ? this.GetSrvFighterInfo(roleList[0]) : null);
		secFBRoundStartFlowRequest.SrvFighter2Info = ((roleList.Count > 1) ? this.GetSrvFighterInfo(roleList[1]) : null);
		secFBRoundStartFlowRequest.SrvFighter3Info = ((roleList.Count > 2) ? this.GetSrvFighterInfo(roleList[2]) : null);
		secFBRoundStartFlowRequest.SrvFighter4Info = ((roleList.Count > 3) ? this.GetSrvFighterInfo(roleList[3]) : null);
		this.SetCollectSpeed(true);
		Net.Instance.Call(ERequestMessageId.SecFBRoundStartFlowRequest, secFBRoundStartFlowRequest, null, 0);
	}

	// Token: 0x0601B58B RID: 112011 RVA: 0x0086397C File Offset: 0x00861B7C
	private SrvFighterInfo GetSrvFighterInfo(SceneTeamRole sceneTeamRole)
	{
		SrvFighterInfo srvFighterInfo = SrvFighterInfo.Create();
		RoleModel instance = RoleModel.Instance;
		RoleInstance roleInstance = (instance != null) ? instance.GetRoleInstanceById(sceneTeamRole.RoleId) : null;
		RoleLevelData roleLevelData = (roleInstance != null) ? roleInstance.GetLevelData() : null;
		srvFighterInfo.Breakthrough = ((roleLevelData != null) ? roleLevelData.GetBreachLevel() : 0);
		srvFighterInfo.Level = ((roleLevelData != null) ? roleLevelData.GetLevel() : 0);
		srvFighterInfo.Exp = ((roleLevelData != null) ? roleLevelData.GetExp() : 0);
		srvFighterInfo.RoleId = sceneTeamRole.RoleId;
		EntityHandle entity = CreatureModel.Instance.GetEntity(sceneTeamRole.CreatureDataId);
		BaseAttributeComponent baseAttributeComponent;
		if (entity == null)
		{
			baseAttributeComponent = null;
		}
		else
		{
			WorldEntity entity2 = entity.Entity;
			baseAttributeComponent = ((entity2 != null) ? entity2.GetComponent<BaseAttributeComponent>() : null);
		}
		BaseAttributeComponent baseAttributeComponent2 = baseAttributeComponent;
		if (baseAttributeComponent2 != null)
		{
			List<PropConfig> list = new List<PropConfig>();
			for (int i = 1; i < 143; i++)
			{
				PropConfig propConfig = PropConfig.Create();
				propConfig.Id = i;
				propConfig.Value = baseAttributeComponent2.GetCurrentValue((EAttributeType)i);
				list.Add(propConfig);
			}
			srvFighterInfo.PropDataList.AddRange(list);
		}
		RoleSkillData roleSkillData = (roleInstance != null) ? roleInstance.GetSkillData() : null;
		Aki.Config.Skill[] array = (roleSkillData != null) ? roleSkillData.GetSkillList() : null;
		if (roleSkillData != null && array != null)
		{
			List<SrvFighterSkillInfo> list2 = new List<SrvFighterSkillInfo>();
			foreach (Aki.Config.Skill skill in array)
			{
				SrvFighterSkillInfo srvFighterSkillInfo = SrvFighterSkillInfo.Create();
				srvFighterSkillInfo.SkillId = skill.Id;
				srvFighterSkillInfo.Level = roleSkillData.GetSkillLevel(skill.Id);
				list2.Add(srvFighterSkillInfo);
			}
			srvFighterInfo.SrvFighterSkillInfo.AddRange(list2);
		}
		return srvFighterInfo;
	}

	// Token: 0x0601B58C RID: 112012 RVA: 0x00863B02 File Offset: 0x00861D02
	private void SetCollectSpeed(bool isStart)
	{
		this.NeedColletSpeed = isStart;
		this.CurSpeedCount = 0;
		this.AvgSpeed = 0;
		this.MaxSpeed = 0;
		this.MinSpeed = 999999;
	}

	// Token: 0x0601B58D RID: 112013 RVA: 0x00863B2C File Offset: 0x00861D2C
	private unsafe void EndSecFbRound(long logId)
	{
		if (this.SecFbRoundLogId != logId)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Net;
			ELogAuthor author = ELogAuthor.ZFJ;
			string message = "EndSecFbRound logId Error";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("logId", logId);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("SecFbRoundLogId", this.SecFbRoundLogId);
			instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
			return;
		}
		SecFBRoundEndFlowReportRequest secFBRoundEndFlowReportRequest = SecFBRoundEndFlowReportRequest.Create();
		secFBRoundEndFlowReportRequest.LogId = logId;
		secFBRoundEndFlowReportRequest.ClientEndTime = TimeUtil.Instance.DateFormat2(DateTime.Now);
		secFBRoundEndFlowReportRequest.RoundTimeUse = (long)(Time.Instance.WorldTime - this.SecFbRoundStartTime);
		secFBRoundEndFlowReportRequest.SpeedMax = this.MaxSpeed;
		secFBRoundEndFlowReportRequest.SpeedMin = ((this.MinSpeed == 999999) ? 0 : this.MinSpeed);
		secFBRoundEndFlowReportRequest.SpeedAvg = this.AvgSpeed;
		this.SetCollectSpeed(false);
		Net.Instance.Call(ERequestMessageId.SecFBRoundEndFlowReportRequest, secFBRoundEndFlowReportRequest, null, 0);
		this.SecFbRoundLogId = -1L;
	}

	// Token: 0x0601B58E RID: 112014 RVA: 0x00863C34 File Offset: 0x00861E34
	private void StartSecRoleFightFlowBigWorld(long logId)
	{
		if (this.SecRoleFightFlowBigWorldLogId > 0L)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Net;
			ELogAuthor author = ELogAuthor.ZFJ;
			string message = "StartSecRoleFightFlowBigWorld repeat";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("logId", logId);
			instance.Warn(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return;
		}
		this.StartColletRoleFightFlow();
		this.SecRoleFightFlowBigWorldLogId = logId;
	}

	// Token: 0x0601B58F RID: 112015 RVA: 0x00863C88 File Offset: 0x00861E88
	private unsafe void EndSecRoleFightFlowBigWorld(long logId)
	{
		if (this.SecRoleFightFlowBigWorldLogId != logId)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Net;
			ELogAuthor author = ELogAuthor.ZFJ;
			string message = "EndSecRoleFightFlowBigWorld logId Error";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("logId", logId);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("SecRoleFightFlowBigWorldLogId", this.SecRoleFightFlowBigWorldLogId);
			instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
			return;
		}
		this.SendRoleFightFlowRequest(logId, AceBattleAntiCheatingLogType.LogTypeSecRoleFightFlowBigWorldEnd);
		this.SecRoleFightFlowBigWorldLogId = -1L;
	}

	// Token: 0x0601B590 RID: 112016 RVA: 0x00863D14 File Offset: 0x00861F14
	private void OnAnyCurrentValueChange(EAttributeType attrId, float oldValue, float newValue)
	{
		if (this.FightRoleInfoMap == null)
		{
			Log.Instance.Warn(ELogModule.Net, ELogAuthor.ZFJ, "SetNewAttrMaxValue FightRoleInfoMap nil", default(ReadOnlySpan<ValueTuple<string, object>>));
			return;
		}
		foreach (long num in this.FightRoleInfoMap.Keys)
		{
			EntityHandle entity = CreatureModel.Instance.GetEntity(num);
			object obj;
			if (entity == null)
			{
				obj = null;
			}
			else
			{
				WorldEntity entity2 = entity.Entity;
				obj = ((entity2 != null) ? entity2.GetComponent<BaseAttributeComponent>() : null);
			}
			object obj2 = obj;
			float num2 = (obj2 != null) ? obj2.GetCurrentValue(attrId) : 0f;
			SrvFighterInfo fighterInfoMax = this.FightRoleInfoMap[num].FighterInfoMax;
			PropConfig propConfig = (fighterInfoMax != null) ? fighterInfoMax.PropDataList[attrId - EAttributeType.Lv] : null;
			if (propConfig != null && propConfig.Id == (int)attrId && propConfig.Value < num2)
			{
				propConfig.Value = num2;
			}
		}
	}

	// Token: 0x0601B591 RID: 112017 RVA: 0x00863E0C File Offset: 0x0086200C
	private void OnDamage(Entity attacker, Entity victim, RequirementPayload requirements, DamageResult damageResult, FVectorDouble damagePosition)
	{
		if (this.FightRoleInfoMap == null)
		{
			Log.Instance.Warn(ELogModule.Net, ELogAuthor.ZFJ, "OnDamage FightRoleInfoMap nil", default(ReadOnlySpan<ValueTuple<string, object>>));
			return;
		}
		float damage = damageResult.Damage;
		if (damage == 0f)
		{
			return;
		}
		int num = (int)(-(int)damage);
		foreach (long num2 in this.FightRoleInfoMap.Keys)
		{
			CreatureDataComponent component = attacker.GetComponent<CreatureDataComponent>();
			long? num3 = (component != null) ? new long?(component.GetCreatureDataId()) : null;
			long num4 = num2;
			if (num3.GetValueOrDefault() == num4 & num3 != null)
			{
				SecRoleFightFlowData secRoleFightFlowData = this.FightRoleInfoMap[num2];
				secRoleFightFlowData.RoundFighterDpsTotal = (long)num + secRoleFightFlowData.RoundFighterDpsTotal;
				secRoleFightFlowData.RoundFighterDpsCount++;
				secRoleFightFlowData.RoundFighterAtkMissTotal += ((requirements.IsImmune.GetValueOrDefault() > false) ? 1 : 0);
				if (requirements.IsCritical.GetValueOrDefault())
				{
					secRoleFightFlowData.RoundFighterPlayerCritCount++;
					if (num > secRoleFightFlowData.RoundFighterDamage2Max)
					{
						secRoleFightFlowData.RoundFighterDamage2Max = num;
					}
					if (num < secRoleFightFlowData.RoundFighterDamage2Min)
					{
						secRoleFightFlowData.RoundFighterDamage2Min = num;
					}
				}
				else
				{
					if (num > secRoleFightFlowData.RoundFighterDamage1Max)
					{
						secRoleFightFlowData.RoundFighterDamage1Max = num;
					}
					if (num < secRoleFightFlowData.RoundFighterDamage1Min)
					{
						secRoleFightFlowData.RoundFighterDamage1Min = num;
					}
				}
			}
		}
	}

	// Token: 0x0601B592 RID: 112018 RVA: 0x00863F9C File Offset: 0x0086219C
	private void OnCharInputPress(EInputAction action, float time)
	{
		if (this.CurGlobalRoleCreatureId == null || this.FightRoleInfoMap == null)
		{
			return;
		}
		SecRoleFightFlowData secRoleFightFlowData;
		if (!this.FightRoleInfoMap.TryGetValue(this.CurGlobalRoleCreatureId.Value, out secRoleFightFlowData))
		{
			return;
		}
		switch (action)
		{
		case 1:
			secRoleFightFlowData.RoundFighterButtonClickCountJump++;
			return;
		case 2:
		case 3:
		case 7:
			break;
		case 4:
			secRoleFightFlowData.RoundFighterButtonClickCountATK++;
			return;
		case 5:
			secRoleFightFlowData.RoundFighterButtonClickCountDodge++;
			return;
		case 6:
			secRoleFightFlowData.RoundFighterButtonClickCount3++;
			break;
		case 8:
			secRoleFightFlowData.RoundFighterButtonClickCount1++;
			return;
		case 9:
			secRoleFightFlowData.RoundFighterButtonClickCount2++;
			return;
		default:
			return;
		}
	}

	// Token: 0x0601B593 RID: 112019 RVA: 0x00864068 File Offset: 0x00862268
	private void OnChangeRole(EntityHandle newEntityHandle, [Nullable(2)] EntityHandle oldEntityHandle)
	{
		if (oldEntityHandle == null || this.FightRoleInfoMap == null)
		{
			return;
		}
		WorldEntity entity = oldEntityHandle.Entity;
		long? num;
		if (entity == null)
		{
			num = null;
		}
		else
		{
			CreatureDataComponent component = entity.GetComponent<CreatureDataComponent>();
			num = ((component != null) ? new long?(component.GetCreatureDataId()) : null);
		}
		long? num2 = num;
		SecRoleFightFlowData secRoleFightFlowData;
		if (num2 != null && this.FightRoleInfoMap.TryGetValue(num2.Value, out secRoleFightFlowData))
		{
			long residentTimeTotal = secRoleFightFlowData.ResidentTimeTotal;
			secRoleFightFlowData.ResidentTimeTotal = (long)(Time.Instance.WorldTime - this.ChangeRoleTimeStamp + (double)residentTimeTotal);
		}
		this.ChangeRoleTimeStamp = Time.Instance.WorldTime;
		WorldEntity entity2 = newEntityHandle.Entity;
		long? curGlobalRoleCreatureId;
		if (entity2 == null)
		{
			curGlobalRoleCreatureId = null;
		}
		else
		{
			CreatureDataComponent component2 = entity2.GetComponent<CreatureDataComponent>();
			curGlobalRoleCreatureId = ((component2 != null) ? new long?(component2.GetCreatureDataId()) : null);
		}
		this.CurGlobalRoleCreatureId = curGlobalRoleCreatureId;
	}

	// Token: 0x0601B594 RID: 112020 RVA: 0x00864140 File Offset: 0x00862340
	private void StartColletRoleFightFlow()
	{
		List<SceneTeamRole> roleList = this.GetRoleList();
		if (roleList == null)
		{
			Log.Instance.Error(ELogModule.Net, ELogAuthor.ZFJ, "StartColletRoleFightFlow roleList Error", default(ReadOnlySpan<ValueTuple<string, object>>));
			return;
		}
		this.FightRoleList = roleList;
		foreach (SceneTeamRole sceneTeamRole in roleList)
		{
			if (this.FightRoleInfoMap == null)
			{
				this.FightRoleInfoMap = new Dictionary<long, SecRoleFightFlowData>();
			}
			if (!this.FightRoleInfoMap.ContainsKey(sceneTeamRole.CreatureDataId))
			{
				SecRoleFightFlowData secRoleFightFlowData = SecRoleFightFlowData.Create();
				secRoleFightFlowData.SrvFighterID = sceneTeamRole.RoleId;
				this.FightRoleInfoMap[sceneTeamRole.CreatureDataId] = secRoleFightFlowData;
			}
			SrvFighterInfo srvFighterInfo = this.GetSrvFighterInfo(sceneTeamRole);
			this.FightRoleInfoMap[sceneTeamRole.CreatureDataId].FighterInfoMax = srvFighterInfo;
			EntityHandle entity = CreatureModel.Instance.GetEntity(sceneTeamRole.CreatureDataId);
			WorldEntity worldEntity = (entity != null) ? entity.Entity : null;
			if (worldEntity == null)
			{
				Log.Instance.Warn(ELogModule.Net, ELogAuthor.ZFJ, "StartColletRoleFightFlow roleEntity Error", default(ReadOnlySpan<ValueTuple<string, object>>));
			}
			else
			{
				BaseAttributeComponent component = worldEntity.GetComponent<BaseAttributeComponent>();
				if (component != null)
				{
					component.AddGeneralListener(new Action<EAttributeType, float, float>(this.OnAnyCurrentValueChange));
				}
				if (!EventSystem.Instance.HasWithTarget(worldEntity, EEventName.CharDamage, new Action<Entity, Entity, RequirementPayload, DamageResult, FVectorDouble>(this.OnDamage)))
				{
					EventSystem.Instance.AddWithTarget<Entity, Entity, RequirementPayload, DamageResult, FVectorDouble>(worldEntity, EEventName.CharDamage, new Action<Entity, Entity, RequirementPayload, DamageResult, FVectorDouble>(this.OnDamage));
				}
				this.NeedColletPos = true;
				this.AddAceAntiCheatInputLayer(worldEntity.Id);
			}
		}
		this.ChangeRoleTimeStamp = Time.Instance.WorldTime;
		CharacterModel instance = CharacterModel.Instance;
		TsBaseCharacter baseCharacter = Global.BaseCharacter;
		EntityHandle handle = instance.GetHandle((baseCharacter != null) ? baseCharacter.EntityId : 0);
		long? curGlobalRoleCreatureId;
		if (handle == null)
		{
			curGlobalRoleCreatureId = null;
		}
		else
		{
			WorldEntity entity2 = handle.Entity;
			if (entity2 == null)
			{
				curGlobalRoleCreatureId = null;
			}
			else
			{
				CreatureDataComponent component2 = entity2.GetComponent<CreatureDataComponent>();
				curGlobalRoleCreatureId = ((component2 != null) ? new long?(component2.GetCreatureDataId()) : null);
			}
		}
		this.CurGlobalRoleCreatureId = curGlobalRoleCreatureId;
		EventSystem.Instance.Add<EntityHandle, EntityHandle>(EEventName.OnChangeRole, new Action<EntityHandle, EntityHandle>(this.OnChangeRole));
	}

	// Token: 0x0601B595 RID: 112021 RVA: 0x00864378 File Offset: 0x00862578
	private void SendRoleFightFlowRequest(long logId, AceBattleAntiCheatingLogType logType)
	{
		if (this.FightRoleList == null || this.FightRoleInfoMap == null)
		{
			Log.Instance.Error(ELogModule.Net, ELogAuthor.ZFJ, "SendRoleFightFlowRequest List Error", default(ReadOnlySpan<ValueTuple<string, object>>));
			return;
		}
		SecRoleFightFlowRequest secRoleFightFlowRequest = SecRoleFightFlowRequest.Create();
		secRoleFightFlowRequest.LogId = logId;
		secRoleFightFlowRequest.ClientTime = TimeUtil.Instance.DateFormat2(DateTime.Now);
		List<SecRoleFightFlowData> list = new List<SecRoleFightFlowData>();
		CharacterModel instance = CharacterModel.Instance;
		TsBaseCharacter baseCharacter = Global.BaseCharacter;
		EntityHandle handle = instance.GetHandle((baseCharacter != null) ? baseCharacter.EntityId : 0);
		long? num;
		if (handle == null)
		{
			num = null;
		}
		else
		{
			WorldEntity entity = handle.Entity;
			if (entity == null)
			{
				num = null;
			}
			else
			{
				CreatureDataComponent component = entity.GetComponent<CreatureDataComponent>();
				num = ((component != null) ? new long?(component.GetCreatureDataId()) : null);
			}
		}
		long? num2 = num;
		SecRoleFightFlowData secRoleFightFlowData;
		if (num2 != null && this.FightRoleInfoMap.TryGetValue(num2.Value, out secRoleFightFlowData))
		{
			long residentTimeTotal = secRoleFightFlowData.ResidentTimeTotal;
			secRoleFightFlowData.ResidentTimeTotal = (long)(Time.Instance.WorldTime - this.ChangeRoleTimeStamp + (double)residentTimeTotal);
		}
		foreach (SecRoleFightFlowData item in this.FightRoleInfoMap.Values)
		{
			list.Add(item);
		}
		secRoleFightFlowRequest.SecRoleFightFlowDataList.AddRange(list);
		secRoleFightFlowRequest.LogType = logType;
		Net.Instance.Call(ERequestMessageId.SecRoleFightFlowRequest, secRoleFightFlowRequest, null, 0);
		foreach (SceneTeamRole sceneTeamRole in this.FightRoleList)
		{
			EntityHandle entity2 = CreatureModel.Instance.GetEntity(sceneTeamRole.CreatureDataId);
			WorldEntity worldEntity = (entity2 != null) ? entity2.Entity : null;
			if (worldEntity == null)
			{
				Log.Instance.Warn(ELogModule.Net, ELogAuthor.ZFJ, "StartColletRoleFightFlow roleEntity Error", default(ReadOnlySpan<ValueTuple<string, object>>));
			}
			else
			{
				BaseAttributeComponent component2 = worldEntity.GetComponent<BaseAttributeComponent>();
				if (component2 != null)
				{
					component2.RemoveGeneralListener(new Action<EAttributeType, float, float>(this.OnAnyCurrentValueChange));
				}
				EventSystem.Instance.RemoveWithTarget(worldEntity, EEventName.CharDamage, new Action<Entity, Entity, RequirementPayload, DamageResult, FVectorDouble>(this.OnDamage));
				this.NeedColletPos = false;
			}
		}
		EventSystem.Instance.Remove<EntityHandle, EntityHandle>(EEventName.OnChangeRole, new Action<EntityHandle, EntityHandle>(this.OnChangeRole));
		this.RemoveAceAntiCheatInputLayer();
		this.FightRoleInfoMap = null;
		this.FightRoleList = null;
	}

	// Token: 0x0601B596 RID: 112022 RVA: 0x008645E8 File Offset: 0x008627E8
	private void StartSecRoleFightFlowInst(long logId)
	{
		if (this.SecRoleFightFlowInstLogId > 0L)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Net;
			ELogAuthor author = ELogAuthor.ZFJ;
			string message = "StartSecRoleFightFlowInst repeat";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("logId", logId);
			instance.Warn(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return;
		}
		this.StartColletRoleFightFlow();
		this.SecRoleFightFlowInstLogId = logId;
	}

	// Token: 0x0601B597 RID: 112023 RVA: 0x0086463C File Offset: 0x0086283C
	private unsafe void EndSecRoleFightFlowInst(long logId)
	{
		if (this.SecRoleFightFlowInstLogId != logId)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Net;
			ELogAuthor author = ELogAuthor.ZFJ;
			string message = "EndSecRoleFightFlowInst logId Error";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("logId", logId);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("SecRoleFightFlowInstLogId", this.SecRoleFightFlowInstLogId);
			instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
			return;
		}
		this.SendRoleFightFlowRequest(logId, AceBattleAntiCheatingLogType.LogTypeSecRoleFightFlowInstEnd);
		this.SecRoleFightFlowInstLogId = -1L;
	}

	// Token: 0x0601B598 RID: 112024 RVA: 0x008646C8 File Offset: 0x008628C8
	private void StartSecWorldInfoFlow(long logId, int endTime)
	{
		if (this.SecWorldInfoFlowLogId > 0L)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Net;
			ELogAuthor author = ELogAuthor.ZFJ;
			string message = "StartSecFbRound repeat";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("logId", logId);
			instance.Warn(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return;
		}
		this.SecWorldInfoFlowLogId = logId;
		this.SetCollectSpeed(true);
		this.EndSecWorldInfoFlowTimerId = TimerSystem.Instance.Delay(delegate(float _)
		{
			this.EndSecWorldInfoFlowTimerId = null;
			this.EndSecWorldInfoFlow(this.SecWorldInfoFlowLogId);
		}, (float)endTime, null, null, true, 1f);
	}

	// Token: 0x0601B599 RID: 112025 RVA: 0x00864740 File Offset: 0x00862940
	private unsafe void EndSecWorldInfoFlow(long logId)
	{
		if (this.SecWorldInfoFlowLogId != logId)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Net;
			ELogAuthor author = ELogAuthor.ZFJ;
			string message = "EndSecWorldInfoFlow logId Error";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("logId", logId);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("SecWorldInfoFlowLogId", this.SecWorldInfoFlowLogId);
			instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
			return;
		}
		if (this.EndSecWorldInfoFlowTimerId != null)
		{
			TimerSystem.Instance.Remove(this.EndSecWorldInfoFlowTimerId);
			this.EndSecWorldInfoFlowTimerId = null;
		}
		SecWorldInfoFlowRequest secWorldInfoFlowRequest = SecWorldInfoFlowRequest.Create();
		secWorldInfoFlowRequest.LogId = logId;
		secWorldInfoFlowRequest.ClientTime = TimeUtil.Instance.DateFormat2(DateTime.Now);
		secWorldInfoFlowRequest.SpeedMax = this.MaxSpeed;
		secWorldInfoFlowRequest.SpeedMin = ((this.MinSpeed == 999999) ? 0 : this.MinSpeed);
		secWorldInfoFlowRequest.SpeedAvg = this.AvgSpeed;
		this.SetCollectSpeed(false);
		Net.Instance.Call(ERequestMessageId.SecWorldInfoFlowRequest, secWorldInfoFlowRequest, null, 0);
		this.SecWorldInfoFlowLogId = -1L;
	}

	// Token: 0x0601B59A RID: 112026 RVA: 0x00864850 File Offset: 0x00862A50
	private void StartSecWorldFlow(long logId)
	{
		if (this.SecWorldFlowLogId > 0L)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Net;
			ELogAuthor author = ELogAuthor.ZFJ;
			string message = "StartSecFbRound repeat";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("logId", logId);
			instance.Warn(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return;
		}
		this.SecWorldFlowLogId = logId;
		this.SecFbRoundStartTime = Time.Instance.WorldTime;
		SecWorldStartFlowRequest secWorldStartFlowRequest = SecWorldStartFlowRequest.Create();
		secWorldStartFlowRequest.LogId = logId;
		secWorldStartFlowRequest.ClientStartTime = TimeUtil.Instance.DateFormat2(DateTime.Now);
		List<SceneTeamRole> roleList = this.GetRoleList();
		if (roleList == null)
		{
			Log instance2 = Log.Instance;
			ELogModule module2 = ELogModule.Net;
			ELogAuthor author2 = ELogAuthor.ZFJ;
			string message2 = "StartSecWorldFlow roleList Error";
			ValueTuple<string, object> valueTuple2 = new ValueTuple<string, object>("logId", logId);
			instance2.Error(module2, author2, message2, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple2));
			return;
		}
		secWorldStartFlowRequest.SrvFighter1Info = ((roleList.Count > 0) ? this.GetSrvFighterInfo(roleList[0]) : null);
		secWorldStartFlowRequest.SrvFighter2Info = ((roleList.Count > 1) ? this.GetSrvFighterInfo(roleList[1]) : null);
		secWorldStartFlowRequest.SrvFighter3Info = ((roleList.Count > 2) ? this.GetSrvFighterInfo(roleList[2]) : null);
		secWorldStartFlowRequest.SrvFighter4Info = ((roleList.Count > 3) ? this.GetSrvFighterInfo(roleList[3]) : null);
		this.SetCollectSpeed(true);
		Net.Instance.Call(ERequestMessageId.SecWorldStartFlowRequest, secWorldStartFlowRequest, null, 0);
	}

	// Token: 0x0601B59B RID: 112027 RVA: 0x0086499C File Offset: 0x00862B9C
	private unsafe void EndSecWorldFlow(long logId)
	{
		if (this.SecWorldFlowLogId != logId)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Net;
			ELogAuthor author = ELogAuthor.ZFJ;
			string message = "EndSecWorldFlow logId Error";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("logId", logId);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("SecWorldFlowLogId", this.SecWorldFlowLogId);
			instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
			return;
		}
		this.SecWorldFlowLogId = -1L;
		SecWorldSEndFlowRequest secWorldSEndFlowRequest = SecWorldSEndFlowRequest.Create();
		secWorldSEndFlowRequest.LogId = logId;
		secWorldSEndFlowRequest.ClientEndTime = TimeUtil.Instance.DateFormat2(DateTime.Now);
		secWorldSEndFlowRequest.RoundTimeUse = (int)(Time.Instance.WorldTime - this.SecFbRoundStartTime);
		secWorldSEndFlowRequest.SpeedMax = this.MaxSpeed;
		secWorldSEndFlowRequest.SpeedMin = ((this.MinSpeed == 999999) ? 0 : this.MinSpeed);
		secWorldSEndFlowRequest.SpeedAvg = this.AvgSpeed;
		this.SetCollectSpeed(false);
		Net.Instance.Call(ERequestMessageId.SecWorldSEndFlowRequest, secWorldSEndFlowRequest, null, 0);
	}

	// Token: 0x0601B59C RID: 112028 RVA: 0x00864AA4 File Offset: 0x00862CA4
	private void AddAceAntiCheatInputLayer(int entityId)
	{
		AceAntiCheatInputLayer aceAntiCheatInputLayer = InputController.Instance.CreateInputLayer(EInputLayer.AceAntiCheat) as AceAntiCheatInputLayer;
		if (aceAntiCheatInputLayer != null)
		{
			InputController.Instance.AddInputLayer(entityId, aceAntiCheatInputLayer);
			if (this.InputLayers == null)
			{
				this.InputLayers = new List<InputLayer>();
			}
			this.InputLayers.Add(aceAntiCheatInputLayer);
		}
	}

	// Token: 0x0601B59D RID: 112029 RVA: 0x00864AF4 File Offset: 0x00862CF4
	private void RemoveAceAntiCheatInputLayer()
	{
		if (this.InputLayers != null)
		{
			foreach (InputLayer inputLayer in this.InputLayers)
			{
				inputLayer.Clear();
				InputController.Instance.RemoveInputLayer(inputLayer);
			}
			this.InputLayers = null;
		}
	}

	// Token: 0x0601B59E RID: 112030 RVA: 0x00864B60 File Offset: 0x00862D60
	public void HandlePress(EInputAction action, float time)
	{
		this.OnCharInputPress(action, time);
	}

	// Token: 0x17002C72 RID: 11378
	// (get) Token: 0x0601B59F RID: 112031 RVA: 0x00864B6A File Offset: 0x00862D6A
	public static AceAntiCheatController Instance
	{
		get
		{
			return AceAntiCheatController._Instance;
		}
	}

	// Token: 0x0601B5A0 RID: 112032 RVA: 0x00864B71 File Offset: 0x00862D71
	public static AceAntiCheatController GetOrCreateInstance()
	{
		if (AceAntiCheatController._Instance == null)
		{
			AceAntiCheatController.CreateInstance();
		}
		return AceAntiCheatController._Instance;
	}

	// Token: 0x0601B5A1 RID: 112033 RVA: 0x00864B85 File Offset: 0x00862D85
	public static bool CreateInstance()
	{
		if (AceAntiCheatController._Instance != null)
		{
			return true;
		}
		AceAntiCheatController._Instance = new AceAntiCheatController();
		return true;
	}

	// Token: 0x0601B5A2 RID: 112034 RVA: 0x00864B9B File Offset: 0x00862D9B
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x0601B5A3 RID: 112035 RVA: 0x00864B9D File Offset: 0x00862D9D
	public static void ResetStaticDefaultValue()
	{
		AceAntiCheatController._Instance = null;
	}

	// Token: 0x0601B5A4 RID: 112036 RVA: 0x00864BA5 File Offset: 0x00862DA5
	static AceAntiCheatController()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(AceAntiCheatController.CreateStaticDefaultValue), new Action(AceAntiCheatController.ResetStaticDefaultValue));
	}

	// Token: 0x0400ECBA RID: 60602
	private const int POSTICKTIME = 1000;

	// Token: 0x0400ECBB RID: 60603
	private const int POSTICKCOUNT = 120;

	// Token: 0x0400ECBC RID: 60604
	private const int MINSPEEDINIT = 999999;

	// Token: 0x0400ECBD RID: 60605
	private long SecFbRoundLogId = -1L;

	// Token: 0x0400ECBE RID: 60606
	private long SecRoleFightFlowBigWorldLogId = -1L;

	// Token: 0x0400ECBF RID: 60607
	private long SecRoleFightFlowInstLogId = -1L;

	// Token: 0x0400ECC0 RID: 60608
	private long SecWorldInfoFlowLogId = -1L;

	// Token: 0x0400ECC1 RID: 60609
	private long SecWorldFlowLogId = -1L;

	// Token: 0x0400ECC2 RID: 60610
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private List<InputLayer> InputLayers;

	// Token: 0x0400ECC3 RID: 60611
	private double SecFbRoundStartTime;

	// Token: 0x0400ECC4 RID: 60612
	private int AvgSpeed;

	// Token: 0x0400ECC5 RID: 60613
	private int MinSpeed;

	// Token: 0x0400ECC6 RID: 60614
	private int MaxSpeed;

	// Token: 0x0400ECC7 RID: 60615
	private int CurSpeedCount;

	// Token: 0x0400ECC8 RID: 60616
	private bool NeedColletSpeed;

	// Token: 0x0400ECC9 RID: 60617
	private bool NeedColletPos;

	// Token: 0x0400ECCA RID: 60618
	private float PosTickTime;

	// Token: 0x0400ECCB RID: 60619
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private List<SceneTeamRole> FightRoleList;

	// Token: 0x0400ECCC RID: 60620
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private Dictionary<long, SecRoleFightFlowData> FightRoleInfoMap;

	// Token: 0x0400ECCD RID: 60621
	private double ChangeRoleTimeStamp;

	// Token: 0x0400ECCE RID: 60622
	private long? CurGlobalRoleCreatureId;

	// Token: 0x0400ECCF RID: 60623
	[Nullable(2)]
	private TimerHandle EndSecWorldInfoFlowTimerId;

	// Token: 0x0400ECD0 RID: 60624
	[Nullable(2)]
	private static AceAntiCheatController _Instance;
}
