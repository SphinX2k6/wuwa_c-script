using System;
using System.Runtime.CompilerServices;

// Token: 0x020000C6 RID: 198
[NullableContext(1)]
[Nullable(0)]
public class StatSecondsAccumulator : IStaticVariableResetter
{
	// Token: 0x0600064E RID: 1614 RVA: 0x0002102D File Offset: 0x0001F22D
	static StatSecondsAccumulator()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(StatSecondsAccumulator.CreateStaticDefaultValue), new Action(StatSecondsAccumulator.ResetStaticDefaultValue));
	}

	// Token: 0x0600064F RID: 1615 RVA: 0x0002104C File Offset: 0x0001F24C
	private StatSecondsAccumulator(string name)
	{
		this.StatName = name;
	}

	// Token: 0x06000650 RID: 1616 RVA: 0x00021068 File Offset: 0x0001F268
	public static StatSecondsAccumulator Create(string nameIn, string desc = "", string group = "")
	{
		if (!CycleCounter.Instance.IsEnabled)
		{
			return StatSecondsAccumulator.Empty;
		}
		string text = nameIn;
		if (text.Length > 800)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Stat;
			ELogAuthor author = ELogAuthor.MZJ;
			string message = "名字过长";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("name", nameIn);
			instance.Warn(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			text = nameIn.Substring(0, 800);
		}
		KuroJsStatsLibrary.CreateSimpleSeconds(text, desc, group, true);
		return new StatSecondsAccumulator(text);
	}

	// Token: 0x06000651 RID: 1617 RVA: 0x000210DC File Offset: 0x0001F2DC
	public void Start()
	{
		if (!CycleCounter.Instance.IsEnabled)
		{
			return;
		}
		KuroJsStatsLibrary.StartSimpleSeconds(this.StatName);
	}

	// Token: 0x06000652 RID: 1618 RVA: 0x000210F6 File Offset: 0x0001F2F6
	public void Stop()
	{
		if (!CycleCounter.Instance.IsEnabled)
		{
			return;
		}
		KuroJsStatsLibrary.StopSimpleSeconds(this.StatName);
	}

	// Token: 0x06000653 RID: 1619 RVA: 0x00021110 File Offset: 0x0001F310
	public static void CreateStaticDefaultValue()
	{
		StatSecondsAccumulator.Empty = new StatSecondsAccumulator("");
	}

	// Token: 0x06000654 RID: 1620 RVA: 0x00021121 File Offset: 0x0001F321
	public static void ResetStaticDefaultValue()
	{
		StatSecondsAccumulator.Empty = null;
	}

	// Token: 0x040004FF RID: 1279
	private readonly string StatName = "";

	// Token: 0x04000500 RID: 1280
	private static StatSecondsAccumulator Empty;
}
