using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Launcher.HotPatchKuroSdk;

// Token: 0x02000E39 RID: 3641
[NullableContext(1)]
[Nullable(0)]
public class SdkReportDirectBuy : SdkReportData, IStaticVariableResetter
{
	// Token: 0x0600578F RID: 22415 RVA: 0x000FC4E9 File Offset: 0x000FA6E9
	public SdkReportDirectBuy([Nullable(new byte[]
	{
		2,
		1,
		1
	})] Dictionary<string, string> eventData) : base(eventData)
	{
	}

	// Token: 0x06005790 RID: 22416 RVA: 0x000FC4F2 File Offset: 0x000FA6F2
	static SdkReportDirectBuy()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(SdkReportDirectBuy.CreateStaticDefaultValue), new Action(SdkReportDirectBuy.ResetStaticDefaultValue));
	}

	// Token: 0x17000654 RID: 1620
	// (get) Token: 0x06005791 RID: 22417 RVA: 0x000FC511 File Offset: 0x000FA711
	private static IReadOnlyDictionary<int, string> GlobalReportMap
	{
		get
		{
			return SdkReportDirectBuy._globalReportMap;
		}
	}

	// Token: 0x06005792 RID: 22418 RVA: 0x000FC518 File Offset: 0x000FA718
	public static bool IfNeedReport(int payId)
	{
		return payId == 42 || payId == 43 || payId == 44 || payId == 45;
	}

	// Token: 0x06005793 RID: 22419 RVA: 0x000FC531 File Offset: 0x000FA731
	public override string GetEventName()
	{
		if (this.IfGlobalSdk)
		{
			return SdkReportDirectBuy.GlobalReportMap.GetValueOrDefault(this.PayItemId, "");
		}
		return "";
	}

	// Token: 0x06005794 RID: 22420 RVA: 0x000FC556 File Offset: 0x000FA756
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

	// Token: 0x06005795 RID: 22421 RVA: 0x000FC596 File Offset: 0x000FA796
	public static void ResetStaticDefaultValue()
	{
		SdkReportDirectBuy._globalReportMap = null;
	}

	// Token: 0x0400286B RID: 10347
	public int PayItemId;

	// Token: 0x0400286C RID: 10348
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private static IReadOnlyDictionary<int, string> _globalReportMap;
}
