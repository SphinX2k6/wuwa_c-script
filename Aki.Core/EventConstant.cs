using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using CSharpScript.Core.Utils.StaticVariableReset;

// Token: 0x0200008A RID: 138
[StaticVariablePriority(100)]
public class EventConstant : IStaticVariableResetter
{
	// Token: 0x0600042E RID: 1070 RVA: 0x00018A2E File Offset: 0x00016C2E
	static EventConstant()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(EventConstant.CreateStaticDefaultValue), new Action(EventConstant.ResetStaticDefaultValue));
	}

	// Token: 0x0600042F RID: 1071 RVA: 0x00018A4D File Offset: 0x00016C4D
	public static void CreateStaticDefaultValue()
	{
		EventConstant.NameStateMap = new Dictionary<Enum, Stat>();
		EventConstant.HandleStatMap = new Dictionary<MethodInfo, Stat>();
	}

	// Token: 0x06000430 RID: 1072 RVA: 0x00018A63 File Offset: 0x00016C63
	public static void ResetStaticDefaultValue()
	{
		EventConstant.NameStateMap = null;
		EventConstant.HandleStatMap = null;
	}

	// Token: 0x040003E4 RID: 996
	[Nullable(1)]
	public static Dictionary<Enum, Stat> NameStateMap;

	// Token: 0x040003E5 RID: 997
	[Nullable(1)]
	public static Dictionary<MethodInfo, Stat> HandleStatMap;
}
