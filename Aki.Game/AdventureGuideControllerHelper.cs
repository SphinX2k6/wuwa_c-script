using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.AdventureGuide;

// Token: 0x02000B44 RID: 2884
[NullableContext(1)]
[Nullable(0)]
public static class AdventureGuideControllerHelper
{
	// Token: 0x060077F8 RID: 30712 RVA: 0x00250DB4 File Offset: 0x0024EFB4
	public static int silentAreasSortFunc(SilentAreaDetectionRecord a, SilentAreaDetectionRecord b)
	{
		if (a.Conf.DangerType != b.Conf.DangerType)
		{
			return b.Conf.DangerType - a.Conf.DangerType;
		}
		if (a.Conf.Secondary != b.Conf.Secondary)
		{
			return b.Conf.Secondary - a.Conf.Secondary;
		}
		return a.Conf.Id - b.Conf.Id;
	}

	// Token: 0x060077F9 RID: 30713 RVA: 0x00250E58 File Offset: 0x0024F058
	public static int monsterSortFunc(MonsterDetectionRecord a, MonsterDetectionRecord b)
	{
		if (a.Conf.DangerType != b.Conf.DangerType)
		{
			return b.Conf.DangerType - a.Conf.DangerType;
		}
		if (a.Conf.TypeDescription2 != b.Conf.TypeDescription2)
		{
			return b.Conf.TypeDescription2 - a.Conf.TypeDescription2;
		}
		return b.Conf.Id - a.Conf.Id;
	}
}
