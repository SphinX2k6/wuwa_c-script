using System;
using System.Runtime.CompilerServices;

// Token: 0x02002952 RID: 10578
[NullableContext(1)]
[Nullable(0)]
public class SceneTeam : IStaticVariableResetter
{
	// Token: 0x06015DA7 RID: 89511 RVA: 0x00583C5E File Offset: 0x00581E5E
	static SceneTeam()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(SceneTeam.CreateStaticDefaultValue), new Action(SceneTeam.ResetStaticDefaultValue));
	}

	// Token: 0x06015DA8 RID: 89512 RVA: 0x00583C7D File Offset: 0x00581E7D
	public static void CreateStaticDefaultValue()
	{
		SceneTeam.Scene = new object();
		SceneTeam.All = new object();
		SceneTeam.Local = new object();
	}

	// Token: 0x06015DA9 RID: 89513 RVA: 0x00583C9D File Offset: 0x00581E9D
	public static void ResetStaticDefaultValue()
	{
		SceneTeam.Scene = null;
		SceneTeam.All = null;
		SceneTeam.Local = null;
	}

	// Token: 0x0400A2BB RID: 41659
	public static object Scene;

	// Token: 0x0400A2BC RID: 41660
	public static object All;

	// Token: 0x0400A2BD RID: 41661
	public static object Local;
}
