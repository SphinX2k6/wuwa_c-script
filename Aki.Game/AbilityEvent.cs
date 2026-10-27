using System;
using System.Runtime.CompilerServices;

// Token: 0x02002E4E RID: 11854
public class AbilityEvent : IStaticVariableResetter
{
	// Token: 0x060194A8 RID: 103592 RVA: 0x006825C2 File Offset: 0x006807C2
	static AbilityEvent()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(AbilityEvent.CreateStaticDefaultValue), new Action(AbilityEvent.ResetStaticDefaultValue));
	}

	// Token: 0x060194A9 RID: 103593 RVA: 0x006825E1 File Offset: 0x006807E1
	public static void CreateStaticDefaultValue()
	{
		AbilityEvent.Instance = new AbilityEventInstance();
	}

	// Token: 0x060194AA RID: 103594 RVA: 0x006825ED File Offset: 0x006807ED
	public static void ResetStaticDefaultValue()
	{
		AbilityEvent.Instance = null;
	}

	// Token: 0x0400BC1D RID: 48157
	public const long DEFAULT_KEY = 0L;

	// Token: 0x0400BC1E RID: 48158
	[Nullable(1)]
	public static AbilityEventInstance Instance;
}
