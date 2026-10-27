using System;
using System.Linq;
using System.Runtime.CompilerServices;
using Aki.Config;

// Token: 0x0200121F RID: 4639
[NullableContext(1)]
[Nullable(0)]
[Config(0)]
public class ActivityDangoMonopolyConfig : ConfigBase
{
	// Token: 0x06007CC6 RID: 31942 RVA: 0x001A651F File Offset: 0x001A471F
	protected override bool OnInit()
	{
		return true;
	}

	// Token: 0x06007CC7 RID: 31943 RVA: 0x001A6522 File Offset: 0x001A4722
	protected override bool OnClear()
	{
		return true;
	}

	// Token: 0x06007CC8 RID: 31944 RVA: 0x001A6525 File Offset: 0x001A4725
	public DangoMonopoly? GetInfo(int activityId)
	{
		return ConfigDangoMonopolyByActivityId.GetConfig(activityId, true);
	}

	// Token: 0x06007CC9 RID: 31945 RVA: 0x001A652E File Offset: 0x001A472E
	public DangoMonopolyBoard? GetBoard(int id)
	{
		return ConfigDangoMonopolyBoardById.GetConfig(id, true);
	}

	// Token: 0x06007CCA RID: 31946 RVA: 0x001A6537 File Offset: 0x001A4737
	public DangoMonopolyBoard[] GetBoardList(int groupId)
	{
		if (ConfigDangoMonopolyBoardByGroup.GetConfigList(groupId, true) == null)
		{
			return Array.Empty<DangoMonopolyBoard>();
		}
		return ConfigDangoMonopolyBoardByGroup.GetConfigList(groupId, true).ToArray<DangoMonopolyBoard>();
	}

	// Token: 0x06007CCB RID: 31947 RVA: 0x001A6554 File Offset: 0x001A4754
	public DangoMonopolyTask? GetTask(int id)
	{
		return ConfigDangoMonopolyTaskById.GetConfig(id, true);
	}

	// Token: 0x06007CCC RID: 31948 RVA: 0x001A655D File Offset: 0x001A475D
	public DangoMonopolyTask[] GetTaskList(int groupId)
	{
		if (ConfigDangoMonopolyTaskByGroup.GetConfigList(groupId, true) == null)
		{
			return Array.Empty<DangoMonopolyTask>();
		}
		return ConfigDangoMonopolyTaskByGroup.GetConfigList(groupId, true).ToArray<DangoMonopolyTask>();
	}

	// Token: 0x06007CCD RID: 31949 RVA: 0x001A657A File Offset: 0x001A477A
	public DangoMonopolyGrid? GetGrid(int id)
	{
		return ConfigDangoMonopolyGridById.GetConfig(id, true);
	}

	// Token: 0x06007CCE RID: 31950 RVA: 0x001A6583 File Offset: 0x001A4783
	public DangoMonopolyGrid[] GetGridList(int groupId)
	{
		if (ConfigDangoMonopolyGridByGroup.GetConfigList(groupId, true) == null)
		{
			return Array.Empty<DangoMonopolyGrid>();
		}
		return ConfigDangoMonopolyGridByGroup.GetConfigList(groupId, true).ToArray<DangoMonopolyGrid>();
	}

	// Token: 0x06007CCF RID: 31951 RVA: 0x001A65A0 File Offset: 0x001A47A0
	public DangoMonopolyProperty? GetProperty(int id)
	{
		return ConfigDangoMonopolyPropertyById.GetConfig(id, true);
	}

	// Token: 0x06007CD0 RID: 31952 RVA: 0x001A65A9 File Offset: 0x001A47A9
	public DangoMonopolyMapPoint[] GetGridPoint(int id)
	{
		if (ConfigDangoMonopolyMapPointByActivityId.GetConfigList(id, true) == null)
		{
			return Array.Empty<DangoMonopolyMapPoint>();
		}
		return ConfigDangoMonopolyMapPointByActivityId.GetConfigList(id, true).ToArray<DangoMonopolyMapPoint>();
	}

	// Token: 0x06007CD1 RID: 31953 RVA: 0x001A65C6 File Offset: 0x001A47C6
	public string GetBattleConfigPath()
	{
		return "/Game/Aki/Character/NPC/Tuanzi/CommonConfig/DangoGlobalConfig_Monopoly.DangoGlobalConfig_Monopoly";
	}

