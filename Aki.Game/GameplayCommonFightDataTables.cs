using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using UnrealEngine;

// Token: 0x020026AC RID: 9900
[NullableContext(2)]
[Nullable(0)]
public class GameplayCommonFightDataTables : IStaticVariableResetter
{
	// Token: 0x06018D1B RID: 101659 RVA: 0x007895A4 File Offset: 0x007877A4
	static GameplayCommonFightDataTables()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(GameplayCommonFightDataTables.CreateStaticDefaultValue), new Action(GameplayCommonFightDataTables.ResetStaticDefaultValue));
	}

	// Token: 0x06018D1C RID: 101660 RVA: 0x007895C3 File Offset: 0x007877C3
	public static void CreateStaticDefaultValue()
	{
		GameplayCommonFightDataTables._gameplayCommonFightDataTables = null;
	}

	// Token: 0x06018D1D RID: 101661 RVA: 0x007895CB File Offset: 0x007877CB
	public static void ResetStaticDefaultValue()
	{
		GameplayCommonFightDataTables._gameplayCommonFightDataTables = null;
	}

	// Token: 0x06018D1E RID: 101662 RVA: 0x007895D3 File Offset: 0x007877D3
	public static void SetGameplayCommonFightDataTables(GameplayCommonFightDataTables data)
	{
		GameplayCommonFightDataTables._gameplayCommonFightDataTables = data;
	}

	// Token: 0x06018D1F RID: 101663 RVA: 0x007895DB File Offset: 0x007877DB
	public static UDataTable GetGameplayCommonSkillInfoTable(EEntityType entityType)
	{
		if (entityType != EEntityType.Player)
		{
			return null;
		}
		GameplayCommonFightDataTables gameplayCommonFightDataTables = GameplayCommonFightDataTables._gameplayCommonFightDataTables;
		if (gameplayCommonFightDataTables == null)
		{
			return null;
		}
		return gameplayCommonFightDataTables.RoleSkillDataTable;
	}

	// Token: 0x06018D20 RID: 101664 RVA: 0x007895F2 File Offset: 0x007877F2
	public static UDataTable GetGameplayCommonBulletDataTable()
	{
		GameplayCommonFightDataTables gameplayCommonFightDataTables = GameplayCommonFightDataTables._gameplayCommonFightDataTables;
		if (gameplayCommonFightDataTables == null)
		{
			return null;
		}
		return gameplayCommonFightDataTables.BulletDataTable;
	}

	// Token: 0x06018D21 RID: 101665 RVA: 0x00789604 File Offset: 0x00787804
	public static UDataTable GetGameplayCommonHitEffectDataTable()
	{
		GameplayCommonFightDataTables gameplayCommonFightDataTables = GameplayCommonFightDataTables._gameplayCommonFightDataTables;
		if (gameplayCommonFightDataTables == null)
		{
			return null;
		}
		return gameplayCommonFightDataTables.HitEffectDataTable;
	}

	// Token: 0x0400D772 RID: 55154
	public UDataTable RoleSkillDataTable;

	// Token: 0x0400D773 RID: 55155
	public UDataTable BulletDataTable;

	// Token: 0x0400D774 RID: 55156
	public UDataTable HitEffectDataTable;

	// Token: 0x0400D775 RID: 55157
	private static GameplayCommonFightDataTables _gameplayCommonFightDataTables;
}
