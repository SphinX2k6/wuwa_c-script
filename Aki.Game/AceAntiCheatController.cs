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

// Token: 0x020034D2 RID: 13522
[NullableContext(1)]
[Nullable(0)]
[TickController(0)]
public class AceAntiCheatController : ControllerBase
{
	// Token: 0x0601D886 RID: 120966 RVA: 0x0083C03C File Offset: 0x0083A23C
	protected override bool OnInit()
	{
		Net.Instance.Register(ENotifyMessageId.BattleAntiCheatingLogNotify, new Action<IMessage, Net.CallbackStatus>(this.BattleAntiCheatingLogNotify));
		return true;
	}

	// Token: 0x0601D887 RID: 120967 RVA: 0x0083C05B File Offset: 0x0083A25B
	protected override bool OnClear()
	{
		Net.Instance.UnRegister(ENotifyMessageId.BattleAntiCheatingLogNotify);
		return true;
	}

	// Token: 0x0601D888 RID: 120968 RVA: 0x0083C070 File Offset: 0x0083A270
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

	// Token: 0x0601D889 RID: 120969 RVA: 0x0083C208 File Offset: 0x0083A408
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

	// Token: 0x0601D88A RID: 120970 RVA: 0x0083C2E8 File Offset: 0x0083A4E8
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

	// Token: 0x0601D88B RID: 120971 RVA: 0x0083C364 File Offset: 0x0083A564
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

	// Token: 0x0601D88C RID: 120972 RVA: 0x0083C4B0 File Offset: 0x0083A6B0
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

	// Token: 0x0601D88D RID: 120973 RVA: 0x0083C636 File Offset: 0x0083A836
	private void SetCollectSpeed(bool isStart)
	{
		this.NeedColletSpeed = isStart;
		this.CurSpeedCount = 0;
		this.AvgSpeed = 0;
		this.MaxSpeed = 0;
		this.MinSpeed = 999999;
	}

	// Token: 0x0601D88E RID: 120974 RVA: 0x0083C660 File Offset: 0x0083A860
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

	// Token: 0x0601D88F RID: 120975 RVA: 0x0083C768 File Offset: 0x0083A968
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

	// Token: 0x0601D890 RID: 120976 RVA: 0x0083C7BC File Offset: 0x0083A9BC
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

	// Token: 0x0601D891 RID: 120977 RVA: 0x0083C848 File Offset: 0x0083AA48
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

	// Token: 0x0601D892 RID: 120978 RVA: 0x0083C940 File Offset: 0x0083AB40
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

	// Token: 0x0601D893 RID: 120979 RVA: 0x0083CAD0 File Offset: 0x0083ACD0
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

	// Token: 0x0601D894 RID: 120980 RVA: 0x0083CB9C File Offset: 0x0083AD9C
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

	// Token: 0x0601D895 RID: 120981 RVA: 0x0083CC74 File Offset: 0x0083AE74
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

	// Token: 0x0601D896 RID: 120982 RVA: 0x0083CEAC File Offset: 0x0083B0AC
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

	// Token: 0x0601D897 RID: 120983 RVA: 0x0083D11C File Offset: 0x0083B31C
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

	// Token: 0x0601D898 RID: 120984 RVA: 0x0083D170 File Offset: 0x0083B370
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

	// Token: 0x0601D899 RID: 120985 RVA: 0x0083D1FC File Offset: 0x0083B3FC
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

	// Token: 0x0601D89A RID: 120986 RVA: 0x0083D274 File Offset: 0x0083B474
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

	// Token: 0x0601D89B RID: 120987 RVA: 0x0083D384 File Offset: 0x0083B584
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

	// Token: 0x0601D89C RID: 120988 RVA: 0x0083D4D0 File Offset: 0x0083B6D0
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

	// Token: 0x0601D89D RID: 120989 RVA: 0x0083D5D8 File Offset: 0x0083B7D8
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

	// Token: 0x0601D89E RID: 120990 RVA: 0x0083D628 File Offset: 0x0083B828
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

