using System;
using System.Runtime.CompilerServices;

// Token: 0x02001213 RID: 4627
[NullableContext(1)]
[Nullable(0)]
[Model(0)]
public class GamePingModel : ModelBase
{
	// Token: 0x17001258 RID: 4696
	// (get) Token: 0x0600B7C3 RID: 47043 RVA: 0x00363111 File Offset: 0x00361311
	public static GamePingModel Instance
	{
		get
		{
			return GamePingModel._Instance;
		}
	}

	// Token: 0x0600B7C4 RID: 47044 RVA: 0x00363118 File Offset: 0x00361318
	public static GamePingModel GetOrCreateInstance()
	{
		if (GamePingModel._Instance == null)
		{
			GamePingModel.CreateInstance();
		}
		return GamePingModel._Instance;
	}

	// Token: 0x0600B7C5 RID: 47045 RVA: 0x0036312C File Offset: 0x0036132C
	public static bool CreateInstance()
	{
		if (GamePingModel._Instance != null)
		{
			return true;
		}
		GamePingModel._Instance = new GamePingModel();
		return true;
	}

	// Token: 0x0600B7C6 RID: 47046 RVA: 0x00363142 File Offset: 0x00361342
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x0600B7C7 RID: 47047 RVA: 0x00363144 File Offset: 0x00361344
	public static void ResetStaticDefaultValue()
	{
		GamePingModel._Instance = null;
	}

	// Token: 0x0600B7C8 RID: 47048 RVA: 0x0036314C File Offset: 0x0036134C
	static GamePingModel()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(GamePingModel.CreateStaticDefaultValue), new Action(GamePingModel.ResetStaticDefaultValue));
	}

	// Token: 0x040069F1 RID: 27121
	public int CurrentPing;

	// Token: 0x040069F2 RID: 27122
	[Nullable(2)]
	private static GamePingModel _Instance;
}
