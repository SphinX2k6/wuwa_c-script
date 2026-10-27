using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text.Json;
using Aki.Config;
using Aki.Protocol;
using Aki.Protocol.Debug;
using CSharpScript.Core.Common;
using CSharpScript.Game;
using CSharpScript.Game.Module.Area;
using CSharpScript.Game.Module.CombatMessage;
using CSharpScript.Game.Module.SkillButtonUi;
using CSharpScript.Launcher.NetworkDetection;
using Google.Protobuf;
using UnrealEngine;

// Token: 0x020034E2 RID: 13538
[NullableContext(1)]
[Nullable(0)]
[Controller(0)]
public class LogController : ControllerBase
{
	// Token: 0x0601DA58 RID: 121432 RVA: 0x0084C06E File Offset: 0x0084A26E
	protected override bool OnInit()
	{
		Net.Instance.Register(ENotifyMessageId.OutputDebugInfoNotify, new Action<IMessage, Net.CallbackStatus>(this.OutputDebugInfoNotify));
		return true;
	}

	// Token: 0x0601DA59 RID: 121433 RVA: 0x0084C08D File Offset: 0x0084A28D
	protected override bool OnClear()
	{
		Net.Instance.UnRegister(ENotifyMessageId.OutputDebugInfoNotify);
		return true;
	}

	// Token: 0x0601DA5A RID: 121434 RVA: 0x0084C0A0 File Offset: 0x0084A2A0
	private void LogReportFramingHandle(float _)
	{
		int framingLogNum = this.FramingLogNum;
		int num = 0;
		CommonLogData commonLogData = null;
		if (this.LogReportFramingQueue.Count > 0)
		{
			commonLogData = this.LogReportFramingQueue[0];
			this.LogReportFramingQueue.RemoveAt(0);
		}
		while (num < framingLogNum && commonLogData != null)
		{
			LogReportController.Instance.LogReport(commonLogData);
			num++;
			if (this.LogReportFramingQueue.Count > 0)
			{
				commonLogData = this.LogReportFramingQueue[0];
				this.LogReportFramingQueue.RemoveAt(0);
			}
			else
			{
				commonLogData = null;
			}
		}
		if (this.LogReportFramingQueue.Count == 0)
		{
			TickSystem.Instance.Remove(this.LogReportFramingTimer);
			this.LogReportFramingTimer = -1;
		}
	}

	// Token: 0x0601DA5B RID: 121435 RVA: 0x0084C148 File Offset: 0x0084A348
	private void PushLogDataInFramingQueue(CommonLogData logData)
	{
		if (this.LogReportFramingTimer == -1)
		{
			Ticker ticker = TickSystem.Instance.Add(new Action<float>(this.LogReportFramingHandle), "LogReportFraming", ETickingGroup.TG_DuringPhysics, false, 0, false);
			if (ticker != null)
			{
				this.LogReportFramingTimer = ticker.Id;
			}
		}
		this.LogReportFramingQueue.Add(logData);
	}

	// Token: 0x0601DA5C RID: 121436 RVA: 0x0084C199 File Offset: 0x0084A399
	public void LogBattleStartPush(BattleStartLogData logData, bool isFraming = false)
	{
		if (isFraming)
		{
			this.PushLogDataInFramingQueue(logData);
			return;
		}
		LogReportController.Instance.LogReport(logData);
	}

	// Token: 0x0601DA5D RID: 121437 RVA: 0x0084C1B1 File Offset: 0x0084A3B1
	public void LogBattleEndPush(BattleEndLogData logData, bool isFraming = false)
	{
		if (isFraming)
		{
			this.PushLogDataInFramingQueue(logData);
			return;
		}
		LogReportController.Instance.LogReport(logData);
	}

	// Token: 0x0601DA5E RID: 121438 RVA: 0x0084C1C9 File Offset: 0x0084A3C9
	public void LogSingleCharacterStatusPush(RoleStateRecord logData, bool isFraming = false)
	{
		if (isFraming)
		{
			this.PushLogDataInFramingQueue(logData);
			return;
		}
		LogReportController.Instance.LogReport(logData);
	}

