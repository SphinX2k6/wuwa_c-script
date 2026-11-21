using System;
using System.Runtime.CompilerServices;

// Token: 0x020023AA RID: 9130
public class AbilityEvent : IStaticVariableResetter
{
	// Token: 0x06016D87 RID: 93575 RVA: 0x006A895C File Offset: 0x006A6B5C
	static AbilityEvent()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(AbilityEvent.CreateStaticDefaultValue), new Action(AbilityEvent.ResetStaticDefaultValue));
	}

	// Token: 0x06016D88 RID: 93576 RVA: 0x006A897B File Offset: 0x006A6B7B
	public static void CreateStaticDefaultValue()
	{
		AbilityEvent.Instance = new AbilityEventInstance();
	}

	// Token: 0x06016D89 RID: 93577 RVA: 0x006A8987 File Offset: 0x006A6B87
	public static void ResetStaticDefaultValue()
	{
		AbilityEvent.Instance = null;
	}

	// Token: 0x0400BFB1 RID: 49073
	public const long DEFAULT_KEY = 0L;

	// Token: 0x0400BFB2 RID: 49074
	[Nullable(1)]
	public static AbilityEventInstance Instance;
}
