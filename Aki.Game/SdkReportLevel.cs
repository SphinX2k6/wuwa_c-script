using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Launcher.HotPatchKuroSdk;

// Token: 0x020002F0 RID: 752
[NullableContext(1)]
[Nullable(0)]
public class SdkReportLevel : SdkReportData, IStaticVariableResetter
{
	// Token: 0x06002B2E RID: 11054 RVA: 0x00103FDF File Offset: 0x001021DF
	public SdkReportLevel([Nullable(new byte[]
	{
		2,
		1,
		1
	})] Dictionary<string, string> eventData) : base(eventData)
	{
	}

	// Token: 0x06002B2F RID: 11055 RVA: 0x00103FE8 File Offset: 0x001021E8
	static SdkReportLevel()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(SdkReportLevel.CreateStaticDefaultValue), new Action(SdkReportLevel.ResetStaticDefaultValue));
	}

	// Token: 0x1700067B RID: 1659
	// (get) Token: 0x06002B30 RID: 11056 RVA: 0x00104007 File Offset: 0x00102207
	private static IReadOnlyList<int> NeedReportLevel
	{
		get
		{
			return SdkReportLevel._needReportLevel;
		}
	}

	// Token: 0x1700067C RID: 1660
	// (get) Token: 0x06002B31 RID: 11057 RVA: 0x0010400E File Offset: 0x0010220E
	private static IReadOnlyDictionary<int, string> ChinaReportMap
	{
		get
		{
			return SdkReportLevel._chinaReportMap;
		}
	}

	// Token: 0x06002B32 RID: 11058 RVA: 0x00104018 File Offset: 0x00102218
	public static bool IfNeedReport(int level)
	{
		IReadOnlyList<int> needReportLevel = SdkReportLevel.NeedReportLevel;
		for (int i = 0; i < needReportLevel.Count; i++)
		{
			if (needReportLevel[i] == level)
			{
				return true;
			}
		}
		return false;
	}

	// Token: 0x06002B33 RID: 11059 RVA: 0x00104049 File Offset: 0x00102249
	public override string GetEventName()
	{
		if (this.IfGlobalSdk)
		{
			return StringUtils.Format("Level_{0}", new string[]
			{
				this.Level.ToString()
			});
		}
		return SdkReportLevel.ChinaReportMap.GetValueOrDefault(this.Level, "");
	}

	// Token: 0x06002B34 RID: 11060 RVA: 0x00104088 File Offset: 0x00102288
	public static void CreateStaticDefaultValue()
	{
		SdkReportLevel._needReportLevel = new <>z__ReadOnlyArray<int>(new int[]
		{
			8,
			10,
			12,
			15,
			20,
			25,
			30,
			35,
			40,
			45
		});
		SdkReportLevel._chinaReportMap = new Dictionary<int, string>
		{
			{
				8,
				"event_20"
			},
			{
				10,
				"event_21"
			},
			{
				12,
				"event_22"
			},
			{
				15,
				"event_23"
			},
			{
				20,
				"event_24"
			},
			{
				25,
				"event_25"
			},
			{
				30,
				"event_26"
			},
			{
				35,
				"event_27"
			},
			{
				40,
				"event_28"
			},
			{
				45,
				"event_29"
			}
		};
	}

	// Token: 0x06002B35 RID: 11061 RVA: 0x0010413C File Offset: 0x0010233C
	public static void ResetStaticDefaultValue()
	{
		SdkReportLevel._needReportLevel = null;
		SdkReportLevel._chinaReportMap = null;
	}

	// Token: 0x04002909 RID: 10505
	public int Level;

	// Token: 0x0400290A RID: 10506
	[Nullable(2)]
	private static IReadOnlyList<int> _needReportLevel;

	// Token: 0x0400290B RID: 10507
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private static IReadOnlyDictionary<int, string> _chinaReportMap;
}
