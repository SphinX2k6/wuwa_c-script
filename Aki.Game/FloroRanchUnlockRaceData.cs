using System;
using System.Runtime.CompilerServices;

// Token: 0x02000FCD RID: 4045
[NullableContext(1)]
[Nullable(0)]
public class FloroRanchUnlockRaceData : FloroRanchUnlockDataBase
{
	// Token: 0x0600A1A2 RID: 41378 RVA: 0x002F843D File Offset: 0x002F663D
	public FloroRanchUnlockRaceData(int id, bool isUnLock, int conditionId) : base(id, isUnLock, conditionId, EFloroRanchCardType.Race)
	{
	}

	// Token: 0x0600A1A3 RID: 41379 RVA: 0x002F8449 File Offset: 0x002F6649
	public void SetRaceData(FloroRanchRaceData raceData)
	{
		this.RaceData = raceData;
	}

	// Token: 0x0600A1A4 RID: 41380 RVA: 0x002F8452 File Offset: 0x002F6652
	public FloroRanchRaceData GetRaceData()
	{
		return this.RaceData;
	}

	// Token: 0x0600A1A5 RID: 41381 RVA: 0x002F845A File Offset: 0x002F665A
	protected string GetConditionText()
	{
		return LevelGeneralCommons.GetConditionGroupHintText(this.ConditionId) ?? "";
	}

	// Token: 0x04005F19 RID: 24345
	private FloroRanchRaceData RaceData;
}
