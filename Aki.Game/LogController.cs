using System;
using System.Collections.Generic;
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

// Token: 0x02002A56 RID: 10838
[NullableContext(1)]
[Nullable(0)]
[Controller(0)]
public class LogController : ControllerBase
{
	// Token: 0x0601B762 RID: 112482 RVA: 0x0087427A File Offset: 0x0087247A
	protected override bool OnInit()
	{
		Net.Instance.Register(ENotifyMessageId.OutputDebugInfoNotify, new Action<IMessage, Net.CallbackStatus>(this.OutputDebugInfoNotify));
		return true;
	}

	// Token: 0x0601B763 RID: 112483 RVA: 0x00874299 File Offset: 0x00872499
	protected override bool OnClear()
	{
		Net.Instance.UnRegister(ENotifyMessageId.OutputDebugInfoNotify);
		return true;
	}

	// Token: 0x0601B764 RID: 112484 RVA: 0x008742AC File Offset: 0x008724AC
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

	// Token: 0x0601B765 RID: 112485 RVA: 0x00874354 File Offset: 0x00872554
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

	// Token: 0x0601B766 RID: 112486 RVA: 0x008743A5 File Offset: 0x008725A5
	public void LogBattleStartPush(BattleStartLogData logData, bool isFraming = false)
	{
		if (isFraming)
		{
			this.PushLogDataInFramingQueue(logData);
			return;
		}
		LogReportController.Instance.LogReport(logData);
	}

	// Token: 0x0601B767 RID: 112487 RVA: 0x008743BD File Offset: 0x008725BD
	public void LogBattleEndPush(BattleEndLogData logData, bool isFraming = false)
	{
		if (isFraming)
		{
			this.PushLogDataInFramingQueue(logData);
			return;
		}
		LogReportController.Instance.LogReport(logData);
	}

	// Token: 0x0601B768 RID: 112488 RVA: 0x008743D5 File Offset: 0x008725D5
	public void LogSingleCharacterStatusPush(RoleStateRecord logData, bool isFraming = false)
	{
		if (isFraming)
		{
			this.PushLogDataInFramingQueue(logData);
			return;
		}
		LogReportController.Instance.LogReport(logData);
	}

	// Token: 0x0601B769 RID: 112489 RVA: 0x008743ED File Offset: 0x008725ED
	public void LogSingleMonsterStatusPush(MonsterStateRecord logData, bool isFraming = false)
	{
		if (isFraming)
		{
			this.PushLogDataInFramingQueue(logData);
			return;
		}
		LogReportController.Instance.LogReport(logData);
	}

	// Token: 0x0601B76A RID: 112490 RVA: 0x00874408 File Offset: 0x00872608
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

	// Token: 0x0601B76B RID: 112491 RVA: 0x008744E6 File Offset: 0x008726E6
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

	// Token: 0x0601B76C RID: 112492 RVA: 0x0087450B File Offset: 0x0087270B
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

	// Token: 0x0601B76D RID: 112493 RVA: 0x00874530 File Offset: 0x00872730
	public void LogDoubleBallReport(ReactionLogRecord reportData, Dictionary<string, ReactionRecord> data, bool isFraming = false)
	{
		reportData.s_reports = JsonSerializer.Serialize<List<ReactionRecord>>(new List<ReactionRecord>(data.Values), null);
		if (isFraming)
		{
			this.PushLogDataInFramingQueue(reportData);
			return;
		}
		LogReportController.Instance.LogReport(reportData);
	}

	// Token: 0x0601B76E RID: 112494 RVA: 0x00874560 File Offset: 0x00872760
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

	// Token: 0x0601B76F RID: 112495 RVA: 0x00874624 File Offset: 0x00872824
	public void LogElevatorUsedPush(ElevatorUsedRecord logData)
	{
		LogReportController.Instance.LogReport(logData);
	}

	// Token: 0x0601B770 RID: 112496 RVA: 0x00874631 File Offset: 0x00872831
	public void LogInstFightStartPush(InstFightStartRecord logData)
	{
		LogReportController.Instance.LogReport(logData);
	}

	// Token: 0x0601B771 RID: 112497 RVA: 0x0087463E File Offset: 0x0087283E
	public void LogInstFightEndPush(InstFightEndRecord logData)
	{
		LogReportController.Instance.LogReport(logData);
	}

