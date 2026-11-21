using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;

namespace CSharpScript.Game.Module.SolarSchool
{
	// Token: 0x020058CB RID: 22731
	[NullableContext(1)]
	[Nullable(0)]
	public sealed class SolarSchoolBonusData : SolarSchoolRecordBase
	{
		// Token: 0x06037FA3 RID: 229283 RVA: 0x00FA5BB3 File Offset: 0x00FA3DB3
		public int GetBonus(ESolarSchoolBonusType type)
		{
			return this.bonusValues.GetValueOrDefault(type, 0);
		}

		// Token: 0x06037FA4 RID: 229284 RVA: 0x00FA5BC4 File Offset: 0x00FA3DC4
		public int AddBonus(ESolarSchoolBonusType type, int delta)
		{
			int num = this.GetBonus(type) + delta;
			if (num == 0)
			{
				this.bonusValues.Remove(type);
			}
			else
			{
				this.bonusValues[type] = num;
			}
			return num;
		}

		// Token: 0x06037FA5 RID: 229285 RVA: 0x00FA5BFB File Offset: 0x00FA3DFB
		public override void Serialize(SolarSchoolSaveGamePb gameData)
		{
		}

		// Token: 0x06037FA6 RID: 229286 RVA: 0x00FA5BFD File Offset: 0x00FA3DFD
		public override void Deserialize(SolarSchoolSaveGamePb gameData)
		{
			this.bonusValues.Clear();
		}

		// Token: 0x0401D864 RID: 120932
		private readonly Dictionary<ESolarSchoolBonusType, int> bonusValues = new Dictionary<ESolarSchoolBonusType, int>();
	}
}
