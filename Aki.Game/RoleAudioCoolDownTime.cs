using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Audio;

// Token: 0x0200325A RID: 12890
[NullableContext(1)]
[Nullable(0)]
public class RoleAudioCoolDownTime
{
	// Token: 0x0601BCF7 RID: 113911 RVA: 0x007AF068 File Offset: 0x007AD268
	public RoleAudioCoolDownTime(ERoleAudioType type)
	{
		this.Type = type;
		RoleAudioRules? config = ConfigRoleAudioRulesById.GetConfig((int)type, true);
		this.TeamIntervalTime = (double)((config != null) ? config.GetValueOrDefault().TeamColdTime : 10000);
		int defaultCooldownTime = (config != null) ? config.GetValueOrDefault().CharacterColdTime : 10000;
		double defaultProbability = (double)((config != null) ? config.GetValueOrDefault().PostProbability : 100) / 100.0;
		this.ProbabilityCooldown = new AudioCoolDownWithTagInfo
		{
			DefaultCooldownTime = defaultCooldownTime,
			DefaultProbability = defaultProbability
		};
		this.GroupId = 0;
		if (config != null)
		{
			switch (config.Value.GroupID)
			{
			case 1:
				this.GroupId = 1;
				return;
			case 2:
				this.GroupId = 2;
				return;
			case 3:
				this.GroupId = 4;
				return;
			case 4:
				this.GroupId = 8;
				return;
			default:
				this.GroupId = 0;
				break;
			}
		}
	}

	// Token: 0x0601BCF8 RID: 113912 RVA: 0x007AF1A1 File Offset: 0x007AD3A1
	public void RefreshCoolDownTime(int entityId, bool log = true)
	{
		GameAudioModel instance = GameAudioModel.Instance;
		if (instance == null)
		{
			return;
		}
		instance.UpdateAudioCooldownRecord(entityId, (int)this.Type, this.ProbabilityCooldown.DefaultProbability, this.ProbabilityCooldown.DefaultCooldownTime, log);
	}

	// Token: 0x0601BCF9 RID: 113913 RVA: 0x007AF1D8 File Offset: 0x007AD3D8
	public bool CheckCoolDownTime(int roleId, int entityId, bool update = true, bool log = true)
	{
		bool flag = true;
		SceneTeamModel instance = SceneTeamModel.Instance;
		List<SceneTeamItem> list = (instance != null) ? instance.GetTeamItems(false) : null;
		if (list == null)
		{
			Log.Instance.Error(ELogModule.Audio, ELogAuthor.CWZ, "[CheckAndUpdateCoolDownTime] GetTeamItems失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		int playerId = CreatureModel.Instance.GetPlayerId();
		foreach (SceneTeamItem sceneTeamItem in list)
		{
			if (sceneTeamItem.GetConfigId == roleId)
			{
				playerId = sceneTeamItem.GetPlayerId();
				break;
			}
		}
		int num = 0;
		if (GameModeModel.Instance.IsMulti)
		{
			OnlineTeamData currentTeamListById = OnlineModel.Instance.GetCurrentTeamListById(playerId);
			num = ((currentTeamListById != null) ? currentTeamListById.PlayerNumber : 1) - 1;
			if (num < 0)
			{
				Log.Instance.Error(ELogModule.Audio, ELogAuthor.CWZ, "[CheckAndUpdateCoolDownTime] GetCurrentTeamListById失败", default(ReadOnlySpan<ValueTuple<string, object>>));
				return false;
			}
		}
		double num2 = Time.Instance.Now - this.CurrentTeamTime[num];
		flag = (flag && num2 >= this.TeamIntervalTime);
		bool flag2 = num2 < this.TeamIntervalTime && log;
		bool flag3;
		if (flag)
		{
			GameAudioModel instance2 = GameAudioModel.Instance;
			flag3 = (instance2 != null && instance2.CheckAudioProbabilityInfo(entityId, (int)this.Type, this.ProbabilityCooldown, false, log, true));
		}
		else
		{
			flag3 = false;
		}
		flag = flag3;
		if (flag && update)
		{
			this.CurrentTeamTime[num] = Time.Instance.Now;
			this.RefreshCoolDownTime(entityId, log);
		}
		return flag;
	}

	// Token: 0x0400DB70 RID: 56176
	public ERoleAudioType Type;

	// Token: 0x0400DB71 RID: 56177
	public double[] CurrentTeamTime = new double[3];

	// Token: 0x0400DB72 RID: 56178
	public double TeamIntervalTime;

	// Token: 0x0400DB73 RID: 56179
	public int GroupId;

	// Token: 0x0400DB74 RID: 56180
	public AudioCoolDownWithTagInfo ProbabilityCooldown = new AudioCoolDownWithTagInfo
	{
		DefaultCooldownTime = 0,
		DefaultProbability = 1.0
	};
}
