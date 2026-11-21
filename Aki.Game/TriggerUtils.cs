using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Character.BaseCharacter;

// Token: 0x02002533 RID: 9523
[NullableContext(1)]
[Nullable(0)]
public static class TriggerUtils
{
	// Token: 0x060178C0 RID: 96448 RVA: 0x006F3BF0 File Offset: 0x006F1DF0
	public static int[] GetSkillTypes([Nullable(2)] IReadOnlyList<ESkillGenre> skillGenres)
	{
		if (skillGenres == null || skillGenres.Count == 0)
		{
			return Array.Empty<int>();
		}
		int[] array = new int[skillGenres.Count];
		for (int i = 0; i < skillGenres.Count; i++)
		{
			array[i] = (int)skillGenres[i];
		}
		return array;
	}

	// Token: 0x060178C1 RID: 96449 RVA: 0x006F3C38 File Offset: 0x006F1E38
	public static string[] GetBattleFlags([Nullable(new byte[]
	{
		2,
		1
	})] IReadOnlyList<string> battleFlags)
	{
		if (battleFlags == null || battleFlags.Count == 0)
		{
			return Array.Empty<string>();
		}
		string[] array = new string[battleFlags.Count];
		for (int i = 0; i < battleFlags.Count; i++)
		{
			array[i] = battleFlags[i];
		}
		return array;
	}

	// Token: 0x060178C2 RID: 96450 RVA: 0x006F3C7E File Offset: 0x006F1E7E
	[NullableContext(2)]
	public static object GetTarget(Entity owner, ETriggerTargetType targetType)
	{
		switch (targetType)
		{
		case ETriggerTargetType.Self:
			return owner;
		case ETriggerTargetType.LocalFormation:
			return SceneTeam.Local;
		case ETriggerTargetType.AllFormation:
			return SceneTeam.All;
		case ETriggerTargetType.Enemy:
			return null;
		default:
			return null;
		}
	}
}