	// Token: 0x0601DA5F RID: 121439 RVA: 0x0084C1E1 File Offset: 0x0084A3E1
	public void LogSingleMonsterStatusPush(MonsterStateRecord logData, bool isFraming = false)
	{
		if (isFraming)
		{
			this.PushLogDataInFramingQueue(logData);
			return;
		}
		LogReportController.Instance.LogReport(logData);
	}

	// Token: 0x0601DA60 RID: 121440 RVA: 0x0084C1FC File Offset: 0x0084A3FC
	public void LogCharacterDeathPush(int roleId, int result, bool isFraming = false)
	{
		DeathRecord deathRecord = new DeathRecord();
		deathRecord.i_area_id = AreaModel.Instance.AreaInfo.Value.AreaId;
		deathRecord.i_area_level = AreaModel.Instance.AreaInfo.Value.Level;
		if (Global.BaseCharacter == null)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Battle;
			ELogAuthor author = ELogAuthor.YZ;
			string message = "日志上报-单机大世界死亡，当前不存在Global.BaseCharacter";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("roleId", roleId);
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return;
		}
		FVectorDouble fvectorDouble = Global.BaseCharacter.D_K2_GetActorLocation();
		deathRecord.f_x = (float)fvectorDouble.X;
		deathRecord.f_y = (float)fvectorDouble.Y;
		deathRecord.f_z = (float)fvectorDouble.Z;
		deathRecord.i_death_reason = result;
		deathRecord.i_death_role_id = roleId;
		if (isFraming)
		{
			this.PushLogDataInFramingQueue(deathRecord);
			return;
		}
		LogReportController.Instance.LogReport(deathRecord);
	}

	// Token: 0x0601DA61 RID: 121441 RVA: 0x0084C2DA File Offset: 0x0084A4DA
	public void LogRoleSkillReportPush(RoleSkillReportLog reportData, List<RoleSkillRecord> data, bool isFraming = false)
	{
		reportData.s_reports = JsonSerializer.Serialize<List<RoleSkillRecord>>(data, null);
		if (isFraming)
		{
			this.PushLogDataInFramingQueue(reportData);
			return;
		}
		LogReportController.Instance.LogReport(reportData);
	}

	// Token: 0x0601DA62 RID: 121442 RVA: 0x0084C2FF File Offset: 0x0084A4FF
	public void LogMonsterSkillReportPush(MonsterSkillReportLog reportData, List<MonsterSkillRecord> data, bool isFraming = false)
	{
		reportData.s_reports = JsonSerializer.Serialize<List<MonsterSkillRecord>>(data, null);
		if (isFraming)
		{
			this.PushLogDataInFramingQueue(reportData);
			return;
		}
		LogReportController.Instance.LogReport(reportData);
	}

	// Token: 0x0601DA63 RID: 121443 RVA: 0x0084C324 File Offset: 0x0084A524
	public void LogDoubleBallReport(ReactionLogRecord reportData, Dictionary<string, ReactionRecord> data, bool isFraming = false)
	{
		reportData.s_reports = JsonSerializer.Serialize<List<ReactionRecord>>(data.Values.ToList<ReactionRecord>(), null);
		if (isFraming)
		{
			this.PushLogDataInFramingQueue(reportData);
			return;
		}
		LogReportController.Instance.LogReport(reportData);
	}

	// Token: 0x0601DA64 RID: 121444 RVA: 0x0084C354 File Offset: 0x0084A554
	public void LogTriggerBuffDamagePush(IBuffRecord buffRecord)
	{
		TriggerBuffDamageRecord triggerBuffDamageRecord = new TriggerBuffDamageRecord();
		triggerBuffDamageRecord.i_area_id = buffRecord.AreaId.ToString();
		triggerBuffDamageRecord.s_buff_id = buffRecord.BuffId.ToString();
		triggerBuffDamageRecord.f_time = buffRecord.TimeStamp.ToString("F2");
		triggerBuffDamageRecord.f_player_pos_x = buffRecord.Location.X.ToString("F2");
		triggerBuffDamageRecord.f_player_pos_y = buffRecord.Location.Y.ToString("F2");
		triggerBuffDamageRecord.f_player_pos_z = buffRecord.Location.Z.ToString("F2");
		triggerBuffDamageRecord.i_damage = buffRecord.Damage.ToString();
		LogReportController.Instance.LogReport(triggerBuffDamageRecord);
	}

	// Token: 0x0601DA65 RID: 121445 RVA: 0x0084C418 File Offset: 0x0084A618
	public void LogElevatorUsedPush(ElevatorUsedRecord logData)
	{
		LogReportController.Instance.LogReport(logData);
	}

	// Token: 0x0601DA66 RID: 121446 RVA: 0x0084C425 File Offset: 0x0084A625
	public void LogInstFightStartPush(InstFightStartRecord logData)
	{
		LogReportController.Instance.LogReport(logData);
	}

	// Token: 0x0601DA67 RID: 121447 RVA: 0x0084C432 File Offset: 0x0084A632
	public void LogInstFightEndPush(InstFightEndRecord logData)
	{
		LogReportController.Instance.LogReport(logData);
	}

	// Token: 0x0601DA68 RID: 121448 RVA: 0x0084C43F File Offset: 0x0084A63F
	public void LogRoleDevPush(RoleDevLogEvent logData)
	{
		LogReportController.Instance.LogReport(logData);
	}

	// Token: 0x0601DA69 RID: 121449 RVA: 0x0084C44C File Offset: 0x0084A64C
	public void SetCurrentUploadLogId(string logId)
	{
		this.CustomServiceLogId = logId;
	}

	// Token: 0x0601DA6A RID: 121450 RVA: 0x0084C458 File Offset: 0x0084A658
	public void LogCustomServiceReport(ESendState result)
	{
		CustomServiceLogEvent customServiceLogEvent = new CustomServiceLogEvent();
		customServiceLogEvent.s_trace_id = this.CustomServiceLogId;
		customServiceLogEvent.log_status = LauncherNetworkDetectionDefine.SendStateToCustomServiceLogMap.GetValueOrDefault(result, 0);
		LogReportController.Instance.LogReport(customServiceLogEvent);
	}

	// Token: 0x0601DA6B RID: 121451 RVA: 0x0084C494 File Offset: 0x0084A694
	public List<SkillButtonDebugInfo> GetSkillButtonDebugInfo()
	{
		List<SkillButtonDebugInfo> list = new List<SkillButtonDebugInfo>();
		foreach (SkillButtonEntityData skillButtonEntityData in SkillButtonUiModel.Instance.GetAllSkillButtonEntityData())
		{
			EntityHandle entityHandle = skillButtonEntityData.EntityHandle;
			SkillButtonDebugInfo skillButtonDebugInfo = new SkillButtonDebugInfo((entityHandle != null) ? entityHandle.Id : 0, new List<string>());
			if (skillButtonEntityData.SkillButtonDataMap != null)
			{
				foreach (SkillButtonData skillButtonData in skillButtonEntityData.SkillButtonDataMap.Values)
				{
					skillButtonDebugInfo.Button.Add(skillButtonData.GetDebugInfo());
				}
			}
			list.Add(skillButtonDebugInfo);
		}
		SkillButtonFollowerEntityData curSkillButtonFollowerEntityData = SkillButtonUiModel.Instance.GetCurSkillButtonFollowerEntityData();
		if (curSkillButtonFollowerEntityData != null && curSkillButtonFollowerEntityData.IsEnable && curSkillButtonFollowerEntityData.SkillButtonDataMap != null)
		{
			EntityHandle entityHandle2 = curSkillButtonFollowerEntityData.EntityHandle;
			SkillButtonDebugInfo skillButtonDebugInfo2 = new SkillButtonDebugInfo((entityHandle2 != null) ? entityHandle2.Id : 0, new List<string>());
			foreach (SkillButtonData skillButtonData2 in curSkillButtonFollowerEntityData.SkillButtonDataMap.Values)
			{
				skillButtonDebugInfo2.Button.Add(skillButtonData2.GetDebugInfo());
			}
			list.Add(skillButtonDebugInfo2);
		}
		return list;
	}

	// Token: 0x0601DA6C RID: 121452 RVA: 0x0084C60C File Offset: 0x0084A80C
	public string OutputDebugInfo(bool log = true)
	{
		InstanceDungeon? instanceDungeon;
		string text = Json.Encode(new DebugInfo(GameModeModel.Instance.InstanceType.ToString(), OnlineModel.Instance.GetIsMyTeam(), (GameModeModel.Instance.InstanceDungeon != null) ? instanceDungeon.GetValueOrDefault().MapConfigId : 0, Time.Instance.TimeDilation, CreatureModel.Instance.GetPlayerId(), new <>z__ReadOnlyArray<string>(new string[]
		{
			Global.BaseCharacter.CharacterActorComponent.ActorLocationProxy.X.ToString("F2"),
			Global.BaseCharacter.CharacterActorComponent.ActorLocationProxy.Y.ToString("F2"),
			Global.BaseCharacter.CharacterActorComponent.ActorLocationProxy.Z.ToString("F2")
		}), GameModeModel.Instance.IsMulti, OnlineModel.Instance.GetAllWorldTeamPlayer(), (from buff in FormationDataController.Instance.GetPlayerEntity(CreatureModel.Instance.GetPlayerId()).GetComponent<PlayerBuffComponent>().GetAllBuffs()
		select buff.Id.ToString()).ToArray<string>(), CharacterGasDebugComponent.GetFormationAttributeDebugStrings().Replace("\n", ",").Replace(" ", ""), SceneTeamModel.Instance.GetTeamItems(false).Select(delegate(SceneTeamItem formationIn)
		{
			global::FormationRoleInfo formationRoleInfo = new global::FormationRoleInfo();
			EntityHandle entityHandle2 = formationIn.EntityHandle;
			formationRoleInfo.EntityHandleId = ((entityHandle2 != null) ? new int?(entityHandle2.Id) : null);
			formationRoleInfo.ConfigId = formationIn.GetConfigId;
			formationRoleInfo.IsMyRole = formationIn.IsMyRole();
			formationRoleInfo.IsControl = formationIn.IsControl();
			formationRoleInfo.IsDead = formationIn.IsDead();
			return formationRoleInfo;
		}).ToArray<global::FormationRoleInfo>(), this.GetSkillButtonDebugInfo()), null);
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler;
		foreach (EntityHandle entityHandle in CreatureModel.Instance.GetAllEntities())
		{
			WorldEntity entity = entityHandle.Entity;
			CharacterActorComponent characterActorComponent = (entity != null) ? entity.GetComponent<CharacterActorComponent>() : null;
			BaseBuffComponent baseBuffComponent = (entity != null) ? entity.GetComponent<BaseBuffComponent>() : null;
			if (entity != null && characterActorComponent != null && baseBuffComponent != null)
			{
				CreatureDataComponent component = entity.GetComponent<CreatureDataComponent>();
				BaseTagComponent component2 = entity.GetComponent<BaseTagComponent>();
				BaseAttributeComponent component3 = entity.GetComponent<BaseAttributeComponent>();
				BaseUnifiedStateComponent component4 = entity.GetComponent<BaseUnifiedStateComponent>();
				string str = text;
				defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(125, 11);
				defaultInterpolatedStringHandler.AppendLiteral("\n***********\n实体信息: EntityHandleId: ");
				defaultInterpolatedStringHandler.AppendFormatted<int>(entityHandle.Id);
				defaultInterpolatedStringHandler.AppendLiteral(", CreatureDataId: ");
				defaultInterpolatedStringHandler.AppendFormatted<long?>((component != null) ? new long?(component.GetCreatureDataId()) : null);
				defaultInterpolatedStringHandler.AppendLiteral(", PbDataId: ");
				defaultInterpolatedStringHandler.AppendFormatted<int?>((component != null) ? new int?(component.GetPbDataId()) : null);
				defaultInterpolatedStringHandler.AppendLiteral(", Type: ");
				defaultInterpolatedStringHandler.AppendFormatted<EEntityType?>((component != null) ? new EEntityType?(component.GetEntityType()) : null);
				defaultInterpolatedStringHandler.AppendLiteral(", 位置: [");
				defaultInterpolatedStringHandler.AppendFormatted((characterActorComponent != null) ? characterActorComponent.ActorLocationProxy.X.ToString("F2") : null);
				defaultInterpolatedStringHandler.AppendLiteral(", ");
				defaultInterpolatedStringHandler.AppendFormatted((characterActorComponent != null) ? characterActorComponent.ActorLocationProxy.Y.ToString("F2") : null);
				defaultInterpolatedStringHandler.AppendLiteral(", ");
				defaultInterpolatedStringHandler.AppendFormatted((characterActorComponent != null) ? characterActorComponent.ActorLocationProxy.Z.ToString("F2") : null);
				defaultInterpolatedStringHandler.AppendLiteral("], IsInFighting: ");
				defaultInterpolatedStringHandler.AppendFormatted<bool?>((component4 != null) ? new bool?(component4.IsInFighting) : null);
				defaultInterpolatedStringHandler.AppendLiteral("\nBuff信息: ");
				string separator = "|";
				IEnumerable<string> enumerable;
				if (baseBuffComponent == null)
				{
					enumerable = null;
				}
				else
				{
					enumerable = baseBuffComponent.GetAllBuffs().Select(delegate(IActiveBuff buff)
					{
						DefaultInterpolatedStringHandler defaultInterpolatedStringHandler2 = new DefaultInterpolatedStringHandler(2, 3);
						defaultInterpolatedStringHandler2.AppendFormatted<long>(buff.Id);
						defaultInterpolatedStringHandler2.AppendLiteral(" ");
						defaultInterpolatedStringHandler2.AppendFormatted<int>(buff.Handle);
						defaultInterpolatedStringHandler2.AppendLiteral(" ");
						defaultInterpolatedStringHandler2.AppendFormatted<int>(buff.StackCount);
						return defaultInterpolatedStringHandler2.ToStringAndClear() + (buff.IsActive() ? "" : "(非激活)");
					}).ToList<string>();
				}
				defaultInterpolatedStringHandler.AppendFormatted(string.Join(separator, enumerable ?? new List<string>()));
				defaultInterpolatedStringHandler.AppendLiteral("\n属性信息: ");
				defaultInterpolatedStringHandler.AppendFormatted((component3 != null) ? component3.GetDebugString() : null);
				defaultInterpolatedStringHandler.AppendLiteral("\nTag信息: ");
				defaultInterpolatedStringHandler.AppendFormatted((component2 != null) ? component2.TagContainer.GetExactTagsDebugString().Replace("\n", ",").Replace(" ", "") : null);
				text = str + defaultInterpolatedStringHandler.ToStringAndClear();
			}
		}
		string str2 = text;
		defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(93, 3);
		defaultInterpolatedStringHandler.AppendLiteral("\n***********\n战斗协议信息: MessagePackDataLength: ");
		defaultInterpolatedStringHandler.AppendFormatted<int>(CombatMessageModel.Instance.MessagePack.Data.Count);
		defaultInterpolatedStringHandler.AppendLiteral(", SystemNowSeconds: ");
		defaultInterpolatedStringHandler.AppendFormatted<double>(Time.Instance.SystemNowSeconds);
		defaultInterpolatedStringHandler.AppendLiteral(", CombatMessageSendLastTime: ");
		defaultInterpolatedStringHandler.AppendFormatted<double>(CombatMessageModel.Instance.CombatMessageSendLastTime);
		text = str2 + defaultInterpolatedStringHandler.ToStringAndClear();
		return text;
	}

	// Token: 0x0601DA6D RID: 121453 RVA: 0x0084CB1C File Offset: 0x0084AD1C
	[NullableContext(2)]
	private void OutputDebugInfoNotify(IMessage msg, Net.CallbackStatus status)
	{
		this.RequestOutputDebugInfo();
	}

	// Token: 0x0601DA6E RID: 121454 RVA: 0x0084CB24 File Offset: 0x0084AD24
	public void RequestOutputDebugInfo()
	{
		if (!LoginModel.Instance.IsLoginStatus(LoginDefine.ELoginStatus.EnterGameRet))
		{
			return;
		}
		OutputDebugInfoRequest outputDebugInfoRequest = new OutputDebugInfoRequest();
		outputDebugInfoRequest.ClientInfo = this.OutputDebugInfo(true);
		Net.Instance.Call(ERequestMessageId.OutputDebugInfoRequest, outputDebugInfoRequest, delegate(IMessage msg, Net.CallbackStatus _)
		{
			if ((OutputDebugInfoResponse)msg == null)
			{
				return;
			}
			Log.Instance.Info(ELogModule.Log, ELogAuthor.YYZ, "[Debug]服务器端战斗状态信息打印", default(ReadOnlySpan<ValueTuple<string, object>>));
		}, 0);
	}

	// Token: 0x170028E7 RID: 10471
	// (get) Token: 0x0601DA6F RID: 121455 RVA: 0x0084CB83 File Offset: 0x0084AD83
	public static LogController Instance
	{
		get
		{
			return LogController._Instance;
		}
	}

	// Token: 0x0601DA70 RID: 121456 RVA: 0x0084CB8A File Offset: 0x0084AD8A
	public static LogController GetOrCreateInstance()
	{
		if (LogController._Instance == null)
		{
			LogController.CreateInstance();
		}
		return LogController._Instance;
	}

	// Token: 0x0601DA71 RID: 121457 RVA: 0x0084CB9E File Offset: 0x0084AD9E
	public static bool CreateInstance()
	{
		if (LogController._Instance != null)
		{
			return true;
		}
		LogController._Instance = new LogController();
		return true;
	}

	// Token: 0x0601DA72 RID: 121458 RVA: 0x0084CBB4 File Offset: 0x0084ADB4
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x0601DA73 RID: 121459 RVA: 0x0084CBB6 File Offset: 0x0084ADB6
	public static void ResetStaticDefaultValue()
	{
		LogController._Instance = null;
	}

	// Token: 0x0601DA74 RID: 121460 RVA: 0x0084CBBE File Offset: 0x0084ADBE
	static LogController()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(LogController.CreateStaticDefaultValue), new Action(LogController.ResetStaticDefaultValue));
	}

	// Token: 0x0400E8A8 RID: 59560
	private const bool LOG_SWITCH = false;

	// Token: 0x0400E8A9 RID: 59561
	private const int FRAMING_LOG_NUM = 20;

	// Token: 0x0400E8AA RID: 59562
	private int LogReportFramingTimer = -1;

	// Token: 0x0400E8AB RID: 59563
	private readonly List<CommonLogData> LogReportFramingQueue = new List<CommonLogData>();

	// Token: 0x0400E8AC RID: 59564
	private readonly int FramingLogNum = 20;

	// Token: 0x0400E8AD RID: 59565
	private readonly Stat LogOnBattleEndFramingReport = Stat.Create("LogOnBattleEnd_Framing", "", "");

	// Token: 0x0400E8AE RID: 59566
	private string CustomServiceLogId = "";

	// Token: 0x0400E8AF RID: 59567
	[Nullable(2)]
	private static LogController _Instance;
}
