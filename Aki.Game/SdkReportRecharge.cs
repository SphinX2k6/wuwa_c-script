using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Launcher.HotPatchKuroSdk;

// Token: 0x02000E37 RID: 3639
[NullableContext(1)]
[Nullable(0)]
public class SdkReportRecharge : SdkReportData, IStaticVariableResetter
{
	// Token: 0x06005785 RID: 22405 RVA: 0x000FC392 File Offset: 0x000FA592
	public SdkReportRecharge([Nullable(new byte[]
	{
		2,
		1,
		1
	})] Dictionary<string, string> eventData) : base(eventData)
	{
	}

	// Token: 0x06005786 RID: 22406 RVA: 0x000FC39B File Offset: 0x000FA59B
	static SdkReportRecharge()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(SdkReportRecharge.CreateStaticDefaultValue), new Action(SdkReportRecharge.ResetStaticDefaultValue));
	}

	// Token: 0x17000652 RID: 1618
	// (get) Token: 0x06005787 RID: 22407 RVA: 0x000FC3BA File Offset: 0x000FA5BA
	private static IReadOnlyDictionary<int, string> GlobalReportMap
	{
		get
		{
			return SdkReportRecharge._globalReportMap;
		}
	}

	// Token: 0x17000653 RID: 1619
	// (get) Token: 0x06005788 RID: 22408 RVA: 0x000FC3C1 File Offset: 0x000FA5C1
	private static IReadOnlyDictionary<int, string> ChinaReportMap
	{
		get
		{
			return SdkReportRecharge._chinaReportMap;
		}
	}

	// Token: 0x06005789 RID: 22409 RVA: 0x000FC3C8 File Offset: 0x000FA5C8
	public static bool IfNeedReport(int payId)
	{
		return payId >= 1 && payId <= 6;
	}

	// Token: 0x0600578A RID: 22410 RVA: 0x000FC3D5 File Offset: 0x000FA5D5
	public override string GetEventName()
	{
		if (this.IfGlobalSdk)
		{
			return SdkReportRecharge.GlobalReportMap.GetValueOrDefault(this.PayItemId, "");
		}
		return SdkReportRecharge.ChinaReportMap.GetValueOrDefault(this.PayItemId, "");
	}

	// Token: 0x0600578B RID: 22411 RVA: 0x000FC40C File Offset: 0x000FA60C
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

	// Token: 0x0600578C RID: 22412 RVA: 0x000FC4BD File Offset: 0x000FA6BD
	public static void ResetStaticDefaultValue()
	{
		SdkReportRecharge._globalReportMap = null;
		SdkReportRecharge._chinaReportMap = null;
	}

	// Token: 0x04002868 RID: 10344
	public int PayItemId;

	// Token: 0x04002869 RID: 10345
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private static IReadOnlyDictionary<int, string> _globalReportMap;

	// Token: 0x0400286A RID: 10346
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private static IReadOnlyDictionary<int, string> _chinaReportMap;
}
