using System;
using System.Runtime.CompilerServices;

// Token: 0x02001B0E RID: 6926
[NullableContext(1)]
[Nullable(0)]
public class FloroRanchUnlockRaceData : FloroRanchUnlockDataBase
{
	// Token: 0x0600CD91 RID: 52625 RVA: 0x002ED351 File Offset: 0x002EB551
	public FloroRanchUnlockRaceData(int id, bool isUnLock, int conditionId) : base(id, isUnLock, conditionId, EFloroRanchCardType.Race)
	{
	}

	// Token: 0x0600CD92 RID: 52626 RVA: 0x002ED35D File Offset: 0x002EB55D
	public void SetRaceData(FloroRanchRaceData raceData)
	{
		this.RaceData = raceData;
	}

	// Token: 0x0600CD93 RID: 52627 RVA: 0x002ED366 File Offset: 0x002EB566
	public FloroRanchRaceData GetRaceData()
	{
		return this.RaceData;
	}

	// Token: 0x0600CD94 RID: 52628 RVA: 0x002ED36E File Offset: 0x002EB56E
	protected string GetConditionText()
	{
		return LevelGeneralCommons.GetConditionGroupHintText(this.ConditionId) ?? "";
	}

	// Token: 0x04005E4A RID: 24138
	private FloroRanchRaceData RaceData;
}
