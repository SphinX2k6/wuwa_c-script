using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.TrapDefense
{
	// Token: 0x020039E6 RID: 14822
	[NullableContext(1)]
	[Nullable(0)]
	public readonly struct ETrapDefenseResKey : IEquatable<ETrapDefenseResKey>
	{
		// Token: 0x06026315 RID: 156437 RVA: 0x00AB61B7 File Offset: 0x00AB43B7
		private ETrapDefenseResKey(string value)
		{
			this._Value = value;
		}

		// Token: 0x06026316 RID: 156438 RVA: 0x00AB61C0 File Offset: 0x00AB43C0
		public override string ToString()
		{
			return this._Value;
		}

		// Token: 0x06026317 RID: 156439 RVA: 0x00AB61C8 File Offset: 0x00AB43C8
		public bool Equals(ETrapDefenseResKey other)
		{
			return this._Value == other._Value;
		}

		// Token: 0x06026318 RID: 156440 RVA: 0x00AB61DC File Offset: 0x00AB43DC
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

		// Token: 0x06026319 RID: 156441 RVA: 0x00AB6201 File Offset: 0x00AB4401
		public override int GetHashCode()
		{
			string value = this._Value;
			if (value == null)
			{
				return 0;
			}
			return value.GetHashCode();
		}

		// Token: 0x0602631A RID: 156442 RVA: 0x00AB6214 File Offset: 0x00AB4414
		public static bool operator ==(ETrapDefenseResKey left, ETrapDefenseResKey right)
		{
			return left.Equals(right);
		}

		// Token: 0x0602631B RID: 156443 RVA: 0x00AB621E File Offset: 0x00AB441E
		public static bool operator !=(ETrapDefenseResKey left, ETrapDefenseResKey right)
		{
			return !left.Equals(right);
		}

		// Token: 0x04014F59 RID: 85849
		private readonly string _Value;

		// Token: 0x04014F5A RID: 85850
		public static readonly ETrapDefenseResKey BdProgressArrowQualityPurple = new ETrapDefenseResKey("SP_ArrowPurple");

		// Token: 0x04014F5B RID: 85851
		public static readonly ETrapDefenseResKey BdProgressArrowQualityGold = new ETrapDefenseResKey("SP_ArrowGold");

		// Token: 0x04014F5C RID: 85852
		public static readonly ETrapDefenseResKey MonsterTagUnStateIcon = new ETrapDefenseResKey("MonsterTagUnStateIcon");

		// Token: 0x04014F5D RID: 85853
		public static readonly ETrapDefenseResKey LevelTargetHp = new ETrapDefenseResKey("TrapDefenseLevelTargetHp");

		// Token: 0x04014F5E RID: 85854
		public static readonly ETrapDefenseResKey LevelTargetWave = new ETrapDefenseResKey("TrapDefenseLevelTargetWave");
	}
}