	// Token: 0x06007CD2 RID: 31954 RVA: 0x001A65CD File Offset: 0x001A47CD
	public int[] GetActiveDangoAniInfo()
	{
		if (ConfigCommonParamById.GetIntArrayConfig("DangoMonopolyActiveDangoAni") == null)
		{
			return Array.Empty<int>();
		}
		return ConfigCommonParamById.GetIntArrayConfig("DangoMonopolyActiveDangoAni").ToArray<int>();
	}

	// Token: 0x06007CD3 RID: 31955 RVA: 0x001A65F0 File Offset: 0x001A47F0
	public bool GetIsOpenHintShow()
	{
		if (this.IsOpenHintShow == null)
		{
			this.IsOpenHintShow = new bool?(ConfigCommonParamById.GetBoolConfig("DangoMonopolyIsOpenHintShow").GetValueOrDefault());
		}
		return this.IsOpenHintShow.Value;
	}

	// Token: 0x06007CD4 RID: 31956 RVA: 0x001A6632 File Offset: 0x001A4832
	public void SetPushHintState(bool state)
	{
		this.IsPushHint = state;
	}

	// Token: 0x06007CD5 RID: 31957 RVA: 0x001A663B File Offset: 0x001A483B
	public bool GetIsPushHintShow()
	{
		return this.IsPushHint && this.GetIsOpenHintShow();
	}

	// Token: 0x06007CD6 RID: 31958 RVA: 0x001A6654 File Offset: 0x001A4854
	public int GetDangoMoveInTime()
	{
		return ConfigCommonParamById.GetIntConfig("MonopolyDangoInTime").GetValueOrDefault();
	}

	// Token: 0x06007CD7 RID: 31959 RVA: 0x001A6674 File Offset: 0x001A4874
	public int GetDangoMoveOutTime()
	{
		return ConfigCommonParamById.GetIntConfig("MonopolyDangoOutTime").GetValueOrDefault();
	}

	// Token: 0x06007CD8 RID: 31960 RVA: 0x001A6694 File Offset: 0x001A4894
	public int GetDangoMoveOutDelayTime()
	{
		return ConfigCommonParamById.GetIntConfig("MonopolyDangoOutDelayTime").GetValueOrDefault();
	}

	// Token: 0x06007CD9 RID: 31961 RVA: 0x001A66B4 File Offset: 0x001A48B4
	public int GetDangoChangeCheckTime()
	{
		return ConfigCommonParamById.GetIntConfig("MonopolyDangoChangeCheckTime").GetValueOrDefault();
	}

	// Token: 0x17000A93 RID: 2707
	// (get) Token: 0x06007CDA RID: 31962 RVA: 0x001A66D3 File Offset: 0x001A48D3
	public static ActivityDangoMonopolyConfig Instance
	{
		get
		{
			return ActivityDangoMonopolyConfig._Instance;
		}
	}

	// Token: 0x06007CDB RID: 31963 RVA: 0x001A66DA File Offset: 0x001A48DA
	public static ActivityDangoMonopolyConfig GetOrCreateInstance()
	{
		if (ActivityDangoMonopolyConfig._Instance == null)
		{
			ActivityDangoMonopolyConfig.CreateInstance();
		}
		return ActivityDangoMonopolyConfig._Instance;
	}

	// Token: 0x06007CDC RID: 31964 RVA: 0x001A66EE File Offset: 0x001A48EE
	public static bool CreateInstance()
	{
		if (ActivityDangoMonopolyConfig._Instance != null)
		{
			return true;
		}
		ActivityDangoMonopolyConfig._Instance = new ActivityDangoMonopolyConfig();
		return true;
	}

	// Token: 0x06007CDD RID: 31965 RVA: 0x001A6704 File Offset: 0x001A4904
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x06007CDE RID: 31966 RVA: 0x001A6706 File Offset: 0x001A4906
	public static void ResetStaticDefaultValue()
	{
		ActivityDangoMonopolyConfig._Instance = null;
	}

	// Token: 0x06007CDF RID: 31967 RVA: 0x001A670E File Offset: 0x001A490E
	static ActivityDangoMonopolyConfig()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(ActivityDangoMonopolyConfig.CreateStaticDefaultValue), new Action(ActivityDangoMonopolyConfig.ResetStaticDefaultValue));
	}

	// Token: 0x040038F2 RID: 14578
	private bool? IsOpenHintShow;

	// Token: 0x040038F3 RID: 14579
	private bool IsPushHint;

	// Token: 0x040038F4 RID: 14580
	[Nullable(2)]
	private static ActivityDangoMonopolyConfig _Instance;
}
