using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace AkiClient.Game.Aki.Character.BaseCharacter
{
	// Token: 0x0200332D RID: 13101
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/ESkillGenre.ESkillGenre")]
	public enum ESkillGenre : byte
	{
		// Token: 0x0401217D RID: 74109
		普攻0,
		// Token: 0x0401217E RID: 74110
		蓄力1,
		// Token: 0x0401217F RID: 74111
		E技能2,
		// Token: 0x04012180 RID: 74112
		大招3,
		// Token: 0x04012181 RID: 74113
		QTE4,
		// Token: 0x04012182 RID: 74114
		极限闪避反击5,
		// Token: 0x04012183 RID: 74115
		地面闪避6,
		// Token: 0x04012184 RID: 74116
		极限闪避7,
		// Token: 0x04012185 RID: 74117
		被动技能8,
		// Token: 0x04012186 RID: 74118
		战斗幻象技9,
		// Token: 0x04012187 RID: 74119
		探索幻象技10,
		// Token: 0x04012188 RID: 74120
		空中闪避11,
		// Token: 0x04012189 RID: 74121
		退场技12,
		// Token: 0x0401218A RID: 74122
		破弱技能13,
		// Token: 0x0401218B RID: 74123
		无类别,
		// Token: 0x0401218C RID: 74124
		ESkillGenre_MAX
	}
}
