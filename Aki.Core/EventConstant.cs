using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using CSharpScript.Core.Utils.StaticVariableReset;

// Token: 0x0200008C RID: 140
[StaticVariablePriority(100)]
public class EventConstant : IStaticVariableResetter
{
	// Token: 0x0600046F RID: 1135 RVA: 0x00019226 File Offset: 0x00017426
	static EventConstant()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(EventConstant.CreateStaticDefaultValue), new Action(EventConstant.ResetStaticDefaultValue));
	}

	// Token: 0x06000470 RID: 1136 RVA: 0x00019245 File Offset: 0x00017445
	public static void CreateStaticDefaultValue()
	{
		EventConstant.NameStateMap = new Dictionary<Enum, Stat>();
		EventConstant.HandleStatMap = new Dictionary<MethodInfo, Stat>();
	}

	// Token: 0x06000471 RID: 1137 RVA: 0x0001925B File Offset: 0x0001745B
	public static void ResetStaticDefaultValue()
	{
		EventConstant.NameStateMap = null;
		EventConstant.HandleStatMap = null;
	}

	// Token: 0x040003F2 RID: 1010
	[Nullable(1)]
	public static Dictionary<Enum, Stat> NameStateMap;

	// Token: 0x040003F3 RID: 1011
	[Nullable(1)]
	public static Dictionary<MethodInfo, Stat> HandleStatMap;
}
