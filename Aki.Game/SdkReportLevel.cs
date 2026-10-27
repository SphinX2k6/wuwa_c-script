using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using CSharpScript.Launcher.HotPatchKuroSdk;

// Token: 0x02000E3B RID: 3643
[NullableContext(1)]
[Nullable(0)]
public class SdkReportLevel : SdkReportData, IStaticVariableResetter
{
	// Token: 0x0600579E RID: 22430 RVA: 0x000FC78B File Offset: 0x000FA98B
	public SdkReportLevel([Nullable(new byte[]
	{
		2,
		1,
		1
	})] Dictionary<string, string> eventData) : base(eventData)
	{
	}

	// Token: 0x0600579F RID: 22431 RVA: 0x000FC794 File Offset: 0x000FA994
	static SdkReportLevel()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(SdkReportLevel.CreateStaticDefaultValue), new Action(SdkReportLevel.ResetStaticDefaultValue));
	}

	// Token: 0x17000657 RID: 1623
	// (get) Token: 0x060057A0 RID: 22432 RVA: 0x000FC7B3 File Offset: 0x000FA9B3
	private static IReadOnlyList<int> NeedReportLevel
	{
		get
		{
			return SdkReportLevel._needReportLevel;
		}
	}

	// Token: 0x17000658 RID: 1624
	// (get) Token: 0x060057A1 RID: 22433 RVA: 0x000FC7BA File Offset: 0x000FA9BA
	private static IReadOnlyDictionary<int, string> ChinaReportMap
	{
		get
		{
			return SdkReportLevel._chinaReportMap;
		}
	}

	// Token: 0x060057A2 RID: 22434 RVA: 0x000FC7C1 File Offset: 0x000FA9C1
	public static bool IfNeedReport(int level)
	{
		return SdkReportLevel.NeedReportLevel.Contains(level);
	}

	// Token: 0x060057A3 RID: 22435 RVA: 0x000FC7CE File Offset: 0x000FA9CE
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

	// Token: 0x060057A4 RID: 22436 RVA: 0x000FC80C File Offset: 0x000FAA0C
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

	// Token: 0x060057A5 RID: 22437 RVA: 0x000FC8C0 File Offset: 0x000FAAC0
	public static void ResetStaticDefaultValue()
	{
		SdkReportLevel._needReportLevel = null;
		SdkReportLevel._chinaReportMap = null;
	}

	// Token: 0x04002870 RID: 10352
	public int Level;

	// Token: 0x04002871 RID: 10353
	[Nullable(2)]
	private static IReadOnlyList<int> _needReportLevel;

	// Token: 0x04002872 RID: 10354
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private static IReadOnlyDictionary<int, string> _chinaReportMap;
}
