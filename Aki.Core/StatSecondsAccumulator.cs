using System;
using System.Runtime.CompilerServices;

// Token: 0x020000C4 RID: 196
[NullableContext(1)]
[Nullable(0)]
public class StatSecondsAccumulator : IStaticVariableResetter
{
	// Token: 0x0600060D RID: 1549 RVA: 0x00020B01 File Offset: 0x0001ED01
	static StatSecondsAccumulator()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(StatSecondsAccumulator.CreateStaticDefaultValue), new Action(StatSecondsAccumulator.ResetStaticDefaultValue));
	}

	// Token: 0x0600060E RID: 1550 RVA: 0x00020B20 File Offset: 0x0001ED20
	private StatSecondsAccumulator(string name)
	{
		this.StatName = name;
	}

	// Token: 0x0600060F RID: 1551 RVA: 0x00020B3C File Offset: 0x0001ED3C
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

	// Token: 0x06000610 RID: 1552 RVA: 0x00020BB0 File Offset: 0x0001EDB0
	public void Start()
	{
		if (!CycleCounter.Instance.IsEnabled)
		{
			return;
		}
		KuroJsStatsLibrary.StartSimpleSeconds(this.StatName);
	}

	// Token: 0x06000611 RID: 1553 RVA: 0x00020BCA File Offset: 0x0001EDCA
	public void Stop()
	{
		if (!CycleCounter.Instance.IsEnabled)
		{
			return;
		}
		KuroJsStatsLibrary.StopSimpleSeconds(this.StatName);
	}

	// Token: 0x06000612 RID: 1554 RVA: 0x00020BE4 File Offset: 0x0001EDE4
	public static void CreateStaticDefaultValue()
	{
		StatSecondsAccumulator.Empty = new StatSecondsAccumulator("");
	}

	// Token: 0x06000613 RID: 1555 RVA: 0x00020BF5 File Offset: 0x0001EDF5
	public static void ResetStaticDefaultValue()
	{
		StatSecondsAccumulator.Empty = null;
	}

	// Token: 0x040004F1 RID: 1265
	private readonly string StatName = "";

	// Token: 0x040004F2 RID: 1266
	private static StatSecondsAccumulator Empty;
}
