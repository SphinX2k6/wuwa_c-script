using System;
using System.Runtime.CompilerServices;

// Token: 0x02001ECD RID: 7885
[NullableContext(1)]
[Nullable(0)]
public class SceneTeam : IStaticVariableResetter
{
	// Token: 0x060137AB RID: 79787 RVA: 0x005AEC5E File Offset: 0x005ACE5E
	static SceneTeam()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(SceneTeam.CreateStaticDefaultValue), new Action(SceneTeam.ResetStaticDefaultValue));
	}

	// Token: 0x060137AC RID: 79788 RVA: 0x005AEC7D File Offset: 0x005ACE7D
	public static void CreateStaticDefaultValue()
	{
		SceneTeam.Scene = new object();
		SceneTeam.All = new object();
		SceneTeam.Local = new object();
	}

	// Token: 0x060137AD RID: 79789 RVA: 0x005AEC9D File Offset: 0x005ACE9D
	public static void ResetStaticDefaultValue()
	{
		SceneTeam.Scene = null;
		SceneTeam.All = null;
		SceneTeam.Local = null;
	}

	// Token: 0x0400A6A5 RID: 42661
	public static object Scene;

	// Token: 0x0400A6A6 RID: 42662
	public static object All;

	// Token: 0x0400A6A7 RID: 42663
	public static object Local;
}
