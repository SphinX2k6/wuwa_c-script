using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Launcher.HotPatchKuroSdk;

// Token: 0x020002EE RID: 750
[NullableContext(1)]
[Nullable(0)]
public class SdkReportDirectBuy : SdkReportData, IStaticVariableResetter
{
	// Token: 0x06002B1F RID: 11039 RVA: 0x00103D3D File Offset: 0x00101F3D
	public SdkReportDirectBuy([Nullable(new byte[]
	{
		2,
		1,
		1
	})] Dictionary<string, string> eventData) : base(eventData)
	{
	}

	// Token: 0x06002B20 RID: 11040 RVA: 0x00103D46 File Offset: 0x00101F46
	static SdkReportDirectBuy()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(SdkReportDirectBuy.CreateStaticDefaultValue), new Action(SdkReportDirectBuy.ResetStaticDefaultValue));
	}

	// Token: 0x17000678 RID: 1656
	// (get) Token: 0x06002B21 RID: 11041 RVA: 0x00103D65 File Offset: 0x00101F65
	private static IReadOnlyDictionary<int, string> GlobalReportMap
	{
		get
		{
			return SdkReportDirectBuy._globalReportMap;
		}
	}

	// Token: 0x06002B22 RID: 11042 RVA: 0x00103D6C File Offset: 0x00101F6C
	public static bool IfNeedReport(int payId)
	{
		return payId == 42 || payId == 43 || payId == 44 || payId == 45;
	}

	// Token: 0x06002B23 RID: 11043 RVA: 0x00103D85 File Offset: 0x00101F85
	public override string GetEventName()
	{
		if (this.IfGlobalSdk)
		{
			return SdkReportDirectBuy.GlobalReportMap.GetValueOrDefault(this.PayItemId, "");
		}
		return "";
	}

	// Token: 0x06002B24 RID: 11044 RVA: 0x00103DAA File Offset: 0x00101FAA
	public static void CreateStaticDefaultValue()
	{
		SdkReportDirectBuy._globalReportMap = new Dictionary<int, string>
		{
			{
				42,
				"Monthly_card"
			},
			{
				43,
				"BattlePass_Primary"
			},
			{
				44,
				"BattlePass_HIGH"
			},
			{
				45,
				"BattlePass_Primary_To_HIGH"
			}
		};
	}

	// Token: 0x06002B25 RID: 11045 RVA: 0x00103DEA File Offset: 0x00101FEA
	public static void ResetStaticDefaultValue()
	{
		SdkReportDirectBuy._globalReportMap = null;
	}

	// Token: 0x04002904 RID: 10500
	public int PayItemId;

	// Token: 0x04002905 RID: 10501
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private static IReadOnlyDictionary<int, string> _globalReportMap;
}
