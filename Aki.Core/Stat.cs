using System;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;

// Token: 0x0200003F RID: 63
[NullableContext(1)]
[Nullable(0)]
public class Stat : IStat
{
	// Token: 0x17000022 RID: 34
	// (get) Token: 0x06000181 RID: 385 RVA: 0x0000A292 File Offset: 0x00008492
	public static bool Enable
	{
		get
		{
			return false;
		}
	}

	// Token: 0x06000182 RID: 386 RVA: 0x0000A295 File Offset: 0x00008495
	public static global::Stat Create(string name, string desc = "", string group = "")
	{
		return global::Stat.EmptyStat;
	}

	// Token: 0x06000183 RID: 387 RVA: 0x0000A29C File Offset: 0x0000849C
	public static global::Stat CreateNoFlameGraph(string name, string desc = "", string group = "")
	{
		return global::Stat.EmptyStat;
	}

	// Token: 0x06000184 RID: 388 RVA: 0x0000A2A3 File Offset: 0x000084A3
	[Conditional("STATS")]
	public static void CreateInstantStat(string name, string desc = "", string group = "")
	{
	}

	// Token: 0x06000185 RID: 389 RVA: 0x0000A2A5 File Offset: 0x000084A5
	public static global::Stat CreateWithStack(string namePrefix, int skipStackIndex = 0, int maxStackCount = 5)
	{
		return global::Stat.EmptyStat;
	}

	// Token: 0x06000186 RID: 390 RVA: 0x0000A2AC File Offset: 0x000084AC
	[Conditional("STATS")]
	public static void Create(string name, [Nullable(2)] [NotNull] ref global::Stat stat, string desc = "", string group = "")
	{
		stat = global::Stat.EmptyStat;
	}

	// Token: 0x06000187 RID: 391 RVA: 0x0000A2B5 File Offset: 0x000084B5
	[Conditional("STATS")]
	public static void CreateNoFlameGraph(string name, [Nullable(2)] [NotNull] ref global::Stat stat, string desc = "", string group = "")
	{
		stat = global::Stat.EmptyStat;
	}

	// Token: 0x06000188 RID: 392 RVA: 0x0000A2BE File Offset: 0x000084BE
	[Conditional("STATS")]
	public static void CreateWithStack(string namePrefix, [Nullable(2)] [NotNull] ref global::Stat stat, int skipStackIndex = 0, int maxStackCount = 5)
	{
		stat = global::Stat.EmptyStat;
	}

	// Token: 0x06000189 RID: 393 RVA: 0x0000A2C7 File Offset: 0x000084C7
	public static string GetStack(string namePrefix, int firstStackIndex = 0, int stackNumberNeeded = 5)
	{
		return string.Empty;
	}

	// Token: 0x0600018A RID: 394 RVA: 0x0000A2CE File Offset: 0x000084CE
	[Conditional("STATS")]
	public void Start()
	{
	}

	// Token: 0x0600018B RID: 395 RVA: 0x0000A2D0 File Offset: 0x000084D0
	[Conditional("STATS")]
	public void Stop()
	{
	}

	// Token: 0x0600018C RID: 396 RVA: 0x0000A2D2 File Offset: 0x000084D2
	void IStat.Start()
	{
	}

	// Token: 0x0600018D RID: 397 RVA: 0x0000A2D4 File Offset: 0x000084D4
	void IStat.Stop()
	{
	}

	// Token: 0x0600018E RID: 398 RVA: 0x0000A2D6 File Offset: 0x000084D6
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x0600018F RID: 399 RVA: 0x0000A2D8 File Offset: 0x000084D8
	public static void ResetStaticDefaultValue()
	{
	}

	// Token: 0x04000176 RID: 374
	[StaticVariableRuleIgnore]
	public static bool EnableCreateWithStack;

	// Token: 0x04000177 RID: 375
	[StaticVariableRuleIgnore]
	private static readonly global::Stat EmptyStat = new global::Stat();
}
