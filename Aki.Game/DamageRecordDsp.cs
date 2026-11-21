using System;

// Token: 0x0200241A RID: 9242
public class DamageRecordDsp
{
	// Token: 0x060171D6 RID: 94678 RVA: 0x006C27CC File Offset: 0x006C09CC
	public DamageRecordDsp(float TimeStamp, float DamageValue, bool QteBegin, bool InGame, bool OutGame, bool OutGameSkill)
	{
		this.TimeStamp = TimeStamp;
		this.DamageValue = DamageValue;
		this.QteBegin = QteBegin;
		this.InGame = InGame;
		this.OutGame = OutGame;
		this.OutGameSkill = OutGameSkill;
	}

	// Token: 0x0400C2C0 RID: 49856
	public float TimeStamp;

	// Token: 0x0400C2C1 RID: 49857
	public float DamageValue;

	// Token: 0x0400C2C2 RID: 49858
	public bool QteBegin;

	// Token: 0x0400C2C3 RID: 49859
	public bool InGame;

	// Token: 0x0400C2C4 RID: 49860
	public bool OutGame;

	// Token: 0x0400C2C5 RID: 49861
	public bool OutGameSkill;
}
