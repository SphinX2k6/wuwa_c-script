using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Launcher.HotPatchKuroSdk;

// Token: 0x020002EF RID: 751
[NullableContext(1)]
[Nullable(0)]
public class SdkReportChapter : SdkReportData, IStaticVariableResetter
{
	// Token: 0x06002B26 RID: 11046 RVA: 0x00103DF2 File Offset: 0x00101FF2
	public SdkReportChapter([Nullable(new byte[]
	{
		2,
		1,
		1
	})] Dictionary<string, string> eventData) : base(eventData)
	{
	}

	// Token: 0x06002B27 RID: 11047 RVA: 0x00103DFB File Offset: 0x00101FFB
	static SdkReportChapter()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(SdkReportChapter.CreateStaticDefaultValue), new Action(SdkReportChapter.ResetStaticDefaultValue));
	}

	// Token: 0x17000679 RID: 1657
	// (get) Token: 0x06002B28 RID: 11048 RVA: 0x00103E1A File Offset: 0x0010201A
	private static IReadOnlyDictionary<int, string> GlobalReportMap
	{
		get
		{
			return SdkReportChapter._globalReportMap;
		}
	}

	// Token: 0x1700067A RID: 1658
	// (get) Token: 0x06002B29 RID: 11049 RVA: 0x00103E21 File Offset: 0x00102021
	private static IReadOnlyDictionary<int, string> ChinaReportMap
	{
		get
		{
			return SdkReportChapter._chinaReportMap;
		}
	}

	// Token: 0x06002B2A RID: 11050 RVA: 0x00103E28 File Offset: 0x00102028
	public static bool IfNeedReport(int treeId, int nodeId)
	{
		return treeId == 139000025 || treeId == 139000026 || treeId == 139000027 || treeId == 139000029 || treeId == 139000030 || treeId == 139000031 || treeId == 114000020 || treeId == 140000004;
	}

	// Token: 0x06002B2B RID: 11051 RVA: 0x00103E78 File Offset: 0x00102078
	public override string GetEventName()
	{
		if (this.IfGlobalSdk)
		{
			return SdkReportChapter.GlobalReportMap.GetValueOrDefault(this.TreeConfigId, "");
		}
		return SdkReportChapter.ChinaReportMap.GetValueOrDefault(this.TreeConfigId, "");
	}

	// Token: 0x06002B2C RID: 11052 RVA: 0x00103EB0 File Offset: 0x001020B0
	public static void CreateStaticDefaultValue()
	{
		SdkReportChapter._globalReportMap = new Dictionary<int, string>
		{
			{
				139000025,
				"Complete_pre_1"
			},
			{
				139000026,
				"Complete_pre_2"
			},
			{
				139000027,
				"Complete_C1_1"
			},
			{
				139000029,
				"Complete_C1_2"
			},
			{
				139000030,
				"Complete_C1_3"
			},
			{
				139000031,
				"Complete_C1_4"
			},
			{
				114000020,
				"Complete_C1_5"
			},
			{
				140000004,
				"Complete_C1_6"
			}
		};
		SdkReportChapter._chinaReportMap = new Dictionary<int, string>
		{
			{
				139000025,
				"event_12"
			},
			{
				139000026,
				"event_13"
			},
			{
				139000027,
				"event_14"
			},
			{
				139000029,
				"event_15"
			},
			{
				139000030,
				"event_16"
			},
			{
				139000031,
				"event_17"
			},
			{
				114000020,
				"event_18"
			},
			{
				140000004,
				"event_19"
			}
		};
	}

	// Token: 0x06002B2D RID: 11053 RVA: 0x00103FD1 File Offset: 0x001021D1
	public static void ResetStaticDefaultValue()
	{
		SdkReportChapter._globalReportMap = null;
		SdkReportChapter._chinaReportMap = null;
	}

	// Token: 0x04002906 RID: 10502
	public int TreeConfigId;

	// Token: 0x04002907 RID: 10503
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private static IReadOnlyDictionary<int, string> _globalReportMap;

	// Token: 0x04002908 RID: 10504
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private static IReadOnlyDictionary<int, string> _chinaReportMap;
}
