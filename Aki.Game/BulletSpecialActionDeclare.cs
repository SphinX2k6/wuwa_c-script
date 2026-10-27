using System;

// Token: 0x02002D9F RID: 11679
public class BulletSpecialActionDeclare : IStaticVariableResetter
{
	// Token: 0x0601886A RID: 100458 RVA: 0x00643F5C File Offset: 0x0064215C
	static BulletSpecialActionDeclare()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(BulletSpecialActionDeclare.CreateStaticDefaultValue), new Action(BulletSpecialActionDeclare.ResetStaticDefaultValue));
	}

	// Token: 0x0601886B RID: 100459 RVA: 0x00643F7B File Offset: 0x0064217B
	public static void CreateStaticDefaultValue()
	{
		BulletSpecialActionDeclare.Registered = false;
	}

	// Token: 0x0601886C RID: 100460 RVA: 0x00643F83 File Offset: 0x00642183
	public static void ResetStaticDefaultValue()
	{
		BulletSpecialActionDeclare.Registered = false;
	}

	// Token: 0x0601886D RID: 100461 RVA: 0x00643F8C File Offset: 0x0064218C
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

	// Token: 0x0400B5E6 RID: 46566
	private static bool Registered;
}
