using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Character.BaseCharacter;

// Token: 0x02002FDE RID: 12254
public static class TriggerUtils
{
	// Token: 0x06019F8D RID: 106381 RVA: 0x006CBDB0 File Offset: 0x006C9FB0
	[NullableContext(1)]
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

	// Token: 0x06019F8E RID: 106382 RVA: 0x006CBDF6 File Offset: 0x006C9FF6
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
