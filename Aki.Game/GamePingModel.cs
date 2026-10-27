using System;
using System.Runtime.CompilerServices;

// Token: 0x02001D51 RID: 7505
[NullableContext(1)]
[Nullable(0)]
[Model(0)]
public class GamePingModel : ModelBase
{
	// Token: 0x1700122E RID: 4654
	// (get) Token: 0x0600E3A6 RID: 58278 RVA: 0x003576A1 File Offset: 0x003558A1
	public static GamePingModel Instance
	{
		get
		{
			return GamePingModel._Instance;
		}
	}

	// Token: 0x0600E3A7 RID: 58279 RVA: 0x003576A8 File Offset: 0x003558A8
	public static GamePingModel GetOrCreateInstance()
	{
		if (GamePingModel._Instance == null)
		{
			GamePingModel.CreateInstance();
		}
		return GamePingModel._Instance;
	}

	// Token: 0x0600E3A8 RID: 58280 RVA: 0x003576BC File Offset: 0x003558BC
	public static bool CreateInstance()
	{
		if (GamePingModel._Instance != null)
		{
			return true;
		}
		GamePingModel._Instance = new GamePingModel();
		return true;
	}

	// Token: 0x0600E3A9 RID: 58281 RVA: 0x003576D2 File Offset: 0x003558D2
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x0600E3AA RID: 58282 RVA: 0x003576D4 File Offset: 0x003558D4
	public static void ResetStaticDefaultValue()
	{
		GamePingModel._Instance = null;
	}

	// Token: 0x0600E3AB RID: 58283 RVA: 0x003576DC File Offset: 0x003558DC
	static GamePingModel()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(GamePingModel.CreateStaticDefaultValue), new Action(GamePingModel.ResetStaticDefaultValue));
	}

	// Token: 0x04006912 RID: 26898
	public int CurrentPing;

	// Token: 0x04006913 RID: 26899
	[Nullable(2)]
	private static GamePingModel _Instance;
}
