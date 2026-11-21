using System;

// Token: 0x020022F9 RID: 8953
public class BulletSpecialActionDeclare : IStaticVariableResetter
{
	// Token: 0x0601610F RID: 90383 RVA: 0x00669D98 File Offset: 0x00667F98
	static BulletSpecialActionDeclare()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(BulletSpecialActionDeclare.CreateStaticDefaultValue), new Action(BulletSpecialActionDeclare.ResetStaticDefaultValue));
	}

	// Token: 0x06016110 RID: 90384 RVA: 0x00669DB7 File Offset: 0x00667FB7
	public static void CreateStaticDefaultValue()
	{
		BulletSpecialActionDeclare.Registered = false;
	}

	// Token: 0x06016111 RID: 90385 RVA: 0x00669DBF File Offset: 0x00667FBF
	public static void ResetStaticDefaultValue()
	{
		BulletSpecialActionDeclare.Registered = false;
	}

	// Token: 0x06016112 RID: 90386 RVA: 0x00669DC8 File Offset: 0x00667FC8
	public static void RegisterAll()
	{
		if (BulletSpecialActionDeclare.Registered)
		{
			return;
		}
		BulletSpecialActionDeclare.Registered = true;
		BulletSpecialActionRegistry.Register<BulletActionUpdateLiveTimePerformance>(391336, EBulletAction.UpdateLiveTime, true, new string[]
		{
			"80037001002",
			"80037103005",
			"80037103006",
			"80037103007",
			"80037103008",
			"80037103009",
			"80037103010",
			"80037103011",
			"80037103012",
			"80037103013",
			"80037103014",
			"80037103015",
			"80037103016",
			"80037103017",
			"80037103018",
			"80037103019",
			"80037103020",
			"80037103021",
			"80037103022",
			"80037103023",
			"80037103024",
			"80037103025",
			"80037103026",
			"80037103027",
			"80037103028",
			"80037103029",
			"80037103030",
			"80037103031",
			"80037103032",
			"80037103033",
			"80037103034",
			"80037103035",
			"80037103036",
			"80037103037",
			"80037103038",
			"80037103039",
			"80037103040",
			"80037103041",
			"80037103042",
			"80037103043",
			"80037103044",
			"80037001001",
			"80037001103"
		});
	}

	// Token: 0x0400B95C RID: 47452
	private static bool Registered;
}
