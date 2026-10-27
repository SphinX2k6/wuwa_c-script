using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.TrapDefense
{
	// Token: 0x02004A3E RID: 19006
	[NullableContext(1)]
	[Nullable(0)]
	public readonly struct ETrapDefenseResKey : IEquatable<ETrapDefenseResKey>
	{
		// Token: 0x06031585 RID: 202117 RVA: 0x00B72233 File Offset: 0x00B70433
		private ETrapDefenseResKey(string value)
		{
			this._Value = value;
		}

		// Token: 0x06031586 RID: 202118 RVA: 0x00B7223C File Offset: 0x00B7043C
		public override string ToString()
		{
			return this._Value;
		}

		// Token: 0x06031587 RID: 202119 RVA: 0x00B72244 File Offset: 0x00B70444
		public bool Equals(ETrapDefenseResKey other)
		{
			return this._Value == other._Value;
		}

		// Token: 0x06031588 RID: 202120 RVA: 0x00B72258 File Offset: 0x00B70458
		[NullableContext(2)]
		public override bool Equals(object obj)
		{
			if (obj is ETrapDefenseResKey)
			{
				ETrapDefenseResKey other = (ETrapDefenseResKey)obj;
				return this.Equals(other);
			}
			return false;
		}

		// Token: 0x06031589 RID: 202121 RVA: 0x00B7227D File Offset: 0x00B7047D
		public override int GetHashCode()
		{
			string value = this._Value;
			if (value == null)
			{
				return 0;
			}
			return value.GetHashCode();
		}

		// Token: 0x0603158A RID: 202122 RVA: 0x00B72290 File Offset: 0x00B70490
		public static bool operator ==(ETrapDefenseResKey left, ETrapDefenseResKey right)
		{
			return left.Equals(right);
		}

		// Token: 0x0603158B RID: 202123 RVA: 0x00B7229A File Offset: 0x00B7049A
		public static bool operator !=(ETrapDefenseResKey left, ETrapDefenseResKey right)
		{
			return !left.Equals(right);
		}

		// Token: 0x0401A607 RID: 108039
		private readonly string _Value;

		// Token: 0x0401A608 RID: 108040
		public static readonly ETrapDefenseResKey BdProgressArrowQualityPurple = new ETrapDefenseResKey("SP_ArrowPurple");

		// Token: 0x0401A609 RID: 108041
		public static readonly ETrapDefenseResKey BdProgressArrowQualityGold = new ETrapDefenseResKey("SP_ArrowGold");

		// Token: 0x0401A60A RID: 108042
		public static readonly ETrapDefenseResKey MonsterTagUnStateIcon = new ETrapDefenseResKey("MonsterTagUnStateIcon");

		// Token: 0x0401A60B RID: 108043
		public static readonly ETrapDefenseResKey LevelTargetHp = new ETrapDefenseResKey("TrapDefenseLevelTargetHp");

		// Token: 0x0401A60C RID: 108044
		public static readonly ETrapDefenseResKey LevelTargetWave = new ETrapDefenseResKey("TrapDefenseLevelTargetWave");
	}
}
