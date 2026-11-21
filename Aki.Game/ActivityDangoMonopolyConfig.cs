using System;
using System.Linq;
using System.Runtime.CompilerServices;
using Aki.Config;

// Token: 0x020006D3 RID: 1747
[NullableContext(1)]
[Nullable(0)]
[Config(0)]
public class ActivityDangoMonopolyConfig : ConfigBase
{
	// Token: 0x0600505C RID: 20572 RVA: 0x001AF1D3 File Offset: 0x001AD3D3
	protected override bool OnInit()
	{
		return true;
	}

	// Token: 0x0600505D RID: 20573 RVA: 0x001AF1D6 File Offset: 0x001AD3D6
	protected override bool OnClear()
	{
		return true;
	}

	// Token: 0x0600505E RID: 20574 RVA: 0x001AF1D9 File Offset: 0x001AD3D9
	public DangoMonopoly? GetInfo(int activityId)
	{
		return ConfigDangoMonopolyByActivityId.GetConfig(activityId, true);
	}

	// Token: 0x0600505F RID: 20575 RVA: 0x001AF1E2 File Offset: 0x001AD3E2
	public DangoMonopolyBoard? GetBoard(int id)
	{
		return ConfigDangoMonopolyBoardById.GetConfig(id, true);
	}

	// Token: 0x06005060 RID: 20576 RVA: 0x001AF1EB File Offset: 0x001AD3EB
	public DangoMonopolyBoard[] GetBoardList(int groupId)
	{
		if (ConfigDangoMonopolyBoardByGroup.GetConfigList(groupId, true) == null)
		{
			return Array.Empty<DangoMonopolyBoard>();
		}
		return ConfigDangoMonopolyBoardByGroup.GetConfigList(groupId, true).ToArray<DangoMonopolyBoard>();
	}

	// Token: 0x06005061 RID: 20577 RVA: 0x001AF208 File Offset: 0x001AD408
	public DangoMonopolyTask? GetTask(int id)
	{
		return ConfigDangoMonopolyTaskById.GetConfig(id, true);
	}

	// Token: 0x06005062 RID: 20578 RVA: 0x001AF211 File Offset: 0x001AD411
	public DangoMonopolyTask[] GetTaskList(int groupId)
	{
		if (ConfigDangoMonopolyTaskByGroup.GetConfigList(groupId, true) == null)
		{
			return Array.Empty<DangoMonopolyTask>();
		}
		return ConfigDangoMonopolyTaskByGroup.GetConfigList(groupId, true).ToArray<DangoMonopolyTask>();
	}

	// Token: 0x06005063 RID: 20579 RVA: 0x001AF22E File Offset: 0x001AD42E
	public DangoMonopolyGrid? GetGrid(int id)
	{
		return ConfigDangoMonopolyGridById.GetConfig(id, true);
	}

	// Token: 0x06005064 RID: 20580 RVA: 0x001AF237 File Offset: 0x001AD437
	public DangoMonopolyGrid[] GetGridList(int groupId)
	{
		if (ConfigDangoMonopolyGridByGroup.GetConfigList(groupId, true) == null)
		{
			return Array.Empty<DangoMonopolyGrid>();
		}
		return ConfigDangoMonopolyGridByGroup.GetConfigList(groupId, true).ToArray<DangoMonopolyGrid>();
	}

	// Token: 0x06005065 RID: 20581 RVA: 0x001AF254 File Offset: 0x001AD454
	public DangoMonopolyProperty? GetProperty(int id)
	{
		return ConfigDangoMonopolyPropertyById.GetConfig(id, true);
	}

	// Token: 0x06005066 RID: 20582 RVA: 0x001AF25D File Offset: 0x001AD45D
	public DangoMonopolyMapPoint[] GetGridPoint(int id)
	{
		if (ConfigDangoMonopolyMapPointByActivityId.GetConfigList(id, true) == null)
		{
			return Array.Empty<DangoMonopolyMapPoint>();
		}
		return ConfigDangoMonopolyMapPointByActivityId.GetConfigList(id, true).ToArray<DangoMonopolyMapPoint>();
	}

	// Token: 0x06005067 RID: 20583 RVA: 0x001AF27A File Offset: 0x001AD47A
	public string GetBattleConfigPath()
	{
		return "/Game/Aki/Character/NPC/Tuanzi/CommonConfig/DangoGlobalConfig_Monopoly.DangoGlobalConfig_Monopoly";
	}

