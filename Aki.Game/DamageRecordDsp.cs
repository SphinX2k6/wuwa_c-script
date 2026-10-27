using System;

// Token: 0x02002EC7 RID: 11975
public class DamageRecordDsp
{
	// Token: 0x060198E3 RID: 104675 RVA: 0x0069C58C File Offset: 0x0069A78C
	public DamageRecordDsp(float TimeStamp, float DamageValue, bool QteBegin, bool InGame, bool OutGame, bool OutGameSkill)
	{
		this.TimeStamp = TimeStamp;
		this.DamageValue = DamageValue;
		this.QteBegin = QteBegin;
		this.InGame = InGame;
		this.OutGame = OutGame;
		this.OutGameSkill = OutGameSkill;
	}

	// Token: 0x0400BF25 RID: 48933
	public float TimeStamp;

	// Token: 0x0400BF26 RID: 48934
	public float DamageValue;

	// Token: 0x0400BF27 RID: 48935
	public bool QteBegin;

	// Token: 0x0400BF28 RID: 48936
	public bool InGame;

	// Token: 0x0400BF29 RID: 48937
	public bool OutGame;

	// Token: 0x0400BF2A RID: 48938
	public bool OutGameSkill;
}
