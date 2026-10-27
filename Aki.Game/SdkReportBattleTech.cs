using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Launcher.HotPatchKuroSdk;

// Token: 0x02000E34 RID: 3636
[NullableContext(1)]
[Nullable(0)]
public class SdkReportBattleTech : SdkReportData, IStaticVariableResetter
{
	// Token: 0x06005771 RID: 22385 RVA: 0x000FC0CC File Offset: 0x000FA2CC
	public SdkReportBattleTech([Nullable(new byte[]
	{
		2,
		1,
		1
	})] Dictionary<string, string> eventData) : base(eventData)
	{
	}

	// Token: 0x06005772 RID: 22386 RVA: 0x000FC0D5 File Offset: 0x000FA2D5
	static SdkReportBattleTech()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(SdkReportBattleTech.CreateStaticDefaultValue), new Action(SdkReportBattleTech.ResetStaticDefaultValue));
	}

	// Token: 0x17000650 RID: 1616
	// (get) Token: 0x06005773 RID: 22387 RVA: 0x000FC0F4 File Offset: 0x000FA2F4
	private static IReadOnlyDictionary<int, string> GlobalReportMap
	{
		get
		{
			return SdkReportBattleTech._globalReportMap;
		}
	}

	// Token: 0x06005774 RID: 22388 RVA: 0x000FC0FB File Offset: 0x000FA2FB
	public static bool IfNeedReport(int treeId, int nodeId)
	{
		return (treeId == 139000025 && (nodeId == 6 || nodeId == 10 || nodeId == 91)) || (treeId == 139000026 && 132 == nodeId) || (treeId == 139000026 && 16 == nodeId);
	}

	// Token: 0x06005775 RID: 22389 RVA: 0x000FC133 File Offset: 0x000FA333
	public override string GetEventName()
	{
		if (this.IfGlobalSdk)
		{
			return SdkReportBattleTech.GlobalReportMap.GetValueOrDefault(this.NodeId, "");
		}
		return "";
	}

	// Token: 0x06005776 RID: 22390 RVA: 0x000FC158 File Offset: 0x000FA358
	protected override string GetEventDataJson()
	{
		this.EventData = new Dictionary<string, string>();
		this.EventData["eventId"] = "101803";
		this.EventData["TreeId"] = this.TreeConfigId.ToString();
		this.EventData["StepId"] = this.NodeId.ToString();
		return base.GetEventDataJson();
	}

	// Token: 0x06005777 RID: 22391 RVA: 0x000FC1C4 File Offset: 0x000FA3C4
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

	// Token: 0x06005778 RID: 22392 RVA: 0x000FC21E File Offset: 0x000FA41E
	public static void ResetStaticDefaultValue()
	{
		SdkReportBattleTech._globalReportMap = null;
	}

	// Token: 0x04002862 RID: 10338
	public int TreeConfigId;

	// Token: 0x04002863 RID: 10339
	public int NodeId;

	// Token: 0x04002864 RID: 10340
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private static IReadOnlyDictionary<int, string> _globalReportMap;
}