	// Token: 0x06005068 RID: 20584 RVA: 0x001AF281 File Offset: 0x001AD481
	public int[] GetActiveDangoAniInfo()
	{
		if (ConfigCommonParamById.GetIntArrayConfig("DangoMonopolyActiveDangoAni") == null)
		{
			return Array.Empty<int>();
		}
		return ConfigCommonParamById.GetIntArrayConfig("DangoMonopolyActiveDangoAni").ToArray<int>();
	}

	// Token: 0x06005069 RID: 20585 RVA: 0x001AF2A4 File Offset: 0x001AD4A4
	public bool GetIsOpenHintShow()
	{
		if (this.IsOpenHintShow == null)
		{
			this.IsOpenHintShow = new bool?(ConfigCommonParamById.GetBoolConfig("DangoMonopolyIsOpenHintShow").GetValueOrDefault());
		}
		return this.IsOpenHintShow.Value;
	}

	// Token: 0x0600506A RID: 20586 RVA: 0x001AF2E6 File Offset: 0x001AD4E6
	public void SetPushHintState(bool state)
	{
		this.IsPushHint = state;
	}

	// Token: 0x0600506B RID: 20587 RVA: 0x001AF2EF File Offset: 0x001AD4EF
	public bool GetIsPushHintShow()
	{
		return this.IsPushHint && this.GetIsOpenHintShow();
	}

	// Token: 0x0600506C RID: 20588 RVA: 0x001AF308 File Offset: 0x001AD508
	public int GetDangoMoveInTime()
	{
		return ConfigCommonParamById.GetIntConfig("MonopolyDangoInTime").GetValueOrDefault();
	}

	// Token: 0x0600506D RID: 20589 RVA: 0x001AF328 File Offset: 0x001AD528
	public int GetDangoMoveOutTime()
	{
		return ConfigCommonParamById.GetIntConfig("MonopolyDangoOutTime").GetValueOrDefault();
	}

	// Token: 0x0600506E RID: 20590 RVA: 0x001AF348 File Offset: 0x001AD548
	public int GetDangoMoveOutDelayTime()
	{
		return ConfigCommonParamById.GetIntConfig("MonopolyDangoOutDelayTime").GetValueOrDefault();
	}

	// Token: 0x0600506F RID: 20591 RVA: 0x001AF368 File Offset: 0x001AD568
	public int GetDangoChangeCheckTime()
	{
		return ConfigCommonParamById.GetIntConfig("MonopolyDangoChangeCheckTime").GetValueOrDefault();
	}

	// Token: 0x17000AB3 RID: 2739
	// (get) Token: 0x06005070 RID: 20592 RVA: 0x001AF387 File Offset: 0x001AD587
	public static ActivityDangoMonopolyConfig Instance
	{
		get
		{
			return ActivityDangoMonopolyConfig._Instance;
		}
	}

	// Token: 0x06005071 RID: 20593 RVA: 0x001AF38E File Offset: 0x001AD58E
	public static ActivityDangoMonopolyConfig GetOrCreateInstance()
	{
		if (ActivityDangoMonopolyConfig._Instance == null)
		{
			ActivityDangoMonopolyConfig.CreateInstance();
		}
		return ActivityDangoMonopolyConfig._Instance;
	}

	// Token: 0x06005072 RID: 20594 RVA: 0x001AF3A2 File Offset: 0x001AD5A2
	public static bool CreateInstance()
	{
		if (ActivityDangoMonopolyConfig._Instance != null)
		{
			return true;
		}
		ActivityDangoMonopolyConfig._Instance = new ActivityDangoMonopolyConfig();
		return true;
	}

	// Token: 0x06005073 RID: 20595 RVA: 0x001AF3B8 File Offset: 0x001AD5B8
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x06005074 RID: 20596 RVA: 0x001AF3BA File Offset: 0x001AD5BA
	public static void ResetStaticDefaultValue()
	{
		ActivityDangoMonopolyConfig._Instance = null;
	}

	// Token: 0x06005075 RID: 20597 RVA: 0x001AF3C2 File Offset: 0x001AD5C2
	static ActivityDangoMonopolyConfig()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(ActivityDangoMonopolyConfig.CreateStaticDefaultValue), new Action(ActivityDangoMonopolyConfig.ResetStaticDefaultValue));
	}

	// Token: 0x0400398B RID: 14731
	private bool? IsOpenHintShow;

	// Token: 0x0400398C RID: 14732
	private bool IsPushHint;

	// Token: 0x0400398D RID: 14733
	[Nullable(2)]
	private static ActivityDangoMonopolyConfig _Instance;
}
