using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Launcher.HotPatchKuroSdk;

// Token: 0x020002E9 RID: 745
[NullableContext(1)]
[Nullable(0)]
public class SdkReportBattleTech : SdkReportData, IStaticVariableResetter
{
	// Token: 0x06002B01 RID: 11009 RVA: 0x00103920 File Offset: 0x00101B20
	public SdkReportBattleTech([Nullable(new byte[]
	{
		2,
		1,
		1
	})] Dictionary<string, string> eventData) : base(eventData)
	{
	}

	// Token: 0x06002B02 RID: 11010 RVA: 0x00103929 File Offset: 0x00101B29
	static SdkReportBattleTech()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(SdkReportBattleTech.CreateStaticDefaultValue), new Action(SdkReportBattleTech.ResetStaticDefaultValue));
	}

	// Token: 0x17000674 RID: 1652
	// (get) Token: 0x06002B03 RID: 11011 RVA: 0x00103948 File Offset: 0x00101B48
	private static IReadOnlyDictionary<int, string> GlobalReportMap
	{
		get
		{
			return SdkReportBattleTech._globalReportMap;
		}
	}

	// Token: 0x06002B04 RID: 11012 RVA: 0x0010394F File Offset: 0x00101B4F
	public static bool IfNeedReport(int treeId, int nodeId)
	{
		return (treeId == 139000025 && (nodeId == 6 || nodeId == 10 || nodeId == 91)) || (treeId == 139000026 && 132 == nodeId) || (treeId == 139000026 && 16 == nodeId);
	}

	// Token: 0x06002B05 RID: 11013 RVA: 0x00103987 File Offset: 0x00101B87
	public override string GetEventName()
	{
		if (this.IfGlobalSdk)
		{
			return SdkReportBattleTech.GlobalReportMap.GetValueOrDefault(this.NodeId, "");
		}
		return "";
	}

	// Token: 0x06002B06 RID: 11014 RVA: 0x001039AC File Offset: 0x00101BAC
	protected override string GetEventDataJson()
	{
		this.EventData = new Dictionary<string, string>();
		this.EventData["eventId"] = "101803";
		this.EventData["TreeId"] = this.TreeConfigId.ToString();
		this.EventData["StepId"] = this.NodeId.ToString();
		return base.GetEventDataJson();
	}

	// Token: 0x06002B07 RID: 11015 RVA: 0x00103A18 File Offset: 0x00101C18
	public static void CreateStaticDefaultValue()
	{
		SdkReportBattleTech._globalReportMap = new Dictionary<int, string>
		{
			{
				6,
				"Beginner_level_Battle_Teach_Finish"
			},
			{
				10,
				"Intermediater_level_Battle_Teach_Finish"
			},
			{
				91,
				"Advanced_level_Battle_Teach_Finish"
			},
			{
				132,
				"capture_Teach_Finish"
			},
			{
				16,
				"Prologue_Task_Finish"
			}
		};
	}

	// Token: 0x06002B08 RID: 11016 RVA: 0x00103A72 File Offset: 0x00101C72
	public static void ResetStaticDefaultValue()
	{
		SdkReportBattleTech._globalReportMap = null;
	}

	// Token: 0x040028FB RID: 10491
	public int TreeConfigId;

	// Token: 0x040028FC RID: 10492
	public int NodeId;

	// Token: 0x040028FD RID: 10493
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private static IReadOnlyDictionary<int, string> _globalReportMap;
}
