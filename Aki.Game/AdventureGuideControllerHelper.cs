using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.AdventureGuide;

// Token: 0x0200168C RID: 5772
[NullableContext(1)]
[Nullable(0)]
public static class AdventureGuideControllerHelper
{
	// Token: 0x0600A419 RID: 42009 RVA: 0x00246B0C File Offset: 0x00244D0C
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

	// Token: 0x0600A41A RID: 42010 RVA: 0x00246BB0 File Offset: 0x00244DB0
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