	// Token: 0x0601D89F RID: 120991 RVA: 0x0083D694 File Offset: 0x0083B894
	public void HandlePress(EInputAction action, float time)
	{
		this.OnCharInputPress(action, time);
	}

	// Token: 0x170028DA RID: 10458
	// (get) Token: 0x0601D8A0 RID: 120992 RVA: 0x0083D69E File Offset: 0x0083B89E
	public static AceAntiCheatController Instance
	{
		get
		{
			return AceAntiCheatController._Instance;
		}
	}

	// Token: 0x0601D8A1 RID: 120993 RVA: 0x0083D6A5 File Offset: 0x0083B8A5
	public static AceAntiCheatController GetOrCreateInstance()
	{
		if (AceAntiCheatController._Instance == null)
		{
			AceAntiCheatController.CreateInstance();
		}
		return AceAntiCheatController._Instance;
	}

	// Token: 0x0601D8A2 RID: 120994 RVA: 0x0083D6B9 File Offset: 0x0083B8B9
	public static bool CreateInstance()
	{
		if (AceAntiCheatController._Instance != null)
		{
			return true;
		}
		AceAntiCheatController._Instance = new AceAntiCheatController();
		return true;
	}

	// Token: 0x0601D8A3 RID: 120995 RVA: 0x0083D6CF File Offset: 0x0083B8CF
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x0601D8A4 RID: 120996 RVA: 0x0083D6D1 File Offset: 0x0083B8D1
	public static void ResetStaticDefaultValue()
	{
		AceAntiCheatController._Instance = null;
	}

	// Token: 0x0601D8A5 RID: 120997 RVA: 0x0083D6D9 File Offset: 0x0083B8D9
	static AceAntiCheatController()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(AceAntiCheatController.CreateStaticDefaultValue), new Action(AceAntiCheatController.ResetStaticDefaultValue));
	}

	// Token: 0x0400E806 RID: 59398
	private const int POSTICKTIME = 1000;

	// Token: 0x0400E807 RID: 59399
	private const int POSTICKCOUNT = 120;

	// Token: 0x0400E808 RID: 59400
	private const int MINSPEEDINIT = 999999;

	// Token: 0x0400E809 RID: 59401
	private long SecFbRoundLogId = -1L;

	// Token: 0x0400E80A RID: 59402
	private long SecRoleFightFlowBigWorldLogId = -1L;

	// Token: 0x0400E80B RID: 59403
	private long SecRoleFightFlowInstLogId = -1L;

	// Token: 0x0400E80C RID: 59404
	private long SecWorldInfoFlowLogId = -1L;

	// Token: 0x0400E80D RID: 59405
	private long SecWorldFlowLogId = -1L;

	// Token: 0x0400E80E RID: 59406
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private List<InputLayer> InputLayers;

	// Token: 0x0400E80F RID: 59407
	private double SecFbRoundStartTime;

	// Token: 0x0400E810 RID: 59408
	private int AvgSpeed;

	// Token: 0x0400E811 RID: 59409
	private int MinSpeed;

	// Token: 0x0400E812 RID: 59410
	private int MaxSpeed;

	// Token: 0x0400E813 RID: 59411
	private int CurSpeedCount;

	// Token: 0x0400E814 RID: 59412
	private bool NeedColletSpeed;

	// Token: 0x0400E815 RID: 59413
	private bool NeedColletPos;

	// Token: 0x0400E816 RID: 59414
	private float PosTickTime;

	// Token: 0x0400E817 RID: 59415
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private List<SceneTeamRole> FightRoleList;

	// Token: 0x0400E818 RID: 59416
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private Dictionary<long, SecRoleFightFlowData> FightRoleInfoMap;

	// Token: 0x0400E819 RID: 59417
	private double ChangeRoleTimeStamp;

	// Token: 0x0400E81A RID: 59418
	private long? CurGlobalRoleCreatureId;

	// Token: 0x0400E81B RID: 59419
	[Nullable(2)]
	private TimerHandle EndSecWorldInfoFlowTimerId;

	// Token: 0x0400E81C RID: 59420
	[Nullable(2)]
	private static AceAntiCheatController _Instance;
}
