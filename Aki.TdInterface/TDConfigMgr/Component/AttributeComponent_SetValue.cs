using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000027 RID: 39
	[NullableContext(2)]
	[Nullable(0)]
	public class AttributeComponent_SetValue
	{
		// Token: 0x0400009C RID: 156
		public bool? Disabled;

		// Token: 0x0400009D RID: 157
		public bool? EdIsLocked;

		// Token: 0x0400009E RID: 158
		public int PropertyId;

		// Token: 0x0400009F RID: 159
		public int MonsterPropExtraRateId;

		// Token: 0x040000A0 RID: 160
		public int? MonsterPropGrowthId;

		// Token: 0x040000A1 RID: 161
		public int Level;

		// Token: 0x040000A2 RID: 162
		public int? MoraleLevel;

		// Token: 0x040000A3 RID: 163
		public int? HonamiStoryMonsterGrowth;

		// Token: 0x040000A4 RID: 164
		public int? FlagChallengeMonsterLevel;

		// Token: 0x040000A5 RID: 165
		public int RageModeId;

		// Token: 0x040000A6 RID: 166
		public int HardnessModeId;

		// Token: 0x040000A7 RID: 167
		public int WorldLevelBonusId;

		// Token: 0x040000A8 RID: 168
		public bool? IgnoreFightMusic;

		// Token: 0x040000A9 RID: 169
		public IFightMusicsSwitchByTagList FightMusics;

		// Token: 0x040000AA RID: 170
		public string FightMusic;

		// Token: 0x040000AB RID: 171
		public bool? FightMusicBanRadioMusic;

		// Token: 0x040000AC RID: 172
		public List<long> AppendBuffIds;

		// Token: 0x040000AD RID: 173
		[Nullable(0)]
		public IWorldLevelBonusType WorldLevelBonusType;
	}
}
