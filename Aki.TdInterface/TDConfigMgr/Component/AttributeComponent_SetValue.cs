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
		// Token: 0x04000097 RID: 151
		public bool? Disabled;

		// Token: 0x04000098 RID: 152
		public bool? EdIsLocked;

		// Token: 0x04000099 RID: 153
		public int PropertyId;

		// Token: 0x0400009A RID: 154
		public int MonsterPropExtraRateId;

		// Token: 0x0400009B RID: 155
		public int? MonsterPropGrowthId;

		// Token: 0x0400009C RID: 156
		public int Level;

		// Token: 0x0400009D RID: 157
		public int? MoraleLevel;

		// Token: 0x0400009E RID: 158
		public int? HonamiStoryMonsterGrowth;

		// Token: 0x0400009F RID: 159
		public int? FlagChallengeMonsterLevel;

		// Token: 0x040000A0 RID: 160
		public int RageModeId;

		// Token: 0x040000A1 RID: 161
		public int HardnessModeId;

		// Token: 0x040000A2 RID: 162
		public int WorldLevelBonusId;

		// Token: 0x040000A3 RID: 163
		public bool? IgnoreFightMusic;

		// Token: 0x040000A4 RID: 164
		public IFightMusicsSwitchByTagList FightMusics;

		// Token: 0x040000A5 RID: 165
		public string FightMusic;

		// Token: 0x040000A6 RID: 166
		public bool? FightMusicBanRadioMusic;

		// Token: 0x040000A7 RID: 167
		public List<long> AppendBuffIds;

		// Token: 0x040000A8 RID: 168
		[Nullable(1)]
		public IWorldLevelBonusType WorldLevelBonusType;
	}
}
