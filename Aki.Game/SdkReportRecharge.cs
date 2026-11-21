using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Launcher.HotPatchKuroSdk;

// Token: 0x020002EC RID: 748
[NullableContext(1)]
[Nullable(0)]
public class SdkReportRecharge : SdkReportData, IStaticVariableResetter
{
	// Token: 0x06002B15 RID: 11029 RVA: 0x00103BE6 File Offset: 0x00101DE6
	public SdkReportRecharge([Nullable(new byte[]
	{
		2,
		1,
		1
	})] Dictionary<string, string> eventData) : base(eventData)
	{
	}

	// Token: 0x06002B16 RID: 11030 RVA: 0x00103BEF File Offset: 0x00101DEF
	static SdkReportRecharge()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(SdkReportRecharge.CreateStaticDefaultValue), new Action(SdkReportRecharge.ResetStaticDefaultValue));
	}

	// Token: 0x17000676 RID: 1654
	// (get) Token: 0x06002B17 RID: 11031 RVA: 0x00103C0E File Offset: 0x00101E0E
	private static IReadOnlyDictionary<int, string> GlobalReportMap
	{
		get
		{
			return SdkReportRecharge._globalReportMap;
		}
	}

	// Token: 0x17000677 RID: 1655
	// (get) Token: 0x06002B18 RID: 11032 RVA: 0x00103C15 File Offset: 0x00101E15
	private static IReadOnlyDictionary<int, string> ChinaReportMap
	{
		get
		{
			return SdkReportRecharge._chinaReportMap;
		}
	}

	// Token: 0x06002B19 RID: 11033 RVA: 0x00103C1C File Offset: 0x00101E1C
	public static bool IfNeedReport(int payId)
	{
		return payId >= 1 && payId <= 6;
	}

	// Token: 0x06002B1A RID: 11034 RVA: 0x00103C29 File Offset: 0x00101E29
	public override string GetEventName()
	{
		if (this.IfGlobalSdk)
		{
			return SdkReportRecharge.GlobalReportMap.GetValueOrDefault(this.PayItemId, "");
		}
		return SdkReportRecharge.ChinaReportMap.GetValueOrDefault(this.PayItemId, "");
	}

	// Token: 0x06002B1B RID: 11035 RVA: 0x00103C60 File Offset: 0x00101E60
	public static void CreateStaticDefaultValue()
	{
		SdkReportRecharge._globalReportMap = new Dictionary<int, string>
		{
			{
				1,
				"Purchase_099"
			},
			{
				2,
				"Purchase_499"
			},
			{
				3,
				"Purchase_1499"
			},
			{
				4,
				"Purchase_2999"
			},
			{
				5,
				"Purchase_4999"
			},
			{
				6,
				"Purchase_9999"
			}
		};
		SdkReportRecharge._chinaReportMap = new Dictionary<int, string>
		{
			{
				1,
				"event_5"
			},
			{
				2,
				"event_6"
			},
			{
				3,
				"event_7"
			},
			{
				4,
				"event_8"
			},
			{
				5,
				"event_9"
			},
			{
				6,
				"event_10"
			}
		};
	}

	// Token: 0x06002B1C RID: 11036 RVA: 0x00103D11 File Offset: 0x00101F11
	public static void ResetStaticDefaultValue()
	{
		SdkReportRecharge._globalReportMap = null;
		SdkReportRecharge._chinaReportMap = null;
	}

	// Token: 0x04002901 RID: 10497
	public int PayItemId;

	// Token: 0x04002902 RID: 10498
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private static IReadOnlyDictionary<int, string> _globalReportMap;

	// Token: 0x04002903 RID: 10499
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private static IReadOnlyDictionary<int, string> _chinaReportMap;
}
