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
	// Token: 0x06000183 RID: 387 RVA: 0x00009F76 File Offset: 0x00008176
	public static global::Stat Create(string name, string desc = "", string group = "")
	{
		return global::Stat.EmptyStat;
	}

	// Token: 0x06000184 RID: 388 RVA: 0x00009F7D File Offset: 0x0000817D
	public static global::Stat CreateNoFlameGraph(string name, string desc = "", string group = "")
	{
		return global::Stat.EmptyStat;
	}

	// Token: 0x06000185 RID: 389 RVA: 0x00009F84 File Offset: 0x00008184
	[Conditional("STATS")]
	public static void CreateInstantStat(string name, string desc = "", string group = "")
	{
	}

	// Token: 0x06000186 RID: 390 RVA: 0x00009F86 File Offset: 0x00008186
	public static global::Stat CreateWithStack(string namePrefix, int skipStackIndex = 0, int maxStackCount = 5)
	{
		return global::Stat.EmptyStat;
	}

	// Token: 0x06000187 RID: 391 RVA: 0x00009F8D File Offset: 0x0000818D
	[Conditional("STATS")]
	public static void Create(string name, [Nullable(2)] [NotNull] ref global::Stat stat, string desc = "", string group = "")
	{
		stat = global::Stat.EmptyStat;
	}

	// Token: 0x06000188 RID: 392 RVA: 0x00009F96 File Offset: 0x00008196
	[Conditional("STATS")]
	public static void CreateNoFlameGraph(string name, [Nullable(2)] [NotNull] ref global::Stat stat, string desc = "", string group = "")
	{
		stat = global::Stat.EmptyStat;
	}

	// Token: 0x06000189 RID: 393 RVA: 0x00009F9F File Offset: 0x0000819F
	[Conditional("STATS")]
	public static void CreateWithStack(string namePrefix, [Nullable(2)] [NotNull] ref global::Stat stat, int skipStackIndex = 0, int maxStackCount = 5)
	{
		stat = global::Stat.EmptyStat;
	}

	// Token: 0x0600018A RID: 394 RVA: 0x00009FA8 File Offset: 0x000081A8
	public static string GetStack(string namePrefix, int firstStackIndex = 0, int stackNumberNeeded = 5)
	{
		return string.Empty;
	}

	// Token: 0x0600018B RID: 395 RVA: 0x00009FAF File Offset: 0x000081AF
	[Conditional("STATS")]
	public void Start()
	{
	}

	// Token: 0x0600018C RID: 396 RVA: 0x00009FB1 File Offset: 0x000081B1
	[Conditional("STATS")]
	public void Stop()
	{
	}

	// Token: 0x0600018D RID: 397 RVA: 0x00009FB3 File Offset: 0x000081B3
	void IStat.Start()
	{
	}

	// Token: 0x0600018E RID: 398 RVA: 0x00009FB5 File Offset: 0x000081B5
	void IStat.Stop()
	{
	}

	// Token: 0x0600018F RID: 399 RVA: 0x00009FB7 File Offset: 0x000081B7
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x06000190 RID: 400 RVA: 0x00009FB9 File Offset: 0x000081B9
	public static void ResetStaticDefaultValue()
	{
	}

	// Token: 0x04000177 RID: 375
	public const bool Enable = false;

	// Token: 0x04000178 RID: 376
	[StaticVariableRuleIgnore]
	public static bool EnableCreateWithStack;

	// Token: 0x04000179 RID: 377
	[StaticVariableRuleIgnore]
	private static readonly global::Stat EmptyStat = new global::Stat();
}
