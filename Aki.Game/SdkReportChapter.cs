using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Launcher.HotPatchKuroSdk;

// Token: 0x02000E3A RID: 3642
[NullableContext(1)]
[Nullable(0)]
public class SdkReportChapter : SdkReportData, IStaticVariableResetter
{
	// Token: 0x06005796 RID: 22422 RVA: 0x000FC59E File Offset: 0x000FA79E
	public SdkReportChapter([Nullable(new byte[]
	{
		2,
		1,
		1
	})] Dictionary<string, string> eventData) : base(eventData)
	{
	}

	// Token: 0x06005797 RID: 22423 RVA: 0x000FC5A7 File Offset: 0x000FA7A7
	static SdkReportChapter()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(SdkReportChapter.CreateStaticDefaultValue), new Action(SdkReportChapter.ResetStaticDefaultValue));
	}

	// Token: 0x17000655 RID: 1621
	// (get) Token: 0x06005798 RID: 22424 RVA: 0x000FC5C6 File Offset: 0x000FA7C6
	private static IReadOnlyDictionary<int, string> GlobalReportMap
	{
		get
		{
			return SdkReportChapter._globalReportMap;
		}
	}

	// Token: 0x17000656 RID: 1622
	// (get) Token: 0x06005799 RID: 22425 RVA: 0x000FC5CD File Offset: 0x000FA7CD
	private static IReadOnlyDictionary<int, string> ChinaReportMap
	{
		get
		{
			return SdkReportChapter._chinaReportMap;
		}
	}

	// Token: 0x0600579A RID: 22426 RVA: 0x000FC5D4 File Offset: 0x000FA7D4
	public static bool IfNeedReport(int treeId, int nodeId)
	{
		return treeId == 139000025 || treeId == 139000026 || treeId == 139000027 || treeId == 139000029 || treeId == 139000030 || treeId == 139000031 || treeId == 114000020 || treeId == 140000004;
	}

	// Token: 0x0600579B RID: 22427 RVA: 0x000FC624 File Offset: 0x000FA824
	public override string GetEventName()
	{
		if (this.IfGlobalSdk)
		{
			return SdkReportChapter.GlobalReportMap.GetValueOrDefault(this.TreeConfigId, "");
		}
		return SdkReportChapter.ChinaReportMap.GetValueOrDefault(this.TreeConfigId, "");
	}

	// Token: 0x0600579C RID: 22428 RVA: 0x000FC65C File Offset: 0x000FA85C
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

	// Token: 0x0600579D RID: 22429 RVA: 0x000FC77D File Offset: 0x000FA97D
	public static void ResetStaticDefaultValue()
	{
		SdkReportChapter._globalReportMap = null;
		SdkReportChapter._chinaReportMap = null;
	}

	// Token: 0x0400286D RID: 10349
	public int TreeConfigId;

	// Token: 0x0400286E RID: 10350
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private static IReadOnlyDictionary<int, string> _globalReportMap;

	// Token: 0x0400286F RID: 10351
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private static IReadOnlyDictionary<int, string> _chinaReportMap;
}