	// Token: 0x0601B772 RID: 112498 RVA: 0x0087464B File Offset: 0x0087284B
	public void LogRoleDevPush(RoleDevLogEvent logData)
	{
		LogReportController.Instance.LogReport(logData);
	}

	// Token: 0x0601B773 RID: 112499 RVA: 0x00874658 File Offset: 0x00872858
	public void SetCurrentUploadLogId(string logId)
	{
		this.CustomServiceLogId = logId;
	}

	// Token: 0x0601B774 RID: 112500 RVA: 0x00874664 File Offset: 0x00872864
	public void LogCustomServiceReport(ESendState result)
	{
		CustomServiceLogEvent customServiceLogEvent = new CustomServiceLogEvent();
		customServiceLogEvent.s_trace_id = this.CustomServiceLogId;
		customServiceLogEvent.log_status = LauncherNetworkDetectionDefine.SendStateToCustomServiceLogMap.GetValueOrDefault(result, 0);
		LogReportController.Instance.LogReport(customServiceLogEvent);
	}

	// Token: 0x0601B775 RID: 112501 RVA: 0x008746A0 File Offset: 0x008728A0
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

	// Token: 0x0601B776 RID: 112502 RVA: 0x00874818 File Offset: 0x00872A18
	public string OutputDebugInfo(bool log = true)
	{
		InstanceDungeon? instanceDungeon;
		string text = Json.Encode(new DebugInfo(GameModeModel.Instance.InstanceType.ToString(), OnlineModel.Instance.GetIsMyTeam(), (GameModeModel.Instance.InstanceDungeon != null) ? instanceDungeon.GetValueOrDefault().MapConfigId : 0, Time.Instance.TimeDilation, CreatureModel.Instance.GetPlayerId(), new <>z__ReadOnlyArray<string>(new string[]
		{
			Global.BaseCharacter.CharacterActorComponent.ActorLocationProxy.X.ToString("F2"),
			Global.BaseCharacter.CharacterActorComponent.ActorLocationProxy.Y.ToString("F2"),
			Global.BaseCharacter.CharacterActorComponent.ActorLocationProxy.Z.ToString("F2")
		}), GameModeModel.Instance.IsMulti, OnlineModel.Instance.GetAllWorldTeamPlayer(), LogController.GetPlayerBuffIds(), CharacterGasDebugComponent.GetFormationAttributeDebugStrings().Replace("\n", ",").Replace(" ", ""), LogController.GetFormationRoleInfos(), this.GetSkillButtonDebugInfo()), null);
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
				defaultInterpolatedStringHandler.AppendFormatted(string.Join("|", LogController.GetBuffInfoTexts(baseBuffComponent)));
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

	// Token: 0x0601B777 RID: 112503 RVA: 0x00874C80 File Offset: 0x00872E80
	private static string[] GetPlayerBuffIds()
	{
		IActiveBuff[] allBuffs = FormationDataController.Instance.GetPlayerEntity(CreatureModel.Instance.GetPlayerId()).GetComponent<PlayerBuffComponent>().GetAllBuffs();
		string[] array = new string[allBuffs.Length];
		for (int i = 0; i < allBuffs.Length; i++)
		{
			array[i] = allBuffs[i].Id.ToString();
		}
		return array;
	}

	// Token: 0x0601B778 RID: 112504 RVA: 0x00874CD8 File Offset: 0x00872ED8
	private static List<global::FormationRoleInfo> GetFormationRoleInfos()
	{
		List<SceneTeamItem> teamItems = SceneTeamModel.Instance.GetTeamItems(false);
		List<global::FormationRoleInfo> list = new List<global::FormationRoleInfo>(teamItems.Count);
		for (int i = 0; i < teamItems.Count; i++)
		{
			SceneTeamItem sceneTeamItem = teamItems[i];
			List<global::FormationRoleInfo> list2 = list;
			global::FormationRoleInfo formationRoleInfo = new global::FormationRoleInfo();
			EntityHandle entityHandle = sceneTeamItem.EntityHandle;
			formationRoleInfo.EntityHandleId = ((entityHandle != null) ? new int?(entityHandle.Id) : null);
			formationRoleInfo.ConfigId = sceneTeamItem.GetConfigId;
			formationRoleInfo.IsMyRole = sceneTeamItem.IsMyRole();
			formationRoleInfo.IsControl = sceneTeamItem.IsControl();
			formationRoleInfo.IsDead = sceneTeamItem.IsDead();
			list2.Add(formationRoleInfo);
		}
		return list;
	}

	// Token: 0x0601B779 RID: 112505 RVA: 0x00874D78 File Offset: 0x00872F78
	private static string[] GetBuffInfoTexts([Nullable(2)] BaseBuffComponent buffComp)
	{
		IActiveBuff[] array = (buffComp != null) ? buffComp.GetAllBuffs() : null;
		if (array == null)
		{
			return Array.Empty<string>();
		}
		string[] array2 = new string[array.Length];
		for (int i = 0; i < array.Length; i++)
		{
			IActiveBuff activeBuff = array[i];
			string[] array3 = array2;
			int num = i;
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(2, 3);
			defaultInterpolatedStringHandler.AppendFormatted<long>(activeBuff.Id);
			defaultInterpolatedStringHandler.AppendLiteral(" ");
			defaultInterpolatedStringHandler.AppendFormatted<int>(activeBuff.Handle);
			defaultInterpolatedStringHandler.AppendLiteral(" ");
			defaultInterpolatedStringHandler.AppendFormatted<int>(activeBuff.StackCount);
			array3[num] = defaultInterpolatedStringHandler.ToStringAndClear() + (activeBuff.IsActive() ? "" : "(非激活)");
		}
		return array2;
	}

	// Token: 0x0601B77A RID: 112506 RVA: 0x00874E22 File Offset: 0x00873022
	[NullableContext(2)]
	private void OutputDebugInfoNotify(IMessage msg, Net.CallbackStatus status)
	{
		this.RequestOutputDebugInfo();
	}

	// Token: 0x0601B77B RID: 112507 RVA: 0x00874E2C File Offset: 0x0087302C
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

	// Token: 0x17002C7F RID: 11391
	// (get) Token: 0x0601B77C RID: 112508 RVA: 0x00874E8B File Offset: 0x0087308B
	public static LogController Instance
	{
		get
		{
			return LogController._Instance;
		}
	}

	// Token: 0x0601B77D RID: 112509 RVA: 0x00874E92 File Offset: 0x00873092
	public static LogController GetOrCreateInstance()
	{
		if (LogController._Instance == null)
		{
			LogController.CreateInstance();
		}
		return LogController._Instance;
	}

	// Token: 0x0601B77E RID: 112510 RVA: 0x00874EA6 File Offset: 0x008730A6
	public static bool CreateInstance()
	{
		if (LogController._Instance != null)
		{
			return true;
		}
		LogController._Instance = new LogController();
		return true;
	}

	// Token: 0x0601B77F RID: 112511 RVA: 0x00874EBC File Offset: 0x008730BC
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x0601B780 RID: 112512 RVA: 0x00874EBE File Offset: 0x008730BE
	public static void ResetStaticDefaultValue()
	{
		LogController._Instance = null;
	}

	// Token: 0x0601B781 RID: 112513 RVA: 0x00874EC6 File Offset: 0x008730C6
	static LogController()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(LogController.CreateStaticDefaultValue), new Action(LogController.ResetStaticDefaultValue));
	}

	// Token: 0x0400ED5F RID: 60767
	private const bool LOG_SWITCH = false;

	// Token: 0x0400ED60 RID: 60768
	private const int FRAMING_LOG_NUM = 20;

	// Token: 0x0400ED61 RID: 60769
	private int LogReportFramingTimer = -1;

	// Token: 0x0400ED62 RID: 60770
	private readonly List<CommonLogData> LogReportFramingQueue = new List<CommonLogData>();

	// Token: 0x0400ED63 RID: 60771
	private readonly int FramingLogNum = 20;

	// Token: 0x0400ED64 RID: 60772
	private readonly Stat LogOnBattleEndFramingReport = Stat.Create("LogOnBattleEnd_Framing", "", "");

	// Token: 0x0400ED65 RID: 60773
	private string CustomServiceLogId = "";

	// Token: 0x0400ED66 RID: 60774
	[Nullable(2)]
	private static LogController _Instance;
}
